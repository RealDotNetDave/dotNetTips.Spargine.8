
// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : david
// Created          : 10-09-2024
//
// Last Modified By : david
// Last Modified On : 10-09-2024
// ***********************************************************************
// <copyright file="LinqExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class LinqExtensionsTests
{

	[TestMethod]
	public void If_WithConditionFalse_ShouldNotApplyTransforms()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 }.AsQueryable();
		bool condition = false;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.Where(x => x > 2),
				query => query.OrderByDescending(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.AreEqual(5, result.Count);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
		Assert.AreEqual(3, result[2]);
		Assert.AreEqual(4, result[3]);
		Assert.AreEqual(5, result[4]);
	}

	[TestMethod]
	public void If_WithConditionFalse_ShouldNotApplyTransforms_IEnumerable()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 };
		bool condition = false;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = {
		sequence => sequence.Where(x => x > 2),
		sequence => sequence.OrderByDescending(x => x)
	};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.AreEqual(5, result.Count);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
		Assert.AreEqual(3, result[2]);
		Assert.AreEqual(4, result[3]);
		Assert.AreEqual(5, result[4]);
	}
	[TestMethod]
	public void If_WithConditionTrue_ShouldApplyTransforms()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 }.AsQueryable();
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.Where(x => x > 2),
				query => query.OrderByDescending(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.AreEqual(3, result.Count);
		Assert.AreEqual(5, result[0]);
		Assert.AreEqual(4, result[1]);
		Assert.AreEqual(3, result[2]);
	}

	[TestMethod]
	public void If_WithConditionTrue_ShouldApplyTransforms_IEnumerable()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 };
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = {
		sequence => sequence.Where(x => x > 2),
		sequence => sequence.OrderByDescending(x => x)
	};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.AreEqual(3, result.Count);
		Assert.AreEqual(5, result[0]);
		Assert.AreEqual(4, result[1]);
		Assert.AreEqual(3, result[2]);
	}


	[TestMethod]
	public void If_WithNullInput_ShouldThrowArgumentNullException()
	{
		// Arrange
		IQueryable<int> data = null;
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.Where(x => x > 2),
				query => query.OrderByDescending(x => x)
			};

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => data.If(condition, transforms));
	}

	[TestMethod]
	public void If_WithNullInput_ShouldThrowArgumentNullException_IEnumerable()
	{
		// Arrange
		IEnumerable<int> data = null;
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = {
		sequence => sequence.Where(x => x > 2),
		sequence => sequence.OrderByDescending(x => x)
	};

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => data.If(condition, transforms));
	}

	[TestMethod]
	public void If_WithNullTransforms_ShouldThrowArgumentNullException()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 }.AsQueryable();
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => data.If(condition, transforms));
	}

	[TestMethod]
	public void If_WithNullTransforms_ShouldThrowArgumentNullException_IEnumerable()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 };
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => data.If(condition, transforms));
	}
}

