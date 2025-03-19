// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-19-2025
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>This file contains extension methods for IEnumerable types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a collection of static methods for querying objects that implement <see cref="IEnumerable{T}"/>.
/// These extensions add functionality for adding, checking, and manipulating elements within enumerable collections.
/// </summary>
[Information(Documentation = "https://bit.ly/SpargineEnumerableExtensions", Status = Status.Available)]
public static class EnumerableExtensions
{
	/// <summary>
	/// A pool of <see cref="StringBuilder"/> objects to minimize memory allocations.
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Generates a random number between 0 and <see cref="int.MaxValue"/>.
	/// </summary>
	/// <returns>A random integer value.</returns>
	private static int GenerateRandomNumber() => RandomNumberGenerator.GetInt32(int.MaxValue);

	/// <summary>
	/// Applies an accumulator accumulatorFunction over a sequence. The specified seed value is used as the initial accumulator value, and the specified accumulatorFunction is used to select the result value.
	/// </summary>
	/// <typeparam name="T1">The type of the elements of the source sequence.</typeparam>
	/// <typeparam name="T2">The type of the accumulator value.</typeparam>
	/// <param name="source">An <see cref="IEnumerable{T1}"/> to aggregate over.</param>
	/// <param name="seed">The initial accumulator value.</param>
	/// <param name="accumulatorFunction">An accumulator accumulatorFunction to be invoked on each element.</param>
	/// <returns>An <see cref="IEnumerable{T2}"/> containing the accumulated values.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> or <paramref name="accumulatorFunction"/> is null.</exception>
	private static IEnumerable<T2> ScanIterator<T1, T2>(IEnumerable<T1> source, T2 seed, Func<T2, T1, T2> accumulatorFunction)
	{
		var current = seed;
		yield return current;

		foreach (var item in source)
		{
			current = accumulatorFunction(current, item);
			yield return current;
		}
	}

	/// <summary>
	/// Adds distinct items to the source enumerable collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="source">The source collection to add items to.</param>
	/// <param name="items">The items to add to the collection if they are not already present.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that contains the distinct elements from the original collection and any new items added.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> or <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddDistinct), author: "David McCarter", createdOn: "3/22/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> AddDistinct<T>(this IEnumerable<T> source, [NotNull] params T[] items)
	{
		if (source == null || items == null || items.Length == 0)
		{
			return source ?? [];
		}

		var result = new HashSet<T>(source);

		foreach (var item in items)
		{
			_ = result.Add(item);
		}

		return result;
	}

	/// <summary>
	/// Adds the specified item to the beginning of the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to add the item to.</param>
	/// <param name="item">The item to add to the collection.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that starts with the specified item followed by the original collection items.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddFirst), "David McCarter", "10/24/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> AddFirst<T>(this IEnumerable<T> collection, T item)
	{
		collection = collection.ArgumentNotNull();
		item = item.ArgumentNotNull();

		yield return item;

		foreach (var element in collection)
		{
			yield return element;
		}
	}

	/// <summary>
	/// Adds the specified item to the collection if the condition is true.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to add the item to.</param>
	/// <param name="item">The item to add to the collection.</param>
	/// <param name="condition">The condition that determines if the item should be added.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that includes the original collection and, if the condition is true, the specified item.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddIf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> AddIf<T>(this IEnumerable<T> collection, T item, bool condition)
	{
		if (item is null)
		{
			return collection;
		}

		collection = collection.ArgumentNotNull();

		if (condition)
		{
			collection = collection.AddLast(item);
		}

		return collection;
	}

	/// <summary>
	/// Adds the specified item to the end of the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to add the item to.</param>
	/// <param name="item">The item to add to the collection.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that includes the original collection items followed by the specified item.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddLast), "David McCarter", "10/24/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> AddLast<T>(this IEnumerable<T> collection, T item)
	{
		collection = collection.ArgumentNotNull();
		item = item.ArgumentNotNull();

		foreach (var element in collection)
		{
			yield return element;
		}

		yield return item;
	}

	/// <summary>
	/// Determines whether the collection contains any of the specified items.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to check.</param>
	/// <param name="items">The items to look for in the collection.</param>
	/// <returns><c>true</c> if the collection contains any of the specified items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ContainsAny), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsAny<T>(this IEnumerable<T> collection, params T[] items) => collection is null || items is null ? false : items.DoesNotHaveItems() ? false : collection.FastAny(p => items.Contains(p));

	/// <summary>
	/// Counts the number of elements in the specified collection.
	/// </summary>
	/// <param name="collection">The collection to count the elements of.</param>
	/// <returns>The number of elements in the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Count), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Count(this IEnumerable collection)
	{
		if (collection is null)
		{
			return 0;
		}

		// If the collection is an ICollection or ICollection<T>, use its Count property for efficiency.
		if (collection is ICollection col)
		{
			return col.Count;
		}
		else if (collection is ICollection<object> colT)
		{
			return colT.Count;
		}

		// Fallback to manual counting for other IEnumerable types.
		var count = 0;
		var enumerator = collection.GetEnumerator();

		while (enumerator.MoveNext())
		{
			count++;
		}
		return count;
	}

	/// <summary>
	/// Counts a collection in an asynchronous operation.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A Task&lt;System.Int32&gt; representing the asynchronous operation.</returns>
	/// <remarks>Orginal code from: https://github.com/dncuug/X.PagedList/blob/master/src/X.PagedList/PagedListExtensions.cs</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(CountAsync), "David McCarter", "3/2/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Task<int> CountAsync<T>(this IEnumerable<T> collection, CancellationToken cancellationToken = default)
	{
		collection = collection.ArgumentNotNull();

		return Task.Run(collection.Count, cancellationToken);
	}

	/// <summary>
	/// Creates a new <see cref="Collection{T}"/> from the specified items. Optionally ensures uniqueness of items in the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="items">The items to include in the new collection.</param>
	/// <param name="ensureUnique">If set to <c>true</c>, the new collection will only include unique items.</param>
	/// <returns>A new <see cref="Collection{T}"/> containing the specified items, with duplicates removed if <paramref name="ensureUnique"/> is <c>true</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Collection<T> Create<T>(this IEnumerable<T> items, in bool ensureUnique)
	{
		items = items.ArgumentNotNull();

		//RECOMENDATION FROM COPILOT SLOWER.
		IList<T> list = ensureUnique ? new HashSet<T>(items).ToList() : [.. items];

		return [.. list];
	}

	/// <summary>
	/// Determines whether the specified <see cref="IEnumerable"/> does not have items or is null.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool DoesNotHaveItems(this IEnumerable collection) => collection?.Count() <= 0;

	/// <summary>
	/// Ensures that all elements in the collection are unique based on default equality comparer.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to check for uniqueness.</param>
	/// <returns>An IEnumerable containing only unique elements from the original collection.</returns>
	/// <remarks>
	/// This method uses default equality comparer for the type <typeparamref name="T"/> to determine uniqueness.
	/// If the collection contains duplicate items, only the first occurrence is included in the returned collection.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(EnsureUnique), "David McCarter", "11/8/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> EnsureUnique<T>(this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		//RECOMENDATION FROM COPILOT SLOWER.
		return collection.Distinct();
	}

	/// <summary>
	/// Determines whether any element of a sequence satisfies a condition.
	/// </summary>
	/// <typeparam name="T">The type of the elements of <paramref name="collection"/>.</typeparam>
	/// <param name="collection">The <see cref="IEnumerable{T}"/> to apply the accumulatorFunction to.</param>
	/// <param name="accumulatorPredicate">A accumulatorFunction to test each element for a condition.</param>
	/// <returns>true if any elements in the source sequence pass the test in the specified accumulatorFunction; otherwise, false.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="collection"/> or <paramref name="accumulatorPredicate"/> is null.</exception>
	/// <example>
	/// This example shows how to use <see cref="FastAny{T}"/> to quickly check if any elements in an array satisfy a condition.
	/// <code>
	/// int[] numbers = { 1, 2, 3 };
	/// bool hasEvenNumber = numbers.FastAny(n => n % 2 == 0);
	/// Console.WriteLine(hasEvenNumber); // Output: True
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(FastAny), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool FastAny<T>(this IEnumerable<T> collection, Func<T, bool> accumulatorPredicate)
	{
		collection = collection.ArgumentNotNull();
		accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

		//RECOMENDATION FROM COPILOT SLOWER.
		foreach (var item in collection)
		{
			if (accumulatorPredicate.Invoke(item) is false)
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Counts the number of elements in the specified collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to count the elements of.</param>
	/// <returns>The number of elements in the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(FastCount), "David McCarter", "5/21/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static long FastCount<T>(this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		if (collection is ICollection<T> col)
		{
			return col.Count;
		}
		else if (collection is ICollection colNonGeneric)
		{
			return colNonGeneric.Count;
		}
		else
		{
			var count = 0;
			using (var enumerator = collection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					count++;
				}
			}
			return count;
		}
	}

	/// <summary>
	/// Counts the number of elements in the specified list.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the list.</typeparam>
	/// <param name="collection">The list to count the elements of.</param>
	/// <returns>The number of elements in the list.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(FastCount), "David McCarter", "4/12/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static long FastCount<T>(this IList<T> collection) => collection.ArgumentNotNull().Count;

	/// <summary>
	/// Counts the number of elements in the collection that satisfy a condition.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to count elements from.</param>
	/// <param name="accumulatorPredicate">A accumulatorFunction to test each element for a condition.</param>
	/// <returns>The number of elements in the collection that satisfy the condition in the accumulatorFunction accumulatorFunction.</returns>
	/// <remarks>
	/// This method is optimized for performance and should be used over <see cref="Enumerable.Count{TSource}(IEnumerable{TSource}, Func{TSource, bool})"/>
	/// when working with large collections or performance-critical code.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(FastCount), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static long FastCount<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> accumulatorPredicate) =>
		//COPILOT OPTIMIZATION SLOWER.
		collection.ArgumentNotNull().Count(accumulatorPredicate.ArgumentNotNull());

	/// <summary>
	/// Modifies each item in the given collection using the specified accumulatorFunction and returns a read-only collection of the modified items.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to process.</param>
	/// <param name="action">The accumulatorFunction to apply to each item in the collection.</param>
	/// <returns>A read-only collection of the modified items.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: NotNull]
	[Information(nameof(FastModifyCollection), author: "David McCarter", createdOn: "8/7/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static ReadOnlyCollection<T> FastModifyCollection<T>(this IEnumerable<T> collection, Func<T, T> action)
	{
		collection = collection.ArgumentNotNull();
		action = action.ArgumentNotNull();

		if (collection is List<T> list)
		{
			var span = CollectionsMarshal.AsSpan(list);
			var processedCollection = new ReadOnlyCollectionBuilder<T>(span.Length);
			var itemCount = span.Length;

			for (var index = 0; index < itemCount; index++)
			{
				processedCollection.Add(action(span[index]));
			}

			return processedCollection.ToReadOnlyCollection();
		}
		else
		{
			var span = CollectionsMarshal.AsSpan(collection.ToList());
			var processedCollection = new ReadOnlyCollectionBuilder<T>(span.Length);
			var itemCount = span.Length;

			for (var index = 0; index < itemCount; index++)
			{
				processedCollection.Add(action(span[index]));
			}

			return processedCollection.ToReadOnlyCollection();
		}
	}

	/// <summary>
	/// Processes each item in the given collection using the specified action.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to process.</param>
	/// <param name="action">The action to apply to each item in the collection.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "12/9/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void FastProcessor<T>(this IEnumerable<T> collection, Action<T> action)
	{
		collection = collection.ArgumentNotNull();
		action = action.ArgumentNotNull();

		if (collection is List<T> list)
		{
			var span = list.AsReadOnlySpan();
			var itemCount = span.Length;

			for (var index = 0; index < itemCount; index++)
			{
				action(span[index]);
			}
		}
		else
		{
			var span = CollectionsMarshal.AsSpan(collection.ToList());
			var itemCount = span.Length;

			for (var index = 0; index < itemCount; index++)
			{
				action(span[index]);
			}
		}
	}

	/// <summary>
	/// Returns the first element of the sequence or a default value if the sequence contains no elements.
	/// </summary>
	/// <typeparam name="T">The type of the elements of <paramref name="collection"/>.</typeparam>
	/// <param name="collection">The <see cref="IEnumerable{T}"/> to return the first element of.</param>
	/// <param name="alternate">The default value to return if the sequence is empty.</param>
	/// <returns>The first element in the specified sequence, or <paramref name="alternate"/> if the sequence contains no elements.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="collection"/> or <paramref name="alternate"/> is null.</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: MaybeNull]
	[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static T FirstOrDefault<T>(this IEnumerable<T> collection, T alternate)
	{
		collection = collection.ArgumentNotNull();

		using (var enumerator = collection.GetEnumerator())
		{
			return enumerator.MoveNext() ? enumerator.Current : alternate;
		}
	}

	/// <summary>
	/// Returns the first element in a sequence that satisfies a specified condition or a default value if no such element is found.
	/// </summary>
	/// <typeparam name="T">The type of the elements of <paramref name="list"/>.</typeparam>
	/// <param name="list">An <see cref="IEnumerable{T}"/> to search.</param>
	/// <param name="accumulatorPredicate">A accumulatorFunction to test each element for a condition.</param>
	/// <param name="alternate">The default value to return if no element satisfies the condition.</param>
	/// <returns>The first element in the sequence that passes the test in the specified accumulatorFunction accumulatorFunction or <paramref name="alternate"/> if no such element is found.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="list"/> or <paramref name="accumulatorPredicate"/> is null.</exception>
	/// <example>
	/// This example shows how to use FirstOrDefault{T}" to find the first element greater than 3 or return -1 if no such element exists.
	/// <code>
	/// int[] numbers = { 1, 2, 3, 4, 5 };
	/// int result = numbers.FirstOrDefault(n => n > 3, -1);
	/// Console.WriteLine(result); // Output: 4
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static T FirstOrDefault<T>(this IEnumerable<T> list, Func<T, bool> accumulatorPredicate, T alternate)
	{
		list = list.ArgumentNotNull();
		accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

		foreach (var item in list)
		{
			if (accumulatorPredicate(item))
			{
				return item;
			}
		}

		return alternate;
	}

	/// <summary>
	/// Returns the first element in the collection that matches the specified condition, or null if no such element is found.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to search.</param>
	/// <param name="accumulatorPredicate">The accumulatorFunction to accumulatorPredicate against the elements of the collection.</param>
	/// <returns>The first element that matches the condition defined by <paramref name="accumulatorPredicate"/>, or null if no such element is found.</returns>
	/// <example>
	/// This example shows how to use <see cref="FirstOrNull{T}"/> to find the first element in an array of integers that is greater than 10, or null if no such element exists.
	/// <code>
	/// int[] numbers = { 1, 4, 7, 10, 12, 15 };
	/// int? firstGreaterThanTen = numbers.FirstOrNull(n => n > 10);
	/// Console.WriteLine(firstGreaterThanTen); // Output: 12
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: MaybeNull]
	[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static T? FirstOrNull<T>(this IEnumerable<T> collection, Func<T, bool> accumulatorPredicate) where T : struct
	{
		collection = collection.ArgumentNotNull();
		accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

		foreach (var item in collection)
		{
			if (accumulatorPredicate(item))
			{
				return item;
			}
		}

		return null;
	}

	/// <summary>
	/// Determines whether the specified collection contains any duplicate elements.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="items">The collection to check for duplicates.</param>
	/// <returns><c>true</c> if the collection contains duplicates; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(HasDuplicates), author: "David McCarter", createdOn: "7/3/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static bool HasDuplicates<T>(this IEnumerable<T> items)
	{
		if (items.DoesNotHaveItems())
		{
			return false;
		}

		var seenItems = new HashSet<T>();

		foreach (var item in items)
		{
			if (!seenItems.Add(item)) // Add returns false if the item was already in the set.
			{
				return true; // Duplicate found.
			}
		}

		return false; // No duplicates found.
	}

	/// <summary>
	/// Determines whether the specified collection has any items.
	/// </summary>
	/// <param name="collection">The collection to check.</param>
	/// <returns><c>true</c> if the collection is not null and contains at least one item; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static bool HasItems(this IEnumerable collection) => collection is null ? false : collection.Count() > 0;

	/// <summary>
	/// Determines whether the <see cref="IEnumerable"/> has a specified count.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <param name="count">The specific count.</param>
	/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static bool HasItems(this IEnumerable collection, int count)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.Count() == count;
		}
	}

	/// <summary>
	/// Finds the index of the first occurrence of an item in the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to search.</param>
	/// <param name="item">The item to find in the collection.</param>
	/// <returns>The zero-based index of the first occurrence of item within the entire collection, if found; otherwise, -1.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="item"/> is null.</exception>
	/// <remarks>
	/// This method uses <see cref="EqualityComparer{T}.Default"/> to compare elements.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(IndexOf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int IndexOf<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item)
	{
		_ = collection.ArgumentItemsExists();
		_ = item.ArgumentNotNull();

		var index = 0;
		var comparer = EqualityComparer<T>.Default;

		foreach (var element in collection)
		{
			if (comparer.Equals(element, item))
			{
				return index;
			}

			index++;
		}

		return -1;
	}

	/// <summary>
	/// Finds the index of the first occurrence of an item in the collection that matches the specified accumulatorFunction.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to search.</param>
	/// <param name="accumulatorPredicate">The accumulatorFunction to accumulatorPredicate against the elements of the collection.</param>
	/// <returns>The zero-based index of the first occurrence of an item that matches the accumulatorFunction within the entire collection, if found; otherwise, -1.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="accumulatorPredicate"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information("Original code by Simon Painter.", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int IndexOf<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> accumulatorPredicate)
	{
		collection = collection.ArgumentNotNull();
		accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

		var result = collection.Select((value, index) => (value, index)).FirstOrDefault(value => accumulatorPredicate(value.value));

		return result.Equals(default((T x, int i))) ? -1 : result.index;
	}

	/// <summary>
	/// Finds the index of the first occurrence of an item in the collection using a specified comparer.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to search.</param>
	/// <param name="item">The item to find in the collection.</param>
	/// <param name="comparer">The equality comparer to use for comparing items.</param>
	/// <returns>The zero-based index of the first occurrence of item within the entire collection, if found; otherwise, -1.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/>, <paramref name="item"/>, or <paramref name="comparer"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(IndexOf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int IndexOf<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item, [NotNull] IEqualityComparer<T> comparer)
	{
		collection = collection.ArgumentItemsExists();
		item = item.ArgumentNotNull();
		comparer = comparer.ArgumentNotNull();

		var index = 0;
		foreach (var element in collection)
		{
			if (comparer.Equals(element, item))
			{
				return index;
			}
			index++;
		}

		return -1;
	}

	/// <summary>
	/// Determines whether the specified collection is null or empty.
	/// </summary>
	/// <param name="collection">The collection to check.</param>
	/// <returns><c>true</c> if the collection is null or empty; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses <see cref="IEnumerable.GetEnumerator"/> to determine if the collection is empty.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(IsNullOrEmpty), "David McCarter", "1/7/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsNullOrEmpty([AllowNull] this IEnumerable collection) => collection.IsNull() ||
	collection.GetEnumerator().MoveNext() is false;

	/// <summary>
	/// Concatenates the members of a collection, using the specified separator between each member.
	/// </summary>
	/// <param name="collection">The collection of objects to concatenate.</param>
	/// <param name="separator">The string to use as a separator. <see cref="ControlChars.DefaultSeparator"/> is used if source parameter is not specified.</param>
	/// <returns>A string that consists of the members of <paramref name="collection"/> delimited by the <paramref name="separator"/> string. If <paramref name="collection"/> has no members, the method returns <see cref="string.Empty"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="separator"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Join), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string Join(this IEnumerable<object> collection, string separator = ControlChars.DefaultSeparator)
	{
		collection = collection.ArgumentNotNull();
		separator = separator.ArgumentNotNull();

		//RECOMENDATION FROM COPILOT IS SLOWER
		return collection.CheckItemsExists() is false
			? string.Empty
			: string.Join(separator.ArgumentNotNullOrEmpty(defaultValue: ControlChars.DefaultSeparator), collection);
	}

	/// <summary>
	/// Orders the elements of a collection according to a specified sort expression.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to order.</param>
	/// <param name="sortExpression">The sort expression used for ordering. Must be a valid property name of <typeparamref name="T"/>.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that contains the elements of the input sequence ordered according to the sort expression.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="sortExpression"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="sortExpression"/> is not a valid property name of <typeparamref name="T"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(OrderBy), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> OrderBy<T>([NotNull] this IEnumerable<T> collection, [NotNull] string sortExpression)
	{
		collection = collection.ArgumentNotNull();

		sortExpression += string.Empty;

		var parts = sortExpression.Split(Convert.ToChar(" ", CultureInfo.InvariantCulture));
		var descending = false;
		var property = string.Empty;

		if (parts.LongLength > 0 && !string.IsNullOrEmpty(parts[0]))
		{
			property = parts[0];

			if (parts.LongLength > 1)
			{
				@descending = CultureInfo.InvariantCulture.TextInfo
					.ToLower(parts[1])
					.Contains("esc", StringComparison.OrdinalIgnoreCase);
			}

			var prop = typeof(T).GetRuntimeProperty(property);

			if (prop.CheckIsNotNull(throwException: true))
			{
				return @descending
					? collection.OrderByDescending(x => prop.GetValue(x, null))
					: collection.OrderBy(x => prop.GetValue(x, null));
			}
		}

		return collection;
	}

	/// <summary>
	/// Orders the elements of a collection by a key selected from each element.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to order.</param>
	/// <param name="accumulatorFunction">A accumulatorFunction to extract a key from an element.</param>
	/// <returns>An <see cref="IOrderedEnumerable{T}"/> whose elements are sorted according to a key.</returns>
	/// <returns>IOrderedEnumerable&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IOrderedEnumerable<T> OrderByOrdinal<T>(this IEnumerable<T> collection, Func<T, string> accumulatorFunction)
	{
		collection = collection.ArgumentNotNull();
		accumulatorFunction = accumulatorFunction.ArgumentNotNull();

		return collection.OrderBy(accumulatorFunction, StringComparer.Ordinal);
	}

	/// <summary>
	/// Pages the specified collection into a sequence of pages each containing a maximum of <paramref name="pageSize"/> elements.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to page.</param>
	/// <param name="pageSize">Size of each page.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> where each item is a page of the original collection containing up to <paramref name="pageSize"/> elements.</returns>
	/// <remarks>
	/// This method uses deferred execution to generate pages only when they are enumerated.
	/// <see cref="ArgumentNullException"/> is thrown if <paramref name="collection"/> is null.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Page), "David McCarter", "11/21/2010", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static IEnumerable<IEnumerable<T>> Page<T>(this IEnumerable<T> collection, int pageSize)
	{
		collection = collection.ArgumentNotNull();
		pageSize = pageSize.EnsureMinimum(1);

		using (var enumerator = collection.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				var currentPage = new List<T>(pageSize);

				do
				{
					currentPage.Add(enumerator.Current);
				} while (currentPage.Count < pageSize && enumerator.MoveNext());

				yield return currentPage;
			}
		}
	}

	/// <summary>
	/// Partitions the elements of a collection into chunks of a specified size.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to partition.</param>
	/// <param name="pageCount">The size of each partition.</param>
	/// <returns>An enumerable of enumerable, where each inner enumerable represents a partition of the original collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="pageCount"/> is less than or equal to 0.</exception>
	/// <example>
	/// This example shows how to use the <see cref="Partition{T}"/> method to split a list of integers into smaller chunks of a specified size.
	/// <code>
	/// var numbers = Enumerable.Range(1, 10);
	/// var partitioned = numbers.Partition(3);
	/// foreach (var chunk in partitioned)
	/// {
	///     Console.WriteLine($"Chunk: {string.Join(", ", chunk)}");
	/// }
	/// </code>
	/// Results in the output:
	/// Chunk: 1, 2, 3
	/// Chunk: 4, 5, 6
	/// Chunk: 7, 8, 9
	/// Chunk: 10
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Partition), "David McCarter", "3/2/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<IEnumerable<T>> Partition<T>(this IEnumerable<T> collection, int pageCount)
	{
		collection = collection.ArgumentNotNull();
		pageCount = pageCount.EnsureMinimum(1);

		// Cache source to avoid evaluating it twice
		var count = collection.Count();

		if (count < pageCount)
		{
			yield return collection;
		}
		else
		{
			var pagesCount = Math.Ceiling(count / (double)pageCount);

			for (var pageIndex = 0; pageIndex < pagesCount; pageIndex++)
			{
				yield return [.. collection.Skip(pageCount * pageIndex)];
			}
		}
	}

	/// <summary>
	/// Picks a random element from the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to pick from.</param>
	/// <returns>A randomly picked element from the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if <paramref name="collection"/> is empty.</exception>
	/// <remarks>
	/// This method uses a secure random number generator to ensure a fair selection.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(PickRandom), "David McCarter", "8/26/2020", "9/19/2020", BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
	public static T PickRandom<T>(this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		return collection.HasItems() ? collection.Shuffle(1).FirstOrDefault() : default;
	}

	/// <summary>
	/// Removes duplicate elements from the specified collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="items">The collection from which to remove duplicates.</param>
	/// <returns>A <see cref="SimpleResult{TResult}"/> containing the collection without duplicates.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(RemoveDuplicates), author: "David McCarter", createdOn: "7/3/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static SimpleResult<IEnumerable<T>> RemoveDuplicates<T>(this IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		return new SimpleResult<IEnumerable<T>>(new HashSet<T>(items).AsEnumerable());
	}

	/// <summary>
	/// Removes any null items from the specified collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to remove null items from.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that contains only non-null elements from the original collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(RemoveNulls), "David McCarter", "2/28/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static IEnumerable<T> RemoveNulls<T>(this IEnumerable<T> collection) where T : class
	{
		collection = collection.ArgumentNotNull();

		foreach (var item in collection)
		{
			if (item != null)
			{
				yield return item;
			}
		}
	}

	/// <summary>
	/// Replaces elements in the collection based on a specified condition.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to process.</param>
	/// <param name="accumulatorPredicate">A accumulatorFunction that determines whether an element should be replaced, based on the element and its index.</param>
	/// <param name="replacement">The replacement value for elements that meet the condition.</param>
	/// <returns>A new collection with elements replaced based on the specified condition.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="accumulatorPredicate"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information("Original code by Simon Painter.", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.None, Status = Status.Available)]
	public static IEnumerable<T> ReplaceIf<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, int, bool> accumulatorPredicate, T replacement)
	{
		collection = collection.ArgumentNotNull();
		accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

		return collection.Select((obj, pos) => accumulatorPredicate(obj, pos) ? replacement : obj);
	}

	/// <summary>
	/// Applies an accumulator accumulatorFunction over a sequence. The specified seed value is used as the initial accumulator value, and the specified accumulatorFunction is used to select the result value.
	/// </summary>
	/// <typeparam name="T1">The type of the elements of the source sequence.</typeparam>
	/// <typeparam name="T2">The type of the accumulator value.</typeparam>
	/// <param name="source">An <see cref="IEnumerable{T1}"/> to aggregate over.</param>
	/// <param name="seed">The initial accumulator value.</param>
	/// <param name="accumulatorFunction">An accumulator accumulatorFunction to be invoked on each element.</param>
	/// <returns>An <see cref="IEnumerable{T2}"/> containing the accumulated values.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> or <paramref name="accumulatorFunction"/> is null.</exception>
	[Information("Original code by Simon Painter.", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.None, Status = Status.Available)]
	public static IEnumerable<T2> Scan<T1, T2>([NotNull] this IEnumerable<T1> source, [NotNull] T2 seed, [NotNull] Func<T2, T1, T2> accumulatorFunction)
	{
		source = source.ArgumentNotNull();
		accumulatorFunction = accumulatorFunction.ArgumentNotNull();

		return ScanIterator(source, seed, accumulatorFunction);
	}

	/// <summary>
	/// Shuffles the elements of the specified collection in a random order.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to shuffle.</param>
	/// <returns>A new collection with the elements of <paramref name="collection"/> shuffled.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <remarks>
	/// This method uses a random number generator to reorder the elements of the collection.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "8/26/2020", BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection) => collection.ArgumentItemsExists()
		.OrderBy(_ => GenerateRandomNumber());

	/// <summary>
	/// Shuffles the elements of the specified collection into a new collection with a specified count.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to shuffle.</param>
	/// <param name="count">The number of elements to include in the shuffled collection. If greater than the collection's count, the entire collection is shuffled.</param>
	/// <returns>A new collection containing <paramref name="count"/> shuffled elements from the original <paramref name="collection"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="count"/> is less than 0.</exception>
	/// <remarks>
	/// This method uses a random number generator to reorder the elements of the collection.
	/// The <see cref="GenerateRandomNumber"/> method is used internally to generate random indices.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection, int count)
	{
		collection = collection.ArgumentNotNull();
		count = count.EnsureMinimum(1);

		return collection.Shuffle().Take(count);
	}

	/// <summary>
	/// Splits the specified collection into smaller collections of a specified size.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to split.</param>
	/// <param name="size">The size of each smaller collection.</param>
	/// <returns>An enumerable of collections, each containing up to <paramref name="size"/> elements from the original <paramref name="collection"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="size"/> is less than or equal to 0.</exception>
	/// <remarks>
	/// This method uses deferred execution and will only process elements as they are requested.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Split), "David McCarter", "3/2/2023", BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> collection, int size)
	{
		collection = collection.ArgumentNotNull();
		size = size.EnsureMinimum(1);

		var start = 0;
		var items = collection as T[] ?? [.. collection];

		while (start < items.Length)
		{
			var count = Math.Min(size, items.Length - start);

			yield return new ArraySegment<T>(items, start, count);

			start += count;
		}
	}

	/// <summary>
	/// Determines whether the beginning of the first collection matches the whole second collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collections.</typeparam>
	/// <param name="first">The first collection to compare.</param>
	/// <param name="second">The second collection to compare to the beginning of the first collection.</param>
	/// <returns>true if <paramref name="first"/> starts with elements from <paramref name="second"/>; otherwise, false.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="first"/> or <paramref name="second"/> is null.</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(StartsWith), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool StartsWith<T>(this IEnumerable<T> first, in IEnumerable<T> second)
	{
		if (first is null || second is null)
		{
			return false;
		}

		//RECOMMENDATION FROM COPILOT SLOWER.
		if (ReferenceEquals(first, second))
		{
			return true;
		}

		using (var firstEnumerator = first.GetEnumerator())
		{
			foreach (var item in second)
			{
				if (!firstEnumerator.MoveNext() || !Equals(firstEnumerator.Current, item))
				{
					return false;
				}
			}
		}

		return true;
	}

	/// <summary>
	/// Determines whether two sequences are structurally equal by comparing their elements by using a default <see cref="IEqualityComparer{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the input sequences.</typeparam>
	/// <param name="first">The first sequence to compare.</param>
	/// <param name="second">The second sequence to compare.</param>
	/// <returns>true if the two source sequences are of equal length and their corresponding elements are equal according to the default equality comparer for their type; otherwise, false.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="first"/> or <paramref name="second"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool StructuralSequenceEqual<T>(this IEnumerable<T> first, IEnumerable<T> second)
	{
		if (first is null || second is null)
		{
			return false;
		}

		if (ReferenceEquals(first, second))
		{
			return true;
		}

		//RECOMENDATION FROM COPILOT SLOWER.
		using (var firstEnumerator = first.GetEnumerator())
		{
			using (var secondEnumerator = second.GetEnumerator())
			{
				while (firstEnumerator.MoveNext())
				{
					if (!secondEnumerator.MoveNext() ||
						!StructuralComparisons.StructuralEqualityComparer
							.Equals(firstEnumerator.Current, secondEnumerator.Current))
					{
						return false;
					}
				}

				return !secondEnumerator.MoveNext();
			}
		}
	}

	/// <summary>
	/// Converts the specified <paramref name="collection"/> to a <see cref="BlockingCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="BlockingCollection{T}"/> containing all the elements of <paramref name="collection"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <remarks>The resulting collection supports IDisposable. Make sure to properly dispose!</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static BlockingCollection<T> ToBlockingCollection<T>(this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		//RECOMMENDATION FROM COPILOT IS SLOWER.
		return [.. new ConcurrentQueue<T>(collection)];
	}

	/// <summary>
	/// Converts the specified <paramref name="collection"/> to a <see cref="Collection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="Collection{T}"/> that contains elements from the input <paramref name="collection"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToCollection), "David McCarter", "4/13/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Collection<T> ToCollection<T>(this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return new Collection<T>([.. collection]);
	}

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a delimited string.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <param name="delimiter">The delimiter to use. Default is comma.</param>
	/// <returns>A string that represents the concatenated elements of the collection, separated by the specified delimiter.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToDelimitedString), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static string ToDelimitedString<T>(this IEnumerable<T> collection, [ConstantExpected] char delimiter = ControlChars.Comma)
	{
		if (collection is null || collection.FastCount() == 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			//FrozenSet, ImmutableArray is slower.
			foreach (var item in collection)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Converts the specified enumerable <paramref name="list"/> to a <see cref="FrozenSet{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="list">The enumerable list to convert.</param>
	/// <returns>A <see cref="FrozenSet{T}"/> that contains elements from the input <paramref name="list"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="list"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static FrozenSet<T> ToFrozenSet<T>(this IEnumerable<T> list) => FrozenSet.ToFrozenSet(list);

	/// <summary>
	/// Converts the specified enumerable <paramref name="collection"/> to an <see cref="ImmutableList{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The enumerable collection to convert.</param>
	/// <returns>An <see cref="ImmutableList{T}"/> that contains elements from the input <paramref name="collection"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ImmutableList<T> ToImmutable<T>(this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		return [.. collection];
	}

	/// <summary>
	/// Converts a <see cref="IEnumerable{T}" /> to <see cref="ImmutableArray{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The values.</param>
	/// <returns>System.Collections.Immutable.ImmutableArray&lt;T&gt;.</returns>
	[Information(nameof(ToImmutable), "David McCarter", "6/7/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ImmutableArray<T> ToImmutableArray<T>([NotNull] this IEnumerable<T> collection) => collection.DoesNotHaveItems() ? [] : [.. collection];

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a <see cref="LinkedList{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="LinkedList{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToLinkedList), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		return new LinkedList<T>(collection);
	}

	/// <summary>
	/// Creates a <see cref="List{T}"/> from the <see cref="IEnumerable{T}"/>.
	/// Validates that <paramref name="collection"/> is not null.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="List{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToListAsync), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Task<List<T>> ToListAsync<T>(this IEnumerable<T> collection, CancellationToken cancellationToken = default)
	{
		collection = collection.ArgumentItemsExists();

		return Task.Run(() => collection.ToList(), cancellationToken);
	}

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a <see cref="ReadOnlyCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="ReadOnlyCollection{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> collection) => new(
		[.. collection.ArgumentNotNull()]);

	/// <summary>
	/// Converts a <see cref="ConcurrentBag{T}"/> to a <see cref="ReadOnlyCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="ReadOnlyCollection{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "2/5/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this ConcurrentBag<T> collection) => new(
		[.. collection.ArgumentNotNull()]);

	/// <summary>
	/// Inserts or updates an item in the collection. If the item already exists, it is updated; otherwise, it is added.
	/// Note: This method returns a new <see cref="IEnumerable{T}"/> with the item upserted and does not modify the original collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to perform the upsert operation on.</param>
	/// <param name="item">The item to insert or update in the collection.</param>
	/// <returns>A new <see cref="IEnumerable{T}"/> with the item upserted.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(Upsert), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> Upsert<T>(this IEnumerable<T> collection, T item)
	{
		collection = collection.ArgumentItemsExists();

		var list = collection.ToList();

		if (!list.Contains(item))
		{
			list.Add(item);
		}

		// Assuming 'item' already exists and 'list' contains unique items,
		// an 'else' block here would handle updating the existing item.
		// The specifics of source operation would depend on the requirements.
		return list;
	}
}
