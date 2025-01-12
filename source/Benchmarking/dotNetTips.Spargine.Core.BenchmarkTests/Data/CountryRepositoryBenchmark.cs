// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-11-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-11-2025
// ***********************************************************************
// <copyright file="CountryRepositoryBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Data;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Data;

public class CountryRepositoryBenchmark : Benchmark
{
	[Benchmark(Description = nameof(CountryRepository.GetCountries))]
	[BenchmarkCategory(Categories.New)]
	public void GetCountries()
	{
		var result = CountryRepository.GetCountries();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryRepository.GetCountry) + ": By Country Id")]
	[BenchmarkCategory(Categories.New)]
	public void GetCountryByCountryId()
	{
		var result = CountryRepository.GetCountry(233);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryRepository.GetCountry) + ": By CountryName")]
	[BenchmarkCategory(Categories.New)]
	public void GetCountryByCountryName()
	{
		var result = CountryRepository.GetCountry(CountryName.UnitedStates);
		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

	}

	[Benchmark(Description = nameof(CountryRepository.ValidatePhoneNumber) + ": US")]
	[BenchmarkCategory(Categories.New)]
	public void ValidatePhoneNumber()
	{
		var result = CountryRepository.ValidatePhoneNumber(CountryName.UnitedStates, "1-555-666-7777", true);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryRepository.ValidatePostalCode) + ": US-Full")]
	[BenchmarkCategory(Categories.New)]
	public void ValidatePostalCode()
	{
		var result = CountryRepository.ValidatePostalCode(CountryName.UnitedStates, "92130-1234");
		this.Consume(result);
	}
}
