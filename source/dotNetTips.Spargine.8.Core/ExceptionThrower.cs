// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2024
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
using System.Text.Json;
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
	/// Returns the default value if the provided string is null; otherwise, returns the string itself.
	/// </summary>
	/// <param name="value">The string to check for null.</param>
	/// <param name="defaultValue">The default value to return if the string is null. This parameter is allowed to be null.</param>
	/// <returns>The original string if it is not null; otherwise, the default value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string DefaultIfNull(this string value, [AllowNull] string defaultValue) => value ?? defaultValue;

	/// <summary>
	/// Throws an <see cref="ArgumentException"/> with a specified error message and the name of the parameter that causes this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("Optimized ThrowArgumentException method for better performance and clarity.", author: "David McCarter", createdOn: "10/10/2023", OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/SpargineExThrow", Status = Status.Available)]
	public static void ThrowArgumentException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentException(message ?? Resources.ErrorInvalidArgument, paramName);

	/// <summary>
	/// Throws an <see cref="ArgumentException"/> with a specified error message and an inner exception.
	/// This method is used to throw an exception indicating that an argument provided to a method is not valid,
	/// with additional context provided by the inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or null if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("Optimized ThrowArgumentException method for better performance and clarity.", author: "David McCarter", createdOn: "10/10/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentException(message ?? Resources.ErrorInvalidArgument, innerException);

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
	public static void ThrowArgumentInvalidException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentInvalidException(message ?? Resources.ErrorInvalidArgument, paramName);

	/// <summary>
	/// Throws an <see cref="ArgumentInvalidException"/> with a specified error message, the name of the parameter that causes this exception, and an optional inner exception.
	/// This method is used to indicate that an argument provided to a method is not valid, providing both the parameter name and additional exception details.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or null if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentInvalidException([AllowNull] string message, [NotNull] string paramName, [AllowNull] Exception innerException) => throw new ArgumentInvalidException(message ?? Resources.ErrorInvalidArgument, paramName, innerException);

	/// <summary>
	/// Throws an <see cref="ArgumentNullException"/> with a specified parameter name and a default error message.
	/// This method is used to indicate that a null argument has been passed to a method that does not accept it.
	/// </summary>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentNullException), author: "David McCarter", createdOn: "8/12/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException([NotNull] string paramName) => throw new ArgumentNullException(paramName, Resources.ErrorArgumentNull);

	/// <summary>
	/// Throws an <see cref="ArgumentNullException"/> with a specified error message and the name of the parameter that causes this exception.
	/// This method is used to indicate that a null argument has been passed to a method for a parameter that does not accept it, with an optional custom error message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentNullException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentNullException(paramName, message ?? Resources.ErrorArgumentNull);

	/// <summary>
	/// Throws an <see cref="ArgumentNullException"/> with a specified error message and an inner exception.
	/// This method is used to indicate that a null argument has been passed to a method for a parameter that does not accept it, with an optional custom error message and the ability to specify an inner exception for detailed error handling.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentNullException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentNullException(message ?? Resources.ErrorArgumentNull, innerException);

	/// <summary>
	/// Throws an ArgumentOutOfRangeException with a specified parameter name and a default error message.
	/// This method is used to indicate that an argument passed to a method is out of the acceptable range of values.
	/// </summary>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException([NotNull] string paramName) => throw new ArgumentOutOfRangeException(paramName, Resources.ErrorArgumentOutOfRange);

	/// <summary>
	/// Throws an ArgumentOutOfRangeException with a specified message and parameter name.
	/// This method is used when an argument passed to a method is outside the allowable range of values.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentOutOfRangeException(paramName, message ?? Resources.ErrorArgumentOutOfRange);

	/// <summary>
	/// Throws an ArgumentOutOfRangeException with a specified message and inner exception.
	/// This method is used when an argument passed to a method is outside the allowable range of values,
	/// allowing for a custom error message and the inclusion of an inner exception for detailed error handling.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentOutOfRangeException(message ?? Resources.ErrorArgumentOutOfRange, innerException);

	/// <summary>
	/// Throws an ArgumentReadOnlyException with a specified message and parameter name.
	/// This method is used when an attempt is made to modify a read-only collection or property.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message indicating the collection or property is read-only is used.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentReadOnlyException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentReadOnlyException([AllowNull] string message, [NotNull] string paramName) => throw new ArgumentReadOnlyException(message ?? Resources.ErrorReadOnlyCollection, paramName);

	/// <summary>
	/// Throws a DirectoryNotFoundException with a specified message and directory information.
	/// This method is used when an attempt is made to access a directory that does not exist on disk.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message indicating the directory was not found is used.</param>
	/// <param name="directory">The <see cref="DirectoryInfo"/> object representing the directory that was not found.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowDirectoryNotFoundException([AllowNull] string message, [NotNull] DirectoryInfo directory) => throw new DirectoryNotFoundException(message ?? Resources.ErrorDirectoryNotFound, directory.ArgumentNotNull());

	/// <summary>
	/// Throws a DirectoryNotFoundException with a specified message and inner exception.
	/// This method is used when an attempt is made to access a directory that does not exist, allowing for a custom error message and the inclusion of an inner exception for detailed error handling.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message indicating the directory was not found is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowDirectoryNotFoundException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentInvalidException(message ?? Resources.ErrorDirectoryNotFound, innerException);

	/// <summary>
	/// Throws a FileNotFoundException with a specified message and inner exception.
	/// This method is used when an attempt is made to access a file that does not exist, allowing for a custom error message and the inclusion of an inner exception for detailed error handling.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message indicating the file was not found is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowFileNotFoundException([AllowNull] string message, [AllowNull] Exception innerException) => throw new FileNotFoundException(message ?? Resources.ErrorFileNotFound, innerException);

	/// <summary>
	/// Throws a FileNotFoundException with a specified message and file name.
	/// This method is used when an attempt is made to access a file that does not exist on disk, allowing for a custom error message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message indicating the file was not found is used.</param>
	/// <param name="fileName">The name of the file that was not found.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowFileNotFoundException([AllowNull] string message, [NotNull] string fileName)
	{
		throw new FileNotFoundException(message ?? Resources.ErrorFileNotFound, fileName.ArgumentNotNullOrEmpty(true));
	}

	/// <summary>
	/// Throws a FileNotFoundException with a specified message, file name, and inner exception.
	/// This method is used when an attempt is made to access a file that does not exist on disk, allowing for a custom error message and the inclusion of an inner exception for detailed error handling.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message indicating the file was not found is used.</param>
	/// <param name="fileName">The name of the file that was not found.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowFileNotFoundException([AllowNull] string message, [NotNull] string fileName, [AllowNull] Exception innerException)
	{
		throw new FileNotFoundException(message ?? Resources.ErrorFileNotFound, fileName.ArgumentNotNullOrEmpty(true), innerException);
	}

	/// <summary>
	/// Throws an <see cref="InvalidCastException"/> with a specified error message and parameter name.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message is used.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidCastException([AllowNull] string message, [NotNull] string paramName) => throw new InvalidCastException($"{message ?? Resources.ErrorInvalidCast} ParamName: {paramName}");

	/// <summary>
	/// Throws an InvalidCastException with a specified message and inner exception.
	/// This method is used when a cast operation fails and cannot be performed, allowing for a custom error message and the inclusion of an inner exception for detailed error handling.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message indicating an invalid cast is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidCastException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidCastException(message ?? Resources.ErrorInvalidCast, innerException);

	/// <summary>
	/// Throws an <see cref="InvalidEnumTypeException"/> with a specified error message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidEnumTypeException([AllowNull] string message) => throw new InvalidEnumTypeException(message ?? Resources.ErrorInvalidEnumType);

	/// <summary>
	/// Throws an <see cref="InvalidEnumTypeException"/> with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidEnumTypeException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidCastException(message ?? Resources.ErrorInvalidEnumType, innerException);

	/// <summary>
	/// Throws an <see cref="InvalidOperationException"/> with a specified error message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidOperationException([AllowNull] string message) => throw new InvalidOperationException(message ?? Resources.ErrorInvalidOperation);

	/// <summary>
	/// Throws an <see cref="InvalidOperationException"/> with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidOperationException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidOperationException(message ?? Resources.ErrorInvalidOperation);

	/// <summary>
	/// Throws an <see cref="InvalidValueException{TValue}"/> with a specified error message and value.
	/// </summary>
	/// <typeparam name="TValue">The type of the value that caused the exception.</typeparam>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="value">The value that caused the exception.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidValueException<TValue>([AllowNull] string message, [NotNull] TValue value) => throw new InvalidValueException<TValue>(message ?? Resources.ErrorInvalidValue, value: value);

	/// <summary>
	/// Throws an <see cref="InvalidValueException{TValue}"/> with a specified error message, value, and inner exception.
	/// </summary>
	/// <typeparam name="TValue">The type of the value that caused the exception.</typeparam>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="value">The value that caused the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidValueException<TValue>([AllowNull] string message, [NotNull] TValue value, [AllowNull] Exception innerException) => throw new InvalidValueException<TValue>(message ?? Resources.ErrorInvalidValue, value: value, innerException: innerException);

	/// <summary>
	/// Throws an <see cref="IOException"/> with the specified message.
	/// </summary>
	/// <param name="message">The message that describes the error. Can be null.</param>
	/// <exception cref="IOException">Always thrown with the specified message.</exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowIOException), author: "David McCarter", createdOn: "7/25/2024", Status = Status.New)]
	public static void ThrowIOException([AllowNull] string message) => throw new IOException(message ?? Resources.ErrorUnknownIOException);

	/// <summary>
	/// Throws a <see cref="JsonException"/> with a specified error message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowJsonException), author: "David McCarter", createdOn: "7/17/2024", Status = Status.New)]
	public static void ThrowJsonException([AllowNull] string message) => throw new JsonException(message ?? Resources.ErrorThereWasAnErrorWithJsonSerialization);

	/// <summary>
	/// Throws a <see cref="JsonException"/> with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowJsonException), author: "David McCarter", createdOn: "7/17/2024", Status = Status.New)]
	public static void ThrowJsonException([AllowNull] string message, [AllowNull] Exception innerException) => throw new JsonException(message ?? Resources.ErrorThereWasAnErrorWithJsonSerialization, innerException);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified error message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message) => throw new MessageNotQueuedException(message ?? Resources.ErrorMessageNotQueued);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] Exception innerException) => throw new MessageNotQueuedException(message ?? Resources.ErrorMessageNotQueued, innerException);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified error message and message ID.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="messageId">The ID of the message that was not queued.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] string messageId) => throw new MessageNotQueuedException(message ?? Resources.ErrorMessageNotQueued, messageId);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified error message, inner exception, and user message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="ex">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	/// <param name="userMessage">A custom user message that provides additional context about the error.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] Exception ex, [AllowNull] string userMessage) => throw new MessageNotQueuedException(message ?? Resources.ErrorMessageNotQueued, ex, userMessage);

	/// <summary>
	/// Throws a <see cref="MessageNotQueuedException"/> with a specified error message, message ID, and inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="messageId">The ID of the message that was not queued.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] string messageId, [AllowNull] Exception innerException) => throw new MessageNotQueuedException(message ?? Resources.ErrorMessageNotQueued, messageId, innerException);

	/// <summary>
	/// Throws a <see cref="NetworkConnectionException"/> with a specified error message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message) => throw new NetworkConnectionException(message ?? Resources.ErrorNetworkConnectionIssue);

	/// <summary>
	/// Throws a <see cref="NetworkConnectionException"/> with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message, [AllowNull] Exception innerException) => throw new NetworkConnectionException(message ?? Resources.ErrorNetworkConnectionIssue, innerException);

	/// <summary>
	/// Throws a <see cref="NetworkConnectionException"/> with a specified error message and network connection.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If the message is null, a default message from resources is used.</param>
	/// <param name="connection">The network connection associated with the exception, or null if not applicable.</param>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message, [AllowNull] NetworkConnection connection) => throw new NetworkConnectionException(message ?? Resources.ErrorNetworkConnectionIssue, connection);

}
