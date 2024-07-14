// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 08-03-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-11-2024
// ***********************************************************************
// <copyright file="StringExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Text;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class StringExtensionsBenchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
[BenchmarkCategory(Categories.Strings)]
public class StringExtensionsBenchmark : Benchmark
{

	public const string MacAddress = "00:1A:C2:7B:00:47";

	private string _compressedString;
	private readonly string _creditCardNumber = RandomData.GenerateNumber(12);
	private readonly string _currencyCode = "USD";
	private readonly string _delimitedString = RandomData.GenerateWords(100).ToDelimitedString();
	private readonly string _domainAddress = "www.dotnettips.com";
	private readonly string _emailAddress = RandomData.GenerateEmailAddress();
	private readonly string _hashCode = RandomData.GenerateWord(100).ComputeSHA256Hash();
	private readonly string _isbn = "0525505997";
	private readonly string _nullTestString = null;
	private readonly string _oneToSevenAlpha = RandomData.GenerateWord(7);
	private readonly string _personName = "David McCarter";
	private readonly string _stringWithEllipsis = RandomData.GenerateWord(100) + "...";
	private readonly char _testCharacter = RandomData.GenerateCharacter();
	private string _zlibString;

	[Benchmark(Description = nameof(StringExtensions.CombineToString))]
	[BenchmarkCategory(Categories.Strings)]
	public void CombineToString()
	{
		var result = this.LongTestString.CombineToString(this.GetStringArray(10, 15, 15));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ComputeHash))]
	[BenchmarkCategory(Categories.Strings)]
	public void ComputeHash()
	{
		var testString = this.LongTestString;

		var result = testString.ComputeHash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ComputeSHA256Hash))]
	[BenchmarkCategory(Categories.Strings)]
	public void ComputeSHA256Hash()
	{
		var testString = this.LongTestString;

		var result = testString.ComputeSHA256Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.Concat))]
	[BenchmarkCategory(Categories.Strings)]
	public void Concat()
	{
		var testString = this.LongTestString;

		var result = testString.Concat(",", true, this.GetStringArray(10, 15, 15));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ContainsAny))]
	[BenchmarkCategory(Categories.Strings)]
	public void ContainsAny()
	{
		var testString = this.LongTestString;

		var result = testString.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "d", "T");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNull))]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNull()
	{
		var result = String15Characters01.DefaultIfNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullOrEmpty()
	{
		var result = String15Characters01.DefaultIfNullOrEmpty("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty) + " + Default Value")]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullOrEmptyWithDefaultValue()
	{
		var result = String15Characters01.DefaultIfNullOrEmpty("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty) + " + Default Value: Null Test")]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullOrEmptyWithDefaultValueFromNull()
	{
		var result = this._nullTestString.DefaultIfNullOrEmpty("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNull) + " + Default Value")]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullWithDefaultValue()
	{
		var result = String15Characters01.DefaultIfNull("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNull) + " + Default Value: Null Test")]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullWithDefaultValueFromNull()
	{
		var result = this._nullTestString.DefaultIfNull("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DelimitedStringToArray))]
	[BenchmarkCategory(Categories.Strings)]
	public void DelimitedStringToArray()
	{
		var testString = this._delimitedString;

		var result = testString.DelimitedStringToArray();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.EqualsIgnoreCase))]
	[BenchmarkCategory(Categories.Strings)]
	public void EqualsIgnoreCase()
	{
		var result = String15Characters01.EqualsIgnoreCase(String15Characters02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.EqualsOrBothNullOrEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void EqualsOrBothNullOrEmpty()
	{
		var result = String15Characters01.EqualsOrBothNullOrEmpty(String15Characters02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.Extract))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void Extract()
	{
		var result = this.LongTestString.Extract("and", "are");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.FromBase64))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void FromBase64()
	{
		var result = this.Base64String.FromBase64();

		this.Consume(result);
	}

	//[Benchmark(Description = nameof(StringExtensions.FromDeflateStringAsync))]
	//[BenchmarkCategory(Categories.Strings)]
	//public async Task FromDeflateStringAsync()
	//{
	//	var result = await this._compressedString.FromDeflateStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	//[Benchmark(Description = nameof(StringExtensions.FromZLibStringAsync))]
	//[BenchmarkCategory(Categories.Strings)]
	//public async Task FromZLibStringAsync()
	//{
	//	var result = await this._zlibString.FromZLibStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	[Benchmark(Description = nameof(StringExtensions.HasValue))]
	[BenchmarkCategory(Categories.Strings)]
	public void HasValue()
	{
		var result = this.LongTestString.HasValue();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasValue) + ": Length")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void HasValueWithLength()
	{
		var result = this.LongTestString.HasValue(100);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasValue) + ": Min & Max Count")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void HasValueWithMinMaxCount()
	{
		var result = this.LongTestString.HasValue(5, 100);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasValue) + ": RegEx + IgnoreCase")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void HasValueWithRegEx()
	{
		var result = TestEmailMixedCase.HasValue(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasValue) + ": String")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void HasValueWithString()
	{
		var result = this.LongTestString.HasValue("A");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasWhitespace))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void HasWhitespace()
	{
		var result = this.LongTestString.HasWhitespace();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.Indent))]
	[BenchmarkCategory(Categories.Strings)]
	public void Indent()
	{
		var result = this.LongTestString.Indent(10, '>');

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsAsciiDigit))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsAsciiDigit()
	{
		var result = this._testCharacter.IsAsciiDigit();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsAsciiLetter))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsAsciiLetter()
	{
		var result = this._testCharacter.IsAsciiLetter();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsAsciiLetterOrDigit))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsAsciiLetterOrDigit()
	{
		var result = this._testCharacter.IsAsciiLetterOrDigit();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsAsciiWhitespace))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsAsciiWhitespace()
	{
		var result = this._testCharacter.IsAsciiWhitespace();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsCreditCardNumber))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsCreditCardNumber()
	{
		var result = this._creditCardNumber.IsCreditCardNumber();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsCurrencyCode))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsCurrencyCode()
	{
		var result = this._currencyCode.IsCurrencyCode();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsDomainAddress))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsDomainAddress()
	{
		var result = this._domainAddress.IsDomainAddress();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsEmailAddress))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsEmailAddress()
	{
		var result = this._emailAddress.IsEmailAddress();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsEmpty))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsEmpty()
	{
		var result = String15Characters01.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsFirstLastName))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsFirstLastName()
	{
		var result = this._personName.IsFirstLastName();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsGuid))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsGuid()
	{
		var guid = this.TestGuid.ToString();
		var result = guid.IsGuid();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsISBN))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsISBN()
	{
		var result = this._isbn.IsISBN();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsMacAddress))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsMacAddress()
	{
		var result = MacAddress.IsMacAddress();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsNotEmpty))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsNotEmpty()
	{
		var result = String15Characters01.IsNotEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsOneToSevenAlpha))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsOneToSevenAlpha()
	{
		var result = this._oneToSevenAlpha.IsOneToSevenAlpha();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsScientific))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsScientific()
	{
		var result = "6.5 ✕ 10^8".IsScientific();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsString))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsString()
	{
		var result = this.LongTestString.IsString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsStringSHA1Hash))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsStringSHA1Hash()
	{
		var result = this._hashCode.IsStringSHA1Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsUrl))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsUrl()
	{
		var result = this._domainAddress.IsUrl();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ReplaceEllipsisWithPeriod))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void ReplaceEllipsisWithPeriod()
	{
		var result = this._stringWithEllipsis.ReplaceEllipsisWithPeriod();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._compressedString = this.LongTestString.ToDeflateStringAsync().Result;
		this._zlibString = this.LongTestString.ToZLibStringAsync().Result;
	}

	[Benchmark(Description = nameof(StringExtensions.Split))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void Split()
	{
		var result = this.LongTestString.Split(StringSplitOptions.TrimEntries);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": With Count")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void Split_WithCount()
	{
		var result = this.LongTestString.Split(StringSplitOptions.TrimEntries, 2, ControlChars.Comma);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.SplitRemoveEmpty))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void SplitRemoveEmpty()
	{
		var result = this.LongTestString.SplitRemoveEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinal))]
	[BenchmarkCategory(Categories.Strings)]
	public void StartsWithOrdinal()
	{
		var result = String10Characters01.StartsWithOrdinal(String15Characters01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinalIgnoreCase))]
	public void StartsWithOrdinalIgnoreCase()
	{
		var result = String10Characters01.StartsWithOrdinalIgnoreCase(String15Characters01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.SubstringTrim))]
	public void SubstringTrim()
	{
		var result = this.StringToTrim.SubstringTrim(25, 25);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToBase64))]
	[BenchmarkCategory(Categories.Strings)]
	public void ToBase64()
	{
		var result = this.LongTestString.ToBase64();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": ASCII")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArray_ASCII()
	{
		var result = this.LongTestString.ToByteArray(Encoding.ASCII);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": BigEndianUnicode")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArray_BigEndianUnicode()
	{
		var result = this.LongTestString.ToByteArray(Encoding.BigEndianUnicode);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": Default")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArray_Default()
	{
		var result = this.LongTestString.ToByteArray(Encoding.Default);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": Latin1")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArray_Latin1()
	{
		var result = this.LongTestString.ToByteArray(Encoding.Latin1);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": Unicode")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArray_Unicode()
	{
		var result = this.LongTestString.ToByteArray(Encoding.Unicode);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": UTF32")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArray_UTF32()
	{
		var result = this.LongTestString.ToByteArray(Encoding.UTF32);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": UTF8")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArray_UTF8()
	{
		var result = this.LongTestString.ToByteArray(Encoding.UTF8);

		this.Consume(result);
	}

	//[Benchmark(Description = nameof(StringExtensions.ToDeflateStringAsync))]
	//[BenchmarkCategory(Categories.Strings)]
	//public async Task ToDeflateStringAsync()
	//{
	//	var result = await this.LongTestString.ToDeflateStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	[Benchmark(Description = nameof(StringExtensions.ToTitleCase))]
	public void ToTitleCase() => this.Consume(LowerCaseString.ToTitleCase());

	[Benchmark(Description = nameof(StringExtensions.ToTrimmed))]
	public void ToTrimmedString()
	{
		var result = this.StringToTrim.ToTrimmed();

		this.Consume(result);
	}

	//[Benchmark(Description = nameof(StringExtensions.ToZLibStringAsync))]
	//[BenchmarkCategory(Categories.Strings)]
	//public async Task ToZLibStringAsync()
	//{
	//	var result = await this.LongTestString.ToZLibStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

}
