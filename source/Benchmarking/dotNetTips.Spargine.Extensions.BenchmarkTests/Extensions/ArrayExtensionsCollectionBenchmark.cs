// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="ArrayExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class ArrayExtensionsCollectionBenchmark.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class ArrayExtensionsCollectionBenchmark : SmallCollectionBenchmark
{

	private PersonRecord[] _personRecordArray;
	private Person<Address>[] _personRefArray;
	private Spargine.Tester.Models.ValueTypes.Person<Spargine.Tester.Models.ValueTypes.Address>[] _personValArray;

	[Benchmark(Description = nameof(ArrayExtensions.AddFirst) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AddFirst_Ref()
	{
		var people = this._personRefArray;

		var result = people.AddFirst(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddLast) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AddLast_Ref()
	{
		var people = this._personRefArray;

		var result = people.AddLast(this.PersonRef02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AreEqual_Ref()
	{
		var people1 = this._personRefArray;
		var people2 = people1.Take(this.Count / 2).ToArray();

		var result = people1.AreEqual(people2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void AreEqual_Val()
	{
		var people1 = this._personValArray;
		var people2 = people1.Take(this.Count / 2).ToArray();

		var result = people1.AreEqual(people2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(GetHashCode))]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ArrayHashCode_Ref()
	{
		var result = this._personRefArray;

		this.Consume(result.GetHashCode());
	}

	[Benchmark(Description = nameof(ArrayExtensions.AsReadOnlySpan) + " : Reference")]
	[BenchmarkCategory(Categories.Span, Categories.ReferenceType)]
	public void AsReadOnlySpan_Ref()
	{
		var result = this._personRefArray.AsReadOnlySpan();

		this.Consume(result.ToArray());
	}

	[Benchmark(Description = nameof(ArrayExtensions.AsSpan) + " : Reference")]
	[BenchmarkCategory(Categories.Span, Categories.ReferenceType)]
	public void AsSpan_Ref()
	{
		var result = this._personRefArray.AsSpan();

		this.Consume(result.ToArray());
	}

	//TODO:FIGURE OUT WHY THIS DOES NOT WORK
	//[Benchmark(Description = "As<>()")]
	//public void As01()
	//{
	//	var people1 = this._personRefArray.Clone<PersonProper>();
	//	var result = people1.As<List<IPerson>>();
	//	base.Consume(result);
	//}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ClonePerson_Ref()
	{
		var result = this._personRefArray.Clone<Person<Address>[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void ClonePerson_Val()
	{
		var result = this._personValArray.Clone<Spargine.Tester.Models.ValueTypes.Person<Spargine.Tester.Models.ValueTypes.Address>>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array as Record")]
	[BenchmarkCategory(Categories.Array, Categories.RecordType)]
	public void ClonePersonRecord_Record()
	{
		var result = this._personRecordArray.Clone<PersonRecord[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ContainsAny) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ContainsAny_Ref()
	{
		var result = this._personRefArray.ContainsAny(this.GetPersonRefArray());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ContainsAny) + ": as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void ContainsAny_Val()
	{
		var result = this._personValArray.ContainsAny(this.GetPersonValArray());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void DoesNotHaveItems_Ref()
	{
		var result = this._personRefArray.DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems) + ": as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void DoesNotHaveItems_Val()
	{
		var result = this._personValArray.DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = "Process Collection: foreach()")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void FastProcessor_Normal_Ref()
	{
		var people = this._personRefArray;

		for (var index = 0; index < people.Length; index++)
		{
			people[index].Phone = "5555555555";
		}


		this.Consume(people);
	}

	[Benchmark(Description = "Process Collection: FastProcessor()")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void FastProcessor_Ref()
	{
		var people = this._personRefArray;

		people.FastProcessor(
			(Person<Address> person) => person.Phone = "5555555555");

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ArrayExtensions.GenerateHashCode) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void GenerateHashCode_Ref()
	{
		var people = this._personRefArray;
		var result = people.GenerateHashCode();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void HasItems_Ref()
	{
		var people = this._personRefArray;
		var result = people.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HasItems_Val()
	{
		var people = this._personValArray;
		var result = people.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Count as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void HasItemsWithCount_Ref()
	{
		var people = this._personRefArray;
		var result = people.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Count as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HasItemsWithCount_Val()
	{
		var people = this._personValArray;
		var result = people.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Predicate as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void HasItemsWithPredicate_Ref()
	{
		var people = this._personRefArray;
		var result = people.HasItems(p => p.LastName.IsNotEmpty());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Predicate as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HasItemsWithPredicate_Val()
	{
		var people = this._personValArray;
		var result = people.HasItems(p => p.LastName.IsNotEmpty());

		this.Consume(result);
	}

	//TODO: FIGURE OUT WHY THIS FAILS.
	//[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Record")]
	//[BenchmarkCategory(Categories.ReferenceType)]
	//public void PerformAction_Record()
	//{
	//	var people = this._personRecordArray;
	//	var sb = new StringBuilder();

	//	people.PerformAction((person) =>
	//	{
	//		_ = sb.Append(CultureInfo.CurrentCulture, $"{person.PropertiesToString()}|");
	//	});

	//	this.Consume(sb.ToString());
	//}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Record (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.RecordType, Categories.ForComparison)]
	public void PerformAction_Record_Comparison()
	{
		var people = this._personRecordArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].GetHashCode()}|");
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Ref")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void PerformAction_Ref()
	{
		var people = this._personRefArray;
		var sb = new StringBuilder();

		people.PerformAction((person) =>
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{person.GetHashCode()}|");
		});

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Ref (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void PerformAction_Ref_Comparison()
	{
		var people = this._personRefArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].GetHashCode()}|");
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Val")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void PerformAction_Val()
	{
		var people = this._personValArray;
		var sb = new StringBuilder();

		people.PerformAction((person) =>
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{person.GetHashCode()}|");
		});

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Val (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType, Categories.ForComparison)]
	public void PerformAction_Val_Comparison()
	{
		var people = this._personValArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].GetHashCode()}|");
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void RemoveFirst_Ref()
	{
		var people = this._personRefArray;

		var result = people.RemoveFirst();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveLast) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void RemoveLast_Ref()
	{
		var people = this._personRefArray;

		var result = people.RemoveLast();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRecordArray = this.GetPersonRecordArray();
		this._personRefArray = this.GetPersonRefArray();
		this._personValArray = this.GetPersonValArray();

		LogInfo($"PersonRecordArray: {this._personRecordArray.Length}");
		LogInfo($"PersonRefArray: {this._personRefArray.Length}");
		LogInfo($"PersonValArray: {this._personValArray.Length}");
	}

	[Benchmark(Description = nameof(ArrayExtensions.ToDistinct) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ToDistinct_Ref()
	{
		var result = this._personRefArray.ToDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ToFrozenSet) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ToFrozenSet_Ref()
	{
		var result = this._personRefArray.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void Upsert_Ref()
	{
		var people = this._personRefArray;

		var result = people.Upsert(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + ": Record")]
	[BenchmarkCategory(Categories.Array, Categories.RecordType)]
	public void UpsertRecord_Record()
	{
		var people = this._personRecordArray;

		var result = people.Upsert(this.PersonRecord01);

		this.Consume(result);
	}

}
