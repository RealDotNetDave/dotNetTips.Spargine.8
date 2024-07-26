// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 07-26-2024
//
// Last Modified By : David McCarter
// Last Modified On : 07-26-2024
// ***********************************************************************
// <copyright file="AppBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

public class AppBenchmark : Benchmark
{
	[Benchmark]
	public void AppInfo()
	{
		var result = App.AppInfo;

		Consume(result);
	}

	[Benchmark]
	public void CurrentCulture()
	{
		var result = App.CurrentCulture;

		Consume(result);
	}

	[Benchmark]
	public void CurrentThreadId()
	{
		var result = App.CurrentThreadId;

		Consume(result);
	}

	[Benchmark]
	public void CurrentUICulture()
	{
		var result = App.CurrentUICulture;

		Consume(result);
	}

	[Benchmark]
	public void ExecutingFolder()
	{
		var result = App.ExecutingFolder;

		Consume(result);
	}

	[Benchmark]
	public void GetCultureNames()
	{
		var result = App.GetCultureNames;

		Consume(result);
	}

	[Benchmark]
	public void GetEnvironmentVariables()
	{
		var result = App.GetEnvironmentVariables;

		Consume(result);
	}

	[Benchmark]
	public void GetProcessorInformation()
	{
		var result = App.GetProcessorInformation;

		Consume(result);
	}

	[Benchmark]
	public void InstalledUICulture()
	{
		var result = App.InstalledUICulture;

		Consume(result);
	}

	[Benchmark]
	public void IsRunning()
	{
		var result = App.IsRunning;

		Consume(result);
	}

	[Benchmark]
	public void IsRunningFromAspNet()
	{
		var result = App.IsRunningFromAspNet;

		Consume(result);
	}

	[Benchmark]
	public void IsUserAdministrator()
	{
		var result = App.IsUserAdministrator;

		Consume(result);
	}

	[Benchmark]
	public void MaxDegreeOfParallelism()
	{
		var result = App.MaxDegreeOfParallelism;

		Consume(result);
	}

	[Benchmark]
	public void OSArchitecture()
	{
		var result = App.OSArchitecture;

		Consume(result);
	}

	[Benchmark]
	public void OSDescription()
	{
		var result = App.OSDescription;

		Consume(result);
	}

	[Benchmark]
	public void ProcessArchitecture()
	{
		var result = App.ProcessArchitecture;

		Consume(result);
	}

	[Benchmark]
	public void ProcessId()
	{
		var result = App.ProcessId;

		Consume(result);
	}

	[Benchmark]
	public void ProcessName()
	{
		var result = App.ProcessName;

		Consume(result);
	}

	[Benchmark]
	public void ProcessPath()
	{
		var result = App.ProcessPath;

		Consume(result);
	}

	[Benchmark]
	public void ReferencedAssemblies()
	{
		var result = App.ReferencedAssemblies;

		Consume(result);
	}

	[Benchmark]
	public void StackTrace()
	{
		var result = App.StackTrace;

		Consume(result);
	}

	[Benchmark]
	public void WorkingSet()
	{
		var result = App.WorkingSet;

		Consume(result);
	}
}
