// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2024
// ***********************************************************************
// <copyright file="ImmutableArrayTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;
[ExcludeFromCodeCoverage]
[TestClass]
public class ImmutableArrayTests
{

	[TestMethod]
	public void HasItemsTest01()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(2500).ToImmutable();
		ImmutableList<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsTest02()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(2500).ToImmutableArray();
		Func<Coordinate, bool> selector = (coordinate) => coordinate.X > 0;

		Assert.IsTrue(collection.HasItems(selector));

		Assert.IsFalse(collection.HasItems(null));
	}

	[TestMethod]
	public void HasItemsTestWithCount()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(2500).ToImmutable();
		ImmutableList<Coordinate> nullCollection = null;

		Assert.IsFalse(collection.HasItems(5));

		Assert.IsFalse(nullCollection.HasItems());
	}
	[TestMethod]
	public void ImmutableArrayTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(2500).ToHashSet().ToImmutable();
		var copyPeople = people;
		Assert.IsTrue(people == copyPeople);
		Assert.IsFalse(people == copyPeople.Shuffle());
	}

}
