// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2025
// ***********************************************************************
// <copyright file="InMemoryCacheTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

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
	public void AddCacheItem_NullIDataModelItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem<IDataModel<string, string>, string>(null);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_NullIDataRecordItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem(null as IDataRecord);
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
	public void AddCacheItem_ValidIDataModelItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var item = RandomData.GeneratePersonRef<Address>();

		cache.AddCacheItem<Person<Address>, string>(item);

		var cachedItem = cache.GetCacheItem<Person<Address>>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public void AddCacheItem_ValidIDataRecordItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var item = RandomData.GeneratePersonRef<Address>();

		cache.AddCacheItem<Person<Address>, string>(item);

		var cachedItem = cache.GetCacheItem<Person<Address>>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
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
	public void AddCacheItem_WithCustomExpirationDateTime_NullIDataModelItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		cache.AddCacheItem<IDataModel<string, string>, string>(null, futureDate);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_WithCustomExpirationDateTime_NullIDataRecordItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		cache.AddCacheItem(null as IDataRecord, futureDate);
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
	public void AddCacheItem_WithCustomExpirationDateTime_ValidIDataModelItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		var item = RandomData.GeneratePersonRef<Address>();

		cache.AddCacheItem<Person<Address>, string>(item);

		var cachedItem = cache.GetCacheItem<Person<Address>>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public void AddCacheItem_WithCustomExpirationDateTime_ValidIDataRecordItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		var item = RandomData.GeneratePersonRef<Address>();

		cache.AddCacheItem<Person<Address>, string>(item);

		var cachedItem = cache.GetCacheItem<Person<Address>>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
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
	public void AddCacheItem_WithCustomTimeout_NullIDataModelItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem<IDataModel<string, string>, string>(null, TimeSpan.FromMinutes(30));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void AddCacheItem_WithCustomTimeout_NullIDataRecordItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.AddCacheItem(null as IDataRecord, TimeSpan.FromMinutes(30));
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
	public void AddCacheItem_WithCustomTimeout_ValidIDataModelItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var timeout = TimeSpan.FromMinutes(30);
		var item = RandomData.GeneratePersonRef<Address>();

		cache.AddCacheItem<Person<Address>, string>(item);

		var cachedItem = cache.GetCacheItem<Person<Address>>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public void AddCacheItem_WithCustomTimeout_ValidIDataRecordItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var timeout = TimeSpan.FromMinutes(30);
		var item = RandomData.GeneratePersonRef<Address>();

		cache.AddCacheItem<Person<Address>, string>(item);

		var cachedItem = cache.GetCacheItem<Person<Address>>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	// Add the following code to the existing test file: source/Unit Tests/dotNetTips.Spargine.Core.Tests/Cache/InMemoryCacheTests.cs

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_NullIDataModelItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.AddCacheItemAsync<IDataModel<string, string>, string>(null);
	}


	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_NullIDataRecordItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.AddCacheItemAsync(null as IDataRecord);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_NullItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.AddCacheItemAsync<string>("testKey", null);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.AddCacheItemAsync<Person<Address>>(null, RandomData.GeneratePersonRef<Address>());
	}

	[TestMethod]
	public async Task AddCacheItemAsync_ValidIDataRecordItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var item = RandomData.GeneratePersonRecord();

		await cache.AddCacheItemAsync(item);

		var cachedItem = cache.GetCacheItem<PersonRecord>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public async Task AddCacheItemAsync_ValidKeyAndItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		await cache.AddCacheItemAsync(person.Id, person);

		var cachedPerson = cache.GetCacheItem<Person<Address>>(person.Id);

		Assert.IsNotNull(cachedPerson);
		Assert.AreEqual(person.Id, cachedPerson.Id);
		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomExpirationDateTime_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		var futureDate = DateTimeOffset.Now.AddMinutes(30); // Custom expiration date

		await cache.AddCacheItemAsync(person.Id, person, futureDate);

		var cachedPerson = cache.GetCacheItem<Person<Address>>(person.Id);

		Assert.IsNotNull(cachedPerson, "Cached item should not be null.");
		Assert.AreEqual(person.Id, cachedPerson.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_WithCustomExpirationDateTime_NullIDataModelItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		await cache.AddCacheItemAsync<IDataModel<string, string>, string>(null, futureDate);
	}


	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_WithCustomExpirationDateTime_NullIDataRecordItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		await cache.AddCacheItemAsync(null as IDataRecord, futureDate);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_WithCustomExpirationDateTime_NullItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		await cache.AddCacheItemAsync<string>("testKey", null, futureDate);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_WithCustomExpirationDateTime_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);
		await cache.AddCacheItemAsync<Person<Address>>(null, RandomData.GeneratePersonRef<Address>(), futureDate);
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomExpirationDateTime_ValidIDataRecordItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var item = RandomData.GeneratePersonRecord();
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		await cache.AddCacheItemAsync(item, futureDate);

		var cachedItem = cache.GetCacheItem<PersonRecord>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomTimeout_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		var timeout = TimeSpan.FromMinutes(30); // Custom timeout

		await cache.AddCacheItemAsync(person.Id, person, timeout);

		var cachedPerson = cache.GetCacheItem<Person<Address>>(person.Id);

		Assert.IsNotNull(cachedPerson, "Cached item should not be null.");
		Assert.AreEqual(person.Id, cachedPerson.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_WithCustomTimeout_NullIDataModelItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.AddCacheItemAsync<IDataModel<string, string>, string>(null, TimeSpan.FromMinutes(30));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_WithCustomTimeout_NullIDataRecordItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.AddCacheItemAsync(null as IDataRecord, TimeSpan.FromMinutes(30));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_WithCustomTimeout_NullItem_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.AddCacheItemAsync<string>("testKey", null, TimeSpan.FromMinutes(30));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task AddCacheItemAsync_WithCustomTimeout_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.AddCacheItemAsync<Person<Address>>(null, RandomData.GeneratePersonRef<Address>(), TimeSpan.FromMinutes(30));
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomTimeout_ValidIDataRecordItem_ItemAdded()
	{
		var cache = InMemoryCache.Instance;
		var item = RandomData.GeneratePersonRecord();
		var timeout = TimeSpan.FromMinutes(30);

		await cache.AddCacheItemAsync(item, timeout);

		var cachedItem = cache.GetCacheItem<PersonRecord>(item.Id);

		Assert.IsNotNull(cachedItem, "Cached item should not be null.");
		Assert.AreEqual(item.Id, cachedItem.Id, "Cached item ID should match the original item's ID.");

		cache.Clear(); // Cleanup after test
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
	public void ContainsKey_InvalidKey_ReturnsFalse()
	{
		var cache = InMemoryCache.Instance;
		var contains = cache.ContainsKey("invalidKey");

		Assert.IsFalse(contains, "Cache should not contain an item with an invalid key.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ContainsKey_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.ContainsKey(null);
	}

	[TestMethod]
	public void ContainsKey_ValidKey_ReturnsTrue()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		cache.AddCacheItem(person.Id, person);

		var contains = cache.ContainsKey(person.Id);

		Assert.IsTrue(contains, "Cache should contain the item with the specified key.");

		cache.Clear(); // Cleanup after test
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
	public void GetAllKeys_ReturnsAllKeys()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear(); // Ensure cache is empty before test

		var person1 = RandomData.GeneratePersonRef<Address>();
		var person2 = RandomData.GeneratePersonRef<Address>();
		cache.AddCacheItem(person1.Id, person1);
		cache.AddCacheItem(person2.Id, person2);

		var keys = cache.GetAllKeys().ToList();

		Assert.AreEqual(2, keys.Count, "Cache should contain two keys.");
		Assert.IsTrue(keys.Contains(person1.Id), "Cache should contain the first key.");
		Assert.IsTrue(keys.Contains(person2.Id), "Cache should contain the second key.");

		cache.Clear(); // Cleanup after test
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
	public async Task GetCacheItemAsync_InvalidKey_ReturnsNull()
	{
		var cache = InMemoryCache.Instance;
		var result = await cache.GetCacheItemAsync<Person<Address>>("invalidKey");

		Assert.IsNull(result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task GetCacheItemAsync_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		await cache.GetCacheItemAsync<Person<Address>>(null);
	}

	[TestMethod]
	public async Task GetCacheItemAsync_ValidKey_ReturnsItem()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		cache.AddCacheItem(person.Id, person);

		var result = await cache.GetCacheItemAsync<Person<Address>>(person.Id);

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

	[TestMethod]
	public void RemoveCacheItem_InvalidKey_ReturnsFalse()
	{
		var cache = InMemoryCache.Instance;
		var removed = cache.RemoveCacheItem("invalidKey");

		Assert.IsFalse(removed, "Removing an item with an invalid key should return false.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void RemoveCacheItem_NullKey_ThrowsArgumentNullException()
	{
		var cache = InMemoryCache.Instance;
		cache.RemoveCacheItem(null);
	}

	[TestMethod]
	public void RemoveCacheItem_ValidKey_ItemRemoved()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePersonRef<Address>();
		cache.AddCacheItem(person.Id, person);

		var removed = cache.RemoveCacheItem(person.Id);

		Assert.IsTrue(removed, "Item should be removed from the cache.");
		var cachedPerson = cache.GetCacheItem<Person<Address>>(person.Id);
		Assert.IsNull(cachedPerson, "Cached item should be null after removal.");

		cache.Clear(); // Cleanup after test
	}

}
