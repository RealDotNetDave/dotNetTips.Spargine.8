// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2024
// ***********************************************************************
// <copyright file="UnhandledExceptionEventInformation.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// A custom exception designed for scenarios where an unhandled
// exception needs to be thrown.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents information about an unhandled exception event. This class holds details about the exception and the state of the application when the exception occurred.
/// </summary>
[Information(nameof(UnhandledExceptionEventInformation), OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
public sealed class UnhandledExceptionEventInformation : IEventInformation
{
	//TODO: ADD TO EXCEPTIONTHROWER.

	/// <summary>
	/// Gets the exception that was unhandled and caused the event.
	/// </summary>
	/// <value>The exception that was not handled.</value>
	[NotNull]
	public LoggableException Exception { get; internal set; }

	/// <summary>
	/// Gets a value indicating whether the application is terminating due to the unhandled exception.
	/// </summary>
	/// <value><c>true</c> if the application is terminating; otherwise, <c>false</c>.</value>
	public bool IsTerminating { get; internal set; }

}
