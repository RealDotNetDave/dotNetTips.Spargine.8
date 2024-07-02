// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="BenchMarkStatus.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration for benchmark status utilized in InformationAttribute.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the benchmark status for a component or method, indicating whether benchmarks have been conducted, are in progress, or are not required.
/// </summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", BenchMarkStatus = NotRequired, Status = Status.Available)]
public enum BenchMarkStatus
{
	/// <summary>
	/// Indicates that no benchmark has been conducted.
	/// </summary>
	None,

	/// <summary>
	/// Indicates that a benchmark is not required for the component or method.
	/// </summary>
	NotRequired,

	/// <summary>
	/// Indicates that benchmark work is currently in progress.
	/// </summary>
	WIP,

	/// <summary>
	/// Indicates that benchmark tests have been completed.
	/// </summary>
	Completed,

	/// <summary>
	/// Indicates that the existing benchmark needs to be updated.
	/// </summary>
	NeedsUpdate,
}
