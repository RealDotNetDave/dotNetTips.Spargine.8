// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-05-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-18-2025
// ***********************************************************************
// <copyright file="RegexProcessorTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.RegularExpressions;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class RegexProcessorTests
{

	[TestMethod]
	public void ContainsFirstLastName_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "John";

		// Act
		var result = RegexProcessor.ContainsFirstLastName(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsFirstLastName_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "John Doe";

		// Act
		var result = RegexProcessor.ContainsFirstLastName(input);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsFirstLastNameTest()
	{

		var result = RegexProcessor.ContainsFirstLastName("David");

		Assert.IsFalse(result);

		result = RegexProcessor.ContainsFirstLastName("David McCarter");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsWord_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "123";

		// Act
		var result = RegexProcessor.ContainsWord(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsWord_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "word";

		// Act
		var result = RegexProcessor.ContainsWord(input);

		// Assert
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
	public void GetNumbers_EmptyInput_ReturnsEmptyString()
	{
		// Arrange
		var input = string.Empty;

		// Act
		var result = RegexProcessor.GetNumbers(input);

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void GetNumbers_InputWithNoNumbers_ReturnsEmptyString()
	{
		// Arrange
		var input = "abcdef";

		// Act
		var result = RegexProcessor.GetNumbers(input);

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void GetNumbers_InputWithSpaces_ReturnsNumbers()
	{
		// Arrange
		var input = "a 1 b 2 c 3";

		// Act
		var result = RegexProcessor.GetNumbers(input);

		// Assert
		Assert.AreEqual("123", result);
	}

	[TestMethod]
	public void GetNumbers_InputWithSpecialCharacters_ReturnsNumbers()
	{
		// Arrange
		var input = "a 1!b2@c 3#";

		// Act
		var result = RegexProcessor.GetNumbers(input);

		// Assert
		Assert.AreEqual("123", result);
	}

	[TestMethod]
	public void GetNumbers_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		string input = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => RegexProcessor.GetNumbers(input));
	}

	[TestMethod]
	public void GetNumbers_ValidInput_ReturnsNumbers()
	{
		// Arrange
		var input = "abc123def456";

		// Act
		var result = RegexProcessor.GetNumbers(input);

		// Assert
		Assert.AreEqual("123456", result);
	}

	[TestMethod]
	public void IsCreditCardNumber_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "1234-5678-9012-3456";

		// Act
		var result = RegexProcessor.IsCreditCardNumber(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsCreditCardNumber_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "4111-1111-1111-1111";

		// Act
		var result = RegexProcessor.IsCreditCardNumber(input);

		// Assert
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
	public void IsCurrencyCode_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "US";

		// Act
		var result = RegexProcessor.IsCurrencyCode(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsCurrencyCode_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "USD";

		// Act
		var result = RegexProcessor.IsCurrencyCode(input);

		// Assert
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
	public void IsEmailAddress_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "test@.com";

		// Act
		var result = RegexProcessor.IsEmailAddress(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmailAddress_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "test@example.com";

		// Act
		var result = RegexProcessor.IsEmailAddress(input);

		// Assert
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
	public void IsGuid_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "123e4567-e89b-12d3-a456-42661417400";

		// Act
		var result = RegexProcessor.IsGuid(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsGuid_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "123e4567-e89b-12d3-a456-426614174000";

		// Act
		var result = RegexProcessor.IsGuid(input);

		// Assert
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
	public void IsIPv4Address_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "999.999.999.999";

		// Act
		var result = RegexProcessor.IsIPv4Address(input);

		// Assert
		Assert.IsFalse(result);
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
	public void IsIPv4Address_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "192.168.1.1";

		// Act
		var result = RegexProcessor.IsIPv4Address(input);

		// Assert
		Assert.IsTrue(result);
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
	public void IsIPv6Address_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "2001:0db8:85a3:8a2e:0370:733";

		// Act
		var result = RegexProcessor.IsIPv6Address(input);

		// Assert
		Assert.IsFalse(result);
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
	public void IsIPv6Address_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";

		// Act
		var result = RegexProcessor.IsIPv6Address(input);

		// Assert
		Assert.IsTrue(result);
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
	public void IsISBN_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "978-3-16-148410-";

		// Act
		var result = RegexProcessor.IsISBN(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsISBN_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "978-3-16-148410-0";

		// Act
		var result = RegexProcessor.IsISBN(input);

		// Assert
		Assert.IsTrue(result);
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
	public void IsMACAddress_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "00:1A:2B:3C:4D:5";

		// Act
		var result = RegexProcessor.IsMACAddress(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsMACAddress_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "00:1A:2B:3C:4D:5E";

		// Act
		var result = RegexProcessor.IsMACAddress(input);

		// Assert
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
	public void IsOneToSevenAlpha_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "abcdefgh";

		// Act
		var result = RegexProcessor.IsOneToSevenAlpha(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsOneToSevenAlpha_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "abcdefg";

		// Act
		var result = RegexProcessor.IsOneToSevenAlpha(input);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsScientific_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "1.23E+";

		// Act
		var result = RegexProcessor.IsScientific(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsScientific_InvalidScientificNotation_ReturnsFalse()
	{
		// Arrange
		var input = "1.23E+";

		// Act
		var result = input.IsScientific();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsScientific_NonScientificNotation_ReturnsFalse()
	{
		// Arrange
		var input = "12345";

		// Act
		var result = input.IsScientific();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsScientific_NullInput_ReturnsFalse()
	{
		// Arrange
		string input = null;

		// Act
		var result = input.IsScientific();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsScientific_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "1.23E+10";

		// Act
		var result = RegexProcessor.IsScientific(input);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsScientific_ValidScientificNotation_ReturnsTrue()
	{
		// Arrange
		var input = "1.23E+10";

		// Act
		var result = input.IsScientific();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsScientific_ValidScientificNotationNegativeExponent_ReturnsTrue()
	{
		// Arrange
		var input = "1.23E-10";

		// Act
		var result = input.IsScientific();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsSHA1Hash_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "a9993e364706816aba3e25717850c26c9cd0d89";

		// Act
		var result = RegexProcessor.IsSHA1Hash(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsSHA1Hash_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "a9993e364706816aba3e25717850c26c9cd0d89d";

		// Act
		var result = RegexProcessor.IsSHA1Hash(input);

		// Assert
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
	public void IsUrl_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "htp://example.com";

		// Act
		var result = RegexProcessor.IsUrl(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsUrl_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "https://example.com";

		// Act
		var result = RegexProcessor.IsUrl(input);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsUrlDomainAddress_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = "example";

		// Act
		var result = RegexProcessor.IsUrlDomainAddress(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsUrlDomainAddress_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "example.com";

		// Act
		var result = RegexProcessor.IsUrlDomainAddress(input);

		// Assert
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
	public void IsValidString_InvalidInput_ReturnsFalse()
	{
		// Arrange
		var input = string.Empty;

		// Act
		var result = RegexProcessor.IsValidString(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsValidString_ValidInput_ReturnsTrue()
	{
		// Arrange
		var input = "This is a valid string.";

		// Act
		var result = RegexProcessor.IsValidString(input);

		// Assert
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
	public void RemoveHtml_ValidInput_ReturnsStringWithoutHtml()
	{
		// Arrange
		var input = "<p>This is a paragraph.</p>";

		// Act
		var result = RegexProcessor.RemoveHtml(input);

		// Assert
		Assert.AreEqual("This is a paragraph.", result);
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
	public void RemoveSpecialChar_ValidInput_ReturnsStringWithoutSpecialChars()
	{
		// Arrange
		var input = "Hello, World!";

		// Act
		var result = RegexProcessor.RemoveSpecialChar(input);

		// Assert
		Assert.AreEqual("HelloWorld", result);
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
	public void ReplaceCrLf_ValidInput_ReturnsStringWithoutCrLf()
	{
		// Arrange
		var input = "Hello\r\nWorld";

		// Act
		var result = RegexProcessor.ReplaceCrLf(input);

		// Assert
		Assert.AreEqual("HelloWorld", result);
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
	public void ReplaceSpaces_ValidInput_ReturnsStringWithoutSpaces()
	{
		// Arrange
		var input = "Hello World";

		// Act
		var result = RegexProcessor.ReplaceSpaces(input);

		// Assert
		Assert.AreEqual("Hello_World", result);
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
