// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-05-2025
// ***********************************************************************
// <copyright file="ChannelQueueCollectionBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading;

/// <summary>
/// Collection type PerfTestRunner.
/// </summary>
[BenchmarkCategory(Categories.Async)]
public class ChannelQueueCollectionBenchmark : SmallCollectionBenchmark
{

	/// <summary>
	/// The person reference array
	/// </summary>
	private Person<Address>[] _personRefArray;

	/// <summary>
	/// Add to queue as an asynchronous operation.
	/// </summary>
	/// <param name="channel">The channel.</param>
	/// <param name="people">The people.</param>
	/// <param name="token">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A Task representing the asynchronous operation.</returns>
	private static async Task AddToQueueAsync(ChannelQueue<Person<Address>> channel, IList<Person<Address>> people, CancellationToken token)
	{
		foreach (var person in people)
		{
			await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
		}

		_ = channel.Lock();
	}

	/// <summary>
	/// Listen to queue as an asynchronous operation.
	/// </summary>
	/// <param name="channel">The channel.</param>
	/// <param name="token">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A Task representing the asynchronous operation.</returns>
	private static async Task ListenToQueueAsync(ChannelQueue<Person<Address>> channel, CancellationToken token)
	{
		await foreach (var item in channel.ListenAsync(token).ConfigureAwait(false))
		{
			Trace.WriteLine(item.Email);
		}
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefArray = this.GetPersonRefArray();
	}

	/// <summary>
	/// Write as an asynchronous operation.
	/// </summary>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[Benchmark(Description = "WriteAsync")]
	[BenchmarkCategory(Categories.Async)]
	public async Task WriteAsync()
	{
		var channel = new ChannelQueue<Person<Address>>();
		var people = this._personRefArray;

		for (var peopleCount = 0; peopleCount < people.Length; peopleCount++)
		{
			await channel.WriteAsync(people[peopleCount]).ConfigureAwait(false);
		}

		await this.ConsumeAsync(channel.Count).ConfigureAwait(false);
	}

	/// <summary>
	/// Write asynchronous i enumerable as an asynchronous operation.
	/// </summary>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[Benchmark(Description = "WriteAsync: IEnumerable")]
	[BenchmarkCategory(Categories.Async)]
	public async Task WriteAsyncIEnumerableAsync()
	{
		var channel = new ChannelQueue<Person<Address>>();
		var people = this._personRefArray;

		await channel.WriteAsync(people).ConfigureAwait(false);

		await this.ConsumeAsync(channel.Count).ConfigureAwait(false);
	}

	/// <summary>
	/// Writes the listen asynchronous test.
	/// </summary>
	[Benchmark(Description = "Write & Listen Async")]
	[BenchmarkCategory(Categories.Async)]
	public void WriteListenAsyncTest()
	{
		var channel = new ChannelQueue<Person<Address>>();
		var people = this._personRefArray;
		var token = CancellationToken.None;

		var tasks = new List<Task>
		{
			AddToQueueAsync(channel, people, token),
			ListenToQueueAsync(channel, token)
		};

		Task.WaitAll([.. tasks]);

		this.Consume(channel.Count);
	}

	/// <summary>
	/// Write read as an asynchronous operation.
	/// </summary>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[Benchmark(Description = "Write & Read Async")]
	[BenchmarkCategory(Categories.Async)]
	public async Task WriteReadAsync()
	{
		var channel = new ChannelQueue<Person<Address>>();
		var people = this._personRefArray;

		for (var personCount = 0; personCount < people.Length; personCount++)
		{
			await channel.WriteAsync(people[personCount]).ConfigureAwait(false);
		}

		while (channel.Count > 0)
		{
			await this.ConsumeAsync(await channel.ReadAsync().ConfigureAwait(false)).ConfigureAwait(false);
		}
	}

	[Benchmark(Description = "Write & Read Async: IEnumerable")]
	[BenchmarkCategory(Categories.Async)]
	public async Task WriteReadAsyncIEnumerableAsync()
	{
		var channel = new ChannelQueue<Person<Address>>();
		var people = this._personRefArray;

		await channel.WriteAsync(people).ConfigureAwait(false);

		while (channel.Count > 0)
		{
			await this.ConsumeAsync(await channel.ReadAsync().ConfigureAwait(false)).ConfigureAwait(false);
		}
	}

}
