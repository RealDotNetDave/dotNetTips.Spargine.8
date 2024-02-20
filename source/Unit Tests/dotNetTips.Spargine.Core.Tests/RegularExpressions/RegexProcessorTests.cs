// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-05-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-09-2024
// ***********************************************************************
// <copyright file="RegexProcessorTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

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
	public void IsUrlTest()
	{
		var result = RegexProcessor.IsUrl("dotnettips");

		Assert.IsFalse(result);

		result = RegexProcessor.IsUrl(@"https://dotnetips.com");

		Assert.IsTrue(result);
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
