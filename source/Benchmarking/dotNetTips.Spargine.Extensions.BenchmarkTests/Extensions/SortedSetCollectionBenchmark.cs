// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-11-2024
// ***********************************************************************
// <copyright file="SortedSetCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
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
/// Class SortedSetCollectionBenchmark. Implements the <see cref="SmallCollectionBenchmark"/>
/// </summary>
/// <seealso cref="SmallCollectionBenchmark"/>
[BenchmarkCategory(Categories.Collections)]
public class SortedSetCollectionBenchmark : SmallCollectionBenchmark
{

	private SortedSet<Person<Address>> _personRefSortedSet;

	[Benchmark(Description = nameof(SortedSetExtensions.DoesNotHaveItems))]
	public void DoesNotHaveItems()
	{
		var people = this._personRefSortedSet;

		this.Consume(people.DoesNotHaveItems());
	}

	[Benchmark(Description = nameof(SortedSetExtensions.HasItems))]
	public void HasItems()
	{
		this.Consume(this._personRefSortedSet.HasItems());
	}

	[Benchmark(Description = nameof(SortedSetExtensions.HasItems) + ": With Predicate")]
	public void HasItemsWithPredicate()
	{
		this.Consume(this._personRefSortedSet.HasItems(p => p.LastName.IsNotEmpty()));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefSortedSet = new SortedSet<Person<Address>>(this.GetPersonRefArray());
	}

	[Benchmark(Description = nameof(SortedSetExtensions.ToImmutableSortedSet))]
	public void ToImmutableSortedSet()
	{
		var people = this._personRefSortedSet;

		this.Consume(people.ToImmutableSortedSet());
	}

}
