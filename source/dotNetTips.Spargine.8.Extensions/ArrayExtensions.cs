// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-12-2024
// ***********************************************************************
// <copyright file="ArrayExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extensions methods for the Array type.</summary>
// ***********************************************************************
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extensions methods for the Array type.
/// </summary>
public static class ArrayExtensions
{

	/// <summary>
	/// Provides a pool of reusable <see cref="StringBuilder"/> instances.
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Adds an item to the beginning of the specified array.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to which the item will be added.</param>
	/// <param name="item">The item to add to the array.</param>
	/// <returns>A new array with the item added at the beginning.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.WIP, Status = Status.NeedsDocumentation)]
	public static T[] AddFirst<T>([NotNull] this T[] array, [NotNull] T item)
	{
		if (item is null)
		{
			return array;
		}

		array = array.ArgumentNotNull();

		var result = new T[array.Length + 1];
		result[0] = item;
		Array.Copy(array, 0, result, 1, array.Length);

		return result;
	}

	/// <summary>
	/// Adds an item to the array if a specified condition is true.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to which the item will be added.</param>
	/// <param name="item">The item to add to the array.</param>
	/// <param name="condition">The condition that determines whether the item should be added.</param>
	/// <returns>A new array with the item added if the condition is true; otherwise, the original array.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddIf), author: "David McCarter", createdOn: "4/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static T[] AddIf<T>([NotNull] this T[] array, [NotNull] T item, bool condition)
	{
		if (item is null)
		{
			return array;
		}

		array = array.ArgumentNotNull();

		return condition ? array.AddLast(item) : array;
	}

	/// <summary>
	/// Adds an item to the end of the specified array.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to which the item will be added.</param>
	/// <param name="item">The item to add to the array.</param>
	/// <returns>A new array with the item added at the end.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.WIP, Status = Status.NeedsDocumentation)]
	public static T[] AddLast<T>([NotNull] this T[] array, [NotNull] T item)
	{
		if (item is null)
		{
			return array;
		}

		array = array.ArgumentNotNull();

		var newSize = array.Length + 1;
		Array.Resize(ref array, newSize);
		array[newSize - 1] = item;

		return array;
	}
	/// <summary>
	/// Checks if the two arrays are equal.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The input.</param>
	/// <param name="arrayToCheck">The array to check.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[Information(nameof(AreEqual), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.NeedsDocumentation)]
	public static bool AreEqual<T>([NotNull] this T[] array, [NotNull] T[] arrayToCheck)
	{
		if (array is null || arrayToCheck is null)
		{
			return false;
		}

		if (array.LongLength != arrayToCheck.LongLength)
		{
			return false;
		}

		return array.AsSpan().SequenceEqual(arrayToCheck);
	}

	/// <summary>
	/// Converts a array to <see cref="ReadOnlySpan{T}"/>.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="list">The list.</param>
	/// <returns>System.ReadOnlySpan&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AsReadOnlySpan), "David McCarter", "5/30/2023", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New, Documentation = "ADD URL")]
	public static ReadOnlySpan<T> AsReadOnlySpan<T>([NotNull] this T[] list) => new(list.ArgumentNotNull());

	/// <summary>
	/// Converts a array to <see cref="Span{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="list">The list.</param>
	/// <returns>System.Span&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AsSpan), "David McCarter", "6/3/2024", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New, Documentation = "ADD URL")]
	public static Span<T> AsSpan<T>([NotNull] this T[] list) => new(list.ArgumentNotNull());

	/// <summary>
	/// Returns a <see cref="string" /> that represents this instance. Uses <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// Validates that <paramref name="array" /> is not null.
	/// </summary>
	/// <param name="array">The bytes.</param>
	/// <returns>A <see cref="string" /> that represents this instance.</returns>
	/// <exception cref="ArgumentNullException">Array cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToString), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.NeedsDocumentation, OptimizationStatus = OptimizationStatus.Completed, Documentation = "ADD URL")]
	public static string BytesToString([NotNull] this byte[] array)
	{
		if (array.DoesNotHaveItems())
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			foreach (var arrayItem in array)
			{
				_ = sb.Append(arrayItem.ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}
	/// <summary>
	/// Converts byte array to a string using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// Validates that <paramref name="array" /> is not null.
	/// </summary>
	/// <param name="array">The array.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentNullException">array cannot be empty.</exception>
	[Information(nameof(BytesToString), "David McCarter", "6/24/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, Status = Status.NeedsDocumentation)]
	public static string BytesToString([NotNull] this ReadOnlySpan<byte> array)
	{
		array = array.ArgumentNotEmpty();

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var byteCount = 0; byteCount < array.Length; byteCount++)
			{
				_ = sb.Append(array[byteCount].ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Clones the specified array.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to clone.</param>
	/// <returns>A new array containing all the elements of the original array.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clone), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
	public static T[] Clone<T>([NotNull] this T[] array)
	{
		array = array.ArgumentNotNull();

		return (T[])array.Clone();
	}

	/// <summary>
	/// Determines whether the array contains any of the specified items.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to check.</param>
	/// <param name="items">The items to check for within the array.</param>
	/// <returns><c>true</c> if the array contains any of the specified items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> or <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Information(nameof(ContainsAny), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.NeedsDocumentation)]
	public static bool ContainsAny<T>([NotNull] this T[] array, [NotNull] params T[] items)
	{
		if (array is null || array.Length is 0 || items.Length is 0)
		{
			return false;
		}

		var itemsSet = new HashSet<T>(items);

		foreach (var element in array)
		{
			if (itemsSet.Contains(element))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Determines whether the specified array does not contain any items.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to check.</param>
	/// <returns><c>true</c> if the array is null or empty; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<T>([AllowNull] this T[] array) => array == null || array.Length == 0;

	/// <summary>
	/// Gets the total number of elements in the array.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to count.</param>
	/// <returns>The total number of elements in the array as a long.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastCount), "David McCarter", "1/9/2023", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
	public static long FastCount<T>([NotNull] this T[] array) => array.ArgumentNotNull().LongLength;

	/// <summary>
	/// Computes a fast SHA256 hash for the given byte array data.
	/// </summary>
	/// <param name="data">The byte array to compute the hash for.</param>
	/// <returns>A byte array containing the hash value.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="data"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastHashData), author: "David McCarter", createdOn: "3/11/2024", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "https://bit.ly/SpargineMay2024")]
	public static byte[] FastHashData([NotNull] this byte[] data)
	{
		if (data.DoesNotHaveItems())
		{
			return [];
		}

		return SHA256.HashData(data);
	}

	/// <summary>
	/// Processes each element in the array with the specified action.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to process.</param>
	/// <param name="action">The action to apply to each element of the array.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "11/8/2021", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static void FastProcessor<T>([NotNull] this T[] array, [NotNull] Action<T> action)
	{
		array = array.ArgumentNotNull();
		action = action.ArgumentNotNull();

		//Span, ImmutableArray and FrozenSet is slower.
		foreach (var item in array)
		{
			action(item);
		}
	}

	/// <summary>
	/// Generates a hash code for the entire array.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array for which to generate a hash code.</param>
	/// <returns>A hash code representing the contents of the array.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.NeedsDocumentation)]
	public static int GenerateHashCode<T>([NotNull] this T[] array) =>
		//RECOMENDATION FROM COPILOT SLOWER
		array.ArgumentNotNull().Where(t => t is not null).Aggregate(6551, (accumulator, t) => accumulator ^= (accumulator << 5) ^ EqualityComparer<T>.Default.GetHashCode(t));

	/// <summary>
	/// Determines whether the specified array has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <returns><c>true</c> if the specified array has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this T[] array)
	{
		if (array is null)
		{
			return false;
		}
		else
		{
			return array.Length > 0;
		}
	}
	/// <summary>
	/// Determines whether the specified values has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <param name="action">The values.</param>
	/// <returns><c>true</c> if the specified values has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this T[] array, [NotNull] Func<T, bool> action)
	{
		if (array is null || action is null)
		{
			return false;
		}
		else
		{
			return array.Any(action);
		}
	}
	/// <summary>
	/// Determines whether the specified count has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <param name="count">The count.</param>
	/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this T[] array, int count)
	{
		if (array is null)
		{
			return false;
		}
		else
		{
			return array.Length == count;
		}
	}

	/// <summary>
	/// Performs the specified action on each element of the array.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="values">The array of elements to perform the action on.</param>
	/// <param name="action">The action to perform on each element of the array.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="values"/> or <paramref name="action"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PerformAction), "David McCarter", "1/4/2023", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.WIP, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static void PerformAction<T>([NotNull] this T[] values, [NotNull] Action<T> action)
	{
		action = action.ArgumentNotNull();

		if (values.IsNullOrEmpty())
		{
			return;
		}

		if (values[0].GetTypeOfType() == TypeExtensions.TypeOfType.Record)
		{
			_ = Parallel.For(0, values.LongLength, (index) => action(values[index]));
		}
		else
		{
			//Span, ImmutableArray is slower.
			foreach (var value in values)
			{
				action(value);
			}
		}

	}

	/// <summary>
	/// Removes the first item in the array.
	/// Validates that <paramref name="array" /> is not null and contains items.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The array.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.WIP, Status = Status.NeedsDocumentation)]
	public static T[] RemoveFirst<T>([NotNull] this T[] array)
	{
		array = array.ArgumentItemsExists();

		return array.Skip(1).ToArray();
	}
	/// <summary>
	/// Removes the last.
	/// Validates that <paramref name="array" /> is not null and has items.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The array.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.WIP, Status = Status.NeedsDocumentation)]
	public static T[] RemoveLast<T>([NotNull] this T[] array)
	{
		array = array.ArgumentItemsExists();

		return array.SkipLast(1).ToArray();
	}
	/// <summary>
	/// Returns the array without duplicates.
	/// Validates that <paramref name="array" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToDistinct), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.NeedsDocumentation)]
	public static T[] ToDistinct<T>([NotNull] this T[] array) => array.ArgumentNotNull().Distinct().ToArray();

	/// <summary>
	/// Converts a array to <see cref="FrozenSet{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="list">The list.</param>
	/// <returns>System.Collections.Frozen.FrozenSet&lt;T&gt;.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New, Documentation = "ADD URL")]
	public static FrozenSet<T> ToFrozenSet<T>([NotNull] this T[] list) => FrozenSet.ToFrozenSet(list);

	/// <summary>
	/// Inserts or updates an item in the array. If the item already exists, it is updated; otherwise, it is added.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array.</typeparam>
	/// <param name="array">The array to upsert the item into.</param>
	/// <param name="item">The item to insert or update in the array.</param>
	/// <returns>A new array with the item inserted or updated.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021")]
	public static T[] Upsert<T>([NotNull] this T[] array, [NotNull] T item)
	{
		if (item is null || array.IsNullOrEmpty())
		{
			return array;
		}

		//Recomendation from CoPilot slower.
		if (array.Contains(item))
		{
			Array.Fill(array, item, array.IndexOf(item), 1);

			return array;
		}
		else
		{
			return array.AddLast(item);
		}
	}

	/// <summary>
	/// Inserts or updates an IDataRecord in the array. If the IDataRecord already exists (based on a specific criteria, e.g., ID), it is updated; otherwise, it is added to the array.
	/// </summary>
	/// <param name="array">The array of IDataRecord to upsert the item into.</param>
	/// <param name="item">The IDataRecord item to insert or update in the array.</param>
	/// <returns>A new array with the IDataRecord inserted or updated.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Upsert), author: "David McCarter", createdOn: "5/2/2021", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IDataRecord[] Upsert([NotNull] this IDataRecord[] array, [NotNull] IDataRecord item)
	{
		if (item is null)
		{
			return array;
		}

		array = array.ArgumentNotNull();

		if (array.FirstOrDefault(p => p.Id.Equals(item.Id, StringComparison.Ordinal)) is not null)
		{
			Array.Fill(array, item, array.IndexOf(item), 1);
		}
		else
		{
			_ = array.AddLast(item);
		}

		return [.. array];
	}

}
