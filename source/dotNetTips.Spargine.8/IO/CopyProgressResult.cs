// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2024
// ***********************************************************************
// <copyright file="CopyProgressResult.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for working with files.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Defines the possible results for a copy progress callback function.
/// </summary>
/// <remarks>
/// This enum is typically used in conjunction with the CopyFileEx method to control the behavior of the file copy operation based on the progress.
/// </remarks>
public enum CopyProgressResult : uint
{
	/// <summary>
	/// Continue the copy operation.
	/// </summary>
	Continue = 0,

	/// <summary>
	/// Cancel the copy operation.
	/// </summary>
	Cancel = 1,

	/// <summary>
	/// Stop the copy operation. Unlike <see cref="Cancel"/>, stopping may allow for resuming at a later time.
	/// </summary>
	Stop = 2,

	/// <summary>
	/// Proceed with the copy operation but do not call the progress callback function.
	/// </summary>
	Quiet = 3
}

