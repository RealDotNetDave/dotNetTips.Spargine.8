// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="JsonSerializationTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spartine.Core.Tests.Serialization
{
	/// <summary>
	/// Defines test class JsonSerializationTests.
	/// </summary>
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class BinarySerializationTests
	{

		/// <summary>
		/// Defines the test method SerializeDeserializeTestPersonProper.
		/// </summary>
		[TestMethod]
		public void SerializeDeserializeTestPersonProper()
		{
			var person = RandomData.GenerateRefPerson<PersonProper>();

			//Serialize
			var result = BinarySerialization.Serialize(person);

			//For debugging
			BinarySerialization.SerializeToFile(person, @"C:\dotNetTips.com\DebugOutput\PersonProper.bin");

			Assert.IsTrue(result.CheckItemsExists());

			//Deserialize
			var serializedPerson = BinarySerialization.Deserialize<PersonProper>(result);

			Assert.IsNotNull(serializedPerson);
		}

		/// <summary>
		/// Defines the test method SerializeDeserializeTestPersonRecord.
		/// </summary>
		[TestMethod]
		public void SerializeDeserializeTestPersonRecord()
		{
			var person = RandomData.GeneratePersonRecordCollection(1).First();

			var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "PersonRecord.bin");

			//For debugging
			BinarySerialization.SerializeToFile(person, fileName);

			Assert.IsTrue(File.ReadAllBytes(fileName).CheckItemsExists());

			//Deserialize
			var serializedPerson = BinarySerialization.DeserializeFromFile<PersonRecord>(fileName);

			Assert.IsNotNull(serializedPerson);
		}

		/// <summary>
		/// Defines the test method SerializeDeserializeToFileTestPersonProper.
		/// </summary>
		[TestMethod]
		public void SerializeDeserializeToFileTestPersonProper()
		{
			var person = RandomData.GenerateRefPerson<PersonProper>();
			var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "TestData.json");

			try
			{
				//Serialize
				BinarySerialization.SerializeToFile(person, fileName);

				//Deserialize
				_ = BinarySerialization.DeserializeFromFile<PersonProper>(fileName);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}

			_ = Assert.ThrowsException<FileNotFoundException>(() => BinarySerialization.DeserializeFromFile<PersonProper>($"{fileName}.bogus"));
		}
	}
}
