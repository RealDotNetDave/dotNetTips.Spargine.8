// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-12-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-09-2024
// ***********************************************************************
// <copyright file="CollectionRandomizerTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic;

[ExcludeFromCodeCoverage]
[TestClass]
public class CollectionRandomizerTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Constructor_WithNullCollection_ShouldThrowArgumentNullException()
	{
		// Arrange, Act & Assert
		_ = new CollectionRandomizer<int>(null);
	}
	[TestMethod]
	public void Constructor_WithValidCollection_ShouldNotThrow()
	{
		// Arrange
		var collection = Enumerable.Range(1, 10);

		// Act & Assert
		Assert.IsNotNull(new CollectionRandomizer<int>(collection));
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidOperationException))]
	public void GetNext_WithExhaustedNonRepeatingCollection_ShouldThrowInvalidOperationException()
	{
		// Arrange
		var collection = Enumerable.Range(1, 3).ToList();
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		while (true) // Intentionally infinite loop to force the exception
		{
			randomizer.GetNext();
		}

		// Assert is handled by the ExpectedException attribute
	}

	[TestMethod]
	public void GetNext_WithRepeatingCollection_ShouldRepeatItems()
	{
		// Arrange
		var collection = Enumerable.Range(1, 5).ToList();
		var randomizer = new CollectionRandomizer<int>(collection, true);
		var retrievedItems = new List<int>();

		// Act
		for (int i = 0; i < collection.Count * 2; i++) // Retrieve twice the number of items in the collection
		{
			retrievedItems.Add(randomizer.GetNext());
		}

		// Assert
		Assert.IsTrue(retrievedItems.Count > collection.Count); // Ensure more items were retrieved than in the original collection
		Assert.IsTrue(retrievedItems.Distinct().Count() == collection.Count); // Ensure all original items were retrieved
	}

}
