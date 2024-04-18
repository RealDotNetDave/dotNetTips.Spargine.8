// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2024
// ***********************************************************************
// <copyright file="HttpHandlerDiagnosticListener.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Accesses the HttpRequestMessage/HttpResponseMessage instances, providing a useful means to retrieve information such as request headers or the response status code.
// Original code by:
// https:www.meziantou.net/observing-all-http-requests-in-a-dotnet-application.htm
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Class HttpHandlerDiagnosticListener. This class cannot be inherited.
/// </summary>
/// <example>
/// Output: HTTP Observer: GET https://dotnettips.com/ 1.1 UserAgent:
/// Output: HTTP Observer: OK https://dotnettips.com/
/// </example>
/// <param name="logger">The logger.</param>
/// <remarks>Initializes a new instance of the <see cref="HttpHandlerDiagnosticListener" /> class.</remarks>
[Information(nameof(HttpHandlerDiagnosticListener), UnitTestCoverage = 100, Status = Status.Available)]
public sealed class HttpHandlerDiagnosticListener(ILogger logger) : IObserver<KeyValuePair<string, object>>
{

	/// <summary>
	/// Creates the get request.
	/// </summary>
	/// <returns>Func&lt;System.Object, HttpRequestMessage&gt;.</returns>
	private static Func<object, HttpRequestMessage> CreateGetRequest()
	{
		var requestDataType = Type.GetType("System.Net.Http.DiagnosticsHandler+ActivityStartData, System.Net.Http", throwOnError: true);
		var requestProperty = requestDataType.GetProperty("Request");

		return (object o) => (HttpRequestMessage)requestProperty.GetValue(o);
	}

	/// <summary>
	/// Creates the get response.
	/// </summary>
	/// <returns>Func&lt;System.Object, HttpResponseMessage&gt;.</returns>
	private static Func<object, HttpResponseMessage> CreateGetResponse()
	{
		var requestDataType = Type.GetType("System.Net.Http.DiagnosticsHandler+ActivityStopData, System.Net.Http", throwOnError: true);
		var requestProperty = requestDataType.GetProperty("Response");

		return (object o) => (HttpResponseMessage)requestProperty.GetValue(o);
	}

	/// <summary>
	/// Logs the message.
	/// </summary>
	/// <param name="message">The message.</param>
	private void LogMessage(string message)
	{
		if (logger is not null)
		{
			FastLogger.LogInformation(logger, message);
		}

		Trace.WriteLine(message);
	}

	/// <summary>
	/// Notifies the observer that the provider has finished sending push-based notifications.
	/// </summary>
	/// <exception cref="NotSupportedException"></exception>
	public void OnCompleted() => throw new NotSupportedException();

	/// <summary>
	/// Notifies the observer that the provider has experienced an error condition.
	/// </summary>
	/// <param name="error">An object that provides additional information about the error.</param>
	/// <exception cref="NotSupportedException"></exception>
	public void OnError(Exception error) => throw new NotSupportedException();

	/// <summary>
	/// Provides the observer with new data.
	/// </summary>
	/// <param name="value">The current notification information.</param>
	public void OnNext([NotNull] KeyValuePair<string, object> value)
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

	/// <summary>
	/// The request accessor
	/// </summary>
	private static readonly Func<object, HttpRequestMessage> _requestAccessor = CreateGetRequest();

	/// <summary>
	/// The response accessor
	/// </summary>
	private static readonly Func<object, HttpResponseMessage> _responseAccessor = CreateGetResponse();

}
