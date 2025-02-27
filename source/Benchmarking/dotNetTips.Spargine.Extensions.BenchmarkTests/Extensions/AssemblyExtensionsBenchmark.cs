// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-07-2024
// ***********************************************************************
// <copyright file="AssemblyExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Reflection;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// AssemblyExtensions Benchmark tests.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
public class AssemblyExtensionsBenchmark : Benchmark
{

	[Benchmark(Description = nameof(AssemblyExtensions.GetAllInterfaces))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetAllInterfaces01()
	{
		var result = Assembly.GetExecutingAssembly().GetAllInterfaces();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(AssemblyExtensions.GetAllTypes))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetAllTypes01()
	{
		var result = Assembly.GetExecutingAssembly().GetAllTypes();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(AssemblyExtensions.GetInstances))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetInstances01()
	{
		var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsBenchmark>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(AssemblyExtensions.GetTypes))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetTypes()
	{
		// Arrange
		var assembly = Assembly.GetExecutingAssembly();
		var type = typeof(AssemblyExtensionsBenchmark);

		// Act
		var result = assembly.GetTypes(type);

		this.Consume(result);
	}

}
