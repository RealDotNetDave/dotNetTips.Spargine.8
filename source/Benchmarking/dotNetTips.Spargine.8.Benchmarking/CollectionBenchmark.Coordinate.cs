// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
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
/// Represents the base class for benchmarks that involve collections, specifically optimized for handling Coordinate objects.
/// This partial class provides methods to preload Coordinate collections to improve benchmark test speed and efficiency.
/// </summary>
public partial class CollectionBenchmark
{

	/// <summary>
	/// The coordinate array.
	/// </summary>
	private Coordinate[] _coordinateArray;

	/// <summary>
	/// The coordinate list.
	/// </summary>
	private List<Coordinate> _coordinateList;

	/// <summary>
	/// Loads the coordinate collections into memory. This includes both a list and an array of Coordinate objects,
	/// populated to the maximum count specified for the benchmark. This method is called to prepare data for benchmark tests.
	/// </summary>
	protected void LoadCoordinateCollections()
	{
		this._coordinateArray = [.. RandomData.GenerateCoordinateCollection<Coordinate>(this.MaxCount)];
		this._coordinateList = [.. this._coordinateArray];

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Coordinate Array Count = {this._coordinateArray.Length}: {nameof(CollectionBenchmark)}.");
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Coordinate List Count = {this._coordinateList.Count}: {nameof(CollectionBenchmark)}.");
	}

	/// <summary>
	/// Gets a copy of the Coordinate array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the Coordinate array.</returns>
	public Coordinate[] GetCoordinateValArray() => this._coordinateArray.Clone<Coordinate[]>();

	/// <summary>
	/// Gets a copy of the Coordinate list as a <see cref="Collection{T}"/>.
	/// Similar to <see cref="GetCoordinateValArray"/>, this method provides a fresh copy of the data for benchmark tests.
	/// </summary>
	/// <returns>A clone of the Coordinate list as a Collection.</returns>
	public Collection<Coordinate> GetCoordinateValCollection() => this._coordinateArray.Clone<Coordinate[]>().ToCollection();

}
