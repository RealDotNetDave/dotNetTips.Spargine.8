// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 07-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2024
// ***********************************************************************
// <copyright file="GuidExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class GuidExtensionsTests
{

	[TestMethod]
	public void ToDigits()
	{
		var result = Guid.NewGuid().ToDigits();

		Assert.IsNotNull(result);
	}

}
