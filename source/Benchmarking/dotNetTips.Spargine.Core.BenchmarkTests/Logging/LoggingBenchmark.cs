// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 06-01-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2024
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Logging;

[BenchmarkCategory(Categories.Logging)]
public class LoggingBenchmark : Benchmark
{

	private const string CriticalMessage = "CRITICAL ENTRY";
	private const string DebugMessage = "DEBUG ENTRY";
	private const string ErrorMessage = "ERROR ENTRY";
	private const string InformationMessage = "INFORMATION ENTRY";
	private const string TraceMessage = "TRACE ENTRY";
	private const string WarningMessage = "WARNING ENTRY";

	private ILogger<LoggingBenchmark> _logger;
	private readonly ArgumentInvalidException _testException = new("TEST EX MESSAGE");

	[Benchmark(Description = nameof(FastLogger.LogCritical))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogCritical_EazyLogger_Benchmark()
	{
		FastLogger.LogCritical(logger: this._logger, message: CriticalMessage, exception: this._testException);
	}

	[Benchmark(Description = "ILogger.LogCritical")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogCritical_ILogger_Benchmark()
	{
		this._logger.LogCritical(100, this._testException, DebugMessage);
	}

	[Benchmark(Description = nameof(FastLogger.LogDebug))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogDebug_FastLogger_Benchmark()
	{
		FastLogger.LogDebug(this._logger, DebugMessage);
	}

	[Benchmark(Description = "ILogger.LogDebug")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogDebug_ILogger_Benchmark()
	{
		this._logger.LogDebug(100, this._testException, DebugMessage);
	}

	[Benchmark(Description = nameof(FastLogger.LogError) + ":Error Message")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogError_FastLogger_Benchmark()
	{
		FastLogger.LogError(logger: this._logger, message: ErrorMessage);
	}

	[Benchmark(Description = "ILogger.LogError")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogError_ILogger_Benchmark()
	{
		this._logger.LogError(eventId: 100, exception: this._testException, message: ErrorMessage);
	}

	[Benchmark(Description = nameof(FastLogger.LogException))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogException_FastLogger_Benchmark()
	{
		FastLogger.LogException(logger: this._logger, message: ErrorMessage, this._testException);
	}

	[Benchmark(Description = nameof(FastLogger.LogInformation))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogInformation_FastLogger_Benchmark()
	{
		FastLogger.LogInformation(this._logger, ErrorMessage);
	}

	[Benchmark(Description = "ILogger.LogInformation")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogInformation_ILogger_Benchmark()
	{
		this._logger.LogInformation(100, this._testException, InformationMessage);
	}

	[Benchmark(Description = nameof(FastLogger.LogTrace))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogTrace_FastLogger_Benchmark()
	{
		FastLogger.LogTrace(this._logger, TraceMessage);
	}

	[Benchmark(Description = "ILogger.LogTrace")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogTrace_ILogger_Benchmark()
	{
		this._logger.LogTrace(100, this._testException, TraceMessage);
	}

	[Benchmark(Description = nameof(FastLogger.LogWarning))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogWarning_FastLogger_Benchmark()
	{
		FastLogger.LogWarning(this._logger, WarningMessage);
	}

	[Benchmark(Description = "ILogger.LogWarning")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogWarning_ILogger_Benchmark()
	{
		this._logger.LogWarning(100, this._testException, DebugMessage);
	}

	public override void Setup()
	{
		base.Setup();

		this._logger = new LoggerFactory().CreateLogger<LoggingBenchmark>();
	}

}
