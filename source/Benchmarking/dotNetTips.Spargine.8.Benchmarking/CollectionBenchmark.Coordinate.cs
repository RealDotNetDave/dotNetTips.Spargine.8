// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-03-2024
// ***********************************************************************
// <copyright file="CollectionBenchmark.Coordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Base class for tests that leverage collections, with added functionality
// for preloading Coordinate collections to improve benchmark test speed.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

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
	/// The coordinate array
	/// </summary>
	private Coordinate[] _coordinateArray;

	/// <summary>
	/// The coordinate list
	/// </summary>
	private List<Coordinate> _coordinateList;

	/// <summary>
	/// Loads the coordinate array.
	/// </summary>
	protected void LoadCoordinateCollections()
	{
		this._coordinateArray = RandomData.GenerateCoordinateCollection<Coordinate>(this.MaxCount).ToArray();
		this._coordinateList = this._coordinateArray.ToList();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Coordinate Array Count = {this._coordinateArray.Length}: {nameof(CollectionBenchmark)}.");
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Coordinate List Count = {this._coordinateList.Count}: {nameof(CollectionBenchmark)}.");
	}

	/// <summary>
	/// Gets <see cref="Coordinate" /> array.
	/// </summary>
	/// <returns>Tester.Models.ValueTypes.Coordinate[].</returns>
	public Coordinate[] GetCoordinateValArray() => this._coordinateArray.Clone<Coordinate[]>();

	/// <summary>
	/// Gets the coordinate list.
	/// </summary>
	/// <returns>Collection&lt;Tester.Models.ValueTypes.Coordinate&gt;.</returns>
	public Collection<Coordinate> GetCoordinateValCollection() => this._coordinateArray.Clone<Coordinate[]>().ToCollection();

}
