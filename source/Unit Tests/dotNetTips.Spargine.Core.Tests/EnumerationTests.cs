// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-27-2024
// ***********************************************************************
// <copyright file="EnumerationTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerationTests
{

	[TestMethod]
	public void AbsoluteDifferenceTest()
	{
		Assert.IsTrue(DateTimeFormat.AbsoluteDifference(DateTimeFormat.MonthDay, DateTimeFormat.MonthYear) > 0);
	}

	[TestMethod]
	public void DisplayNameTest()
	{
		Assert.IsNotNull(DateTimeFormat.MonthDay.DisplayName);
	}


	[TestMethod]
	public void EqualsTest()
	{
		var dateTimeFormat = DateTimeFormat.FullDateLongTime;

		Assert.IsTrue(dateTimeFormat.Equals(DateTimeFormat.FullDateLongTime));
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
