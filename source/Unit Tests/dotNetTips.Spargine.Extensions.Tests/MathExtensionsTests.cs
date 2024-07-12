// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 07-12-2024
//
// Last Modified By : David McCarter
// Last Modified On : 07-12-2024
// ***********************************************************************
// <copyright file="MathExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;
[TestClass]
public class MathExtensionsTests
{

	[TestMethod]
	public void CalculatePercent_DoubleNegativeDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		double first = 200.0;
		double second = 100.0;

		// Expected percentage calculation: ((100 - 200) / 200) * 100 = -50%
		double expectedPercentage = -50.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a negative difference.");
	}

	[TestMethod]
	public void CalculatePercent_DoublePositiveDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		double first = 100.0;
		double second = 200.0;

		// Expected percentage calculation: ((200 - 100) / 100) * 100 = 100%
		double expectedPercentage = 100.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a positive difference.");
	}

	[TestMethod]
	public void CalculatePercent_DoubleSameValues_ReturnsZero()
	{
		// Arrange
		double first = 100.0;
		double second = 100.0;

		// Expected percentage calculation: ((100 - 100) / 100) * 100 = 0%
		double expectedPercentage = 0.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should be zero when both values are the same.");
	}

	[TestMethod]
	[ExpectedException(typeof(DivideByZeroException))]
	public void CalculatePercent_DoubleZeroFirstValue_ThrowsDivideByZeroException()
	{
		// Arrange
		double first = 0.0;
		double second = 100.0;

		// Act & Assert
		first.CalculatePercent(second);
	}

	[TestMethod]
	public void CalculatePercent_IntegerNegativeDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		int first = 200;
		int second = 100;

		// Expected percentage calculation: ((100 - 200) / 200) * 100 = -50%
		double expectedPercentage = -50.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a negative difference.");
	}
	[TestMethod]
	public void CalculatePercent_IntegerPositiveDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		int first = 100;
		int second = 200;

		// Expected percentage calculation: ((200 - 100) / 100) * 100 = 100%
		double expectedPercentage = 100.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a positive difference.");
	}

	[TestMethod]
	public void CalculatePercent_IntegerSameValues_ReturnsZero()
	{
		// Arrange
		int first = 100;
		int second = 100;

		// Expected percentage calculation: ((100 - 100) / 100) * 100 = 0%
		double expectedPercentage = 0.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should be zero when both values are the same.");
	}


	[TestMethod]
	[ExpectedException(typeof(DivideByZeroException))]
	public void CalculatePercent_IntegerZeroFirstValue_ThrowsDivideByZeroException()
	{
		// Arrange
		int first = 0;
		int second = 100;

		// Act & Assert
		first.CalculatePercent(second);
	}

	[TestMethod]
	public void CalculatePercent_LongNegativeDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		long first = 200L;
		long second = 100L;

		// Expected percentage calculation: ((100 - 200) / 200) * 100 = -50%
		double expectedPercentage = -50.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a negative difference.");
	}

	[TestMethod]
	public void CalculatePercent_LongPositiveDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		long first = 100L;
		long second = 200L;

		// Expected percentage calculation: ((200 - 100) / 100) * 100 = 100%
		double expectedPercentage = 100.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a positive difference.");
	}

	[TestMethod]
	public void CalculatePercent_LongSameValues_ReturnsZero()
	{
		// Arrange
		long first = 100L;
		long second = 100L;

		// Expected percentage calculation: ((100 - 100) / 100) * 100 = 0%
		double expectedPercentage = 0.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should be zero when both values are the same.");
	}

	[TestMethod]
	[ExpectedException(typeof(DivideByZeroException))]
	public void CalculatePercent_LongZeroFirstValue_ThrowsDivideByZeroException()
	{
		// Arrange
		long first = 0L;
		long second = 100L;

		// Act & Assert
		first.CalculatePercent(second);
	}


	[TestMethod]
	public void CalculatePercent_NegativeDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		var first = TimeSpan.FromMilliseconds(200);
		var second = TimeSpan.FromMilliseconds(100);

		// Expected percentage calculation: ((100 - 200) / 200) * 100 = -50%
		var expectedPercentage = -50.0;

		// Act
		var result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a negative difference.");
	}
	[TestMethod]
	public void CalculatePercent_PositiveDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		var first = TimeSpan.FromMilliseconds(100);
		var second = TimeSpan.FromMilliseconds(200);

		// Expected percentage calculation: ((200 - 100) / 100) * 100 = 100%
		var expectedPercentage = 100.0;

		// Act
		var result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a positive difference.");
	}

	[TestMethod]
	public void CalculatePercent_SameValues_ReturnsZero()
	{
		// Arrange
		var first = TimeSpan.FromMilliseconds(100);
		var second = TimeSpan.FromMilliseconds(100);

		// Expected percentage calculation: ((100 - 100) / 100) * 100 = 0%
		var expectedPercentage = 0.0;

		// Act
		var result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should be zero when both values are the same.");
	}

	[TestMethod]
	public void CalculatePercent_ZeroFirstValue_ThrowsDivideByZeroException()
	{
		// Arrange
		var first = TimeSpan.FromMilliseconds(0);
		var second = TimeSpan.FromMilliseconds(100);

		// Act & Assert
		Assert.ThrowsException<DivideByZeroException>(() => first.CalculatePercent(second), "Calculating percentage with a zero first value should throw DivideByZeroException.");
	}

	[TestMethod]
	public void IsPrime_GivenNegativeNumber_ReturnsFalse()
	{
		// Arrange
		int negativeNumber = -5;

		// Act
		bool result = negativeNumber.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for a negative number.");
	}

	[TestMethod]
	public void IsPrime_GivenNonPrimeNumber_ReturnsFalse()
	{
		// Arrange
		int nonPrimeNumber = 4;

		// Act
		bool result = nonPrimeNumber.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for a non-prime number.");
	}

	[TestMethod]
	public void IsPrime_GivenOne_ReturnsFalse()
	{
		// Arrange
		int number = 1;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for one.");
	}

	[TestMethod]
	public void IsPrime_GivenPrimeNumber_ReturnsTrue()
	{
		// Arrange
		int primeNumber = 13;

		// Act
		bool result = primeNumber.IsPrime();

		// Assert
		Assert.IsTrue(result, "The method should return true for a prime number.");
	}

	[TestMethod]
	public void IsPrime_GivenThree_ReturnsTrue()
	{
		// Arrange
		int number = 3;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsTrue(result, "The method should return true for three, which is a prime number.");
	}

	[TestMethod]
	public void IsPrime_GivenTwo_ReturnsTrue()
	{
		// Arrange
		int number = 2;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsTrue(result, "The method should return true for two, which is a prime number.");
	}

	[TestMethod]
	public void IsPrime_GivenZero_ReturnsFalse()
	{
		// Arrange
		int number = 0;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for zero.");
	}

	[TestMethod]
	public void Round_DecimalValue_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.5m;

		// Expected result is 3 because 2.5 rounds up to 3
		int expectedResult = 3;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer.");
	}

	[TestMethod]
	public void Round_DecimalValueHalfway_ReturnsRoundedUpInteger()
	{
		// Arrange
		decimal value = 4.5m;

		// Expected result is 5 because 4.5 rounds up to 5 according to the default rounding mechanism
		int expectedResult = 5;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding halfway cases away from zero.");
	}

	[TestMethod]
	public void Round_DecimalValueLessThanHalfway_ReturnsRoundedDownInteger()
	{
		// Arrange
		decimal value = 3.4m;

		// Expected result is 3 because 3.4 rounds down to 3
		int expectedResult = 3;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding down when less than halfway.");
	}

	[TestMethod]
	public void Round_DecimalValueMoreThanHalfway_ReturnsRoundedUpInteger()
	{
		// Arrange
		decimal value = 6.6m;

		// Expected result is 7 because 6.6 rounds up to 7
		int expectedResult = 7;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding up when more than halfway.");
	}
	[TestMethod]
	public void Round_DecimalValueWithAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.5m;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 with AwayFromZero should result in 3.");
	}
	[TestMethod]
	public void Round_DecimalValueWithDigitsAndAwayFromZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = 2.55m;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		decimal expectedResult = 2.6m;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.55 to 1 decimal place with AwayFromZero should result in 2.6.");
	}

	[TestMethod]
	public void Round_DecimalValueWithDigitsAndToEvenRounding_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = 2.55m;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToEven;
		decimal expectedResult = 2.6m;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.55 to 1 decimal place with ToEven should result in 2.6.");
	}

	[TestMethod]
	public void Round_DecimalValueWithHighDigits_NoChange()
	{
		// Arrange
		decimal value = 2.555m;
		int digits = 10; // A high number of decimal places should not change the value before converting to int
		int expectedResult = 3; // 2.555 remains 2.555, which rounds to 3

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.555 to 10 decimal places should result in 3.");
	}

	[TestMethod]
	public void Round_DecimalValueWithHighDigitsAndToEvenRounding_NoChange()
	{
		// Arrange
		decimal value = 2.555m;
		int digits = 10; // A high number of decimal places should not change the value
		MidpointRounding mode = MidpointRounding.ToEven;
		decimal expectedResult = 2.555m; // 2.555 remains 2.555 after rounding

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.555 to 10 decimal places with ToEven should not change the value.");
	}
	[TestMethod]
	public void Round_DecimalValueWithOneDigit_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = 2.25m;
		int digits = 1;
		int expectedResult = 2;

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.25 to 1 decimal place should result in 2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithToEvenRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.5m;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = 2;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 with ToEven should result in 2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithToZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.8m;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = 2;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.8 with ToZero should result in 2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithTwoDigits_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = 2.25m;
		int digits = 2;
		int expectedResult = 2;

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.25 to 2 decimal places should result in 2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithZeroDigits_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.8m;
		int digits = 0;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.8 to 0 decimal places should result in 3.");
	}

	[TestMethod]
	public void Round_DecimalValueWithZeroDigitsAndAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.5m;
		int digits = 0;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		decimal expectedResult = 3m;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 to 0 decimal places with AwayFromZero should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValue_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.5;

		// Expected result is 3 because 2.5 rounds up to 3
		int expectedResult = 3;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer.");
	}

	[TestMethod]
	public void Round_DoubleValueHalfway_ReturnsRoundedUpInteger()
	{
		// Arrange
		double value = 4.5;

		// Expected result is 5 because 4.5 rounds up to 5 according to the default rounding mechanism
		int expectedResult = 5;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding halfway cases away from zero.");
	}

	[TestMethod]
	public void Round_DoubleValueLessThanHalfway_ReturnsRoundedDownInteger()
	{
		// Arrange
		double value = 3.4;

		// Expected result is 3 because 3.4 rounds down to 3
		int expectedResult = 3;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding down when less than halfway.");
	}

	[TestMethod]
	public void Round_DoubleValueMoreThanHalfway_ReturnsRoundedUpInteger()
	{
		// Arrange
		double value = 6.6;

		// Expected result is 7 because 6.6 rounds up to 7
		int expectedResult = 7;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding up when more than halfway.");
	}
	[TestMethod]
	public void Round_DoubleValueWithAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.5;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = 3;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 with AwayFromZero should result in 3.");
	}
	[TestMethod]
	public void Round_DoubleValueWithDigits_ReturnsRoundedValue()
	{
		// Arrange
		double value = 2.555;
		int digits = 2;
		int expectedResult = 3; // Rounding 2.555 to 2 decimal places should round up to 2.56, then to 3 when converting to int

		// Act
		int result = value.Round(digits);

		// Assert
		Assert.AreEqual(expectedResult, result, $"Rounding {value} to {digits} decimal places should result in {expectedResult}.");
	}
	[TestMethod]
	public void Round_DoubleValueWithDigitsAndAwayFromZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = 2.55;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.55 to 1 decimal place with AwayFromZero should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValueWithDigitsAndToEvenRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = 2.55;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.55 to 1 decimal place with ToEven should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValueWithHighDigits_NoChange()
	{
		// Arrange
		double value = 2.555;
		int digits = 10; // A high number of decimal places should not change the value before converting to int
		int expectedResult = 3; // 2.555 remains 2.555, which rounds to 3

		// Act
		int result = value.Round(digits);

		// Assert
		Assert.AreEqual(expectedResult, result, $"Rounding {value} to {digits} decimal places should result in {expectedResult}.");
	}

	[TestMethod]
	public void Round_DoubleValueWithHighDigitsAndToEvenRounding_NoChange()
	{
		// Arrange
		double value = 2.555;
		int digits = 10; // A high number of decimal places should not change the value before converting to int
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = 3; // 2.555 remains 2.555, which rounds to 3

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.555 to 10 decimal places with ToEven should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValueWithToEvenRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.5;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = 2;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 with ToEven should result in 2.");
	}

	[TestMethod]
	public void Round_DoubleValueWithToZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.8;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = 2;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.8 with ToZero should result in 2.");
	}

	[TestMethod]
	public void Round_DoubleValueWithZeroDigits_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.8;
		int digits = 0; // Rounding to 0 decimal places is essentially rounding to the nearest whole number
		int expectedResult = 3;

		// Act
		int result = value.Round(digits);

		// Assert
		Assert.AreEqual(expectedResult, result, $"Rounding {value} to {digits} decimal places should result in {expectedResult}.");
	}

	[TestMethod]
	public void Round_DoubleValueWithZeroDigitsAndAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.5;
		int digits = 0;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 to 0 decimal places with AwayFromZero should result in 3.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValue_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = -2.5m;

		// Expected result is -2 because -2.5 rounds up to -2
		int expectedResult = -2;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding negative halfway cases away from zero.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = -2.5m;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = -3;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.5 with AwayFromZero should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithDigits_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = -2.55m;
		int digits = 1;
		int expectedResult = -3;

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithDigitsAndAwayFromZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = -2.55m;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		decimal expectedResult = -2.6m;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place with AwayFromZero should result in -2.6.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithDigitsAndToEvenRounding_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = -2.55m;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToEven;
		decimal expectedResult = -2.6m;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place with ToEven should result in -2.6.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithToEvenRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = -2.5m;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = -2;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.5 with ToEven should result in -2.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithToZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = -2.8m;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = -2;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.8 with ToZero should result in -2.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValue_ReturnsRoundedInteger()
	{
		// Arrange
		double value = -2.5;

		// Expected result is -2 because -2.5 rounds up to -2
		int expectedResult = -2;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding negative halfway cases away from zero.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = -2.5;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = -3;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.5 with AwayFromZero should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithDigits_ReturnsRoundedValue()
	{
		// Arrange
		double value = -2.555;
		int digits = 2;
		int expectedResult = -3; // Rounding -2.555 to 2 decimal places should round up to -2.56, then to -3 when converting to int

		// Act
		int result = value.Round(digits);

		// Assert
		Assert.AreEqual(expectedResult, result, $"Rounding {value} to {digits} decimal places should result in {expectedResult}.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithDigitsAndAwayFromZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = -2.55;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = -3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place with AwayFromZero should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithDigitsAndToEvenRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = -2.55;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = -3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place with ToEven should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithToEvenRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = -2.5;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = -2;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.5 with ToEven should result in -2.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithToZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = -2.8;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = -2;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.8 with ToZero should result in -2.");
	}

	[TestMethod]
	public void Subtract_TwoIntegers_ReturnsDifference()
	{
		// Arrange
		int input = 10;
		int subtract = 5;
		double expectedResult = 5;

		// Act
		double result = MathExtensions.Subtract(input, subtract);

		// Assert
		Assert.AreEqual(expectedResult, result, "Subtracting 5 from 10 should result in 5.");
	}

}
