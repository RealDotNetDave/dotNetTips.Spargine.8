// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-13-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-09-2024
// ***********************************************************************
// <copyright file="DistinctBlockingCollectionTests.cs" company="McCarter Consulting">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

/// <summary>
/// Defines test class DistinctBlockingCollectionTests.
/// </summary>
[TestClass]
public class DistinctBlockingCollectionTests
{
	/// <summary>
	/// Defines the test method AddNullItemTest.
	/// </summary>
	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddNullItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add(null);
	}

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
	/// Defines the test method AddTest.
	/// </summary>
	[TestMethod]
	public void AddTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");

		Assert.AreEqual(1, collection.Count);
		Assert.IsTrue(collection.Contains("test1"));
	}

	/// <summary>
	/// Defines the test method AddWithCancellationTokenTest.
	/// </summary>
	[TestMethod]
	public void AddWithCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationToken = new CancellationToken();
		collection.Add("test1", cancellationToken);

		Assert.AreEqual(1, collection.Count);
		Assert.IsTrue(collection.Contains("test1"));
	}

	/// <summary>
	/// Defines the test method AddWithCancelledTokenTest.
	/// </summary>
	[TestMethod]
	[ExpectedException(typeof(OperationCanceledException))]
	public void AddWithCancelledTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();
		collection.Add("test1", cancellationTokenSource.Token);
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
	/// Defines the test method ClearEmptyCollectionTest.
	/// </summary>
	[TestMethod]
	public void ClearEmptyCollectionTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		collection.Clear();

		Assert.AreEqual(0, collection.Count);
	}

	/// <summary>
	/// Defines the test method ClearNonEmptyCollectionTest.
	/// </summary>
	[TestMethod]
	public void ClearNonEmptyCollectionTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");
		collection.Add("test2");

		collection.Clear();

		Assert.AreEqual(0, collection.Count);
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
	/// Defines the test method ClearWithBoundedCapacityTest.
	/// </summary>
	[TestMethod]
	public void ClearWithBoundedCapacityTest()
	{
		var collection = new DistinctBlockingCollection<string>(5);
		collection.Add("test1");
		collection.Add("test2");

		collection.Clear();

		Assert.AreEqual(0, collection.Count);
		Assert.AreEqual(5, collection.BoundedCapacity);
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
	/// Defines the test method ConstructorWithBoundedCapacityNegativeTest.
	/// </summary>
	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void ConstructorWithBoundedCapacityNegativeTest()
	{
		var collection = new DistinctBlockingCollection<string>(-1);
	}

	/// <summary>
	/// Defines the test method ConstructorWithBoundedCapacityTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithBoundedCapacityTest()
	{
		var collection = new DistinctBlockingCollection<string>(5);

		Assert.IsNotNull(collection);
		Assert.AreEqual(5, collection.BoundedCapacity);
	}

	/// <summary>
	/// Defines the test method ConstructorWithCollectionTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithCollectionTest()
	{
		var initialCollection = new List<string> { "test1", "test2" };
		var collection = new DistinctBlockingCollection<string>(initialCollection);

		Assert.IsNotNull(collection);
		Assert.AreEqual(2, collection.Count);
		Assert.IsTrue(collection.Contains("test1"));
		Assert.IsTrue(collection.Contains("test2"));
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

	[TestMethod]
	public void IsReadOnlyWhenAddingCompletedTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.CompleteAdding();
		Assert.IsTrue(collection.IsReadOnly);
	}

	[TestMethod]
	public void IsReadOnlyWhenAddingNotCompletedTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		Assert.IsFalse(collection.IsReadOnly);
	}

	/// <summary>
	/// Defines the test method RemoveExistingItemTest.
	/// </summary>
	[TestMethod]
	public void RemoveExistingItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");

		var result = collection.Remove("test1");

		Assert.IsTrue(result);
		Assert.IsFalse(collection.Contains("test1"));
	}

	/// <summary>
	/// Defines the test method RemoveFromEmptyCollectionTest.
	/// </summary>
	[TestMethod]
	public void RemoveFromEmptyCollectionTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		var result = collection.Remove("test1");

		Assert.IsFalse(result);
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

	[TestMethod]
	public void TryAddNullItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd(null);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd("test1");

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
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


	[TestMethod]
	public void TryAddWithMillisecondsTimeoutAndCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationToken = new CancellationToken();
		var result = collection.TryAdd("test1", 1000, cancellationToken);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	[ExpectedException(typeof(OperationCanceledException))]
	public void TryAddWithMillisecondsTimeoutAndCancelledTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();
		collection.TryAdd("test1", 1000, cancellationTokenSource.Token);
	}

	[TestMethod]
	public void TryAddWithMillisecondsTimeoutDuplicateItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");
		var result = collection.TryAdd("test1", 1000);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithMillisecondsTimeoutNullItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd(null, 1000);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithMillisecondsTimeoutTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd("test1", 1000);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	public void TryAddWithTimeoutAndCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationToken = new CancellationToken();
		var result = collection.TryAdd("test1", 1000, cancellationToken);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	[ExpectedException(typeof(OperationCanceledException))]
	public void TryAddWithTimeoutAndCancelledTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();
		collection.TryAdd("test1", 1000, cancellationTokenSource.Token);
	}

	[TestMethod]
	public void TryAddWithTimeoutDuplicateItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");
		var result = collection.TryAdd("test1", 1000);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithTimeoutTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd("test1", 1000);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	public void TryAddWithTimeSpanAndCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationToken = new CancellationToken();
		var result = collection.TryAdd("test1", 1000, cancellationToken);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	[ExpectedException(typeof(OperationCanceledException))]
	public void TryAddWithTimeSpanAndCancelledTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();
		collection.TryAdd("test1", 1000, cancellationTokenSource.Token);
	}

	[TestMethod]
	public void TryAddWithTimeSpanDuplicateItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");
		var result = collection.TryAdd("test1", TimeSpan.FromSeconds(1));

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithTimeSpanNullItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd(null, TimeSpan.FromSeconds(1));

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithTimeSpanTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd("test1", TimeSpan.FromSeconds(1));

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

}
