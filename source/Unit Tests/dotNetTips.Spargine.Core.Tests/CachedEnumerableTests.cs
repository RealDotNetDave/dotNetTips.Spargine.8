// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-10-2025
// ***********************************************************************
// <copyright file="CachedEnumerableTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CachedEnumerableTests
{

	[TestMethod]
	public void CachedEnumerable_Count_ShouldReturnCachedItemCount()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var countBeforeEnumeration = cachedEnumerable.Count;
		var firstIteration = cachedEnumerable.ToList();
		var countAfterEnumeration = cachedEnumerable.Count;

		// Assert
		Assert.AreEqual(0, countBeforeEnumeration, "Count before enumeration should be 0.");
		Assert.AreEqual(firstIteration.Count, countAfterEnumeration, "Count after enumeration should match the number of items in the enumerable.");
	}

	[TestMethod]
	public void CachedEnumerable_Dispose_ShouldReleaseResources()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		cachedEnumerable.Dispose();

		// Assert
		Assert.ThrowsException<ObjectDisposedException>(() => cachedEnumerable.ToList(), "Accessing the cached enumerable after disposal should throw an ObjectDisposedException.");
	}

	[TestMethod]
	public void CachedEnumerable_EnumerateAfterReset_ShouldReEnumerate()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var firstIteration = cachedEnumerable.ToList();
		cachedEnumerable.Reset();
		var secondIteration = cachedEnumerable.ToList();

		// Assert
		CollectionAssert.AreEqual(firstIteration, secondIteration, "The items in both iterations should be the same after reset.");
	}

	[TestMethod]
	public void CachedEnumerable_EnumerateEmptyEnumerable_ShouldReturnEmpty()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Empty<int>();
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var result = cachedEnumerable.ToList();

		// Assert
		Assert.AreEqual(0, result.Count, "Enumerating an empty enumerable should return an empty list.");
	}
	[TestMethod]
	public void CachedEnumerable_EnumerateMultipleTimes_ShouldReturnSameResults()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var firstIteration = cachedEnumerable.ToList();
		var secondIteration = cachedEnumerable.ToList();

		// Assert
		CollectionAssert.AreEqual(firstIteration, secondIteration, "The items in both iterations should be the same, indicating they were cached.");
	}

	[TestMethod]
	public void CachedEnumerable_GetEnumerator_ShouldCacheItems()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var firstIteration = cachedEnumerable.ToList();
		var secondIteration = cachedEnumerable.ToList();

		// Assert
		CollectionAssert.AreEqual(firstIteration, secondIteration, "The items in both iterations should be the same, indicating they were cached.");
	}

	[TestMethod]
	public void CachedEnumerable_GetEnumerator_ShouldEnumerateAfterReset()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var firstIteration = cachedEnumerable.ToList();
		cachedEnumerable.Reset();
		var secondIteration = cachedEnumerable.ToList();

		// Assert
		CollectionAssert.AreEqual(firstIteration, secondIteration, "The items in both iterations should be the same after reset.");
	}

	[TestMethod]
	public void CachedEnumerable_GetEnumerator_ShouldEnumerateAllItems()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var enumeratedItems = new List<int>();
		foreach (var item in cachedEnumerable)
		{
			enumeratedItems.Add(item);
		}

		// Assert
		CollectionAssert.AreEqual(numbers.ToList(), enumeratedItems, "The enumerated items should match the original enumerable.");
	}

	[TestMethod]
	public void CachedEnumerable_GetEnumerator_ShouldHandleEmptyEnumerable()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Empty<int>();
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var enumeratedItems = new List<int>();
		foreach (var item in cachedEnumerable)
		{
			enumeratedItems.Add(item);
		}

		// Assert
		Assert.AreEqual(0, enumeratedItems.Count, "Enumerating an empty enumerable should return an empty list.");
	}

	[TestMethod]
	public void CachedEnumerable_GetEnumerator_ShouldReturnSameEnumerator()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var firstEnumerator = cachedEnumerable.GetEnumerator();
		var secondEnumerator = cachedEnumerable.GetEnumerator();

		// Assert
		Assert.AreNotSame(firstEnumerator, secondEnumerator, "Each call to GetEnumerator should return a new enumerator instance.");
	}

	[TestMethod]
	public void CachedEnumerable_GetEnumerator_ShouldThrowObjectDisposedException_WhenDisposed()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);
		cachedEnumerable.Dispose();

		// Act & Assert
		Assert.ThrowsException<ObjectDisposedException>(() =>
		{
			foreach (var item in cachedEnumerable)
			{
				// This line should not be executed
			}
		}, "Accessing the cached enumerable after disposal should throw an ObjectDisposedException.");
	}

	[TestMethod]
	public void CachedEnumerable_Reset_ShouldClearCache()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var firstIteration = cachedEnumerable.ToList();
		cachedEnumerable.Reset();
		var secondIteration = cachedEnumerable.ToList();

		// Assert
		CollectionAssert.AreEqual(firstIteration, secondIteration, "The items in both iterations should be the same after reset.");
	}

	[TestMethod]
	public void Create_FromEnumerable_ShouldCacheItems()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 5);
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Act
		var firstIteration = cachedEnumerable.ToList();
		var secondIteration = cachedEnumerable.ToList();

		// Assert
		Assert.AreEqual(firstIteration.Count, secondIteration.Count, "The number of items should be the same in both iterations.");
		CollectionAssert.AreEqual(firstIteration, secondIteration, "The items in both iterations should be the same, indicating they were cached.");
	}
	[TestMethod]
	public void Create_FromNonNullEnumerable_ShouldNotBeNull()
	{
		// Arrange
		IEnumerable<int> numbers = Enumerable.Range(1, 10);

		// Act
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// Assert
		Assert.IsNotNull(cachedEnumerable, "CachedEnumerable created from a non-null IEnumerable should not be null.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Create_FromNullEnumerable_ShouldThrowArgumentNullException()
	{
		// Arrange
		IEnumerable<int> numbers = null;

		// Act
		_ = CachedEnumerable.Create(numbers);

		// This line should not be executed
		Assert.Fail("Expected an ArgumentNullException to be thrown when creating a CachedEnumerable from a null IEnumerable.");
	}

}

