// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 11-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-07-2025
// ***********************************************************************
// <copyright file="ThreadExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using DotNetTips.Spargine.Core.Devices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ThreadExtensionsTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void TrySetPriority_InvalidPriority_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var thread = new Thread(() => { });
		var invalidPriority = (ThreadPriority)int.MaxValue;

		// Act
		thread.TrySetPriority(invalidPriority);

		// Assert is handled by ExpectedException
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void TrySetPriority_NullThread_ThrowsArgumentNullException()
	{
		// Arrange
		Thread thread = null;

		// Act
		thread.TrySetPriority(ThreadPriority.Normal);

		// Assert is handled by ExpectedException
	}

	[TestMethod]
	public void TrySetPriority_ValidPriority_ReturnsTrue()
	{
		// Arrange
		var thread = new Thread(() => { });
		var priority = ThreadPriority.AboveNormal;

		// Act
		var result = thread.TrySetPriority(priority);

		// Assert
		Assert.IsTrue(result, "The method should return true for a valid priority.");
		Assert.AreEqual(priority, thread.Priority, "The thread priority should be set to the specified value.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void WaitUntil_NegativeWaitIterations_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.FromMilliseconds(100);
		var negativeWaitIterations = -1;

		// Act
		thread.WaitUntil(interval, negativeWaitIterations);

		// Assert is handled by ExpectedException
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void WaitUntil_NullThread_ThrowsArgumentNullException()
	{
		// Arrange
		Thread thread = null;
		var interval = TimeSpan.FromMilliseconds(100);

		// Act
		thread.WaitUntil(interval);

		// Assert is handled by ExpectedException
	}

	[TestMethod]
	public void WaitUntil_ValidInterval_WaitsCorrectly()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.FromTicks(1000);

		// Act
		var startTime = TimeSpan.FromTicks(Clock.LocalTime.Ticks);
		thread.WaitUntil(interval);
		var endTime = TimeSpan.FromTicks(Clock.LocalTime.Ticks);

		// Assert
		Assert.IsTrue(endTime - startTime >= interval, "The method should wait for at least the specified interval.");
	}

	[TestMethod]
	public void WaitUntil_ValidIntervalAndIterations_WaitsCorrectly()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.FromSeconds(1);
		var waitIterations = 1000;

		// Act
		var startTime = Clock.LocalTime;
		thread.WaitUntil(interval, waitIterations);

		var endTime = Clock.LocalTime;

		// Assert
		Assert.IsTrue(endTime.Ticks - startTime.Ticks >= interval.Ticks, "The method should wait for at least the specified interval.");
	}
}

