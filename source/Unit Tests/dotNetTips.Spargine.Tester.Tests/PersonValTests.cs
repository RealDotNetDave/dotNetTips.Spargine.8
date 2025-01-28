// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="PersonValTests.cs" company="DotNetTips.Spargine.Tester.Tests">
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
public class PersonValTests
{

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
	public void Person_ToString_ReturnsCorrectString()
	{
		// Arrange
		var person = new Person<Address>("test@example.com", "123");
		var expectedString = person.PropertiesToString();

		// Act
		var result = person.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}
}
