// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2025
// ***********************************************************************
// <copyright file="BenchmarkStatus.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration for benchmark status utilized in InformationAttribute.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the benchmark status for a component or method, indicating the current state of performance testing.
/// </summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", BenchmarkStatus = NotRequired, Status = Status.Available)]
public enum BenchmarkStatus
{
	/// <summary>
	/// Indicates that no benchmark has been conducted.
	/// </summary>
	[EnumMember(Value = "None")]
	None,

	/// <summary>
	/// Indicates that a benchmark needs to be created.
	/// </summary>
	[EnumMember(Value = "Benchmark")]
	Benchmark,

	/// <summary>
	/// Indicates that benchmark tests have been completed.
	/// </summary>
	[EnumMember(Value = "Completed")]
	Completed,

	/// <summary>
	/// Indicates that performance should be checked from benchmark test.
	/// </summary>
	[EnumMember(Value = "Check Performance")]
	CheckPerformance,

	/// <summary>
	/// Indicates that the existing benchmark needs to be updated.
	/// </summary>
	[EnumMember(Value = "Needs Update")]
	NeedsUpdate,

	/// <summary>
	/// Indicates that a benchmark is not required for the component or method.
	/// </summary>
	[EnumMember(Value = "Not Required")]
	NotRequired,

	/// <summary>
	/// Indicates that benchmark work is currently in progress.
	/// </summary>
	[EnumMember(Value = "Work In Progress")]
	WIP,
}
