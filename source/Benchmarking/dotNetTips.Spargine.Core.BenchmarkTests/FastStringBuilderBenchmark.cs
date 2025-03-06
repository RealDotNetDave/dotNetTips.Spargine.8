// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 03-06-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-06-2025
// ***********************************************************************
// <copyright file="FastStringBuilderBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

[BenchmarkCategory(Categories.Strings)]
public class FastStringBuilderBenchmark : TinyCollectionBenchmark
{

	private string[] _words;

	[Benchmark(Description = nameof(FastStringBuilder.Format))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void Format()
	{
		var result = FastStringBuilder.Format("Word1 {0}, Word2 {1}, Word3 {1}", this._words);

		this.Consume(result);
	}

	[Benchmark(Description = "AppendFormat: SB.AppendFormat() for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void FormatComparison()
	{
		var sb = new StringBuilder();

		var result = sb.AppendFormat("Word1 {0}, Word2 {1}, Word3 {1}", this._words);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.Remove))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void Remove()
	{
		var result = FastStringBuilder.Remove(this.LongTestString, "and");

		this.Consume(result);
	}

	[Benchmark(Description = "Remove: SB.Replace() with string.Empty for Comparison")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void RemoveComparison()
	{
		var sb = new StringBuilder(this.LongTestString);

		var result = sb.Replace("and", string.Empty);

		this.Consume(result.ToString());
	}

	public override void Setup()
	{
		base.Setup();

		this._words = [.. RandomData.GenerateWords(3, 10, 10)];
	}
}
