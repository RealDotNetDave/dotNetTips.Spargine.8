// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2024
// ***********************************************************************
// <copyright file="IsoDateTimeOffsetConverter.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Converter tailored for IsoDateTimeOffset.</summary>
// ***********************************************************************

using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

#nullable enable
/// <summary>
/// Provides a custom JSON converter for <see cref="DateTimeOffset"/> objects, allowing for serialization and deserialization
/// with specific formats and cultural settings.
/// </summary>
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
	/// Determines whether this instance can convert the specified type.
	/// </summary>
	/// <param name="t">The type to check for conversion capability.</param>
	/// <returns><c>true</c> if this instance can convert the specified type; otherwise, <c>false</c>.</returns>
	public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

	/// <summary>
	/// Reads and converts the JSON to a <see cref="DateTimeOffset"/>.
	/// </summary>
	/// <param name="reader">The reader to read from.</param>
	/// <param name="typeToConvert">The type to convert. Should be <see cref="DateTimeOffset"/>.</param>
	/// <param name="options">Serialization options to use.</param>
	/// <returns>The converted <see cref="DateTimeOffset"/> value.</returns>
	/// <exception cref="JsonException">Thrown when the JSON is invalid or cannot be converted to <see cref="DateTimeOffset"/>.</exception>
	public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var dateText = reader.GetString();

		if (!string.IsNullOrEmpty(dateText))
		{
			try
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
			catch (FormatException e)
			{
				ExceptionThrower.ThrowJsonException($"Unable to convert \"{dateText}\" to DateTimeOffset.", e);
			}
		}
		else
		{
			ExceptionThrower.ThrowJsonException("Date text is null or empty.");
		}

		return default;
	}

	/// <summary>
	/// Writes the specified <see cref="DateTimeOffset"/> value as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The <see cref="DateTimeOffset"/> value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <exception cref="ArgumentNullException">Thrown if the writer is null.</exception>
	public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
	{
		writer = writer.ArgumentNotNull();

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
	/// Gets or sets the culture used for parsing and formatting <see cref="DateTimeOffset"/> values.
	/// </summary>
	/// <value>The culture information to use. If not set, the current culture is used.</value>
	public CultureInfo Culture
	{
		get => this._culture ?? CultureInfo.CurrentCulture;
		set => this._culture = value;
	}

	/// <summary>
	/// Gets or sets the date and time format used for parsing and formatting <see cref="DateTimeOffset"/> values.
	/// </summary>
	/// <value>The date and time format string. If not set, an empty string is returned, indicating the default format should be used.</value>
	public string? DateTimeFormat
	{
		get => this._dateTimeFormat ?? string.Empty;
		set => this._dateTimeFormat = string.IsNullOrEmpty(value) ? null : value;
	}

	/// <summary>
	/// Gets or sets the <see cref="DateTimeStyles"/> options used for parsing <see cref="DateTimeOffset"/> values.
	/// </summary>
	/// <value>The <see cref="DateTimeStyles"/> options that define the formatting options. The default is <see cref="DateTimeStyles.RoundtripKind"/>.</value>
	public DateTimeStyles DateTimeStyles { get; set; } = DateTimeStyles.RoundtripKind;

	/// <summary>
	/// Provides a singleton instance of the <see cref="IsoDateTimeOffsetConverter"/> for reuse across the application.
	/// This ensures that only one instance of the converter is created and used, which can improve performance and memory usage.
	/// </summary>
	public static readonly IsoDateTimeOffsetConverter Singleton = new();

}
