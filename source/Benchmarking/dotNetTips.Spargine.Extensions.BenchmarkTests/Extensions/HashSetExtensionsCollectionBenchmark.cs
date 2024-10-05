// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 06-10-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2024
// ***********************************************************************
// <copyright file="HashSetExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class HashSetExtensionsCollectionBenchmark : SmallCollectionBenchmark
{

	private HashSet<Person<Address>> _peopleRefToAdd;
	private HashSet<Person<Address>> _personRefHashSet;
	private Person<Address> _personRefToAdd;

	[Benchmark(Description = nameof(HashSetExtensions.AddIf))]
	public void AddIf()
	{
		var collection = this._personRefHashSet;

		collection.AddIf(this._personRefToAdd, true);

		this.Consume(collection);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefHashSet = [.. this.GetPersonRefCollection()];
		this._peopleRefToAdd = this._personRefHashSet.Take(this.Count / 2).ToHashSet();
		this._personRefToAdd = this._personRefHashSet.Last();

	}

	[Benchmark(Description = nameof(HashSetExtensions.ToConcurrentHashSet))]
	public void ToConcurrentHashSet()
	{
		var result = this._personRefHashSet.ToConcurrentHashSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(HashSetExtensions.ToImmutableHashSet))]
	public void ToImmutableHashSet()
	{
		var result = this._personRefHashSet.ToImmutableHashSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(HashSetExtensions.Upsert))]
	public void Upsert()
	{
		var collection = this._personRefHashSet;

		collection.Upsert(this._personRefToAdd);

		this.Consume(collection);
	}

}
