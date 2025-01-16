// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2025
// ***********************************************************************
// <copyright file="ListExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

	private async IAsyncEnumerable<T> GetAsyncEnumerable<T>(IEnumerable<T> items)
	{
		foreach (var item in items)
		{
			yield return item;
			await Task.Yield();
		}
	}

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
		peopleList.AddLast(nullPerson);

		Assert.IsTrue(peopleList.FastCount() == Count);

		peopleList.AddLast(person);

		Assert.IsTrue(peopleList.Last().Equals(person));

		// Test Array
		var result2 = peopleArray.AddLast(person);
		Assert.IsTrue(result2.Length == Count + 1);
		Assert.IsTrue(result2.Last().Equals(person));
	}

	[TestMethod]
	public void AddRangeIfNotExistsTest()
	{
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new List<int> { 3, 4, 5 };

		list.AddRangeIfNotExists(itemsToAdd);

		Assert.AreEqual(5, list.Count);
		Assert.IsTrue(list.Contains(1));
		Assert.IsTrue(list.Contains(2));
		Assert.IsTrue(list.Contains(3));
		Assert.IsTrue(list.Contains(4));
		Assert.IsTrue(list.Contains(5));
	}

	[TestMethod]
	public void AsReadOnlySpanTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var span = list.AsReadOnlySpan();

		// Assert
		Assert.AreEqual(list.Count, span.Length, "The length of the span should match the count of the list.");
		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], span[i], $"The element at index {i} should match between the list and the span.");
		}
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
	public void DoesNotHaveItemsTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(Count).ToList();
		List<Coordinate> nullCollection = null;

		Assert.IsFalse(collection.DoesNotHaveItems());

		Assert.IsTrue(nullCollection.DoesNotHaveItems());
	}

	[TestMethod]
	public void GenerateHashCodeForRecord()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count).ToList();

		var result = people.GenerateHashCode();

		Assert.IsTrue(result < 100);
	}

	[TestMethod]
	public void GenerateHashCodeWithDifferentListsTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 5, 4, 3, 2, 1 };

		// Act
		var hashCode1 = list1.GenerateHashCode();
		var hashCode2 = list2.GenerateHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2, "Hash codes should not be equal for lists with different contents.");
	}


	[TestMethod]
	public void GenerateHashCodeWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var hashCode = list.GenerateHashCode();

		// Assert
		Assert.AreNotEqual(0, hashCode, "Hash code should not be zero for an empty list.");
	}


	[TestMethod]
	public void GenerateHashCodeWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var hashCode1 = list.GenerateHashCode();
		var hashCode2 = list.GenerateHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2, "Hash codes should be equal for the same list contents.");
	}

	[TestMethod]
	public void GenerateHashCodeWithNullListTest()
	{
		// Arrange
		List<int> nullList = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => nullList.GenerateHashCode(), "Expected an ArgumentNullException for a null list.");
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
	public void IndexAtLoopedWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() => list.IndexAtLooped(0), "Expected an ArgumentOutOfRangeException for an empty list.");
	}

	[TestMethod]
	public void IndexAtLoopedWithIndexGreaterThanListCountTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var expectedIndex5 = 1; // Looped back to the start
		var expectedIndex6 = 2; // Looped back to the start + 1

		// Act
		var resultIndex5 = list.IndexAtLooped(5);
		var resultIndex6 = list.IndexAtLooped(6);

		// Assert
		Assert.AreEqual(expectedIndex5, resultIndex5, "The item at index 5 (looped) should be 1.");
		Assert.AreEqual(expectedIndex6, resultIndex6, "The item at index 6 (looped) should be 2.");
	}

	[TestMethod]
	public void IndexAtLoopedWithNegativeIndexTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var expectedIndexMinus1 = 5; // Looped to the end
		var expectedIndexMinus2 = 4; // Looped to the end - 1

		// Act
		var resultIndexMinus1 = list.IndexAtLooped(-1);
		var resultIndexMinus2 = list.IndexAtLooped(-2);

		// Assert
		Assert.AreEqual(expectedIndexMinus1, resultIndexMinus1, "The item at index -1 (looped) should be 5.");
		Assert.AreEqual(expectedIndexMinus2, resultIndexMinus2, "The item at index -2 (looped) should be 4.");
	}

	[TestMethod]
	public void IndexAtLoopedWithValidIndexTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var expectedIndex0 = 1;
		var expectedIndex4 = 5;

		// Act
		var resultIndex0 = list.IndexAtLooped(0);
		var resultIndex4 = list.IndexAtLooped(4);

		// Assert
		Assert.AreEqual(expectedIndex0, resultIndex0, "The item at index 0 should be 1.");
		Assert.AreEqual(expectedIndex4, resultIndex4, "The item at index 4 should be 5.");
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
	public void IsEqualToWithBothEmptyListsTest()
	{
		// Arrange
		var list1 = new List<int>();
		var list2 = new List<int>();

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsTrue(result, "Two empty lists should be considered equal.");
	}

	[TestMethod]
	public void IsEqualToWithDifferentListsTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 5, 4, 3, 2, 1 };

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsFalse(result, "Lists with different elements should not be considered equal.");
	}

	[TestMethod]
	public void IsEqualToWithEqualListsTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsTrue(result, "Lists with identical elements should be considered equal.");
	}


	[TestMethod]
	public void IsEqualToWithOneEmptyListTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int>();

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsFalse(result, "A non-empty list and an empty list should not be considered equal.");
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
	public void PivotTest()
	{
		// Arrange
		var source = new List<(string Category, string Product, int Quantity)>
	{
		("Fruit", "Apple", 5),
		("Fruit", "Banana", 2),
		("Vegetable", "Carrot", 10),
		("Fruit", "Apple", 7),
		("Vegetable", "Beet", 3)
	};

		// Act
		var result = source.Pivot(
			item => item.Category,
			item => item.Product,
			items => items.Sum(item => item.Quantity));

		// Assert
		Assert.AreEqual(2, result.Count, "Expected 2 categories.");
		Assert.IsTrue(result.ContainsKey("Fruit"), "Expected 'Fruit' category.");
		Assert.IsTrue(result.ContainsKey("Vegetable"), "Expected 'Vegetable' category.");
		Assert.AreEqual(12, result["Fruit"]["Apple"], "Expected 12 apples.");
		Assert.AreEqual(2, result["Fruit"]["Banana"], "Expected 2 bananas.");
		Assert.AreEqual(10, result["Vegetable"]["Carrot"], "Expected 10 carrots.");
		Assert.AreEqual(3, result["Vegetable"]["Beet"], "Expected 3 beets.");
	}

	[TestMethod]
	public void PivotWithEmptySourceTest()
	{
		// Arrange
		var source = new List<(string Category, string Product, int Quantity)>();

		// Act
		var result = source.Pivot(
			item => item.Category,
			item => item.Product,
			items => items.Sum(item => item.Quantity));

		// Assert
		Assert.AreEqual(0, result.Count, "Expected empty result for empty source.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void PivotWithNullSourceTest()
	{
		// Arrange
		List<(string Category, string Product, int Quantity)> source = null;

		// Act
		var result = source.Pivot(
			item => item.Category,
			item => item.Product,
			items => items.Sum(item => item.Quantity));

		// Assert is handled by the ExpectedException
	}

	[TestMethod]
	public void RemoveFirstTest()
	{
		var list = new List<int> { 1, 2, 3, 2, 4 };

		var result = list.RemoveFirst(2);

		Assert.IsTrue(result);
		Assert.AreEqual(4, list.Count);
		Assert.AreEqual(1, list[0]);
		Assert.AreEqual(3, list[1]);
		Assert.AreEqual(2, list[2]);
		Assert.AreEqual(4, list[3]);
	}

	[TestMethod]
	public void RemoveLastTest()
	{
		var list = new List<int> { 1, 2, 3, 2, 4 };

		var result = list.RemoveLast(2);

		Assert.IsTrue(result);
		Assert.AreEqual(4, list.Count);
		Assert.AreEqual(1, list[0]);
		Assert.AreEqual(2, list[1]);
		Assert.AreEqual(3, list[2]);
		Assert.AreEqual(4, list[3]);
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
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var originalList = new List<int>(list);

		list.Shuffle();

		Assert.AreEqual(5, list.Count);
		Assert.IsTrue(list.Contains(1));
		Assert.IsTrue(list.Contains(2));
		Assert.IsTrue(list.Contains(3));
		Assert.IsTrue(list.Contains(4));
		Assert.IsTrue(list.Contains(5));
		CollectionAssert.AreNotEqual(originalList, list);
	}

	[TestMethod]
	public void SplitTest()
	{
		var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		var result = list.Split(3);

		Assert.AreEqual(3, result.Count);
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result[0]);
		CollectionAssert.AreEqual(new List<int> { 4, 5, 6 }, result[1]);
		CollectionAssert.AreEqual(new List<int> { 7, 8, 9 }, result[2]);
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
	public void ToCollectionWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var result = list.ToCollection();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsInstanceOfType(result, typeof(Collection<int>), "Result should be of type Collection<int>.");
		Assert.AreEqual(0, result.Count, "Resulting collection should be empty.");
	}

	[TestMethod]
	public void ToCollectionWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = list.ToCollection();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsInstanceOfType(result, typeof(Collection<int>), "Result should be of type Collection<int>.");
		Assert.AreEqual(list.Count, result.Count, "Resulting collection should have the same count as the source list.");
		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], result[i], $"Item at index {i} should be equal in both list and resulting collection.");
		}
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToCollectionWithNullListTest()
	{
		// Arrange
		List<int> list = null;

		// Act
		var result = list.ToCollection();

		// Assert is handled by the ExpectedException
	}


	[TestMethod]
	public void ToDistinctBlockingCollectionCompleteAddingTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };

		// Act
		var result = list.ToDistinctBlockingCollection(completeAdding: true);

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsTrue(result.IsAddingCompleted, "Adding should be marked as completed.");
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
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToDistinctBlockingCollectionWithNullListTest()
	{
		// Arrange
		List<int> list = null;

		// Act
		var result = list.ToDistinctBlockingCollection();

		// Assert is handled by the ExpectedException
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
	public void ToFastSortedList_WithCustomComparer_ShouldReturnSortedList()
	{
		// Arrange
		var list = new List<string> { "apple", "banana", "cherry" };
		var comparer = Comparer<string>.Create((x, y) => y.CompareTo(x)); // Reverse order

		// Act
		var result = list.ToFastSortedList(comparer);

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.AreEqual(list.Count, result.Count, "Resulting list should have the same count as the source list.");
		CollectionAssert.AreEqual(new List<string> { "cherry", "banana", "apple" }, result, "Resulting list should be sorted in reverse order.");
	}

	[TestMethod]
	public void ToFastSortedList_WithEmptyList_ShouldReturnEmptyList()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var result = list.ToFastSortedList();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.AreEqual(0, result.Count, "Resulting list should be empty.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToFastSortedList_WithNullComparer_ShouldThrowArgumentNullException()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		IComparer<int> comparer = null;

		// Act
		var result = list.ToFastSortedList(comparer);

		// Assert is handled by the ExpectedException
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToFastSortedList_WithNullList_ShouldThrowArgumentNullException()
	{
		// Arrange
		List<int> list = null;

		// Act
		var result = list.ToFastSortedList();

		// Assert is handled by the ExpectedException
	}

	[TestMethod]
	public void ToFastSortedList_WithValidList_ShouldReturnSortedList()
	{
		// Arrange
		var list = new List<int> { 5, 3, 1, 4, 2 };

		// Act
		var result = list.ToFastSortedList();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.AreEqual(list.Count, result.Count, "Resulting list should have the same count as the source list.");
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, result, "Resulting list should be sorted.");
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
	public void ToFrozenSetWithDuplicatesTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

		// Act
		var result = list.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.AreEqual(list.Distinct().Count(), result.Count, "Resulting FrozenSet should contain distinct elements only.");
		foreach (var item in list.Distinct())
		{
			Assert.IsTrue(result.Contains(item), $"Item {item} should be present in the resulting FrozenSet.");
		}
	}

	[TestMethod]
	public void ToFrozenSetWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var result = list.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.AreEqual(0, result.Count, "Resulting FrozenSet should be empty.");
	}

	[TestMethod]
	public void ToFrozenSetWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = list.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.AreEqual(list.Count, result.Count, "Resulting FrozenSet should have the same count as the source list.");
		foreach (var item in list)
		{
			Assert.IsTrue(result.Contains(item), $"Item {item} should be present in the resulting FrozenSet.");
		}
	}


	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToFrozenSetWithNullListTest()
	{
		// Arrange
		List<int> list = null;

		// Act
		var result = list.ToFrozenSet();

		// Assert is handled by the ExpectedException
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
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task ToListAsync_WithNullInput_ShouldThrowArgumentNullException()
	{
		// Arrange
		IAsyncEnumerable<int> data = null;
		var cancellationToken = CancellationToken.None;

		// Act
		await data.ToListAsync(cancellationToken);
	}

	[TestMethod]
	public async Task ToListAsync_WithValidInput_ShouldReturnList()
	{
		// Arrange
		var data = GetAsyncEnumerable(new[] { 1, 2, 3, 4, 5 });
		var cancellationToken = CancellationToken.None;

		// Act
		var result = await data.ToListAsync(cancellationToken);

		// Assert
		Assert.AreEqual(5, result.Count);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
		Assert.AreEqual(3, result[2]);
		Assert.AreEqual(4, result[3]);
		Assert.AreEqual(5, result[4]);
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

	[TestMethod]
	public void ToReadOnlyListWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var readOnlyList = list.ToReadOnlyList();

		// Assert
		Assert.IsNotNull(readOnlyList, "Result should not be null.");
		Assert.AreEqual(0, readOnlyList.Count, "Resulting IReadOnlyList should be empty.");
	}

	[TestMethod]
	public void ToReadOnlyListWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var readOnlyList = list.ToReadOnlyList();

		// Assert
		Assert.IsNotNull(readOnlyList, "Result should not be null.");
		Assert.AreEqual(list.Count, readOnlyList.Count, "Resulting IReadOnlyList should have the same count as the source list.");
		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], readOnlyList[i], $"Item at index {i} should be equal in both list and resulting IReadOnlyList.");
		}
	}


	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToReadOnlyListWithNullListTest()
	{
		// Arrange
		List<int> list = null;

		// Act
		var readOnlyList = list.ToReadOnlyList();

		// Assert is handled by the ExpectedException
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var readOnlyObservableCollection = list.ToReadOnlyObservableCollection();

		// Assert
		Assert.IsNotNull(readOnlyObservableCollection, "Result should not be null.");
		Assert.AreEqual(0, readOnlyObservableCollection.Count, "Resulting ReadOnlyObservableCollection should be empty.");
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var readOnlyObservableCollection = list.ToReadOnlyObservableCollection();

		// Assert
		Assert.IsNotNull(readOnlyObservableCollection, "Result should not be null.");
		Assert.AreEqual(list.Count, readOnlyObservableCollection.Count, "Resulting ReadOnlyObservableCollection should have the same count as the source list.");
		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], readOnlyObservableCollection[i], $"Item at index {i} should be equal in both list and resulting ReadOnlyObservableCollection.");
		}
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToReadOnlyObservableCollectionWithNullListTest()
	{
		// Arrange
		List<int> list = null;

		// Act
		var readOnlyObservableCollection = list.ToReadOnlyObservableCollection();

		// Assert is handled by the ExpectedException
	}

}

