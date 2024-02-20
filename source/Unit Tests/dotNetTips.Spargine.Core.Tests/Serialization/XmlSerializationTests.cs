// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2024
// ***********************************************************************
// <copyright file="XmlSerializationTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests.Serialization;

/// <summary>
/// Defines test class XmlSerializationTests.
/// </summary>
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

		var fileName = @"C:\dotNetTips.com\DebugOutput\PersonCollection.xml";

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<Person<Address>[]>(xml);

		Assert.IsNotNull(serializedPerson);

		File.Delete(fileName);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeTestPerson.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPerson()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var fileName = @"C:\dotNetTips.com\DebugOutput\Person.xml";

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<Person<Address>>(xml);

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

		var fileName = @"C:\dotNetTips.com\DebugOutput\PersonRecord.xml";

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<PersonRecord>(xml);

		Assert.IsNotNull(serializedPerson);

		//File.Delete(fileName);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeToFileTest.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeToFileTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var fileName = @"C:\dotNetTips.com\DebugOutput\TestXml.xml";

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

		_ = Assert.ThrowsException<FileNotFoundException>(() => XmlSerialization.DeserializeFromFile<Person<Address>>(new FileInfo("XXX")));
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
