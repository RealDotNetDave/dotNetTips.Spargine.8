// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-01-2024
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2025
// ***********************************************************************
// <copyright file="OptimizationStatus.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the optimization status for a component or method, indicating the current state of optimization.
/// </summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/1/2024", Status = Status.Available)]
public enum OptimizationStatus
{
	/// <summary>
	/// Indicates no optimization status has been set.
	/// </summary>
	[EnumMember(Value = "None")]
	None,

	/// <summary>
	/// Indicates optimization has been completed.
	/// </summary>
	[EnumMember(Value = "Completed")]
	Completed,

	/// <summary>
	/// Indicates the optimization needs to be updated.
	/// </summary>
	[EnumMember(Value = "Needs Update")]
	NeedsUpdate,

	/// <summary>
	/// Indicates that optimization is not required for the component or operation.
	/// </summary>
	[EnumMember(Value = "Not Required")]
	NotRequired,

	/// <summary>
	/// Indicates optimization should be performed.
	/// </summary>
	[EnumMember(Value = "Optimize")]
	Optimize,

	/// <summary>
	/// Indicates optimization is a work in progress.
	/// </summary>
	[EnumMember(Value = "Work In Progress")]
	WIP,
}
