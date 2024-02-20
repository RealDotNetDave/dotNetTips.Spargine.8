// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2023
// ***********************************************************************
// <copyright file="RegionConverter.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json;
using System.Text.Json.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class RegionConverter.
/// Implements the <see cref="JsonConverter{Region}" />
/// </summary>
/// <seealso cref="JsonConverter{Region}" />
internal sealed class RegionConverter : JsonConverter<Region>
{

	/// <summary>
	/// Determines whether this instance can convert the specified t.
	/// </summary>
	/// <param name="t">The t.</param>
	/// <returns><c>true</c> if this instance can convert the specified t; otherwise, <c>false</c>.</returns>
	public override bool CanConvert(Type t) => t == typeof(Region);

	/// <summary>
	/// Reads and converts the JSON to type <see cref=" Region" />.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	/// <remarks>A converter may throw any Exception, but should throw <cref>JsonException</cref> when the JSON is invalid.</remarks>
	public override Region Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString();

		return value switch
		{
			"Africa" => Region.Africa,
			"Americas" => Region.Americas,
			"Asia" => Region.Asia,
			"Europe" => Region.Europe,
			"Oceania" => Region.Oceania,
			"Polar" => Region.Polar,
			_ => Region.Empty,
		};
	}

	/// <summary>
	/// Writes a specified value as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <exception cref="Exception">Cannot marshal type Region</exception>
	/// <remarks>A converter may throw any Exception, but should throw <cref>JsonException</cref> when the JSON
	/// cannot be created.</remarks>
	public override void Write(Utf8JsonWriter writer, Region value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case Region.Africa:
				JsonSerializer.Serialize(writer, "Africa", options);
				return;
			case Region.Americas:
				JsonSerializer.Serialize(writer, "Americas", options);
				return;
			case Region.Asia:
				JsonSerializer.Serialize(writer, "Asia", options);
				return;
			case Region.Europe:
				JsonSerializer.Serialize(writer, "Europe", options);
				return;
			case Region.Oceania:
				JsonSerializer.Serialize(writer, "Oceania", options);
				return;
			case Region.Polar:
				JsonSerializer.Serialize(writer, "Polar", options);
				return;
			case Region.Empty:
				JsonSerializer.Serialize(writer, string.Empty, options);
				break;
			default:
				JsonSerializer.Serialize(writer, string.Empty, options);
				break;
		}
	}

	/// <summary>
	/// The singleton
	/// </summary>
	public static readonly RegionConverter Singleton = new();

}
