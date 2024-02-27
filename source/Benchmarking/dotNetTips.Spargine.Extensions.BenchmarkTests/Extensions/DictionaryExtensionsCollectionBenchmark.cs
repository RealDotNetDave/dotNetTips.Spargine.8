// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2023
// ***********************************************************************
// <copyright file="DictionaryExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class DictionaryExtensionsCollectionBenchmark.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class DictionaryExtensionsCollectionBenchmark : SmallCollectionBenchmark
{

	private Dictionary<string, Person<Address>> _personRefDictionary;

	[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Dictionary")]
	[BenchmarkCategory(Categories.Collections)]
	public void GetOrAddDictionary02()
	{
		var people = this._personRefDictionary;

		var result = people.GetOrAdd(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.HasItems) + ": With Predicate")]
	public void HasItemsWithPredicateTest()
	{
		var people = this._personRefDictionary;

		var result = people.HasItems(p => p.Value.Age.TotalDays > 0);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefDictionary = this.GetPersonRefDictionary();
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToSortedDictionary))]
	public void ToSortedDictionaryTest()
	{
		var people = this._personRefDictionary.ToSortedDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
	public void UpsertDictionary01()
	{
		var people = this._personRefDictionary;
		var person = people.Last();

		people.Upsert(person.Key, person.Value);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ": New Person")]
	public void UpsertDictionary02()
	{
		var people = this._personRefDictionary;

		people.Upsert(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(people);
	}

}
