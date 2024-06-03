// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-05-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2024
// ***********************************************************************
// <copyright file="NetworkConnectionException.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Custom exception to be used when there is a network connection error.
// </summary>
// ***********************************************************************

using DotNetTips.Spargine.Core.Network;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class NetworkConnectionException. This class cannot be inherited.
/// Implements the <see cref="Exception" />
/// </summary>
/// <seealso cref="Exception" />
[Serializable]
[Information(nameof(NetworkConnectionException), UnitTestCoverage = 0, Status = Status.Available)]
public sealed class NetworkConnectionException : LoggableException
{

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentInvalidException" /> class.
	/// </summary>
	public NetworkConnectionException() : base(Resources.NetworkConnectionIssue)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentInvalidException" /> class.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public NetworkConnectionException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class that accepts a message an inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public NetworkConnectionException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentInvalidException" /> class.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="connection">The connection.</param>
	public NetworkConnectionException(string message, NetworkConnection connection) : base($"{connection}:{message}")
	{
	}

}
