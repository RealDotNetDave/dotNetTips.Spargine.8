// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2024
// ***********************************************************************
// <copyright file="DateOnlyConverter.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json;
using System.Text.Json.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class DateOnlyConverter.
/// Implements the <see cref="JsonConverter{DateOnly}" />
/// </summary>
/// <seealso cref="JsonConverter{DateOnly}" />
/// <param name="serializationFormat">The serialization format.</param>
/// <remarks>Initializes a new instance of the <see cref="DateOnlyConverter" /> class.</remarks>
#nullable enable
public class DateOnlyConverter(string? serializationFormat) : JsonConverter<DateOnly>
{

	/// <summary>
	/// The serialization format
	/// </summary>
	private readonly string _serializationFormat = serializationFormat ?? "yyyy-MM-dd";

	/// <summary>
	/// Initializes a new instance of the <see cref="DateOnlyConverter" /> class.
	/// </summary>
	public DateOnlyConverter() : this(null) { }

	/// <summary>
	/// Reads and converts the JSON to type <see cref="DateOnly" />.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	/// <remarks>A converter may throw any Exception, but should throw <cref>JsonException</cref> when the JSON is invalid.</remarks>
	public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString();
		return DateOnly.Parse(value!, IsoDateTimeOffsetConverter.Singleton.Culture);
	}

	/// <summary>
	/// Writes a specified value as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <remarks>A converter may throw any Exception, but should throw <cref>JsonException</cref> when the JSON
	/// cannot be created.</remarks>
	public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options) => writer?.WriteStringValue(value.ToString(this._serializationFormat, IsoDateTimeOffsetConverter.Singleton.Culture));

}