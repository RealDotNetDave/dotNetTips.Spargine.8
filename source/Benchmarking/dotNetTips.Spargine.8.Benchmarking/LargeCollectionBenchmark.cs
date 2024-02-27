// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
// ***********************************************************************
// <copyright file="LargeCollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class for performing benchmark tests on large collections with count values set to 64, 128, 256, 512, 1024, 2048, 4096, and 8192.</summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Benchmark class for large collections.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
public class LargeCollectionBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="LargeCollectionBenchmark" /> class.
	/// </summary>
	public LargeCollectionBenchmark() : base(8192)
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this.MaxCount}: {nameof(LargeCollectionBenchmark)}.");
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}: {nameof(LargeCollectionBenchmark)} Before Setup");

		this.MaxCount = this.Count;
		base.Setup();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}: {nameof(LargeCollectionBenchmark)} After Setup");
	}

	/// <summary>
	/// Gets or sets the collection count.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(64, 128, 256, 512, 1024, 2048, 4096, 8192)]
	public int Count { get; set; }

}
