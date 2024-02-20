// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2024
// ***********************************************************************
// <copyright file="CollectionsBenchmark.Coordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;

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
	/// The coordinate array
	/// </summary>
	private Tester.Models.ValueTypes.Coordinate[] _coordinateArray;

	/// <summary>
	/// The coordinate list
	/// </summary>
	private List<Tester.Models.ValueTypes.Coordinate> _coordinateList;

	/// <summary>
	/// Loads the coordinate array.
	/// </summary>
	protected void LoadCoordinateCollections()
	{
		this._coordinateList = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(this.MaxCount).ToList();
		this._coordinateArray = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(this.MaxCount).ToArray();
	}

	/// <summary>
	/// Gets <see cref="Tester.Models.ValueTypes.Coordinate" /> array.
	/// </summary>
	/// <returns>Tester.Models.ValueTypes.Coordinate[].</returns>
	public Tester.Models.ValueTypes.Coordinate[] GetCoordinateValArray()
	{
		return this._coordinateArray.Clone<Tester.Models.ValueTypes.Coordinate[]>();
	}

	/// <summary>
	/// Gets the coordinate list.
	/// </summary>
	/// <returns>Collection&lt;Tester.Models.ValueTypes.Coordinate&gt;.</returns>
	public Collection<Tester.Models.ValueTypes.Coordinate> GetCoordinateValCollection()
	{
		return this._coordinateArray.Clone<Tester.Models.ValueTypes.Coordinate[]>().ToCollection();
	}

}
