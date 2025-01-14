// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-14-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-14-2025
// ***********************************************************************
// <copyright file="PersonAddressComparerByLastName.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Provides a comparison for <see cref="KeyValuePair{TKey, TValue}"/> objects where the value is a <see cref="Person{Address}"/>.
/// </summary>
[Information(Status = Status.New)]
public class PersonAddressComparerByLastName : IComparer<KeyValuePair<string, Person<Address>>>
{
	/// <summary>
	/// Compares two <see cref="KeyValuePair{TKey, TValue}"/> objects and returns a value indicating whether one is less than, equal to, or greater than the other.
	/// </summary>
	/// <param name="x">The first <see cref="KeyValuePair{TKey, TValue}"/> to compare.</param>
	/// <param name="y">The second <see cref="KeyValuePair{TKey, TValue}"/> to compare.</param>
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
	public int Compare(KeyValuePair<string, Person<Address>> x, KeyValuePair<string, Person<Address>> y)
	{
		return string.Compare(x.Value.LastName, y.Value.LastName, StringComparison.Ordinal);
	}
}
