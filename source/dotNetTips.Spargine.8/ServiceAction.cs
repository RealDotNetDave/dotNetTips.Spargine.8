// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="ServiceAction.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine;

/// <summary>
/// Represents a service action, encapsulating both the request and the result of the service action, along with the service name.
/// </summary>
public sealed class ServiceAction
{

	/// <summary>
	/// Gets or sets the service action request.
	/// </summary>
	/// <value>The service action request. See <see cref="ServiceActionRequest"/> for the request details.</value>
	public ServiceActionRequest ServiceActionRequest
	{
		get; internal set;
	}


	/// <summary>
	/// Gets or sets the service action result.
	/// </summary>
	/// <value>The service action result. See <see cref="ServiceActionResult"/> for the result details.</value>
	public ServiceActionResult ServiceActionResult
	{
		get; internal set;
	}

	/// <summary>
	/// Gets or sets the name of the service.
	/// </summary>
	/// <value>The name of the service.</value>
	public string ServiceName
	{
		get; internal set;
	}

}
