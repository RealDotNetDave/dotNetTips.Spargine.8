// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-22-2024
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class CollectionExtensionsCollectionBenchmark.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class CollectionExtensionsCollectionBenchmark : SmallCollectionBenchmark
{

	private Collection<Person<Address>> _peopleRefCollection;
	private List<Person<Address>> _peopleRefList;

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": List")]
	public void AddRange01()
	{
		var people = this._peopleRefList;

		_ = people.AddRange<Person<Address>>(this.GetPersonRefCollectionToInsert(), true);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsReadOnlySpan))]
	public void AsReadOnlySpan()
	{
		var result = this._peopleRefCollection.AsReadOnlySpan();

		this.Consume(result.ToArray());
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsSpan))]
	public void AsSpan()
	{
		var result = this._peopleRefCollection.AsSpan();

		this.Consume(result.ToArray());
	}

	[Benchmark(Description = nameof(CollectionExtensions.HasItems))]
	public void HasItems()
	{
		var result = this._peopleRefCollection.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Count")]
	public void HasItemsWithCount()
	{
		var result = this._peopleRefCollection.HasItems(5);

		this.Consume(result);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._peopleRefCollection = this.GetPersonRefArray().ToCollection();
		this._peopleRefList = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(CollectionExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._peopleRefCollection.ToFrozenSet();

		this.Consume(result);
	}

}
