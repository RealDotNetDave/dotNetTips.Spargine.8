// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2025
// ***********************************************************************
// <copyright file="Status.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration used in InformationAttribute.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


using System.Runtime.Serialization;

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
	[EnumMember(Value = "Not Set")]
	NotSet,

	/// <summary>
	/// Indicates that the method or class is new.
	/// </summary>
	[EnumMember(Value = "New")]
	New,

	/// <summary>
	/// Indicates that the method or class is available for use.
	/// </summary>
	[EnumMember(Value = "Available")]
	Available,

	/// <summary>
	/// Indicates that the method or class is not used.
	/// </summary>
	[EnumMember(Value = "Not Used")]
	NotUsed,

	/// <summary>
	/// Indicates that the method or class has been updated.
	/// </summary>
	[EnumMember(Value = "Updated")]
	Updated,

	/// <summary>
	/// Indicates that the code needs documentation.
	/// </summary>
	[EnumMember(Value = "Needs Documentation")]
	NeedsDocumentation,

	/// <summary>
	/// Indicates that the code needs its documentation updated.
	/// </summary>
	[EnumMember(Value = "Update Documentation")]
	UpdateDocumentation,
}
