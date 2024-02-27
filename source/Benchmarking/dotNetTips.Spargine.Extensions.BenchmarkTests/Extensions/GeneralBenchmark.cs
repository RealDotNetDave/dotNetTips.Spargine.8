// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2022
//
// Last Modified By : David McCarter
// Last Modified On : 08-30-2022
// ***********************************************************************
// <copyright file="GeneralBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class GeneralBenchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
public class GeneralBenchmark : Benchmark
{
	private readonly Guid _firstGuid = Guid.NewGuid();
	private readonly Guid _secondGuid = Guid.NewGuid();

	[Benchmark(Description = "Equals: Guid")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GuidEqualsTest()
	{
		this.Consume(this._firstGuid.Equals(this._secondGuid));
	}
}
