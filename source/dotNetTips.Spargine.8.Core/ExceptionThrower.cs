// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2024
// ***********************************************************************
// <copyright file="ExceptionThrower.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Inspired by the .NET ExceptionThrower, this tool streamlines the process of throwing exceptions effortlessly. All exceptions thrown utilize default messages, and if necessary, custom messages can also be provided.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Network;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Exception Thrower.
/// </summary>
public static class ExceptionThrower
{

	/// <summary>
	/// Defaults if null.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="defaultValue">The default value.</param>
	/// <returns>System.String.</returns>
	private static string DefaultIfNull(this string value, [AllowNull] string defaultValue) => value switch
	{
		null when defaultValue is not null => defaultValue,
		_ => string.Empty,
	};

	/// <summary>
	/// Throws the ArgumentException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <exception cref="ArgumentException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentException([AllowNull] string message, string paramName) => throw new ArgumentException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName);

	/// <summary>
	/// Throws the ArgumentException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="ArgumentException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentException(message.DefaultIfNull(Resources.ErrorInvalidArgument), innerException);

	/// <summary>
	/// Throws the ArgumentInvalidException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <exception cref="ArgumentInvalidException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentInvalidException([AllowNull] string message, string paramName) => throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName);

	/// <summary>
	/// Throws the ArgumentInvalidException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="ArgumentInvalidException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentInvalidException([AllowNull] string message, string paramName, [AllowNull] Exception innerException) => throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName.ArgumentNotNullOrEmpty(true), innerException);

	/// <summary>
	/// Throws the argument null exception.
	/// </summary>
	/// <param name="paramName">Name of the parameter.</param>
	/// <exception cref="ArgumentNullException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "8/12/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException(string paramName) => throw new ArgumentNullException(paramName.ArgumentNotNullOrEmpty(true), Resources.ErrorArgumentNull);

	/// <summary>
	/// Throws the ArgumentNullException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <exception cref="ArgumentNullException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException([AllowNull] string message, string paramName) => throw new ArgumentNullException(paramName.ArgumentNotNullOrEmpty(true), message.DefaultIfNull(Resources.ErrorArgumentNull));

	/// <summary>
	/// Throws the ArgumentNullException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="ArgumentNullException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentNullException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentNullException(message.DefaultIfNull(Resources.ErrorArgumentNull), innerException);

	/// <summary>
	/// Throws the argument out of range exception.
	/// </summary>
	/// <param name="paramName">Name of the parameter.</param>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException(string paramName) => throw new ArgumentOutOfRangeException(paramName.ArgumentNotNullOrEmpty(true), Resources.ErrorArgumentOutOfRange);

	/// <summary>
	/// Throws the argument out of range exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException([AllowNull] string message, string paramName) => throw new ArgumentOutOfRangeException(paramName.ArgumentNotNullOrEmpty(true), message.DefaultIfNull(Resources.ErrorArgumentOutOfRange));

	/// <summary>
	/// Throws the argument out of range exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentOutOfRangeException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentOutOfRangeException(message.DefaultIfNull(Resources.ErrorArgumentOutOfRange), innerException);

	/// <summary>
	/// Throws the ArgumentReadOnlyException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <exception cref="ArgumentReadOnlyException"></exception>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowArgumentReadOnlyException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowArgumentReadOnlyException([AllowNull] string message, string paramName) => throw new ArgumentReadOnlyException(message.DefaultIfNull(Resources.ErrorReadOnlyCollection), paramName.ArgumentNotNullOrEmpty(true));

	/// <summary>
	/// Throws the ArgumentInvalidException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="directory">The directory.</param>
	/// <exception cref="DirectoryNotFoundException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowDirectoryNotFoundException([AllowNull] string message, [NotNull] DirectoryInfo directory) => throw new DirectoryNotFoundException(message.DefaultIfNull(Resources.ErrorDirectoryNotFound), directory.ArgumentNotNull());

	/// <summary>
	/// Throws the ArgumentInvalidException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="ArgumentInvalidException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowDirectoryNotFoundException([AllowNull] string message, [AllowNull] Exception innerException) => throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorDirectoryNotFound), innerException);

	/// <summary>
	/// Throws the file not found exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="FileNotFoundException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowFileNotFoundException([AllowNull] string message, [AllowNull] Exception innerException) => throw new FileNotFoundException(message.DefaultIfNull(Resources.ErrorFileNotFound), innerException);

	/// <summary>
	/// Throws the file not found exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="fileName">Name of the file.</param>
	/// <exception cref="FileNotFoundException">message.DefaultIfNull(Resources.ErrorFileNotFound), fileName.ArgumentNotNullOrEmpty(true)</exception>
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
	/// Throws the file not found exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="FileNotFoundException">message.DefaultIfNull(Resources.ErrorFileNotFound), fileName.ArgumentNotNullOrEmpty(true), innerException</exception>
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
	/// Throws the invalid cast exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <exception cref="InvalidCastException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidCastException([AllowNull] string message, string paramName) => throw new InvalidCastException($"{message.DefaultIfNull(Resources.ErrorInvalidCast)} ParamName: {paramName.ArgumentNotNullOrEmpty(true)}");

	/// <summary>
	/// Throws the invalid cast exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="InvalidCastException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidCastException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidCastException(message.DefaultIfNull(Resources.ErrorInvalidCast), innerException);

	/// <summary>
	/// Throws the invalid enum type exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <exception cref="InvalidEnumTypeException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidEnumTypeException([AllowNull] string message) => throw new InvalidEnumTypeException(message.DefaultIfNull(Resources.ErrorInvalidEnumType));

	/// <summary>
	/// Throws the invalid enum type exception.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="InvalidCastException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidEnumTypeException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidCastException(message.DefaultIfNull(Resources.ErrorInvalidEnumType), innerException);

	/// <summary>
	/// Throws a InvalidOperationException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <exception cref="InvalidOperationException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidOperationException([AllowNull] string message) => throw new InvalidOperationException(message.DefaultIfNull(Resources.ErrorInvalidOperation));

	/// <summary>
	/// Throws a InvalidOperationException.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="InvalidOperationException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidOperationException([AllowNull] string message, [AllowNull] Exception innerException) => throw new InvalidOperationException(message.DefaultIfNull(Resources.ErrorInvalidOperation), innerException);

	/// <summary>
	/// Throws the invalid value exception.
	/// </summary>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="message">The message.</param>
	/// <param name="value">The value.</param>
	/// <exception cref="InvalidValueException{TValue}"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidValueException<TValue>([AllowNull] string message, [NotNull] TValue value) => throw new InvalidValueException<TValue>(message, value: value);

	/// <summary>
	/// Throws the invalid value exception.
	/// </summary>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="message">The message.</param>
	/// <param name="value">The value.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="InvalidValueException{TValue}"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowInvalidValueException<TValue>([AllowNull] string message, [NotNull] TValue value, [AllowNull] Exception innerException) => throw new InvalidValueException<TValue>(message, value: value, innerException: innerException);

	/// <summary>
	/// Throws the <see cref="MessageNotQueuedException" />.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <exception cref="MessageNotQueuedException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued));

	/// <summary>
	/// Throws the <see cref="MessageNotQueuedException" />.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="MessageNotQueuedException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] Exception innerException) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued), innerException);

	/// <summary>
	/// Throws the <see cref="MessageNotQueuedException" />.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="messageId">The message identifier.</param>
	/// <exception cref="MessageNotQueuedException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] string messageId) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued), messageId);

	/// <summary>
	/// Throws the <see cref="MessageNotQueuedException" />.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="ex">The ex.</param>
	/// <param name="userMessage">The user message.</param>
	/// <exception cref="MessageNotQueuedException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] Exception ex, [AllowNull] string userMessage) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued), ex, userMessage);

	/// <summary>
	/// Throws the <see cref="MessageNotQueuedException" />.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="messageId">The message identifier.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="MessageNotQueuedException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowMessageNotQueuedException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowMessageNotQueuedException([AllowNull] string message, [AllowNull] string messageId, [AllowNull] Exception innerException) => throw new MessageNotQueuedException(message.DefaultIfNull(Resources.ErrorMessageNotQueued), messageId, innerException);

	/// <summary>
	/// Throws a <see cref="NetworkConnection" />.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <exception cref="NetworkConnectionException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message) => throw new NetworkConnectionException(message.DefaultIfNull(Resources.ErrorNetworkConnectionIssue));

	/// <summary>
	/// Throws a <see cref="NetworkConnection" />.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	/// <exception cref="NetworkConnectionException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message, [AllowNull] Exception innerException) => throw new NetworkConnectionException(message.DefaultIfNull(Resources.ErrorNetworkConnectionIssue), innerException);

	/// <summary>
	/// Throws a <see cref="NetworkConnection" />.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="connection">The <see cref="NetworkConnection" />.</param>
	/// <exception cref="NetworkConnectionException"></exception>
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(ThrowNetworkConnectionException), author: "David McCarter", createdOn: "5/4/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineExThrow")]
	public static void ThrowNetworkConnectionException([AllowNull] string message, [AllowNull] NetworkConnection connection) => throw new NetworkConnectionException(message.DefaultIfNull(Resources.ErrorNetworkConnectionIssue), connection);

}
