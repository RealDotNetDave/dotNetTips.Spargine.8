// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2024
// ***********************************************************************
// <copyright file="IsoDateTimeOffsetConverter.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Converter tailored for IsoDateTimeOffset.</summary>
// ***********************************************************************

using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

#nullable enable
/// <summary>
/// Class IsoDateTimeOffsetConverter.
/// Implements the <see cref="JsonConverter{DateTimeOffset}" />
/// </summary>
/// <seealso cref="JsonConverter{DateTimeOffset}" />

internal sealed class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{

	/// <summary>
	/// The default date time format
	/// </summary>
	private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

	/// <summary>
	/// The culture
	/// </summary>
	private CultureInfo? _culture;

	/// <summary>
	/// The date time format
	/// </summary>
	private string? _dateTimeFormat;

	/// <summary>
	/// Determines whether this instance can convert the specified t.
	/// </summary>
	/// <param name="t">The t.</param>
	/// <returns><c>true</c> if this instance can convert the specified t; otherwise, <c>false</c>.</returns>
	public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

	/// <summary>
	/// Reads and converts the JSON to type <see cref="DateTimeOffset" />.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	/// <remarks>A converter may throw any Exception, but should throw <cref>JsonException</cref> when the JSON is invalid.</remarks>
	public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var dateText = reader.GetString();

		if (string.IsNullOrEmpty(dateText) is false)
		{
			if (!string.IsNullOrEmpty(this._dateTimeFormat))
			{
				return DateTimeOffset.ParseExact(dateText, this._dateTimeFormat, this.Culture, this.DateTimeStyles);
			}
			else
			{
				return DateTimeOffset.Parse(dateText, this.Culture, this.DateTimeStyles);
			}
		}
		else
		{
			return default;
		}
	}

	/// <summary>
	/// Writes a specified value as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <remarks>A converter may throw any Exception, but should throw <cref>JsonException</cref> when the JSON
	/// cannot be created.</remarks>
	public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
	{
		string text;

		if ((this.DateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
			|| (this.DateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
		{
			value = value.ToUniversalTime();
		}

		text = value.ToString(this._dateTimeFormat ?? DefaultDateTimeFormat, this.Culture);

		writer.WriteStringValue(text);
	}

	/// <summary>
	/// Gets or sets the culture.
	/// </summary>
	/// <value>The culture.</value>
	public CultureInfo Culture
	{
		get => this._culture ?? CultureInfo.CurrentCulture;
		set => this._culture = value;
	}

	/// <summary>
	/// Gets or sets the date time format.
	/// </summary>
	/// <value>The date time format.</value>
	public string? DateTimeFormat
	{
		get => this._dateTimeFormat ?? string.Empty;
		set => this._dateTimeFormat = string.IsNullOrEmpty(value) ? null : value;
	}

	/// <summary>
	/// Gets or sets the date time styles.
	/// </summary>
	/// <value>The date time styles.</value>
	public DateTimeStyles DateTimeStyles { get; set; } = DateTimeStyles.RoundtripKind;

	/// <summary>
	/// The singleton
	/// </summary>
	public static readonly IsoDateTimeOffsetConverter Singleton = new();

}
