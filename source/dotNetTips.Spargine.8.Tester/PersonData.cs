// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2023
// ***********************************************************************
// <copyright file="PersonData.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Tester.Data;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Class PersonData.
/// Implements the <see cref="IEquatable{PersonData}" />
/// </summary>
/// <seealso cref="IEquatable{PersonData}" />
[Serializable]
public sealed record PersonData
{

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonData"/> class.
	/// </summary>
	public PersonData() { }

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonData"/> class.
	/// </summary>
	/// <param name="bornOn">The born on.</param>
	/// <param name="cellPhone">The cell phone.</param>
	/// <param name="country">The country.</param>
	/// <param name="email">The email.</param>
	/// <param name="firstName">The first name.</param>
	/// <param name="lastName">The last name.</param>
	/// <param name="phone">The phone.</param>
	/// <exception cref="ArgumentNullException">cellPhone</exception>
	/// <exception cref="ArgumentNullException">country</exception>
	/// <exception cref="ArgumentNullException">email</exception>
	/// <exception cref="ArgumentNullException">firstName</exception>
	/// <exception cref="ArgumentNullException">lastName</exception>
	/// <exception cref="ArgumentNullException">phone</exception>
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
	/// Gets the born on date.
	/// </summary>
	/// <value>The born on.</value>
	public DateTimeOffset BornOn { get; init; }

	/// <summary>
	/// Gets the cell phone number.
	/// </summary>
	/// <value>The cell phone.</value>
	public string CellPhone { get; init; }

	/// <summary>
	/// Gets the country.
	/// </summary>
	/// <value>The country.</value>
	public Country Country { get; init; }

	/// <summary>
	/// Gets the email.
	/// </summary>
	/// <value>The email.</value>
	public string Email { get; init; }

	/// <summary>
	/// Gets the first name.
	/// </summary>
	/// <value>The first name.</value>
	public string FirstName { get; init; }

	/// <summary>
	/// Gets the last name.
	/// </summary>
	/// <value>The last name.</value>
	public string LastName { get; init; }

	/// <summary>
	/// Gets the phone.
	/// </summary>
	/// <value>The phone.</value>
	public string Phone { get; init; }

}
