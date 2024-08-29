// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 06-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 08-15-2024
// ***********************************************************************
// <copyright file="NetworkHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides helper methods for network-related operations.</summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

namespace DotNetTips.Spargine.Core.Network;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

/// <summary>
/// Provides helper methods for network-related operations.
/// </summary>
public static class NetworkHelper
{

	/// <summary>
	/// Checks the network connections and returns a read-only collection of active network interfaces.
	/// </summary>
	/// <returns>A read-only collection of <see cref="NetworkInterface"/> representing the active network connections.</returns>
	[Information(nameof(GetNetworkConnections), OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static ReadOnlyCollection<NetworkInterface> GetNetworkConnections()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var connections = new List<NetworkInterface>(networkInterfaces.Length);

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				connections.Add(networkInterface);
			}
		}

		connections.TrimExcess();

		return connections.AsReadOnly();
	}

	/// <summary>
	/// Checks if the computer is connected to a Bluetooth network.
	/// </summary>
	/// <returns><c>true</c> if the computer is connected to a Bluetooth network; otherwise, <c>false</c>.</returns>
	[Information(nameof(GetNetworkConnections), OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool IsConnectedToBluetooth()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces.AsSpan())
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up &&
				networkInterface.Description.Contains("Bluetooth", StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}

		return false;
	}
}
