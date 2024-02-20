// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 08-02-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2024
// ***********************************************************************
// <copyright file="RandomDataCollectionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

/// <summary>
/// Class RandomDataCollectionsBenchmark.
/// </summary>
public class RandomDataCollectionsBenchmark : LargeCollectionsBenchmark
{

	private const CountryName DefaultCountry = CountryName.UnitedStates;

	private Collection<Coordinate> _coordinateProperCollection;
	private Collection<PersonRecord> _personRecordCollection;
	private Collection<Models.RefTypes.Person<Models.RefTypes.Address>> _personRefCollection;

	[Benchmark(Description = nameof(Coordinate) + ":OrderBy()")]
	[BenchmarkCategory(Categories.New, Categories.ValueType)]
	public void CoordinateProperOrderByBenchmark()
	{
		var result = this._personRecordCollection.OrderBy(p => p.Id);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateAddressRecordCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateAddressRecordCollection()
	{
		var result = RandomData.GenerateAddressRecordCollection(DefaultCountry, this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCoordinateCollection) + ": Coordinate")]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCoordinateCollection()
	{
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCoordinateCollection) + ": CoordinateProper")]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCoordinateProperCollection()
	{
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRefCollection) + ": PersonProper")]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonProperRefCollection()
	{
		var result = RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRecordCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonRecordCollection()
	{
		var result = RandomData.GeneratePersonRecordCollection(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRefCollection) + ": Person")]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonRefCollection()
	{
		var result = RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonValCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonValCollection()
	{
		var result = RandomData.GeneratePersonValCollection<Models.ValueTypes.Address>(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = "Person" + ":OrderBy()")]
	[BenchmarkCategory(Categories.New)]
	public void PersonOrderByBenchmark()
	{
		var result = this._personRefCollection.OrderBy(p => p.Id);

		this.Consume(result);
	}

	[Benchmark(Description = "Person" + ":OrderBy()")]
	[BenchmarkCategory(Categories.New)]
	public void PersonProperOrderByBenchmark()
	{
		var result = this._personRefCollection.OrderBy(p => p.Id);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(PersonRecord) + ":OrderBy()")]
	[BenchmarkCategory(Categories.New)]
	public void PersonValOrderByBenchmark()
	{
		var result = this._personRecordCollection.OrderBy(p => p.Id);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._coordinateProperCollection = RandomData.GenerateCoordinateCollection<Coordinate>(this.Count).ToCollection();
		this._personRecordCollection = RandomData.GeneratePersonRecordCollection(this.Count).ToCollection();
		this._personRefCollection = RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(this.Count).ToCollection();

	}

}
