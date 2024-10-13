// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-13-2024
// ***********************************************************************
// <copyright file="ObservableCollectionExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ObservableCollectionExtensionsTests
{

	private readonly int _count = 2500;

	[TestMethod]
	public void DoesNotHaveItems_EmptyCollection_ReturnsTrue()
	{
		var emptyCollection = new ObservableCollection<int>();
		var result = emptyCollection.DoesNotHaveItems();
		Assert.IsTrue(result, "Expected result to be true for an empty collection.");
	}

	[TestMethod]
	public void DoesNotHaveItems_NonEmptyCollection_ReturnsFalse()
	{
		var nonEmptyCollection = new ObservableCollection<int> { 1, 2, 3 };
		var result = nonEmptyCollection.DoesNotHaveItems();
		Assert.IsFalse(result, "Expected result to be false for a non-empty collection.");
	}

	[TestMethod]
	public void DoesNotHaveItems_NullCollection_ReturnsFalse()
	{
		ObservableCollection<int> nullCollection = null;
		var result = nullCollection.DoesNotHaveItems();
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(this._count).ToList().ToObservableCollection();
		ObservableCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}


	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(this._count).ToList().ToObservableCollection();
		ObservableCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems(this._count));

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsWithFunctionTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(this._count).ToList().ToObservableCollection();
		ObservableCollection<Coordinate> nullCollection = null;

		Func<Coordinate, bool> selector = (coordinate) => coordinate.X > 0;

		Assert.IsTrue(collection.HasItems(selector));

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void ToObservableCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(this._count).ToList();

		//Test 
		Assert.IsTrue(people.ToObservableCollection().HasItems());
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(this._count).ToList();

		//Test 
		Assert.IsTrue(people.ToReadOnlyObservableCollection().HasItems());
	}

}
