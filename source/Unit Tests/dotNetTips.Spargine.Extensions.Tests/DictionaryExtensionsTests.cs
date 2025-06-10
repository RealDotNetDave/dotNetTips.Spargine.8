// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-28-2025
// ***********************************************************************
// <copyright file="DictionaryExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DictionaryExtensionsTests
{

	private const int CollectionCount = 256;

	/// <summary>
	/// Defines the test method AddIfNotExistDictionaryTest.
	/// </summary>
	[TestMethod]
	public void AddIfNotExistDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);
		var newPerson = RandomData.GeneratePersonRef<Address>();

		// Test parameters
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(null, newPerson));

		// Test
		Assert.IsTrue(people.AddIfNotExists(newPerson.Id, newPerson));

		Assert.IsFalse(people.AddIfNotExists(newPerson.Id, newPerson));
	}

	[TestMethod]
	public void AddIfNotExists_WithExistingKey_DoesNotAddKeyValuePair()
	{
		// Arrange
		var dictionary = new Dictionary<string, int> { { "key1", 42 } };
		var key = "key1";
		var value = 99;

		// Act
		var result = dictionary.AddIfNotExists(key, value);

		// Assert
		Assert.IsFalse(result);
		Assert.AreEqual(42, dictionary[key]); // Ensure the original value is not overwritten
	}

	[TestMethod]
	public void AddIfNotExists_WithNewKey_AddsKeyValuePair()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>();
		var key = "key1";
		var value = 42;

		// Act
		var result = dictionary.AddIfNotExists(key, value);

		// Assert
		Assert.IsTrue(result);
		Assert.IsTrue(dictionary.ContainsKey(key));
		Assert.AreEqual(value, dictionary[key]);
	}

	[TestMethod]
	public void AddIfNotExists_WithNullDictionary_ThrowsArgumentNullException()
	{
		// Arrange
		Dictionary<string, int> dictionary = null;
		var key = "key1";
		var value = 42;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => dictionary.AddIfNotExists(key, value));
	}

	[TestMethod]
	public void AddIfNotExists_WithNullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>();
		string key = null;
		var value = 42;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => dictionary.AddIfNotExists(key, value));
	}

	[TestMethod]
	public void AddIfNotExists_WithNullValue_ReturnsFalse()
	{
		// Arrange
		var dictionary = new Dictionary<string, string>();
		var key = "key1";
		string value = null;

		// Act
		var result = dictionary.AddIfNotExists(key, value);

		// Assert
		Assert.IsFalse(result);
		Assert.IsFalse(dictionary.ContainsKey(key));
	}

	/// <summary>
	/// Defines the test method AddRangeDictionaryTest01.
	/// </summary>
	[TestMethod]
	public void AddRangeDictionaryTest01()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);
		var newPeople = RandomData.GeneratePersonRefCollection<Address>(2).ToDictionary(p => p.Id);

		var result = people.AddRange(newPeople, true);
		Assert.IsTrue(people.FastCount() == CollectionCount + 2);

		result = people.AddRange(newPeople, true);
		Assert.IsTrue(people.FastCount() == CollectionCount + 2);
	}


	/// <summary>
	/// Defines the test method DoesNotHaveItemsTest.
	/// </summary>
	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		Assert.IsFalse(people.DoesNotHaveItems());
	}

	/// <summary>
	/// Defines the test method AddRangeDictionaryTest02.
	/// </summary>
	[TestMethod]
	public void FastCountTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		Assert.IsTrue(people1.FastCount() == CollectionCount);

	}

	/// <summary>
	/// Defines the test method GetOrAddTest.
	/// </summary>
	[TestMethod]
	public void GetOrAddTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);
		var newPerson = RandomData.GeneratePersonRef<Address>();

		// Test Parameters
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.GetOrAdd(null, newPerson));

		// TEST
		_ = people.GetOrAdd(newPerson.Id, newPerson);
		Assert.IsTrue(people.FastCount() == CollectionCount + 1);

		_ = people.GetOrAdd(newPerson.Id, newPerson);
		Assert.IsTrue(people.FastCount() == CollectionCount + 1);
	}

	/// <summary>
	/// Defines the test method HasItemsTest.
	/// </summary>
	[TestMethod]
	public void HasItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);
		Dictionary<string, Person<Address>> nullPeople = null;

		Assert.IsTrue(people.HasItems());

		Assert.IsFalse(nullPeople.HasItems());
	}

	/// <summary>
	/// Defines the test method HasItemsTestWithFunction.
	/// </summary>
	[TestMethod]
	public void HasItemsTestWithFunction()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		Func<KeyValuePair<string, Person<Address>>, bool> selector = p => p.Value.Email.IsNotNull();

		Assert.IsTrue(people.HasItems(selector));
	}

	/// <summary>
	/// Defines the test method HasItemsWithCountTest.
	/// </summary>
	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);
		Dictionary<string, Person<Address>> nullPeople = null;

		Assert.IsTrue(people.HasItems(CollectionCount));
		Assert.IsFalse(people.HasItems(100));

		Assert.IsFalse(nullPeople.HasItems(CollectionCount));
	}

	/// <summary>
	/// Defines the test method ToConcurrentDictionaryTest.
	/// </summary>
	[TestMethod]
	public void ToConcurrentDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToConcurrentDictionary();

		Assert.IsTrue(result.HasItems());
	}
	/// <summary>
	/// Defines the test method ToDelimitedDictionaryTest.
	/// </summary>
	[TestMethod]
	public void ToDelimitedDictionaryTest()
	{
		var words = RandomData.GenerateWords(CollectionCount, 25, 50);

		var dic = new Dictionary<string, string>(CollectionCount);

		foreach (var item in words)
		{
			dic.Add(item, item);
		}

		Assert.IsNotNull((dic).ToDelimitedString(','));
	}

	[TestMethod]
	public void ToFrozenDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToFrozenDictionary();

		Assert.IsTrue(result.HasItems());
		Assert.AreEqual(people.Count, result.Count);
		foreach (var kvp in people)
		{
			Assert.IsTrue(result.ContainsKey(kvp.Key));
			Assert.AreEqual(kvp.Value, result[kvp.Key]);
		}
	}


	[TestMethod]
	public void ToFrozenDictionaryWithEmptyDictionaryTest()
	{
		var emptyDictionary = new Dictionary<string, Person<Address>>();

		var result = emptyDictionary.ToFrozenDictionary();

		Assert.IsFalse(result.HasItems());
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void ToFrozenDictionaryWithNullDictionaryTest()
	{
		Dictionary<string, Person<Address>> nullDictionary = null;

		Assert.ThrowsException<ArgumentNullException>(() => nullDictionary.ToFrozenDictionary());
	}

	[TestMethod]
	public void ToImmutableSortedDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToImmutableSortedDictionary();

		Assert.IsTrue(result.HasItems());
		Assert.AreEqual(people.Count, result.Count);
		foreach (var kvp in people)
		{
			Assert.IsTrue(result.ContainsKey(kvp.Key));
			Assert.AreEqual(kvp.Value, result[kvp.Key]);
		}
	}

	[TestMethod]
	public void ToImmutableSortedDictionaryWithEmptyDictionaryTest()
	{
		var emptyDictionary = new Dictionary<string, Person<Address>>();

		var result = emptyDictionary.ToImmutableSortedDictionary();

		Assert.IsFalse(result.HasItems());
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void ToImmutableSortedDictionaryWithNullDictionaryTest()
	{
		Dictionary<string, Person<Address>> nullDictionary = null;

		Assert.ThrowsException<ArgumentNullException>(() => nullDictionary.ToImmutableSortedDictionary());
	}

	/// <summary>
	/// Defines the test method ToImmutableTest.
	/// </summary>
	[TestMethod]
	public void ToImmutableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToImmutable();

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void ToLookup_WithExistingKey_ReturnsValue()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		var lookup = dictionary.ToLookupWithDefault(0);

		// Act
		var result = lookup("key1");

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public void ToLookup_WithNonExistingKey_ReturnsDefaultValue()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		var lookup = dictionary.ToLookupWithDefault(0);

		// Act
		var result = lookup("key3");

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void ToLookup_WithNullDictionary_ThrowsArgumentNullException()
	{
		// Arrange
		Dictionary<string, int> dictionary = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => dictionary.ToLookupWithDefault(0));
	}



	[TestMethod]
	public void ToReadOnlyCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToReadOnlyCollection();

		// Test
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == CollectionCount);
	}

	[TestMethod]
	public void ToReadOnlyDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToReadOnlyDictionary();

		// Test
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == CollectionCount);
	}

	[TestMethod]
	public void ToSortedDictionary_WithCustomComparer_ReturnsSortedDictionary()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "b", 2 },
		{ "a", 1 },
		{ "c", 3 }
	};
		var comparer = Comparer<string>.Create((x, y) => string.Compare(y, x, StringComparison.Ordinal));

		// Act
		var result = dictionary.ToSortedDictionary(comparer);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(3, result.Count);
		CollectionAssert.AreEqual(new[] { "c", "b", "a" }, result.Keys.ToArray());
	}

	[TestMethod]
	public void ToSortedDictionary_WithDefaultComparer_ReturnsSortedDictionary()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "b", 2 },
		{ "a", 1 },
		{ "c", 3 }
	};
		var comparer = Comparer<string>.Default;

		// Act
		var result = dictionary.ToSortedDictionary(comparer);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(3, result.Count);
		CollectionAssert.AreEqual(new[] { "a", "b", "c" }, result.Keys.ToArray());
	}

	[TestMethod]
	public void ToSortedDictionary_WithEmptyDictionary_ReturnsEmptySortedDictionary()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>();
		var comparer = Comparer<string>.Default;

		// Act
		var result = dictionary.ToSortedDictionary(comparer);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void ToSortedDictionary_WithNullComparer_ThrowsArgumentNullException()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "b", 2 },
		{ "a", 1 },
		{ "c", 3 }
	};
		IComparer<string> comparer = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => dictionary.ToSortedDictionary(comparer));
	}

	[TestMethod]
	public void ToSortedDictionary_WithNullDictionary_ThrowsArgumentNullException()
	{
		// Arrange
		Dictionary<string, int> dictionary = null;
		var comparer = Comparer<string>.Default;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => dictionary.ToSortedDictionary(comparer));
	}

	/// <summary>
	/// Defines the test method ToSortedDictionaryTest.
	/// </summary>
	[TestMethod]
	public void ToSortedDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToSortedDictionary();

		Assert.IsTrue(result.HasItems());
	}


	[TestMethod]
	public void TryGetKey_WithExistingKey_ReturnsValue()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		Func<string, int> func = key => 0;

		// Act
		var result = dictionary.TryGetValue("key1", func);

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public void TryGetKey_WithNonExistingKey_AddsAndReturnsValue()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		Func<string, int> func = key => 3;

		// Act
		var result = dictionary.TryGetValue("key3", func);

		// Assert
		Assert.AreEqual(3, result);
		Assert.IsTrue(dictionary.ContainsKey("key3"));
		Assert.AreEqual(3, dictionary["key3"]);
	}

	[TestMethod]
	public void TryGetKey_WithNullDictionary_ThrowsArgumentNullException()
	{
		// Arrange
		Dictionary<string, int> dictionary = null;
		Func<string, int> func = key => 0;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => dictionary.TryGetValue("key1", func));
	}

	[TestMethod]
	public void TryGetKey_WithNullFunc_ThrowsArgumentNullException()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		Func<string, int> func = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => dictionary.TryGetValue("key3", func));
	}

	/// <summary>
	/// Defines the test method UpsertDictionaryTest.
	/// </summary>
	[TestMethod]
	public void UpsertDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(CollectionCount).ToDictionary(p => p.Id);
		var newPerson = RandomData.GeneratePersonRef<Address>();
		var personFromCollection = people.Shuffle().First();

		// Test Parameters
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.Upsert(null, newPerson));

		// Test
		people.Upsert(newPerson.Id, newPerson);
		Assert.IsTrue(people.FastCount() == CollectionCount + 1);

		people.Upsert(newPerson);
		Assert.IsTrue(people.FastCount() == CollectionCount + 1);

		people.Upsert(personFromCollection.Value.Id, personFromCollection.Value);
		Assert.IsTrue(people.FastCount() == CollectionCount + 1);
	}

}

[ExcludeFromCodeCoverage]
public class MockDisposable : IDisposable
{

	public void Dispose()
	{
		this.IsDisposed = true;
	}

	public bool IsDisposed { get; private set; }
}
