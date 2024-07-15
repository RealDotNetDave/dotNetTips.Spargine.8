// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-08-2024
// ***********************************************************************
// <copyright file="WebClientExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for WebClient.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="WebClient"/> to enhance its functionality,
/// including methods for converting JSON data to objects.
/// </summary>
public static class WebClientExtensions
{

	/// <summary>
	/// Converts JSON data from a specified URL into an object of type <typeparamref name="T"/>.
	/// Validates that <paramref name="client"/> and <paramref name="url"/> are not null.
	/// </summary>
	/// <typeparam name="T">The type of the object to convert to.</typeparam>
	/// <param name="client">The <see cref="WebClient"/> instance. This parameter cannot be null.</param>
	/// <param name="url">The URL to download JSON data from. This parameter cannot be null.</param>
	/// <returns>An instance of type <typeparamref name="T"/> populated with data from the JSON string; otherwise, null if the JSON data is empty.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is null.</exception>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="url"/> is null.</exception>
	[Information(nameof(ConvertFrom), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static T ConvertFrom<T>([NotNull] this WebClient client, [NotNull] Uri url)
		where T : class
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();

		var data = client.DownloadString(url);

		if (string.IsNullOrEmpty(data))
		{
			return null;
		}

		using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
		{
			var serializer = new DataContractJsonSerializer(typeof(T));
			var obj = (T)serializer.ReadObject(stream);

			stream.FlushClose();

			return obj;
		}
	}

}
