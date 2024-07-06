// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-20-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="ProcessorArchitecture.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Enumeration to indicate the type of processor being used
// by the computer.
// </summary>
// ***********************************************************************




namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines processor architectures.
/// </summary>
public enum ProcessorArchitecture
{
	/// <summary>
	/// The Intel x86 processor architecture.
	/// </summary>
	Intel = 0,

	/// <summary>
	/// The ARM processor architecture.
	/// </summary>
	Arm = 5,

	/// <summary>
	/// The Intel Itanium (IA64) processor architecture.
	/// </summary>
	IA64 = 6,

	/// <summary>
	/// The AMD x64 (AMD64) processor architecture.
	/// </summary>
	AMD64 = 9,

	/// <summary>
	/// The ARM64 processor architecture.
	/// </summary>
	ARM64 = 12,

	/// <summary>
	/// An unknown processor architecture.
	/// </summary>
	Unknown = 0xFFFF
}
