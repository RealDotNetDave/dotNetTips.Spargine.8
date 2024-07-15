// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-29-2023
// ***********************************************************************
// <copyright file="EnumHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net.Cache;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumHelperTests
{

	[TestMethod]
	public void GetValuesTest()
	{
		var result = EnumHelper.GetValues<RequestCacheLevel>(false, false);
		Assert.IsTrue(result.FastCount() > 0);

		result = EnumHelper.GetValues<HttpCacheAgeControl>(fixNames: true, useXmlNames: false);
		Assert.IsTrue(result.FastCount() > 0);

		result = EnumHelper.GetValues<HttpCacheAgeControl>(false, true);
		Assert.IsTrue(result.FastCount() > 0);

		result = EnumHelper.GetValues<HttpCacheAgeControl>(true, true);
		Assert.IsTrue(result.FastCount() > 0);
	}

}
