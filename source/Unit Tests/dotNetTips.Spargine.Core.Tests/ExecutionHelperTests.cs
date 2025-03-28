// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-28-2025
// ***********************************************************************
// <copyright file="ExecutionHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ExecutionHelperTests
{

	private const int RetryCount = 3;
	private const int RetryWait = 10;

	[TestMethod]
	public void ProgressiveRetryTest()
	{
		try
		{
			var result = ExecutionHelper.ProgressiveRetry(() =>
			  {
				  var drives = DriveHelper.GetRemovableDrives();
			  }, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

			Assert.IsTrue(result.Value > 0);
		}
		catch (Exception ex)
		{
			Assert.Fail($"Progressive retry failed: {ex.Message}.");
		}
	}

}
