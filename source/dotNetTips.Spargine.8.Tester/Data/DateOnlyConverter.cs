// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2024
// ***********************************************************************
// <copyright file="DateOnlyConverter.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Converter tailored for DateOnly.</summary>
// ***********************************************************************

using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Initializes a new instance of the <see cref="DateOnlyConverter"/> class with an optional serialization format.
/// </summary>
/// <param name="serializationFormat">The serialization format to use for <see cref="DateOnly"/> values. If null, defaults to "yyyy-MM-dd".</param>
#nullable enable
public class DateOnlyConverter(string? serializationFormat) : JsonConverter<DateOnly>
{

	/// <summary>
	/// The serialization format
	/// </summary>
	private readonly string _serializationFormat = serializationFormat ?? "yyyy-MM-dd";

	/// <summary>
	/// Initializes a new instance of the <see cref="DateOnlyConverter"/> class with the default serialization format.
	/// </summary>
	public DateOnlyConverter() : this(null) { }

	/// <summary>
	/// Reads and converts the JSON to type <see cref="DateOnly"/>.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	/// <exception cref="JsonException">Thrown when the JSON is invalid or cannot be converted to <see cref="DateOnly"/>.</exception>
	public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString();
		try
		{
			return DateOnly.Parse(value!, IsoDateTimeOffsetConverter.Singleton.Culture);
		}
		catch (FormatException e)
		{
			ExceptionThrower.ThrowJsonException("Invalid date format.", e);
		}

		return default;
	}

	/// <summary>
	/// Writes the <see cref="DateOnly"/> value as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The <see cref="DateOnly"/> value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <exception cref="ArgumentNullException">Thrown if the writer is null.</exception>
	public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
	{
		writer = writer.ArgumentNotNull();

		writer.WriteStringValue(value.ToString(this._serializationFormat, IsoDateTimeOffsetConverter.Singleton.Culture));
	}

}
