// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 03-15-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2025
// ***********************************************************************
// <copyright file="ConcurrentBagExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ConcurrentBagExtensionsCollectionBenchmark : SmallCollectionBenchmark
{
	private ConcurrentBag<Person<Address>> _peopleRefConcurrentBag;
	private IEnumerable<Person<Address>> _peopleRefEnumerable;

	[Benchmark(Description = nameof(ConcurrentBagExtensions.AddRange))]
	public void AddRange()
	{
		var bag = new ConcurrentBag<Person<Address>>();

		bag.AddRange(this._peopleRefEnumerable);

		this.Consume(bag);
	}

	[Benchmark(Description = nameof(ConcurrentBagExtensions.RemoveRange))]
	public void RemoveRange()
	{
		var bag = new ConcurrentBag<Person<Address>>(this._peopleRefEnumerable);

		bag = bag.RemoveRange(this._peopleRefEnumerable);

		this.Consume(bag);
	}


	public override void Setup()
	{
		base.Setup();

		this._peopleRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._peopleRefConcurrentBag = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(ConcurrentBagExtensions.ToList))]
	public void ToList()
	{
		var list = this._peopleRefConcurrentBag.ToList();

		this.Consume(list);
	}
}
