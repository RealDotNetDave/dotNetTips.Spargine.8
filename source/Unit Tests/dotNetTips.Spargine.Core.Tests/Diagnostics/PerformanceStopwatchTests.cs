// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 08-09-2023
// ***********************************************************************
// <copyright file="PerformanceStopwatchTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using DotNetTips.Spargine.Core.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Diagnostics;
[ExcludeFromCodeCoverage]
[TestClass]
public class PerformanceStopwatchTests
{

	private readonly ILogger _logger = new NullLogger<PerformanceStopwatchTests>();

	[TestMethod]
	public void DiagnosticsLogTest()
	{
		var psw = PerformanceStopwatch.StartNew(title: "GetUsers()");
		var currentTime = DateTime.UtcNow;

		Thread.Sleep(1000);

		var result = psw.StopRestart(this._logger, "Load users from database.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));

		Thread.Sleep(1000);

		result = psw.StopRestart(logger: this._logger, message: "Save users to database.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));

		Assert.IsNotNull(psw.Diagnostics);

		Assert.IsNotNull(psw.ToString());
	}

	[TestMethod]
	public void StartNewTest()
	{
		var psw = PerformanceStopwatch.StartNew();

		Assert.IsNotNull(psw);
	}

	[TestMethod]
	public void StopResetLogTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(StopResetLogTest));
		var currentTime = DateTime.UtcNow;

		Thread.Sleep(1000);

		var result = psw.StopReset(this._logger, "Call to Database.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopResetTest()
	{
		var psw = PerformanceStopwatch.StartNew();
		var currentTime = DateTime.UtcNow;

		Thread.Sleep(1000);

		var result = psw.StopReset();

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopRestartLogTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(StopRestartLogTest));
		var currentTime = DateTime.UtcNow;

		Thread.Sleep(1000);

		var result = psw.StopRestart(this._logger, "Call to database #2.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopRestartTest()
	{
		var psw = PerformanceStopwatch.StartNew();
		var currentTime = DateTime.UtcNow;

		Thread.Sleep(1000);

		var result = psw.StopRestart();

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

}
