// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 04-21-2025
//
// Last Modified By : David McCarter
// Last Modified On : 08-05-2025
// ***********************************************************************
// <copyright file="IEasyDisposable.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a simplified interface for disposable objects with a default implementation of <see cref="IDisposable.Dispose"/>.
/// </summary>
/// <remarks>
/// This interface offers a default implementation for disposing fields that implement <see cref="IDisposable"/> and tracks disposal state.
/// </remarks>
[Information(Status = Status.Available)]
public interface IEasyDisposable : IDisposable
{
	/// <summary>
	/// Releases resources used by the object.
	/// </summary>
	/// <remarks>
	/// This method disposes all fields of the object that implement <see cref="IDisposable"/> and suppresses finalization.
	/// </remarks> 
	void IDisposable.Dispose()
	{
		// Default implementation for Dispose.  
		DisposeFields(this);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Disposes fields of the specified object that implement <see cref="IDisposable"/>.
	/// </summary>
	/// <param name="obj">The object whose fields should be disposed.</param>
	/// <remarks>
	/// Iterates through all instance fields of the object and disposes any field that implements <see cref="IDisposable"/>.
	/// </remarks>  
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DisposeFields), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	private static void DisposeFields([NotNull] object obj)
	{
		if (obj is null)
		{
			return;
		}

		foreach (var field in obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
		{
			if (typeof(IDisposable).IsAssignableFrom(field.FieldType) && field.GetValue(obj) is IDisposable disposableField)
			{
				disposableField.Dispose();
			}
		}
	}

	/// <summary>
	/// Attempts to dispose the specified object and optionally throws an exception if disposal fails.
	/// </summary>
	/// <param name="obj">The object to dispose.</param>
	/// <param name="throwException">If <c>true</c>, rethrows any exception that occurs during disposal; otherwise, suppresses the exception.</param>
	/// <remarks>
	/// Ensures that disposal is attempted even if an exception occurs, and optionally suppresses the exception.
	/// </remarks>  
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	private static void TryDispose([NotNull] IDisposable obj, bool throwException)
	{
		if (obj is null)
		{
			return;
		}

		try
		{
			obj.Dispose();
		}
		catch
		{
			if (throwException)
			{
				throw;
			}
		}
	}

	/// <summary>
	/// Gets or sets a value indicating whether this instance is disposed.
	/// </summary>
	/// <value>
	/// <c>true</c> if this instance is disposed; otherwise, <c>false</c>.
	/// </value>
	public bool IsDisposed { get; set; }
}
