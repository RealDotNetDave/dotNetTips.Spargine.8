// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 07-10-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-28-2023
// ***********************************************************************
// <copyright file="IPerson.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Core interface for Person.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// The interface for IPerson
/// </summary>
/// <typeparam name="TAddress">The type of the t address.</typeparam>
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public interface IPerson<TAddress> : IDataModel<IPerson<TAddress>, string> where TAddress : IAddress, new()
{

	/// <summary>
	/// Gets the addresses.
	/// </summary>
	/// <value>The addresses.</value>
	Collection<TAddress> Addresses { get; set; }

	/// <summary>
	/// Gets or sets the born on date.
	/// </summary>
	/// <value>The born on.</value>
	DateTimeOffset BornOn { get; set; }

	/// <summary>
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	string CellPhone { get; set; }

	/// <summary>
	/// Gets or sets the email address.
	/// </summary>
	/// <value>The email address.</value>
	string Email { get; set; }

	/// <summary>
	/// Gets or sets the person's first name.
	/// </summary>
	/// <value>The first name.</value>
	string FirstName { get; set; }

	/// <summary>
	/// Gets or sets the person's last name.
	/// </summary>
	/// <value>The last name.</value>
	string LastName { get; set; }

	/// <summary>
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	string Phone { get; set; }

}