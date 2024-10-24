// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-13-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-03-2024
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
public sealed class InMemoryCache
{

	/// <summary>
	/// The default timeout duration for cache items, in minutes.
	/// </summary>
	/// <remarks>
	/// This value is used as the default expiration time for items added to the cache without a specified timeout.
	/// See <see cref="AddCacheItem{T}(string, T)"/> and <see cref="CreateCache"/> for how this value is applied.
	/// </remarks>
	private const int TimeoutMinutes = 20;

	/// <summary>
	/// Initializes a new instance of the <see cref="InMemoryCache"/> class. The cache is created with default settings.
	/// </summary>
	private InMemoryCache() => this.Cache = CreateCache();

	/// <summary>
	/// Creates the cache with a default configuration.
	/// </summary>
	/// <returns>A new instance of <see cref="MemoryCache"/> configured with a compaction percentage and a default expiration policy.</returns>
	/// <remarks>
	/// The cache is configured to compact by 50% when the size limit is exceeded. The default expiration time for each cache entry is set through the <see cref="TimeoutMinutes"/> constant.
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
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	/// <remarks>
	/// This method utilizes MemoryCache.Set to add the item to the cache with an absolute expiration time set through MemoryCacheEntryOptions.SetAbsoluteExpiration.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "1/16/2021", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public void AddCacheItem<T>([NotNull] string key, [NotNull] T item)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		var cacheEntryOptions = new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(TimeSpan.FromMinutes(TimeoutMinutes)); // Sets the item to expire 20 minutes from now

		_ = this.Cache.Set(key, item, cacheEntryOptions);
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
	[Information(nameof(AddCacheItem), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
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
	[Information(nameof(AddCacheItem), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
	public void AddCacheItem<T>([NotNull] string key, [NotNull] T item, DateTimeOffset timeout)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout));
	}

	/// <summary>
	/// Clears all items from the cache.
	/// </summary>
	/// <remarks>This method is intended to remove all items from the cache, effectively resetting it.
	/// Use with caution as this will remove all cached data.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clear), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
	public void Clear() => this.Cache.Compact(1.0);

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
	[Information(nameof(GetCacheItem), "David McCarter", "1/16/2021", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
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
