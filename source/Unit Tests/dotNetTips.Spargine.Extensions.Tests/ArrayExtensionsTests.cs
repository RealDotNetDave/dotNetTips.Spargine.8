// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-02-2024
// ***********************************************************************
// <copyright file="ArrayExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

/// <summary>
/// Defines test class ArrayExtensionsTests.
/// </summary>
[ExcludeFromCodeCoverage]
[TestClass]
public class ArrayExtensionsTests
{

	/// <summary>
	/// Defines the test method AddFirstTest.
	/// </summary>
	[TestMethod]
	public void AddFirstTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = people.AddFirst(person);

		Assert.IsTrue(result.FastCount() == 11);
	}

	/// <summary>
	/// Defines the test method AddIfTest.
	/// </summary>
	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = people.AddIf(person, people.Length == 10);

		Assert.IsTrue(result.FastCount() == 11);
	}

	/// <summary>
	/// Defines the test method AddLastTest.
	/// </summary>
	[TestMethod]
	public void AddLastTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = people.AddLast(person);

		Assert.IsTrue(result.FastCount() == 11);
		Assert.IsTrue(result.Last() == person);

		Assert.IsTrue(result.AddLast(null).FastCount() == 11);
	}

	/// <summary>
	/// Defines the test method AreEqualTest.
	/// </summary>
	[TestMethod]
	public void AreEqualTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var people2 = people1;
		var people3 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();

		Assert.IsFalse(people1.AreEqual(people3));

		Assert.IsTrue(people1.AreEqual(people2));

		Assert.IsFalse(people1.AreEqual(arrayToCheck: null));
	}

	[TestMethod]
	public void AsReadOnlySpanTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.AsReadOnlySpan();

		Assert.IsTrue(result.Length == 10);
	}

	[TestMethod]
	public void AsReadOnlyTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.AsReadOnly();

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == 10);
	}

	/// <summary>
	/// Defines the test method BytesToStringTest.
	/// </summary>
	[TestMethod]
	public void BytesToStringTest()
	{
		var bytes = RandomData.GenerateByteArray(100);

		var result = bytes.BytesToString();

		Assert.IsTrue(result.Length > 100);
	}

	/// <summary>
	/// Defines the test method BytesToStringUsingSpanTest.
	/// </summary>
	[TestMethod]
	public void BytesToStringUsingSpanTest()
	{
		var bytes = RandomData.GenerateByteArray(100);

		var readOnlySpan = new ReadOnlySpan<byte>(bytes);
		var result = readOnlySpan.BytesToString();

		Assert.IsTrue(result.Length > 100);
	}

	/// <summary>
	/// Defines the test method CloneTest.
	/// </summary>
	[TestMethod]
	public void CloneTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();

		var result = people.Clone<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>();

		Assert.IsTrue(people.AreEqual(result));
	}

	/// <summary>
	/// Defines the test method ContainsAnyTest.
	/// </summary>
	[TestMethod]
	public void ContainsAnyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		Assert.IsFalse(people.ContainsAny(person));

		Assert.IsTrue(people.ContainsAny(people.Last()));

		//Person[] nullPerson = default;

		//Assert.IsFalse(words.ContainsAny(nullPerson));

	}

	/// <summary>
	/// Defines the test method DoesNotHasItemsTest.
	/// </summary>
	[TestMethod]
	public void DoesNotHasItemsTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>[] nullPeople = null;

		Assert.IsFalse(people1.DoesNotHaveItems());

		Assert.IsTrue(nullPeople.DoesNotHaveItems());
	}

	[TestMethod]
	public void FastHashData_EmptyData_ReturnsEmptyHash()
	{
		// Arrange
		var data = new byte[0];

		// Act
		var result = data.FastHashData();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	public void FastHashData_ValidData_ReturnsHash()
	{
		// Arrange
		var data = Encoding.UTF8.GetBytes("Test data");

		// Act
		var result = data.FastHashData();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Length > 0);
	}

	/// <summary>
	/// Defines the test method FastProcessorTest.
	/// </summary>
	[TestMethod]
	public void FastProcessorTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(100).ToArray();

		people.FastProcessor((Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> person) => person.LastName = "TEST NAME");
	}

	/// <summary>
	/// Defines the test method HasItemsTest.
	/// </summary>
	[TestMethod]
	public void HasItemsTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>[] nullPeople = null;

		Assert.IsTrue(people1.HasItems());

		Assert.IsFalse(nullPeople.HasItems());
	}

	/// <summary>
	/// Defines the test method HasItemsTestWithCount.
	/// </summary>
	[TestMethod]
	public void HasItemsTestWithCount()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>[] nullPeople = null;

		Assert.IsTrue(people1.HasItems(10));

		Assert.IsFalse(people1.HasItems(100));

		Assert.IsFalse(nullPeople.HasItems(10));

	}

	/// <summary>
	/// Defines the test method HasItemsTestWithFunction.
	/// </summary>
	[TestMethod]
	public void HasItemsTestWithFunction()
	{
		var collection = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>[] nullCollection = null;

		Func<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>, bool> selector = (person) => person.Email.IsNotNull();

		Assert.IsTrue(collection.HasItems(selector));

		Assert.IsFalse(nullCollection.HasItems(selector));

		Assert.IsFalse(nullCollection.HasItems(null));
	}

	/// <summary>
	/// Defines the test method PerformActionTest_Ref.
	/// </summary>
	[TestMethod]
	public void PerformActionTest_Ref()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append($"{person.ToString()}|"));

		Assert.IsTrue(sb.Length > 1000);
	}

	/// <summary>
	/// Defines the test method PerformActionTest_Val.
	/// </summary>
	[TestMethod]
	public void PerformActionTest_Val()
	{
		var people = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(10).ToArray();
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append($"{person.ToString()}|"));

		Assert.IsTrue(sb.Length > 100);
	}

	/// <summary>
	/// Defines the test method RemoveLastTest.
	/// </summary>
	[TestMethod]
	public void RemoveLastTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(100).ToArray();

		var result = people.RemoveLast();

		Assert.IsTrue(result.FastCount() == 99);
	}

	/// <summary>
	/// Defines the test method ToDistinctTest.
	/// </summary>
	[TestMethod]
	public void ToDistinctTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		words = words.AddLast(words.First());

		Assert.IsTrue(words.ToDistinct().FastCount() == 10);
	}

	[TestMethod]
	public void ToFrozenSetTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.ToFrozenSet();

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == 10);
	}

	//[TestMethod]
	//public void PerformActionTest_Record()
	//{
	//	var words = RandomData.GeneratePersonRecordCollection(10).ToArray();
	//	var sb = new StringBuilder();

	//	words.PerformAction((person) =>
	//	{
	//		sb.Append($"{person.ToString()}|");
	//	});

	//	Assert.IsTrue(sb.Length > 100);
	//}

	/// <summary>
	/// Defines the test method UpsertTest01.
	/// </summary>
	[TestMethod]
	public void UpsertTest01()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var personFromCollection = people.Shuffle().First();
		_ = personFromCollection.Phone = "1234567890";
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = people.Upsert(personFromCollection);

		Assert.IsTrue(result.FastCount() == 10);

		result = people.Upsert(person);

		Assert.IsTrue(result.FastCount() == 11);

		result = people.Upsert(personFromCollection);

		Assert.IsTrue(result.FastCount() == 10);

		result = people.Upsert(null);

		Assert.IsTrue(result.FastCount() == 10);
	}

}
