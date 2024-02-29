// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 06-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2024
// ***********************************************************************
// <copyright file="SimpleResult.cs" company="David McCarter - dotNetTips.com">
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
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Use for return results from methods. This type is thread-safe.
/// </summary>
/// <typeparam name="T"></typeparam>
[Information(nameof(SimpleResult), author: "David McCarter", createdOn: "6/20/2023", UnitTestCoverage = 0, Documentation = "ADD URL")]
public class SimpleResult<T>
{

	/// <summary>
	/// The exception
	/// </summary>
	private readonly ConcurrentBag<Exception> _exceptions = [];

	/// <summary>
	/// The value
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
	/// <returns>System.String.</returns>
	private string GenerateExceptionMessages() => FastStringBuilder.PerformAction((builder) =>
		   {
			   foreach (var exception in this._exceptions)
			   {
				   _ = builder.AppendLine(exception.GetAllMessages());
			   }
		   });

	/// <summary>
	/// Gets the reference.
	/// </summary>
	/// <param name="result">The result.</param>
	/// <returns>T.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ref readonly T GetReference(in SimpleResult<T> result) => ref result._value;

	/// <summary>
	/// Adds the exception..
	/// </summary>
	/// <param name="error">The error.</param>
	public void AddException(Exception error) => this._exceptions.Add(ExceptionDispatchInfo.Capture(error).SourceException);

	/// <summary>
	/// Gets exceptions associated with this result.
	/// </summary>
	/// <returns>ReadOnlyCollection&lt;Exception&gt;.</returns>
	public ReadOnlyCollection<Exception> Errors() => new(this._exceptions.ToList());

	/// <summary>
	/// Extracts actual result.
	/// </summary>
	/// <param name="result">The result object.</param>
	/// <returns>T.</returns>
	public static T FromResult(in SimpleResult<T> result) => result.ArgumentNotNull().Value;

	/// <summary>
	/// Returns Exception messages, including the InnerException.
	/// </summary>
	/// <returns>The error messages.</returns>
	public string GetErrorMessages() => this.GenerateExceptionMessages();

	/// <summary>
	/// Gets the hash code.
	/// </summary>
	/// <returns>int.</returns>
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
	/// Sets the value.
	/// </summary>
	/// <param name="value">The value.</param>
	public void SetValue(T value) => this._value = value;

	/// <summary>
	/// Returns the error message or the string representation of the value.
	/// </summary>
	/// <returns>The textual representation of this object.</returns>
	public override string ToString() => !this._exceptions.IsEmpty ? this.GenerateExceptionMessages() : this._value?.ToString();

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
	/// Indicates that the result is successful.
	/// </summary>
	/// <value><see langword="true" /> if this result is successful; <see langword="false" /> if this result represents exception.</value>
	public ResultStatus Status
	{
		get
		{
			if (this._exceptions.IsEmpty)
			{
				return ResultStatus.Succeeded;
			}
			else if (this._exceptions.IsEmpty == false && this.Value is not null)
			{
				return ResultStatus.PartialSuccess;
			}
			else
			{
				return ResultStatus.Failed;
			}
		}
	}

	/// <summary>
	/// Extracts the actual result.
	/// </summary>
	/// <value>The value.</value>
	public T Value => this._value;

}

/// <summary>
/// Result Status
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
	public static SimpleResult<T> FromException<T>(Exception e) => new(e);

	/// <summary>
	/// Creates a new instance of <see cref="SimpleResult{T}" /> from the specified value.
	/// </summary>
	/// <typeparam name="T">The type of the value.</typeparam>
	/// <param name="value">The value to be placed to the container.</param>
	/// <returns>The value encapsulated by <see cref="SimpleResult{T}" />.</returns>
	public static SimpleResult<T> FromValue<T>(T value) => new(value);

}

