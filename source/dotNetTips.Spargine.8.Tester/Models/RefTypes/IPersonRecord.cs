// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2025
// ***********************************************************************
// <copyright file="PersonRecord.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// A real-world type for testing and benchmarking named "PersonRecord"
// with the following properties: Addresses, Age, BornOn, CellPhone,
// Email, FirstName, FullName, LastName, and Phone. Additionally,
// this type includes methods to convert from both Person reference
// and value types to PersonRecord.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Tester.Models.RefTypes;
/// <summary>
/// Represents a contract for a person record with properties such as addresses, contact information, and personal details.
/// </summary>
/// <remarks>
/// This interface is designed to define the structure of a person record, including properties for addresses, phone numbers, email, and personal identifiers.
/// It is intended to be implemented by classes or records that represent a person in various contexts, such as testing or benchmarking.
/// </remarks>
public interface IPersonRecord : IDataRecord
{
	/// <summary>
	/// Gets or sets the collection of addresses for the person. This collection encapsulates all the addresses associated with the person,
	/// allowing for multiple addresses such as home, work, or other. Implementing classes should ensure proper initialization of this collection
	/// to avoid null reference exceptions.
	/// </summary>
	/// <value>The collection of addresses.</value>
	public Collection<AddressRecord> Addresses { get; init; }

	/// <summary>
	/// Gets or sets the date and time when the person was born.
	/// </summary>
	/// <value>The date and time representing the person's birth date.</value>
	[DataType(DataType.Date)]
	public DateTimeOffset BornOn { get; init; }

	/// <summary>
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	[Phone(ErrorMessage = "The cell phone number is not in a valid format.")]
	public string CellPhone { get; init; }

	/// <summary>
	/// Gets or sets the email address. Implementing classes should ensure the email address is in a valid format
	/// as specified by the <see cref="EmailAddressAttribute"/>.
	/// </summary>
	/// <value>The email address.</value>
	[EmailAddress(ErrorMessage = "The email address is not in a valid format.")]
	public string Email { get; init; }

	/// <summary>
	/// Gets or sets the person's first name. This property is constrained by a maximum length of 50 characters.
	/// </summary>
	/// <value>The first name of the person.</value>
	[StringLength(50, ErrorMessage = "The first name must not exceed 50 characters.")]
	public string FirstName { get; init; }

	/// <summary>
	/// Gets or sets the person's last name. This property is constrained by a maximum length of 50 characters,
	/// ensuring that the last name adheres to a standardized format suitable for storage and display.
	/// </summary>
	/// <value>The last name of the person.</value>
	[StringLength(50, ErrorMessage = "The last name must not exceed 50 characters.")]
	public string LastName { get; init; }

	/// <summary>
	/// Gets or sets the phone number. Implementing classes should ensure the phone number is in a valid format
	/// as specified by the <see cref="PhoneAttribute"/>.
	/// </summary>
	/// <value>The phone number.</value>
	[Phone(ErrorMessage = "The phone number is not in a valid format.")]
	public string Phone { get; init; }
}
