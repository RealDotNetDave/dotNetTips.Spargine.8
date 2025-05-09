// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="ExceptionExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods tailored for Exception.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for enhancing the functionality of the <see cref="Exception"/> class.
/// These methods include getting all messages, checking if an exception is critical or fatal, and more.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class ExceptionExtensions
{

	/// <summary>
	/// Returns an enumerable collection representing the hierarchy of exceptions starting from the specified source exception.
	/// This method is useful for traversing nested exceptions (e.g., when dealing with aggregate exceptions).
	/// </summary>
	/// <typeparam name="TSource">The type of the source exception, must derive from <see cref="Exception"/>.</typeparam>
	/// <param name="source">The source exception to start traversing from.</param>
	/// <param name="accumulatorFunction">A delegate that defines the method to retrieve the next exception in the hierarchy.</param>
	/// <returns>An <see cref="IEnumerable{TSource}"/> that represents the hierarchy of exceptions.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> or <paramref name="accumulatorFunction"/> is null.</exception>
	[Information(nameof(FromHierarchy), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, Func<TSource, TSource> accumulatorFunction) where TSource : Exception
	{
		source = source.ArgumentNotNull();
		accumulatorFunction = accumulatorFunction.ArgumentNotNull();

		return FromHierarchy(source, accumulatorFunction, s => s is not null);
	}

	/// <summary>
	/// Returns the hierarchy from the source, validating that <paramref name="source"/>, <paramref name="nextItem"/>, and <paramref name="canContinuePreducate"/> are not null.
	/// This method allows traversing a hierarchy (e.g., of exceptions) by repeatedly applying <paramref name="nextItem"/> to get the next item in the hierarchy,
	/// until <paramref name="canContinuePreducate"/> returns false.
	/// </summary>
	/// <typeparam name="TSource">The type of the source items in the hierarchy.</typeparam>
	/// <param name="source">The starting item in the hierarchy.</param>
	/// <param name="nextItem">A function to get the next item in the hierarchy from the current item.</param>
	/// <param name="canContinuePreducate">A function that determines whether to continue traversing the hierarchy from the current item.</param>
	/// <returns>A sequence of items from the source up through the hierarchy as determined by <paramref name="nextItem"/> and <paramref name="canContinuePreducate"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/>, <paramref name="nextItem"/>, or <paramref name="canContinuePreducate"/> is null.</exception>
	[Information(nameof(FromHierarchy), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, Func<TSource, TSource> nextItem, Func<TSource, bool> canContinuePreducate)
		where TSource : Exception
	{
		source = source.ArgumentNotNull();
		nextItem = nextItem.ArgumentNotNull();
		canContinuePreducate = canContinuePreducate.ArgumentNotNull();

		while (source != null && canContinuePreducate(source))
		{
			yield return source;
			source = nextItem(source);
		}
	}

	/// <summary>
	/// Gets all messages from an <see cref="Exception"/> and its inner exceptions, concatenated into a single string.
	/// </summary>
	/// <param name="exception">The exception to extract messages from.</param>
	/// <param name="delimiter">The character used to separate individual exception messages in the resulting string. Defaults to a comma.</param>
	/// <returns>A string containing all exception messages, separated by the specified delimiter.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	[Information(nameof(GetAllMessages), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static string GetAllMessages(this Exception exception, [ConstantExpected] char delimiter = ControlChars.Comma)
	{
		exception = exception.ArgumentNotNull();

		var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);

		return FastStringBuilder.Join(messages, delimiter);
	}

	/// <summary>
	/// Gets all messages and their stack traces from an <see cref="Exception"/> and its inner exceptions, encapsulating them into a read-only collection.
	/// Each tuple in the collection contains the message and the stack trace of an exception.
	/// If the stack trace is null, "NONE" is used as a placeholder.
	/// </summary>
	/// <param name="exception">The exception to extract messages and stack traces from.</param>
	/// <returns>A <see cref="ReadOnlyCollection{T}"/> where each item is a tuple containing the message and stack trace of an exception.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	[Information(nameof(GetAllMessagesWithStackTrace), author: "David McCarter", createdOn: "10/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static ReadOnlyCollection<(string message, string StackTrace)> GetAllMessagesWithStackTrace([NotNull] this Exception exception)
	{
		exception = exception.ArgumentNotNull();

		var result = new List<(string message, string StackTrace)>();

		foreach (var ex in exception.FromHierarchy(ex => ex.InnerException))
		{
			result.Add((ex.Message, ex.StackTrace ?? "NONE"));
		}

		return result.ToReadOnlyCollection();
	}

	/// <summary>
	/// Determines whether the specified <see cref="Exception"/> is considered critical. A critical exception is one of the following types:
	/// <see cref="NullReferenceException"/>, <see cref="StackOverflowException"/>, <see cref="OutOfMemoryException"/>, <see cref="ThreadAbortException"/>,
	/// <see cref="IndexOutOfRangeException"/>, or <see cref="AccessViolationException"/>.
	/// </summary>
	/// <param name="exception">The exception to check.</param>
	/// <returns><c>true</c> if the exception is critical; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsCritical(this Exception exception) => exception.IsNull()
			? false
			: exception is NullReferenceException or
		StackOverflowException or
		OutOfMemoryException or
		ThreadAbortException or
		IndexOutOfRangeException or
		AccessViolationException;

	/// <summary>
	/// Determines whether the specified <see cref="Exception"/> is fatal. A fatal exception is one that is severe enough to justify terminating the application, such as <see cref="OutOfMemoryException"/>.
	/// </summary>
	/// <param name="exception">The exception to check.</param>
	/// <returns><c>true</c> if the exception is fatal; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsFatal(this Exception exception) => exception.IsNull() ? false : exception is OutOfMemoryException;

	/// <summary>
	/// Determines whether the specified <see cref="Exception"/> is either a <see cref="SecurityException"/> or considered critical.
	/// A critical exception is one of the types identified by the <see cref="IsCritical"/> method.
	/// </summary>
	/// <param name="exception">The exception to check.</param>
	/// <returns><c>true</c> if the exception is a <see cref="SecurityException"/> or critical; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsSecurityOrCritical(this Exception exception) => exception.IsNull() ? false : (exception is SecurityException) || exception.IsCritical();

	/// <summary>
	/// Traverses the exception hierarchy starting from the specified exception to find an exception of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of exception to search for.</typeparam>
	/// <param name="exception">The starting exception for the traversal.</param>
	/// <returns>An exception of type <typeparamref name="T"/> if found; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	[Information(nameof(TraverseFor), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T TraverseFor<T>(this Exception exception)
		where T : class
	{
		exception = exception.ArgumentNotNull();

		while (exception != null)
		{
			if (exception is T targetException)
			{
				return targetException;
			}

			exception = exception.InnerException;
		}

		return null;
	}
}
