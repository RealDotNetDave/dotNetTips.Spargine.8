// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-06-2023
// ***********************************************************************
// <copyright file="CopyProgressResult.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for working with files.</summary>
// ***********************************************************************

namespace DotNetTips.Spargine.IO;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

/// <summary>
/// Enum CopyProgressResult
/// </summary>
public enum CopyProgressResult : uint
{
	/// <summary>
	/// The continue
	/// </summary>
	Continue = 0,

	/// <summary>
	/// The cancel
	/// </summary>
	Cancel = 1,

	/// <summary>
	/// The stop
	/// </summary>
	Stop = 2,

	/// <summary>
	/// The quiet
	/// </summary>
	Quiet = 3
}

