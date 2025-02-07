// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Common.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-29-2023
// ***********************************************************************
// <copyright file="ComputerInfoTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ComputerInfoTests
{

	[TestMethod]
	public void ComputerInfoTest()
	{
		var ci = new ComputerInfo();

		Assert.IsNotNull(ci);
	}

	[TestMethod]
	public void IsNetworkAvailable_NetworkIsAvailable_ReturnsTrue()
	{
		// Act
		var result = new ComputerInfo().IsNetworkAvailable;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void LoggableExceptionComputerInfoTest()
	{
		var ex = new LoggableException();

		var result = ex.ComputerInformation;

		Assert.IsNotNull(result);
	}
}

