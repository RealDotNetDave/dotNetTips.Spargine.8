// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Common.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2025
// ***********************************************************************
// <copyright file="ComputerInfoTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core.Devices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ComputerInfoTests
{

	[TestMethod]
	public void ComputerCulture_ShouldReturnCorrectCulture()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedCulture = CultureInfo.CurrentCulture.ThreeLetterISOLanguageName;

		// Act
		var actualCulture = computerInfo.ComputerCulture;

		// Assert
		Assert.AreEqual(expectedCulture, actualCulture, "The ComputerCulture property should return the correct culture.");
	}


	[TestMethod]
	public void ComputerInfoTest()
	{
		var ci = new ComputerInfo();

		Assert.IsNotNull(ci);
	}

	[TestMethod]
	public void ComputerUICulture_ShouldReturnCorrectUICulture()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedUICulture = CultureInfo.CurrentUICulture.ThreeLetterISOLanguageName;

		// Act
		var actualUICulture = computerInfo.ComputerUICulture;

		// Assert
		Assert.AreEqual(expectedUICulture, actualUICulture, "The ComputerUICulture property should return the correct UI culture.");
	}

	[TestMethod]
	public void CurrentManagedTreadId_ShouldReturnCorrectThreadId()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedThreadId = Environment.CurrentManagedThreadId;

		// Act
		var actualThreadId = computerInfo.CurrentManagedTreadId;

		// Assert
		Assert.AreEqual(expectedThreadId, actualThreadId, "The CurrentManagedTreadId property should return the correct thread ID.");
	}

	[TestMethod]
	public void CurrentSystemTickCount_ShouldReturnCorrectTickCount()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedTickCount = Clock.TickCount;

		// Act
		var actualTickCount = computerInfo.CurrentSystemTickCount;

		// Assert
		Assert.AreEqual(expectedTickCount, actualTickCount, "The CurrentSystemTickCount property should return the correct tick count.");
	}

	[TestMethod]
	public void CurrentWorkingDirectory_ShouldReturnCorrectDirectory()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedDirectory = Environment.CurrentDirectory;

		// Act
		var actualDirectory = computerInfo.CurrentWorkingDirectory;

		// Assert
		Assert.AreEqual(expectedDirectory, actualDirectory, "The CurrentWorkingDirectory property should return the correct directory.");
	}

	[TestMethod]
	public void FrameworkDescription_ShouldReturnCorrectDescription()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedDescription = RuntimeInformation.FrameworkDescription;

		// Act
		var actualDescription = computerInfo.FrameworkDescription;

		// Assert
		Assert.AreEqual(expectedDescription, actualDescription, "The FrameworkDescription property should return the correct framework description.");
	}

	[TestMethod]
	public void FrameworkVersion_ShouldReturnCorrectVersion()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedVersion = Environment.Version;

		// Act
		var actualVersion = computerInfo.FrameworkVersion;

		// Assert
		Assert.AreEqual(expectedVersion, actualVersion, "The FrameworkVersion property should return the correct framework version.");
	}

	[TestMethod]
	public void HasShutdownStarted_ShouldReturnCorrectValue()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedValue = Environment.HasShutdownStarted;

		// Act
		var actualValue = computerInfo.HasShutdownStarted;

		// Assert
		Assert.AreEqual(expectedValue, actualValue, "The HasShutdownStarted property should return the correct value.");
	}

	[TestMethod]
	public void IPAddressTest()
	{
		var ci = new ComputerInfo().IPAddress;

		Assert.IsNotNull(ci);
	}

	[TestMethod]
	public void Is64BitOperatingSystem_ShouldReturnCorrectValue()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedValue = Environment.Is64BitOperatingSystem;

		// Act
		var actualValue = computerInfo.Is64BitOperatingSystem;

		// Assert
		Assert.AreEqual(expectedValue, actualValue, "The Is64BitOperatingSystem property should return the correct value.");
	}

	[TestMethod]
	public void Is64BitProcess_ShouldReturnCorrectValue()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedValue = Environment.Is64BitProcess;

		// Act
		var actualValue = computerInfo.Is64BitProcess;

		// Assert
		Assert.AreEqual(expectedValue, actualValue, "The Is64BitProcess property should return the correct value.");
	}

	[TestMethod]
	public void IsNetworkAvailable_NetworkIsAvailable_ReturnsTrue()
	{
		// Act
		var result = new ComputerInfo().IsNetworkAvailable;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsNetworkAvailable_ShouldReturnCorrectValue()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedValue = NetworkInterface.GetAllNetworkInterfaces().Any(ni => ni.OperationalStatus == OperationalStatus.Up && !ni.Description.Contains("VIRTUALBOX", StringComparison.OrdinalIgnoreCase) && !ni.Description.Contains("LOOPBACK", StringComparison.OrdinalIgnoreCase));

		// Act
		var actualValue = computerInfo.IsNetworkAvailable;

		// Assert
		Assert.AreEqual(expectedValue, actualValue, "The IsNetworkAvailable property should return the correct value.");
	}

	[TestMethod]
	public void IsUserInteractive_ShouldReturnCorrectValue()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedValue = Environment.UserInteractive;

		// Act
		var actualValue = computerInfo.IsUserInteractive;

		// Assert
		Assert.AreEqual(expectedValue, actualValue, "The IsUserInteractive property should return the correct value.");
	}

	[TestMethod]
	public void LoggableExceptionComputerInfoTest()
	{
		var ex = new LoggableException();

		var result = ex.ComputerInformation;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void LogicalDrives_ShouldReturnCorrectDrives()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedDrives = Environment.GetLogicalDrives();

		// Act
		var actualDrives = computerInfo.LogicalDrives;

		// Assert
		CollectionAssert.AreEqual(expectedDrives, actualDrives, "The LogicalDrives property should return the correct drives.");
	}

	[TestMethod]
	public void MachineName_ShouldReturnCorrectName()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedName = Environment.MachineName;

		// Act
		var actualName = computerInfo.MachineName;

		// Assert
		Assert.AreEqual(expectedName, actualName, "The MachineName property should return the correct name.");
	}

	[TestMethod]
	public void OSArchitecture_ShouldReturnCorrectArchitecture()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedArchitecture = RuntimeInformation.OSArchitecture.ToString();

		// Act
		var actualArchitecture = computerInfo.OSArchitecture;

		// Assert
		Assert.AreEqual(expectedArchitecture, actualArchitecture, "The OSArchitecture property should return the correct architecture.");
	}

	[TestMethod]
	public void OSDescription_ShouldReturnCorrectDescription()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedDescription = RuntimeInformation.OSDescription;

		// Act
		var actualDescription = computerInfo.OSDescription;

		// Assert
		Assert.AreEqual(expectedDescription, actualDescription, "The OSDescription property should return the correct description.");
	}

	[TestMethod]
	public void OsMemoryPageSize_ShouldReturnCorrectPageSize()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedPageSize = Environment.SystemPageSize;

		// Act
		var actualPageSize = computerInfo.OSMemoryPageSize;

		// Assert
		Assert.AreEqual(expectedPageSize, actualPageSize, "The OsMemoryPageSize property should return the correct page size.");
	}

	[TestMethod]
	public void PhysicalMemoryInUse_ShouldReturnCorrectMemoryUsage()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedMemoryUsage = Environment.WorkingSet;

		// Act
		var actualMemoryUsage = computerInfo.PhysicalMemoryInUse;

		// Assert
		Assert.AreEqual(expectedMemoryUsage, actualMemoryUsage, "The PhysicalMemoryInUse property should return the correct memory usage.");
	}

	[TestMethod]
	public void ProcessArchitecture_ShouldReturnCorrectArchitecture()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedArchitecture = RuntimeInformation.ProcessArchitecture;

		// Act
		var actualArchitecture = computerInfo.ProcessArchitecture;

		// Assert
		Assert.AreEqual(expectedArchitecture, actualArchitecture, "The ProcessArchitecture property should return the correct architecture.");
	}

	[TestMethod]
	public void ProcessorCount_ShouldReturnCorrectCount()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedCount = Environment.ProcessorCount;

		// Act
		var actualCount = computerInfo.ProcessorCount;

		// Assert
		Assert.AreEqual(expectedCount, actualCount, "The ProcessorCount property should return the correct count.");
	}

	[TestMethod]
	public void SystemDirectory_ShouldReturnCorrectDirectory()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedDirectory = Environment.SystemDirectory;

		// Act
		var actualDirectory = computerInfo.SystemDirectory;

		// Assert
		Assert.AreEqual(expectedDirectory, actualDirectory, "The SystemDirectory property should return the correct directory.");
	}

	[TestMethod]
	public void SystemPageSize_ShouldReturnCorrectPageSize()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedPageSize = Environment.SystemPageSize;

		// Act
		var actualPageSize = computerInfo.SystemPageSize;

		// Assert
		Assert.AreEqual(expectedPageSize, actualPageSize, "The SystemPageSize property should return the correct page size.");
	}

	[TestMethod]
	public void TickCount_ShouldReturnCorrectTickCount()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedTickCount = Clock.TickCount;

		// Act
		var actualTickCount = computerInfo.TickCount;

		// Assert
		Assert.AreEqual(expectedTickCount, actualTickCount, "The TickCount property should return the correct tick count.");
	}

	[TestMethod]
	public void TickCount64_ShouldReturnCorrectTickCount64()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedTickCount64 = Clock.TickCount64;

		// Act
		var actualTickCount64 = computerInfo.TickCount64;

		// Assert
		Assert.AreEqual(expectedTickCount64, actualTickCount64, "The TickCount64 property should return the correct tick count.");
	}

	[TestMethod]
	public void ToString_ShouldContainPropertyValues()
	{
		// Arrange
		var computerInfo = new ComputerInfo();

		// Act
		var result = computerInfo.ToString();

		// Assert
		Assert.IsTrue(result.Contains(computerInfo.ComputerCulture), "The ToString method should contain the ComputerCulture property value.");
		Assert.IsTrue(result.Contains(computerInfo.ComputerUICulture), "The ToString method should contain the ComputerUICulture property value.");
		Assert.IsTrue(result.Contains(computerInfo.CurrentManagedTreadId.ToString()), "The ToString method should contain the CurrentManagedTreadId property value.");
		Assert.IsTrue(result.Contains(computerInfo.CurrentStackTrace), "The ToString method should contain the CurrentStackTrace property value.");
		Assert.IsTrue(result.Contains(computerInfo.CurrentSystemTickCount.ToString()), "The ToString method should contain the CurrentSystemTickCount property value.");
		Assert.IsTrue(result.Contains(computerInfo.CurrentWorkingDirectory), "The ToString method should contain the CurrentWorkingDirectory property value.");
		Assert.IsTrue(result.Contains(computerInfo.FrameworkDescription), "The ToString method should contain the FrameworkDescription property value.");
		Assert.IsTrue(result.Contains(computerInfo.FrameworkVersion.ToString()), "The ToString method should contain the FrameworkVersion property value.");
		Assert.IsTrue(result.Contains(computerInfo.HasShutdownStarted.ToString()), "The ToString method should contain the HasShutdownStarted property value.");
		Assert.IsTrue(result.Contains(computerInfo.IPAddress), "The ToString method should contain the IPAddress property value.");
		Assert.IsTrue(result.Contains(computerInfo.Is64BitOperatingSystem.ToString()), "The ToString method should contain the Is64BitOperatingSystem property value.");
		Assert.IsTrue(result.Contains(computerInfo.Is64BitProcess.ToString()), "The ToString method should contain the Is64BitProcess property value.");
		Assert.IsTrue(result.Contains(computerInfo.IsNetworkAvailable.ToString()), "The ToString method should contain the IsNetworkAvailable property value.");
		Assert.IsTrue(result.Contains(computerInfo.IsUserInteractive.ToString()), "The ToString method should contain the IsUserInteractive property value.");
		Assert.IsTrue(result.Contains(computerInfo.MachineName), "The ToString method should contain the MachineName property value.");
		Assert.IsTrue(result.Contains(computerInfo.OSArchitecture.ToString()), "The ToString method should contain the OSArchitecture property value.");
		Assert.IsTrue(result.Contains(computerInfo.OSDescription), "The ToString method should contain the OSDescription property value.");
		Assert.IsTrue(result.Contains(computerInfo.OSMemoryPageSize.ToString()), "The ToString method should contain the OsMemoryPageSize property value.");
		Assert.IsTrue(result.Contains(computerInfo.PhysicalMemoryInUse.ToString()), "The ToString method should contain the PhysicalMemoryInUse property value.");
		Assert.IsTrue(result.Contains(computerInfo.ProcessArchitecture.ToString()), "The ToString method should contain the ProcessArchitecture property value.");
		Assert.IsTrue(result.Contains(computerInfo.ProcessorCount.ToString()), "The ToString method should contain the ProcessorCount property value.");
		Assert.IsTrue(result.Contains(computerInfo.SystemDirectory), "The ToString method should contain the SystemDirectory property value.");
		Assert.IsTrue(result.Contains(computerInfo.SystemPageSize.ToString()), "The ToString method should contain the SystemPageSize property value.");
		Assert.IsTrue(result.Contains(computerInfo.TickCount.ToString()), "The ToString method should contain the TickCount property value.");
		Assert.IsTrue(result.Contains(computerInfo.TickCount64.ToString()), "The ToString method should contain the TickCount64 property value.");
		Assert.IsTrue(result.Contains(computerInfo.UserDomainName), "The ToString method should contain the UserDomainName property value.");
		Assert.IsTrue(result.Contains(computerInfo.UserName), "The ToString method should contain the UserName property value.");
	}

	[TestMethod]
	public void ToString_ShouldReturnNonEmptyString()
	{
		// Arrange
		var computerInfo = new ComputerInfo();

		// Act
		var result = computerInfo.ToString();

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result), "The ToString method should return a non-empty string.");
	}

	[TestMethod]
	public void Uptime_ShouldReturnCorrectTimeSpan()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedUptime = TimeSpan.FromMilliseconds(Environment.TickCount64);

		// Act
		var actualUptime = computerInfo.Uptime;

		// Assert
		Assert.AreEqual(expectedUptime, actualUptime, "The Uptime property should return the correct TimeSpan based on Environment.TickCount64.");
	}

	[TestMethod]
	public void UserDomainName_ShouldReturnCorrectDomainName()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedDomainName = Environment.UserDomainName;

		// Act
		var actualDomainName = computerInfo.UserDomainName;

		// Assert
		Assert.AreEqual(expectedDomainName, actualDomainName, "The UserDomainName property should return the correct domain name.");
	}

	[TestMethod]
	public void UserName_ShouldReturnCorrectUserName()
	{
		// Arrange
		var computerInfo = new ComputerInfo();
		var expectedUserName = Environment.UserName;

		// Act
		var actualUserName = computerInfo.UserName;

		// Assert
		Assert.AreEqual(expectedUserName, actualUserName, "The UserName property should return the correct user name.");
	}
}

