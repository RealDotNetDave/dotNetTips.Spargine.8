// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-20-2023
//
// Last Modified By : David McCarter
// Last Modified On : 11-06-2023
// ***********************************************************************
// <copyright file="ProcessorArchitecture.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

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