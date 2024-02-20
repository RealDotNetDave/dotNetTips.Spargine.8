// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-17-2024
// ***********************************************************************
// <copyright file="PersonComparer.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests;

/// <summary>
/// Class PersonComparer.
/// Implements the <see cref="IEqualityComparer{Person{Address}}" />
/// </summary>
/// <seealso cref="IEqualityComparer{Person{Address}}" />
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
	public int GetHashCode([DisallowNull] Person<Address> obj) => obj.Id.GetHashCode();

}
