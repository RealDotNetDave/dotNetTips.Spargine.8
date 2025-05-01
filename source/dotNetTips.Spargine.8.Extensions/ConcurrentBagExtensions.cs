// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 02-24-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2025
// ***********************************************************************
// <copyright file="ConcurrentBagExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Concurrent;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ConcurrentBag{T}"/>.
/// </summary>
[Information(Status = Status.Available)]
public static class ConcurrentBagExtensions
{

	/// <summary>
	/// Adds a range of items to the <see cref="ConcurrentBag{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the bag.</typeparam>
	/// <param name="bag">The <see cref="ConcurrentBag{T}"/> to which to add items. Must not be null.</param>
	/// <param name="items">The items to add to the bag. Must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="bag"/> or <paramref name="items"/> is null.</exception>
	[Information(nameof(AddRange), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void AddRange<T>(this ConcurrentBag<T> bag, in IEnumerable<T> items)
	{
		bag = bag.ArgumentNotNull();
		_ = items.ArgumentNotNull();

		foreach (var item in items)
		{
			bag.Add(item);
		}
	}

	/// <summary>
	/// Removes the specified items from the <see cref="ConcurrentBag{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the bag.</typeparam>
	/// <param name="bag">The <see cref="ConcurrentBag{T}"/> from which to remove items. Must not be null.</param>
	/// <param name="items">The items to remove from the bag. Must not be null.</param>
	/// <returns>A new <see cref="ConcurrentBag{T}"/> with the specified items removed.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="bag"/> or <paramref name="items"/> is null.</exception>
	[Information(nameof(RemoveRange), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ConcurrentBag<T> RemoveRange<T>(this ConcurrentBag<T> bag, IEnumerable<T> items)
	{
		bag = bag.ArgumentNotNull();
		items = items.ArgumentNotNull();

		var tempBag = new ConcurrentBag<T>();

		_ = Parallel.ForEach(bag, item =>
		{
			if (!items.Contains(item))
			{
				tempBag.Add(item);
			}
		});

		return tempBag;
	}

	/// <summary>
	/// Converts the <see cref="ConcurrentBag{T}"/> to a <see cref="List{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the bag.</typeparam>
	/// <param name="bag">The <see cref="ConcurrentBag{T}"/> to convert. Must not be null.</param>
	/// <returns>A <see cref="List{T}"/> containing the elements of the bag.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="bag"/> is null.</exception>
	[Information(nameof(ToList), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static List<T> ToList<T>(this ConcurrentBag<T> bag)
	{
		bag = bag.ArgumentNotNull();

		return [.. bag];
	}
}
