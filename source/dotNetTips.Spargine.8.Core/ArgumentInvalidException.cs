// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2024
// ***********************************************************************
// <copyright file="ArgumentInvalidException.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Custom exception type for invalid argument value.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents errors that occur during application execution due to invalid argument values.
/// This exception is thrown when an argument passed to a method is not valid, indicating a programming error.
/// </summary>
/// <seealso cref="ArgumentException" />
[Serializable]
[Information(nameof(ArgumentInvalidException), OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
public sealed class ArgumentInvalidException : ArgumentException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentInvalidException"/> class with a default error message.
	/// This constructor initializes a new instance with a predefined error message that indicates an invalid argument was passed.
	/// </summary>
	public ArgumentInvalidException() : base(Resources.MessageGoToDotNetTipsComForHelp)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentInvalidException"/> class with a specified error message.
	/// This constructor allows for specifying a custom error message that describes the invalid argument.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public ArgumentInvalidException([NotNull] string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentInvalidException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// This constructor allows for specifying a custom error message and linking an inner exception that provides more details about the cause of the error.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public ArgumentInvalidException([NotNull] string message, [NotNull] Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentInvalidException"/> class with a specified error message and the name of the parameter that causes this exception.
	/// This constructor allows for specifying a custom error message and the name of the parameter that was invalid, providing clearer context for the error.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	public ArgumentInvalidException([NotNull] string message, [NotNull] string paramName) : base(message, paramName)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentInvalidException"/> class with a specified error message, the name of the parameter that causes this exception, and a reference to the inner exception that is the cause of this exception.
	/// This constructor allows for specifying a custom error message, the name of the invalid parameter, and linking an inner exception for more detailed error analysis.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
	public ArgumentInvalidException([NotNull] string message, [NotNull] string paramName, [NotNull] Exception innerException) : base(message, paramName, innerException)
	{
	}
}
