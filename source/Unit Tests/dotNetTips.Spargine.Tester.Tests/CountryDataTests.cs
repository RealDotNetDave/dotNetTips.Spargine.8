// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-02-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2024
// ***********************************************************************
// <copyright file="CountryDataTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CountryDataTests
{

	[TestMethod]
	public void GetCountriesTest()
	{
		var countries = Countries.GetCountries();

		Assert.IsNotNull(countries);

		Assert.IsTrue(countries.Count == 250);
	}

	[TestMethod]
	public void GetCountryByIdTest()
	{
		var country = Countries.GetCountry(233);

		Assert.IsNotNull(country);
	}

	[TestMethod]
	public void GetCountryByNameTest()
	{
		var country = Countries.GetCountry(CountryName.UnitedStates);

		Assert.IsNotNull(country);
	}

}