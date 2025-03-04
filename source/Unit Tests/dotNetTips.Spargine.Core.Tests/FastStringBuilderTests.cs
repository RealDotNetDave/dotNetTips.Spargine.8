// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-03-2023
//
// Last Modified By : David McCarter
// Last Modified On : 03-04-2025
// ***********************************************************************
// <copyright file="FastStringBuilderTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

/// <summary>
/// Defines test class FastStringBuilderTests.
/// </summary>
[ExcludeFromCodeCoverage]
[TestClass]
public class FastStringBuilderTests
{

	/// <summary>
	/// The word count
	/// </summary>
	private const int WordCount = 256;
	/// <summary>
	/// The word maximum length
	/// </summary>
	private const int WordMaxLength = 10;
	/// <summary>
	/// The word minimum length
	/// </summary>
	private const int WordMinLength = 5;

	/// <summary>
	/// Defines the test method AppendFormatTest.
	/// </summary>
	[TestMethod]
	public void AppendFormatTest()
	{
		var result = FastStringBuilder.AppendFormat("Hello, {0}!", "world");
		Assert.AreEqual("Hello, world!", result);

		result = FastStringBuilder.AppendFormat("Number: {0}, String: {1}", "123", "test");
		Assert.AreEqual("Number: 123, String: test", result);

		result = FastStringBuilder.AppendFormat("Empty: {0}", null);
		Assert.AreEqual(string.Empty, result);

		result = FastStringBuilder.AppendFormat(null, "test");
		Assert.AreEqual(string.Empty, result);
	}

	/// <summary>
	/// Defines the test method BytesToStringTest.
	/// </summary>
	[TestMethod]
	public void BytesToStringTest()
	{
		var bytes = new byte[] { 0x1, 0x2, 0x3, 0x4, 0x5 };
		var result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual("'0x0102030405'", result);

		bytes = null;
		result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}


	/// <summary>
	/// Defines the test method CombineToStringTest.
	/// </summary>
	[TestMethod]
	public void CombineToStringTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.CombineStrings(false, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);

		result = FastStringBuilder.CombineStrings(true, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.CombineStrings(false, null) == ControlChars.EmptyString);
	}

	/// <summary>
	/// Defines the test method ConcatToStringCharTest.
	/// </summary>
	[TestMethod]
	public void ConcatToStringCharTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.ConcatStrings(delimiter: ControlChars.Plus, addLineFeed: false, args: strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.ConcatStrings(null) == ControlChars.EmptyString);
	}

	/// <summary>
	/// Defines the test method ConcatToStringTest.
	/// </summary>
	[TestMethod]
	public void ConcatToStringTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.ConcatStrings(ControlChars.CommaSpace.ToString(), false, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		result = FastStringBuilder.ConcatStrings(ControlChars.CommaSpace.ToString(), true, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.ConcatStrings(null) == ControlChars.EmptyString);
	}

	/// <summary>
	/// Defines the test method JoinStringsTest.
	/// </summary>
	[TestMethod]
	public void JoinStringsTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();
		var result = FastStringBuilder.JoinStrings(strings, ControlChars.CommaSpace);
		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		result = FastStringBuilder.JoinStrings(null, ControlChars.CommaSpace);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	/// <summary>
	/// Defines the test method PerformActionTest.
	/// </summary>
	[TestMethod]
	public void PerformActionTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			foreach (var word in strings)
			{
				_ = sb.Append($"WORD:{word}|");
			}
		};

		var result = FastStringBuilder.PerformAction(action);

		Assert.IsNotNull(result);
	}

	/// <summary>
	/// Defines the test method ReplaceTest.
	/// </summary>
	[TestMethod]
	public void ReplaceTest()
	{
		var result = FastStringBuilder.Replace("world", "universe", "Hello, world!");
		Assert.AreEqual("Hello, universe!", result);

		result = FastStringBuilder.Replace("test", "exam", "This is a test.");
		Assert.AreEqual("This is a exam.", result);

		result = FastStringBuilder.Replace("notfound", "found", "This string does not contain the word.");
		Assert.AreEqual("This string does not contain the word.", result);

		result = FastStringBuilder.Replace("test", "exam", null);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	/// <summary>
	/// Defines the test method SubstringTest.
	/// </summary>
	[TestMethod]
	public void SubstringTest()
	{
		var result = FastStringBuilder.Substring("Hello, world!", 7, 5);
		Assert.AreEqual("world", result);

		result = FastStringBuilder.Substring("This is a test.", 10, 4);
		Assert.AreEqual("test", result);

		result = FastStringBuilder.Substring(null, 0, 4);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	/// <summary>
	/// Defines the test method ToDelimitedStringTest.
	/// </summary>
	[TestMethod]
	public void ToDelimitedStringTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var dictionary = new Dictionary<string, string>(WordCount);

		foreach (var word in strings)
		{
			dictionary.Add(word, word);
		}

		var result = FastStringBuilder.ToDelimitedString(dictionary, ControlChars.Comma);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.ToDelimitedString<string, string>(null) == ControlChars.EmptyString);
	}

}
