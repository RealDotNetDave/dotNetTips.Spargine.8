// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-19-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="CollectionBenchmark.PersonRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Base class for tests that leverage collections, with added
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
/// Represents the base class for benchmarks that involve collections, specifically optimized for handling PersonRecord objects.
/// This class provides methods to preload PersonRecord collections to improve benchmark test speed and efficiency.
/// </summary>
public partial class CollectionBenchmark
{

	/// <summary>
	/// The person record reference array.
	/// </summary>
	private PersonRecord[] _personRecordArray;

	/// <summary>
	/// The person record list.
	/// </summary>
	private List<PersonRecord> _personRecordList;

	/// <summary>
	/// Loads the person record collections into memory. This includes both a list and an array of PersonRecord objects,
	/// populated to the maximum count specified for the benchmark. This method is called to prepare data for benchmark tests.
	/// </summary>
	protected void LoadPersonRecordCollections()
	{
		this._personRecordList = [.. RandomData.GeneratePersonRecordCollection(this.MaxCount)];
		this._personRecordArray = [.. this._personRecordList];

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Record List Count = {this._personRecordList.Count}: {nameof(CollectionBenchmark)}.");
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Record Array Count = {this._personRecordArray.Length}: {nameof(CollectionBenchmark)}.");
	}

	/// <summary>
	/// Gets a copy of the PersonRecord array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the PersonRecord array.</returns>
	public PersonRecord[] GetPersonRecordArray() => this._personRecordArray.Clone<PersonRecord[]>();

	/// <summary>
	/// Gets a copy of the PersonRecord list as a <see cref="Collection{T}"/>.
	/// Similar to <see cref="GetPersonRecordArray"/>, this method provides a fresh copy of the data for benchmark tests.
	/// </summary>
	/// <returns>A clone of the PersonRecord list as a Collection.</returns>
	[Obsolete("Use GetPersonRecordArray() instead. Will be removed at the end of 2024.")]
	public Collection<PersonRecord> GetPersonRecordCollection() => this._personRecordList.Clone<List<PersonRecord>>().ToCollection();

}
