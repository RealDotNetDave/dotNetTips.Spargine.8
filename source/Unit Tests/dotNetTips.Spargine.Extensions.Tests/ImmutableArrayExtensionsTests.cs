// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="ImmutableArrayExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ImmutableArrayExtensionsTests
{

	[TestMethod]
	public void HasItems_EmptyImmutableArray_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray<int>.Empty;

		// Act
		var result = array.HasItems();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItems_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		var result = array.HasItems();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasItems_WithCount_EmptyImmutableArray_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray<int>.Empty;

		// Act
		var result = array.HasItems(3);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItems_WithCount_InvalidCount_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		var result = array.HasItems(2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItems_WithCount_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		var result = array.HasItems(3);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasItems_WithPredicate_EmptyImmutableArray_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray<int>.Empty;

		// Act
		var result = array.HasItems(x => x > 1);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItems_WithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		Assert.IsFalse(array.HasItems(null));
	}

	[TestMethod]
	public void HasItems_WithPredicate_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		var result = array.HasItems(x => x > 1);

		// Assert
		Assert.IsTrue(result);
	}
}
