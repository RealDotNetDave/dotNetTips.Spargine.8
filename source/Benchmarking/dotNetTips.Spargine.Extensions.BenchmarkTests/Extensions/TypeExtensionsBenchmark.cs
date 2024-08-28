// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 06-02-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2024
// ***********************************************************************
// <copyright file="TypeExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json.Serialization;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

public class TypeExtensionsBenchmark : Benchmark
{

	[Benchmark(Description = nameof(TypeExtensions.GetAllDeclaredFields))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllDeclaredFields()
	{
		var result = typeof(Person<Address>).GetAllDeclaredFields();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetAllDeclaredMethods))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllDeclaredMethods()
	{
		var result = typeof(Person<Address>).GetAllDeclaredMethods();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetAllFields))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllFields()
	{
		var result = typeof(Person<Address>).GetAllFields();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetAllMethods))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllMethods()
	{
		var result = typeof(Person<Address>).GetAllMethods();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetAllProperties))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllProperties()
	{
		var result = typeof(Person<Address>).GetAllProperties();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetTypeMembersWithAttribute))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetTypeMembersWithAttribute()
	{
		var result = typeof(Person<Address>).GetTypeMembersWithAttribute<JsonPropertyNameAttribute>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetTypeOfType))]
	[BenchmarkCategory(Categories.ReferenceType, Categories.New)]
	public void GetTypeOfType()
	{
		var result = typeof(Person<Address>).GetTypeOfType();

		this.Consume(result);
	}

}
