// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2025
// ***********************************************************************
// <copyright file="SimpleResultTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SimpleResultTests
{

	[TestMethod]
	public void ErrorMessagesTest()
	{
		var ex = new ArgumentException("Invalue value for the parameter.");

		var result = SimpleResult.FromException<string>(ex);

		var errors = result.GetErrorMessages();

		Assert.IsTrue(errors.Any());
	}
	[TestMethod]
	public void FromExceptionTest()
	{
		var ex = new ArgumentException("Argument Exception");

		var result = SimpleResult.FromException<string>(ex);

		Assert.IsTrue(result.Status == ResultStatus.Failed);
	}

	[TestMethod]
	public void FromValueTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var result = SimpleResult.FromValue(person);

		Assert.IsTrue(result.Status == ResultStatus.Succeeded);
	}

	[TestMethod]
	public void SimpleResult_AddException_ShouldAddToExceptions()
	{
		// Arrange
		var result = new SimpleResult<int>();
		var exception = new InvalidOperationException("Test exception");

		// Act
		result.AddException(exception);

		// Assert
		Assert.AreEqual(1, result.Errors().Count);
		Assert.AreEqual(exception.Message, result.Errors()[0].Message);
	}

	[TestMethod]
	public void SimpleResult_ConstructorWithException_ShouldAddException()
	{
		// Arrange
		var exception = new InvalidOperationException("Test exception");

		// Act
		var result = new SimpleResult<string>(exception);

		// Assert
		Assert.AreEqual(ResultStatus.Failed, result.Status);
		Assert.AreEqual(1, result.Errors().Count);
		Assert.AreEqual(exception.Message, result.Errors()[0].Message);
	}

	[TestMethod]
	public void SimpleResult_ConstructorWithValue_ShouldSetValue()
	{
		// Arrange
		var value = 42;

		// Act
		var result = new SimpleResult<int>(value);

		// Assert
		Assert.AreEqual(value, result.Value);
		Assert.AreEqual(ResultStatus.Succeeded, result.Status);
	}

	[TestMethod]
	public void SimpleResult_GetErrorMessages_ShouldReturnAllMessages()
	{
		// Arrange
		var result = new SimpleResult<int>();
		var exception1 = new InvalidOperationException("Test exception 1");
		var exception2 = new InvalidOperationException("Test exception 2");
		result.AddException(exception1);
		result.AddException(exception2);

		// Act
		var errorMessages = result.GetErrorMessages();

		// Assert
		Assert.IsTrue(errorMessages.Contains(exception1.Message));
		Assert.IsTrue(errorMessages.Contains(exception2.Message));
	}

	[TestMethod]
	public void SimpleResult_Or_ShouldReturnDefaultValueIfFailed()
	{
		// Arrange
		var result = new SimpleResult<int>(new InvalidOperationException("Test exception"));
		var defaultValue = 100;

		// Act
		var value = result.Or(defaultValue);

		// Assert
		Assert.AreEqual(defaultValue, value);
	}

	[TestMethod]
	public void SimpleResult_OrDefault_ShouldReturnDefaultValue()
	{
		// Arrange
		var result = new SimpleResult<int>();

		// Act
		var value = result.OrDefault();

		// Assert
		Assert.AreEqual(default(int), value);
	}

	[TestMethod]
	public void SimpleResult_SetValue_ShouldUpdateValue()
	{
		// Arrange
		var result = new SimpleResult<int>();
		var newValue = 42;

		// Act
		result.SetValue(newValue);

		// Assert
		Assert.AreEqual(newValue, result.Value);
	}

	[TestMethod]
	public void SimpleResult_Status_ShouldReturnPartialSuccessIfValueAndExceptionPresent()
	{
		// Arrange
		var value = 42;
		var result = new SimpleResult<int>(value);
		var exception = new InvalidOperationException("Test exception");
		result.AddException(exception);

		// Act
		var status = result.Status;

		// Assert
		Assert.AreEqual(ResultStatus.PartialSuccess, status);
	}

	[TestMethod]
	public void SimpleResult_ToString_ShouldReturnErrorMessages()
	{
		// Arrange
		var exception = new InvalidOperationException("Test exception");
		var result = new SimpleResult<int>(exception);

		// Act
		var resultString = result.ToString();

		// Assert
		Assert.IsTrue(resultString.Contains(exception.Message));
	}

	[TestMethod]
	public void SimpleResult_ToString_ShouldReturnValueString()
	{
		// Arrange
		var value = 42;
		var result = new SimpleResult<int>(value);

		// Act
		var resultString = result.ToString();

		// Assert
		Assert.AreEqual(value.ToString(), resultString);
	}
}
