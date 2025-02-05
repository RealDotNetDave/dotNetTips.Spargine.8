// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-04-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-04-2025
// ***********************************************************************
// <copyright file="AutoDefaultDictionaryTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic;

[ExcludeFromCodeCoverage]
[TestClass]
public class AutoDefaultDictionaryTests
{

	[TestMethod]
	public void ConstructorWithComparer_ShouldInitializeWithDefaultValue()
	{
		// Arrange
		var comparer = EqualityComparer<int>.Default;
		var dictionary = new AutoDefaultDictionary<int, string>(comparer);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.IsNull(value);
	}

	[TestMethod]
	[ExpectedException(typeof(KeyNotFoundException))]
	public void DefaultConstructor_ShouldFailLikeStdDictionary()
	{
		var dictionary = new AutoDefaultDictionary<int, string>();
		// Act
		var value = dictionary[1];

	}

	[TestMethod]
	public void ConstructorWithDefaultValue_ShouldInitializeWithSpecifiedDefaultValue()
	{
		// Arrange
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(defaultValue);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual(defaultValue, value);
	}

	[TestMethod]
	public void ConstructorWithDefaultValueAndComparer_ShouldInitializeWithSpecifiedDefaultValue()
	{
		// Arrange
		var defaultValue = "default";
		var comparer = EqualityComparer<int>.Default;
		var dictionary = new AutoDefaultDictionary<int, string>(defaultValue, comparer);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual(defaultValue, value);
	}

	[TestMethod]
	public void ConstructorWithKeyValuePairs_ShouldInitializeWithSpecifiedDefaultValue()
	{
		// Arrange
		var keyValuePairs = new List<KeyValuePair<int, string>>
	{
		new KeyValuePair<int, string>(1, "one"),
		new KeyValuePair<int, string>(2, "two")
	};
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(keyValuePairs, defaultValue);

		// Act
		var value1 = dictionary[1];
		var value2 = dictionary[2];
		var value3 = dictionary[3];

		// Assert
		Assert.AreEqual("one", value1);
		Assert.AreEqual("two", value2);
		Assert.AreEqual(defaultValue, value3);
	}


	/// <summary>
	/// This probably should be split into several test methods.
	/// </summary>
	[TestMethod]
	public void ConstructorDelegate_ShouldInitializeWithReturnedValue()
	{
		// Arrange
		var callsToDelegate = 0;
		var dictionary = new AutoDefaultDictionary<int, string>(key =>
		{
			callsToDelegate++;
			return key.RoundToPowerOf2().ToString();
		});
		dictionary[2] = "two";		// value not affected by delegate

		// Act
		var value5 = dictionary[5];				// Should be counted in callsToDelegate
		var value10 = dictionary[10];			// Should be counted in callsToDelegate
		var value100 = dictionary[100];		// Should be counted in callsToDelegate
		var value2 = dictionary[2];				// Should NOT be counted in callsToDelegate   (directly added)
		var value10a = dictionary[10];			// Should NOT be counted in callsToDelegate   (Added by previous lookup)

		// Make many calls to added item.   Should NOT be counted in callsToDelegate
		var value5a = dictionary[5] + dictionary[5] + dictionary[5];


		// Assert
		Assert.AreEqual("8", value5);
		Assert.AreEqual("16", value10);
		Assert.AreEqual("128", value100);
		Assert.AreEqual(value10a, value10);
		Assert.AreEqual("two", value2);
		Assert.AreEqual("888",  value5a);

		Assert.AreEqual(3, callsToDelegate);
		Assert.AreEqual(4, dictionary.Count);
	}

	[TestMethod]
	public void GetDefaultCoordinate()
	{
		var coordinates = RandomData.GenerateCoordinateCollection<Coordinate>(256)
									.ToDictionary(coord => RandomData.GenerateKey(), coord => coord);

		var defaultCoordinate = RandomData.GenerateCoordinate<Coordinate>();

		var dictionary = new AutoDefaultDictionary<string, Coordinate>(coordinates, defaultCoordinate);

		var result = dictionary["notincollection"];

		Assert.AreEqual(defaultCoordinate, result);
	}


	[TestMethod]
	public void IndexerGet_ShouldReturnDefaultValueWhenKeyDoesNotExist()
	{
		// Arrange
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(defaultValue);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual(defaultValue, value);
	}

	[TestMethod]
	public void IndexerGet_ShouldReturnExistingValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>();
		dictionary[1] = "value";

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual("value", value);
	}

	[TestMethod]
	public void IndexerSet_ShouldSetValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>();

		// Act
		dictionary[1] = "value";
		var value = dictionary[1];

		// Assert
		Assert.AreEqual("value", value);
	}
}
