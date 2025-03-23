// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-06-2023
//
// Last Modified By : David McCarter
// Last Modified On : 03-22-2025
// ***********************************************************************
// <copyright file="PreserveReason.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration intended for use in PreserveAttribute.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Specifies reasons why a member might be preserved during code optimization or linking.
/// Intended for use with the PreserveAttribute to provide hints to the compiler or linker.
/// </summary>
public enum PreserveReason
{
	/// <summary>
	/// Indicates no specific reason for preservation.
	/// </summary>
	[EnumMember(Value = "None")]
	None = 0,

	/// <summary>
	/// Indicates the object is preserved because it is injected via dependency injection.
	/// </summary>
	[EnumMember(Value = "Object Injected")]
	ObjectInjected = 1,

	/// <summary>
	/// Indicates the method is preserved because it is defined as part of an interface implementation.
	/// </summary>
	[EnumMember(Value = "Method From Interface")]
	MethodFromInterface = 4,

	/// <summary>
	/// Indicates the method is preserved because it overrides a method from a base class.
	/// </summary>
	[EnumMember(Value = "Method Override")]
	MethodOverride = 8,

	/// <summary>
	/// Indicates the method is preserved because it is part of the IDisposable pattern.
	/// </summary>
	[EnumMember(Value = "Method Part Of IDisposable")]
	MethodPartOfIDisposable = 16,

	/// <summary>
	/// Indicates the member is preserved for a reason not covered by other values.
	/// When using this value, set the ReasonDescription property of the PreserveAttribute to describe the reason.
	/// </summary>
	[EnumMember(Value = "Other")]
	Other = 1000,
}
