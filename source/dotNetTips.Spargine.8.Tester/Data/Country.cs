// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 05-11-2024
// ***********************************************************************
// <copyright file="Country.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class that encapsulates information for a Country.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class Country.
/// </summary>
[Serializable]
public sealed class Country
{

	/// <summary>
	/// Gets or sets the capital.
	/// </summary>
	/// <value>The capital.</value>
	[JsonPropertyName("capital")]
	public string Capital { get; set; } = "UNKNOWN";

	/// <summary>
	/// Gets or sets the currency.
	/// </summary>
	/// <value>The currency.</value>
	[JsonPropertyName("currency")]
	public string Currency { get; set; }

	/// <summary>
	/// Gets or sets the name of the currency.
	/// </summary>
	/// <value>The name of the currency.</value>
	[JsonPropertyName("currency_name")]
	public string CurrencyName { get; set; }

	/// <summary>
	/// Gets or sets the currency symbol.
	/// </summary>
	/// <value>The currency symbol.</value>
	[JsonPropertyName("currency_symbol")]
	public string CurrencySymbol { get; set; }

	/// <summary>
	/// Gets or sets the emoji.
	/// </summary>
	/// <value>The emoji.</value>
	[JsonPropertyName("emoji")]
	public string Emoji { get; set; }

	/// <summary>
	/// Gets or sets the emoji u.
	/// </summary>
	/// <value>The emoji u.</value>
	[JsonPropertyName("emojiU")]
	public string EmojiU { get; set; }
	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Gets or sets the iso2.
	/// </summary>
	/// <value>The iso2.</value>
	[JsonPropertyName("iso2")]
	public string Iso2 { get; set; }

	/// <summary>
	/// Gets or sets the iso3.
	/// </summary>
	/// <value>The iso3.</value>
	[JsonPropertyName("iso3")]
	public string Iso3 { get; set; }

	/// <summary>
	/// Gets or sets the latitude.
	/// </summary>
	/// <value>The latitude.</value>
	[JsonPropertyName("latitude")]
	public string Latitude { get; set; }

	/// <summary>
	/// Gets or sets the longitude.
	/// </summary>
	/// <value>The longitude.</value>
	[JsonPropertyName("longitude")]
	public string Longitude { get; set; }

	/// <summary>
	/// Gets or sets the name.
	/// </summary>
	/// <value>The name.</value>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Gets or sets the native.
	/// </summary>
	/// <value>The native.</value>
	[JsonPropertyName("native")]
	public string Native { get; set; }

	/// <summary>
	/// Gets or sets the numeric code.
	/// </summary>
	/// <value>The numeric code.</value>
	[JsonPropertyName("numeric_code")]
	public string NumericCode { get; set; }

	/// <summary>
	/// Gets or sets the phone code.
	/// </summary>
	/// <value>The phone code.</value>
	[JsonPropertyName("phone_code")]
	public string PhoneCode { get; set; }

	/// <summary>
	/// Gets or sets the length of the phone number.
	/// </summary>
	/// <value>The length of the phone number.</value>
	[JsonPropertyName("phone_length")]
	public int PhoneNumberLength { get; set; } = 10;

	/// <summary>
	/// Gets or sets the postal format.
	/// </summary>
	/// <value>The postal format.</value>
	[JsonPropertyName("postalFormat")]
	public string PostalFormat { get; set; }

	/// <summary>
	/// Gets or sets the postal regex.
	/// </summary>
	/// <value>The postal regex.</value>
	[JsonPropertyName("postalRegex")]
	public string PostalRegex { get; set; }

	/// <summary>
	/// Gets or sets the region.
	/// </summary>
	/// <value>The region.</value>
	[JsonPropertyName("region")]
	public Region Region { get; set; }

	/// <summary>
	/// Gets or sets the states.
	/// </summary>
	/// <value>The states.</value>
	[JsonPropertyName("states")]
	[MaybeNull]
	public State[] States { get; set; }

	/// <summary>
	/// Gets or sets the subregion.
	/// </summary>
	/// <value>The subregion.</value>
	[JsonPropertyName("subregion")]
	public string Subregion { get; set; }

	/// <summary>
	/// Gets or sets the timezones.
	/// </summary>
	/// <value>The timezones.</value>
	[JsonPropertyName("timezones")]
	[MaybeNull]
	public Timezone[] Timezones { get; set; }

	/// <summary>
	/// Gets or sets the TLD.
	/// </summary>
	/// <value>The TLD.</value>
	[JsonPropertyName("tld")]
	public string Tld { get; set; }

	/// <summary>
	/// Gets or sets the translations.
	/// </summary>
	/// <value>The translations.</value>
	[MaybeNull]
	[JsonPropertyName("translations")]
	public Translations Translations { get; set; }

}
