// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-03-2024
// ***********************************************************************
// <copyright file="TypeHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// TypeHelper PerfTestRunner.
/// Implements the <see cref="Benchmarking.PerfTestRunner" />
/// </summary>
/// <seealso cref="Benchmarking.PerfTestRunner" />
public class TypeHelperBenchmark : Benchmark
{

	private readonly int _collectionCount = 50;
	private List<Person<Address>> _people;

	[Benchmark(Description = nameof(TypeHelper.BuiltinTypes))]
	[BenchmarkCategory(Categories.Reflection)]
	public void BuiltinTypes()
	{
		var result = TypeHelper.BuiltinTypes;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.Create))]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateNormal()
	{
		var result = TypeHelper.Create<Person<Address>>();

		this.Consume(result);
	}

	[Benchmark(Description = "Looping Collection: Normal StringBuilder")]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateStringBuilder()
	{
		var sb = new StringBuilder();

		foreach (var person in this._people)
		{
			_ = sb.AppendFormat(CultureInfo.InvariantCulture, "{0}={1}", person.Email, person.Id);
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(TypeHelper.Create) + ": With Parameters")]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateWithParameters()
	{
		var result = TypeHelper.Create<Person<Address>>("TESTID", "DOTNETDAVE@LIVE.COM");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.DoesObjectEqualInstance))]
	[BenchmarkCategory(Categories.Strings)]
	public void DoesObjectEqualInstance()
	{
		var result = TypeHelper.DoesObjectEqualInstance(this.PersonRef01, this.PersonRef02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.FindDerivedTypes))]
	[BenchmarkCategory(Categories.Reflection)]
	public void FindDerivedTypes()
	{
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(MulticastDelegate), true);
		Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetPropertyValues))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetPropertyValues()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var result = TypeHelper.GetPropertyValues(person);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		var list = new Dictionary<string, string>(this._collectionCount);
		for (var i = 0; i < this._collectionCount; i++)
		{
			list.Add(RandomData.GenerateKey(), RandomData.GenerateKey());
		}

		this._people = RandomData.GeneratePersonRefCollection<Address>(this._collectionCount).ToList();
	}

}
