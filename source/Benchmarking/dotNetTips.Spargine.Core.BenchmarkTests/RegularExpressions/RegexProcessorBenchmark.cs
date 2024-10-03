// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 06-03-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-03-2024
// ***********************************************************************
// <copyright file="RegexProcessorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.RegularExpressions;
using DotNetTips.Spargine.Tester;
using Microsoft.Diagnostics.Runtime.Utilities;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions;
public class RegexProcessorBenchmark : Benchmark
{

	[Benchmark(Description = nameof(RegexProcessor.ContainsFirstLastName))]
	[BenchmarkCategory(Categories.Strings)]
	public void ContainsFirstLastName()
	{
		var result = RegexProcessor.ContainsFirstLastName("David McCarter");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.ContainsWord))]
	[BenchmarkCategory(Categories.Strings)]
	public void ContainsWord()
	{
		var result = RegexProcessor.ContainsWord(this.LongTestString);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsCreditCardNumber))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsCreditCardNumber()
	{
		var result = RegexProcessor.IsCreditCardNumber("5576190012341234");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsCurrencyCode))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsCurrencyCode()
	{
		var result = RegexProcessor.IsCreditCardNumber("USD");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsEmailAddress))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsEmailAddress()
	{
		var result = RegexProcessor.IsEmailAddress("david@microsoft.com");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsGuid))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsGuid()
	{
		var result = RegexProcessor.IsGuid("19C908E3-B4C0-47AA-87E9-C93379E1E264");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsISBN))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsISBN()
	{
		var result = RegexProcessor.IsISBN("9798878213479");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsMACAddress))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsMACAddress()
	{
		var result = RegexProcessor.IsMACAddress("00:1A:2B:3C:4D:5E");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsSHA1Hash))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsSHA1Hash()
	{
		var result = RegexProcessor.IsSHA1Hash("2ef7bde608ce5404e97d5f042f95f89f1c232871");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsUrl))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsUrl()
	{
		var result = RegexProcessor.IsUrl(@"https://dotnetips.com");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsUrlDomainAddress))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsUrlDomainAddress()
	{
		var result = RegexProcessor.IsUrlDomainAddress(@"https://dotnetips.com");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.IsValidString))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsValidString()
	{
		var result = RegexProcessor.IsValidString(RandomData.LongTestString);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.RemoveHtml))]
	[BenchmarkCategory(Categories.New)]
	public void RemoveHtml()
	{
		var result = RegexProcessor.RemoveHtml("<p>dotnettips</p>");


		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.RemoveSpecialChar))]
	[BenchmarkCategory(Categories.New)]
	public void RemoveSpecialChar()
	{
		var result = RegexProcessor.RemoveSpecialChar("dot@net!tips#");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.ReplaceCrLf))]
	[BenchmarkCategory(Categories.Strings)]
	public void ReplaceCrLf()
	{
		var result = RegexProcessor.ReplaceCrLf("dotnettips" + ControlChars.CRLF);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.ReplaceSpaces))]
	[BenchmarkCategory(Categories.Strings)]
	public void ReplaceSpaces()
	{
		var result = RegexProcessor.ReplaceSpaces(RandomData.LongTestString);

		this.Consume(result);
	}

}
