// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="MessageNotQueuedException.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Custom exception to be employed when a message could not be queued.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )





namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents errors that occur when a message could not be queued.
/// </summary>
[Serializable]
public class MessageNotQueuedException : LoggableException
{

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException"/> class.
	/// </summary>
	public MessageNotQueuedException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MessageNotQueuedException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException"/> class with a specified error message and message identifier.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="messageId">The identifier for the message that was not queued.</param>
	public MessageNotQueuedException(string message, string messageId) : base(message) => this.MessageId = messageId;

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public MessageNotQueuedException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException"/> class with a specified error message, message identifier, and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="messageId">The identifier for the message that was not queued.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public MessageNotQueuedException(string message, string messageId, Exception innerException) : base(message, innerException) => this.MessageId = messageId;

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageNotQueuedException"/> class with a specified error message, a reference to the inner exception that is the cause of this exception, and a user-friendly message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="ex">The exception that is the cause of the current exception.</param>
	/// <param name="userMessage">The user-friendly message.</param>
	public MessageNotQueuedException(string message, Exception ex, string userMessage) : base(message, ex, userMessage)
	{
	}

	/// <summary>
	/// Gets the message identifier.
	/// </summary>
	/// <value>The message identifier.</value>
	public string MessageId { get; }

}
