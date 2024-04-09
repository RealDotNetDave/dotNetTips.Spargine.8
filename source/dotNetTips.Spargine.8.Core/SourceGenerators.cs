// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-20-2023
//
// Last Modified By : David McCarter
// Last Modified On : 03-04-2024
// ***********************************************************************
// <copyright file="SourceGenerators.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.InteropServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class SourceGenerators.
/// </summary>
internal static partial class SourceGenerators
{

	/// <summary>
	/// The processor architecture am D64
	/// </summary>
	internal const int PROCESSOR_ARCHITECTURE_AMD64 = 9;

	/// <summary>
	/// The processor architecture arm
	/// </summary>
	internal const int PROCESSOR_ARCHITECTURE_ARM = 5;

	/// <summary>
	/// The processor architecture ar M64
	/// </summary>
	internal const int PROCESSOR_ARCHITECTURE_ARM64 = 12;

	/// <summary>
	/// The processor architecture intel
	/// </summary>
	internal const int PROCESSOR_ARCHITECTURE_INTEL = 0;

	/// <summary>
	/// Converts the processor architecture.
	/// </summary>
	/// <param name="processorArchitecture">The processor architecture.</param>
	/// <returns>Architecture.</returns>
	internal static Architecture ConvertProcessorArchitecture(int processorArchitecture) => processorArchitecture switch
	{
		PROCESSOR_ARCHITECTURE_ARM64 => Architecture.Arm64,
		PROCESSOR_ARCHITECTURE_ARM => Architecture.Arm,
		PROCESSOR_ARCHITECTURE_AMD64 => Architecture.X64,
		_ => Architecture.X86,
	};

	/// <summary>
	/// Gets the system information.
	/// </summary>
	/// <param name="si">The si.</param>
	[DllImport(ApiLibraries.Kernel32, EntryPoint = "GetSystemInfo", SetLastError = true)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal static extern void GetSystemInfoDllImport(ref SystemInfo si);

	//#if NET7_0_OR_GREATER
	//	[LibraryImport(ApiLibraries.Kernel32, EntryPoint = "GetSystemInfo", SetLastError = true)]
	//	internal static partial void GetSystemInfoLibraryImport(ref SystemInfo si)
	//	{ }
	//#endif

	/// <summary>
	/// Struct SystemInfo
	/// </summary>
	internal struct SystemInfo
	{

		/// <summary>
		/// The dw oem identifier
		/// </summary>
		internal uint _dwOemId;

		/// <summary>
		/// The dw page size
		/// </summary>
		internal uint _dwPageSize;

		/// <summary>
		/// The lp minimum application address
		/// </summary>
		internal IntPtr _lpMinimumApplicationAddress;

		/// <summary>
		/// The lp maximum application address
		/// </summary>
		internal IntPtr _lpMaximumApplicationAddress;

		/// <summary>
		/// The dw active processor mask
		/// </summary>
		internal IntPtr _dwActiveProcessorMask;

		/// <summary>
		/// The dw number of processors
		/// </summary>
		internal uint _dwNumberOfProcessors;

		/// <summary>
		/// The dw processor type
		/// </summary>
		internal uint _dwProcessorType;

		/// <summary>
		/// The dw allocation granularity
		/// </summary>
		internal uint _dwAllocationGranularity;

		/// <summary>
		/// The w processor level
		/// </summary>
		internal ushort _wProcessorLevel;

		/// <summary>
		/// The w processor revision
		/// </summary>
		internal ushort _wProcessorRevision;

	}

}
