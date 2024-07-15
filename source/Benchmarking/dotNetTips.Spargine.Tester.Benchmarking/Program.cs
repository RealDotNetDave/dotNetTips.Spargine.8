// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
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
using DotNetTips.Spargine.Extensions.BenchmarkTests;
using Perfolizer.Horology;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

/// <summary>
/// Class Program.
/// </summary>
public static class Program
{

	/// <summary>
	/// Defines the entry point of the application.
	/// </summary>
	public static void Main()
	{
		try
		{
			var config = DefaultConfig.Instance.AddJob(Job.Default.WithRuntime(CoreRuntime.Core80)).WithSummaryStyle(SummaryStyle.Default.WithTimeUnit(TimeUnit.Nanosecond));

			config = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true);

			//_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

			_ = BenchmarkRunner.Run<ArrayExtensionsCollectionBenchmark>(config);
			_ = BenchmarkRunner.Run<EnumerableExtensionsCollectionBenchmark>(config);
			_ = BenchmarkRunner.Run<ObjectExtensionsBenchmark>(config);
			_ = BenchmarkRunner.Run<ReadOnlyCollectionBenchmark>(config);
			_ = BenchmarkRunner.Run<StringExtensionsBenchmark>(config);
			_ = BenchmarkRunner.Run<StringExtensionsCounterBenchmark>(config);

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
