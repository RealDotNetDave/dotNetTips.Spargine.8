// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-07-2025
// ***********************************************************************
// <copyright file="ThreadExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for Thread.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Devices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Thread"/> to enhance thread operations.
/// These methods include setting thread priority and implementing wait mechanisms without the need for timers.
/// </summary>
[Information(Status = Status.Available)]
public static class ThreadExtensions
{

	/// <summary>
	/// Tries to set the priority of the specified thread. Validates that <paramref name="thread" /> is not null.
	/// </summary>
	/// <param name="thread">The thread whose priority is to be set. This parameter cannot be null.</param>
	/// <param name="priority">The desired <see cref="ThreadPriority"/> for the thread.</param>
	/// <returns><c>true</c> if the priority was successfully set; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="thread"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="priority"/> is not a defined <see cref="ThreadPriority"/> value.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool TrySetPriority([NotNull] this Thread thread, ThreadPriority priority = ThreadPriority.Normal)
	{
		thread.ArgumentNotNull().Priority = priority.ArgumentDefined();

		return true;
	}

	/// <summary>
	/// Waits for a certain amount of time. Does not use a timer, thus no need to call Dispose.
	/// Validates that <paramref name="thread" /> is not null.
	/// </summary>
	/// <param name="thread">The <see cref="Thread"/> to wait on. This parameter cannot be null.</param>
	/// <param name="interval">The wait interval.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="thread"/> is null.</exception>
	[Information(nameof(WaitUntil), OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void WaitUntil([NotNull] this Thread thread, TimeSpan interval) => WaitUntil(thread.ArgumentNotNull(), interval, 0);

	/// <summary>
	/// Waits until the specified time interval has passed or the specified number of wait iterations has been completed, whichever comes first.
	/// This method performs a spin-wait for a specified number of iterations and checks the thread's alive status.
	/// </summary>
	/// <param name="thread">The <see cref="Thread"/> to monitor. This parameter cannot be null.</param>
	/// <param name="interval">The maximum time to wait.</param>
	/// <param name="waitIterations">The number of iterations to perform a spin-wait. Must be zero or greater.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="thread"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="waitIterations"/> is less than zero.</exception>
	[Information(nameof(WaitUntil), OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void WaitUntil([NotNull] this Thread thread, TimeSpan interval, int waitIterations)
	{
		thread = thread.ArgumentNotNull();
		waitIterations = waitIterations.ArgumentInRange(lower: 0);

		var stopAt = Clock.LocalTime.Add(interval);

		while (thread.IsAlive && Clock.LocalTime < stopAt)
		{
			Thread.SpinWait(waitIterations);
		}
	}

}
