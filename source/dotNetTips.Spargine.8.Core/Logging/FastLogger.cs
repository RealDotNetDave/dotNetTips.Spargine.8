// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 05-01-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-02-2024
// ***********************************************************************
// <copyright file="FastLogger.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// This class efficiently logs to any ILogger object, providing rapid
// logging for Critical, Debug, Error, Exception, Information, Trace,
// and Warning messages.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using Microsoft.Extensions.Logging;

namespace DotNetTips.Spargine.Core.Logging;

/// <summary>
/// Class Logger.
/// </summary>
public static partial class FastLogger
{

	/// <summary>
	/// Logs critical storedProcedure.
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <param name="exception">The exception.</param>
	/// </summary>
	/// <summary>
	/// Logs the critical.
	/// </summary>
	[Information(nameof(LogCritical), author: "David McCarter", createdOn: "1/1/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 911, Level = LogLevel.Critical, EventName = "CRITICAL", Message = "{message}")]
	public static partial void LogCritical(ILogger logger, string message, Exception exception);

	/// <summary>
	/// Logs debug storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <summary>
	/// Logs the debug.
	/// </summary>
	[Information(nameof(LogDebug), author: "David McCarter", createdOn: "1/1/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 200, Level = LogLevel.Debug, EventName = "DEBUG", Message = "{message}")]
	public static partial void LogDebug(ILogger logger, string message);

	/// <summary>
	/// Logs error storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <summary>
	/// Logs the error.
	/// </summary>
	[Information(nameof(LogError), author: "David McCarter", createdOn: "1/1/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 300, Level = LogLevel.Error, EventName = "ERROR", Message = "{message}")]
	public static partial void LogError(ILogger logger, string message);

	/// <summary>
	/// Logs <see cref="Exception"/> along with error storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <param name="exception">The exception.</param>
	/// <summary>
	/// Logs the exception.
	/// </summary>
	[Information(nameof(LogException), author: "David McCarter", createdOn: "1/1/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 500, Level = LogLevel.Error, EventName = "EXCEPTION", Message = "{message}")]
	public static partial void LogException(ILogger logger, string message, Exception exception);

	/// <summary>
	/// Logs information storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <summary>
	/// Logs the information.
	/// </summary>
	[Information(nameof(LogInformation), author: "David McCarter", createdOn: "1/1/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 400, Level = LogLevel.Information, EventName = "INFORMATION", Message = "{message}")]
	public static partial void LogInformation(ILogger logger, string message);

	/// <summary>
	/// Logs trace storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <summary>
	/// Logs the trace.
	/// </summary>
	[Information(nameof(LogTrace), author: "David McCarter", createdOn: "1/1/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 100, Level = LogLevel.Trace, EventName = "TRACE", Message = "{message}")]
	public static partial void LogTrace(ILogger logger, string message);

	/// <summary>
	/// Logs warning storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <summary>
	/// Logs the warning.
	/// </summary>
	[Information(nameof(LogWarning), author: "David McCarter", createdOn: "1/1/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 600, Level = LogLevel.Warning, EventName = "WARNING", Message = "{message}")]
	public static partial void LogWarning(ILogger logger, string message);

}
