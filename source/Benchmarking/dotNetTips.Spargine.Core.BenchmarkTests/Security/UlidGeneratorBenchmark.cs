// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 08-29-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-29-2024
// ***********************************************************************
// <copyright file="UlidGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

public class UlidGeneratorBenchmark : Benchmark
{
	private string _ulid;

	[Benchmark(Description = nameof(UlidGenerator.ExtractTimestamp))]
	[BenchmarkCategory(Categories.New)]
	public void ExtractTimestamp()
	{
		var result = UlidGenerator.ExtractTimestamp(_ulid);

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

	public override void Setup()
	{
		base.Setup();

		this._ulid = UlidGenerator.GenerateUlid();
	}
}
