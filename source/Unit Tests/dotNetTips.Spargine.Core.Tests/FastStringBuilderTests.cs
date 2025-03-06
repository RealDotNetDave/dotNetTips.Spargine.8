// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-03-2023
//
// Last Modified By : David McCarter
// Last Modified On : 03-05-2025
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

	private const int WordCount = 256;
	private const int WordMaxLength = 10;
	private const int WordMinLength = 5;

	[TestMethod]
	public void AppendFormatTest()
	{
		var result = FastStringBuilder.Format("Hello, {0}!", "world");
		Assert.AreEqual("Hello, world!", result);

		result = FastStringBuilder.Format("Number: {0}, String: {1}", "123", "test");
		Assert.AreEqual("Number: 123, String: test", result);

		result = FastStringBuilder.Format("Empty: {0}", null);
		Assert.AreEqual(string.Empty, result);

		result = FastStringBuilder.Format(null, "test");
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void BytesToStringTest()
	{
		var bytes = new byte[] { 0x1, 0x2, 0x3, 0x4, 0x5 };
		var result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual("0x0102030405", result);

		bytes = null;
		result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void CombineToStringTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.Combine(addLineFeed: false, args: strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);

		result = FastStringBuilder.Combine(true, args: strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.Combine(false, args: null) == ControlChars.EmptyString);
	}

	[TestMethod]
	public void CombineWithSpaceTest()
	{
		var result = FastStringBuilder.CombineWithSpace("Hello", "world");
		Assert.AreEqual("Hello world", result);

		result = FastStringBuilder.CombineWithSpace("This", "is", "a", "test");
		Assert.AreEqual("This is a test", result);

		result = FastStringBuilder.CombineWithSpace("SingleWord");
		Assert.AreEqual("SingleWord", result);

		result = FastStringBuilder.CombineWithSpace(null);
		Assert.AreEqual(ControlChars.EmptyString, result);

		result = FastStringBuilder.CombineWithSpace();
		Assert.AreEqual(ControlChars.EmptyString, result);
	}


	[TestMethod]
	public void ConcatToStringCharTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.Concat(delimiter: ControlChars.Plus, addLineFeed: false, args: strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.Concat(null) == ControlChars.EmptyString);
	}

	[TestMethod]
	public void ConcatToStringTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.Concat(ControlChars.CommaSpace.ToString(), false, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		result = FastStringBuilder.Concat(ControlChars.CommaSpace.ToString(), true, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.Concat(null) == ControlChars.EmptyString);
	}

	[TestMethod]
	public void JoinStringsTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();
		var result = FastStringBuilder.Join(strings, ControlChars.CommaSpace);
		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		result = FastStringBuilder.Join(null, ControlChars.Comma.ToString());
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

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
	/// Defines the test method RemoveStringTest.
	/// </summary>
	[TestMethod]
	public void RemoveStringTest()
	{
		var result = FastStringBuilder.Remove("Hello, world!", "world");
		Assert.AreEqual("Hello, !", result);

		result = FastStringBuilder.Remove("This is a test. This is only a test.", "test");
		Assert.AreEqual("This is a . This is only a .", result);

		result = FastStringBuilder.Remove("No occurrences here.", "notfound");
		Assert.AreEqual("No occurrences here.", result);

		result = FastStringBuilder.Remove(null, "test");
		Assert.AreEqual(ControlChars.EmptyString, result);

		result = FastStringBuilder.Remove("This is a test.", null);
		Assert.AreEqual("This is a test.", result);

		result = FastStringBuilder.Remove("This is a test.", string.Empty);
		Assert.AreEqual("This is a test.", result);

		result = FastStringBuilder.Remove(string.Empty, "test");
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

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
