// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2024
// ***********************************************************************
// <copyright file="SimpleResultTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SimpleResultTests
{

	[TestMethod]
	public void ErrorMessagesTest()
	{
		var ex = new ArgumentException("Invalue value for the parameter.");

		var result = SimpleResult.FromException<string>(ex);

		var errors = result.GetErrorMessages();

		Assert.IsTrue(errors.Any());
	}
	[TestMethod]
	public void FromExceptionTest()
	{
		var ex = new ArgumentException("Argument Exception");

		var result = SimpleResult.FromException<string>(ex);

		Assert.IsFalse(result.Status == ResultStatus.Failed);
	}

	[TestMethod]
	public void FromValueTest()
	{
		var person = RandomData.GeneratePersonRef<Address>();

		var result = SimpleResult.FromValue(person);

		Assert.IsTrue(result.Status == ResultStatus.Succeeded);
	}

}
