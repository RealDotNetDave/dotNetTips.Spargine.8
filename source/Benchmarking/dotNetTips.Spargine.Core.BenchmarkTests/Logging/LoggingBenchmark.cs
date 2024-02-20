// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 06-01-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-02-2023
// ***********************************************************************
// <copyright file="LoggingBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Logging;

[BenchmarkCategory(Categories.Logging)]
public class LoggingBenchmark : Benchmark
{
	private const string DebugMessage = "DEBUG ENTRY";
	private const string CriticalMessage = "CRITICAL ENTRY";
	private const string ErrorMessage = "ERROR ENTRY";
	private const string TraceMessage = "TRACE ENTRY";
	private const string WarningMessage = "WARNING ENTRY";
	private const string InformationMessage = "INFORMATION ENTRY";
	private ILogger<LoggingBenchmark> _logger;
	private readonly ArgumentInvalidException _testException = new("TEST EX MESSAGE");

	[Benchmark(Description = "EasyLogger.LogCritical")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogCritical_EazyLogger_Benchmark()
	{
		EasyLogger.LogCritical(logger: this._logger, message: CriticalMessage, exception: this._testException);
	}

	[Benchmark(Description = "EasyLogger.LogDebug")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogDebug_EasyLogger_Benchmark()
	{
		EasyLogger.LogDebug(this._logger, DebugMessage);
	}

	[Benchmark(Description = "EasyLogger.LogError")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogError_EasyLogger_Benchmark()
	{
		EasyLogger.LogError(logger: this._logger, message: ErrorMessage);
	}

	[Benchmark(Description = "EasyLogger.LogException")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogException_EasyLogger_Benchmark()
	{
		EasyLogger.LogException(logger: this._logger, message: ErrorMessage, this._testException);
	}

	[Benchmark(Description = "EasyLogger.LogInformation")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogInformation_EasyLogger_Benchmark()
	{
		EasyLogger.LogInformation(this._logger, ErrorMessage);
	}

	[Benchmark(Description = "EasyLogger.LogTrace")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogTrace_EasyLogger_Benchmark()
	{
		EasyLogger.LogTrace(this._logger, TraceMessage);
	}

	[Benchmark(Description = "EasyLogger.Warning")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogWarning_EasyLogger_Benchmark()
	{
		EasyLogger.LogWarning(this._logger, WarningMessage);
	}

	[Benchmark(Description = "ILogger.LogCritical")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogCritical_ILogger_Benchmark()
	{
		this._logger.LogCritical(100, this._testException, DebugMessage);
	}

	[Benchmark(Description = "ILogger.LogDebug")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogDebug_ILogger_Benchmark()
	{
		this._logger.LogDebug(100, this._testException, DebugMessage);
	}

	[Benchmark(Description = "ILogger.LogError")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogError_ILogger_Benchmark()
	{
		this._logger.LogError(eventId: 100, exception: this._testException, message: ErrorMessage);
	}

	[Benchmark(Description = "ILogger.LogInformation")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogInformation_ILogger_Benchmark()
	{
		this._logger.LogInformation(100, this._testException, InformationMessage);
	}

	[Benchmark(Description = "ILogger.LogTrace")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogTrace_ILogger_Benchmark()
	{
		this._logger.LogTrace(100, this._testException, TraceMessage);
	}

	[Benchmark(Description = "ILogger.LogWarning")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogWarning_ILogger_Benchmark()
	{
		this._logger.LogWarning(100, this._testException, DebugMessage);
	}

	[Benchmark(Description = "EasyLoggerExtensions.LogWarningMessage")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogWarning_EazyLoggerExtensions_Benchmark()
	{
		this._logger.LogWarningMessage(DebugMessage);
	}

	[Benchmark(Description = "EasyLoggerExtensions.LogTraceMessage")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogTrace_EazyLoggerExtensions_Benchmark()
	{
		this._logger.LogTraceMessage(TraceMessage);
	}

	[Benchmark(Description = "EasyLoggerExtensions.LogInformationMessage")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogInformation_EazyLoggerExtensions_Benchmark()
	{
		this._logger.LogInformationMessage(InformationMessage);
	}

	[Benchmark(Description = "EasyLoggerExtensions.LogExceptionMessage")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogException_EazyLoggerExtensions_Benchmark()
	{
		this._logger.LogDebugMessage(DebugMessage);
	}

	[Benchmark(Description = "EasyLoggerExtensions.LogCriticalMessage")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogCritical_EazyLoggerExtensions_Benchmark()
	{
		this._logger.LogCriticalMessage(CriticalMessage, this._testException);
	}

	[Benchmark(Description = "EasyLoggerExtensions.LogErrorMessage")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogError_EazyLoggerExtensions_Benchmark()
	{
		this._logger.LogErrorMessage(ErrorMessage);
	}

	[Benchmark(Description = "EasyLoggerExtensions.LogStoredProcedureError")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
	{
		this._logger.LogStoredProcedureError(ErrorMessage, this._testException);
	}

	[Benchmark(Description = "EasyLoggerExtensions.LogStoredProcedureNoRecordsFound")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
	{
		this._logger.LogStoredProcedureNoRecordsFound("sp_load_users");
	}

	public override void Setup()
	{
		base.Setup();

		this._logger = new LoggerFactory().CreateLogger<LoggingBenchmark>();
	}
}
