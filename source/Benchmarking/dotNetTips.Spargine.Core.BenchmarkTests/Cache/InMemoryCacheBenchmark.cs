// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : david
// Created          : 10-03-2024
//
// Last Modified By : david
// Last Modified On : 10-15-2024
// ***********************************************************************
// <copyright file="InMemoryCacheBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Address = DotNetTips.Spargine.Tester.Models.RefTypes.Address;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Cache;

public class InMemoryCacheBenchmark : SmallCollectionBenchmark
{
	private InMemoryCache _cache;
	private string _cacheId;
	private Person<Address>[] _personRefArray;

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": DateTimeOffset")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemDateTimeOffset()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Email, item, futureDate);
		}

		this.Consume(cache.Cache.Count);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": Timespan")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemTimeSpan()
	{
		var cache = InMemoryCache.Instance;

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Email, item, TimeSpan.FromSeconds(5));
		}

		this.Consume(cache.Cache.Count);
	}

	[Benchmark(Description = nameof(InMemoryCache.Clear))]
	[BenchmarkCategory(Categories.Collections)]
	public void Clear()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Email, item, futureDate);
		}

		cache.Clear();

		this.Consume(cache.Cache.Count);
	}

	[Benchmark(Description = nameof(InMemoryCache.GetCacheItem))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void GetCacheItem()
	{
		this.Consume(this._cache.GetCacheItem<Person<Address>>(this._cacheId));
	}

	public override void Setup()
	{
		base.Setup();
		this._personRefArray = this.GetPersonRefArray();
		this._cache = InMemoryCache.Instance;
		this._cache.AddCacheItem(this.PersonRef01.Id, this.PersonRef01);
		this._cacheId = this.PersonRef01.Id;

	}
}
