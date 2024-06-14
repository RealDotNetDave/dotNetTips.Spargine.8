// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-13-2024
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="dotNetTips.Spargine.8.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for IEnumerable types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;
//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a collection of static methods for querying objects that implement <see cref="IEnumerable{T}"/>.
/// These extensions add functionality for adding, checking, and manipulating elements within enumerable collections.
/// </summary>

public static class EnumerableExtensions
{

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Gets the random.
	/// </summary>
	/// <returns>System.Int32.</returns>
	/// <value>The random.</value>
	private static int GenerateRandomNumber() => RandomNumberGenerator.GetInt32(int.MaxValue);

	/// <summary>
	/// Adds distinct items to the source enumerable collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="source">The source collection to add items to.</param>
	/// <param name="items">The items to add to the collection if they are not already present.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that contains the distinct elements from the original collection and any new items added.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> or <paramref name="items"/> is null.</exception>
	[Information(nameof(AddDistinct), author: "David McCarter", createdOn: "3/22/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.CheckPerformance)]
	public static IEnumerable<T> AddDistinct<T>([NotNull] this IEnumerable<T> source, [NotNull] params T[] items)
	{
		source ??= [];

		if (items is null || !items.HasItems())
		{
			return source;
		}

		var result = source.ToList();

		foreach (var itemItem in items.AsSpan())
		{
			if (!result.Contains(itemItem))
			{
				result.Add(itemItem);
			}
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
	[Information(nameof(AddFirst), "David McCarter", "10/24/2023", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static IEnumerable<T> AddFirst<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item)
	{
		if (item is null)
		{
			return collection;
		}

		return collection.ArgumentNotNull().Prepend(item);
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
	[Information(nameof(AddIf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IEnumerable<T> AddIf<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item, bool condition)
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
	[Information(nameof(AddLast), "David McCarter", "10/24/2023", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static IEnumerable<T> AddLast<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item)
	{
		if (item is null)
		{
			return collection;
		}

		return collection.ArgumentNotNull().Append(item);
	}

	/// <summary>
	/// Determines whether the collection contains any of the specified items.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to check.</param>
	/// <param name="items">The items to look for in the collection.</param>
	/// <returns><c>true</c> if the collection contains any of the specified items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="items"/> is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static bool ContainsAny<T>([NotNull] this IEnumerable<T> collection, [NotNull] params T[] items)
	{
		if (collection is null || items is null)
		{
			return false;
		}

		if (items.DoesNotHaveItems())
		{
			return false;
		}

		return collection.FastAny(p => items.Contains(p));
	}

	/// <summary>
	/// Counts the number of elements in the specified collection.
	/// </summary>
	/// <param name="collection">The collection to count the elements of.</param>
	/// <returns>The number of elements in the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(Count), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static int Count([NotNull] this IEnumerable collection)
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
	[Information(nameof(CountAsync), "David McCarter", "3/2/2023", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static async Task<int> CountAsync<T>([NotNull] this IEnumerable<T> collection, [AllowNull] CancellationToken cancellationToken) => await Task.Run(collection.ArgumentNotNull().Count, cancellationToken).ConfigureAwait(false);

	/// <summary>
	/// Creates a new <see cref="Collection{T}"/> from the specified items. Optionally ensures uniqueness of items in the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="items">The items to include in the new collection.</param>
	/// <param name="ensureUnique">If set to <c>true</c>, the new collection will only include unique items.</param>
	/// <returns>A new <see cref="Collection{T}"/> containing the specified items, with duplicates removed if <paramref name="ensureUnique"/> is <c>true</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.CheckPerformance, Documentation = "https://bit.ly/SpargineMay2024")]
	public static Collection<T> Create<T>([NotNull] this IEnumerable<T> items, bool ensureUnique)
	{
		items = items.ArgumentNotNull();

		//TODO: TRY CHANING TO FROZENSET
		IList<T> list = ensureUnique ? new HashSet<T>(items).ToList() : new List<T>(items);

		return new Collection<T>(list);

	}

	/// <summary>
	/// Determines whether the specified <see cref="IEnumerable" /> does not have items or is null.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems([NotNull] this IEnumerable collection) => collection?.Count() <= 0;

	/// <summary>
	/// Ensures the items in the processedCollection are unique.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The processedCollection.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	[Information(nameof(EnsureUnique), "David McCarter", "11/8/2022", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IEnumerable<T> EnsureUnique<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		return collection.Distinct();
	}

	/// <summary>
	/// Determines if any items exist in the <see cref="IEnumerable" />.
	/// Validates that <paramref name="collection" /> and <paramref name="predicate" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="predicate">The predicate.</param>
	/// <returns>System.Boolean.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
	/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastAny), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static bool FastAny<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> predicate)
	{
		collection = collection.ArgumentNotNull();
		predicate = predicate.ArgumentNotNull();

		//FrozenSet is slower.
		foreach (var item in collection)
		{
			if (predicate.Invoke(item) is false)
			{
				return false;

			}
		}

		return true;
	}

	/// <summary>
	/// Counts items in the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>System.Int64.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastCount), "David McCarter", "5/21/2022", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static long FastCount<T>([NotNull] this IEnumerable<T> collection) => collection.ArgumentNotNull().Count();

	/// <summary>
	/// Counts items in the <see cref="IList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>long.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastCount), "David McCarter", "4/12/2022", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
	public static long FastCount<T>([NotNull] this IList<T> collection) => collection.ArgumentNotNull().Count;

	/// <summary>
	/// Counts items in the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="predicate" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="predicate">The predicate.</param>
	/// <returns>System.Int64.</returns>
	/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastCount), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static long FastCount<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> predicate) => collection.ArgumentNotNull().Count(predicate.ArgumentNotNull());

	/// <summary>
	/// Processes the collection with the specified action.
	/// Validates that <paramref name="collection" /> and <paramref name="action" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="action">The action.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "12/9/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static void FastProcessor<T>([NotNull] this IEnumerable<T> collection, [NotNull] Action<T> action)
	{
		collection = collection.ArgumentNotNull();
		action = action.ArgumentNotNull();

		var processedCollection = collection.ToFrozenSet();

		foreach (var item in processedCollection)
		{
			action(item);
		}
	}

	/// <summary>
	/// Returns first item in the <see cref="IEnumerable{T}" /> or an alternate.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="alternate">The alternate.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">Alternate cannot be null.</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T FirstOrDefault<T>([NotNull] this IEnumerable<T> collection, [NotNull] T alternate) => collection is null ? alternate.ArgumentNotNull() : collection.DefaultIfEmpty(alternate).First();

	/// <summary>
	/// Returns first item in the <see cref="IEnumerable{T}" /> or an alternate using a predicate.
	/// Validates that <paramref name="alternate" /> and <paramref name="predicate" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="list">The source.</param>
	/// <param name="predicate">The predicate.</param>
	/// <param name="alternate">The alternate.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
	/// <exception cref="ArgumentNullException">Alternate cannot be null.</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T FirstOrDefault<T>([NotNull] this IEnumerable<T> list, [NotNull] Func<T, bool> predicate, [NotNull] T alternate)
	{
		alternate = alternate.ArgumentNotNull();

		if (list is null)
		{
			return alternate;
		}

		predicate = predicate.ArgumentNotNull();

		var filteredList = list.Where(predicate).AsEnumerable();

		return filteredList.HasItems() ? filteredList.FirstOrDefault(alternate) : alternate;
	}

	/// <summary>
	/// Returns the first element of a sequence that satisfies a specified condition or a default null value if no such element is found.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The <see cref="IEnumerable{T}"/> to search.</param>
	/// <param name="match">The predicate function to apply to each element.</param>
	/// <returns>The first element that satisfies the condition defined by <paramref name="match"/>, or default null if no such element is found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="match"/> is null.</exception>
	[DefaultValue(null)]
	[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.CheckPerformance, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T? FirstOrNull<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> match)
		where T : struct
	{
		collection = collection.ArgumentNotNull();
		match = match.ArgumentNotNull();

		var result = collection.FirstOrDefault(match);
		return result.Equals(default(T)) ? null : result;
	}

	/// <summary>
	/// Determines whether the specified collection contains any duplicate elements.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="items">The collection to check for duplicates.</param>
	/// <returns><c>true</c> if the collection contains duplicates; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[Information("Orginal code by Milan Jovanović", author: "David McCarter", createdOn: "7/3/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.CheckPerformance, Documentation = "https://bit.ly/SpargineAug23")]
	public static bool HasDuplicates<T>([NotNull] this IEnumerable<T> items)
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
	/// Determines whether the specified <see cref="IEnumerable" /> has items or is null.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems([NotNull] this IEnumerable collection)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.Count() > 0;
		}
	}

	/// <summary>
	/// Determines whether the <see cref="IEnumerable" /> has a specified count.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <param name="count">The specific count.</param>
	/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems([NotNull] this IEnumerable collection, int count)
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
	/// Returns index of item in the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="item">The item.</param>
	/// <returns>System.Int32.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static int IndexOf<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item) => IndexOf(collection.ArgumentItemsExists(), item.ArgumentNotNull(), EqualityComparer<T>.Default);

	/// <summary>
	/// Returns index of an item in the processedCollection using comparer.
	/// Validates that <paramref name="collection" />, <paramref name="item" /> and <paramref name="comparer" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="item">The item.</param>
	/// <param name="comparer">The comparer.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentNullException">item or comparer</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static int IndexOf<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item, [NotNull] IEqualityComparer<T> comparer)
	{
		collection = collection.ArgumentItemsExists();
		item = item.ArgumentNotNull();
		comparer = comparer.ArgumentNotNull();

		return collection.Select((x, index) => comparer.Equals(item, x) ? index : -1).FirstOrDefault(x => x != -1, -1);
	}

	/// <summary>
	/// Determines whether <see cref="IEnumerable" /> is null or empty.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if [is null or empty] [the specified source]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsNullOrEmpty), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool IsNullOrEmpty([AllowNull] this IEnumerable collection) => collection.IsNull() || collection.GetEnumerator().MoveNext() is false;

	/// <summary>
	/// Joins a processedCollection using the specified separator.
	/// Validates that <paramref name="collection" /> contains items.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <param name="separator">The separator.</param>
	/// <returns>System.String.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(Join), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static string Join([NotNull] this IEnumerable<object> collection, [NotNull] string separator = ControlChars.DefaultSeparator)
	{
		if (collection.CheckItemsExists() is false)
		{
			return string.Empty;
		}

		return string.Join(separator.ArgumentNotNullOrEmpty(defaultValue: ControlChars.DefaultSeparator), collection);
	}

	/// <summary>
	/// Orders a <see cref="IEnumerable{T}" /> based on a sort expression. Useful in object binding scenarios where the ObjectDataSource
	/// generates a dynamic sort expression (example: "Name desc") that specifies the property of the object sort
	/// on.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="sortExpression">The sort expression.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <exception cref="InvalidCastException"></exception>
	/// <remarks>Original code by: C.F.Meijers</remarks>
	[Information(nameof(OrderBy), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
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
				@descending = CultureInfo.InvariantCulture.TextInfo.ToLower(parts[1]).Contains("esc", StringComparison.OrdinalIgnoreCase);
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
	/// Orders <see cref="IEnumerable{T}" /> by <see cref="StringComparer.Ordinal" />
	/// Validates that <paramref name="collection" /> and <paramref name="keySelector" /> is not null.
	/// </summary>
	/// <typeparam name="T">The type of the t source.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="keySelector">The key selector.</param>
	/// <returns>IOrderedEnumerable&lt;T&gt;.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IOrderedEnumerable<T> OrderByOrdinal<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, string> keySelector) => collection.ArgumentNotNull().OrderBy(keySelector.ArgumentNotNull(), StringComparer.Ordinal);

	/// <summary>
	/// Partitions the specified collection into smaller collections of a given size.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to partition.</param>
	/// <param name="pageSize">The size of each partition.</param>
	/// <returns>An enumerable of collections, where each collection contains no more than <paramref name="pageSize"/> elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="pageSize"/> is less than or equal to 0.</exception>
	[Information(nameof(Page), "David McCarter", "11/21/2010", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.CheckPerformance, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IEnumerable<IEnumerable<T>> Page<T>([NotNull] this IEnumerable<T> collection, int pageSize)
	{
		collection = collection.ArgumentNotNull();
		pageSize = pageSize.EnsureMinimum(1);

		using var enumerator = collection.GetEnumerator();
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

	/// <summary>
	/// Partitions the specified collection into smaller collections of a specified size.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to partition.</param>
	/// <param name="pageCount">The size of each partition.</param>
	/// <returns>An enumerable of collections, where each collection contains no more than <paramref name="pageCount"/> elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="pageCount"/> is less than or equal to 0.</exception>
	/// <remarks>Original code from: https://github.com/dncuug/X.PagedList/blob/master/src/X.PagedList/PagedListExtensions.cs</remarks>
	[Information(nameof(Partition), "David McCarter", "3/2/2023", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static IEnumerable<IEnumerable<T>> Partition<T>([NotNull] this IEnumerable<T> collection, int pageCount)
	{
		collection = collection.ArgumentNotNull();
		pageCount = pageCount.EnsureMinimum(1);

		// Cache this to avoid evaluating it twice
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
				yield return collection.Skip(pageCount * pageIndex).Take(pageCount);
			}
		}
	}

	/// <summary>
	/// Picks a random element from the specified collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection from which to pick a random element.</param>
	/// <returns>A randomly selected element from the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if <paramref name="collection"/> is empty.</exception>
	[Information(nameof(PickRandom), "David McCarter", "8/26/2020", "9/19/2020", BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T PickRandom<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		if (collection.HasItems())
		{
			return collection.Shuffle(1).FirstOrDefault();
		}
		else
		{
			return default;
		}

	}

	/// <summary>
	/// Removes the duplicates from a collection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="items">The items.</param>
	/// <returns>SimpleResult&lt;IEnumerable&lt;T&gt;&gt;.</returns>
	[Information(nameof(RemoveDuplicates), author: "David McCarter", createdOn: "7/3/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug23")]
	public static SimpleResult<IEnumerable<T>> RemoveDuplicates<T>([NotNull] this IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		try
		{
			var uniqueItems = ImmutableHashSet.CreateBuilder<T>();

			//FrozenSet is slower.
			foreach (var item in items)
			{
				_ = uniqueItems.Add(item);
			}

			return SimpleResult.FromValue(uniqueItems.AsEnumerable());
		}
		catch (Exception ex)
		{
			return SimpleResult.FromException<IEnumerable<T>>(ex);
		}
	}

	/// <summary>
	/// Shuffles the specified <see cref="List{T}" />.
	/// Validates that <paramref name="collection" /> contains items.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The items.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">list</exception>
	[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "8/26/2020", BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineSep2020")]
	public static IEnumerable<T> Shuffle<T>([NotNull] this IEnumerable<T> collection) => collection.ArgumentItemsExists().OrderBy(_ => GenerateRandomNumber());

	/// <summary>
	/// Shuffles items in a <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The items.</param>
	/// <param name="count">The count.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Count must be greater than 0</exception>
	[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineSep2020")]
	public static IEnumerable<T> Shuffle<T>([NotNull] this IEnumerable<T> collection, int count)
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
	/// <returns>An enumerable of collections, where each collection contains no more than <paramref name="size"/> elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="size"/> is less than or equal to 0.</exception>
	/// <remarks>Original code from: https://github.com/dncuug/X.PagedList/blob/master/src/X.PagedList/PagedListExtensions.cs</remarks>
	[Information(nameof(Split), "David McCarter", "3/2/2023", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.CheckPerformance, Documentation = "https://bit.ly/SpargineApril2022")]
	public static IEnumerable<IEnumerable<T>> Split<T>([NotNull] this IEnumerable<T> collection, int size)
	{
		collection = collection.ArgumentNotNull();
		size = size.EnsureMinimum(1);

		var bucket = new List<T>(size);

		foreach (var item in collection)
		{
			bucket.Add(item);
			if (bucket.Count == size)
			{
				yield return bucket;
				bucket = new List<T>(size);
			}
		}

		if (bucket.Count > 0)
		{
			yield return bucket;
		}
	}

	/// <summary>
	/// Determines whether the beginning of the first sequence matches the second sequence.
	/// </summary>
	/// <typeparam name="T">The type of elements in the sequences.</typeparam>
	/// <param name="first">The first sequence to compare.</param>
	/// <param name="second">The sequence to compare to the beginning of the first sequence.</param>
	/// <returns>true if the first sequence starts with the second sequence; otherwise, false.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="first"/> or <paramref name="second"/> is null.</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(StartsWith), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.CheckPerformance, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool StartsWith<T>([NotNull] this IEnumerable<T> first, [NotNull] IEnumerable<T> second)
	{
		if (first is null || second is null)
		{
			return false;
		}

		using (var firstEnumerator = first.GetEnumerator())
		using (var secondEnumerator = second.GetEnumerator())
		{
			while (secondEnumerator.MoveNext())
			{
				if (!firstEnumerator.MoveNext() || !EqualityComparer<T>.Default.Equals(firstEnumerator.Current, secondEnumerator.Current))
				{
					return false;
				}
			}
		}

		return true;
	}

	/// <summary>
	/// Determines whether the beginning of the first sequence structurally equals the second sequence.
	/// </summary>
	/// <typeparam name="T">The type of elements in the sequences.</typeparam>
	/// <param name="first">The first sequence to compare.</param>
	/// <param name="second">The sequence to compare against the first sequence.</param>
	/// <returns>true if the first sequence structurally equals the second sequence; otherwise, false.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="first"/> or <paramref name="second"/> is null.</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.CheckPerformance, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool StructuralSequenceEqual<T>([NotNull] this IEnumerable<T> first, [NotNull] IEnumerable<T> second)
	{
		if (first is null || second is null)
		{
			return false;
		}

		var comparer = StructuralComparisons.StructuralEqualityComparer;

		using (var enumerator1 = first.GetEnumerator())
		using (var enumerator2 = second.GetEnumerator())
		{
			while (enumerator1.MoveNext())
			{
				if (!(enumerator2.MoveNext() && comparer.Equals(enumerator1.Current, enumerator2.Current)))
				{
					return false;
				}
			}

			if (enumerator2.MoveNext())
			{
				return false; // Second sequence has more elements
			}
		}

		return true;
	}

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a <see cref="BlockingCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="BlockingCollection{T}"/> containing all the elements of the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <remarks>The resulting collection supports IDisposable. Make sure to properly dispose!</remarks>
	[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.CheckPerformance, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static BlockingCollection<T> ToBlockingCollection<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		return new BlockingCollection<T>(new ConcurrentQueue<T>(collection));
	}

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a <see cref="Collection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="Collection{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(ToCollection), "David McCarter", "4/13/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static Collection<T> ToCollection<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return new Collection<T>(collection.ToList());
	}

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a delimited string.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <param name="delimiter">The delimiter to use. Default is comma.</param>
	/// <returns>A string that represents the concatenated elements of the collection, separated by the specified delimiter.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(ToDelimitedString), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb21")]
	public static string ToDelimitedString<T>([NotNull] this IEnumerable<T> collection, char delimiter = ControlChars.Comma)
	{
		if (collection is null || collection.FastCount() == 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			//FrozenSet is slower.
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
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a <see cref="FrozenSet{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="list">The collection to convert.</param>
	/// <returns>A <see cref="FrozenSet{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="list"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.New, Documentation = "ADD URL")]
	public static FrozenSet<T> ToFrozenSet<T>([NotNull] this IEnumerable<T> list) => FrozenSet.ToFrozenSet(list);

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to an <see cref="ImmutableList{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>An <see cref="ImmutableList{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static ImmutableList<T> ToImmutable<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return ImmutableList.CreateRange(collection);
	}

	///// <summary>
	///// Converts a <see cref="IEnumerable{T}" /> to <see cref="ImmutableArray{T}" />.
	///// Validates that <paramref name="collection" /> is not null.
	///// </summary>
	///// <typeparam name="T">Generic type parameter.</typeparam>
	///// <param name="collection">The values.</param>
	///// <returns>System.Collections.Immutable.ImmutableArray&lt;T&gt;.</returns>
	//[Information(nameof(ToImmutable), "David McCarter", "6/7/2024", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.New, Documentation = "ADD URL")]
	//public static ImmutableArray<T> ToImmutableArray<T>([NotNull] this IEnumerable<T> collection)
	//{
	//	if (collection.DoesNotHaveItems())
	//	{
	//		return [];
	//	}

	//	return ImmutableArray.CreateRange(collection);
	//}

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a <see cref="LinkedList{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="LinkedList{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(ToLinkedList), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static LinkedList<T> ToLinkedList<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return new LinkedList<T>(collection);
	}

	/// <summary>
	/// Creates a <see cref="List{T}" /> from the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(ToListAsync), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static async Task<List<T>> ToListAsync<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return await Task.Run(() => collection.ToList(), CancellationToken.None).ConfigureAwait(false);
	}

	/// <summary>
	/// Converts an <see cref="IEnumerable{T}"/> to a <see cref="ReadOnlyCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="ReadOnlyCollection{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available)]
	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>([NotNull] this IEnumerable<T> collection) => new(collection.ArgumentNotNull().ToList());

	/// <summary>
	/// Converts a <see cref="ConcurrentBag{T}"/> to a <see cref="ReadOnlyCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to convert.</param>
	/// <returns>A <see cref="ReadOnlyCollection{T}"/> that contains elements from the input collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "2/5/2024", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>([NotNull] this ConcurrentBag<T> collection) => new(collection.ArgumentNotNull().ToList());

	/// <summary>
	/// Inserts or updates an item in the collection. If the item already exists, it is updated; otherwise, it is added.
	/// Note: This method returns a new <see cref="IEnumerable{T}"/> with the item upserted and does not modify the original collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to perform the upsert operation on.</param>
	/// <param name="item">The item to insert or update in the collection.</param>
	/// <returns>A new <see cref="IEnumerable{T}"/> with the item upserted.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(Upsert), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IEnumerable<T> Upsert<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item)
	{
		collection = collection.ArgumentItemsExists();

		if (item is null)
		{
			return collection;
		}

		var items = collection.ToList();

		if (items.Contains(item))
		{
			_ = items.Remove(item);
			items.Add(item);
		}
		else
		{
			items.Add(item);
		}

		return items;
	}

}
