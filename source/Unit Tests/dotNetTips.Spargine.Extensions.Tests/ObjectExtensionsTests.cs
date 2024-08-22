// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-21-2024
// ***********************************************************************
// <copyright file="ObjectExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ObjectExtensionsTests : TestClass
{
	[TestMethod]
	public void CloneTest()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		try
		{
			var clonedPerson = person.Clone<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>();

			Assert.IsNotNull(clonedPerson);
			Assert.IsFalse(person.Equals(clonedPerson));
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ComputeSha256HashTest()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = person.ComputeSha256Hash();

		//PrintResult(result, nameof(this.ComputeSha256HashTest));

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void DisposeFieldsTest()
	{
		var disposableObj = new DisposableFields();
		DisposableFields nullTest = null;

		try
		{
			disposableObj.DisposeFields();
			nullTest.DisposeFields();
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void FastGetHashCodeArrayTest()
	{
		int[] numbers = { 1, 2, 3, 4, 5 };

		var hashCode = numbers.GetHashCode();
		var fastHashCode = numbers.FastGetHashCode();

		Assert.AreEqual(hashCode, fastHashCode);
	}

	[TestMethod]
	public void FastGetHashCodePersonTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var hashCode = person.GetHashCode();
		var fastHashCode = person.FastGetHashCode();

		Assert.AreEqual(hashCode, fastHashCode);
	}

	[TestMethod]
	public void FromJsonTest()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>().ToJson();

		Assert.IsNotNull(person.FromJson<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>());
	}

	[TestMethod]
	public void HasPropertyTest()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		Assert.IsTrue(person.HasProperty("Id"));

		Assert.IsFalse(person.HasProperty("XXXXXXXXXXXXX"));
	}

	[TestMethod]
	public void InitializeFieldsTest()
	{
		var testObject = new DisposableFields();

		testObject.InitializeFields();
	}

	[TestMethod]
	public void NullObjectTest()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> nullPerson = null;

		Assert.IsFalse(person.IsNull());
		Assert.IsTrue(nullPerson.IsNull());

		Assert.IsTrue(person.IsNotNull());
		Assert.IsFalse(nullPerson.IsNotNull());
	}

	[TestMethod]
	public void PropertiesToDictionaryTest()
	{
		var personProper = RandomData.GeneratePersonRecord();

		var propertiesTest = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			Person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>(),
			PersonRecord = RandomData.GeneratePersonRecord(),
			Today = DateTime.Now
		};

		var result = personProper.PropertiesToDictionary(memberName: $"Person-{personProper.Id}", ignoreNulls: true);

		Assert.IsTrue(result.FastCount() > 1);

		result = propertiesTest.PropertiesToDictionary(memberName: $"TestPerson-{personProper.Id}", ignoreNulls: true);

		Assert.IsTrue(result.FastCount() > 1);
	}

	[TestMethod]
	public void PropertiesToStringTest()
	{
		var personRecord = RandomData.GeneratePersonRecord();

		var propertiesTest = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			Person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>(),
			PersonRecord = RandomData.GeneratePersonRecord(),
			Today = DateTimeOffset.Now,
			ClosedOn = DateTimeOffset.Now,
		};

		var result = personRecord.PropertiesToString(
			header: "PersonRecord",
			keyValueSeparator: ':',
			sequenceSeparator: ", ",
			ignoreNulls: true);

		Assert.IsTrue(result.Length > 100);
		Assert.IsTrue(result.Contains("Addresses"));

		//PrintResult(result, nameof(this.PropertiesToStringTest));

		result = propertiesTest.PropertiesToString(
			header: "PersonRecord",
			keyValueSeparator: ':',
			sequenceSeparator: ", ",
			ignoreNulls: true,
			includeMemberName: false);

		Assert.IsTrue(result.Length > 100);
		Assert.IsTrue(result.Contains("Addresses"));

		//PrintResult(result, nameof(this.PropertiesToStringTest));

		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		result = person.PropertiesToString(header: person.Id);

		Assert.IsTrue(result.Length > 500);
		Assert.IsTrue(result.Contains("Address1"));

		//PrintResult(result, nameof(this.PropertiesToStringTest));

		var coordinate = RandomData.GenerateCoordinate<Coordinate>();

		result = coordinate.PropertiesToString();

		Assert.IsTrue(result.Length > 50);
		Assert.IsTrue(result.Contains("X"));

		//PrintResult(result, nameof(this.PropertiesToStringTest));

		var personCollection = RandomData.GeneratePersonRecordCollection(5);

		result = personCollection.PropertiesToString();
		Assert.IsTrue(result.Contains("LastName"));
		Assert.IsTrue(result.Length > 1000);
	}

	[TestMethod]
	public void StripNullTest()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> nullPerson = null;

		Assert.IsFalse(string.IsNullOrEmpty(person.StripNull()));
		Assert.IsTrue(string.IsNullOrEmpty(nullPerson.StripNull()));
	}

	[TestMethod]
	public void ToJsonFileTest()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var fileName = new FileInfo(RandomData.GenerateRandomFileName());

		try
		{
			person.ToJsonFile(fileName);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}

		File.Delete(fileName.FullName);
	}

	[TestMethod]
	public void ToJsonTest_01()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		Assert.IsFalse(string.IsNullOrEmpty(person.ToJson()));
	}

	[TestMethod]
	public void ToJsonTest_02()
	{
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var json = person.ToJson(JsonSerializerOptions.Default);

		Assert.IsTrue(json.Status == ResultStatus.Succeeded);
		Assert.IsFalse(string.IsNullOrEmpty(json.Value));
	}

	[TestMethod]
	public void TryDisposeTest()
	{
		var disposableObj = new DisposableFields();

		try
		{
			disposableObj.TryDispose();
			disposableObj.TryDispose(true);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}
}
