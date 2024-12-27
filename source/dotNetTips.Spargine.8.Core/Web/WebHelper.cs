// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2024
// ***********************************************************************
// <copyright file="WebHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Utility methods for website calls. These functions streamline website
// interactions and efficiently manage HTTP-related tasks.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Microsoft.AspNetCore.Http;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Web;

/// <summary>
/// Provides utility methods for website calls, streamlining interactions and efficiently managing HTTP-related tasks.
/// </summary>
/// <remarks>
/// The WebHelper class simplifies common web operations such as downloading content asynchronously,
/// identifying local URIs, and managing HTTP headers. It leverages <see cref="HttpClient"/> for network communications,
/// ensuring best practices like connection reuse are followed. This class is part of the DotNetTips.Spargine.8.Core library,
/// aimed at enhancing .NET development productivity.
/// </remarks>
[Information("From dotNetTips.Utility", Status = Status.NeedsDocumentation)]
public static class WebHelper
{

	/// <summary>
	/// A static instance of <see cref="HttpClient"/> used for making HTTP requests.
	/// </summary>
	/// <remarks>
	/// This instance is shared across all uses of the WebHelper class to ensure efficient socket usage and modern HTTP/2 protocol support.
	/// </remarks>
	private static readonly HttpClient _httpClient = new();

	/// <summary>
	/// Asynchronously downloads the string content from the specified URI.
	/// </summary>
	/// <param name="address">The URI from which to download the string content. Must not be null.</param>
	/// <param name="clientId">Optional. The client identifier to be added to the request headers. If not specified, defaults to "NONE".</param>
	/// <returns>A task that represents the asynchronous download operation. The task result contains the downloaded string content.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="address"/> is null.</exception>
	/// <exception cref="HttpRequestException">Thrown if the request fails due to an underlying issue such as network connectivity, DNS failure, server certificate validation, or timeout.</exception>
	/// <remarks>
	/// This method adds a "CLIENTID" header to the request if <paramref name="clientId"/> is provided and not "NONE".
	/// Ensure proper disposal of the task to avoid resource leaks.
	/// </remarks>
	[Information(nameof(DownloadStringAsync), OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static async Task<string> DownloadStringAsync([NotNull] Uri address, string clientId = "NONE")
	{
		address = address.ArgumentNotNull();

		if (!string.IsNullOrEmpty(clientId) && !string.Equals(clientId, "NONE", StringComparison.Ordinal))
		{
			_httpClient.DefaultRequestHeaders.Add("CLIENTID", clientId);
		}

		// Download the data
		using (var response = await _httpClient.GetAsync(address, CancellationToken.None).ConfigureAwait(false))
		{
			return await response.Content.ReadAsStringAsync(CancellationToken.None).ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Retrieves a read-only collection of HTTP header names defined in <see cref="HttpRequestHeader"/>.
	/// </summary>
	/// <returns>A read-only collection of strings representing the names of HTTP headers.</returns>
	/// <remarks>
	/// This method provides a convenient way to access all standard HTTP header names as defined by the .NET framework.
	/// It can be useful for validation, logging, or setting headers in HTTP requests.
	/// </remarks>
	[Information(nameof(HttpHeaderNames), "David McCarter", "9/2/2020", "9/2/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<string> HttpHeaderNames() => Enum.GetNames<HttpRequestHeader>().AsReadOnly();

	/// <summary>
	/// Determines whether the specified URI is local to the server.
	/// </summary>
	/// <param name="path">The URI to check.</param>
	/// <param name="request">The current HTTP request context.</param>
	/// <returns><c>true</c> if the URI is local; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method is useful for validating whether a given URI points to a resource on the same server,
	/// which can be important for security and resource access decisions.
	/// </remarks>
	[Information(nameof(IsLocalUri), author: "David McCarter", createdOn: "9/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static bool IsLocalUri([NotNull] string path, [NotNull] HttpRequest request)
	{
		path = path.ArgumentNotNullOrEmpty(true);
		request = request.ArgumentNotNull();

		if (Uri.TryCreate(path, UriKind.Absolute, out var absoluteUri))
		{
			return string.Equals(request.Host.ToUriComponent(), absoluteUri.Host, StringComparison.OrdinalIgnoreCase);
		}
		else
		{
			return !path.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
				!path.StartsWith("https://", StringComparison.OrdinalIgnoreCase) &&
				Uri.IsWellFormedUriString(path, UriKind.Relative);
		}
	}

}
