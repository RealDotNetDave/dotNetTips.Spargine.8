// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 06-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2025
// ***********************************************************************
// <copyright file="SimpleResult.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Enables methods to return a value, a status, and exception information
// as needed. This comprehensive approach provides flexibility in
// handling various outcomes.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents extension methods for type <see cref="SimpleResult{T}" />.
/// </summary>
[Information(nameof(SimpleResult), author: "David McCarter", createdOn: "6/20/2023", Status = Status.NeedsDocumentation)]
public static class SimpleResult
{

	/// <summary>
	/// Creates a new instance of <see cref="SimpleResult{T}" /> from the specified exception.
	/// </summary>
	/// <typeparam name="T">The type of the value.</typeparam>
	/// <param name="e">The exception to be placed to the container.</param>
	/// <returns>The exception encapsulated by <see cref="SimpleResult{T}" />.</returns>
	[Information(nameof(SimpleResult), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static SimpleResult<T> FromException<T>([NotNull] Exception e) => new(e);

	/// <summary>
	/// Creates a new instance of <see cref="SimpleResult{T}" /> from the specified value.
	/// </summary>
	/// <typeparam name="T">The type of the value.</typeparam>
	/// <param name="value">The value to be placed to the container.</param>
	/// <returns>The value encapsulated by <see cref="SimpleResult{T}" />.</returns>
	[Information(nameof(SimpleResult), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static SimpleResult<T> FromValue<T>([NotNull] T value) => new(value);
}
