// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 06-02-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-02-2024
// ***********************************************************************
// <copyright file="EnumHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Net.Cache;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

public class EnumHelperBenchmark : Benchmark
{

	[Benchmark(Description = nameof(EnumHelper.GetValues))]
	public void GetValues()
	{
		var result = EnumHelper.GetValues<RequestCacheLevel>(false, false);

		Consume(result);
	}

}
