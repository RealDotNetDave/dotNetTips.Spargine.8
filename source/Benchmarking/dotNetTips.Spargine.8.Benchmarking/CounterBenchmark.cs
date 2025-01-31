// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-31-2025
// ***********************************************************************
// <copyright file="CounterBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Abstract class designed for benchmark tests that involve a counter.</summary>
// ***********************************************************************


namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Provides a base class for benchmark tests that involve a counter. This abstract class is designed to be inherited by benchmarks that require counting operations, ensuring a consistent setup and logging mechanism across different counting benchmarks.
/// </summary>
public abstract class CounterBenchmark : Benchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="CounterBenchmark"/> class.
	/// </summary>
	/// <param name="maxCount">The maximum count for the benchmark, ensuring that the count does not fall below 2.</param>
	protected CounterBenchmark(int maxCount)
	{
		this.MaxCount = Math.Max(2, maxCount);
		LogInfo($"Max Count={maxCount}: {nameof(CounterBenchmark)}.");
	}

	/// <summary>
	/// Gets the maximum count for the benchmark. This value is used to determine the upper limit of counting operations in derived benchmark classes.
	/// </summary>
	/// <value>The maximum count.</value>
	protected int MaxCount { get; }

	/// <summary>
	/// Performs setup operations for the counter benchmark. This method is called automatically by the BenchmarkDotNet framework before each benchmark run. It ensures that the base setup is called and logs the maximum count.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		LogInfo($"Max Count={this.MaxCount}: {nameof(CounterBenchmark)}.");
	}

}
