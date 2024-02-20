// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2023
// ***********************************************************************
// <copyright file="FileProgressState.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>File progress state values for FileProcessor.cs</summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


namespace DotNetTips.Spargine.IO;

/// <summary>
/// Enum FileProgressState
/// </summary>
public enum FileProgressState
{
	/// <summary>
	/// The error
	/// </summary>
	Error = 0,

	/// <summary>
	/// The deleted
	/// </summary>
	Deleted = 1,

	/// <summary>
	/// The moved
	/// </summary>
	Moved = 2,

	/// <summary>
	/// The copied
	/// </summary>
	Copied = 3,
}
