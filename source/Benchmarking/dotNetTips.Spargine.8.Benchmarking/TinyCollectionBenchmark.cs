// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 02-27-2024
//
// Last Modified By : David McCarter
// Last Modified On : 07-14-2024
// ***********************************************************************
// <copyright file="TinyCollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Class for performing benchmark tests on very small collections with
// count values set to 2, 4, 8, 16, 32, 64, 128, and 256.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;


/// <summary>
/// Provides benchmark tests for very small collections, with count values ranging from 2 to 256.
/// This class is designed to measure the performance of operations on collections of varying small sizes,
/// helping to identify the most efficient data structures and algorithms for use cases involving small datasets.
/// </summary>
public class TinyCollectionBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="TinyCollectionBenchmark"/> class with a maximum count of 256.
	/// This constructor also logs the maximum count information using the <see cref="ConsoleLogger"/>.
	/// </summary>
	public TinyCollectionBenchmark() : base(256) => ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this.MaxCount}: {nameof(TinyCollectionBenchmark)}.");

	/// <summary>
	/// Performs setup operations specific to TinyCollectionBenchmark. This includes logging the current count before and after the base setup is called,
	/// and adjusting the MaxCount property to match the current Count. This method is called automatically by the BenchmarkDotNet framework before each benchmark run.
	/// </summary>
	public override void Setup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}: {nameof(TinyCollectionBenchmark)}");

		this.MaxCount = this.Count;
		base.Setup();
	}

	/// <summary>
	/// Gets or sets the collection count for the benchmark. This value determines the size of the collection to be used in the benchmark tests.
	/// Valid values are 2, 4, 8, 16, 32, 64, 128, and 256, allowing for a range of small collection sizes to be tested.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(2, 4, 8, 16, 32, 64, 128, 256)]
	public int Count { get; set; }

}
