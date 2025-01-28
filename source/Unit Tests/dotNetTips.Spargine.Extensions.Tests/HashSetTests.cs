// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="HashSetTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
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
public class HashSetTests
{

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(10).ToHashSet();
		var person = RandomData.GeneratePersonRef<Address>();

		people.AddIf(person, true);

		Assert.IsTrue(people.FastCount() == 11);

		people.AddIf(person, false);

		Assert.IsTrue(people.FastCount() == 11);

	}

	[TestMethod]
	public void ToConcurrentHashSetTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(10).ToHashSet().ToConcurrentHashSet();

		Assert.IsTrue(people.FastCount() == 10);
	}

	[TestMethod]
	public void ToImmutableHashSet_DuplicateElements_ReturnsImmutableHashSetWithUniqueElements()
	{
		// Arrange
		var hashSet = new HashSet<int> { 1, 2, 2, 3, 4, 5 };

		// Act
		var result = hashSet.ToImmutableHashSet();

		// Assert
		Assert.AreEqual(5, result.Count);
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3, 4, 5 }, result.ToList());
	}

	[TestMethod]
	public void ToImmutableHashSet_EmptyHashSet_ReturnsEmptyImmutableHashSet()
	{
		// Arrange
		var hashSet = new HashSet<int>();

		// Act
		var result = hashSet.ToImmutableHashSet();

		// Assert
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToImmutableHashSet_NullHashSet_ThrowsArgumentNullException()
	{
		// Arrange
		HashSet<int> hashSet = null;

		// Act
		_ = hashSet.ToImmutableHashSet();
	}

	[TestMethod]
	public void ToImmutableHashSet_ValidHashSet_ReturnsImmutableHashSet()
	{
		// Arrange
		var hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = hashSet.ToImmutableHashSet();

		// Assert
		Assert.AreEqual(hashSet.Count, result.Count);
		CollectionAssert.AreEquivalent(hashSet.ToList(), result.ToList());
	}

	[TestMethod]
	public void ToImmutableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(10).ToHashSet().ToImmutable();

		Assert.IsTrue(people.FastCount() == 10);
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Address>(10).ToHashSet();
		var person = RandomData.GeneratePersonRef<Address>();
		var personFromCollection = people.Shuffle().First();

		people.Upsert(person);

		Assert.IsTrue(people.FastCount() == 11);

		people.Upsert(personFromCollection);

		Assert.IsTrue(people.FastCount() == 11);
	}
}
