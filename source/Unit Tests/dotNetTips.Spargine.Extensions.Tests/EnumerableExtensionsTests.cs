// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-28-2025
// ***********************************************************************
// <copyright file="EnumerableExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerableExtensionsTests
{
	private const int Count = 1024;
	private const string TestData = "TEST DATA";

	[TestMethod]
	public void AddDistinctTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();
		var person1 = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		people = people.AddDistinct(person1);

		Assert.IsTrue(people.Count() == Count + 1);

		people = people.AddDistinct(person1);

		Assert.IsTrue(people.Count() == Count + 1);

		people = people.AddDistinct(null);

		Assert.IsTrue(people.Count() == Count + 1);
	}

	[TestMethod]
	public void AddFirstTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var person1 = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		people.AddFirst(person1);

		Assert.IsTrue(people.Count == Count + 1);

		people.AddFirst(null);

		Assert.IsTrue(people.Count == Count + 1);
	}

	[TestMethod]
	public void AdIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = people.AddIf(person, true);

		Assert.IsTrue(result.FastCount() == people.Count() + 1);

		result = people.AddIf(person, false);

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void ContainsAnyTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		var people2 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count / 2);

		Assert.IsFalse(people1.ContainsAny(people2.ToArray()));

		Assert.IsTrue(people1.AddRange(people2, ensureUnique: true));
	}

	[TestMethod]
	public async Task CountAsync()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var peopleCount = await people.CountAsync(CancellationToken.None);

		Assert.IsTrue(peopleCount == Count);
	}

	[TestMethod]
	public void CountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		Assert.IsTrue(people.Count() == Count);
	}

	[TestMethod]
	public void CreateCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		_ = people.Create(true);

		Assert.IsTrue(people.Count() == Count);
	}

	[TestMethod]
	public void CreateNewCollectionAsParallelRefConcurrentBagComparison()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10000);
		var updatedCollection = new ConcurrentBag<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>();

		people.AsParallel().WithMergeOptions(ParallelMergeOptions.Default).ForAll(person =>
		{
			var updatedPerson = person;
			updatedPerson.Email = TestData;
			updatedCollection.Add(updatedPerson);
		});

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = new List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>().AsEnumerable();

		Assert.IsTrue(people.DoesNotHaveItems());
	}

	[TestMethod]
	public void EnsureUniqueTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		people.Add(people.FirstOrDefault());

		var result = people.EnsureUnique().ToList();

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void FastAnyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		//Test Params
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

		//Test Finding Days of over 100
		Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
	}

	[TestMethod]
	public void FastCountPredicateTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		// Test Params
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

		//Test Finding City names that contain 'A'.
		Assert.IsNotNull(people.FastCount(p => p.FirstName.Contains('A', StringComparison.CurrentCultureIgnoreCase)));
	}

	[TestMethod]
	public void FastCountQuerableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsQueryable();

		Assert.IsTrue(people.FastCount() == Count);

		Assert.IsTrue(people.FastCount(p => p.Age.TotalDays > 365) > 0);
	}

	[TestMethod]
	public void FastCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		Assert.IsTrue(people.FastCount() == Count);
	}

	[TestMethod]
	public void FastModifyCollectionTestRecord()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count);

		var updatedCollection = people.FastModifyCollection(person => person with { Email = TestData });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}


	[TestMethod]
	public void FastModifyCollectionTestRef()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		var updatedCollection = people.FastModifyCollection(person => { person.Email = TestData; return person; });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void FastModifyCollectionTestVal()
	{
		var people = RandomData.GeneratePersonValCollection<Address>(Count);

		var updatedCollection = people.FastModifyCollection(person => { person.Email = TestData; return person; });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void FastProcessorTestRecord()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count);
		people.FastProcessor(person => person.GetHashCode());

		Assert.IsTrue(people.Count == Count);
	}

	[TestMethod]
	public void FastProcessorTestRef()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		people.FastProcessor(person => person.GetHashCode());

		Assert.IsTrue(people.Count == Count);
	}

	[TestMethod]
	public void FastProcessorTestVal()
	{
		var people = RandomData.GeneratePersonValCollection<Address>(Count);

		people.FastProcessor(person => person.GetHashCode());

		Assert.IsTrue(people.Count == Count);
	}


	[TestMethod]
	public void FirstOrDefaultTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var person1 = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		people.Add(person1);

		//Test Finding item in collection
		Assert.IsNotNull(people.FirstOrDefault(person1) == person1);
		Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 2500, person1).Equals(person1));
		Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 50000, person1).Equals(person1));
	}

	[TestMethod]
	public void FirstOrNullTest()
	{
		var coordinates = RandomData.GenerateCoordinateCollection<Coordinate>(Count);
		var searchValue = coordinates.Last().X;

		//Test Finding Days of over 100
		Assert.IsNotNull(coordinates.FirstOrNull(p => p.X == searchValue));
		Assert.IsNull(coordinates.FirstOrNull(p => p.X == int.MinValue));
	}

	[TestMethod]
	public void FromDelimitedStringTest()
	{
		var testValue = ".net, c#, vb, f#";

		//Test
		Assert.IsTrue(testValue.ToDelimitedString(',').HasItems());
		Assert.IsTrue(testValue.ToDelimitedString().HasItems());
		Assert.IsTrue(string.Empty.ToDelimitedString().DoesNotHaveItems());
	}

	[TestMethod]
	public void HasDuplicatesEmptyTest()
	{
		IEnumerable<string> strings = new List<string>();

		Assert.IsFalse(strings.HasDuplicates());
	}

	[TestMethod]
	public void HasDuplicatesTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		Assert.IsFalse(people.HasDuplicates());

		people.Shuffle();

		var dups = people.Take(Count / 10).ToList();

		foreach (var person in dups)
		{
			people.AddLast(person);
		}

		var result = people.HasDuplicates();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();
		IEnumerable<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();
		IEnumerable<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullCollection = null;

		Assert.IsTrue(collection.HasItems(Count));

		Assert.IsFalse(collection.HasItems(100));

		Assert.IsFalse(nullCollection.HasItems(Count));
	}

	[TestMethod]
	public void IndexOf_WithComparer_FindsCorrectIndex()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var person = people[Count / 2];
		var comparer = new PersonComparer();

		var index = people.IndexOf(person, comparer);

		Assert.AreEqual(Count / 2, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_ReturnsNegativeOneWhenNotFound()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		var comparer = new PersonComparer();

		var index = people.IndexOf(person, comparer);

		Assert.AreEqual(-1, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_ThrowsArgumentNullException_WhenCollectionIsNull()
	{
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullCollection = null;
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		var comparer = new PersonComparer();

		Assert.ThrowsException<ArgumentNullException>(() => nullCollection.IndexOf(person, comparer));
	}

	[TestMethod]
	public void IndexOf_WithComparer_ThrowsArgumentNullException_WhenComparerIsNull()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		IEqualityComparer<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullComparer = null;

		Assert.ThrowsException<ArgumentNullException>(() => people.IndexOf(person, nullComparer));
	}



	[TestMethod]
	public void IndexOf_WithComparer_ThrowsArgumentNullException_WhenItemIsNull()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> nullPerson = null;
		var comparer = new PersonComparer();

		Assert.ThrowsException<ArgumentNullException>(() => people.IndexOf(nullPerson, comparer));
	}

	[TestMethod]
	public void IndexOf_WithPredicate_FindsCorrectIndex()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var person = people[Count / 2];

		var index = people.IndexOf(p => p.Equals(person));

		Assert.AreEqual(Count / 2, index);
	}

	[TestMethod]
	public void IndexOf_WithPredicate_ReturnsNegativeOneWhenNotFound()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var index = people.IndexOf(p => p.FirstName == "NonExistentName");

		Assert.AreEqual(-1, index);
	}

	[TestMethod]
	public void IndexOf_WithPredicate_ThrowsArgumentNullException_WhenCollectionIsNull()
	{
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullCollection = null;

		Assert.ThrowsException<ArgumentNullException>(() => nullCollection.IndexOf(p => p.FirstName == "Test"));
	}

	[TestMethod]
	public void IndexOf_WithPredicate_ThrowsArgumentNullException_WhenPredicateIsNull()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();

		Assert.ThrowsException<ArgumentNullException>(() => people.IndexOf(accumulatorPredicate: null));
	}

	[TestMethod]
	public void IndexOfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);
		var person1 = people.Shuffle(1).First();

		Assert.IsTrue(people.IndexOf(person1).IsNegative() == false);

		Assert.IsTrue(people.IndexOf(person1, new PersonComparer()).IsNegative() == false);
	}

	[TestMethod]
	public void IsNullOrEmptyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var result = people.IsNullOrEmpty();

		Assert.IsFalse(result);

		result = people.Take(0).IsNullOrEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void JoinTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var result = people.Join();

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void OrderByOrdinalTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var result = people.OrderByOrdinal(p => p.Email);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void OrderByTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var result = people.OrderBy("Email desc");

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void PageTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var result = people.Page(10);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void PartitionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var splitPeople = people.Partition(people.Count() / 10);

		Assert.IsNotNull(splitPeople);
		Assert.IsTrue(splitPeople.Count() == 11);

		var emptyPeople = new List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>();

		var splitEmptyPeople = emptyPeople.Partition(10);

		Assert.IsNotNull(splitEmptyPeople);

	}

	[TestMethod]
	public void PickRandomTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var result = people.PickRandom();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ProcessCollectionAsParallelRefListComparison()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		people.AsParallel().WithMergeOptions(ParallelMergeOptions.Default).ForAll(person =>
		{
			var updatedPerson = person;
			updatedPerson.Email = TestData;
		});

		Assert.IsTrue(people.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void ProcessCollectionAsParallelValListComparison()
	{
		var people = RandomData.GeneratePersonValCollection<Address>(Count);

		people.AsParallel().WithMergeOptions(ParallelMergeOptions.Default).ForAll(person =>
		{
			person.Email = TestData;
		});

		Assert.IsFalse(people.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void RemoveDuplicatesTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		var dups = people.Shuffle().Take(Count / 10).ToList();

		foreach (var person in dups)
		{
			_ = people.AddLast(person);
		}

		var result = people.RemoveDuplicates();
		Assert.IsTrue(result.Status == ResultStatus.Succeeded);
		Assert.IsTrue(result.Value.Count() == Count);
	}

	[TestMethod]
	public void RemoveNulls_AllNullItems()
	{
		var collection = new List<string> { null, null, null };
		var result = collection.RemoveNulls().ToList();

		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void RemoveNulls_EmptyCollection()
	{
		var collection = new List<string>();
		var result = collection.RemoveNulls().ToList();

		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void RemoveNulls_NoNullItems()
	{
		var collection = new List<string> { "apple", "banana", "cherry" };
		var result = collection.RemoveNulls().ToList();

		Assert.AreEqual(3, result.Count);
		CollectionAssert.AreEqual(new List<string> { "apple", "banana", "cherry" }, result);
	}

	[TestMethod]
	public void RemoveNulls_NullCollection_ThrowsArgumentNullException()
	{
		List<string> nullCollection = null;

		Assert.ThrowsException<ArgumentNullException>(() => nullCollection.RemoveNulls().ToList());
	}

	[TestMethod]
	public void RemoveNulls_RemovesNullItems()
	{
		var collection = new List<string> { "apple", null, "banana", null, "cherry" };
		var result = collection.RemoveNulls().ToList();

		Assert.AreEqual(3, result.Count);
		CollectionAssert.AreEqual(new List<string> { "apple", "banana", "cherry" }, result);
	}

	[TestMethod]
	public void ReplaceIf_ReplacesElementsCorrectly()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5 };
		var result = numbers.ReplaceIf((x, index) => x % 2 == 0, 0).ToList();

		var expected = new List<int> { 1, 0, 3, 0, 5 };
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void ReplaceIf_ThrowsArgumentNullException_WhenCollectionIsNull()
	{
		List<int> nullCollection = null;

		Assert.ThrowsException<ArgumentNullException>(() => nullCollection.ReplaceIf((x, index) => x % 2 == 0, 0).ToList());
	}

	[TestMethod]
	public void ReplaceIf_ThrowsArgumentNullException_WhenPredicateIsNull()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5 };

		Assert.ThrowsException<ArgumentNullException>(() => numbers.ReplaceIf(null, 0).ToList());
	}

	[TestMethod]
	public void ReplaceIf_WithComplexType_ReplacesElementsCorrectly()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var replacementPerson = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		var result = people.ReplaceIf((p, index) => index % 2 == 0, replacementPerson).ToList();

		for (int i = 0; i < result.Count; i += 2)
		{
			Assert.AreEqual(replacementPerson, result[i]);
		}
	}

	[TestMethod]
	public void ReplaceIf_WithEmptyCollection_ReturnsEmptyCollection()
	{
		var emptyList = new List<int>();
		var result = emptyList.ReplaceIf((x, index) => x % 2 == 0, 0).ToList();

		Assert.AreEqual(0, result.Count);
	}



	[TestMethod]
	public void Scan_AppliesAccumulatorFunctionCorrectly()
	{
		var numbers = Enumerable.Range(1, 5);
		var result = numbers.Scan(0, (acc, x) => acc + x).ToList();

		var expected = new List<int> { 0, 1, 3, 6, 10, 15 };
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void Scan_ThrowsArgumentNullException_WhenPredicateIsNull()
	{
		var numbers = Enumerable.Range(1, 5);

		Assert.ThrowsException<ArgumentNullException>(() => numbers.Scan(0, null).ToList());
	}

	[TestMethod]
	public void Scan_ThrowsArgumentNullException_WhenSourceIsNull()
	{
		IEnumerable<int> nullSource = null;

		Assert.ThrowsException<ArgumentNullException>(() => nullSource.Scan(0, (acc, x) => acc + x).ToList());
	}

	[TestMethod]
	public void Scan_WithComplexType_AppliesAccumulatorFunctionCorrectly()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).ToList();
		var result = people.Scan(new Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>(), (acc, p) => p).ToList();

		Assert.AreEqual(Count + 1, result.Count);
		Assert.AreEqual(people.Last(), result.Last());
	}

	[TestMethod]
	public void Scan_WithEmptySource_ReturnsSeedOnly()
	{
		var emptyList = new List<int>();
		var result = emptyList.Scan(0, (acc, x) => acc + x).ToList();

		var expected = new List<int> { 0 };
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void ShuffleTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		Assert.IsTrue(people.Shuffle().Count() == Count);
	}

	[TestMethod]
	public void ShuffleWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		Assert.IsTrue(people.Shuffle(5).FastCount() == 5);
	}

	[TestMethod]
	public void SplitTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var splitPeople = people.Split(Count / 10);

		Assert.IsNotNull(splitPeople);
		Assert.IsTrue(splitPeople.Count() == 11);

		var emptyPeople = new List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>();

		Assert.ThrowsException<ArgumentOutOfRangeException>(() => emptyPeople.Split(10));
	}

	[TestMethod]
	public void StartsWithTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);
		var people1 = people.Take(5);
		var people2 = people1;

		Assert.IsTrue(people.StartsWith(people.Take(5)));

		Assert.IsTrue(people1.StartsWith(people2));
	}

	[TestMethod]
	public void StructuralSequenceEqualTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		var people2 = people1.Clone<List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>>();

		Assert.IsFalse(people1.StructuralSequenceEqual(people2));

		Assert.IsTrue(people1.StructuralSequenceEqual(people1));
	}

	[TestMethod]
	public void ToBlockingTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var result = people.ToBlockingCollection();

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void ToCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		Assert.IsTrue(people.ToCollection().HasItems());
	}

	[TestMethod]
	public void ToDelimitedStringTest()
	{
		var words = RandomData.GenerateWords(Count, 25, 50);

		Assert.IsNotNull(words.ToDelimitedString(','));
	}

	[TestMethod]
	public void ToFrozenTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		Assert.IsTrue(people.ToFrozenSet().HasItems());
	}

	[TestMethod]
	public void ToImmutableArrayTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		Assert.IsTrue(people.ToImmutableArray().HasItems());
	}

	[TestMethod]
	public void ToImmutableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		Assert.IsTrue(people.ToImmutable().HasItems());
	}

	[TestMethod]
	public void ToLinkedListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		Assert.IsTrue(people.ToLinkedList().HasItems());
	}

	[TestMethod]
	public async Task ToListAsyncTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var result = await people.ToListAsync().ConfigureAwait(false);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ToReadOnlyCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count);

		Assert.IsTrue(people.ToReadOnlyCollection().HasItems());
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count).AsEnumerable();

		var personFromCollection = people.Shuffle().First();

		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = people.Upsert(person);

		Assert.IsTrue(result.FastCount() == people.Count() + 1);

		result = people.Upsert(personFromCollection);

		Assert.IsTrue(result.FastCount() == Count);
	}

}
