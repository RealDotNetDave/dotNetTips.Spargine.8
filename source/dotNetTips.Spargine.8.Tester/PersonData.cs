// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="PersonData.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Class that represents person data, including properties BornOn,
// CellPhone, Country, Email, FirstName, LastName, and Phone.
// </summary>
// ***********************************************************************

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Data.Models;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Represents person data including personal information and contact details.
/// </summary>
[DataContract(Name = "PersonData", Namespace = "http://DotNetTips.Spargine.Tester")]
[DebuggerDisplay("FirstName = {FirstName}, LastName = {LastName}, Email = {Email}")]
[Serializable]
public sealed record PersonData
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PersonData"/> class.
	/// </summary>
	[ExcludeFromCodeCoverage]
	public PersonData()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonData"/> class with detailed personal and contact information.
	/// </summary>
	/// <param name="bornOn">The date and time the person was born.</param>
	/// <param name="cellPhone">The cell phone number. Cannot be null.</param>
	/// <param name="country">The country. Cannot be null.</param>
	/// <param name="email">The email address. Cannot be null.</param>
	/// <param name="firstName">The first name. Cannot be null.</param>
	/// <param name="lastName">The last name. Cannot be null.</param>
	/// <param name="phone">The phone number. Cannot be null.</param>
	/// <exception cref="ArgumentNullException">Thrown when a required argument is null.</exception>
	[Information(nameof(PersonData), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public PersonData(DateTimeOffset bornOn, string cellPhone, Country country, string email, string firstName, string lastName, string phone)
	{
		this.BornOn = bornOn;
		this.CellPhone = cellPhone ?? throw new ArgumentNullException(nameof(cellPhone));
		this.Country = country ?? throw new ArgumentNullException(nameof(country));
		this.Email = email ?? throw new ArgumentNullException(nameof(email));
		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
		this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
		this.Phone = phone ?? throw new ArgumentNullException(nameof(phone));
	}

	/// <summary>
	/// Gets the date and time the person was born.
	/// </summary>
	/// <value>The date and time of birth.</value>
	[DataMember(Order = 1)]
	public DateTimeOffset BornOn { get; init; }

	/// <summary>
	/// Gets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	[DataMember(Order = 2)]
	public string CellPhone { get; init; } = string.Empty;

	/// <summary>
	/// Gets the country.
	/// </summary>
	/// <value>The country.</value>
	[DataMember(Order = 3)]
	public Country Country { get; init; } = default!;

	/// <summary>
	/// Gets the email address.
	/// </summary>
	/// <value>The email address.</value>
	[DataMember(Order = 4)]
	public string Email { get; init; } = string.Empty;

	/// <summary>
	/// Gets the first name.
	/// </summary>
	/// <value>The first name.</value>
	[DataMember(Order = 5)]
	public string FirstName { get; init; } = string.Empty;

	/// <summary>
	/// Gets the last name.
	/// </summary>
	/// <value>The last name.</value>
	[DataMember(Order = 6)]
	public string LastName { get; init; } = string.Empty;

	/// <summary>
	/// Gets the phone number.
	/// </summary>
	/// <value>The phone number.</value>
	[DataMember(Order = 7)]
	public string Phone { get; init; } = string.Empty;
}
