// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-13-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-19-2024
// ***********************************************************************
// <copyright file="PrefixAndLength.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class for representing a prefix and length.</summary>
// ***********************************************************************

using System.Diagnostics;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester;
/// <summary>
/// Struct PrefixAndLength
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="PrefixAndLength" /> struct.
/// </remarks>
/// <param name="prefix">The prefix.</param>
/// <param name="length">The length.</param>
[DebuggerDisplay("Prefix")]
internal struct PrefixAndLength(string prefix, int length) : IEquatable<PrefixAndLength>
{

	/// <summary>
	/// Implements the != operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !=(PrefixAndLength left, PrefixAndLength right) => !(left == right);

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(PrefixAndLength left, PrefixAndLength right) => left.Equals(right);

	/// <summary>
	/// Determines whether the specified <see cref="object" /> is equal to this instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
	public override readonly bool Equals(object obj) => base.Equals(obj);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public readonly bool Equals(PrefixAndLength other) => this == other;

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public override readonly int GetHashCode() => base.GetHashCode();

	/// <summary>
	/// Returns a <see cref="string" /> that represents this instance.
	/// </summary>
	/// <returns>A <see cref="string" /> that represents this instance.</returns>
	public override readonly string ToString() => base.ToString();

	/// <summary>
	/// Gets or sets the length.
	/// </summary>
	/// <value>The length.</value>
	public int Length { get; set; } = length;
	/// <summary>
	/// Gets or sets the prefix.
	/// </summary>
	/// <value>The prefix.</value>
	public string Prefix { get; set; } = prefix;

}
