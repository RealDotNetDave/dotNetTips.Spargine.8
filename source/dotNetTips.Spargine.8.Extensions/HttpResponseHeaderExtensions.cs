// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 07-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-28-2025
// ***********************************************************************
// <copyright file="HttpResponseHeaderExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for HttpResponseHeader.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http.Headers;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for working with <see cref="HttpResponseHeader"/>, enhancing its functionality by allowing easy retrieval of header names.
/// </summary>
/// <remarks>
/// This class simplifies the process of converting <see cref="HttpResponseHeader"/> enumeration values to their corresponding string names.
/// It is particularly useful for logging, debugging, or any scenario where the string representation of an HTTP response header is needed.
/// </remarks>
[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
public static class HttpResponseHeaderExtensions
{

	/// <summary>
	/// The header names
	/// </summary>
	private static readonly string[] _headerNames = [
		"Cache-Control",
		"Connection",
		"Date",
		"Keep-Alive",
		"Pragma",
		"Trailer",
		"Transfer-Encoding",
		"Upgrade",
		"Via",
		"Warning",
		"Allow",
		"Content-Length",
		"Content-Type",
		"Content-Encoding",
		"Content-Language",
		"Content-Location",
		"Content-MD5",
		"Content-Range",
		"Expires",
		"Last-Modified",
		"Accept-Ranges",
		"Age",
		"ETag",
		"Location",
		"Proxy-Authenticate",
		"Retry-After",
		"Server",
		"Set-Cookie",
		"Vary",
		"WWW-Authenticate",
	];

	/// <summary>
	/// Gets the <see cref="HttpRequestHeader" /> name.
	/// </summary>
	/// <param name="header">The header.</param>
	/// <returns>System.String.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static string GetName([NotNull] this HttpResponseHeader header)
	{
		header = header.ArgumentDefined(nameof(header));

		return _headerNames[(int)header];
	}

	/// <summary>
	/// Retrieves the request identifier from the HTTP headers.
	/// </summary>
	/// <param name="headers">The HTTP headers from which the request identifier will be retrieved.</param>
	/// <returns>The request identifier if found; otherwise, an empty string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	[Information(nameof(GetRequestId), author: "David McCarter", createdOn: "3/18/2024", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string GetRequestId([NotNull] this HttpResponseHeaders headers)
	{
		headers = headers.ArgumentNotNull();

		return headers.TryGetValues("X-Request-UUID", out var values) ? values.FirstOrDefault() ?? string.Empty : string.Empty;
	}

}
