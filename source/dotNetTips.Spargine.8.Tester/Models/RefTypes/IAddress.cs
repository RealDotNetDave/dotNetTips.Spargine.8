// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 11-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-26-2023
// ***********************************************************************
// <copyright file="IAddress.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Interface IAddress
/// </summary>
public interface IAddress : IDataModel<IAddress, string>
{

	/// <summary>
	/// Gets the address1.
	/// </summary>
	/// <value>The address1.</value>
	string Address1 { get; set; }

	/// <summary>
	/// Gets the address2.
	/// </summary>
	/// <value>The address2.</value>
	string Address2 { get; set; }

	/// <summary>
	/// Gets the city.
	/// </summary>
	/// <value>The city.</value>
	string City { get; set; }

	/// <summary>
	/// Gets the country.
	/// </summary>
	/// <value>The country.</value>
	string Country { get; set; }

	/// <summary>
	/// Gets the county province.
	/// </summary>
	/// <value>The county province.</value>
	string CountyProvince { get; set; }

	/// <summary>
	/// Gets the phone number.
	/// </summary>
	/// <value>The phone.</value>
	string Phone { get; set; }

	/// <summary>
	/// Gets the postal code.
	/// </summary>
	/// <value>The postal code.</value>
	string PostalCode { get; set; }

	/// <summary>
	/// Gets the state.
	/// </summary>
	/// <value>The state.</value>
	string State { get; set; }

}