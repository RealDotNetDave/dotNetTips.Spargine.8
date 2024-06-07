// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 09-28-2023
// ***********************************************************************
// <copyright file="JsonSerializationTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Core.Tests.Properties;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests.Serialization;

/// <summary>
/// Defines test class JsonSerializationTests.
/// </summary>
[ExcludeFromCodeCoverage]
[TestClass]
public class JsonSerializationTests
{

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

	/// <summary>
	/// Defines the test method SerializeDeserializeTestPerson.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPerson()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		//Serialize
		var json = JsonSerialization.Serialize(person);

		//For debugging
		JsonSerialization.SerializeToFile(person, new FileInfo(@"C:\dotNetTips.com\DebugOutput\Person.json"));

		Assert.IsTrue(string.IsNullOrEmpty(json) is false);

		//Deserialize
		var serializedPerson = JsonSerialization.Deserialize<Person<Address>>(Resources.JsonPersonProper);

		Assert.IsNotNull(serializedPerson);
	}

	[TestMethod]
	public void SerializeDeserializeTestPersonCollection()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(2);

		//Serialize
		var json = JsonSerialization.Serialize(people);

		//For debugging
		JsonSerialization.SerializeToFile(people, new FileInfo(@"C:\dotNetTips.com\DebugOutput\PersonCollection.json"));

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
		var fileName = @"C:\dotNetTips.com\DebugOutput\PersonRecord.json";

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
		var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "TestData.json");

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

		_ = Assert.ThrowsException<FileNotFoundException>(() => JsonSerialization.DeserializeFromFile<Person<Address>>(new FileInfo($"{fileName}.bogus")));
	}

}
