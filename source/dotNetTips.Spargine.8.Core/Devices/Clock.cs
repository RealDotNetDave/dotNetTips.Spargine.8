// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-07-2025
// ***********************************************************************
// <copyright file="Clock.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Time Utility Class for common tasks related to clocks and time.
// It includes functionalities to retrieve the current time and tick
// count, along with a method to determine the number of days in the
// current month (DaysInCurrentMonth).
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Devices;

/// <summary>
/// Provides utility methods for common tasks related to clocks and time, such as retrieving the current time, tick count, and the number of days in the current month.
/// </summary>
/// <remarks>
/// Some of this code is from the Microsoft.VisualBasic.dll.
/// </remarks>
[ExcludeFromCodeCoverage(Justification = "Not needed due to just using the <see cref=\"DateTime\"/> type.")]
[Information(nameof(Clock), "David McCarter", "11/11/2020", Status = Status.NeedsDocumentation)]
public static class Clock
{

	/// <summary>
	/// Determines whether the specified year is a leap year.
	/// </summary>
	/// <param name="year">The year to check.</param>
	/// <returns><c>true</c> if the specified year is a leap year; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsLeapYear), "David McCarter", "11/14/2024", Status = Status.Available)]
	public static bool IsLeapYear([ConstantExpected(Min = 0, Max = int.MaxValue)] int year) => DateTime.IsLeapYear(year);

	/// <summary>
	/// Gets the days in the current month (local time) by utilizing <see cref="DateTime.DaysInMonth(int, int)"/>.
	/// </summary>
	/// <value>The number of days in the current month.</value>
	[Information(nameof(DaysInCurrentMonth), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int DaysInCurrentMonth => DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

	/// <summary>
	/// Gets the days in the current UTC month by utilizing <see cref="DateTime.DaysInMonth(int, int)"/>.
	/// </summary>
	/// <value>The number of days in the current UTC month.</value>
	[Information(nameof(DaysInCurrentUtcMonth), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int DaysInCurrentUtcMonth => DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month);

	/// <summary>
	/// Gets the local time by converting <see cref="DateTime.Now"/> to local time.
	/// </summary>
	/// <value>The local time.</value>
	[Information(nameof(LocalTime), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static DateTime LocalTime => DateTime.Now;

	/// <summary>
	/// Gets the current tick count by utilizing <see cref="Environment.TickCount"/>.
	/// </summary>
	/// <value>The tick count since the system started.</value>
	[Information(nameof(TickCount), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int TickCount => Environment.TickCount;

	/// <summary>
	/// Gets the current tick count as a 64-bit integer by utilizing <see cref="Environment.TickCount64"/>.
	/// </summary>
	/// <value>The tick count since the system started as a 64-bit integer.</value>
	[Information(nameof(TickCount64), "David McCarter", "11/14/2024", Status = Status.Available)]
	public static long TickCount64 => Environment.TickCount64;

	/// <summary>
	/// Gets the UTC time by retrieving <see cref="DateTime.UtcNow"/>.
	/// </summary>
	/// <value>The current UTC time.</value>
	[Information(nameof(UtcTime), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static DateTime UtcTime => DateTime.UtcNow;

}
