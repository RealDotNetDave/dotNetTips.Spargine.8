// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-23-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-23-2025
// ***********************************************************************
// <copyright file="PersonEmailEqualityComparer.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Provides equality comparison for <see cref="Person{Address}"/> objects based on their email addresses.
/// </summary>
[Information(Status = Status.New)]
public sealed class PersonEmailEqualityComparer : IEqualityComparer<Person<Address>>
{
	/// <summary>
	/// Determines whether the specified <see cref="Person{Address}"/> objects are equal based on their email addresses.
	/// </summary>
	/// <param name="x">The first <see cref="Person{Address}"/> to compare.</param>
	/// <param name="y">The second <see cref="Person{Address}"/> to compare.</param>
	/// <returns><c>true</c> if the specified <see cref="Person{Address}"/> objects are equal; otherwise, <c>false</c>.</returns>
	public bool Equals(Person<Address> x, Person<Address> y)
	{
		if (x == null && y == null)
		{
			return true;
		}

		if (x == null || y == null)
		{
			return false;
		}

		return string.Equals(x.Email, y.Email, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Returns a hash code for the specified <see cref="Person{Address}"/> based on their email address.
	/// </summary>
	/// <param name="obj">The <see cref="Person{Address}"/> for which a hash code is to be returned.</param>
	/// <returns>A hash code for the specified <see cref="Person{Address}"/>.</returns>
	public int GetHashCode(Person<Address> obj)
	{
		return obj?.Email?.GetHashCode(StringComparison.OrdinalIgnoreCase) ?? 0;
	}
}
