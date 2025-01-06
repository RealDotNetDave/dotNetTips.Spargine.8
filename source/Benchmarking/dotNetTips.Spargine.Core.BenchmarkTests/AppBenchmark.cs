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

		this.Consume(result);
	}

	[Benchmark]
	public void CurrentCulture()
	{
		var result = App.CurrentCulture;

		this.Consume(result);
	}

	[Benchmark]
	public void CurrentThreadId()
	{
		var result = App.CurrentThreadId;

		this.Consume(result);
	}

	[Benchmark]
	public void CurrentUICulture()
	{
		var result = App.CurrentUICulture;

		this.Consume(result);
	}

	[Benchmark]
	public void ExecutingFolder()
	{
		var result = App.ExecutingFolder;

		this.Consume(result);
	}

	[Benchmark]
	public void GetCultureNames()
	{
		var result = App.GetCultureNames;

		this.Consume(result);
	}

	[Benchmark]
	public void GetEnvironmentVariables()
	{
		var result = App.GetEnvironmentVariables;

		this.Consume(result);
	}

	[Benchmark]
	public void GetProcessorInformation()
	{
		var result = App.GetProcessorInformation;

		this.Consume(result);
	}

	[Benchmark]
	public void InstalledUICulture()
	{
		var result = App.InstalledUICulture;

		this.Consume(result);
	}

	[Benchmark]
	public void IsRunning()
	{
		var result = App.IsRunning;

		this.Consume(result);
	}

	[Benchmark]
	public void IsRunningFromAspNet()
	{
		var result = App.IsRunningFromAspNet;

		this.Consume(result);
	}

	[Benchmark]
	public void IsUserAdministrator()
	{
		var result = App.IsUserAdministrator;

		this.Consume(result);
	}

	[Benchmark]
	public void MaxDegreeOfParallelism()
	{
		var result = App.MaxDegreeOfParallelism;

		this.Consume(result);
	}

	[Benchmark]
	public void OSArchitecture()
	{
		var result = App.OSArchitecture;

		this.Consume(result);
	}

	[Benchmark]
	public void OSDescription()
	{
		var result = App.OSDescription;

		this.Consume(result);
	}

	[Benchmark]
	public void ProcessArchitecture()
	{
		var result = App.ProcessArchitecture;

		this.Consume(result);
	}

	[Benchmark]
	public void ProcessId()
	{
		var result = App.ProcessId;

		this.Consume(result);
	}

	[Benchmark]
	public void ProcessName()
	{
		var result = App.ProcessName;

		this.Consume(result);
	}

	[Benchmark]
	public void ProcessPath()
	{
		var result = App.ProcessPath;

		this.Consume(result);
	}

	[Benchmark]
	public void ReferencedAssemblies()
	{
		var result = App.ReferencedAssemblies;

		this.Consume(result);
	}

	[Benchmark]
	public void StackTrace()
	{
		var result = App.StackTrace;

		this.Consume(result);
	}

	[Benchmark]
	public void WorkingSet()
	{
		var result = App.WorkingSet;

		this.Consume(result);
	}
}
