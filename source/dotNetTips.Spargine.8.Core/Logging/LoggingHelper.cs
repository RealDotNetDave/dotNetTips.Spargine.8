// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Utility methods designed for logging purposes. Includes functionality
// to log computer information and application details. Additionally,
// it can capture and log all domain exceptions, even if the exception
// originates from a different assembly, covering exceptions from the
// .NET framework.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Logging;

/// <summary>
/// Provides utility methods for logging, including functionality to log computer information, application details, and capture all domain exceptions.
/// </summary>
public static class LoggingHelper
{

	/// <summary>
	/// The application domain exception logger.
	/// </summary>
	/// <remarks>
	/// This logger is used specifically for capturing and logging exceptions that occur within the application domain.
	/// It is set through the <see cref="LogAppDomainExceptions(ILogger)"/> method.
	/// </remarks>
	private static ILogger _appDomainExceptionLogger;

	/// <summary>
	/// Handles the <see cref="AppDomain.FirstChanceException"/> event of the <see cref="AppDomain.CurrentDomain"/> control.
	/// Logs the exception using the <see cref="FastLogger.LogException(ILogger, string, Exception)"/> method.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="FirstChanceExceptionEventArgs"/> instance containing the event data.</param>
	private static void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e) => FastLogger.LogException(_appDomainExceptionLogger, e.Exception.GetAllMessages(), e.Exception);

	/// <summary>
	/// Initializes logging of application domain exceptions.
	/// </summary>
	/// <param name="logger">The logger to use for logging domain exceptions. This cannot be null and is validated by ArgumentNotNull.</param>
	/// <remarks>
	/// Logger can only be set once. If this is called twice or more, it will be ignored.
	/// Utilizes <see cref="AppDomain.CurrentDomain"/> for capturing all exceptions across the application domain.
	/// </remarks>
	[Information(nameof(LogAppDomainExceptions), author: "David McCarter", createdOn: "10/19/2021", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static void LogAppDomainExceptions(ILogger logger)
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
	/// Logs default application information as key/value pairs to the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The logger to use for logging application information. Must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="logger"/> is null.</exception>
	/// <example>
	///   <b>Output:</b>
	/// AppInfo:Company - Microsoft Corporation
	/// AppInfo:Version - 16.8.0
	/// AppInfo:Copyright - © Microsoft Corporation.All rights reserved.
	/// AppInfo:Product - dotNetTips.Spargine
	/// AppInfo:FileVersion - 15.0.0
	/// AppInfo:Title - dotNetTips.Spargine
	/// </example>
	[Information(nameof(LogApplicationInformation), author: "David McCarter", createdOn: "11/03/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
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
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="logger"/> is null.</exception>
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
	[Information(nameof(LogComputerInformation), author: "David McCarter", createdOn: "11/04/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
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
	/// Retrieves all exception messages from the provided exception, including messages from any inner exceptions.
	/// </summary>
	/// <param name="exception">The exception to retrieve messages from. Must not be null.</param>
	/// <returns>A read-only collection of exception messages.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	[Information(nameof(RetrieveAllExceptionMessages), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> RetrieveAllExceptionMessages(Exception exception)
	{
		exception = exception.ArgumentNotNull();

		var exceptions = RetrieveAllExceptions(exception);

		var messages = new List<string>();

		foreach (var ex in exceptions)
		{
			messages.Add(ex.Message);
		}

		return messages.AsReadOnly();
	}

	/// <summary>
	/// Retrieves all exceptions, including inner exceptions, from the provided exception.
	/// </summary>
	/// <param name="exception">The exception from which to retrieve all exceptions, including inner exceptions. Must not be null.</param>
	/// <returns>A read-only collection of all exceptions, including inner exceptions.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	[Information(nameof(RetrieveAllExceptions), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Exception> RetrieveAllExceptions(Exception exception)
	{
		exception = exception.ArgumentNotNull();

		var collection = new List<Exception> { exception };

		if (exception.InnerException is not null)
		{
			collection.AddRange(RetrieveAllExceptions(exception.InnerException));
		}

		return collection.AsReadOnly();
	}

}
