// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-26-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="ChannelQueueTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

[ExcludeFromCodeCoverage]
[TestClass]
public class ChannelQueueTests
{

	private static async Task AddToQueueAsync(ChannelQueue<Person<Address>> channel, List<Person<Address>> people, CancellationToken token)
	{
		foreach (var person in people)
		{
			await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
		}

		_ = channel.Lock();
	}

	private static async Task ListenToQueue(ChannelQueue<Person<Address>> channel, CancellationToken token)
	{
		await foreach (var item in channel.ListenAsync(token))
		{
			Debug.WriteLine(item.Email);
		}
	}

	[TestMethod]
	public void Constructor_Default_IsUnbounded()
	{
		var channel = new ChannelQueue<int>();
		// Adding more items than a typical bounded capacity to test if it's unbounded
		for (int i = 0; i < 10000; i++)
		{
			channel.WriteAsync(i).Wait();
		}
		Assert.IsTrue(channel.Count > 0, "Channel should allow adding many items, indicating it's unbounded.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void Constructor_NegativeCapacity_ThrowsArgumentOutOfRangeException()
	{
		_ = new ChannelQueue<int>(-1);
	}

	[TestMethod]
	public void Constructor_WithCapacity_IsBounded()
	{
		int capacity = 5;
		var channel = new ChannelQueue<int>(capacity);
		for (int i = 0; i < capacity; i++)
		{
			channel.WriteAsync(i).Wait();
		}
		Assert.AreEqual(capacity, channel.Count, $"Channel should not allow adding more than {capacity} items.");
	}

	[TestMethod]
	public async Task Count_AfterAddingItems_CorrectCount()
	{
		var channel = new ChannelQueue<int>();
		await channel.WriteAsync(1);
		await channel.WriteAsync(2);
		Assert.AreEqual(2, channel.Count, "Count should reflect the number of items added.");
	}

	[TestMethod]
	public async Task Count_AfterReadingItems_Decreases()
	{
		var channel = new ChannelQueue<int>();
		await channel.WriteAsync(1);
		await channel.WriteAsync(2);
		_ = await channel.ReadAsync();
		Assert.AreEqual(1, channel.Count, "Count should decrease after reading an item.");
	}

	[TestMethod]
	public void Count_BoundedChannel_SupportsCount()
	{
		var channel = new ChannelQueue<int>(10);
		Assert.IsTrue(channel.Count >= 0, "Count should be supported and non-negative for a bounded channel.");
	}

	[TestMethod]
	public void Count_InitiallyZero()
	{
		var channel = new ChannelQueue<int>();
		Assert.AreEqual(0, channel.Count, "Count should be 0 for a new channel.");
	}

	[TestMethod]
	public void Count_UnboundedChannel_SupportsCount()
	{
		var channel = new ChannelQueue<int>();
		Assert.IsTrue(channel.Count >= 0, "Count should be supported and non-negative for an unbounded channel.");
	}


	[TestMethod]
	public async Task ListenAsync_CompletesWhenChannelLocked()
	{
		var channel = new ChannelQueue<int>();
		var items = Enumerable.Range(1, 3).ToList();

		foreach (var item in items)
		{
			await channel.WriteAsync(item);
		}

		channel.Lock(); // Lock the channel to allow ListenAsync to complete.

		var readItems = new List<int>();
		await foreach (var item in channel.ListenAsync())
		{
			readItems.Add(item);
		}

		Assert.AreEqual(items.Count, readItems.Count, "ListenAsync should complete reading all items once the channel is locked.");
	}

	[TestMethod]
	public async Task ListenAsync_ReadsAllItems()
	{
		var channel = new ChannelQueue<int>();
		var items = Enumerable.Range(1, 5).ToList();

		foreach (var item in items)
		{
			await channel.WriteAsync(item);
		}

		channel.Lock(); // Ensure no more items can be added and ListenAsync can complete.

		var readItems = new List<int>();
		await foreach (var item in channel.ListenAsync())
		{
			readItems.Add(item);
		}

		CollectionAssert.AreEqual(items, readItems, "All items written to the channel should be read by ListenAsync.");
	}

	[TestMethod]
	public void Lock_AfterLockingChannelIsCompleted()
	{
		var channel = new ChannelQueue<int>();
		channel.Lock();

		var readerCompletion = channel.ListenAsync().GetAsyncEnumerator().MoveNextAsync();
		readerCompletion.AsTask().Wait(1000);

		Assert.IsTrue(readerCompletion.IsCompleted, "After locking, the channel should complete and no longer allow reads.");
	}

	[TestMethod]
	public void Lock_LocksChannelPreventingWrites()
	{
		var channel = new ChannelQueue<int>();
		Assert.IsTrue(channel.WriteAsync(1).Wait(1000), "Should be able to write to the channel initially.");

		var lockResult = channel.Lock();
		Assert.IsTrue(lockResult, "Lock should succeed on first call.");

		var writeTask = channel.WriteAsync(2);
		Assert.ThrowsException<AggregateException>(() => writeTask.Wait(1000), "Writing to a locked channel should throw an exception.");
	}

	[TestMethod]
	public void Lock_MultipleCallsReturnFalse()
	{
		var channel = new ChannelQueue<int>();
		Assert.IsTrue(channel.Lock(), "First call to Lock should succeed.");

		for (int i = 0; i < 5; i++)
		{
			Assert.IsFalse(channel.Lock(), $"Subsequent calls to Lock should return false. Failed at iteration {i}.");
		}
	}

	[TestMethod]
	public void Lock_PreventsFurtherAdditions()
	{
		var channel = new ChannelQueue<int>();
		channel.WriteAsync(1).Wait();
		channel.Lock();
		try
		{
			channel.WriteAsync(2).Wait();
		}
		catch (AggregateException ae) when (ae.InnerExceptions.Any(e => e is ChannelClosedException))
		{
			// Expected exception
			return;
		}
		Assert.Fail("Expected a ChannelClosedException to be thrown when writing to a locked channel.");
	}

	[TestMethod]
	public async Task ReadAsync_CancellationRequested_ThrowsOperationCanceledException()
	{
		var channel = new ChannelQueue<int>();
		var cts = new CancellationTokenSource();

		// Simulate a scenario where cancellation is requested before the operation starts
		cts.Cancel();

		await Assert.ThrowsExceptionAsync<TaskCanceledException>(async () => await channel.ReadAsync(cts.Token), "ReadAsync should throw an OperationCanceledException when cancellation is requested.");
	}

	[TestMethod]
	public async Task ReadAsync_EmptyChannel_ThrowsChannelClosedException()
	{
		var channel = new ChannelQueue<int>();
		channel.Lock(); // Ensure the channel is closed for writing and will not receive any items.

		await Assert.ThrowsExceptionAsync<ChannelClosedException>(async () => await channel.ReadAsync(), "Reading from an empty and locked channel should throw a ChannelClosedException.");
	}


	[TestMethod]
	public async Task ReadAsync_WithItems_ReturnsCorrectItem()
	{
		var channel = new ChannelQueue<int>();
		await channel.WriteAsync(42);

		var result = await channel.ReadAsync();
		Assert.AreEqual(42, result, "ReadAsync should return the first item written to the channel.");
	}

	[TestMethod]
	public async Task WriteAsync_AfterLock_ThrowsChannelClosedException()
	{
		var channel = new ChannelQueue<int>();
		channel.Lock(); // Lock the channel to prevent further writes

		await Assert.ThrowsExceptionAsync<ChannelClosedException>(async () => await channel.WriteAsync(42), "WriteAsync should throw a ChannelClosedException when attempting to write to a locked channel.");
	}

	[TestMethod]
	public async Task WriteAsync_CancellationRequested_ThrowsOperationCanceledException()
	{
		var channel = new ChannelQueue<int>();
		var items = Enumerable.Range(1, 5);
		var cts = new CancellationTokenSource();
		cts.Cancel(); // Immediately request cancellation

		await Assert.ThrowsExceptionAsync<TaskCanceledException>(async () => await channel.WriteAsync(items, false, cts.Token), "WriteAsync should throw an OperationCanceledException when cancellation is requested.");
	}

	[TestMethod]
	public async Task WriteAsync_LockQueue_PreventsFurtherWrites()
	{
		var channel = new ChannelQueue<int>();
		var items = Enumerable.Range(1, 5);

		await channel.WriteAsync(items, true);

		await Assert.ThrowsExceptionAsync<ChannelClosedException>(async () => await channel.WriteAsync(6), "WriteAsync should throw a ChannelClosedException when attempting to write to a locked channel.");
	}

}
