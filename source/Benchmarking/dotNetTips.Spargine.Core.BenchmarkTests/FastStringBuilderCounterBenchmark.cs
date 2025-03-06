// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-05-2025
// ***********************************************************************
// <copyright file="FastStringBuilderCounterBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

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
/// </summary>
[BenchmarkCategory(Categories.Strings)]
public class FastStringBuilderCounterBenchmark : TinyCollectionBenchmark
{
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	private byte[] _byteArray;
	private Dictionary<string, string> _wordDictionary;
	private string[] _words;

	[Benchmark(Description = nameof(FastStringBuilder.BytesToString))]
	[BenchmarkCategory(Categories.Array, Categories.Strings)]
	public void BytesToString()
	{
		var result = FastStringBuilder.BytesToString(ref this._byteArray);

		this.Consume(result);
	}

	[Benchmark(Description = "BytesToString: SB.Append() for Comparison")]
	[BenchmarkCategory(Categories.Array, Categories.Strings, Categories.ForComparison)]
	public void BytesToStringComparison()
	{
		var sb = new StringBuilder();

		_ = sb.Capacity = this._byteArray.Length * 2;
		_ = sb.Append("0x");

		for (var byteCount = 0; byteCount < this._byteArray.LongLength; byteCount++)
		{
			_ = sb.Append(this._byteArray[byteCount].ToString("X2", CultureInfo.InvariantCulture));
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(FastStringBuilder.Combine))]
	[BenchmarkCategory(Categories.Strings)]
	public void Combine()
	{
		var result = FastStringBuilder.Combine(false, this._words);

		base.Consume(result);
	}

	[Benchmark(Description = "Combine Strings: SB.Append() for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void CombineComparison()
	{
		var sb = new StringBuilder();

		foreach (var arg in this._words)
		{
			_ = sb.Append(string.Format(CultureInfo.InvariantCulture, "{0}", arg));
		}

		base.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(FastStringBuilder.CombineWithSpace))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void CombineWithSpace()
	{
		var result = FastStringBuilder.CombineWithSpace(this._words);

		base.Consume(result);
	}

	[Benchmark(Description = "Combine Strings with Space: SB.Append() for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void CombineWithSpaceComparison()
	{
		var sb = new StringBuilder();

		foreach (var arg in this._words)
		{
			_ = sb.Append(string.Format(CultureInfo.InvariantCulture, "{0} ", arg));
		}

		base.Consume(sb.ToString().Trim());
	}

	[Benchmark(Description = nameof(FastStringBuilder.Concat) + ": with Char delimiter")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void ConcatChar()
	{
		var result = FastStringBuilder.Concat(delimiter: ControlChars.Comma, addLineFeed: true, args: this._words);

		this.Consume(result);
	}

	[Benchmark(Description = "Concat Strings: SB.Append() with Char delimiter for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void ConcatCharComparison()
	{
		var sb = new StringBuilder();

		for (var argumentIndex = 0; argumentIndex < this._words.Length; argumentIndex++)
		{
			var line = this._words[argumentIndex];

			_ = sb.Append(string.Format(CultureInfo.InvariantCulture, "{0}{1}", line, ControlChars.Comma));
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(FastStringBuilder.Concat) + ": with String delimiter")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void ConcatString()
	{
		var result = FastStringBuilder.Concat(delimiter: ControlChars.CommaSpace, addLineFeed: true, args: this._words);

		this.Consume(result);
	}

	[Benchmark(Description = "Concat Strings: SB.Append() with String delimiter for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void ConcatStringComparison()
	{
		var sb = new StringBuilder();

		for (var argumentIndex = 0; argumentIndex < this._words.Length; argumentIndex++)
		{
			var line = this._words[argumentIndex];

			_ = sb.Append(string.Format(CultureInfo.InvariantCulture, "{0}{1}", line, ControlChars.CommaSpace));
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(FastStringBuilder.Join) + ": with Char delimiter")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void JoinChar()
	{
		var result = FastStringBuilder.Join(this._words, ControlChars.Comma);

		this.Consume(result);
	}

	[Benchmark(Description = "Join String: SB.AppendJoin()  with Char delimiter for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void JoinCharComparison()
	{
		var sb = new StringBuilder();

		var result = sb.AppendJoin(ControlChars.Comma, this._words);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.Join) + ": with String delimiter")]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void JoinString()
	{
		var result = FastStringBuilder.Join(this._words, ControlChars.CommaSpace);

		this.Consume(result);
	}

	[Benchmark(Description = "Join String: SB.AppendJoin() with String delimiter for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void JoinStringComparison()
	{
		var sb = new StringBuilder();

		var result = sb.AppendJoin(ControlChars.CommaSpace, this._words);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.PerformAction))]
	[BenchmarkCategory(Categories.Strings)]
	public void PerformAction()
	{
		void action(StringBuilder sb)
		{
			for (var index = 0; index < this._words.Length; index++)
			{
				_ = sb.Append(this._words[index]);
			}
		}

		var result = FastStringBuilder.PerformAction(action);


		base.Consume(result);
	}

	[Benchmark(Description = "PerformAction: SB.Append() for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void PerformActionComparison()
	{
		var sb = new StringBuilder();

		for (var index = 0; index < this._words.Length; index++)
		{
			_ = sb.Append(this._words[index]);
		}

		base.Consume(sb.ToString());
	}

	[Benchmark(Description = "PerformAction: Using Object Pool for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void PerformActionStringBuilderPool()
	{
		var sb = _stringBuilderPool.Get();

		void action(StringBuilder sb)
		{
			for (var index = 0; index < this._words.Length; index++)
			{
				_ = sb.Append(this._words[index]);
			}
		}

		var result = FastStringBuilder.PerformAction(action);

		_stringBuilderPool.Return(sb);


		base.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._byteArray = this.GetByteArray(this.Count);
		this._words = [.. RandomData.GenerateWords(this.Count, 10, 10)];
		this._wordDictionary = RandomData.GenerateWords(this.Count, 10, 10).ToDictionary(x => RandomData.GenerateKey(), y => y);

		LogInfo($"ByteArray: {this._byteArray.Length}.");
	}

	[Benchmark(Description = nameof(FastStringBuilder.ToDelimitedString))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void ToDelimitedString()
	{
		var result = FastStringBuilder.ToDelimitedString(this._wordDictionary, ControlChars.Colon);

		this.Consume(result);
	}

	[Benchmark(Description = "ToDelimitedString: SB.Append() for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void ToDelimitedStringComparison()
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
