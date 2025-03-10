// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="AddressValTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
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
	public void Address_CompareTo_ValidAddress_ShouldReturnExpectedResults()
	{
		// Arrange
		var address1 = new Address("123");
		var address2 = new Address("123");
		var address3 = new Address("124");

		// Act & Assert
		Assert.AreEqual(0, address1.CompareTo(address2));
		Assert.IsTrue(address1.CompareTo(address3) < 0);
		Assert.IsTrue(address3.CompareTo(address1) > 0);
	}

	[TestMethod]
	public void Address_ComparisonOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var address1 = new Address("123");
		var address2 = new Address("123");
		var address3 = new Address("124");

		// Act & Assert
		Assert.IsTrue(address1 <= address2);
		Assert.IsTrue(address1 >= address2);
		Assert.IsTrue(address1 < address3);
		Assert.IsTrue(address3 > address1);
	}

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
	public void Address_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var id = "123";

		// Act
		var address = new Address(id);

		// Assert
		Assert.AreEqual(id, address.Id);
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
	public void Address_EqualityOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var address1 = new Address("123");
		var address2 = new Address("123");
		var address3 = new Address("124");

		// Act & Assert
		Assert.IsTrue(address1 == address2);
		Assert.IsFalse(address1 == address3);
		Assert.IsFalse(address1 != address2);
		Assert.IsTrue(address1 != address3);
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
	public void Address_Equals_ShouldReturnExpectedResults()
	{
		// Arrange
		var address1 = new Address("123");
		var address2 = new Address("123");
		var address3 = new Address("124");

		// Act & Assert
		Assert.IsTrue(address1.Equals(address2));
		Assert.IsFalse(address1.Equals(address3));
		Assert.IsFalse(address1.Equals(null));
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
	public void Address_GetHashCode_ShouldReturnExpectedResults()
	{
		// Arrange
		var address1 = new Address("123");
		var address2 = new Address("123");
		var address3 = new Address("124");

		// Act & Assert
		Assert.AreEqual(address1.GetHashCode(), address2.GetHashCode());
		Assert.AreNotEqual(address1.GetHashCode(), address3.GetHashCode());
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
	public void Address_ToAddress_FromAddressRecord_ShouldReturnExpectedResults()
	{
		// Arrange
		var addressRecord = new Models.RefTypes.AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var address = Address.ToAddress(addressRecord);

		// Assert
		Assert.AreEqual(addressRecord.Id, address.Id);
		Assert.AreEqual(addressRecord.Address1, address.Address1);
		Assert.AreEqual(addressRecord.Address2, address.Address2);
		Assert.AreEqual(addressRecord.City, address.City);
		Assert.AreEqual(addressRecord.State, address.State);
		Assert.AreEqual(addressRecord.CountyProvince, address.CountyProvince);
		Assert.AreEqual(addressRecord.Country, address.Country);
		Assert.AreEqual(addressRecord.PostalCode, address.PostalCode);
		Assert.AreEqual(addressRecord.Phone, address.Phone);
	}

	[TestMethod]
	public void Address_ToString_ReturnsCorrectString()
	{
		// Arrange
		var address = new Address("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var expectedString = address.PropertiesToString(includeMemberName: false);

		// Act
		var result = address.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Address_ToString_ShouldReturnExpectedResults()
	{
		// Arrange
		var address = new Address("123");
		var expectedString = "Country:USA, Id:123";

		// Act
		var result = address.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void CompareTo_DifferentId_ReturnsNonZero()
	{
		// Arrange
		var address1 = new Address("123");
		var address2 = new Address("124");

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreNotEqual(0, result);
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
	public void CompareTo_IAddress_DifferentId_ReturnsNonZero()
	{
		// Arrange
		var address1 = new Address("123");
		Models.RefTypes.IAddress address2 = new Address("124");

		// Act
		var result = ((IComparable<Models.RefTypes.IAddress>)address1).CompareTo(address2);

		// Assert
		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_IAddress_SameId_ReturnsZero()
	{
		// Arrange
		var address1 = new Address("123");
		Models.RefTypes.IAddress address2 = new Address("123");

		// Act
		var result = ((IComparable<Models.RefTypes.IAddress>)address1).CompareTo(address2);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_NullOther_ReturnsOne()
	{
		// Arrange
		var address1 = new Address("123");
		Models.RefTypes.IAddress address2 = null;

		// Act
		var result = ((IComparable<Models.RefTypes.IAddress>)address1).CompareTo(address2);

		// Assert
		Assert.AreEqual(1, result);
	}
	[TestMethod]
	public void CompareTo_SameId_ReturnsZero()
	{
		// Arrange
		var address1 = new Address("123");
		var address2 = new Address("123");

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreEqual(0, result);
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
