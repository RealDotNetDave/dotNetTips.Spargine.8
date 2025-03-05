// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-31-2025
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

using DotNetTips.Spargine.Benchmarking.Properties;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Represents the base class for benchmarks that involve collections, specifically optimized for handling PersonRecord objects.
/// This class provides methods to preload PersonRecord collections to improve benchmark test speed and efficiency.
/// </summary>
[Information(Documentation = "https://bit.ly/BenchmarkLikeDotNetDave", Status = Status.Available)]
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
	internal static PersonRecord[] LoadPeopleRecordFromResources(int count) => JsonSerialization.LoadCollectionFromJson<PersonRecord>(Resources.PeopleJson, count, PersonJsonSerializerContext.Default.PersonRecord);

	/// <summary>
	/// Loads a specified number of <see cref="Person{TAddress}"/> reference objects from embedded resources.
	/// </summary>
	/// <param name="count">The number of <see cref="Person{TAddress}"/> reference objects to load. The value must be in the range of 1 to 10000.</param>
	/// <returns>An array of <see cref="Person{TAddress}"/> reference objects.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the count is not within the valid range.</exception>
	internal static Person<Address>[] LoadPeopleRefFromResources(int count) => JsonSerialization.LoadCollectionFromJson<Person<Address>>(Resources.PeopleJson, count, PersonJsonSerializerContext.Default.Person);

	/// <summary>
	/// Loads a specified number of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects from embedded resources.
	/// </summary>
	/// <param name="count">The number of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects to load. The value must be in the range of 1 to 10000.</param>
	/// <returns>An array of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the count is not within the valid range.</exception>
	internal static Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] LoadPeopleValFromResources(int count) => JsonSerialization.LoadCollectionFromJson<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>(Resources.PeopleJson, count, Tester.Models.ValueTypes.PersonJsonValSerializerContext.Default.Person);

	/// <summary>
	/// Setups the benchmark instance. This method is called before the benchmark runs and is responsible for initializing the collections and loading the data.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		LogInfo($"Collection Count={this.MaxCount}: {nameof(CollectionBenchmark)}.");

		// Load collections
		this.LoadCoordinateCollections();
		this.LoadPersonRecordCollections();
		this.LoadPersonCollections();

		// Setup Lookups
		var halfCount = this.MaxCount / 2;

		this.PersonEmailHalf = this.GetPersonRefArray()[halfCount].Phone;
		this.PersonEmailLast = this.GetPersonRefArray().Last().Phone;
		this.PersonFirstNameHalf = this.GetPersonRefArray()[halfCount].FirstName;
		this.PersonFirstNameLast = this.GetPersonRefArray().Last().FirstName;
		this.PersonLastNameHalf = this.GetPersonRefArray()[halfCount].LastName;
		this.PersonLastNameLast = this.GetPersonRefArray().Last().LastName;
		this.PersonRecordLookupHalf = this.GetPersonRecordArray()[halfCount];
		this.PersonRecordLookupLast = this.GetPersonRecordArray().Last();
		this.PersonRefLookupHalf = this.GetPersonRefArray()[halfCount];
		this.PersonRefLookupLast = this.GetPersonRefArray().Last();
		this.PersonValLookupHalf = this.GetPersonValArray()[halfCount];
		this.PersonValLookupLast = this.GetPersonValArray().Last();

		// Load people objects
		this._peopleRefToInsert = [.. RandomData.GeneratePersonRefCollection<Address>(halfCount)];
		this._peopleValToInsert = [.. RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(halfCount)];
		this._peopleRecordToInsert = [.. RandomData.GeneratePersonRecordCollection(halfCount)];
	}

	/// <summary>
	/// Gets or sets the maximum count for the collections used in the benchmark.
	/// </summary>
	/// <value>The maximum count.</value>
	public int MaxCount { get; internal set; }

	/// <summary>
	/// Gets the email address of a person in the middle of the collection.
	/// </summary>
	public string PersonEmailHalf { get; private set; }

	/// <summary>
	/// Gets the email address of the last person in the collection.
	/// </summary>
	public string PersonEmailLast { get; private set; }

	/// <summary>
	/// Gets the first name of a person in the middle of the collection.
	/// </summary>
	public string PersonFirstNameHalf { get; private set; }

	/// <summary>
	/// Gets the first name of the last person in the collection.
	/// </summary>
	public string PersonFirstNameLast { get; private set; }

	/// <summary>
	/// Gets the last name of a person in the middle of the collection.
	/// </summary>
	public string PersonLastNameHalf { get; private set; }

	/// <summary>
	/// Gets the last name of the last person in the collection.
	/// </summary>
	public string PersonLastNameLast { get; private set; }

	/// <summary>
	/// Gets the person record for lookup from the middle of the collection.
	/// </summary>
	public PersonRecord PersonRecordLookupHalf { get; private set; }

	/// <summary>
	/// Gets the person record for lookup of the last item in the collection.
	/// </summary>
	public PersonRecord PersonRecordLookupLast { get; private set; }

	/// <summary>
	/// Gets the reference type person for lookup from the middle of the collection.
	/// </summary>
	public Person<Address> PersonRefLookupHalf { get; private set; }

	/// <summary>
	/// Gets the reference type person for lookup of the last item in the collection.
	/// </summary>
	public Person<Address> PersonRefLookupLast { get; private set; }

	/// <summary>
	/// Gets the value type person for lookup from the middle of the collection.
	/// </summary>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address> PersonValLookupHalf { get; private set; }

	/// <summary>
	/// Gets the value type person for lookup of the last item in the collection.
	/// </summary>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address> PersonValLookupLast { get; private set; }
}
