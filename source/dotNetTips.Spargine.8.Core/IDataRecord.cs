// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="IDataRecord.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Interface tailored for model records, mandating the implementation of
// the "Id" property. Additionally, it provides functionality to convert
// all the properties and their data to a string representation.
// </summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Internal;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the essential characteristics of a data record, including a unique identifier and the ability to represent its properties as a string.
/// </summary>
[Information(nameof(IDataRecord), author: "David McCarter", createdOn: "3/4/2021", BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
public interface IDataRecord
{

	/// <summary>
	/// Converts all properties and their values of the implementing class to a string representation.
	/// </summary>
	/// <returns>A string that represents all the properties and their values of the implementing class.</returns>
	/// <remarks>This method uses reflection to iterate over all properties.</remarks>
	[Information(nameof(AllPropertiesToString), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public sealed string AllPropertiesToString() => this.PropertiesToString();

	/// <summary>
	/// Gets the unique identifier for the data record.
	/// </summary>
	/// <value>The unique identifier as a string.</value>
	/// <remarks>
	/// The identifier must be between 10 to 50 characters in length.
	/// </remarks>
	[Required(ErrorMessage = "Id is required.")]
	[MaxLength(50, ErrorMessage = "Id must be a maximum of 50 characters.")]
	[MinLength(10, ErrorMessage = "Id must be at least 10 characters.")]
	[DisallowNull()]
	public string Id { get; init; }

}
