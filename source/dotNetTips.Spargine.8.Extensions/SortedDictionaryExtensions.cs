// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-16-2024
// ***********************************************************************
// <copyright file="SortedDictionaryExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods designed for SortedDictionary.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="SortedDictionary{TKey, TValue}"/> to enhance functionality
/// with additional utility methods. These methods include checking for items, converting to immutable collections,
/// and upsert operations.
/// </summary>
public static class SortedDictionaryExtensions
{

	/// <summary>
	/// Checks if the <see cref="SortedDictionary{TKey, TValue}"/> is null or does not contain any items.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <see cref="SortedDictionary{TKey, TValue}"/> to check.</param>
	/// <returns><c>true</c> if the dictionary is null or empty; otherwise, <c>false</c>.</returns>
	[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> collection)
	{
		if (collection is null)
		{
			return true;
		}
		else
		{
			return collection.Count <= 0;
		}
	}

	/// <summary>
	/// Determines whether the specified <see cref="SortedDictionary{TKey, TValue}"/> has items.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <see cref="SortedDictionary{TKey, TValue}"/> to check.</param>
	/// <returns><c>true</c> if the specified dictionary has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> collection)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.Count > 0;
		}
	}

	/// <summary>
	/// Determines whether the specified action finds any items in the <see cref="SortedDictionary{TKey, TValue}"/>.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <see cref="SortedDictionary{TKey, TValue}"/> to check.</param>
	/// <param name="action">The action to test each item in the <paramref name="collection"/>.</param>
	/// <returns><c>true</c> if the specified action finds items that match the condition; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> collection, [NotNull] Func<KeyValuePair<TKey, TValue>, bool> action)
	{
		if (collection is null || action is null)
		{
			return true;
		}
		else
		{
			return collection.Any(action);
		}
	}

	/// <summary>
	/// Determines whether the specified count of items exists in the <see cref="SortedDictionary{TKey, TValue}"/>.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <see cref="SortedDictionary{TKey, TValue}"/> to check.</param>
	/// <param name="count">The count of items to verify in the <paramref name="collection"/>.</param>
	/// <returns><c>true</c> if the count of items in the <paramref name="collection"/> equals the specified <paramref name="count"/>; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> collection, int count)
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
	/// Converts the specified <see cref="SortedDictionary{TKey, TValue}"/> to an <see cref="ImmutableSortedDictionary{TKey, TValue}"/>.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <see cref="SortedDictionary{TKey, TValue}"/> to convert.</param>
	/// <returns>An <see cref="ImmutableSortedDictionary{TKey, TValue}"/> that contains the elements from the specified dictionary.</returns>
	[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ImmutableSortedDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> collection) => ImmutableSortedDictionary.CreateRange(collection.ArgumentNotNull());

	/// <summary>
	/// Upserts the specified key.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="key">The key.</param>
	/// <param name="value">The value.</param>
	/// <returns>TValue.</returns>
	[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static TValue Upsert<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> collection, [NotNull] TKey key, [NotNull] TValue value)
	{
		if (value is null)
		{
			return value;
		}

		if (collection.ArgumentNotNull().TryGetValue(key.ArgumentNotNull(), out var item) is false)
		{
			collection.Add(key, value);
			item = value;
		}

		return item;
	}

}
