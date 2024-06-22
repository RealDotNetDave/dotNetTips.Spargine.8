// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="HttpEventListenerAsyncLocal.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Listens asynchronously and logs messages from HTTP events, including request start and stop. This functionality enables comprehensive monitoring and logging of asynchronous HTTP-related activities.
// Orginal code by:
// https:www.meziantou.net/observing-all-http-requests-in-a-dotnet-application.htm
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.Tracing;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Provides an event listener for HTTP events that operates with <see cref="AsyncLocal{T}"/> to track and log HTTP request start and stop events asynchronously.
/// This class is designed to capture and log detailed information about HTTP requests, including their execution time, which aids in monitoring and debugging HTTP traffic in .NET applications.
/// </summary>
/// <remarks>
/// This class leverages <see cref="EventListener"/> to subscribe to HTTP-related events emitted by the System.Net.Http event source.
/// It uses an <see cref="AsyncLocal{T}"/> field to maintain the context of the current HTTP request across asynchronous control flows, enabling accurate logging of request execution times.
/// </remarks>
/// <example>
/// Usage example:
/// <code>
/// using (var logger = new LoggerFactory().CreateLogger("HttpLogger"))
/// {
///     using var listener = new HttpEventListenerAsyncLocal(logger);
///     // Perform HTTP operations...
/// }
/// </code>
/// </example>
/// <seealso cref="EventListener"/>
/// <param name="logger">The logger used for logging HTTP events. This logger is utilized to log information about each HTTP request's start and stop events, including the URL and execution time.</param>
[Information(nameof(HttpEventListenerAsyncLocal), UnitTestCoverage = 100, Status = Status.Available)]
public sealed class HttpEventListenerAsyncLocal(ILogger logger) : EventListener
{

	/// <summary>
	/// Holds the context of the current HTTP request across asynchronous control flows.
	/// This enables tracking of request start and stop events to accurately log request execution times.
	/// </summary>
	private readonly AsyncLocal<Request> _currentRequest = new();

	/// <summary>
	/// Logs a message to the configured logger and writes the message to the system diagnostic trace.
	/// This method is intended for internal use within the <see cref="HttpEventListenerAsyncLocal"/> class to log HTTP event information.
	/// </summary>
	/// <param name="message">The message to be logged. It should contain information about the HTTP event being processed.</param>
	private void LogMessage(string message)
	{
		if (logger is not null)
		{
			FastLogger.LogInformation(logger, message);
		}

		Trace.WriteLine(message);
	}

	/// <summary>
	/// Called for all existing event sources when the event listener is created and when a new event source is attached to the listener.
	/// This method subscribes to the HTTP event source to enable logging of HTTP request start and stop events.
	/// </summary>
	/// <param name="eventSource">The event source to be processed.</param>
	protected override void OnEventSourceCreated(EventSource eventSource)
	{
		eventSource = eventSource.ArgumentNotNull();

		if (string.Equals(eventSource.Name, "System.Net.Http", StringComparison.Ordinal))
		{
			this.EnableEvents(eventSource, EventLevel.Informational, EventKeywords.All);
		}

		base.OnEventSourceCreated(eventSource);
	}

	/// <summary>
	/// Called whenever an event has been written by an event source for which the event listener has enabled events.
	/// This method processes the event data, extracting relevant information for logging purposes.
	/// Specifically, it handles "RequestStart" and "RequestStop" events to track and log the execution time of HTTP requests.
	/// </summary>
	/// <param name="eventData">The event arguments that describe the event. This includes details such as the event ID and payload.</param>
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
	/// Represents an HTTP request with its URL and a stopwatch to measure execution time.
	/// This record is used to track the start and stop times of HTTP requests for logging purposes.
	/// </summary>
	/// <param name="Url">The URL of the HTTP request.</param>
	/// <param name="ExecutionTime">The stopwatch used to measure the execution time of the HTTP request.</param>
	private sealed record Request(string Url, Stopwatch ExecutionTime);

}
