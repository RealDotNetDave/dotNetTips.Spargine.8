// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2023
// ***********************************************************************
// <copyright file="HttpEventListenerTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Network;
using DotNetTips.Spargine.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Core.Tests.Network;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpEventListenersTests
{

	private readonly HttpClient _httpClient = new();
	private readonly ILogger _logger = new NullLogger<HttpEventListenersTests>();

	[TestCleanup]
	public void Cleanup()
	{
		this._httpClient.TryDispose();
	}

	[TestMethod]
	public async Task HttpEventListenerAsyncLocalTest()
	{
		try
		{
			using (var listener = new HttpEventListenerAsyncLocal(this._logger))
			{
				_ = await this._httpClient.GetStringAsync("https://c-sharpcorner.com");
			}
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public async Task HttpEventListenerTest()
	{
		try
		{
			using (var listener = new HttpEventListener(this._logger))
			{
				_ = await this._httpClient.GetStringAsync("https://c-sharpcorner.com");
			}
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public async Task HttpRequestsObserverTest()
	{
		try
		{
			using (var observer = new HttpRequestsObserver(this._logger))
			{
				using (DiagnosticListener.AllListeners.Subscribe(observer))
				{
					_ = await this._httpClient.GetStringAsync("https://c-sharpcorner.com");
				}
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.Message);

			Assert.Fail();
		}
	}

}
