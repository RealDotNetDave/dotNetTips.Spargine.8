// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-06-2025
// ***********************************************************************
// <copyright file="ListExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ListExtensionsCollectionBenchmark : SmallCollectionBenchmark
{
	private List<PersonRecord> _peopleRecordList;
	private List<Person<Address>> _peopleRefList;
	private List<Person<Address>> _peopleRefSubSet;
	private List<Spargine.Tester.Models.ValueTypes.Person<Spargine.Tester.Models.ValueTypes.Address>> _peopleValList;
	private readonly Person<Address> _person = RandomData.GeneratePersonRef<Address>();

	[Benchmark(Description = nameof(ListExtensions.AddFirst))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddFirst()
	{
		var people = this._peopleRefList;

		people.AddFirst(this._person);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddLast))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddLast()
	{
		var people = this._peopleRefList;

		people.AddLast(this._person);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddRangeIfNotExists))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRangeIfNotExists()
	{
		var people = this._peopleRefList;
		var peopleToAdd = this._peopleRefSubSet;

		var modifiedPeople = people.AddRangeIfNotExists(peopleToAdd);

		this.Consume(modifiedPeople);
	}

	[Benchmark(Description = nameof(ListExtensions.AsReadOnlySpan))]
	public void AsReadOnlySpan()
	{
		var people = this._peopleRefList;

		var collection = people.AsReadOnlySpan();

		this.Consume(collection.Length);
	}

	[Benchmark(Description = nameof(ListExtensions.AsSpan))]
	public void AsSpan()
	{
		var people = this._peopleRefList;

		var collection = people.AsSpan();

		this.Consume(collection.Length);
	}

	[Benchmark(Description = nameof(ListExtensions.ClearNulls))]
	public void ClearNulls()
	{
		var people = this._peopleRefList;
		people.Add(null);

		var result = people.ClearNulls();

		this.Consume(result);
	}

	[Benchmark(Description = "CopyTo()")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void CopyToList()
	{
		var result = new Person<Address>[this._peopleRefList.Count];
		this._peopleRefList.CopyTo(result);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.DoesNotHaveItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void DoesNotHaveItems()
	{
		var people = this._peopleRefList;

		this.Consume(people.DoesNotHaveItems());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": record")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeRecord()
	{
		var people = this._peopleRecordList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": ref")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeRef()
	{
		var people = this._peopleRefList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": val")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeVal()
	{
		var people = this._peopleValList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.HasItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItems()
	{
		var people = this._peopleRefList;

		this.Consume(people.HasItems());
	}

	[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithCount()
	{
		var people = this._peopleRefList;

		this.Consume(people.HasItems(5));
	}

	[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Predicate")]
	public void HasItemsWithPredicate()
	{
		var people = this._peopleRefList;

		this.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
	}

	[Benchmark(Description = "Index []")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void Index()
	{
		var result = this._peopleRefList[this.Count / 2];

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IndexAtLooped))]
	public void IndexAtLooped()
	{
		var result = this._peopleRefList.IndexAtLooped(this.Count / 2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IsEqualTo))]
	[BenchmarkCategory(Categories.Collections)]
	public void IsEqualTo()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsEqualTo(this._peopleRefList));
	}

	[IterationCleanup]
	public void IterationCleanup()
	{
		this._peopleRecordList = [.. this.GetPersonRecordArray()];
		this._peopleRefList = [.. this.GetPersonRefArray()];
		this._peopleValList = [.. this.GetPersonValArray()];
	}

	[Benchmark(Description = nameof(ListExtensions.PerformAction) + " :Ref")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void PerformAction_Ref()
	{
		var people = this._peopleRefList;
		var sb = new StringBuilder();

		people.PerformAction((person) =>
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{person.ToString()}|");
		});

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveFirst))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveFirst()
	{
		var result = this._peopleRefList.RemoveFirst(this._peopleRefList.First());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveLast))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveLast()
	{
		var result = this._peopleRefList.RemoveLast(this._peopleRefList.Last());

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRecordList = [.. this.GetPersonRecordArray()];
		this._peopleRefList = [.. this.GetPersonRefArray()];
		this._peopleRefSubSet = this.GetPersonRefArray().TakeLast(10).ToList();
		this._peopleValList = [.. this.GetPersonValArray()];

	}

	[Benchmark(Description = nameof(ListExtensions.Shuffle))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Shuffle()
	{
		this._peopleRefList.Shuffle();

		this.Consume(this._peopleRefList);
	}

	[Benchmark(Description = nameof(ListExtensions.Split))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Split()
	{
		var result = this._peopleRefList.Split(this._peopleRefList.Count / 2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._peopleRefList.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToImmutableArray))]
	public void ToImmutableArray()
	{
		var result = this._peopleRefList.ToImmutableArray();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToObservableCollection))]
	public void ToObservableCollection()
	{
		var result = this._peopleRefList.ToObservableCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyCollection))]
	public void ToReadOnlyCollection()
	{
		var result = this._peopleRefList.ToReadOnlyCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyList))]
	public void ToReadOnlyList()
	{
		var result = this._peopleRefList.ToReadOnlyList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyObservableCollection))]
	public void ToReadOnlyObservableCollection()
	{
		var result = this._peopleRefList.ToReadOnlyObservableCollection();

		this.Consume(result);
	}

}

/// <summary>
/// Class PersonComparer.
/// </summary>
public class PersonComparer : IEqualityComparer<Person<Address>>
{

	/// <summary>
	/// Determines whether the specified objects are equal.
	/// </summary>
	/// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
	/// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
	/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	public bool Equals([AllowNull] Person<Address> x, [AllowNull] Person<Address> y) => x?.Id == y?.Id;

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <param name="obj">The <see cref="object" /> for which a hash code is to be returned.</param>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public int GetHashCode([DisallowNull] Person<Address> obj) => obj.ArgumentNotNull().Id.GetHashCode(StringComparison.Ordinal);

}
