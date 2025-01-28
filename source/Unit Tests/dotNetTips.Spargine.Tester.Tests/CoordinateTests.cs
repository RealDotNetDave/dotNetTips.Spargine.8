// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="CoordinateTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CoordinateTests
{

	[TestMethod]
	public void Coordinate_CompareTo_DifferentValues_ReturnsNonZero()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(4, 5, 6);

		// Act
		var result = coordinate1.CompareTo(coordinate2);

		// Assert
		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void Coordinate_CompareTo_SameValues_ReturnsZero()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(1, 2, 3);

		// Act
		var result = coordinate1.CompareTo(coordinate2);

		// Assert
		Assert.AreEqual(0, result);
	}
	[TestMethod]
	public void Coordinate_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var x = 1;
		var y = 2;
		var z = 3;

		// Act
		var coordinate = new Coordinate(x, y, z);

		// Assert
		Assert.IsNotNull(coordinate);
		Assert.AreEqual(x, coordinate.X);
		Assert.AreEqual(y, coordinate.Y);
		Assert.AreEqual(z, coordinate.Z);
	}

	[TestMethod]
	public void Coordinate_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(4, 5, 6);

		// Act
		var result = coordinate1.Equals(coordinate2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Coordinate_Equals_SameValues_ReturnsTrue()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(1, 2, 3);

		// Act
		var result = coordinate1.Equals(coordinate2);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Coordinate_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(4, 5, 6);

		// Act
		var hashCode1 = coordinate1.GetHashCode();
		var hashCode2 = coordinate2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Coordinate_GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(1, 2, 3);

		// Act
		var hashCode1 = coordinate1.GetHashCode();
		var hashCode2 = coordinate2.GetHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Coordinate_OperatorEquals_SameValues_ReturnsTrue()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(1, 2, 3);

		// Act
		var result = coordinate1 == coordinate2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Coordinate_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(4, 5, 6);

		// Act
		var result = coordinate1 != coordinate2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Coordinate_ToString_ReturnsCorrectString()
	{
		// Arrange
		var coordinate = new Coordinate(1, 2, 3);
		var expectedString = coordinate.PropertiesToString();

		// Act
		var result = coordinate.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}
}
