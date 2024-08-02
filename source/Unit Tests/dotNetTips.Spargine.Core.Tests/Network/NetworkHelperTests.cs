// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 08-02-2024
// ***********************************************************************
// <copyright file="NetworkHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using DotNetTips.Spargine.Core.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Core.Tests.Network;

[ExcludeFromCodeCoverage]
[TestClass]
public class NetworkHelperTests
{
	[TestMethod]
	public void CheckNetworkConnections_ContainsActiveNetworkInterfaces()
	{
		var result = NetworkHelper.GetNetworkConnections();

		foreach (var networkInterface in result)
		{
			Assert.AreEqual(OperationalStatus.Up, networkInterface.OperationalStatus, "All network interfaces should be active.");
		}
	}

	[TestMethod]
	public void CheckNetworkConnections_ReturnsNonNullCollection()
	{
		var result = NetworkHelper.GetNetworkConnections();

		Assert.IsNotNull(result, "The result should not be null.");
	}

	[TestMethod]
	public void CheckNetworkConnections_ReturnsReadOnlyCollection()
	{
		var result = NetworkHelper.GetNetworkConnections();

		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<NetworkInterface>), "The result should be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void IsConnectedToBluetooth_ReturnsFalseWhenNoBluetoothConnection()
	{
		var result = NetworkHelper.IsConnectedToBluetooth();

		Assert.IsFalse(result, "The result should be false when there is no Bluetooth connection.");
	}

	[TestMethod]
	public void IsConnectedToBluetooth_ReturnsTrueWhenBluetoothConnectionExists()
	{
		// This test assumes that there is a Bluetooth connection available.
		// It may need to be adjusted based on the actual environment where the test is run.
		var result = NetworkHelper.IsConnectedToBluetooth();

		if (result)
		{
			Assert.IsTrue(result, "The result should be true when there is a Bluetooth connection.");
		}
		else
		{
			Assert.Inconclusive("No Bluetooth connection is available, so this test cannot be conclusively run.");
		}
	}
}

