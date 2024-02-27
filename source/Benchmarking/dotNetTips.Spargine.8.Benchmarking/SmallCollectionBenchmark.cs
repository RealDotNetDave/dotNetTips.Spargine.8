// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 07-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
// ***********************************************************************
// <copyright file="SmallCollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class for conducting benchmark tests on small collections with count values set to 16, 32, 64, 128, 256, 512, 1024, and 2048.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Benchmark class for small collections.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
public class SmallCollectionBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="SmallCollectionBenchmark" /> class.
	/// </summary>
	public SmallCollectionBenchmark() : base(2048)
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this.MaxCount}: {nameof(SmallCollectionBenchmark)}.");
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}: {nameof(SmallCollectionBenchmark)} Before Setup");

		this.MaxCount = this.Count;
		base.Setup();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}: {nameof(SmallCollectionBenchmark)} After Setup");
	}

	/// <summary>
	/// Gets or sets the collection count.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(16, 32, 64, 128, 256, 512, 1024, 2048)]
	public int Count { get; set; }

}
