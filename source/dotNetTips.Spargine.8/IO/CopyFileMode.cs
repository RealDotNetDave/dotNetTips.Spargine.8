// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 11-02-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2024
// ***********************************************************************
// <copyright file="CopyFileMode.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Copy File Mode values for CopyFileEx</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Defines copy file modes for use with CopyFileEx method.
/// </summary>
[Flags]
public enum CopyFileMode : uint
{
	/// <summary>
	/// The operation fails if the target file already exists.
	/// </summary>
	FailIfExists = 0x00000001,

	/// <summary>
	/// The copy operation is restartable.
	/// </summary>
	Restartable = 0x00000002,

	/// <summary>
	/// Opens the source file with write permissions.
	/// </summary>
	OpenSourceForWrite = 0x00000004,

	/// <summary>
	/// Allows the destination file to be decrypted.
	/// </summary>
	AllowDecryptedDestination = 0x00000008,

	/// <summary>
	/// Copies the symbolic link itself rather than the target of the link.
	/// </summary>
	CopySymlink = 0x00000800,

	/// <summary>
	/// Copies data to the target file without using the Windows cache manager.
	/// </summary>
	NoBuffering = 0x00001000
}

