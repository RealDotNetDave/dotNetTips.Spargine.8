// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 02-27-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
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
/// Class TinyCollectionBenchmark.
/// Implements the <see cref="CollectionBenchmark" />
/// </summary>
/// <seealso cref="CollectionBenchmark" />
public class TinyCollectionBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="LargeCollectionBenchmark" /> class.
	/// </summary>
	public TinyCollectionBenchmark() : base(256) => ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this.MaxCount}: {nameof(TinyCollectionBenchmark)}.");

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}: {nameof(TinyCollectionBenchmark)} Before Setup");

		this.MaxCount = this.Count;
		base.Setup();

		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}: {nameof(TinyCollectionBenchmark)} After Setup");
	}

	/// <summary>
	/// Gets or sets the collection count.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(2, 4, 8, 16, 32, 64, 128, 256)]
	public int Count { get; set; }

}
