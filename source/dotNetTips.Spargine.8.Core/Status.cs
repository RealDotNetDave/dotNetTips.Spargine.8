// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2023
// ***********************************************************************
// <copyright file="Status.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration used in InformationAttribute.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )































namespace DotNetTips.Spargine.Core;

/// <summary>Availability Status</summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Available)]
public enum Status
{
	/// <summary>
	/// Status not set.
	/// </summary>
	NotSet,

	/// <summary>
	/// New method or class.
	/// </summary>
	New,

	/// <summary>
	/// Method or class is available.
	/// </summary>
	Available,

	/// <summary>
	/// Method or class is not used
	/// </summary>
	NotUsed,

	/// <summary>
	/// Method or class has been updated
	/// </summary>
	Updated,

	/// <summary>
	/// The code needs documentation
	/// </summary>
	NeedsDocumentation,

	/// <summary>The check performance</summary>
	CheckPerformance,
}
