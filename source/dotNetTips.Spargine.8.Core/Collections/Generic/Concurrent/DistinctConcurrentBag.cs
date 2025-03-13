// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="DistinctConcurrentBag.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Inherits from ConcurrentBag<T> and ensures that all items in the bag
// are unique.
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
/// <seealso cref="ConcurrentBag{T}" />
/// <seealso cref="ICollection{T}" />
[Information(Status = Status.NeedsDocumentation)]
public sealed class DistinctConcurrentBag<T> : ConcurrentBag<T>, ICollection<T>
{

	/// <summary>
	/// The hash codes of the items contained in the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	private readonly HashSet<int> _hashCodes = [];

	/// <summary>
	/// The synchronization lock used to ensure thread safety when modifying the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	private readonly object _lock = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}" /> class.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public DistinctConcurrentBag()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}" /> class.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the <see cref="DistinctConcurrentBag{T}" />.</param>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public DistinctConcurrentBag([NotNull] in IEnumerable<T> collection) => collection?.ToList().ForEach(this.Add);

	/// <summary>
	/// Adds an object to the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="item">The object to be added to the bag. The value cannot be a null reference for reference types.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public new void Add([NotNull] T item)
	{
		item = item.ArgumentNotNull();

		var hashCode = item.GetHashCode();

		lock (this._lock)
		{
			if (this._hashCodes.Contains(hashCode) is false)
			{
				base.Add(item);
				_ = this._hashCodes.Add(hashCode);
			}
		}
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

		var hashCode = item.GetHashCode();

		lock (this._lock)
		{
			return this._hashCodes.Contains(hashCode);
		}
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

		var hashCode = item.GetHashCode();

		lock (this._lock)
		{
			if (this._hashCodes.Contains(hashCode))
			{
				var items = this.ToList();
				if (items.Remove(item))
				{
					this.Clear();
					foreach (var i in items)
					{
						base.Add(i);
					}
					_ = this._hashCodes.Remove(hashCode);
					return true;
				}
			}
		}

		return false;
	}

	/// <summary>
	/// Attempts to remove and return an object from the <see cref="DistinctConcurrentBag{T}" />.
	/// </summary>
	/// <param name="result">When this method returns, <paramref name="result"/> contains the object removed from the <see cref="DistinctConcurrentBag{T}" /> or the default value of <typeparamref name="T"/> if the bag is empty.</param>
	/// <returns><see langword="true"/> if an object was removed successfully; otherwise, <see langword="false"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public new bool TryTake([NotNullWhen(true)] out T result)
	{
		lock (this._lock)
		{
			if (base.TryTake(out result))
			{
				_ = this._hashCodes.Remove(result.GetHashCode());
				return true;
			}
			else
			{
				result = default;
				return false;
			}
		}
	}

	/// <summary>
	/// Gets a value indicating whether the <see cref="DistinctConcurrentBag{T}"/> is read-only.
	/// </summary>
	/// <value>Always <c>false</c> because the <see cref="DistinctConcurrentBag{T}"/> allows adding and removing items.</value>
	[Information(Status = Status.Available)]
	public bool IsReadOnly => false;

}
