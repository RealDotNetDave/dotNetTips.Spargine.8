// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
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
	/// The person value list
	/// </summary>
	private List<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>> _personValList;

	/// <summary>
	/// Loads the person reference array.
	/// </summary>
	protected void LoadPersonCollections()
	{
		this._personRefArray = RandomData.GeneratePersonRefCollection<Address>(this.MaxCount).ToArray();
		this._personRefDictionary = RandomData.GeneratePersonRefCollection<Address>(this.MaxCount).ToDictionary(p => p.Id);
		this._personRefList = RandomData.GeneratePersonRefCollection<Address>(this.MaxCount).ToList();
		this._personValArray = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(this.MaxCount).ToArray();
		this._personValList = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Address>(this.MaxCount).ToList();
	}

	/// <summary>
	/// Gets <see cref="Person{TAddress}" /> reference array.
	/// </summary>
	/// <returns>Person[].</returns>
	public Person<Address>[] GetPersonRefArray()
	{
		return this._personRefArray.Clone<Person<Address>[]>();
	}

	/// <summary>
	/// Gets the <see cref="Person{TAddress}" /> reference list as a <see cref="Collection{T}" />.
	/// </summary>
	/// <returns>Collection&lt;Person&lt;Address&gt;&gt;.</returns>
	public Collection<Person<Address>> GetPersonRefCollection()
	{
		return this._personRefList.Clone<List<Person<Address>>>().ToCollection();
	}

	/// <summary>
	/// Gets <see cref="Person{TAddress}" /> reference types as a <see cref="Dictionary{TKey, TValue}" />.
	/// </summary>
	/// <returns>Dictionary&lt;System.String, Person&lt;Address&gt;&gt;.</returns>
	public Dictionary<string, Person<Address>> GetPersonRefDictionary()
	{
		return this._personRefDictionary.Clone<Dictionary<string, Person<Address>>>();
	}

	/// <summary>
	/// Gets <see cref="Person{TAddress}" /> value types as an array.
	/// </summary>
	/// <returns>Tester.Models.ValueTypes.Person[].</returns>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] GetPersonValArray()
	{
		return this._personValArray.Clone<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[]>();
	}

	/// <summary>
	/// Retrieves <see cref="Person{TAddress}" />  value types as a <see cref="Collection{T}" />.
	/// </summary>
	/// <returns>Collection&lt;Tester.Models.ValueTypes.Person&lt;Tester.Models.ValueTypes.Address&gt;&gt;.</returns>
	public Collection<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>> GetPersonValCollection()
	{
		return this._personValList.Clone<List<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>>().ToCollection();
	}

}
