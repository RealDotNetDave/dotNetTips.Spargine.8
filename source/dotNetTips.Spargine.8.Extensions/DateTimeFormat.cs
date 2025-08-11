// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-28-2025
// ***********************************************************************
// <copyright file="DateTimeFormat.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Class that offers common date and time formats.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a set of common date and time formats as strongly-typed enumeration instances.
/// </summary>
/// <remarks>
/// This class extends <see cref="Enumeration"/> to offer reusable, self-documenting date and time format patterns.
/// </remarks>
[Information(nameof(DateTimeFormat), Status = Status.Available, Documentation = "https://bit.ly/SpargineDateTimeFormat")]
public class DateTimeFormat : Enumeration
{
	/// <summary>
	/// Prevents direct instantiation of the <see cref="DateTimeFormat"/> class.
	/// </summary>
	[ExcludeFromCodeCoverage]
	private DateTimeFormat()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="DateTimeFormat"/> class with a specified value and display name.
	/// </summary>
	/// <param name="value">The integer value representing the format.</param>
	/// <param name="displayName">The display name or format string.</param>
	private DateTimeFormat(int value, string displayName) : base(value, displayName) { }

	/// <summary>
	/// Full date/time pattern (long time). Example: Monday, December 21, 2025 3:16:12 PM
	/// </summary>
	public static readonly DateTimeFormat FullDateLongTime = new(0, "F");

	/// <summary>
	/// Full date/time pattern (short time). Example: Monday, December 21, 2025 3:16 PM
	/// </summary>
	public static readonly DateTimeFormat FullDateShortTime = new(1, "f");

	/// <summary>
	/// Full date/time pattern (short time). Example: Monday, December 21, 2025 3:16 PM
	/// </summary>
	public static readonly DateTimeFormat FullDateTime = new(2, "f");

	/// <summary>
	/// General date/time pattern (long time). Example: 2/21/2025 3:16:12 PM
	/// </summary>
	public static readonly DateTimeFormat GeneralDateLongTime = new(3, "G");

	/// <summary>
	/// General date/time pattern (short time). Example: 12/21/2025 3:16 PM
	/// </summary>
	public static readonly DateTimeFormat GeneralDateShortTime = new(4, "g");

	/// <summary>
	/// Custom format. Example: Dec 21, 2025
	/// </summary>
	public static readonly DateTimeFormat Jan01Comma2020 = new(5, "MMM dd, yyyy");

	/// <summary>
	/// Custom format. Example: December 21, 2025
	/// </summary>
	public static readonly DateTimeFormat January01Comma2020 = new(6, "MMMM dd, yyyy");

	/// <summary>
	/// Long date pattern. Example: Monday, December 21, 2025
	/// </summary>
	public static readonly DateTimeFormat LongDate = new(7, "D");

	/// <summary>
	/// Long time pattern. Example: 3:16:12 PM
	/// </summary>
	public static readonly DateTimeFormat LongTime = new(8, "T");

	/// <summary>
	/// Month/day pattern. Example: December 21
	/// </summary>
	public static readonly DateTimeFormat MonthDay = new(9, "M");

	/// <summary>
	/// Month/year pattern. Example: December 2025
	/// </summary>
	public static readonly DateTimeFormat MonthYear = new(16, "Y");

	/// <summary>
	/// RFC1123 pattern. Example: Mon, 21 Dec 2025 15:16:12 GMT
	/// </summary>
	public static readonly DateTimeFormat RFC1123 = new(10, "R");

	/// <summary>
	/// Round-trip date/time pattern; preserves time zone. Example: 2025-12-21T15:16:12.2487693-08:00
	/// </summary>
	public static readonly DateTimeFormat RoundTripDateTime = new(11, "O");

	/// <summary>
	/// Short date pattern. Example: 12/21/2025
	/// </summary>
	public static readonly DateTimeFormat ShortDate = new(12, "d");

	/// <summary>
	/// Short time pattern. Example: 3:16 PM
	/// </summary>
	public static readonly DateTimeFormat ShortTime = new(13, "t");

	/// <summary>
	/// Sortable date/time pattern. Example: 2025-12-21T15:16:12
	/// </summary>
	public static readonly DateTimeFormat SortableDateTime = new(14, "s");

	/// <summary>
	/// Universal full date/time pattern. Example: Monday, December 21, 2025 11:16:12 PM
	/// </summary>
	public static readonly DateTimeFormat UniversalFullDateTime = new(15, "U");

}
