// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 05-26-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="StringType.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>String type for validating parameters/ values.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )







namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines string validation types.
/// </summary>
public enum StringType
{
	/// <summary>
	/// Indicates that the string type is not set.
	/// </summary>
	NotSet,

	/// <summary>
	/// Validates that the string is an email address.
	/// </summary>
	Email,

	/// <summary>
	/// Validates that the string is a URL.
	/// </summary>
	Url
}
