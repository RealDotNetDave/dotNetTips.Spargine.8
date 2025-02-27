// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-01-2024
// ***********************************************************************
// <copyright file="Status.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration used in InformationAttribute.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )





namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the availability status for use in the InformationAttribute.
/// </summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Available)]
public enum Status
{
	/// <summary>
	/// Indicates that the status has not been set.
	/// </summary>
	NotSet,

	/// <summary>
	/// Indicates that the method or class is new.
	/// </summary>
	New,

	/// <summary>
	/// Indicates that the method or class is available for use.
	/// </summary>
	Available,

	/// <summary>
	/// Indicates that the method or class is not used.
	/// </summary>
	NotUsed,

	/// <summary>
	/// Indicates that the method or class has been updated.
	/// </summary>
	Updated,

	/// <summary>
	/// Indicates that the code needs documentation.
	/// </summary>
	NeedsDocumentation,

	/// <summary>
	/// Indicates that the code needs its documentation updated.
	/// </summary>
	UpdateDocumentation,
}
