
// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-01-2024
//
// Last Modified By : David McCarter
// Last Modified On : 07-01-2024
// ***********************************************************************
// <copyright file="UnitTestStatus.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the status of unit testing for a component.
/// </summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/1/2024", Status = Status.Available)]
public enum UnitTestStatus
{
	/// <summary>
	/// Indicates no unit test status has been set.
	/// </summary>
	None,

	/// <summary>
	/// Indicates unit testing is not required for the component.
	/// </summary>
	NotRequired,

	/// <summary>
	/// Indicates unit testing is a work in progress.
	/// </summary>
	WIP,
	/// <summary>
	/// Indicates the component is untestable.
	/// </summary>
	Untestable,

	/// <summary>
	/// Indicates unit testing has been completed.
	/// </summary>
	Completed,

	/// <summary>
	/// Indicates the unit tests need to be updated.
	/// </summary>
	NeedsUpdate,
}
