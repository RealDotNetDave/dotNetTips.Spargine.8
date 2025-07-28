// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-08-2025
// ***********************************************************************
// <copyright file="DriveHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides common methods for working with disk drives on Windows.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides common methods for working with disk drives on Windows.
/// </summary>
/// <remarks>
/// This class includes methods for retrieving information about the system's drives, such as getting the serial number of a drive using <see cref="GetDriveSerialNumber"/>, 
/// listing all fixed drives that are ready using <see cref="GetFixedDrives"/>, and listing all removable drives that are ready using <see cref="GetRemovableDrives"/>.
/// Utilizing the Windows Management Instrumentation (WMI) for some of its operations, it provides a simple interface for drive management tasks.
/// Note: These methods are intended to be used on Windows platforms only.
/// </remarks>
[SupportedOSPlatform("windows")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineDriveHelper")]
public static class DriveHelper
{

	/// <summary>
	/// Gets the file system format of the specified drive such as NTFS or FAT32.
	/// </summary>
	/// <param name="drive">The drive letter (e.g., "C:"). Must not be null or empty.</param>
	/// <returns>The file system format of the drive as a string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="drive"/> is null or empty.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(GetDriveFormat), OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetDriveFormat([NotNull][DisallowNull] string drive)
	{
		drive = drive.ArgumentNotNullOrEmpty();

		return new DriveInfo(drive).DriveFormat;
	}

	/// <summary>
	/// Gets the free space available on the specified drive.
	/// </summary>
	/// <param name="drive">The drive letter (e.g., "C:"). Must not be null or empty.</param>
	/// <returns>The free space available on the drive in bytes.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="drive"/> is null or empty.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(GetDriveFreeSpace), OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static long GetDriveFreeSpace([NotNull][DisallowNull] string drive)
	{
		drive = drive.ArgumentNotNullOrEmpty();

		var driveInfo = new DriveInfo(drive);

		return driveInfo.AvailableFreeSpace;
	}

	/// <summary>
	/// Gets the volume label of the specified drive.
	/// </summary>
	/// <param name="drive">The drive letter (e.g., "C:"). Must not be null or empty.</param>
	/// <returns>The volume label of the drive as a string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="drive"/> is null or empty.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(GetDriveLabel), OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetDriveLabel([NotNull][DisallowNull] string drive)
	{
		drive = drive.ArgumentNotNullOrEmpty();

		var driveInfo = new DriveInfo(drive);

		return driveInfo.VolumeLabel;
	}

	/// <summary>
	/// Gets the serial number of the specified drive.
	/// </summary>
	/// <param name="drive">The drive letter (e.g., "C:"). Must not be null or empty.</param>
	/// <returns>The serial number of the drive as a string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="drive"/> is null or empty.</exception>
	/// <remarks>
	/// This method utilizes the <see cref="ManagementObjectSearcher"/> to query the system for the drive's serial number.
	/// It's important to ensure that the <paramref name="drive"/> parameter is not null or empty to avoid runtime errors.
	/// </remarks>
	[SupportedOSPlatform("windows")]
	[Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://dotnettips.wordpress.com/2007/12/14/finding-a-drives-serial-number/", Status = Status.Available)]
	public static string GetDriveSerialNumber([NotNull][DisallowNull] string drive)
	{
		drive = drive.ArgumentNotNullOrEmpty();

		// No matter what is sent in, get just the drive letter
		var driveFixed = Path.GetPathRoot(drive).Replace(@"\", string.Empty, StringComparison.Ordinal);

		// Perform Query
		using (var querySearch = new ManagementObjectSearcher(
			$"SELECT VolumeSerialNumber FROM Win32_LogicalDisk Where Name = '{driveFixed}'"))
		{
			using (var queryCollection = querySearch.Get())
			{
				foreach (var driveInfo in queryCollection)
				{
					return Convert.ToString(
						driveInfo.GetPropertyValue(propertyName: "VolumeSerialNumber"),
						CultureInfo.CurrentCulture);
				}
			}
		}

		return string.Empty;
	}

	/// <summary>
	/// Gets the total size of the specified drive.
	/// </summary>
	/// <param name="drive">The drive letter (e.g., "C:"). Must not be null or empty.</param>
	/// <returns>The total size of the drive in bytes.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="drive"/> is null or empty.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(GetDriveTotalSize), author: "David McCarter", createdOn: "10/10/2023", OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static long GetDriveTotalSize([NotNull][DisallowNull] string drive)
	{
		drive = drive.ArgumentNotNullOrEmpty();

		var driveInfo = new DriveInfo(drive);

		return driveInfo.TotalSize;
	}

	/// <summary>
	/// Gets the fixed drives that are ready for a computer.
	/// </summary>
	/// <returns>A <see cref="ReadOnlyCollection{DriveInfo}"/> representing the fixed drives that are ready.</returns>
	/// <example>Result Example - [0]: {C:\}</example>
	/// <remarks>
	/// This method filters the drives returned by <see cref="DriveInfo.GetDrives"/> to include only those that are fixed and ready.
	/// </remarks>
	/// <example>Result Example - [0]: {C:\}</example>
	[SupportedOSPlatform("windows")]
	[Information(nameof(GetFixedDrives), author: "David McCarter", createdOn: "9/6/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static ReadOnlyCollection<DriveInfo> GetFixedDrives() => DriveInfo.GetDrives()
					.Where(p => p.DriveType == DriveType.Fixed && p.IsReady)
					.Distinct().ToReadOnlyCollection();

	/// <summary>
	/// Gets the removable drives that are ready for a computer.
	/// </summary>
	/// <returns>A <see cref="ReadOnlyCollection{DriveInfo}"/> representing the removable drives that are ready.</returns>
	/// <example>Result example - [0]: {E:\} [1]: {F:\}</example>
	/// <remarks>
	/// This method filters the drives returned by <see cref="DriveInfo.GetDrives"/> to include only those that are removable and ready.
	/// </remarks>
	[SupportedOSPlatform("windows")]
	[Information(nameof(GetRemovableDrives), author: "David McCarter", createdOn: "9/6/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static ReadOnlyCollection<DriveInfo> GetRemovableDrives() => DriveInfo.GetDrives()
					.Where(p => p.DriveType == DriveType.Removable && p.IsReady)
					.Distinct().ToReadOnlyCollection();

}
