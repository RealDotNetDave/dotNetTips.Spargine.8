// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-14-2025
// ***********************************************************************
// <copyright file="SerializationBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Text.Json;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Serialization;

/// <summary>
/// Class SerializationBenchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
[BenchmarkCategory(Categories.Serialization)]
public class SerializationBenchmark : Benchmark
{

	private const int Count = 100;

	private string _jsonPersonRecord;
	private string _jsonPersonRef;

	private string _jsonPersonRefList;
	private List<Person<Address>> _personRefList;
	private string _xmlPersonRecord;
	private string _xmlPersonRef;

	[Benchmark(Description = "Deserialize JSON: JsonSerializer + Generator - Person")]
	[BenchmarkCategory(Categories.JSON, Categories.New, "JsonSerializer")]
	public void Deserialize_Json_JsonSerializer_Generator_Person()
	{
		var result = JsonSerializer.Deserialize(this._jsonPersonRef, typeof(Person<Address>), PersonJsonSerializerContext.Default) as Person<Address>;
		base.Consume(result);
	}

	[Benchmark(Description = "Deserialize JSON: JsonSerializer + Generator - List<Person>")]
	[BenchmarkCategory(Categories.JSON, Categories.New, "JsonSerializer")]
	public void Deserialize_Json_JsonSerializer_Generator_Person_List()
	{
		var result = JsonSerializer.Deserialize(this._jsonPersonRefList, typeof(List<Person<Address>>), PersonJsonSerializerContext.Default) as List<Person<Address>>;
		base.Consume(result);
	}

	/// <summary>
	/// Deserializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": List<Person>")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize_Json_Person_List()
	{
		var result = JsonSerialization.Deserialize<List<Person<Address>>>(this._jsonPersonRefList);

		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize_Json_PersonRecord()
	{
		var result = JsonSerialization.Deserialize<PersonRecord>(this._jsonPersonRecord);

		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the XML record.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonRecord")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize_Xml_PersonRecord()
	{
		var result = XmlSerialization.Deserialize<PersonRecord>(this._xmlPersonRecord);

		this.Consume(result);
	}
	/// <summary>
	/// Deserializes the XML reference.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=Person")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize_Xml_Ref_Person()
	{
		var result = XmlSerialization.Deserialize<Person<Address>>(this._xmlPersonRef);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.JsonEqual))]
	[BenchmarkCategory(Categories.JSON, Categories.New)]
	public void JsonEqual()
	{
		var actual = "{\"Name\":\"Test\",\"Value\":1}";
		var expected = "{\"Name\":\"Test\",\"Value\":2}";

		// Act
		var result = JsonSerialization.JsonEqual(actual, expected);

		base.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.LoadCollectionFromJson) + ": JSON=People")]
	[BenchmarkCategory(Categories.JSON, Categories.New)]
	public void LoadCollectionFromJson_People()
	{
		var result = JsonSerialization.LoadCollectionFromJson<Person<Address>>(this._jsonPersonRefList, Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.LoadCollectionFromJson) + ": JSON=People, SerializerContext")]
	[BenchmarkCategory(Categories.JSON, Categories.New)]
	public void LoadCollectionFromJson_People_SerializerContext()
	{
		var result = JsonSerialization.LoadCollectionFromJson<Person<Address>>(this._jsonPersonRefList, Count, PersonJsonSerializerContext.Default.Person);

		this.Consume(result);
	}

	[Benchmark(Description = "Serialize JSON: JsonSerializer + Generator - Person")]
	[BenchmarkCategory(Categories.JSON, Categories.New, "JsonSerializer")]
	public void Serialize_Json_JsonSerializer_Generator_Person()
	{
		var result = JsonSerializer.Serialize(base.PersonRef01, typeof(Person<Address>), PersonJsonSerializerContext.Default);

		base.Consume(result);
	}

	[Benchmark(Description = "Serialize JSON: JsonSerializer + Generator - List<Person>")]
	[BenchmarkCategory(Categories.JSON, Categories.New, "JsonSerializer")]
	public void Serialize_Json_JsonSerializer_Generator_Person_List()
	{
		var result = JsonSerializer.Serialize(this._personRefList, typeof(List<Person<Address>>), PersonJsonSerializerContext.Default);
		base.Consume(result);
	}

	/// <summary>
	/// Serializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": List<Person>")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_Person_List()
	{
		var result = JsonSerialization.Serialize(this._personRefList);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_PersonRecord()
	{
		var result = JsonSerialization.Serialize(this.PersonRecord02);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json reference.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=Person")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_Ref_Person()
	{
		var result = JsonSerialization.Serialize(this.PersonRef01);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the XML reference.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Serialize) + ": XML=Person")]
	[BenchmarkCategory(Categories.XML)]
	public void Serialize_XML_Ref_Person()
	{
		var result = XmlSerialization.Serialize(this.PersonRef01);

		this.Consume(result);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._jsonPersonRef = JsonSerialization.Serialize(base.PersonRef01);
		this._jsonPersonRecord = JsonSerialization.Serialize(base.PersonRecord01);
		this._xmlPersonRef = XmlSerialization.Serialize(base.PersonRef01);
		this._xmlPersonRecord = XmlSerialization.Serialize(base.PersonRecord01);
		this._jsonPersonRefList = RandomData.GeneratePersonRefCollection<Address>(Count).ToJson();
		this._personRefList = [.. RandomData.GeneratePersonRefCollection<Address>(100)];
	}

}
