// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="DataRecordComparer.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Comparer to be used in DataRecord.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a comparer for comparing two <see cref="IDataRecord"/> instances.
/// </summary>
/// <remarks>
/// This comparer uses the ID property of the <see cref="IDataRecord"/> to determine equality.
/// </remarks>
public sealed class DataRecordComparer : IEqualityComparer<IDataRecord>
{

	/// <summary>
	/// Determines whether the specified <see cref="IDataRecord"/> instances are equal.
	/// </summary>
	/// <param name="x">The first <see cref="IDataRecord"/> instance to compare.</param>
	/// <param name="y">The second <see cref="IDataRecord"/> instance to compare.</param>
	/// <returns><c>true</c> if the specified <see cref="IDataRecord"/> instances are equal; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// Equality is determined by comparing the ID property of each <see cref="IDataRecord"/>.
	/// </remarks>
	public bool Equals([AllowNull] IDataRecord x, [AllowNull] IDataRecord y) => string.Equals(x?.Id, y?.Id, StringComparison.Ordinal);

	/// <summary>
	/// Returns a hash code for the specified <see cref="IDataRecord"/>.
	/// </summary>
	/// <param name="obj">The <see cref="IDataRecord"/> for which a hash code is to be returned.</param>
	/// <returns>A hash code for the specified <see cref="IDataRecord"/>, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the <paramref name="obj"/> is null.</exception>
	public int GetHashCode([DisallowNull] IDataRecord obj) => string.GetHashCode(obj.ArgumentNotNull().Id, StringComparison.Ordinal);

}
