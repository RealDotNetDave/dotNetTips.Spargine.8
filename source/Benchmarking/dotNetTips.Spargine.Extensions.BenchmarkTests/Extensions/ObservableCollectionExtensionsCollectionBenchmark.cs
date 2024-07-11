// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 08-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
// ***********************************************************************
// <copyright file="ObservableCollectionExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ObservableCollectionExtensionsCollectionBenchmark : SmallCollectionBenchmark
{

	private ObservableCollection<Person<Address>> _personRefObservableCollection;

	[Benchmark(Description = nameof(ObservableCollectionExtensions.DoesNotHaveItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void DoesNotHaveItems()
	{
		var result = this._personRefObservableCollection.DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObservableCollectionExtensions.HasItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItems()
	{
		var result = this._personRefObservableCollection.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObservableCollectionExtensions.HasItems) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithCount()
	{
		var result = this._personRefObservableCollection.HasItems(5);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObservableCollectionExtensions.HasItems) + ": With Predicate")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithPredicate()
	{
		var result = this._personRefObservableCollection.HasItems(p => p.LastName.IsNotEmpty());

		this.Consume(result);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();
		this._personRefObservableCollection = new ObservableCollection<Person<Address>>(this.GetPersonRefCollection());

	}

}
