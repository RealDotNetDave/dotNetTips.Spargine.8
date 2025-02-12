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
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Collection type PerfTestRunner.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class CachedEnumerableCollectionBenchmark : LargeCollectionBenchmark
{
	private CachedEnumerable<Person<Address>> _personRefCached;
	private IEnumerable<Person<Address>> _personRefEnumerable;

	[Benchmark(Description = "Looping with foreach(): CachedEnumerable")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void LoopingForEachCachedEnumerableRef()
	{
		var people = this._personRefCached;

		foreach (var person in people)
		{
			this.SimulateWork(person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with foreach(): CachedEnumerable X2")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void LoopingForEachCachedEnumerableRefX2()
	{
		var people = this._personRefCached;

		// First iteration
		foreach (var person in people)
		{
			this.SimulateWork(person);
		}

		// Second iteration
		foreach (var person in people)
		{
			this.SimulateWork(person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with foreach(): IEnumerable")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void LoopingForEachIEnumerableRef()
	{
		var people = this._personRefEnumerable;

		foreach (var person in people)
		{
			this.SimulateWork(person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with foreach(): IEnumerable X2")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void LoopingForEachIEnumerableRefX2()
	{
		var people = this._personRefEnumerable;

		// First iteration
		foreach (var person in people)
		{
			this.SimulateWork(person);
		}

		// Second iteration
		foreach (var person in people)
		{
			this.SimulateWork(person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with Parallel.ForEach(): CachedEnumerable")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void LoopingParallelForEachCachedEnumerableRef()
	{
		var people = this._personRefCached;

		_ = Parallel.ForEach(people, this.SimulateWork);

		this.Consume(people);
	}


	[Benchmark(Description = "Looping with Parallel.ForEach(): CachedEnumerable X2")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void LoopingParallelForEachCachedEnumerableRefX2()
	{
		var people = this._personRefCached;

		// First iteration
		_ = Parallel.ForEach(people, this.SimulateWork);

		// Second iteration
		_ = Parallel.ForEach(people, this.SimulateWork);

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with Parallel.ForEach(): IEnumerable")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void LoopingParallelForEachIEnumerableRef()
	{
		var people = this._personRefEnumerable;

		_ = Parallel.ForEach(people, this.SimulateWork);

		this.Consume(people);
	}

	[Benchmark(Description = "Looping with Parallel.ForEach(): IEnumerable X2")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void LoopingParallelForEachIEnumerableRefX2()
	{
		var people = this._personRefEnumerable;

		// First iteration
		_ = Parallel.ForEach(people, this.SimulateWork);

		// Second iteration
		_ = Parallel.ForEach(people, this.SimulateWork);

		this.Consume(people);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefCached = CachedEnumerable.Create(this.GetPersonRefArray().AsEnumerable());
	}


}
