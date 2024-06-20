// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 04-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="FileMoveOptions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>File move options for the FileMove method.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )




namespace DotNetTips.Spargine.IO;

/// <summary>
/// Defines options for the <see cref="FileHelper.MoveFile(FileInfo, FileInfo, FileMoveOptions, int)"/> method.
/// </summary>
[Flags]
public enum FileMoveOptions
{
	/// <summary>
	/// No additional options specified. The move is performed using default behavior.
	/// </summary>
	None = 0,

	/// <summary>
	/// If the destination file exists, replaces its contents with the contents of the source file.
	/// This option requires that security requirements regarding access control lists (ACLs) are met.
	/// </summary>
	ReplaceExisting = 1,

	/// <summary>
	/// Allows the file to be moved to a different volume. If the file is successfully copied but the original
	/// cannot be deleted, the operation still succeeds, leaving the source file intact.
	/// This option cannot be used with <see cref="DelayUntilReboot"/>.
	/// </summary>
	CopyAllowed = 2,

	/// <summary>
	/// Delays moving the file until the next system restart. This option is useful for replacing files
	/// that are in use by the system. Cannot be used with <see cref="CopyAllowed"/>.
	/// </summary>
	DelayUntilReboot = 4,

	/// <summary>
	/// Fails the move operation if the source file is a link source and cannot be tracked after the move.
	/// This can occur if the destination is on a volume formatted with the FAT file system.
	/// </summary>
	FailIfNotTrackable = 32,

	/// <summary>
	/// Ensures that the move operation is flushed to disk before returning. This option is useful to ensure
	/// that a move performed as a copy and delete operation is physically completed on the disk.
	/// </summary>
	WriteThrough = 8,
}
