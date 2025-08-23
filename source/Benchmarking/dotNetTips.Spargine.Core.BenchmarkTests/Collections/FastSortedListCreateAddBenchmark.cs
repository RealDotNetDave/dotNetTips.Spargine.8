// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 03-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 03-05-2025
// ***********************************************************************
// <copyright file="FastSortedListCreateAddBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections;

/// <summary>
/// Class FastSortedListCreateAddBenchmark.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class FastSortedListCreateAddBenchmark : SmallCollectionBenchmark
{
	private Person<Address>[] _peopleRefArrayToInsert;
	private Dictionary<string, Person<Address>> _peopleRefDictionaryToInsert;

	private void GenerateData()
	{
		this._peopleRefArrayToInsert = this.GetPersonRefArray();
		this._peopleRefDictionaryToInsert = this.GetPersonRefDictionary();
	}

	[Benchmark(Description = "Add: FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Add_FastSortedList()
	{
		var people = new FastSortedList<Person<Address>>(this.Count);

		foreach (var person in this._peopleRefArrayToInsert)
		{
			people.Add(person);
		}

		this.Consume(people.Count);
	}

	[Benchmark(Description = "Add: with Comparer(LastName)  - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Add_FastSortedList_Comparer()
	{
		var people = new FastSortedList<Person<Address>>(this.Count, new PersonComparerByLastName());

		foreach (var person in this._peopleRefArrayToInsert)
		{
			people.Add(person);
		}

		this.Consume(people.Count);
	}

	[Benchmark(Description = "Add: SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Add_SortedList()
	{
		var people = new SortedList<string, Person<Address>>(this.Count);

		foreach (var person in this._peopleRefDictionaryToInsert)
		{
			people.Add(person.Key, person.Value);
		}

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.Add) + ": with OrdinalStringComparer")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Add_SortedList_Comparer()
	{
		var people = new SortedList<string, Person<Address>>(this.Count, new OrdinalStringComparer());

		foreach (var person in this._peopleRefArrayToInsert)
		{
			people.Add(person.Id, person);
		}

		this.Consume(people.Count);
	}

	[Benchmark(Description = "AddRange: FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRange_FastSortedList()
	{
		var people = new FastSortedList<Person<Address>>(this.Count);

		people.AddRange(this._peopleRefArrayToInsert);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "AddRange: with Comparer(LastName) - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRange_FastSortedList_Comparer()
	{
		var people = new FastSortedList<Person<Address>>(this.Count, new PersonComparerByLastName());

		people.AddRange(this._peopleRefArrayToInsert);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "AddRange: SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRange_SortedList()
	{
		var people = new SortedList<string, Person<Address>>(this.Count);

		_ = people.AddRange(this._peopleRefDictionaryToInsert);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "AddRange:  with OrdinalStringComparer - SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRange_SortedList_Comparer()
	{
		var people = new SortedList<string, Person<Address>>(this.Count, new OrdinalStringComparer());

		_ = people.AddRange(this._peopleRefDictionaryToInsert);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "New: add collection in constructor - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Create_FastSortedList()
	{
		var people = new FastSortedList<Person<Address>>(this._peopleRefArrayToInsert);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "New: add items in constructor + Comparer(LastName) - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Create_FastSortedList_Comparer()
	{
		var people = new FastSortedList<Person<Address>>(this._peopleRefArrayToInsert, new PersonComparerByLastName());

		this.Consume(people.Count);
	}

	[Benchmark(Description = "New: add collection in constructor - SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Create_SortedList()
	{
		var people = new SortedList<string, Person<Address>>(this._peopleRefDictionaryToInsert);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "New: with OrdinalStringComparer - SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Create_SortedList_Comparer()
	{
		var people = new SortedList<string, Person<Address>>(this._peopleRefDictionaryToInsert, new OrdinalStringComparer());

		this.Consume(people.Count);
	}

	public override void Setup()
	{
		base.Setup();

		this.GenerateData();
	}
}
