// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-02-2024
// ***********************************************************************
// <copyright file="NumericExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods designed for numbers.</summary>
// ***********************************************************************

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for numeric types, offering a variety of mathematical and utility operations to enhance the functionality of the basic numeric types in .NET.
/// </summary>
public static class NumericExtensions
{

	/// <summary>
	/// The file format sizes
	/// </summary>
	private static readonly string[] _fileFormatSizes = [Resources.Bytes, Resources.KB, Resources.MB, Resources.GB, Resources.TB, Resources.PB, Resources.EB];

	/// <summary>
	/// The roman numerals
	/// </summary>
	private static readonly string[] _romanNumerals = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];

	/// <summary>
	/// The roman values
	/// </summary>
	private static readonly int[] _romanValues = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Calculates the average of two double values.
	/// </summary>
	/// <param name="a">The first double value.</param>
	/// <param name="b">The second double value.</param>
	/// <returns>The average of the two double values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "2/19/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static double Average(this in double a, in double b) => (a + b) / 2;

	/// <summary>
	/// Calculates the average of two long values.
	/// </summary>
	/// <param name="a">The first long value.</param>
	/// <param name="b">The second long value.</param>
	/// <returns>The average of the two long values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "2/19/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static long Average(this in long a, in long b) => (a + b) / 2;

	/// <summary>
	/// Calculates the average of two integer values.
	/// </summary>
	/// <param name="a">The first integer value.</param>
	/// <param name="b">The second integer value.</param>
	/// <returns>The average of the two integer values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "2/19/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static int Average(this in int a, in int b) => (a + b) / 2;

	/// <summary>
	/// Calculates the average of two decimal values.
	/// </summary>
	/// <param name="a">The first decimal value.</param>
	/// <param name="b">The second decimal value.</param>
	/// <returns>The average of the two decimal values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "2/19/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static decimal Average(this in decimal a, in decimal b) => (a + b) / 2;

	/// <summary>
	/// Converts the number of bytes into megabytes.
	/// </summary>
	/// <param name="bytes">The number of bytes.</param>
	/// <returns>The equivalent number of megabytes as a double.</returns>

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToMegabytes), "David McCarter", "7/9/2024", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New, Documentation = "ADD URL")]
	public static double BytesToMegabytes(this long bytes)
	{
		bytes = bytes.ArgumentInRange(0);

		return bytes / 1048576.0; // 1024 * 1024
	}

	/// <summary>
	/// Decrements the specified value by a given step, not going below a specified lower bound.
	/// </summary>
	/// <param name="value">The value to decrement.</param>
	/// <param name="lowerBound">The minimum value that can be returned. Default is 0.</param>
	/// <param name="step">The decrement step. Default is 1.</param>
	/// <returns>The decremented value, ensuring it does not fall below the lower bound.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Decrement), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int Decrement(this in int value, in int lowerBound = 0, int step = 1)
	{
		var result = value - step;
		return result < lowerBound ? lowerBound : result;
	}

	/// <summary>
	/// Ensures that the given value is not less than the specified minimum value.
	/// </summary>
	/// <param name="value">The value to check against the minimum value.</param>
	/// <param name="minValue">The minimum value.</param>
	/// <returns>The original value if it is greater than or equal to the minimum value; otherwise, the minimum value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureMinimum), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int EnsureMinimum(this in int value, in int minValue) => value < minValue ? minValue : value;

	/// <summary>
	/// Formats the size of a file from bytes into a more readable string format (e.g., KB, MB, GB, TB, etc.).
	/// This method is optimized for long integer values to accommodate large file sizes.
	/// </summary>
	/// <param name="fileSize">The size of the file in bytes.</param>
	/// <returns>A string representing the formatted size of the file, including the appropriate size unit.</returns>
	[Information(nameof(FormatSize), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static string FormatSize(this in long fileSize)
	{
		if (fileSize < 0)
		{
			return "Invalid size";
		}

		var order = 0;
		double len = fileSize;
		while (len >= 1024 && order < _fileFormatSizes.Length - 1)
		{
			order++;
			len /= 1024;
		}

		return $"{len:0.##} {_fileFormatSizes[order]}";
	}

	/// <summary>
	/// Formats the size of a file from bytes into a more readable string format (e.g., KB, MB, GB, TB, etc.).
	/// This method is optimized for double precision floating-point numbers to accommodate very large or very precise file sizes.
	/// </summary>
	/// <param name="fileSize">The size of the file in bytes as a double.</param>
	/// <returns>A string representing the formatted size of the file, including the appropriate size unit.</returns>
	[Information(nameof(FormatSize), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static string FormatSize(this double fileSize)
	{
		var order = 0;
		while (fileSize >= 1024 && order < _fileFormatSizes.Length - 1)
		{
			order++;
			fileSize /= 1024;
		}

		return $"{Math.Round(fileSize, 2)} {_fileFormatSizes[order]}";
	}

	/// <summary>
	/// Increments the specified value by a given step, not exceeding a specified upper bound.
	/// </summary>
	/// <param name="value">The value to increment.</param>
	/// <param name="upperBound">The maximum value that can be returned. Default is 100.</param>
	/// <param name="step">The increment step. Default is 1.</param>
	/// <returns>The incremented value, ensuring it does not exceed the upper bound.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Increment), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int Increment(this in int value, in int upperBound = 100, int step = 1)
	{
		step = step.ArgumentInRange(0);

		var number = value + step;
		return number > upperBound ? upperBound : number;
	}

	/// <summary>
	/// Determines whether the specified decimal value is even.
	/// </summary>
	/// <param name="value">The decimal value to check.</param>
	/// <returns><c>true</c> if the value is even; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this in decimal value) => (value % 2) == 0;

	/// <summary>
	/// Determines whether the specified double value is even.
	/// </summary>
	/// <param name="value">The double value to check.</param>
	/// <returns><c>true</c> if the value is even; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this in double value) => (value % 2) == 0;

	/// <summary>
	/// Determines whether the specified float value is even.
	/// </summary>
	/// <param name="value">The float value to check.</param>
	/// <returns><c>true</c> if the value is even; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this in float value) => (value % 2) == 0;

	/// <summary>
	/// Determines whether the specified integer value is even.
	/// </summary>
	/// <param name="value">The integer value to check.</param>
	/// <returns><c>true</c> if the value is even; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this in int value) => (value % 2) == 0;

	/// <summary>
	/// Determines whether the specified long value is even.
	/// </summary>
	/// <param name="value">The long value to check.</param>
	/// <returns><c>true</c> if the value is even; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this in long value) => (value % 2) == 0;

	/// <summary>
	/// Determines whether the specified sbyte value is even.
	/// </summary>
	/// <param name="value">The sbyte value to check.</param>
	/// <returns><c>true</c> if the value is even; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this in sbyte value) => (value % 2) == 0;

	/// <summary>
	/// Determines whether the specified short value is even.
	/// </summary>
	/// <param name="value">The short value to check.</param>
	/// <returns><c>true</c> if the value is even; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this in short value) => (value % 2) == 0;

	/// <summary>
	/// Determines whether the specified integer value is within a specified range.
	/// </summary>
	/// <param name="value">The integer value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <returns><c>true</c> if the value is within the range; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRange), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRange(this in int value, in int lower, in int upper) => value >= lower && value <= upper;

	/// <summary>
	/// Determines whether the specified long value is within a specified range.
	/// </summary>
	/// <param name="value">The long value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <returns><c>true</c> if the value is within the range; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRange), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRange(this in long value, in long lower, in long upper) => value >= lower && value <= upper;

	/// <summary>
	/// Determines whether the specified double value is within a specified range.
	/// </summary>
	/// <param name="value">The double value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <returns><c>true</c> if the value is within the range; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRange), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRange(this in double value, in double lower, in double upper) => value >= lower && value <= upper;

	/// <summary>
	/// Determines whether the specified decimal value is within a specified range.
	/// </summary>
	/// <param name="value">The decimal value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <returns><c>true</c> if the value is within the range; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRange), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRange(this in decimal value, in decimal lower, in decimal upper) => value >= lower && value <= upper;

	/// <summary>
	/// Determines whether the specified double value is within a specified range and throws an exception if it is not.
	/// </summary>
	/// <param name="value">The double value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <returns><c>true</c> if the value is within the range; otherwise, throws an exception.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not within the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRangeThrowsException(this in double value, in double lower, in double upper)
	{
		if (value.IsInRange(lower, upper) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
		}

		return true;
	}

	/// <summary>
	/// Determines whether the specified decimal value is within a specified range and throws an exception if it is not.
	/// </summary>
	/// <param name="value">The decimal value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <returns><c>true</c> if the value is within the range; otherwise, throws an <see cref="ArgumentOutOfRangeException" />.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not within the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRangeThrowsException(this in decimal value, in decimal lower, in decimal upper)
	{
		if (value.IsInRange(lower, upper) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
		}

		return true;
	}

	/// <summary>
	/// Determines whether the specified integer value is within a specified range and throws an exception if it is not.
	/// </summary>
	/// <param name="value">The integer value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <returns><c>true</c> if the value is within the range; otherwise, throws an <see cref="ArgumentOutOfRangeException" />.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not within the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRangeThrowsException(this in int value, in int lower, in int upper)
	{
		if (value.IsInRange(lower, upper) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
		}

		return true;
	}

	/// <summary>
	/// Determines whether the specified long value is within a specified range and throws an exception if it is not.
	/// </summary>
	/// <param name="value">The long value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <returns><c>true</c> if the value is within the range; otherwise, throws an <see cref="ArgumentOutOfRangeException" />.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not within the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRangeThrowsException(this in long value, in long lower, in long upper)
	{
		if (value.IsInRange(lower, upper) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
		}

		return true;
	}

	/// <summary>
	/// Determines whether the specified integer value is evenly divisible by the given interval.
	/// </summary>
	/// <param name="value">The integer value to check.</param>
	/// <param name="interval">The interval to check divisibility against.</param>
	/// <returns><c>true</c> if the value is evenly divisible by the interval; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInterval), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInterval(this in int value, in int interval) => value % interval == 0;

	/// <summary>
	/// Determines whether the specified integer value is evenly divisible by the given interval and throws an exception if it is not.
	/// </summary>
	/// <param name="value">The integer value to check.</param>
	/// <param name="interval">The interval to check divisibility against.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	/// <returns><c>true</c> if the value is evenly divisible by the interval; otherwise, throws an <see cref="ArgumentOutOfRangeException" />.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not evenly divisible by the interval.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsIntervalThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsIntervalThrowsException(this in int value, in int interval, string paramName)
	{
		if (value.IsInterval(interval) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
		}

		return true;
	}

	/// <summary>
	/// Determines whether the specified double value is negative.
	/// </summary>
	/// <param name="value">The double value to check.</param>
	/// <returns><c>true</c> if the value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this in double value) => Math.Sign(value) == -1;

	/// <summary>
	/// Determines whether the specified integer value is negative.
	/// </summary>
	/// <param name="value">The integer value to check.</param>
	/// <returns><c>true</c> if the value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this in int value) => Math.Sign(value) == -1;

	/// <summary>
	/// Determines whether the specified long value is negative.
	/// </summary>
	/// <param name="value">The long value to check.</param>
	/// <returns><c>true</c> if the value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this in long value) => Math.Sign(value) == -1;

	/// <summary>
	/// Determines whether the specified sbyte value is negative.
	/// </summary>
	/// <param name="value">The sbyte value to check.</param>
	/// <returns><c>true</c> if the value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this in sbyte value) => Math.Sign(value) == -1;

	/// <summary>
	/// Determines whether the specified short value is negative.
	/// </summary>
	/// <param name="value">The short value to check.</param>
	/// <returns><c>true</c> if the value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this in short value) => Math.Sign(value) == -1;

	/// <summary>
	/// Determines whether the specified decimal value is negative.
	/// </summary>
	/// <param name="value">The decimal value to check.</param>
	/// <returns><c>true</c> if the value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this in decimal value) => Math.Sign(value) == -1;

	/// <summary>
	/// Determines whether the specified float value is negative.
	/// </summary>
	/// <param name="value">The float value to check.</param>
	/// <returns><c>true</c> if the value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this in float value) => Math.Sign(value) == -1;

	/// <summary>
	/// Converts the total milliseconds to a formatted string representation.
	/// </summary>
	/// <param name="totalMilliseconds">The total milliseconds to convert.</param>
	/// <returns>A string representation of the total milliseconds in the format of hours, minutes, seconds, and milliseconds.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MillisecondsToString), "David McCarter", "4/16/2003", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static string MillisecondsToString(this long totalMilliseconds)
	{
		totalMilliseconds = totalMilliseconds.ArgumentInRange(0);

		return $"{(int)(totalMilliseconds / (1000 * 60 * 60)):D2}:{(int)(totalMilliseconds / (1000 * 60) % 60):D2}:{(int)(totalMilliseconds / 1000 % 60):D2}";
	}

	/// <summary>
	/// Converts a TimeSpan to a formatted string representation of milliseconds.
	/// </summary>
	/// <param name="input">The TimeSpan to convert.</param>
	/// <returns>A string representation of the total milliseconds contained in the TimeSpan.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MillisecondsToString), "David McCarter", "4/16/2003", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static string MillisecondsToString(this in TimeSpan input)
	{
		var totalMilliseconds = input.TotalMilliseconds;

		return $"{(int)(totalMilliseconds / (1000 * 60 * 60)):D2}:{(int)(totalMilliseconds / (1000 * 60) % 60):D2}:{(int)(totalMilliseconds / 1000 % 60):D2}";
	}

	/// <summary>
	/// Converts the total milliseconds to a formatted string representation.
	/// </summary>
	/// <param name="totalMilliseconds">The total milliseconds to convert.</param>
	/// <returns>A string representation of the total milliseconds in the format of hours, minutes, seconds, and milliseconds.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MillisecondsToString), "David McCarter", "4/16/2003", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static string MillisecondsToString(this int totalMilliseconds)
	{
		totalMilliseconds = totalMilliseconds.ArgumentInRange(0);

		return $"{totalMilliseconds / (1000 * 60 * 60):D2}:{totalMilliseconds / (1000 * 60) % 60:D2}:{totalMilliseconds / 1000 % 60:D2}";
	}

	/// <summary>
	/// Rounds the given integer value up to the nearest power of two.
	/// </summary>
	/// <param name="value">The integer value to round.</param>
	/// <returns>The nearest power of two that is greater than or equal to the given value.</returns>
	/// <remarks>If the input value is less than or equal to 1, the return value is 1.
	/// This method uses bitwise operations for efficient computation.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RoundToPowerOf2), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int RoundToPowerOf2(this int value)
	{
		value = value.ArgumentInRange(0);

		var exponent = 1;

		while (true)
		{
			var powerOf2 = (uint)Math.Pow(2, exponent++);

			if (powerOf2 >= value)
			{
				return (int)powerOf2;
			}
		}
	}

	/// <summary>
	/// Converts the given integer to a formatted string based on the specified numeric format.
	/// </summary>
	/// <param name="input">The integer to format.</param>
	/// <param name="format">The numeric format to apply.</param>
	/// <returns>A formatted string representation of the input integer.</returns>
	/// <exception cref="ArgumentInvalidException">Invalid number format.</exception>
	/// <example>
	/// Output: Currency: $2,103,162,670.00, Decimal: 2103162670, Exponential: 2.103163E+009 FixedPoint:
	/// 2103162670.00, General: 2103162670, Hexadecimal: 7D5BB72E Number: 2,103,162,670.00, Percent:
	/// 210,316,267,000.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this in int input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException(Resources.InvalidNumberFormat, nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts the given double to a formatted string based on the specified numeric format.
	/// </summary>
	/// <param name="input">The double to format.</param>
	/// <param name="format">The numeric format to apply.</param>
	/// <returns>A formatted string representation of the input double.</returns>
	/// <exception cref="ArgumentInvalidException">Invalid number format.</exception>
	/// <example>
	/// Output: Currency: $555.55, RoundTrip: 555.555, Exponential: 5.555550E+002, FixedPoint: 555.55, General:
	/// 555.555, Number: 555.55, Percent: 55,555.50%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" /> or <see cref="NumericFormat.Hexadecimal" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this in double input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.Decimal || format == NumericFormat.Hexadecimal)
		{
			ExceptionThrower.ThrowArgumentInvalidException(Resources.InvalidNumberFormat, nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts the given long to a formatted string based on the specified numeric format.
	/// </summary>
	/// <param name="input">The long value to format.</param>
	/// <param name="format">The numeric format to apply.</param>
	/// <returns>A formatted string representation of the input long.</returns>
	/// <exception cref="ArgumentInvalidException">Invalid number format.</exception>
	/// <example>
	/// Output: Currency: $4,611,686,018,427,387.00, Decimal: 4611686018427387, Exponential: 4.611686E+015
	/// FixedPoint: 4611686018427387.00, General: 4611686018427387, Hexadecimal: 10624DD2F1A9FB Number:
	/// 4,611,686,018,427,387.00, Percent: 461,168,601,842,738,700.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this in long input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException(Resources.InvalidNumberFormat, nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts the given unsigned long to a formatted string based on the specified numeric format.
	/// </summary>
	/// <param name="input">The unsigned long value to format.</param>
	/// <param name="format">The numeric format to apply.</param>
	/// <returns>A formatted string representation of the input unsigned long.</returns>
	/// <exception cref="ArgumentInvalidException">Invalid number format.</exception>
	/// <example>
	/// Output: Currency: $9,223,372,036,854.00, Decimal: 9223372036854, Exponential: 9.223372E+012 FixedPoint:
	/// 9223372036854.00, General: 9223372036854, Hexadecimal: 8637BD05AF6 Number: 9,223,372,036,854.00, Percent:
	/// 922,337,203,685,400.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this in ulong input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException(Resources.InvalidNumberFormat, nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts the given unsigned integer to a formatted string based on the specified numeric format.
	/// </summary>
	/// <param name="input">The unsigned integer value to format.</param>
	/// <param name="format">The numeric format to apply.</param>
	/// <returns>A formatted string representation of the input unsigned integer.</returns>
	/// <exception cref="ArgumentInvalidException">Invalid number format.</exception>
	/// <example>
	/// Output: Currency: $21,474,836.00, Decimal: 21474836, Exponential: 2.147484E+007 FixedPoint: 21474836.00,
	/// General: 21474836, Hexadecimal: 147AE14 Number: 21,474,836.00, Percent: 2,147,483,600.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this in uint input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException(Resources.InvalidNumberFormat, nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts the given short to a formatted string based on the specified numeric format.
	/// </summary>
	/// <param name="input">The short value to format.</param>
	/// <param name="format">The numeric format to apply.</param>
	/// <returns>A formatted string representation of the input short.</returns>
	/// <exception cref="ArgumentInvalidException">Invalid number format.</exception>
	/// <example>
	/// Output: Currency: $32,767.00, Decimal: 32767, Exponential: 3.276700E+004 FixedPoint: 32767.00, General:
	/// 32767, Hexadecimal: 7FFF, Number: 32,767.00 Percent: 3,276,700.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this in short input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException(Resources.InvalidNumberFormat, nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts the given unsigned short to a formatted string based on the specified numeric format.
	/// </summary>
	/// <param name="input">The unsigned short value to format.</param>
	/// <param name="format">The numeric format to apply.</param>
	/// <returns>A formatted string representation of the input unsigned short.</returns>
	/// <exception cref="ArgumentInvalidException">Invalid number format.</exception>
	/// <example>
	/// Output: Currency: $65,535.00, Decimal: 65535, Exponential: 6.553500E+004, FixedPoint: 65535.00 General:
	/// 65535, Hexadecimal: FFFF, Number: 65,535.00, Percent: 6,553,500.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this in ushort input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException(Resources.InvalidNumberFormat, nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts a negative integer to 0, otherwise returns the original value.
	/// </summary>
	/// <param name="value">The integer value to convert.</param>
	/// <returns>The original value if it is within the range of 0 to <see cref="int.MaxValue" />, otherwise returns 0.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToPositiveValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int ToPositiveValue(this in int value) => value.IsInRange(0, int.MaxValue) ? value : 0;

	/// <summary>
	/// Converts a negative long integer to 0, otherwise returns the original value.
	/// </summary>
	/// <param name="value">The long integer value to convert.</param>
	/// <returns>The original value if it is within the range of 0 to <see cref="int.MaxValue" />, otherwise returns 0.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToPositiveValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static long ToPositiveValue(this in long value) => value.IsInRange(0, int.MaxValue) ? value : 0;

	/// <summary>
	/// Converts a negative decimal value to 0, otherwise returns the original value.
	/// </summary>
	/// <param name="value">The decimal value to convert.</param>
	/// <returns>The original value if it is within the range of 0 to <see cref="int.MaxValue" />, otherwise returns 0.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToPositiveValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static decimal ToPositiveValue(this in decimal value) => value.IsInRange(0, int.MaxValue) ? value : 0;

	/// <summary>
	/// Converts the given integer to its Roman numeral representation.
	/// </summary>
	/// <param name="number">The integer to convert. Must be in the range 1 to 3999.</param>
	/// <returns>A string containing the Roman numeral representation of the given integer.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="number" /> is outside the range 1 to 3999.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToRomanNumeral), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static string ToRomanNumeral(this int number)
	{
		if (number is < 1 or > 3999)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.ValueMustBeInTheRange13999, nameof(number));
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var count = 0; count < _romanValues.Length; count++)
			{
				while (number >= _romanValues[count])
				{
					number -= _romanValues[count];
					_ = sb.Append(_romanNumerals[count]);
				}
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Converts the integer value to a string representation if it falls outside the specified range. Otherwise, returns a default text.
	/// </summary>
	/// <param name="value">The integer value to evaluate.</param>
	/// <param name="lowerLimit">The inclusive lower limit of the range. If <paramref name="value" /> is less than or equal to this, <paramref name="defaultText" /> is returned.</param>
	/// <param name="upperLimit">The exclusive upper limit of the range. If <paramref name="value" /> is greater than this, <paramref name="defaultText" /> is returned.</param>
	/// <param name="defaultText">The default text to return if <paramref name="value" /> falls outside the specified range. Defaults to a double quote.</param>
	/// <returns>A string representation of <paramref name="value" /> if it falls outside the specified range; otherwise, <paramref name="defaultText" />.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToStringOrEmpty), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static string ToStringOrEmpty(this in int value, in int lowerLimit = 100, in int upperLimit = 9000, string defaultText = ControlChars.DoubleQuote) => value <= lowerLimit || value > upperLimit
			? defaultText
			: value.ToString(CultureInfo.InvariantCulture);

	/// <summary>
	/// Converts the specified integer value to its equivalent in English words.
	/// </summary>
	/// <param name="value">The integer value to convert.</param>
	/// <returns>A string that represents the specified integer value in English words.</returns>
	/// <example>
	/// Input: 54928 Output: Fifty-Four Thousand Nine Hundred and Twenty-Eight"
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToWords), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static string ToWords(this int value)
	{
		if (value == 0)
		{
			return Resources.Zero;
		}

		if (value < 0)
		{
			return $"{Resources.Minus}{ControlChars.Space}{ToWords(Math.Abs(value))}";
		}

		var words = string.Empty;

		if ((value / 1000000) > 0)
		{
			words += $"{ToWords(value / 1000000)}{ControlChars.Space}{Resources.Million}{ControlChars.Space}";
			value %= 1000000;
		}

		if ((value / 1000) > 0)
		{
			words += $"{ToWords(value / 1000)}{ControlChars.Space}{Resources.Thousand}{ControlChars.Space}";
			value %= 1000;
		}

		if ((value / 100) > 0)
		{
			words += $"{ToWords(value / 100)}{ControlChars.Space}{Resources.Hundred}{ControlChars.Space}";
			value %= 100;
		}

		if (value > 0)
		{
			if (string.IsNullOrEmpty(words) is false)
			{
				words += $"{Resources.AndLowerCase}{ControlChars.Space}";
			}

			var units = new[]
			{
				Resources.Zero,
				Resources.One,
				Resources.Two,
				Resources.Three,
				Resources.Four,
				Resources.Five,
				Resources.Six,
				Resources.Seven,
				Resources.Eight,
				Resources.Nine,
				Resources.Ten,
				Resources.Eleven,
				Resources.Twelve,
				Resources.Thirteen,
				Resources.Fourteen,
				Resources.Fifteen,
				Resources.Sixteen,
				Resources.Seventeen,
				Resources.Eighteen,
				Resources.Nineteen
			};

			var tens = new[]
			{
				Resources.Zero,
				Resources.Ten,
				Resources.Twenty,
				Resources.Thirty,
				Resources.Forty,
				Resources.Fifty,
				Resources.Sixty,
				Resources.Seventy,
				Resources.Eighty,
				Resources.Ninety
			};

			if (value < 20)
			{
				words += units[value];
			}
			else
			{
				words += tens[value / 10];

				if ((value % 10) > 0)
				{
					words += $"{ControlChars.Dash}{units[value % 10]}";
				}
			}
		}

		return words;
	}

}
