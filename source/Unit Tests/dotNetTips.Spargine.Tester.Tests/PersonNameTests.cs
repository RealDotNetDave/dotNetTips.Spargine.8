// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="PersonNameTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;
[TestClass]
public class PersonNameTests
{
	[TestMethod]
	public void PersonName_Constructor_Default_CreatesInstance()
	{
		// Act
		var personName = new PersonName();

		// Assert
		Assert.IsNotNull(personName);
		Assert.AreEqual(string.Empty, personName.FirstName);
		Assert.AreEqual(string.Empty, personName.LastName);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void PersonName_Constructor_NullFirstName_ThrowsArgumentNullException()
	{
		// Arrange
		var lastName = "Doe";

		// Act
		_ = new PersonName(null, lastName);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void PersonName_Constructor_NullLastName_ThrowsArgumentNullException()
	{
		// Arrange
		var firstName = "John";

		// Act
		_ = new PersonName(firstName, null);
	}
	[TestMethod]
	public void PersonName_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var firstName = "John";
		var lastName = "Doe";

		// Act
		var personName = new PersonName(firstName, lastName);

		// Assert
		Assert.IsNotNull(personName);
		Assert.AreEqual(firstName, personName.FirstName);
		Assert.AreEqual(lastName, personName.LastName);
	}

	[TestMethod]
	public void PersonName_FullName_ReturnsCorrectFullName()
	{
		// Arrange
		var firstName = "John";
		var lastName = "Doe";
		var expectedFullName = "John Doe";

		// Act
		var personName = new PersonName(firstName, lastName);

		// Assert
		Assert.AreEqual(expectedFullName, personName.FullName);
	}
}
