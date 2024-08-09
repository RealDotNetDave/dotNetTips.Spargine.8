// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-09-2024
// ***********************************************************************
// <copyright file="StringBuilderExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class StringBuilderExtensionsTests
{

	[TestMethod]
	public void AppendBytesTest()
	{
		var sb = new StringBuilder();
		var byteArray = RandomData.GenerateByteArray(sizeInKb: 1);
		sb.AppendBytes(byteArray);

		Assert.IsTrue(sb.Length > 50);

		var pool = new StringBuilder();

		pool.AppendBytes(byteArray);

		Assert.IsTrue(pool.Length > 50);
	}

	[TestMethod]
	public void AppendKeyValueTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToDictionary(p => p.Id);

		var sb = new StringBuilder();

		foreach (var person in people)
		{
			sb.AppendKeyValue(person.Key, person.Value.Email);
			sb.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true);
			sb.AppendKeyValue(person.Key, person.Value.Email, includeComma: true);
			sb.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true, includeComma: true);
		}

		Assert.IsTrue(sb.ToString().Length > 50 * 4);

		var pool = new StringBuilder();

		foreach (var person in people)
		{
			pool.AppendKeyValue(person.Key, person.Value.Email);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeComma: true);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true, includeComma: true);
		}

		Assert.IsTrue(pool.ToString().Length > 50 * 4);
	}

	[TestMethod]
	public void AppendValues01()
	{
		var sb = new StringBuilder();
		var values = RandomData.GenerateWords(count: 5, minLength: 5, maxLength: 7);

		sb.AppendValues(ControlChars.CommaSpace, values);

		Assert.IsTrue(sb.Length > 10);

		var pool = new StringBuilder();

		pool.AppendValues(", ", values);

		Assert.IsTrue(pool.Length > 10);
	}

	[TestMethod]
	public void AppendValues02()
	{
		var sb = new StringBuilder();

		sb.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

		Assert.IsTrue(sb.Length > 10);

		var pool = new StringBuilder();

		pool.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

		Assert.IsTrue(pool.Length > 10);
	}


	[TestMethod]
	public void AppendValuesTest()
	{
		var sb = new StringBuilder();
		var values = RandomData.GenerateCoordinateCollection<Coordinate>(count: 15);

		sb.AppendValues(", ", values, (person) =>
		{
			_ = sb.Append(person.X);
			_ = sb.Append(ControlChars.Colon);
			_ = sb.Append(person.Y);
		});

		Assert.IsTrue(sb.Length > 50);

		var pool = new StringBuilder();

		pool.AppendValues(", ", values, (person) =>
		{
			_ = pool.Append(person.X);
			_ = pool.Append(ControlChars.Colon);
			_ = pool.Append(person.Y);
		});

		Assert.IsTrue(pool.Length > 50);
	}


	[TestMethod]
	public void AppendValuesWithParamTest()
	{
		var sb = new StringBuilder();
		var values = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(count: 5);
		string separator = ", ";
		string format = "{0} - {1}";

		sb.AppendValues(separator, values, format, (person, fmt) =>
		{
			_ = sb.AppendFormat(fmt, person.FirstName, person.LastName);
		});

		Assert.IsTrue(sb.Length > 0, "StringBuilder should contain formatted values.");

		var pool = new StringBuilder();

		pool.AppendValues(separator, values, format, (person, fmt) =>
		{
			_ = pool.AppendFormat(fmt, person.FirstName, person.LastName);
		});

		Assert.IsTrue(pool.Length > 0, "StringBuilder should contain formatted values in the pool instance.");
	}

	[TestMethod]
	public void AppendValuesWithTwoParamsEmptyValuesTest()
	{
		var sb = new StringBuilder();
		var values = new List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>(); // Empty collection
		string separator = ", ";

		sb.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> person, string param1, string param2) =>
		{
			// This block should not execute because the collection is empty
			Assert.Fail("The action should not be executed for an empty collection.");
		});

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty for an empty input collection.");
		var pool = new StringBuilder();

		pool.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> person, string param1, string param2) =>
		{
			// This block should not execute because the collection is empty
			Assert.Fail("The action should not be executed for an empty collection.");
		});

		Assert.AreEqual(0, pool.Length, "StringBuilder should remain empty for an empty input collection in the pool instance.");
	}

	[TestMethod]
	public void AppendValuesWithTwoParamsTest()
	{
		var sb = new StringBuilder();
		var values = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(count: 5);
		string separator = ", ";
		string format = "{0} - {1} lives at {2}";

		sb.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> person, string param1, string param2) =>
		{
			_ = builder.AppendFormat(format, person.FirstName, person.LastName, person.Addresses, param1, param2);
		});

		Assert.IsTrue(sb.Length > 0, "StringBuilder should contain formatted values.");
		var pool = new StringBuilder();

		pool.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> person, string param1, string param2) =>
		{
			_ = builder.AppendFormat(format, person.FirstName, person.LastName, person.Addresses, param1, param2);
		});

		Assert.IsTrue(pool.Length > 0, "StringBuilder should contain formatted values in the pool instance.");
	}

}
