// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 05-11-2024
// ***********************************************************************
// <copyright file="State.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class that encapsulates information for a State.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class State.
/// </summary>
public sealed class State
{

	/// <summary>
	/// Gets or sets the cities.
	/// </summary>
	/// <value>The cities.</value>
	[MaybeNull]
	[JsonPropertyName("cities")]
	public City[] Cities { get; set; }

	/// <summary>
	/// Gets or sets the country.
	/// </summary>
	/// <value>The country.</value>
	public static Country Country
	{
		get => default!;
		set
		{
		}
	}
	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	[JsonPropertyName("id")]
	public long Id { get; set; }

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
	/// Gets or sets the state code.
	/// </summary>
	/// <value>The state code.</value>
	[JsonPropertyName("state_code")]
	public string StateCode { get; set; }

	/// <summary>
	/// Gets or sets the type.
	/// </summary>
	/// <value>The type.</value>
	[JsonPropertyName("type")]
	public string Type { get; set; }

}
