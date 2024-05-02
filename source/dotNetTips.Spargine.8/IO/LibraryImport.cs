// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 04-29-2024
// ***********************************************************************
// <copyright file="LibraryImport.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>API Calls</summary>
// ***********************************************************************

using System.Runtime.InteropServices;
using static DotNetTips.Spargine.IO.FileHelper;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Class LibraryImport.
/// </summary>
internal static partial class LibraryImport
{

	/// <summary>
	/// Copies the file ex.
	/// </summary>
	/// <param name="lpExistingFileName">Name of the lp existing file.</param>
	/// <param name="lpNewFileName">Name of the lp new file.</param>
	/// <param name="lpProgressRoutine">The lp progress routine.</param>
	/// <param name="lpData">The lp data.</param>
	/// <param name="pbCancel">The pb cancel.</param>
	/// <param name="dwCopyFlags">The dw copy flags.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[LibraryImport("kernel32.dll", EntryPoint = "CopyFileExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static partial bool CopyFileEx(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref int pbCancel, CopyFileMode dwCopyFlags);

	/// <summary>
	/// Moves the file.
	/// </summary>
	/// <param name="lpExistingFileName">Name of the lp existing file.</param>
	/// <param name="lpNewFileName">Name of the lp new file.</param>
	/// <param name="dwFlags">The dw flags.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[LibraryImport("kernel32.dll", EntryPoint = "MoveFileExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static partial bool MoveFileExW(string lpExistingFileName, string lpNewFileName, int dwFlags);

}
