// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 10-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-07-2023
// ***********************************************************************
// <copyright file="HashType.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enum used in ComputeHash methods.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Enum for HashType
/// </summary>
public enum HashType
{
	/// <summary>
	/// SHA256 hash
	/// </summary>
	SHA256,

	/// <summary>
	/// SHA384 hash
	/// </summary>
	SHA384,

	/// <summary>
	/// SHA512 hash
	/// </summary>
	SHA512
}
