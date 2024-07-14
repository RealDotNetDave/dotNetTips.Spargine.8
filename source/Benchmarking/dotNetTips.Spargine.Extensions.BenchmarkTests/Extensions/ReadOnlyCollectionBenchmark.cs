// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-11-2024
// ***********************************************************************
// <copyright file="ReadOnlyCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
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
public class ReadOnlyCollectionBenchmark : SmallCollectionBenchmark
{

	private ReadOnlyCollection<Person<Address>> _personRefReadOnlyCollection;

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.DoesNotHaveItems))]
	public void DoesNotHaveItems()
	{
		this.Consume(this._personRefReadOnlyCollection.DoesNotHaveItems());
	}

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.GenerateHashCode))]
	public void GenerateHashCode()
	{
		this.Consume(this._personRefReadOnlyCollection.GenerateHashCode());
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefReadOnlyCollection = this.GetPersonRefArray().ToReadOnlyCollection();
	}

}
