// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-01-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-17-2025
// ***********************************************************************
// <copyright file="ConcurrentHashSet.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Represents a thread-safe, hash-based unique collection.</summary>
// ***********************************************************************
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Internal;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// Represents a thread-safe collection of unique elements.
/// </summary>
/// <typeparam name="T">The type of elements in the hash set. See <see cref="ICollection{T}"/>.</typeparam>
/// <remarks>
/// This implementation provides atomic operations for adding, removing, and checking for elements, making it suitable for concurrent scenarios.
/// </remarks>
[DebuggerDisplay("Count = {Count}")]
[Information(Status = Status.Available)]
public sealed class ConcurrentHashSet<T> : IReadOnlyCollection<T>, ICollection<T>
{
	/// <summary>
	/// The default capacity of the <see cref="ConcurrentHashSet{T}"/> when not specified.
	/// </summary>
	private const int DefaultCapacity = 31;

	/// <summary>
	/// The maximum number of locks that can be used for concurrency management in <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	private const int MaxLockNumber = 1024;

	/// <summary>
	/// The budget for resizing. Controls when to resize the <see cref="Tables"/> based on the number of elements and the current capacity.
	/// </summary>
	private int _budget;

	/// <summary>
	/// The <see cref="IEqualityComparer{T}"/> instance that is used to determine equality of keys for the hash set.
	/// </summary>
	private readonly IEqualityComparer<T> _comparer;

	/// <summary>
	/// Indicates whether the array of locks used for concurrency control should dynamically grow with the collection.
	/// </summary>
	/// <remarks>
	/// When <c>true</c>, the internal lock array can grow to improve concurrency at the cost of increased memory usage.
	/// This is beneficial in scenarios where the <see cref="ConcurrentHashSet{T}"/> is expected to store a large number of items.
	/// </remarks>
	private readonly bool _growLockArray;

	/// <summary>
	/// Represents the internal data structure of the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <remarks>
	/// This field holds the tables structure, which includes the buckets and locks used for managing concurrency.
	/// The <see cref="Tables"/> structure is marked as volatile to ensure that updates to its reference are immediately visible to all threads,
	/// providing a mechanism for safe publication.
	/// </remarks>
	private volatile Tables _tables;

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class with the specified concurrency level, initial capacity, option to allow lock array growth, and comparer.
	/// </summary>
	/// <param name="concurrencyLevel">The estimated number of threads that will update the <see cref="ConcurrentHashSet{T}"/> concurrently.</param>
	/// <param name="capacity">The initial number of elements that the <see cref="ConcurrentHashSet{T}"/> can contain.</param>
	/// <param name="growLockArray">Whether the lock array can grow with the collection, improving concurrency at the cost of increased memory usage.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items for equality.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="concurrencyLevel"/> or <paramref name="capacity"/> is less than 1.</exception>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="comparer"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ConcurrentHashSet(int concurrencyLevel, int capacity, bool growLockArray, [NotNull] IEqualityComparer<T> comparer)
	{
		if (concurrencyLevel < 1)
		{
			concurrencyLevel = 1;
		}

		concurrencyLevel = concurrencyLevel.EnsureMinimum(1);
		capacity = capacity.EnsureMinimum(0);

		// The capacity should be at least as large as the concurrency level. Otherwise, we would have locks that don't guard
		// any buckets.
		if (capacity < concurrencyLevel)
		{
			capacity = concurrencyLevel;
		}

		var locks = new object[concurrencyLevel];
		var locksLength = locks.LongLength;

		for (var lockCount = 0; lockCount < locksLength; lockCount++)
		{
			locks[lockCount] = new object();
		}

		var countPerLock = new int[locks.LongLength];
		var buckets = new Node[capacity];

		this._tables = new Tables(buckets, locks, countPerLock);
		this._growLockArray = growLockArray;
		this._budget = buckets.Length / locks.Length;
		this._comparer = comparer ?? EqualityComparer<T>.Default;
	}


	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet()
		: this(DefaultConcurrencyLevel, DefaultCapacity, true, null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class that contains elements copied from the specified collection.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if the <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet([NotNull] IEnumerable<T> collection)
		: this(collection, null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class using the specified comparer for the set.
	/// </summary>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items in the set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="comparer"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet([NotNull] IEqualityComparer<T> comparer)
		: this(concurrencyLevel: DefaultConcurrencyLevel, capacity: DefaultCapacity, growLockArray: true, comparer: comparer)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class with the specified concurrency level and initial capacity.
	/// </summary>
	/// <param name="concurrencyLevel">The estimated number of threads that will update the <see cref="ConcurrentHashSet{T}"/> concurrently.</param>
	/// <param name="capacity">The initial number of elements that the <see cref="ConcurrentHashSet{T}"/> can contain.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="concurrencyLevel"/> or <paramref name="capacity"/> is less than 1.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(int concurrencyLevel, int capacity)
		: this(concurrencyLevel, capacity, false, null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class that contains elements copied from the specified collection and uses the specified comparer for element comparison.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items in the set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="comparer"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet([NotNull] IEnumerable<T> collection, [NotNull] IEqualityComparer<T> comparer)
		: this(comparer) => this.InitializeFromCollection(collection);

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class with the specified concurrency level, collection, and comparer.
	/// </summary>
	/// <param name="concurrencyLevel">The estimated number of threads that will update the <see cref="ConcurrentHashSet{T}"/> concurrently.</param>
	/// <param name="collection">The collection whose elements are copied to the new <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items in the set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="comparer"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(int concurrencyLevel, [NotNull] IEnumerable<T> collection, [NotNull] IEqualityComparer<T> comparer)
		: this(concurrencyLevel, DefaultCapacity, false, comparer) => this.InitializeFromCollection(collection);

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class with the specified concurrency level, capacity, and comparer.
	/// </summary>
	/// <param name="concurrencyLevel">The estimated number of threads that will update the <see cref="ConcurrentHashSet{T}"/> concurrently.</param>
	/// <param name="capacity">The initial number of elements that the <see cref="ConcurrentHashSet{T}"/> can contain.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items in the set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="comparer"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcurrentHashSet<T>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(int concurrencyLevel, int capacity, [NotNull] IEqualityComparer<T> comparer)
		: this(concurrencyLevel, capacity, false, comparer)
	{
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <returns>An <see cref="IEnumerator"/> that can be used to iterate through the collection.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Returns an enumerator that iterates through a collection.
	/// </summary>
	/// <returns>An <see cref="IEnumerator"></see> object that can be used to iterate through the collection.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Acquires all locks for the <see cref="ConcurrentHashSet{T}"/>, used to ensure thread safety during operations that need to access all elements.
	/// </summary>
	/// <param name="locksAcquired">The number of locks successfully acquired.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void AcquireAllLocks(ref int locksAcquired)
	{
		// First, acquire lock 0
		this.AcquireLocks(0, 1, ref locksAcquired);

		// Now that we have lock 0, the _locks array will not change (i.e., grow),
		// and so we can safely read _locks.Length.
		this.AcquireLocks(1, this._tables._locks.Length, ref locksAcquired);

		Debug.Assert(locksAcquired == this._tables._locks.Length);
	}

	/// <summary>
	/// Acquires locks for a range of buckets, used to ensure thread safety during operations that need to access a subset of elements.
	/// </summary>
	/// <param name="fromInclusive">The inclusive start index of the bucket range for which locks are to be acquired.</param>
	/// <param name="toExclusive">The exclusive end index of the bucket range for which locks are to be acquired.</param>
	/// <param name="locksAcquired">The number of locks successfully acquired by this method. This parameter is passed by reference.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
	{
		Debug.Assert(fromInclusive <= toExclusive);
		var locks = this._tables._locks;

		for (var inclusiveCount = fromInclusive; inclusiveCount < toExclusive; inclusiveCount++)
		{
			var lockTaken = false;

			try
			{
				Monitor.Enter(locks[inclusiveCount], ref lockTaken);
			}
			finally
			{
				if (lockTaken)
				{
					locksAcquired++;
				}
			}
		}
	}

	/// <summary>
	/// Attempts to add an item to the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to add. Cannot be null.</param>
	/// <param name="hashCode">The hash code of the item.</param>
	/// <param name="acquireLock">Indicates whether to lock the table during the add operation.</param>
	/// <returns><c>true</c> if the item was added successfully; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool AddInternal([NotNull] T item, int hashCode, bool acquireLock)
	{
		while (true)
		{
			var tables = this._tables;

			GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, tables._buckets.Length, tables._locks.Length);

			var resizeDesired = false;
			var lockTaken = false;

			try
			{
				if (acquireLock)
				{
					Monitor.Enter(tables._locks[lockNo], ref lockTaken);
				}

				// If the table just got resized, we may not be holding the right lock, and must retry.
				// This should be a rare occurrence.
				if (tables != this._tables)
				{
					continue;
				}

				// Try to find this item in the bucket
				Node previous = null;

				for (var current = tables._buckets[bucketNo]; current is not null; current = current._next)
				{
					Debug.Assert((previous is null && current == tables._buckets[bucketNo]) || previous._next == current);
					if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
					{
						return false;
					}

					previous = current;
				}

				// The item was not found in the bucket. Insert the new item.
				Volatile.Write(ref tables._buckets[bucketNo], new Node(item, hashCode, tables._buckets[bucketNo]));
				checked
				{
					tables._countPerLock[lockNo]++;
				}

				// If the number of elements guarded by this lock has exceeded the budget, resize the bucket table.
				// It is also possible that GrowTable will increase the budget but won't resize the bucket table.
				// That happens if the bucket table is found to be poorly utilized due to a bad hash function.
				if (tables._countPerLock[lockNo] > this._budget)
				{
					resizeDesired = true;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(tables._locks[lockNo]);
				}
			}

			// The fact that we got here means that we just performed an insertion. If necessary, we will grow the table.
			//
			// Concurrency notes:
			// - Notice that we are not holding any locks at when calling GrowTable. This is necessary to prevent deadlocks.
			// - As a result, it is possible that GrowTable will be called unnecessarily. But, GrowTable will obtain lock 0
			//   and then verify that the table we passed to it as the argument is still the current table.
			if (resizeDesired)
			{
				this.GrowTable(tables);
			}

			return true;
		}
	}

	/// <summary>
	/// Copies the elements of the <see cref="ConcurrentHashSet{T}"/> to an array, starting at a specified array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from <see cref="ConcurrentHashSet{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is less than 0.</exception>
	/// <exception cref="ArgumentException">Thrown if the number of elements in the source <see cref="ConcurrentHashSet{T}"/> is greater than the available space from <paramref name="index"/> to the end of the destination <paramref name="array"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void CopyToItems([NotNull] T[] array, int index)
	{
		array = array.ArgumentNotNull();
		index = index.ArgumentInRange(0);

		var buckets = this._tables._buckets;

		for (var bucketCount = 0; bucketCount < buckets.LongLength; bucketCount++)
		{
			for (var current = buckets[bucketCount]; current is not null; current = current._next)
			{
				array[index] = current._item;
				index++; // this should never flow, CopyToItems is only called when there's no overflow risk
			}
		}
	}

	/// <summary>
	/// Calculates the bucket index for the specified hash code.
	/// </summary>
	/// <param name="hashCode">The hash code of the item.</param>
	/// <param name="bucketCount">The total number of buckets in the <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <returns>The index of the bucket.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int GetBucket(int hashCode, int bucketCount)
	{
		//SUGGESTION FROM COPILOT BROKE THE CODE
		var bucketNo = (hashCode & 0x7fffffff) % bucketCount;
		Debug.Assert(bucketNo >= 0 && bucketNo < bucketCount);
		return bucketNo;
	}

	/// <summary>
	/// Calculates the bucket and lock numbers for a given hash code.
	/// </summary>
	/// <param name="hashCode">The hash code of the item.</param>
	/// <param name="bucketNo">The calculated bucket number.</param>
	/// <param name="lockNo">The calculated lock number.</param>
	/// <param name="bucketCount">The total number of buckets in the <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <param name="lockCount">The total number of locks in the <see cref="ConcurrentHashSet{T}"/>.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void GetBucketAndLockNo(int hashCode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
	{
		bucketNo = (hashCode & 0x7fffffff) % bucketCount;
		lockNo = bucketNo % lockCount;
	}

	/// <summary>
	/// Grows the table by doubling its size and rehashing all the elements.
	/// </summary>
	/// <param name="tables">The current table to grow.</param>
	/// <exception cref="ArgumentNullException">Thrown when the tables parameter is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void GrowTable([NotNull] Tables tables)
	{
		const int MaxArrayLength = 0X7FEFFFFF;
		var locksAcquired = 0;

		try
		{
			// The thread that first obtains _locks[0] will be the one doing the resize operation
			this.AcquireLocks(fromInclusive: 0, toExclusive: 1, locksAcquired: ref locksAcquired);

			// Make sure nobody resized the table while we were waiting for lock 0:
			if (tables != this._tables)
			{
				// We assume that since the table reference is different, it was already resized (or the budget
				// was adjusted). If we ever decide to do table shrinking, or replace the table for other reasons,
				// we will have to revisit this logic.
				return;
			}

			// Compute the (approx.) total size. Use an Int64 accumulation variable to avoid an overflow.
			long approxCount = 0;

			for (var tableCount = 0; tableCount < tables._countPerLock.LongLength; tableCount++)
			{
				approxCount += tables._countPerLock[tableCount];
			}

			// If the bucket array is too empty, double the budget instead of resizing the table
			if (approxCount < tables._buckets.LongLength / 4)
			{
				this._budget = 2 * this._budget;

				if (this._budget < 0)
				{
					this._budget = int.MaxValue;
				}

				return;
			}

			// Compute the new table size. We find the smallest integer larger than twice the previous table size, and not divisible by
			// 2,3,5 or 7. We can consider a different table-sizing policy in the future.
			var newLength = 0;
			var maximizeTableSize = false;
			try
			{
				checked
				{
					// Double the size of the buckets table and add one, so that we have an odd integer.
					newLength = (tables._buckets.Length * 2) + 1;

					// Now, we only need to check odd integers, and find the first that is not divisible
					// by 3, 5 or 7.
					while (newLength % 3 == 0 || newLength % 5 == 0 || newLength % 7 == 0)
					{
						newLength += 2;
					}

					Debug.Assert(newLength % 2 != 0);

					if (newLength > MaxArrayLength)
					{
						maximizeTableSize = true;
					}
				}
			}
			catch (OverflowException)
			{
				maximizeTableSize = true;
			}

			if (maximizeTableSize)
			{
				newLength = MaxArrayLength;

				// We want to make sure that GrowTable will not be called again, since table is at the maximum size.
				// To achieve that, we set the budget to int.MaxValue.
				//
				// (There is one special case that would allow GrowTable() to be called in the future:
				// calling Clear() on the ConcurrentHashSet will shrink the table and lower the budget.)
				this._budget = int.MaxValue;
			}

			// Now acquire all other locks for the table
			this.AcquireLocks(1, tables._locks.Length, ref locksAcquired);

			var newLocks = tables._locks;

			// Add more locks
			if (this._growLockArray && tables._locks.LongLength < MaxLockNumber)
			{
				newLocks = new object[tables._locks.LongLength * 2];
				Array.Copy(tables._locks, 0, newLocks, 0, tables._locks.Length);

				for (var tableCount = tables._locks.LongLength; tableCount < newLocks.Length; tableCount++)
				{
					newLocks[tableCount] = new object();
				}
			}

			var newBuckets = new Node[newLength];
			var newCountPerLock = new int[newLocks.Length];

			// Copy all data into a new table, creating new nodes for all elements
			for (var bucketCount = 0; bucketCount < tables._buckets.LongLength; bucketCount++)
			{
				var current = tables._buckets[bucketCount];

				while (current is not null)
				{
					var next = current._next;
					GetBucketAndLockNo(current._hashCode, out var newBucketNo, out var newLockNo, newBuckets.Length, newLocks.Length);

					newBuckets[newBucketNo] = new Node(current._item, current._hashCode, newBuckets[newBucketNo]);

					checked
					{
						newCountPerLock[newLockNo]++;
					}

					current = next;
				}
			}

			// Adjust the budget
			this._budget = Math.Max(1, newBuckets.Length / newLocks.Length);

			// Replace tables with the new versions
			this._tables = new Tables(newBuckets, newLocks, newCountPerLock);
		}
		finally
		{
			// Release all locks that we took earlier
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Initializes the ConcurrentHashSet from the provided collection.
	/// </summary>
	/// <param name="collection">The collection to initialize from.</param>
	/// <exception cref="ArgumentNullException">Thrown when the collection is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void InitializeFromCollection([NotNull] IEnumerable<T> collection)
	{
		collection.ArgumentNotNull().ToList().ForEach(item => _ = this.AddInternal(item, this._comparer.GetHashCode(item), false));

		if (this._budget == 0)
		{
			this._budget = this._tables._buckets.Length / this._tables._locks.Length;
		}
	}

	/// <summary>
	/// Releases the locks for a range of buckets.
	/// </summary>
	/// <param name="fromInclusive">The inclusive start index of the bucket range for which locks are to be released.</param>
	/// <param name="toExclusive">The exclusive end index of the bucket range for which locks are to be released.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ReleaseLocks(int fromInclusive, int toExclusive)
	{
		for (var inclusiveCount = fromInclusive; inclusiveCount < toExclusive; inclusiveCount++)
		{
			Monitor.Exit(this._tables._locks[inclusiveCount]);
		}
	}

	/// <summary>
	/// Adds an item to the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to add to the set. The value cannot be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void Add([NotNull] T item)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		_ = this.AddInternal(item, this._comparer.GetHashCode(item), false);
	}

	/// <summary>
	/// Removes all items from the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <remarks>
	/// This method acquires all locks to ensure thread safety during the clear operation.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clear), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void Clear()
	{
		var locksAcquired = 0;

		try
		{
			this.AcquireAllLocks(ref locksAcquired);

			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
			this._tables = newTables;
			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
		}
		finally
		{
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Determines whether the <see cref="ConcurrentHashSet{T}"/> contains a specific value.
	/// </summary>
	/// <param name="item">The object to locate in the <see cref="ConcurrentHashSet{T}"/>. Cannot be null.</param>
	/// <returns><c>true</c> if <paramref name="item"/> is found in the <see cref="ConcurrentHashSet{T}"/>; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[DefaultValue(false)]
	[Information(nameof(Contains), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool Contains([NotNull] T item)
	{
		var hashCode = this._comparer.GetHashCode(item);

		// We must capture the _buckets field in a local variable. It is set to a new table on each table resize.
		var tables = this._tables;

		var bucketNo = GetBucket(hashCode, tables._buckets.Length);

		// We can get away w/out a lock here.
		// The Volatile.Read ensures that the load of the fields of 'n' doesn't move before the load from buckets[i].
		var current = Volatile.Read(ref tables._buckets[bucketNo]);

		while (current is not null)
		{
			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
			{
				return true;
			}

			current = current._next;
		}

		return false;
	}

	/// <summary>
	/// Copies the elements of the <see cref="ConcurrentHashSet{T}"/> to an array, starting at a particular array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from <see cref="ConcurrentHashSet{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="arrayIndex"/> is less than 0.</exception>
	/// <exception cref="ArgumentException">Thrown if the number of elements in the source <see cref="ConcurrentHashSet{T}"/> is greater than the available space from <paramref name="arrayIndex"/> to the end of the destination <paramref name="array"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void CopyTo([NotNull] T[] array, int arrayIndex)
	{
		array = array.ArgumentItemsExists(nameof(array));

		var locksAcquired = 0;

		try
		{
			this.AcquireAllLocks(ref locksAcquired);

			var count = 0;

			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
			{
				count += this._tables._countPerLock[lockCount];
			}

			// "count" itself or "count + arrayIndex" can overflow
			if (array.Length - count < arrayIndex || count < 0)
			{
				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
			}

			this.CopyToItems(array, arrayIndex);
		}
		finally
		{
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <returns>An <see cref="IEnumerator{T}"/> for the <see cref="ConcurrentHashSet{T}"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetEnumerator), author: "David McCarter", createdOn: "7/28/2021", OptimizationStatus = OptimizationStatus.Optimize, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public IEnumerator<T> GetEnumerator()
	{
		var buckets = this._tables._buckets;

		foreach (var bucket in buckets)
		{
			var current = Volatile.Read(in bucket);

			while (current is not null)
			{
				yield return current._item;
				current = current._next;
			}
		}
	}

	/// <summary>
	/// Removes the specified item from the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to remove.</param>
	/// <returns><c>true</c> if the item was successfully removed; otherwise, <c>false</c>. This method also returns <c>false</c> if the item was not found in the original <see cref="ConcurrentHashSet{T}"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool Remove([NotNull] T item) => this.TryRemove(item.ArgumentNotNull());

	/// <summary>
	/// Attempts to remove the specified item from the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to remove.</param>
	/// <returns><c>true</c> if the item was successfully removed; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	/// <remarks>
	/// This method is thread-safe and may be used concurrently with other operations on the <see cref="ConcurrentHashSet{T}"/>.
	/// </remarks>
	[DefaultValue(false)]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryRemove), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryRemove([NotNull] T item)
	{
		item = item.ArgumentNotNull();

		var hashCode = this._comparer.GetHashCode(item);

		while (true)
		{
			var tables = this._tables;

			GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, tables._buckets.Length, tables._locks.Length);

			lock (tables._locks[lockNo])
			{
				// If the table just got resized, we may not be holding the right lock, and must retry.
				// This should be a rare occurrence.
				if (tables != this._tables)
				{
					continue;
				}

				Node previous = null;

				for (var current = tables._buckets[bucketNo]; current is not null; current = current._next)
				{
					Debug.Assert((previous is null && current == tables._buckets[bucketNo]) || previous._next == current);

					if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
					{
						if (previous is null)
						{
							Volatile.Write(ref tables._buckets[bucketNo], current._next);
						}
						else
						{
							previous._next = current._next;
						}

						tables._countPerLock[lockNo]--;
						return true;
					}

					previous = current;
				}
			}

			return false;
		}
	}


	/// <summary>
	/// Gets the number of elements contained in the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <value>The number of elements contained in the <see cref="ConcurrentHashSet{T}"/>.</value>
	[Information(nameof(Count), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int Count
	{
		get
		{
			var count = 0;
			var acquiredLocks = 0;

			try
			{
				this.AcquireAllLocks(ref acquiredLocks);
				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
			}
			finally
			{
				this.ReleaseLocks(0, acquiredLocks);
			}

			return count;
		}
	}

	/// <summary>
	/// Gets the default concurrency level, which is the number of processors on the current machine.
	/// </summary>
	/// <value>The default concurrency level, based on the number of processors.</value>
	public static int DefaultConcurrencyLevel => Environment.ProcessorCount;

	/// <summary>
	/// Gets a value indicating whether the <see cref="ConcurrentHashSet{T}"/> is empty.
	/// </summary>
	/// <value><c>true</c> if the <see cref="ConcurrentHashSet{T}"/> is empty; otherwise, <c>false</c>.</value>
	[DefaultValue(true)]
	[Information(nameof(IsEmpty), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool IsEmpty
	{
		get
		{
			var acquiredLocks = 0;

			try
			{
				this.AcquireAllLocks(ref acquiredLocks);

				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
				{
					if (this._tables._countPerLock[counter] != 0)
					{
						return false;
					}
				}
			}
			finally
			{
				this.ReleaseLocks(0, acquiredLocks);
			}

			return true;
		}
	}

	/// <summary>
	/// Gets a value indicating whether the <see cref="ConcurrentHashSet{T}"/> is read-only.
	/// </summary>
	/// <value>
	/// Always returns <c>false</c>, as <see cref="ConcurrentHashSet{T}"/> is not a read-only collection.
	/// </value>
	public bool IsReadOnly => false;

	/// <summary>
	/// Represents a node in the concurrent hash set.
	/// </summary>
	private sealed class Node
	{

		/// <summary>
		/// The Hash Code...
		/// </summary>
		internal readonly int _hashCode;

		/// <summary>
		/// The item...
		/// </summary>
		internal readonly T _item;

		/// <summary>
		/// The next...
		/// </summary>
		internal volatile Node _next;

		/// <summary>
		/// Initializes a new instance of the <see cref="Node"/> class.
		/// </summary>
		/// <param name="item">The item to store in the node. Cannot be null.</param>
		/// <param name="hashCode">The hash code of the item.</param>
		/// <param name="next">The next node in the chain. Can be null if the node is the last in the chain.</param>
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Node([NotNull] T item, int hashCode, [AllowNull] Node next)
		{
			this._item = item;
			this._hashCode = hashCode;
			this._next = next;
		}

	}

	/// <summary>
	/// Represents the table structure used internally by the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <remarks>
	/// This class holds the buckets, locks, and count per lock used to manage the concurrent hash set.
	/// </remarks>
	private sealed class Tables
	{

		/// <summary>
		/// An array of buckets, each containing a linked list of <see cref="Node"/> instances.
		/// </summary>
		internal readonly Node[] _buckets;

		/// <summary>
		/// An array that keeps track of the count of elements in each corresponding bucket in <see cref="_buckets"/>.
		/// </summary>
		internal volatile int[] _countPerLock;

		/// <summary>
		/// An array of objects used as locks for synchronizing access to buckets.
		/// </summary>
		internal readonly object[] _locks;

		/// <summary>
		/// Initializes a new instance of the <see cref="Tables"/> class.
		/// </summary>
		/// <param name="buckets">The array of buckets to store the elements of the <see cref="ConcurrentHashSet{T}"/>.</param>
		/// <param name="locks">The array of objects used as locks for synchronizing access to buckets.</param>
		/// <param name="countPerLock">The array that keeps track of the count of elements in each corresponding bucket.</param>
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Tables(Node[] buckets, object[] locks, int[] countPerLock)
		{
			this._buckets = buckets.ArgumentNotNull();
			this._locks = locks.ArgumentNotNull();
			this._countPerLock = countPerLock.ArgumentNotNull();
		}

	}

}
