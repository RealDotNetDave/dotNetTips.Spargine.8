// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-06-2024
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ReadOnlyCollection{T}"/>.
/// These methods include checks for item presence, generating hash codes, and performing actions on items within the collection.
/// </summary>
public static class ReadOnlyCollectionExtensions
{

	/// <summary>
	/// Checks collection for null and ensures there are items in the collection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<T>([NotNull] this ReadOnlyCollection<T> collection)
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
	/// Generates hash code for the collection.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list to use to generate hash code.</param>
	/// <returns>Hash code as System.Int32.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.WIP, Status = Status.Available)]
	public static int GenerateHashCode<T>([NotNull] this ReadOnlyCollection<T> collection)
	{
		collection = collection.ArgumentNotNull();

		var comparer = EqualityComparer<T>.Default;
		var hash = collection.Where(item => item is not null)
			.Aggregate(6551, (accumulator, t) => accumulator ^= (accumulator << 5) ^ comparer.GetHashCode(t));

		return hash;
	}

	/// <summary>
	/// Determines whether the specified list has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="action">The action.</param>
	/// <returns>bool.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([AllowNull] this ReadOnlyCollection<T> collection, [NotNull] Func<T, bool> action)
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

}
