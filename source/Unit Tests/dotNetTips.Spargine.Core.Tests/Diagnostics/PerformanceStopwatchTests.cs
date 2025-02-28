// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-28-2025
// ***********************************************************************
// <copyright file="PerformanceStopwatchTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading;
using DotNetTips.Spargine.Core.Devices;
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
	public void ClearDiagnosticsTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.ClearDiagnosticsTest));

		Thread.Sleep(500);

		psw.StopReset(this._logger, "Test message 1");
		psw.StopReset(this._logger, "Test message 2");

		Assert.IsTrue(psw.Diagnostics.Count > 0);

		psw.ClearDiagnostics();

		Assert.AreEqual(0, psw.Diagnostics.Count);
	}

	[TestMethod]
	public void ConstructorWithoutTitleTest()
	{
		var psw = new PerformanceStopwatch();

		Assert.AreEqual(string.Empty, psw.Title);
	}

	[TestMethod]
	public void ConstructorWithTitleTest()
	{
		var title = "TestTitle";
		var psw = new PerformanceStopwatch(title);

		Assert.AreEqual(title, psw.Title);
	}

	[TestMethod]
	public void CreateMessageTest()
	{
		var psw = new PerformanceStopwatch("TestTitle");
		var message = "TestMessage";
		var elapsed = new TimeSpan(0, 0, 1); // 1 second

		var result = psw.GetType().GetMethod("CreateMessage", BindingFlags.NonPublic | BindingFlags.Instance)
			.Invoke(psw, new object[] { message, elapsed }) as string;

		Assert.IsTrue(result.Contains("TestTitle"));
		Assert.IsTrue(result.Contains("TestMessage"));
		Assert.IsTrue(result.Contains("Time: 1000 ms"));
	}


	[TestMethod]
	public void DiagnosticsLogTest()
	{
		var psw = PerformanceStopwatch.StartNew(title: nameof(this.DiagnosticsLogTest));
		var currentTime = Clock.UtcTime;

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
	public void DiagnosticsTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.DiagnosticsTest));

		Thread.Sleep(500);

		psw.StopReset(this._logger, "Test message");

		var diagnostics = psw.Diagnostics;

		Assert.IsTrue(diagnostics.Count > 0);
		Assert.IsTrue(diagnostics[0].Contains("Test message"));
	}

	[TestMethod]
	public void GetElapsedTimeStringTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.GetElapsedTimeStringTest));

		Thread.Sleep(500);

		var elapsedTimeString = psw.GetElapsedTimeString();

		Assert.IsTrue(elapsedTimeString.StartsWith("Elapsed Time:"));
	}

	[TestMethod]
	public void LogMessageTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.LogMessageTest));

		Thread.Sleep(500);

		psw.LogMessage(this._logger, "Intermediate log message");

		Assert.IsTrue(psw.Diagnostics.Count > 0);
		Assert.IsTrue(psw.Diagnostics[0].Contains("Intermediate log message"));
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
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopResetLogTest));
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopReset(this._logger, "Call to Database.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopResetTest()
	{
		var psw = PerformanceStopwatch.StartNew();
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopReset();

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopRestartLogTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.StopRestartLogTest));
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopRestart(this._logger, "Call to database #2.");

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void StopRestartTest()
	{
		var psw = PerformanceStopwatch.StartNew();
		var currentTime = Clock.UtcTime;

		Thread.Sleep(1000);

		var result = psw.StopRestart();

		Assert.IsNotNull(currentTime.Subtract(result) > currentTime.AddMilliseconds(1000));
	}

	[TestMethod]
	public void ToStringTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.ToStringTest));

		Thread.Sleep(500);

		psw.StopReset(this._logger, "Test message");

		var result = psw.ToString();

		Assert.IsTrue(result.Contains("Test message"));
	}

}
