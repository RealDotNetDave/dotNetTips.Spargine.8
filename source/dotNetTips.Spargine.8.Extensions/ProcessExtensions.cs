// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="ProcessExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for Process.</summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Process"/> class to manipulate process priorities and execute processes with specific configurations.
/// </summary>
/// <remarks>
/// These extension methods include setting process priority, running processes with custom arguments and handling their output, and more.
/// They are designed to simplify common tasks related to process management in .NET applications.
/// </remarks>
public static class ProcessExtensions
{

	/// <summary>
	/// Ensures the high priority.
	/// Validates that <paramref name="process" /> is not null.
	/// </summary>
	/// <param name="process">The process.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="ArgumentNullException">process</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static void EnsureHighPriority([NotNull] this Process process, [AllowNull] ILogger logger)
	{
		process = process.ArgumentNotNull();

		try
		{
			process.PriorityClass = ProcessPriorityClass.High;
		}
		catch (InvalidOperationException ex)
		{
			if (logger != null)
			{
				LoggerMessage.Define<string>(LogLevel.Error, 0, string.Empty).Invoke(logger, Resources.FailedToSetUpHighPriority, ex);
			}
		}
	}

	/// <summary>
	/// Ensures the low priority.
	/// Validates that <paramref name="process" /> is not null.
	/// </summary>
	/// <param name="process">The process.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="ArgumentNullException">process</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static void EnsureLowPriority([NotNull] this Process process, [AllowNull] ILogger logger)
	{
		process = process.ArgumentNotNull();

		try
		{
			process.PriorityClass = ProcessPriorityClass.BelowNormal;
		}
		catch (InvalidOperationException ex)
		{
			if (logger != null)
			{
				LoggerMessage.Define<string>(LogLevel.Error, 0, string.Empty).Invoke(logger, Resources.FailedToSetUpLowPriority, ex);
			}
		}
	}

	/// <summary>
	/// Runs the process and ignore output.
	/// Validates that <paramref name="fileName" /> and <paramref name="arguments" /> is not null.
	/// </summary>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="arguments">The arguments.</param>
	/// <param name="timeout">The timeout.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentException">fileName</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int RunProcessAndIgnoreOutput([NotNull] this string fileName, [NotNull] string arguments, TimeSpan timeout)
	{
		fileName = fileName.ArgumentNotNullOrEmpty();
		arguments = arguments.ArgumentNotNullOrEmpty();

		var startInfo = new ProcessStartInfo
		{
			FileName = fileName,
			Arguments = arguments,
			RedirectStandardOutput = false,
			RedirectStandardError = false,
			UseShellExecute = false,
			CreateNoWindow = true
		};

		using var process = Process.Start(startInfo);

		if (!process.WaitForExit((int)timeout.TotalMilliseconds))
		{
			process.Kill();
		}

		return process.ExitCode;
	}

	/// <summary>
	/// Runs the process and read output.
	/// Validates that <paramref name="fileName" /> and <paramref name="arguments" /> is not null.
	/// </summary>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="arguments">The arguments.</param>
	/// <param name="timeout">The timeout.</param>
	/// <returns>System.ValueTuple&lt;System.Int32, System.String&gt;.</returns>
	/// <exception cref="ArgumentException">fileName</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static (int exitCode, string output) RunProcessAndReadOutput([NotNull] this string fileName, [NotNull] string arguments, TimeSpan timeout)
	{
		fileName = fileName.ArgumentNotNullOrEmpty();
		arguments = arguments.ArgumentNotNullOrEmpty();

		var startInfo = new ProcessStartInfo
		{
			FileName = fileName,
			Arguments = arguments,
			RedirectStandardOutput = true,
			UseShellExecute = false
		};

		using var process = Process.Start(startInfo);
		if (process.WaitForExit((int)timeout.TotalMilliseconds))
		{
			return (process.ExitCode, process.StandardOutput.ReadToEnd());
		}
		else
		{
			process.Kill();
		}

		return (process.ExitCode, default);
	}

	/// <summary>
	/// Tries the set priority.
	/// </summary>
	/// <param name="process">The process.</param>
	/// <param name="priority">The priority.</param>
	/// <param name="logger">The logger.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">process or logger error</exception>
	/// <exception cref="ArgumentOutOfRangeException">priority</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool TrySetPriority([NotNull] this Process process, ProcessPriorityClass priority, [AllowNull] ILogger logger)
	{
		if (process is null)
		{
			return false;
		}

		priority = priority.ArgumentDefined(nameof(priority));

		try
		{
			process.PriorityClass = priority;
			return true;
		}
		catch (InvalidOperationException ex)
		{
			if (logger != null)
			{
				LoggerMessage.Define<string, string>(LogLevel.Error, 0, formatString: "Failed to set up priority {Priority} for process {Process}. Make sure you have the right permissions.").Invoke(logger, nameof(priority), nameof(process), ex);
			}
		}

		return false;
	}

}
