// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2024
// ***********************************************************************
// <copyright file="SortedDictionaryExtensionsTest.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SortedDictionaryExtensionsTest
{

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(10).ToDictionary(p => p.Id));
		SortedDictionary<string, Person<Address>> nullPeople = null;

		Assert.IsFalse(peopleSortedSet.DoesNotHaveItems());

		Assert.IsTrue(nullPeople.DoesNotHaveItems());
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(10).ToDictionary(p => p.Id));
		SortedDictionary<string, Person<Address>> nullPeople = null;

		Assert.IsTrue(peopleSortedSet.HasItems());

		Assert.IsFalse(nullPeople.HasItems());
	}

	/// <summary>
	/// Defines the test method HasItemsTestWithFunction.
	/// </summary>
	[TestMethod]
	public void HasItemsTestWithFunction()
	{
		var peopleSortedSet = new SortedDictionary<string, Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(10).ToDictionary(p => p.Id));

		Func<KeyValuePair<string, Person<Address>>, bool> selector = p => p.Value.Email.IsNotNull();

		Assert.IsTrue(peopleSortedSet.HasItems(selector));
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(10).ToDictionary(p => p.Id));
		SortedDictionary<string, Person<Address>> nullPeople = null;

		Assert.IsTrue(peopleSortedSet.HasItems(10));
		Assert.IsFalse(peopleSortedSet.HasItems(100));

		Assert.IsFalse(nullPeople.HasItems(10));
	}
	[TestMethod]
	public void ToImmutableTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(100).ToDictionary(p => p.Id));

		var result = peopleSortedSet.ToImmutable();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void UpsertTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person<Address>>(RandomData.GeneratePersonRefCollection<Address>(10).ToDictionary(p => p.Id));
		var person = RandomData.GeneratePersonRef<Address>();

		var personFromCollection = peopleSortedSet.Shuffle().First();

		_ = peopleSortedSet.Upsert(person.Id, person);

		Assert.IsTrue(peopleSortedSet.FastCount() == 11);

		_ = peopleSortedSet.Upsert(personFromCollection.Key, personFromCollection.Value);

		Assert.IsTrue(peopleSortedSet.FastCount() == 11);

	}

}
