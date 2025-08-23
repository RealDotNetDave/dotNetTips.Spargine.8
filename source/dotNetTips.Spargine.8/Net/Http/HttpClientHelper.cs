// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 01-11-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-04-2025
// ***********************************************************************
// <copyright file="HttpClientHelper.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Utility methods for HttpClient.</summary>
// ***********************************************************************
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Net.Http;

/// <summary>
/// Provides utility methods for working with HttpClient, including getting HTTP responses and streams with a default timeout.
/// </summary>
/// <remarks>
/// This class encapsulates functionality for making HTTP requests and handling responses. It simplifies the process of using <see cref="HttpClient"/>
/// by providing methods that abstract away some of the complexities involved in setting up requests and processing responses. The class is designed
/// to be used statically, with a shared instance of <see cref="HttpClient"/> that is configured with a default timeout value. This approach helps to
/// avoid the common pitfalls associated with managing the lifecycle of <see cref="HttpClient"/> instances.
/// </remarks>
[Information(Status = Status.Available)]
public static class HttpClientHelper
{

	/// <summary>
	/// The format string used to indicate that a resource was not found.
	/// </summary>
	private static readonly CompositeFormat _resourceWasNotFound = CompositeFormat.Parse(Resources.ResourceWasNotFound);

	/// <summary>
	/// The HttpClient instance used for making HTTP requests. Configured with a 20-second timeout.
	/// </summary>
	private static readonly HttpClient Client = new()
	{
		Timeout = TimeSpan.FromSeconds(value: 20),
	};

	/// <summary>
	/// Asynchronously gets an HTTP response for the specified URL using a cancellation token.
	/// </summary>
	/// <param name="url">The URL to get the response from.</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns>A task that represents the asynchronous operation and contains the HTTP response.</returns>
	/// <exception cref="ArgumentInvalidException">Thrown when the URL is null or empty.</exception>
	/// <example>
	/// Here is how you can use the GetHttpResponseAsync method with a cancellation token:
	/// <code>
	/// Uri url = new Uri("https://example.com");
	/// using var cancellationTokenSource = new CancellationTokenSource();
	/// HttpResponseMessage response = await HttpClientHelper.GetHttpResponseAsync(url, cancellationTokenSource);
	/// Console.WriteLine(response.StatusCode);
	/// </code></example>
	/// <remarks>Original code by: Máňa Píchová.</remarks>
	[DefaultValue(null)]
	[Information(nameof(GetHttpResponseAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<HttpResponseMessage> GetHttpResponseAsync([NotNull] Uri url, CancellationToken cancellationToken = default)
	{
		url = url.ArgumentNotNull<Uri>();

		try
		{
			// Pass in the token.
			var response = await Client.GetAsync(url, cancellationToken: cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

			_ = response.EnsureSuccessStatusCode();

			return response;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			// If the token has been canceled, it is not a timeout.
			// Handle cancellation.
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasBeenCanceled, ex);
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			// Handle timeout.
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasTimedOut, ex);
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			// Handle 404
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
		}

		return null;
	}

	/// <summary>
	/// Asynchronously retrieves a stream from the specified URL.
	/// </summary>
	/// <param name="url">The URL to retrieve the stream from.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation and contains the stream from the specified URL.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="url"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled or times out.</exception>
	/// <example>
	/// Here is how you can use the GetStreamAsync method:
	/// <code>
	/// Uri url = new Uri("https://example.com");
	/// Stream stream = await HttpClientHelper.GetStreamAsync(url);
	/// // Use the stream
	/// </code>
	/// </example>
	[DefaultValue(null)]
	[Information(nameof(GetHttpResponseAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<Stream> GetStreamAsync(Uri url, CancellationToken cancellationToken = default)
	{
		url = url.ArgumentNotNull<Uri>();

		try
		{
			// Pass in the token.
			var response = await Client.GetStreamAsync(url, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

			return response;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			// If the token has been canceled, it is not a timeout.
			// Handle cancellation.
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasBeenCanceled, ex);
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			// Handle timeout.
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasTimedOut, ex);
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			// Handle 404
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
		}
		catch (HttpRequestException ex)
		{
			// Handle 404
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
		}

		return null;
	}

}
