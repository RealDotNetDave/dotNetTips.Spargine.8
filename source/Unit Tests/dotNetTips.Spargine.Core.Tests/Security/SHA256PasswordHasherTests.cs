// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-04-2024
// ***********************************************************************
// <copyright file="SHA256PasswordHasherTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Text;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Security;

[TestClass]
public class SHA256PasswordHasherTests
{

	[TestMethod]
	public void FixedTimeEquals_DifferentInputs_ReturnsFalse()
	{
		// Arrange
		var left = Encoding.UTF8.GetBytes("Test");
		var right = Encoding.UTF8.GetBytes("Test2");

		// Act
		var result = SHA256PasswordHasher.FixedTimeEquals(left, right);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FixedTimeEquals_DifferentLengths_ReturnsFalse()
	{
		// Arrange
		var left = Encoding.UTF8.GetBytes("Test");
		var right = Encoding.UTF8.GetBytes("Test1");

		// Act
		var result = SHA256PasswordHasher.FixedTimeEquals(left, right);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FixedTimeEquals_EqualInputs_ReturnsTrue()
	{
		// Arrange
		var left = Encoding.UTF8.GetBytes("Test");
		var right = Encoding.UTF8.GetBytes("Test");

		// Act
		var result = SHA256PasswordHasher.FixedTimeEquals(left, right);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FixedTimeEquals_NullLeft_ThrowsArgumentNullException()
	{
		// Arrange
		var right = Encoding.UTF8.GetBytes("Test");

		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => SHA256PasswordHasher.FixedTimeEquals(null, right));
	}

	[TestMethod]
	public void FixedTimeEquals_NullRight_ThrowsArgumentNullException()
	{
		// Arrange
		var left = Encoding.UTF8.GetBytes("Test");

		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => SHA256PasswordHasher.FixedTimeEquals(left, null));
	}

	[TestMethod]
	public void VerifyHashedPassword_InvalidPassword_ReturnsFailed()
	{
		// Arrange
		var password = "TestPassword";
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		// Act
		var result = SHA256PasswordHasher.VerifyHashedPassword(hashedPassword, "WrongPassword");

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_NullPassword_ThrowsArgumentNullException()
	{
		// Arrange
		var password = "TestPassword";
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => SHA256PasswordHasher.VerifyHashedPassword(hashedPassword, null));
	}

	[TestMethod]
	public void VerifyHashedPassword_ValidInputs_ReturnsSuccess()
	{
		// Arrange
		var password = "TestPassword";
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		// Act
		var result = SHA256PasswordHasher.VerifyHashedPassword(hashedPassword, password);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

}

