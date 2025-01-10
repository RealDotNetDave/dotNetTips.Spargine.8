// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="PostalCodeState.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data;

/// <summary>
/// Represents the state of a postal code validation.
/// </summary>
public enum PostalCodeState
{
	/// <summary>
	/// The postal code is invalid.
	/// </summary>
	Invalid,

	/// <summary>
	/// The postal code state is unknown.
	/// </summary>
	Unknown,

	/// <summary>
	/// The postal code is valid.
	/// </summary>
	Valid,
}
