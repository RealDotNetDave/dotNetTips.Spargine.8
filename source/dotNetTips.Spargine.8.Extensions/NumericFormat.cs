// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-27-2024
// ***********************************************************************
// <copyright file="NumericFormat.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Class that provides common formats for numbers.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class NumericFormat.
/// Implements the <see cref="Enumeration" />
/// </summary>
/// <seealso cref="Enumeration" />
public class NumericFormat : Enumeration
{
	/// <summary>  
	/// Initializes a new instance of the <see cref="NumericFormat"/> class.  
	/// </summary>
	[ExcludeFromCodeCoverage]
	private NumericFormat() { }

	/// <summary>
	/// Initializes a new instance of the <see cref="NumericFormat" /> class.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="displayName">The display name.</param>
	private NumericFormat(int value, string displayName) : base(value, displayName) { }

	/// <summary>
	/// Custom format. Example: $2,147,483,647.00
	/// </summary>
	public static readonly NumericFormat Currency = new(0, "C");

	/// <summary>
	/// Custom format. Example: 2147483647
	/// </summary>
	public static readonly NumericFormat Decimal = new(1, "D");

	/// <summary>
	/// Custom format. Example: 2.147484E+009
	/// </summary>
	public static readonly NumericFormat Exponential = new(2, "E");

	/// <summary>
	/// Custom format. Example: 2147483647.00
	/// </summary>
	public static readonly NumericFormat FixedPoint = new(3, "F");

	/// <summary>
	/// Custom format. Example: 2147483647
	/// </summary>
	public static readonly NumericFormat General = new(4, "G");

	/// <summary>
	/// Custom format. Example: 7FFFFFFF
	/// </summary>
	public static readonly NumericFormat Hexadecimal = new(5, "X");

	/// <summary>
	/// Custom format. Example: 2,147,483,647.00
	/// </summary>
	public static readonly NumericFormat Number = new(6, "N");

	/// <summary>
	/// Custom format. Example: 214,748,364,700.00%
	/// </summary>
	public static readonly NumericFormat Percent = new(7, "P");

	/// <summary>
	/// Custom format. Example:  8.988465674311579E+307
	/// </summary>
	public static readonly NumericFormat RoundTrip = new(8, "R");

}
