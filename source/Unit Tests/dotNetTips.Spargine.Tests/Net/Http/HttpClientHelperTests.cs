// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2025
// ***********************************************************************
// <copyright file="HttpClientHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;
using DotNetTips.Spargine.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.Net.Http;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpClientHelperTests
{

	[TestMethod]
	public async Task GetHttpResponseAsync_InvalidUrl_ThrowsHttpRequestException()
	{
		// Arrange
		var url = new Uri("https://thisurldoesnotexist123456789.com");

		// Act & Assert
		await Assert.ThrowsExceptionAsync<HttpRequestException>(async () =>
		{
			await HttpClientHelper.GetHttpResponseAsync(url);
		});
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task GetHttpResponseAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		Uri url = null;

		// Act
		await HttpClientHelper.GetHttpResponseAsync(url);

		// Assert is handled by the ExpectedException attribute
	}

	[TestMethod]
	public async Task GetHttpResponseAsync_UrlNotFound_ThrowsInvalidOperationException()
	{
		// Arrange
		var url = new Uri("https://httpbin.org/status/404");

		// Act & Assert
		await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
		{
			await HttpClientHelper.GetHttpResponseAsync(url);
		});
	}


	[TestMethod]
	public async Task GetHttpResponseAsync_ValidUrl_ReturnsSuccessStatusCode()
	{
		// Arrange
		var url = new Uri("https://httpbin.org/get");

		// Act
		var response = await HttpClientHelper.GetHttpResponseAsync(url);

		// Assert
		Assert.IsNotNull(response);
		Assert.IsTrue(response.IsSuccessStatusCode);
	}

	[TestMethod]
	public async Task GetStreamAsync_InvalidUrl_ThrowsHttpRequestException()
	{
		// Arrange
		var url = new Uri("https://thisurldoesnotexist123456789.com");

		// Act & Assert
		await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
		{
			await HttpClientHelper.GetStreamAsync(url);
		});
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task GetStreamAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		Uri url = null;

		// Act
		await HttpClientHelper.GetStreamAsync(url);

		// Assert is handled by the ExpectedException attribute
	}

	[TestMethod]
	public async Task GetStreamAsync_UrlNotFound_ThrowsInvalidOperationException()
	{
		// Arrange
		var url = new Uri("https://httpbin.org/status/404");

		// Act & Assert
		await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
		{
			await HttpClientHelper.GetStreamAsync(url);
		});
	}
	[TestMethod]
	public async Task GetStreamAsync_ValidUrl_ReturnsStream()
	{
		// Arrange
		var url = new Uri("https://httpbin.org/stream/1");

		// Act
		var stream = await HttpClientHelper.GetStreamAsync(url);

		// Assert
		Assert.IsNotNull(stream);
		Assert.IsTrue(stream.CanRead);
	}

}
