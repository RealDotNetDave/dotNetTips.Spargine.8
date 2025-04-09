// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 04-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-09-2025
// ***********************************************************************
// <copyright file="AssemblyHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[TestClass]
public class AssemblyHelperTests
{
	[TestMethod]
	public void FindNetSDKFiles_DotnetRootSet_ReturnsFiles()
	{
		// Act
		var result = AssemblyHelper.FindNetSDKFiles(null);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find .NET SDK files, but none were found.");
	}

	[TestMethod]
	public void FindNetSDKFiles_NoMatchingVersion_ReturnsEmpty()
	{
		// Act
		var result = AssemblyHelper.FindNetSDKFiles("99.99.99");

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Expected no .NET SDK files for version 99.99.99, but some were found.");
	}

	[TestMethod]
	public void FindNetSDKFiles_SpecificVersion_ReturnsFiles()
	{
		// Act
		var result = AssemblyHelper.FindNetSDKFiles("8.0.15");

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find .NET SDK files for version 8.0.15, but none were found.");
	}
}

