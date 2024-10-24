// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2024
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
/// Represents information for a state, including its cities, country, geographic coordinates, and other details.
/// </summary>
[Serializable]
public sealed class State
{

	/// <summary>
	/// Gets or sets the cities within the state.
	/// </summary>
	/// <value>The cities.</value>
	[MaybeNull]
	[JsonPropertyName("cities")]
	public City[] Cities { get; set; }

	/// <summary>
	/// Gets or sets the country that all instances of the state belong to.
	/// </summary>
	/// <value>The country the state belongs to.</value>
	/// <remarks>
	/// This property is static, implying all instances of <see cref="State"/> are considered to belong to the same country.
	/// If your application requires each state to belong to a different country, consider redesigning this property to be an instance property.
	/// </remarks>
	[JsonPropertyName("country")]
	public static Country Country { get; set; }

	/// <summary>
	/// Gets or sets the identifier for the state.
	/// </summary>
	/// <value>The identifier.</value>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Gets or sets the latitude of the state.
	/// </summary>
	/// <value>The latitude.</value>
	[JsonPropertyName("latitude")]
	public string Latitude { get; set; }

	/// <summary>
	/// Gets or sets the longitude of the state.
	/// </summary>
	/// <value>The longitude.</value>
	[JsonPropertyName("longitude")]
	public string Longitude { get; set; }

	/// <summary>
	/// Gets or sets the name of the state.
	/// </summary>
	/// <value>The name of the state.</value>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Gets or sets the state code.
	/// </summary>
	/// <value>The state code.</value>
	[JsonPropertyName("state_code")]
	public string StateCode { get; set; }

	/// <summary>
	/// Gets or sets the type of the state.
	/// </summary>
	/// <value>The type of the state.</value>
	[JsonPropertyName("type")]
	public string Type { get; set; }

}
