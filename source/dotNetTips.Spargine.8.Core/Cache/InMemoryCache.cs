// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-13-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2024
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
	private InMemoryCache() => this.Cache = CreateCache(new TimeSpan(0, TimeoutMinutes, 0));

	/// <summary>
	/// Creates the cache using 20 minute expiration.
	/// </summary>
	/// <param name="expiration">The expiration.</param>
	/// <returns>MemoryCache.</returns>
	private static MemoryCache CreateCache(TimeSpan expiration)
	{
		var options = new MemoryCacheOptions
		{
			ExpirationScanFrequency = expiration,
		};

		return new MemoryCache(options);
	}

	/// <summary>
	/// Adds item to the cache.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="key">The key.</param>
	/// <param name="item">The item.</param>
	/// <exception cref="ArgumentNullException">Key cannot be null or empty.</exception>
	/// <exception cref="ArgumentNullException">Item cannot be null.</exception>
	[Information(nameof(AddCacheItem), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public void AddCacheItem<T>(string key, [NotNull] T item)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item);
	}

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
