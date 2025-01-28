// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-22-2024
// ***********************************************************************
// <copyright file="XmlSerializationTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Serialization;

[ExcludeFromCodeCoverage]
[TestClass]
public class XmlSerializationTests
{
	/// <summary>
	/// Defines the test method SerializeDeserializeTestCollection.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestCollection()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(2).ToList();

		//Serialize
		var xml = XmlSerialization.Serialize(people);

		var fileName = Path.Combine(App.ExecutingFolder(), "PersonCollectionRef.xml");

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<List<Person<Address>>>(xml);

		Assert.IsNotNull(serializedPerson);

		File.Delete(fileName);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeTestPersonRecord.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPersonRecord()
	{
		var person = RandomData.GeneratePersonRecord();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var fileName = Path.Combine(App.ExecutingFolder(), "PersonRecord.xml");

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<PersonRecord>(xml);

		Assert.IsNotNull(serializedPerson);

		//File.Delete(fileName);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeTestPerson.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPersonRef()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var fileName = Path.Combine(App.ExecutingFolder(), "PersonRef.xml");

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<Person<Address>>(xml);

		Assert.IsNotNull(serializedPerson);

		File.Delete(fileName);
	}

	[TestMethod]
	public void SerializeDeserializeTestPersonVal()
	{
		var person = RandomData.GeneratePersonVal<Tester.Models.ValueTypes.Address>();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var fileName = Path.Combine(App.ExecutingFolder(), "PersonVal.xml");

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>(
			xml);

		Assert.IsNotNull(serializedPerson);

		File.Delete(fileName);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeToFileTest.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeToFileTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var fileName = @"C:\dotNetTips.com\DebugOutput\PersonXmlRef.xml";

		try
		{
			//Serialize
			XmlSerialization.SerializeToFile(person, new FileInfo(fileName));

			//Deserialize
			_ = XmlSerialization.DeserializeFromFile<Person<Address>>(new FileInfo(fileName));

			File.Delete(fileName);
		}
		catch (Exception ex)
		{
			Assert.Fail(ex.Message);
		}

		_ = Assert.ThrowsException<FileNotFoundException>(
			() => XmlSerialization.DeserializeFromFile<Person<Address>>(new FileInfo("XXX")));
	}

	/// <summary>
	/// Defines the test method StringToXDocumentTest.
	/// </summary>
	[TestMethod]
	public void StringToXDocumentTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var result = XmlSerialization.StringToXDocument(xml);

		Assert.IsNotNull(result);
	}
}
