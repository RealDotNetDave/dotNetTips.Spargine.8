// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-09-2024
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Utility methods designed for logging purposes. Includes functionality
// to log computer information and application details. Additionally,
// it can capture and log all domain exceptions, even if the loggableException
// originates from a different assembly, covering exceptions from the
// .NET framework.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ExceptionServices;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Logging;

/// <summary>
/// Provides utility methods for logging, including functionality to log computer information, application details, and capture all domain exceptions and events.
/// </summary>
public static class LoggingHelper
{

	/// <summary>
	/// The logger used for capturing and logging application domain events.
	/// </summary>
	/// <remarks>
	/// This logger is specifically for logging significant application domain events such as assembly load, assembly resolve, domain unload, process exit, and type resolve.
	/// It is set through the <see cref="LogAppDomainEvents(ILogger)"/> method.
	/// </remarks>
	private static ILogger _appDomainEventsLogger;

	/// <summary>
	/// The application domain loggableException logger.
	/// </summary>
	/// <remarks>
	/// This logger is used specifically for capturing and logging exceptions that occur within the application domain.
	/// It is set through the <see cref="LogAppDomainEvents(ILogger)"/> method.
	/// </remarks>
	private static ILogger _appDomainExceptionLogger;

	/// <summary>
	/// The logger used for capturing and logging unhandled exceptions within the application domain.
	/// </summary>
	/// <remarks>
	/// This logger is specifically for logging unhandled exceptions that occur within the application domain, providing a mechanism to log critical issues that could lead to application failure.
	/// It is set through the <see cref="LogAppDomainUnhandledException(ILogger)"/> method.
	/// </remarks>
	private static ILogger _appDomainUnhandledExceptionLogger;

	/// <summary>
	/// Handles the <see cref="AppDomain.AssemblyLoad"/> event. Logs the loaded assembly information using the application domain events logger.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="args">The <see cref="AssemblyLoadEventArgs"/> instance containing the event data, including the loaded assembly.</param>
	/// <remarks>
	/// This method is automatically invoked whenever an assembly is loaded into the application domain. It uses the <see cref="_appDomainEventsLogger"/> to log the name of the loaded assembly.
	/// </remarks>
	private static void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
	{
		if (_appDomainEventsLogger is not null)
		{
			FastLogger.LogDebug(_appDomainEventsLogger, $"Assembly loading: {args.LoadedAssembly.FullName}.");
		}
	}

	/// <summary>
	/// Handles the <see cref="AppDomain.AssemblyResolve"/> event. Attempts to resolve the assembly that failed to load.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="args">The <see cref="ResolveEventArgs"/> instance containing the event data, including the name of the assembly that failed to load.</param>
	/// <returns>The resolved assembly if found; otherwise, null.</returns>
	/// <remarks>
	/// This method is automatically invoked when the resolution of an assembly fails during its load process. It uses the <see cref="_appDomainEventsLogger"/> to log the failure.
	/// Implementations can vary based on how and where the application expects to find its assemblies.
	/// </remarks>
	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		if (_appDomainEventsLogger is not null)
		{
			FastLogger.LogDebug(_appDomainEventsLogger, $"Resolution of an assembly failed: {args.Name}.");
		}

		return null;
	}

	/// <summary>
	/// Handles the <see cref="AppDomain.DomainUnload"/> event. Logs the domain unload information using the application domain events logger.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The event data.</param>
	/// <remarks>
	/// This method is automatically invoked when the application domain is being unloaded. It uses the <see cref="_appDomainEventsLogger"/> to log the unloading event of the <see cref="AppDomain"/>.
	/// </remarks>
	private static void CurrentDomain_DomainUnload(object sender, EventArgs e)
	{
		if (_appDomainEventsLogger is not null)
		{
			FastLogger.LogDebug(_appDomainEventsLogger, $"{AppDomain.CurrentDomain.FriendlyName} domain is unloading.");
		}
	}

	/// <summary>
	/// Handles the <see cref="AppDomain.FirstChanceException"/> event. Logs the exception using the application domain exception logger.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="FirstChanceExceptionEventArgs"/> instance containing the event data, including the exception that was thrown.</param>
	/// <remarks>
	/// This method is automatically invoked whenever an exception is thrown in the application domain, before the runtime searches for exception handlers.
	/// It uses the <see cref="_appDomainExceptionLogger"/> to log the exception details, including the message and stack trace.
	/// If the exception is of type <see cref="LoggableException"/>, it marks the exception as logged.
	/// </remarks>
	private static void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
	{
		if (_appDomainExceptionLogger is not null)
		{
			FastLogger.LogException(_appDomainExceptionLogger, $"FirstChanceException in {AppDomain.CurrentDomain.FriendlyName}:  {e.Exception.Message}", e.Exception);

			if (e.Exception is LoggableException loggableException)
			{
				loggableException.HasBeenLogged = true;
			}
		}
	}

	/// <summary>
	/// Handles the <see cref="AppDomain.ProcessExit"/> event. Logs the process exit information using the application domain events logger.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The event data.</param>
	/// <remarks>
	/// This method is automatically invoked when the process hosting the application domain is exiting. It uses the <see cref="_appDomainEventsLogger"/> to log the exit event of the process.
	/// </remarks>
	private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
	{
		if (_appDomainEventsLogger is not null)
		{
			FastLogger.LogDebug(_appDomainEventsLogger, $"{App.ProcessName} exit.");
		}
	}

	/// <summary>
	/// Handles the <see cref="AppDomain.ReflectionOnlyAssemblyResolve"/> event. Attempts to resolve the assembly that failed to load in a reflection-only context.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="args">The <see cref="ResolveEventArgs"/> instance containing the event data, including the name of the assembly that failed to load.</param>
	/// <returns>The resolved assembly if found; otherwise, null.</returns>
	/// <remarks>
	/// This method is automatically invoked when the resolution of an assembly fails during its load process in a reflection-only context. It uses the <see cref="_appDomainEventsLogger"/> to log the failure.
	/// Implementations can vary based on how and where the application expects to find its assemblies.
	/// </remarks>
	private static Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
	{
		if (_appDomainEventsLogger is not null)
		{
			FastLogger.LogDebug(_appDomainEventsLogger, $"Resolution of a reflection-only assembly failed {args.Name}.");
		}

		return null;
	}

	/// <summary>
	/// Handles the <see cref="AppDomain.ResourceResolve"/> event. Attempts to resolve the resource that failed to load.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="args">The <see cref="ResolveEventArgs"/> instance containing the event data, including the name of the resource that failed to load.</param>
	/// <returns>The resolved assembly if found; otherwise, null.</returns>
	/// <remarks>
	/// This method is automatically invoked when the resolution of a resource fails during its load process. It uses the <see cref="_appDomainEventsLogger"/> to log the failure.
	/// Implementations can vary based on how and where the application expects to find its resources.
	/// </remarks>
	private static Assembly CurrentDomain_ResourceResolve(object sender, ResolveEventArgs args)
	{
		if (_appDomainEventsLogger is not null)
		{
			FastLogger.LogDebug(_appDomainEventsLogger, $"Resolution of a resource failed {args.Name}.");
		}

		return null;
	}

	/// <summary>
	/// Handles the <see cref="AppDomain.TypeResolve"/> event. Attempts to resolve the type that failed to load.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="args">The <see cref="ResolveEventArgs"/> instance containing the event data, including the name of the type that failed to load.</param>
	/// <returns>The resolved assembly if found; otherwise, null.</returns>
	/// <remarks>
	/// This method is automatically invoked when the resolution of a type fails during its load process. It uses the <see cref="_appDomainEventsLogger"/> to log the failure.
	/// Implementations can vary based on how and where the application expects to find its types.
	/// </remarks>
	private static Assembly CurrentDomain_TypeResolve(object sender, ResolveEventArgs args)
	{
		if (_appDomainEventsLogger is not null)
		{
			FastLogger.LogDebug(_appDomainEventsLogger, $"Resolution of a type failed {args.Name}.");
		}

		return null;
	}

	/// <summary>
	/// Handles the <see cref="AppDomain.UnhandledException"/> event. Logs the exception as critical using the application domain unhandled exception logger.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="UnhandledExceptionEventArgs"/> instance containing the event data, including the exception object.</param>
	/// <remarks>
	/// This method is automatically invoked whenever an unhandled exception occurs in the application domain, providing a last chance to log the exception before the application terminates.
	/// It uses the <see cref="_appDomainUnhandledExceptionLogger"/> to log the exception details, including the message and stack trace.
	/// If the exception is of type <see cref="LoggableException"/>, it marks the exception as logged.
	/// </remarks>
	private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		if (_appDomainUnhandledExceptionLogger is not null)
		{
			if (e.ExceptionObject is Exception ex)
			{
				FastLogger.LogCritical(_appDomainUnhandledExceptionLogger, $"UnhandledException in {AppDomain.CurrentDomain.FriendlyName}:  {ex.Message}", ex);

				if (ex is LoggableException loggableException)
				{
					loggableException.HasBeenLogged = true;
				}
			}
		}
	}

	/// <summary>
	/// Initializes logging for various application domain events such as assembly load, assembly resolve, domain unload, process exit, and type resolve.
	/// </summary>
	/// <param name="logger">The logger to use for logging application domain events. This cannot be null.</param>
	/// <remarks>
	/// This method sets up a logger to capture and log significant application domain events, aiding in diagnostics and monitoring of the application's behavior.
	/// It is crucial to call this method early in the application startup process to ensure all relevant domain events are logged.
	/// The logger can only be set once. Subsequent calls to this method will be ignored.
	/// </remarks>
	[Information(nameof(LogAppDomainEvents), author: "David McCarter", createdOn: "7/13/2024", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Documentation = "ADD URL", Status = Status.New)]
	public static void LogAppDomainEvents(ILogger logger)
	{
		logger = logger.ArgumentNotNull();

		if (_appDomainEventsLogger is null)
		{
			_appDomainEventsLogger = logger;
			AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
			AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
			AppDomain.CurrentDomain.DomainUnload += CurrentDomain_DomainUnload;
			AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
			AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ReflectionOnlyAssemblyResolve;
			AppDomain.CurrentDomain.ResourceResolve += CurrentDomain_ResourceResolve;
			AppDomain.CurrentDomain.TypeResolve += CurrentDomain_TypeResolve;

			FastLogger.LogInformation(logger, $"Starting to capture all domain events on {DateTime.UtcNow} UTC");
		}
	}

	/// <summary>
	/// Initializes logging for first chance exceptions within the application domain.
	/// </summary>
	/// <param name="logger">The logger to use for logging first chance exceptions. This cannot be null.</param>
	/// <remarks>
	/// This method sets up a logger to capture first chance exceptions that occur within the application domain.
	/// First chance exceptions are exceptions that are thrown but may be handled by the application.
	/// It is important to call this method early in the application startup process to ensure all first chance exceptions are logged.
	/// The logger can only be set once. Subsequent calls to this method will be ignored.
	/// </remarks>
	[Information(nameof(LogAppDomainFirstChanceException), author: "David McCarter", createdOn: "10/19/2021", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Documentation = "https://bit.ly/SpargineJan2022", Status = Status.Available)]
	public static void LogAppDomainFirstChanceException(ILogger logger)
	{
		logger = logger.ArgumentNotNull();

		if (_appDomainExceptionLogger is null)
		{
			_appDomainExceptionLogger = logger;
			AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

			FastLogger.LogInformation(logger, $"Starting to capture all exceptions on {DateTime.UtcNow} UTC");
		}
	}

	/// <summary>
	/// Initializes logging for unhandled exceptions as critical within the application domain.
	/// </summary>
	/// <param name="logger">The logger to use for logging unhandled domain exceptions. This cannot be null.</param>
	/// <remarks>
	/// This method sets up a logger to capture unhandled exceptions that occur within the application domain.
	/// It is important to call this method early in the application startup process to ensure all unhandled exceptions are logged.
	/// Logger can only be set once. Subsequent calls to this method will be ignored.
	/// </remarks>
	[Information(nameof(LogAppDomainUnhandledException), author: "David McCarter", createdOn: "7/13/2024", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Documentation = "ADD URL", Status = Status.New)]
	public static void LogAppDomainUnhandledException(ILogger logger)
	{
		logger = logger.ArgumentNotNull();

		if (_appDomainUnhandledExceptionLogger is not null)
		{
			_appDomainUnhandledExceptionLogger = logger;
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

			FastLogger.LogInformation(logger, $"Starting to capture unhandled exceptions on {DateTime.UtcNow} UTC");
		}
	}

	/// <summary>
	/// Logs default application information as key/value pairs to the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The logger to use for logging application information. Must not be null.</param>
	/// <loggableException cref="ArgumentNullException">Thrown if <paramref name="logger"/> is null.</loggableException>
	/// <example>
	///   <b>Output:</b>
	/// AppInfo:Company - Microsoft Corporation
	/// AppInfo:Version - 16.8.0
	/// AppInfo:Copyright - © Microsoft Corporation.All rights reserved.
	/// AppInfo:Product - dotNetTips.Spargine
	/// AppInfo:FileVersion - 15.0.0
	/// AppInfo:Title - dotNetTips.Spargine
	/// </example>
	[Information(nameof(LogApplicationInformation), author: "David McCarter", createdOn: "11/03/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static void LogApplicationInformation(ILogger logger)
	{
		logger = logger.ArgumentNotNull();

		var appInfo = App.AppInfo;

		var values = TypeHelper.GetPropertyValues(input: appInfo);

		if (values?.FastCount() > 0)
		{
			//FrozenSet is slower.
			foreach (var item in values.OrderBy(p => p.Key))
			{
				FastLogger.LogInformation(logger, $"{nameof(AppInfo)}:{item.Key} - {item.Value}");
			}
		}
	}

	/// <summary>
	/// Logs detailed computer information, such as OS, architecture, and memory usage, to the specified logger.
	/// </summary>
	/// <param name="logger">The logger to use for logging computer information. Must not be null.</param>
	/// <loggableException cref="ArgumentNullException">Thrown if <paramref name="logger"/> is null.</loggableException>
	/// <example>OUTPUT:
	/// AppInfo:Is64BitProcess - True
	/// AppInfo:ProcessArchitecture - X64
	/// AppInfo:CurrentStackTrace - at System.Environment.get_StackTrace()\r\n at
	/// .Standard.ComputerInfo..ctor() in...
	/// AppInfo:ComputerCulture - eng
	/// AppInfo:UserName - david
	/// AppInfo:IsUserInteractive - True
	/// AppInfo:OsMemoryPageSize - 4096
	/// AppInfo:FrameworkVersion - 3.1.10
	/// AppInfo:IPAddress - 192.168.0.7
	/// AppInfo:Is64BitOperatingSystem - True
	/// AppInfo:CurrentSystemTickCount - 185990421
	/// AppInfo:ComputerUICulture - eng
	/// AppInfo:ProcessorCount - 4
	/// AppInfo:FrameworkDescription - .NET Core 3.1.10
	/// AppInfo:PhysicalMemoryInUse - 49123328
	/// AppInfo:OSArchitecture - X64
	/// AppInfo:CurrentManagedTreadId - 6
	/// AppInfo:CurrentWorkingDirectory - C:\\src\\GitHub\\dotNetTips.Utility.Core\\src\\Unit Tests\\dotNetTips.Utility.Standard.Tests\\bin\\Debug\\netcoreapp3.1
	/// AppInfo:MachineName - DOTNETTIPS
	/// AppInfo:OSDescription - Microsoft Windows 10.0.19042
	/// AppInfo:UserDomainName - DOTNETTIPS
	/// AppInfo:SystemDirectory - C:\\WINDOWS\\system32
	/// AppInfo:HasShutdownStarted - False
	/// </example>
	[Information(nameof(LogComputerInformation), author: "David McCarter", createdOn: "11/04/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static void LogComputerInformation(ILogger logger)
	{
		logger = logger.ArgumentNotNull();

		var computerInfo = new ComputerInfo();

		var values = TypeHelper.GetPropertyValues(computerInfo);

		if (values?.FastCount() > 0)
		{
			//FrozenSet is slower.
			foreach (var item in values.OrderBy(p => p.Key))
			{
				logger.LogDebugMessage($"{nameof(ComputerInfo)}:{item.Key} - {item.Value}");
			}
		}
	}

	/// <summary>
	/// Retrieves all Exception messages from the provided Exception, including messages from any inner exceptions.
	/// </summary>
	/// <param name="exception">The exception to retrieve messages from. Must not be null.</param>
	/// <returns>A read-only collection of exception messages.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	/// <example>
	/// <code>
	/// try
	/// {
	///     // Some code that throws an exception
	/// }
	/// catch (Exception ex)
	/// {
	///     var messages = LoggingHelper.RetrieveAllExceptionMessages(ex);
	///     foreach (var message in messages)
	///     {
	///         Console.WriteLine(message);
	///     }
	/// }
	/// </code>
	/// </example>
	[Information(nameof(RetrieveAllExceptionMessages), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static ReadOnlyCollection<string> RetrieveAllExceptionMessages(Exception exception)
	{
		exception = exception.ArgumentNotNull();

		var exceptions = RetrieveAllExceptions(exception);

		var messages = new List<string>(exceptions.Count);

		foreach (var ex in exceptions)
		{
			messages.Add(ex.Message);
		}

		return messages.AsReadOnly();
	}

	/// <summary>
	/// Retrieves all exceptions, including inner exceptions, from the provided Exception.
	/// </summary>
	/// <param name="exception">The exception from which to retrieve all exceptions, including inner exceptions. Must not be null.</param>
	/// <returns>A read-only collection of all exceptions, including inner exceptions.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	/// <example>
	/// <code>
	/// try
	/// {
	///     // Some code that throws an exception
	/// }
	/// catch (Exception ex)
	/// {
	///     var exceptions = LoggingHelper.RetrieveAllExceptions(ex);
	///     foreach (var ex in exceptions)
	///     {
	///         Console.WriteLine(ex.Message);
	///     }
	/// }
	/// </code>
	/// </example>
	[Information(nameof(RetrieveAllExceptions), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.CheckPerformance, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static ReadOnlyCollection<Exception> RetrieveAllExceptions(Exception exception)
	{
		exception = exception.ArgumentNotNull();

		var collection = new List<Exception>();

		for (var currentException = exception; currentException is not null; currentException = currentException.InnerException)
		{
			collection.Add(currentException);
		}

		return collection.AsReadOnly();
	}

}
