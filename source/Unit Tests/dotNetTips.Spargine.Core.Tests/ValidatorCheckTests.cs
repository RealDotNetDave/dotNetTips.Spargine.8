// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 04-13-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-19-2024
// ***********************************************************************
// <copyright file="ValidatorCheckTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ValidatorCheckTests
{
	[TestMethod]
	public void ArgumentIsInRangeDateTimeTest()
	{
		var lowerValue = new DateTime(2021, 3, 3);
		var outOfRangeLower = new DateTime(1900, 3, 3);
		var outOfRangeUpper = new DateTime(1991, 3, 3);
		var testValue = new DateTime(2022, 3, 20);
		var upperValue = new DateTime(2025, 3, 3);

		Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

		Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLower, outOfRangeUpper));

		// Test Exception throwing.
		_ = Assert.ThrowsException<InvalidValueException<DateTime>>(
			() => testValue.CheckIsInRange(outOfRangeLower, outOfRangeUpper, true));
	}

	[TestMethod]
	public void CheckEqualsTest()
	{
		// Good Test
		Assert.IsTrue(typeof(Person<Address>).CheckEquals(typeof(Person<Address>)));

		// Test Exception throwing.
		_ = Assert.ThrowsException<InvalidValueException<Type>>(
			() => typeof(Person<Address>).CheckEquals(
				typeof(DotNetTips.Spargine.Tester.Models.ValueTypes.Person<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>),
				true));
	}

	[TestMethod]
	public void CheckIsDefinedEnumTest()
	{
		var value = BenchmarkStatus.Completed;

		// Good test
		Assert.IsTrue(value.CheckIsDefined());

		// Test Exception throwing.
		_ = Assert.ThrowsException<InvalidValueException<Enum>>(() => ((BenchmarkStatus)100).CheckIsDefined(true));
	}

	[TestMethod]
	public void CheckIsInRangeDateOnlyTest()
	{
		var lowerValue = new DateOnly(2021, 3, 3);
		var upperValue = new DateOnly(2025, 3, 3);
		var testValue = new DateOnly(2022, 3, 20);
		var outOfRangeLowerValue = new DateOnly(1900, 3, 3);
		var outOfRangeUpperValue = new DateOnly(1991, 3, 3);

		Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

		Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

		// Test Exception
		_ = Assert.ThrowsException<InvalidValueException<DateOnly>>(
			() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
	}

	[TestMethod]
	public void CheckIsInRangeDateTimeOffsetTest()
	{
		var lowerValue = new DateTimeOffset(new DateTime(2021, 3, 3));
		var upperValue = new DateTimeOffset(new DateTime(2025, 3, 3));
		var testValue = new DateTimeOffset(new DateTime(2022, 3, 20));
		var outOfRangeLowerValue = new DateTimeOffset(new DateTime(1900, 3, 3));
		var outOfRangeUpperValue = new DateTimeOffset(new DateTime(1991, 3, 3));

		Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

		Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

		// Test Exception
		_ = Assert.ThrowsException<InvalidValueException<DateTimeOffset>>(
			() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
	}

	[TestMethod]
	public void CheckIsInRangeDecimalTest()
	{
		var testValue = 10000m;

		Assert.IsTrue(testValue.CheckIsInRange(0, decimal.MaxValue));

		Assert.IsFalse(testValue.CheckIsInRange(0, 100));

		// Test Exception
		_ = Assert.ThrowsException<InvalidValueException<decimal>>(() => testValue.CheckIsInRange(0, 100, true));
	}

	[TestMethod]
	public void CheckIsInRangeDoubleTest()
	{
		double testValue = 1000;

		Assert.IsTrue(testValue.CheckIsInRange(0, double.MaxValue));

		Assert.IsFalse(testValue.CheckIsInRange(0, 100));

		// Test Exception
		_ = Assert.ThrowsException<InvalidValueException<double>>(() => testValue.CheckIsInRange(0, 100, true));
	}

	[TestMethod]
	public void CheckIsInRangeIntTest()
	{
		var testValue = 1000;

		Assert.IsTrue(testValue.CheckIsInRange(0, int.MaxValue));

		Assert.IsFalse(testValue.CheckIsInRange(0, 100));

		// Test Exception
		_ = Assert.ThrowsException<InvalidValueException<int>>(() => testValue.CheckIsInRange(0, 100, true));
	}

	[TestMethod]
	public void CheckIsInRangeLongTest()
	{
		long testValue = 1000;

		Assert.IsTrue(testValue.CheckIsInRange(0, long.MaxValue));

		Assert.IsFalse(testValue.CheckIsInRange(0, 100));

		// Test Exception
		_ = Assert.ThrowsException<InvalidValueException<long>>(() => testValue.CheckIsInRange(0, 100, true));
	}

	[TestMethod]
	public void CheckIsInRangeTimeOnlyTest()
	{
		var lowerValue = new TimeOnly(1, 3, 3);
		var upperValue = new TimeOnly(10, 3, 3);
		var testValue = new TimeOnly(5, 3, 20);
		var outOfRangeLowerValue = new TimeOnly(1, 3, 3);
		var outOfRangeUpperValue = new TimeOnly(2, 3, 3);

		Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

		Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

		// Test Exception
		_ = Assert.ThrowsException<InvalidValueException<TimeOnly>>(
			() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
	}

	[TestMethod]
	public void CheckIsNotEmptyReadOnlySpanTest01()
	{
		ReadOnlySpan<Person<Address>> people = RandomData.GeneratePersonRefCollection<Address>(10).ToArray();
		var emptyPeople = ReadOnlySpan<Person<Address>>.Empty;

		Assert.IsTrue(people.CheckIsNotEmpty());

		Assert.IsFalse(emptyPeople.CheckIsNotEmpty());

		// Test Exception
		//_ = Assert.ThrowsException < InvalidValueException<ReadOnlySpan<Person<Address>>>(() => emptyPeople.CheckIsNotEmpty(true));
	}

	[TestMethod]
	public void CheckIsNotNullObjectTest()
	{
		var testPerson = RandomData.GeneratePersonRef<Address>();
		Person<Address> invalidValue = null;

		Assert.IsTrue(testPerson.CheckIsNotNull());

		Assert.IsFalse(invalidValue.CheckIsNotNull());

		// Test Exception
		_ = Assert.ThrowsException<ArgumentNullException>(() => invalidValue.CheckIsNotNull(true));
	}

	[TestMethod]
	public void CheckIsNotNullOrEmptyGuidTest()
	{
		var value = Guid.NewGuid();

		Assert.IsTrue(value.CheckIsNotEmpty());

		Assert.IsFalse(Guid.Empty.CheckIsNotEmpty());

		// Test Exception
		_ = Assert.ThrowsException<InvalidOperationException>(() => Guid.Empty.CheckIsNotEmpty(true));
	}

	[TestMethod]
	public void CheckItemsExistsIEnumerableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(10).AsEnumerable();
		IEnumerable<Person<Address>> nullPeople = null;

		Assert.IsTrue(people.CheckItemsExists());

		Assert.IsFalse(nullPeople.CheckItemsExists());
	}

	[TestMethod]
	public void ConditionCheckTest()
	{
		var personProper = RandomData.GeneratePersonRef<Address>();

		Assert.IsTrue(personProper.CheckIsCondition(personProper.Id.IsNotEmpty(), errorMessage: "Should be true."));
		Assert.IsFalse(personProper.CheckIsCondition(personProper.Id.IsEmpty(), errorMessage: "Should be false."));

		Person<Address> nullPerson = null;
		_ = Assert.ThrowsException<ArgumentNullException>(
			() => nullPerson.CheckIsCondition(personProper.Id.IsNotEmpty(), true));
	}

	[TestMethod]
	public void ExistsCheckDirectoryInfoTest()
	{
		var directoryName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		var directoryInfo = new DirectoryInfo(directoryName);

		try
		{
			_ = directoryInfo.CheckExists(true);
		}
		catch
		{
			Assert.Fail();
		}

		DirectoryInfo nullDirectoryInfo = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullDirectoryInfo.CheckExists(true));

		_ = Assert.ThrowsException<DirectoryNotFoundException>(
			() => new DirectoryInfo("fakefile").CheckExists(throwException: true));
	}

	[TestMethod]
	public void ExistsCheckFileInfoTest()
	{
		var fileName = RandomData.GenerateRandomFileName();

		_ = RandomData.GenerateFile(fileName, 500);

		var fileInfo = new FileInfo(fileName);

		try
		{
			_ = fileInfo.CheckExists(true);
		}
		catch
		{
			Assert.Fail();
		}

		FileInfo nullFileInfo = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullFileInfo.CheckExists(true));

		_ = Assert.ThrowsException<FileNotFoundException>(() => new FileInfo("fakefile").CheckExists(true));
	}

	[TestMethod]
	public void IsNotNullCheckTest()
	{
		try
		{
			var personProper = RandomData.GeneratePersonRef<Address>();
			_ = personProper.CheckIsNotNull(throwException: true);
		}
		catch
		{
			Assert.Fail();
		}
	}
}
