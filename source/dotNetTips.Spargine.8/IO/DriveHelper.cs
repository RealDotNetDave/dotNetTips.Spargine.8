// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="DriveHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for working with disk drives.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides common methods for working with disk drives on Windows.
/// </summary>
/// <remarks>
/// This class includes methods for retrieving information about the system's drives, such as getting the serial number of a drive using <see cref="GetDriveSerialNumber"/>, 
/// listing all fixed drives that are ready using <see cref="GetFixedDrives"/>, and listing all removable drives that are ready using <see cref="GetRemovableDrives"/>.
/// </remarks>
[SupportedOSPlatform("windows")]
public static class DriveHelper
{

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
	[Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://dotnettips.wordpress.com/2007/12/14/finding-a-drives-serial-number/")]
	public static string GetDriveSerialNumber([NotNull][DisallowNull] string drive)
	{
		drive = drive.ArgumentNotNullOrEmpty();

		var driveSerial = string.Empty;

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
					driveSerial = Convert.ToString(
						driveInfo.GetPropertyValue(propertyName: "VolumeSerialNumber"),
						CultureInfo.CurrentCulture);
				}
			}
		}

		return driveSerial;
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
	[Information(nameof(GetFixedDrives), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ReadOnlyCollection<DriveInfo> GetFixedDrives() => DriveInfo.GetDrives()
					.Where(p => p.DriveType == DriveType.Fixed && p.IsReady)
					.Distinct()
					.ToList().AsReadOnly();

	/// <summary>
	/// Gets the removable drives that are ready for a computer.
	/// </summary>
	/// <returns>A <see cref="ReadOnlyCollection{DriveInfo}"/> representing the removable drives that are ready.</returns>
	/// <example>Result example - [0]: {E:\} [1]: {F:\}</example>
	/// <remarks>
	/// This method filters the drives returned by <see cref="DriveInfo.GetDrives"/> to include only those that are removable and ready.
	/// </remarks>
	[Information(nameof(GetRemovableDrives), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ReadOnlyCollection<DriveInfo> GetRemovableDrives() => DriveInfo.GetDrives()
					.Where(p => p.DriveType == DriveType.Removable && p.IsReady)
					.Distinct()
					.ToList().AsReadOnly();

}
