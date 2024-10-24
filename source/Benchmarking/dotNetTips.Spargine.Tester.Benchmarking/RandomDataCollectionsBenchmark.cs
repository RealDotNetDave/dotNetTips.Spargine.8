// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 08-02-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2024
// ***********************************************************************
// <copyright file="RandomDataCollectionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

/// <summary>
/// Class RandomDataCollectionsBenchmark.
/// </summary>
public class RandomDataCollectionsBenchmark : LargeCollectionBenchmark
{
	private const CountryName DefaultCountryName = CountryName.UnitedStates;

	private Collection<Coordinate> _coordinateCollection;
	private Collection<PersonRecord> _personRecordCollection;
	private Collection<Models.RefTypes.Person<Models.RefTypes.Address>> _personRefCollection;
	private readonly Country DefaultCountry = Countries.GetCountry(CountryName.UnitedStates);

	[Benchmark(Description = nameof(Coordinate) + ":OrderBy()")]
	[BenchmarkCategory(Categories.New, Categories.ValueType)]
	public void CoordinateOrderByBenchmark()
	{
		var result = this._personRecordCollection.OrderBy(p => p.Id);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateAddressCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateAddressCollectionRef()
	{
		var result = RandomData.GenerateAddressCollection<Models.RefTypes.Address>(this.DefaultCountry);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateAddressRecordCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateAddressRecordCollection()
	{
		var result = RandomData.GenerateAddressRecordCollection(DefaultCountryName, this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCoordinateCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCoordinateCollection()
	{
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCreditCards))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCreditCards()
	{
		var result = RandomData.GenerateCreditCards(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonNames))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonNames()
	{
		var result = RandomData.GeneratePersonNames(this.Count);

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

		this._coordinateCollection = this.GetCoordinateValArray().ToCollection();
		this._personRecordCollection = this.GetPersonRecordCollection().ToCollection();
		this._personRefCollection = this.GetPersonRefCollection();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"PersonRefCollection: {this._personRefCollection.Count}");

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"PersonRecordCollection: {this._personRecordCollection.Count}");

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"FIRST PERSON: {this._personRefCollection.First().Email}");
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"LAST PERSON: {this._personRefCollection.Last().Email}");
	}

}
