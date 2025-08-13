// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 11-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 08-13-2025
// ***********************************************************************
// <copyright file="IAddress.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Interface "IAddress" that defines properties for Address1 and
// Address2, City, Country, CountryProvince, Phone, PostalCode,
// and State. This interface inherits from another interface named
// IAddress.
// </summary>
// ***********************************************************************

using System.ComponentModel.DataAnnotations;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Defines the contract for an address model, including properties for address lines, city, country, county or province, phone number, postal code, and state.
/// </summary>
public interface IAddress : IDataModel<IAddress, string>
{

	/// <summary>
	/// Gets or sets the first line of the address.
	/// </summary>
	/// <value>The first line of the address.</value>
	public string Address1 { get; set; }

	/// <summary>
	/// Gets or sets the second line of the address.
	/// </summary>
	/// <value>The second line of the address. This field is optional.</value>
	public string Address2 { get; set; }

	/// <summary>
	/// Gets or sets the city where the address is located.
	/// </summary>
	/// <value>The city of the address.</value>
	public string City { get; set; }

	/// <summary>
	/// Gets or sets the country part of the address.
	/// </summary>
	/// <value>The country where the address is located.</value>
	[StringLength(50, ErrorMessage = "The country must not exceed 50 characters.")]
	public string Country { get; set; }

	/// <summary>
	/// Gets or sets the county or province part of the address.
	/// </summary>
	/// <value>The county or province where the address is located. This field is optional.</value>
	public string CountyProvince { get; set; }

	/// <summary>
	/// Gets or sets the phone number associated with the address.
	/// </summary>
	/// <value>The phone number.</value>
	[Phone(ErrorMessage = "The phone number is not in a valid format.")]
	public string Phone { get; set; }

	/// <summary>
	/// Gets or sets the postal code for the address.
	/// </summary>
	/// <value>The postal code where the address is located.</value>
	public string PostalCode { get; set; }

	/// <summary>
	/// Gets or sets the state or region part of the address.
	/// </summary>
	/// <value>The state or region where the address is located.</value>
	public string State { get; set; }

}
