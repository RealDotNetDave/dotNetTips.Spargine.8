// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="HttpEventListener.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Listens and logs messages from HTTP events, including request start
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
/// Class HttpEventListener. This class cannot be inherited.
/// Implements the <see cref="EventListener" />
/// </summary>
/// <example>
///   <b>Output:</b> HTTP RequestStart: 00000011-0000-0000-0000-00008ed19d59 https://dotnettips.com:443/
/// HTTP/1.1 POLICY: RequestVersionOrLower
/// <b>Output:</b> HTTP RequestStop: 00000011-0000-0000-0000-00008ed19d59
/// </example>
/// <seealso cref="EventListener" />
/// <param name="logger">The logger.</param>
/// <remarks>Creates a new instance of the <see cref="HttpEventListener" /> class.</remarks>
[Information(nameof(HttpEventListener), UnitTestCoverage = 100, Status = Status.Available)]
public sealed class HttpEventListener(ILogger logger) : EventListener
{

	/// <summary>
	/// Logs the message.
	/// </summary>
	/// <param name="message">The message.</param>
	private void LogMessage(string message)
	{
		logger?.LogInformationMessage(message);

		Trace.WriteLine(message);
	}

	/// <summary>
	/// Called for all existing event sources when the event listener is created and when a new event source is attached to the listener.
	/// </summary>
	/// <param name="eventSource">The event source.</param>
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
	/// </summary>
	/// <param name="eventData">The event arguments that describe the event.</param>
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
