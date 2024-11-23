// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 11-23-2024
// ***********************************************************************
// <copyright file="TypeHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
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
		var result = TypeHelper.BuiltInTypeNames;

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
	public void GetTypeDisplayNameTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var result = TypeHelper.GetTypeDisplayName(person);

		Assert.IsTrue(
			string.Compare(
					result,
					"DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>",
					StringComparison.Ordinal) ==
				0);

		result = TypeHelper.GetTypeDisplayName(person, true);

		Assert.IsTrue(
			string.Compare(
					result,
					"DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>",
					StringComparison.Ordinal) ==
				0);

		result = TypeHelper.GetTypeDisplayName(typeof(int), true, true, true, '-');

		Assert.IsTrue(string.Compare(result, "int", StringComparison.Ordinal) == 0);

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
		Assert.AreEqual("System.Collections.Generic.Dictionary<string, int>", result);
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
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Collections.Generic.List<string>, System.Collections.Generic.Dictionary<int, string>>", result);
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
		Assert.AreEqual("System.Collections.Generic.List<int>", result);
	}

}
