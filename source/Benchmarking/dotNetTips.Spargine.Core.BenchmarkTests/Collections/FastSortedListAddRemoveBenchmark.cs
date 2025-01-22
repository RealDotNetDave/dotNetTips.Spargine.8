// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-13-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-14-2025
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
	private Person<Address> _lastPersonRefFastSortedListComparer;
	private int _lastPersonRefFastSortedListIndex;
	private int _lastPersonRefFastSortedListIndexComparer;
	private KeyValuePair<string, Person<Address>> _lastPersonRefSortedList;
	private KeyValuePair<string, Person<Address>> _lastPersonRefSortedListComparer;
	private int _lastPersonRefSortedListIndex;
	private int _lastPersonRefSortedListIndexComparer;
	private FastSortedList<Person<Address>> _personRefFastSortedList;
	private FastSortedList<Person<Address>> _personRefFastSortedListComparer;
	private SortedList<string, Person<Address>> _personRefSortedList;

	private SortedList<string, Person<Address>> _personRefSortedListComparer;

	private void GenerateData()
	{
		// FastSortedList
		this._personRefFastSortedList = new FastSortedList<Person<Address>>(this.GetPersonRefArray());
		this._lastPersonRefFastSortedListIndex = this._personRefFastSortedList.Count - 1;
		this._lastPersonRefFastSortedList = this._personRefFastSortedList[^1];

		// FastSortedList Comparer
		this._personRefFastSortedListComparer = new FastSortedList<Person<Address>>(this.GetPersonRefArray(), new PersonComparerByLastName());
		this._lastPersonRefFastSortedListIndexComparer = this._personRefFastSortedListComparer.Count - 1;
		this._lastPersonRefFastSortedListComparer = this._personRefFastSortedListComparer[^1];

		// SortedList
		this._personRefSortedList = new SortedList<string, Person<Address>>(this.GetPersonRefDictionary());
		this._lastPersonRefSortedListIndex = this._personRefSortedList.Count - 1;
		this._lastPersonRefSortedList = this._personRefSortedList.Last();

		// SortedList Comparer
		this._personRefSortedListComparer = new SortedList<string, Person<Address>>(this.GetPersonRefDictionary(), new OrdinalStringComparer());
		this._lastPersonRefSortedListIndexComparer = this._personRefSortedListComparer.Count - 1;
		this._lastPersonRefSortedListComparer = this._personRefSortedListComparer.Last();

		//ConsoleLogger.Default.WriteLine(LogKind.Info, $"SL Index: {this._lastPersonRefSortedListIndex}.");
	}

	[IterationCleanup]
	public void IterationCleanup()
	{
		this.GenerateData();
	}

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.Remove))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Remove_FastSortedList()
	{
		var people = new FastSortedList<Person<Address>>();

		_ = people.Remove(this._lastPersonRefFastSortedList);

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

	[Benchmark(Description = nameof(FastSortedList<Person<Address>>.RemoveAt) + ": Comparer(LastName)")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveAtFastSortedListComparer()
	{
		var people = this._personRefFastSortedListComparer;

		people.RemoveAt(this._lastPersonRefFastSortedListIndexComparer);

		this.Consume(people.Count);
	}

	[Benchmark(Description = nameof(SortedList.RemoveAt) + ": With Comparer(LastName)")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void RemoveAtSortedListComparer()
	{
		var people = this._personRefSortedListComparer;

		people.RemoveAt(this._lastPersonRefSortedListIndexComparer);

		this.Consume(people.Count);
	}

	public override void Setup()
	{
		base.Setup();

		this.GenerateData();
	}
}
