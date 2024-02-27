// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-06-2023
//
// Last Modified By : David McCarter
// Last Modified On : 11-06-2023
// ***********************************************************************
// <copyright file="PreserveReason.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Enum PreserveReason
/// </summary>
public enum PreserveReason
{
	/// <summary>
	/// None selected
	/// </summary>
	None = 0,

	/// <summary>
	/// Object is injected via DI.
	/// </summary>
	ObjectInjected = 1,

	/// <summary>
	/// Method is defined due to an interface
	/// </summary>
	MethodFromInterface = 4,

	/// <summary>
	/// Method overrides a method from a base class.
	/// </summary>
	MethodOverride = 8,

	/// <summary>
	/// Other - Make sure to set ReasonDescription.
	/// </summary>
	Other = 1000,
}
