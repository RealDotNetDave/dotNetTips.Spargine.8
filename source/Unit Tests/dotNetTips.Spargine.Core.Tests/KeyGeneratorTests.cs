// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-28-2024
// ***********************************************************************
// <copyright file="KeyGeneratorTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class KeyGeneratorTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GenerateKey_WithNullPrefix_ShouldThrowArgumentNullException()
	{
		// Act
		KeyGenerator.GenerateKey(null);

		// Assert is handled by ExpectedException
	}
	[TestMethod]
	public void GenerateKey_WithoutPrefix_ShouldReturnValidGuidString()
	{
		// Act
		var key = KeyGenerator.GenerateKey();

		// Assert
		Assert.IsFalse(string.IsNullOrWhiteSpace(key), "Generated key should not be null or whitespace.");
		Assert.AreEqual(32, key.Length, "Generated key should have a length of 32 characters (GUID without dashes).");

		var isValidGuid = Guid.TryParseExact(key, "N", out var parsedGuid);
		Assert.IsTrue(isValidGuid, "Generated key should be a valid GUID without dashes.");
	}

	[TestMethod]
	public void GenerateKey_WithPrefix_ShouldReturnValidPrefixedGuidString()
	{
		// Arrange
		var prefix = "Prefix";

		// Act
		var key = KeyGenerator.GenerateKey(prefix);

		// Assert
		Assert.IsTrue(key.StartsWith(prefix), "Generated key should start with the provided prefix.");
		var guidPart = key.Substring(prefix.Length);
		Assert.AreEqual(32, guidPart.Length, "The GUID part of the generated key should have a length of 32 characters (GUID without dashes).");
		Guid parsedGuid;
		var isValidGuid = Guid.TryParseExact(guidPart, "N", out parsedGuid);
		Assert.IsTrue(isValidGuid, "The GUID part of the generated key should be a valid GUID without dashes.");
	}

}
