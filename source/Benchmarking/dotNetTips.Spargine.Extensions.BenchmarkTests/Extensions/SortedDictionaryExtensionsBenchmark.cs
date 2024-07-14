// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-11-2024
// ***********************************************************************
// <copyright file="SortedDictionaryExtensionsBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class SortedDictionaryExtensionsBenchmark.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class SortedDictionaryExtensionsBenchmark : SmallCollectionBenchmark
{

	private SortedDictionary<string, Person<Address>> _personRefSortedDictionary;

	[Benchmark(Description = nameof(SortedDictionaryExtensions.DoesNotHaveItems))]
	public void DoesNotHaveItems()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.DoesNotHaveItems());
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.HasItems))]
	public void HaveItems()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.HasItems());
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.HasItems) + ": With Count")]
	public void HaveItemsWithCount()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.HasItems(this.Count));
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.HasItems) + ": With Predicate")]
	public void HaveItemsWithPredicate()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.HasItems(p => p.Value.Age.TotalDays > 500));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefSortedDictionary = this.GetPersonRefDictionary().ToSortedDictionary();
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.ToImmutable))]
	public void ToImmutable()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.ToImmutable());
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.Upsert))]
	public void Upsert()
	{
		var people = this._personRefSortedDictionary;

		people.Upsert(this.PersonRef01);

		this.Consume(people);
	}

}
