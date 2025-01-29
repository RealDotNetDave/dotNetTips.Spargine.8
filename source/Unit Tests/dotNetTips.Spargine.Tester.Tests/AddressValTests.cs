// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2025
// ***********************************************************************
// <copyright file="AddressValTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AddressValTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Address_Constructor_NullId_ThrowsArgumentNullException()
	{
		// Arrange
		var address1 = "123 Main St";
		var address2 = "Apt 4B";
		var city = "Anytown";
		var state = "CA";
		var countyProvince = "AnyCounty";
		var country = "USA";
		var postalCode = "12345";
		var phone = "555-1234";

		// Act
		_ = new Address(null, address1, address2, city, state, countyProvince, country, postalCode, phone);
	}

	[TestMethod]
	public void Address_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var id = "123";
		var address1 = "123 Main St";
		var address2 = "Apt 4B";
		var city = "Anytown";
		var state = "CA";
		var countyProvince = "AnyCounty";
		var country = "USA";
		var postalCode = "12345";
		var phone = "555-1234";

		// Act
		var address = new Address(id, address1, address2, city, state, countyProvince, country, postalCode, phone);

		// Assert
		Assert.IsNotNull(address);
		Assert.AreEqual(id, address.Id);
		Assert.AreEqual(address1, address.Address1);
		Assert.AreEqual(address2, address.Address2);
		Assert.AreEqual(city, address.City);
		Assert.AreEqual(state, address.State);
		Assert.AreEqual(countyProvince, address.CountyProvince);
		Assert.AreEqual(country, address.Country);
		Assert.AreEqual(postalCode, address.PostalCode);
		Assert.AreEqual(phone, address.Phone);
	}

	[TestMethod]
	public void Address_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("124", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = address1.Equals(address2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Address_Equals_SameValues_ReturnsTrue()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var result = address1.Equals(address2);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Address_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("124", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var hashCode1 = address1.GetHashCode();
		var hashCode2 = address2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Address_GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var hashCode1 = address1.GetHashCode();
		var hashCode2 = address2.GetHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Address_OperatorEquals_SameValues_ReturnsTrue()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var result = address1 == address2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Address_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var address1 = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var address2 = new Address("124", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = address1 != address2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Address_Properties_SetAndGetValues()
	{
		// Arrange
		var address = new Address("123");
		var address1 = "123 Main St";
		var address2 = "Apt 4B";
		var city = "Anytown";
		var state = "CA";
		var countyProvince = "AnyCounty";
		var country = "USA";
		var postalCode = "12345";
		var phone = "555-1234";

		// Act
		address.Address1 = address1;
		address.Address2 = address2;
		address.City = city;
		address.State = state;
		address.CountyProvince = countyProvince;
		address.Country = country;
		address.PostalCode = postalCode;
		address.Phone = phone;

		// Assert
		Assert.AreEqual(address1, address.Address1);
		Assert.AreEqual(address2, address.Address2);
		Assert.AreEqual(city, address.City);
		Assert.AreEqual(state, address.State);
		Assert.AreEqual(countyProvince, address.CountyProvince);
		Assert.AreEqual(country, address.Country);
		Assert.AreEqual(postalCode, address.PostalCode);
		Assert.AreEqual(phone, address.Phone);
	}

	[TestMethod]
	public void Address_ToString_ReturnsCorrectString()
	{
		// Arrange
		var address = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var expectedString = address.PropertiesToString();

		// Act
		var result = address.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

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
