// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 08-29-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-03-2024
// ***********************************************************************
// <copyright file="UlidGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Tester;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

public class UlidGeneratorBenchmark : Benchmark
{
	[Benchmark(Description = nameof(RandomData.GenerateKey))]
	[BenchmarkCategory(Categories.New, Categories.ForComparison)]
	public void GenerateKey()
	{
		var result = RandomData.GenerateKey();

		Consume(result);
	}

	[Benchmark(Description = nameof(UlidGenerator.GenerateMultipleUlids))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateMultipleUlids()
	{
		var result = UlidGenerator.GenerateMultipleUlids(256);

		Consume(result);
	}

	[Benchmark(Description = nameof(UlidGenerator.GenerateUlid))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateUlid()
	{
		var result = UlidGenerator.GenerateUlid;

		Consume(result);
	}

	[Benchmark(Description = nameof(Guid.NewGuid))]
	[BenchmarkCategory(Categories.New, Categories.ForComparison)]
	public void GuidNewGuid()
	{
		var result = Guid.NewGuid();

		Consume(result);
	}

	public override void Setup()
	{
		base.Setup();
	}
}
