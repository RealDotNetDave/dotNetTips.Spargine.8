// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2024
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
using DotNetTips.Spargine.Core;
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
	/// Loads a specified number of <see cref="PersonRecord"/> objects from embedded resources.
	/// </summary>
	/// <param name="count">The number of <see cref="PersonRecord"/> objects to load. The value must be in the range of 1 to 10000.</param>
	/// <returns>An array of <see cref="PersonRecord"/> objects.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the count is not within the valid range.</exception>
	public static PersonRecord[] LoadPeopleRecordFromResources(int count)
	{
		count = count.ArgumentInRange(lower: 1, upper: _maxPeopleDataCount);
		var items = new List<PersonRecord>(count);

		using (var doc = JsonDocument.Parse(Properties.Resources.PeopleJson))
		{
			for (var itemCount = 0; itemCount < count; itemCount++)
			{
				items.Add(JsonSerializer.Deserialize(doc.RootElement[itemCount].GetRawText(), PersonJsonSerializerContext.Default.PersonRecord));
			}
		}

		return [.. items];
	}

	/// <summary>
	/// Loads a specified number of <see cref="Person{TAddress}"/> reference objects from embedded resources.
	/// </summary>
	/// <param name="count">The number of <see cref="Person{TAddress}"/> reference objects to load. The value must be in the range of 1 to 10000.</param>
	/// <returns>An array of <see cref="Person{TAddress}"/> reference objects.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the count is not within the valid range.</exception>
	public static Person<Address>[] LoadPeopleRefFromResources(int count)
	{
		count = count.ArgumentInRange(lower: 1, upper: _maxPeopleDataCount);
		var items = new List<Person<Address>>(count);

		using (var doc = JsonDocument.Parse(Properties.Resources.PeopleJson))
		{
			for (var itemCount = 0; itemCount < count; itemCount++)
			{
				items.Add(JsonSerializer.Deserialize(doc.RootElement[itemCount].GetRawText(), PersonJsonSerializerContext.Default.Person));
			}
		}

		return [.. items];
	}

	/// <summary>
	/// Loads a specified number of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects from embedded resources.
	/// </summary>
	/// <param name="count">The number of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects to load. The value must be in the range of 1 to 10000.</param>
	/// <returns>An array of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the count is not within the valid range.</exception>
	public static Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] LoadPeopleValFromResources(int count)
	{
		count = count.ArgumentInRange(lower: 1, upper: _maxPeopleDataCount);
		var items = new List<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>(count);

		using (var doc = JsonDocument.Parse(Properties.Resources.PeopleJson))
		{
			for (var itemCount = 0; itemCount < count; itemCount++)
			{
				items.Add(JsonSerializer.Deserialize(doc.RootElement[itemCount].GetRawText(), Tester.Models.ValueTypes.PersonJsonValSerializerContext.Default.Person));
			}
		}

		return [.. items];
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
