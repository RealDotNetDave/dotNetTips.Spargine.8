// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2024
// ***********************************************************************
// <copyright file="Region.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration for all the regions in the world.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )



namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Represents all the geographic regions in the world.
/// </summary>
public enum Region
{
	/// <summary>
	/// The African region.
	/// </summary>
	Africa,

	/// <summary>
	/// The Americas region, including both North and South America.
	/// </summary>
	Americas,

	/// <summary>
	/// The Asian region.
	/// </summary>
	Asia,

	/// <summary>
	/// Represents an undefined or unspecified region.
	/// </summary>
	Empty,

	/// <summary>
	/// The European region.
	/// </summary>
	Europe,

	/// <summary>
	/// The Oceania region, including Australasia, Melanesia, Micronesia, and Polynesia.
	/// </summary>
	Oceania,

	/// <summary>
	/// The Polar regions, including the Arctic and Antarctica.
	/// </summary>
	Polar
};
