// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="RegistryExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Helper methods to access the Windows Registration Database</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using Microsoft.Win32;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for working with the Windows Registry. These methods extend the <see cref="RegistryKey"/> class,
/// allowing for simplified access to registry keys and values with additional safety checks and platform compatibility considerations.
/// </summary>
/// <remarks>
/// The methods in this class are designed to be used on Windows platforms only. Attempts to use these methods on non-Windows platforms
/// will result in a <see cref="PlatformNotSupportedException"/>.
/// </remarks>
[SupportedOSPlatform("windows")]
public static class RegistryExtensions
{

	/// <summary>
	/// Gets the registry key sub key.
	/// </summary>
	/// <param name="key">The key.</param>
	/// <param name="name">The name.</param>
	/// <returns>RegistryKey.</returns>
	/// <exception cref="PlatformNotSupportedException"></exception>
	[Information(nameof(GetSubKey), author: "David McCarter", createdOn: "3/1/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static RegistryKey GetSubKey([NotNull] this RegistryKey key, [NotNull] string name) => RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? key.OpenSubKey(name) : throw new PlatformNotSupportedException();

	/// <summary>
	/// Gets the registry key value.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="key">The key.</param>
	/// <param name="name">The name.</param>
	/// <returns>T.</returns>
	/// <exception cref="PlatformNotSupportedException"></exception>
	[Information(nameof(GetValue), author: "David McCarter", createdOn: "3/1/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T GetValue<T>([NotNull] this RegistryKey key, string name)
	{
		name = name.ArgumentNotNullOrEmpty();
		key = key.ArgumentNotNull();

		var returnValue = default(T);

		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			var keyValue = key.GetValue(name);

			if (keyValue is not null)
			{
				returnValue = (T)keyValue;
			}

			return returnValue;
		}
		else
		{
			throw new PlatformNotSupportedException();
		}
	}

}
