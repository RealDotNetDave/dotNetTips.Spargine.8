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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Core.Diagnostics;
using DotNetTips.Spargine.Tester;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Diagnostics;

[ExcludeFromCodeCoverage]
[TestClass]
public class PerformanceStopwatchTests : UnitTester
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
	public void ClearLapsTest()
	{
		var psw = PerformanceStopwatch.StartNew("ClearLapsTest");

		psw.RecordLap();
		psw.RecordLap();

		Assert.AreEqual(2, psw.GetLaps().Count);

		psw.ClearLaps();

		Assert.AreEqual(0, psw.GetLaps().Count);
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
	}

	[TestMethod]
	public void ExportToJsonHandlesEmptyDiagnosticsTest()
	{
		var psw = PerformanceStopwatch.StartNew("ExportToJsonHandlesEmptyDiagnosticsTest");

		var json = psw.ExportToJson();

		Assert.IsNotNull(json);
		Assert.IsTrue(json.Contains("Diagnostics"));
	}

	[TestMethod]
	public void ExportToJsonHandlesEmptyLapsTest()
	{
		var psw = PerformanceStopwatch.StartNew("ExportToJsonHandlesEmptyLapsTest");

		var json = psw.ExportToJson();

		Assert.IsNotNull(json);
		Assert.IsTrue(json.Contains("Laps"));
	}

	[TestMethod]
	public void ExportToJsonTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.ExportToJsonTest));

		psw.RecordLap();

		Thread.Sleep(RandomData.GenerateInteger(1, 500));

		psw.RecordLap();

		psw.AddDiagnosticEntry("Operation complete.");

		_ = psw.StopReset();

		var json = psw.ExportToJson();

		Assert.IsNotNull(json);
		Assert.IsTrue(json.Contains("ElapsedTimeMs"));
		Assert.IsTrue(json.Contains("Operation complete"));
		Assert.IsTrue(json.Contains("Laps"));
	}

	[TestMethod]
	public void GetDiagnosticMessagesTest()
	{
		var psw = PerformanceStopwatch.StartNew("GetDiagnosticMessagesTest");

		psw.StopReset(this._logger, "Test message 1");
		psw.StopReset(this._logger, "Test message 2");

		var messages = psw.GetDiagnosticMessages();

		Assert.AreEqual(2, messages.Count);
		Assert.IsTrue(messages[0].Contains("Test message 1"));
		Assert.IsTrue(messages[1].Contains("Test message 2"));
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
	public void GetLapsTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.GetLapsTest));

		Thread.Sleep(500);

		psw.RecordLap();
		psw.RecordLap();

		var laps = psw.GetLaps();

		Assert.AreEqual(2, laps.Count);
		Assert.IsTrue(laps[0] > TimeSpan.Zero);
	}

	[TestMethod]
	public void LogMessageTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.LogMessageTest));

		Thread.Sleep(500);

		psw.LogMessage(this._logger, "Intermediate log message");

		Assert.IsTrue(psw.Diagnostics.Count > 0);
	}

	[TestMethod]
	public void RecordLapTest()
	{
		var psw = PerformanceStopwatch.StartNew(nameof(this.RecordLapTest));

		Thread.Sleep(500);

		psw.RecordLap();

		Assert.AreEqual(1, psw.GetLaps().Count);
	}

	[TestMethod]
	public void StartNewTest()
	{
		var psw = PerformanceStopwatch.StartNew();

		Assert.IsNotNull(psw);
	}

	[TestMethod]
	public void StartNewWithAlertThresholdTest()
	{
		var alertThreshold = TimeSpan.FromMilliseconds(500);
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(alertThreshold, "TestOperation");

		Assert.IsNotNull(psw);
		Assert.AreEqual(alertThreshold, psw.AlertThreshold);
	}

	[TestMethod]
	public void StartNewWithTelemetryTest()
	{
		var client = new TelemetryClient(new TelemetryConfiguration
		{
			ConnectionString = "InstrumentationKey=e4c79667-0fd3-4753-bcb7-460551dc64de;IngestionEndpoint=https://westus3-1.in.applicationinsights.azure.com/;LiveEndpoint=https://westus3.livediagnostics.monitor.azure.com/;ApplicationId=bb5d61d5-6e42-452e-8ccd-626f6202dbcb",
		});

		var psw = PerformanceStopwatch.StartNewWithTelemetry(telemetry: client, operationName: "TestOperation", alertThreshold: TimeSpan.FromMilliseconds(500), message: "TestMessage", properties: new Dictionary<string, string> { { "Key", "Value" } });

		psw.StopReset();

		Assert.IsNotNull(psw);
		Assert.IsTrue(psw.ToString().Contains("TestMessage"));
	}

	[TestMethod]
	public void StopIfThresholdExceededFiresEventTest()
	{
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(TimeSpan.FromMilliseconds(500), "StopIfThresholdExceededFiresEventTest");

		bool thresholdExceededFired = false;

		psw.ThresholdExceeded += (sender, args) => thresholdExceededFired = true;

		Thread.Sleep(600);

		psw.StopIfThresholdExceeded();

		Assert.IsTrue(thresholdExceededFired);
	}

	[TestMethod]
	public void StopIfThresholdExceededTest()
	{
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(TimeSpan.FromMilliseconds(500), nameof(this.StopIfThresholdExceededTest));

		Thread.Sleep(600);

		var exceeded = psw.StopIfThresholdExceeded();

		Assert.IsTrue(exceeded);
		Assert.IsFalse(psw.IsRunning);
	}

	[TestMethod]
	public void StopIfThresholdNotExceededTest()
	{
		var psw = PerformanceStopwatch.StartNewWithAlertThreshold(TimeSpan.FromMilliseconds(1000), "TestOperation");

		Thread.Sleep(500);

		var exceeded = psw.StopIfThresholdExceeded();

		Assert.IsFalse(exceeded);
		Assert.IsTrue(psw.IsRunning);
	}

	[TestMethod]
	public void StopResetFiresEventsTest()
	{
		var psw = PerformanceStopwatch.StartNew("StopResetFiresEventsTest");

		bool resetCompletedFired = false;
		bool stoppedCompletedFired = false;

		psw.ResetCompleted += (sender, args) => resetCompletedFired = true;
		psw.StoppedCompleted += (sender, args) => stoppedCompletedFired = true;

		psw.StopReset();

		Assert.IsTrue(resetCompletedFired);
		Assert.IsTrue(stoppedCompletedFired);
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
	public void ToStringIncludesDiagnosticsTest()
	{
		var psw = PerformanceStopwatch.StartNew("ToStringIncludesDiagnosticsTest");

		psw.StopReset(this._logger, "Test message");

		var result = psw.ToString();

		Assert.IsTrue(result.Contains("Test message"));
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

	[TestMethod]
	public void TrackTelemetryHandlesNullPropertiesTest()
	{
		var telemetryClient = new TelemetryClient();
		var psw = PerformanceStopwatch.StartNew("TrackTelemetryHandlesNullPropertiesTest");

		psw.TrackTelemetry(telemetryClient, "TestOperation", "TestMessage", null);

		Assert.IsNotNull(psw);
	}

	[TestMethod]
	public void TrackTelemetryTest()
	{
		var telemetryClient = new TelemetryClient();
		var psw = PerformanceStopwatch.StartNew(nameof(this.TrackTelemetryTest));

		Thread.Sleep(500);

		psw.TrackTelemetry(telemetryClient, "TestOperation", "TestMessage", new Dictionary<string, string> { { "Key", "Value" } });

		Assert.IsNotNull(psw);
		Assert.IsTrue(psw.ToString().Contains(nameof(this.TrackTelemetryTest)));
	}

	[TestMethod]
	public void WithTelemetryHandlesNullMessageTest()
	{
		var telemetryClient = new TelemetryClient();
		var psw = PerformanceStopwatch.StartNew("WithTelemetryHandlesNullMessageTest")
			.WithTelemetry(telemetryClient, "TestOperation", null, new Dictionary<string, string> { { "Key", "Value" } });

		Assert.IsNotNull(psw);
	}

	[TestMethod]
	public void WithTelemetryTest()
	{
		var telemetryClient = new TelemetryClient();
		var psw = PerformanceStopwatch.StartNew(nameof(this.WithTelemetryTest))
			.WithTelemetry(telemetryClient, "TestOperation", "TestMessage", new Dictionary<string, string> { { "Key", "Value" } });

		Assert.IsNotNull(psw);
		Assert.IsTrue(psw.ToString().Contains(nameof(this.WithTelemetryTest)));
	}

}
