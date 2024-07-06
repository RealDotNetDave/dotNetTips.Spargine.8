// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-05-2023
//
// Last Modified By : David McCarter
// Last Modified On : 05-05-2023
// ***********************************************************************
// <copyright file="WIP.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Threading;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests;
[ExcludeFromCodeCoverage]
[TestClass]
public class WIP
{

	[TestMethod]
	public void TEST01()
	{
		var result = PathHelper.PathSeparators;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void TEST02()
	{
		var result = PathHelper.InvalidPathNameChars().ToList().ToDelimitedString();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void TEST03()
	{
		//var result = PathHelper.InvalidFilterChars().ToList().ToDelimitedString();

		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-HK");

		var result = string.Format(CultureInfo.CurrentCulture, "The time is now: {0}.", DateTime.Now);

		Assert.IsNotNull(result);
	}

}
