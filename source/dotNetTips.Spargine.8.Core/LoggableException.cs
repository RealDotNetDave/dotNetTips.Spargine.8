// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-09-2024
// ***********************************************************************
// <copyright file="LoggableException.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Exception type that includes the property HasBeenLogged, providing
// the ability to log the exception once.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Security;
using System.Text;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core.Internal;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents an exception that can be logged. This class extends <see cref="Exception"/> to include additional functionality for logging.
/// </summary>
[Serializable]
[Information(nameof(LoggableException), OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
public class LoggableException : Exception
{

	/// <summary>
	/// The string builder pool used for performance optimization.
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());


	/// <summary>
	/// Gets the computer information associated with the exception.
	/// </summary>
	/// <value>A string representing the computer information.</value>
	private readonly ComputerInfo _computerInfo = new();

	/// <summary>
	/// Indicates whether the exception has been logged.
	/// </summary>
	[NonSerialized]
	[XmlIgnore]
	private bool _hasBeenLogged;

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException"/> class.
	/// </summary>
	public LoggableException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public LoggableException([NotNull] string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public LoggableException([NotNull] string message, [AllowNull] Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException"/> class with a specified error message, a reference to the inner exception that is the cause of this exception, and a user-friendly message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="ex">The exception that is the cause of the current exception.</param>
	/// <param name="userMessage">The user-friendly message.</param>
	public LoggableException([NotNull] string message, [NotNull] Exception ex, [AllowNull] string userMessage) : base(message, ex) => this.UserMessage = userMessage;

	/// <summary>
	/// Reflects the exception to return a list of properties and their values using a <see cref="ObjectPool&lt;StringBuilder&gt;"/> for performance optimization.
	/// </summary>
	/// <param name="ex">The exception to reflect.</param>
	/// <returns>A string representation of the exception properties and their values.</returns>
	private static string ReflectException([NotNull] Exception ex)
	{
		var sb = _stringBuilderPool.Value.Get();

		try
		{
			var properties = ex.GetType().GetRuntimeProperties();

			foreach (var current in properties)
			{
				object objectValue = null;

				try
				{
					objectValue = current.GetValue(ex, null);
				}
				catch (SecurityException securityEx)
				{
					Trace.WriteLine(securityEx);
				}

				if (objectValue is not null &&
								!string.Equals(objectValue.ToString(), objectValue.GetType().FullName, StringComparison.Ordinal))
				{
					_ = sb.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}", current.Name, objectValue).AppendLine();
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Gets a collection of exception messages, including those from inner exceptions.
	/// </summary>
	/// <returns>A read-only collection of exception messages.</returns>
	public virtual ReadOnlyCollection<string> Messages()
	{
		var exceptions = LoggingHelper.RetrieveAllExceptions(this);
		var errorMessages = new List<string>(exceptions.Count * 3); // Preallocate list size

		foreach (var current in exceptions)
		{
			errorMessages.Add(current.GetType().FullName);
			errorMessages.Add(ReflectException(current));

			if (current.StackTrace is not null)
			{
				errorMessages.Add(current.StackTrace);
			}
		}

		return errorMessages.AsReadOnly();
	}

	/// <summary>
	/// Gets the computer information associated with the exception.
	/// </summary>
	/// <value>A string representing the computer information.</value>
	public string ComputerInformation => this._computerInfo.PropertiesToString();

	/// <summary>
	/// Gets or sets a value indicating whether this instance has been logged.
	/// </summary>
	/// <value><c>true</c> if this instance has been logged; otherwise, <c>false</c>.</value>
	public bool HasBeenLogged
	{
		get => this._hasBeenLogged;

		set
		{
			// Prevent from being set (from code) to false.
			if (value)
			{
				this._hasBeenLogged = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the user-friendly message associated with the exception.
	/// </summary>
	/// <value>The user-friendly message.</value>
	[AllowNull]
	public virtual string UserMessage { get; }
}
