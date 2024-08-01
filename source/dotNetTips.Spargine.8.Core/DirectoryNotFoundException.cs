// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="DirectoryNotFoundException.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Custom exception to be utilized when a directory cannot be found.</summary>
// ***********************************************************************
using System.Runtime.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents errors that occur during application execution when a directory expected to exist cannot be found.
/// </summary>
/// <seealso cref="LoggableException" />
/// <seealso cref="ISerializable" />
[Serializable]
public class DirectoryNotFoundException : LoggableException, ISerializable
{

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"/> class.
	/// </summary>
	public DirectoryNotFoundException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public DirectoryNotFoundException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"/> class with a specified directory that could not be found.
	/// </summary>
	/// <param name="directory">The directory that could not be found.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directory"/> is null.</exception>
	public DirectoryNotFoundException(DirectoryInfo directory) => this.Directory = directory ?? throw new ArgumentNullException(nameof(directory));

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"/> class with a specified error message and the directory that could not be found.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="directory">The directory that could not be found.</param>
	public DirectoryNotFoundException(string message, DirectoryInfo directory) : base(message) => this.Directory = directory;

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public DirectoryNotFoundException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"/> class with a specified error message, the directory that could not be found, and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="directory">The directory that could not be found.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public DirectoryNotFoundException(string message, DirectoryInfo directory, Exception innerException) : base(message, innerException) => this.Directory = directory;

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"/> class with a specified error message, a reference to the inner exception that is the cause of this exception, and a user-friendly message.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="ex">The exception that is the cause of the current exception.</param>
	/// <param name="userMessage">The user-friendly message that describes the error.</param>
	public DirectoryNotFoundException(string message, Exception ex, string userMessage) : base(message, ex, userMessage)
	{
	}

	/// <summary>
	/// Gets the directory that could not be found.
	/// </summary>
	/// <value>The directory.</value>
	public DirectoryInfo Directory { get; }

}
