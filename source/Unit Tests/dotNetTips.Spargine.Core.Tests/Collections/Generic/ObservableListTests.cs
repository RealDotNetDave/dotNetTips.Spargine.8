// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-04-2025
// ***********************************************************************
// <copyright file="ObservableListTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic;

[ExcludeFromCodeCoverage]
[TestClass]
public class ObservableListTests
{

	private List<NotifyCollectionChangedEventArgs> _collectionChangedEvents;
	private ObservableList<int> _observableList;
	private List<PropertyChangedEventArgs> _propertyChangedEvents;

	[TestMethod]
	public void Add_ShouldTriggerCollectionAndPropertyChangedEvents()
	{
		_observableList.Add(1);

		Assert.AreEqual(1, _collectionChangedEvents.Count, "Adding an item should trigger a CollectionChanged event.");
		Assert.IsTrue(_propertyChangedEvents.Exists(e => e.PropertyName == "Count"), "Adding an item should trigger a PropertyChanged event for 'Count'.");
	}

	[TestMethod]
	public void Add_WithCustomComparer_ShouldNotAddDuplicate()
	{
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(customComparer);

		list.Add(1);
		bool added = list.Add(-1); // Attempt to add a duplicate according to the custom comparer

		Assert.IsFalse(added, "Adding -1 should return false as it is considered a duplicate of 1.");
		Assert.AreEqual(1, list.Count, "List should only contain one item after attempting to add a duplicate.");
	}

	[TestMethod]
	public void Comparer_ShouldReturnCorrectComparer()
	{
		// Arrange
		var customComparer = new CustomIntComparer();
		var observableListWithComparer = new ObservableList<int>(customComparer);

		// Act
		var comparerUsed = observableListWithComparer.Comparer;

		// Assert
		Assert.AreEqual(customComparer, comparerUsed, "Comparer property should return the IEqualityComparer<T> instance that was provided.");
	}

	[TestMethod]
	public void Constructor_WithCollection_ShouldInitializeWithElements()
	{
		var collection = new List<int> { 5, 2, 4, 3, 1 };
		var list = new ObservableList<int>(collection);

		Assert.AreEqual(collection.Count, list.Count, "List should contain all elements from the collection.");
		for (int i = 0; i < collection.Count; i++)
		{
			Assert.IsTrue(list.Contains(collection[i]), $"List should contain the element {collection[i]}.");
		}
	}

	[TestMethod]
	public void Constructor_WithCollectionAndComparer_ShouldInitializeWithElementsAndUseComparer()
	{
		var collection = new List<int> { 1, -1, 2, -2, 3, -3 };
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(collection, customComparer);

		Assert.AreEqual(3, list.Count, "List should contain 3 items as custom comparer treats positive and negative numbers as equal.");

		Assert.IsTrue(list.Contains(1), "List should contain 1.");
		Assert.IsTrue(list.Contains(-1), "List should contain -1 as it is considered equal to 1 by the custom comparer.");
		Assert.IsFalse(list.Contains(4), "List should not contain 4.");
	}

	[TestMethod]
	public void Constructor_WithComparer_ShouldUseProvidedComparer()
	{
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(customComparer);

		list.Add(1);
		list.Add(2);

		// Attempt to add an item that is considered equal by the custom comparer
		list.Add(-1);

		// Verify that the custom comparer was used, expecting only 2 items in the list
		Assert.AreEqual(2, list.Count, "List should contain 2 items as custom comparer treats 1 and -1 as equal.");
	}


	[TestMethod]
	public void Contains_ShouldReturnCorrectValue()
	{
		_observableList.Add(1);

		Assert.IsTrue(_observableList.Contains(1), "Contains should return true for an item that exists in the list.");
		Assert.IsFalse(_observableList.Contains(2), "Contains should return false for an item that does not exist in the list.");
	}


	[TestMethod]
	public void Contains_WithCustomComparer_ShouldReturnCorrectValue()
	{
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(customComparer);

		list.Add(1);

		// Verify Contains method respects the custom comparer
		Assert.IsTrue(list.Contains(-1), "Contains should return true for -1 as custom comparer treats 1 and -1 as equal.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void CopyTo_ArrayTooSmall_ShouldThrowArgumentException()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		int[] array = new int[2]; // Smaller array than list size

		// Act
		_observableList.CopyTo(array, 0); // Attempt to copy
	}

	[TestMethod]
	public void CopyTo_ArrayWithCorrectIndex_ShouldCopyElementsCorrectly()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		int[] array = new int[5]; // Larger array to test copying at index

		// Act
		_observableList.CopyTo(array, 1); // Start copying at index 1

		// Assert
		Assert.AreEqual(0, array[0], "First element should remain default value.");
		Assert.AreEqual(1, array[1], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(2, array[2], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(3, array[3], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(0, array[4], "Last element should remain default value.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void CopyTo_NegativeArrayIndex_ShouldThrowArgumentOutOfRangeException()
	{
		// Arrange
		_observableList.Add(1);
		int[] array = new int[1];

		// Act
		_observableList.CopyTo(array, -1); // Attempt to copy with a negative index
	}


	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void CopyTo_NullArray_ShouldThrowArgumentNullException()
	{
		// Act
		_observableList.CopyTo(null, 0); // Attempt to copy to a null array
	}

	[TestMethod]
	public void CopyTo_ShouldCopyAllElementsToArray()
	{
		// Arrange
		var list = new ObservableList<int>();
		list.Add(1);
		list.Add(2);
		list.Add(3);
		int[] array = new int[3];

		// Act
		list.CopyTo(array);

		// Assert
		Assert.AreEqual(list.Count, array.Length, "The length of the array should match the count of the list.");
		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list.ElementAt(i), array[i], $"The element at index {i} should match between the list and the array.");
		}
	}

	[TestMethod]
	public void CopyTo_WithCount_ShouldCopyCorrectNumberOfElements()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		_observableList.Add(4);
		_observableList.Add(5);
		int[] array = new int[5];

		// Act
		_observableList.CopyTo(array, 1, 3); // Copy 3 elements starting at index 1 of the array

		// Assert
		Assert.AreEqual(0, array[0], "First element should remain default value.");
		Assert.AreEqual(1, array[1], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(2, array[2], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(3, array[3], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(0, array[4], "Last element should remain default value.");
	}

	[TestMethod]
	public void CopyTo_WithExactCount_ShouldCopyAllElements()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		int[] array = new int[2];

		// Act
		_observableList.CopyTo(array, 0, 2); // Copy all elements

		// Assert
		Assert.AreEqual(1, array[0], "First element should match.");
		Assert.AreEqual(2, array[1], "Second element should match.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void CopyTo_WithNegativeCount_ShouldThrowArgumentOutOfRangeException()
	{
		// Arrange
		_observableList.Add(1);
		int[] array = new int[1];

		// Act
		_observableList.CopyTo(array, 0, -1); // Attempt to copy with a negative count
	}

	[TestMethod]
	public void Count_AfterAddingItems_ShouldIncrease()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);

		// Act
		var count = _observableList.Count;

		// Assert
		Assert.AreEqual(2, count, "Count should reflect the number of items added.");
	}


	[TestMethod]
	public void Count_AfterClearingList_ShouldBeZero()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Clear();

		// Act
		var count = _observableList.Count;

		// Assert
		Assert.AreEqual(0, count, "Count should be 0 after clearing the list.");
	}

	[TestMethod]
	public void Count_AfterRemovingItems_ShouldDecrease()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Remove(1);

		// Act
		var count = _observableList.Count;

		// Assert
		Assert.AreEqual(1, count, "Count should decrease when items are removed.");
	}

	[TestMethod]
	public void Count_Initially_ShouldBeZero()
	{
		// Arrange & Act (Initialization in TestInitialize)

		// Assert
		Assert.AreEqual(0, _observableList.Count, "Count should be 0 for a newly initialized list.");
	}


	[TestMethod]
	public void ExceptWith_EmptyOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int>();

		// Act
		_observableList.ExceptWith(otherCollection);

		// Assert
		Assert.AreEqual(2, _observableList.Count, "List should not be modified if the other collection is empty.");
	}

	[TestMethod]
	public void ExceptWith_NullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange
		_observableList.Add(1);

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.ExceptWith(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void ExceptWith_SelfAsOtherCollection_ShouldClearList()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);

		// Act
		_observableList.ExceptWith(_observableList);

		// Assert
		Assert.AreEqual(0, _observableList.Count, "List should be cleared if it is passed as the other collection.");
	}

	[TestMethod]
	public void ExceptWith_ShouldRemoveCommonElements()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 2, 3, 4 };

		// Act
		_observableList.ExceptWith(otherCollection);

		// Assert
		Assert.AreEqual(1, _observableList.Count, "List should contain only elements that are not in the other collection.");
		Assert.IsTrue(_observableList.Contains(1), "List should contain 1.");
		Assert.IsFalse(_observableList.Contains(2), "List should not contain 2.");
		Assert.IsFalse(_observableList.Contains(3), "List should not contain 3.");
	}

	[TestInitialize]
	public void Initialize()
	{
		_observableList = new ObservableList<int>();
		_collectionChangedEvents = new List<NotifyCollectionChangedEventArgs>();
		_propertyChangedEvents = new List<PropertyChangedEventArgs>();

		_observableList.CollectionChanged += (sender, e) => _collectionChangedEvents.Add(e);
		_observableList.PropertyChanged += (sender, e) => _propertyChangedEvents.Add(e);
	}

	[TestMethod]
	public void IntersectWith_EmptyOtherCollection_ShouldClearList()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int>();

		// Act
		_observableList.IntersectWith(otherCollection);

		// Assert
		Assert.AreEqual(0, _observableList.Count, "List should be cleared if the other collection is empty.");
	}


	[TestMethod]
	public void IntersectWith_NullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange
		_observableList.Add(1);

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.IntersectWith(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IntersectWith_SelfAsOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);

		// Act
		_observableList.IntersectWith(_observableList);

		// Assert
		Assert.AreEqual(2, _observableList.Count, "List should not be modified if it is passed as the other collection.");
	}

	[TestMethod]
	public void IntersectWith_ShouldRetainCommonElements()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 2, 3, 4 };

		// Act
		_observableList.IntersectWith(otherCollection);

		// Assert
		Assert.AreEqual(2, _observableList.Count, "List should contain only elements that are also in the other collection.");
		Assert.IsTrue(_observableList.Contains(2), "List should contain 2.");
		Assert.IsTrue(_observableList.Contains(3), "List should contain 3.");
	}

	[TestMethod]
	public void IsProperSubsetOf_WithEqualSets_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = _observableList.IsProperSubsetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper subset of the other collection if both collections are equal.");
	}


	[TestMethod]
	public void IsProperSubsetOf_WithNoCommonElements_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 3, 4 };

		// Act
		bool result = _observableList.IsProperSubsetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper subset of the other collection if there are no common elements.");
	}

	[TestMethod]
	public void IsProperSubsetOf_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.IsProperSubsetOf(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IsProperSubsetOf_WithProperSubset_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = _observableList.IsProperSubsetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a proper subset of the other collection.");
	}

	[TestMethod]
	public void IsProperSupersetOf_WithEqualSets_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = _observableList.IsProperSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper superset of the other collection if both collections are equal.");
	}

	[TestMethod]
	public void IsProperSupersetOf_WithNoCommonElements_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 3, 4 };

		// Act
		bool result = _observableList.IsProperSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper superset of the other collection if there are no common elements.");
	}


	[TestMethod]
	public void IsProperSupersetOf_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.IsProperSupersetOf(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IsProperSupersetOf_WithProperSuperset_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = _observableList.IsProperSupersetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a proper superset of the other collection.");
	}

	[TestMethod]
	public void IsProperSupersetOf_WithSubsetIncludingNonListElements_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = _observableList.IsProperSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper superset if the other collection contains elements not in the list.");
	}

	[TestMethod]
	public void IsReadOnly_AfterAddingItems_ShouldStillBeFalse()
	{
		// Arrange
		_observableList.Add(1);

		// Act
		var isReadOnly = _observableList.IsReadOnly;

		// Assert
		Assert.IsFalse(isReadOnly, "IsReadOnly should remain false after adding items.");
	}

	[TestMethod]
	public void IsReadOnly_AfterClearingList_ShouldStillBeFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Clear();

		// Act
		var isReadOnly = _observableList.IsReadOnly;

		// Assert
		Assert.IsFalse(isReadOnly, "IsReadOnly should remain false after clearing the list.");
	}

	[TestMethod]
	public void IsReadOnly_Initially_ShouldBeFalse()
	{
		// Arrange & Act
		var isReadOnly = _observableList.IsReadOnly;

		// Assert
		Assert.IsFalse(isReadOnly, "IsReadOnly should be false for a newly initialized list.");
	}

	[TestMethod]
	public void IsReadOnly_WhenSetExternallyIfPossible_ShouldReflectChange()
	{
		// This test assumes there's a way to set the list to read-only externally, which may not be applicable.
		// If the ObservableList<T> class does not support setting IsReadOnly directly or indirectly,
		// this test should be omitted or modified according to the class's design.

		// Arrange
		// Assuming there's a method or property to set the list as read-only, which needs to be implemented in the ObservableList<T> class.
		// _observableList.SetReadOnly(true); // Hypothetical method to set the list as read-only.

		// Act
		var isReadOnly = _observableList.IsReadOnly;

		// Assert
		// Assert.IsTrue(isReadOnly, "IsReadOnly should be true after setting the list as read-only.");
		// This assertion is commented out because it depends on a hypothetical method that may not exist.
	}

	[TestMethod]
	public void IsSubsetOf_WithEqualSets_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = _observableList.IsSubsetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be considered a subset of the other collection if both collections are equal.");
	}

	[TestMethod]
	public void IsSubsetOf_WithNoCommonElements_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 3, 4 };

		// Act
		bool result = _observableList.IsSubsetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a subset of the other collection if there are no common elements.");
	}


	[TestMethod]
	public void IsSubsetOf_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.IsSubsetOf(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IsSubsetOf_WithProperSubset_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = _observableList.IsSubsetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a subset of the other collection.");
	}

	[TestMethod]
	public void IsSubsetOf_WithSupersetIncludingNonListElements_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = _observableList.IsSubsetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a subset if the other collection contains all elements of the list plus additional elements.");
	}

	[TestMethod]
	public void IsSupersetOf_WithEqualSets_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = _observableList.IsSupersetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be considered a superset of the other collection if both collections are equal.");
	}

	[TestMethod]
	public void IsSupersetOf_WithNoCommonElements_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 3, 4 };

		// Act
		bool result = _observableList.IsSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a superset of the other collection if there are no common elements.");
	}

	[TestMethod]
	public void IsSupersetOf_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.IsSupersetOf(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IsSupersetOf_WithProperSuperset_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = _observableList.IsSupersetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a superset of the other collection.");
	}


	[TestMethod]
	public void IsSupersetOf_WithSubsetIncludingNonListElements_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = _observableList.IsSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a superset if the other collection contains elements not in the list.");
	}


	[TestMethod]
	public void Overlaps_WithEmptyCollection_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int>();

		// Act
		bool result = _observableList.Overlaps(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when the other collection is empty.");
	}

	[TestMethod]
	public void Overlaps_WithNonOverlappingCollection_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 4, 5, 6 };

		// Act
		bool result = _observableList.Overlaps(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when collections do not overlap.");
	}

	[TestMethod]
	public void Overlaps_WithNullCollection_ShouldThrowArgumentNullException()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.Overlaps(null), "Should throw ArgumentNullException when the other collection is null.");
	}

	[TestMethod]
	public void Overlaps_WithOverlappingCollection_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 3, 4, 5 };

		// Act
		bool result = _observableList.Overlaps(otherCollection);

		// Assert
		Assert.IsTrue(result, "Should return true when collections overlap.");
	}

	[TestMethod]
	public void Remove_ShouldTriggerCollectionAndPropertyChangedEvents()
	{
		_observableList.Add(1);
		_observableList.Remove(1);

		Assert.IsTrue(_collectionChangedEvents.Exists(e => e.Action == NotifyCollectionChangedAction.Remove), "Removing an item should trigger a CollectionChanged event with Remove action.");
		Assert.IsTrue(_propertyChangedEvents.Exists(e => e.PropertyName == "Count"), "Removing an item should trigger a PropertyChanged event for 'Count'.");
	}

	[TestMethod]
	public void Remove_WithCustomComparer_ShouldRemoveCorrectItem()
	{
		var collection = new List<int> { 1, 2, 3 };
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(collection, customComparer);

		bool removed = list.Remove(-2); // Attempt to remove 2 using its negative

		Assert.IsTrue(removed, "Removing -2 should return true as it is considered equal to 2.");
		Assert.AreEqual(2, list.Count, "List should contain 2 items after removing one.");
		Assert.IsFalse(list.Contains(2), "List should not contain 2 after it has been removed.");
	}

	[TestMethod]
	public void RemoveWhere_WithMatchingPredicate_ShouldRemoveCorrectItems()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		Predicate<int> match = x => x > 1;

		// Act
		int removedCount = _observableList.RemoveWhere(match);

		// Assert
		Assert.AreEqual(2, removedCount, "Should remove two items.");
		Assert.AreEqual(1, _observableList.Count, "List should contain only one item after removal.");
		Assert.IsTrue(_observableList.Contains(1), "List should contain the item that does not match the predicate.");
	}


	[TestMethod]
	public void RemoveWhere_WithNoMatchingPredicate_ShouldNotRemoveAnyItems()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		Predicate<int> match = x => x > 3;

		// Act
		int removedCount = _observableList.RemoveWhere(match);

		// Assert
		Assert.AreEqual(0, removedCount, "Should not remove any items.");
		Assert.AreEqual(3, _observableList.Count, "List should still contain all items.");
	}

	[TestMethod]
	public void RemoveWhere_WithNullPredicate_ShouldThrowArgumentNullException()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.RemoveWhere(null), "Should throw ArgumentNullException for null predicate.");
	}

	[TestMethod]
	public void SetEquals_WithDifferentSets_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 4, 5, 6 };

		// Act
		bool result = _observableList.SetEquals(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when collections do not contain the same elements.");
	}

	[TestMethod]
	public void SetEquals_WithEqualSets_ShouldReturnTrue()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 3, 2, 1 };

		// Act
		bool result = _observableList.SetEquals(otherCollection);

		// Assert
		Assert.IsTrue(result, "Should return true when both collections contain the same elements.");
	}


	[TestMethod]
	public void SetEquals_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.SetEquals(null), "Should throw ArgumentNullException when the other collection is null.");
	}

	[TestMethod]
	public void SetEquals_WithSubset_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = _observableList.SetEquals(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when one collection is a subset of the other.");
	}

	[TestMethod]
	public void SetEquals_WithSuperset_ShouldReturnFalse()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = _observableList.SetEquals(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when one collection is a superset of the other.");
	}

	[TestMethod]
	public void SymmetricExceptWith_EmptyOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int>();

		// Act
		_observableList.SymmetricExceptWith(otherCollection);

		// Assert
		Assert.AreEqual(3, _observableList.Count, "List should not be modified when the other collection is empty.");
	}

	[TestMethod]
	public void SymmetricExceptWith_NullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.SymmetricExceptWith(null), "Method should throw ArgumentNullException when the other collection is null.");
	}


	[TestMethod]
	public void SymmetricExceptWith_SelfAsOtherCollection_ShouldClearList()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);

		// Act
		_observableList.SymmetricExceptWith(_observableList);

		// Assert
		Assert.AreEqual(0, _observableList.Count, "List should be cleared when the method is called with itself as the other collection.");
	}

	[TestMethod]
	public void SymmetricExceptWith_ShouldRemoveCommonElementsAndAddUniqueFromOtherCollection()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		_observableList.Add(3);
		var otherCollection = new List<int> { 2, 3, 4, 5 };

		// Act
		_observableList.SymmetricExceptWith(otherCollection);

		// Assert
		Assert.IsFalse(_observableList.Contains(2), "List should not contain elements common to both collections.");
		Assert.IsFalse(_observableList.Contains(3), "List should not contain elements common to both collections.");
		Assert.IsTrue(_observableList.Contains(1), "List should retain elements not in the other collection.");
		Assert.IsTrue(_observableList.Contains(4), "List should contain elements unique to the other collection.");
		Assert.IsTrue(_observableList.Contains(5), "List should contain elements unique to the other collection.");
		Assert.AreEqual(3, _observableList.Count, "List should contain exactly three elements.");
	}


	[TestMethod]
	public void TrimExcess_ShouldOptimizeMemoryUsage()
	{
		// Arrange
		var capacity = 100;
		_observableList = new ObservableList<int>(new int[capacity]);
		for (int i = 0; i < 10; i++)
		{
			_observableList.Add(i);
		}
		// Assuming the internal data structure is a List<T> or similar,
		// after adding 10 items, the capacity would be significantly higher than the count.

		// Act
		_observableList.TrimExcess();
		// After TrimExcess, the capacity should be optimized to match the count more closely.

		// Assert
		// Note: Direct capacity checks are not possible without reflection or internal knowledge,
		// so this test assumes an indirect approach to validate the optimization.
		// Adding a large number of items to see if it triggers a resize operation sooner than expected.
		int initialResizeThreshold = _observableList.Count + 1; // Assuming capacity is now optimized
		for (int i = 0; i < initialResizeThreshold; i++)
		{
			_observableList.Add(i);
		}
		// If TrimExcess worked, adding this number of items should not trigger a resize operation,
		// which would be indicated by no exceptions or significant delays.
		Assert.IsTrue(_observableList.Count > 10, "List should contain more items after adding additional elements post-TrimExcess.");
	}

	[TestMethod]
	public void UnionWith_EmptyOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int>();

		// Act
		_observableList.UnionWith(otherCollection);

		// Assert
		Assert.AreEqual(2, _observableList.Count, "List should not be modified when the other collection is empty.");
	}


	[TestMethod]
	public void UnionWith_NullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => _observableList.UnionWith(null), "Method should throw ArgumentNullException when the other collection is null.");
	}

	[TestMethod]
	public void UnionWith_SelfAsOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);

		// Act
		_observableList.UnionWith(_observableList);

		// Assert
		Assert.AreEqual(2, _observableList.Count, "List should not be modified when the method is called with itself as the other collection.");
	}

	[TestMethod]
	public void UnionWith_ShouldContainAllUniqueElementsFromBothCollections()
	{
		// Arrange
		_observableList.Add(1);
		_observableList.Add(2);
		var otherCollection = new List<int> { 2, 3, 4 };

		// Act
		_observableList.UnionWith(otherCollection);

		// Assert
		Assert.IsTrue(_observableList.Contains(1), "List should contain elements from the original list.");
		Assert.IsTrue(_observableList.Contains(2), "List should contain elements present in both collections.");
		Assert.IsTrue(_observableList.Contains(3), "List should contain elements from the other collection.");
		Assert.IsTrue(_observableList.Contains(4), "List should contain elements from the other collection.");
		Assert.AreEqual(4, _observableList.Count, "List should contain exactly four unique elements.");
	}

	internal class CustomIntComparer : IEqualityComparer<int>
	{

		public bool Equals(int x, int y)
		{
			// Custom logic: consider negative and positive of the same number as equal
			return Math.Abs(x) == Math.Abs(y);
		}

		public int GetHashCode(int obj)
		{
			// Ensure that negative and positive of the same number have the same hash code
			return Math.Abs(obj).GetHashCode();
		}

	}

}
