// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="CountryDataTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Data;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Data;

[ExcludeFromCodeCoverage]
[TestClass]
public class CountryDataTests
{

	[TestMethod]
	public void GetCountriesTest()
	{
		var countries = CountryRepository.GetCountries();

		Assert.IsNotNull(countries);

		Assert.IsTrue(countries.Count() == 250);
	}

	[TestMethod]
	public void GetCountryByIdTest()
	{
		var country = CountryRepository.GetCountry(233);

		Assert.IsNotNull(country);
	}

	[TestMethod]
	public void GetCountryByNameTest()
	{
		var country = CountryRepository.GetCountry(CountryName.UnitedStates);

		Assert.IsNotNull(country);
	}

	[TestMethod]
	public void ValidatePhoneNumberDOInvalidCountryCodeTest()
	{

		var result = CountryRepository.ValidatePhoneNumber(CountryName.DominicanRepublic, "900-555-666-7777", true);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberDOValidCountryCodeTest()
	{

		var result = CountryRepository.ValidatePhoneNumber(CountryName.DominicanRepublic, "1-809-555-666-7777", true);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberUSInvalidCountryCodeTest()
	{

		var result = CountryRepository.ValidatePhoneNumber(CountryName.UnitedStates, "9-555-666-7777", true);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberUSInvalidTest()
	{

		var result = CountryRepository.ValidatePhoneNumber(CountryName.UnitedStates, "12-34");

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberUSValidCountryCodeTest()
	{

		var result = CountryRepository.ValidatePhoneNumber(CountryName.UnitedStates, "1-555-666-7777", true);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePhoneNumberUSValidTest()
	{

		var result = CountryRepository.ValidatePhoneNumber(CountryName.UnitedStates, "555-666-7777");

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidatePostalCodeUSInvalidTest()
	{

		var result = CountryRepository.ValidatePostalCode(CountryName.UnitedStates, "1234");

		Assert.IsTrue(result == PostalCodeState.Invalid);
	}

	[TestMethod]
	public void ValidatePostalCodeUSValidFullTest()
	{

		var result = CountryRepository.ValidatePostalCode(CountryName.UnitedStates, "92130-1234");

		Assert.IsTrue(result == PostalCodeState.Valid);
	}

	[TestMethod]
	public void ValidatePostalCodeUSValidTest()
	{

		var result = CountryRepository.ValidatePostalCode(CountryName.UnitedStates, "92130");

		Assert.IsTrue(result == PostalCodeState.Valid);
	}
}
