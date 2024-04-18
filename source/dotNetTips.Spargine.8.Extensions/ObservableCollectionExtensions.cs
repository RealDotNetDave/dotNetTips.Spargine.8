// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-12-2024
// ***********************************************************************
// <copyright file="ObservableCollectionExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for ObservableCollection.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class ObservableCollectionExtensions.
/// </summary>
public static class ObservableCollectionExtensions
{

	/// <summary>
	/// Determines whether the specified collection does not have items or is null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns><c>true</c> if the specified collection has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<T>([NotNull] this ObservableCollection<T> collection)
	{
		if (collection is null)
		{
			return false;
		}

		return collection.FastCount() <= 0;
	}

	/// <summary>
	/// Determines whether the specified collection has items.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns><c>true</c> if the specified collection has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this ObservableCollection<T> collection)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.FastCount() > 0;
		}
	}

	/// <summary>
	/// Determines whether the specified collection has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="action">The action.</param>
	/// <returns>bool.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this ObservableCollection<T> collection, [NotNull] Func<T, bool> action)
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
	/// Determines whether the specified count has items.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="count">The specific count.</param>
	/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([NotNull] this ObservableCollection<T> collection, int count)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.FastCount() == count;
		}
	}

}
