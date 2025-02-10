// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-10-2025
// ***********************************************************************
// <copyright file="JsonSerializationTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Serialization;

[ExcludeFromCodeCoverage]
[TestClass]
public class JsonSerializationTests
{
	private const int _collectionCount = 100;

	[TestMethod]
	public void JsonEqual_DifferentInputs_ReturnsFalse()
	{
		// Arrange
		var actual = "{\"Name\":\"Test\",\"Value\":1}";
		var expected = "{\"Name\":\"Test\",\"Value\":2}";

		// Act
		var result = JsonSerialization.JsonEqual(actual, expected);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void JsonEqual_EqualInputs_ReturnsTrue()
	{
		// Arrange
		var actual = "{\"Name\":\"Test\",\"Value\":1}";
		var expected = "{\"Name\":\"Test\",\"Value\":1}";

		// Act
		var result = JsonSerialization.JsonEqual(actual, expected);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void JsonEqual_NullActual_ThrowsArgumentNullException()
	{
		// Arrange
		var expected = "{\"Name\":\"Test\",\"Value\":1}";

		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.JsonEqual(null, expected));
	}

	[TestMethod]
	public void LoadCollectionFromJson()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(_collectionCount);

		//Serialize
		var json = JsonSerialization.Serialize(people);

		//Deserialize
		var serializedPeople = JsonSerialization.LoadCollectionFromJson<Person<Address>>(json, _collectionCount);

		Assert.IsNotNull(serializedPeople);
	}

	[TestMethod]
	public void LoadCollectionFromJsonJsonInfoType()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(_collectionCount);

		//Serialize
		var json = JsonSerialization.Serialize(people);

		//Deserialize
		var serializedPeople = JsonSerialization.LoadCollectionFromJson<Person<Address>>(json, _collectionCount, PersonJsonSerializerContext.Default.Person);

		Assert.IsNotNull(serializedPeople);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeTestPerson.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPerson()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		//Serialize
		var json = JsonSerialization.Serialize(person);

		Assert.IsTrue(string.IsNullOrEmpty(json) is false);

		//Deserialize
		var serializedPerson = JsonSerialization.Deserialize<Person<Address>>(json);

		Assert.IsNotNull(serializedPerson);
	}

	[TestMethod]
	public void SerializeDeserializeTestPersonCollection()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(2);

		//Serialize
		var json = JsonSerialization.Serialize(people);

		Assert.IsTrue(string.IsNullOrEmpty(json) is false);

		//Deserialize
		var serializedPeople = JsonSerialization.Deserialize<List<Person<Address>>>(json);

		Assert.IsNotNull(serializedPeople);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeTestPersonRecord.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPersonRecord()
	{
		var fileName = RandomData.GenerateRandomFileName();

		//For debugging
		var person = RandomData.GeneratePersonRecord();
		JsonSerialization.SerializeToFile(person, new FileInfo(fileName));

		Assert.IsTrue(string.IsNullOrEmpty(File.ReadAllText(fileName)) is false);

		//Deserialize
		var serializedPerson = JsonSerialization.DeserializeFromFile<PersonRecord>(new FileInfo(fileName));

		Assert.IsNotNull(serializedPerson);
	}

	[TestMethod]
	public void SerializeDeserializeToFileTestPerson()
	{
		var person = RandomData.GeneratePersonRef<Address>();
		var fileName = RandomData.GenerateRandomFileName();

		try
		{
			//Serialize
			JsonSerialization.SerializeToFile(person, new FileInfo(fileName));

			//Deserialize
			_ = JsonSerialization.DeserializeFromFile<Person<Address>>(new FileInfo(fileName));
		}
		catch (Exception ex)
		{
			Assert.Fail(ex.Message);
		}

		_ = Assert.ThrowsException<FileNotFoundException>(
			() => JsonSerialization.DeserializeFromFile<Person<Address>>(new FileInfo($"{fileName}.bogus")));
	}
}
