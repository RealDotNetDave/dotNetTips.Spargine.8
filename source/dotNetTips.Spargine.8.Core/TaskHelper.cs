// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-25-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-09-2024
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
public static class TaskHelper
{

	/// <summary>
	/// A TaskFactory configured with default settings for running tasks synchronously.
	/// </summary>
	private static readonly TaskFactory _taskFactory = new(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, TaskScheduler.Default);

	/// <summary>
	/// Executes the specified asynchronous task synchronously on a background thread.
	/// </summary>
	/// <param name="task">The asynchronous task to execute.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="task"/> is null.</exception>
	/// <example>
	/// TaskHelper.RunSync(() =&gt; SomeType.FireAsync("Test Message"));
	/// </example>
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static void RunSync([NotNull] Func<Task> task) => _taskFactory.StartNew(task.ArgumentNotNull(), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();

	/// <summary>
	/// Executes an async Task&lt;T&gt; method which has a TResult return type synchronously.
	/// </summary>
	/// <typeparam name="TResult">The return type of the task.</typeparam>
	/// <param name="task">The Task&lt;T&gt; method to execute.</param>
	/// <returns>The result of type TResult.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="task"/> is null.</exception>
	/// <example>
	/// var result = TaskHelper.RunSync(() => SomeType.CalculateAsync());
	/// </example>
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static TResult RunSync<TResult>([NotNull] this Func<Task<TResult>> task)
	{
		task = task.ArgumentNotNull();

		return _taskFactory.StartNew(task, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
	}

	/// <summary>
	/// Executes an async Task&lt;T&gt; method which has a TResult return type synchronously, with support for cancellation and custom task configuration.
	/// </summary>
	/// <typeparam name="TResult">The return type of the task.</typeparam>
	/// <param name="func">The Task&lt;T&gt; method to execute.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <param name="taskCreation">The task creation options.</param>
	/// <param name="taskContinuation">The task continuation options.</param>
	/// <param name="taskScheduler">The task scheduler to use.</param>
	/// <returns>The result of type TResult.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="func"/> is null.</exception>
	/// <example>
	/// var cancelToken = new CancellationTokenSource().Token;
	/// var result = TaskHelper.RunSync(() => SomeType.CalculateAsync(), cancelToken);
	/// </example>
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static TResult RunSync<TResult>([NotNull] Func<Task<TResult>> func, CancellationToken cancellationToken, TaskCreationOptions taskCreation = TaskCreationOptions.None, TaskContinuationOptions taskContinuation = TaskContinuationOptions.None, TaskScheduler taskScheduler = null)
	{
		func = func.ArgumentNotNull();

		taskScheduler ??= TaskScheduler.Default;

		return new TaskFactory(cancellationToken, taskCreation, taskContinuation, taskScheduler)
			.StartNew(func, cancellationToken)
			.Unwrap()
			.GetAwaiter()
			.GetResult();
	}

	/// <summary>
	/// Executes the specified asynchronous task synchronously with support for cancellation and custom task configuration.
	/// </summary>
	/// <param name="task">The asynchronous task to execute.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <param name="taskCreation">The task creation options.</param>
	/// <param name="taskContinuation">The task continuation options.</param>
	/// <param name="taskScheduler">The task scheduler to use. If null, the default scheduler is used.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="task"/> is null.</exception>
	/// <example>
	/// var cancelToken = new CancellationTokenSource().Token;
	/// TaskHelper.RunSync(() => SomeType.FireAsync("Test Message"), cancellationToken: cancelToken);
	/// </example>
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static void RunSync([NotNull] this Func<Task> task, CancellationToken cancellationToken, TaskCreationOptions taskCreation = TaskCreationOptions.None, TaskContinuationOptions taskContinuation = TaskContinuationOptions.None, TaskScheduler taskScheduler = null)
	{
		task = task.ArgumentNotNull();

		taskScheduler ??= TaskScheduler.Default;

		new TaskFactory(cancellationToken, taskCreation, taskContinuation, taskScheduler)
			.StartNew(task)
			.Unwrap()
			.GetAwaiter()
			.GetResult();
	}

}
