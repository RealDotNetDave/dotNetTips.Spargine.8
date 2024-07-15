// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-05-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="NetworkConnectionException.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Custom exception to be used when there is a network connection error.</summary>
// ***********************************************************************

using DotNetTips.Spargine.Core.Network;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents errors that occur during network connection operations.
/// </summary>
[Serializable]
[Information(nameof(NetworkConnectionException), Status = Status.Available)]
public sealed class NetworkConnectionException : LoggableException
{

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a default error message.
	/// </summary>
	public NetworkConnectionException() : base(Resources.NetworkConnectionIssue)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public NetworkConnectionException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	public NetworkConnectionException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a specified error message and the network connection that caused this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="connection">The network connection that caused the exception.</param>
	public NetworkConnectionException(string message, NetworkConnection connection) : base($"{connection}:{message}")
	{
	}

}
