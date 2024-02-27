// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-28-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="FastLoggerTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests.Logging;

[ExcludeFromCodeCoverage]
[TestClass]
public class FastLoggerTests
{

	private readonly ArgumentException _argumentException = new();
	private readonly ILogger _logger = new NullLogger<FastLoggerTests>();

	[TestMethod]
	public void LogCriticalMessageTest() => this._logger.LogCriticalMessage(message: "Server is down!", exception: this._argumentException);

	[TestMethod]
	public void LogCriticalTest() => FastLogger.LogCritical(this._logger, message: "Server is down!", exception: this._argumentException);

	[TestMethod]
	public void LogDebugMessageTest()
	{
		this._logger.LogDebugMessage(message: "Test Message");
	}

	[TestMethod]
	public void LogDebugTest() => FastLogger.LogDebug(this._logger, message: "Test Message");

	[TestMethod]
	public void LogErrorMesageTest() => this._logger.LogErrorMessage(message: "Test Message");

	[TestMethod]
	public void LogErrorTest() => FastLogger.LogError(this._logger, message: "Test Message");

	[TestMethod]
	public void LogExceptionMessageTest() => this._logger.LogExceptionMessage(message: "Cannot connect to database.", exception: this._argumentException);

	[TestMethod]
	public void LogInformationMessageTest() => this._logger.LogInformationMessage(message: "Test Message");

	[TestMethod]
	public void LogInformationTest() => FastLogger.LogInformation(this._logger, message: "Test Message");

	[TestMethod]
	public void LogStoredProcedureErrorTest() => this._logger.LogStoredProcedureError(storedProcedure: "Get_Customers", exception: this._argumentException);

	[TestMethod]
	public void LogTraceMessageTest()
	{
		this._logger.LogTraceMessage(message: "Test Message");
	}

	[TestMethod]
	public void LogTraceTest()
	{
		FastLogger.LogTrace(this._logger, message: "Test Message");
	}

}
