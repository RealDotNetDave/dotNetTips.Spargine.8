// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 04-26-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-14-2024
// ***********************************************************************
// <copyright file="LoggingHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
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

	[Benchmark(Description = nameof(LoggingHelper.RetrieveAllExceptionMessages))]
	[BenchmarkCategory(Categories.Logging)]
	public void RetrieveAllExceptionMessages()
	{
		var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

		var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

		base.Consume(result);
	}

	[Benchmark(Description = nameof(LoggingHelper.RetrieveAllExceptions))]
	[BenchmarkCategory(Categories.Logging)]
	public void RetrieveAllExceptions()
	{
		var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

		var result = LoggingHelper.RetrieveAllExceptions(testException);

		base.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._logger = new LoggerFactory().CreateLogger<LoggingHelperBenchmark>();
	}

}
