// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
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

using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Partial class for Collections benchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
public partial class CollectionBenchmark : Benchmark
{

	/// <summary>
	/// The people record to insert
	/// </summary>
	private PersonRecord[] _peopleRecordToInsert;

	/// <summary>
	/// The people to insert
	/// </summary>
	private Person<Address>[] _peopleRefToInsert;

	/// <summary>
	/// The people value to insert
	/// </summary>
	private Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] _peopleValToInsert;

	/// <summary>
	/// Initializes a new instance of the <see cref="CollectionBenchmark" /> class.
	/// </summary>
	/// <param name="maxCount">The maximum count.</param>
	protected CollectionBenchmark(int maxCount) => this.MaxCount = Math.Max(2, maxCount);

	/// <summary>
	/// Gets a collection of <see cref="PersonRecord" /> objects for insertion into collections.
	/// </summary>
	/// <returns>PersonRecord[].</returns>
	protected virtual PersonRecord[] GetPeopleRecordToInsert() => this._peopleRecordToInsert;

	/// <summary>
	/// Gets a collection of <see cref="Person{TAddress}" /> reference objects for insertion into collections.
	/// </summary>
	/// <returns>Person&lt;Address&gt;[].</returns>
	protected virtual Person<Address>[] GetPeopleRefToInsert() => this._peopleRefToInsert;

	/// <summary>
	/// Gets a collection of <see cref="Person{TAddress}" /> value objects for insertion into collections.
	/// </summary>
	/// <returns>Tester.Models.ValueTypes.Person[].</returns>
	protected virtual Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] GetPeopleValToInsert() => this._peopleValToInsert;

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.MaxCount}: {nameof(CollectionBenchmark)}.");

		//Load collections
		this.LoadCoordinateCollections();
		this.LoadPersonRecordCollections();
		this.LoadPersonCollections();

		//Load people objects
		this._peopleRefToInsert = new List<Person<Address>>(this.GetPersonRefArray().Shuffle(Math.Max(2, this.MaxCount / 2))).ToArray();
		this._peopleValToInsert = new List<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>(this.GetPersonValArray().Shuffle(Math.Max(2, this.MaxCount / 2))).ToArray();
		this._peopleRecordToInsert = new List<PersonRecord>(this.GetPersonRecordArray().Shuffle(Math.Max(2, this.MaxCount / 2))).ToArray();
	}

	/// <summary>
	/// Retrieves the maximum count.
	/// </summary>
	/// <value>The maximum count.</value>
	public int MaxCount { get; internal set; }

}
