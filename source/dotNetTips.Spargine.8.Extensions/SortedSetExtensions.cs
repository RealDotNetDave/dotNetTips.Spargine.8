// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-16-2024
// ***********************************************************************
// <copyright file="SortedSetExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods designed for SortedSet.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="SortedSet{T}"/>.
/// </summary>
/// <remarks>
/// This class contains extension methods for <see cref="SortedSet{T}"/> that enhance its functionality by providing methods to check for items,
/// determine if any items match a specified condition, and convert the set to an immutable sorted set. These methods aim to simplify common
/// operations performed on sorted sets and improve code readability and maintainability.
/// </remarks>
public static class SortedSetExtensions
{

	/// <summary>
	/// Checks set for null and ensures there are items in the set.
	/// </summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	/// <param name="collection">The <see cref="SortedSet{T}"/> to check.</param>
	/// <returns><c>true</c> if the <paramref name="collection"/> is null or has no items; otherwise, <c>false</c>.</returns>
	[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<T>([NotNull] this SortedSet<T> collection)
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
	/// Determines whether the specified <see cref="SortedSet{T}"/> has items.
	/// </summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	/// <param name="collection">The collection to check.</param>
	/// <returns><c>true</c> if the specified collection has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this SortedSet<T> collection)
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
	/// Determines whether the specified <see cref="SortedSet{T}"/> has items that match the condition defined by the specified predicate.
	/// </summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	/// <param name="collection">The collection to check.</param>
	/// <param name="action">The predicate to apply to each element. Each element is passed to the <see cref="Func{T, TResult}"/> to determine if it matches the condition.</param>
	/// <returns><c>true</c> if any elements in the specified collection match the condition defined by the specified predicate; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this SortedSet<T> collection, [NotNull] Func<T, bool> action)
	{
		if (collection is null || action is null)
		{
			return false;
		}
		else
		{
			return collection.Any(action);
		}
	}

	/// <summary>
	/// Converts the specified <see cref="SortedSet{T}"/> to an <see cref="ImmutableSortedSet{T}"/>.
	/// Validates that <paramref name="collection"/> is not null before conversion.
	/// </summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	/// <param name="collection">The <see cref="SortedSet{T}"/> to convert.</param>
	/// <returns>An <see cref="ImmutableSortedSet{T}"/> that contains elements from the input collection.</returns>
	[Information(nameof(ToImmutableSortedSet), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ImmutableSortedSet<T> ToImmutableSortedSet<T>([NotNull] this SortedSet<T> collection) => ImmutableSortedSet.CreateRange(collection);

}
