// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-15-2024
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="dotNetTips.Spargine.8.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for IEnumerable types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
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
/// Class EnumerableExtensions.
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
	/// Adds items to a list if they do not exist.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="source">The source.</param>
	/// <param name="items">The items.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	[Information(nameof(AddDistinct), author: "David McCarter", createdOn: "3/22/2023", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Updated)]
	public static IEnumerable<T> AddDistinct<T>([NotNull] this IEnumerable<T> source, [NotNull] params T[] items)
	{
		source ??= [];

		if (items is null || !items.HasItems())
		{
			return source;
		}

		var result = source.ToList();

		for (var index = 0; index < items.LongLength; index++)
		{
			var item = items[index];
			if (!result.Contains(item))
			{
				result.Add(item);
			}
		}

		return result;
	}

	/// <summary>
	/// Adds the specified item to the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(AddFirst), "David McCarter", "10/24/2023", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static IEnumerable<T> AddFirst<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item)
	{
		if (item is null)
		{
			return collection;
		}

		return collection.ArgumentNotNull().Prepend(item);
	}

	/// <summary>
	/// Adds item to the <see cref="IEnumerable{T}" /> if the condition is met.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <param name="condition">if set to <c>true</c> [condition].</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	[Information(nameof(AddIf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
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
	/// Adds the specified item to the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(AddLast), "David McCarter", "10/24/2023", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static IEnumerable<T> AddLast<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item)
	{
		if (item is null)
		{
			return collection;
		}

		return collection.ArgumentNotNull().Append(item);
	}

	/// <summary>
	/// Determines whether the specified  <see cref="IEnumerable{T}" /> has items specified.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="items">The items.</param>
	/// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">List is null or empty.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
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
	/// Counts items in a <see cref="IEnumerable" />.
	/// </summary>
	/// <param name="collection">The list.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentNullException">list</exception>
	[Information(nameof(Count), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static int Count([NotNull] this IEnumerable collection)
	{
		if (collection is null)
		{
			return 0;
		}

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
	[Information(nameof(CountAsync), "David McCarter", "3/2/2023", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static async Task<int> CountAsync<T>([NotNull] this IEnumerable<T> collection, [AllowNull] CancellationToken cancellationToken) => await Task.Run(collection.ArgumentNotNull().Count, cancellationToken).ConfigureAwait(false);

	/// <summary>
	/// Creates the specified <see cref="Collection{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="items">The items.</param>
	/// <param name="ensureUnique">if set to <c>true</c> [ensure unique].</param>
	/// <returns>Collection&lt;T&gt;.</returns>
	[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Updated)]
	public static Collection<T> Create<T>([NotNull] this IEnumerable<T> items, bool ensureUnique)
	{
		items = items.ArgumentNotNull();

		var newItems = new Collection<T>();

		foreach (var item in items.Where(p => p is not null))
		{
			if (ensureUnique is true)
			{
				_ = newItems.AddIfNotExists(item);
			}
			else
			{
				newItems.Add(item);
			}
		}

		return newItems;
	}

	/// <summary>
	/// Determines whether the specified <see cref="IEnumerable" /> does not have items or is null.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems([NotNull] this IEnumerable collection) => collection?.Count() <= 0;

	/// <summary>
	/// Ensures the items in the processedCollection are unique.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The processedCollection.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	[Information(nameof(EnsureUnique), "David McCarter", "11/8/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
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
	[Information(nameof(FastAny), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Updated, Documentation = "ADD URL")]
	public static bool FastAny<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> predicate)
	{
		//return collection.ArgumentNotNull().Any(predicate.ArgumentNotNull());

		collection = collection.ArgumentNotNull();
		predicate = predicate.ArgumentNotNull();

		foreach (var item in collection)
		{
			if (predicate.Invoke(item) == false)
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
	[Information(nameof(FastCount), "David McCarter", "5/21/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static long FastCount<T>([NotNull] this IEnumerable<T> collection) => collection.ArgumentNotNull().Count();

	/// <summary>
	/// Counts items in the <see cref="IList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>long.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastCount), "David McCarter", "4/12/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.New)]
	public static long FastCount<T>([NotNull] this IList<T> collection) => collection.ArgumentNotNull().Count;

	/// <summary>
	/// Counts items in the <see cref="IQueryable{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>long.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastCount), "David McCarter", "4/12/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.New)]
	public static long FastCount<T>([NotNull] this IQueryable<T> collection)
	{
		if (collection.ArgumentNotNull().TryGetNonEnumeratedCount(out var count))
		{
			return count;
		}
		else
		{
			return 0;
		}
	}

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
	[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "12/9/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static void FastProcessor<T>([NotNull] this IEnumerable<T> collection, [NotNull] Action<T> action)
	{
		collection = collection.ArgumentNotNull();
		action = action.ArgumentNotNull();

		var processedCollection = collection.ToList().AsSpan();

		for (var itemCount = 0; itemCount < processedCollection.Length; itemCount++)
		{
			action(processedCollection[itemCount]);
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
	[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
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
	/// Finds first item in the <see cref="IEnumerable{T}" /> or returns null.
	/// Validates that <paramref name="collection" /> contains items.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="match">The match.</param>
	/// <returns>System.Nullable&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Match cannot be null.</exception>
	[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T? FirstOrNull<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> match)
		where T : struct
	{
		var listToProcess = collection.ArgumentItemsExists().ToCollection();
		match = match.ArgumentNotNull();

		for (var listCount = 0; listCount < listToProcess.FastCount(); listCount++)
		{
			var local = listToProcess[listCount];

			if (match?.Invoke(local) ?? default)
			{
				return new T?(local);
			}
		}

		return null;
	}

	/// <summary>
	/// Determines whether the specified items has duplicates.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="items">The items.</param>
	/// <returns><c>true</c> if the specified items has duplicates; otherwise, <c>false</c>.</returns>
	[Information("Orginal code by Milan Jovanović", author: "David McCarter", createdOn: "7/3/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug23")]
	public static bool HasDuplicates<T>([NotNull] this IEnumerable<T> items)
	{
		if (items.DoesNotHaveItems())
		{
			return false;
		}

		var elements = ImmutableHashSet.CreateBuilder<T>();

		foreach (var item in items)
		{
			if (elements.Add(item) == false)
			{
				return true;
			}
		}

		return false;
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
	[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
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
	[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
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
	[Information(nameof(IsNullOrEmpty), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool IsNullOrEmpty([AllowNull] this IEnumerable collection) => collection.IsNull() || collection.GetEnumerator().MoveNext() is false;

	/// <summary>
	/// Joins a processedCollection using the specified separator.
	/// Validates that <paramref name="collection" /> contains items.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <param name="separator">The separator.</param>
	/// <returns>System.String.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(Join), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
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
	[Information(nameof(OrderBy), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
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
	[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IOrderedEnumerable<T> OrderByOrdinal<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, string> keySelector) => collection.ArgumentNotNull().OrderBy(keySelector.ArgumentNotNull(), StringComparer.Ordinal);

	/// <summary>
	/// Converts a processedCollection into separate collections based on page size.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="pageSize">Size of the page. Minimum page size is 1.</param>
	/// <returns>IEnumerable&lt;IEnumerable&lt;T&gt;&gt;.</returns>
	/// <exception cref="ArgumentOutOfRangeException">pageCount</exception>
	/// <exception cref="ArgumentNullException">pageCount</exception>
	/// <exception cref="ArgumentNullException">pageCount</exception>
	/// <exception cref="ArgumentOutOfRangeException">pageCount</exception>
	[Information(nameof(Page), "David McCarter", "11/21/2010", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IEnumerable<IEnumerable<T>> Page<T>([NotNull] this IEnumerable<T> collection, int pageSize)
	{
		collection = collection.ArgumentNotNull();

		pageSize = pageSize.EnsureMinimum(1);

		using (var enumerator = collection.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				var currentPage = new List<T>(pageSize) { enumerator.Current };

				while (currentPage.FastCount() < pageSize && enumerator.MoveNext())
				{
					currentPage.Add(enumerator.Current);
				}

				yield return currentPage.AsEnumerable();
			}
		}
	}

	/// <summary>
	/// Partitions the collection into the specified page count.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection to partition.</param>
	/// <param name="pageCount">The page count.</param>
	/// <returns>IEnumerable&lt;IEnumerable&lt;T&gt;&gt;.</returns>
	/// <remarks>Original code from: https://github.com/dncuug/X.PagedList/blob/master/src/X.PagedList/PagedListExtensions.cs</remarks>
	[Information(nameof(Partition), "David McCarter", "3/2/2023", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
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
	/// Picks a random item from a processedCollection.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>T.</returns>
	[Information(nameof(PickRandom), "David McCarter", "8/26/2020", "9/19/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineNov2022")]
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
	/// Splits a collection into the specified page count.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection to split.</param>
	/// <param name="pageCount">The page count.</param>
	/// <returns>IEnumerable&lt;IEnumerable&lt;T&gt;&gt;.</returns>
	/// <remarks>Original code from: https://github.com/dncuug/X.PagedList/blob/master/src/X.PagedList/PagedListExtensions.cs</remarks>
	[Information(nameof(Split), "David McCarter", "3/2/2023", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static IEnumerable<IEnumerable<T>> Split<T>([NotNull] this IEnumerable<T> collection, int pageCount)
	{
		collection = collection.ArgumentNotNull();

		pageCount = pageCount.EnsureMinimum(1);

		var takeCount = Convert.ToInt32(Math.Ceiling(collection.Count() / (double)pageCount));

		var result = new List<IEnumerable<T>>();

		for (var pageIndex = 0; pageIndex < pageCount; pageIndex++)
		{
			var chunk = collection.Skip(pageIndex * takeCount).Take(takeCount).ToList();

			if (chunk.HasItems())
			{
				result.Add(chunk);
			};
		}

		return result;
	}

	/// <summary>
	/// Determines if first <see cref="IEnumerable{T}" /> starts with the second <see cref="IEnumerable{T}" />.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="first">The first.</param>
	/// <param name="second">The second.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(StartsWith), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool StartsWith<T>([NotNull] this IEnumerable<T> first, [NotNull] IEnumerable<T> second)
	{
		if (first is null || second is null)
		{
			return false;
		}

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
	/// Determines if two <see cref="IEnumerable{T}" /> sequences are equal.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="first">The first.</param>
	/// <param name="second">The second.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">second</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool StructuralSequenceEqual<T>([NotNull] this IEnumerable<T> first, [NotNull] IEnumerable<T> second)
	{
		if (first is null || second is null)
		{
			return false;
		}

		if (ReferenceEquals(first, second))
		{
			return true;
		}

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
	/// Converts a <see cref="IEnumerable{T}" /> to a BlockingCollection.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>BlockingCollection&lt;T&gt;.</returns>
	/// <remarks>The resulting collection supports IDisposable. Make sure to properly dispose!</remarks>
	[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static BlockingCollection<T> ToBlockingCollection<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		var returnValue = new BlockingCollection<T>(collection.Count());

		foreach (var item in collection)
		{
			_ = returnValue.TryAdd(item);
		}

		return returnValue;
	}

	/// <summary>
	/// Converts the <see cref="IEnumerable{T}" /> to a <see cref="Collection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>Collection&lt;T&gt;.</returns>
	[Information(nameof(ToCollection), "David McCarter", "4/13/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static Collection<T> ToCollection<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return new Collection<T>(collection.ToList());
	}

	/// <summary>
	/// Convert a <see cref="IEnumerable{T}" /> to a delimited string using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ToDelimitedString), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb21")]
	public static string ToDelimitedString<T>([NotNull] this IEnumerable<T> collection, char delimiter = ControlChars.Comma)
	{
		if (collection is null || collection.FastCount() == 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
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
	/// Converts a <see cref="IEnumerable{T}" /> to <see cref="ImmutableList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The values.</param>
	/// <returns>IImmutableList&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
	[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static ImmutableList<T> ToImmutable<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return ImmutableList.CreateRange(collection);
	}

	/// <summary>
	/// Converts <see cref="IEnumerable{T}" /> to a <see cref="LinkedList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The values.</param>
	/// <returns>LinkedList&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
	[Information(nameof(ToLinkedList), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
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
	[Information(nameof(ToListAsync), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static async Task<List<T>> ToListAsync<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return await Task.Run(() => collection.ToList(), CancellationToken.None).ConfigureAwait(false);
	}

	/// <summary>
	/// Converts to <see cref=" ReadOnlyCollection{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>([NotNull] this IEnumerable<T> collection) => new(collection.ArgumentNotNull().ToList());

	/// <summary>
	/// Converts to <see cref=" ReadOnlyCollection{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "2/5/2024", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>([NotNull] this ConcurrentBag<T> collection) => new(collection.ArgumentNotNull().ToList());

	/// <summary>
	/// Upserts (update or insert) the specified item to the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" />  is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <returns>System.Collections.Generic.IEnumerable&lt;T&gt;.</returns>
	[Information(nameof(Upsert), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
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
