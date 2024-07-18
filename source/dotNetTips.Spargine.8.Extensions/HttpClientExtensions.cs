// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 07-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="HttpClientExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for HttpClient.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods tailored for <see cref="HttpClient"/>, enhancing its functionality with additional utility methods.
/// These methods simplify common tasks such as deserializing JSON responses from HTTP GET requests.
/// </summary>
/// <remarks>
/// The extension methods within this class aim to reduce boilerplate code and improve readability when working with <see cref="HttpClient"/>.
/// For example, the <see cref="GetAndDeserializeAsync{T}"/> method streamlines the process of sending a GET request, checking the response status,
/// reading the response content as a string, and deserializing it into an instance of a type.
/// </remarks>
public static class HttpClientExtensions
{

	/// <summary>
	/// Gets and deserializes the <see cref="HttpClient" />.
	/// Validates that <paramref name="client" />, <paramref name="url" />
	/// and <paramref name="options" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="client">The client.</param>
	/// <param name="url">The URL.</param>
	/// <param name="options">The options.</param>
	/// <returns>T.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information("Original code from: https://ardalis.com/keep-tests-short-and-dry-with-extensions", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static async Task<T> GetAndDeserializeAsync<T>([NotNull] this HttpClient client, [NotNull] Uri url, [NotNull] JsonSerializerOptions options)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		options = options.ArgumentNotNull();

		using (var response = await client.GetAsync(new Uri(url.PathAndQuery), CancellationToken.None).ConfigureAwait(false))
		{
			_ = response.EnsureSuccessStatusCode();

			var stringResponse = await response.Content.ReadAsStringAsync(CancellationToken.None).ConfigureAwait(false);

			return JsonSerializer.Deserialize<T>(stringResponse, options);
		}
	}

}
