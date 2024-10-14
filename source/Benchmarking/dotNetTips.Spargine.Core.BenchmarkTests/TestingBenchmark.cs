// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-20-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2024
// ***********************************************************************
// <copyright file="TestingBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Testing Benchmark for temporary tests.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
[BenchmarkCategory("Work in Progress")]
public class TestingBenchmark : TinyCollectionBenchmark
{

	//[Benchmark(Description = "Clone Val")]
	//[BenchmarkCategory(Categories.New)]
	//public void Clone01()
	//{
	//	var result = _peopleVal.Clone<Tester.Models.ValueTypes.Person[]>();

	//	this.Consume(result);
	//}

	//[Benchmark(Description = "Clone Ref")]
	//[BenchmarkCategory(Categories.New)]
	//public void Clone02()
	//{
	//	var result = _peopleRef.Clone<PersonProper[]>();

	//	this.Consume(result);
	//}

	public override void Setup()
	{

	}

}
