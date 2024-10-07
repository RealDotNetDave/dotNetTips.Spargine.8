// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : david
// Created          : 10-07-2024
//
// Last Modified By : david
// Last Modified On : 10-07-2024
// ***********************************************************************
// <copyright file="EnumerationBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

public class EnumerationBenchmark : Benchmark
{

	[Benchmark(Description = nameof(Enumeration.FromDisplayName))]
	public void FromDisplayName()
	{
		var result = Enumeration.FromDisplayName<NumericFormat>("C");

		Consume(result);
	}

	[Benchmark(Description = nameof(Enumeration.FromValue))]
	public void FromName()
	{
		var result = Enumeration.FromValue<NumericFormat>(1);

		Consume(result);
	}

	[Benchmark(Description = nameof(Enumeration.GetAll))]
	public void GetAll()
	{
		var result = Enumeration.GetAll<NumericFormat>().ToList();

		Consume(result);
	}
}
