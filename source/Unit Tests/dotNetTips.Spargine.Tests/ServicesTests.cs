// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2025
// ***********************************************************************
// <copyright file="TempFileManagerTests.cs" company="DotNetTips.Spargine.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.ServiceProcess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ServicesTests
{
	private const string ExistingServiceName = "EventLog"; // Common Windows service
	private const string NonExistingServiceName = "FakeService123";
	private const string RunningProcessName = "explorer"; // Common Windows process

	[TestMethod]
	public void AllServices_ReturnsNonEmptyCollection()
	{
		var services = Services.AllServices();

		Assert.IsNotNull(services);
		Assert.IsTrue(services.Count > 0);
		Assert.IsTrue(services.Contains(ExistingServiceName));
	}

	[TestMethod]
	public void IsProcessRunning_ExistingProcess_ReturnsTrue()
	{
		var result = Services.IsProcessRunning(RunningProcessName);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsProcessRunning_NonExistingProcess_ReturnsFalse()
	{
		var result = Services.IsProcessRunning("FakeProcess123");
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ServiceExists_ExistingService_ReturnsTrue()
	{
		var result = Services.ServiceExists(ExistingServiceName);
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ServiceExists_NonExistingService_ReturnsFalse()
	{
		var result = Services.ServiceExists(NonExistingServiceName);
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ServiceStatus_ExistingService_ReturnsValidStatus()
	{
		var status = Services.ServiceStatus(ExistingServiceName);
		Assert.IsTrue(Enum.IsDefined(typeof(ServiceControllerStatus), status));
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidOperationException))]
	public void ServiceStatus_NonExistingService_ThrowsInvalidOperationException()
	{
		_ = Services.ServiceStatus(NonExistingServiceName);
	}

	[TestMethod]
	public void StartService_NonExistingService_ReturnsNotFound()
	{
		var result = Services.StartService(NonExistingServiceName);
		Assert.AreEqual(ServiceActionResult.NotFound, result);
	}

	[TestMethod]
	public void StopService_NonExistingService_ReturnsNotFound()
	{
		var result = Services.StopService(NonExistingServiceName);
		Assert.AreEqual(ServiceActionResult.NotFound, result);
	}


	// KillProcess is not tested to avoid terminating system processes.
}
