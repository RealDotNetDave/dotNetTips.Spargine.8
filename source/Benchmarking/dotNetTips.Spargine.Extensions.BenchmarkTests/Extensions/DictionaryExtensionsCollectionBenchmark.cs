// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-10-2024
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

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
	private Dictionary<string, Person<Address>> _personRefDictionaryToInsert;


	[Benchmark(Description = nameof(DictionaryExtensions.AddRange))]
	public void AddRange()
	{
		var people = this._personRefDictionary;

		var result = people.AddRange(this._personRefDictionaryToInsert);

		this.Consume(result);
	}

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
		this._personRefDictionaryToInsert = this.GetPersonRefDictionary().Take(this.Count / 2).ToDictionary();
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToConcurrentDictionary))]
	public void ToConcurrentDictionary()
	{
		var people = this._personRefDictionary.ToConcurrentDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToDelimitedString))]
	public void ToDelimitedString()
	{
		var people = this._personRefDictionary;

		var result = people.ToDelimitedString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToFrozenDictionary))]
	public void ToFrozenDictionary()
	{
		var people = this._personRefDictionary.ToFrozenDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToImmutableDictionary))]
	public void ToImmutableDictionary()
	{
		var people = this._personRefDictionary.ToImmutableDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToImmutableSortedDictionary))]
	public void ToImmutableSortedDictionary()
	{
		var people = this._personRefDictionary.ToReadOnlyCollection();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToReadOnlyCollection))]
	public void ToReadOnlyCollection()
	{
		var people = this._personRefDictionary.ToImmutableSortedDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToReadOnlyDictionary))]
	public void ToReadOnlyDictionary()
	{
		var people = this._personRefDictionary.ToReadOnlyDictionary();

		this.Consume(people);
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
