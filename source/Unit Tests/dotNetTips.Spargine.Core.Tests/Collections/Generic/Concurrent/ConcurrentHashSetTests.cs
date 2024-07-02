// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-06-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="ConcurrentHashSetTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;
[ExcludeFromCodeCoverage]
[TestClass]
public class ConcurrentHashSetTests
{

	[TestMethod]
	public void Add_DuplicateItem_ReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<int>();
		bool firstAddResult = hashSet.Add(1);
		bool secondAddResult = hashSet.Add(1); // Attempt to add duplicate

		Assert.IsTrue(firstAddResult, "First add should succeed.");
		Assert.IsFalse(secondAddResult, "Second add of a duplicate item should return false.");
		Assert.AreEqual(1, hashSet.Count, "Count should be 1 after attempting to add a duplicate item.");
	}

	[TestMethod]
	public void Add_MultipleUniqueItems_IncreasesCountCorrectly()
	{
		var hashSet = new ConcurrentHashSet<int>();
		for (int i = 0; i < 10; i++)
		{
			hashSet.Add(i);
		}

		Assert.AreEqual(10, hashSet.Count, "Count should reflect the number of unique items added.");
	}



	[TestMethod]
	public void Add_NullItem_ThrowsArgumentNullException()
	{
		var hashSet = new ConcurrentHashSet<string>();
		Assert.ThrowsException<ArgumentNullException>(() => hashSet.Add(null));
	}

	[TestMethod]
	public void Add_WithComparer_DuplicatesNotAdded()
	{
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(comparer);

		bool firstAddResult = hashSet.Add("test");
		bool secondAddResult = hashSet.Add("TEST");

		Assert.IsTrue(firstAddResult, "First add should succeed.");
		Assert.IsFalse(secondAddResult, "Second add should fail due to case-insensitive comparison.");
		Assert.AreEqual(1, hashSet.Count, "Hash set should contain only one item due to the custom comparer.");
	}

	[TestMethod]
	public void AddTest()
	{
		var people = new ConcurrentHashSet<Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(100));

		var result = people.Add(RandomData.GeneratePersonRef<Address>());

		Assert.IsTrue(result);
		Assert.IsTrue(people.Count == 101);
	}

	[TestMethod]
	public void Clear_AlreadyEmptySet_RemainsEmpty()
	{
		var hashSet = new ConcurrentHashSet<int>();
		hashSet.Clear(); // Calling Clear on an already empty set

		Assert.AreEqual(0, hashSet.Count, "HashSet should remain empty after calling Clear.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should return true for an already empty set after calling Clear.");
	}


	[TestMethod]
	public void Clear_NonEmptySet_BecomesEmpty()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.Clear();

		Assert.AreEqual(0, hashSet.Count, "HashSet should be empty after calling Clear.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should return true after clearing the set.");
	}

	[TestMethod]
	public void ClearEmptyTest()
	{
		var people = new ConcurrentHashSet<Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(100));

		people.Clear();

		Assert.IsTrue(people.Count == 0);

		Assert.IsTrue(people.IsEmpty);

	}

	[TestMethod]
	public void Constructor_WithCollection_InitializesCorrectly()
	{
		var initialCollection = RandomData.GeneratePersonRefCollection<Address>(100);
		var hashSet = new ConcurrentHashSet<Person<Address>>(initialCollection);

		Assert.AreEqual(initialCollection.Count, hashSet.Count, "The count of the ConcurrentHashSet should match the count of the initial collection.");

		foreach (var item in initialCollection)
		{
			Assert.IsTrue(hashSet.Contains(item), "The ConcurrentHashSet should contain all items from the initial collection.");
		}
	}


	[TestMethod]
	public void Constructor_WithCollectionAndComparer_InitializesCorrectlyAndUsesComparer()
	{
		var initialCollection = new List<string> { "apple", "Apple", "banana", "Banana" };
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(initialCollection, comparer);

		// Verify the count reflects that duplicates (based on the comparer) were not added
		Assert.AreEqual(2, hashSet.Count, "The count of the ConcurrentHashSet should reflect unique items based on the comparer.");

		// Verify that the hashSet contains items from the initial collection, considering the comparer
		Assert.IsTrue(hashSet.Contains("apple"), "The ConcurrentHashSet should contain 'apple'.");
		Assert.IsTrue(hashSet.Contains("banana"), "The ConcurrentHashSet should contain 'banana'.");

		// Verify that the hashSet considers different casing as equal, due to the comparer
		Assert.IsTrue(hashSet.Contains("Apple"), "The ConcurrentHashSet should consider 'Apple' as existing due to the comparer.");
		Assert.IsTrue(hashSet.Contains("Banana"), "The ConcurrentHashSet should consider 'Banana' as existing due to the comparer.");
	}

	[TestMethod]
	public void Constructor_WithComparer_UsesComparerCorrectly()
	{
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(comparer);

		hashSet.Add("test");
		Assert.IsTrue(hashSet.Contains("TEST"), "The hash set should use the provided comparer for case-insensitive comparison.");
	}

	[TestMethod]
	public void Constructor_WithConcurrencyLevelAndCapacity_InitializesCorrectly()
	{
		int concurrencyLevel = 4; // Example concurrency level
		int capacity = 100; // Example initial capacity
		var hashSet = new ConcurrentHashSet<int>(concurrencyLevel, capacity);

		// Verify the hashSet is empty upon initialization
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a newly initialized ConcurrentHashSet.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should be true for a newly initialized ConcurrentHashSet.");

		// Verify that the hashSet can have items added after being initialized with the specified concurrency level and capacity
		for (int i = 0; i < capacity; i++)
		{
			hashSet.Add(i);
		}
		Assert.AreEqual(capacity, hashSet.Count, $"Count should reflect the number of items added, expected {capacity}.");

		// Further validation to ensure the specified concurrency level and capacity do not cause unexpected behavior could be performed here
		// Note: Direct validation of concurrencyLevel's effect might not be straightforward without internal access or specific concurrent scenarios
	}


	[TestMethod]
	public void Constructor_WithConcurrencyLevelCapacityAndComparer_InitializesCorrectly()
	{
		int concurrencyLevel = 4; // Example concurrency level
		int capacity = 100; // Example initial capacity
		var comparer = StringComparer.OrdinalIgnoreCase; // Example custom comparer
		var hashSet = new ConcurrentHashSet<string>(concurrencyLevel, capacity, comparer);

		// Verify the hashSet is empty upon initialization
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a newly initialized ConcurrentHashSet.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should be true for a newly initialized ConcurrentHashSet.");

		// Add items to test the custom comparer's effect
		hashSet.Add("test");
		hashSet.Add("TEST");
		// Due to the custom comparer, adding "TEST" should not increase the count
		Assert.AreEqual(1, hashSet.Count, "Count should reflect unique items based on the custom comparer.");

		// Verify that the hashSet can have items added after being initialized with the specified concurrency level, capacity, and comparer
		for (int i = 1; i < capacity; i++)
		{
			hashSet.Add("test" + i);
		}
		// Verify the count reflects the added items plus the initial "test" item, respecting the custom comparer
		Assert.AreEqual(capacity, hashSet.Count, $"Count should reflect the number of unique items added, expected {capacity}.");

		// Further validation to ensure the specified concurrency level and capacity do not cause unexpected behavior could be performed here
		// Note: Direct validation of concurrencyLevel's effect might not be straightforward without internal access or specific concurrent scenarios
	}


	[TestMethod]
	public void Constructor_WithConcurrencyLevelCollectionAndComparer_InitializesCorrectly()
	{
		var concurrencyLevel = 2;
		var initialCollection = new List<string> { "apple", "Apple", "banana", "Banana" };
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(concurrencyLevel, initialCollection, comparer);

		// Verify the count reflects that duplicates (based on the comparer) were not added
		Assert.AreEqual(2, hashSet.Count, "The count of the ConcurrentHashSet should reflect unique items based on the comparer.");

		// Verify that the hashSet contains items from the initial collection, considering the comparer
		Assert.IsTrue(hashSet.Contains("apple"), "The ConcurrentHashSet should contain 'apple'.");
		Assert.IsTrue(hashSet.Contains("banana"), "The ConcurrentHashSet should contain 'banana'.");

		// Verify that the hashSet considers different casing as equal, due to the comparer
		Assert.IsTrue(hashSet.Contains("Apple"), "The ConcurrentHashSet should consider 'Apple' as existing due to the comparer.");
		Assert.IsTrue(hashSet.Contains("Banana"), "The ConcurrentHashSet should consider 'Banana' as existing due to the comparer.");

		// Additional checks could be performed to ensure the concurrency level is respected, though this may require a more complex setup
	}
	[TestMethod]
	public void ConstructorsTest()
	{
		var comparer = new PersonComparer();

		var test1 = new ConcurrentHashSet<Person<Address>>();

		Assert.IsNotNull(test1);

		var test2 = new ConcurrentHashSet<Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(100));

		Assert.IsNotNull(test2);
		Assert.IsTrue(test2.Count == 100);

		var test3 = new ConcurrentHashSet<Person<Address>>(comparer);

		Assert.IsNotNull(test3);

		var test4 = new ConcurrentHashSet<Person<Address>>(2, 100);

		Assert.IsNotNull(test4);

		var test5 = new ConcurrentHashSet<Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(100), comparer);

		Assert.IsNotNull(test5);
		Assert.IsTrue(test5.Count == 100);

		var test6 = new ConcurrentHashSet<Person<Address>>(2, 100, comparer);

		Assert.IsNotNull(test6);

		var test7 = new ConcurrentHashSet<Person<Address>>(2, RandomData.GeneratePersonRefCollection<Address>(100), comparer);

		Assert.IsNotNull(test7);
		Assert.IsTrue(test7.Count == 100);
	}

	[TestMethod]
	public void Contains_ExistingItem_ReturnsTrue()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		bool result = hashSet.Contains(2);

		Assert.IsTrue(result, "Contains should return true for an item that exists in the set.");
	}


	[TestMethod]
	public void Contains_NonExistingItem_ReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		bool result = hashSet.Contains(4);

		Assert.IsFalse(result, "Contains should return false for an item that does not exist in the set.");
	}

	[TestMethod]
	public void Contains_NullItem_ReturnsCorrectResult()
	{
		var hashSet = new ConcurrentHashSet<string> { "a", "b", "c" };
		bool result = hashSet.Contains(null);

		// Adjust the assertion based on whether your implementation allows nulls or not.
		// If nulls are allowed and expected to be found, use Assert.IsTrue(result);
		// If nulls are not allowed or expected not to be found, use Assert.IsFalse(result);
		Assert.IsFalse(result, "Contains should return the correct result for a null item, depending on whether nulls are allowed.");
	}

	[TestMethod]
	public void Contains_WithComparer_FindsCorrectly()
	{
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(comparer);

		hashSet.Add("test");
		bool containsResult = hashSet.Contains("TEST");

		Assert.IsTrue(containsResult, "Should find item with case-insensitive key.");
	}

	[TestMethod]
	public void Count_AfterAddingDuplicateItem_RemainsUnchanged()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.Add(2); // Attempt to add a duplicate item

		Assert.AreEqual(3, hashSet.Count, "Count should remain unchanged after attempting to add a duplicate item.");
	}

	[TestMethod]
	public void Count_AfterAddingUniqueItems_IncreasesCorrectly()
	{
		var hashSet = new ConcurrentHashSet<int>();
		hashSet.Add(1);
		hashSet.Add(2);
		hashSet.Add(3);

		Assert.AreEqual(3, hashSet.Count, "Count should be 3 after adding three unique items.");
	}

	[TestMethod]
	public void Count_AfterRemovingItems_DecreasesCorrectly()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.TryRemove(2);
		hashSet.TryRemove(3);

		Assert.AreEqual(1, hashSet.Count, "Count should be 1 after removing two items.");
	}

	[TestMethod]
	public void Count_ForNewOrClearedSet_IsZero()
	{
		var hashSet = new ConcurrentHashSet<int>();
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a new set.");

		hashSet.Add(1);
		hashSet.Clear();
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a cleared set.");
	}

	[TestMethod]
	public void DefaultConcurrencyLevel_EqualsProcessorCount()
	{
		var expectedConcurrencyLevel = Environment.ProcessorCount;
		var actualConcurrencyLevel = ConcurrentHashSet<int>.DefaultConcurrencyLevel;

		Assert.AreEqual(expectedConcurrencyLevel, actualConcurrencyLevel, "DefaultConcurrencyLevel should equal the number of processors available to the current process.");
	}

	[TestMethod]
	public void DefaultConstructorTest()
	{
		var hashSet = new ConcurrentHashSet<int>();

		// Verify the hashSet is empty upon initialization
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a newly initialized ConcurrentHashSet.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should be true for a newly initialized ConcurrentHashSet.");

		// Verify that the hashSet can have items added after being initialized with the default constructor
		bool addResult = hashSet.Add(1);
		Assert.IsTrue(addResult, "Should be able to add an item to the ConcurrentHashSet initialized with the default constructor.");
		Assert.AreEqual(1, hashSet.Count, "Count should reflect the number of items added.");
	}

	[TestMethod]
	public void GetEnumerator_ExplicitInterfaceImplementation_EnumeratesAllItems()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		var items = new List<int>();

		// Explicitly cast to IEnumerable<T> to use the explicit interface implementation
		IEnumerable<int> enumerable = hashSet;
		foreach (var item in enumerable)
		{
			items.Add(item);
		}

		Assert.AreEqual(3, items.Count, "The enumerator should iterate over all items.");
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, items, "The enumerated items should match the items in the set.");
	}

	[TestMethod]
	public void IsEmpty_AfterAddingItems_ReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		Assert.IsFalse(hashSet.IsEmpty, "IsEmpty should return false for a set that contains items.");
	}

	[TestMethod]
	public void IsEmpty_AfterClearingSet_ReturnsTrue()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.Clear();
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should return true for a set that has been cleared.");
	}

	[TestMethod]
	public void IsEmpty_NewSet_ReturnsTrue()
	{
		var hashSet = new ConcurrentHashSet<int>();
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should return true for a new set.");
	}


	[TestMethod]
	public void IsReadOnly_AlwaysReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<int>();
		Assert.IsFalse(((ICollection<int>)hashSet).IsReadOnly, "IsReadOnly should always return false for ConcurrentHashSet.");
	}


	[TestMethod]
	public void TryRemove_ExistingItem_ReturnsTrueAndRemovesItem()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		bool result = hashSet.TryRemove(2);

		Assert.IsTrue(result, "TryRemove should return true for an item that exists in the set.");
		Assert.IsFalse(hashSet.Contains(2), "The item should no longer exist in the set after being removed.");
	}

	[TestMethod]
	public void TryRemove_NonExistingItem_ReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		bool result = hashSet.TryRemove(4);

		Assert.IsFalse(result, "TryRemove should return false for an item that does not exist in the set.");
	}

	[TestMethod]
	public void TryRemove_NullItem_ReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<string> { "a", "b", "c" };
		bool result = hashSet.TryRemove(null);

		// Adjust the assertion based on whether your implementation allows nulls or not.
		// If nulls are allowed and expected to be found, use Assert.IsTrue(result);
		// If nulls are not allowed or expected not to be found, use Assert.IsFalse(result);
		Assert.IsFalse(result, "TryRemove should return false for a null item, depending on whether nulls are allowed.");
	}


	[TestMethod]
	public void TryRemove_WithComparer_RemovesCorrectly()
	{
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(comparer);

		hashSet.Add("test");
		bool removeResult = hashSet.TryRemove("TEST");

		Assert.IsTrue(removeResult, "Should be able to remove item with case-insensitive key.");
		Assert.IsTrue(hashSet.IsEmpty, "Hash set should be empty after removal.");
	}

}
