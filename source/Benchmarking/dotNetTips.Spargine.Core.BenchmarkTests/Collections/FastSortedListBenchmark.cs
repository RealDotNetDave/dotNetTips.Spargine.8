// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 03-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 03-05-2025
// ***********************************************************************
// <copyright file="FastSortedListBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections;


[BenchmarkCategory(Categories.Collections)]
public class FastSortedListBenchmark : SmallCollectionBenchmark
{
	private Person<Address>[] _peopleRefArrayToInsert;
	private Dictionary<string, Person<Address>> _peopleRefDictionaryToInsert;

	private void GenerateData()
	{
		this._peopleRefArrayToInsert = this.GetPersonRefArray();
		this._peopleRefDictionaryToInsert = this.GetPersonRefDictionary();
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.Add) + ": New FastSortedList + Sort")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Add_FastSortedList()
	{
		var people = new FastSortedList<Person<Address>>();

		foreach (var person in this._peopleRefArrayToInsert)
		{
			people.Add(person);
		}

		people.Sort();

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.Add) + ": New FastSortedList with Comparer(LastName) + Sort")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Add_FastSortedList_Comparer()
	{
		var people = new FastSortedList<Person<Address>>(new PersonComparerByLastName());

		foreach (var person in this._peopleRefArrayToInsert)
		{
			people.Add(person);
		}

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(SortedList.Add) + ": New SortedList")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Add_SortedList()
	{
		var people = new SortedList<string, Person<Address>>();

		foreach (var person in this._peopleRefDictionaryToInsert)
		{
			people.Add(person.Key, person.Value);
		}

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.AddRange) + ": New FastSortedList + Sort")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRange_FastSortedList()
	{
		var people = new FastSortedList<Person<Address>>();

		people.AddRange(this._peopleRefArrayToInsert);

		people.Sort();

		this.Consume(people.Count);
	}


	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.AddRange) + ": New FastSortedList with Comparer(LastName) + Sort")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRangeFastSortedListComparer()
	{
		var people = new FastSortedList<Person<Address>>(new PersonComparerByLastName());

		people.AddRange(this._peopleRefArrayToInsert);

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>) + ": Create + Sort")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Create_FastSortedList()
	{
		var people = new FastSortedList<Person<Address>>(this._peopleRefArrayToInsert);

		people.Sort();

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(SortedList<string, Person<Address>>) + ": Create")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Create_SortedList()
	{
		var people = new SortedList<string, Person<Address>>(this._peopleRefDictionaryToInsert);

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>) + ": Create with Comparer(LastName) + Sort")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void CreateFastSortedListComparer()
	{
		var people = new FastSortedList<Person<Address>>(this._peopleRefArrayToInsert, new PersonComparerByLastName());

		this.Consume(people.Count);
	}

	public override void Setup()
	{
		base.Setup();

		this.GenerateData();
	}
}
