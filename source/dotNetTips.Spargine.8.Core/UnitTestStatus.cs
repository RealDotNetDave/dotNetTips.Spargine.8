
// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-01-2024
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2025
// ***********************************************************************
// <copyright file="UnitTestStatus.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the status of unit testing for a component or method, indicating the current state of testing.
/// </summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/1/2024", Status = Status.Available)]
public enum UnitTestStatus
{
	/// <summary>
	/// Indicates no unit test status has been set.
	/// </summary>
	[EnumMember(Value = "None")]
	None,

	/// <summary>
	/// Indicates unit testing has been completed.
	/// </summary>
	[EnumMember(Value = "Completed")]
	Completed,

	/// <summary>
	/// Indicates the unit tests need to be updated.
	/// </summary>
	[EnumMember(Value = "Needs Update")]
	NeedsUpdate,

	/// <summary>
	/// Indicates unit testing is not required for the component.
	/// </summary>
	[EnumMember(Value = "Not Required")]
	NotRequired,

	/// <summary>
	/// Indicates the component is untestable.
	/// </summary>
	[EnumMember(Value = "Untestable")]
	Untestable,

	/// <summary>
	/// Indicates unit testing is a work in progress.
	/// </summary>
	[EnumMember(Value = "Work In Progress")]
	WIP,
}
