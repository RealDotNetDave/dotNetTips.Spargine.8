// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-05-2024
// ***********************************************************************
// <copyright file="CollectionBenchmark.Person.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Base class for tests that leverage collections, with added
// functionality for preloading Person collections to improve
// benchmark test speed.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Partial class for Collections benchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
public partial class CollectionBenchmark
{

	/// <summary>
	/// The person record dictionary
	/// </summary>
	private Dictionary<string, PersonRecord> _personRecordDictionary;

	/// <summary>
	/// The person reference array
	/// </summary>
	private Person<Address>[] _personRefArray;

	/// <summary>
	/// The person reference dictionary
	/// </summary>
	private Dictionary<string, Person<Address>> _personRefDictionary;

	/// <summary>
	/// The person reference list
	/// </summary>
	private List<Person<Address>> _personRefList;

	/// <summary>
	/// The person value array
	/// </summary>
	private Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] _personValArray;

	/// <summary>
	/// The person value dictionary
	/// </summary>
	private Dictionary<string, Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>> _personValDictionary;

	/// <summary>
	/// The person value list
	/// </summary>
	private List<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>> _personValList;

	/// <summary>
	/// Loads the person reference array.
	/// </summary>
	protected void LoadPersonCollections()
	{
		this._personRecordArray = RandomData.GeneratePersonRecordCollection(this.MaxCount).ToArray();
		this._personRefArray = RandomData.GeneratePersonRefCollection<Address>(this.MaxCount).ToArray();
		this._personValArray = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(this.MaxCount).ToArray();
		this._personRecordList = this._personRecordArray.ToList();
		this._personRefList = this._personRefArray.ToList();
		this._personValList = this._personValArray.ToList();
		this._personRecordDictionary = this._personRecordArray.ToDictionary(p => p.Id);
		this._personRefDictionary = this._personRefArray.ToDictionary(p => p.Id);
		this._personValDictionary = this._personValArray.ToDictionary(p => p.Id);

		//Display collection counts
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Records Array Count={_personRecordArray.Length}");
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Ref Array Count={_personRefArray.Length}");
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Val Array Count={_personValArray.Length}");
	}

	/// <summary>
	/// Gets a <see cref="Dictionary{TKey, TValue}" /> for <see cref="PersonRecord" />.
	/// </summary>
	/// <returns>System.Collections.Generic.Dictionary&lt;string, DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord&gt;.</returns>
	public Dictionary<string, PersonRecord> GetPersonRecordDictionary() => this._personRecordDictionary.Clone<Dictionary<string, PersonRecord>>();

	/// <summary>
	/// Gets <see cref="Person{TAddress}" /> reference array.
	/// </summary>
	/// <returns>Person[].</returns>
	public Person<Address>[] GetPersonRefArray() => this._personRefArray.Clone<Person<Address>[]>();

	/// <summary>
	/// Gets the <see cref="Person{TAddress}" /> reference list as a <see cref="Collection{T}" />.
	/// </summary>
	/// <returns>Collection&lt;Person&lt;Address&gt;&gt;.</returns>
	public Collection<Person<Address>> GetPersonRefCollection() => this._personRefList.Clone<List<Person<Address>>>().ToCollection();

	/// <summary>
	/// Gets <see cref="Person{TAddress}" /> reference types as a <see cref="Dictionary{TKey, TValue}" />.
	/// </summary>
	/// <returns>Dictionary&lt;System.String, Person&lt;Address&gt;&gt;.</returns>
	public Dictionary<string, Person<Address>> GetPersonRefDictionary() => this._personRefDictionary.Clone<Dictionary<string, Person<Address>>>();

	/// <summary>
	/// Gets <see cref="Person{TAddress}" /> value types as an array.
	/// </summary>
	/// <returns>Tester.Models.ValueTypes.Person[].</returns>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] GetPersonValArray() => this._personValArray.Clone<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[]>();

	/// <summary>
	/// Retrieves <see cref="Person{TAddress}" />  value types as a <see cref="Collection{T}" />.
	/// </summary>
	/// <returns>Collection&lt;Tester.Models.ValueTypes.Person&lt;Tester.Models.ValueTypes.Address&gt;&gt;.</returns>
	public Collection<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>> GetPersonValCollection() => this._personValList.Clone<List<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>>().ToCollection();

	/// <summary>
	/// Gets the person reference dictionary.
	/// </summary>
	/// <returns>System.Collections.Generic.Dictionary&lt;string, DotNetTips.Spargine.Tester.Models.ValueTypes.Person&lt;DotNetTips.Spargine.Tester.Models.ValueTypes.Address&gt;[]&gt;.</returns>
	public Dictionary<string, Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>> GetPersonValDictionary() => this._personValDictionary.Clone<Dictionary<string, Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>>();

}
