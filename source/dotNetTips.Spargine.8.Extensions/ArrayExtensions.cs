// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2024
// ***********************************************************************
// <copyright file="ArrayExtensions.cs" company="dotNetTips.Spargine.8.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extensions methods for the Array type.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extensions methods for the Array type.
/// </summary>
public static class ArrayExtensions
{

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Adds a single item to the beginning of the array.
	/// Validates that <paramref name="array" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The array.</param>
	/// <param name="item">The item.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static T[] AddFirst<T>([NotNull] this T[] array, [NotNull] T item)
	{
		if (item is null)
		{
			return array;
		}

		array = array.ArgumentNotNull();

		var result = new List<T>(array);

		return [.. result.AddFirst(item)];
	}

	/// <summary>
	/// Adds item to the array if the condition is meet.
	/// Validates that <paramref name="array" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <param name="item">The item.</param>
	/// <param name="condition">if set to <c>true</c> [condition].</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[Information(nameof(AddIf), author: "David McCarter", createdOn: "4/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
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
	/// Adds item to the end of the array.
	/// Validates that <paramref name="array" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The array.</param>
	/// <param name="item">The item.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static T[] AddLast<T>([NotNull] this T[] array, [NotNull] T item)
	{
		if (item is null)
		{
			return array;
		}

		array = array.ArgumentNotNull();

		Array.Resize(ref array, array.Length + 1);

		array[^1] = item;

		return array;
	}

	/// <summary>
	/// Checks if the two arrays are equal.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The input.</param>
	/// <param name="arrayToCheck">The array to check.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(AreEqual), author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static bool AreEqual<T>([NotNull] this T[] array, [NotNull] T[] arrayToCheck)
	{
		if (array is null || arrayToCheck is null)
		{
			return false;
		}

		if (array.Length != arrayToCheck.Length)
		{
			return false;
		}

		return array.AsSpan().SequenceEqual(arrayToCheck);
	}

	/// <summary>
	/// Returns a <see cref="string" /> that represents this instance. Uses <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// Validates that <paramref name="array" /> is not null.
	/// </summary>
	/// <param name="array">The bytes.</param>
	/// <returns>A <see cref="string" /> that represents this instance.</returns>
	/// <exception cref="ArgumentNullException">Array cannot be null.</exception>
	[Information(nameof(BytesToString), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static string BytesToString([NotNull] this byte[] array)
	{
		if (array.DoesNotHaveItems())
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var byteIndex = 0; byteIndex < array.Length; byteIndex++)
			{
				_ = sb.Append(array[byteIndex].ToString("x2", CultureInfo.InvariantCulture));
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
	[Information(nameof(BytesToString), "David McCarter", "6/24/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
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
	/// Validates that <paramref name="array" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The input.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static T[] Clone<T>([NotNull] this T[] array)
	{
		array = array.ArgumentNotNull();

		return [.. array];
	}

	/// <summary>
	/// Determines whether the specified array has items specified.
	/// Validates that <paramref name="array" /> and <paramref name="items" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The source.</param>
	/// <param name="items">The items.</param>
	/// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">items cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsAny<T>([NotNull] this T[] array, [NotNull] params T[] items)
	{
		if (array is null)
		{
			return false;
		}

		if (items.ArgumentNotNull().FastCount() == 0)
		{
			return false;
		}

		var itemsList = items.ToReadOnlyCollection();

		return itemsList.HasItems() && array.ToReadOnlyCollection().Any(itemsList.Contains);
	}

	/// <summary>
	/// Ensures there are items no items in the array.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<T>([AllowNull] this T[] array)
	{
		if (array is null)
		{
			return true;
		}
		else
		{
			return array.Count() <= 0;
		}
	}

	/// <summary>
	/// Counts items in the array.
	/// Validates that <paramref name="array" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The list.</param>
	/// <returns>System.Int64.</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastCount), "David McCarter", "1/9/2023", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static long FastCount<T>([NotNull] this T[] array) => array.ArgumentNotNull().LongLength;

	/// <summary>
	/// Processes the array with the specified values.
	/// Validates that <paramref name="array" /> and <paramref name="action" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <param name="action">The values.</param>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	/// <exception cref="ArgumentNullException">action cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "11/8/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static void FastProcessor<T>([NotNull] this T[] array, [NotNull] Action<T> action)
	{
		array = array.ArgumentNotNull();
		action = action.ArgumentNotNull();

		var collection = new ReadOnlySpan<T>(array);

		for (var itemCount = 0; itemCount < collection.Length; itemCount++)
		{
			action(collection[itemCount]);
		}
	}

	/// <summary>
	/// Generates hash code for the array.
	/// Validates that <paramref name="array" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="array">The array to use to generate hash code.</param>
	/// <returns>Hash code as System.Int32.</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static int GenerateHashCode<T>([NotNull] this T[] array) => array.ArgumentNotNull().Where(t => t is not null).Aggregate(6551, (accumulator, t) => accumulator ^= (accumulator << 5) ^ EqualityComparer<T>.Default.GetHashCode(t));

	/// <summary>
	/// Determines whether the specified array has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <returns><c>true</c> if the specified array has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this T[] array)
	{
		if (array is null)
		{
			return false;
		}
		else
		{
			return array.Count() > 0;
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
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
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
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this T[] array, int count)
	{
		if (array is null)
		{
			return false;
		}
		else
		{
			return array.Count() == count;
		}
	}

	/// <summary>
	/// Performs the action for the items in the array.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="values">The values.</param>
	/// <param name="action">The action.</param>
	/// <exception cref="ArgumentNullException">action cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PerformAction), "David McCarter", "1/4/2023", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static void PerformAction<T>([NotNull] this T[] values, [NotNull] Action<T> action)
	{
		action = action.ArgumentNotNull();

		if (values.IsNullOrEmpty())
		{
			return;
		}

		var typeOfType = values.First().GetTypeOfType();

		if (typeOfType == TypeExtensions.TypeOfType.Record)
		{
			_ = Parallel.For(0, values.Length, (index) => action(values[index]));
		}
		else
		{
			for (var index = 0; index < values.LongLength; index++)
			{
				action(values[index]);
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
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
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
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
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
	[Information(nameof(ToDistinct), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static T[] ToDistinct<T>([NotNull] this T[] array) => array.ArgumentNotNull().Distinct().ToArray();

	/// <summary>
	/// Upserts (add or insert) the specified item.
	/// Validates that <paramref name="array" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="array">The array.</param>
	/// <param name="item">The item.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static T[] Upsert<T>([NotNull] this T[] array, [NotNull] T item)
	{
		if (item is null)
		{
			return array;
		}

		array = array.ArgumentNotNull();

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
	/// Upserts the specified array.
	/// Validates that <paramref name="array" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <param name="array">The array.</param>
	/// <param name="item">The item.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">array cannot be null.</exception>
	[Information(nameof(Upsert), author: "David McCarter", createdOn: "5/2/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
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