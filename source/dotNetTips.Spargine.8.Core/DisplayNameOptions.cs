// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-11-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-11-2025
// ***********************************************************************
// <copyright file="DisplayNameOptions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents options for displaying type names.
/// </summary>
/// <param name=
/// "fullName">If true, the full name of the type is used; otherwise, the short name is used.</param>
/// <param name="includeGenericParameterNames">If true, includes the names of generic parameters.</param>
/// <param name="includeGenericParameters">If true, includes generic parameters in the display name.</param>
/// <param name="nestedTypeDelimiter">The delimiter to use for nested types.</param>
[Information(Status = Status.Available)]
public readonly struct DisplayNameOptions(bool fullName, bool includeGenericParameterNames, bool includeGenericParameters, char nestedTypeDelimiter = ControlChars.Plus) : IEquatable<DisplayNameOptions>
{

	/// <summary>
	/// Determines whether two <see cref="DisplayNameOptions"/> instances are not equal.
	/// </summary>
	/// <param name="left">The first <see cref="DisplayNameOptions"/> instance to compare.</param>
	/// <param name="right">The second <see cref="DisplayNameOptions"/> instance to compare.</param>
	/// <returns><c>true</c> if the specified <see cref="DisplayNameOptions"/> instances are not equal; otherwise, <c>false</c>.</returns>
	public static bool operator !=(DisplayNameOptions left, DisplayNameOptions right) => !(left == right);

	/// <summary>
	/// Determines whether two <see cref="DisplayNameOptions"/> instances are equal.
	/// </summary>
	/// <param name="left">The first <see cref="DisplayNameOptions"/> instance to compare.</param>
	/// <param name="right">The second <see cref="DisplayNameOptions"/> instance to compare.</param>
	/// <returns><c>true</c> if the specified <see cref="DisplayNameOptions"/> instances are equal; otherwise, <c>false</c>.</returns>
	public static bool operator ==(DisplayNameOptions left, DisplayNameOptions right) => left.Equals(right);

	/// <summary>
	/// Determines whether the specified object is equal to the current object.
	/// </summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
	public override bool Equals([NotNullWhen(true)] object obj) => base.Equals(obj);

	/// <summary>
	/// Determines whether the specified <see cref="DisplayNameOptions"/> instance is equal to the current instance.
	/// </summary>
	/// <param name="other">The <see cref="DisplayNameOptions"/> instance to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified <see cref="DisplayNameOptions"/> instance is equal to the current instance; otherwise, <c>false</c>.</returns>
	public bool Equals(DisplayNameOptions other) => this.FullName == other.FullName &&
			   this.IncludeGenericParameterNames == other.IncludeGenericParameterNames &&
			   this.IncludeGenericParameters == other.IncludeGenericParameters &&
			   this.NestedTypeDelimiter == other.NestedTypeDelimiter;

	/// <summary>
	/// Returns the hash code for the current object.
	/// </summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode() => base.GetHashCode();
	/// <summary>
	/// Returns a string that represents the current object.
	/// </summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString() => base.ToString();

	/// <summary>
	/// Gets a value indicating whether the full name of the type is used.
	/// </summary>
	public bool FullName { get; } = fullName;

	/// <summary>
	/// Gets a value indicating whether the names of generic parameters are included in the type's display name.
	/// </summary>
	public bool IncludeGenericParameterNames { get; } = includeGenericParameterNames;

	/// <summary>
	/// Gets a value indicating whether generic parameters are included in the type's display name.
	/// </summary>
	public bool IncludeGenericParameters { get; } = includeGenericParameters;

	/// <summary>
	/// Gets the delimiter used for nested types in the type's display name.
	/// </summary>
	public char NestedTypeDelimiter { get; } = nestedTypeDelimiter;
}

