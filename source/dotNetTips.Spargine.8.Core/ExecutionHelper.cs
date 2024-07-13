// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-13-2024
// ***********************************************************************
// <copyright file="ExecutionHelper.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// When making calls to code that might be interrupted by network issues,
// the ProgressiveRetry() method proves beneficial. It automatically
// retries the code multiple times (default is 3) when encountering
// connection problems or other internet-related interruptions.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Helper class for executing methods.
/// </summary>
public static class ExecutionHelper
{

	/// <summary>
	/// Provides utility methods for executing operations with retry logic, allowing for progressive delays between retries.
	/// This can be particularly useful for handling transient faults in network communication or external service calls.
	/// </summary>
	/// <param name="operation">The operation to execute. Must not be null.</param>
	/// <param name="retryCount">The maximum number of retry attempts.</param>
	/// <param name="retryWaitMilliseconds">The initial wait time in milliseconds before the first retry. This wait time increases progressively with each retry.</param>
	/// <returns>A SimpleResult{int} object that contains the result of the operation and the number of attempts made.</returns>
	/// <example>
	/// This example shows how to use the <see cref="ProgressiveRetry"/> method to attempt an operation up to 3 times with a progressive delay.
	/// <code>
	/// var result = ExecutionHelper.ProgressiveRetry(() =>
	/// {
	///     // Operation that may fail and need retries
	/// }, 3, 100);
	/// </code>
	/// </example>
	[Information(nameof(ProgressiveRetry), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Benchmark, Status = Status.NeedsDocumentation)]
	public static SimpleResult<int> ProgressiveRetry([NotNull] Action operation, byte retryCount = 3, int retryWaitMilliseconds = 100)
	{
		operation = operation.ArgumentNotNull();
		retryCount = retryCount.ArgumentInRange(lower: 1, upper: byte.MaxValue);
		retryWaitMilliseconds = retryWaitMilliseconds.ArgumentInRange(lower: 1);

		var attempts = 0;
		var result = new SimpleResult<int>();

		while (true)
		{
			try
			{
				attempts++;
				result.SetValue(attempts);

				operation();

				return result;
			}
			catch (Exception ex) // Catching Exception since the type of Exception is unknown.
			{
				result.AddException(ex);

				if (attempts == retryCount)
				{
					return result;
				}

				Task.Delay(retryWaitMilliseconds * attempts).Wait();
			}
		}
	}

}
