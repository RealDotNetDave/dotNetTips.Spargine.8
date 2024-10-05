// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-11-2024
//
// Last Modified By : David McCarter
// Last Modified On : 07-14-2024
// ***********************************************************************
// <copyright file="ReadOnlySpanBenchmark.cs" company="McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ReadOnlySpanBenchmark : SmallCollectionBenchmark
{

	private Person<Address>[] _personRefArray;

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.PickRandom))]
	public void DoesNotHaveItems()
	{
		var collection = new ReadOnlySpan<Person<Address>>(this._personRefArray);

		var result = collection.PickRandom();

		Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefArray = GetPersonRefArray();
	}

}
