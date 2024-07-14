// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-01-2024
// ***********************************************************************
// <copyright file="StringExtensionsCounterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Globalization;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// StringExtensions CounterPerfTestRunner.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
[BenchmarkCategory(Categories.Strings)]
public class StringExtensionsCounterBenchmark : TinyCollectionBenchmark
{

	private readonly string _base64String;
	private string _brotilString;
	private string _crlfString;
	private string _gzipString;

	[Benchmark(Description = nameof(StringExtensions.ComputeHash) + ": SHA256")]
	[BenchmarkCategory(Categories.Strings)]
	public void ComputeHash()
	{
		var result = this._crlfString.ComputeHash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ComputeSHA256Hash))]
	[BenchmarkCategory(Categories.Strings)]
	public void ComputeSHA256Hash()
	{
		var result = this._crlfString.ComputeSha256Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ContainsAny))]
	[BenchmarkCategory(Categories.Strings)]
	public void ContainsAny()
	{
		var result = this._crlfString.ContainsAny(Convert.ToChar("a", CultureInfo.InvariantCulture), Convert.ToChar("z", CultureInfo.InvariantCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DelimitedStringToArray))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void DelimitedStringToArray()
	{
		var result = this._crlfString.DelimitedStringToArray(ControlChars.Dot);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.EqualsIgnoreCase))]
	[BenchmarkCategory(Categories.Strings)]
	public void EqualsIgnoreCase()
	{
		var result = this._crlfString.EqualsIgnoreCase(this._crlfString);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.EqualsOrBothNullOrEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void EqualsOrBothNullOrEmpty()
	{
		var result = this._crlfString.EqualsOrBothNullOrEmpty(this._crlfString);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.FromBase64))]
	[BenchmarkCategory(Categories.Strings)]
	public void FromBase64()
	{
		var result = this._base64String.FromBase64();

		this.Consume(result);
	}

	//[Benchmark(Description = nameof(StringExtensions.FromBrotliStringAsync))]
	//[BenchmarkCategory(Categories.New, Categories.Strings, Categories.Async)]
	//public async Task FromBrotliAsync()
	//{
	//	var result = await this._brotilString.FromBrotliStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	//[Benchmark(Description = nameof(StringExtensions.FromGZipStringAsync))]
	//[BenchmarkCategory(Categories.New, Categories.Strings, Categories.Async)]
	//public async Task FromGZipAsync()
	//{
	//	var result = await this._gzipString.FromGZipStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	[Benchmark(Description = nameof(StringExtensions.RemoveCRLF))]
	[BenchmarkCategory(Categories.Strings)]
	public void RemoveCRLF01()
	{
		var testString = this._crlfString.Clone<string>();

		var result = testString.RemoveCRLF();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		//Create lines of text.
		var sb = new StringBuilder(Count * 70);

		for (var lineCount = 0; lineCount < this.Count; lineCount++)
		{
			_ = sb.Append(RandomData.GenerateWord(10))
			  .Append(ControlChars.Space)
			  .Append(RandomData.GenerateWord(10)).Append(ControlChars.Space)
			  .Append(RandomData.GenerateWord(10)).Append(ControlChars.Space)
			  .Append(RandomData.GenerateWord(10)).Append(ControlChars.Space)
			  .Append(RandomData.GenerateWord(10))
			  .Append(ControlChars.Dot)
			  .AppendLine();
		}

		this._crlfString = sb.ToString().Trim();
		this._brotilString = this._crlfString.ToBrotliStringAsync().Result;
		_brotilString = _crlfString.ToBrotliStringAsync().GetAwaiter().GetResult();
		_gzipString = _crlfString.ToGZipStringAsync().GetAwaiter().GetResult();
	}

	[Benchmark(Description = "Split")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void Split()
	{
		foreach (var line in this._crlfString.Split(ControlChars.CRLF))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.SplitLines))]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitLines()
	{
		foreach (var line in this._crlfString.SplitLines())
		{
			this.Consume(line.Line.ToString());
		}
	}

	[Benchmark(Description = nameof(StringExtensions.SplitRemoveEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitRemoveEmpty()
	{
		foreach (var line in this._crlfString.SplitRemoveEmpty())
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": RemoveEmptyEntries")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithRemoveEmptyEntries()
	{
		foreach (var line in this._crlfString.Split(StringSplitOptions.RemoveEmptyEntries, ControlChars.Dot))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": TrimEntries")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithTrimEntries()
	{
		foreach (var line in this._crlfString.Split(StringSplitOptions.TrimEntries, ControlChars.Dot))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": TrimEntries + Count")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithTrimEntriesCount()
	{
		foreach (var line in this._crlfString.Split(StringSplitOptions.TrimEntries, 10, ControlChars.Dot))
		{
			this.Consume(line);
		}
	}

	//TODO: CAUSES BENCHMARK TESTS TO CRASH
	//[Benchmark(Description = nameof(StringExtensions.ToBrotliStringAsync))]
	//[BenchmarkCategory(Categories.New, Categories.Strings)]
	//public async Task ToBrotliAsync()
	//{
	//	var result = await this._crlfString.ToBrotliStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	//[Benchmark(Description = nameof(StringExtensions.ToGZipStringAsync))]
	//[BenchmarkCategory(Categories.New, Categories.Strings)]
	//public async Task ToGZipAsync()
	//{
	//	var result = await this._crlfString.ToGZipStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

}
