// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2025
// ***********************************************************************
// <copyright file="App.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Application Information and Utility Methods.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using DotNetTips.Spargine.Core.Properties;
using static DotNetTips.Spargine.Core.SourceGenerators;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a centralized point of application-level properties and methods, including information about the application, culture settings, and system information.
/// </summary>
/// <remarks>
/// This class serves as a utility for accessing various application and system properties such as culture information, OS details, and processor information.
/// It also provides methods for changing culture settings, retrieving environment variables, and managing application processes.
/// </remarks>
[Information(Documentation = "https://bit.ly/SpargineApp", Status = Status.Available)]
public static class App
{

	/// <summary>
	/// The temporary ASP files location.
	/// </summary>
	private const string TempAspFiles = "\\Temporary ASP.NET Files\\";

	/// <summary>
	/// Application information.
	/// </summary>
	private static readonly Lazy<AppInfo> _appInfo = new(InitAppInfo());

	/// <summary>
	/// Computer information.
	/// </summary>
	private static readonly Lazy<ComputerInfo> _computerInfo = new(() => new ComputerInfo());

	/// <summary>
	/// The culture names
	/// </summary>
	private static ReadOnlyCollection<string> _cultureNames;

	/// <summary>
	/// Initializes the application information.
	/// </summary>
	/// <returns>AppInfo.</returns>
	private static AppInfo InitAppInfo()
	{
		var assembly = Assembly.GetEntryAssembly();

		return new AppInfo
		{
			Company = assembly.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault()?.Company,
			Configuration = assembly.GetCustomAttributes<AssemblyConfigurationAttribute>().FirstOrDefault()?.Configuration,
			Copyright = assembly.GetCustomAttributes<AssemblyCopyrightAttribute>().FirstOrDefault()?.Copyright,
			Description = assembly.GetCustomAttributes<AssemblyDescriptionAttribute>().FirstOrDefault()?.Description,
			FileVersion = assembly.GetCustomAttributes<AssemblyFileVersionAttribute>().FirstOrDefault()?.Version,
			MemoryAllocated = GC.GetTotalMemory(forceFullCollection: false),
			MemoryInfo = GC.GetGCMemoryInfo(),
			Product = assembly.GetCustomAttributes<AssemblyProductAttribute>().FirstOrDefault()?.Product,
			ThreadAllocatedBytes = GC.GetAllocatedBytesForCurrentThread(),
			Title = assembly.GetCustomAttributes<AssemblyTitleAttribute>().FirstOrDefault()?.Title,
			TotalAllocatedBytes = GC.GetTotalAllocatedBytes(precise: false),
			Version = assembly.GetName().Version.ToString(),
		};
	}

	/// <summary>
	/// Kills the specified process by name.
	/// </summary>
	/// <param name="processName">The name of the process to kill.</param>
	/// <example>
	/// Here is how you can use the <see cref="KillProcess" /> method:
	/// <code>
	/// App.KillProcess("notepad");
	/// </code></example>
	private static void KillProcess(string processName)
	{
		processName = processName.ArgumentNotNullOrEmpty();

		var app = Process.GetProcessesByName(processName).FirstOrDefault();

		if (app is not null)
		{
			app.Kill();

			_ = app.WaitForExit(milliseconds: 6000);
		}
	}

	/// <summary>
	/// Changes the culture.
	/// </summary>
	/// <param name="cultureName">Name of the culture.</param>
	/// <example>
	/// Here is how you can use the ChangeCulture method:
	/// <code>
	/// App.ChangeCulture("en-US");
	/// </code>
	/// This will change the current culture to English (United States).
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void ChangeCulture(string cultureName) => CultureInfo.CurrentCulture = new CultureInfo(cultureName.ArgumentNotNullOrEmpty());

	/// <summary>
	/// Changes the current culture and UI culture.
	/// </summary>
	/// <param name="culture">The culture.</param>
	/// <example>
	/// Here is how you can use the ChangeCulture method:
	/// <code>
	/// App.ChangeCulture(new CultureInfo("en-US"));
	/// </code>
	/// This will change the current culture and UI culture to English (United States).
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void ChangeCulture(CultureInfo culture)
	{
		CultureInfo.CurrentCulture = culture.ArgumentNotNull();
		CultureInfo.CurrentUICulture = culture;
	}

	/// <summary>
	/// Modifies the UI culture in the application, providing localized user interface adjustments.
	/// </summary>
	/// <param name="cultureName">Name of the culture.</param>
	/// <example>
	/// Here is how you can use the ChangeUICulture method:
	/// <code>
	/// App.ChangeUICulture("fr-FR");
	/// </code>
	/// This will change the current UI culture to French (France).
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void ChangeUICulture(string cultureName) => CultureInfo.CurrentUICulture = new CultureInfo(cultureName.ArgumentNotNullOrEmpty());

	/// <summary>
	/// Returns the folder path for the entry assembly.
	/// </summary>
	/// <returns>The directory name of the process executable in the default application domain. In other application domains, this is the first executable that was executed by AppDomain.ExecuteAssembly.</returns>
	/// <example>
	/// Here is how you can use the ExecutingFolder method:
	/// <code>
	/// var folderPath = App.ExecutingFolder();
	/// Console.WriteLine(folderPath);
	/// </code></example>
	[Information(nameof(ExecutingFolder), author: "David McCarter", createdOn: "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ExecutingFolder() => Path.GetDirectoryName(_computerInfo.Value.CurrentWorkingDirectory);

	/// <summary>
	/// Gets the culture names based on the specified culture type.
	/// </summary>
	/// <param name="cultureType">Type of the culture. Defaults to AllCultures.</param>
	/// <returns>A read-only collection of culture names.</returns>
	/// <example>
	/// Here is how you can use the <see cref="GetCultureNames" /> method:
	/// <code>
	/// var cultureNames = App.GetCultureNames(CultureTypes.SpecificCultures);
	/// foreach(var name in cultureNames)
	/// {
	/// Console.WriteLine(name);
	/// }
	/// </code>
	/// This will print the names of all specific cultures.
	/// </example>
	[Information(nameof(GetCultureNames), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> GetCultureNames(CultureTypes cultureType = CultureTypes.AllCultures) => _cultureNames ??= CultureInfo.GetCultures(cultureType).OrderBy(p => p.Name).Select(c => c.Name).ToList().AsReadOnly();

	/// <summary>
	/// Fetches the environment variables for the current process.
	/// </summary>
	/// <returns>An immutable dictionary containing all environment variables where the key is the variable name and the value is its value.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IImmutableDictionary<string, string> GetEnvironmentVariables() => Environment.GetEnvironmentVariables().Cast<DictionaryEntry>().ToImmutableDictionary(de => de.Key.ToString(), de => de.Value.ToString());

	/// <summary>
	/// Retrieves detailed information about the processor.
	/// </summary>
	/// <returns>A <see cref="ProcessorInformation" /> object containing various details about the processor such as architecture, speed, and core count.</returns>
	/// <example>
	/// Example output:<br />
	/// ActiveProcessorMask: 0x0000000000000fff
	/// AllocationGranularity: 65536
	/// MaximumApplicationAddress: 0x00007ffffffeffff
	/// MinimumApplicationAddress: 0x0000000000010000
	/// NumberOfProcessors: 12
	/// PageSize: 4096
	/// ProcessorArchitecture: X86
	/// ProcessorLevel: 6
	/// ProcessorRevision: 42243
	/// </example>
	/// <remarks>This method utilizes system-specific calls to gather comprehensive details about the processor. It's designed to work across different platforms, providing a unified interface for accessing processor information.</remarks>
	[Information(nameof(GetProcessorInformation), "David McCarter", "3/20/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ProcessorInformation GetProcessorInformation()
	{
		var info = new SystemInfo();

		GetSystemInfoDllImport(ref info);

		//Convert data
		return new ProcessorInformation()
		{
			PageSize = (int)info._dwPageSize,
			MinimumApplicationAddress = info._lpMinimumApplicationAddress,
			MaximumApplicationAddress = info._lpMaximumApplicationAddress,
			ActiveProcessorMask = info._dwActiveProcessorMask,
			NumberOfProcessors = (int)info._dwNumberOfProcessors,
			ProcessorArchitecture = ConvertProcessorArchitecture((int)info._dwProcessorType),
			AllocationGranularity = (int)info._dwAllocationGranularity,
			ProcessorLevel = info._wProcessorLevel,
			ProcessorRevision = info._wProcessorRevision
		};
	}

	/// <summary>
	/// Checks if the current application is already running.
	/// </summary>
	/// <returns><c>true</c> if the application is already running; otherwise, <c>false</c>.</returns>
	/// <remarks>This method checks if there are any processes with the same name as the current process. If more than one is found, it indicates that the application is already running.</remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsRunning() => Process.GetProcessesByName(ProcessName).Count() > 0;

	/// <summary>
	/// Checks to see if the current application is running from an ASP.NET context.
	/// </summary>
	/// <returns><c>true</c> if the application is running from an ASP.NET context; otherwise, <c>false</c>.</returns>
	/// <remarks>This method determines if the application is running within an ASP.NET context by checking the presence of ASP.NET temporary files in the application's dynamic directory.</remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsRunningFromAspNet() => (!string.IsNullOrEmpty(AppDomain.CurrentDomain.DynamicDirectory)) && AppDomain.CurrentDomain.DynamicDirectory.Contains(TempAspFiles, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Determines whether the current user is an administrator.
	/// </summary>
	/// <returns><c>true</c> if the current user is an administrator; otherwise, <c>false</c>.</returns>
	/// <exception cref="PlatformNotSupportedException">Thrown when the operating system is not Windows, as administrator status can only be checked on Windows.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsUserAdministrator() => !RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
			? throw new PlatformNotSupportedException()
			: new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

	/// <summary>
	/// Terminates the current process instantly, useful in critical failure scenarios.
	/// </summary>
	/// <remarks>This method retrieves the name of the process that started the currently executing application,
	/// removes the file extension to get the process name, and then calls <see cref="KillProcess" />
	/// with that name to terminate the process.</remarks>
	[Information(Status = Status.Available)]
	public static void Kill() => KillProcess(Path.GetFileNameWithoutExtension(AppContext.BaseDirectory));

	/// <summary>
	/// Calculates the maximum number of tasks that can run concurrently, based on the system’s processor count.
	/// </summary>
	/// <returns>The maximum degree of parallelism.</returns>
	/// <remarks>This method calculates the maximm degree of parallelism by taking 75% of the processor count, doubling it, and rounding up to the nearest whole number.
	/// It is designed to optimize parallel operations by not overloading the system with too many concurrent tasks.</remarks>
	[Information(nameof(MaxDegreeOfParallelism), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int MaxDegreeOfParallelism() => Convert.ToInt32(Math.Ceiling(_computerInfo.Value.ProcessorCount * 0.75 * 2.0));

	/// <summary>
	/// Reboots the system programmatically.
	/// </summary>
	/// <exception cref="PlatformNotSupportedException">Thrown when the operating system is not supported.</exception>
	[Information(Status = Status.Available)]
	public static void RebootComputer()
	{
		if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			throw new PlatformNotSupportedException(Resources.RebootingIsOnlySupportedOnWindows);
		}

		var psi = new ProcessStartInfo("shutdown", "/r /t 0")
		{
			CreateNoWindow = true,
			UseShellExecute = false
		};

		_ = Process.Start(psi);
	}

	/// <summary>
	/// Loads a list of all assemblies referenced by the running application, aiding in diagnostics or reflective operations.
	/// </summary>
	/// <returns>A read-only collection of strings representing the full names of all assemblies referenced by the running assembly.</returns>
	/// <example>Example usage:
	/// <code>
	/// var referencedAssemblies = App.ReferencedAssemblies();
	/// foreach(var assembly in referencedAssemblies)
	/// {
	/// Console.WriteLine(assembly);
	/// }
	/// </code></example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> ReferencedAssemblies() => Assembly.GetEntryAssembly().GetReferencedAssemblies().Select(a => a.ToString()).ToList().AsReadOnly();

	/// <summary>
	/// Restarts the application with elevated administrative privileges, if required by the task at hand.
	/// </summary>
	/// <remarks>If the current user is not an administrator, this method will attempt to restart the application with administrator privileges.
	/// It prompts the user for permission to run as an administrator. If granted, the application restarts; otherwise, it exits.
	/// This method should be used cautiously, as it terminates the current process and starts a new one.</remarks>
	[Information(Status = Status.Available)]
	public static void RunAsAdministrator()
	{
		if (IsUserAdministrator())
		{
			return;
		}

		var processInfo = new ProcessStartInfo
		{
			FileName = _computerInfo.Value.CurrentWorkingDirectory,
			UseShellExecute = true,
			Verb = "runas",
		};

		_ = Process.Start(processInfo);

		Environment.ExitCode = 0;
		Environment.Exit(0);
	}

	/// <summary>
	/// Gets the application information.
	/// </summary>
	/// <value>The application information, including company, configuration, copyright, description, file version, memory allocated, memory info, product, thread allocated bytes, title, total allocated bytes, and version.</value>
	/// <example>Example usage:
	/// <code>
	/// var appInfo = App.AppInfo;
	/// Console.WriteLine($"Company: {appInfo.Company}");
	/// </code>
	/// This will output the company name from the application's assembly information.
	/// </example>
	[Information(nameof(AppInfo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static AppInfo AppInfo => _appInfo.Value;

	/// <summary>
	/// Gets the current culture of the application.
	/// </summary>
	/// <value>The current culture.</value>
	/// <remarks>This property provides access to the current culture used by the application. It is a wrapper around <see cref="CultureInfo.CurrentCulture" />.</remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static CultureInfo CurrentCulture => CultureInfo.CurrentCulture;

	/// <summary>
	/// Gets a unique identifier for the current managed thread.
	/// </summary>
	/// <value>The current thread identifier.</value>
	/// <remarks>This property provides the unique identifier of the currently executing thread. It is useful for logging, debugging, or tracking thread-specific operations.</remarks>
	[Information(nameof(CurrentThreadId), "David McCarter", "1/20/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static int CurrentThreadId => _computerInfo.Value.CurrentManagedTreadId;

	/// <summary>
	/// Retrieves the current UI culture used by the application for localization.
	/// </summary>
	/// <value>The current UI culture.</value>
	/// <remarks>This property provides access to the current UI culture used by the application. It is a wrapper around <see cref="CultureInfo.CurrentUICulture" />.
	/// The UI culture is used for string localization, date and number formatting, and other culture-specific operations in the UI.</remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static CultureInfo CurrentUICulture => CultureInfo.CurrentUICulture;

	/// <summary>
	/// Provides a string describing the .NET installation running the application, useful for ensuring compatibility.
	/// </summary>
	/// <value>The framework description.</value>
	/// <example>Example output: ".NET 5.0.6"</example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string FrameworkDescription => RuntimeInformation.FrameworkDescription;

	/// <summary>
	/// Returns the default UI culture installed on the system.
	/// </summary>
	/// <value>The installed UI culture.</value>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static CultureInfo InstalledUICulture => CultureInfo.InstalledUICulture;

	/// <summary>
	/// Describes the architecture (e.g., x86, x64) of the operating system hosting the application.
	/// </summary>
	/// <value>The operating system platform.</value>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Architecture OSArchitecture => RuntimeInformation.OSArchitecture;

	/// <summary>
	/// Gets a string that describes the operating system on which the app is running.
	/// </summary>
	/// <value>The operating system description.</value>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string OSDescription => RuntimeInformation.OSDescription;

	/// <summary>
	/// Gets the process architecture of the currently running app.
	/// </summary>
	/// <value>The process architecture.</value>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Architecture ProcessArchitecture => RuntimeInformation.ProcessArchitecture;

	/// <summary>
	/// Provides the unique identifier for the current process, useful for diagnostics and logging.
	/// </summary>
	/// <value>The process identifier.</value>
	/// <example>Example usage:
	/// <code>
	/// var processId = App.ProcessId;
	/// Console.WriteLine(processId);
	/// </code>
	/// This will output the unique identifier of the current process.
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int ProcessId => Environment.ProcessId;

	/// <summary>
	/// The name of the process currently running, aiding in identification and tracking.
	/// </summary>
	/// <value>The name of the process.</value>
	/// <example>Example usage:
	/// <code>
	/// var processName = App.ProcessName;
	/// Console.WriteLine(processName);
	/// </code>
	/// This will output the name of the current process.
	/// </example>
	[Information(nameof(ProcessName), "David McCarter", "7/26/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ProcessName => Process.GetCurrentProcess().ProcessName;

	/// <summary>
	/// Returns the path of the executable that started the currently executing process. Returns null when the path is not available.
	/// </summary>
	/// <value>The process path.</value>
	[Information(nameof(GetProcessorInformation), "David McCarter", "1/20/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string ProcessPath => _computerInfo.Value.CurrentWorkingDirectory;

	/// <summary>
	/// Gets the stack trace for the current thread.
	/// </summary>
	/// <value>A string that describes the stack trace for the current thread.</value>
	/// <remarks>
	/// This property provides a string representation of the stack trace, which can be useful for debugging purposes.
	/// It includes the sequence of method calls that led to the current point of execution.
	/// </remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string StackTrace => Environment.StackTrace;

	/// <summary>
	/// Gets the working set of the current process.
	/// </summary>
	/// <value>The amount of physical memory mapped to the process context.</value>
	/// <remarks>
	/// This property provides the size of the working set, which is the set of memory pages currently visible to the process in physical RAM.
	/// It includes both shared and private data, such as the pages containing all the instructions that the process executes, as well as the pages containing the process's data.
	/// </remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static long WorkingSet => Environment.WorkingSet;

}
