// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="FastLoggerExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for FastLogger.</summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Logging;

/// <summary>
/// Extension methods for <see cref="ILogger"/> to simplify logging with enriched messages including the calling method's name.
/// </summary>
public static partial class FastLoggerExtensions
{

	/// <summary>
	/// Logs a critical level message along with an exception using the specified <see cref="ILogger"/>.
	/// This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The critical message to log.</param>
	/// <param name="exception">The <see cref="Exception"/> related to the critical log entry.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogCriticalMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 912, Level = LogLevel.Critical, EventName = "CRITICAL", Message = "{methodName}: {message}.")]
	public static partial void LogCriticalMessage(this ILogger logger, string message, Exception exception, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs a debug level message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The debug message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogDebugMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 201, Level = LogLevel.Debug, EventName = "DEBUG", Message = "{methodName}: {message}.")]
	public static partial void LogDebugMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs an error message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The error message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogErrorMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 301, Level = LogLevel.Error, EventName = "ERROR", Message = "{methodName}: {message}.")]
	public static partial void LogErrorMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs an exception message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The exception message to log.</param>
	/// <param name="exception">The <see cref="Exception"/> that occurred.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogExceptionMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 501, Level = LogLevel.Error, EventName = "EXCEPTION", Message = "{methodName}: {message}.")]
	public static partial void LogExceptionMessage(this ILogger logger, string message, Exception exception, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs an information level message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The information message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogInformationMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 401, Level = LogLevel.Information, EventName = "INFORMATION", Message = "{methodName}: {message}.")]
	public static partial void LogInformationMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs a stored procedure error using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="storedProcedure">The name of the stored procedure that caused the error.</param>
	/// <param name="exception">The <see cref="Exception"/> that was thrown.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogStoredProcedureError), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 502, Level = LogLevel.Error, EventName = "SP ERROR", Message = "{methodName}: Stored procedure error for {storedProcedure}.")]
	public static partial void LogStoredProcedureError(this ILogger logger, string storedProcedure, Exception exception, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs the stored procedure no records found using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="storedProcedure">The name of the stored procedure that returned no records.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogStoredProcedureNoRecordsFound), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 602, Level = LogLevel.Error, EventName = "SP NO RECORDS ERROR", Message = "{methodName}: No records found from stored procedure {storedProcedure}.")]
	public static partial void LogStoredProcedureNoRecordsFound(this ILogger logger, string storedProcedure, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs a trace level message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The trace message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	/// <example>logger.LogTraceMessage($"Entering method {nameof(LogTraceMessage)}.");</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogTraceMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 101, Level = LogLevel.Trace, EventName = "TRACE", Message = "{methodName}: {message}.")]
	public static partial void LogTraceMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

	/// <summary>
	/// Logs a warning message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The warning message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	/// <example>logger.LogWarningMessage("Database connection pool count is low.");</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogWarningMessage), "David McCarter", "2/27/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 601, Level = LogLevel.Warning, EventName = "WARNING", Message = "{methodName}: {message}.")]
	public static partial void LogWarningMessage(this ILogger logger, string message, [CallerMemberName] string methodName = "");

}
