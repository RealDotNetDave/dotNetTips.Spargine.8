// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-20-2025
// ***********************************************************************
// <copyright file="StringExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Tests.Properties;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class StringExtensionsTests
{

	[TestMethod]
	public async Task BrotliStringCompressionAsyncTest()
	{
		var testValue = RandomData.GenerateWord(25);

		var r2 = await testValue.ToBrotliStringAsync(CompressionLevel.NoCompression);
		var r3 = await testValue.ToBrotliStringAsync(CompressionLevel.Optimal);
		var r4 = await testValue.ToBrotliStringAsync(CompressionLevel.SmallestSize);

		Assert.IsFalse(string.IsNullOrEmpty(r2));
		Assert.IsFalse(string.IsNullOrEmpty(r3));
		Assert.IsFalse(string.IsNullOrEmpty(r4));

		Assert.IsFalse(string.IsNullOrEmpty(await r2.FromBrotliStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r3.FromBrotliStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r4.FromBrotliStringAsync()));
	}
	[TestMethod]
	public void CalculateByteArraySize_NullOrEmptyString_ReturnsZero()
	{
		// Arrange
		string nullString = null;
		string emptyString = string.Empty;

		// Act
		var resultForNull = StringExtensions.CalculateByteArraySize(nullString);
		var resultForEmpty = StringExtensions.CalculateByteArraySize(emptyString);

		// Assert
		Assert.AreEqual(0, resultForNull, "Byte array size for null string should be zero.");
		Assert.AreEqual(0, resultForEmpty, "Byte array size for empty string should be zero.");
	}

	[TestMethod]
	public void CalculateByteArraySize_SpecialCharacters_ReturnsCorrectSize()
	{
		// Arrange
		string input = "TëstStrîng";

		// Act
		var result = StringExtensions.CalculateByteArraySize(input);

		// Assert
		var expectedSize = input.Length * 3 / 4;
		Assert.AreEqual(expectedSize, result, "Byte array size for string with special characters is incorrect.");
	}

	[TestMethod]
	public void CalculateByteArraySize_ValidString_ReturnsCorrectSize()
	{
		// Arrange
		string input = "TestString";

		// Act
		var result = StringExtensions.CalculateByteArraySize(input);

		// Assert
		var expectedSize = input.Length * 3 / 4;
		Assert.AreEqual(expectedSize, result, "Byte array size for valid string is incorrect.");
	}


	[TestMethod]
	public void CombineToStringTest()
	{
		var words = RandomData.GenerateWord(100);

		var result = words.CombineToString();

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void ComputeHashTest()
	{
		var word = RandomData.GenerateWord(100);

		foreach (var item in Enum.GetValues(typeof(HashType)))
		{
			var result = word.ComputeHash((HashType)item);

			Assert.IsTrue(result.IsNotEmpty());
		}
	}


	[TestMethod]
	public void ComputeSha256HashTest()
	{
		var testValue = RandomData.GenerateWord(10);

		Assert.IsTrue(string.IsNullOrEmpty(testValue.ComputeSHA256Hash()) is false);
	}

	[TestMethod]
	public void ConcatTest()
	{
		var testValue1 = RandomData.GenerateWord(10);
		var testValue2 = RandomData.GenerateWord(15);

		Assert.IsTrue(string.IsNullOrEmpty(testValue1.Concat("-", false, testValue2)) is false);

		Assert.IsTrue(string.IsNullOrEmpty(testValue1.Concat("-", true, testValue2)) is false);

		Assert.IsTrue(testValue1.Concat("-", false, testValue2).Length == 26);
	}

	[TestMethod]
	public void ContainsAnyTest()
	{
		var testValue = "dotNetTips.com";

		Assert.IsTrue(testValue.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "d", "T"));

		Assert.IsFalse(testValue.ContainsAny(StringComparison.InvariantCulture, "D", "Z"));
	}

	[TestMethod]
	public void DefaultIfNullOrEmptyTest()
	{
		string testValue = null;

		Assert.IsTrue(testValue.DefaultIfNullOrEmpty(RandomData.GenerateWord(5)).Length == 5);
	}

	[TestMethod]
	public void DefaultIfNullTest()
	{
		string testValue = null;

		Assert.IsTrue(testValue.DefaultIfNull().Length == 0);

		Assert.IsTrue(testValue.DefaultIfNull(RandomData.GenerateWord(5)).Length == 5);
	}

	[TestMethod]
	public async Task DeflateStringCompressionAsyncTest()
	{
		var testValue = RandomData.GenerateWord(25);

		var r1 = await testValue.ToDeflateStringAsync(); // Fastest is default
		var r2 = await testValue.ToDeflateStringAsync(CompressionLevel.NoCompression);
		var r3 = await testValue.ToDeflateStringAsync(CompressionLevel.Optimal);
		var r4 = await testValue.ToDeflateStringAsync(CompressionLevel.SmallestSize);

		Assert.IsFalse(string.IsNullOrEmpty(r1));
		Assert.IsFalse(string.IsNullOrEmpty(r2));
		Assert.IsFalse(string.IsNullOrEmpty(r3));
		Assert.IsFalse(string.IsNullOrEmpty(r4));

		//var test = await r1.FromGZipAsync();

		Assert.IsFalse(string.IsNullOrEmpty(await r1.FromDeflateStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r2.FromDeflateStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r3.FromDeflateStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r4.FromDeflateStringAsync()));
	}

	[TestMethod]
	public void DelimitedStringToArrayEmptyTest()
	{
		var inputString = string.Empty;

		var result = inputString.DelimitedStringToArray();

		Assert.IsTrue(result.Count() == 0);
	}

	[TestMethod]
	public void DelimitedStringToArrayTest()
	{
		var inputString = "Microsoft .NET, Visual Studio, Azure";

		var result = inputString.DelimitedStringToArray();

		Assert.IsTrue(result.Count() == 3);

		Assert.IsTrue(result.Count() == 3);
	}

	[TestMethod]
	public void EqualsIgnoreCaseTest()
	{
		var testValue = RandomData.GenerateWord(10);

		Assert.IsTrue(testValue.EqualsIgnoreCase(testValue));
	}

	[TestMethod]
	public void EqualsOrBothNullOrEmptyTest()
	{
		var testValue = RandomData.GenerateWord(10);

		Assert.IsTrue(testValue.EqualsOrBothNullOrEmpty(testValue));

		Assert.IsTrue(string.Empty.EqualsOrBothNullOrEmpty(null));
	}

	[TestMethod]
	public void ExtractTest()
	{
		var inputString = "Microsoft .NET, Visual Studio, Azure";

		var result = inputString.Extract("Micro", "V");

		Assert.IsTrue(result.HasValue());
	}

	[TestMethod]
	public void FastCompare_DifferentStrings_ReturnsFalse()
	{
		// Arrange
		var value = "Hello";
		var valueToCompare = "World";
		var comparison = StringComparison.Ordinal;

		// Act
		var result = value.FastCompare(valueToCompare, comparison);

		// Assert
		Assert.IsFalse(result, "Expected to return false for different strings.");
	}

	[TestMethod]
	public void FastCompare_DifferentStringsIgnoreCase_ReturnsFalse()
	{
		// Arrange
		var value = "Hello";
		var valueToCompare = "world";
		var comparison = StringComparison.OrdinalIgnoreCase;

		// Act
		var result = value.FastCompare(valueToCompare, comparison);

		// Assert
		Assert.IsFalse(result, "Expected to return false for different strings ignoring case.");
	}

	[TestMethod]
	public void FastCompare_SameStrings_ReturnsTrue()
	{
		// Arrange
		var value = "Hello";
		var valueToCompare = "Hello";
		var comparison = StringComparison.Ordinal;

		// Act
		var result = value.FastCompare(valueToCompare, comparison);

		// Assert
		Assert.IsTrue(result, "Expected to return true for the same strings.");
	}

	[TestMethod]
	public void FastCompare_SameStringsIgnoreCase_ReturnsTrue()
	{
		// Arrange
		var value = "Hello";
		var valueToCompare = "hello";
		var comparison = StringComparison.OrdinalIgnoreCase;

		// Act
		var result = value.FastCompare(valueToCompare, comparison);

		// Assert
		Assert.IsTrue(result, "Expected to return true for the same strings ignoring case.");
	}

	[TestMethod]
	public void FromBase64Test()
	{
		var testValue = RandomData.GenerateWord(25);

		Assert.IsTrue(testValue.ToBase64().FromBase64().IsNotEmpty());

		Assert.IsTrue(string.Empty.ToBase64().FromBase64().IsEmpty());
	}


	[TestMethod]
	public async Task GzipStringCompressionAsyncTest()
	{
		var testValue = RandomData.GenerateWord(25);

		var r1 = await testValue.ToGZipStringAsync(); // Fastest is default
		var r2 = await testValue.ToGZipStringAsync(CompressionLevel.NoCompression);
		var r3 = await testValue.ToGZipStringAsync(CompressionLevel.Optimal);
		var r4 = await testValue.ToGZipStringAsync(CompressionLevel.SmallestSize);

		Assert.IsFalse(string.IsNullOrEmpty(r1));
		Assert.IsFalse(string.IsNullOrEmpty(r2));
		Assert.IsFalse(string.IsNullOrEmpty(r3));
		Assert.IsFalse(string.IsNullOrEmpty(r4));

		//var test = await r1.FromGZipAsync();

		Assert.IsFalse(string.IsNullOrEmpty(await r1.FromGZipStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r2.FromGZipStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r3.FromGZipStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r4.FromGZipStringAsync()));
	}

	[TestMethod]
	public void HasValueTest()
	{
		var testValue = RandomData.GenerateWord(10);

		Assert.IsTrue(testValue.HasValue());

		Assert.IsTrue(testValue.HasValue(10));

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(-100));

		Assert.IsTrue(testValue.HasValue(1, 10));

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(-10, 500));

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(12, -10));

		Assert.IsFalse(testValue.HasValue("XXXXX"));

		//Test Regex
		var email = "dotnetdave@live.com";
		Assert.IsTrue(email.HasValue(@"([a-zA-Z0-9+._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)", RegexOptions.IgnoreCase));

		Assert.IsFalse("David".HasValue(string.Empty, RegexOptions.IgnoreCase));
	}

	[TestMethod]
	public void HasWhiteSpaceTest()
	{
		var testWithText = RandomData.GenerateWord(10);
		var testWithWhitespace = "      ";

		Assert.IsFalse(testWithText.HasWhitespace());
		Assert.IsTrue(testWithWhitespace.HasWhitespace());
		Assert.IsTrue(' '.IsAsciiWhitespace());
		Assert.IsFalse('d'.IsAsciiWhitespace());
	}

	[TestMethod]
	public void IndentTest()
	{
		var testValue = RandomData.GenerateWord(100);

		var result = testValue.Indent(2, '>');

		Assert.IsTrue(result.Length > 100);

		result = testValue.Indent(0, '>');

		Assert.IsTrue(result.Length == 0);
	}

	[TestMethod]
	public void IsAsciiLetterOrDigitTest()
	{
		Assert.IsTrue('A'.IsAsciiLetterOrDigit());

		Assert.IsTrue('1'.IsAsciiLetterOrDigit());
	}

	[TestMethod]
	public void IsAsciiLetterTest() => Assert.IsTrue('A'.IsAsciiLetter());

	[TestMethod]
	public void IsCreditCardTest() => Assert.IsFalse("123".IsCreditCardNumber());

	[TestMethod]
	public void IsCurrencyCode()
	{
		var goodCode = "USD";
		var badCode = RandomData.GenerateWord(5);

		Assert.IsTrue(goodCode.IsCurrencyCode());

		Assert.IsFalse(badCode.IsCurrencyCode());
	}

	[TestMethod]
	public void IsDigitTest()
	{
		Assert.IsTrue('1'.IsAsciiDigit());

		Assert.IsFalse('A'.IsAsciiDigit());
	}

	[TestMethod]
	public void IsDomainAddressTest() => Assert.IsTrue("dotnettips.com".IsDomainAddress());

	[TestMethod]
	public void IsEmailAddressTest() => Assert.IsTrue("dotnetdave@live.com".IsEmailAddress());

	[TestMethod]
	public void IsEmptyTest()
	{
		Assert.IsFalse(RandomData.GenerateWord(10).IsEmpty());

		Assert.IsTrue(string.Empty.IsEmpty());
	}

	[TestMethod]
	public void IsFirstLastNameTest()
	{
		Assert.IsTrue("David McCarter".IsFirstLastName());
	}


	[TestMethod]
	public void IsGuid_EmptyStringTest()
	{
		// Arrange
		var emptyString = string.Empty;

		// Act
		var result = emptyString.IsGuid();

		// Assert
		Assert.IsFalse(result, "Expected to return false for an empty string.");
	}

	[TestMethod]
	public void IsGuid_InvalidGuidTest()
	{
		// Arrange
		var invalidGuid = "ThisIsNotAGuid";

		// Act
		var result = invalidGuid.IsGuid();

		// Assert
		Assert.IsFalse(result, "Expected to return false for an invalid GUID string.");
	}

	[TestMethod]
	public void IsGuid_NullStringTest()
	{
		// Arrange
		string nullString = null;

		// Act
		// Using a lambda to defer the evaluation and catch the ArgumentNullException
		var result = nullString.IsGuid();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsGuid_ValidGuidTest()
	{
		// Arrange
		var validGuid = Guid.NewGuid().ToString();

		// Act
		var result = validGuid.IsGuid();

		// Assert
		Assert.IsTrue(result, "Expected to return true for a valid GUID string.");
	}

	[TestMethod]
	public void IsISBNTest()
	{
		Assert.IsTrue("1257561035".IsISBN());
	}

	[TestMethod]
	public void IsMacAddress_EmptyStringTest()
	{
		// Arrange
		var emptyString = string.Empty;

		// Act
		var result = emptyString.IsMacAddress();

		// Assert
		Assert.IsFalse(result, "Expected to return false for an empty string.");
	}

	[TestMethod]
	public void IsMacAddress_InvalidMacAddressTest()
	{
		// Arrange
		var invalidMacAddress = "00-14-22-01-23-G5"; // Invalid character 'G'

		// Act
		var result = invalidMacAddress.IsMacAddress();

		// Assert
		Assert.IsFalse(result, "Expected to return false for an invalid MAC address.");
	}

	[TestMethod]
	public void IsMacAddress_NullStringTest()
	{
		// Arrange
		string nullString = null;

		// Act
		var result = nullString.IsMacAddress();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsMacAddress_ValidMacAddressTest()
	{
		// Arrange
		var validMacAddress = "00-14-22-01-23-45";

		// Act
		var result = validMacAddress.IsMacAddress();

		// Assert
		Assert.IsTrue(result, "Expected to return true for a valid MAC address.");
	}

	[TestMethod]
	public void IsMacAddress_WithColonsTest()
	{
		// Arrange
		var macAddressWithColons = "00:14:22:01:23:45";

		// Act
		var result = macAddressWithColons.IsMacAddress();

		// Assert
		Assert.IsTrue(result, "Expected to return true for a MAC address with colons.");
	}

	[TestMethod]
	public void IsMacAddress_WithDashesTest()
	{
		// Arrange
		var macAddressWithDashes = "00-14-22-01-23-45";

		// Act
		var result = macAddressWithDashes.IsMacAddress();

		// Assert
		Assert.IsTrue(result, "Expected to return true for a MAC address with dashes.");
	}

	[TestMethod]
	public void IsNotEmptyTest()
	{
		Assert.IsTrue(RandomData.GenerateWord(10).IsNotEmpty());

		Assert.IsFalse(string.Empty.IsNotEmpty());
	}

	[TestMethod]
	public void IsOneToSevenAlphaTest()
	{
		var goodCode = RandomData.GenerateWord(7, 'A', 'Z');
		var badCode = RandomData.GenerateWord(25, 'A', 'Z');

		Assert.IsTrue(goodCode.IsOneToSevenAlpha());

		Assert.IsFalse(badCode.IsOneToSevenAlpha());
	}

	[TestMethod]
	public void IsScientificTest()
	{
		Assert.IsFalse("6.5 ✕ 10^8".IsScientific());
	}

	[TestMethod]
	public void IsStringSHA1Hash_EmptyString_ReturnsFalse()
	{
		// Arrange
		var emptyString = string.Empty;

		// Act
		var result = emptyString.IsStringSHA1Hash();

		// Assert
		Assert.IsFalse(result, "Expected to return false for an empty string.");
	}

	[TestMethod]
	public void IsStringSHA1Hash_InvalidSHA1Hash_ReturnsFalse()
	{
		// Arrange
		var invalidSHA1Hash = "invalidSHA1Hash";

		// Act
		var result = invalidSHA1Hash.IsStringSHA1Hash();

		// Assert
		Assert.IsFalse(result, "Expected to return false for an invalid SHA1 hash.");
	}

	[TestMethod]
	public void IsStringSHA1Hash_LongString_ReturnsFalse()
	{
		// Arrange
		var longString = new string('a', 50);

		// Act
		var result = longString.IsStringSHA1Hash();

		// Assert
		Assert.IsFalse(result, "Expected to return false for a long string.");
	}

	[TestMethod]
	public void IsStringSHA1Hash_NullString_ReturnsFalse()
	{
		// Arrange
		string nullString = null;

		// Act
		var result = nullString.IsStringSHA1Hash();

		// Assert
		Assert.IsFalse(result, "Expected to return false for a null string.");
	}

	[TestMethod]
	public void IsStringSHA1Hash_ShortString_ReturnsFalse()
	{
		// Arrange
		var shortString = "12345";

		// Act
		var result = shortString.IsStringSHA1Hash();

		// Assert
		Assert.IsFalse(result, "Expected to return false for a short string.");
	}

	[TestMethod]
	public void IsStringSHA1Hash_ValidSHA1Hash_ReturnsTrue()
	{
		// Arrange
		var validSHA1Hash = "5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8"; // SHA1 hash for "password"

		// Act
		var result = validSHA1Hash.IsStringSHA1Hash();

		// Assert
		Assert.IsTrue(result, "Expected to return true for a valid SHA1 hash.");
	}

	[TestMethod]
	public void IsStringSHA1Hash_ValidSHA1HashWithMixedCase_ReturnsTrue()
	{
		// Arrange
		var validSHA1HashMixedCase = "5bAa61E4c9B93F3F0682250B6Cf8331B7Ee68Fd8"; // SHA1 hash for "password" in mixed case

		// Act
		var result = validSHA1HashMixedCase.IsStringSHA1Hash();

		// Assert
		Assert.IsTrue(result, "Expected to return true for a valid SHA1 hash in mixed case.");
	}

	[TestMethod]
	public void IsStringSHA1Hash_ValidSHA1HashWithUpperCase_ReturnsTrue()
	{
		// Arrange
		var validSHA1HashUpperCase = "5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8"; // SHA1 hash for "password" in upper case

		// Act
		var result = validSHA1HashUpperCase.IsStringSHA1Hash();

		// Assert
		Assert.IsTrue(result, "Expected to return true for a valid SHA1 hash in upper case.");
	}

	[TestMethod]
	public void IsStringTest()
	{
		Assert.IsTrue("979-8589711707".IsString());
	}

	[TestMethod]
	public void IsUrlTest() => Assert.IsTrue("http://dotnettips.com".IsUrl());

	[TestMethod]
	public void IsWhiteSpaceTest()
	{
		Assert.IsTrue("      ".HasWhitespace());

		Assert.IsTrue(ControlChars.Space.IsAsciiWhitespace());

		Assert.IsFalse("David".HasWhitespace());
	}

	[TestMethod]
	public void RemoveCRLFTest()
	{
		var testValue1 = $"{RandomData.GenerateWord(10)}{ControlChars.NewLine}{RandomData.GenerateWord(15)}{ControlChars.CRLF}{RandomData.GenerateWord(15)}";

		var testValue2 = $"{RandomData.GenerateWord(15)}{RandomData.GenerateWord(25)}";

		var result1 = testValue1.RemoveCRLF(replacement: ".");
		var result2 = testValue2.RemoveCRLF();

		Assert.IsTrue(result1.Contains(ControlChars.NewLine) is false);
		Assert.IsTrue(result1.Contains(ControlChars.CRLF) is false);
		Assert.IsTrue(result1.Contains(ControlChars.CR) is false);

		Assert.IsTrue(result2.Contains(ControlChars.NewLine) is false);
		Assert.IsTrue(result2.Contains(ControlChars.CRLF) is false);
		Assert.IsTrue(result2.Contains(ControlChars.CR) is false);
	}

	[TestMethod]
	public void ReplaceEllipsisWithPeriodTest()
	{
		var testValue = $"{RandomData.GenerateWord(25)}...";

		var result = testValue.ReplaceEllipsisWithPeriod();

		Assert.IsTrue(result.EndsWith("...") is false);

		_ = Assert.ThrowsException<ArgumentNullException>(() => string.IsNullOrEmpty(string.Empty.ReplaceEllipsisWithPeriod()));
	}

	[TestMethod]
	public void Split_WithCountGreaterThanNumberOfParts_ShouldIncludeAllParts()
	{
		// Arrange
		var input = "one,two,three";
		var separator = ',';
		var expected = new[] { "one", "two", "three" };

		// Act
		var result = input.Split(StringSplitOptions.None, 5, separator);

		// Assert
		CollectionAssert.AreEqual(expected, result);
	}


	[TestMethod]
	public void Split_WithCountLessThanNumberOfParts_ShouldSplitCorrectly()
	{
		// Arrange
		var input = "one,two,three,four";
		var separator = ',';
		var expected = new[] { "one", "two", "three,four" };

		// Act
		var result = input.Split(StringSplitOptions.None, 3, separator);

		// Assert
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void Split_WithCustomSeparatorTest()
	{
		// Arrange
		var input = "apple|banana|cherry";
		var expected = new[] { "apple", "banana", "cherry" };
		var separator = '|';

		// Act
		var result = input.Split(StringSplitOptions.None, separator);

		// Assert
		CollectionAssert.AreEqual(expected, result.ToArray(), "The split strings should match the expected array with custom separator.");
	}

	[TestMethod]
	public void Split_WithDefaultSeparatorTest()
	{
		// Arrange
		var input = "apple,banana,cherry";
		var expected = new[] { "apple", "banana", "cherry" };

		// Act
		var result = input.Split(StringSplitOptions.None);

		// Assert
		CollectionAssert.AreEqual(expected, result.ToArray(), "The split strings should match the expected array.");
	}

	[TestMethod]
	public void Split_WithMultipleCalls_ReturnsConsistentResults()
	{
		// Arrange
		var input = "alpha|beta|gamma|delta";
		var separator = "|";
		var count = 2;
		var expectedFirstCall = new[] { "alpha", "beta|gamma|delta" };
		var expectedSecondCall = new[] { "alpha", "beta|gamma|delta" };

		// Act
		var resultFirstCall = input.Split(StringSplitOptions.None, count, separator);
		var resultSecondCall = input.Split(StringSplitOptions.None, count, separator);

		// Assert
		CollectionAssert.AreEqual(expectedFirstCall, resultFirstCall, "First call should return the expected result.");
		CollectionAssert.AreEqual(expectedSecondCall, resultSecondCall, "Second call should return the same result as the first call.");
	}

	[TestMethod]
	public void Split_WithMultipleSeparators_ShouldSplitCorrectly()
	{
		// Arrange
		var input = "one,two;three|four";
		var separators = new[] { ',', ';', '|' };
		var expected = new[] { "one", "two", "three", "four" };

		// Act
		var result = input.Split(separators, StringSplitOptions.None);

		// Assert
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void Split_WithNoMatchingSeparator_ReturnsOriginalString()
	{
		// Arrange
		var input = "one two three";
		var separator = ",";
		var count = 3;
		var expected = new[] { "one two three" };

		// Act
		var result = input.Split(StringSplitOptions.None, count, separator);

		// Assert
		CollectionAssert.AreEqual(expected, result, "The original string should be returned as a single element array.");
	}

	[TestMethod]
	public void Split_WithOptionsNoneTest()
	{
		// Arrange
		var input = "apple,,banana,,cherry,";
		var expected = new[] { "apple", string.Empty, "banana", string.Empty, "cherry", string.Empty };

		// Act
		var result = input.Split(StringSplitOptions.None);

		// Assert
		CollectionAssert.AreEqual(expected, result.ToArray(), "The split strings should match the expected array, including empty entries.");
	}

	[TestMethod]
	public void Split_WithOptionsRemoveEmptyEntries_RemovesEmptyEntries()
	{
		// Arrange
		var input = "one,,two,,,three";
		var separator = ",";
		var count = 5;
		var expected = new[] { "one", "two", "three" };

		// Act
		var result = input.Split(StringSplitOptions.RemoveEmptyEntries, count, separator);

		// Assert
		CollectionAssert.AreEqual(expected, result, "Empty entries should be removed from the result.");
	}

	[TestMethod]
	public void Split_WithOptionsRemoveEmptyEntries_ShouldRemoveEmptyEntries()
	{
		// Arrange
		var input = "one,,two,,";
		var separator = ',';
		var expected = new[] { "one", "two" };

		// Act
		var result = input.Split(StringSplitOptions.RemoveEmptyEntries, 3, separator);

		// Assert
		CollectionAssert.AreEqual(expected, result);
	}


	[TestMethod]
	public void Split_WithOptionsRemoveEmptyEntriesTest()
	{
		// Arrange
		var input = "apple,,banana,,cherry,";
		var expected = new[] { "apple", "banana", "cherry" };

		// Act
		var result = input.Split(StringSplitOptions.RemoveEmptyEntries);

		// Assert
		CollectionAssert.AreEqual(expected, result.ToArray(), "The split strings should match the expected array, removing empty entries.");
	}

	[TestMethod]
	public void Split_WithSeparatorAndCount_SplitsCorrectly()
	{
		// Arrange
		var input = "one,two,three,four";
		var separator = ",";
		var count = 3;
		var expected = new[] { "one", "two", "three,four" };

		// Act
		var result = input.Split(StringSplitOptions.None, count, separator);

		// Assert
		CollectionAssert.AreEqual(expected, result, "The input string should be split into the expected parts.");
	}

	[TestMethod]
	public void Split_WithSingleSeparator_ShouldSplitCorrectly()
	{
		// Arrange
		var input = "one,two,three";
		var separator = ',';
		var expected = new[] { "one", "two", "three" };

		// Act
		var result = input.Split(StringSplitOptions.None, 3, separator);

		// Assert
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void SplitLinesTest()
	{
		var text = Resources.TestMutipleLinesOfText;
		try
		{
			foreach (var lse in text.SplitLines())
			{
				Console.WriteLine(lse.Line.ToString());
			}
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void SplitRemoveEmptyTest()
	{
		var testValue = $"{RandomData.GenerateWord(25)},{RandomData.GenerateWord(25)}";

		Assert.IsTrue(testValue.SplitRemoveEmpty().FastCount() > 1);
	}

	[TestMethod]
	public void SplitTest()
	{
		var testValue = $"{RandomData.GenerateWord(25)},{RandomData.GenerateWord(25)}";

		Assert.IsTrue(testValue.Split(',', options: StringSplitOptions.RemoveEmptyEntries).FastCount() == 2);

		Assert.IsTrue(testValue.Split(',', count: 2, options: StringSplitOptions.RemoveEmptyEntries).FastCount() == 2);
	}

	[TestMethod]
	public void SplitWithCharAndCountTest()
	{
		var testValue = $"coding, programming, microsoft";

		var result = testValue.Split(',', 2, StringSplitOptions.RemoveEmptyEntries);

		Assert.IsTrue(result.FastCount() == 2);

		result = testValue.Split(',', 1, StringSplitOptions.None);

		Assert.IsTrue(result.FastCount() == 1);
	}

	[TestMethod]
	public void SplitWithCharTest()
	{
		var testValue = $"coding, programming, microsoft";

		var result = testValue.Split(',', StringSplitOptions.RemoveEmptyEntries);

		Assert.IsTrue(result.FastCount() == 3);

		result = testValue.Split(',', StringSplitOptions.None);

		Assert.IsTrue(result.FastCount() == 3);
	}

	[TestMethod]
	public void SplitWithStringAndCountTest()
	{
		var testValue = $"coding, programming, microsoft";

		var result = testValue.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);

		Assert.IsTrue(result.FastCount() == 2);

		result = testValue.Split(",", 1, StringSplitOptions.None);

		Assert.IsTrue(result.FastCount() == 1);
	}

	[TestMethod]
	public void SplitWithStringTest()
	{
		var testValue = $"coding, programming, microsoft";

		var result = testValue.Split(",", StringSplitOptions.RemoveEmptyEntries);

		Assert.IsTrue(result.FastCount() == 3);

		result = testValue.Split(",", StringSplitOptions.None);

		Assert.IsTrue(result.FastCount() == 3);
	}

	[TestMethod]
	public void StartsWithOrdinal_EmptyInput_ReturnsFalse()
	{
		var input = string.Empty;
		var startsWith = "Hello";

		var result = input.StartsWithOrdinal(startsWith);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void StartsWithOrdinal_EmptyStartsWith_ReturnsTrue()
	{
		var input = "Hello World";
		var startsWith = string.Empty;

		var result = input.StartsWithOrdinal(startsWith);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void StartsWithOrdinal_InputDoesNotStartWithSpecifiedString_ReturnsFalse()
	{
		var input = "Hello World";
		var startsWith = "World";

		var result = input.StartsWithOrdinal(startsWith);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void StartsWithOrdinal_InputStartsWithSpecifiedString_ReturnsTrue()
	{
		var input = "Hello World";
		var startsWith = "Hello";

		var result = input.StartsWithOrdinal(startsWith);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void StartsWithOrdinalIgnoreCaseTest()
	{
		var testValue = RandomData.GenerateWord(10);

		Assert.IsTrue(testValue.StartsWithOrdinalIgnoreCase(testValue));
	}

	[TestMethod]
	public void SubstringTrimTest()
	{
		var testValue = RandomData.GenerateWord(50);

		//Test parameters
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(-100, 10));
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(1, -10));
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(1, 100));

		//Test
		Assert.IsTrue(testValue.SubstringTrim(1, 10).HasValue());
	}

	[TestMethod]
	public void ToBase64ByteSpan_InvalidBase64String_ReturnsEmptySpan()
	{
		// Arrange
		string input = "InvalidBase64String";

		// Act
		var result = StringExtensions.ToBase64ByteSpan(input);

		// Assert
		Assert.AreEqual(0, result.Length, "The byte span should be empty for an invalid Base64 string.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToBase64ByteSpan_NullString_ThrowsArgumentNullException()
	{
		// Arrange
		string input = null;

		// Act
		StringExtensions.ToBase64ByteSpan(input);

		// Assert is handled by ExpectedException
	}

	[TestMethod]
	public void ToBase64ByteSpan_ValidBase64String_ReturnsCorrectSpan()
	{
		// Arrange
		string input = "VGhpcyBpcyBhIHRlc3Qgc3RyaW5nLg=="; // "This is a test string."

		// Act
		var result = StringExtensions.ToBase64ByteSpan(input);

		// Assert
		var expectedBytes = Encoding.UTF8.GetBytes("This is a test string.");
		CollectionAssert.AreEqual(expectedBytes, result.ToArray(), "The byte span does not match the expected byte array.");
	}

	[TestMethod]
	public void ToBase64Test()
	{
		var testValue = RandomData.GenerateWord(25);

		Assert.IsTrue(testValue.ToBase64().IsNotEmpty());
	}

	[TestMethod]
	[ExpectedException(typeof(FormatException))]
	public void ToByteArrayFromBase64_InvalidBase64String_ThrowsFormatException()
	{
		// Arrange
		var base64String = "InvalidBase64String";

		// Act
		base64String.ToByteArrayFromBase64();

		// Assert is handled by ExpectedException
	}

	[TestMethod]
	public void ToByteArrayFromBase64_ValidBase64String_ReturnsCorrectByteArray()
	{
		// Arrange
		var base64String = "VGhpcyBpcyBhIHRlc3Qgc3RyaW5nLg=="; // "This is a test string."
		var expectedBytes = Encoding.UTF8.GetBytes("This is a test string.");

		// Act
		var result = base64String.ToByteArrayFromBase64();

		// Assert
		CollectionAssert.AreEqual(expectedBytes, result, "The byte array does not match the expected byte array.");
	}

	[TestMethod]
	public void ToByteArrayTest()
	{
		var testValue = RandomData.GenerateWord(25);

		Assert.IsTrue(testValue.ToByteArray(encoding: Encoding.ASCII).Length > 0);

		Assert.IsTrue(testValue.ToByteArray(encoding: Encoding.BigEndianUnicode).Length > 0);

		Assert.IsTrue(testValue.ToByteArray(encoding: Encoding.Default).Length > 0);

		Assert.IsTrue(testValue.ToByteArray(encoding: Encoding.Latin1).Length > 0);

		Assert.IsTrue(testValue.ToByteArray(encoding: Encoding.Unicode).Length > 0);

		Assert.IsTrue(testValue.ToByteArray(encoding: Encoding.UTF32).Length > 0);

		Assert.IsTrue(testValue.ToByteArray(encoding: Encoding.UTF8).Length > 0);
	}

	[TestMethod]
	public void ToTitleCaseTest()
	{
		var words = RandomData.GenerateWords(10, 10, 20).ToDelimitedString(ControlChars.Space);

		var testValue = words.ToTitleCase();

		Assert.IsTrue(testValue.IsNotEmpty());
	}

	[TestMethod]
	public void TrimTest()
	{
		var testValue = $"{RandomData.GenerateWord(25)}   ";

		Assert.IsTrue(testValue.ToTrimmed().Length == 25);
	}

	[TestMethod]
	public async Task ZLibStringCompressionAsyncTest()
	{
		var testValue = RandomData.GenerateWord(25);

		var r1 = await testValue.ToZLibStringAsync(); // Fastest is default
		var r2 = await testValue.ToZLibStringAsync(CompressionLevel.NoCompression);
		var r3 = await testValue.ToZLibStringAsync(CompressionLevel.Optimal);
		var r4 = await testValue.ToZLibStringAsync(CompressionLevel.SmallestSize);

		Assert.IsFalse(string.IsNullOrEmpty(r1));
		Assert.IsFalse(string.IsNullOrEmpty(r2));
		Assert.IsFalse(string.IsNullOrEmpty(r3));
		Assert.IsFalse(string.IsNullOrEmpty(r4));

		//var test = await r1.FromGZipAsync();

		Assert.IsFalse(string.IsNullOrEmpty(await r1.FromZLibStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r2.FromZLibStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r3.FromZLibStringAsync()));
		Assert.IsFalse(string.IsNullOrEmpty(await r4.FromZLibStringAsync()));
	}

}
