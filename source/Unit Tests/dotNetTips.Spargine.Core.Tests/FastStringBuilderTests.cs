// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-03-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2024
// ***********************************************************************
// <copyright file="FastStringBuilderTests.cs" company="dotNetTips.Spargine.Core.Tests">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class FastStringBuilderTests
{

	private const int WordCount = 256;
	private const int WordMaxLength = 10;
	private const int WordMinLength = 5;

	[TestMethod]
	public void BytesToStringTest()
	{
		var testData = RandomData.GenerateByteArray(1);

		var result = FastStringBuilder.BytesToString(testData);

		Assert.IsNotNull(result);

		Assert.IsTrue(result.Length > 0);

		Assert.IsNotNull(FastStringBuilder.BytesToString(null));
	}

	[TestMethod]
	public void CombineToStringTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.CombineStrings(false, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		result = FastStringBuilder.CombineStrings(true, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.CombineStrings(false, null) == ControlChars.EmptyString);
	}

	[TestMethod]
	public void ConcatToStringCharTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.ConcatStrings(delimiter: ControlChars.Plus, addLineFeed: false, args: strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.ConcatStrings(null) == ControlChars.EmptyString);
	}

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
