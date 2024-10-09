// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-09-2024
// ***********************************************************************
// <copyright file="ReadOnlySpanExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for ReadOnlySpan.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ReadOnlySpan{T}"/>.
/// These methods include operations that are not provided by the framework but are commonly used.
/// </summary>
public static class ReadOnlySpanExtensions
{

	/// <summary>
	/// Picks a random item from the specified <see cref="ReadOnlySpan{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the span.</typeparam>
	/// <param name="span">The span from which to pick a random item. Must not be empty.</param>
	/// <returns>A single item of type <typeparamref name="T"/> randomly picked from the span.</returns>
	/// <exception cref="ArgumentException">Thrown if <paramref name="span"/> is empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNull]
	[Information(nameof(PickRandom), "David McCarter", "6/28/2021", BenchMarkStatus = BenchMarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T PickRandom<T>([NotNull] this ReadOnlySpan<T> span)
	{
		span = span.ArgumentNotEmpty();

		return span[RandomNumberGenerator.GetInt32(0, span.Length - 1)];
	}

}
