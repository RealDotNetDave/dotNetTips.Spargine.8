// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="PersonRefTests.cs" company="DotNetTips.Spargine.Tester.Tests">
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
public class PersonRefTests
{

	[TestMethod]
	public void CompareTo_DifferentId_ReturnsNonZero()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test2@example.com", "124");

		// Act
		var result = person1.CompareTo(person2);

		// Assert
		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_IPerson_DifferentId_ReturnsNonZero()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		IPerson<Address> person2 = new Person<Address>("test2@example.com", "124");

		// Act
		var result = person1.CompareTo(person2);

		// Assert
		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_IPerson_SameId_ReturnsZero()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		IPerson<Address> person2 = new Person<Address>("test2@example.com", "123");

		// Act
		var result = person1.CompareTo(person2);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_NullOther_ReturnsOne()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		IPerson<Address> person2 = null;

		// Act
		var result = person1.CompareTo(person2);

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public void CompareTo_SameId_ReturnsZero()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test2@example.com", "123");

		// Act
		var result = person1.CompareTo(person2);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Person_CalculateAge_ReturnsCorrectAge()
	{
		// Arrange
		var person = new Person<Address>("test@example.com", "123");
		var bornOn = DateTimeOffset.Now.AddYears(-30);
		person.BornOn = bornOn;
		var expectedAge = DateTimeOffset.UtcNow.Subtract(bornOn);

		// Act
		var age = person.CalculateAge();

		// Assert
		Assert.AreEqual(expectedAge.Days, age.Days);
	}

	[TestMethod]
	public void Person_CalculateAge_ShouldReturnExpectedResults()
	{
		// Arrange
		var bornOn = new DateTimeOffset(new DateTime(1990, 1, 1));
		var person = new Person<Address>("test@example.com", "123") { BornOn = bornOn };
		var expectedAge = DateTimeOffset.UtcNow.Subtract(bornOn);

		// Act
		var age = person.CalculateAge();

		// Assert
		Assert.AreEqual(expectedAge.Days, age.Days);
	}

	[TestMethod]
	public void Person_CompareTo_ValidPerson_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test1@example.com", "123");
		var person3 = new Person<Address>("test2@example.com", "124");

		// Act & Assert
		Assert.AreEqual(0, person1.CompareTo(person2));
		Assert.IsTrue(person1.CompareTo(person3) < 0);
		Assert.IsTrue(person3.CompareTo(person1) > 0);
	}

	[TestMethod]
	public void Person_ComparisonOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test1@example.com", "123");
		var person3 = new Person<Address>("test2@example.com", "124");

		// Act & Assert
		Assert.IsTrue(person1 <= person2);
		Assert.IsTrue(person1 >= person2);
		Assert.IsTrue(person1 < person3);
		Assert.IsTrue(person3 > person1);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Person_Constructor_NullEmail_ThrowsArgumentNullException()
	{
		// Arrange
		var id = "123";

		// Act
		_ = new Person<Address>(null, id);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Person_Constructor_NullId_ThrowsArgumentNullException()
	{
		// Arrange
		var email = "test@example.com";

		// Act
		_ = new Person<Address>(email, null);
	}

	[TestMethod]
	public void Person_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var id = "123";
		var email = "test@example.com";

		// Act
		var person = new Person<Address>(email, id);

		// Assert
		Assert.AreEqual(id, person.Id);
		Assert.AreEqual(email, person.Email);
	}

	[TestMethod]
	public void Person_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var email = "test@example.com";
		var id = "123";

		// Act
		var person = new Person<Address>(email, id);

		// Assert
		Assert.IsNotNull(person);
		Assert.AreEqual(email, person.Email);
		Assert.AreEqual(id, person.Id);
	}

	[TestMethod]
	public void Person_EqualityOperators_ShouldReturnExpectedResults()
	{
		var age = DateTime.UtcNow;

		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123") { BornOn = age };
		var person2 = new Person<Address>("test1@example.com", "123") { BornOn = age };
		var person3 = new Person<Address>("test2@example.com", "124") { BornOn = age };

		// Act & Assert
		Assert.IsFalse(person1 == person2);
		Assert.IsFalse(person1 == person3);
		Assert.IsTrue(person1 != person2);
		Assert.IsTrue(person1 != person3);
	}

	[TestMethod]
	public void Person_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test2@example.com", "124");

		// Act
		var result = person1.Equals(person2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Person_Equals_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test1@example.com", "123");
		var person3 = new Person<Address>("test2@example.com", "124");

		// Act & Assert
		Assert.IsFalse(person1.Equals(person2));
		Assert.IsFalse(person1.Equals(person3));
		Assert.IsFalse(person1.Equals(null));
	}

	[TestMethod]
	public void Person_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test2@example.com", "124");

		// Act
		var hashCode1 = person1.GetHashCode();
		var hashCode2 = person2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Person_GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var person1 = new Person<Address>("test@example.com", "123");
		var person2 = new Person<Address>("test@example.com", "123");

		// Act
		var hashCode1 = person1.GetHashCode();
		var hashCode2 = person2.GetHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Person_GetHashCode_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test1@example.com", "123");
		var person3 = new Person<Address>("test2@example.com", "124");

		// Act & Assert
		Assert.AreEqual(person1.GetHashCode(), person2.GetHashCode());
		Assert.AreNotEqual(person1.GetHashCode(), person3.GetHashCode());
	}

	[TestMethod]
	public void Person_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var person1 = new Person<Address>("test1@example.com", "123");
		var person2 = new Person<Address>("test2@example.com", "124");

		// Act
		var result = person1 != person2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Person_ToPerson_FromPersonRecord_ShouldReturnExpectedResults()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "123")
		{
			FirstName = "John",
			LastName = "Doe",
			BornOn = new DateTimeOffset(new DateTime(1990, 1, 1)),
			CellPhone = "555-1234",
			Phone = "555-5678",
			Addresses = new Collection<AddressRecord> { new AddressRecord("1") }
		};

		// Act
		var person = Person<Address>.ToPerson(personRecord);

		// Assert
		Assert.AreEqual(personRecord.Id, person.Id);
		Assert.AreEqual(personRecord.Email, person.Email);
		Assert.AreEqual(personRecord.FirstName, person.FirstName);
		Assert.AreEqual(personRecord.LastName, person.LastName);
		Assert.AreEqual(personRecord.BornOn, person.BornOn);
		Assert.AreEqual(personRecord.CellPhone, person.CellPhone);
		Assert.AreEqual(personRecord.Phone, person.Phone);
		Assert.AreEqual(personRecord.Addresses.Count, person.Addresses.Count);
	}

	[TestMethod]
	public void Person_ToPerson_FromValueTypesPerson_ShouldReturnExpectedResults()
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
		var person = Person<Address>.ToPerson(valueTypesPerson);

		// Assert
		Assert.AreEqual(valueTypesPerson.Id, person.Id);
		Assert.AreEqual(valueTypesPerson.Email, person.Email);
		Assert.AreEqual(valueTypesPerson.FirstName, person.FirstName);
		Assert.AreEqual(valueTypesPerson.LastName, person.LastName);
		Assert.AreEqual(valueTypesPerson.BornOn, person.BornOn);
		Assert.AreEqual(valueTypesPerson.CellPhone, person.CellPhone);
		Assert.AreEqual(valueTypesPerson.Phone, person.Phone);
		Assert.AreEqual(valueTypesPerson.Addresses.Count, person.Addresses.Count);
	}


	[TestMethod]
	public void Person_ToString_ReturnsCorrectString()
	{
		// Arrange
		var person = new Person<Address>("test@example.com", "123");
		var expectedString = person.PropertiesToString(includeMemberName: false);

		// Act
		var result = person.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Person_ToString_ShouldReturnExpectedResults()
	{
		// Arrange
		var person = new Person<Address>("test@example.com", "123");
		var expectedString = "BornOn:1/1/0001 12:00:00 AM +00:00, Email:test@example.com, Id:123";

		// Act
		var result = person.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}
}
