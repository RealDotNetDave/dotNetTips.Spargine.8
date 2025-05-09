// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2025
// ***********************************************************************
// <copyright file="EnumerableExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// EnumerableExtensions PerfTestRunner.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsCollectionBenchmark : SmallCollectionBenchmark
{

	private IEnumerable<Spargine.Tester.Models.ValueTypes.Coordinate> _coordinateValEnumerable;
	private List<PersonRecord> _personRecordList;
	private IEnumerable<Person<Address>> _personRefEnumerable;
	private IEnumerable<Person<Address>> _personRefEnumerableToAdd;
	private string _personRefId;
	private Person<Address> _personRefLast;
	private List<Person<Address>> _personRefList;
	private List<Person<Address>> _personRefListDups;

	private static bool AnyWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate) => list.Any(predicate);
	private static int CountWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate) => list.Count(predicate);



	[Benchmark(Description = nameof(EnumerableExtensions.AddDistinct))]
	public void AddDistinct()
	{
		var people = this._personRefEnumerable;
		var peopleToAdd = this._personRefEnumerableToAdd;

		var result = people.AddDistinct(peopleToAdd.ToArray());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddFirst))]
	public void AddFirst()
	{
		var people = this._personRefEnumerable;

		var result = people.AddFirst(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddIf))]
	public void AddIf()
	{
		var people = this._personRefEnumerable;

		var result = people.AddIf(this.PersonRef01, true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddLast))]
	public void AddLast()
	{
		var people = this._personRefEnumerable;

		var result = people.AddLast(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = "Any: With Predicate")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void AnyWithPredicate()
	{
		var result = AnyWithPredicate(this._personRefEnumerable, p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = "Chunk (compare to Page and Partition)")]
	[BenchmarkCategory(Categories.ForComparison, Categories.New)]
	public void Chunk()
	{
		foreach (var people in this._personRefEnumerable.Chunk(25))
		{
			foreach (var person in people)
			{
				this.Consume(person);
			}
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ContainsAny))]
	public void ContainsAny()
	{
		var people = this._personRefEnumerable;

		people = people.AddLast(people.FirstOrDefault());

		var result = people.ContainsAny(people.Take(10).ToArray());

		this.Consume(result);
	}

	[Benchmark(Description = "IEnumerable.Count: With Predicate")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void Count_Count_WithPredicate()
	{
		var result = CountWithPredicate(this._personRefEnumerable, p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.CountAsync))]
	public async Task Count_CountAsync()
	{
		var result = await this._personRefEnumerable.CountAsync(CancellationToken.None).ConfigureAwait(false);

		this.Consume(result);
	}

	[Benchmark(Description = "EnumerableExtensions.Count()")]
	public void Count_EnumerableExtensions_Count()
	{
		var result = this._personRefEnumerable.Count();

		this.Consume(result);
	}

	[Benchmark(Description = "EnumerableExtensions.Count()" + ": IList ")]
	public void Count_FastCount_IList()
	{
		var result = this._personRefList.FastCount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastCount) + ":With Predicate")]
	public void Count_FastCount_WithPredicate()
	{
		var result = this._personRefEnumerable.FastCount(p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastCount))]
	public void Counting_FastCount()
	{
		var result = this._personRefEnumerable.FastCount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Create))]
	public void Create()
	{
		var people = this._personRefEnumerable;

		people = people.Create(true);

		var result = people.ContainsAny(people.Take(10).ToArray());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.DoesNotHaveItems))]
	public void DoesNotHaveItems()
	{
		var people = new List<Person<Address>>().AsEnumerable();

		var result = people.DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.EnsureUnique))]
	public void EnsureUnique()
	{
		var people = this._personRefEnumerable;

		people = people.AddLast(people.FirstOrDefault());

		var result = people.EnsureUnique().ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastAny) + ": With Predicate")]
	public void FastAnyWithPredicate()
	{
		var result = this._personRefEnumerable.FastAny(p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastModifyCollection))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void FastModifyCollection()
	{
		var people = this._personRecordList;

		var result = people.FastModifyCollection(person => person with { Email = "TestData" });

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastProcessor))]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void FastProcessor_Ref()
	{
		var people = this._personRefEnumerable;

		people.FastProcessor(person => person.Phone = "5555555555");

		this.Consume(people);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": With Alternate")]
	public void FirstOrDefaultAlternate()
	{
		var result = this._personRefEnumerable.FirstOrDefault(alternate: this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, With Alternate")]
	public void FirstOrDefaultPredicateAlternate()
	{
		var result = this._personRefEnumerable.FirstOrDefault(p => string.Equals(p.Id, this.PersonRef01.Id, StringComparison.Ordinal), this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
	public void FirstOrNull()
	{
		var result = this._coordinateValEnumerable.FirstOrNull(p => p.X == this.CoordinateVal01.X);

		this.Consume(result);
	}


	[Benchmark(Description = nameof(EnumerableExtensions.HasDuplicates))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasDuplicates()
	{
		var result = this._personRefListDups.HasDuplicates();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.HasItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItems()
	{
		var result = this._personRefEnumerable.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.HasItems) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithCount()
	{
		var result = this._personRefEnumerable.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
	public void IndexOf()
	{
		var people = this._personRefEnumerable;
		var result = people.IndexOf(this._personRefLast);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Comparer")]
	public void IndexOfComparer()
	{
		var people = this._personRefEnumerable;
		var comparer = new PersonComparer();
		var result = people.IndexOf(this._personRefLast, comparer);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Predicate")]
	[BenchmarkCategory(Categories.New)]

	public void IndexOfPredicate()
	{
		var people = this._personRefEnumerable;
		var result = people.IndexOf(p => p.Equals(this._personRefLast));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsNullOrEmpty))]
	public void IsNullOrEmpty()
	{
		var people = new List<Person<Address>>().AsEnumerable();

		var result = people.IsNullOrEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Join))]
	public void Join()
	{
		var people = this._personRefEnumerable;

		var result = people.Join();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderBy))]
	public void OrderBy()
	{
		var result = this._personRefEnumerable.OrderBy(p => p.LastName);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
	public void OrderByOrdinal()
	{
		var result = this._personRefEnumerable.OrderByOrdinal(p => p.FirstName);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderBy) + ": With Sort Expression")]
	public void OrderBySortExpression()
	{
		var result = this._personRefEnumerable.OrderBy("Email desc");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Page))]
	public void Page()
	{
		foreach (var people in this._personRefEnumerable.Page(25))
		{
			foreach (var person in people)
			{
				this.Consume(person);
			}
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Partition))]
	public void Partition()
	{
		var people = this._personRefEnumerable;

		var splitPeople = people.Partition(this.Count / 2);

		this.Consume(splitPeople);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
	public void PickRandom()
	{
		var result = this._personRefEnumerable.PickRandom();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.RemoveDuplicates))]
	[BenchmarkCategory(Categories.Collections)]
	public void RemoveDuplicates()
	{
		var result = this._personRefListDups.RemoveDuplicates();

		this.Consume(result.Value);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.RemoveNulls))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveNulls()
	{
		var collection = this._personRefEnumerable.ToList();

		// Add a null to the collection
		collection.AddFirst(null);
		collection.AddLast(null);

		var result = collection.RemoveDuplicates();

		this.Consume(result.Value);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ReplaceIf))]
	[BenchmarkCategory(Categories.New)]
	public void ReplaceIf()
	{
		var people = this._personRefEnumerable;
		var result = people.ReplaceIf((p, index) => string.Equals(p.Id, this._personRefId, StringComparison.Ordinal), this._personRefLast);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Scan))]
	[BenchmarkCategory(Categories.New)]
	public void Scan()
	{
		var people = this._personRefEnumerable;

		var result = people.Scan(new Person<Address>(), (acc, p) => p);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefList = [.. this.GetPersonRefArray()];
		this._personRecordList = [.. this.GetPersonRecordArray()];
		this._coordinateValEnumerable = this.GetCoordinateValArray().AsEnumerable();

		this._personRefLast = this._personRefList.Last();
		this._personRefId = this._personRefList[this.Count / 2].Id;

		var peopleToAdd = this._personRefEnumerable.ToList();
		peopleToAdd.AddRange(this.GetPersonRefCollectionToInsert().Take(this.Count / 10));
		this._personRefEnumerableToAdd = peopleToAdd.AsEnumerable();

		// Create collection with duplicates
		var dups = this._personRefEnumerable.Shuffle().Take(this.Count / 10);
		this._personRefListDups = this._personRefEnumerable.ToList();
		foreach (var person in dups)
		{
			_ = this._personRefListDups.Append(person);
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Shuffle))]
	public void Shuffle()
	{
		var result = this._personRefEnumerable.Shuffle();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Shuffle) + "With Count")]
	public void ShuffleWithCount()
	{
		var result = this._personRefEnumerable.Shuffle(this.Count / 2);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Split))]
	public void Split()
	{
		var people = this._personRefEnumerable;

		var splitPeople = people.Split(10);

		this.Consume(splitPeople);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
	public void StartsWith()
	{
		var people = this._personRefEnumerable;
		var result = people.StartsWith(people.Take(10));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
	public void StructuralSequenceEqual()
	{
		var people = this._personRefEnumerable;
		var result = people.StructuralSequenceEqual(people.TakeLast(10));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
	public void ToBlockingCollection01()
	{
		var result = this._personRefEnumerable.ToBlockingCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToCollection))]
	public void ToCollection()
	{
		var result = this._personRefEnumerable.ToCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
	public void ToDelimitedString()
	{
		var result = this._personRefEnumerable.ToDelimitedString(',');

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._personRefEnumerable.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable))]
	public void ToImmutable()
	{
		var result = this._personRefEnumerable.AsEnumerable().ToImmutable();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
	public void ToLinkedList()
	{
		var result = this._personRefEnumerable.ToLinkedList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToListAsync))]
	public async Task ToListAsync()
	{
		var people = this._personRefEnumerable;

		var result = await people.ToListAsync().ConfigureAwait(false);

		await this.ConsumeAsync(result).ConfigureAwait(false);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToReadOnlyCollection))]
	public void ToReadOnlyCollection()
	{
		var result = this._personRefEnumerable.ToReadOnlyCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Upsert))]
	public void Upsert()
	{
		var people = this._personRefEnumerable;

		var result = people.Upsert(this.PersonRef01);

		this.Consume(result);
	}

}
