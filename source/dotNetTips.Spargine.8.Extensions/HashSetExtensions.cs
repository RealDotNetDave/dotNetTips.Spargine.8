// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-03-2025
// ***********************************************************************
// <copyright file="HashSetExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for the HashSet type.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="HashSet{T}" /> to enhance its functionality.
/// These methods include adding items conditionally, converting to concurrent or immutable hash sets, and upserting items.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class HashSetExtensions
{

	/// <summary>
	/// Adds an item to the <see cref="HashSet{T}" /> if a specified condition is met.
	/// This method validates that both the <paramref name="collection" /> and <paramref name="item" /> are not null before attempting to add.
	/// </summary>
	/// <typeparam name="T">The type of elements in the hash set.</typeparam>
	/// <param name="collection">The hash set to which the item may be added.</param>
	/// <param name="item">The item to add to the hash set.</param>
	/// <param name="condition">The condition that determines whether the item should be added.</param>
	[Information(nameof(AddIf), "David McCarter", "5/2/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void AddIf<T>(this HashSet<T> collection, T item, bool condition)
	{
		collection = collection.ArgumentNotNull();
		item = item.ArgumentNotNull();

		if (condition)
		{
			_ = collection.Add(item);
		}
	}

	/// <summary>
	/// Converts a <see cref="HashSet{T}" /> to a <see cref="ConcurrentHashSet{T}" />.
	/// This method ensures thread-safe operations on the hash set by creating a concurrent version of it.
	/// </summary>
	/// <typeparam name="T">The type of elements in the hash set.</typeparam>
	/// <param name="collection">The hash set to convert.</param>
	/// <returns>A new instance of <see cref="ConcurrentHashSet{T}" /> containing all elements from the original hash set.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection" /> is null.</exception>
	[Information(nameof(ToConcurrentHashSet), "David McCarter", "12/3/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ConcurrentHashSet<T> ToConcurrentHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];

	/// <summary>
	/// Converts a <see cref="HashSet{T}" /> to an <see cref="ImmutableHashSet{T}" />.
	/// This method creates an immutable hash set containing all the elements of the original hash set,
	/// providing a snapshot that cannot be modified.
	/// </summary>
	/// <typeparam name="T">The type of elements in the hash set.</typeparam>
	/// <param name="collection">The hash set to convert.</param>
	/// <returns>An <see cref="ImmutableHashSet{T}" /> containing all elements from the original hash set.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection" /> is null.</exception>
	[Information(nameof(ToImmutableHashSet), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ImmutableHashSet<T> ToImmutableHashSet<T>(this HashSet<T> collection) => [.. collection.ArgumentNotNull()];

	/// <summary>
	/// Upserts (updates or inserts) an item into the <see cref="HashSet{T}" />.
	/// If the item already exists in the hash set, it is first removed and then added again to ensure the latest value is stored.
	/// This method ensures that both the <paramref name="collection" /> and <paramref name="item" /> are not null before performing the upsert operation.
	/// </summary>
	/// <typeparam name="T">The type of elements in the hash set.</typeparam>
	/// <param name="collection">The hash set where the item will be upserted.</param>
	/// <param name="item">The item to upsert into the hash set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection" /> or <paramref name="item" /> is null.</exception>
	[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void Upsert<T>(this HashSet<T> collection, T item)
	{
		collection = collection.ArgumentNotNull();
		item = item.ArgumentNotNull();

		if (collection.Contains(item))
		{
			_ = collection.Remove(item);
		}

		_ = collection.Add(item);
	}

}
