using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>  
/// Provides a simplified interface for disposable objects with a default implementation of Dispose.  
/// </summary>  
[Information(Status = Status.New)]
public interface IEazyDisposable : IDisposable
{
	/// <summary>  
	/// Releases resources used by the object.  
	/// </summary>  
	/// <remarks>  
	/// This method calls <see cref="Dispose(bool)"/> with <c>true</c> to release both managed and unmanaged resources,  
	/// and suppresses finalization of the object using <see cref="GC.SuppressFinalize(object)"/>.  
	/// </remarks>  
	void IDisposable.Dispose()
	{
		// Default implementation for Dispose.  
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	/// <summary>  
	/// Disposes fields of the object that implement <see cref="IDisposable"/>.  
	/// </summary>  
	/// <param name="obj">The object whose fields should be disposed.</param>  
	/// <remarks>  
	/// This method iterates through all fields of the object and disposes any field that implements <see cref="IDisposable"/>.  
	/// </remarks>  
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DisposeFields), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	private void DisposeFields([NotNull] IDisposable obj)
	{
		if (obj is null)
		{
			return;
		}

		foreach (var field in obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
		{
			if (field.FieldType.IsAssignableTo(typeof(IDisposable)) && field.GetValue(obj) is IDisposable disposableField)
			{

				disposableField.Dispose();
			}
		}
	}


	/// <summary>  
	/// Attempts to dispose the object and optionally throws an exception if disposal fails.  
	/// </summary>  
	/// <param name="obj">The object to dispose.</param>  
	/// <param name="throwException">If <c>true</c>, rethrows any exception that occurs during disposal.</param>  
	/// <remarks>  
	/// This method ensures that disposal is attempted even if an exception occurs, and optionally suppresses the exception.  
	/// </remarks>  
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	private static void TryDispose([NotNull] IDisposable obj, [DoesNotReturnIf(true)] bool throwException)
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
	/// Releases unmanaged and optionally managed resources.  
	/// </summary>  
	/// <param name="disposing">True to release both managed and unmanaged resources; false to release only unmanaged resources.</param>  
	/// <remarks>  
	/// This method is called by <see cref="IDisposable.Dispose"/> and the finalizer (if implemented).  
	/// When <paramref name="disposing"/> is <c>true</c>, it disposes managed resources by calling <see cref="DisposeFields"/>.  
	/// </remarks>  
	public void Dispose(bool disposing)
	{
		if (this.IsDisposed)
		{
			return;
		}

		if (disposing)
		{
			this.DisposeFields(this);
		}

		this.IsDisposed = true;
	}

	/// <summary>  
	/// Gets a value indicating whether the object has already been disposed.  
	/// </summary>  
	/// <value><c>true</c> if the object has been disposed; otherwise, <c>false</c>.</value>  
	public bool IsDisposed { get; internal set; }
}
