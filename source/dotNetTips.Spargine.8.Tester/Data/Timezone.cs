// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2023
// ***********************************************************************
// <copyright file="Timezone.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class Timezone.
/// </summary>
public sealed class Timezone
{

	/// <summary>
	/// Gets or sets the abbreviation.
	/// </summary>
	/// <value>The abbreviation.</value>
	[JsonPropertyName("abbreviation")]
	public string Abbreviation { get; set; }

	/// <summary>
	/// Gets the country.
	/// </summary>
	/// <value>The country.</value>
	public static Country Country => default!;

	/// <summary>
	/// Gets or sets the GMT offset.
	/// </summary>
	/// <value>The GMT offset.</value>
	[JsonPropertyName("gmtOffset")]
	public long GmtOffset { get; set; }

	/// <summary>
	/// Gets or sets the name of the GMT offset.
	/// </summary>
	/// <value>The name of the GMT offset.</value>
	[JsonPropertyName("gmtOffsetName")]
	public string GmtOffsetName { get; set; }

	/// <summary>
	/// Gets or sets the name of the tz.
	/// </summary>
	/// <value>The name of the tz.</value>
	[JsonPropertyName("tzName")]
	public string TzName { get; set; }
	/// <summary>
	/// Gets or sets the name of the zone.
	/// </summary>
	/// <value>The name of the zone.</value>
	[JsonPropertyName("zoneName")]
	public string ZoneName { get; set; }

}