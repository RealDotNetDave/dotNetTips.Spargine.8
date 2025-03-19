// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-11-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2024
// ***********************************************************************
// <copyright file="ReadOnlySpanBenchmark.cs" company="McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ReadOnlySpanBenchmark : SmallCollectionBenchmark
{
	private byte[] _bytes;
	private PersonRecord[] _peopleRecordArray;
	private Spargine.Tester.Models.ValueTypes.Person<Spargine.Tester.Models.ValueTypes.Address>[] _peopleValArray;
	private Person<Address>[] _personRefArray;

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.BytesToString))]
	public void BytesToString()
	{
		var collection = this._bytes.AsReadOnlySpan();

		var result = collection.BytesToString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.PickRandom) + ": record")]
	public void PickRandomRecord()
	{
		var collection = new ReadOnlySpan<PersonRecord>(this._peopleRecordArray);

		var result = collection.PickRandom();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.PickRandom) + ": ref")]
	public void PickRandomRef()
	{
		var collection = new ReadOnlySpan<Person<Address>>(this._personRefArray);

		var result = collection.PickRandom();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.PickRandom) + ": val")]
	public void PickRandomVal()
	{
		var collection = new ReadOnlySpan<Spargine.Tester.Models.ValueTypes.Person<Spargine.Tester.Models.ValueTypes.Address>>(this._peopleValArray);

		var result = collection.PickRandom();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._bytes = this.GetByteArray();
		this._personRefArray = this.GetPersonRefArray();
		this._peopleRecordArray = this.GetPersonRecordArray();
		this._peopleValArray = this.GetPersonValArray();
	}

}
