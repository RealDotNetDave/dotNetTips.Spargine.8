// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-06-2024
// ***********************************************************************
// <copyright file="FastStringBuilderCounterBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// StringBuilderHelper PerfTestRunner.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
[BenchmarkCategory(Categories.Strings)]
public class FastStringBuilderCounterBenchmark : TinyCollectionBenchmark
{

	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	private byte[] _byteArray;
	private IEnumerable<byte> _bytes1Kb;
	private Dictionary<string, string> _wordDictionary;
	private string[] _words;

	[Benchmark(Description = nameof(FastStringBuilder.BytesToString))]
	[BenchmarkCategory(Categories.Collections)]
	public void BytesToString()
	{
		var result = FastStringBuilder.BytesToString(this._byteArray);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.BytesToString) + ": Comparison")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void BytesToString_Comparison()
	{
		if (this._byteArray is null)
		{
			return;
		}

		var sb = new StringBuilder();

		_ = sb.Capacity = this._byteArray.Length * 2;
		_ = sb.Append("'0x");

		for (var byteCount = 0; byteCount < this._byteArray.LongLength; byteCount++)
		{
			_ = sb.Append(this._byteArray[byteCount].ToString("X2", CultureInfo.InvariantCulture));
		}

		_ = sb.Append('\'');

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(FastStringBuilder.CombineStrings))]
	[BenchmarkCategory(Categories.Collections)]
	public void CombineStrings()
	{
		var result = FastStringBuilder.CombineStrings(false, this._words);

		base.Consume(result);
	}

	[Benchmark(Description = "Combine Strings: SB.Append() + foreach()")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void CombineStrings_Comparison()
	{
		var sb = new StringBuilder();

		foreach (var arg in this._words)
		{
			_ = sb.Append(arg + ControlChars.EmptyString);
		}

		base.Consume(sb.ToString());
	}

	[Benchmark(Description = "Combine Strings: ConcatStrings")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void ConcatStrings()
	{
		var result = FastStringBuilder.ConcatStrings(delimiter: ControlChars.Comma, addLineFeed: true, args: this._words);

		this.Consume(result);
	}

	[Benchmark(Description = "Combine Strings: SB.AppendLine() + for()")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void ConcatStrings_Comparison()
	{
		var sb = new StringBuilder();

		for (var argumentIndex = 0; argumentIndex < this._words.Length; argumentIndex++)
		{
			var line = this._words[argumentIndex];

			_ = sb.AppendLine(line + ControlChars.Comma);
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(FastStringBuilder.PerformAction))]
	[BenchmarkCategory(Categories.Collections)]
	public void PerformAction()
	{
		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			for (var index = 0; index < this._words.Length; index++)
			{
				_ = sb.Append(this._words[index]);
			}
		};

		var result = FastStringBuilder.PerformAction(action);


		base.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.PerformAction) + ": Comparison")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void PerformAction_Comparison()
	{
		var sb = new StringBuilder();

		for (var index = 0; index < this._words.Length; index++)
		{
			_ = sb.Append(this._words[index]);
		}

		base.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(FastStringBuilder.PerformAction) + ": Using Object Pool")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void PerformAction_StringBuilderPool()
	{
		var sb = _stringBuilderPool.Get();

		Action<StringBuilder> action = (sb) =>
		{
			for (var index = 0; index < this._words.Length; index++)
			{
				_ = sb.Append(this._words[index]);
			}
		};

		var result = FastStringBuilder.PerformAction(action);

		_stringBuilderPool.Return(sb);


		base.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._bytes1Kb = this.GetByteArray(this.Count).AsEnumerable();
		this._byteArray = this.GetByteArray(this.Count);
		this._words = [.. RandomData.GenerateWords(this.Count, 10, 10)];
		this._wordDictionary = RandomData.GenerateWords(this.Count, 10, 10).ToDictionary(x => RandomData.GenerateKey(), y => y);
	}

	[Benchmark(Description = "Creating Delimited String: ToDelimitedString()")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void ToDelimitedString()
	{
		var result = FastStringBuilder.ToDelimitedString(this._wordDictionary, ControlChars.Colon);

		this.Consume(result);
	}

	[Benchmark(Description = "Creating Delimited String: Normal")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void ToDelimitedString_Comparison()
	{
		var sb = new StringBuilder();

		foreach (var item in this._wordDictionary)
		{
			if (sb.Length > 0)
			{
				_ = sb.Append(ControlChars.Comma);
			}

			_ = sb.Append($"{item.Key}: {item.Value}".ToString(CultureInfo.CurrentCulture));
		}

		base.Consume(sb.ToString());
	}

}
