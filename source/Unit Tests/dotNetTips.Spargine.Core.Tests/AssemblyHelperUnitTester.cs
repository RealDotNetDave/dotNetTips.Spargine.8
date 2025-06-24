// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 04-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-24-2025
// ***********************************************************************
// <copyright file="AssemblyHelperUnitTester.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[TestClass]
public class AssemblyHelperUnitTester : UnitTester
{
	private string _testOutputDirectory;

	private TestUnitTester _unitTester;

	[TestCleanup]
	public void Cleanup()
	{
		if (Directory.Exists(this._testOutputDirectory))
		{
			Directory.Delete(this._testOutputDirectory, true);
		}
	}

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
		var result = AssemblyHelper.GetNetSdkDllFiles("8.0.17");

		PrintToDebug<FileInfo>(result, prop => prop.Name == "Name");

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

		SaveToFile<Type>(foundTypes, prop => prop.Name == "FullName", nameof(this.FindSDKTypesImplementing_IDisposable));

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

		PrintToDebug<Type>(result, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find types implementing Attribute, but none were found.");
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
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

		this.SaveToFile(result, prop => prop.Name == nameof(Attribute.TypeId), nameof(AssemblyHelper.GetAssemblyCustomAttributes));

		// Assert
		Assert.IsNotNull(result, "Expected a non-null result, but got null.");
		Assert.IsTrue(result.Count > 0, "Expected to find custom attributes, but none were found.");
	}

	[TestMethod]
	public void GetAssemblyEntryPoint_AssemblyWithoutEntryPoint_ReturnsNull()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(object).Assembly.Location); // mscorlib or System.Private.CoreLib

		// Act
		var entryPoint = AssemblyHelper.GetAssemblyEntryPoint(assemblyFile);

		// Assert
		Assert.IsNull(entryPoint, "Expected null for an assembly without an entry point, but got a value.");
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void GetAssemblyEntryPoint_InvalidAssembly_ReturnsNull()
	{
		// Arrange
		var invalidAssemblyFile = new FileInfo("NonExistentAssembly.dll");

		// Act
		var entryPoint = AssemblyHelper.GetAssemblyEntryPoint(invalidAssemblyFile);

		// Assert
		Assert.IsNull(entryPoint, "Expected null for an invalid assembly, but got a value.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetAssemblyEntryPoint_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.GetAssemblyEntryPoint(null!);
	}

	[TestMethod]
	public void GetAssemblyEntryPoint_ValidAssembly_ReturnsEntryPoint()
	{
		// Arrange
		var assemblyFile = new FileInfo(Assembly.GetExecutingAssembly().Location);

		// Act
		var entryPoint = AssemblyHelper.GetAssemblyEntryPoint(assemblyFile);

		this.PrintToDebug<MethodInfo>(entryPoint, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(entryPoint, "Expected a valid entry point, but got null.");
		Assert.AreEqual("Main", entryPoint.Name, "Expected the entry point to be 'Main'.");
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void GetAssemblyMetadata_InvalidAssembly_ReturnsErrorMetadata()
	{
		// Arrange
		var invalidAssemblyFile = new FileInfo("NonExistentAssembly.dll");

		// Act
		var metadata = AssemblyHelper.GetAssemblyMetadata(invalidAssemblyFile);

		// Assert
		Assert.IsNotNull(metadata, "Expected metadata dictionary, but got null.");
		Assert.IsTrue(metadata.ContainsKey("Error"), "Expected 'Error' key in metadata.");
		Assert.AreEqual("Invalid .NET assembly", metadata["Error"], "Expected 'Invalid .NET assembly' error message.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetAssemblyMetadata_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.GetAssemblyMetadata(null!);
	}

	[TestMethod]
	public void GetAssemblyMetadata_ValidAssembly_ReturnsMetadata()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var metadata = AssemblyHelper.GetAssemblyMetadata(assemblyFile);

		// Assert
		Assert.IsNotNull(metadata, "Expected metadata dictionary, but got null.");
		Assert.IsTrue(metadata.ContainsKey("Name"), "Expected 'Name' key in metadata.");
		Assert.IsTrue(metadata.ContainsKey("Version"), "Expected 'Version' key in metadata.");
		Assert.IsTrue(metadata.ContainsKey("Culture"), "Expected 'Culture' key in metadata.");
		Assert.IsTrue(metadata.ContainsKey("FullName"), "Expected 'FullName' key in metadata.");
	}

	[TestMethod]
	public void GetAssemblyMetadata_ValidAssemblyWithNoCulture_ReturnsNeutralCulture()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var metadata = AssemblyHelper.GetAssemblyMetadata(assemblyFile);

		// Assert
		Assert.IsNotNull(metadata, "Expected metadata dictionary, but got null.");
		Assert.AreEqual("Neutral", metadata["Culture"], "Expected 'Neutral' culture for the assembly.");
	}

	[TestMethod]
	public void GetDependentAssemblies_AssemblyWithNoDependencies_ReturnsEmptyCollection()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(object).Assembly.Location); // mscorlib or System.Private.CoreLib

		// Act
		var dependentAssemblies = AssemblyHelper.GetDependentAssemblies(assemblyFile);

		// Assert
		Assert.IsNotNull(dependentAssemblies, "Expected a non-null collection of dependent assemblies.");
		Assert.AreEqual(0, dependentAssemblies.Count, "Expected an empty collection for an assembly with no dependencies.");
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void GetDependentAssemblies_InvalidAssembly_ReturnsEmptyCollection()
	{
		// Arrange
		var invalidAssemblyFile = new FileInfo("NonExistentAssembly.dll");

		// Act
		var dependentAssemblies = AssemblyHelper.GetDependentAssemblies(invalidAssemblyFile);

		// Assert
		Assert.IsNotNull(dependentAssemblies, "Expected a non-null collection of dependent assemblies.");
		Assert.AreEqual(0, dependentAssemblies.Count, "Expected an empty collection for an invalid assembly.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetDependentAssemblies_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.GetDependentAssemblies(null!);
	}

	[TestMethod]
	public void GetDependentAssemblies_ValidAssembly_ReturnsDependencies()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var dependentAssemblies = AssemblyHelper.GetDependentAssemblies(assemblyFile);

		this.PrintToDebug<AssemblyName>(dependentAssemblies, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(dependentAssemblies, "Expected a non-null collection of dependent assemblies.");
		Assert.IsTrue(dependentAssemblies.Count > 0, "Expected at least one dependent assembly.");
		Assert.IsTrue(dependentAssemblies.Any(dep => dep.Name == "System.Runtime"), "Expected 'System.Runtime' to be a dependent assembly.");
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void GetMethodsInType_InvalidAssembly_ReturnsEmptyCollection()
	{
		// Arrange
		var invalidAssemblyFile = new FileInfo("NonExistentAssembly.dll");
		var typeName = typeof(FastStringBuilder).FullName!;

		// Act
		var methods = AssemblyHelper.GetMethodsInType(invalidAssemblyFile, typeName);

		// Assert
		Assert.IsNotNull(methods, "Expected a non-null collection of methods.");
		Assert.AreEqual(0, methods.Count, "Expected an empty collection for an invalid assembly.");
	}

	[TestMethod]
	public void GetMethodsInType_InvalidType_ReturnsEmptyCollection()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var invalidTypeName = "NonExistentNamespace.NonExistentType";

		// Act
		var methods = AssemblyHelper.GetMethodsInType(assemblyFile, invalidTypeName);

		// Assert
		Assert.IsNotNull(methods, "Expected a non-null collection of methods.");
		Assert.AreEqual(0, methods.Count, "Expected an empty collection for a non-existent type.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetMethodsInType_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.GetMethodsInType(null!, typeof(FastStringBuilder).FullName!);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetMethodsInType_NullTypeName_ThrowsArgumentNullException()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		_ = AssemblyHelper.GetMethodsInType(assemblyFile, null!);
	}

	[TestMethod]
	public void GetMethodsInType_ValidType_ReturnsMethods()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var typeName = typeof(FastStringBuilder).FullName!;

		// Act
		var methods = AssemblyHelper.GetMethodsInType(assemblyFile, typeName);

		this.PrintToDebug<MethodInfo>(methods, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(methods, "Expected a non-null collection of methods.");
		Assert.IsTrue(methods.Count > 0, "Expected at least one method in the type.");
	}

	[TestMethod]
	public void GetPublicTypes_AssemblyWithNoPublicTypes_ReturnsEmptyCollection()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(object).Assembly.Location); // mscorlib or System.Private.CoreLib

		// Act
		var publicTypes = AssemblyHelper.GetAssemblyPublicTypes(assemblyFile);

		// Assert
		Assert.IsNotNull(publicTypes, "Expected a non-null collection of public types.");
		Assert.AreEqual(0, publicTypes.Count, "Expected an empty collection for an assembly with no public types.");
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void GetPublicTypes_InvalidAssembly_ReturnsEmptyCollection()
	{
		// Arrange
		var invalidAssemblyFile = new FileInfo("NonExistentAssembly.dll");

		// Act
		var publicTypes = AssemblyHelper.GetAssemblyPublicTypes(invalidAssemblyFile);

		// Assert
		Assert.IsNotNull(publicTypes, "Expected a non-null collection of public types.");
		Assert.AreEqual(0, publicTypes.Count, "Expected an empty collection for an invalid assembly.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetPublicTypes_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.GetAssemblyPublicTypes(null!);
	}

	[TestMethod]
	public void GetPublicTypes_ValidAssembly_HandlesPartialTypeLoading()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var publicTypes = AssemblyHelper.GetAssemblyPublicTypes(assemblyFile);

		// Assert
		Assert.IsNotNull(publicTypes, "Expected a non-null collection of public types.");
		Assert.IsTrue(publicTypes.All(type => type.IsPublic), "Expected all returned types to be public.");
	}

	[TestMethod]
	public void GetPublicTypes_ValidAssembly_ReturnsPublicTypes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var publicTypes = AssemblyHelper.GetAssemblyPublicTypes(assemblyFile);

		this.PrintToDebug<Type>(publicTypes, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(publicTypes, "Expected a non-null collection of public types.");
		Assert.IsTrue(publicTypes.Count > 0, "Expected at least one public type in the assembly.");
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_DirectoryWithNonAssemblies_ReturnsEmptyCollection()
	{
		// Arrange
		var testDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "TestDirectoryWithNonAssemblies"));
		if (!testDirectory.Exists)
		{
			testDirectory.Create();
		}

		var testFile = new FileInfo(Path.Combine(testDirectory.FullName, "test.txt"));
		File.WriteAllText(testFile.FullName, "This is a test file.");

		// Act
		var assemblies = AssemblyHelper.FindAssembliesFromDirectory(testDirectory);

		// Assert
		Assert.IsNotNull(assemblies, "Expected a non-null collection of assemblies.");
		Assert.AreEqual(0, assemblies.Count, "Expected an empty collection for a directory with no assemblies.");

		// Cleanup
		testFile.Delete();
		testDirectory.Delete();
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_EmptyDirectory_ReturnsEmptyCollection()
	{
		// Arrange
		var emptyDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "EmptyTestDirectory"));
		if (!emptyDirectory.Exists)
		{
			emptyDirectory.Create();
		}

		// Act
		var assemblies = AssemblyHelper.FindAssembliesFromDirectory(emptyDirectory);

		// Assert
		Assert.IsNotNull(assemblies, "Expected a non-null collection of assemblies.");
		Assert.AreEqual(0, assemblies.Count, "Expected an empty collection for an empty directory.");

		// Cleanup
		emptyDirectory.Delete();
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_InvalidDirectory_ReturnsEmptyCollection()
	{
		// Arrange
		var invalidDirectory = new DirectoryInfo("NonExistentDirectory");

		// Act
		var assemblies = AssemblyHelper.FindAssembliesFromDirectory(invalidDirectory);

		// Assert
		Assert.IsNotNull(assemblies, "Expected a non-null collection of assemblies.");
		Assert.AreEqual(0, assemblies.Count, "Expected an empty collection for a non-existent directory.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void LoadAssembliesFromDirectory_NullDirectory_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.FindAssembliesFromDirectory(null!);
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_ValidDirectory_ReturnsAssemblies()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var assemblies = AssemblyHelper.FindAssembliesFromDirectory(assemblyFile.Directory);

		this.PrintToDebug<FileInfo>(assemblies, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(assemblies, "Expected a non-null collection of assemblies.");
		Assert.IsTrue(assemblies.Count > 0, "Expected at least one assembly in the directory.");
		Assert.IsTrue(assemblies.Any(assembly => assembly.FullName!.Contains("DotNetTips.Spargine.Core")), "Expected the current assembly to be loaded.");
	}


	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void LoadAssemblyTypes_NullFile_ThrowsArgumentNullException()
	{
		// Act
		_ = AssemblyHelper.GetAssemblyTypes(null!);
	}

	[TestMethod]
	public void LoadAssemblyTypes_ValidAssembly_ReturnsTypes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.GetAssemblyTypes(assemblyFile);

		this.SaveToFile<Type>(result, prop => prop.Name == "Name", nameof(AssemblyHelper.GetAssemblyTypes));

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find types in the assembly, but none were found.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void PrintToDebug_NullPropertySelector_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new List<object> { new { Name = "Test" } };

		// Act
		this._unitTester.PrintToDebug(collection, null);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void SaveToFile_NullPropertySelector_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new List<object> { new { Name = "Test" } };

		// Act
		this._unitTester.SaveToFile(collection, null);
	}

	[TestInitialize]
	public void Setup()
	{
		this._testOutputDirectory = Path.Combine(Path.GetTempPath(), "UnitTesterTests");
		Directory.CreateDirectory(this._testOutputDirectory);
		this._unitTester = new TestUnitTester(this._testOutputDirectory);
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

		this.PrintToDebug(result.ToString());

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

	private class TestUnitTester : UnitTester
	{
		public TestUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}
}

