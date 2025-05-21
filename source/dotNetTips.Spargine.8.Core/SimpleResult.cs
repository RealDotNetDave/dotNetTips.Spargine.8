// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 06-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-04-2025
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
/// Provides factory methods for creating instances of <see cref="SimpleResult{T}" />.
/// These methods allow encapsulation of either a value or an exception in a result container,
/// enabling methods to return both success and error information in a consistent way.
/// </summary>
[Information(nameof(SimpleResult), author: "David McCarter", createdOn: "6/20/2023", Status = Status.NeedsDocumentation)]
public static class SimpleResult
{

	/// <summary>
	/// Creates a new instance of <see cref="SimpleResult{T}" /> that encapsulates the specified exception.
	/// </summary>
	/// <typeparam name="T">The type of the value that would be returned on success.</typeparam>
	/// <param name="e">The exception to encapsulate. Cannot be <see langword="null"/>.</param>
	/// <returns>
	/// A <see cref="SimpleResult{T}"/> representing a failed result containing the specified exception.
	/// </returns>
	[Information(nameof(SimpleResult), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static SimpleResult<T> FromException<T>([NotNull] Exception e) => new(e);

	/// <summary>
	/// Creates a new instance of <see cref="SimpleResult{T}" /> that encapsulates the specified value.
	/// </summary>
	/// <typeparam name="T">The type of the value to encapsulate.</typeparam>
	/// <param name="value">The value to encapsulate. Cannot be <see langword="null"/>.</param>
	/// <returns>
	/// A <see cref="SimpleResult{T}"/> representing a successful result containing the specified value.
	/// </returns>
	[Information(nameof(SimpleResult), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static SimpleResult<T> FromValue<T>([NotNull] T value) => new(value);
}
