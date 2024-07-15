// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2023
// ***********************************************************************
// <copyright file="TimeOnlyConverter.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Converter tailored for TimeOnly.</summary>
// ***********************************************************************

using System.Text.Json;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

#nullable enable
/// <summary>
/// Class TimeOnlyConverter.
/// Implements the <see cref="JsonConverter{TimeOnly}" />
/// </summary>
/// <seealso cref="JsonConverter{TimeOnly}" />
/// <param name="serializationFormat">The serialization format.</param>
/// <remarks>Initializes a new instance of the <see cref="TimeOnlyConverter" /> class.</remarks>
public class TimeOnlyConverter(string? serializationFormat) : JsonConverter<TimeOnly>
{

	/// <summary>
	/// The serialization format
	/// </summary>
	private readonly string _serializationFormat = serializationFormat ?? "HH:mm:ss.fff";

	/// <summary>
	/// Initializes a new instance of the <see cref="TimeOnlyConverter" /> class.
	/// </summary>
	public TimeOnlyConverter() : this(null) { }

	/// <summary>
	/// Reads and converts the JSON to type <see cref="TimeOnly" />.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	/// <remarks>A converter may throw any Exception, but should throw <cref>JsonException</cref> when the JSON is invalid.</remarks>
	public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString();
		return TimeOnly.Parse(value!, IsoDateTimeOffsetConverter.Singleton.Culture);
	}

	/// <summary>
	/// Writes a specified value as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <remarks>A converter may throw any Exception, but should throw <cref>JsonException</cref> when the JSON
	/// cannot be created.</remarks>
	public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options) => writer?.WriteStringValue(value.ToString(this._serializationFormat, IsoDateTimeOffsetConverter.Singleton.Culture));

}
