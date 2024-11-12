// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-12-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-12-2024
// ***********************************************************************
// <copyright file="PasswordGeneratorTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Linq;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Security;

[TestClass]
public class PasswordGeneratorTests
{

	[TestMethod]
	public void GeneratePassword_ContainsRequiredCharacters()
	{
		// Arrange
		int length = 12;

		// Act
		var password = PasswordGenerator.GeneratePassword(length);

		// Assert
		Assert.IsTrue(password.Any(char.IsUpper), "Password should contain at least one uppercase letter.");
		Assert.IsTrue(password.Any(char.IsLower), "Password should contain at least one lowercase letter.");
		Assert.IsTrue(password.Any(char.IsDigit), "Password should contain at least one digit.");
		Assert.IsTrue(password.Any(ch => "!@#$%^&*()_-+=<>?".Contains(ch)), "Password should contain at least one special character.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void GeneratePassword_InvalidLength_ThrowsException()
	{
		// Arrange
		int length = 7;

		// Act
		PasswordGenerator.GeneratePassword(length);

		// Assert is handled by ExpectedException
	}
	[TestMethod]
	public void GeneratePassword_ValidLength_ReturnsPassword()
	{
		// Arrange
		int length = 12;

		// Act
		var password = PasswordGenerator.GeneratePassword(length);

		// Assert
		Assert.IsNotNull(password);
		Assert.AreEqual(length, password.Length);
	}
}

