// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-06-2024
// ***********************************************************************
// <copyright file="ReadOnlySpanExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for ReadOnlySpan.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ReadOnlySpan{T}"/>.
/// These methods include operations that are not provided by the framework but are commonly used.
/// </summary>
public static class ReadOnlySpanExtensions
{

	/// <summary>
	/// Picks a random item from a <see cref="ReadOnlySpan{T}" />.
	/// Validates that the <paramref name="span"/> is not empty before selecting a random item.
	/// </summary>
	/// <typeparam name="T">The type of elements in the span.</typeparam>
	/// <param name="span">The span from which to pick a random item.</param>
	/// <returns>A single item from the span as a new <see cref="ReadOnlySpan{T}"/> of length 1.</returns>
	/// <exception cref="ArgumentException">Thrown when the <paramref name="span"/> is empty.</exception>	[return: NotNull]
	[Information(nameof(PickRandom), "David McCarter", "6/28/2021", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestStatus = UnitTestStatus.None)]
	public static ReadOnlySpan<T> PickRandom<T>([NotNull] this ReadOnlySpan<T> span)
	{
		span = span.ArgumentNotEmpty();

		var index = RandomNumberGenerator.GetInt32(0, span.Length - 1);

		return span[index..];
	}

}
