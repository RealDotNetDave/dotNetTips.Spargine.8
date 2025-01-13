// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-13-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-13-2025
// ***********************************************************************
// <copyright file="FastSortedListAddRemoveBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections;

[BenchmarkCategory(Categories.Collections)]
public class FastSortedListAddRemoveBenchmark : SmallCollectionBenchmark
{
	private Person<Address> _lastPersonRefFastSortedList;
	private int _lastPersonRefFastSortedListIndex;
	private KeyValuePair<string, Person<Address>> _lastPersonRefSortedList;
	private int _lastPersonRefSortedListIndex;
	private FastSortedList<Person<Address>> _personRefFastSortedList;
	private SortedList<string, Person<Address>> _personRefSortedList;

	private void GenerateData()
	{
		// FastSortedList
		this._personRefFastSortedList = new FastSortedList<Person<Address>>(this.GetPersonRefArray());
		this._lastPersonRefFastSortedListIndex = this._personRefFastSortedList.LastIndexOf(this._personRefFastSortedList.Last());
		this._lastPersonRefFastSortedList = this._personRefFastSortedList[^1];

		//SortedList
		this._personRefSortedList = new SortedList<string, Person<Address>>(this.GetPersonRefDictionary());
		this._lastPersonRefSortedListIndex = this._personRefSortedList.IndexOfValue(this._personRefSortedList.Last().Value);
		this._lastPersonRefSortedList = this._personRefSortedList.Last();
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.Remove))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Remove_FastSortedList()
	{
		var people = new FastSortedList<Person<Address>>();

		_ = people.Remove(_lastPersonRefFastSortedList);

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.RemoveAt))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveAt_FastSortedList()
	{
		var people = this._personRefFastSortedList;

		people.RemoveAt(this._lastPersonRefSortedListIndex);

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(SortedList.RemoveAt))]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void RemoveAt_SortedList()
	{
		var people = this._personRefSortedList;

		people.RemoveAt(this._lastPersonRefSortedListIndex);

		this.Consume(people.Count);
	}

	public override void Setup()
	{
		base.Setup();

		this.GenerateData();
	}
}
