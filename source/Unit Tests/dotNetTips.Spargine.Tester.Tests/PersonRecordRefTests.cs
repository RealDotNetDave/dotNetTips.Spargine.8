// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-28-2025
// ***********************************************************************
// <copyright file="PersonRecordRefTests.cs" company="DotNetTips.Spargine.Tester.Tests">
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
public class PersonRecordRefTests
{
	[TestMethod]
	public void Age_CalculateAge_ReturnsCorrectAge()
	{
		// Arrange
		var bornOn = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);
		var person = new PersonRecord("test@example.com", "123")
		{
			BornOn = bornOn
		};

		// Act
		var age = person.Age;

		// Assert
		var expectedAge = DateTimeOffset.UtcNow.Subtract(bornOn);
		Assert.AreEqual(expectedAge.Days, age.Days);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void BornOn_SetFutureDate_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var futureDate = DateTimeOffset.UtcNow.AddDays(1);
		var person = new PersonRecord("test@example.com", "123");

		// Act
		person = person with { BornOn = futureDate };
	}

	[TestMethod]
	public void BornOn_SetPastDate_SetsCorrectly()
	{
		// Arrange
		var pastDate = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);
		var person = new PersonRecord("test@example.com", "123");

		// Act
		person = person with { BornOn = pastDate };

		// Assert
		Assert.AreEqual(pastDate, person.BornOn);
	}

	[TestMethod]
	public void PersonRecord_CalculateAge_ShouldReturnExpectedResults()
	{
		// Arrange
		var bornOn = new DateTimeOffset(new DateTime(1990, 1, 1));
		var personRecord = new PersonRecord("test@example.com", "123") { BornOn = bornOn };
		var expectedAge = DateTimeOffset.UtcNow.Subtract(bornOn);

		// Act
		var age = personRecord.CalculateAge();

		// Assert
		Assert.AreEqual(expectedAge.Days, age.Days);
	}

	[TestMethod]
	public void PersonRecord_CompareTo_ValidPersonRecord_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new PersonRecord("test1@example.com", "123");
		var person2 = new PersonRecord("test1@example.com", "123");
		var person3 = new PersonRecord("test2@example.com", "124");

		// Act & Assert
		Assert.AreEqual(0, person1.CompareTo(person2));
		Assert.IsTrue(person1.CompareTo(person3) < 0);
		Assert.IsTrue(person3.CompareTo(person1) > 0);
	}

	[TestMethod]
	public void PersonRecord_ComparisonOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new PersonRecord("test1@example.com", "123");
		var person2 = new PersonRecord("test1@example.com", "123");
		var person3 = new PersonRecord("test2@example.com", "124");

		// Act & Assert
		Assert.IsTrue(person1 <= person2);
		Assert.IsTrue(person1 >= person2);
		Assert.IsTrue(person1 < person3);
		Assert.IsTrue(person3 > person1);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void PersonRecord_Constructor_NullId_ThrowsArgumentNullException()
	{
		// Arrange
		var email = "test@example.com";

		// Act
		_ = new PersonRecord(email, null);
	}

	[TestMethod]
	public void PersonRecord_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var id = "123";
		var email = "test@example.com";

		// Act
		var personRecord = new PersonRecord(email, id);

		// Assert
		Assert.AreEqual(id, personRecord.Id);
		Assert.AreEqual(email, personRecord.Email);
	}
	[TestMethod]
	public void PersonRecord_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var email = "test@example.com";
		var id = "123";

		// Act
		var personRecord = new PersonRecord(email, id);

		// Assert
		Assert.IsNotNull(personRecord);
		Assert.AreEqual(email, personRecord.Email);
		Assert.AreEqual(id, personRecord.Id);
	}

	[TestMethod]
	public void PersonRecord_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var personRecord1 = new PersonRecord("test1@example.com", "123");
		var personRecord2 = new PersonRecord("test2@example.com", "124");

		// Act
		var result = personRecord1.Equals(personRecord2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void PersonRecord_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var personRecord1 = new PersonRecord("test1@example.com", "123");
		var personRecord2 = new PersonRecord("test2@example.com", "124");

		// Act
		var hashCode1 = personRecord1.GetHashCode();
		var hashCode2 = personRecord2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void PersonRecord_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var personRecord1 = new PersonRecord("test1@example.com", "123");
		var personRecord2 = new PersonRecord("test2@example.com", "124");

		// Act
		var result = personRecord1 != personRecord2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void PersonRecord_Properties_SetAndGetValues()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "123");
		var firstName = "John";
		var lastName = "Doe";
		var bornOn = new DateTimeOffset(new DateTime(1990, 1, 1));
		var cellPhone = "555-1234";
		var phone = "555-5678";
		var addresses = new Collection<AddressRecord> { new AddressRecord("1") };

		// Act
		personRecord = personRecord with
		{
			FirstName = firstName,
			LastName = lastName,
			BornOn = bornOn,
			CellPhone = cellPhone,
			Phone = phone,
			Addresses = addresses
		};

		// Assert
		Assert.AreEqual(firstName, personRecord.FirstName);
		Assert.AreEqual(lastName, personRecord.LastName);
		Assert.AreEqual(bornOn, personRecord.BornOn);
		Assert.AreEqual(cellPhone, personRecord.CellPhone);
		Assert.AreEqual(phone, personRecord.Phone);
	}

	[TestMethod]
	public void PersonRecord_ToPersonRecord_FromPerson_ShouldReturnExpectedResults()
	{
		// Arrange
		var person = new Person<Address>("test@example.com", "123")
		{
			FirstName = "John",
			LastName = "Doe",
			BornOn = new DateTimeOffset(new DateTime(1990, 1, 1)),
			CellPhone = "555-1234",
			Phone = "555-5678",
			Addresses = new Collection<Address> { new Address("1") }
		};

		// Act
		var personRecord = PersonRecord.ToPersonRecord(person);

		// Assert
		Assert.AreEqual(person.Id, personRecord.Id);
		Assert.AreEqual(person.Email, personRecord.Email);
		Assert.AreEqual(person.FirstName, personRecord.FirstName);
		Assert.AreEqual(person.LastName, personRecord.LastName);
		Assert.AreEqual(person.BornOn, personRecord.BornOn);
		Assert.AreEqual(person.CellPhone, personRecord.CellPhone);
		Assert.AreEqual(person.Phone, personRecord.Phone);
		Assert.AreEqual(person.Addresses.Count, personRecord.Addresses.Count);
	}

	[TestMethod]
	public void PersonRecord_ToPersonRecord_FromValueTypesPerson_ShouldReturnExpectedResults()
	{
		// Arrange
		var valueTypesPerson = new Models.ValueTypes.Person<Models.ValueTypes.Address>("123", "test@example.com")
		{
			FirstName = "John",
			LastName = "Doe",
			BornOn = new DateTimeOffset(new DateTime(1990, 1, 1)),
			CellPhone = "555-1234",
			Phone = "555-5678",
			Addresses = new Collection<Models.ValueTypes.Address> { new Models.ValueTypes.Address("1") }
		};

		// Act
		var personRecord = PersonRecord.ToPersonRecord(valueTypesPerson);

		// Assert
		Assert.AreEqual(valueTypesPerson.Id, personRecord.Id);
		Assert.AreEqual(valueTypesPerson.Email, personRecord.Email);
		Assert.AreEqual(valueTypesPerson.FirstName, personRecord.FirstName);
		Assert.AreEqual(valueTypesPerson.LastName, personRecord.LastName);
		Assert.AreEqual(valueTypesPerson.BornOn, personRecord.BornOn);
		Assert.AreEqual(valueTypesPerson.CellPhone, personRecord.CellPhone);
		Assert.AreEqual(valueTypesPerson.Phone, personRecord.Phone);
		Assert.AreEqual(valueTypesPerson.Addresses.Count, personRecord.Addresses.Count);
	}

	[TestMethod]
	public void PersonRecord_ToString_ReturnsCorrectString()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "123");
		var expectedString = personRecord.PropertiesToString(includeMemberName: false);

		// Act
		var result = personRecord.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void PersonRecord_ToString_ShouldReturnExpectedResults()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "123");
		var expectedString = "BornOn:1/1/0001 12:00:00 AM +00:00, Email:test@example.com, Id:123";

		// Act
		var result = personRecord.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void ToString_Test()
	{
		// Arrange
		var personRecord = RandomData.GeneratePersonRecord();

		var result = personRecord.ToString();

		Assert.IsNotNull(result);
	}
}
