// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2025
// ***********************************************************************
// <copyright file="ReadOnlyCollectionExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for ReadOnlyCollection.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ReadOnlyCollection{T}"/>.
/// These methods include checks for item presence, generating hash codes, and performing actions on items within the collection.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class ReadOnlyCollectionExtensions
{

	/// <summary>
	/// Checks collection for null and ensures there are items in the collection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<T>([NotNull] this ReadOnlyCollection<T> collection) => collection is null ? true : collection.Count <= 0;

	/// <summary>
	/// Generates a hash code for the <see cref="ReadOnlyCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection for which to generate a hash code.</param>
	/// <returns>A hash code for the collection, considering the hash codes of individual elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <remarks>
	/// This method computes the hash code by aggregating the hash codes of the elements in the collection.
	/// It ensures that the collection is not null before proceeding with the computation.
	/// </remarks>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static int GenerateHashCode<T>([NotNull] this ReadOnlyCollection<T> collection)
	{
		collection = collection.ArgumentNotNull();

		var comparer = EqualityComparer<T>.Default;
		var hash = 6551;

		foreach (var item in collection)
		{
			if (item is not null)
			{
				hash ^= (hash << 5) ^ comparer.GetHashCode(item);
			}
		}

		return hash;
	}

	/// <summary>
	/// Determines whether the specified list has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="actionPredicate">The actionPredicate.</param>
	/// <returns>bool.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([AllowNull] this ReadOnlyCollection<T> collection, [NotNull] Func<T, bool> actionPredicate) => collection is null || actionPredicate is null ? false : collection.Any(actionPredicate);

}
