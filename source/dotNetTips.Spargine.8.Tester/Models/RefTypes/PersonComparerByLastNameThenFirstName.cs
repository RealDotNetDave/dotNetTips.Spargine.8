// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2025
// ***********************************************************************
// <copyright file="PersonComparerByLastNameThenFirstName.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Provides a comparison for <see cref="Person{Address}"/> objects based on their last names and then first names.
/// </summary>
[Information(Status = Status.Available)]
public sealed class PersonComparerByLastNameThenFirstName : IComparer<Person<Address>>
{
	/// <summary>
	/// Compares two <see cref="Person{Address}"/> objects and returns a value indicating whether one is less than, equal to, or greater than the other.
	/// </summary>
	/// <param name="x">The first <see cref="Person{Address}"/> to compare.</param>
	/// <param name="y">The second <see cref="Person{Address}"/> to compare.</param>
	/// <returns>
	/// A signed integer that indicates the relative values of <paramref name="x"/> and <paramref name="y"/>:
	/// <list type="bullet">
	/// <item>
	/// <description>Less than zero: <paramref name="x"/> is less than <paramref name="y"/>.</description>
	/// </item>
	/// <item>
	/// <description>Zero: <paramref name="x"/> equals <paramref name="y"/>.</description>
	/// </item>
	/// <item>
	/// <description>Greater than zero: <paramref name="x"/> is greater than <paramref name="y"/>.</description>
	/// </item>
	/// </list>
	/// </returns>
	public int Compare(Person<Address> x, Person<Address> y)
	{
		var lastNameComparison = string.Compare(x?.LastName ?? string.Empty, y?.LastName ?? string.Empty, StringComparison.Ordinal);

		return lastNameComparison != 0
			? lastNameComparison
			: string.Compare(x?.FirstName ?? string.Empty, y?.FirstName ?? string.Empty, StringComparison.Ordinal);
	}
}
