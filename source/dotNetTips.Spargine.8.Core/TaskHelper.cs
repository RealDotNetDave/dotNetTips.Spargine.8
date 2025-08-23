// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-25-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-25-2025
// ***********************************************************************
// <copyright file="TaskHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Synchronous execution methods for Tasks streamline the process of running asynchronous operations without requiring explicit asynchronous handling. This simplifies code readability and management.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides utility methods for synchronously running asynchronous tasks. This includes methods for running tasks without awaiting them (fire and forget) and for running tasks with return values synchronously.
/// </summary>
[Information(Status = Status.Available)]
public static class TaskHelper
{

	/// <summary>
	/// A TaskFactory configured with default settings for running tasks synchronously.
	/// </summary>
	private static readonly TaskFactory _taskFactory = new(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, TaskScheduler.Default);

	/// <summary>
	/// Executes the specified asynchronous taskFunction synchronously on a background thread.
	/// </summary>
	/// <param name="taskFunction">The asynchronous taskFunction to execute.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="taskFunction"/> is null.</exception>
	/// <example>
	/// TaskHelper.RunSync(() =&gt; SomeType.FireAsync("Test Message"));
	/// </example>
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static void RunSync([NotNull] Func<Task> taskFunction) => _taskFactory.StartNew(taskFunction.ArgumentNotNull(), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();

	/// <summary>
	/// Executes an async Task&lt;T&gt; method which has a TResult return type synchronously.
	/// </summary>
	/// <typeparam name="TResult">The return type of the taskFunction.</typeparam>
	/// <param name="taskFunction">The Task&lt;T&gt; method to execute.</param>
	/// <returns>The result of type TResult.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="taskFunction"/> is null.</exception>
	/// <example>
	/// var result = TaskHelper.RunSync(() => SomeType.CalculateAsync());
	/// </example>
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static TResult RunSync<TResult>([NotNull] this Func<Task<TResult>> taskFunction)
	{
		taskFunction = taskFunction.ArgumentNotNull();

		return _taskFactory.StartNew(taskFunction, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
	}

	/// <summary>
	/// Executes an async Task&lt;T&gt; method which has a TResult return type synchronously, with support for cancellation and custom taskFunction configuration.
	/// </summary>
	/// <typeparam name="TResult">The return type of the taskFunction.</typeparam>
	/// <param name="taskFunction">The Task&lt;T&gt; method to execute.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <param name="taskCreation">The taskFunction creation options.</param>
	/// <param name="taskContinuation">The taskFunction continuation options.</param>
	/// <param name="taskScheduler">The taskFunction scheduler to use.</param>
	/// <returns>The result of type TResult.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="taskFunction"/> is null.</exception>
	/// <example>
	/// var cancelToken = new CancellationTokenSource().Token;
	/// var result = TaskHelper.RunSync(() => SomeType.CalculateAsync(), cancelToken);
	/// </example>
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static TResult RunSync<TResult>([NotNull] Func<Task<TResult>> taskFunction, CancellationToken cancellationToken, TaskCreationOptions taskCreation = TaskCreationOptions.None, TaskContinuationOptions taskContinuation = TaskContinuationOptions.None, TaskScheduler taskScheduler = null)
	{
		taskFunction = taskFunction.ArgumentNotNull();

		taskScheduler ??= TaskScheduler.Default;

		return new TaskFactory(cancellationToken, taskCreation, taskContinuation, taskScheduler)
			.StartNew(taskFunction, cancellationToken)
			.Unwrap()
			.GetAwaiter()
			.GetResult();
	}

	/// <summary>
	/// Executes the specified asynchronous taskFunction synchronously with support for cancellation and custom taskFunction configuration.
	/// </summary>
	/// <param name="taskFunction">The asynchronous taskFunction to execute.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <param name="taskCreation">The taskFunction creation options.</param>
	/// <param name="taskContinuation">The taskFunction continuation options.</param>
	/// <param name="taskScheduler">The taskFunction scheduler to use. If null, the default scheduler is used.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="taskFunction"/> is null.</exception>
	/// <example>
	/// var cancelToken = new CancellationTokenSource().Token;
	/// TaskHelper.RunSync(() => SomeType.FireAsync("Test Message"), cancellationToken: cancelToken);
	/// </example>
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static void RunSync([NotNull] this Func<Task> taskFunction, CancellationToken cancellationToken, TaskCreationOptions taskCreation = TaskCreationOptions.None, TaskContinuationOptions taskContinuation = TaskContinuationOptions.None, TaskScheduler taskScheduler = null)
	{
		taskFunction = taskFunction.ArgumentNotNull();

		taskScheduler ??= TaskScheduler.Default;

		new TaskFactory(cancellationToken, taskCreation, taskContinuation, taskScheduler)
			.StartNew(taskFunction)
			.Unwrap()
			.GetAwaiter()
			.GetResult();
	}

}
