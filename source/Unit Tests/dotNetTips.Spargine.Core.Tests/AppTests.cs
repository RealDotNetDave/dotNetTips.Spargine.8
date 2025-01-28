// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="AppTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AppTests
{

	[TestMethod]
	public void AppConfigTest()
	{
		var config = new AppConfig();

		Assert.IsTrue(string.IsNullOrEmpty(config.ConfigFileName) == false);

		_ = config.TestValues.Count1 = 100;

		_ = config.Save();

		_ = config.Load();

		Assert.IsTrue(config.TestValues.Count1 == 100);

	}

	[TestMethod]
	public void AppInfoTest()
	{
		var info = App.AppInfo;

		Assert.IsTrue(info is not null);
	}

	[TestMethod]
	public void ChangeCulture_WithCultureInfo_ChangesCurrentCulture()
	{
		// Arrange
		var originalCulture = CultureInfo.CurrentCulture;
		var testCultureInfo = new CultureInfo("fr-FR");

		// Act
		App.ChangeCulture(testCultureInfo);

		// Assert
		Assert.AreEqual(testCultureInfo, CultureInfo.CurrentCulture, "The current culture should be changed to the one provided.");

		// Cleanup
		App.ChangeCulture(originalCulture);
	}

	[TestMethod]
	public void ChangeCulture_WithCultureInfoToSameCulture_DoesNotThrowException()
	{
		// Arrange
		var testCultureInfo = new CultureInfo(CultureInfo.CurrentCulture.Name);

		// Act & Assert
		App.ChangeCulture(testCultureInfo);

		// No exception means the test passed. Cleanup is not necessary as the culture was not changed.
	}

	[TestMethod]
	public void ChangeCultureTest()
	{
		App.ChangeCulture("aa");

		Assert.AreEqual("aa", App.CurrentCulture.Name);

		App.ChangeUICulture("af");

		Assert.AreEqual("af", App.CurrentUICulture.Name);

		App.ChangeCulture("en-US");
		App.ChangeUICulture("en-US");
	}

	[TestMethod]
	public void CurrentThreadIdTest()
	{
		var result = App.CurrentThreadId;

		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void ExecutingFolderTest()
	{
		var result = App.ExecutingFolder();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void FrameworkDescriptionTest()
	{
		var result = App.FrameworkDescription;

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void GetCultureNames_ReturnsAllCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames();

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count > 0);
		Assert.IsTrue(cultureNames.Contains("en-US"));
	}

	[TestMethod]
	public void GetCultureNames_ReturnsInstalledWin32Cultures()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.InstalledWin32Cultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count > 0);
		Assert.IsTrue(cultureNames.Contains("en-US"));
	}

	[TestMethod]
	public void GetCultureNames_ReturnsNeutralCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.NeutralCultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count > 0);
		Assert.IsTrue(cultureNames.Contains("en"));
	}

	[TestMethod]
	public void GetCultureNames_ReturnsSpecificCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.SpecificCultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count > 0);
		Assert.IsTrue(cultureNames.Contains("en-US"));
	}

	[TestMethod]
	public void GetCultureNames_ReturnsUserCustomCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.UserCustomCulture);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count >= 0); // User custom cultures might be empty
	}

	[TestMethod]
	public void GetCultureTest()
	{
		var result = App.CurrentCulture;

		Assert.IsNotNull(result);

		result = App.CurrentUICulture;

		Assert.IsNotNull(result);

		result = App.InstalledUICulture;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetEnvironmentVariablesTest()
	{
		var result = App.GetEnvironmentVariables();

		Assert.IsTrue(result.FastCount() > 0);

		foreach (var info in result)
		{
			Debug.WriteLine($"{info.Key}:{info.Value}");
		}
	}

	[TestMethod]
	public void GetProcessorInformationTest()
	{
		var result = App.GetProcessorInformation();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void InformationTest()
	{
		var result1 = App.StackTrace;

		Assert.IsTrue(string.IsNullOrEmpty(result1) is false);

		var result3 = App.OSArchitecture;

		Assert.IsTrue(result3 == Architecture.X64);

		var result4 = App.OSDescription;

		Assert.IsTrue(string.IsNullOrEmpty(result4) is false);

		var result5 = App.ProcessArchitecture;

		Assert.IsTrue(result5 == Architecture.X64);

		var result2 = App.WorkingSet;

		Assert.IsTrue(result2 > 0);
	}

	[TestMethod]
	public void IsRunningFromAspNet()
	{
		var result = App.IsRunningFromAspNet();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsRunningTest()
	{
		var result = App.IsRunning();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsUserAdministrator()
	{
		var result = App.IsUserAdministrator();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void MaxDegreeOfParallelism_ValidProcessorCount_ReturnsExpectedValue()
	{
		// Arrange
		var processorCount = Environment.ProcessorCount;
		var expectedValue = Convert.ToInt32(Math.Ceiling(processorCount * 0.75 * 2.0));

		// Act
		var result = App.MaxDegreeOfParallelism();

		// Assert
		Assert.AreEqual(expectedValue, result);
	}

	[TestMethod]
	public void ProcessIdTest()
	{
		var result = App.ProcessId;

		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void ProcessNameTest()
	{
		var result = App.ProcessName;

		Assert.IsFalse(string.IsNullOrEmpty(result), "Process name should not be null or empty.");
		Assert.AreEqual(Process.GetCurrentProcess().ProcessName, result, "Process name should match the current process name.");
	}

	[TestMethod]
	public void ProcessPathTest()
	{
		var result = App.ProcessPath;

		Assert.IsTrue(result.Length > 0);
	}

	[TestMethod]
	public void ReferencedAssembliesTest()
	{
		var result = App.ReferencedAssemblies();

		Assert.IsTrue(result.FastCount() > 0);
	}
}

public class GlobalConfig
{

	public GlobalConfig()
	{
	}

}

public class AppConfig : Config<GlobalConfig>
{

	public Values TestValues { get; set; } = new Values();

}

public class Values
{

	public int Count1 { get; set; }
	public int Count2 { get; set; }

}
