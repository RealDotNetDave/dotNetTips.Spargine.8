// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-18-2025
// ***********************************************************************
// <copyright file="DistinctConcurrentBag.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// Provides a thread-safe, unordered collection of unique elements.
// Internally wraps a ConcurrentBag<T> for storage and a ConcurrentHashSet<T> for uniqueness.
// Ensures that duplicate elements are never added, and supports atomic add, remove, and enumeration operations.
// Implements ICollection<T> and supports concurrent scenarios.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// Represents a thread-safe, unordered collection of objects that does not allow duplicate elements.
/// </summary>
/// <typeparam name="T">The type of the elements in the bag.</typeparam>
/// <remarks>
/// This collection wraps a <see cref="ConcurrentBag{T}"/>, ensuring that all elements are unique.
/// </remarks>
/// <seealso cref="ICollection{T}" />
[Information(Status = Status.NeedsDocumentation, Documentation = "ADD URL")]
public sealed class DistinctConcurrentBag<T> : ICollection<T>
{

	/// <summary>
	/// The underlying thread-safe bag storing the items.
	/// </summary>
	private readonly ConcurrentBag<T> _bag = new();

	/// <summary>
	/// The set of unique items contained in the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	private readonly ConcurrentHashSet<T> _uniqueItems = new();


	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}"/> class.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public DistinctConcurrentBag()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}"/> class that contains elements copied from the specified collection.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new <see cref="DistinctConcurrentBag{T}"/>.</param>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public DistinctConcurrentBag([NotNull] in IEnumerable<T> collection)
	{
		foreach (var item in collection)
		{
			this.Add(item);
		}
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	/// <summary>
	/// Adds an object to the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="item">The object to be added to the bag. The value cannot be a null reference for reference types.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public void Add([NotNull] T item)
	{
		if (item is null)
		{
			throw new ArgumentNullException(nameof(item));
		}

		if (this._uniqueItems.AddIfNotExists(item))
		{
			this._bag.Add(item);
		}
	}

	/// <summary>
	/// Removes all items from the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void Clear()
	{
		while (this._bag.TryTake(out _))
		{ }

		this._uniqueItems.Clear();
	}

	/// <summary>
	/// Determines whether the <see cref="DistinctConcurrentBag{T}"/> contains a specific value.
	/// </summary>
	/// <param name="item">The object to locate in the <see cref="DistinctConcurrentBag{T}"/>.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> is found in the <see cref="DistinctConcurrentBag{T}"/>; otherwise, <see langword="false" />.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public bool Contains([NotNullWhen(true)] T item)
	{
		if (item is null)
		{
			return false;
		}

		return this._uniqueItems.Contains(item);
	}

	/// <summary>
	/// Copies the elements of the <see cref="DistinctConcurrentBag{T}"/> to an array, starting at a particular array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from <see cref="DistinctConcurrentBag{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void CopyTo(T[] array, int arrayIndex)
	{
		this._uniqueItems.CopyTo(array, arrayIndex);
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <returns>An <see cref="IEnumerator{T}"/> for the <see cref="DistinctConcurrentBag{T}"/>.</returns>

	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public IEnumerator<T> GetEnumerator()
	{
		return this._uniqueItems.GetEnumerator();
	}

	/// <summary>
	/// Removes the first occurrence of a specific object from the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="item">The object to remove from the <see cref="DistinctConcurrentBag{T}"/>.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> was successfully removed from the <see cref="DistinctConcurrentBag{T}"/>; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public bool Remove([NotNull] T item)
	{
		item = item.ArgumentNotNull();

		if (this._uniqueItems.Remove(item))
		{
			// Remove from bag: reconstruct bag without the item
			var newItems = new List<T>(this._uniqueItems.Count);

			var removed = false;

			while (this._bag.TryTake(out var current))
			{
				if (!removed && EqualityComparer<T>.Default.Equals(current, item))
				{
					removed = true;
					continue;
				}

				newItems.Add(current);
			}

			foreach (var newItem in newItems)
			{
				this._bag.Add(newItem);
			}

			return true;
		}

		return false;
	}

	/// <summary>
	/// Tries the add.
	/// </summary>
	/// <param name="item">The item.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">item</exception>
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public bool TryAdd([NotNull] T item)
	{
		if (item is null)
		{
			throw new ArgumentNullException(nameof(item));
		}

		if (this._uniqueItems.AddIfNotExists(item))
		{
			this._bag.Add(item);

			return true;
		}
		return false;
	}

	/// <summary>
	/// Attempts to remove and return an object from the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="result">When this method returns, <paramref name="result"/> contains the object removed from the <see cref="DistinctConcurrentBag{T}"/> or the default value of <typeparamref name="T"/> if the bag is empty.</param>
	/// <returns><see langword="true"/> if an object was removed successfully; otherwise, <see langword="false"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public bool TryTake([NotNullWhen(true)] out T result)
	{
		if (this._bag.TryTake(out result))
		{
			return this._uniqueItems.Remove(result);
		}

		result = default;

		return false;
	}

	/// <summary>
	/// Gets the number of elements contained in the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public int Count
	{
		get
		{
			return this._uniqueItems.Count;
		}
	}

	/// <summary>
	/// Gets a value indicating whether the <see cref="DistinctConcurrentBag{T}"/> is read-only.
	/// </summary>
	/// <value>Always <c>false</c> because the <see cref="DistinctConcurrentBag{T}"/> allows adding and removing items.</value>
	[Information(Status = Status.Available)]
	public bool IsReadOnly => false;

}
