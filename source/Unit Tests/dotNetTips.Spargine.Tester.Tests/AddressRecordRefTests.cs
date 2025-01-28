// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="AddressRecordRefTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AddressRecordRefTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddressRecord_Constructor_NullId_ThrowsArgumentNullException()
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
		_ = new AddressRecord(null, address1, address2, city, state, countyProvince, country, postalCode, phone);
	}
	[TestMethod]
	public void AddressRecord_Constructor_ValidParameters_CreatesInstance()
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
		var addressRecord = new AddressRecord(id, address1, address2, city, state, countyProvince, country, postalCode, phone);

		// Assert
		Assert.IsNotNull(addressRecord);
		Assert.AreEqual(id, addressRecord.Id);
		Assert.AreEqual(address1, addressRecord.Address1);
		Assert.AreEqual(address2, addressRecord.Address2);
		Assert.AreEqual(city, addressRecord.City);
		Assert.AreEqual(state, addressRecord.State);
		Assert.AreEqual(countyProvince, addressRecord.CountyProvince);
		Assert.AreEqual(country, addressRecord.Country);
		Assert.AreEqual(postalCode, addressRecord.PostalCode);
		Assert.AreEqual(phone, addressRecord.Phone);
	}

	[TestMethod]
	public void AddressRecord_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("124", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = addressRecord1.Equals(addressRecord2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AddressRecord_Equals_SameValues_ReturnsTrue()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var result = addressRecord1.Equals(addressRecord2);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void AddressRecord_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("124", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var hashCode1 = addressRecord1.GetHashCode();
		var hashCode2 = addressRecord2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void AddressRecord_GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var hashCode1 = addressRecord1.GetHashCode();
		var hashCode2 = addressRecord2.GetHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void AddressRecord_OperatorEquals_SameValues_ReturnsTrue()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var result = addressRecord1 == addressRecord2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void AddressRecord_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("123", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("124", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = addressRecord1 != addressRecord2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void AddressRecord_Properties_SetAndGetValues()
	{
		// Arrange
		var addressRecord = new AddressRecord("123");
		var address1 = "123 Main St";
		var address2 = "Apt 4B";
		var city = "Anytown";
		var state = "CA";
		var countyProvince = "AnyCounty";
		var country = "USA";
		var postalCode = "12345";
		var phone = "555-1234";

		// Act
		addressRecord = addressRecord with
		{
			Address1 = address1,
			Address2 = address2,
			City = city,
			State = state,
			CountyProvince = countyProvince,
			Country = country,
			PostalCode = postalCode,
			Phone = phone
		};

		// Assert
		Assert.AreEqual(address1, addressRecord.Address1);
		Assert.AreEqual(address2, addressRecord.Address2);
		Assert.AreEqual(city, addressRecord.City);
		Assert.AreEqual(state, addressRecord.State);
		Assert.AreEqual(countyProvince, addressRecord.CountyProvince);
		Assert.AreEqual(country, addressRecord.Country);
		Assert.AreEqual(postalCode, addressRecord.PostalCode);
		Assert.AreEqual(phone, addressRecord.Phone);
	}
}
