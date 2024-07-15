// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-20-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="SourceGenerators.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.InteropServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides utility methods and constants for working with source generation and system information.
/// </summary>
internal static partial class SourceGenerators
{

	/// <summary>
	/// The processor architecture AMD64
	/// </summary>
	internal const int PROCESSOR_ARCHITECTURE_AMD64 = 9;

	/// <summary>
	/// The processor architecture ARM
	/// </summary>
	internal const int PROCESSOR_ARCHITECTURE_ARM = 5;

	/// <summary>
	/// The processor architecture ARM64
	/// </summary>
	internal const int PROCESSOR_ARCHITECTURE_ARM64 = 12;

	/// <summary>
	/// The processor architecture Intel
	/// </summary>
	internal const int PROCESSOR_ARCHITECTURE_INTEL = 0;

	/// <summary>
	/// Converts an integer representing a processor architecture into the corresponding <see cref="Architecture"/> enum value.
	/// </summary>
	/// <param name="processorArchitecture">The processor architecture as an integer. Expected values are from the PROCESSOR_ARCHITECTURE_* constants.</param>
	/// <returns>The <see cref="Architecture"/> enum value that corresponds to the given processor architecture integer.</returns>
	internal static Architecture ConvertProcessorArchitecture(int processorArchitecture) => processorArchitecture switch
	{
		PROCESSOR_ARCHITECTURE_ARM64 => Architecture.Arm64,
		PROCESSOR_ARCHITECTURE_ARM => Architecture.Arm,
		PROCESSOR_ARCHITECTURE_AMD64 => Architecture.X64,
		_ => Architecture.X86,
	};

	/// <summary>
	/// Retrieves information about the current system.
	/// </summary>
	/// <param name="si">A reference to a <see cref="SystemInfo"/> structure that receives the information.</param>
	/// <remarks>
	/// This method directly invokes the native GetSystemInfo function from the Kernel32 DLL.
	/// </remarks>
	[DllImport(ApiLibraries.Kernel32, EntryPoint = "GetSystemInfo", SetLastError = true)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal static extern void GetSystemInfoDllImport(ref SystemInfo si);

	/// <summary>
	/// Represents information about the system's current configuration.
	/// </summary>
	internal struct SystemInfo
	{

		/// <summary>
		/// The OEM ID.
		/// </summary>
		internal uint _dwOemId;

		/// <summary>
		/// The system's page size.
		/// </summary>
		internal uint _dwPageSize;

		/// <summary>
		/// The minimum application address.
		/// </summary>
		internal IntPtr _lpMinimumApplicationAddress;

		/// <summary>
		/// The maximum application address.
		/// </summary>
		internal IntPtr _lpMaximumApplicationAddress;

		/// <summary>
		/// A mask representing the active processor set.
		/// </summary>
		internal IntPtr _dwActiveProcessorMask;

		/// <summary>
		/// The number of processors in the system.
		/// </summary>
		internal uint _dwNumberOfProcessors;

		/// <summary>
		/// The processor type.
		/// </summary>
		internal uint _dwProcessorType;

		/// <summary>
		/// The granularity with which virtual memory is allocated.
		/// </summary>
		internal uint _dwAllocationGranularity;

		/// <summary>
		/// The processor level.
		/// </summary>
		internal ushort _wProcessorLevel;

		/// <summary>
		/// The processor revision.
		/// </summary>
		internal ushort _wProcessorRevision;

	}

}
