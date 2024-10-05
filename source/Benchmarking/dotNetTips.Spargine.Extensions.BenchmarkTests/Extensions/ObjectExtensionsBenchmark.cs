// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2024
// ***********************************************************************
// <copyright file="ObjectExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

public class ObjectExtensionsBenchmark : Benchmark
{

	private string _peopleJson;
	private Collection<Person<Address>> _personCollection;

	private void CheckForNullParamNormal(object input)
	{
		input ??= "TEST";

		this.Consume(input);
	}

	private void CheckForNullParamSpargine(object input)
	{
		input ??= "SPARGINE";

		this.Consume(input);
	}

	[Benchmark(Description = nameof(ObjectExtensions.As) + ": IPerson")]
	public void As()
	{
		var result = this.PersonRef01.As<IPerson<Address>>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.Clone) + ": Person-ref")]
	public void ClonePerson()
	{
		var result = this.PersonRef01.Clone<Person<Address>>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.Clone) + ": Person Array")]
	public void ClonePersonArray()
	{
		var result = this._personCollection.ToArray().Clone<Person<Address>[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.Clone) + ": Person Collection")]
	public void ClonePersonCollection()
	{
		var result = this._personCollection.Clone<Collection<Person<Address>>>();

		this.Consume(result);
	}

	[Benchmark(Description = "Clone: PersonRecord*")]
	public void ClonePersonRecord()
	{
		var result = this.PersonRecord01 with { };

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash) + ": Person-ref")]
	public void ComputeSha256Hash01()
	{
		var result = this.PersonRef01.ComputeSha256Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash) + ": PersonRecord")]
	public void ComputeSha256Hash02()
	{
		var result = this.PersonRecord01.ComputeSha256Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.DisposeFields) + ": DataTable")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void DisposeFields()
	{
		var disposableType = new DataTable("TEST");

		disposableType.DisposeFields();
	}

	[Benchmark(Description = "PersonRecord: Duplication with new ID")]
	public void Duplicate01()
	{
		var result = this.PersonRecord01 with { Id = "12345678" };

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FastGetHashCode))]
	[BenchmarkCategory(Categories.New)]
	public void FastGetHashCode()
	{
		var word = RandomData.GenerateWord(15);

		this.Consume(word.FastGetHashCode());
	}

	[Benchmark(Description = nameof(ObjectExtensions.FromJson))]
	public void FromJson()
	{
		var result = this._peopleJson.FromJson<Person<Address>>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.HasProperty) + ": Person-ref")]
	public void HasProperty01()
	{
		var result = this.PersonRef01.HasProperty("City");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.HasProperty) + ": PersonRecord")]
	public void HasProperty02()
	{
		var result = this.PersonRecord01.HasProperty("City");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.InitializeFields))]
	public void InitializeFields()
	{
		using var testObject = new DisposableFields();

		testObject.InitializeFields();

		this.Consume(testObject);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNotNull) + ": Person-ref")]
	public void IsNotNull01()
	{
		var result = this.PersonRef01.IsNotNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNotNull) + ": PersonRecord")]
	public void IsNotNull02()
	{
		var result = this.PersonRecord01.IsNotNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNull) + ": Person-ref")]
	public void IsNull01()
	{
		var result = this.PersonRef01.IsNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNull) + ": PersonRecord")]
	public void IsNull02()
	{
		var result = this.PersonRecord01.IsNull();

		this.Consume(result);
	}

	[Benchmark(Description = "PersonRecord: ToString()")]
	public void PersonRecordToString01()
	{
		var person = this.PersonRecord01;

		var result = person.ToString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": Person-ref-Ignore Nulls")]
	public void PropertiesToDictionary01()
	{
		var person = this.PersonRef01;

		var result = person.PropertiesToDictionary(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": Person-ref-With Nulls")]
	public void PropertiesToDictionary02()
	{
		var person = this.PersonRef01;

		var result = person.PropertiesToDictionary(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonRecord-With Nulls")]
	public void PropertiesToDictionary04()
	{
		var person = this.PersonRecord01;

		var result = person.PropertiesToDictionary(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonRecord-Ignore Nulls")]
	public void PropertiesToDictionary05()
	{
		var person = this.PersonRecord01;

		var result = person.PropertiesToDictionary(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": Person-ref-Ignore Nulls")]
	public void PropertiesToString01()
	{
		var person = this.PersonRef01;

		var result = person.PropertiesToString(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": Person-ref-With Nulls")]
	public void PropertiesToString02()
	{
		var person = this.PersonRef01;

		var result = person.PropertiesToString(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonRecord-Ignore Nulls")]
	public void PropertiesToString03()
	{
		var person = this.PersonRecord01;

		var result = person.PropertiesToString(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonRecord-With Nulls")]
	public void PropertiesToString04()
	{
		var person = this.PersonRecord01;

		var result = person.PropertiesToString(ignoreNulls: false);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleJson = this.PersonRef01.ToJson();
		this._personCollection = RandomData.GeneratePersonRefCollection<Address>(1000).ToCollection();
	}

	[Benchmark(Description = nameof(ObjectExtensions.StripNull) + ": Person")]
	public void StripNull()
	{
		var result = this.PersonRef01.StripNull();

		this.Consume(result);
	}

	[Benchmark(Description = "Testing Param for Null: != null")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TestingForNull01()
	{
		var input = new object();

		this.CheckForNullParamNormal(input);
	}

	[Benchmark(Description = "Testing Param for Null: Validate.TryValidateNull()")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TestingForNull02()
	{
		var input = new object();

		this.CheckForNullParamSpargine(input);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": Person")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJson01()
	{
		var result = this.PersonRef01.ToJson();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": PersonRecord")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJson02()
	{
		var result = this.PersonRecord01.ToJson();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": Person - JsonSerializerOptions")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJson03()
	{
		var result = this.PersonRef01.ToJson(JsonSerializerOptions.Default);

		this.Consume(result.Value);
	}

	[Benchmark(Description = nameof(ObjectExtensions.TryDispose) + ": Person")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TryDispose()
	{
		var disposableType = new DataTable("TEST");

		disposableType.TryDispose();
	}

}

[ExcludeFromCodeCoverage]
public class DisposableFields : IDisposable
{

	/// <summary>
	/// The data set
	/// </summary>
	private readonly DataSet _dataSet = new("TEST");

	/// <summary>
	/// The disposed value
	/// </summary>
	private bool _disposedValue;

	/// <summary>
	/// Disposes the specified disposing.
	/// </summary>
	/// <param name="disposing">The disposing.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!this._disposedValue)
		{
			if (disposing)
			{
				this._dataSet.Dispose();
			}

			this._disposedValue = true;
		}
	}

	/// <summary>
	/// Disposes this instance.
	/// </summary>
	[Preserve("Part of IDisposable", "4/16/2023", "David McCarter")]
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		this.Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

}
