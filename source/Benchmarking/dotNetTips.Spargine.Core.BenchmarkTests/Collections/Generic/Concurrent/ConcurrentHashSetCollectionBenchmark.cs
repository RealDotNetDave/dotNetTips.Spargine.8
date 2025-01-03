// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2025
// ***********************************************************************
// <copyright file="ConcurrentHashSetCollectionBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent;

[BenchmarkCategory(Categories.Async)]
public class ConcurrentHashSetCollectionBenchmark : SmallCollectionBenchmark
{
	private ConcurrentHashSet<Person<Address>> _personRefConcurrentHashSet;

	[Benchmark(Description = nameof(ConcurrentHashSet<Person<Address>>.Clear))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void Clear()
	{
		var people = this._personRefConcurrentHashSet;

		people.Clear();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person<Address>>.Contains))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void Contains()
	{
		var people = this._personRefConcurrentHashSet;

		var result = people.Contains(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person<Address>>.CopyTo))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void CopyTo()
	{
		var people = this._personRefConcurrentHashSet;
		var array = new Person<Address>[people.Count];

		people.CopyTo(array, 0);

		this.Consume(array);
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person<Address>>.Count))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void CountPeople()
	{
		var people = this._personRefConcurrentHashSet;

		var result = people.Count;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person<Address>>.IsEmpty))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void IsEmpty()
	{
		var people = this._personRefConcurrentHashSet;

		var result = people.IsEmpty;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person<Address>>.Remove))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void Remove()
	{
		var people = this._personRefConcurrentHashSet;

		var result = people.Remove(this.PersonRef01);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		// Create Hash Set
		this._personRefConcurrentHashSet = [.. this.GetPersonRefArray()];

	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person<Address>>.TryRemove))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void TryRemove()
	{
		var people = this._personRefConcurrentHashSet;

		var result = people.TryRemove(this.PersonRef01);

		this.Consume(result);
	}
}
