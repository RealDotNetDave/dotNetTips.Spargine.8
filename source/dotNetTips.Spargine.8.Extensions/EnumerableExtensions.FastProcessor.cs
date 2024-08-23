// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 08-20-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2024
// ***********************************************************************
// <copyright file="EnumerableExtensions.FastProcessor.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Provides extension methods for modifying collections in parallel.</summary>
// ***********************************************************************
using System.Collections.Concurrent;
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
	/// Processes the collection in parallel using the specified action with auto-buffered merge options.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each item in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	private static void ProcessCollectionWithAsParallelWithMergeOptionsAutoBuffered<T>(Action<T> action, IEnumerable<T> collection)
	{
		collection.AsParallel().WithMergeOptions(ParallelMergeOptions.AutoBuffered).ForAll(person => action(person));
	}

	/// <summary>
	/// Processes the collection in parallel using the specified action with default-buffered merge options.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each item in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	private static void ProcessCollectionWithAsParallelWithMergeOptionsDefaultBuffered<T>(Action<T> action, IEnumerable<T> collection)
	{
		collection.AsParallel().WithMergeOptions(ParallelMergeOptions.Default).ForAll(person => action(person));
	}
	/// <summary>
	/// Processes the collection in parallel using the specified action with not-buffered merge options.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each item in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	private static void ProcessCollectionWithAsParallelWithMergeOptionsNotBuffered<T>(Action<T> action, IEnumerable<T> collection)
	{
		collection.AsParallel().WithMergeOptions(ParallelMergeOptions.NotBuffered).ForAll(person => action(person));
	}

	/// <summary>
	/// Processes the collection using the specified action with CollectionsMarshal.AsSpan for efficient iteration.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each item in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	private static void ProcessCollectionWithCollectionsMarshallAsSpan<T>(Action<T> action, IEnumerable<T> collection)
	{
		if (collection is List<T> list)
		{
			var span = CollectionsMarshal.AsSpan(list);
			for (var index = 0; index < span.Length; index++)
			{
				action(span[index]);
			}
		}
		else
		{
			var span = CollectionsMarshal.AsSpan(collection.ToList());
			for (var index = 0; index < span.Length; index++)
			{
				action(span[index]);
			}
		}
	}

	/// <summary>
	/// Processes the collection using the specified action with a partitioner.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="action">The action to apply to each item in the collection.</param>
	/// <param name="collection">The collection to process.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	private static void ProcessCollectionWithForEachPartitioner<T>(Action<T> action, IEnumerable<T> collection)
	{
		var list = collection as List<T> ?? collection.ToList();
		var rangePartitioner = Partitioner.Create(list);

		_ = Parallel.ForEach(rangePartitioner, person => action(person));
	}

	/// <summary>
	/// Processes each item in the given collection using the specified action.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to process.</param>
	/// <param name="action">The action to apply to each item in the collection.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="action"/> is null.</exception>
	/// <example>
	/// This example shows how to use <see cref="FastProcessor{T}"/> to print each element in an array of integers.
	/// <code>
	/// int[] numbers = { 1, 2, 3, 4, 5 };
	/// numbers.FastProcessor(n => Console.WriteLine(n));
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "12/9/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NeedsUpdate, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static void FastProcessor<T>(this IEnumerable<T> collection, Action<T> action)
	{
		collection = collection.ArgumentNotNull();
		action = action.ArgumentNotNull();

		// Change processing due to collection size.
		var size = collection is ICollection<T> col ? col.Count : collection.Count();
		var itemType = collection.First().GetTypeOfType();

		switch (itemType)
		{
			case TypeExtensions.TypeOfType.Value:
				ProcessCollectionWithValueType(action, collection, size);
				break;
			case TypeExtensions.TypeOfType.Record:
				ProcessCollectionWithRecordType(action, collection, size);
				break;
			case TypeExtensions.TypeOfType.Unknown:
			case TypeExtensions.TypeOfType.Reference:
				ProcessCollectionWithReferenceType(action, collection, size);
				break;
			default:
				ExceptionThrower.ThrowInvalidOperationException($"{itemType} is not supported in {nameof(FastProcessor)}.");
				break;

		}

		// Processes a collection of value types using the specified action.
		// The method chooses the appropriate processing strategy based on the size of the collection.
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static void ProcessCollectionWithValueType(Action<T> action, IEnumerable<T> processedCollection, in int size)
		{
			if (size >= 128)
			{
				ProcessCollectionWithAsParallelWithMergeOptionsNotBuffered(action, processedCollection);
			}
			else
			{
				ProcessCollectionWithCollectionsMarshallAsSpan(action, processedCollection);
			}
		}

		// Processes a collection of record types using the specified action.
		// The method chooses the appropriate processing strategy based on the size of the collection.
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static void ProcessCollectionWithRecordType(Action<T> action, IEnumerable<T> processedCollection, in int size)
		{
			if (size >= 8192)
			{
				ProcessCollectionWithForEachPartitioner(action, processedCollection);
			}
			else if (size >= 4096)
			{
				ProcessCollectionWithAsParallelWithMergeOptionsAutoBuffered(action, processedCollection);
			}
			else
			{
				ProcessCollectionWithCollectionsMarshallAsSpan(action, processedCollection);
			}
		}

		// Processes a collection of reference types using the specified action.
		// The method chooses the appropriate processing strategy based on the size of the collection.
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static void ProcessCollectionWithReferenceType(Action<T> action, IEnumerable<T> processedCollection, in int size)
		{
			if (size >= 8192)
			{
				ProcessCollectionWithForEachPartitioner(action, processedCollection);
			}
			else if (size >= 4096)
			{
				ProcessCollectionWithAsParallelWithMergeOptionsDefaultBuffered(action, processedCollection);
			}
			else
			{
				ProcessCollectionWithCollectionsMarshallAsSpan(action, processedCollection);
			}
		}
	}
}
