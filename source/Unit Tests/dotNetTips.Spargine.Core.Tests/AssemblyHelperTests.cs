// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 04-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-09-2025
// ***********************************************************************
// <copyright file="AssemblyHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[TestClass]
public class AssemblyHelperTests
{
	[TestMethod]
	public void FindNetSDKFiles_DotnetRootSet_ReturnsFiles()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(null);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find .NET SDK files, but none were found.");
	}

	[TestMethod]
	public void FindNetSDKFiles_NoMatchingVersion_ReturnsEmpty()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles("99.99.99");

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Expected no .NET SDK files for version 99.99.99, but some were found.");
	}

	[TestMethod]
	public void FindNetSDKFiles_SpecificVersion_ReturnsFiles()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles("8.0.15");

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find .NET SDK files for version 8.0.15, but none were found.");
	}

	[TestMethod]
	public void FindTypesImplementing_NoMatchingTypes_ReturnsEmpty()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.FindTypesImplementing(assemblyFile, typeof(ICloneable));

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Expected no types implementing ICloneable, but some were found.");
	}
	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void FindTypesImplementing_NullFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.FindTypesImplementing(null!, typeof(IDisposable));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void FindTypesImplementing_NullTypeNames_ThrowsArgumentNullException()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		_ = AssemblyHelper.FindTypesImplementing(assemblyFile, null!);
	}

	[TestMethod]
	public void FindTypesImplementing_ValidAssembly_ReturnsMatchingTypes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.FindTypesImplementing(assemblyFile, typeof(Attribute));

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find types implementing Attribute, but none were found.");
	}

	[TestMethod]
	[ExpectedException(typeof(BadImageFormatException))]
	public void LoadAssemblyTypes_InvalidAssembly_ThrowsBadImageFormatException()
	{
		// Arrange
		var tempFile = Path.GetTempFileName();

		try
		{
			var invalidAssemblyFile = new FileInfo(tempFile);

			// Act
			_ = AssemblyHelper.LoadAssemblyTypes(invalidAssemblyFile);
		}
		finally
		{
			// Cleanup
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void LoadAssemblyTypes_NonExistentFile_ThrowsFileNotFoundException()
	{
		// Arrange
		var nonExistentFile = new FileInfo("NonExistentAssembly.dll");

		// Act
		_ = AssemblyHelper.LoadAssemblyTypes(nonExistentFile);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void LoadAssemblyTypes_NullFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.LoadAssemblyTypes(null!);
	}

	[TestMethod]
	public void LoadAssemblyTypes_ValidAssembly_ReturnsTypes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.LoadAssemblyTypes(assemblyFile);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find types in the assembly, but none were found.");
	}

}

