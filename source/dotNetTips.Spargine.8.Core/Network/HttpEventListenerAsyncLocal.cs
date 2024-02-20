// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="HttpEventListenerAsyncLocal.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Listens and logs messages from HTTP events async, including request start
// and stop. This functionality allows for comprehensive monitoring and
// logging of HTTP-related activities.
// Orginal code by:
// https:www.meziantou.net/observing-all-http-requests-in-a-dotnet-application.htm
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.Tracing;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Class HttpEventListenerAsyncLocal. This class cannot be inherited.
/// Implements the <see cref="EventListener" />
/// </summary>
/// <example>
/// Output: HTTP Request: https://dotnettips.com:443/ executed in 1408.0ms
/// </example>
/// <seealso cref="EventListener" />
/// <param name="logger">The logger.</param>
/// <remarks>Initializes a new instance of the <see cref="HttpEventListenerAsyncLocal" /> class.</remarks>
[Information(nameof(HttpEventListenerAsyncLocal), UnitTestCoverage = 100, Status = Status.Available)]
public sealed class HttpEventListenerAsyncLocal(ILogger logger) : EventListener
{

	/// <summary>
	/// The current request
	/// </summary>
	private readonly AsyncLocal<Request> _currentRequest = new();

	/// <summary>
	/// Logs the message.
	/// </summary>
	/// <param name="message">The message.</param>
	private void LogMessage(string message)
	{
		if (logger is not null)
		{
			EasyLogger.LogInformation(logger, message);
		}

		Trace.WriteLine(message);
	}

	/// <summary>
	/// Called for all existing event sources when the event listener is created and when a new event source is attached to the listener.
	/// </summary>
	/// <param name="eventSource">The event source.</param>
	protected override void OnEventSourceCreated(EventSource eventSource)
	{
		eventSource = eventSource.ArgumentNotNull();

		if (eventSource.Name == "System.Net.Http")
		{
			this.EnableEvents(eventSource, EventLevel.Informational, EventKeywords.All);
		}

		base.OnEventSourceCreated(eventSource);
	}

	/// <summary>
	/// Called whenever an event has been written by an event source for which the event listener has enabled events.
	/// </summary>
	/// <param name="eventData">The event arguments that describe the event.</param>
	protected override void OnEventWritten(EventWrittenEventArgs eventData)
	{
		eventData = eventData.ArgumentNotNull();

		if (eventData.EventId == 1) // eventData.EventName == "RequestStart"
		{
			var scheme = (string)eventData.Payload[0];
			var host = (string)eventData.Payload[1];
			var port = (int)eventData.Payload[2];
			var pathAndQuery = (string)eventData.Payload[3];

			this._currentRequest.Value = new Request($"{scheme}://{host}:{port}{pathAndQuery}", Stopwatch.StartNew());
		}
		else if (eventData.EventId == 2) // eventData.EventName == "RequestStop"
		{
			var currentRequest = this._currentRequest.Value;

			if (currentRequest != null)
			{
				this.LogMessage($"HTTP Request: {currentRequest.Url} executed in {currentRequest.ExecutionTime.ElapsedMilliseconds:F1}ms");
			}
		}
	}

	/// <summary>
	/// Class Request. This class cannot be inherited.
	/// </summary>
	private sealed record Request(string Url, Stopwatch ExecutionTime);

}
