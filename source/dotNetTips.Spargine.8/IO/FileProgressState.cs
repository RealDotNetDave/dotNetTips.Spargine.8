// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-22-2025
// ***********************************************************************
// <copyright file="FileProgressState.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>File progress state values for FileProcessor.cs</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Enum FileProgressState
/// </summary>
/// <remarks>
/// Defines the possible states of a file operation, such as copying, moving, or deleting.
/// </remarks>
public enum FileProgressState
{
	//TODO: CHANGE ENUM TO IN V10 - DeletedFile, DeletedFolder, MovedFile, MovedFolder, CopiedFile, CopiedFolder

	/// <summary>
	/// Indicates an error occurred during the file operation.
	/// </summary>
	Error = 0,

	/// <summary>
	/// Indicates the file was successfully deleted.
	/// </summary>
	Deleted = 1,

	/// <summary>
	/// Indicates the file was successfully moved.
	/// </summary>
	Moved = 2,

	/// <summary>
	/// Indicates the file was successfully copied.
	/// </summary>
	Copied = 3,
}
