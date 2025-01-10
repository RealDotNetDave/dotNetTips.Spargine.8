// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="Timezone.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data.Models;

/// <summary>
/// Represents information for a timezone, including its abbreviation, GMT offset, and names.
/// </summary>
[DataContract]
[Serializable]
public sealed class Timezone
{
	/// <summary>
	/// Gets or sets the abbreviation of the timezone.
	/// </summary>
	/// <value>The abbreviation of the timezone.</value>
	[DataMember(Name = "abbreviation")]
	[JsonPropertyName("abbreviation")]
	public string Abbreviation { get; set; }

	/// <summary>
	/// Gets the country associated with the timezone. This property is static and not serialized.
	/// </summary>
	/// <value>The country associated with the timezone.</value>
	[JsonIgnore]
	public static Country Country => default!;

	/// <summary>
	/// Gets or sets the GMT offset of the timezone.
	/// </summary>
	/// <value>The GMT offset of the timezone.</value>
	[DataMember(Name = "gmtOffset")]
	[JsonPropertyName("gmtOffset")]
	public long GmtOffset { get; set; }

	/// <summary>
	/// Gets or sets the name of the GMT offset.
	/// </summary>
	/// <value>The name of the GMT offset.</value>
	[DataMember(Name = "gmtOffsetName")]
	[JsonPropertyName("gmtOffsetName")]
	public string GmtOffsetName { get; set; }

	/// <summary>
	/// Gets or sets the timezone name.
	/// </summary>
	/// <value>The timezone name.</value>
	[DataMember(Name = "tzName")]
	[JsonPropertyName("tzName")]
	public string TzName { get; set; }

	/// <summary>
	/// Gets or sets the name of the zone.
	/// </summary>
	/// <value>The name of the zone.</value>
	[DataMember(Name = "zoneName")]
	[JsonPropertyName("zoneName")]
	public string ZoneName { get; set; }

}
