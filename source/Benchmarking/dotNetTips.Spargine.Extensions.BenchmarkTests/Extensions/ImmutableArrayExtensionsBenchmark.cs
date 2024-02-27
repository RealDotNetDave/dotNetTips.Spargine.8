// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-31-2023
// ***********************************************************************
// <copyright file="ImmutableArrayExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class ImmutableArrayExtensionsBenchmark.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class ImmutableArrayExtensionsBenchmark : SmallCollectionBenchmark
{

	private ImmutableArray<Person<Address>> _personRefImmutableArray;

	[Benchmark(Description = nameof(ImmutableArrayExtensions.HasItems))]
	public void ImmutableArrayHasItems()
	{
		var result = this._personRefImmutableArray.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ImmutableArrayExtensions.HasItems) + ": With Count")]
	public void ImmutableArrayHasItemsWithCount()
	{
		var result = this._personRefImmutableArray.HasItems(this.Count);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefImmutableArray = this.GetPersonRefArray().ToImmutableArray();
	}

}
