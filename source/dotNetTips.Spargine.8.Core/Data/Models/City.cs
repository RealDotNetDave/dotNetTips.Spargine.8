// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="City.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data.Models;

/// <summary>
/// Represents a city with properties for identification and location coordinates.
/// </summary>
[DataContract] // Indicates that this class is part of a data contract for serialization.
public sealed class City
{

	/// <summary>
	/// Initializes a new instance of the <see cref="City"/> class.
	/// </summary>
	public City()
	{
	}

	/// <summary>
	/// Gets or sets the unique identifier for the city.
	/// </summary>
	/// <value>The city's unique identifier.</value>
	[DataMember(Name = "id")] // Specifies the name of the data member when the object is serialized.
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Gets or sets the latitude of the city.
	/// </summary>
	/// <value>The city's latitude.</value>
	[DataMember(Name = "latitude")] // Specifies the name of the data member when the object is serialized.
	[JsonPropertyName("latitude")]
	public string Latitude { get; set; }

	/// <summary>
	/// Gets or sets the longitude of the city.
	/// </summary>
	/// <value>The city's longitude.</value>
	[DataMember(Name = "longitude")] // Specifies the name of the data member when the object is serialized.
	[JsonPropertyName("longitude")]
	public string Longitude { get; set; }

	/// <summary>
	/// Gets or sets the name of the city.
	/// </summary>
	/// <value>The city's name.</value>
	[DataMember(Name = "name")] // Specifies the name of the data member when the object is serialized.
	[JsonPropertyName("name")]
	public string Name { get; set; }

}
