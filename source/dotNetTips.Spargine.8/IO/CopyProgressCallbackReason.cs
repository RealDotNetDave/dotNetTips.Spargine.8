// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2024
// ***********************************************************************
// <copyright file="CopyProgressCallbackReason.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for working with files.</summary>
// ***********************************************************************

namespace DotNetTips.Spargine.IO;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

/// <summary>
/// Enum CopyProgressCallbackReason
/// </summary>
public enum CopyProgressCallbackReason : uint
{
	/// <summary>
	/// The chunk finished
	/// </summary>
	ChunkFinished = 0x00000000,

	/// <summary>
	/// The stream switch
	/// </summary>
	StreamSwitch = 0x00000001
}

