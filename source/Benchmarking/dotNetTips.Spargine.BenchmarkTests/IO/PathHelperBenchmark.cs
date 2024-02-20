// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : David McCarter
// Created          : 01-12-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="PathHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using System;
using System.IO;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.BenchmarkTests.IO;

[BenchmarkCategory(Categories.IO)]
public class PathHelperBenchmark : Benchmark
{
	[Benchmark(Description = nameof(PathHelper.EnsureTrailingSlash))]
	[BenchmarkCategory(Categories.New)]
	public void EnsureTrailingSlash()
	{
		var result = PathHelper.EnsureTrailingSlash(Environment.ProcessPath);

		base.Consume(result);
	}

	[Benchmark(Description = nameof(PathHelper.HasInvalidFilterChars))]
	[BenchmarkCategory(Categories.New)]
	public void HasInvalidFilterChars()
	{
		var result = PathHelper.HasInvalidFilterChars(string.Concat(this.LongTestString, Path.DirectorySeparatorChar));

		base.Consume(result);
	}

	[Benchmark(Description = nameof(PathHelper.PathContainsWildcard))]
	[BenchmarkCategory(Categories.New)]
	public void PathContainsWildcard()
	{
		var result = PathHelper.PathContainsWildcard(string.Concat(this.LongTestString, '*'));

		base.Consume(result);
	}
}
