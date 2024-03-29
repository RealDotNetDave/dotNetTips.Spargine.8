// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="DataTableExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the DataTable type.</summary>
// ***********************************************************************
using System.Data;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extension methods for the DataTable type.
/// </summary>
public static class DataTableExtensions
{

	/// <summary>
	/// Determines whether the specified <see cref="DataTable" /> has rows.
	/// </summary>
	/// <param name="table">The table.</param>
	/// <returns><c>true</c> if the specified table has rows; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasRows), author: "David McCarter", createdOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
	public static bool HasRows(this DataTable table) => (table is not null) && (table.Rows is not null) && (table.Rows.Count > 0);

	/// <summary>
	/// Determines whether [is database null] [the specified value].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if [is database null] [the specified value]; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasRows), author: "David McCarter", createdOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
	public static bool IsDBNull(this object value) => Convert.IsDBNull(value);

}
