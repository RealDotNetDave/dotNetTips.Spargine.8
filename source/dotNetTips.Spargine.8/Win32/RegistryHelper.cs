// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-15-2024
// ***********************************************************************
// <copyright file="RegistryHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Convenient methods for interacting with the Windows registration database, streamlining access and manipulation tasks.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using Microsoft.Win32;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Win32;

/// <summary>
/// Provides utility methods for interacting with the Windows Registry, simplifying access and manipulation of registry keys.
/// </summary>
[SupportedOSPlatform("windows")]
public static class RegistryHelper
{

	/// <summary>
	/// User key for Environment.
	/// </summary>
	public const string KeyCurrentUserEnvironment = @"\Environment";

	/// <summary>
	/// User key for Microsoft.
	/// </summary>
	public const string KeyCurrentUserMicrosoft = @"SOFTWARE\Microsoft";

	/// <summary>
	/// User key for OneDrive.
	/// </summary>
	public const string KeyCurrentUserOneDrive = @"Software\Microsoft\OneDrive";

	/// <summary>
	/// Gets the registry key.
	/// </summary>
	/// <param name="keyName">The name.</param>
	/// <param name="registryKeyType">Type of the registry key.</param>
	/// <returns>RegistryKey.</returns>
	/// <exception cref="PlatformNotSupportedException"></exception>
	/// <example>
	/// Here is how you can use the GetRegistryKey method:
	/// <code>
	/// var key = RegistryHelper.GetRegistryKey(RegistryHelper.KeyCurrentUserMicrosoft, RegistryHive.CurrentUser);
	/// if (key != null)
	/// {
	///     // Use the key
	/// }
	/// </code>
	/// </example>
	[Information(nameof(GetRegistryKey), "David McCarter", "9/10/2020", "9/10/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None)]
	public static RegistryKey GetRegistryKey([NotNull] string keyName, [NotNull] RegistryHive registryKeyType)
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) is false)
		{
			throw new PlatformNotSupportedException();
		}

		keyName = keyName.ArgumentNotNullOrEmpty();
		registryKeyType = registryKeyType.ArgumentNotNull();

		return registryKeyType switch
		{
			RegistryHive.ClassesRoot => Registry.ClassesRoot.OpenSubKey(keyName),
			RegistryHive.CurrentConfig => Registry.CurrentConfig.OpenSubKey(keyName),
			RegistryHive.CurrentUser => Registry.CurrentUser.OpenSubKey(keyName),
			RegistryHive.LocalMachine => Registry.LocalMachine.OpenSubKey(keyName),
			RegistryHive.PerformanceData => Registry.PerformanceData.OpenSubKey(keyName),
			RegistryHive.Users => Registry.CurrentUser.OpenSubKey(keyName),
			_ => throw new ArgumentOutOfRangeException(nameof(registryKeyType), $"Unsupported registry hive: {registryKeyType}"),
		};
	}

}
