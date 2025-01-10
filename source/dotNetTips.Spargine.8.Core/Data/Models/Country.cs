// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="Country.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data.Models;

/// <summary>
/// Represents detailed information about a country, including its name, capital, currency, and geographical data.
/// </summary>
[DataContract]
[Serializable]
public sealed class Country
{

	/// <summary>
	/// Gets or sets the capital city of the country.
	/// </summary>
	/// <value>The capital city. Defaults to "UNKNOWN" if not set.</value>
	[DataMember(Name = "capital")]
	[JsonPropertyName("capital")]
	public string Capital { get; set; } = "UNKNOWN";

	/// <summary>
	/// Gets or sets the currency used by the country.
	/// </summary>
	/// <value>The currency code, such as "USD" for the United States Dollar.</value>
	[DataMember(Name = "currency")]
	[JsonPropertyName("currency")]
	public string Currency { get; set; }

	/// <summary>
	/// Gets or sets the name of the currency used by the country.
	/// </summary>
	/// <value>The name of the currency, such as "United States Dollar" for USD.</value>
	[DataMember(Name = "currency_name")]
	[JsonPropertyName("currency_name")]
	public string CurrencyName { get; set; }

	/// <summary>
	/// Gets or sets the currency symbol used by the country.
	/// </summary>
	/// <value>The currency symbol, such as "$" for the United States Dollar.</value>
	[DataMember(Name = "currency_symbol")]
	[JsonPropertyName("currency_symbol")]
	public string CurrencySymbol { get; set; }

	/// <summary>
	/// Gets or sets the emoji representing the country.
	/// </summary>
	/// <value>The emoji symbol, such as "🇺🇸" for the United States.</value>
	[DataMember(Name = "emoji")]
	[JsonPropertyName("emoji")]
	public string Emoji { get; set; }

	/// <summary>
	/// Gets or sets the Unicode representation of the country's emoji.
	/// </summary>
	/// <value>The Unicode string for the emoji, such as "U+1F1FA U+1F1F8" for the United States.</value>
	[DataMember(Name = "emojiU")]
	[JsonPropertyName("emojiU")]
	public string EmojiU { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier for the country.
	/// </summary>
	/// <value>The unique identifier.</value>
	[DataMember(Name = "id")]
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Gets or sets the two-letter ISO 3166-1 alpha-2 country code.
	/// </summary>
	/// <value>The two-letter country code.</value>
	[DataMember(Name = "iso2")]
	[JsonPropertyName("iso2")]
	public string Iso2 { get; set; }

	/// <summary>
	/// Gets or sets the three-letter ISO 3166-1 alpha-3 country code.
	/// </summary>
	/// <value>The three-letter country code.</value>
	[DataMember(Name = "iso3")]
	[JsonPropertyName("iso3")]
	public string Iso3 { get; set; }

	/// <summary>
	/// Gets or sets the latitude of the country's geographical location.
	/// </summary>
	/// <value>The latitude in decimal degrees.</value>
	[DataMember(Name = "latitude")]
	[JsonPropertyName("latitude")]
	public string Latitude { get; set; }

	/// <summary>
	/// Gets or sets the longitude of the country's geographical location.
	/// </summary>
	/// <value>The longitude in decimal degrees.</value>
	[DataMember(Name = "longitude")]
	[JsonPropertyName("longitude")]
	public string Longitude { get; set; }

	/// <summary>
	/// Gets or sets the name of the country.
	/// </summary>
	/// <value>The name of the country.</value>
	[DataMember(Name = "name")]
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Gets or sets the native name of the country.
	/// </summary>
	/// <value>The native name of the country.</value>
	[DataMember(Name = "native")]
	[JsonPropertyName("native")]
	public string Native { get; set; }

	/// <summary>
	/// Gets or sets the numeric code of the country.
	/// </summary>
	/// <value>The numeric code as defined by ISO 3166-1 numeric.</value>
	[DataMember(Name = "numeric_code")]
	[JsonPropertyName("numeric_code")]
	public string NumericCode { get; set; }

	/// <summary>
	/// Gets or sets the phone code of the country.
	/// </summary>
	/// <value>The international dialing code, such as "+1" for the United States.</value>
	[DataMember(Name = "phone_code")]
	[JsonPropertyName("phone_code")]
	public string PhoneCode { get; set; }

	/// <summary>
	/// Gets or sets the length of the phone number.
	/// </summary>
	/// <value>The length of the phone number, defaulting to 10.</value>
	[DataMember(Name = "phone_length")]
	[JsonPropertyName("phone_length")]
	public int PhoneNumberLength { get; set; } = 10;

	/// <summary>
	/// Gets or sets the postal format used by the country.
	/// </summary>
	/// <value>The postal format, such as specific patterns or codes used in the country's mailing system.</value>
	[DataMember(Name = "postalFormat")]
	[JsonPropertyName("postalFormat")]
	public string PostalFormat { get; set; }

	/// <summary>
	/// Gets or sets the regular expression pattern used to validate postal codes for the country.
	/// </summary>
	/// <value>The regular expression pattern for postal code validation.</value>
	[DataMember(Name = "postalRegex")]
	[JsonPropertyName("postalRegex")]
	public string PostalRegex { get; set; }

	/// <summary>
	/// Gets or sets the geographical region where the country is located.
	/// </summary>
	/// <value>The geographical region, such as "Europe" or "Asia".</value>
	[DataMember(Name = "region")]
	[JsonPropertyName("region")]
	public Region Region { get; set; }

	/// <summary>
	/// Gets or sets the states within the country.
	/// </summary>
	/// <value>The states of the country.</value>
	[MaybeNull]
	[JsonPropertyName("states")]
	[DataMember(Name = "states")]
	public State[] States { get; set; }

	/// <summary>
	/// Gets or sets the subregion where the country is located, which is a smaller part of the geographical region.
	/// </summary>
	/// <value>The subregion of the country.</value>
	[DataMember(Name = "subregion")]
	[JsonPropertyName("subregion")]
	public string Subregion { get; set; }

	/// <summary>
	/// Gets or sets the timezones associated with the country.
	/// </summary>
	/// <value>The timezones in which the country is located.</value>
	[DataMember(Name = "timezones")]
	[JsonPropertyName("timezones")]
	[MaybeNull]
	public Timezone[] Timezones { get; set; }

	/// <summary>
	/// Gets or sets the Top-Level Domain (TLD) of the country.
	/// </summary>
	/// <value>The TLD, such as ".us" for the United States.</value>
	[DataMember(Name = "tld")]
	[JsonPropertyName("tld")]
	public string Tld { get; set; }

	/// <summary>
	/// Gets or sets the translations for the country's name.
	/// </summary>
	/// <value>The translations of the country's name into various languages.</value>
	[MaybeNull]
	[JsonPropertyName("translations")]
	[DataMember(Name = "translations")]
	public Translations Translations { get; set; }

}
