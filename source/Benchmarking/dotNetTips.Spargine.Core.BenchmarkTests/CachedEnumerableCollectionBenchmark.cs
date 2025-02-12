// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-26-2024
// ***********************************************************************
// <copyright file="CachedEnumerableCollectionBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Collection type PerfTestRunner.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class CachedEnumerableCollectionBenchmark : SmallCollectionBenchmark
{
	private IEnumerable<Person<Address>> _peopleRef;
	private CachedEnumerable<Person<Address>> _peopleRefCached;

	[Benchmark(Description = "Looping with for: CachedEnumerable")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void LoopingForCachedEnumerableRef()
	{
		var people = this._peopleRefCached;

		for (var index = 0; index < people.Count; index++)
		{
			this.SimulateWork(people.ElementAt(index));
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with foreach: CachedEnumerable")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void LoopingForEachCachedEnumerableRef()
	{
		var people = this._peopleRefCached;

		foreach (var person in people)
		{
			this.SimulateWork(person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with foreach: IEnumerable")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void LoopingForEachIEnumerableRef()
	{
		var people = this._peopleRef;

		foreach (var person in people)
		{
			this.SimulateWork(person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with for: IEnumerable")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void LoopingForIEnumerableRef()
	{
		var people = this._peopleRef;

		for (var index = 0; index < people.Count(); index++)
		{
			this.SimulateWork(people.ElementAt(index));
		}

		this.Consume(people);
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRef = this.GetPersonRefArray().AsEnumerable();
		this._peopleRefCached = CachedEnumerable.Create(this._peopleRef);
	}
}
