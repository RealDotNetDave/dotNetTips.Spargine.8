// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-01-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-31-2025
// ***********************************************************************
// <copyright file="FastestLoopingBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Benchmarks various looping constructs to determine the fastest method for iterating over collections.
/// This class inherits from <see cref="CollectionBenchmark"/> to utilize common setup and benchmarking functionality for collections.
/// </summary>
public class FastestLoopingBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="FastestLoopingBenchmark"/> class with a predefined maximum count.
	/// This constructor logs the maximum count to the console for informational purposes.
	/// </summary>
	public FastestLoopingBenchmark() : base(8192) => LogInfo($"Max Count={this.MaxCount}: {nameof(FastestLoopingBenchmark)}.");

	/// <summary>
	/// Gets or sets the collection count for the benchmark. This value determines the size of the collection to be used in the benchmark tests.
	/// The collection sizes range from 32 to 8,192, allowing for a comprehensive analysis of looping performance across different collection sizes.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(32, 64, 128, 256, 512, 1024, 2048, 4096, 8192)]
	public int Count { get; set; }

}
