// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-04-2025
// ***********************************************************************
// <copyright file="DateTimeExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DateTimeExtensionsTests : UnitTester
{

	/// <summary>
	/// Defines the test method DateTimeIntersectsTest.
	/// </summary>
	[TestMethod]
	public void DateTimeIntersectsTest()
	{
		var now = Clock.LocalTime;

		var result = now.Intersects(endDate: now.AddDays(100), intersectingStartDate: now.AddDays(1), intersectingEndDate: now.AddDays(10));

		//PrintResult(result, nameof(this.DateTimeIntersectsTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method DateTimeIsInRangeTest.
	/// </summary>
	[TestMethod]
	public void DateTimeIsInRangeTest()
	{
		var now = Clock.LocalTime;

		var result = now.IsInRange(beginningTime: new DateTime(1970), endTime: now.AddDays(10));

		//PrintResult(result, nameof(this.DateTimeIsInRangeTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method DateTimeLocalTimeFromUtcTest.
	/// </summary>
	[TestMethod]
	public void DateTimeLocalTimeFromUtcTest()
	{
		var now = Clock.LocalTime;

		var result = now.LocalTimeFromUtc(timezoneFromUtc: -5);

		//PrintResult(result, nameof(this.DateTimeLocalTimeFromUtcTest));

		Assert.IsTrue(result >= now);
	}

	/// <summary>
	/// Defines the test method DateTimeMaxTest.
	/// </summary>
	[TestMethod]
	public void DateTimeMaxTest()
	{
		var now = Clock.LocalTime;

		var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

		//PrintResult(result, nameof(this.DateTimeMaxTest));

		Assert.IsTrue(result == now);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetGetLastDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetGetLastDayOfWeekTest()
	{
		var result = DateTimeOffset.Now.GetLastDayOfWeek(DayOfWeek.Monday);

		//PrintResult(result, nameof(this.DateTimeOffsetGetLastDayOfWeekTest));

		Assert.IsTrue(result <= Clock.LocalTime);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetGetNextDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetGetNextDayOfWeekTest()
	{
		var result = DateTimeOffset.Now.GetNextDayOfWeek(DayOfWeek.Monday);

		//PrintResult(result, nameof(this.DateTimeOffsetGetNextDayOfWeekTest));

		Assert.IsTrue(result >= Clock.LocalTime);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetIntersectsTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetIntersectsTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.Intersects(now.AddDays(100), now.AddDays(1), now.AddDays(10));

		//PrintResult(result, nameof(this.DateTimeOffsetIntersectsTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetIsInRangeTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetIsInRangeTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(10));

		//PrintResult(result, nameof(this.DateTimeOffsetIsInRangeTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetMaxTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetMaxTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

		//PrintResult(result, nameof(this.DateTimeOffsetMaxTest));

		Assert.IsTrue(result == now);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetNextDayOfTheWeekTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetNextDayOfTheWeekTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.GetNextDayOfWeek(DayOfWeek.Sunday);

		//PrintResult(result, nameof(this.DateTimeOffsetNextDayOfTheWeekTest));

		Assert.IsTrue(result >= now);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetTimeUntilNextHourTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetTimeUntilNextHourTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.TimeUntilNextHour();

		Assert.IsTrue(result.TotalMinutes <= 60);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetTimeUntilNextMinuteTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetTimeUntilNextMinuteTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.TimeUntilNextMinute();

		Assert.IsTrue(result.TotalSeconds <= 60);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetToFriendlyStringTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetToFriendlyStringTest()
	{
		var result = DateTimeOffset.Now.ToFriendlyDateString();

		//PrintResult(result, nameof(this.DateTimeOffsetToFriendlyStringTest));

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	/// <summary>
	/// Defines the test method DateTimeSubtractTest.
	/// </summary>
	[TestMethod]
	public void DateTimeSubtractTest()
	{
		var now = Clock.LocalTime;
		var timeSpan = new TimeSpan(1, 0, 0, 0);

		var result = now.Subtract(timeSpan);

		Assert.AreEqual(now.Add(-timeSpan), result);
	}

	/// <summary>
	/// Defines the test method DateTimeTimeUntilNextHourTest.
	/// </summary>
	[TestMethod]
	public void DateTimeTimeUntilNextHourTest()
	{
		var now = Clock.LocalTime;

		var result = now.TimeUntilNextHour();

		Assert.IsTrue(result.TotalMinutes <= 60);
	}

	/// <summary>
	/// Defines the test method DateTimeTimeUntilNextMinuteTest.
	/// </summary>
	[TestMethod]
	public void DateTimeTimeUntilNextMinuteTest()
	{
		var now = Clock.LocalTime;

		var result = now.TimeUntilNextMinute();

		Assert.IsTrue(result.TotalSeconds <= 60);
	}

	/// <summary>
	/// Defines the test method DateTimeToFormattedStringTest.
	/// </summary>
	[TestMethod]
	public void DateTimeToFormattedStringTest()
	{
		var now = Clock.LocalTime;

		var result = now.ToFormattedString(DateTimeFormat.FullDateLongTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateLongTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.FullDateShortTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateShortTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.FullDateTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.GeneralDateLongTime);

		//PrintResult(result, nameof(DateTimeFormat.GeneralDateLongTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.GeneralDateShortTime);

		//PrintResult(result, nameof(DateTimeFormat.GeneralDateShortTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.Jan01Comma2020);

		//PrintResult(result, nameof(DateTimeFormat.Jan01Comma2020));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.January01Comma2020);

		//PrintResult(result, nameof(DateTimeFormat.Janurary01Comma2020));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.LongDate);

		//PrintResult(result, nameof(DateTimeFormat.LongDate));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.LongTime);

		//PrintResult(result, nameof(DateTimeFormat.LongTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.MonthDay);

		//PrintResult(result, nameof(DateTimeFormat.MonthDay));

		Assert.IsTrue(result.Length > 4);

		result = now.ToFormattedString(DateTimeFormat.RFC1123);

		//PrintResult(result, nameof(DateTimeFormat.RFC1123));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.RoundTripDateTime);

		//PrintResult(result, nameof(DateTimeFormat.RoundTripDateTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.ShortDate);

		//PrintResult(result, nameof(DateTimeFormat.ShortDate));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.ShortTime);

		//PrintResult(result, nameof(DateTimeFormat.ShortTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.SortableDateTime);

		//PrintResult(result, nameof(DateTimeFormat.SortableDateTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.UniversalFullDateTime);

		//PrintResult(result, nameof(DateTimeFormat.UniversalFullDateTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.MonthYear);

		//PrintResult(result, nameof(DateTimeFormat.MonthYear));

		Assert.IsTrue(result.Length > 5);
	}

	/// <summary>
	/// Defines the test method DateTimeToFriendlyStringTest.
	/// </summary>
	[TestMethod]
	public void DateTimeToFriendlyStringTest()
	{
		var result = Clock.LocalTime.ToFriendlyDateString();

		//PrintResult(result, nameof(this.DateTimeToFriendlyStringTest));

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	/// <summary>
	/// Defines the test method GetLastDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void GetLastDayOfWeekTest()
	{
		var dateTime = DateTimeOffset.Parse("1/1/2020");

		var result = dateTime.GetLastDayOfWeek(DayOfWeek.Sunday);

		Assert.IsTrue(result.DayOfWeek == DayOfWeek.Sunday);
	}

	/// <summary>
	/// Defines the test method GetNextDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void GetNextDayOfWeekTest()
	{
		var dateTime = DateTimeOffset.Parse("1/1/2020");

		var result = dateTime.GetNextDayOfWeek(DayOfWeek.Tuesday);

		Assert.IsTrue(result.DayOfWeek == DayOfWeek.Tuesday);
	}

	/// <summary>
	/// Defines the test method IsInRangeThrowsExceptionTestDateTime.
	/// </summary>
	[TestMethod]
	public void IsInRangeThrowsExceptionTestDateTime()
	{
		var now = Clock.LocalTime;

		var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(days: 1, hours: 0, minutes: 0, seconds: 0)), now.AddDays(value: 1), paramName: "TEST");

		Assert.IsTrue(result1);

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
	}

	/// <summary>
	/// Defines the test method IsInRangeThrowsExceptionTestDateTimeOffset.
	/// </summary>
	[TestMethod]
	public void IsInRangeThrowsExceptionTestDateTimeOffset()
	{
		var now = DateTimeOffset.Now;

		var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(1), "TEST");

		Assert.IsTrue(result1);

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
	}

	/// <summary>
	/// Defines the test method IsInRangeThrowsExceptionTestTimeSpan.
	/// </summary>
	[TestMethod]
	public void IsInRangeThrowsExceptionTestTimeSpan()
	{
		var now = TimeSpan.FromDays(5);

		var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Add(TimeSpan.FromDays(10)), "TEST");

		Assert.IsTrue(result1);

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.Add(new TimeSpan(10, 0, 0, 0)), new TimeSpan(20, 0, 0, 0), "TEST"));
	}

	/// <summary>
	/// Defines the test method TimeSpanIsInRangeTest.
	/// </summary>
	[TestMethod]
	public void TimeSpanIsInRangeTest()
	{
		var now = new TimeSpan(3, 0, 0, 0);

		var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Multiply(10));

		//PrintResult(result, nameof(this.TimeSpanIsInRangeTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method ToFromMilliEpochTimeTest.
	/// </summary>
	[TestMethod]
	public void ToFromMilliEpochTimeTest()
	{
		var currentTime = Clock.LocalTime;
		var epochTime = currentTime.ToMilliEpochTime();

		//PrintResult(epochTime, nameof(this.ToFromMilliEpochTimeTest));

		Assert.IsTrue(epochTime > 0);

		// Test reverse
		var convertedTime = epochTime.FromMilliEpochTime();

		Assert.IsTrue(convertedTime >= currentTime.Subtract(new TimeSpan(0, 5, 0)));

		//PrintResult(convertedTime, nameof(this.ToFromMilliEpochTimeTest));
	}

}
