// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-27-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-27-2025
// ***********************************************************************
// <copyright file="LoggableExceptionTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class LoggableExceptionTests
{

	[TestMethod]
	public void ComputerInformation_ReturnsNonEmptyString()
	{
		// Arrange
		var exception = new LoggableException();

		// Act
		var computerInfo = exception.ComputerInformation;

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(computerInfo));
	}
	[TestMethod]
	public void Constructor_Default_CreatesInstance()
	{
		// Act
		var exception = new LoggableException();

		// Assert
		Assert.IsNotNull(exception);
		Assert.IsFalse(exception.HasBeenLogged);
		Assert.IsNull(exception.UserMessage);
	}

	[TestMethod]
	public void Constructor_WithMessage_CreatesInstance()
	{
		// Arrange
		var message = "Test message";

		// Act
		var exception = new LoggableException(message);

		// Assert
		Assert.IsNotNull(exception);
		Assert.AreEqual(message, exception.Message);
		Assert.IsFalse(exception.HasBeenLogged);
		Assert.IsNull(exception.UserMessage);
	}

	[TestMethod]
	public void Constructor_WithMessageAndInnerException_CreatesInstance()
	{
		// Arrange
		var message = "Test message";
		var innerException = new Exception("Inner exception");

		// Act
		var exception = new LoggableException(message, innerException);

		// Assert
		Assert.IsNotNull(exception);
		Assert.AreEqual(message, exception.Message);
		Assert.AreEqual(innerException, exception.InnerException);
		Assert.IsFalse(exception.HasBeenLogged);
		Assert.IsNull(exception.UserMessage);
	}

	[TestMethod]
	public void Constructor_WithMessageInnerExceptionAndUserMessage_CreatesInstance()
	{
		// Arrange
		var message = "Test message";
		var innerException = new Exception("Inner exception");
		var userMessage = "User-friendly message";

		// Act
		var exception = new LoggableException(message, innerException, userMessage);

		// Assert
		Assert.IsNotNull(exception);
		Assert.AreEqual(message, exception.Message);
		Assert.AreEqual(innerException, exception.InnerException);
		Assert.AreEqual(userMessage, exception.UserMessage);
		Assert.IsFalse(exception.HasBeenLogged);
	}

	[TestMethod]
	public void HasBeenLogged_SetToFalse_DoesNotUpdateProperty()
	{
		// Arrange
		var exception = new LoggableException { HasBeenLogged = true };

		// Act
		exception.HasBeenLogged = false;

		// Assert
		Assert.IsTrue(exception.HasBeenLogged);
	}

	[TestMethod]
	public void HasBeenLogged_SetToTrue_UpdatesProperty()
	{
		// Arrange
		var exception = new LoggableException();

		// Act
		exception.HasBeenLogged = true;

		// Assert
		Assert.IsTrue(exception.HasBeenLogged);
	}

	[TestMethod]
	public void Messages_ReturnsExceptionMessages()
	{
		// Arrange
		var message = "Test message";
		var innerException = new Exception("Inner exception");
		var exception = new LoggableException(message, innerException);

		// Act
		var messages = exception.Messages();

		// Assert
		Assert.IsNotNull(messages);
		Assert.IsTrue(messages.Count > 0);
		//Assert.IsTrue(messages.Contains(message));
		Assert.IsTrue(messages.Any(m => m.Contains(message)));
		Assert.IsTrue(messages.Any(m => m.Contains(innerException.Message)));
	}
}
