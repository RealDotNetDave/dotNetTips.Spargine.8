// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2025
// ***********************************************************************
// <copyright file="State.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data.Models;

/// <summary>
/// Represents information for a state, including its cities, country, geographic coordinates, and other details.
/// </summary>
[DataContract]
[Serializable]
public sealed class State
{
	private Collection<City> _cities;

	/// <summary>
	/// Gets or sets the cities within the state.
	/// </summary>
	/// <value>The cities.</value>
	[DataMember(Name = "cities")]
	[MaybeNull]
	[JsonPropertyName("cities")]
	public Collection<City> Cities
	{
		get => this._cities ??= [];
		set => this._cities = value;
	}

	/// <summary>
	/// Gets or sets the country that all instances of the state belong to.
	/// </summary>
	/// <value>The country the state belongs to.</value>
	/// <remarks>
	/// This property is static, implying all instances of <see cref="State"/> are considered to belong to the same country.
	/// If your application requires each state to belong to a different country, consider redesigning this property to be an instance property.
	/// </remarks>
	[DataMember(Name = "country")]
	[JsonPropertyName("country")]
	public static Country Country { get; set; }

	/// <summary>
	/// Gets or sets the identifier for the state.
	/// </summary>
	/// <value>The identifier.</value>
	[DataMember(Name = "id")]
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Gets or sets the latitude of the state.
	/// </summary>
	/// <value>The latitude.</value>
	[DataMember(Name = "latitude")]
	[JsonPropertyName("latitude")]
	public string Latitude { get; set; }

	/// <summary>
	/// Gets or sets the longitude of the state.
	/// </summary>
	/// <value>The longitude.</value>
	[DataMember(Name = "longitude")]
	[JsonPropertyName("longitude")]
	public string Longitude { get; set; }

	/// <summary>
	/// Gets or sets the name of the state.
	/// </summary>
	/// <value>The name of the state.</value>
	[DataMember(Name = "name")]
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Gets or sets the state code.
	/// </summary>
	/// <value>The state code.</value>
	[DataMember(Name = "state_code")]
	[JsonPropertyName("state_code")]
	public string StateCode { get; set; }

	/// <summary>
	/// Gets or sets the type of the state.
	/// </summary>
	/// <value>The type of the state.</value>
	[DataMember(Name = "type")]
	[JsonPropertyName("type")]
	public string Type { get; set; }

}
