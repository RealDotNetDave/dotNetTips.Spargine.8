// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 02-24-2025
//
// Last Modified By : David McCarter
// Last Modified On : 02-24-2025
// ***********************************************************************
// <copyright file="ConcurrentBagExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[TestClass]
public class ConcurrentBagExtensionsTests
{
	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddRange_NullBag_ThrowsArgumentNullException()
	{
		// Arrange
		ConcurrentBag<int> bag = null;
		var items = new List<int> { 1, 2, 3 };

		// Act
		bag.AddRange(items);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddRange_NullItems_ThrowsArgumentNullException()
	{
		// Arrange
		var bag = new ConcurrentBag<int>();
		List<int> items = null;

		// Act
		bag.AddRange(items);
	}

	[TestMethod]
	public void AddRange_ValidParameters_AddsItems()
	{
		// Arrange
		var bag = new ConcurrentBag<int>();
		var items = new List<int> { 1, 2, 3 };

		// Act
		bag.AddRange(items);

		// Assert
		Assert.AreEqual(3, bag.Count);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void RemoveRange_NullBag_ThrowsArgumentNullException()
	{
		// Arrange
		ConcurrentBag<int> bag = null;
		var items = new List<int> { 1, 2, 3 };

		// Act
		bag.RemoveRange(items);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void RemoveRange_NullItems_ThrowsArgumentNullException()
	{
		// Arrange
		var bag = new ConcurrentBag<int>();
		List<int> items = null;

		// Act
		bag.RemoveRange(items);
	}

	[TestMethod]
	public void RemoveRange_ValidParameters_RemovesItems()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3, 4, 5 };
		var items = new List<int> { 2, 4 };

		// Act
		var result = bag.RemoveRange(items);

		// Assert
		Assert.AreEqual(3, result.Count);
		CollectionAssert.DoesNotContain(result, 2);
		CollectionAssert.DoesNotContain(result, 4);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToList_NullBag_ThrowsArgumentNullException()
	{
		// Arrange
		ConcurrentBag<int> bag = null;

		// Act
		bag.ToList();
	}

	[TestMethod]
	public void ToList_ValidBag_ReturnsList()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };

		// Act
		var result = bag.ToList();

		// Assert
		Assert.AreEqual(3, result.Count);
		CollectionAssert.Contains(result, 1);
		CollectionAssert.Contains(result, 2);
		CollectionAssert.Contains(result, 3);
	}
}
