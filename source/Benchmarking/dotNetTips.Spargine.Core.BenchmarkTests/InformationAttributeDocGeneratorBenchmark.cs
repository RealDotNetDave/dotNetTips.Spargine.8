// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-02-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2025
// ***********************************************************************
// <copyright file="InformationAttributeDocGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Reflection;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

public class InformationAttributeDocGeneratorBenchmark : Benchmark
{
	[Benchmark(Description = nameof(EnumHelper.GetValues))]
	public void GenerateMarkdownDocumentForAssembly()
	{
		var assembly = Assembly.Load("DotNetTips.Spargine.8.Benchmarking");
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly);

		this.Consume(result);
	}
}
