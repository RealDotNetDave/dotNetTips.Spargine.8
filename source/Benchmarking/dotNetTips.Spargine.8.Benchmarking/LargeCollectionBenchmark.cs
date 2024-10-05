// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="LargeCollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Class for performing benchmark tests on large collections with count
// values set to 64, 128, 256, 512, 1,024, 2,048, 4,096, and 8,192.
// </summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Provides benchmark tests for large collections, with count values ranging from 64 to 8,192.
/// This class is designed to measure the performance of operations on collections of varying large sizes,
/// helping to identify the most efficient data structures and algorithms for use cases involving large datasets.
/// </summary>
public class LargeCollectionBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="LargeCollectionBenchmark"/> class with a maximum count of 8,192.
	/// This constructor also logs the maximum count information using the <see cref="ConsoleLogger"/>.
	/// </summary>
	public LargeCollectionBenchmark() : base(8192)
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this.MaxCount}: {nameof(LargeCollectionBenchmark)}.");

	}

	/// <summary>
	/// Performs setup operations specific to LargeCollectionBenchmark. This includes logging the current count before and after the base setup is called,
	/// and adjusting the MaxCount property to match the current Count. This method is called automatically by the BenchmarkDotNet framework before each benchmark run.
	/// </summary>
	public override void Setup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}: {nameof(LargeCollectionBenchmark)}");

		this.MaxCount = this.Count;
		base.Setup();
	}

	/// <summary>
	/// Gets or sets the collection count for the benchmark. This value determines the size of the collection to be used in the benchmark tests.
	/// Valid values are 64, 128, 256, 512, 1,024, 2,048, 4,096, and 8,192, allowing for a range of large collection sizes to be tested.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(64, 128, 256, 512, 1024, 2048, 4096, 8192)]
	public int Count { get; set; }

}
