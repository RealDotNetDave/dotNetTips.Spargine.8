// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-29-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2025
// ***********************************************************************
// <copyright file="AddressRefTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AddressRefTests
{

	[TestMethod]
	public void CompareTo_DifferentId_ReturnsNonZero()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("124", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreNotEqual(0, result, "Expected CompareTo to return a non-zero value for addresses with different Ids.");
	}

	[TestMethod]
	public void CompareTo_DifferentIdCaseSensitive_ReturnsNonZero()
	{
		// Arrange
		var address1 = new Address("abc", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("ABC", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreEqual(0, result, "Expected CompareTo to return 0 for addresses with the same Id but different case.");
	}

	[TestMethod]
	public void CompareTo_NullAddress_ReturnsPositive()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var result = address1.CompareTo(null);

		// Assert
		Assert.IsTrue(result > 0, "Expected CompareTo to return a positive value when comparing with null.");
	}
	[TestMethod]
	public void CompareTo_SameId_ReturnsZero()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("123", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreEqual(0, result, "Expected CompareTo to return 0 for addresses with the same Id.");
	}

	[TestMethod]
	public void CompareTo_SameIdDifferentCase_ReturnsZero()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("123".ToUpper(), "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreEqual(0, result, "Expected CompareTo to return 0 for addresses with the same Id but different case.");
	}
}
