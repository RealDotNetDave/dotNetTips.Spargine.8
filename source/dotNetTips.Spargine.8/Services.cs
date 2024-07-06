// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="Services.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Convenient helper methods for seamless management of Windows services, offering key features such as loading a service, checking its running status, starting and stopping services, and more.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.ServiceProcess;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine;

/// <summary>
/// Provides a collection of methods for managing and interacting with Windows services and processes.
/// This includes functionality to load, start, stop services, check service existence, and process status.
/// </summary>
[SupportedOSPlatform("windows")]
public static class Services
{

	/// <summary>
	/// Loads the service specified by the service name.
	/// </summary>
	/// <param name="serviceName">The name of the service to load.</param>
	/// <returns>A ServiceController object for the specified service.</returns>
	/// <example>
	/// Here is how you can use the LoadService method:
	/// <code>
	/// var serviceName = "YourServiceName";
	/// var serviceController = Services.LoadService(serviceName);
	/// if(serviceController != null)
	/// {
	///     Console.WriteLine($"Service {serviceName} is loaded.");
	/// }
	/// else
	/// {
	///     Console.WriteLine($"Service {serviceName} could not be found.");
	/// }
	/// </code>
	/// </example>
	[Information(nameof(LoadService), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	private static ServiceController LoadService([NotNull] string serviceName) => Array.Find(ServiceController.GetServices(), p => string.Equals(p.ServiceName, serviceName, StringComparison.Ordinal));

	/// <summary>
	/// Retrieves the names of all services installed on the system.
	/// </summary>
	/// <returns>A read-only collection of strings containing the names of all services.</returns>
	[Information(nameof(AllServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ReadOnlyCollection<string> AllServices() => ServiceController.GetServices().Select(p => p.ServiceName).ToReadOnlyCollection();

	/// <summary>
	/// Determines whether the specified process is already running.
	/// </summary>
	/// <param name="processName">Name of the process.</param>
	/// <returns><c>true</c> if the specified process is running; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the IsProcessRunning method:
	/// <code>
	/// var processName = "notepad";
	/// var isRunning = Services.IsProcessRunning(processName);
	/// Console.WriteLine($"{processName} is running: {isRunning}");
	/// </code>
	/// </example>
	[Information(Status = Status.Available)]
	public static bool IsProcessRunning([NotNull] string processName)
	{
		processName = processName.ArgumentNotNullOrEmpty();

		return Process.GetProcessesByName(processName).Length > 0;
	}

	/// <summary>
	/// Kills the specified process.
	/// </summary>
	/// <param name="processName">Name of the process to kill.</param>
	/// <exception cref="ArgumentNullException">Thrown when the process name is null or empty.</exception>
	/// <example>
	/// Here is how you can use the KillProcess method:
	/// <code>
	/// var processName = "notepad";
	/// Services.KillProcess(processName);
	/// Console.WriteLine($"{processName} has been killed.");
	/// </code>
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static void KillProcess([NotNull] string processName)
	{
		var app = Process.GetProcessesByName(processName.ArgumentNotNullOrEmpty()).FirstOrDefault();

		if (app is not null)
		{
			app.Kill();
			_ = app.WaitForExit(milliseconds: 6000);
		}
	}

	/// <summary>
	/// Checks if the specified service exists on the system.
	/// </summary>
	/// <param name="serviceName">The name of the service to check.</param>
	/// <returns><c>true</c> if the service exists; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the ServiceExists method:
	/// <code>
	/// var serviceName = "MSSQLSERVER";
	/// var exists = Services.ServiceExists(serviceName);
	/// Console.WriteLine($"Service exists: {exists}");
	/// </code>
	/// </example>
	[Information(nameof(ServiceExists), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static bool ServiceExists([NotNull] string serviceName)
	{
		var service = LoadService(serviceName.ArgumentNotNullOrEmpty());

		return service is not null;
	}

	/// <summary>
	/// Gets the current status of the specified service.
	/// </summary>
	/// <param name="serviceName">The name of the service.</param>
	/// <returns>The current status of the service.</returns>
	/// <exception cref="InvalidOperationException">Thrown when the service is not found.</exception>
	/// <example>
	/// Here is how you can use the ServiceStatus method:
	/// <code>
	/// var serviceName = "MSSQLSERVER";
	/// var status = Services.ServiceStatus(serviceName);
	/// Console.WriteLine($"Service status: {status}");
	/// </code>
	/// </example>
	[Information(nameof(ServiceStatus), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceControllerStatus ServiceStatus([NotNull] string serviceName)
	{
		var service = LoadService(serviceName.ArgumentNotNullOrEmpty());
		return service is not null ? service.Status : throw new InvalidOperationException(Resources.ServiceNotFound);
	}

	/// <summary>
	/// Starts the specified service.
	/// </summary>
	/// <param name="serviceName">The name of the service to start.</param>
	/// <returns>A <see cref="ServiceActionResult"/> indicating the result of the operation.</returns>
	/// <example>
	/// Here is how you can use the StartService method:
	/// <code>
	/// var serviceName = "YourServiceName";
	/// var result = Services.StartService(serviceName);
	/// Console.WriteLine($"Service start result: {result}");
	/// </code>
	/// </example>
	[Information(nameof(StartService), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceActionResult StartService([NotNull] string serviceName)
	{
		serviceName = serviceName.ArgumentNotNullOrEmpty();

		var statusResult = ServiceActionResult.Error;

		if (ServiceExists(serviceName) is false)
		{
			return ServiceActionResult.NotFound;
		}

		var service = LoadService(serviceName);

		if (service is not null && service.Status == ServiceControllerStatus.Stopped)
		{
			service.Start();
			statusResult = ServiceActionResult.Running;
		}

		return statusResult;
	}

	/// <summary>
	/// Starts the services specified in the requests collection.
	/// </summary>
	/// <param name="requests">The collection of service action requests.</param>
	[Information(nameof(StartServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StartServices([NotNull] IEnumerable<ServiceAction> requests) => requests.ToList().ForEach(request => request.ServiceActionResult = StartService(request.ServiceName));

	/// <summary>
	/// Starts or stops the specified services based on the action requests.
	/// </summary>
	/// <param name="requests">The collection of service action requests, indicating whether to start or stop each service.</param>
	[Information(nameof(StartStopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StartStopServices([NotNull] IEnumerable<ServiceAction> requests) => requests.ToList().ForEach(request =>
		{
			if (request.ServiceActionRequest == ServiceActionRequest.Start)
			{
				request.ServiceActionResult = StartService(request.ServiceName);
			}
			else if (request.ServiceActionRequest == ServiceActionRequest.Stop)
			{
				request.ServiceActionResult = StopService(request.ServiceName);
			}
		});

	/// <summary>
	/// Stops the specified service.
	/// </summary>
	/// <param name="serviceName">The name of the service to stop.</param>
	/// <returns>A <see cref="ServiceActionResult"/> indicating the result of the operation.</returns>
	/// <example>
	/// Here is how you can use the StopService method:
	/// <code>
	/// var serviceName = "YourServiceName";
	/// var result = Services.StopService(serviceName);
	/// Console.WriteLine($"Service stop result: {result}");
	/// </code>
	/// </example>
	[Information(nameof(StopService), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceActionResult StopService([NotNull] string serviceName)
	{
		serviceName = serviceName.ArgumentNotNullOrEmpty();

		var statusResult = ServiceActionResult.NotFound;

		if (ServiceExists(serviceName) is false)
		{
			return statusResult;
		}

		var service = LoadService(serviceName);

		if (service is not null && service.Status == ServiceControllerStatus.Running)
		{
			service.Stop();
			statusResult = ServiceActionResult.Stopped;
		}

		return statusResult;
	}

	/// <summary>
	/// Stops the services specified in the requests collection.
	/// </summary>
	/// <param name="requests">The collection of service action requests.</param>
	[Information(nameof(StopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StopServices([NotNull] IEnumerable<ServiceAction> requests) => requests.ToList().ForEach(request => request.ServiceActionResult = StopService(request.ServiceName));

}
