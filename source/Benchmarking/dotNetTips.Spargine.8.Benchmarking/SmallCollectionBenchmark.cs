// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 07-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-05-2025
// ***********************************************************************
// <copyright file="SmallCollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Class for conducting benchmark tests on small collections with count
// values set to 16, 32, 64, 128, 256, 512, 1,024, and 2,048.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Provides benchmark tests for small collections, with count values ranging from 16 to 2,048.
/// This class is designed to measure the performance of operations on collections of varying small sizes,
/// helping to identify the most efficient data structures and algorithms for use cases involving small datasets.
/// </summary>
[Information(Documentation = "https://bit.ly/BenchmarkLikeDotNetDave", Status = Status.Available)]
public class SmallCollectionBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="SmallCollectionBenchmark"/> class with a maximum count of 2,048.
	/// This constructor also logs the maximum count information using the <see cref="ConsoleLogger"/>.
	/// </summary>
	public SmallCollectionBenchmark() : base(2048) => LogInfo($"Max Count={this.MaxCount}: {nameof(SmallCollectionBenchmark)}.");

	/// <summary>
	/// Performs setup operations specific to SmallCollectionBenchmark. This includes logging the current count before and after the base setup is called,
	/// and adjusting the MaxCount property to match the current Count. This method is called automatically by the BenchmarkDotNet framework before each benchmark run.
	/// </summary>
	public override void Setup()
	{
		LogInfo($"Count={this.Count}: {nameof(SmallCollectionBenchmark)}");

		this.MaxCount = this.Count;
		base.Setup();
	}

	/// <summary>
	/// Gets or sets the collection count for the benchmark. This value determines the size of the collection to be used in the benchmark tests.
	/// Valid values are 16, 32, 64, 128, 256, 512, 1024, and 2048, allowing for a range of small collection sizes to be tested.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(16, 32, 64, 128, 256, 512, 1024, 2048)]
	public int Count { get; set; }

}
