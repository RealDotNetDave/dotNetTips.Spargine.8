// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 06-15-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-06-2024
// ***********************************************************************
// <copyright file="ReadOnlyCollectionExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ReadOnlyCollectionExtensionsTests
{

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var collection = new ReadOnlyCollection<Coordinate>(RandomData.GenerateCoordinateCollection<Coordinate>(10).ToCollection());
		ReadOnlyCollection<Coordinate> nullCollection = null;

		Assert.IsFalse(collection.DoesNotHaveItems());

		Assert.IsTrue(nullCollection.DoesNotHaveItems());
	}
	[TestMethod]
	public void HasItemsTest()
	{
		var collection = new ReadOnlyCollection<Coordinate>(RandomData.GenerateCoordinateCollection<Coordinate>(10).ToCollection());
		ReadOnlyCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsTestWithCount()
	{
		var collection = new ReadOnlyCollection<Coordinate>(RandomData.GenerateCoordinateCollection<Coordinate>(10).ToCollection());
		ReadOnlyCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems(10));

		Assert.IsFalse(collection.HasItems(100));

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsTestWithFunction()
	{
		var collection = new ReadOnlyCollection<Coordinate>(RandomData.GenerateCoordinateCollection<Coordinate>(10).ToCollection());
		ReadOnlyCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems(p => p.X > 0));

		Assert.IsFalse(nullCollection.HasItems());
	}

}
