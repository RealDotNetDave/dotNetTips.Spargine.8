// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="CollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Base class for tests utilizing collections, with additional
// functionality to preload collections for enhanced benchmark test
// speed.
// </summary>
// ***********************************************************************

using System.Text.Json;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Represents the base class for benchmarks that involve collections, specifically optimized for handling PersonRecord objects.
/// This class provides methods to preload PersonRecord collections to improve benchmark test speed and efficiency.
/// </summary>
public partial class CollectionBenchmark : Benchmark
{

	/// <summary>
	/// The people record to insert.
	/// </summary>
	private PersonRecord[] _peopleRecordToInsert;

	/// <summary>
	/// The people to insert as reference types.
	/// </summary>
	private Person<Address>[] _peopleRefToInsert;

	/// <summary>
	/// The people to insert as value types.
	/// </summary>
	private Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] _peopleValToInsert;

	/// <summary>
	/// Initializes a new instance of the <see cref="CollectionBenchmark"/> class.
	/// </summary>
	/// <param name="maxCount">The maximum count for the collections used in the benchmark.</param>
	protected CollectionBenchmark(int maxCount) => this.MaxCount = Math.Max(2, maxCount);

	/// <summary>
	/// Gets a collection of <see cref="PersonRecord"/> objects for insertion into collections.
	/// </summary>
	/// <returns>An array of <see cref="PersonRecord"/>.</returns>
	protected virtual PersonRecord[] GetPersonRecordCollectionToInsert() => this._peopleRecordToInsert;

	/// <summary>
	/// Gets a collection of <see cref="Person{TAddress}"/> reference objects for insertion into collections.
	/// </summary>
	/// <returns>An array of <see cref="Person{TAddress}"/>.</returns>
	protected virtual Person<Address>[] GetPersonRefCollectionToInsert() => this._peopleRefToInsert;

	/// <summary>
	/// Gets a collection of <see cref="Tester.Models.ValueTypes.Person{TAddress}"/> value objects for insertion into collections.
	/// </summary>
	/// <returns>An array of <see cref="Tester.Models.ValueTypes.Person{TAddress}"/>.</returns>
	protected virtual Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] GetPersonValCollectionToInsert() => this._peopleValToInsert;

	/// <summary>
	/// Loads the people reference from resources.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="count">The count.</param>
	/// <returns>T[].</returns>
	public static T[] LoadPeopleFromResources<T>(int count)
	{
		var people = JsonSerializer.Deserialize(Properties.Resources.PeopleJson, PersonJsonSerializerContext.Default.PersonList).Take(count).ToList();
	}

	/// <summary>
	/// Setups the benchmark instance. This method is called before the benchmark runs and is responsible for initializing the collections and loading the data.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.MaxCount}: {nameof(CollectionBenchmark)}.");

		// Load collections
		this.LoadCoordinateCollections();
		this.LoadPersonRecordCollections();
		this.LoadPersonCollections();

		// Load people objects
		this._peopleRefToInsert = new List<Person<Address>>(this.GetPersonRefArray().Shuffle(Math.Max(2, this.MaxCount / 2))).ToArray();
		this._peopleValToInsert = new List<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>(this.GetPersonValArray().Shuffle(Math.Max(2, this.MaxCount / 2))).ToArray();
		this._peopleRecordToInsert = new List<PersonRecord>(this.GetPersonRecordArray().Shuffle(Math.Max(2, this.MaxCount / 2))).ToArray();
	}

	/// <summary>
	/// Gets or sets the maximum count for the collections used in the benchmark.
	/// </summary>
	/// <value>The maximum count.</value>
	public int MaxCount { get; internal set; }

}
