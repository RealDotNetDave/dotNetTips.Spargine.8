// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-11-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-08-2025
// ***********************************************************************
// <copyright file="DriveHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using DotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class DriveHelperTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	[SupportedOSPlatform("windows")]
	public void GetDriveFormat_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		DriveHelper.GetDriveFormat(null);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveFormat_ValidDrive_ReturnsFormat()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveFormat(drive);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result)); // Assuming the drive C:\ has a format
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	[SupportedOSPlatform("windows")]
	public void GetDriveFreeSpace_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		DriveHelper.GetDriveFreeSpace(null);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveFreeSpace_ValidDrive_ReturnsFreeSpace()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveFreeSpace(drive);

		// Assert
		Assert.IsTrue(result > 0); // Assuming the drive C:\ has free space
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	[SupportedOSPlatform("windows")]
	public void GetDriveLabel_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		DriveHelper.GetDriveLabel(null);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveLabel_ValidDrive_ReturnsLabel()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveLabel(drive);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result)); // Assuming the drive C:\ has a label
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	[SupportedOSPlatform("windows")]
	public void GetDriveSerialNumber_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		DriveHelper.GetDriveSerialNumber(null);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveSerialNumber_ValidDrive_ReturnsSerialNumber()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveSerialNumber(drive);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result)); // Assuming the drive C:\ has a serial number
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	[SupportedOSPlatform("windows")]
	public void GetDriveTotalSize_NullDrive_ThrowsArgumentNullException()
	{
		// Act
		DriveHelper.GetDriveTotalSize(null);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetDriveTotalSize_ValidDrive_ReturnsTotalSize()
	{
		// Arrange
		var drive = "C:\\"; // Example drive, in a real test, you might mock the underlying system call

		// Act
		var result = DriveHelper.GetDriveTotalSize(drive);

		// Assert
		Assert.IsTrue(result > 0); // Assuming the drive C:\ has a total size
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetFixedDrives()
	{
		var result = DriveHelper.GetFixedDrives();

		Assert.IsTrue(result.Count > 0);
	}

	[TestMethod]
	[SupportedOSPlatform("windows")]
	public void GetRemovableDrives()
	{
		var result = DriveHelper.GetRemovableDrives();

		Assert.IsNotNull(result);
	}

}
