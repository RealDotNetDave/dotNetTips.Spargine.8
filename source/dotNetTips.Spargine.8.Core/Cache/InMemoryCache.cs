// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-13-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-19-2024
// ***********************************************************************
// <copyright file="InMemoryCache.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// MemoryCache with a default duration of 20 minutes for storing objects
// in memory.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Caching.Memory;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Cache;

/// <summary>
/// InMemoryCache.
/// </summary>
/// <remarks>Expiration is set to 20 minutes.</remarks>
public sealed class InMemoryCache
{

	/// <summary>
	/// The timeout amount.
	/// </summary>
	private const int TimeoutMinutes = 20;

	/// <summary>
	/// Prevents a default instance of the <see cref="InMemoryCache" /> class from being created.
	/// Default timeout is 20 minutes.
	/// </summary>
	private InMemoryCache() => this.Cache = CreateCache();

	/// <summary>
	/// Creates the cache using 20 minute expiration.
	/// </summary>
	/// <returns>MemoryCache.</returns>
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
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key" /> is null or empty, or <paramref name="item" /> is null.</exception>
	[Information(nameof(AddCacheItem), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
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

	[Information(nameof(AddCacheItem), "David McCarter", "6/12/2024", Status = Status.New, UnitTestCoverage = 0)]
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

	[Information(nameof(AddCacheItem), "David McCarter", "6/12/2024", Status = Status.New, UnitTestCoverage = 0)]
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
	[Information(nameof(Clear), "David McCarter", "6/12/2024", Status = Status.New, UnitTestCoverage = 0)]
	public void Clear() => this.Cache.Clear();

	/// <summary>
	/// Gets the cache item.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="key">The key.</param>
	/// <returns>TValue.</returns>
	[Information(nameof(GetCacheItem), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public T GetCacheItem<T>(string key)
	{
		if (this.Cache.TryGetValue(key, out T item))
		{
			return item;
		}

		return default!;
	}

	/// <summary>
	/// Gets or sets (private) the cache.
	/// </summary>
	/// <value>The cache.</value>
	[Information(nameof(Cache), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public MemoryCache Cache { get; }

	/// <summary>
	/// Gets the count.
	/// </summary>
	/// <value>The count.</value>
	[Information(nameof(Count), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public static int Count => Instance.Cache.Count;

	/// <summary>
	/// Gets the instance.
	/// </summary>
	/// <value>The instance.</value>
	[Information(nameof(Instance), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public static InMemoryCache Instance { get; } = new();

}
