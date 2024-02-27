// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
// ***********************************************************************
// <copyright file="CollectionBenchmark.Coordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
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
		this._coordinateList = RandomData.GenerateCoordinateCollection<Coordinate>(this.MaxCount).ToList();
		this._coordinateArray = RandomData.GenerateCoordinateCollection<Coordinate>(this.MaxCount).ToArray();
	}

	/// <summary>
	/// Gets <see cref="Tester.Models.ValueTypes.Coordinate" /> array.
	/// </summary>
	/// <returns>Tester.Models.ValueTypes.Coordinate[].</returns>
	public Coordinate[] GetCoordinateValArray()
	{
		return this._coordinateArray.Clone<Coordinate[]>();
	}

	/// <summary>
	/// Gets the coordinate list.
	/// </summary>
	/// <returns>Collection&lt;Tester.Models.ValueTypes.Coordinate&gt;.</returns>
	public Collection<Coordinate> GetCoordinateValCollection()
	{
		return this._coordinateArray.Clone<Coordinate[]>().ToCollection();
	}

}
