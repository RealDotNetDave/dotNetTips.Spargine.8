// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 02-08-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-28-2023
// ***********************************************************************
// <copyright file="RandomDataBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests.Tester;

public class RandomDataBenchmark : Benchmark
{

	[Benchmark(Description = "Creating: " + nameof(Person<Address>))]
	public void CreatePerson01()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		this.Consume(person);
	}

	[Benchmark(Description = "Creating: " + nameof(Person<Address>))]
	public void CreatePerson04()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		this.Consume(person);
	}

	[Benchmark(Description = "Creating: " + nameof(PersonRecord))]
	public void CreatePerson05()
	{
		var person = RandomData.GeneratePersonRecord();

		this.Consume(person);
	}

	[Benchmark(Description = "PropertiesToString(): " + nameof(Person<Address>))]
	public void PropertiesToString01()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		this.Consume(person.PropertiesToString());
	}

	[Benchmark(Description = "PropertiesToString(): " + nameof(PersonRecord))]
	public void PropertiesToString02()
	{
		var person = RandomData.GeneratePersonRecord();

		this.Consume(person.PropertiesToString());
	}

}
