// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-20-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2024
// ***********************************************************************
// <copyright file="ProcessorArchitecture.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration to indicate the type of processor being used
// by the computer.
// </summary>
// ***********************************************************************


namespace DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

/// <summary>
/// Enum ProcessorArchitecture
/// </summary>
public enum ProcessorArchitecture
{
	/// <summary>
	/// Intel
	/// </summary>
	Intel = 0,

	/// <summary>
	/// Arm
	/// </summary>
	Arm = 5,

	/// <summary>
	/// IA64
	/// </summary>
	IA64 = 6,

	/// <summary>
	/// AMD64
	/// </summary>
	AMD64 = 9,

	/// <summary>
	/// ARM64
	/// </summary>
	ARM64 = 12,

	/// <summary>
	/// Unknown architecture
	/// </summary>
	Unknown = 0xFFFF
}
