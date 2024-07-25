// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-10-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2024
// ***********************************************************************
// <copyright file="InvalidValueException.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Custom exception to be used when an invalid value is encountered.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Internal;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents an exception that is thrown when an invalid value of type <typeparamref name="TValue"/> is encountered.
/// </summary>
/// <typeparam name="TValue">The type of the invalid value.</typeparam>
[Serializable]
[Information(nameof(InvalidValueException<TValue>), OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
public sealed class InvalidValueException<TValue> : LoggableException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidValueException{TValue}"/> class with a default error message.
	/// </summary>
	public InvalidValueException() : base(Resources.MessageGoToDotNetTipsComForHelp)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidValueException{TValue}"/> class with the specified invalid value.
	/// </summary>
	/// <param name="value">The invalid value that caused the exception.</param>
	public InvalidValueException([AllowNull] TValue value) : base(Resources.MessageGoToDotNetTipsComForHelp) => this.Value = value;

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidValueException{TValue}"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public InvalidValueException([NotNull] string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidValueException{TValue}"/> class with a specified error message and invalid value.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="value">The invalid value that caused the exception.</param>
	public InvalidValueException([NotNull] string message, [AllowNull] TValue value) : base(message) => this.Value = value;

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidValueException{TValue}"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public InvalidValueException([NotNull] string message, [AllowNull] Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidValueException{TValue}"/> class with a specified error message, invalid value, and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="value">The invalid value that caused the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public InvalidValueException([NotNull] string message, [AllowNull] TValue value, [AllowNull] Exception innerException) : base(message, innerException) => this.Value = value;

	/// <summary>
	/// Converts to string.
	/// Provides a string representation of the exception, including the message, inner exception, and the invalid value.
	/// </summary>
	/// <returns>A string that represents the current exception.</returns>
	public override string ToString()
	{
		var valueProperties = string.Empty;
		var innerException = string.Empty;

		if (this.Value is not null)
		{
			valueProperties = this.Value.PropertiesToString();
		}

		if (this.InnerException is not null)
		{
			innerException = this.InnerException.PropertiesToString();
		}

		return $"{this.Message} InnerException: {innerException} Value: {valueProperties}.";
	}

	/// <summary>
	/// Gets the invalid value that caused the exception.
	/// </summary>
	/// <value>The invalid value.</value>
	[AllowNull]
	public TValue Value { get; private set; }
}
