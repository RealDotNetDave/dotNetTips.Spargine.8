// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 03-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="FastLoggerExtensionsTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Logging;

[TestClass]
public class FastLoggerExtensionsTests
{
	private ILogger _logger;

	[TestMethod]
	public void LogCriticalMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Critical error occurred.";
		var exception = new Exception("Critical exception");

		// Act
		this._logger.LogCriticalMessage(message, exception);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogDebugMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Debugging information.";

		// Act
		this._logger.LogDebugMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogErrorMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "An error occurred.";

		// Act
		this._logger.LogErrorMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogExceptionMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Exception occurred.";
		var exception = new Exception("Exception details");

		// Act
		this._logger.LogExceptionMessage(message: message, exception: exception);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogInformationMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Information message.";

		// Act
		this._logger.LogInformationMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogStoredProcedureError_ValidParameters_LogsMessage()
	{
		// Arrange
		var storedProcedure = "sp_GetData";
		var exception = new Exception("Stored procedure exception");

		// Act
		this._logger.LogStoredProcedureError(storedProcedure, exception);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogStoredProcedureNoRecordsFound_ValidParameters_LogsMessage()
	{
		// Arrange
		var storedProcedure = "sp_GetData";

		// Act
		this._logger.LogStoredProcedureNoRecordsFound(storedProcedure);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogTraceMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Trace message.";

		// Act
		this._logger.LogTraceMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogWarningMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Warning message.";

		// Act
		this._logger.LogWarningMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestInitialize]
	public void Setup()
	{
		this._logger = new NullLogger<FastLoggerExtensionsTests>();
	}
}
