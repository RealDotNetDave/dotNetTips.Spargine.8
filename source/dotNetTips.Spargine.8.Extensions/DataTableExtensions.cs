// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="DataTableExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the DataTable type.</summary>
// ***********************************************************************
using System.Data;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="DataTable"/> type, enhancing its functionality with additional utility methods.
/// These methods include checking if a DataTable has any rows and if an object is a database null value.
/// </summary>
/// <remarks>
/// The extension methods provided in this class are designed to simplify common operations performed on <see cref="DataTable"/> instances,
/// such as determining if the table contains any rows or if a particular value is equivalent to a database null. These utilities can help
/// streamline data handling and validation processes in applications that interact with databases.
/// </remarks>
public static class DataTableExtensions
{

	/// <summary>
	/// Determines whether the specified <see cref="DataTable" /> has rows.
	/// </summary>
	/// <param name="table">The table.</param>
	/// <returns><c>true</c> if the specified table has rows; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasRows), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool HasRows(this DataTable table) => (table is not null) && (table.Rows is not null) && (table.Rows.Count > 0);

	/// <summary>
	/// Determines whether [is database null] [the specified value].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if [is database null] [the specified value]; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasRows), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool IsDBNull(this object value) => Convert.IsDBNull(value);

}
