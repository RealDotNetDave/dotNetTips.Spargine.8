// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : david
// Created          : 10-03-2024
//
// Last Modified By : david
// Last Modified On : 10-03-2024
// ***********************************************************************
// <copyright file="KeyGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

public class KeyGeneratorBenchmark : Benchmark
{
	[Benchmark(Description = nameof(KeyGenerator.GenerateKey))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateKey()
	{
		var result = KeyGenerator.GenerateKey();

		Consume(result);
	}

	[Benchmark(Description = nameof(KeyGenerator.GenerateKey) + ": With Prefix")]
	[BenchmarkCategory(Categories.New)]
	public void GenerateKeyPrefix()
	{
		var result = KeyGenerator.GenerateKey("TEST");

		Consume(result);
	}
}
