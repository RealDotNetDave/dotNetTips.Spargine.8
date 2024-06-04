// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 04-26-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2024
// ***********************************************************************
// <copyright file="LoggingHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
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
public class LoggingHelperBenchmark : Benchmark
{

	private ILogger<LoggingHelperBenchmark> _logger;

	[Benchmark(Description = nameof(LoggingHelper.LogAppDomainExceptions))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogAppDomainExceptions()
	{
		LoggingHelper.LogAppDomainExceptions(this._logger);
	}

	[Benchmark(Description = nameof(LoggingHelper.LogApplicationInformation))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogApplicationInformation()
	{
		LoggingHelper.LogApplicationInformation(this._logger);
	}

	[Benchmark(Description = nameof(LoggingHelper.LogComputerInformation))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogComputerInformation()
	{
		LoggingHelper.LogComputerInformation(this._logger);
	}

	public override void Setup()
	{
		base.Setup();

		this._logger = new LoggerFactory().CreateLogger<LoggingHelperBenchmark>();
	}

}
