// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2024
// ***********************************************************************
// <copyright file="CollectionsBenchmark.Person.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Partial class for Collections benchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
public partial class CollectionsBenchmark
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
	/// Gets <see cref="Person{TAddress}" /> array.
	/// </summary>
	/// <returns>Person[].</returns>
	public Person<Address>[] GetPersonRefArray()
	{
		return this._personRefArray.Clone<Person<Address>[]>();
	}

	/// <summary>
	/// Gets the person reference list.
	/// </summary>
	/// <returns>Collection&lt;Person&lt;Address&gt;&gt;.</returns>
	public Collection<Person<Address>> GetPersonRefCollection()
	{
		return this._personRefList.Clone<List<Person<Address>>>().ToCollection();
	}

	/// <summary>
	/// Gets <see cref="Person{TAddress}" /> array.
	/// </summary>
	/// <returns>Dictionary&lt;System.String, Person&lt;Address&gt;&gt;.</returns>
	public Dictionary<string, Person<Address>> GetPersonRefDictionary()
	{
		return this._personRefDictionary.Clone<Dictionary<string, Person<Address>>>();
	}

	/// <summary>
	/// Gets <see cref="Person{TAddress}" /> array.
	/// </summary>
	/// <returns>Tester.Models.ValueTypes.Person[].</returns>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[] GetPersonValArray()
	{
		return this._personValArray.Clone<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>[]>();
	}

	/// <summary>
	/// Gets the person value list.
	/// </summary>
	/// <returns>Collection&lt;Tester.Models.ValueTypes.Person&lt;Tester.Models.ValueTypes.Address&gt;&gt;.</returns>
	public Collection<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>> GetPersonValCollection()
	{
		return this._personValList.Clone<List<Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>>>().ToCollection();
	}

}