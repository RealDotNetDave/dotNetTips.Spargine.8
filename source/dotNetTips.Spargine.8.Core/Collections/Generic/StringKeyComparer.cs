// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-14-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-14-2025
// ***********************************************************************
// <copyright file="StringKeyComparer.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// Provides a comparison for <see cref="string"/> objects using ordinal comparison.
/// </summary>
[Information(Status = Status.New)]
public class OrdinalStringComparer : IComparer<string>
{
	/// <summary>
	/// Compares two <see cref="string"/> objects and returns a value indicating whether one is less than, equal to, or greater than the other.
	/// </summary>
	/// <param name="x">The first <see cref="string"/> to compare.</param>
	/// <param name="y">The second <see cref="string"/> to compare.</param>
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
	public int Compare(string x, string y)
	{
		return string.Compare(x, y, StringComparison.Ordinal);
	}
}
