// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 06-13-2024
// ***********************************************************************
// <copyright file="MathExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods tailored for Math.</summary>
// ***********************************************************************
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for mathematical operations, enhancing the built-in Math class with additional functionality and utilities.
/// These methods include operations such as addition, subtraction, rounding, and calculating percentages, as well as determining if a number is prime.
/// </summary>
public static class MathExtensions
{

	/// <summary>
	/// Adds the specified number to the input value.
	/// </summary>
	/// <param name="input">The base value.</param>
	/// <param name="add">The number to add.</param>
	/// <returns>The sum of the input value and the specified number.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/19/2022", Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static double Add(this int input, int add) => input + add;

	/// <summary>
	/// Calculates the percentage difference between two <see cref="TimeSpan" /> values.
	/// </summary>
	/// <param name="first">The first <see cref="TimeSpan" /> value.</param>
	/// <param name="second">The second <see cref="TimeSpan" /> value, to compare with the first.</param>
	/// <returns>The percentage difference between the first and second <see cref="TimeSpan" /> values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculatePercent), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static double CalculatePercent(this TimeSpan first, TimeSpan second) => (second.TotalMilliseconds - first.TotalMilliseconds) / Math.Abs(first.TotalMilliseconds) * 100;

	/// <summary>
	/// Calculates the percentage difference between two integers.
	/// </summary>
	/// <param name="first">The first integer value.</param>
	/// <param name="second">The second integer value, to compare with the first.</param>
	/// <returns>The percentage difference between the first and second integer values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculatePercent), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static double CalculatePercent(this int first, int second) => (second - first) / Math.Abs(first) * 100;

	/// <summary>
	/// Calculates the percentage difference between two double values.
	/// </summary>
	/// <param name="first">The first double value.</param>
	/// <param name="second">The second double value, to compare with the first.</param>
	/// <returns>The percentage difference between the first and second double values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculatePercent), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static double CalculatePercent(this double first, double second) => (second - first) / Math.Abs(first) * 100;

	/// <summary>
	/// Calculates the percentage difference between two long integer values.
	/// </summary>
	/// <param name="first">The first long integer value.</param>
	/// <param name="second">The second long integer value, to compare with the first.</param>
	/// <returns>The percentage difference between the first and second long integer values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculatePercent), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static double CalculatePercent(this long first, long second) => (second - first) / Math.Abs(first) * 100;

	/// <summary>
	/// Determines whether the specified number is prime.
	/// </summary>
	/// <param name="number">The number to check for primality.</param>
	/// <returns><c>true</c> if the specified number is prime; otherwise, <c>false</c>.</returns>
	/// <remarks>A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.
	/// This method efficiently checks for primality by eliminating divisible numbers early.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsPrime), author: "David McCarter", createdOn: "7/15/2022", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool IsPrime(this int number)
	{
		if (number < 2)
		{
			return false;
		}

		if (number is 2 or 3)
		{
			return true;
		}

		if (number % 2 == 0 || number % 3 == 0)
		{
			return false;
		}

		var sqrtN = (int)Math.Sqrt(number);

		for (var count = 5; count <= sqrtN; count += 6)
		{
			if (number % count == 0 || number % (count + 2) == 0)
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Rounds the specified double value to the nearest integer.
	/// </summary>
	/// <param name="value">The double value to round.</param>
	/// <returns>The integer value that is closest to the specified double value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int Round(this double value) => Convert.ToInt32(Math.Round(value));

	/// <summary>
	/// Rounds the specified decimal value to the nearest integer.
	/// </summary>
	/// <param name="value">The decimal value to round.</param>
	/// <returns>The integer value that is closest to the specified decimal value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int Round(this decimal value) => Convert.ToInt32(Math.Round(value));

	/// <summary>
	/// Rounds the specified double value to a specified number of fractional digits.
	/// </summary>
	/// <param name="value">The double value to round.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <returns>The integer value that is closest to the specified double value, rounded to the specified number of fractional digits.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int Round(this double value, int digits) => Convert.ToInt32(Math.Round(value, digits));

	/// <summary>
	/// Rounds the specified double value using the specified rounding convention.
	/// </summary>
	/// <param name="value">The double value to round.</param>
	/// <param name="mode">The rounding convention to use.</param>
	/// <returns>The integer value that is closest to the specified double value, rounded according to the specified rounding convention.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="mode" /> is not a valid <see cref="MidpointRounding" /> value.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int Round(this double value, MidpointRounding mode)
	{
		mode = mode.ArgumentDefined(nameof(mode));

		return Convert.ToInt32(Math.Round(value, mode));
	}

	/// <summary>
	/// Rounds the specified decimal value to a specified number of fractional digits.
	/// </summary>
	/// <param name="value">The decimal value to round.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <returns>The integer value that is closest to the specified decimal value, rounded to the specified number of fractional digits.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int Round(this decimal value, int digits) => Convert.ToInt32(Math.Round(value, digits));

	/// <summary>
	/// Rounds the specified decimal value using the specified rounding convention.
	/// </summary>
	/// <param name="value">The decimal value to round.</param>
	/// <param name="mode">The rounding convention to use.</param>
	/// <returns>The integer value that is closest to the specified decimal value, rounded according to the specified rounding convention.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="mode" /> is not a valid <see cref="MidpointRounding" /> value.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int Round(this decimal value, MidpointRounding mode)
	{
		mode = mode.ArgumentDefined(nameof(mode));

		return Convert.ToInt32(Math.Round(value, mode));
	}

	/// <summary>
	/// Rounds the specified double value to a specified number of fractional digits using the specified rounding convention.
	/// </summary>
	/// <param name="value">The double value to round.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <param name="mode">The rounding convention to use.</param>
	/// <returns>The integer value that is closest to the specified double value, rounded to the specified number of fractional digits and according to the specified rounding convention.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="mode" /> is not a valid <see cref="MidpointRounding" /> value.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int Round(this double value, int digits, MidpointRounding mode)
	{
		mode = mode.ArgumentDefined(nameof(mode));

		return Convert.ToInt32(Math.Round(value, digits, mode));
	}

	/// <summary>
	/// Rounds the specified decimal value to a specified number of fractional digits using the specified rounding convention.
	/// </summary>
	/// <param name="value">The decimal value to round.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <param name="mode">The rounding convention to use.</param>
	/// <returns>The integer value that is closest to the specified decimal value, rounded to the specified number of fractional digits and according to the specified rounding convention.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="mode" /> is not a valid <see cref="MidpointRounding" /> value.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int Round(this decimal value, int digits, MidpointRounding mode)
	{
		mode = mode.ArgumentDefined(nameof(mode));

		return Convert.ToInt32(Math.Round(value, digits, mode));
	}

	/// <summary>
	/// Subtracts the specified number from the input value.
	/// </summary>
	/// <param name="input">The base value.</param>
	/// <param name="subtract">The number to subtract.</param>
	/// <returns>The difference between the input value and the specified number.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Subtract), author: "David McCarter", createdOn: "7/19/2022", Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static double Subtract(this int input, int subtract) => input - subtract;

}
