// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-24-2024
// ***********************************************************************
// <copyright file="CachedEnumerableTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests;


[TestClass]
public class CachedEnumerableTests
{

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
		var cachedEnumerable = CachedEnumerable.Create(numbers);

		// This line should not be executed
		Assert.Fail("Expected an ArgumentNullException to be thrown when creating a CachedEnumerable from a null IEnumerable.");
	}

}

