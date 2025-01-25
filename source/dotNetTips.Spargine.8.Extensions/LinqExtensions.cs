// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 08-18-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-25-2025
// ***********************************************************************
// <copyright file="LinqExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for LINQ.</summary>
// ***********************************************************************
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for LINQ to enhance its functionality and usability.
/// These methods include conditional transformations on <see cref="IQueryable{T}"/> and <see cref="IEnumerable{T}"/>,
/// allowing for more expressive and dynamic query composition.
/// </summary>
[Information(nameof(LinqExtensions), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, Documentation = "https://bit.ly/SpargineListExtensions")]
public static class LinqExtensions
{

	/// <summary>
	/// Conditionally applies a series of transformations to the input <see cref="IQueryable{T}"/> based on a boolean condition.
	/// This allows for dynamic query composition by including or excluding parts of the query based on the specified condition.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <see cref="IQueryable{T}"/>.</typeparam>
	/// <param name="input">The input query to transform.</param>
	/// <param name="should">A boolean value indicating whether the transformations should be applied.</param>
	/// <param name="transformsFunction">A params array of functions that represent the transformations to apply to the input query.</param>
	/// <returns>An <see cref="IQueryable{T}"/> that has been conditionally transformed based on the provided functions.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> or <paramref name="transformsFunction"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine", "David McCarter", "8/18/20", ModifiedBy = "David McCarter", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IQueryable<T> If<T>(this IQueryable<T> input, bool should, params Func<IQueryable<T>, IQueryable<T>>[] transformsFunction)
	{
		input = input.ArgumentNotNull();
		transformsFunction = transformsFunction.ArgumentItemsExists();

		return should ? transformsFunction.Aggregate(input, (current, transform) => transform(current)) : input;
	}

	/// <summary>
	/// Conditionally applies a series of transformations to the input <see cref="IEnumerable{T}"/> based on a boolean condition.
	/// This allows for dynamic query composition by including or excluding parts of the query based on the specified condition.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <see cref="IEnumerable{T}"/>.</typeparam>
	/// <param name="input">The input sequence to transform.</param>
	/// <param name="should">A boolean value indicating whether the transformations should be applied.</param>
	/// <param name="transformsFunction">A params array of functions that represent the transformations to apply to the input sequence.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that has been conditionally transformed based on the provided functions.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> or <paramref name="transformsFunction"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine", "David McCarter", "8/18/20", ModifiedBy = "David McCarter", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> If<T>(this IEnumerable<T> input, bool should, params Func<IEnumerable<T>, IEnumerable<T>>[] transformsFunction)
	{
		input = input.ArgumentNotNull();
		transformsFunction = transformsFunction.ArgumentItemsExists();

		return should ? transformsFunction.Aggregate(input, (current, transform) => transform(current)) : input;
	}

}
