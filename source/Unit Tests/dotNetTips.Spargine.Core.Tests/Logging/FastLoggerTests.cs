// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-28-2023
//
// Last Modified By : David McCarter
// Last Modified On : 09-02-2024
// ***********************************************************************
// <copyright file="FastLoggerTests.cs" company="McCarter Consulting">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Logging;

[ExcludeFromCodeCoverage]
[TestClass]
public class FastLoggerTests
{
	private readonly ILogger _logger = new NullLogger<FastLoggerTests>();

	[TestMethod]
	public void LogCritical_ValidParameters_LogsCriticalMessage()
	{
		var exception = new Exception("Test exception");

		_logger.LogCritical("Test message", exception);
	}

	[TestMethod]
	public void LogDebug_ValidParameters_LogsDebugMessage()
	{
		_logger.LogDebug("Test message");
	}

	[TestMethod]
	public void LogException_ValidParameters_LogsExceptionMessage()
	{
		var exception = new Exception("Test exception");

		FastLogger.LogException(this._logger, "Test message", exception);
	}

	[TestMethod]
	public void LogInformation_ValidParameters_LogsInformationMessage()
	{
		FastLogger.LogInformation(this._logger, "Test message");
	}

	[TestMethod]
	public void LogTrace_ValidParameters_LogsTraceMessage()
	{
		FastLogger.LogTrace(this._logger, "Test message");
	}

	[TestMethod]
	public void LogWarning_ValidParameters_LogsWarningMessage()
	{
		FastLogger.LogWarning(this._logger, "Test message");
	}
}
