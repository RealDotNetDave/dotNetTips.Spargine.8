// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2024
// ***********************************************************************
// <copyright file="CollectionExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CollectionExtensionsTests
{

	[TestMethod]
	public void AddIfNotExists()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToList();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> nullPerson = null;
		var comparer = new PersonComparer();
		PersonComparer nullComparer = null;
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullList = null;

		// TEST
		Assert.IsFalse(people.AddIfNotExists(nullPerson));

		_ = Assert.ThrowsException<ArgumentNullException>(() => _ = nullList.AddIfNotExists(person));

		Assert.IsFalse(people.AddIfNotExists(nullPerson, nullComparer));

		Assert.IsTrue(people.AddIfNotExists(person));

		Assert.IsFalse(people.AddIfNotExists(nullPerson));

		Assert.IsTrue(people.AddIfNotExists(RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>(), comparer));

		Assert.IsFalse(people.AddIfNotExists(nullPerson, comparer));

	}

	[TestMethod]
	public void AddIfNotExistsSingleItemTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToList();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> nullPerson = null;

		// TEST
		Assert.IsFalse(people.AddIfNotExists(nullPerson));

		var testPerson = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		Assert.IsTrue(people.AddIfNotExists(testPerson));

		Assert.IsFalse(people.AddIfNotExists(testPerson));
	}

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToList();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		// TEST
		people.AddIf(person, people.FastCount() == 10);

		Assert.IsTrue(people.FastCount() == 11);
	}

	[TestMethod]
	public void AddRangeTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(500).ToList();
		var peopleToAdd = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(5000).ToList();

		people.AddRange(peopleToAdd);

		Assert.IsNotNull(people);

		Assert.IsTrue(people.Count() == 5500);
	}

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToList();
		var emptyPeople = new List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>();

		Assert.IsFalse(people.DoesNotHaveItems());

		Assert.IsTrue(emptyPeople.DoesNotHaveItems());
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10).ToCollection();
		Collection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsTestWithCount()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10).ToCollection();
		Collection<Coordinate> nullCollection = null;

		Assert.IsFalse(collection.HasItems(5));

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).ToList();
		var personFromCollection = people.Shuffle().First();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		var personRecords = RandomData.GeneratePersonRecordCollection(10).ToList();
		var personRecord = RandomData.GeneratePersonRecord();

		// TEST
		people.Upsert(person);

		Assert.IsTrue(people.FastCount() == 11);

		people.Upsert<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>, string>(personFromCollection);

		Assert.IsTrue(people.FastCount() == 11);

		personRecords.Upsert(personRecord);

		Assert.IsTrue(personRecords.FastCount() == 11);
	}

}