// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-05-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-09-2025
// ***********************************************************************
// <copyright file="RegexProcessorTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class RegexProcessorTests
{

	[TestMethod]
	public void ContainsFirstLastNameTest()
	{

		var result = RegexProcessor.ContainsFirstLastName("David");

		Assert.IsFalse(result);

		result = RegexProcessor.ContainsFirstLastName("David McCarter");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsWordTest()
	{
		var result = RegexProcessor.ContainsWord("100.10");

		Assert.IsFalse(result);

		result = RegexProcessor.ContainsWord("Sevendust");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCreditCardNumerTest()
	{
		var result = RegexProcessor.IsCreditCardNumber("5559494833");

		Assert.IsFalse(result);

		result = RegexProcessor.IsCreditCardNumber("5576190012341234");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCurrencyCodeTest()
	{
		var result = RegexProcessor.IsCurrencyCode("USDF");

		Assert.IsFalse(result);

		result = RegexProcessor.IsCurrencyCode("USD");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmailAddressTest()
	{
		var result = RegexProcessor.IsEmailAddress("david@microsoft");

		Assert.IsFalse(result);

		result = RegexProcessor.IsEmailAddress("david@microsoft.com");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsGuidTest()
	{
		var result = RegexProcessor.IsGuid("1234567890");

		Assert.IsFalse(result);

		result = RegexProcessor.IsGuid("19C908E3-B4C0-47AA-87E9-C93379E1E264");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsIPv4Address_EmptyString_ReturnsFalse()
	{
		// Arrange
		var emptyString = string.Empty;

		// Act
		var result = RegexProcessor.IsIPv4Address(emptyString);

		// Assert
		Assert.IsFalse(result, "The method should return false for an empty string.");
	}

	[TestMethod]
	public void IsIPv4Address_InvalidIPv4Address_ReturnsFalse()
	{
		// Arrange
		var invalidIPv4 = "999.999.999.999";

		// Act
		var result = RegexProcessor.IsIPv4Address(invalidIPv4);

		// Assert
		Assert.IsFalse(result, "The method should return false for an invalid IPv4 address.");
	}

	[TestMethod]
	public void IsIPv4Address_NullInput_ReturnsFalse()
	{
		// Act
		var result = RegexProcessor.IsIPv4Address(null);

		// Assert
		Assert.IsFalse(result, "The method should return false for a null input.");
	}

	[TestMethod]
	public void IsIPv4Address_ValidIPv4Address_ReturnsTrue()
	{
		// Arrange
		var validIPv4 = "192.168.1.1";

		// Act
		var result = RegexProcessor.IsIPv4Address(validIPv4);

		// Assert
		Assert.IsTrue(result, "The method should return true for a valid IPv4 address.");
	}

	[TestMethod]
	public void IsIPv4Address_ValidIPv6Address_ReturnsFalse()
	{
		// Arrange
		var validIPv6 = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";

		// Act
		var result = RegexProcessor.IsIPv4Address(validIPv6);

		// Assert
		Assert.IsFalse(result, "The method should return false for a valid IPv6 address.");
	}

	[TestMethod]
	public void IsIPv6Address_EmptyString_ReturnsFalse()
	{
		// Arrange
		var emptyString = string.Empty;

		// Act
		var result = RegexProcessor.IsIPv6Address(emptyString);

		// Assert
		Assert.IsFalse(result, "The method should return false for an empty string.");
	}

	[TestMethod]
	public void IsIPv6Address_InvalidIPv6Address_ReturnsFalse()
	{
		// Arrange
		var invalidIPv6 = "2001:0db8:85a3:0000:0000:8a2e:0370:7334:1234";

		// Act
		var result = RegexProcessor.IsIPv6Address(invalidIPv6);

		// Assert
		Assert.IsFalse(result, "The method should return false for an invalid IPv6 address.");
	}

	[TestMethod]
	public void IsIPv6Address_NullInput_ReturnsFalse()
	{
		// Act
		var result = RegexProcessor.IsIPv6Address(null);

		// Assert
		Assert.IsFalse(result, "The method should return false for a null input.");
	}

	[TestMethod]
	public void IsIPv6Address_ValidIPv4Address_ReturnsFalse()
	{
		// Arrange
		var validIPv4 = "192.168.1.1";

		// Act
		var result = RegexProcessor.IsIPv6Address(validIPv4);

		// Assert
		Assert.IsFalse(result, "The method should return false for a valid IPv4 address.");
	}

	[TestMethod]
	public void IsIPv6Address_ValidIPv6Address_ReturnsTrue()
	{
		// Arrange
		var validIPv6 = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";

		// Act
		var result = RegexProcessor.IsIPv6Address(validIPv6);

		// Assert
		Assert.IsTrue(result, "The method should return true for a valid IPv6 address.");
	}

	[TestMethod]
	public void IsISBNTest()
	{
		var result = RegexProcessor.IsISBN("14567890");

		Assert.IsFalse(result);

		result = RegexProcessor.IsISBN("9798878213479");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsMACTest()
	{
		var result = RegexProcessor.IsMACAddress("14567890");

		Assert.IsFalse(result);

		result = RegexProcessor.IsMACAddress("00:1A:2B:3C:4D:5E");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsSHA1HashTest()
	{
		var result = RegexProcessor.IsSHA1Hash("14567890");

		Assert.IsFalse(result);

		result = RegexProcessor.IsSHA1Hash("2ef7bde608ce5404e97d5f042f95f89f1c232871");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsUrlDomainAddressTest_EmptyAndNull()
	{
		// Test with empty string
		var resultEmpty = RegexProcessor.IsUrlDomainAddress(string.Empty);
		Assert.IsFalse(resultEmpty, "Empty string should be invalid.");

		// Test with null
		var resultNull = RegexProcessor.IsUrlDomainAddress(null);
		Assert.IsFalse(resultNull, "Null should be invalid.");
	}

	[TestMethod]
	public void IsUrlDomainAddressTest_InvalidDomains()
	{
		// Invalid domain addresses
		var invalidDomains = new string[]
		{
		"example",
		"dotnettips",
		"spargine.xyz",
		"localhost",
		"192.168.1.1",
		"example.com.au"
		};

		foreach (var domain in invalidDomains)
		{
			var result = RegexProcessor.IsUrlDomainAddress(domain);
			Assert.IsFalse(result, $"Domain '{domain}' should be invalid.");
		}
	}

	[TestMethod]
	public void IsUrlDomainAddressTest_ValidDomains()
	{
		// Valid domain addresses
		var validDomains = new string[]
		{
		"example.com",
		"dotnettips.net",
		"spargine.org",
		"microsoft.edu",
		"us-army.mil"
		};

		foreach (var domain in validDomains)
		{
			var result = RegexProcessor.IsUrlDomainAddress(domain);
			Assert.IsTrue(result, $"Domain '{domain}' should be valid.");
		}
	}



	[TestMethod]
	public void IsUrlTest()
	{
		var result = RegexProcessor.IsUrl("dotnettips");

		Assert.IsFalse(result);

		result = RegexProcessor.IsUrl(@"https://dotnetips.com");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsValidStringTest_EmptyAndNull()
	{
		// Test with empty string
		var resultEmpty = RegexProcessor.IsValidString(string.Empty);
		Assert.IsFalse(resultEmpty, "Empty string should be invalid.");

		// Test with null
		var resultNull = RegexProcessor.IsValidString(null);
		Assert.IsFalse(resultNull, "Null should be invalid.");
	}

	[TestMethod]
	public void IsValidStringTest_InvalidStrings()
	{
		// Invalid strings (if any specific cases exist that should be considered invalid)
		// Note: Based on the current implementation, all non-null strings are considered valid.
		// This test is a placeholder for future modifications or specific invalid cases.
	}

	[TestMethod]
	public void IsValidStringTest_ValidStrings()
	{
		// Valid strings
		var validStrings = new string[]
		{
		"Hello, World!",
		"1234567890",
		"@#$%^&*()_+",
		"Text with spaces",
		"Text_with_underscores",
		"Mixed123Text&Symbols"
		};

		foreach (var str in validStrings)
		{
			var result = RegexProcessor.IsValidString(str);
			Assert.IsTrue(result, $"String '{str}' should be valid.");
		}
	}

	[TestMethod]
	public void RemoveHtmlTest()
	{
		// Test with null input
		var result = RegexProcessor.RemoveHtml(null);
		Assert.IsNull(result, "Null input should return null.");

		// Test with empty string
		result = RegexProcessor.RemoveHtml(string.Empty);
		Assert.AreEqual(string.Empty, result, "Empty string should return empty string.");

		// Test with no HTML tags
		result = RegexProcessor.RemoveHtml("dotnettips");
		Assert.AreEqual("dotnettips", result, "String without HTML tags should remain unchanged.");

		// Test with HTML tags
		result = RegexProcessor.RemoveHtml("<p>dotnettips</p>");
		Assert.AreEqual("dotnettips", result, "HTML tags should be removed.");

		// Test with HTML tags and replacement
		result = RegexProcessor.RemoveHtml("<p>dotnettips</p>", "_");
		Assert.AreEqual("_dotnettips_", result, "HTML tags should be replaced with '_'.");
	}

	[TestMethod]
	public void RemoveSpecialCharTest()
	{
		// Test with null input
		var result = RegexProcessor.RemoveSpecialChar(null);
		Assert.IsNull(result, "Null input should return null.");

		// Test with empty string
		result = RegexProcessor.RemoveSpecialChar(string.Empty);
		Assert.AreEqual(string.Empty, result, "Empty string should return empty string.");

		// Test with no special characters
		result = RegexProcessor.RemoveSpecialChar("dotnettips");
		Assert.AreEqual("dotnettips", result, "String without special characters should remain unchanged.");

		// Test with special characters
		result = RegexProcessor.RemoveSpecialChar("dot@net!tips#");
		Assert.AreEqual("dotnettips", result, "Special characters should be removed.");

		// Test with special characters and replacement
		result = RegexProcessor.RemoveSpecialChar("dot@net!tips#", "_");
		Assert.AreEqual("dot_net_tips_", result, "Special characters should be replaced with '_'.");
	}

	[TestMethod]
	public void ReplaceCRLFTest()
	{
		var result = RegexProcessor.ReplaceCrLf("dotnettips");

		Assert.IsTrue(result.Length == 10);

		result = RegexProcessor.ReplaceCrLf("dotnettips" + ControlChars.CRLF);

		Assert.IsTrue(result.Length == 10);
	}

	[TestMethod]
	public void ReplaceSpacesTest()
	{
		var result = RegexProcessor.ReplaceSpaces("dotnettips");

		Assert.IsTrue(result.Length == 10);

		result = RegexProcessor.ReplaceSpaces("dot nett ip s");

		Assert.IsTrue(result.Length == 13);
	}
}
