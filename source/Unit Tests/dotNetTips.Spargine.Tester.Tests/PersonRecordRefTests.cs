// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
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
	[ExpectedException(typeof(ArgumentNullException))]
	public void PersonRecord_Constructor_NullId_ThrowsArgumentNullException()
	{
		// Arrange
		var email = "test@example.com";

		// Act
		_ = new PersonRecord(email, null);
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
	public void PersonRecord_ToString_ReturnsCorrectString()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "123");
		var expectedString = personRecord.PropertiesToString();

		// Act
		var result = personRecord.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}
}
