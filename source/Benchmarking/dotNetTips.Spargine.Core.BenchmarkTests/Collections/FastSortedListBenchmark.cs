// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 03-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-03-2024
// ***********************************************************************
// <copyright file="FastSortedListBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections;

/// <summary>
/// Collection type PerfTestRunner.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
[BenchmarkCategory(Categories.Async)]
public class FastSortedListBenchmark : SmallCollectionBenchmark
{
	private List<Person<Address>> _personRefList;

	public override void Setup()
	{
		base.Setup();

		// Create Hash Set
		this._personRefList = new List<Person<Address>>(this.GetPersonRefArray());
	}

	[Benchmark(Description = nameof(FastSortedList.Add))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
}
