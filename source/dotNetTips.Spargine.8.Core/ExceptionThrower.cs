// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="ExceptionThrower.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Inspired by the .NET ExceptionThrower,
// this tool streamlines the process of throwing exceptions effortlessly.
// All exceptions thrown utilize default messages, and if necessary,
// custom messages can also be provided.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Network;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a centralized mechanism for throwing exceptions. This class includes methods for throwing various types of exceptions,
/// such as argument exceptions, null reference exceptions, and more. Each method is designed to be a concise way to throw an exception
/// with a specific message, parameter name, or inner exception. This approach helps maintain consistency and readability in error handling
/// across a project.
/// </summary>
public static class ExceptionThrower
{

	/// <summary>
	/// Returns the provided <paramref name="value"/> if it is not null; otherwise, returns the <paramref name="defaultValue"/>.
	/// </summary>
	/// <param name="value">The value to check for null.</param>
	/// <param name="defaultValue">The default value to return if <paramref name="value"/> is null.</param>
	/// <returns>The original <paramref name="value"/> if it is not null; otherwise, the <paramref name="defaultValue"/>.</returns>
	private static string DefaultIfNull(this string value, [AllowNull] string defaultValue) => value switch
	{
		null when defaultValue is not null => defaultValue,
		_ => string.Empty,
	};

	/// <summary>
	/// Throws an <see cref="ArgumentException"/> with a specified message and parameter name.
	/// </summary>
	/// <param name="message">The message that describes the error. This can be null.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception. This cannot be null.</param>
	/// <exception cref="ArgumentException">An exception is always thrown by this method.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName);

	/// <summary>
	/// Throws an <see cref="ArgumentException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	/// <exception cref="ArgumentException">An exception is thrown with the provided message and inner exception.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentException(message.DefaultIfNull(Resources.ErrorInvalidArgument), innerException);

	/// <summary>
	/// Throws an <see cref="ArgumentInvalidException"/> with a specified message and the name of the parameter that causes this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception. This cannot be null.</param>
	/// <exception cref="ArgumentInvalidException">An exception is always thrown by this method.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentInvalidException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName);

	/// <summary>
	/// Throws an <see cref="ArgumentInvalidException"/> with a specified message, parameter name, and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception. This cannot be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="ArgumentInvalidException">An exception is always thrown by this method.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentInvalidException([AllowNull] string message, [NotNull] string paramName, [AllowNull] Exception innerException) => throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName.ArgumentNotNullOrEmpty(true), innerException);

	/// <summary>
	/// Throws an <see cref="ArgumentNullException"/> if the specified parameter name is null or empty.
	/// </summary>
	/// <param name="paramName">The name of the parameter to check.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="paramName"/> is null or empty.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "8/12/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException([NotNull] string paramName) => throw new ArgumentNullException(paramName.ArgumentNotNullOrEmpty(true), Resources.ErrorArgumentNull);

	/// <summary>
	/// Throws an <see cref="ArgumentNullException"/> with a specified message and the name of the parameter that causes this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception. This cannot be null.</param>
	/// <exception cref="ArgumentNullException">An exception is thrown if <paramref name="paramName"/> is null or empty.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentNullException(paramName.ArgumentNotNullOrEmpty(true), message.DefaultIfNull(Resources.ErrorArgumentNull));

	/// <summary>
	/// Throws an <see cref="ArgumentNullException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="ArgumentNullException">An exception is thrown if the message or inner exception is null.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentNullException(message.DefaultIfNull(Resources.ErrorArgumentNull), innerException);

	/// <summary>
	/// Throws an <see cref="ArgumentOutOfRangeException"/> if the specified parameter name is out of the valid range.
	/// </summary>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value of the argument <paramref name="paramName"/> is outside the allowable range of values as defined by the invoked method.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException([NotNull] string paramName) => throw new ArgumentOutOfRangeException(paramName.ArgumentNotNullOrEmpty(true), Resources.ErrorArgumentOutOfRange);

	/// <summary>
	/// Throws an <see cref="ArgumentOutOfRangeException"/> with a specified message and the name of the parameter that causes this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception. This cannot be null.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value of <paramref name="paramName"/> is outside the allowable range of values as defined by the invoked method.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentOutOfRangeException(paramName.ArgumentNotNullOrEmpty(true), message.DefaultIfNull(Resources.ErrorArgumentOutOfRange));

	/// <summary>
	/// Throws an <see cref="ArgumentOutOfRangeException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the specified condition is met.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentOutOfRangeException(message.DefaultIfNull(Resources.ErrorArgumentOutOfRange), innerException);

	/// <summary>
	/// Throws an <see cref="ArgumentReadOnlyException"/> with a specified message and the name of the parameter that causes this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception. This cannot be null.</param>
	/// <exception cref="ArgumentReadOnlyException">Thrown when an attempt is made to modify a read-only collection.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentReadOnlyException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentReadOnlyException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentReadOnlyException(message.DefaultIfNull(Resources.ErrorReadOnlyCollection), paramName.ArgumentNotNullOrEmpty(true));

	/// <summary>
	/// Throws a <see cref="DirectoryNotFoundException"/> with a specified message and validates the directory parameter.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="directory">The <see cref="DirectoryInfo"/> object representing the directory. This cannot be null.</param>
	/// <exception cref="DirectoryNotFoundException">Thrown when the specified directory is not found.</exception>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directory"/> is null.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowDirectoryNotFoundException([AllowNull] string message, [NotNull] DirectoryInfo directory) => throw new DirectoryNotFoundException(message.DefaultIfNull(Resources.ErrorDirectoryNotFound), directory.ArgumentNotNull());

	/// <summary>
	/// Throws a <see cref="DirectoryNotFoundException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="DirectoryNotFoundException">Thrown when the specified directory is not found.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowDirectoryNotFoundException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorDirectoryNotFound), innerException);

	/// <summary>
	/// Throws a <see cref="FileNotFoundException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="FileNotFoundException">Thrown when the file specified in <paramref name="message"/> or the file implied by <paramref name="innerException"/> is not found.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowFileNotFoundException([AllowNull] string message, [AllowNull] Exception innerException) => throw new FileNotFoundException(message.DefaultIfNull(Resources.ErrorFileNotFound), innerException);

	/// <summary>
	/// Throws a <see cref="FileNotFoundException"/> with a specified message and file name.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="fileName">The name of the file that could not be found. This cannot be null.</param>
	/// <exception cref="FileNotFoundException">Thrown when the file specified in <paramref name="fileName"/> is not found.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowFileNotFoundException([AllowNull] string message, [NotNull] string fileName)
	{
		fileName = fileName.ArgumentNotNullOrEmpty();

		throw new FileNotFoundException(message.DefaultIfNull(Resources.ErrorFileNotFound), fileName.ArgumentNotNullOrEmpty(true));
	}

	/// <summary>
	/// Throws a <see cref="FileNotFoundException"/> with a specified message, file name, and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="fileName">The name of the file that could not be found. This cannot be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="FileNotFoundException">Thrown when the file specified in <paramref name="fileName"/> is not found.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowFileNotFoundException([AllowNull] string message, [NotNull] string fileName, [AllowNull] Exception innerException)
	{
		fileName = fileName.ArgumentNotNullOrEmpty();

		throw new FileNotFoundException(message.DefaultIfNull(Resources.ErrorFileNotFound), fileName.ArgumentNotNullOrEmpty(true), innerException);
	}

	/// <summary>
	/// Throws an <see cref="InvalidCastException"/> with a specified message and parameter name.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception. This cannot be null.</param>
	/// <exception cref="InvalidCastException">Thrown when an explicit conversion from a base type or interface to a derived type fails at runtime.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidCastException([AllowNull] string message, [NotNull] string paramName) => throw new InvalidCastException($"{message.DefaultIfNull(Resources.ErrorInvalidCast)} ParamName: {paramName.ArgumentNotNullOrEmpty(true)}");

	/// <summary>
	/// Throws an <see cref="InvalidCastException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="InvalidCastException">Thrown when an attempt to cast is not valid.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidCastException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidCastException(message.DefaultIfNull(Resources.ErrorInvalidCast), innerException);

	/// <summary>
	/// Throws an <see cref="InvalidEnumTypeException"/> with a specified message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <exception cref="InvalidEnumTypeException">Thrown when an enumeration type does not match an expected type, based on the provided message.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidEnumTypeException([AllowNull] string message) => throw new InvalidEnumTypeException(message.DefaultIfNull(Resources.ErrorInvalidEnumType));

	/// <summary>
	/// Throws an <see cref="InvalidEnumTypeException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="InvalidEnumTypeException">Thrown when an enumeration type does not match an expected type, based on the provided message and inner exception.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidEnumTypeException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidCastException(message.DefaultIfNull(Resources.ErrorInvalidEnumType), innerException);

	/// <summary>
	/// Throws an <see cref="InvalidOperationException"/> with a specified message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <exception cref="InvalidOperationException">Thrown when a method call is invalid for the object's current state.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidOperationException([AllowNull] string message) => throw new InvalidOperationException(message.DefaultIfNull(Resources.ErrorInvalidOperation));

	/// <summary>
	/// Throws an <see cref="InvalidOperationException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="InvalidOperationException">Thrown when a method call is invalid for the object's current state.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidOperationException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidOperationException(message.DefaultIfNull(Resources.ErrorInvalidOperation), innerException);

	/// <summary>
	/// Throws an <see cref="InvalidValueException{TValue}"/> with a specified message and value.
	/// </summary>
	/// <typeparam name="TValue">The type of the value that caused the exception.</typeparam>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="value">The value that caused the exception. This cannot be null.</param>
	/// <exception cref="InvalidValueException{TValue}">Thrown when the specified value is invalid.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidValueException<TValue>([AllowNull] string message, [NotNull] TValue value) => throw new InvalidValueException<TValue>(message, value: value);

	/// <summary>
	/// Throws an <see cref="InvalidValueException{TValue}"/> with a specified message, value, and an inner exception.
	/// </summary>
	/// <typeparam name="TValue">The type of the value that caused the exception.</typeparam>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="value">The value that caused the exception. This cannot be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="InvalidValueException{TValue}">Thrown when the specified value is invalid, along with a detailed message and an optional inner exception.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidValueException<TValue>([AllowNull] string message, [NotNull] TValue value, [AllowNull] Exception innerException) => throw new InvalidValueException<TValue>(message, value: value, innerException: innerException);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <exception cref="MessageNotQueuedException">Thrown when a message fails to be queued.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued));

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="MessageNotQueuedException">Thrown when a message fails to be queued.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] Exception innerException) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued), innerException);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified message and message ID.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="messageId">The ID of the message that was not queued. This can be null.</param>
	/// <exception cref="MessageNotQueuedException">Thrown when a message fails to be queued.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] string messageId) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued), messageId);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified message, exception, and user message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="ex">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <param name="userMessage">A user-friendly message that can be displayed in the UI. This can be null.</param>
	/// <exception cref="MessageNotQueuedException">Thrown when a message fails to be queued.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] Exception ex, [AllowNull] string userMessage) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued), ex, userMessage);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified message, message ID, and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="messageId">The ID of the message that was not queued. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="MessageNotQueuedException">Thrown when a message fails to be queued.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] string messageId, [AllowNull] Exception innerException) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued), messageId, innerException);

	/// <summary>
	/// Throws a <see cref="NetworkConnectionException"/> with a specified message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <exception cref="NetworkConnectionException">Thrown when there is a network connection issue.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message) => throw new NetworkConnectionException(message.DefaultIfNull(Resources.ErrorNetworkConnectionIssue));

	/// <summary>
	/// Throws a <see cref="NetworkConnectionException"/> with a specified message and an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <exception cref="NetworkConnectionException">Thrown when there is a network connection issue.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message, [AllowNull] Exception innerException) => throw new NetworkConnectionException(message.DefaultIfNull(Resources.ErrorNetworkConnectionIssue), innerException);

	/// <summary>
	/// Throws a <see cref="NetworkConnectionException"/> with a specified message and network connection.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. This can be null.</param>
	/// <param name="connection">The network connection associated with the exception. This can be null.</param>
	/// <exception cref="NetworkConnectionException">Thrown when there is an issue with the network connection.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message, [AllowNull] NetworkConnection connection) => throw new NetworkConnectionException(message.DefaultIfNull(Resources.ErrorNetworkConnectionIssue), connection);

}
