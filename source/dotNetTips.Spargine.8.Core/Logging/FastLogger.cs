// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 05-01-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="FastLogger.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// This class efficiently logs to any ILogger object, providing rapid
// logging for Critical, Debug, Error, Exception, Information, Trace,
// and Warning messages.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using Microsoft.Extensions.Logging;

namespace DotNetTips.Spargine.Core.Logging;

/// <summary>
/// Provides a set of static methods for logging different levels of information to an <see cref="ILogger"/>. This includes methods for critical, debug, error, exception, information, trace, and warning messages.
/// </summary>
public static partial class FastLogger
{

	/// <summary>
	/// Logs a critical level message and exception using the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> to use for logging.</param>
	/// <param name="message">The message to log.</param>
	/// <param name="exception">The exception to log.</param>
	[Information(nameof(LogCritical), author: "David McCarter", createdOn: "1/1/2022", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 911, Level = LogLevel.Critical, EventName = "CRITICAL", Message = "{message}")]
	public static partial void LogCritical(ILogger logger, string message, Exception exception);

	/// <summary>
	/// Logs a debug level message using the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> to use for logging. Must not be null.</param>
	/// <param name="message">The message to log. Must not be null.</param>
	[Information(nameof(LogDebug), author: "David McCarter", createdOn: "1/1/2022", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 200, Level = LogLevel.Debug, EventName = "DEBUG", Message = "{message}")]
	public static partial void LogDebug(ILogger logger, string message);

	/// <summary>
	/// Logs an error message using the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> to use for logging. Must not be null.</param>
	/// <param name="message">The error message to log. Must not be null.</param>
	[Information(nameof(LogError), author: "David McCarter", createdOn: "1/1/2022", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 300, Level = LogLevel.Error, EventName = "ERROR", Message = "{message}")]
	public static partial void LogError(ILogger logger, string message);

	/// <summary>
	/// Logs an exception along with a custom message using the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> to use for logging the exception and message. Must not be null.</param>
	/// <param name="message">The custom message to log alongside the exception. Must not be null.</param>
	/// <param name="exception">The <see cref="Exception"/> to log. Must not be null.</param>
	[Information(nameof(LogException), author: "David McCarter", createdOn: "1/1/2022", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 500, Level = LogLevel.Error, EventName = "EXCEPTION", Message = "{message}")]
	public static partial void LogException(ILogger logger, string message, Exception exception);

	/// <summary>
	/// Logs an information level message using the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> to use for logging. Must not be null.</param>
	/// <param name="message">The message to log. Must not be null.</param>
	[Information(nameof(LogInformation), author: "David McCarter", createdOn: "1/1/2022", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 400, Level = LogLevel.Information, EventName = "INFORMATION", Message = "{message}")]
	public static partial void LogInformation(ILogger logger, string message);

	/// <summary>
	/// Logs a trace level message using the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> to use for logging. Must not be null.</param>
	/// <param name="message">The message to log. Must not be null.</param>
	[Information(nameof(LogTrace), author: "David McCarter", createdOn: "1/1/2022", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 100, Level = LogLevel.Trace, EventName = "TRACE", Message = "{message}")]
	public static partial void LogTrace(ILogger logger, string message);

	/// <summary>
	/// Logs a warning level message using the specified <see cref="ILogger"/>.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> to use for logging. Must not be null.</param>
	/// <param name="message">The message to log. Must not be null.</param>
	[Information(nameof(LogWarning), author: "David McCarter", createdOn: "1/1/2022", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	[LoggerMessage(EventId = 600, Level = LogLevel.Warning, EventName = "WARNING", Message = "{message}")]
	public static partial void LogWarning(ILogger logger, string message);

}
