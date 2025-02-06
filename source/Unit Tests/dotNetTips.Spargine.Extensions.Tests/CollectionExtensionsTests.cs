// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2025
// ***********************************************************************
// <copyright file="CollectionExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CollectionExtensionsTests
{

	private const int Count = 10;

	[TestMethod]
	public void AddIfNotExists()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(Count).ToList();
		var person = RandomData.GeneratePersonRef<Address>();
		Person<Address> nullPerson = null;
		var comparer = new PersonComparer();
		PersonComparer nullComparer = null;
		List<Person<Address>> nullList = null;

		// TEST
		Assert.IsFalse(people.AddIfNotExists(nullPerson));

		_ = Assert.ThrowsException<ArgumentNullException>(() => _ = nullList.AddIfNotExists(person));

		Assert.IsFalse(people.AddIfNotExists(nullPerson, nullComparer));

		Assert.IsTrue(people.AddIfNotExists(person));

		Assert.IsFalse(people.AddIfNotExists(nullPerson));

		Assert.IsTrue(people.AddIfNotExists(RandomData.GeneratePersonRef<Address>(), comparer));

		Assert.IsFalse(people.AddIfNotExists(nullPerson, comparer));

	}

	[TestMethod]
	public void AddIfNotExistsSingleItemTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(Count).ToList();
		Person<Address> nullPerson = null;

		// TEST
		Assert.IsFalse(people.AddIfNotExists(nullPerson));

		var testPerson = RandomData.GeneratePersonRef<Address>();

		Assert.IsTrue(people.AddIfNotExists(testPerson));

		Assert.IsFalse(people.AddIfNotExists(testPerson));
	}

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(Count).ToList();
		var person = RandomData.GeneratePersonRef<Address>();

		// TEST
		people.AddIf(person, people.FastCount() == Count);

		Assert.IsTrue(people.FastCount() == 11);
	}

	[TestMethod]
	public void AddRangeTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(500).ToList();
		var peopleToAdd = RandomData.GeneratePersonRefCollection<Address>(5000).ToList();

		people.AddRange(peopleToAdd);

		Assert.IsNotNull(people);

		Assert.IsTrue(people.Count == 5500);
	}

	[TestMethod]
	public void AsReadOnlySpanTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(Count).ToCollection().AsReadOnlySpan();

		Assert.IsTrue(collection.Length == Count);
	}

	[TestMethod]
	public void AsSpanTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(Count).ToCollection().AsSpan();

		Assert.IsTrue(collection.Length == Count);
	}

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(Count).ToList();
		var emptyPeople = new List<Person<Address>>();

		Assert.IsFalse(people.DoesNotHaveItems());

		Assert.IsTrue(emptyPeople.DoesNotHaveItems());
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(Count).ToCollection();
		Collection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsTestWithCount()
	{
		var collection = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(Count).ToCollection();
		Collection<Coordinate> nullCollection = null;

		Assert.IsFalse(collection.HasItems(5));

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void ToFrozenTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(Count).ToCollection().ToFrozenSet();

		Assert.IsTrue(collection.Count == Count);
	}

	[TestMethod]
	public void Upsert_WithNewItem_ShouldAddItem()
	{
		// Arrange
		var collection = new List<IDataRecord>();
		var newItem = new PersonRecord("1", "John Doe");

		// Act
		collection.Upsert(newItem);

		// Assert
		Assert.AreEqual(1, collection.Count);
		Assert.IsTrue(collection.Contains(newItem));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Upsert_WithNullCollection_ShouldThrowArgumentNullException()
	{
		// Arrange
		List<IDataRecord> nullCollection = null;
		var newItem = new PersonRecord("1", "John Doe");

		// Act
		nullCollection.Upsert(newItem);

		// This test expects an exception
	}

	[TestMethod]
	public void Upsert_WithNullItem_ShouldNotAddItem()
	{
		// Arrange
		var collection = new List<IDataRecord>();
		IDataRecord nullItem = null;

		// Act
		collection.Upsert(nullItem);

		// Assert
		Assert.AreEqual(0, collection.Count);
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(Count).ToList();
		people.Shuffle();
		var personFromCollection = people.First();
		var person = RandomData.GeneratePersonRef<Address>();
		var personRecords = RandomData.GeneratePersonRecordCollection(Count).ToList();
		var personRecord = RandomData.GeneratePersonRecord();

		// TEST
		people.Upsert(person);

		Assert.IsTrue(people.FastCount() == 11);

		people.Upsert<Person<Address>, string>(personFromCollection);

		Assert.IsTrue(people.FastCount() == 11);

		personRecords.Upsert(personRecord);

		Assert.IsTrue(personRecords.FastCount() == 11);
	}


}
