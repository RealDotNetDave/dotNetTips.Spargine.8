// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-23-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2025
// ***********************************************************************
// <copyright file="PersonRecordEmailEqualityComparer.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Provides equality comparison for <see cref="PersonRecord"/> objects based on the email address.
/// </summary>
[Information(Status = Status.Available)]
public sealed class PersonRecordEmailEqualityComparer : IEqualityComparer<PersonRecord>
{
	/// <summary>
	/// Determines whether the specified <see cref="PersonRecord"/> objects are equal based on their email addresses.
	/// </summary>
	/// <param name="x">The first <see cref="PersonRecord"/> to compare.</param>
	/// <param name="y">The second <see cref="PersonRecord"/> to compare.</param>
	/// <returns><c>true</c> if the specified <see cref="PersonRecord"/> objects are equal; otherwise, <c>false</c>.</returns>
	public bool Equals(PersonRecord x, PersonRecord y)
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
	/// Returns a hash code for the specified <see cref="PersonRecord"/> based on their email address.
	/// </summary>
	/// <param name="obj">The <see cref="PersonRecord"/> for which a hash code is to be returned.</param>
	/// <returns>A hash code for the specified <see cref="PersonRecord"/>.</returns>
	public int GetHashCode(PersonRecord obj) => obj?.Email?.GetHashCode(StringComparison.OrdinalIgnoreCase) ?? 0;
}
