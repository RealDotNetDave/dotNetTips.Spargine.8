// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-11-2025
// ***********************************************************************
// <copyright file="RandomDataBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Data;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

public class RandomDataBenchmark : Benchmark
{

	private readonly string _filePath = Path.Combine(
		Environment.GetFolderPath(
			Environment.SpecialFolder.ApplicationData,
			Environment.SpecialFolderOption.DoNotVerify),
		"BenchmarkTests");

	public override void Cleanup()
	{
		base.Cleanup();

		DirectoryHelper.DeleteDirectory(new DirectoryInfo(this._filePath));
	}

	[Benchmark(Description = nameof(RandomData.GenerateByteArray))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateByteArray()
	{
		var result = RandomData.GenerateByteArray(sizeInKb: 1);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCharacter))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCharacter()
	{
		var result = RandomData.GenerateCharacter();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCharacter) + ": Min and Max Char")]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCharacterMinMax()
	{
		var result = RandomData.GenerateCharacter(char.MinValue, char.MaxValue);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCoordinate))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCoordinate()
	{
		var result = RandomData.GenerateCoordinate<Coordinate>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateDecimal))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateDecimal()
	{
		var result = RandomData.GenerateDecimal(0, maxValue: 1000, decimalPlaces: 2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateDomainExtension))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateDomainExtension()
	{
		var result = RandomData.GenerateDomainExtension();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateEmailAddress))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateEmailAddress()
	{
		var result = RandomData.GenerateEmailAddress();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateFile))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateFile()
	{
		var fileName = RandomData.GenerateFile(Path.Combine(this._filePath, "UnitTest.test"));

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateFiles))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateFiles()
	{
		var fileNames = RandomData.GenerateFiles(this._filePath, 2);

		this.Consume(fileNames);
	}

	[Benchmark(Description = nameof(RandomData.GenerateInteger))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateInteger()
	{
		var result = RandomData.GenerateInteger();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateKey))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateKey()
	{
		var result = RandomData.GenerateKey();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateNumber))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateNumber()
	{
		var result = RandomData.GenerateNumber(10);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRecord))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonRecord()
	{
		var result = RandomData.GeneratePersonRecord();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRef))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonRef()
	{
		var result = RandomData.GeneratePersonRef<Models.RefTypes.Address>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonVal))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonVal()
	{
		var result = RandomData.GeneratePersonVal<Address>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePhoneNumber))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePhoneNumber()
	{
		var result = RandomData.GeneratePhoneNumber(CountryName.UnitedStates);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomFileName))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateRandomFileName()
	{
		var fileName = RandomData.GenerateRandomFileName();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomFileName) + ": With Path")]
	[BenchmarkCategory(Categories.New)]
	public void GenerateRandomFileNameWithPath()
	{
		var fileName = RandomData.GenerateRandomFileName(this._filePath);

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomLocationData))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateRandomLocationData()
	{
		var result = RandomData.GenerateRandomLocationData();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomPersonData))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateRandomPersonData()
	{
		var result = RandomData.GenerateRandomPersonData();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomPersonName))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateRandomPersonName()
	{
		var result = RandomData.GenerateRandomPersonName();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRelativeUrl))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateRelativeUrl()
	{
		var result = RandomData.GenerateRelativeUrl();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateTempFile))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateTempFile()
	{
		var fileName = RandomData.GenerateTempFile();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrl))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateUrl()
	{
		var result = RandomData.GenerateUrl();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrlFragment))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateUrlFragment()
	{
		var fileName = RandomData.GenerateUrlFragment();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrlHostName))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateUrlHostName()
	{
		var fileName = RandomData.GenerateUrlHostName();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrlHostNameNoProtocol))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateUrlHostNameNoProtocol()
	{
		var fileName = RandomData.GenerateUrlHostNameNoProtocol();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrlHostNameNoSubDomain))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateUrlHostNameNoSubDomain()
	{
		var fileName = RandomData.GenerateUrlHostNameNoSubDomain();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWord))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateWord()
	{
		var result = RandomData.GenerateWord(10);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWord) + ": MIN AND MAX CHAR")]
	[BenchmarkCategory(Categories.New)]
	public void GenerateWordMinMaxChar()
	{
		var result = RandomData.GenerateWord(10, char.MinValue, char.MaxValue);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWord) + ": MIN AND MAX LENGTH")]
	[BenchmarkCategory(Categories.New)]
	public void GenerateWordMinMaxLength()
	{
		var result = RandomData.GenerateWord(10, 100);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWord) + ": MIN AND MAX LENGTH + CHAR")]
	[BenchmarkCategory(Categories.New)]
	public void GenerateWordMinMaxLengthChar()
	{
		var result = RandomData.GenerateWord(10, 100, char.MinValue, char.MaxValue);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWords))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateWords()
	{
		var result = RandomData.GenerateWords(10, 5, 10);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		_ = Directory.CreateDirectory(this._filePath);
	}

}
