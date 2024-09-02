// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 09-02-2024
//
// Last Modified By : David McCarter
// Last Modified On : 09-02-2024
// ***********************************************************************
// <copyright file="NumericExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

public class NumericExtensionsBenchmark : Benchmark
{

	private readonly int _testValue = 54928;

	[Benchmark(Description = nameof(NumericExtensions.ToWords))]
	[BenchmarkCategory(Categories.New)]
	public void ToWords()
	{
		var result = this._testValue.ToWords();

		this.Consume(result);
	}
}
