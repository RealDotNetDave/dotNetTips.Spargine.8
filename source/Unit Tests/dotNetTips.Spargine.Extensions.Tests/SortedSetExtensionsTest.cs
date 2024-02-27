// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2024
// ***********************************************************************
// <copyright file="SortedSetExtensionsTest.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SortedSetExtensionsTest
{

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var collection = new SortedSet<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>(RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(100));
		SortedSet<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullCollection = null;

		Assert.IsFalse(collection.DoesNotHaveItems());

		Assert.IsTrue(nullCollection.DoesNotHaveItems());
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = new SortedSet<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>(RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(100));
		SortedSet<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = new SortedSet<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>(RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(100));
		ObservableCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems(100));

		Assert.IsFalse(collection.HasItems(5));

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsWithFunctionTest()
	{
		var collection = new SortedSet<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>(RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(100));
		ObservableCollection<Coordinate> nullCollection = null;

		Func<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>, bool> selector = (person) => person.Email.IsNotNull();

		Assert.IsTrue(collection.HasItems(selector));

		Assert.IsFalse(nullCollection.HasItems());
	}
	[TestMethod]
	public void ToImmutableTest()
	{
		var peopleSortedSet = new SortedSet<Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>>(RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(100));

		var result = peopleSortedSet.ToImmutable();

		Assert.IsNotNull(result);
	}

}
