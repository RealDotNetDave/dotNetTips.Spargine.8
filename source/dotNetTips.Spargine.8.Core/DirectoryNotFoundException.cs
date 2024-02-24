// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2024
// ***********************************************************************
// <copyright file="DirectoryNotFoundException.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Custom exception to be utilized when a directory cannot be found.</summary>
// ***********************************************************************
using System.Runtime.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class DirectoryNotFoundException.
/// Implements the <see cref="LoggableException" />
/// </summary>
[Serializable]
public class DirectoryNotFoundException : LoggableException, ISerializable
{

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class.
	/// </summary>
	public DirectoryNotFoundException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException" /> class.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public DirectoryNotFoundException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException" /> class.
	/// </summary>
	/// <param name="directory">The directory.</param>
	/// <exception cref="ArgumentNullException">directory</exception>
	public DirectoryNotFoundException(DirectoryInfo directory) => this.Directory = directory ?? throw new ArgumentNullException(nameof(directory));

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="directory">The directory.</param>
	public DirectoryNotFoundException(string message, DirectoryInfo directory) : base(message) => this.Directory = directory;

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException" /> class.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The inner exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	public DirectoryNotFoundException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="directory">The directory.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	public DirectoryNotFoundException(string message, DirectoryInfo directory, Exception innerException) : base(message, innerException) => this.Directory = directory;

	/// <summary>
	/// Initializes a new instance of the <see cref="DirectoryNotFoundException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="ex">The Exception.</param>
	/// <param name="userMessage">The user message.</param>
	public DirectoryNotFoundException(string message, Exception ex, string userMessage) : base(message, ex, userMessage)
	{
	}

	/// <summary>
	/// Gets the directory.
	/// </summary>
	/// <value>The directory.</value>
	public DirectoryInfo Directory { get; }

}
