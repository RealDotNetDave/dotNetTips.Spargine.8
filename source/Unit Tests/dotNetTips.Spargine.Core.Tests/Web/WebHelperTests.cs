// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-10-2024
// ***********************************************************************
// <copyright file="WebHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Web;

[ExcludeFromCodeCoverage]
[TestClass]
public class WebHelperTests
{

	[TestMethod]
	public void DownloadStringAsyncTest()
	{
		var result = WebHelper.DownloadStringAsync(new Uri(@"https://dotnettips.com"), clientId: "UNITTEST1").GetAwaiter().GetResult;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void DownloadStringTest()
	{
		var result = WebHelper.DownloadStringAsync(new Uri(@"https://www.google.com/"), clientId: "UNITTEST2").GetAwaiter().GetResult();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}
	[TestMethod]
	public void IsLocalUri_WithLocalAbsoluteUri_ReturnsTrue()
	{
		var request = new DefaultHttpContext().Request;
		request.Host = new HostString("localhost");

		var result = WebHelper.IsLocalUri("http://localhost/home", request);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsLocalUri_WithLocalRelativeUri_ReturnsTrue()
	{
		var request = new DefaultHttpContext().Request;
		// Assuming the request host is set to a default or specific value in the actual test environment setup.

		var result = WebHelper.IsLocalUri("/home", request);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsLocalUri_WithNonLocalAbsoluteUri_ReturnsFalse()
	{
		var request = new DefaultHttpContext().Request;
		request.Host = new HostString("localhost");

		var result = WebHelper.IsLocalUri("http://www.example.com/home", request);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsLocalUri_WithNonLocalRelativeUri_ReturnsFalse()
	{
		var request = new DefaultHttpContext().Request;
		// Assuming the request host is set to a default or specific value in the actual test environment setup.

		var result = WebHelper.IsLocalUri("http://www.example.com/home", request);

		Assert.IsFalse(result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void IsLocalUri_WithNullPath_ThrowsArgumentNullException()
	{
		var request = new DefaultHttpContext().Request;

		WebHelper.IsLocalUri(null, request);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void IsLocalUri_WithNullRequest_ThrowsArgumentNullException()
	{
		WebHelper.IsLocalUri("/home", null);
	}

}
