// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="ComputerInformation.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Net.NetworkInformation;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine;

/// <summary>
/// Provides methods to retrieve computer information.
/// </summary>
[SupportedOSPlatform("windows")]
[Information(Status = Status.NeedsDocumentation)]
public static class ComputerInformation
{
	/// <summary>
	/// Determines whether the network is available.
	/// </summary>
	/// <returns><c>true</c> if the network is available; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks all network interfaces to determine if any are operational and not virtual or loopback interfaces.
	/// </remarks>
	[Information(nameof(IsNetworkAvailable), OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static bool IsNetworkAvailable()
	{
		return NetworkInterface.GetAllNetworkInterfaces()
			.Where(i => i.OperationalStatus == OperationalStatus.Up)
			.Select(i => i.Description.ToUpperInvariant())
			.Where(n => !n.Contains("VIRTUALBOX", StringComparison.OrdinalIgnoreCase))
			.Any(n => !n.Contains("LOOPBACK", StringComparison.OrdinalIgnoreCase));
	}
}
