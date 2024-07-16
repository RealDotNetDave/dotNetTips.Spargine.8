// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-13-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2024
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
/// Represents a prefix and its associated length.
/// </summary>
[DebuggerDisplay("{Prefix,nq}")]
internal struct PrefixAndLength : IEquatable<PrefixAndLength>
{

	/// <summary>
	/// Initializes a new instance of the <see cref="PrefixAndLength"/> struct.
	/// </summary>
	/// <param name="prefix">The prefix.</param>
	/// <param name="length">The length.</param>
	public PrefixAndLength(string prefix, int length)
	{
		Prefix = prefix;
		Length = length;
	}

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
	/// Determines whether the specified object is equal to the current object.
	/// </summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
	public override readonly bool Equals(object obj) => obj is PrefixAndLength other && Equals(other);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
	public readonly bool Equals(PrefixAndLength other) => this.Prefix == other.Prefix && this.Length == other.Length;

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public override readonly int GetHashCode() => HashCode.Combine(Prefix, Length);

	/// <summary>
	/// Returns a string that represents this instance.
	/// </summary>
	/// <returns>A string that represents this instance.</returns>
	public override readonly string ToString() => $"{Prefix}, {Length}";

	/// <summary>
	/// Gets or sets the length.
	/// </summary>
	/// <value>The length.</value>
	public int Length { get; set; }

	/// <summary>
	/// Gets or sets the prefix.
	/// </summary>
	/// <value>The prefix.</value>
	public string Prefix { get; set; }

}
