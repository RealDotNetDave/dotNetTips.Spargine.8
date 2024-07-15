// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-11-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-11-2024
// ***********************************************************************
// <copyright file="DriveHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Runtime.Versioning;
using DotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.IO;

[TestClass]
public class DriveHelperTests
{

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
