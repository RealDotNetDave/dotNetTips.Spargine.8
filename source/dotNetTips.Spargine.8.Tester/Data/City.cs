// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2023
// ***********************************************************************
// <copyright file="City.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class City.
/// </summary>
public sealed class City
{

	/// <summary>
	/// Initializes a new instance of the <see cref="City" /> class.
	/// </summary>
	public City()
	{
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

}