// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-10-2025
// ***********************************************************************
// <copyright file="CachedEnumerable.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Custom collection type for enhanced performance during iteration.
// Original code by: Gérald Barré
// https:www.meziantou.net/caching-an-ienumerable-t-instance.htm
// </summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a mechanism for caching the results of enumerating an <see cref="IEnumerable{T}"/>.
/// This can significantly improve performance when iterating over the same enumerable multiple times.
/// </summary>
/// <remarks>
/// This static class offers a method to create a cached version of any <see cref="IEnumerable{T}"/>.
/// The cached enumerable stores the results of enumeration, allowing for repeated iterations over the data
/// without re-enumerating the underlying sequence. This approach is particularly useful for expensive enumerations
/// that do not change between iterations.
/// </remarks>
[Information(nameof(CachedEnumerable), OptimizationStatus = OptimizationStatus.Completed, Status = Status.NeedsDocumentation)]
public static class CachedEnumerable
{
	/// <summary>
	/// Creates a cached version of the specified enumerable.
	/// </summary>
	/// <typeparam name="T">The type of elements in the enumerable.</typeparam>
	/// <param name="enumerable">The enumerable to cache.</param>
	/// <returns>A <see cref="CachedEnumerable{T}"/> that caches the results of enumerating the specified enumerable.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="enumerable"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static CachedEnumerable<T> Create<T>([NotNull] IEnumerable<T> enumerable)
	{
		enumerable = enumerable.ArgumentNotNull();

		return new(enumerable);
	}
}

/// <summary>
/// Represents a cached enumerable that caches the results of enumerating an <see cref="IEnumerable{T}"/>.
/// This class provides improved performance by storing the results of enumeration, allowing for repeated iterations over the data without re-enumerating the underlying sequence.
/// </summary>
/// <typeparam name="T">The type of elements in the enumerable.</typeparam>
/// <param name="enumerable">The enumerable sequence to cache.</param>
/// <remarks>
/// This type implements <see cref="IDisposable"/>. Make sure to call Dispose or use the 'using' statement to release resources when done.
/// </remarks>
[Information(nameof(CachedEnumerable<T>), Status = Status.Available)]
public sealed class CachedEnumerable<T>(IEnumerable<T> enumerable) : IEnumerable<T>, IDisposable
{
	/// <summary>
	/// The cache used to store enumerated elements.
	/// </summary>
	private readonly List<T> _cache = [];

	/// <summary>
	/// Indicates whether the <see cref="CachedEnumerable{T}"/> has been disposed.
	/// </summary>
	private bool _disposed;

	/// <summary>
	/// Indicates whether the entire enumerable has been enumerated and cached.
	/// </summary>
	private bool _enumerated;

	/// <summary>
	/// The enumerator used to iterate through the enumerable.
	/// </summary>
	private IEnumerator<T> _enumerator;

	/// <summary>
	/// Finalizes an instance of the <see cref="CachedEnumerable{T}"/> class.
	/// </summary>
	~CachedEnumerable() => this.Dispose(false);

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	[Information(nameof(IEnumerable.GetEnumerator), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Validates that the enumerable has been initialized and is not null.
	/// </summary>
	/// <exception cref="InvalidOperationException">Thrown if the enumerable is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void CheckEnumerable()
	{
		if (this._disposed)
		{
			throw new ObjectDisposedException("The cached enumerable has been disposed.");
		}
		else
		{
			_ = this._enumerable.CheckIsNotNull(true);
		}
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing">If set to <c>true</c>, releases both managed and unmanaged resources; if <c>false</c>, releases only unmanaged resources.</param>
	private void Dispose(bool disposing)
	{
		if (!this._disposed)
		{
			if (disposing && this._enumerator is not null)
			{
				this.Reset();
			}

			this._disposed = true;
		}
	}

	/// <summary>
	/// Attempts to retrieve an item at the specified index from the cache. If the item is not in the cache,
	/// it will try to enumerate the underlying enumerable to get the item.
	/// </summary>
	/// <param name="index">The zero-based index of the item to retrieve.</param>
	/// <param name="result">When this method returns, contains the item at the specified index, if the item is found;
	/// otherwise, the default value for the type of the item parameter. This parameter is passed uninitialized.</param>
	/// <returns><c>true</c> if the item at the specified index is successfully retrieved; otherwise, <c>false</c>.</returns>
	[Information(nameof(TryGetItem), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	private bool TryGetItem(in int index, out T result)
	{
		this.CheckEnumerable();

		// if the item is in the cache, use it
		if (index < this._cache.FastCount())
		{
			result = this._cache[index];
			return true;
		}

		lock (this._cache)
		{
			if (this._enumerator is null && !this._enumerated)
			{
				this._enumerator = this._enumerable.GetEnumerator();
			}

			// Another thread may have get the item while we were acquiring the lock
			if (index < this._cache.FastCount())
			{
				result = this._cache[index];
				return true;
			}

			// If we have already enumerate the whole stream, there is nothing else to do
			if (this._enumerated)
			{
				result = default;
				return false;
			}

			// Get the next item and store it to the cache
			if (this._enumerator.MoveNext())
			{
				result = this._enumerator.Current;
				this._cache.Add(result);
				return true;
			}
			else
			{
				// There are no more items, we can dispose the underlying enumerator
				this._enumerated = true;
				this._enumerator.Dispose();
				this._enumerator = null;

				result = default;
				return false;
			}
		}
	}

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	[Preserve("Part of IDisposable", "4/16/2023", "David McCarter")]
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		this.Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	[Information(nameof(IEnumerable<T>.GetEnumerator), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public IEnumerator<T> GetEnumerator()
	{
		this.CheckEnumerable();

		for (var index = 0; this.TryGetItem(index, out var result); index++)
		{
			yield return result;
		}
	}

	/// <summary>
	/// Resets the cache and re-enumerates the underlying enumerable.
	/// </summary>
	[Information(nameof(Reset), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public void Reset()
	{
		lock (this._cache)
		{
			this._cache.Clear();
			this._enumerated = false;
			this._enumerator?.Dispose();
			this._enumerator = null;
		}
	}

	/// <summary>
	/// Gets the count of cached items.
	/// </summary>
	[Information(nameof(Count), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int Count => this._cache.Count;

	/// <summary>
	/// The underlying enumerable sequence that is being cached.
	/// </summary>
	private IEnumerable<T> _enumerable = enumerable;
}
