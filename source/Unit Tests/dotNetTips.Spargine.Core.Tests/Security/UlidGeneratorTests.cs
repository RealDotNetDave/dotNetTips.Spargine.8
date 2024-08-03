// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 08-03-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-03-2024
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

[TestClass]
public class UlidGeneratorTests
{
	[TestMethod]
	public void ExtractTimestamp_ShouldReturnCorrectTimestamp()
	{
		// Arrange
		var ulid = UlidGenerator.GenerateUlid();
		var expectedTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

		// Act
		var timestamp = UlidGenerator.ExtractTimestamp(ulid);

		// Assert
		Assert.IsTrue(Math.Abs((timestamp.ToUnixTimeMilliseconds() - expectedTimestamp)) > 10000);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ExtractTimestamp_ShouldThrowArgumentException()
	{
		// Arrange
		var invalidUlid = "12345";

		// Act
		UlidGenerator.ExtractTimestamp(invalidUlid);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ExtractTimestamp_ShouldThrowArgumentNullException()
	{
		// Act
		UlidGenerator.ExtractTimestamp(null);
	}

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

