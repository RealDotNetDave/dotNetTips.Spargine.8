// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-18-2025
// ***********************************************************************
// <copyright file="DistinctConcurrentBagTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

[ExcludeFromCodeCoverage]
[TestClass]
public class DistinctConcurrentBagTests
{

	[TestMethod]
	public void Add_ShouldAddUniqueItem()
	{
		var bag = new DistinctConcurrentBag<int>();
		bag.Add(1);
		Assert.IsTrue(bag.Contains(1));
	}

	[TestMethod]
	public void Add_ShouldIgnoreDuplicate()
	{
		var bag = new DistinctConcurrentBag<int>();
		bag.Add(1);
		bag.Add(1);
		Assert.AreEqual(1, bag.Count);
	}

	[TestMethod]
	public void Clear_ShouldRemoveAllItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		bag.Clear();
		Assert.AreEqual(0, bag.Count);
		Assert.IsFalse(bag.Contains(1));
		Assert.IsFalse(bag.Contains(2));
		Assert.IsFalse(bag.Contains(3));
	}

	[TestMethod]
	public void Constructor_ShouldInitializeEmptyBag()
	{
		var bag = new DistinctConcurrentBag<int>();
		Assert.AreEqual(0, bag.Count);
	}

	[TestMethod]
	public void Constructor_WithCollection_ShouldCopyItems()
	{
		var initialItems = new List<int> { 1, 2, 3 };
		var bag = new DistinctConcurrentBag<int>(initialItems);
		Assert.IsTrue(initialItems.All(item => bag.Contains(item)));
	}

	[TestMethod]
	public void Contains_ShouldReturnFalseForNonExistingItem()
	{
		var bag = new DistinctConcurrentBag<int> { 1 };
		Assert.IsFalse(bag.Contains(2));
	}

	[TestMethod]
	public void Contains_ShouldReturnTrueForExistingItem()
	{
		var bag = new DistinctConcurrentBag<int> { 1 };
		Assert.IsTrue(bag.Contains(1));
	}

	[TestMethod]
	public void CopyTo_ShouldCopyAllItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var array = new int[3];
		bag.CopyTo(array, 0);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, array);
	}

	[TestMethod]
	public void Enumeration_ShouldReturnAllUniqueItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var items = bag.ToList();
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, items);
	}

	[TestMethod]
	public void IsReadOnly_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<int>();
		Assert.IsFalse(bag.IsReadOnly);
	}

	[TestMethod]
	public void Remove_ShouldRemoveItemAndUpdateCount()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		Assert.IsTrue(bag.Remove(2));
		Assert.AreEqual(2, bag.Count);
		Assert.IsFalse(bag.Contains(2));
	}

	[TestMethod]
	public void Remove_ShouldReturnFalseForNonExistingItem()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		Assert.IsFalse(bag.Remove(4));
		Assert.AreEqual(3, bag.Count);
	}

	[TestMethod]
	public void TryAdd_ShouldAddUniqueItemAndReturnTrue()
	{
		var bag = new DistinctConcurrentBag<int>();
		Assert.IsTrue(bag.TryAdd(5));
		Assert.IsTrue(bag.Contains(5));
	}

	[TestMethod]
	public void TryAdd_ShouldReturnFalseForDuplicate()
	{
		var bag = new DistinctConcurrentBag<int>();
		Assert.IsTrue(bag.TryAdd(5));
		Assert.IsFalse(bag.TryAdd(5));
		Assert.AreEqual(1, bag.Count);
	}

	[TestMethod]
	public void TryTake_ShouldRemoveExistingItem()
	{
		var bag = new DistinctConcurrentBag<int> { 1 };
		bool success = bag.TryTake(out int result);
		Assert.IsTrue(success);
		Assert.AreEqual(1, result);
		Assert.IsFalse(bag.Contains(1));
	}

	[TestMethod]
	public void TryTake_ShouldReturnFalseWhenEmpty()
	{
		var bag = new DistinctConcurrentBag<int>();
		bool success = bag.TryTake(out int result);
		Assert.IsFalse(success);
		Assert.AreEqual(default(int), result);
	}

}
