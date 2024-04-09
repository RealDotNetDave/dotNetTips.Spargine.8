// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 04-01-2024
//
// Last Modified By : David McCarter
// Last Modified On : 04-05-2024
// ***********************************************************************
// <copyright file="CollectionLoopingBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Class CollectionLoopingBenchmark.
/// Implements the <see cref="CollectionBenchmark" />
/// </summary>
/// <seealso cref="CollectionBenchmark" />
public class FastestLoopingBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="FastestLoopingBenchmark"/> class.
	/// </summary>
	public FastestLoopingBenchmark() : base(8192) => ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this.MaxCount}: {nameof(FastestLoopingBenchmark)}.");

	/// <summary>
	/// Gets or sets the collection count.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(32, 64, 128, 256, 512, 1024, 2048, 4096, 8192)]
	public int Count { get; set; }



}
