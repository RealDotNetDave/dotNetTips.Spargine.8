// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2025
// ***********************************************************************
// <copyright file="TypeHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DotNetTips.Spargine.Core.TypeHelper;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
[Guid("5AE2E147-D4DB-4FA4-AAE4-0675C3A2DFC5")]
public class TypeHelperTests : TestClass
{

	[TestMethod]
	public void BuiltInTypeNames01()
	{
		var result = TypeHelper.BuiltInTypeNames().Values;

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void BuiltinTypesTest()
	{
		var result = TypeHelper.BuiltinTypes;

		Assert.IsNotNull(result);

		Assert.IsTrue(result.Count >= 16);
	}

	[TestMethod]
	public void CreateTypeTest01()
	{
		var result = TypeHelper.Create<Person<Address>>();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void CreateTypeTest02()
	{
		var result = TypeHelper.Create<Person<Address>>("TESTID", "DOTNETDAVE@LIVE.COM");

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void DoesObjectEqualInstance01()
	{
		var person = RandomData.GeneratePersonRef<Address>();
		var testPerson = person;

		Assert.IsTrue(TypeHelper.DoesObjectEqualInstance(person, testPerson));
	}

	[TestMethod]
	public void DoesObjectEqualInstance02()
	{
		var person = RandomData.GeneratePersonRef<Address>();
		var testPerson = RandomData.GeneratePersonRef<Address>();

		Assert.IsFalse(TypeHelper.DoesObjectEqualInstance(person, testPerson));
	}

	[TestMethod]
	public void FindDerivedTypes_AppDomain_NullBaseType_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, null, true));
	}

	[TestMethod]
	public void FindDerivedTypes_AppDomain_NullDomain_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(null, typeof(Exception), true));
	}

	[TestMethod]
	public void FindDerivedTypes_AppDomain_ValidBaseType_ReturnsDerivedTypes()
	{
		// Act
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(Exception), true);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0);
	}

	[TestMethod]
	public void FindDerivedTypes_CurrentlyLoadedAssemblies_NullBaseType_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(null, true));
	}

	[TestMethod]
	public void FindDerivedTypes_CurrentlyLoadedAssemblies_ValidBaseType_ReturnsDerivedTypes()
	{
		// Act
		var result = TypeHelper.FindDerivedTypes(typeof(Exception), true);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0);
	}

	[TestMethod]
	public void FindDerivedTypes_Directory()
	{
		var result = TypeHelper.FindDerivedTypes(
			new DirectoryInfo(App.ExecutingFolder()),
			SearchOption.AllDirectories,
			typeof(MulticastDelegate),
			true);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void FindDerivedTypes_Directory_InvalidPath_ThrowsDirectoryNotFoundException()
	{
		// Act & Assert
		Assert.ThrowsException<DirectoryNotFoundException>(() => TypeHelper.FindDerivedTypes(new DirectoryInfo(@"C:\InvalidPath"), SearchOption.AllDirectories, typeof(Exception), true));
	}

	[TestMethod]
	public void FindDerivedTypes_Directory_NullBaseType_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(new DirectoryInfo(App.ExecutingFolder()), SearchOption.AllDirectories, null, true));
	}

	[TestMethod]
	public void FindDerivedTypes_Directory_NullPath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(null, SearchOption.AllDirectories, typeof(Exception), true));
	}

	[TestMethod]
	public void FindDerivedTypes_Exception()
	{
		var result = TypeHelper.FindDerivedTypes(typeof(Exception), true);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void FindDerivedTypes_MulticastDelegate()
	{
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(MulticastDelegate), true);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void FromJson01()
	{
		var person = RandomData.GeneratePersonRef<Address>();
		var json = person.ToJson();

		Assert.IsNotNull(TypeHelper.FromJson<Person<Address>>(json));
	}

	[TestMethod]
	public void FromJsonFile_InvalidJson_ThrowsJsonException()
	{
		// Arrange
		var invalidJson = "{ invalid json }";
		var fileName = Path.GetTempFileName();
		File.WriteAllText(fileName, invalidJson);
		var fileInfo = new FileInfo(fileName);

		// Act & Assert
		Assert.ThrowsException<JsonException>(() => TypeHelper.FromJsonFile<Person<Address>>(fileInfo));

		// Cleanup
		File.Delete(fileName);
	}

	[TestMethod]
	public void FromJsonFile_NonExistentFile_ThrowsFileNotFoundException()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\nonexistentfile.json");

		// Act & Assert
		Assert.ThrowsException<FileNotFoundException>(() => TypeHelper.FromJsonFile<Person<Address>>(fileInfo));
	}

	[TestMethod]
	public void FromJsonFile_NullFile_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.FromJsonFile<Person<Address>>(null));
	}

	[TestMethod]
	public void FromJsonFile_ValidJson_ReturnsDeserializedObject()
	{
		// Arrange
		var person = RandomData.GeneratePersonRef<Address>();
		var json = person.ToJson();
		var fileName = Path.GetTempFileName();
		File.WriteAllText(fileName, json);
		var fileInfo = new FileInfo(fileName);

		// Act
		var result = TypeHelper.FromJsonFile<Person<Address>>(fileInfo);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(person.Id, result.Id);
		Assert.AreEqual(person.Email, result.Email);

		// Cleanup
		File.Delete(fileName);
	}

	[TestMethod]
	public void FromJsonFile01()
	{
		var person = RandomData.GeneratePersonRef<Address>();
		var fileName = RandomData.GenerateRandomFileName();

		person.ToJsonFile(new FileInfo(fileName));

		Assert.IsNotNull(TypeHelper.FromJsonFile<Person<Address>>(new FileInfo(fileName)));

		File.Delete(fileName);
	}

	[TestMethod]
	public void GetDefault01()
	{
		var result = TypeHelper.GetDefault<AccessControlType>();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetInstanceHashCode_EmptyObject_ReturnsHashCode()
	{
		// Arrange
		var emptyObject = new { };

		// Act
		var hashCode = TypeHelper.GetInstanceHashCode(emptyObject);

		// Assert
		Assert.AreNotEqual(0, hashCode, "Hash code should not be zero.");
	}

	[TestMethod]
	public void GetInstanceHashCode_NullObject_ThrowsArgumentNullException()
	{
		// Arrange
		object nullObject = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.GetInstanceHashCode(nullObject), "Null object should throw ArgumentNullException.");
	}

	[TestMethod]
	public void GetInstanceHashCode_ValidObject_ReturnsHashCode()
	{
		// Arrange
		var person = RandomData.GeneratePersonRef<Address>();

		// Act
		var hashCode = TypeHelper.GetInstanceHashCode(person);

		// Assert
		Assert.AreNotEqual(0, hashCode, "Hash code should not be zero.");
	}

	[TestMethod]
	public void GetMembersWithAttribute_WithNoAttributes_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(DataTable);

		// Act
		var members = TypeHelper.GetMembersWithAttribute<InformationAttribute>(type);

		// Assert
		Assert.IsNotNull(members);
		Assert.IsFalse(members.Any());
	}

	[TestMethod]
	public void GetMembersWithAttribute_WithNullType_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.GetMembersWithAttribute<InformationAttribute>(null));
	}

	[TestMethod]
	public void GetMembersWithAttribute_WithValidType_ReturnsMembersWithAttribute()
	{
		// Arrange
		var type = typeof(Person<Address>);

		// Act
		var members = TypeHelper.GetMembersWithAttribute<InformationAttribute>(type);

		// Assert
		Assert.IsNotNull(members);
		Assert.IsTrue(members.Any());
	}

	[TestMethod]
	public void GetPropertyValues()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var result = TypeHelper.GetPropertyValues(person);
		Assert.IsTrue(result.Count > 5);

		var exTest = new ArgumentOutOfRangeException("TESTPARAM", "TESTMESSAGE");

		result = TypeHelper.GetPropertyValues(exTest);

		Assert.IsTrue(result.Count > 1);
	}

	[TestMethod]
	public void GetPropertyValues_EmptyObject_ReturnsEmptyCollection()
	{
		// Arrange
		var emptyObject = new { };

		// Act
		var result = TypeHelper.GetPropertyValues(emptyObject);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void GetPropertyValues_NullInput_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.GetPropertyValues<object>(null));
	}

	[TestMethod]
	public void GetPropertyValues_ObjectWithComplexProperty_ReturnsComplexPropertyAsString()
	{
		// Arrange
		var complexObject = new { Address = new { Street = "123 Main St", City = "Anytown" } };

		// Act
		var result = TypeHelper.GetPropertyValues(complexObject);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Count);
		Assert.IsTrue(result.Any(kv => kv.Key == "Address" && kv.Value.Contains("Street") && kv.Value.Contains("City")));
	}

	[TestMethod]
	public void GetPropertyValues_ObjectWithDictionaryProperty_ReturnsDictionaryAsString()
	{
		// Arrange
		var objectWithDictionary = new { Data = new Dictionary<string, int> { { "Key1", 1 }, { "Key2", 2 } } };

		// Act
		var result = TypeHelper.GetPropertyValues(objectWithDictionary);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Count);
		Assert.IsTrue(result.Any(kv => kv.Key == "Data" && kv.Value == "Key1: 1,Key2: 2"));
	}

	[TestMethod]
	public void GetPropertyValues_ObjectWithNullProperty_ReturnsNullAsString()
	{
		// Arrange
		var objectWithNullProperty = new { Name = (string)null };

		// Act
		var result = TypeHelper.GetPropertyValues(objectWithNullProperty);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void GetPropertyValues_SimpleObject_ReturnsPropertyValues()
	{
		// Arrange
		var simpleObject = new { Name = "Test", Age = 30 };

		// Act
		var result = TypeHelper.GetPropertyValues(simpleObject);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Count);
		Assert.IsTrue(result.Any(kv => kv.Key == "Name" && kv.Value == "Test"));
		Assert.IsTrue(result.Any(kv => kv.Key == "Age" && kv.Value == "30"));
	}

	[TestMethod]
	public void GetTypeDisplayName_WithArrayType_ReturnsArrayTypeName()
	{
		// Arrange
		var type = typeof(int[]);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Int32[]", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithFullNameOption_ReturnsFullName()
	{
		// Arrange
		var type = typeof(List<int>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.List<System.Int32>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithGenericParameterNames_ReturnsNames()
	{
		// Arrange
		var type = typeof(Dictionary<,>);
		var options = new DisplayNameOptions(fullName: false, includeGenericParameterNames: true, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("Dictionary<TKey, TValue>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithGenericParameterNamesAndFullName_ReturnsFullNameWithParameterNames()
	{
		// Arrange
		var type = typeof(Dictionary<,>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: true, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.Dictionary<TKey, TValue>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithGenericType_ReturnsGenericTypeName()
	{
		// Arrange
		var type = typeof(Dictionary<int, List<string>>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithNestedGenericType_ReturnsNestedGenericTypeName()
	{
		// Arrange
		var type = typeof(Dictionary<int, List<Dictionary<string, int>>>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Int32>>>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithNestedTypeDelimiter_ReturnsCustomDelimiter()
	{
		// Arrange
		var type = typeof(Dictionary<int, List<string>>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithShortNameOption_ReturnsShortName()
	{
		// Arrange
		var type = typeof(List<int>);
		var options = new DisplayNameOptions(fullName: false, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("List<Int32>", result);
	}

	[TestMethod]
	public void GetTypeDisplayNameTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var result = TypeHelper.GetTypeDisplayName(person);

		Assert.IsTrue(string.Compare(result, "DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>",
					StringComparison.Ordinal) == 0);

		result = TypeHelper.GetTypeDisplayName(person, true);

		Assert.IsTrue(string.Compare(result, "DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>", StringComparison.Ordinal) == 0);

		result = TypeHelper.GetTypeDisplayName(typeof(int), true, true, true, '-');

		Assert.IsTrue(string.Compare(result, "System.Int32", StringComparison.Ordinal) == 0);

		var people = RandomData.GeneratePersonRefCollection<Address>(5);

		result = TypeHelper.GetTypeDisplayName(people);

		Assert.IsTrue(result.Length > 0);

		result = TypeHelper.GetTypeDisplayName(RandomData.GeneratePersonRef<Address>());

		Assert.IsTrue(result.Length > 0);
	}

	[TestMethod]
	public void IsBuiltInTypeTest_Int()
	{
		var result = TypeHelper.IsBuiltinType(typeof(Int64));

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsBuiltInTypeTest_PersonRecord()
	{
		var result = TypeHelper.IsBuiltinType(typeof(PersonRecord));

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_BadImageFormatException_ReturnsFalse()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\Windows\System32\ntdll.dll");

		// Act
		var result = TypeHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_InvalidAssembly_ReturnsFalse()
	{
		// Arrange
		var fileInfo = new FileInfo(@"c:\windows\twain_32.dll");

		// Act
		var result = TypeHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_InvalidDotNetAssembly_ReturnsFalse()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\Windows\System32\kernel32.dll");

		// Act
		var result = TypeHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_IOException_FileNotFoundException()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\Windows\System32\config\SYSTEM");

		// Act & Assert
		Assert.ThrowsException<FileNotFoundException>(() => TypeHelper.IsDotNetAssembly(fileInfo));
	}

	[TestMethod]
	public void IsDotNetAssembly_NonExistentFile_ThrowsFileNotFoundException()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\nonexistentfile.dll");

		// Act & Assert
		Assert.ThrowsException<FileNotFoundException>(() => TypeHelper.IsDotNetAssembly(fileInfo));
	}

	[TestMethod]
	public void IsDotNetAssembly_NullFile_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TypeHelper.IsDotNetAssembly(null));
	}

	[TestMethod]
	public void IsDotNetAssembly_ValidAssembly_ReturnsTrue()
	{
		// Arrange
		var assemblyPath = Assembly.GetExecutingAssembly().Location;
		var fileInfo = new FileInfo(assemblyPath);

		// Act
		var result = TypeHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_ValidDotNetAssembly_ReturnsTrue()
	{
		// Arrange
		var assemblyPath = Assembly.GetExecutingAssembly().Location;
		var fileInfo = new FileInfo(assemblyPath);

		// Act
		var result = TypeHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ProcessGenericType_EmptyGenericArguments()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(List<>);
		var genericArguments = Array.Empty<Type>();
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.List<>", result);
	}

	[TestMethod]
	public void ProcessGenericType_MultipleGenericArguments()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(Dictionary<,>);
		var genericArguments = new[] { typeof(string), typeof(int) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.String, System.Int32>", result);
	}

	[TestMethod]
	public void ProcessGenericType_NestedGenericTypes()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(Dictionary<,>);
		var genericArguments = new[] { typeof(List<string>), typeof(Dictionary<int, string>) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Collections.Generic.List<System.String>, System.Collections.Generic.Dictionary<System.Int32, System.String>>", result);
	}

	[TestMethod]
	public void ProcessGenericType_SingleGenericArgument()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(List<>);
		var genericArguments = new[] { typeof(int) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.List<System.Int32>", result);
	}

	[TestMethod]
	public void ProcessGenericType_WithArrayGenericArgument()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(List<>);
		var genericArguments = new[] { typeof(int[]) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.List<System.Int32[]>", result);
	}

	[TestMethod]
	public void ProcessGenericType_WithNestedGenericTypeAndCustomDelimiter()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(Dictionary<,>);
		var genericArguments = new[] { typeof(List<string>), typeof(Dictionary<int, string>) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Collections.Generic.List<System.String>, System.Collections.Generic.Dictionary<System.Int32, System.String>>", result);
	}
}
