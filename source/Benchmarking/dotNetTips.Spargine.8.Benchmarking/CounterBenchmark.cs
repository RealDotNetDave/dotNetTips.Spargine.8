// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
// ***********************************************************************
// <copyright file="CounterBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Abstract class designed for benchmark tests that involve a counter.
// </summary>
// ***********************************************************************
using BenchmarkDotNet.Loggers;

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// CounterBenchmark base class.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
public abstract class CounterBenchmark : Benchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="CounterBenchmark" /> class.
	/// </summary>
	/// <param name="maxCount">The maximum count.</param>
	protected CounterBenchmark(int maxCount)
	{
		this.MaxCount = Math.Max(2, maxCount);

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={maxCount}: {nameof(CounterBenchmark)}.");

	}

	/// <summary>
	/// Gets the maximum count.
	/// </summary>
	/// <value>The maximum count.</value>

	protected int MaxCount { get; }

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this.MaxCount}: {nameof(CounterBenchmark)}.");
	}

}
