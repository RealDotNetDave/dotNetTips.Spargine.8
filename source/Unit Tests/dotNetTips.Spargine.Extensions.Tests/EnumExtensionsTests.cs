// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="EnumExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumExtensionsTests
{

	[TestMethod]
	public void GetDescriptionTest()
	{
		var enumValue = TaskStatus.Canceled;

		var result = enumValue.GetDescription();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void GetItemsTest()
	{
		var result = TaskStatus.Canceled.GetItems();

		Assert.IsTrue(result.FastCount() > 0);
	}

	[TestMethod]
	public void ParseTest()
	{

		var result = "Canceled".Parse<TaskStatus>();

		Assert.IsTrue(string.Compare(result.ToString(), "Canceled", StringComparison.Ordinal) == 0);

	}

}
