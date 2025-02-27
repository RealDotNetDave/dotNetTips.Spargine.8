// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2024
// ***********************************************************************
// <copyright file="PersonComparer.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

/// <summary>
/// Class PersonProperComparer.
/// Implements the <see cref="IEqualityComparer{PersonProper}" />
/// </summary>
/// <seealso cref="IEqualityComparer{PersonProper}" />
[ExcludeFromCodeCoverage]
public class PersonComparer : IEqualityComparer<Person<Address>>
{

	/// <summary>
	/// Determines whether the specified objects are equal.
	/// </summary>
	/// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
	/// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
	/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	public bool Equals([AllowNull] Person<Address> x, [AllowNull] Person<Address> y) { return string.Compare(x.Id, y.Id, StringComparison.Ordinal) == 0; }

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public int GetHashCode([DisallowNull] Person<Address> obj) { return obj.Id.GetHashCode(); }

}

/// <summary>
/// Class PersonRecordComparer.
/// Implements the <see cref="IEqualityComparer{Models.RefTypes.PersonRecord}" />
/// </summary>
/// <seealso cref="IEqualityComparer{Models.RefTypes.PersonRecord}" />
[ExcludeFromCodeCoverage]
public class PersonRecordComparer : IEqualityComparer<PersonRecord>
{

	/// <summary>
	/// Determines whether the specified objects are equal.
	/// </summary>
	/// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
	/// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
	/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	public bool Equals([AllowNull] PersonRecord x, [AllowNull] PersonRecord y) { return string.Compare(x.Id, y.Id, StringComparison.Ordinal) == 0; }

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public int GetHashCode([DisallowNull] PersonRecord obj) { return obj.Id.GetHashCode(); }

}
