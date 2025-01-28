// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 07-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="GuidExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class GuidExtensionsTests
{

	[TestMethod]
	public void ToDigits()
	{
		var result = Guid.NewGuid().ToDigits();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ToDigits_EmptyGuid_ReturnsEmptyString()
	{
		// Arrange
		var guid = Guid.Empty;

		// Act
		var result = guid.ToDigits();

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void ToDigits_ValidGuid_CorrectFormat()
	{
		// Arrange
		var guid = Guid.NewGuid();

		// Act
		var result = guid.ToDigits();

		// Assert
		Assert.IsTrue(Guid.TryParseExact(result, "N", out _));
	}

	[TestMethod]
	public void ToDigits_ValidGuid_NotEmptyString()
	{
		// Arrange
		var guid = Guid.NewGuid();

		// Act
		var result = guid.ToDigits();

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void ToDigits_ValidGuid_ReturnsStringWithoutDashes()
	{
		// Arrange
		var guid = Guid.NewGuid();

		// Act
		var result = guid.ToDigits();

		// Assert
		Assert.AreEqual(32, result.Length);
		Assert.IsFalse(result.Contains('-'));
	}
}
