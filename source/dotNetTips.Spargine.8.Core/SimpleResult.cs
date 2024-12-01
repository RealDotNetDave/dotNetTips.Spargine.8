// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 06-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2024
// ***********************************************************************
// <copyright file="SimpleResult.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Enables methods to return a value, a status, and exception information
// as needed. This comprehensive approach provides flexibility in
// handling various outcomes.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Use for return results from methods. This type is thread-safe.
/// </summary>
/// <typeparam name="T"></typeparam>
[Information(nameof(SimpleResult), author: "David McCarter", createdOn: "6/20/2023", Status = Core.Status.NeedsDocumentation)]
public class SimpleResult<T>
{

	/// <summary>
	/// The collection of exceptions associated with this result.
	/// </summary>
	private readonly ConcurrentBag<Exception> _exceptions = [];

	/// <summary>
	/// The value associated with this result.
	/// </summary>
	private T _value;

	/// <summary>
	/// Initializes a new instance of the <see cref="SimpleResult{T}" /> class.
	/// </summary>
	public SimpleResult()
	{
	}

	/// <summary>
	/// Initializes a new successful result.
	/// </summary>
	/// <param name="value">The value to be stored as result.</param>
	public SimpleResult(T value) => this.SetValue(value);

	/// <summary>
	/// Initializes a new unsuccessful result.
	/// </summary>
	/// <param name="error">The exception representing error. Cannot be <see langword="null" />.</param>
	public SimpleResult(Exception error) => this.AddException(error);

	/// <summary>
	/// Generates the exception messages.
	/// </summary>
	/// <returns>A string containing all exception messages.</returns>
	[return: NotNull]
	private string GenerateExceptionMessages() => FastStringBuilder.PerformAction((builder) =>
		   {
			   foreach (var exception in this._exceptions)
			   {
				   _ = builder.AppendLine(exception.GetAllMessages());
			   }
		   });

	/// <summary>
	/// Gets the reference to the value associated with the specified result.
	/// </summary>
	/// <param name="result">The result object containing the value.</param>
	/// <returns>A reference to the value of type <typeparamref name="T"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ref readonly T GetReference([NotNull] in SimpleResult<T> result) => ref result._value;

	/// <summary>
	/// Adds an exception to the collection of exceptions. This method captures the exception
	/// and stores it, allowing multiple exceptions to be associated with a single result.
	/// </summary>
	/// <param name="error">The exception to add. Cannot be <see langword="null"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="error"/> is <see langword="null"/>.</exception>
	public void AddException([NotNull] Exception error)
	{
		error = error.ArgumentNotNull();

		this._exceptions.Add(ExceptionDispatchInfo.Capture(error).SourceException);
	}

	/// <summary>
	/// Gets exceptions associated with this result.
	/// </summary>
	/// <returns>ReadOnlyCollection&lt;Exception&gt;.</returns>
	public ReadOnlyCollection<Exception> Errors() => new([.. this._exceptions]);

	/// <summary>
	/// Extracts the actual result from the specified <see cref="SimpleResult{T}"/>.
	/// </summary>
	/// <param name="result">The result object containing the value.</param>
	/// <returns>The value of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="result"/> is <see langword="null"/>.</exception>
	public static T FromResult([NotNull] in SimpleResult<T> result) => result.ArgumentNotNull().Value;

	/// <summary>
	/// Returns the error messages, including the InnerException, if any.
	/// </summary>
	/// <returns>A string containing all error messages.</returns>
	public string GetErrorMessages() => this.GenerateExceptionMessages();

	/// <summary>
	/// Gets the hash code for the current instance.
	/// </summary>
	/// <returns>An integer representing the hash code of the current instance.</returns>
	public override int GetHashCode() => base.GetHashCode();

	/// <summary>
	/// Returns the value if present; otherwise return the default value.
	/// </summary>
	/// <param name="defaultValue">The value to be returned if this result is unsuccessful.</param>
	/// <returns>The value, if present, otherwise <paramref name="defaultValue" />.</returns>
	public T Or(T defaultValue) => this._exceptions.Count is 0 ? this._value : defaultValue;

	/// <summary>
	/// Returns the value if present; otherwise return default value.
	/// </summary>
	/// <returns>The value, if present, otherwise <c>default</c>.</returns>
	public T OrDefault() => this._value;

	/// <summary>
	/// Sets the value associated with this result.
	/// </summary>
	/// <param name="value">The value to be set.</param>
	public void SetValue(T value) => this._value = value;

	/// <summary>
	/// Returns the error message or the string representation of the value.
	/// </summary>
	/// <returns>The textual representation of this object.</returns>
	public override string ToString() => this._exceptions.IsEmpty ? this._value?.ToString() ?? string.Empty : this.GenerateExceptionMessages();

	/// <summary>
	/// Attempts to extract value if it is present.
	/// </summary>
	/// <param name="value">Extracted value.</param>
	/// <returns><see langword="true" /> if value is present; otherwise, <see langword="false" />.</returns>
	public bool TryGet(out T value)
	{
		value = this._value;
		return !this._exceptions.IsEmpty;
	}

	/// <summary>
	/// Indicates the status of the result.
	/// </summary>
	/// <value>
	/// <see cref="ResultStatus.Succeeded"/> if the result is successful; 
	/// <see cref="ResultStatus.PartialSuccess"/> if there are exceptions but a value is present;
	/// otherwise, <see cref="ResultStatus.Failed"/>.
	/// </value>>
	public ResultStatus Status
	{
		get
		{
			if (this._exceptions.IsEmpty)
			{
				return ResultStatus.Succeeded;
			}
			return this._value is not null ? ResultStatus.PartialSuccess : ResultStatus.Failed;
		}
	}

	/// <summary>
	/// Gets the value associated with this result.
	/// </summary>
	/// <value>The value of type <typeparamref name="T"/>.</value>
	public T Value => this._value;

}

/// <summary>
/// Represents the status of a result.
/// </summary>
public enum ResultStatus
{
	/// <summary>
	/// The action has failed
	/// </summary>
	Failed,

	/// <summary>
	/// The action has succeeded
	/// </summary>
	Succeeded,

	/// <summary>
	/// The action had partial success
	/// </summary>
	PartialSuccess,
}

/// <summary>
/// Represents extension methods for type <see cref="SimpleResult{T}" />.
/// </summary>
public static class SimpleResult
{

	/// <summary>
	/// Creates a new instance of <see cref="SimpleResult{T}" /> from the specified exception.
	/// </summary>
	/// <typeparam name="T">The type of the value.</typeparam>
	/// <param name="e">The exception to be placed to the container.</param>
	/// <returns>The exception encapsulated by <see cref="SimpleResult{T}" />.</returns>
	public static SimpleResult<T> FromException<T>([NotNull] Exception e) => new(e);

	/// <summary>
	/// Creates a new instance of <see cref="SimpleResult{T}" /> from the specified value.
	/// </summary>
	/// <typeparam name="T">The type of the value.</typeparam>
	/// <param name="value">The value to be placed to the container.</param>
	/// <returns>The value encapsulated by <see cref="SimpleResult{T}" />.</returns>
	public static SimpleResult<T> FromValue<T>([NotNull] T value) => new(value);

}
