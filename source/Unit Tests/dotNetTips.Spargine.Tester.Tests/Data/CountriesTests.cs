using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Tester.Tests.Data;

[ExcludeFromCodeCoverage]
[TestClass]
public class CountriesTests
{
	[TestMethod]
	public void LoadCountriesTest()
	{
		var result = DotNetTips.Spargine.Tester.Data.Countries.GetCountries();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.Length == 250);
	}
}
