// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-27-2024
// ***********************************************************************
// <copyright file="EnumerationTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerationTests
{

	[TestMethod]
	public void AbsoluteDifference_NullFirstValue_ThrowsArgumentNullException()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Enumeration.AbsoluteDifference(null, DateTimeFormat.MonthDay));
	}

	[TestMethod]
	public void AbsoluteDifference_NullSecondValue_ThrowsArgumentNullException()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Enumeration.AbsoluteDifference(DateTimeFormat.MonthDay, null));
	}

	[TestMethod]
	public void AbsoluteDifference_ValidValues_ReturnsCorrectDifference()
	{
		var difference = Enumeration.AbsoluteDifference(DateTimeFormat.MonthDay, DateTimeFormat.MonthYear);
		Assert.AreEqual(Math.Abs(DateTimeFormat.MonthDay.Value - DateTimeFormat.MonthYear.Value), difference);
	}

	[TestMethod]
	public void AbsoluteDifferenceTest()
	{
		Assert.IsTrue(DateTimeFormat.AbsoluteDifference(DateTimeFormat.MonthDay, DateTimeFormat.MonthYear) > 0);
	}

	[TestMethod]
	public void CompareTo_DifferentType_ThrowsArgumentException()
	{
		var numericFormat = NumericFormat.Currency;
		var differentType = new object();
		Assert.ThrowsException<ArgumentException>(() => numericFormat.CompareTo(differentType));
	}

	[TestMethod]
	public void CompareTo_NullObject_ThrowsArgumentNullException()
	{
		var numericFormat = NumericFormat.Currency;
		Assert.ThrowsException<ArgumentNullException>(() => numericFormat.CompareTo(null));
	}

	[TestMethod]
	public void CompareTo_SameType_ReturnsCorrectComparison()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Decimal;
		var numericFormat3 = NumericFormat.Currency;

		Assert.IsTrue(numericFormat1.CompareTo(numericFormat2) < 0);
		Assert.IsTrue(numericFormat2.CompareTo(numericFormat1) > 0);
		Assert.IsTrue(numericFormat1.CompareTo(numericFormat3) == 0);
	}

	[TestMethod]
	public void DisplayNameTest()
	{
		Assert.IsNotNull(DateTimeFormat.MonthDay.DisplayName);
	}

	[TestMethod]
	public void Equals_DifferentType_ReturnsFalse()
	{
		var numericFormat = NumericFormat.Currency;
		var differentType = new object();
		Assert.IsFalse(numericFormat.Equals(differentType));
	}

	[TestMethod]
	public void Equals_NullObject_ReturnsFalse()
	{
		var numericFormat = NumericFormat.Currency;
		Assert.IsFalse(numericFormat.Equals(null));
	}

	[TestMethod]
	public void Equals_SameTypeDifferentValue_ReturnsFalse()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Decimal;
		Assert.IsFalse(numericFormat1.Equals(numericFormat2));
	}

	[TestMethod]
	public void Equals_SameTypeSameValue_ReturnsTrue()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Currency;
		Assert.IsTrue(numericFormat1.Equals(numericFormat2));
	}

	[TestMethod]
	public void EqualsTest()
	{
		var dateTimeFormat = DateTimeFormat.FullDateLongTime;

		Assert.IsTrue(dateTimeFormat.Equals(DateTimeFormat.FullDateLongTime));
	}

	[TestMethod]
	public void GetHashCode_DifferentValue_ReturnsDifferentHashCode()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Decimal;
		Assert.AreNotEqual(numericFormat1.GetHashCode(), numericFormat2.GetHashCode());
	}



	[TestMethod]
	public void GetHashCode_SameValue_ReturnsSameHashCode()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Currency;
		Assert.AreEqual(numericFormat1.GetHashCode(), numericFormat2.GetHashCode());
	}

	[TestMethod]
	public void GetHashCodeTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		Assert.IsTrue(person.GetHashCode().IsInRange(int.MinValue, int.MaxValue));
	}

	[TestMethod]
	public void ToStringTest()
	{
		var dateTimeFormat = DateTimeFormat.FullDateLongTime;

		Assert.IsTrue(string.IsNullOrEmpty(dateTimeFormat.ToString()) is false);
	}

	[TestMethod]
	public void ValueTest()
	{
		Assert.IsNotNull(DateTimeFormat.MonthDay.Value);
	}

}
