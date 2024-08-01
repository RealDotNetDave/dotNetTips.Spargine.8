// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-05-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2024
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
	public void RemoveSpecialCharTest()
	{
		// Test with null input
		var result = RegexProcessor.RemoveSpecialChar(null);
		Assert.IsNull(result, "Null input should return null.");

		// Test with empty string
		result = RegexProcessor.RemoveSpecialChar(string.Empty);
		Assert.AreEqual(string.Empty, result, "Empty string should return empty string.");

		// Test with string containing special characters
		result = RegexProcessor.RemoveSpecialChar("Hello, World!");
		Assert.AreEqual("Hello  World ", result, "Special characters should be replaced with spaces.");

		// Test with string containing only special characters
		result = RegexProcessor.RemoveSpecialChar("@#$%^&*()_+");
		Assert.AreEqual("           ", result, "All special characters should be replaced with spaces.");

		// Test with string containing no special characters
		result = RegexProcessor.RemoveSpecialChar("HelloWorld");
		Assert.AreEqual("HelloWorld", result, "String with no special characters should remain unchanged.");
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
