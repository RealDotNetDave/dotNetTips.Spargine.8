// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-09-2025
// ***********************************************************************
// <copyright file="DistinctBlockingCollection.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// A custom thread-safe collection type designed for multi-threading
// tasks, ensuring uniqueness for all items in the collection.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// Represents a thread-safe collection that does not allow duplicate items.
/// </summary>
/// <typeparam name="T">The type of elements contained in the collection.</typeparam>
/// <remarks>
/// This collection extends <see cref="BlockingCollection{T}"/> to ensure that all operations are thread-safe.
/// It also implements <see cref="ICloneable{T}"/> and <see cref="ICollection{T}"/>, providing additional functionality
/// while ensuring that duplicate items are not added to the collection.
/// This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
/// to remove from memory.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineDistinctBlockingCollection")]
public sealed class DistinctBlockingCollection<T> : BlockingCollection<T>, ICloneable<T>, ICollection<T>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctBlockingCollection{T}" /> class.
	/// </summary>
	public DistinctBlockingCollection()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctBlockingCollection{T}" /> class.
	/// </summary>
	/// <param name="boundedCapacity">The bounded size of the collection.</param>
	public DistinctBlockingCollection(int boundedCapacity) : base(boundedCapacity)
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctBlockingCollection{T}" /> class.
	/// </summary>
	/// <param name="collection">The collection.</param>
	public DistinctBlockingCollection([NotNull] in IEnumerable<T> collection)
	{
		if (collection?.Count() > 0)
		{
			foreach (var _ in collection.Where(p => p is not null).Where(item => this.TryAdd(item) is false).Select(_ => new { }))
			{
				ExceptionThrower.ThrowArgumentInvalidException(Resources.ThereWasAnIssueAddingAnItemInTheCollection, nameof(collection));
			}
		}
	}

	/// <summary>
	/// Clones this instance of <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <returns>A shallow copy of the current <see cref="DistinctBlockingCollection{T}"/>.</returns>
	/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
	/// to remove from memory.</remarks>
	T ICloneable<T>.Clone() => (T)this.MemberwiseClone();

	/// <summary>
	/// Determines whether the specified item is not already in the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <param name="item">The item to check.</param>
	/// <returns><c>true</c> if the item is null or not contained in the <see cref="DistinctBlockingCollection{T}"/>; otherwise, <c>false</c>.</returns>
	private bool IsNotInCollection([NotNullWhen(false)] in T item) => this.Contains(item) is false;

	/// <summary>
	/// Adds the specified item to the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the operation to complete.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the item already exists in the collection.</exception>
	public new void Add([NotNull] T item, CancellationToken cancellationToken = default)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		if (this.IsNotInCollection(item))
		{
			base.Add(item, cancellationToken);
		}
	}

	/// <summary>
	/// Removes all items from the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	public void Clear()
	{
		while (this.TryTake(out _))
		{
			// Intentionally left blank to continuously try and take items until the collection is empty.
		}
	}

	/// <summary>
	/// Determines whether the <see cref="DistinctBlockingCollection{T}"/> contains a specific value.
	/// </summary>
	/// <param name="item">
	/// The object to locate in the <see cref="DistinctBlockingCollection{T}"/>. The value cannot be null.
	/// </param>
	/// <returns>
	/// <see langword="true"/> if <paramref name="item"/> is found in the <see cref="DistinctBlockingCollection{T}"/>; otherwise, <see langword="false"/>.
	/// </returns>
	/// <remarks>
	/// This method performs an equality comparison using <see cref="EqualityComparer{T}.Default"/> to determine if the specified item exists in the collection.
	/// If <paramref name="item"/> is <c>null</c>, the method returns <c>false</c>.
	/// </remarks>
	public bool Contains([NotNull] T item)
	{
		//SUGGESTION FROM COPILOT BREAKS THIS METHOD
		if (item is null)
		{
			return false;
		}

		foreach (var element in this)
		{
			if (EqualityComparer<T>.Default.Equals(element, item))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Removes a specific object from the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <param name="item">The object to remove from the <see cref="DistinctBlockingCollection{T}"/>. The value cannot be null.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> was successfully removed from the <see cref="DistinctBlockingCollection{T}"/>; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original collection.</returns>
	public bool Remove([NotNull] T item) => this.TryTake(out _);

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> could be added; otherwise, <see langword="false" />. If the item is a duplicate, and the underlying collection does not accept duplicate items, then <see langword="false" /> is returned.</returns>
	public new bool TryAdd(T item)
	{
		if (item is null || this.IsNotInCollection(item) == false)
		{
			return false;
		}

		return base.TryAdd(item);
	}

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />
	/// within the specified time period.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="Timeout.Infinite"/> (-1) to wait indefinitely.</param>
	/// <returns><see langword="true" /> if the <paramref name="item" /> could be added to the collection within the specified time; otherwise, <see langword="false" />. If the item is a duplicate, and the underlying collection does not accept duplicate items, then <see langword="false" /> is returned.</returns>
	public new bool TryAdd([AllowNull] T item, [ConstantExpected(Min = 1, Max = int.MaxValue)] int millisecondsTimeout)
	{
		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout);
	}

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <param name="timeout">A <see cref="TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
	/// <returns><see langword="true" /> if the <paramref name="item" /> could be added to the collection within the specified time span; otherwise, <see langword="false" />. If the item is a duplicate, and the underlying collection does not accept duplicate items, then <see langword="false" /> is returned.</returns>
	public new bool TryAdd(T item, TimeSpan timeout)
	{
		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, timeout);
	}

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />
	/// within the specified time period, while observing a cancellation token.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="Timeout.Infinite" /> (-1) to wait
	/// indefinitely.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the operation to complete.</param>
	/// <returns>true if the <paramref name="item" /> could be added to the collection within the specified time; otherwise,
	/// false. If the item is a duplicate, and the underlying collection does not accept duplicate items, then false is returned.</returns>
	public new bool TryAdd(T item, [ConstantExpected(Min = 1, Max = int.MaxValue)] int millisecondsTimeout, CancellationToken cancellationToken = default)
	{
		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout, cancellationToken);
	}

	/// <summary>
	/// Gets a value indicating whether the collection is read-only.
	/// </summary>
	/// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>. This property returns <c>true</c> if <see cref="BlockingCollection{T}.IsAddingCompleted"/> is <c>true</c>, indicating that no more items can be added to the collection.</value>
	public bool IsReadOnly => this.IsAddingCompleted;

}
