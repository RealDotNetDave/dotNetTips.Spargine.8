// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2023
// ***********************************************************************
// <copyright file="ServiceActionResult.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine;

/// <summary>
/// Enum ServiceActionResult.
/// </summary>
public enum ServiceActionResult
{
	/// <summary>
	/// The not found
	/// </summary>
	NotFound,

	/// <summary>
	/// The running
	/// </summary>
	Running,

	/// <summary>
	/// The stopped
	/// </summary>
	Stopped,

	/// <summary>
	/// The error
	/// </summary>
	Error,
}
