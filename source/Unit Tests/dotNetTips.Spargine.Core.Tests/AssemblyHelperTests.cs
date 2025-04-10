// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 04-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-10-2025
// ***********************************************************************
// <copyright file="AssemblyHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[TestClass]
public class AssemblyHelperTests : TestClass
{

	[TestMethod]
	public void DoesAssemblyReference_InvalidReference_ReturnsFalse()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var referencedAssemblyName = "NonExistentAssembly";

		// Act
		var result = AssemblyHelper.DoesAssemblyReference(assemblyFile, referencedAssemblyName);

		// Assert
		Assert.IsFalse(result, $"Expected the assembly not to reference {referencedAssemblyName}, but it does.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void DoesAssemblyReference_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.DoesAssemblyReference(null!, "System.Runtime");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void DoesAssemblyReference_NullReferencedAssemblyName_ThrowsArgumentNullException()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		_ = AssemblyHelper.DoesAssemblyReference(assemblyFile, null!);
	}

	[TestMethod]
	public void DoesAssemblyReference_ValidReference_ReturnsTrue()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var referencedAssemblyName = "System.Runtime";

		// Act
		var result = AssemblyHelper.DoesAssemblyReference(assemblyFile, referencedAssemblyName);

		// Assert
		Assert.IsTrue(result, $"Expected the assembly to reference {referencedAssemblyName}, but it does not.");
	}

	[TestMethod]
	public void DoesTypeExistInAssembly_InvalidType_ReturnsFalse()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var typeName = "NonExistentType";

		// Act
		var result = AssemblyHelper.DoesTypeExistInAssembly(assemblyFile, typeName);

		// Assert
		Assert.IsFalse(result, $"Expected the type {typeName} not to exist in the assembly, but it does.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void DoesTypeExistInAssembly_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.DoesTypeExistInAssembly(null!, "System.String");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void DoesTypeExistInAssembly_NullTypeName_ThrowsArgumentNullException()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		_ = AssemblyHelper.DoesTypeExistInAssembly(assemblyFile, null!);
	}

	[TestMethod]
	public void DoesTypeExistInAssembly_ValidType_ReturnsTrue()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var typeName = typeof(AssemblyHelper).FullName!;

		// Act
		var result = AssemblyHelper.DoesTypeExistInAssembly(assemblyFile, typeName);

		// Assert
		Assert.IsTrue(result, $"Expected the type {typeName} to exist in the assembly, but it does not.");
	}

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

		var info = CollectionPropertiesToString(result, prop => prop.Name == "Name");
		Debug.WriteLine(info);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find .NET SDK files for version 8.0.15, but none were found.");
	}

	[TestMethod]
	public void FindSDKTypesImplementing_IDisposable()
	{
		// Arrange
		var assemblyFiles = AssemblyHelper.GetNetSdkDllFiles();
		var foundTypes = new List<Type>();

		// Act
		foreach (var assemblyFile in assemblyFiles)
		{
			var types = AssemblyHelper.FindTypesImplementing(assemblyFile, typeof(IDisposable));

			if (types.Count > 0)
			{
				foundTypes.AddRange(types);
			}
		}

		var info = CollectionPropertiesToString(foundTypes, prop => prop.Name == "Name");
		Debug.WriteLine(info);

		// Assert
		Assert.IsTrue(foundTypes.Count > 100, "Expected to find types implementing IDisposable, but none were found.");
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

		var info = CollectionPropertiesToString(result, prop => prop.Name == "Name");
		Debug.WriteLine(info);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find types implementing Attribute, but none were found.");
	}

	[TestMethod]
	public void GetAssemblyCustomAttributes_InvalidAssembly_ReturnsEmptyCollection()
	{
		// Arrange
		var invalidAssemblyFile = new FileInfo("NonExistentAssembly.dll");

		// Act
		var result = AssemblyHelper.GetAssemblyCustomAttributes(invalidAssemblyFile);

		// Assert
		Assert.IsNotNull(result, "Expected a non-null result, but got null.");
		Assert.AreEqual(0, result.Count, "Expected no custom attributes for an invalid assembly, but some were found.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetAssemblyCustomAttributes_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.GetAssemblyCustomAttributes(null!);
	}

	[TestMethod]
	public void GetAssemblyCustomAttributes_ValidAssembly_ReturnsAttributes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.GetAssemblyCustomAttributes(assemblyFile);

		var info = CollectionPropertiesToString(result, prop => prop.Name == nameof(Attribute.TypeId));
		Debug.WriteLine(info);

		// Assert
		Assert.IsNotNull(result, "Expected a non-null result, but got null.");
		Assert.IsTrue(result.Count > 0, "Expected to find custom attributes, but none were found.");
	}

	[TestMethod]
	public void GetPublicTypes_ValidAssembly_ReturnsPublicTypes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.GetPublicTypes(assemblyFile);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find public types in the assembly, but none were found.");
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

		var info = CollectionPropertiesToString(result, prop => prop.Name == "Name");
		Debug.WriteLine(info);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find types in the assembly, but none were found.");
	}

	[TestMethod]
	public void UnloadAssembly_ValidAssembly_DoesNotThrow()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act & Assert
		AssemblyHelper.UnloadAssembly(assemblyFile);
	}

	[TestMethod]
	public void VersionParseSafe_InvalidVersionString_ReturnsDefaultVersion()
	{
		// Arrange
		var versionString = "invalid-version";

		// Act
		var result = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { versionString }) as Version;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(new Version(0, 0), result, "Expected default version 0.0, but got a different result.");
	}

	[TestMethod]
	[ExpectedException(typeof(TargetInvocationException))]
	public void VersionParseSafe_NullInput_ThrowsArgumentNullException()
	{
		// Act
		_ = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { null! });
	}

	[TestMethod]
	public void VersionParseSafe_ValidVersionString_ReturnsParsedVersion()
	{
		// Arrange
		var versionString = "2.5.8";

		// Act
		var result = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { versionString }) as Version;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(new Version(2, 5, 8), result, "Expected version 2.5.8, but got a different result.");
	}


	[TestMethod]
	public void VersionParseSafe_VersionWithPreviewSuffix_ReturnsParsedVersion()
	{
		// Arrange
		var versionString = "1.2.3-preview";

		// Act
		var result = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { versionString }) as Version;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(new Version(1, 2, 3), result, "Expected version 1.2.3, but got a different result.");
	}

	[TestMethod]
	public void VersionParseSafe_VersionWithSuffix_ReturnsParsedVersion()
	{
		// Arrange
		var versionString = "3.1.4-beta";

		// Act
		var result = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { versionString }) as Version;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(new Version(3, 1, 4), result, "Expected version 3.1.4, but got a different result.");
	}


}

