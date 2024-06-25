// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-13-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="DistinctBlockingCollectionTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

/// <summary>
/// Defines test class DistinctBlockingCollectionTests.
/// </summary>
[TestClass]
public class DistinctBlockingCollectionTests
{

	/// <summary>
	/// Defines the test method AddRangeTest.
	/// </summary>
	[TestMethod]
	public void AddRangeTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		Assert.IsTrue(collection.Count == 2);
	}

	/// <summary>
	/// Defines the test method BoundedTest.
	/// </summary>
	[TestMethod]
	public void BoundedTest()
	{
		var collection = new DistinctBlockingCollection<string>(5);

		Assert.IsTrue(collection.BoundedCapacity == 5);
	}

	/// <summary>
	/// Defines the test method ClearTest.
	/// </summary>
	[TestMethod]
	public void ClearTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		collection.Clear();

		Assert.IsTrue(collection.Count == 0);
	}

	/// <summary>
	/// Defines the test method CloneTest.
	/// </summary>
	[TestMethod]
	public void CloneTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		var result = collection.Clone<List<string>>();

		Assert.IsTrue(result.Count == 2);
	}

	/// <summary>
	/// Defines the test method ContainsTest.
	/// </summary>
	[TestMethod]
	public void ContainsTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		Assert.IsTrue(collection.Contains("test2"));
	}

	/// <summary>
	/// Defines the test method CopyToTest.
	/// </summary>
	[TestMethod]
	public void CopyToTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		var array = new string[2];

		collection.CopyTo(array, 0);

		Assert.IsTrue(array.Length == 2);
	}

	/// <summary>
	/// Defines the test method DisposeTest.
	/// </summary>
	[TestMethod]
	public void DisposeTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		collection.Dispose();

		Assert.IsTrue(collection.Count == 0);
	}

	/// <summary>
	/// Defines the test method GetConsumingEnumerableTest.
	/// </summary>
	[TestMethod]
	public void GetConsumingEnumerableTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		var enumerator = collection.GetConsumingEnumerable();

		Assert.IsTrue(enumerator.Any());
	}

	/// <summary>
	/// Defines the test method GetConsumingEnumerableWithCancellationTokenTest.
	/// </summary>
	[TestMethod]
	public void GetConsumingEnumerableWithCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		var enumerator = collection.GetConsumingEnumerable(new CancellationToken());

		Assert.IsTrue(enumerator.Any());
	}

	/// <summary>
	/// Defines the test method IsAddingCompletedTest.
	/// </summary>
	[TestMethod]
	public void IsAddingCompletedTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		Assert.IsTrue(collection.IsAddingCompleted);
	}

	/// <summary>
	/// Defines the test method RemoveTest.
	/// </summary>
	[TestMethod]
	public void RemoveTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		Assert.IsTrue(collection.Remove("test1"));
	}

	/// <summary>
	/// Defines the test method TryAddTest.
	/// </summary>
	[TestMethod]
	public void TryAddTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		Assert.IsTrue(collection.TryAdd("test"));
	}

	/// <summary>
	/// Defines the test method TryAddTimeoutCancellationTest.
	/// </summary>
	[TestMethod]
	public void TryAddTimeoutCancellationTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		Assert.IsTrue(collection.TryAdd("test", 1000, CancellationToken.None));
	}

	/// <summary>
	/// Defines the test method TryAddTimeoutTest.
	/// </summary>
	[TestMethod]
	public void TryAddTimeoutTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		Assert.IsTrue(collection.TryAdd("test", 1000));
	}

	/// <summary>
	/// Defines the test method TryAddTimeSpanTest.
	/// </summary>
	[TestMethod]
	public void TryAddTimeSpanTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		Assert.IsTrue(collection.TryAdd("test", new TimeSpan(0, 0, 10)));
	}

}
