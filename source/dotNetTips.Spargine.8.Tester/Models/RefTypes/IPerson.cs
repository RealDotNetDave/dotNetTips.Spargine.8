// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 07-10-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-13-2025
// ***********************************************************************
// <copyright file="IPerson.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Interface "IPerson" that defines properties for Addresses, BornOn,
// CellPhone, Email, FirstName, LastName, and Phone.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Defines the contract for a person entity. This interface encapsulates properties for personal and contact information,
/// including multiple addresses, birth date, cell phone number, email address, first name, last name, and phone number.
/// It extends the <see cref="IDataModel{TModel, TKey}"/> interface, allowing for integration with data models,
/// and enforces a constraint on the address type to ensure it implements <see cref="IAddress"/> and has a parameterless constructor,
/// facilitating ease of instantiation and flexibility in address management.
/// </summary>
/// <typeparam name="TAddress">The type of address, constrained to types that implement <see cref="IAddress"/> and have a parameterless constructor, allowing for flexible address management.</typeparam>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public interface IPerson<TAddress> : IDataModel<IPerson<TAddress>, string> where TAddress : IAddress, new()
{
	/// <summary>
	/// Gets or sets the collection of addresses for the person. This collection encapsulates all the addresses associated with the person,
	/// allowing for multiple addresses such as home, work, or other. Implementing classes should ensure proper initialization of this collection
	/// to avoid null reference exceptions.
	/// </summary>
	/// <value>The collection of addresses.</value>
	public Collection<TAddress> Addresses { get; set; }

	/// <summary>
	/// Gets or sets the date and time when the person was born.
	/// </summary>
	/// <value>The date and time representing the person's birth date.</value>
	public DateTimeOffset BornOn { get; set; }

	/// <summary>
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	public string CellPhone { get; set; }

	/// <summary>
	/// Gets or sets the email address. Implementing classes should ensure the email address is in a valid format
	/// as specified by the <see cref="EmailAddressAttribute"/>.
	/// </summary>
	/// <value>The email address.</value>
	public string Email { get; set; }

	/// <summary>
	/// Gets or sets the person's first name. This property is constrained by a maximum length of 50 characters.
	/// </summary>
	/// <value>The first name of the person.</value>
	public string FirstName { get; set; }

	/// <summary>
	/// Gets or sets the person's last name. This property is constrained by a maximum length of 50 characters,
	/// ensuring that the last name adheres to a standardized format suitable for storage and display.
	/// </summary>
	/// <value>The last name of the person.</value>
	public string LastName { get; set; }

	/// <summary>
	/// Gets or sets the phone number. Implementing classes should ensure the phone number is in a valid format
	/// as specified by the <see cref="PhoneAttribute"/>.
	/// </summary>
	/// <value>The phone number.</value>
	public string Phone { get; set; }
}
