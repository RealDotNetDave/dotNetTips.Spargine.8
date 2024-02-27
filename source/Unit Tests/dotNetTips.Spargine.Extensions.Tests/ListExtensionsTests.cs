// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2024
// ***********************************************************************
// <copyright file="ListExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ListExtensionsTests
{

	private const int Count = 256;

	[TestMethod]
	public void AddIfNotExistsTwoListsTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		var result = people.AddIfNotExists(null);

		Assert.IsFalse(result);

		Assert.IsTrue(people.FastCount() == Count);

		var newPerson = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>(5);

		result = people.AddIfNotExists<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>(newPerson);

		Assert.IsTrue(result);

		Assert.IsTrue(people.FastCount() == Count + 1);
	}

	[TestMethod]
	public void AddLastTest()
	{
		var peopleList = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var peopleArray = peopleList.ToArray();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> nullPerson = null;

		// Test List
		_ = peopleList.AddLast(nullPerson);

		Assert.IsTrue(peopleList.FastCount() == Count);

		peopleList = peopleList.AddLast(person);

		Assert.IsTrue(peopleList.Last().Equals(person));

		// Test Array
		var result2 = peopleArray.AddLast(person);
		Assert.IsTrue(result2.Length == Count + 1);
		Assert.IsTrue(result2.Last().Equals(person));
	}

	[TestMethod]
	public void AsSpanTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		var result = people.AsSpan();

		Assert.IsTrue(result.IsEmpty is false);
	}
	[TestMethod]
	public void ClearNullListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(RandomData.GenerateInteger(10, Count)).ToList();

		people.Add(null);

		Assert.IsTrue(people.ClearNulls());

		Assert.IsFalse(people.ClearNulls());

		Assert.IsFalse(new List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>(10).ClearNulls());
	}
	[TestMethod]
	public void CopyToListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var newPeople = people.CopyToCollection();

		Assert.IsTrue(people.FastCount() == newPeople.FastCount());
	}

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(Count).ToList();
		List<Coordinate> nullCollection = null;

		Assert.IsFalse(collection.DoesNotHaveItems());

		Assert.IsTrue(nullCollection.DoesNotHaveItems());
	}

	[TestMethod]
	public void HasItemsTest01()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(Count);

		Assert.IsTrue(collection.ToList().HasItems());
	}

	[TestMethod]
	public void HasItemsTest02()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(Count);

		Assert.IsFalse(collection.ToList().HasItems(p => p.X == 999999999));
	}

	[TestMethod]
	public void HasItemsTest03()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(Count);

		Assert.IsFalse(collection.ToList().HasItems(5));
	}

	[TestMethod]
	public void IndexOfTest()
	{
		var peopleList = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);
		var testPerson = peopleList[5];

		//Test Parameters
		_ = Assert.ThrowsException<ArgumentNullException>(() => peopleList.IndexOf(testPerson, null));
		_ = Assert.ThrowsException<ArgumentNullException>(() => peopleList.IndexOf(null, new PersonComparer()));

		// Test 
		Assert.IsTrue(peopleList.IndexOf(testPerson, new PersonComparer()) >= 0);
	}

	[TestMethod]
	public void ListHashCodeTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		var result = people.GenerateHashCode();

		Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

		result = people.ToArray().GenerateHashCode();

		Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

		result = people.ToReadOnlyCollection().GenerateHashCode();

		Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));
	}

	[TestMethod]
	public void PagingTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);
		const int PageCount = 10;
		var peopleCount = 0;
		var loopedCount = 0;

		foreach (var peoplePage in people.Page(PageCount))
		{
			loopedCount++;
			peopleCount += peoplePage.Count();
		}

		Assert.IsTrue(peopleCount == Count);

		Assert.IsTrue(loopedCount == 26);
	}

	[TestMethod]
	public void PerformActionTest()
	{
		var words = RandomData.GenerateWords(10, 10, Count).ToList();
		var sb = new StringBuilder();

		words.PerformAction((word) => _ = sb.Append($"WORD:{word}|"));

		Assert.IsTrue(sb.Length > Count);
	}

	[TestMethod]
	public void PickRandomTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToDictionary(p => p.Id);

		var result = people.PickRandom();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void RemoveFirstTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(2500).ToArray();

		Assert.IsTrue(people.RemoveFirst().FastCount() == 2499);
	}

	[TestMethod]
	public void RemoveLastTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToArray();

		Assert.IsTrue(people.RemoveLast().FastCount() == Count - 1);
	}

	[TestMethod]
	public void ShuffleImmutableArrayTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToImmutable();
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		var shuffledPeople = people.Shuffle();

		Assert.IsTrue(people.FastCount() == shuffledPeople.FastCount());
	}

	[TestMethod]
	public void ShuffleTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullList = null;
		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		var shuffleCount = people.Shuffle().FastCount();

		Assert.IsTrue(people.FastCount() == shuffleCount);
	}

	[TestMethod]
	public void ToCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		var result = people.ToCollection();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void ToDistinctBlockingCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		var result = people.ToDistinctBlockingCollection(true);

		Assert.IsNotNull(result);

		Assert.IsTrue(result.FastCount() == Count);

		Assert.IsTrue(result.IsAddingCompleted);
	}

	[TestMethod]
	public void ToDistinctConcurrentBagTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		var result = people.ToDistinctConcurrentBag();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void ToFastSortedListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		var result = people.ToFastSortedList();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void ToImmutableArrayTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		var result = people.ToImmutableArray();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void ToObservableListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		var result = people.ToObservableList();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void ToReadOnlyCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToReadOnlyCollection();

		Assert.IsTrue(people.FastCount() == Count);
	}

}

