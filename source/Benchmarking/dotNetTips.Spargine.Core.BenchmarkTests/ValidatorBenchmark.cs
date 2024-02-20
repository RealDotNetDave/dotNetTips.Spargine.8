// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 12-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 12-28-2023
// ***********************************************************************
// <copyright file="ValidatorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

namespace DotNetTips.Spargine.Core.BenchmarkTests;
public class ValidatorBenchmark : Benchmark
{

	private const string TestString = "This IS a Test string.";

	private readonly IEnumerable<Person<Address>> _people = RandomData.GeneratePersonRefCollection<Address>(100).ToList();

	private string ValidateIsNullOrEmpty_Test_NoValidation(string input)
	{
		var result = input;

		this.Consume(input);

		return result;
	}

	private string ValidateIsNullOrEmpty_Test_Validation(string input)
	{
		var result = input.ArgumentNotNullOrEmpty();

		this.Consume(input);

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	private string ValidateIsNullOrEmpty_Test_Validation_Inlining(string input)
	{
		var result = input.ArgumentNotNullOrEmpty();

		this.Consume(input);

		return result;
	}

	private bool ValidateItemsExist_NoValidation<T>(IEnumerable<T> input)
	{
		var result = true;

		this.Consume(input);

		return result;
	}

	private bool ValidateItemsExist_Validation<T>(IEnumerable<T> input)
	{
		var result = input.CheckItemsExists();

		this.Consume(input);

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	private bool ValidateItemsExist_Validation_Inlining<T>(IEnumerable<T> input)
	{
		var result = input.CheckItemsExists();

		this.Consume(input);

		return result;
	}

	[Benchmark(Description = "Validating Empty/Null String: No Validation")]
	[BenchmarkCategory(Categories.Validation, Categories.New, Categories.ForComparison)]
	public void ArgumentNotNullOrEmpty_NoValidation()
	{
		_ = this.ValidateIsNullOrEmpty_Test_NoValidation(TestString);
	}

	[Benchmark(Description = "Validating Empty/Null String: Validation")]
	[BenchmarkCategory(Categories.Validation, Categories.New, Categories.ForComparison)]
	public void ArgumentNotNullOrEmpty_Validation()
	{
		_ = this.ValidateIsNullOrEmpty_Test_Validation(TestString);
	}

	[Benchmark(Description = "Validating Empty/Null String: Validation + Inlining")]
	[BenchmarkCategory(Categories.Validation, Categories.New, Categories.ForComparison)]
	public void ArgumentNotNullOrEmpty_Validation_Inlining()
	{
		_ = this.ValidateIsNullOrEmpty_Test_Validation_Inlining(TestString);
	}

	[Benchmark(Description = "Validating Collection: No Validation")]
	[BenchmarkCategory(Categories.Validation, Categories.New, Categories.ForComparison)]
	public void CheckItemsExists_NoValidation()
	{
		_ = this.ValidateItemsExist_NoValidation(this._people);
	}

	[Benchmark(Description = "Validating Collection: Validation")]
	[BenchmarkCategory(Categories.Validation, Categories.New)]
	public void CheckItemsExists_Validation()
	{
		_ = this.ValidateItemsExist_Validation(this._people);
	}

	[Benchmark(Description = "Validating Collection: Validation + Inlining")]
	[BenchmarkCategory(Categories.Validation, Categories.New)]
	public void CheckItemsExists_Validation_Inlining()
	{
		_ = this.ValidateItemsExist_Validation_Inlining(this._people);
	}

}
