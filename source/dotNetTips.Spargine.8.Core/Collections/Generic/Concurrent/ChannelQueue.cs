// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-12-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2025
// ***********************************************************************
// <copyright file="ChannelQueue.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// QueueManager class featuring the ListenAsync method for common queuing
// of items.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// Thread-Safe queue using <see cref="Channel{T}"/>.
/// </summary>
/// <typeparam name="T">The type of items stored in the queue.</typeparam>
[Information("Queue using Channel<T>.", "David McCarter", "7/26/2021", Status = Status.NeedsDocumentation)]
public sealed class ChannelQueue<T>
{

	/// <summary>
	/// The timeout duration for the cancellation token.
	/// </summary>
	private readonly TimeSpan _cancellationTimeout;

	/// <summary>
	/// The channel used for storing items.
	/// </summary>
	private readonly Channel<T> _channel;

	/// <summary>
	/// The object used for thread synchronization.
	/// </summary>
	private readonly object _lock = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class with an unbounded capacity.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ChannelQueue<T>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue()
	{
		this._channel = Channel.CreateUnbounded<T>();
		this._cancellationTimeout = TimeSpan.FromMinutes(5);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class with an unbounded capacity.
	/// </summary>
	/// <param name="cancellationTimeout">The timeout for the cancellation token.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ChannelQueue<T>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue(TimeSpan? cancellationTimeout = null)
	{
		this._channel = Channel.CreateUnbounded<T>();
		this._cancellationTimeout = cancellationTimeout ?? TimeSpan.FromMinutes(5);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class with a specified capacity.
	/// </summary>
	/// <param name="capacity">The capacity of the <see cref="Channel{T}"/>.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ChannelQueue<T>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue(int capacity)
	{
		this._channel = Channel.CreateBounded<T>(capacity);
		this._cancellationTimeout = TimeSpan.FromMinutes(5);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class with a specified capacity.
	/// </summary>
	/// <param name="capacity">The capacity of the <see cref="Channel{T}"/>.</param>
	/// <param name="cancellationTimeout">The timeout for the cancellation token.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ChannelQueue<T>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue(int capacity, TimeSpan? cancellationTimeout = null)
	{
		this._channel = Channel.CreateBounded<T>(capacity);
		this._cancellationTimeout = cancellationTimeout ?? TimeSpan.FromMinutes(5);
	}

	/// <summary>
	/// Reads all items from the Channel as an asynchronous operation.
	/// Call <see cref="Lock"/> to complete this method.
	/// </summary>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>An IAsyncEnumerable of type <typeparamref name="T"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ListenAsync), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async IAsyncEnumerable<T> ListenAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
	{
		// Ensure the cancellation token is linked with any existing tokens with a reasonable timeout to allow for graceful shutdowns
		using (var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
		{
			linkedCts.CancelAfter(this._cancellationTimeout);

			await foreach (var item in this._channel.Reader.ReadAllAsync(linkedCts.Token).ConfigureAwait(false))
			{
				yield return item;
			}
		}
	}

	/// <summary>
	/// Locks the Channel so more items cannot be added. This is not reversible.
	/// </summary>
	/// <returns><c>true</c> if the <see cref="ChannelWriter{T}"/> successfully marked the channel as complete; <c>false</c> otherwise.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Lock), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool Lock()
	{
		lock (this._lock)
		{
			return this._channel.Writer.TryComplete();
		}
	}

	/// <summary>
	/// Reads an item from the Channel as an asynchronous operation.
	/// </summary>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A task that represents the asynchronous read operation. The task result contains the read item of type <typeparamref name="T"/>.</returns>
	/// <exception cref="OperationCanceledException">Thrown when the operation is canceled.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ReadAsync), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async Task<T> ReadAsync(CancellationToken cancellationToken = default)
	{
		try
		{
			return await this._channel.Reader.ReadAsync(cancellationToken).ConfigureAwait(false);
		}
		catch (OperationCanceledException)
		{
			throw;
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(Resources.AnErrorOccurredWhileReadingFromTheChannel, ex);
		}
	}

	/// <summary>
	/// Writes an item to the Channel as an asynchronous operation.
	/// </summary>
	/// <param name="item">The item to write.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation. See <see cref="CancellationToken"/>.</param>
	/// <returns>A Task representing the asynchronous operation. See <see cref="Task"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(WriteAsync), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async Task WriteAsync([NotNull] T item, CancellationToken cancellationToken = default)
	{
		item = item.ArgumentNotNull();

		try
		{
			await this._channel.Writer.WriteAsync(item, cancellationToken).ConfigureAwait(false);
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(Resources.AnErrorOccurredWhileWritingToTheChannel, ex);
		}
	}

	// ...

	/// <summary>
	/// Write a collection to the Channel as an asynchronous operation.
	/// </summary>
	/// <param name="items">The items to write to the <see cref="Channel{T}"/>.</param>
	/// <param name="lockQueue">If set to <c>true</c>, locks the queue after writing the items, preventing any more items from being added.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation. See <see cref="CancellationToken"/>.</param>
	/// <returns>A Task representing the asynchronous operation. See <see cref="Task"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="items"/> is null.</exception>
	/// <remarks>
	/// This method allows for multiple items to be written to the channel at once. If <paramref name="lockQueue"/> is true,
	/// the queue will be locked after the items are written, which is useful for batch processing scenarios.
	/// Make sure to call .Dispose on Task
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(WriteAsync), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async Task WriteAsync([NotNull] IEnumerable<T> items, bool lockQueue = false, CancellationToken cancellationToken = default)
	{
		items = items.ArgumentNotNull();

		try
		{
			foreach (var item in items)
			{
				await this._channel.Writer.WriteAsync(item, cancellationToken).ConfigureAwait(false);
			}

			if (lockQueue)
			{
				_ = this.Lock();
			}
		}
		catch (Exception ex)
		{
			// Log or handle the exception as needed
			throw new InvalidOperationException(Resources.AnErrorOccurredWhileWritingToTheChannel, ex);
		}
	}

	/// <summary>
	/// Gets the count of items currently in the channel.
	/// </summary>
	/// <value>The count of items. Returns -1 if the channel does not support counting.</value>
	/// <remarks>
	/// Use this property to get the number of items that are currently queued in the <see cref="Channel{T}"/>.
	/// This property acquires a lock to ensure thread safety when accessing the count.
	/// </remarks>
	[Information(nameof(Count), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public int Count
	{
		get
		{
			lock (this._lock)
			{
				return this._channel.Reader.CanCount ? this._channel.Reader.Count : -1;
			}
		}
	}

}
