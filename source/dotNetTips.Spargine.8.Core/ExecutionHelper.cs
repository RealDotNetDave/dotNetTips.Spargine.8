// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-25-2025
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
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Helper class for executing methods with retry logic, including progressive delays between retries.
/// </summary>
/// <remarks>
/// This class provides methods to execute operations with retry logic, which is useful for handling transient faults,
/// especially in network communication or external service calls. The <see cref="ProgressiveRetry"/> method, for example,
/// attempts the provided function multiple times with increasing delay intervals, improving the robustness of applications
/// in unstable network conditions.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class ExecutionHelper
{

	/// <summary>
	/// Provides utility methods for executing operations with retry logic, allowing for progressive delays between retries.
	/// This can be particularly useful for handling transient faults in network communication or external service calls.
	/// </summary>
	/// <param name="operation">The function to execute. Must not be null.</param>
	/// <param name="retryCount">The maximum number of retry attempts.</param>
	/// <param name="retryWaitMilliseconds">The initial wait time in milliseconds before the first retry. This wait time increases progressively with each retry.</param>
	/// <param name="logger">Optional logger to log retry attempts and failures.</param>
	/// <returns>A SimpleResult{int} object that contains the result of the function and the number of attempts made.</returns>
	/// <example>
	/// This example shows how to use the <see cref="ProgressiveRetry"/> method to attempt an function up to 3 times with a progressive delay.
	/// <code>
	/// var result = ExecutionHelper.ProgressiveRetry(() =>
	/// {
	///     // Operation that may fail and need retries
	/// }, 3, 100);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ProgressiveRetry), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineProgressiveRetry")]
	public static SimpleResult<int> ProgressiveRetry([NotNull] Action operation, byte retryCount = 3, int retryWaitMilliseconds = 100, ILogger logger = null)
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
				FastLogger.LogException(logger, $"Attempt {attempts} failed.", ex);

				if (attempts == retryCount)
				{
					return result;
				}

				Task.Delay(retryWaitMilliseconds * attempts).Wait();
			}
		}
	}

	/// <summary>
	/// Executes an function with retry logic asynchronously, allowing for progressive delays between retries.
	/// </summary>
	/// <param name="function">The function to execute. Must not be null.</param>
	/// <param name="retryCount">The maximum number of retry attempts.</param>
	/// <param name="retryWaitMilliseconds">The initial wait time in milliseconds before the first retry. This wait time increases progressively with each retry.</param>
	/// <param name="cancellationToken">The cancellation token to cancel the function.</param>
	/// <param name="logger">Optional logger to log retry attempts and failures.</param>
	/// <returns>A SimpleResult{int} object that contains the result of the function and the number of attempts made.</returns>
	/// <example>
	/// This example shows how to use the <see cref="ProgressiveRetryAsync"/> method to attempt an function up to 3 times with a progressive delay.
	/// <code>
	/// var result = await ExecutionHelper.ProgressiveRetryAsync(async () =>
	/// {
	///     // Operation that may fail and need retries
	/// }, 3, 100);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ProgressiveRetryAsync), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static async Task<SimpleResult<int>> ProgressiveRetryAsync([NotNull] Func<Task> function, byte retryCount = 3, int retryWaitMilliseconds = 100, ILogger logger = null, CancellationToken cancellationToken = default)
	{
		function = function.ArgumentNotNull();
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

				await function().ConfigureAwait(false);

				return result;
			}
			catch (Exception ex) // Catching Exception since the type of Exception is unknown.
			{
				result.AddException(ex);
				FastLogger.LogException(logger, $"Attempt {attempts} failed.", ex);

				if (attempts == retryCount || cancellationToken.IsCancellationRequested)
				{
					return result;
				}

				await Task.Delay(retryWaitMilliseconds * attempts, cancellationToken).ConfigureAwait(false);
			}
		}
	}
}
