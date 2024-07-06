// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="InMemoryCacheTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Cache;
[ExcludeFromCodeCoverage]
[TestClass]
public class InMemoryCacheTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_EmptyKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem<Person<Address>>(string.Empty, RandomData.GeneratePersonRef<Address>());
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_NullItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem<string>("testKey", null);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem<Person<Address>>(null, RandomData.GeneratePersonRef<Address>());
	}

	[TestMethod]
	public void AddCacheItem_ValidKeyAndItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		cache.AddCacheItem(person.Id, person);

		var cachedPerson = cache.GetCacheItem<Person<Address>>(person.Id);

		Assert.IsNotNull(cachedPerson);
		Assert.AreEqual(person.Id, cachedPerson.Id);
		cache.Clear(); // Cleanup after test
	}


	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_WithCustomExpirationDateTime_EmptyKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		cache.AddCacheItem<Person<Address>>(string.Empty, RandomData.GeneratePersonRef<Address>(), futureDate);
	}

	[TestMethod]
	public void AddCacheItem_WithCustomExpirationDateTime_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		var futureDate = DateTimeOffset.Now.AddMinutes(30); // Custom expiration date

		cache.AddCacheItem(person.Id, person, futureDate);

		var cachedPerson = cache.GetCacheItem<Person<Address>>(person.Id);

		Assert.IsNotNull(cachedPerson, "Cached item should not be null.");
		Assert.AreEqual(person.Id, cachedPerson.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_WithCustomExpirationDateTime_NullItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		cache.AddCacheItem<string>("testKey", null, futureDate);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_WithCustomExpirationDateTime_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		cache.AddCacheItem<Person<Address>>(null, RandomData.GeneratePersonRef<Address>(), futureDate);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_WithCustomTimeout_EmptyKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem<Person<Address>>(string.Empty, RandomData.GeneratePersonRef<Address>(), TimeSpan.FromMinutes(30));
	}

	[TestMethod]
	public void AddCacheItem_WithCustomTimeout_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		var timeout = TimeSpan.FromMinutes(30); // Custom timeout

		cache.AddCacheItem(person.Id, person, timeout);

		var cachedPerson = cache.GetCacheItem<Person<Address>>(person.Id);

		Assert.IsNotNull(cachedPerson, "Cached item should not be null.");
		Assert.AreEqual(person.Id, cachedPerson.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_WithCustomTimeout_NullItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem<string>("testKey", null, TimeSpan.FromMinutes(30));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_WithCustomTimeout_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem<Person<Address>>(null, RandomData.GeneratePersonRef<Address>(), TimeSpan.FromMinutes(30));
	}


	[TestMethod]
	public void CacheProperty_CanAddAndRetrieveItem()
	{
		var cacheInstance = InMemoryCache.Instance;
		var testKey = "testKey";
		var testValue = "testValue";

		cacheInstance.Cache.Set(testKey, testValue, DateTimeOffset.Now.AddMinutes(5));
		var result = cacheInstance.Cache.Get<string>(testKey);

		Assert.AreEqual(testValue, result, "Should be able to add and retrieve an item using the Cache property.");

		cacheInstance.Clear(); // Cleanup after test
	}

	[TestMethod]
	public void CacheProperty_CanClearItems()
	{
		var cacheInstance = InMemoryCache.Instance;
		var testKey = "testKey";
		var testValue = "testValue";

		_ = cacheInstance.Cache.Set(testKey, testValue, DateTimeOffset.Now.AddMinutes(5));
		cacheInstance.Clear(); // Clearing the cache

		var result = cacheInstance.Cache.Get<string>(testKey);
		Assert.IsNull(result, "Cache should be empty after calling Clear method.");
	}

	[TestMethod]
	public void CacheProperty_IsNotNull()
	{
		var cacheInstance = InMemoryCache.Instance;
		Assert.IsNotNull(cacheInstance.Cache, "Cache property should not be null.");
	}

	[TestMethod]
	public void Count_DecreasesAfterClear()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear(); // Reset cache before test

		cache.AddCacheItem("testKey1", "testValue1");
		cache.AddCacheItem("testKey2", "testValue2");
		cache.Clear(); // Clear cache after adding items

		Assert.AreEqual(0, InMemoryCache.Count, "Cache count should be 0 after clearing the cache.");
	}

	[TestMethod]
	public void Count_IncreasesWithAddedItems()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear(); // Reset cache before test

		cache.AddCacheItem("testKey1", "testValue1");
		cache.AddCacheItem("testKey2", "testValue2");

		Assert.AreEqual(2, InMemoryCache.Count, "Cache count should increase as items are added.");
	}

	[TestMethod]
	public void Count_InitiallyZero()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear(); // Ensure cache is empty before test
		Assert.AreEqual(0, InMemoryCache.Count, "Cache count should be 0 initially.");
	}
	[TestMethod]
	public void CreateInstanceTest()
	{
		var result = InMemoryCache.Instance;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetCacheItem_InvalidKey_ReturnsNull()
	{
		var cache = InMemoryCache.Instance;
		var result = cache.GetCacheItem<Person<Address>>("invalidKey");

		Assert.IsNull(result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetCacheItem_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.GetCacheItem<Person<Address>>(null);
	}


	[TestMethod]
	public void GetCacheItem_ValidKey_ReturnsItem()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		cache.AddCacheItem(person.Id, person);

		var result = cache.GetCacheItem<Person<Address>>(person.Id);

		Assert.IsNotNull(result);
		Assert.AreEqual(person.Id, result.Id);

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public void Instance_AlwaysReturnsSameObject()
	{
		var instance1 = InMemoryCache.Instance;
		var instance2 = InMemoryCache.Instance;

		Assert.AreSame(instance1, instance2, "Multiple calls to InMemoryCache.Instance should return the same object instance.");
	}

}
