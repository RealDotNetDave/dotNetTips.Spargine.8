// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-21-2024
// ***********************************************************************
// <copyright file="DateTimeExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for DateTime and DateTimeOffset.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="DateTime"/>, <see cref="DateTimeOffset"/>, and <see cref="TimeSpan"/> types, enhancing functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class includes methods for converting between Unix epoch time and <see cref="DateTime"/>, finding the next or last day of the week from a given date, checking if a date range intersects with another, and more.
/// These methods are designed to simplify common date and time operations, making code more readable and efficient.
/// </remarks>
[Information(Documentation = "https://bit.ly/SpargineDateTimeExtensions")]
public static class DateTimeExtensions
{

	/// <summary>
	/// Converts a <see cref="long" /> value representing the time in milliseconds since
	/// the Unix epoch (January 1, 1970, 00:00:00 UTC) back into a <see cref="DateTime" /> object.
	/// </summary>
	/// <param name="epochTime">The Epoch time.</param>
	/// <returns>DateTime.</returns>
	[Information(nameof(FromMilliEpochTime), "David McCarter", "3/24/2017", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static DateTime FromMilliEpochTime(this in long epochTime)
	{
		var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		return epoch.AddMilliseconds(epochTime);
	}

	/// <summary>
	/// Calculates and return the last occurrence of a specified day of the week before
	/// or on the given <see cref="DateTimeOffset" /> input.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="dayOfWeek">The day of week.</param>
	/// <returns>DateTimeOffset.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTimeOffset GetLastDayOfWeek(this in DateTimeOffset input, DayOfWeek dayOfWeek = DayOfWeek.Sunday) => input.AddDays((input.DayOfWeek > dayOfWeek
							? input.DayOfWeek - dayOfWeek
							: 7 - (int)dayOfWeek + (int)input.DayOfWeek) * -1);

	/// <summary>
	/// Returns the next occurrence of a specified day of the week after
	/// the given <see cref="DateTimeOffset" /> input.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="dayOfWeek">The day of week.</param>
	/// <returns>DateTimeOffset.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTimeOffset GetNextDayOfWeek(this in DateTimeOffset input, DayOfWeek dayOfWeek)
	{
		var daysToAdd = input.DayOfWeek < dayOfWeek
			 ? dayOfWeek - input.DayOfWeek
			 : 7 - (int)input.DayOfWeek + (int)dayOfWeek;

		return input.AddDays(daysToAdd);
	}

	/// <summary>
	/// Intersects the specified start date.
	/// </summary>
	/// <param name="startDate">The start date.</param>
	/// <param name="endDate">The end date.</param>
	/// <param name="intersectingStartDate">The intersecting start date.</param>
	/// <param name="intersectingEndDate">The intersecting end date.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(Intersects), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool Intersects(this in DateTime startDate, in DateTime endDate, in DateTime intersectingStartDate, in DateTime intersectingEndDate) => intersectingEndDate >= startDate && intersectingStartDate <= endDate;

	/// <summary>
	/// Intersects the specified end date.
	/// </summary>
	/// <param name="startDate">The start date.</param>
	/// <param name="endDate">The end date.</param>
	/// <param name="intersectingStartDate">The intersecting start date.</param>
	/// <param name="intersectingEndDate">The intersecting end date.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool Intersects(this in DateTimeOffset startDate, in DateTimeOffset endDate, in DateTimeOffset intersectingStartDate, in DateTimeOffset intersectingEndDate) => intersectingEndDate >= startDate && intersectingStartDate <= endDate;

	/// <summary>
	/// Determines whether value is in range of the specified beginning time and end time.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning date.</param>
	/// <param name="endTime">The end date.</param>
	/// <returns><c>true</c> if [is in range] [the specified beginning date]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsInRange), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRange(this in DateTime value, in DateTime beginningTime, in DateTime endTime) => value >= beginningTime && value <= endTime;

	/// <summary>
	/// Determines whether value is in range of the specified beginning time and end time.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <returns><c>true</c> if [is in range] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsInRange), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRange(this in TimeSpan value, in TimeSpan beginningTime, in TimeSpan endTime) => value >= beginningTime && value <= endTime;

	/// <summary>
	/// Determines whether value is in range of the specified beginning time and end time.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <returns><c>true</c> if [is in range] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsInRange), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRange(this in DateTimeOffset value, in DateTimeOffset beginningTime, in DateTimeOffset endTime) => value >= beginningTime && value <= endTime;

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRangeThrowsException(this in DateTime value, in DateTime beginningTime, in DateTime endTime, string paramName)
	{
		if (value.IsInRange(beginningTime, endTime) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
		}

		return true;
	}

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if
	/// invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRangeThrowsException(this in TimeSpan value, in TimeSpan beginningTime, in TimeSpan endTime, string paramName)
	{
		if (value.IsInRange(beginningTime, endTime) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
		}

		return true;
	}

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if
	/// invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRangeThrowsException(this in DateTimeOffset value, in DateTimeOffset beginningTime, in DateTimeOffset endTime, string paramName = "")
	{
		if (value.IsInRange(beginningTime, endTime) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
		}

		return true;
	}

	/// <summary>
	/// Given a date, it returns the local <see cref="DateTime" /> based on a timezone.
	/// </summary>
	/// <param name="date">Date to process</param>
	/// <param name="timezoneFromUtc">Hours of the timezone from UTC</param>
	/// <returns>Future date</returns>
	[Information(nameof(LocalTimeFromUtc), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTime LocalTimeFromUtc(this in DateTime date, in int timezoneFromUtc) => date.ToUniversalTime().AddHours(timezoneFromUtc);

	/// <summary>
	/// Determines the maximum of the two <see cref="DateTime" />s.
	/// </summary>
	/// <param name="date">The date.</param>
	/// <param name="compareTo">The date to compare.</param>
	/// <returns>DateTime.</returns>
	[Information(nameof(Max), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTime Max(this in DateTime date, in DateTime compareTo) => date > compareTo ? date : compareTo;

	/// <summary>
	/// Determines the maximum of the two <see cref="DateTime" />s.
	/// </summary>
	/// <param name="date">The date.</param>
	/// <param name="compareTo">The date to compare.</param>
	/// <returns>DateTimeOffset.</returns>
	[Information(nameof(Max), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTimeOffset Max(this in DateTimeOffset date, in DateTimeOffset compareTo) => date > compareTo ? date : compareTo;

	/// <summary>
	/// Subtracts the specified <see cref="TimeSpan" /> value from
	/// a <see cref="DateTime" /> value.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="time">The time.</param>
	/// <returns>DateTime.</returns>
	[Information(nameof(Subtract), author: "David McCarter", createdOn: "10/9/2023", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public static DateTime Subtract(this in DateTime input, in TimeSpan time) => input.ToUniversalTime().Add(time);

	/// <summary>
	/// Converts <see cref="DateTime" /> to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>System.String.</returns>
	/// <example>
	/// FullDateLongTime: Thursday, January 7, 2021 3:36:39 PM
	/// FullDateShortTime: Thursday, January 7, 2021 3:36 PM
	/// FullDateTime: Thursday, January 7, 2021 3:36 PM
	/// GeneralDateLongTime: 1/7/2021 3:36:39 PM
	/// GeneralDateShortTime: 1/7/2021 3:36 PM
	/// Jan01Comma2020: Jan 07, 2021
	/// Janurary01Comma2020: January 07, 2021
	/// LongDate: Thursday, January 7, 2021
	/// LongTime: 3:36:39 PM
	/// MonthDay: January 7
	/// MonthYear: January 2021
	/// RFC1123: Thu, 07 Jan 2021 15:36:39 GMT
	/// RoundTripDateTime: 2021-01-07T15:36:39.4416894-08:00
	/// ShortDate: 1/7/2021
	/// ShortTime: 3:36 PM
	/// SortableDateTime: 2021-01-07T15:36:39
	/// UniversalFullDateTime: Thursday, January 7, 2021 11:36:39 PM.
	/// </example>
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToFormattedString(this in DateTime input, [NotNull] DateTimeFormat format) => input.ToString(format.DisplayName, CultureInfo.CurrentCulture);

	/// <summary>
	/// Converts <see cref="DateTime" /> to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>System.String.</returns>
	/// <example>
	/// FullDateLongTime: Thursday, January 7, 2021 3:36:39 PM
	/// FullDateShortTime: Thursday, January 7, 2021 3:36 PM
	/// FullDateTime: Thursday, January 7, 2021 3:36 PM
	/// GeneralDateLongTime: 1/7/2021 3:36:39 PM
	/// GeneralDateShortTime: 1/7/2021 3:36 PM
	/// Jan01Comma2020: Jan 07, 2021
	/// Janurary01Comma2020: January 07, 2021
	/// LongDate: Thursday, January 7, 2021
	/// LongTime: 3:36:39 PM
	/// MonthDay: January 7
	/// MonthYear: January 2021
	/// RFC1123: Thu, 07 Jan 2021 15:36:39 GMT
	/// RoundTripDateTime: 2021-01-07T15:36:39.4416894-08:00
	/// ShortDate: 1/7/2021
	/// ShortTime: 3:36 PM
	/// SortableDateTime: 2021-01-07T15:36:39
	/// UniversalFullDateTime: Thursday, January 7, 2021 11:36:39 PM.
	/// </example>
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToFormattedString(this DateTimeOffset input, [NotNull] DateTimeFormat format) => input.ToString(format.ArgumentNotNull().DisplayName, CultureInfo.CurrentCulture);

	/// <summary>
	/// Creates a friendly date string.
	/// </summary>
	/// <param name="input">The date.</param>
	/// <returns>System.String.</returns>
	/// <example>
	/// Output: Today @ 10:27:43 am
	/// </example>
	[Information(nameof(ToFriendlyDateString), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToFriendlyDateString(this in DateTime input)
	{
		string formattedDate;

		if (input.Date == DateTime.Today)
		{
			formattedDate = nameof(DateTime.Today);
		}
		else
		{
			string condition;

			if (input.Date > DateTime.Today.AddDays(-6))
			{
				condition = input.ToString("dddd", CultureInfo.CurrentCulture);
			}
			else
			{
				condition = input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern,
												  CultureInfo.CurrentCulture);
			}

			formattedDate = input.Date == DateTime.Today.AddDays(-1)
				? Resources.Yesterday
				: condition;
		}

		formattedDate += $" @ {input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern, CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture)}";

		return formattedDate;
	}

	/// <summary>
	/// Converts to friendly date string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>System.String.</returns>
	/// <example>
	/// Output: Today @ 10:27:43 am
	/// </example>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToFriendlyDateString(this in DateTimeOffset input)
	{
		string formattedDate;

		if (input.Date == DateTime.Today)
		{
			formattedDate = nameof(DateTime.Today);
		}
		else
		{
			string condition;

			if (input.Date > DateTime.Today.AddDays(-6))
			{
				condition = input.ToString("dddd", CultureInfo.CurrentCulture);
			}
			else
			{
				condition = input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern,
												  CultureInfo.CurrentCulture);
			}

			formattedDate = input.Date == DateTime.Today.AddDays(-1)
				? Resources.Yesterday
				: condition;
		}

		formattedDate += $" @ {input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern, CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture)}";

		return formattedDate;
	}

	/// <summary>
	/// Converts convert a <see cref="DateTime" /> object into a long representing the time in milliseconds
	/// since the Unix epoch (January 1, 1970, 00:00:00 UTC).
	/// </summary>
	/// <param name="date">The date.</param>
	/// <returns>System.Int64.</returns>
	/// <remarks>In computing, an epoch is a date and time from which a computer measures system time.
	/// For instance, Unix and POSIX measure time as the number of seconds that have passed
	/// since 1 January 1970 00:00:00 UT, a point in time known as the Unix epoch.</remarks>
	[Information(nameof(ToMilliEpochTime), "David McCarter", "3/24/2017", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static long ToMilliEpochTime(this in DateTime date)
	{
		var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return Convert.ToInt64((date - epoch).TotalMilliseconds);
	}

}
