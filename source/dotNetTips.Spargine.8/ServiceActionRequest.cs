// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="ServiceActionRequest.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine;

/// <summary>
/// Defines the request types for a service action.
/// </summary>
public enum ServiceActionRequest
{
	/// <summary>
	/// Represents an unknown request. This is the default value.
	/// </summary>
	Unknown,

	/// <summary>
	/// Represents a request to start the service.
	/// </summary>
	Start,

	/// <summary>
	/// Represents a request to stop the service.
	/// </summary>
	Stop,
}
