// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-20-2024
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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LinqToDB.Reflection.Methods.LinqToDB.Insert;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerableExtensionsTests
{
	private const int Count1024 = 1024;
	private const int Count2048 = 2048;
	private const int Count4096 = 4096;
	private const int Count8192 = 8192;
	private const string TestData = "TEST DATA";

	[TestMethod]
	public void AddDistinctTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();
		var person1 = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		people = people.AddDistinct(person1);

		Assert.IsTrue(people.Count() == Count8192 + 1);

		people = people.AddDistinct(person1);

		Assert.IsTrue(people.Count() == Count8192 + 1);

		people = people.AddDistinct(null);

		Assert.IsTrue(people.Count() == Count8192 + 1);
	}

	[TestMethod]
	public void AddFirstTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).ToList();
		var person1 = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		people = people.AddFirst(person1);

		Assert.IsTrue(people.Count == Count8192 + 1);

		people = people.AddFirst(null);

		Assert.IsTrue(people.Count == Count8192 + 1);
	}

	[TestMethod]
	public void AdIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = people.AddIf(person, true);

		Assert.IsTrue(result.FastCount() == people.Count() + 1);

		result = people.AddIf(person, false);

		Assert.IsTrue(result.FastCount() == Count8192);
	}

	[TestMethod]
	public void ContainsAnyTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).ToList();

		var people2 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192 / 2);

		Assert.IsFalse(people1.ContainsAny(people2.ToArray()));

		Assert.IsTrue(people1.AddRange(people2, ensureUnique: true));
	}

	[TestMethod]
	public async Task CountAsync()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var peopleCount = await people.CountAsync(CancellationToken.None);

		Assert.IsTrue(peopleCount == Count8192);
	}

	[TestMethod]
	public void CountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		Assert.IsTrue(people.Count() == Count8192);
	}

	[TestMethod]
	public void CreateCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		_ = people.Create(true);

		Assert.IsTrue(people.Count() == Count8192);
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
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).ToList();

		people.Add(people.FirstOrDefault());

		var result = people.EnsureUnique().ToList();

		Assert.IsTrue(result.FastCount() == Count8192);
	}

	[TestMethod]
	public void FastAnyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		//Test Params
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

		//Test Finding Days of over 100
		Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
	}

	[TestMethod]
	public void FastCountPredicateTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		// Test Params
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

		//Test Finding City names that contain 'A'.
		Assert.IsNotNull(people.FastCount(p => p.FirstName.Contains('A', StringComparison.CurrentCultureIgnoreCase)));
	}

	[TestMethod]
	public void FastCountQuerableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsQueryable();

		Assert.IsTrue(people.FastCount() == Count8192);

		Assert.IsTrue(people.FastCount(p => p.Age.TotalDays > 365) > 0);
	}

	[TestMethod]
	public void FastCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		Assert.IsTrue(people.FastCount() == Count8192);

		Assert.IsTrue(people.FastCount(p => p.Age.TotalDays > 365) > 0);
	}

	[TestMethod]
	public void FastModifyCollectionTestRecord2048()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count2048);

		var updatedCollection = people.FastModifyCollection(person => person with { Email = TestData });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void FastModifyCollectionTestRecord4096()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count4096);

		var updatedCollection = people.FastModifyCollection(person => person with { Email = TestData });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void FastModifyCollectionTestRecord8192()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count8192);

		var updatedCollection = people.FastModifyCollection(person => person with { Email = TestData });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}


	[TestMethod]
	public void FastModifyCollectionTestRef8192()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		var updatedCollection = people.FastModifyCollection(person => { person.Email = TestData; return person; });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void FastModifyCollectionTestVal1024()
	{
		var people = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(Count1024);

		var updatedCollection = people.FastModifyCollection(person => { person.Email = TestData; return person; });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void FastModifyCollectionTestVal2048()
	{
		var people = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(Count2048);

		var updatedCollection = people.FastModifyCollection(person => { person.Email = TestData; return person; });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void FastModifyCollectionTestVal8192()
	{
		var people = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(Count8192);

		var updatedCollection = people.FastModifyCollection(person => { person.Email = TestData; return person; });

		Assert.IsTrue(people.Count == updatedCollection.Count);

		Assert.IsTrue(updatedCollection.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void FastProcessorTestRecord8192()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count8192);

		people.FastProcessor(person => person.GetHashCode());

		Assert.IsTrue(people.Count == Count8192);
	}

	[TestMethod]
	public void FastProcessorTestRef8192()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		people.FastProcessor(person => person.GetHashCode());

		Assert.IsTrue(people.Count == Count8192);
	}

	[TestMethod]
	public void FastProcessorTestVal8192()
	{
		var people = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(Count8192);

		people.FastProcessor(person => person.GetHashCode());

		Assert.IsTrue(people.Count == Count8192);
	}

	[TestMethod]
	public void FirstOrDefaultTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).ToList();
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
		var coordinates = RandomData.GenerateCoordinateCollection<Coordinate>(Count8192);
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
	public void HasDuplicatesTest()
	{
		//TODO: ADD TEST METHOD TO ADD NON-DULICATES
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).ToList();

		Assert.IsFalse(people.HasDuplicates());

		var dups = people.Shuffle().Take(Count8192 / 10).ToList();

		foreach (var person in dups)
		{
			_ = people.AddLast(person);
		}

		var result = people.HasDuplicates();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();
		IEnumerable<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();
		IEnumerable<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullCollection = null;

		Assert.IsTrue(collection.HasItems(Count8192));

		Assert.IsFalse(collection.HasItems(100));

		Assert.IsFalse(nullCollection.HasItems(Count8192));
	}

	[TestMethod]
	public void IndexOfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);
		var person1 = people.Shuffle(1).First();

		Assert.IsTrue(people.IndexOf(person1).IsNegative() == false);

		Assert.IsTrue(people.IndexOf(person1, new PersonComparer()).IsNegative() == false);
	}

	[TestMethod]
	public void IsNullOrEmptyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var result = people.IsNullOrEmpty();

		Assert.IsFalse(result);

		result = people.Take(0).IsNullOrEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void JoinTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var result = people.Join();

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void ModifyCreateReadOnlyCollectionTestRecord2048()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count2048).ToArray();

		var processedCollection = new ReadOnlyCollectionBuilder<PersonRecord>(people.Length);

		_ = Parallel.For(0, people.Length, (index) => processedCollection.Add(people[index] with { Email = TestData }));

		Assert.IsFalse(people.Length == processedCollection.Count);
	}

	[TestMethod]
	public void OrderByOrdinalTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var result = people.OrderByOrdinal(p => p.Email);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void OrderByTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var result = people.OrderBy("Email desc");

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void PageTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var result = people.Page(10);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void PartitionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

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
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var result = people.PickRandom();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ProcessCollectionAsParallelRefListComparison()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

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
		var people = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(Count8192);

		people.AsParallel().WithMergeOptions(ParallelMergeOptions.Default).ForAll(person =>
		{
			person.Email = TestData;
		});

		Assert.IsFalse(people.All(p => p.Email == TestData));
	}

	[TestMethod]
	public void RemoveDuplicatesTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		var dups = people.Shuffle().Take(Count8192 / 10).ToList();

		foreach (var person in dups)
		{
			_ = people.AddLast(person);
		}

		var result = people.RemoveDuplicates();
		Assert.IsTrue(result.Status == ResultStatus.Succeeded);
		Assert.IsTrue(result.Value.Count() == Count8192);
	}

	[TestMethod]
	public void ShuffleTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		Assert.IsTrue(people.Shuffle().Count() == Count8192);
	}

	[TestMethod]
	public void ShuffleWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);
		List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		Assert.IsTrue(people.Shuffle(5).FastCount() == 5);
	}

	[TestMethod]
	public void SplitTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var splitPeople = people.Split(Count8192 / 10);

		Assert.IsNotNull(splitPeople);
		Assert.IsTrue(splitPeople.Count() == 11);

		var emptyPeople = new List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>();

		var splitEmptyPeople = emptyPeople.Split(10);

		Assert.IsTrue(splitEmptyPeople.Count() == 0);
	}

	[TestMethod]
	public void StartsWithTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);
		var people1 = people.Take(5);
		var people2 = people1;

		Assert.IsTrue(people.StartsWith(people.Take(5)));

		Assert.IsTrue(people1.StartsWith(people2));
	}

	[TestMethod]
	public void StructuralSequenceEqualTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		var people2 = people1.Clone<List<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>>();

		Assert.IsFalse(people1.StructuralSequenceEqual(people2));

		Assert.IsTrue(people1.StructuralSequenceEqual(people1));
	}

	[TestMethod]
	public void ToBlockingTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var result = people.ToBlockingCollection();

		Assert.IsTrue(result.FastCount() == Count8192);
	}

	[TestMethod]
	public void ToCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		Assert.IsTrue(people.ToCollection().HasItems());
	}

	[TestMethod]
	public void ToDelimitedStringTest()
	{
		var words = RandomData.GenerateWords(Count8192, 25, 50);

		Assert.IsNotNull(words.ToDelimitedString(','));
	}

	[TestMethod]
	public void ToImmutableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		Assert.IsTrue(people.ToImmutable().HasItems());
	}

	[TestMethod]
	public void ToLinkedListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192);

		Assert.IsTrue(people.ToLinkedList().HasItems());
	}

	[TestMethod]
	public async Task ToListAsyncTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var result = await people.ToListAsync().ConfigureAwait(false);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(Count8192).AsEnumerable();

		var personFromCollection = people.Shuffle().First();

		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		var result = people.Upsert(person);

		Assert.IsTrue(result.FastCount() == people.Count() + 1);

		result = people.Upsert(personFromCollection);

		Assert.IsTrue(result.FastCount() == Count8192);
	}

}
