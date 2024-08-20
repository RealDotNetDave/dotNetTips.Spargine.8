// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 08-20-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-20-2024
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Provides extension methods for modifying collections in parallel.</summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for modifying collections in parallel.
/// </summary>
public static partial class EnumerableExtensions
{

	/// <summary>
	/// Processes a collection using a provided action and returns a read-only collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each element in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <returns>A read-only collection with the processed elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the collection or action is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: NotNull]
	private static ReadOnlyCollection<T> ModifyWithCollectionsMarshallAsSpan<T>(Func<T, T> action, IEnumerable<T> collection)
	{
		var list = collection as List<T> ?? collection.ToList();
		var processedBag = new ReadOnlyCollectionBuilder<T>(collection.Count());

		foreach (var item in CollectionsMarshal.AsSpan(list))
		{
			processedBag.Add(action(item));
		}

		return processedBag.ToReadOnlyCollection();
	}

	/// <summary>
	/// Processes a collection using a provided action and returns a read-only collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each element in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <returns>A read-only collection with the processed elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the collection or action is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: NotNull]
	private static ReadOnlyCollection<T> ModifyWithForEach<T>(Func<T, T> action, IEnumerable<T> collection)
	{
		var processedBag = new ConcurrentBag<T>();

		_ = Parallel.ForEach(collection, person =>
		{
			processedBag.Add(action(person));
		});

		return processedBag.ToReadOnlyCollection();
	}

	/// <summary>
	/// Processes a collection in parallel using a provided action and returns a read-only collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each element in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <returns>A read-only collection with the processed elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the collection or action is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: NotNull]
	private static ReadOnlyCollection<T> ModifyWithParallelFor<T>(Func<T, T> action, in IEnumerable<T> collection)
	{
		var processedArray = collection as T[] ?? collection.ToArray();
		var processedBag = new ConcurrentBag<T>();

		_ = Parallel.For(0, processedArray.Length, index => processedBag.Add(action(processedArray[index])));

		return processedBag.ToReadOnlyCollection();
	}

	/// <summary>
	/// Processes a collection in parallel using a provided action and returns a read-only collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each element in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <returns>A read-only collection with the processed elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the collection or action is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: NotNull]
	private static ReadOnlyCollection<T> ModifyWithParallelForEachWithPartitioner<T>(Func<T, T> action, in IEnumerable<T> collection)
	{
		var processedArray = collection as T[] ?? collection.ToArray();
		var rangePartitioner = Partitioner.Create(0, processedArray.Length);
		var processedBag = new ConcurrentBag<T>();

		_ = Parallel.ForEach(rangePartitioner, (range, state) =>
		{
			for (var index = range.Item1; index < range.Item2; index++)
			{
				processedBag.Add(action(processedArray[index]));
			}
		});

		return processedBag.ToReadOnlyCollection();
	}

	/// <summary>
	/// Processes a collection in parallel using a provided action and a maximum degree of parallelism, and returns a read-only collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each element in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <returns>A read-only collection with the processed elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the collection or action is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: NotNull]
	private static ReadOnlyCollection<T> ModifyWithParallelForWithMaxDegreeOfParallelism<T>(Func<T, T> action, in IEnumerable<T> collection)
	{
		var processedArray = collection as T[] ?? collection.ToArray();
		var processedBag = new ConcurrentBag<T>();

		_ = Parallel.For(0, processedArray.Length, _parallelOptions, index => processedBag.Add(action(processedArray[index])));

		return processedBag.ToReadOnlyCollection();
	}

	/// <summary>
	/// Modifies a collection in parallel using a provided action and returns a read-only collection.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to process.</param>
	/// <param name="action">The action to apply to each element in the collection.</param>
	/// <returns>A read-only collection with the modified elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the collection or action is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[return: NotNull]
	[Information(nameof(FastModifyCollection), author: "David McCarter", createdOn: "8/7/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Benchmark, Status = Status.New)]
	public static ReadOnlyCollection<T> FastModifyCollection<T>(this IEnumerable<T> collection, Func<T, T> action)
	{
		collection = collection.ArgumentNotNull();
		action = action.ArgumentNotNull();

		// Change processing due to collection size.
		var size = collection is ICollection<T> col ? col.Count : collection.Count();

		if (size == 0)
		{
			return new ReadOnlyCollection<T>(Array.Empty<T>());
		}

		// Change processing due to collection item type.
		var itemType = collection.First().GetTypeOfType();
		ReadOnlyCollection<T> updatedCollection = default;

		switch (itemType)
		{
			case TypeExtensions.TypeOfType.Value:
				updatedCollection = ModifyCollectionWithValueType(action, collection, size);
				break;
			case TypeExtensions.TypeOfType.Record:
				updatedCollection = ModifyCollectionWithRecordType(action, collection, size);
				break;
			case TypeExtensions.TypeOfType.Unknown:
			case TypeExtensions.TypeOfType.Reference:
				updatedCollection = ModifyCollectionWithReferenceType(action, collection);
				break;
			default:
				ExceptionThrower.ThrowInvalidOperationException($"{itemType} is not supported in {nameof(FastModifyCollection)}.");
				break;
		}

		return updatedCollection;

		// Processes a collection of value types using the specified action.
		// The method chooses the appropriate processing strategy based on the size of the collection.
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static ReadOnlyCollection<T> ModifyCollectionWithValueType(Func<T, T> action, IEnumerable<T> processedCollection, int size)
		{
			if (size >= 8192)
			{
				return ModifyWithForEach(action, processedCollection);
			}
			else if (size >= 2048)
			{
				return ModifyWithParallelFor(action, processedCollection);
			}
			else
			{
				return ModifyWithCollectionsMarshallAsSpan(action, processedCollection);
			}
		}

		// Processes a collection of record types using the specified action.
		// The method chooses the appropriate processing strategy based on the size of the collection.
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static ReadOnlyCollection<T> ModifyCollectionWithRecordType(Func<T, T> action, IEnumerable<T> processedCollection, int size)
		{
			if (size >= 8192)
			{
				return ModifyWithParallelForWithMaxDegreeOfParallelism(action, processedCollection);
			}
			else if (size >= 4096)
			{
				return ModifyWithParallelForEachWithPartitioner(action, processedCollection);
			}
			else if (size >= 2048)
			{
				return ModifyWithParallelFor(action, processedCollection);
			}
			else
			{
				return ModifyWithCollectionsMarshallAsSpan(action, processedCollection);
			}
		}

		// Processes a collection of reference types using the specified action.
		// The method chooses the appropriate processing strategy based on the size of the collection.
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static ReadOnlyCollection<T> ModifyCollectionWithReferenceType(Func<T, T> action, IEnumerable<T> processedCollection)
		{
			return ModifyWithCollectionsMarshallAsSpan(action, processedCollection);
		}
	}
}
