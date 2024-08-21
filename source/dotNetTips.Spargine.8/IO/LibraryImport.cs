// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="LibraryImport.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>API Calls</summary>
// ***********************************************************************

using System.Runtime.InteropServices;
using static DotNetTips.Spargine.IO.FileHelper;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides P/Invoke method signatures for Windows API calls.
/// </summary>
/// <remarks>
/// This class contains methods that are used to invoke native system calls from the Windows Kernel32.dll.
/// The methods within are used for file operations such as copying and moving files with advanced options not available through managed code.
/// </remarks>
internal static partial class LibraryImport
{

	/// <summary>
	/// Copies an existing file to a new file, notifying the application of its progress through a callback function.
	/// </summary>
	/// <param name="lpExistingFileName">The name of the existing file.</param>
	/// <param name="lpNewFileName">The name of the new file.</param>
	/// <param name="lpProgressRoutine">A callback function that is called each time another portion of the file has been copied. This function is of type <see cref="CopyProgressRoutine"/>.</param>
	/// <param name="lpData">An argument to be passed to the callback function. This is a pointer to the data used by the callback function.</param>
	/// <param name="pbCancel">A reference to an integer that, if set to TRUE during the copy operation, cancels the operation. Otherwise, the copy operation will continue to completion.</param>
	/// <param name="dwCopyFlags">Flags that specify how the file is to be copied. This parameter can be one or more of the values defined in the <see cref="CopyFileMode"/> enumeration.</param>
	/// <returns><c>true</c> if the file was successfully copied; otherwise, <c>false</c>.</returns>
	[LibraryImport("kernel32.dll", EntryPoint = "CopyFileExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static partial bool CopyFileEx(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref int pbCancel, CopyFileMode dwCopyFlags);

	/// <summary>
	/// Moves an existing file to a new file location, with options for overwrite behavior and other flags.
	/// </summary>
	/// <param name="lpExistingFileName">The name of the existing file to move.</param>
	/// <param name="lpNewFileName">The name of the new file location.</param>
	/// <param name="dwFlags">Flags that specify how the file is to be moved. This parameter can be one or more of the values defined in the MoveFileFlags enumeration.</param>
	/// <returns><c>true</c> if the file was successfully moved; otherwise, <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
	[LibraryImport("kernel32.dll", EntryPoint = "MoveFileExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static partial bool MoveFileExW(string lpExistingFileName, string lpNewFileName, int dwFlags);

}
