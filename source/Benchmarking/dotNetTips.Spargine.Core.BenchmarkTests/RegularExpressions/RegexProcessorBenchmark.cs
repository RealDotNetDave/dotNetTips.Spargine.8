// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 06-03-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2024
// ***********************************************************************
// <copyright file="RegexProcessorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.RegularExpressions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions;
public class RegexProcessorBenchmark : Benchmark
{

	[Benchmark(Description = nameof(RegexProcessor.ContainsFirstLastName))]
	[BenchmarkCategory(Categories.Strings)]
	public void ContainsFirstLastName()
	{
		var result = RegexProcessor.ContainsFirstLastName("David McCarter");

		Consume(result);
	}

	[Benchmark(Description = nameof(RegexProcessor.ContainsWord))]
	[BenchmarkCategory(Categories.Strings)]
	public void ContainsWord()
	{
		var result = RegexProcessor.ContainsWord(LongTestString);

		Consume(result);
	}


}
