// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2025
// ***********************************************************************
// <copyright file="ServiceActionResult.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using System.Runtime.Serialization;

namespace DotNetTips.Spargine;

/// <summary>
/// Enum ServiceActionResult represents the possible outcomes of a service action.
/// </summary>
public enum ServiceActionResult
{
	/// <summary>
	/// Indicates that the requested item or service was not found.
	/// </summary>
	[EnumMember(Value = "Not Found")]
	NotFound,

	/// <summary>
	/// Indicates that the service is currently running.
	/// </summary>
	[EnumMember(Value = "Running")]
	Running,

	/// <summary>
	/// Indicates that the service has been stopped.
	/// </summary>
	[EnumMember(Value = "Stopped")]
	Stopped,

	/// <summary>
	/// Indicates that an error occurred during the service action.
	/// </summary>
	[EnumMember(Value = "Error")]
	Error,
}
