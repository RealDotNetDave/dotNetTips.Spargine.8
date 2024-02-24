// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2024
// ***********************************************************************
// <copyright file="MessageNotQueuedException.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Custom exception to be employed when a message could not be queued.</summary>
// ***********************************************************************


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class MessageNotQueuedException.
/// Implements the <see cref="LoggableException" />
/// </summary>
/// <seealso cref="LoggableException" />
/// <seealso cref="Exception" />
[Serializable]
public class MessageNotQueuedException : LoggableException
{

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
	/// </summary>
	public MessageNotQueuedException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MessageNotQueuedException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="messageId">The message identifier.</param>
	public MessageNotQueuedException(string message, string messageId) : base(message) => this.MessageId = messageId;

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The inner exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	public MessageNotQueuedException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="messageId">The message identifier.</param>
	/// <param name="innerException">The inner exception.</param>
	public MessageNotQueuedException(string message, string messageId, Exception innerException) : base(message, innerException) => this.MessageId = messageId;

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="ex">The ex.</param>
	/// <param name="userMessage">The user message.</param>
	public MessageNotQueuedException(string message, Exception ex, string userMessage) : base(message, ex, userMessage)
	{
	}

	/// <summary>
	/// Gets the message identifier.
	/// </summary>
	/// <value>The message identifier.</value>
	public string MessageId { get; }

}
