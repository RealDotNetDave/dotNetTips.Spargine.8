// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-09-2024
// ***********************************************************************
// <copyright file="ExceptionExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.ServiceModel.Security;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ExceptionExtensionsTests
{

	[TestMethod]
	public void FromHierarchy_WithNullCanContinue_ShouldThrowArgumentNullException()
	{
		var ex = new Exception("Test exception");

		Assert.ThrowsException<ArgumentNullException>(() => ex.FromHierarchy(e => e.InnerException, null).ToList());
	}


	[TestMethod]
	public void FromHierarchy_WithNullNextItem_ShouldThrowArgumentNullException()
	{
		var ex = new Exception("Test exception");

		Assert.ThrowsException<ArgumentNullException>(() => ex.FromHierarchy(null, e => e != null).ToList());
	}

	[TestMethod]
	public void FromHierarchy_WithNullSource_ShouldThrowArgumentNullException()
	{
		Exception ex = null;

		Assert.ThrowsException<ArgumentNullException>(() => ex.FromHierarchy(e => e.InnerException, e => e != null).ToList());
	}

	[TestMethod]
	public void FromHierarchy_WithValidInput_ShouldReturnHierarchy()
	{
		var innerEx = new InvalidOperationException("Inner exception");
		var ex = new Exception("Outer exception", innerEx);

		var hierarchy = ex.FromHierarchy(e => e.InnerException, e => e != null).ToList();

		Assert.AreEqual(2, hierarchy.Count);
		Assert.AreEqual("Outer exception", hierarchy[0].Message);
		Assert.AreEqual("Inner exception", hierarchy[1].Message);
	}

	[TestMethod]
	public void GetAllMessagesTest()
	{
		var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

		var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

		var messages = ex.GetAllMessages();

		Assert.IsTrue(messages.IsNotEmpty());
	}

	[TestMethod]
	public void GetAllMessagesWithStackTraceTest()
	{
		var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

		var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

		var messages = ex.GetAllMessagesWithStackTrace();

		Assert.IsTrue(messages.HasItems());
	}

	[TestMethod]
	public void IsCritical_AccessViolationException_ReturnsTrue()
	{
		// Arrange
		var exception = new AccessViolationException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCritical_ArgumentNullException_ReturnsFalse()
	{
		// Arrange
		var exception = new ArgumentNullException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsCritical_IndexOutOfRangeException_ReturnsTrue()
	{
		// Arrange
		var exception = new IndexOutOfRangeException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCritical_NullException_ReturnsFalse()
	{
		// Arrange
		Exception exception = null;

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsCritical_NullReferenceException_ReturnsTrue()
	{
		// Arrange
		var exception = new NullReferenceException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCritical_OutOfMemoryException_ReturnsTrue()
	{
		// Arrange
		var exception = new OutOfMemoryException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCritical_StackOverflowException_ReturnsTrue()
	{
		// Arrange
		var exception = new StackOverflowException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}
	[TestMethod]
	public void IsCriticalTest()
	{
		var exGood = new NullReferenceException();
		var exBad = new ArgumentNullException();

		Assert.IsTrue(exGood.IsCritical());
		Assert.IsFalse(exBad.IsCritical());
	}

	[TestMethod]
	public void IsFatal_ArgumentNullException_ReturnsFalse()
	{
		// Arrange
		var exception = new ArgumentNullException();

		// Act
		var result = exception.IsFatal();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsFatal_NullException_ReturnsFalse()
	{
		// Arrange
		Exception exception = null;

		// Act
		var result = exception.IsFatal();

		// Assert
		Assert.IsFalse(result);
	}
	[TestMethod]
	public void IsFatal_OutOfMemoryException_ReturnsTrue()
	{
		// Arrange
		var exception = new OutOfMemoryException();

		// Act
		var result = exception.IsFatal();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsFatalTest()
	{
		var exGood = new OutOfMemoryException();
		var exBad = new ArgumentNullException();

		Assert.IsTrue(exGood.IsFatal());
		Assert.IsFalse(exBad.IsFatal());
	}

	[TestMethod]
	public void IsSecurityOrCritical_ArgumentNullException_ReturnsFalse()
	{
		// Arrange
		var exception = new ArgumentNullException();

		// Act
		var result = exception.IsSecurityOrCritical();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsSecurityOrCritical_NullException_ReturnsFalse()
	{
		// Arrange
		Exception exception = null;

		// Act
		var result = exception.IsSecurityOrCritical();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsSecurityOrCritical_NullReferenceException_ReturnsTrue()
	{
		// Arrange
		var exception = new NullReferenceException();

		// Act
		var result = exception.IsSecurityOrCritical();

		// Assert
		Assert.IsTrue(result);
	}
	[TestMethod]
	public void IsSecurityOrCritical_SecurityException_ReturnsTrue()
	{
		// Arrange
		var exception = new SecurityException();

		// Act
		var result = exception.IsSecurityOrCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsSecurityOrCriticalTest()
	{
		var exGood = new SecurityException();
		var exBad = new ArgumentNullException();

		Assert.IsTrue(exGood.IsSecurityOrCritical());
		Assert.IsFalse(exBad.IsSecurityOrCritical());
	}

	[TestMethod]
	public void TraverseFor_WithMatchingType_ShouldReturnException()
	{
		var innerEx = new InvalidOperationException("Inner exception");
		var ex = new Exception("Outer exception", innerEx);

		var result = ex.TraverseFor<InvalidOperationException>();

		Assert.IsNotNull(result);
		Assert.AreEqual("Inner exception", result.Message);
	}

	[TestMethod]
	public void TraverseFor_WithNonMatchingType_ShouldReturnNull()
	{
		var innerEx = new InvalidOperationException("Inner exception");
		var ex = new Exception("Outer exception", innerEx);

		var result = ex.TraverseFor<ArgumentNullException>();

		Assert.IsNull(result);
	}

	[TestMethod]
	public void TraverseFor_WithNullException_ShouldThrowArgumentNullException()
	{
		Exception ex = null;

		Assert.ThrowsException<ArgumentNullException>(() => ex.TraverseFor<InvalidOperationException>());
	}

}
