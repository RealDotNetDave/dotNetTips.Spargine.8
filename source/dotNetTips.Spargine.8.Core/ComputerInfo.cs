// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2025
// ***********************************************************************
// <copyright file="ComputerInfo.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Used to retrieve common computer information.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Core.Internal;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides detailed information about the computer system.
/// </summary>
[Information(nameof(ComputerInfo), author: "David McCarter", createdOn: "10/15/2018", Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineComputerInfo")]
[DataContract(Namespace = "dotNetTips.com/Info")]
[Serializable]
public sealed class ComputerInfo
{
	//TODO: ADD Environment.CpuUsage * Environment.ProcessCpuUsage FROM .NET 9
	//TODO: CHANGE TO STATIC METHODS IN V10? MAKE SURE IT SERIALIZES OR IS AVABLE VIA TOSTRING!

	/// <summary>
	/// Initializes a new instance of the <see cref="ComputerInfo"/> class.
	/// </summary>
	public ComputerInfo()
	{
	}

	/// <summary>
	/// Returns a string that represents the current object.
	/// </summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString() => this.PropertiesToString();

	/// <summary>
	/// Gets the computer culture in three-letter ISO language name format.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string ComputerCulture { get; private set; } = CultureInfo.CurrentCulture.ThreeLetterISOLanguageName;

	/// <summary>
	/// Gets the computer UI culture in three-letter ISO language name format.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string ComputerUICulture { get; private set; } = CultureInfo.CurrentUICulture.ThreeLetterISOLanguageName;

	/// <summary>
	/// Gets the current managed thread identifier.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CurrentManagedTreadId { get; private set; } = Environment.CurrentManagedThreadId;

	/// <summary>
	/// Gets the current stack trace information.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CurrentStackTrace { get; private set; } = Environment.StackTrace;

	/// <summary>
	/// Gets the current system tick count.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CurrentSystemTickCount { get; private set; } = Clock.TickCount;

	/// <summary>
	/// Shows the directory from which the current process is running.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CurrentWorkingDirectory { get; private set; } = Environment.CurrentDirectory;

	/// <summary>
	/// Displays a description of the .NET framework in use.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FrameworkDescription { get; private set; } = RuntimeInformation.FrameworkDescription;

	/// <summary>
	/// Gets the version of the .NET framework.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Version FrameworkVersion { get; private set; } = Environment.Version;

	/// <summary>
	/// Gets a value indicating whether the shutdown process has started.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool HasShutdownStarted { get; private set; } = Environment.HasShutdownStarted;

	/// <summary>
	/// Gets the IP addresses assigned to the computer.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string IPAddress { get; private set; } = Dns.GetHostAddresses(Dns.GetHostName()).Where(p => p.AddressFamily == AddressFamily.InterNetwork).ToDelimitedString(char.Parse(","));

	/// <summary>
	/// Gets a value indicating whether the operating system is 64-bit.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool Is64BitOperatingSystem { get; private set; } = Environment.Is64BitOperatingSystem;

	/// <summary>
	/// Gets a value indicating whether the process is 64-bit.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool Is64BitProcess { get; private set; } = Environment.Is64BitProcess;

	/// <summary>
	/// Determines whether the network is available.
	/// </summary>
	/// <returns><c>true</c> if the network is available; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks all network interfaces to determine if any are operational and not virtual or loopback interfaces.
	/// </remarks>
	[Information(nameof(IsNetworkAvailable), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public bool IsNetworkAvailable => NetworkInterface.GetAllNetworkInterfaces()
				.Any(networkInterface =>
					networkInterface.OperationalStatus == OperationalStatus.Up &&
					!networkInterface.Description.Contains("VIRTUALBOX", StringComparison.OrdinalIgnoreCase) &&
					!networkInterface.Description.Contains("LOOPBACK", StringComparison.OrdinalIgnoreCase));

	/// <summary>
	/// Gets a value indicating whether the user interface is interactive.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool IsUserInteractive { get; private set; } = Environment.UserInteractive;

	/// <summary>
	/// Gets the logical drives on the computer.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ReadOnlyCollection<string> LogicalDrives { get; private set; } = Environment.GetLogicalDrives().AsReadOnly();

	/// <summary>
	/// Gets the computer’s machine name.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string MachineName { get; private set; } = Environment.MachineName;

	/// <summary>
	/// Gets the architecture (e.g., 64-bit or 32-bit) of the operating system.
	/// </summary>
	[DataMember()]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string OSArchitecture { get; private set; } = RuntimeInformation.OSArchitecture.ToString();

	/// <summary>
	/// Gets the description of the operating system.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string OSDescription { get; private set; } = RuntimeInformation.OSDescription;

	/// <summary>
	/// Gets the size of the operating system's memory page.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int OSMemoryPageSize { get; private set; } = Environment.SystemPageSize;

	/// <summary>
	/// Gets the amount of physical memory in use.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public long PhysicalMemoryInUse { get; private set; } = Environment.WorkingSet;

	/// <summary>
	/// Gets the architecture of the process.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Architecture ProcessArchitecture { get; private set; } = RuntimeInformation.ProcessArchitecture;

	/// <summary>
	/// Gets the number of processors.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int ProcessorCount { get; private set; } = Environment.ProcessorCount;

	/// <summary>
	/// Gets the system directory path.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string SystemDirectory { get; private set; } = Environment.SystemDirectory;

	/// <summary>
	/// Gets the size of the system page.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int SystemPageSize { get; private set; } = Environment.SystemPageSize;

	/// <summary>
	/// Gets the system tick count.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int TickCount { get; private set; } = Clock.TickCount;

	/// <summary>
	/// Gets the system tick count as a 64-bit value.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public long TickCount64 { get; private set; } = Clock.TickCount64;

	/// <summary>
	/// Gets the uptime of the system.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public TimeSpan Uptime => TimeSpan.FromMilliseconds(Environment.TickCount64);

	/// <summary>
	/// Gets the domain name associated with the current user.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string UserDomainName { get; private set; } = Environment.UserDomainName;

	/// <summary>
	/// Gets the name of the current user.
	/// </summary>
	[DataMember]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string UserName { get; private set; } = Environment.UserName;
}
