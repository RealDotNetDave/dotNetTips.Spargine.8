// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="HttpEventListener.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Listens and logs messages from HTTP events, capturing events such as request start and stop. This functionality facilitates comprehensive monitoring and logging of HTTP-related activities.
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
/// Provides a mechanism to listen to and log HTTP events, facilitating comprehensive monitoring and logging of HTTP-related activities within an application.
/// This class captures events such as HTTP request start and stop, providing insights into the HTTP traffic that occurs during the application's runtime.
/// </summary>
/// <remarks>
/// This class is sealed to prevent inheritance, ensuring that the behavior defined here is consistent and not altered through subclassing.
/// The functionality is based on the <see cref="EventListener"/> class, leveraging event sources for HTTP activities.
/// </remarks>
/// <example>
/// Usage example:
/// <code>
/// using (var logger = new LoggerFactory().CreateLogger("HttpLogger"))
/// {
///     using var listener = new HttpEventListener(logger);
///     // Perform HTTP operations...
/// }
/// </code>
/// </example>
/// <seealso cref="EventListener"/>
[Information(nameof(HttpEventListener), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
public sealed class HttpEventListener(ILogger logger) : EventListener
{

	/// <summary>
	/// Logs a message to the configured logger and writes the message to the system diagnostic trace.
	/// This method is intended for internal use within the <see cref="HttpEventListener"/> class to log HTTP event information.
	/// </summary>
	/// <param name="message">The message to be logged. It should contain information about the HTTP event being processed.</param>
	private void LogMessage(string message)
	{
		logger?.LogInformationMessage(message);

		Trace.WriteLine(message);
	}

	/// <summary>
	/// Called for all existing event sources when the event listener is created and when a new event source is attached to the listener.
	/// This method ensures that events from specific sources, particularly those related to HTTP activities, are captured and logged.
	/// </summary>
	/// <param name="eventSource">The event source to be processed. This parameter is validated to ensure it is not null.</param>
	protected override void OnEventSourceCreated(EventSource eventSource)
	{
		eventSource = eventSource.ArgumentNotNull();
		const EventKeywords TasksFlowActivityIds = (EventKeywords)0x80;

		switch (eventSource.Name)
		{
			case "System.Net.Http":
				this.EnableEvents(eventSource, EventLevel.Informational, EventKeywords.All);
				break;

			// Enable EventWrittenEventArgs.ActivityId to correlate Start and Stop events
			case "System.Threading.Tasks.TplEventSource":

				this.EnableEvents(eventSource, EventLevel.LogAlways, TasksFlowActivityIds);
				break;
			default:
				break;
		}

		base.OnEventSourceCreated(eventSource);
	}

	/// <summary>
	/// Called whenever an event has been written by an event source for which the event listener has enabled events.
	/// This method processes the event data, extracting relevant information for logging purposes.
	/// </summary>
	/// <param name="eventData">The event arguments that describe the event. This includes details such as the event ID and payload.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="eventData"/> is null, ensuring that event processing does not proceed with null event data.</exception>
	protected override void OnEventWritten(EventWrittenEventArgs eventData)
	{
		eventData = eventData.ArgumentNotNull();

		// note: Use eventData.ActivityId to correlate Start and Stop events
		if (eventData.EventId == 1) // eventData.EventName == "RequestStart"
		{
			var scheme = (string)eventData.Payload[0];
			var host = (string)eventData.Payload[1];
			var port = (int)eventData.Payload[2];
			var pathAndQuery = (string)eventData.Payload[3];
			var versionMajor = (byte)eventData.Payload[4];
			var versionMinor = (byte)eventData.Payload[5];
			var policy = (HttpVersionPolicy)eventData.Payload[6];

			this.LogMessage($"HTTP {eventData.EventName}: {eventData.ActivityId} {scheme}://{host}:{port}{pathAndQuery} HTTP/{versionMajor}.{versionMinor} POLICY: {policy}");
		}
		else if (eventData.EventId == 2) // eventData.EventName == "RequestStop"
		{
			this.LogMessage($"HTTP {eventData.EventName}: {eventData.ActivityId}");
		}
	}

}
