// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 11-06-2023
// ***********************************************************************
// <copyright file="FastLoggerExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for FastLogger.</summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Logging;

/// <summary>
/// Class FastLogger Extensions.
/// </summary>
public static partial class FastLoggerExtensions
{

	/// <summary>
	/// Logs the critical message.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The message.</param>
	/// <param name="exception">The exception.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogCriticalMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "ADD URL")]
	[LoggerMessage(EventId = 912, Level = LogLevel.Critical, EventName = "CRITICAL", Message = "{methodName}: {message}.")]
	public static partial void LogCriticalMessage(this ILogger logger, string message, Exception exception, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs debug message. Adds method name to message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance.</param>
	/// <param name="message">The message.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogDebugMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "ADD URL")]
	[LoggerMessage(EventId = 201, Level = LogLevel.Debug, EventName = "DEBUG", Message = "{methodName}: {message}.")]
	public static partial void LogDebugMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs error message. Adds method name to message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance.</param>
	/// <param name="message">The message.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	/// <example>logger.LogErrorMessage("Processed request failed.");</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogErrorMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "ADD URL")]
	[LoggerMessage(EventId = 301, Level = LogLevel.Error, EventName = "ERROR", Message = "{methodName}: {message}.")]
	public static partial void LogErrorMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs exception. Adds method name to message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance.</param>
	/// <param name="message">The message.</param>
	/// <param name="exception">The <see cref="Exception"/>.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	/// <example>logger.LogCritical("Unable to create connection to CosmosDB.", exception);</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogExceptionMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "ADD URL")]
	[LoggerMessage(EventId = 501, Level = LogLevel.Error, EventName = "EXCEPTION", Message = "{methodName}: {message}.")]
	public static partial void LogExceptionMessage(this ILogger logger, string message, Exception exception, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs the information. Adds method name to message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance.</param>
	/// <param name="message">The message.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	/// <example>logger.LogInformationMessage("Processing request.");</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogInformationMessage), "David McCarter", "2/27/2023", Status = Status.Available)]
	[LoggerMessage(EventId = 401, Level = LogLevel.Information, EventName = "INFORMATION", Message = "{methodName}: {message}.")]
	public static partial void LogInformationMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs a stored procedure error. Adds method name to message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance.</param>
	/// <param name="storedProcedure">The stored procedure.</param>
	/// <param name="exception">The <see cref="Exception"/>.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	/// <example>logger.LogStoredProcedureError("Get_Customers", exception);</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogStoredProcedureError), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "ADD URL")]
	[LoggerMessage(EventId = 502, Level = LogLevel.Error, EventName = "SP ERROR", Message = "{methodName}: Stored procedure error for {storedProcedure}.")]
	public static partial void LogStoredProcedureError(this ILogger logger, string storedProcedure, Exception exception, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs a stored procedure error. Adds method name to message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance.</param>
	/// <param name="storedProcedure">The stored procedure.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	/// <example>logger.LogStoredProcedureError("Get_Customers", exception);</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogStoredProcedureNoRecordsFound), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "ADD URL")]
	[LoggerMessage(EventId = 602, Level = LogLevel.Error, EventName = "SP NO RECORDS ERROR", Message = "{methodName}: No records found from stored procedure {storedProcedure}.")]
	public static partial void LogStoredProcedureNoRecordsFound(this ILogger logger, string storedProcedure, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs trace message. Adds method name to message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance.</param>
	/// <param name="message">The message.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	/// <example>logger.LogTraceMessage($"Entering method {nameof{LogTraceMessage}.");</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogTraceMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "ADD URL")]
	[LoggerMessage(EventId = 101, Level = LogLevel.Trace, EventName = "TRACE", Message = "{methodName}: {message}.")]
	public static partial void LogTraceMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs a warning message. Adds method name to message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance.</param>
	/// <param name="message">The message.</param>
	/// <param name="methodName">NOT REQUIRED</param>
	/// <example>logger.LogWarningMessage("Database connection pool count is low.");</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogWarningMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "ADD URL")]
	[LoggerMessage(EventId = 601, Level = LogLevel.Warning, EventName = "WARNING", Message = "{methodName}: {message}.")]
	public static partial void LogWarningMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

}
