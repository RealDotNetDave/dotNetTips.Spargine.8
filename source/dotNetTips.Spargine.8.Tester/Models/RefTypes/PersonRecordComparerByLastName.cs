// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-15-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2025
// ***********************************************************************
// <copyright file="PersonRecordComparerByLastName.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Provides a comparer for <see cref="PersonRecord"/> objects that compares them by their last names.
/// </summary>
[Information(Status = Status.New)]
public class PersonRecordComparerByLastName : IComparer<PersonRecord>
{
	/// <summary>
	/// Compares two <see cref="PersonRecord"/> objects by their last names.
	/// </summary>
	/// <param name="x">The first <see cref="PersonRecord"/> to compare.</param>
	/// <param name="y">The second <see cref="PersonRecord"/> to compare.</param>
	/// <returns>
	/// A signed integer that indicates the relative values of <paramref name="x"/> and <paramref name="y"/>.
	/// Less than zero: <paramref name="x"/> is less than <paramref name="y"/>.
	/// Zero: <paramref name="x"/> equals <paramref name="y"/>.
	/// Greater than zero: <paramref name="x"/> is greater than <paramref name="y"/>.
	/// </returns>
	public int Compare(PersonRecord x, PersonRecord y)
	{
		return string.Compare(x?.LastName, y?.LastName, StringComparison.Ordinal);
	}
}
