// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-01-2024
//
// Last Modified By : David McCarter
// Last Modified On : 07-01-2024
// ***********************************************************************
// <copyright file="OptimizationStatus.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************


//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )



namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents the optimization status of a component or operation.
/// </summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/1/2024", Status = Status.Available)]
public enum OptimizationStatus
{
	/// <summary>
	/// Indicates no optimization status has been set.
	/// </summary>
	None,

	/// <summary>
	/// Indicates optimization is unnecessary.
	/// </summary>
	Unnecessary,

	/// <summary>
	/// Indicates optimization is a work in progress.
	/// </summary>
	WIP,

	/// <summary>
	/// Indicates optimization has been completed.
	/// </summary>
	Completed,

	/// <summary>
	/// Indicates the optimization needs to be updated.
	/// </summary>
	NeedsUpdate,
}
