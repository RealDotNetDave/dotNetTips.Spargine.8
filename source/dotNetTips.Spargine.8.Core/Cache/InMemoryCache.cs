// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-13-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2025
// ***********************************************************************
// <copyright file="InMemoryCache.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// MemoryCache with a default duration of 20 minutes for storing objects
// in memory.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Microsoft.Extensions.Caching.Memory;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Cache;

/// <summary>
/// Provides a simple in-memory cache with a default expiration time. This class cannot be inherited.
/// </summary>
/// <remarks>
/// <para>This cache is built on top of <see cref="MemoryCache"/> and provides a simplified interface for adding, retrieving, and managing cached items with default and custom expiration times.</para>
/// <para>The default expiration time for cached items is 20 minutes.</para>
/// </remarks>
/// <example>
/// Using the InMemoryCache to cache an object:
/// <code>
/// var cache = DotNetTips.Spargine.Core.Cache.InMemoryCache.Instance;
/// var myObject = new MyObject();
/// cache.AddCacheItem("myKey", myObject);
///
/// // Retrieve the cached item
/// var cachedObject = cache.GetCacheItem&lt;MyObject&gt;("myKey");
/// </code>
/// </example>
/// <seealso cref="AddCacheItem{T}(string, T)"/>
/// <seealso cref="AddCacheItem{T}(string, T, TimeSpan)"/>
/// <seealso cref="AddCacheItem{T}(string, T, DateTimeOffset)"/>
/// <seealso cref="GetCacheItem{T}(string)"/>
/// <seealso cref="Clear"/>
[SupportedOSPlatform("windows")]
[Information(Status = Status.NeedsDocumentation, Documentation = "")]
public sealed class InMemoryCache
{
	/// <summary>  
	/// The default timeout duration for cache items, in minutes.  
	/// </summary>  
	/// <remarks>  
	/// This value is used as the default expiration time for items added to the cache without a specified timeout.  
	/// See <see cref="AddCacheItem{T}(string, T)"/> and <see cref="CreateCache"/> for how this value is applied.  
	/// </remarks>  
	private readonly TimeSpan _timeoutInMinutes = TimeSpan.FromMinutes(20);

	/// <summary>
	/// Initializes a new instance of the <see cref="InMemoryCache"/> class. The cache is created with default settings.
	/// </summary>
	private InMemoryCache() => this.Cache = CreateCache();

	/// <summary>
	/// Creates the cache with a default configuration.
	/// </summary>
	/// <returns>A new instance of <see cref="MemoryCache"/> configured with a compaction percentage and a default expiration policy.</returns>
	/// <remarks>
	/// The cache is configured to compact by 50% when the size limit is exceeded. The default expiration time for each cache entry is set to 20 minutes.
	/// </remarks>
	private static MemoryCache CreateCache()
	{
		var options = new MemoryCacheOptions
		{
			CompactionPercentage = 0.5,
		};

		return new MemoryCache(options);
	}

	/// <summary>
	/// Adds an item to the cache with a timeout of 20 minutes.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <typeparam name="TKey">The type of the identifier for the data model.</typeparam>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataModel{T, TKey}"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public void AddCacheItem<T, TKey>([NotNull] IDataModel<T, TKey> item)
	{
		item = item.ArgumentNotNull();


		_ = this.Cache.Set(item.Id.ToString(), item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(this._timeoutInMinutes));
	}

	/// <summary>
	/// Adds an item to the cache with a timeout of 20 minutes.
	/// </summary>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataRecord"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public void AddCacheItem([NotNull] IDataRecord item)
	{
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(item.Id.ToString(), item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(this._timeoutInMinutes));
	}

	/// <summary>
	/// Adds an item to the cache with a timeout of 20 minutes.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "1/16/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void AddCacheItem<T>([NotNull] string key, [NotNull] T item)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(this._timeoutInMinutes));
	}

	/// <summary>
	/// Adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <typeparam name="TKey">The type of the identifier for the data model.</typeparam>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataModel{T, TKey}"/>.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public void AddCacheItem<T, TKey>([NotNull] IDataModel<T, TKey> item, DateTimeOffset timeout)
	{
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(item.Id.ToString(), item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout));
	}

	/// <summary>
	/// Adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataRecord"/>.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public void AddCacheItem([NotNull] IDataRecord item, DateTimeOffset timeout)
	{
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(item.Id.ToString(), item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout));
	}

	/// <summary>
	/// Adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <typeparam name="TKey">The type of the identifier for the data model.</typeparam>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataModel{T, TKey}"/>.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public void AddCacheItem<T, TKey>([NotNull] IDataModel<T, TKey> item, TimeSpan timeout)
	{
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(item.Id.ToString(), item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout));
	}

	/// <summary>
	/// Adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataRecord"/>.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public void AddCacheItem([NotNull] IDataRecord item, TimeSpan timeout)
	{
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(item.Id.ToString(), item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout));
	}

	/// <summary>
	/// Adds an item to the cache with a custom timeout.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="timeout">The custom timeout for the cache item.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key" /> is null or empty, or <paramref name="item" /> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void AddCacheItem<T>([NotNull] string key, [NotNull] T item, TimeSpan timeout)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout));
	}

	/// <summary>
	/// Adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key" /> is null or empty, or <paramref name="item" /> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void AddCacheItem<T>([NotNull] string key, [NotNull] T item, DateTimeOffset timeout)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout));
	}

	/// <summary>
	/// Asynchronously adds an item to the cache with a timeout of 20 minutes.
	/// </summary>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataRecord"/>.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync([NotNull] IDataRecord item, CancellationToken cancellationToken = default) => Task.Run(() => this.AddCacheItem(item), cancellationToken);

	/// <summary>
	/// Asynchronously adds an item to the cache with a timeout of 20 minutes.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <typeparam name="TKey">The type of the identifier for the data model.</typeparam>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataModel{T, TKey}"/>.</param>
	/// <param name="cancelationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync<T, TKey>([NotNull] IDataModel<T, TKey> item, CancellationToken cancelationToken = default) => Task.Run(() => this.AddCacheItem(item), cancelationToken);

	/// <summary>
	/// Asynchronously adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataRecord"/>.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync([NotNull] IDataRecord item, DateTimeOffset timeout, CancellationToken cancellationToken = default) => Task.Run(() => this.AddCacheItem(item, timeout), cancellationToken);

	/// <summary>
	/// Asynchronously adds an item to the cache with a timeout of 20 minutes.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync<T>([NotNull] string key, [NotNull] T item, CancellationToken cancellationToken = default) => Task.Run(() => this.AddCacheItem(key, item), cancellationToken);

	/// <summary>
	/// Asynchronously adds an item to the cache with a custom timeout.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <typeparam name="TKey">The type of the identifier for the data model.</typeparam>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataModel{T, TKey}"/>.</param>
	/// <param name="timeout">The custom timeout for the cache item.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync<T, TKey>([NotNull] IDataModel<T, TKey> item, TimeSpan timeout, CancellationToken cancellationToken = default) => Task.Run(() => this.AddCacheItem(item, timeout), cancellationToken);

	/// <summary>
	/// Asynchronously adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataRecord"/>.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync([NotNull] IDataRecord item, TimeSpan timeout, CancellationToken cancellationToken = default) => Task.Run(() => this.AddCacheItem(item, timeout), cancellationToken);

	/// <summary>
	/// Asynchronously adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <typeparam name="TKey">The type of the identifier for the data model.</typeparam>
	/// <param name="item">The item to add to the cache. This must implement <see cref="IDataModel{T, TKey}"/>.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync<T, TKey>([NotNull] IDataModel<T, TKey> item, DateTimeOffset timeout, CancellationToken cancellationToken = default) => Task.Run(() => this.AddCacheItem(item, timeout), cancellationToken);

	/// <summary>
	/// Asynchronously adds an item to the cache with a custom timeout.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="timeout">The custom timeout for the cache item.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync<T>([NotNull] string key, [NotNull] T item, TimeSpan timeout, CancellationToken cancellationToken = default) => Task.Run(() => this.AddCacheItem(key, item, timeout), cancellationToken);

	/// <summary>
	/// Asynchronously adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task AddCacheItemAsync<T>([NotNull] string key, [NotNull] T item, DateTimeOffset timeout, CancellationToken cancellationToken = default) => Task.Run(() => this.AddCacheItem(key, item, timeout), cancellationToken);

	/// <summary>
	/// Clears all items from the cache.
	/// </summary>
	/// <remarks>This method is intended to remove all items from the cache, effectively resetting it.
	/// Use with caution as this will remove all cached data.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clear), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void Clear() => this.Cache.Compact(1.0);

	/// <summary>
	/// Determines whether the cache contains an item with the specified key.
	/// </summary>
	/// <param name="key">The key of the item to locate in the cache.</param>
	/// <returns><c>true</c> if the cache contains an item with the specified key; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	[Information(nameof(ContainsKey), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public bool ContainsKey([NotNull] string key)
	{
		key = key.ArgumentNotNullOrEmpty();
		return this.Cache.TryGetValue(key, out _);
	}

	/// <summary>
	/// Gets all keys currently stored in the cache.
	/// </summary>
	/// <returns>An enumerable collection of keys in the cache.</returns>
	/// <remarks>
	/// This method provides a way to retrieve all keys currently stored in the cache. It can be useful for debugging and monitoring purposes.
	/// </remarks>
	[Information(nameof(GetAllKeys), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public IEnumerable<string> GetAllKeys() => this.Cache.Keys.Select(p => p.ToString());

	/// <summary>
	/// Gets the cache item associated with the specified key.
	/// </summary>
	/// <typeparam name="T">The type of the item stored in the cache.</typeparam>
	/// <param name="key">The key of the item to retrieve from the cache.</param>
	/// <returns>The item of type <typeparamref name="T"/> if found; otherwise, the default value of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	/// <remarks>
	/// Retrieves an item from the cache using the specified key. If the item is found, it is returned; otherwise, the default value for type <typeparamref name="T"/> is returned.
	/// This method utilizes the <see cref="MemoryCache.TryGetValue"/> method to attempt to retrieve the item.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(GetCacheItem), "David McCarter", "1/16/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public T GetCacheItem<T>([NotNull] string key)
	{
		key = key.ArgumentNotNullOrEmpty();

		if (this.Cache.TryGetValue(key, out T item))
		{
			return item;
		}

		return default!;
	}

	/// <summary>
	/// Asynchronously gets the cache item associated with the specified key.
	/// </summary>
	/// <typeparam name="T">The type of the item stored in the cache.</typeparam>
	/// <param name="key">The key of the item to retrieve from the cache.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the item of type <typeparamref name="T"/> if found; otherwise, the default value of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	/// <remarks>
	/// Retrieves an item from the cache using the specified key asynchronously. If the item is found, it is returned; otherwise, the default value for type <typeparamref name="T"/> is returned.
	/// This method utilizes the <see cref="MemoryCache.TryGetValue"/> method to attempt to retrieve the item.
	/// </remarks>
	[Information(nameof(GetCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public Task<T> GetCacheItemAsync<T>([NotNull] string key, CancellationToken cancellationToken = default) => Task.Run(() => this.GetCacheItem<T>(key), cancellationToken);

	/// <summary>
	/// Removes the cache item associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the item to remove from the cache.</param>
	/// <returns><c>true</c> if the item is successfully removed; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	[Information(nameof(RemoveCacheItem), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public bool RemoveCacheItem([NotNull] string key)
	{
		key = key.ArgumentNotNullOrEmpty();

		if (this.Cache.TryGetValue(key, out _))
		{
			this.Cache.Remove(key);
			return true;
		}

		return false;
	}

	/// <summary>
	/// Gets the <see cref="MemoryCache"/> instance used by the <see cref="InMemoryCache"/>.
	/// </summary>
	/// <value>The <see cref="MemoryCache"/> instance.</value>
	/// <remarks>
	/// This property exposes the underlying <see cref="MemoryCache"/> used by the <see cref="InMemoryCache"/> class to store cached items.
	/// </remarks>
	[NotNull]
	[Information(nameof(Cache), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public MemoryCache Cache { get; }

	/// <summary>
	/// Gets the count of items currently stored in the cache.
	/// </summary>
	/// <value>The count of items in the cache.</value>
	/// <remarks>
	/// This property provides the total number of items currently stored in the cache. It accesses the <see cref="MemoryCache.Count"/> property of the underlying <see cref="MemoryCache"/> instance used by the <see cref="InMemoryCache"/>.
	/// </remarks>
	[Pure]
	[Information(nameof(Count), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public static int Count
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Instance.Cache.Count;
	}

	/// <summary>
	/// Gets the singleton instance of <see cref="InMemoryCache"/>.
	/// </summary>
	/// <value>The singleton instance of the <see cref="InMemoryCache"/> class.</value>
	/// <remarks>
	/// This property provides a global access point to the single instance of the <see cref="InMemoryCache"/> class, ensuring that only one instance is used throughout the application.
	/// </remarks>
	[NotNull]
	[Information(nameof(Instance), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public static InMemoryCache Instance { get; } = new();

}
