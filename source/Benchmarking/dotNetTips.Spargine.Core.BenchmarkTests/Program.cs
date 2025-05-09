// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-05-2025
// ***********************************************************************
// <copyright file="Program.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Perfolizer.Horology;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Class Program.
/// </summary>
public class Program
{
	/// <summary>
	/// Defines the entry point of the application.
	/// </summary>
	private static void Main()
	{
		try
		{
			var config = DefaultConfig.Instance
				.AddJob(Job.Default.WithRuntime(CoreRuntime.Core80))
				.WithSummaryStyle(SummaryStyle.Default.WithTimeUnit(TimeUnit.Nanosecond));

			config = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true);

			_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

			//_ = BenchmarkRunner.Run<SerializationBenchmark>(config);
			//_ = BenchmarkRunner.Run<LoggingBenchmark>(config);

			ConsoleLogger.Default.WriteLine("COMPLETE!");
			Console.Beep();
			Console.Beep(frequency: 500, duration: 1000);
			Console.Beep(frequency: 750, duration: 2000);
			Console.Beep(frequency: 800, duration: 3000);
			_ = Console.ReadLine();
		}
		catch (Exception ex)
		{
			ConsoleLogger.Default.WriteLine("ERROR!");
			ConsoleLogger.Default.WriteLine(ex.Message);
			Console.Beep(frequency: 5000, duration: 6000);
			_ = Console.ReadLine();
		}
	}
}
