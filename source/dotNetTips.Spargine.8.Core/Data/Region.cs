// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="Region.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace DotNetTips.Spargine.Core.Data;

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
