// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 06-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="NetworkHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>https:docs.microsoft.com/en-us/dotnet/api/xamarin.essentials.connectivity</summary>
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
	[Information(nameof(CheckNetworkConnections), OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static ReadOnlyCollection<NetworkInterface> CheckNetworkConnections()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var connections = new List<NetworkInterface>(networkInterfaces.Length);

		foreach (var networkInterface in networkInterfaces.AsSpan())
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				connections.Add(networkInterface);
			}
		}

		connections.TrimExcess();

		return connections.AsReadOnly();
	}
}
