// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-24-2024
// ***********************************************************************
// <copyright file="DistinctConcurrentBagTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

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
	[ExpectedException(typeof(NotImplementedException))]
	public void Remove_ShouldThrowNotImplementedException()
	{
		var bag = new DistinctConcurrentBag<int> { 1 };
		bag.Remove(1);
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
