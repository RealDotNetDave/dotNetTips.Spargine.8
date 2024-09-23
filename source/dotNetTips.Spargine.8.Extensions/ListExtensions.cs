// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions **
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 09-23-2024
// ***********************************************************************
// <copyright file="ListExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>

// <summary>Extension methods for different List collection types.</summary>
// ***********************************************************************
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="List{T}"/> to enhance its functionality.
/// </summary>
/// <remarks>
/// This class includes methods for adding elements to the beginning or end of a list, checking for nulls,
/// converting lists to various collection types, performing actions on list elements, and more. These methods
/// are designed to extend the capabilities of <see cref="List{T}"/> and simplify common operations.
/// </remarks>
public static class ListExtensions
{

	/// <summary>
	/// Adds an item to the beginning of the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="collection">The list to which the item will be added.</param>
	/// <param name="item">The item to add to the beginning of the list.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static List<T> AddFirst<T>([NotNull] this List<T> collection, [NotNull] T item)
	{
		if (item is null)
		{
			return collection;
		}

		return collection.ArgumentNotNull().ArgumentNotReadOnly().Prepend(item).ToList();
	}

	/// <summary>
	/// Adds an item to the end of the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="collection">The list to which the item will be added.</param>
	/// <param name="item">The item to add to the end of the list.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static List<T> AddLast<T>([NotNull] this List<T> collection, [NotNull] T item)
	{
		if (item is null)
		{
			return collection;
		}

		return [.. collection.ArgumentNotNull().ArgumentNotReadOnly(), item];

	}

	/// <summary>
	/// Creates a <see cref="ReadOnlySpan{T}"/> from the <see cref="List{T}"/>. Utilizing spans can improve performance when iterating over the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="list">The list to create a read-only span from.</param>
	/// <returns>A read-only span representing the list.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="list"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AsReadOnlySpan), "David McCarter", "5/30/2023", BenchMarkStatus = BenchMarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static ReadOnlySpan<T> AsReadOnlySpan<T>([NotNull] this List<T> list) => CollectionsMarshal.AsSpan(list.ArgumentNotNull());

	/// <summary>
	/// Creates a new <see cref="Span{T}" /> using CollectionsMarshal over an input <see cref="List{T}" /> instance. Utilizing spans can improve performance when iterating over the collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the input <see cref="List{T}" /> instance.</typeparam>
	/// <param name="list">The input <see cref="List{T}" /> instance.</param>
	/// <returns>A <see cref="Span{T}" /> instance with the collection  of <paramref name="list" />.</returns>
	/// <remarks>Note that the returned <see cref="Span{T}" /> is only guaranteed to be valid as long as the items within
	/// <paramref name="list" /> are not modified. Doing so might cause the <see cref="List{T}" /> to swap its
	/// internal buffer, causing the returned <see cref="Span{T}" /> to become out of date. That means that in this
	/// scenario, the <see cref="Span{T}" /> would end up wrapping an array no longer in use. Always make sure to use
	/// the returned <see cref="Span{T}" /> while the target <see cref="List{T}" /> is not modified.
	/// Original code from:
	/// https://github.com/CommunityToolkit/dotnet/blob/main/CommunityToolkit.HighPerformance/Extensions/ListExtensions.cs</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AsSpan), "David McCarter", "8/3/2022", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static Span<T> AsSpan<T>([NotNull] this List<T> list) => CollectionsMarshal.AsSpan(list.ArgumentNotNull());

	/// <summary>
	/// Removes all null elements from the <see cref="List{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="collection">The list from which to remove null elements.</param>
	/// <returns><c>true</c> if any elements were removed; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ClearNulls), author: "David McCarter", createdOn: "8/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, Status = Status.Available)]
	public static bool ClearNulls<T>([NotNull] this List<T> collection)
	{
		if (collection is null)
		{
			return false;
		}

		return collection.RemoveAll(p => p is null) > 0;
	}

	/// <summary>
	/// Copies the elements of the <see cref="List{T}"/> to a new <see cref="Collection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="collection">The list whose elements are copied.</param>
	/// <returns>A new <see cref="Collection{T}"/> containing the elements of the input list.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Obsolete("Use ToCollection() instead. Method will be removed at the end of 2024.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CopyToCollection), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Collection<T> CopyToCollection<T>([NotNull] this List<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return new Collection<T>(collection);
	}

	/// <summary>
	/// Determines whether the specified <see cref="List{T}"/> does not contain any items.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="collection">The list to check.</param>
	/// <returns><c>true</c> if the list is null or contains no elements; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<T>([NotNull] this List<T> collection)
	{
		return collection == null || collection.Count == 0;
	}

	/// <summary>
	/// Generates a hash code for the entire <see cref="List{T}"/> based on the hash codes of its elements.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="collection">The list for which to generate a hash code.</param>
	/// <returns>A hash code representing the contents of the list.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static int GenerateHashCode<T>([NotNull] this List<T> collection)
	{
		collection = collection.ArgumentNotNull();

		var hash = HashCode.Combine(collection);

		return hash;
	}

	/// <summary>
	/// Determines whether the specified <see cref="List{T}"/> contains any items.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="collection">The list to check.</param>
	/// <returns><c>true</c> if the list contains one or more elements; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(nameof(HasItems), "David McCarter", "8/27/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineAug2022", Status = Status.Available)]
	public static bool HasItems<T>([NotNull] this List<T> collection) => collection?.Count > 0;

	/// <summary>
	/// Determines whether the specified <see cref="List{T}" /> has items based on the Predicate.
	/// Returns false if <paramref name="action" /> or <paramref name="collection" /> is null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="action">The action.</param>
	/// <returns><c>true</c> if the specified action has items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">action</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this List<T> collection, [NotNull] Predicate<T> action)
	{
		if (collection.CheckIsNotNull() is false || action.CheckIsNotNull() is false)
		{
			return false;
		}

		return collection.Exists(action);
	}

	/// <summary>
	/// Determines whether the <see cref="List{T}" /> has a specified count.
	/// Returns false if <paramref name="collection" /> is null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="count">The specific count.</param>
	/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), "David McCarter", "8/27/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.WIP, Documentation = "https://bit.ly/SpargineAug2022", Status = Status.Available)]
	public static bool HasItems<T>([NotNull] this List<T> collection, in int count)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.Count == count;
		}
	}

	/// <summary>
	/// Finds index that avoids multiple enumerations.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="index">The index.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">collection</exception>
	/// <remarks>Original code by: @TheOtherBoz</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IndexAtLooped), author: "David McCarter", createdOn: "7/17/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static T IndexAtLooped<T>([NotNull] this List<T> collection, int index)
	{
		collection = collection.ArgumentNotNull();

		var count = collection.Count;

		if (count == 0)
		{
			ExceptionThrower.ThrowArgumentException("Collection is empty.", nameof(collection));
		}

		var indexWrap = index % count;

		if (indexWrap < 0)
		{
			indexWrap += count;
		}

		return collection[indexWrap];
	}

	/// <summary>
	/// Determines whether the specified list to check is equal.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="collectionToCheck">The list to check.</param>
	/// <returns><c>true</c> if the specified list to check is equal; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">collection</exception>
	/// <exception cref="ArgumentNullException">collectionToCheck</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEqualTo), author: "David McCarter", createdOn: "3/22/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, Documentation = "https://bit.ly/SpargineMay2023", Status = Status.Available)]
	public static bool IsEqualTo<T>([NotNull] this List<T> collection, [NotNull] List<T> collectionToCheck)
	{
		if (collection is null || collectionToCheck is null)
		{
			return false;
		}

		if (collection.Count != collectionToCheck.Count)
		{
			return false;
		}

		var itemCount = collection.Count;

		for (var index = 0; index < itemCount; index++)
		{
			if (!EqualityComparer<T>.Default.Equals(collection[index], collectionToCheck[index]))
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Performs the action for the items in the <see cref="List{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="action">The action.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PerformAction), "David McCarter", "1/4/2023", Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static void PerformAction<T>([NotNull] this List<T> collection, [NotNull] Action<T> action)
	{
		collection = collection.ArgumentNotNull();
		action = action.ArgumentNotNull();

		if (collection.Count == 0)
		{
			return;
		}

		var itemCount = collection.Count;

		for (var index = 0; index < itemCount; index++)
		{
			action(collection[index]);
		}
	}

	/// <summary>
	/// Groups the elements of a <see cref="List{T}" /> sequence according to a specified firstKey selector function and rotates the unique
	/// collection  from the secondKey selector function into multiple collection  in the output, and performs aggregations.
	/// Validates that <paramref name="collection" />, <paramref name="firstKeySelector" />,
	/// <paramref name="secondKeySelector" />, <paramref name="aggregate" /> is not null.
	/// </summary>
	/// <typeparam name="TSource">The type of the t list.</typeparam>
	/// <typeparam name="TFirstKey">The type of the t first key.</typeparam>
	/// <typeparam name="TSecondKey">The type of the t second key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="firstKeySelector">The first key selector.</param>
	/// <param name="secondKeySelector">The second key selector.</param>
	/// <param name="aggregate">The aggregate.</param>
	/// <returns>Dictionary&lt;TFirstKey, Dictionary&lt;TSecondKey, TValue&gt;&gt;.</returns>
	/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value. or list - Aggregate cannot be null. or firstKeySelector -
	/// First key selector cannot be null. or secondKeySelector - Second key selector cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Pivot), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot<TSource, TFirstKey, TSecondKey, TValue>([NotNull] this IEnumerable<TSource> collection, [NotNull] Func<TSource, TFirstKey> firstKeySelector, [NotNull] Func<TSource, TSecondKey> secondKeySelector, [NotNull] Func<IEnumerable<TSource>, TValue> aggregate)
	{
		collection = collection.ArgumentNotNull();
		firstKeySelector = firstKeySelector.ArgumentNotNull();
		secondKeySelector = secondKeySelector.ArgumentNotNull();
		aggregate = aggregate.ArgumentNotNull();

		var returnValue = new Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>();

		var lookup = collection.ToLookup(firstKeySelector).ToList();

		lookup.ForEach(item =>
		{
			var collection = new Dictionary<TSecondKey, TValue>();

			returnValue.Add(item.Key, collection);

			var secondLookup = item.ToLookup(secondKeySelector).ToList();

			secondLookup.ForEach(subitem => collection.Add(subitem.Key, aggregate.Invoke(subitem)));
		});

		return returnValue;
	}

	/// <summary>
	/// Converts to <see cref="List{T}" /> to a <see cref="Collection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>Core.Collections.Generic.Collection&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToCollection), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static Collection<T> ToCollection<T>([NotNull] this List<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts <see cref="List{T}" /> to a <see cref=" DistinctBlockingCollection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="completeAdding">Set to true if no more items will be acced
	/// to this collection.</param>
	/// <returns>DistinctBlockingCollection&lt;T&gt;.</returns>
	/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
	/// to remove from memory.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToDistinctBlockingCollection), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineJan2022", Status = Status.Available)]
	public static DistinctBlockingCollection<T> ToDistinctBlockingCollection<T>([NotNull] this List<T> collection, bool completeAdding = false)
	{
		var result = new DistinctBlockingCollection<T>(collection.ArgumentItemsExists());

		if (completeAdding)
		{
			result.CompleteAdding();
		}

		return result;
	}

	/// <summary>
	/// Converts <see cref="List{T}" /> to a <see cref="DistinctConcurrentBag{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>DistinctConcurrentBag&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToDistinctConcurrentBag), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineJan2022", Status = Status.Available)]
	public static DistinctConcurrentBag<T> ToDistinctConcurrentBag<T>([NotNull] this List<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts a <see cref="List{T}" /> to the Spargine <see cref="FastSortedList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>FastSortedList&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFastSortedList), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineJan2022", Status = Status.Available)]
	public static FastSortedList<T> ToFastSortedList<T>([NotNull] this List<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts a <see cref="List{T}" /> to <see cref="FrozenSet{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="list">The list.</param>
	/// <returns>FrozenSet&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "ADD URL", Status = Status.New)]
	public static FrozenSet<T> ToFrozenSet<T>([NotNull] this List<T> list) => FrozenSet.ToFrozenSet(list);

	/// <summary>
	/// Converts <see cref="List{T}" /> to an <see cref="ImmutableArray{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>ImmutableArray&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToCollection), "David McCarter", "12/3/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ImmutableArray<T> ToImmutableArray<T>([NotNull] this List<T> collection)
	{
		collection = collection.ArgumentNotNull();

		return ImmutableArray.CreateRange(collection);
	}

	/// <summary>
	/// Converts the <see cref="IAsyncEnumerable{T}" /> to a <see cref="List{T}" /> in an asynchronous operation.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">The type of the t source.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>List&lt;T&gt;.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToListAsync), "David McCarter", "12/3/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static async Task<List<T>> ToListAsync<T>([NotNull] this IAsyncEnumerable<T> collection, CancellationToken cancellationToken = default)
	{
		collection = collection.ArgumentNotNull();

		var returnList = new List<T>();

		await foreach (var element in collection.WithCancellation(cancellationToken))
		{
			returnList.Add(element);
		}

		return returnList;
	}

	/// <summary>
	/// Converts <see cref="List{T}" /> to a <see cref="ObservableCollection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>ObservableCollection.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToObservableCollection), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ObservableCollection<T> ToObservableCollection<T>([NotNull] this List<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts the <see cref="List{T}" /> to a <see cref="ObservableList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>ObservableList&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToObservableList), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ObservableList<T> ToObservableList<T>([NotNull] this List<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts the <see cref="List{T}" /> to a <see cref="ReadOnlyCollection{T}" />
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The <see cref="List{T}" /> to convert.</param>
	/// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>([NotNull] this List<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts the <see cref="List{T}" /> to <see cref="IReadOnlyList{T}" />/&gt;.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The <see cref="List{T}" /> to convert.</param>
	/// <returns>IReadOnlyList&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToReadOnlyList), "David McCarter", "4/10/2022", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IReadOnlyList<T> ToReadOnlyList<T>([NotNull] this List<T> collection) => collection.ArgumentNotNull().AsReadOnly();

	/// <summary>
	/// Converts to <see cref="ReadOnlyObservableCollection{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>ReadOnlyObservableCollection&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToObservableCollection), "David McCarter", "11/26/2022", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static ReadOnlyObservableCollection<T> ToReadOnlyObservableCollection<T>([NotNull] this List<T> collection) => new(collection.ArgumentNotNull().ToObservableCollection());

}
