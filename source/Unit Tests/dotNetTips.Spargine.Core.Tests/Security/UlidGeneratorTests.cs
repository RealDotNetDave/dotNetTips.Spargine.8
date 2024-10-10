// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 08-03-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-03-2024
// ***********************************************************************
// <copyright file="UlidGeneratorTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Security;

/// <summary>
/// Defines test class UlidGeneratorTests.
/// </summary>
[TestClass]
public class UlidGeneratorTests
{

	/// <summary>
	/// Defines the test method GenerateMultipleUlids_ShouldReturnCorrectCount.
	/// </summary>
	[TestMethod]
	public void GenerateMultipleUlids_ShouldReturnCorrectCount()
	{
		// Arrange
		int count = 1000000;

		// Act
		ReadOnlyCollection<string> ulids = UlidGenerator.GenerateMultipleUlids(count);

		// Assert
		Assert.AreEqual(count, ulids.Count);

		// Make sure all ULIDs are unique
		CollectionAssert.AllItemsAreUnique(ulids);
	}

	/// <summary>
	/// Defines the test method GenerateUlid_ShouldReturnValidUlid.
	/// </summary>
	[TestMethod]
	public void GenerateUlid_ShouldReturnValidUlid()
	{
		// Act
		var ulid = UlidGenerator.GenerateUlid();

		// Assert
		Assert.IsNotNull(ulid);
		Assert.AreEqual(26, ulid.Length);
	}
}

