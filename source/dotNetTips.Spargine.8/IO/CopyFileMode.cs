// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 11-02-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2024
// ***********************************************************************
// <copyright file="CopyFileMode.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Copy File Mode values for CopyFileEx</summary>
// ***********************************************************************


namespace DotNetTips.Spargine.IO;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

/// <summary>
/// Enum CopyFileMode
/// </summary>
[Flags]
public enum CopyFileMode : uint
{
	/// <summary>
	/// The fail if exists
	/// </summary>
	FailIfExists = 0x00000001,

	/// <summary>
	/// The restartable
	/// </summary>
	Restartable = 0x00000002,

	/// <summary>
	/// The open source for write
	/// </summary>
	OpenSourceForWrite = 0x00000004,

	/// <summary>
	/// The allow decrypted destination
	/// </summary>
	AllowDecryptedDestination = 0x00000008,

	/// <summary>
	/// The copy symlink
	/// </summary>
	CopySymlink = 0x00000800,

	/// <summary>
	/// The no buffering
	/// </summary>
	NoBuffering = 0x00001000
}

