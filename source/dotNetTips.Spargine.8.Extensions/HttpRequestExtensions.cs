// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 06-01-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-18-2025
// ***********************************************************************
// <copyright file="HttpRequestExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for HttpRequest.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.AspNetCore.Http;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="HttpRequest"/> to enhance its functionality.
/// These methods include retrieving the raw body as a byte array or string, and trying to get the body directly into a specified type.
/// </summary>
/// <remarks>
/// The extension methods in this class aim to simplify the process of working with the request body of <see cref="HttpRequest"/>.
/// They provide convenient ways to access the raw body for various purposes such as logging, validation, or further processing.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class HttpRequestExtensions
{
	/// <summary>
	/// Adds a unique request identifier to the HTTP headers.
	/// </summary>
	/// <param name="headers">The HTTP headers to which the request identifier will be added.</param>
	/// <returns>The generated unique request identifier.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	[Information(nameof(AddRequestId), author: "David McCarter", createdOn: "3/18/2024", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static string AddRequestId([NotNull] this HttpRequestHeaders headers)
	{
		headers = headers.ArgumentNotNull();

		var id = UlidGenerator.GenerateUlid();

		headers.Add("X-Request-UUID", id);

		return id;
	}

	/// <summary>
	/// Retrieves the raw body as a byte array from the <see cref="HttpRequest" /> body stream.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <param name="request">The request.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>Task&lt;System.Byte[]&gt;.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(GetRawBodyBytesAsync), "David McCarter", "11/07/2023", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static async Task<byte[]> GetRawBodyBytesAsync([NotNull] this HttpRequest request, CancellationToken cancellationToken = default)
	{
		request = request.ArgumentNotNull();

		using (var ms = new MemoryStream(2048))
		{
			await request.Body.CopyToAsync(ms, cancellationToken).ConfigureAwait(false);

			return ms.ToArray();
		}
	}

	/// <summary>
	/// Retrieve the raw body as a string from the <see cref="HttpRequest" /> body stream.
	/// Validates that <paramref name="request" /> and <paramref name="encoding" /> is not null.
	/// </summary>
	/// <param name="request">Request instance to apply to.</param>
	/// <param name="encoding">Optional - Encoding, defaults to UTF8.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>Task&lt;System.String&gt;.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> or <paramref name="encoding"/> is null.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(GetRawBodyStringAsync), "David McCarter", "11/07/2023", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static async Task<string> GetRawBodyStringAsync([NotNull] this HttpRequest request, [NotNull] Encoding encoding, CancellationToken cancellationToken = default)
	{
		request = request.ArgumentNotNull();
		encoding = encoding.ArgumentNotNull();

		using (var reader = new StreamReader(request.Body, encoding))
		{
			return await reader.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Tries the get <see cref="HttpRequest" /> body.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="request">The HTTPRequest object.</param>
	/// <param name="value">The return value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">request</exception>
	/// <remarks>Original code by Jerry Nixon</remarks>
	[Information(nameof(TryGetBody), "David McCarter", "11/07/2023", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool TryGetBody<T>([NotNull] this HttpRequest request, out T value)
	{
		request = request.ArgumentNotNull();

		if (!request.TryGetBody(out var bytes))
		{
			value = default;
			return false;
		}

		try
		{
			value = JsonSerializer.Deserialize<T>(BitConverter.ToString(bytes));

			return true;
		}
		catch (ArgumentNullException)
		{
			value = default;
			return false;
		}
	}

	/// <summary>
	/// Tries the get <see cref="HttpRequest" /> body.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <param name="request">The HTTPRequest object.</param>
	/// <param name="value">The return value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">request</exception>
	/// <exception cref="ArgumentException">HttpRequest has no body.</exception>
	/// <remarks>Original code by Jerry Nixon</remarks>
	[Information(nameof(TryGetBody), "David McCarter", "11/07/2023", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool TryGetBody([NotNull] this HttpRequest request, out byte[] value)
	{
		request = request.ArgumentNotNull();

		if ((request.Body?.Length ?? 0) == 0)
		{
			ExceptionThrower.ThrowArgumentException(Resources.HttpRequestHasNoBody, nameof(request.Body));
		}

		value = GetBytes(request);

		return value.HasItems();

		static byte[] GetBytes(HttpRequest request)
		{
			byte[] bytes;

			using (var ms = new MemoryStream())
			{
				request.Body.CopyTo(ms);
				bytes = ms.ToArray();
			}

			return bytes;
		}
	}

}
