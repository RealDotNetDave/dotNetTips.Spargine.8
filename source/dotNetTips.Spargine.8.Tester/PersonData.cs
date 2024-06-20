// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="PersonData.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Class that represents person data, including properties BornOn,
// CellPhone, Country, Email, FirstName, LastName, and Phone.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Data;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Represents person data including personal information and contact details.
/// </summary>
[Serializable]
public sealed record PersonData
{

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonData" /> class.
	/// </summary>
	public PersonData() { }

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonData"/> class.
	/// </summary>
	/// <param name="bornOn">The date and time the person was born.</param>
	/// <param name="cellPhone">The cell phone number. Cannot be null.</param>
	/// <param name="country">The country. Cannot be null.</param>
	/// <param name="email">The email address. Cannot be null.</param>
	/// <param name="firstName">The first name. Cannot be null.</param>
	/// <param name="lastName">The last name. Cannot be null.</param>
	/// <param name="phone">The phone number. Cannot be null.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="cellPhone"/>, <paramref name="country"/>, <paramref name="email"/>, <paramref name="firstName"/>, <paramref name="lastName"/>, or <paramref name="phone"/> is null.</exception>
	public PersonData(DateTimeOffset bornOn, [NotNull] string cellPhone, [NotNull] Country country, [NotNull] string email, [NotNull] string firstName, [NotNull] string lastName, [NotNull] string phone)
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
	public DateTimeOffset BornOn { get; init; }

	/// <summary>
	/// Gets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	/// <seealso cref="PersonData"/>
	[NotNull]
	public string CellPhone { get; init; }

	/// <summary>
	/// Gets the country.
	/// </summary>
	/// <value>The country.</value>
	/// <seealso cref="Country"/>
	[NotNull]
	public Country Country { get; init; }

	/// <summary>
	/// Gets the email address.
	/// </summary>
	/// <value>The email address.</value>
	/// <seealso cref="PersonData"/>
	[NotNull]
	public string Email { get; init; }

	/// <summary>
	/// Gets the first name.
	/// </summary>
	/// <value>The first name.</value>
	/// <seealso cref="PersonData"/>
	[NotNull]
	public string FirstName { get; init; }

	/// <summary>
	/// Gets the last name.
	/// </summary>
	/// <value>The last name.</value>
	/// <seealso cref="PersonData"/>
	[NotNull]
	public string LastName { get; init; }

	/// <summary>
	/// Gets the phone number.
	/// </summary>
	/// <value>The phone number.</value>
	/// <seealso cref="PersonData"/>
	[NotNull]
	public string Phone { get; init; }

}
