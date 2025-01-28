// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-21-2025
// ***********************************************************************
// <copyright file="PerformanceStopwatch.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Enhances Stopwatch with helpful methods: StartNew() and StopReset().
// Additionally, it possesses the ability to add messages that can be
// retrieved when the Stopwatch stops.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Internal;
using DotNetTips.Spargine.Core.Properties;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// <see cref="Stopwatch"/> with added features for enhanced diagnostics and performance measurement.
/// </summary>
/// <seealso cref="Stopwatch"/>
[ExcludeFromCodeCoverage(Justification = "Primarily used for diagnostics and performance measurement, not business logic.")]
[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", Status = Status.Available, BenchmarkStatus = BenchmarkStatus.NotRequired, Documentation = "bit.ly/SpargineFeb2023")]
public sealed class PerformanceStopwatch : Stopwatch
{

	/// <summary>
	/// The diagnostics messages logged during the stopwatch's lifetime. These messages can be retrieved for analysis or logging purposes.
	/// </summary>
	private readonly List<string> _diagnostics = [];

	/// <summary>
	/// Initializes a new instance of the <see cref="PerformanceStopwatch"/> class with the specified title.
	/// </summary>
	/// <param name="title">The title message associated with the stopwatch instance.</param>
	private PerformanceStopwatch(string title) => this.Title = title;

	/// <summary>
	/// Creates a diagnostic message combining the specified message and the elapsed time, then logs it.
	/// </summary>
	/// <param name="message">The message to log. Should not be null.</param>
	/// <param name="result">The elapsed time to include in the message.</param>
	/// <returns>A formatted string combining the title, message, and elapsed time.</returns>
	private string CreateMessage(string message, TimeSpan result)
	{
		var formattedMessage = string.Concat(this.Title, message, $" Time: {result.TotalMilliseconds} ms");

		lock (this._diagnostics)
		{
			this._diagnostics.Add(formattedMessage);
		}

		return formattedMessage;
	}

	/// <summary>
	/// Starts a new <see cref="PerformanceStopwatch"/> instance with an optional title.
	/// </summary>
	/// <param name="title">The title associated with the stopwatch instance for logging purposes. If not provided, an empty string is used.</param>
	/// <returns>A started <see cref="PerformanceStopwatch"/> instance.</returns>
	[Information(nameof(StartNew), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static PerformanceStopwatch StartNew(string title = ControlChars.EmptyString)
	{
		if (title.HasValue())
		{
			title = $"{title}{ControlChars.Colon}";
		}
		var sw = new PerformanceStopwatch(title);

		sw.Start();

		return sw;
	}

	/// <summary>
	/// Stops the <see cref="PerformanceStopwatch"/>, resets it to zero, and returns the elapsed time.
	/// </summary>
	/// <returns>The elapsed time as a <see cref="TimeSpan"/> before the stopwatch was stopped and reset.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", Status = Status.Available)]
	public TimeSpan StopReset()
	{
		this.Stop();
		var result = this.Elapsed;
		this.Reset();

		return result;
	}

	/// <summary>
	/// Stops the <see cref="PerformanceStopwatch"/>, resets it to zero, logs a message using the specified <paramref name="logger"/>, and returns the elapsed time.
	/// </summary>
	/// <param name="logger">The logger used for logging the message. Must not be null.</param>
	/// <param name="message">The message to log. Must not be null.</param>
	/// <returns>The elapsed time as a <see cref="TimeSpan"/> before the stopwatch was stopped and reset.</returns>
	/// <example>
	/// Output: LoadUsers():Call to Database. Time: 1006.3728 ms
	/// </example>
	[Information(nameof(StopReset), "David McCarter", "1/18/2023", Status = Status.Available)]
	public TimeSpan StopReset(ILogger logger, string message)
	{
		logger = logger.ArgumentNotNull();
		message = message.ArgumentNotNull();

		var result = this.StopReset();

		try
		{
			logger.WriteInformationMessage(this.CreateMessage(message, result));
		}
		catch (Exception ex)
		{
			// Handle or log the exception as needed
			throw new InvalidOperationException(Resources.AnErrorOccurredWhileLoggingTheMessage, ex);
		}

		return result;
	}

	/// <summary>
	/// Stops the <see cref="PerformanceStopwatch"/>, restarts it, and returns the elapsed time before the restart.
	/// </summary>
	/// <returns>The elapsed time as a <see cref="TimeSpan"/> before the stopwatch was stopped and restarted.</returns>
	[Information(nameof(StopRestart), "David McCarter", "11/11/2020", Status = Status.Available)]
	public TimeSpan StopRestart()
	{
		var result = this.Elapsed;

		this.Restart();

		return result;
	}

	/// <summary>
	/// Stops the <see cref="PerformanceStopwatch"/>, restarts it, logs a message using the specified logger, and returns the elapsed time before the restart.
	/// </summary>
	/// <param name="logger">The logger used for logging the message. Must not be null.</param>
	/// <param name="message">The message to log. Must not be null.</param>
	/// <returns>The elapsed time as a <see cref="TimeSpan"/> before the stopwatch was stopped and restarted.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
	/// <example>
	/// Output: LoadUsers():Call to Database. Time: 1006.3728 ms
	/// </example>
	[Information(nameof(StopRestart), "David McCarter", "1/18/2023", Status = Status.Available)]
	public TimeSpan StopRestart(ILogger logger, string message)
	{
		var result = this.StopRestart();

		try
		{
			logger.WriteInformationMessage(this.CreateMessage(message, result));
		}
		catch (Exception ex)
		{
			// Handle or log the exception as needed
			throw new InvalidOperationException(Resources.AnErrorOccurredWhileLoggingTheMessage, ex);
		}

		return result;
	}

	/// <summary>
	/// Returns a <see cref="string"/> that represents all the logged messages.
	/// </summary>
	/// <returns>A <see cref="string"/> that concatenates all the logged diagnostic messages.</returns>
	public override string ToString() => FastStringBuilder.CombineStrings(true, [.. this._diagnostics]);

	/// <summary>
	/// Gets the logged messages as a read-only collection.
	/// </summary>
	/// <value>The logged messages as a <see cref="ReadOnlyCollection{String}"/>.</value>
	/// <example>
	/// Output:
	/// GetUsers():Load users from database. Time: 1013.02 ms
	/// GetUsers():Save users to database.Time: 1013.7925 ms
	/// </example>
	public ReadOnlyCollection<string> Diagnostics
	{
		get
		{
			lock (this._diagnostics)
			{
				return this._diagnostics.AsReadOnly();
			}
		}
	}

	/// <summary>
	/// Gets the title of the <see cref="PerformanceStopwatch"/>.
	/// </summary>
	/// <value>The title associated with the stopwatch instance.</value>
	public string Title { get; private set; }

}
