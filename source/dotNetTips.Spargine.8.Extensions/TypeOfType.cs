// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2025
// ***********************************************************************
// <copyright file="TypeOfType.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Defines the type categories for <see cref="Type"/> extensions.
/// </summary>
public enum TypeOfType
{
	/// <summary>
	/// Represents an unknown type category. This is used as a default value when the type category cannot be determined.
	/// </summary>
	Unknown,

	/// <summary>
	/// Represents a value type. Value types include any struct or enum types.
	/// </summary>
	Value,

	/// <summary>
	/// Represents a reference type. Reference types include classes, interfaces, delegates, and arrays.
	/// </summary>
	Reference,

	/// <summary>
	/// Represents a record type. Record types are reference types that provide built-in functionality for value-based equality.
	/// </summary>
	Record
}
