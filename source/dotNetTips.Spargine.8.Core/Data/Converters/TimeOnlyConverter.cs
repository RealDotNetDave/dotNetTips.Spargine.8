// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="TimeOnlyConverter.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data.Converters;

#nullable enable
/// <summary>
/// Provides a JSON converter for the <see cref="TimeOnly"/> type, allowing for custom serialization and deserialization.
/// </summary>
public class TimeOnlyConverter(string? serializationFormat) : JsonConverter<TimeOnly>
{

	/// <summary>
	/// The serialization format
	/// </summary>
	private readonly string _serializationFormat = serializationFormat ?? "HH:mm:ss.fff";

	/// <summary>
	/// Initializes a new instance of the <see cref="TimeOnlyConverter"/> class with the default serialization format.
	/// </summary>
	public TimeOnlyConverter() : this(null) { }

	/// <summary>
	/// Reads and converts the JSON to type <see cref="TimeOnly"/>.
	/// </summary>
	/// <param name="reader">The reader from which to read the JSON.</param>
	/// <param name="typeToConvert">The type to convert. While this parameter is part of the method signature, it is not used in this method because the type is known (<see cref="TimeOnly"/>).</param>
	/// <param name="options">The serialization options to use. Options are not used in this method, but they could be considered for future enhancements or to adhere to method signature requirements.</param>
	/// <returns>The converted <see cref="TimeOnly"/> value.</returns>
	/// <exception cref="JsonException">Thrown when the JSON is invalid or cannot be converted to a <see cref="TimeOnly"/> value.</exception>
	/// <remarks>
	/// This method attempts to parse a <see cref="TimeOnly"/> value from the JSON string. It uses the IsoDateTimeOffsetConverter.Singleton.Culture for parsing.
	/// If the JSON string cannot be parsed, a <see cref="JsonException"/> is thrown.
	/// </remarks>
	public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString() ?? throw new JsonException("The JSON value is null or not a valid TimeOnly representation.");

		try
		{
			return TimeOnly.Parse(value, IsoDateTimeOffsetConverter.Singleton.Culture);
		}
		catch (FormatException e)
		{
			ExceptionThrower.ThrowJsonException($"The JSON value '{value}' cannot be parsed as a TimeOnly.", e);
		}

		return default;
	}

	/// <summary>
	/// Writes the specified <see cref="TimeOnly"/> value as JSON.
	/// </summary>
	/// <param name="writer">The writer to which the JSON is written.</param>
	/// <param name="value">The <see cref="TimeOnly"/> value to convert to JSON.</param>
	/// <param name="options">The serialization options to use. This parameter is not used in this method, but it is part of the method signature for custom converters.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="writer"/> is null.</exception>
	/// <remarks>
	/// This method converts the <see cref="TimeOnly"/> value to its string representation using the specified serialization format
	/// and writes it as a JSON string value. It uses IsoDateTimeOffsetConverter.Singleton.Culture for formatting.
	/// </remarks>
	public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
	{
		writer = writer.ArgumentNotNull();

		writer.WriteStringValue(value.ToString(this._serializationFormat, IsoDateTimeOffsetConverter.Singleton.Culture));
	}

}
