// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-25-2025
// ***********************************************************************
// <copyright file="ImmutableArrayExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the ImmutableArray.</summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ImmutableArray{T}"/> to enhance usability and functionality.
/// These methods include checks for item presence, conditional actions, count comparisons, and item shuffling.
/// </summary>
public static class ImmutableArrayExtensions
{

	/// <summary>
	/// Checks if the <see cref="ImmutableArray{T}"/> contains any elements.
	/// </summary>
	/// <typeparam name="T">The type of elements in the array.</typeparam>
	/// <param name="collection">The immutable array to check.</param>
	/// <returns><c>true</c> if the array contains one or more elements; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>(this ImmutableArray<T> collection)
	{
		if (collection.ArgumentNotNull().IsEmpty)
		{
			return false;
		}
		else
		{
			return collection.Length > 0;
		}
	}

	/// <summary>
	/// Determines whether the <see cref="ImmutableArray{T}"/> contains any elements that match the condition defined by the specified predicate.
	/// </summary>
	/// <typeparam name="T">The type of elements in the array.</typeparam>
	/// <param name="list">The immutable array to check.</param>
	/// <param name="actionPredicate">The predicate that defines the conditions of the elements to search for.</param>
	/// <returns><c>true</c> if one or more elements in the <see cref="ImmutableArray{T}"/> match the condition defined by the specified predicate; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="list"/> or <paramref name="actionPredicate"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>(this ImmutableArray<T> list, Func<T, bool> actionPredicate)
	{
		if (list.ArgumentNotNull().IsEmpty || actionPredicate is null)
		{
			return false;
		}
		else
		{
			return list.Any(actionPredicate);
		}
	}

	/// <summary>
	/// Determines whether the <see cref="ImmutableArray{T}"/> has exactly the specified number of items.
	/// </summary>
	/// <typeparam name="T">The type of elements in the array.</typeparam>
	/// <param name="list">The immutable array to check.</param>
	/// <param name="count">The number of items to match.</param>
	/// <returns><c>true</c> if the array contains exactly <paramref name="count"/> items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="list"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>(this ImmutableArray<T> list, int count)
	{
		if (list.ArgumentNotNull().IsEmpty)
		{
			return false;
		}
		else
		{
			return list.Length == count;
		}
	}

	/// <summary>
	/// Shuffles the elements of the specified <see cref="ImmutableArray{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the array.</typeparam>
	/// <param name="list">The immutable array to shuffle.</param>
	/// <returns>A new <see cref="ImmutableArray{T}"/> with elements in random order.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="list"/> is null.</exception>
	/// <remarks>
	/// This method generates a sequence of random indices using <see cref="RandomNumberGenerator"/> to shuffle the array elements.
	/// If the array does not contain any items, it is returned unchanged.
	/// </remarks>
	[Information(nameof(Shuffle), "David McCarter", "8/27/2020", "1/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ImmutableArray<T> Shuffle<T>(this ImmutableArray<T> list) => list.DoesNotHaveItems() ? list : [.. list.OrderBy(_ => RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue))];

}
