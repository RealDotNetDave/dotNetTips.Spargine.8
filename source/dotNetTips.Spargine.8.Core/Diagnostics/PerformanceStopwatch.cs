// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-11-2025
// ***********************************************************************
// <copyright file="PerformanceStopwatch.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Enhances Stopwatch with helpful methods: StartNewWithAlertThreshold() and StopReset().
// Additionally, it possesses the ability to add messages that can be
// retrieved when the Stopwatch stops.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core.Logging;
using DotNetTips.Spargine.Core.Properties;
using Microsoft.ApplicationInsights;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Core.Diagnostics;

#nullable enable

/// <summary>
/// A thread-safe, high-precision stopwatch with enhanced diagnostics, lap support, telemetry, and logging capabilities.
/// </summary>
[DebuggerDisplay("Elapsed: {ElapsedMilliseconds}ms, Title: {Title}")]
[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SparginePerformanceStopwatch")]
public sealed class PerformanceStopwatch : Stopwatch
{
	/// <summary>
	/// A pool of <see cref="StringBuilder"/> objects to minimize memory allocations.
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// A collection of diagnostic entries recorded during the stopwatch's operation.
	/// </summary>
	private readonly ConcurrentBag<DiagnosticEntry> _diagnostics = [];

	/// <summary>
	/// JSON serializer options for exporting stopwatch data.
	/// </summary>
	private readonly JsonSerializerOptions _jsonSerializerOptions = new()
	{
		WriteIndented = true,
	};

	/// <summary>
	/// A list of recorded lap times.
	/// </summary>
	private readonly ConcurrentBag<TimeSpan> _laps = [];

	/// <summary>
	/// The name of the operation being tracked.
	/// </summary>
	private string? _operationName;

	/// <summary>
	/// The telemetry client used for tracking events and metrics.
	/// </summary>
	private TelemetryClient? _telemetry;

	/// <summary>
	/// A custom message to include with telemetry events.
	/// </summary>
	private string? _telemetryMessage;

	/// <summary>
	/// Optional key/value properties to attach to telemetry events.
	/// </summary>
	private IDictionary<string, string>? _telemetryProperties;

	/// <summary>
	/// Initializes a new instance of the <see cref="PerformanceStopwatch"/> class with an empty title.
	/// </summary>
	[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", Status = Status.Available)]
	public PerformanceStopwatch() => this.Title = ControlChars.EmptyString;

	/// <summary>
	/// Initializes a new instance with a custom title.
	/// </summary>
	/// <param name="title">The operation title.</param>
	[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", Status = Status.Available)]
	public PerformanceStopwatch([NotNull] string title) => this.Title = title;

	/// <summary>
	/// Event triggered when the stopwatch is reset.
	/// </summary>
	[Information(nameof(Reset), "David McCarter", "11/11/2020", Status = Status.New)]
	public event EventHandler<ElapsedEventArgs>? ResetCompleted;

	/// <summary>
	/// Event triggered when the stopwatch is stopped.
	/// </summary>
	[Information(nameof(StoppedCompleted), "David McCarter", "11/11/2020", Status = Status.New)]
	public event EventHandler<ElapsedEventArgs>? StoppedCompleted;

	/// <summary>
	/// Event triggered when elapsed time exceeds the threshold.
	/// </summary>
	[Information(nameof(ThresholdExceeded), "David McCarter", "11/11/2020", Status = Status.New)]
	public event EventHandler<ElapsedEventArgs>? ThresholdExceeded;

	/// <summary>
	/// Creates a structured diagnostic entry.
	/// </summary>
	/// <param name="message">The message to record.</param>
	/// <param name="result">The elapsed time.</param>
	/// <returns>A new <see cref="DiagnosticEntry"/>.</returns>
	private DiagnosticEntry CreateEntry(string message, TimeSpan result)
	{
		var entry = new DiagnosticEntry(DateTimeOffset.UtcNow, $"{this.Title} {message}", result);

		this._diagnostics.Add(entry);

		return entry;
	}


	/// <summary>
	/// Adds a diagnostic entry with the specified message and the current elapsed time.
	/// </summary>
	/// <param name="message">The message to include in the diagnostic entry. Cannot be null or empty.</param>
	/// <exception cref="ArgumentNullException">Thrown when the <paramref name="message"/> is null or empty.</exception>
	[Information(nameof(AddDiagnosticEntry), "David McCarter", "5/9/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void AddDiagnosticEntry([NotNull] string message)
	{
		message = message.ArgumentNotNullOrEmpty();

		var entry = new DiagnosticEntry(DateTimeOffset.UtcNow, $"{this.Title} {message}", this.Elapsed);
		this._diagnostics.Add(entry);
	}

	/// <summary>
	/// Clears all recorded diagnostic entries.
	/// </summary>
	/// <remarks>
	/// This method resets the internal diagnostics collection to an empty state.
	/// </remarks>
	[Information(nameof(ClearDiagnostics), "David McCarter", "05/08/2025", Status = Status.Available)]
	public void ClearDiagnostics() => this._diagnostics.Clear();

	/// <summary>
	/// Clears all recorded lap times.
	/// </summary>
	[Information(nameof(ClearLaps), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public void ClearLaps() => this._laps.Clear();

	/// <summary>
	/// Serializes stopwatch data to JSON including laps and diagnostics.
	/// </summary>
	/// <returns>A JSON string representing stopwatch data.</returns>
	[Information(nameof(ExportToJson), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public string ExportToJson()
	{
		return JsonSerializer.Serialize(
			new
			{
				this.Title,
				ElapsedTimeMs = this.Elapsed.TotalMilliseconds,
				Laps = this.GetLaps().ToArray(),
				Diagnostics = this.Diagnostics.Select(
					d => new
					{
						d.Timestamp,
						d.Message,
						ElapsedMs = d.Elapsed.TotalMilliseconds,
					})
					.ToArray()
			}, this._jsonSerializerOptions);
	}

	/// <summary>
	/// Retrieves all diagnostic messages recorded during the stopwatch's operation.
	/// </summary>
	/// <returns>
	/// A read-only collection of diagnostic messages as strings.
	/// </returns>
	[Information(nameof(GetDiagnosticMessages), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public ReadOnlyCollection<string> GetDiagnosticMessages() =>
	this.Diagnostics.Select(d => d.ToString()).ToList().AsReadOnly();

	/// <summary>
	/// Gets the current elapsed time formatted as a string.
	/// </summary>
	/// <returns>A formatted string showing the elapsed time in milliseconds.</returns>
	[Information(nameof(GetElapsedTimeString), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public string GetElapsedTimeString() => $"Elapsed Time: {this.Elapsed.TotalMilliseconds} ms";

	/// <summary>
	/// Gets a read-only list of all recorded lap times.
	/// </summary>
	/// <returns>A read-only collection of <see cref="TimeSpan"/> lap durations.</returns>
	[Information(nameof(GetLaps), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public ReadOnlyCollection<TimeSpan> GetLaps() => this._laps.OrderBy(p => p.TotalNanoseconds).ToArray().AsReadOnly();

	/// <summary>
	/// Returns a detailed summary report including laps and diagnostics.
	/// </summary>
	/// <returns>A human-readable summary string.</returns>
	[Information(nameof(GetSummaryReport), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public string GetSummaryReport()
	{

		var builder = _stringBuilderPool.Value.Get();

		try
		{
			_ = builder.AppendLine($"Performance Report - {this.Title}");
			_ = builder.AppendLine(this.GetElapsedTimeString());

			var lapCount = 0;
			foreach (var lap in this.GetLaps())
			{
				_ = builder.AppendLine($"Lap {lapCount++}: {lap.TotalMilliseconds} ms");
			}

			foreach (var entry in this.Diagnostics)
			{
				_ = builder.AppendLine(
					$"{entry.Timestamp:u}: {entry.Message} - {entry.Elapsed.TotalMilliseconds} ms");
			}

			return builder.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(builder);
		}
	}

	/// <summary>
	/// Logs a custom message and the current elapsed time using the provided logger.
	/// </summary>
	/// <param name="logger">Logger used for logging.</param>
	/// <param name="message">The message to log.</param>
	[Information(nameof(LogMessage), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public void LogMessage(ILogger logger, string message)
	{
		logger = logger.ArgumentNotNull();
		message = message.ArgumentNotNullOrEmpty();

		try
		{
			var entry = this.CreateEntry(message, this.Elapsed);

			using (logger.BeginScope(new Dictionary<string, object>
			{
				["Title"] = this.Title,
				["ElapsedMs"] = this.Elapsed.TotalMilliseconds,
				["Message"] = message
			}))
			{
				logger.LogInformationMessage(entry.ToString());
			}
		}
		catch (Exception ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileLoggingTheMessage, ex);
		}
	}

	/// <summary>
	/// Records a lap (checkpoint) using the current elapsed time.
	/// </summary>
	[Information(nameof(RecordLap), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public void RecordLap() => this._laps.Add(this.Elapsed);

	/// <summary>
	/// Starts a new stopwatch instance with optional title.
	/// </summary>
	/// <param name="title">Optional title for diagnostics.</param>
	[Information(nameof(StartNew), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static PerformanceStopwatch StartNew(string title = ControlChars.EmptyString)
	{
		if (!string.IsNullOrEmpty(title))
		{
			title += ControlChars.Colon;
		}

		var sw = new PerformanceStopwatch(title);
		sw.Start();

		return sw;
	}

	/// <summary>
	/// Starts a new instance of <see cref="PerformanceStopwatch"/> with a specified alert threshold and optional title.
	/// </summary>
	/// <param name="alertThreshold">The threshold for performance alerts.</param>
	/// <param name="title">An optional title for the stopwatch instance.</param>
	/// <returns>A new instance of <see cref="PerformanceStopwatch"/> configured with the specified alert threshold and title.</returns>
	[Information(nameof(StartNew), "David McCarter", "5/8/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static PerformanceStopwatch StartNewWithAlertThreshold(TimeSpan? alertThreshold, string title = ControlChars.EmptyString)
	{
		var sw = new PerformanceStopwatch(title) { AlertThreshold = alertThreshold };

		sw.Start();

		return sw;
	}

	/// <summary>
	/// Starts a new instance of <see cref="PerformanceStopwatch"/> with telemetry tracking enabled.
	/// </summary>
	/// <param name="telemetry">The telemetry client used to record events and metrics.</param>
	/// <param name="operationName">The name of the operation being tracked.</param>
	/// <param name="alertThreshold">An optional threshold for performance alerts.</param>
	/// <param name="message">An optional custom message to include with telemetry events.</param>
	/// <param name="properties">Optional key/value properties to attach to telemetry events.</param>
	/// <returns>A new instance of <see cref="PerformanceStopwatch"/> configured with telemetry tracking.</returns>
	[Information(nameof(StartNewWithTelemetry), "David McCarter", "5/8/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static PerformanceStopwatch StartNewWithTelemetry(TelemetryClient telemetry, string operationName, TimeSpan? alertThreshold = null, string message = ControlChars.EmptyString, IDictionary<string, string>? properties = null)
	{
		return StartNewWithAlertThreshold(alertThreshold, message).WithTelemetry(telemetry, operationName, message, properties);
	}

	/// <summary>
	/// Stops the stopwatch if the elapsed time exceeds the configured threshold.
	/// </summary>
	/// <returns>
	/// <c>true</c> if the elapsed time exceeds the threshold and the stopwatch is stopped; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// This method checks if the elapsed time has exceeded the configured <see cref="AlertThreshold"/>. 
	/// If the threshold is exceeded, the stopwatch is stopped, and the <see cref="ThresholdExceeded"/> event is triggered.
	/// </remarks>
	[Information(nameof(StopIfThresholdExceeded), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public bool StopIfThresholdExceeded()
	{
		if (this.IsThresholdExceeded)
		{
			this.Stop();
			this.ThresholdExceeded?.Invoke(this, new ElapsedEventArgs(this.Elapsed));
			return true;
		}

		return false;
	}

	/// <summary>
	/// Stops and resets the stopwatch, returning the elapsed time. Fires telemetry and threshold events if configured.
	/// </summary>
	/// <returns>The elapsed time before reset.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public TimeSpan StopReset()
	{
		this.Stop();
		var result = this.Elapsed;
		this.StoppedCompleted?.Invoke(this, new ElapsedEventArgs(result));
		this.ResetCompleted?.Invoke(this, new ElapsedEventArgs(result));
		this.Reset();

		if (this.IsThresholdExceeded)
		{
			this.ThresholdExceeded?.Invoke(this, new ElapsedEventArgs(result));
		}

		if (this._telemetry != null && !string.IsNullOrWhiteSpace(this._operationName))
		{
			this.TrackTelemetry(this._telemetry, this._operationName!, this._telemetryMessage ?? string.Empty, this._telemetryProperties);
		}

		return result;
	}

	/// <summary>
	/// Stops and resets the stopwatch, logs a message, and returns the elapsed time.
	/// </summary>
	/// <param name="logger">Logger used for logging.</param>
	/// <param name="message">Message to log.</param>
	/// <returns>The elapsed time before reset.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public TimeSpan StopReset(ILogger logger, string message)
	{
		var result = this.StopReset();

		if (logger.CheckIsNotNull() is false)
		{
			return result;
		}

		try
		{
			var entry = this.CreateEntry(message, result);

			using (logger.BeginScope(new Dictionary<string, object>
			{
				["Title"] = this.Title,
				["ElapsedMs"] = result.TotalMilliseconds
			}))
			{
				logger.LogInformationMessage(entry.ToString());
			}
		}
		catch (Exception ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileLoggingTheMessage, ex);
		}

		return result;
	}

	/// <summary>
	/// Stops and restarts the stopwatch, triggering threshold alerts if applicable.
	/// </summary>
	/// <returns>The elapsed time before restart.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public TimeSpan StopRestart()
	{
		var result = this.Elapsed;
		this.StoppedCompleted?.Invoke(this, new ElapsedEventArgs(result));
		this.Restart();

		if (this.IsThresholdExceeded)
		{
			this.ThresholdExceeded?.Invoke(this, new ElapsedEventArgs(result));
		}

		if (this._telemetry != null && !string.IsNullOrWhiteSpace(this._operationName))
		{
			this.TrackTelemetry(this._telemetry, this._operationName!, this._telemetryMessage ?? string.Empty, this._telemetryProperties);
		}

		return result;
	}

	/// <summary>
	/// Stops and restarts the stopwatch, logs a message, and returns the elapsed time.
	/// </summary>
	/// <param name="logger">Logger used for logging.</param>
	/// <param name="message">Message to log.</param>
	/// <returns>The elapsed time before restart.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public TimeSpan StopRestart(ILogger logger, string message)
	{
		var result = this.StopRestart();

		if (logger.CheckIsNotNull() is false)
		{
			return result;
		}

		try
		{
			var entry = this.CreateEntry(message, result);

			using (logger.BeginScope(new Dictionary<string, object>
			{
				["Title"] = this.Title,
				["ElapsedMs"] = result.TotalMilliseconds
			}))
			{
				logger.LogInformationMessage(entry.ToString());
			}
		}
		catch (Exception ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileLoggingTheMessage, ex);
		}

		return result;
	}


	/// <summary>
	/// Returns a detailed summary report of the stopwatch, including laps and diagnostics, as a string.
	/// </summary>
	/// <returns>A string representation of the stopwatch's summary report.</returns>
	[Information(nameof(ToString), "David McCarter", "1/18/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString() => this.GetSummaryReport();

	/// <summary>
	/// Tracks telemetry data for the current stopwatch instance using Application Insights.
	/// </summary>
	/// <param name="telemetry">The telemetry client used to record events and metrics.</param>
	/// <param name="operationName">The name of the operation being tracked.</param>
	/// <param name="message">An optional custom message to include with the telemetry event.</param>
	/// <param name="properties">Optional key/value properties to attach to the telemetry event.</param>
	/// <remarks>
	/// This method records an event and a metric for the operation, including the elapsed time and any additional properties provided.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="telemetry"/> is null.</exception>
	[Information(nameof(TrackTelemetry), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public void TrackTelemetry(TelemetryClient telemetry, string operationName, string message = ControlChars.EmptyString, IDictionary<string, string>? properties = null)
	{
		telemetry = telemetry.ArgumentNotNull();

		properties ??= new Dictionary<string, string>();
		properties["Title"] = this.Title;
		properties["ElapsedMs"] = this.Elapsed.TotalMilliseconds.ToString("F2", CultureInfo.CurrentCulture);

		if (!string.IsNullOrWhiteSpace(message))
		{
			properties["Message"] = message;
		}

		telemetry.TrackEvent(operationName, properties);
		telemetry.TrackMetric($"{operationName}.Duration", this.Elapsed.TotalMilliseconds);
	}

	/// <summary>
	/// Configures telemetry tracking for this stopwatch instance using Application Insights.
	/// </summary>
	/// <param name="telemetry">The telemetry client to record events and metrics.</param>
	/// <param name="operationName">The name of the operation being tracked.</param>
	/// <param name="message">A custom message to include with the telemetry event.</param>
	/// <param name="properties">Optional key/value properties to attach to the telemetry.</param>
	/// <returns>The current instance for fluent configuration.</returns>
	[Information(nameof(WithTelemetry), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public PerformanceStopwatch WithTelemetry(TelemetryClient telemetry, string operationName, string? message = null, IDictionary<string, string>? properties = null)
	{
		this._telemetry = telemetry.ArgumentNotNull();
		this._operationName = operationName;
		this._telemetryMessage = message;
		this._telemetryProperties = properties;

		return this;
	}

	/// <summary>
	/// Gets the threshold for performance alerts.
	/// </summary>
	[Information("AlertThreshold", "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public TimeSpan? AlertThreshold { get; private set; }

	/// <summary>
	/// The logged messages as a <see cref="ReadOnlyCollection{String}"/>.
	/// </summary>
	/// <example>
	/// Output:
	/// GetUsers():Load users from database. Time: 1013.02 ms
	/// GetUsers():Save users to database.Time: 1013.7925 ms
	/// </example>
	[Information(nameof(StopRestart), "David McCarter", "1/18/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ReadOnlyCollection<DiagnosticEntry> Diagnostics => this._diagnostics.OrderBy(p => p.Timestamp).ToArray().AsReadOnly();

	/// <summary>
	/// Gets a value indicating whether the elapsed time has exceeded the configured threshold.
	/// </summary>
	[Information(nameof(IsThresholdExceeded), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public bool IsThresholdExceeded => this.AlertThreshold.HasValue && this.Elapsed > this.AlertThreshold.Value;

	/// <summary>
	/// Gets the title for the stopwatch instance.
	/// </summary>
	[Information(nameof(Title), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public string Title { get; }
}
