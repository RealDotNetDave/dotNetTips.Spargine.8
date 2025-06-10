// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-28-2025
// ***********************************************************************
// <copyright file="HttpHandlerDiagnosticListener.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Accesses the HttpRequestMessage/HttpResponseMessage instances, providing a useful means to retrieve information such as request headers or the response status code.
// Original code by:
// https:www.meziantou.net/observing-all-http-requests-in-a-dotnet-application.htm
// </summary>
// ***********************************************************************
using System.Diagnostics;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Listens to diagnostic HTTP messages for HttpRequestMessage and HttpResponseMessage instances.
/// This class provides a way to observe and log HTTP request and response information, which can be useful for debugging and monitoring HTTP traffic.
/// </summary>
/// <remarks>
/// This class implements IObserver{T} where T is KeyValuePair{string, object}.
/// It listens for specific diagnostic events related to HTTP activities and logs them using the provided <see cref="ILogger"/> instance.
/// The diagnostic events include the start and stop of HTTP requests, allowing for detailed observation of HTTP traffic.
/// </remarks>
/// <example>
/// Usage example:
/// <code>
/// var logger = new LoggerFactory().CreateLogger("HttpLogger");
/// using var listener = new HttpHandlerDiagnosticListener(logger);
/// // Perform HTTP operations...
/// </code>
/// </example>
/// <remarks>Initializes a new instance of the <see cref="HttpHandlerDiagnosticListener" /> class.</remarks>
[Information(nameof(HttpHandlerDiagnosticListener), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
public sealed class HttpHandlerDiagnosticListener(ILogger logger) : IObserver<KeyValuePair<string, object>>
{

	/// <summary>
	/// A delegate that extracts the <see cref="HttpRequestMessage"/> from the diagnostic event's payload using reflection.
	/// This delegate is initialized by the <see cref="CreateGetRequest"/> method, which uses reflection to access the private "ActivityStartData" type within the System.Net.Http assembly.
	/// </summary>
	private static readonly Func<object, HttpRequestMessage> _requestAccessor = CreateGetRequest();

	/// <summary>
	/// A delegate that extracts the <see cref="HttpResponseMessage"/> from the diagnostic event's payload using reflection.
	/// This delegate is initialized by the <see cref="CreateGetResponse"/> method, which uses reflection to access the private "ActivityStopData" type within the System.Net.Http assembly.
	/// </summary>
	private static readonly Func<object, HttpResponseMessage> _responseAccessor = CreateGetResponse();

	/// <summary>
	/// Creates a delegate that extracts the <see cref="HttpRequestMessage"/> from the diagnostic event's payload.
	/// This method uses reflection to access the private "ActivityStartData" type within the System.Net.Http assembly,
	/// which contains the HttpRequestMessage. This approach is necessary due to the internal visibility of the relevant types.
	/// </summary>
	/// <returns>A delegate that takes an object (the event payload) and returns an <see cref="HttpRequestMessage"/>.</returns>
	private static Func<object, HttpRequestMessage> CreateGetRequest()
	{
		var requestDataType = Type.GetType("System.Net.Http.DiagnosticsHandler+ActivityStartData, System.Net.Http", throwOnError: true);
		var requestProperty = requestDataType.GetProperty("Request");

		return @object => (HttpRequestMessage)requestProperty.GetValue(@object);
	}

	/// <summary>
	/// Creates a delegate that extracts the <see cref="HttpResponseMessage"/> from the diagnostic event's payload.
	/// This method uses reflection to access the private "ActivityStopData" type within the System.Net.Http assembly,
	/// which contains the HttpResponseMessage. This approach is necessary due to the internal visibility of the relevant types.
	/// </summary>
	/// <returns>A delegate that takes an object (the event payload) and returns an <see cref="HttpResponseMessage"/>.</returns>
	private static Func<object, HttpResponseMessage> CreateGetResponse()
	{
		var requestDataType = Type.GetType("System.Net.Http.DiagnosticsHandler+ActivityStopData, System.Net.Http", throwOnError: true);
		var requestProperty = requestDataType.GetProperty("Response");

		return @object => (HttpResponseMessage)requestProperty.GetValue(@object);
	}

	/// <summary>
	/// Logs the specified message to the configured logger and writes the message to the system diagnostic trace.
	/// </summary>
	/// <param name="message">The message to log.</param>
	private void LogMessage(string message)
	{
		logger?.LogInformationMessage(message);

		Trace.WriteLine(message);
	}

	/// <summary>
	/// Notifies the observer that the provider has finished sending push-based notifications.
	/// This method is not supported in this context and will always throw a <see cref="NotSupportedException"/>.
	/// </summary>
	/// <exception cref="NotSupportedException">Always thrown to indicate that this operation is not supported.</exception>
	public void OnCompleted() => throw new NotSupportedException();

	/// <summary>
	/// Notifies the observer that the provider has experienced an error condition.
	/// This method is intentionally not supported in this context and will always throw a <see cref="NotSupportedException"/>.
	/// </summary>
	/// <param name="error">An object that provides additional information about the error.</param>
	/// <exception cref="NotSupportedException">Always thrown to indicate that this operation is not supported in this context.</exception>
	public void OnError(Exception error) => throw new NotSupportedException();

	/// <summary>
	/// Provides the observer with new data. This method is called whenever a diagnostic event related to HTTP activities is emitted.
	/// It processes the event data, extracting and logging relevant information such as HTTP request start and stop details.
	/// </summary>
	/// <param name="value">The current notification information, containing the event key and its payload.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="value"/> is null, ensuring that event processing does not proceed with null event data.</exception>
	public void OnNext(KeyValuePair<string, object> value)
	{
		value = value.ArgumentNotNull();

		// note: Legacy applications can use "System.Net.Http.HttpRequest" and "System.Net.Http.Response"
		if (string.Equals(value.Key, "System.Net.Http.HttpRequestOut.Start", StringComparison.OrdinalIgnoreCase))
		{
			// The type is private, so we need to use reflection to access it.
			var request = _requestAccessor(value.Value);
			this.LogMessage($"HTTP Diagnostic: {request.Method} {request.RequestUri} {request.Version} UserAgent: {request.Headers.UserAgent}");
		}
		else if (value.Key.Equals("System.Net.Http.HttpRequestOut.Stop", StringComparison.OrdinalIgnoreCase))
		{
			// The type is private, so we need to use reflection to access it.
			var response = _responseAccessor(value.Value);

			this.LogMessage($"HTTP Diagnostic: {response.StatusCode} {response.RequestMessage.RequestUri}");
		}
	}

}
