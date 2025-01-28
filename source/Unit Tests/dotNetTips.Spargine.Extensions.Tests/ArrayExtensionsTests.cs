// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
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
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ArrayExtensionsTests
{

	[TestMethod]
	public void AddFirstNullTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();

		var result = people.AddFirst(null);

		Assert.IsTrue(result.FastCount() == 10);
	}

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

	[TestMethod]
	public void AddIfNullTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();

		var result = people.AddIf(null, people.Length == 10);

		Assert.IsTrue(result.FastCount() == 10);
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

	[TestMethod]
	public void AreEqual_BothNullArrays_ReturnsFalse()
	{
		// Arrange
		int[] array1 = null;
		int[] array2 = null;

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AreEqual_DifferentArrays_ReturnsFalse()
	{
		// Arrange
		var array1 = new[] { 1, 2, 3, 4, 5 };
		var array2 = new[] { 1, 2, 3, 4, 6 };

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AreEqual_DifferentLengths_ReturnsFalse()
	{
		// Arrange
		var array1 = new[] { 1, 2, 3, 4, 5 };
		var array2 = new[] { 1, 2, 3, 4 };

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AreEqual_NullArray_ReturnsFalse()
	{
		// Arrange
		int[] array1 = null;
		var array2 = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AreEqual_SameArrays_ReturnsTrue()
	{
		// Arrange
		var array1 = new[] { 1, 2, 3, 4, 5 };
		var array2 = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsTrue(result);
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

	[TestMethod]
	public void BytesToString_EmptyByteArray_ReturnsEmptyString()
	{
		// Arrange
		var byteArray = new byte[0];

		// Act
		var result = byteArray.BytesToString();

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void BytesToString_ValidByteArray_ReturnsHexString()
	{
		// Arrange
		var byteArray = new byte[] { 0x0F, 0xA0, 0xB1, 0xC2 };

		// Act
		var result = byteArray.BytesToString();

		// Assert
		Assert.AreEqual("0fa0b1c2", result);
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

	[TestMethod]
	public void ContainsAny_DifferentStringComparison_ReturnsFalse()
	{
		// Arrange
		var input = "Hello, World!";
		var characters = new[] { "H", "W" };

		// Act
		var result = input.ContainsAny(StringComparison.Ordinal, characters);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsAny_DifferentStringComparison_ReturnsTrue()
	{
		// Arrange
		var input = "Hello, World!";
		var characters = new[] { "h", "w" };

		// Act
		var result = input.ContainsAny(StringComparison.Ordinal, characters);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_EmptyCharacters_ReturnsFalse()
	{
		// Arrange
		var input = "Hello, World!";
		var characters = new string[0];

		// Act
		var result = input.ContainsAny(StringComparison.OrdinalIgnoreCase, characters);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_EmptyInput_ReturnsFalse()
	{
		// Arrange
		var input = string.Empty;
		var characters = new[] { "H", "W" };

		// Act
		var result = input.ContainsAny(StringComparison.OrdinalIgnoreCase, characters);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_NullCharacters_ReturnsFalse()
	{
		// Arrange
		var input = "Hello, World!";
		string[] characters = null;

		// Act
		var result = input.ContainsAny(StringComparison.OrdinalIgnoreCase, characters);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_NullInput_ReturnsFalse()
	{
		// Arrange
		string input = null;
		var characters = new[] { "H", "W" };

		// Act
		var result = input.ContainsAny(StringComparison.OrdinalIgnoreCase, characters);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_ValidInput_ReturnsFalse()
	{
		// Arrange
		var input = "Hello, World!";
		var characters = new[] { "X", "Y" };

		// Act
		var result = input.ContainsAny(StringComparison.OrdinalIgnoreCase, characters);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "Hello, World!";
		var characters = new[] { "H", "W" };

		// Act
		var result = input.ContainsAny(StringComparison.OrdinalIgnoreCase, characters);

		// Assert
		Assert.IsTrue(result);
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

	[TestMethod]
	public void PerformAction_ActionWithMultipleAppends_ReturnsConcatenatedString()
	{
		// Arrange
		Action<StringBuilder> action = sb =>
		{
			sb.Append("First part. ");
			sb.Append("Second part. ");
			sb.Append("Third part.");
		};

		// Act
		var result = FastStringBuilder.PerformAction(action);

		// Assert
		Assert.AreEqual("First part. Second part. Third part.", result);
	}

	[TestMethod]
	public void PerformAction_EmptyAction_ReturnsEmptyString()
	{
		// Arrange
		Action<StringBuilder> action = sb => { };

		// Act
		var result = FastStringBuilder.PerformAction(action);

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void PerformAction_NullAction_ReturnsEmptyString()
	{
		// Arrange
		Action<StringBuilder> action = null;

		// Act
		var result = FastStringBuilder.PerformAction(action);

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void PerformAction_ValidAction_ReturnsExpectedString()
	{
		// Arrange
		Action<StringBuilder> action = sb =>
		{
			sb.Append("Hello, ");
			sb.Append("world!");
		};

		// Act
		var result = FastStringBuilder.PerformAction(action);

		// Assert
		Assert.AreEqual("Hello, world!", result);
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

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void RemoveFirst_NullArray_ThrowsArgumentNullException()
	{
		// Arrange
		int[] array = null;

		// Act
		_ = array.RemoveFirst();
	}

	[TestMethod]
	public void RemoveFirst_SingleElementArray_ReturnsEmptyArray()
	{
		// Arrange
		var array = new[] { 1 };

		// Act
		var result = array.RemoveFirst();

		// Assert
		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	public void RemoveFirst_ValidArray_RemovesFirstElement()
	{
		// Arrange
		var array = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array.RemoveFirst();

		// Assert
		Assert.AreEqual(4, result.Length);
		CollectionAssert.AreEqual(new[] { 2, 3, 4, 5 }, result);
	}

	[TestMethod]
	public void RemoveLast_EmptyArray_ReturnsEmptyArray()
	{
		// Arrange
		var array = new int[0];

		// Act
		var result = array.RemoveLast();

		// Assert
		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void RemoveLast_NullArray_ThrowsArgumentNullException()
	{
		// Arrange
		int[] array = null;

		// Act
		_ = array.RemoveLast();
	}

	[TestMethod]
	public void RemoveLast_SingleElementArray_ReturnsEmptyArray()
	{
		// Arrange
		var array = new[] { 1 };

		// Act
		var result = array.RemoveLast();

		// Assert
		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	public void RemoveLast_ValidArray_RemovesLastElement()
	{
		// Arrange
		var array = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array.RemoveLast();

		// Assert
		Assert.AreEqual(4, result.Length);
		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, result);
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

	[TestMethod]
	public void Upsert_ExistingItem_UpdatesArray()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var existingPerson = people.First();
		existingPerson.Phone = "1234567890"; // Modify a property to check for update

		// Act
		var result = people.Upsert(existingPerson);

		// Assert
		Assert.AreEqual(people.Length, result.Length, "The length of the array should remain unchanged when upserting an existing item.");
		Assert.AreEqual("1234567890", result.First().Phone, "The existing item should be updated in the array.");
	}

	[TestMethod]
	public void Upsert_ExistingItemById_UpdatesArray()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var existingPerson = people.First();
		existingPerson.Phone = "1234567890"; // Modify a property to check for update

		// Act
		var result = people.Upsert(existingPerson);

		// Assert
		Assert.AreEqual(people.Length, result.Length, "The length of the array should remain unchanged when upserting an existing item.");
		Assert.AreEqual("1234567890", result.First(p => p.Id == existingPerson.Id).Phone, "The existing item should be updated in the array.");
	}

	[TestMethod]
	public void Upsert_NewItem_AddsToArray()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToArray();
		var newPerson = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		// Act
		var result = people.Upsert(newPerson);

		// Assert
		Assert.AreEqual(people.Length + 1, result.Length, "The length of the array should increase by one when upserting a new item.");
		Assert.IsTrue(result.Contains(newPerson), "The new item should be present in the array after upserting.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Upsert_NullArray_ThrowsArgumentNullException()
	{
		// Arrange
		IDataRecord[] records = null;
		var newRecord = new TestDataRecord { Id = "1", Name = "Record1" };

		// Act
		_ = records.Upsert(newRecord);
	}

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

	public record TestDataRecord : IDataRecord
	{

		public string AllPropertiesToString()
		{
			return $"Id: {Id}, Name: {Name}";
		}

		public string Id { get; init; }
		public string Name { get; init; }
	}
}
