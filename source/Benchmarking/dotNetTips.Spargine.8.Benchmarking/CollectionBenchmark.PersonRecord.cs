// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-19-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
// ***********************************************************************
// <copyright file="CollectionBenchmark.PersonRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Base class for tests that leverage collections, with added
// functionality for preloading PersonRecord collections to improve
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
	/// The person record reference array
	/// </summary>
	private PersonRecord[] _personRecordArray;

	/// <summary>
	/// The person record list
	/// </summary>
	private List<PersonRecord> _personRecordList;

	/// <summary>
	/// Loads the person record array.
	/// </summary>
	protected void LoadPersonRecordCollections()
	{
		this._personRecordList = RandomData.GeneratePersonRecordCollection(this.MaxCount).ToList();
		this._personRecordArray = RandomData.GeneratePersonRecordCollection(this.MaxCount).ToArray();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Record List Count = {_personRecordList.Count}: {nameof(CollectionBenchmark)}.");
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Record Array Count = {_personRecordArray.Length}: {nameof(CollectionBenchmark)}.");
	}

	/// <summary>
	/// Gets <see cref="PersonRecord" /> as an array.
	/// </summary>
	/// <returns>PersonRecord[].</returns>
	public PersonRecord[] GetPersonRecordArray()
	{
		return this._personRecordArray.Clone<PersonRecord[]>();
	}

	/// <summary>
	/// Gets <see cref="PersonRecord" /> as an <see cref="Collection{T}" />.
	/// </summary>
	/// <returns>Collection&lt;PersonRecord&gt;.</returns>
	public Collection<PersonRecord> GetPersonRecordCollection()
	{
		return this._personRecordList.Clone<List<PersonRecord>>().ToCollection();
	}

}
