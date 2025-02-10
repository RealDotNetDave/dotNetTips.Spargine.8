// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 02-10-2025
// ***********************************************************************
// <copyright file="CoordinateRefTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CoordinateRefTests
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
	public void Coordinate_CompareTo_DifferentValues_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 3, 3);
		var coord3 = new Coordinate(2, 2, 3);
		var coord4 = new Coordinate(1, 2, 4);

		// Act & Assert
		Assert.IsTrue(coord1.CompareTo(coord2) < 0);
		Assert.IsTrue(coord1.CompareTo(coord3) < 0);
		Assert.IsTrue(coord1.CompareTo(coord4) < 0);
		Assert.IsTrue(coord2.CompareTo(coord1) > 0);
		Assert.IsTrue(coord3.CompareTo(coord1) > 0);
		Assert.IsTrue(coord4.CompareTo(coord1) > 0);
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidCastException))]
	public void Coordinate_CompareTo_InvalidObjectType_ShouldThrowArgumentException()
	{
		// Arrange
		var coord = new Coordinate(1, 2, 3);
		var invalidObject = new object();

		// Act
		_ = coord.CompareTo(invalidObject);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Coordinate_CompareTo_NullObject_ShouldThrowArgumentException()
	{
		// Arrange
		var coord = new Coordinate(1, 2, 3);

		// Act
		_ = coord.CompareTo(null);
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
	public void Coordinate_CompareTo_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.AreEqual(0, coord1.CompareTo(coord2));
		Assert.IsTrue(coord1.CompareTo(coord3) < 0);
		Assert.IsTrue(coord3.CompareTo(coord1) > 0);
	}

	[TestMethod]
	public void Coordinate_CompareTo_ValidCoordinate_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.AreEqual(0, coord1.CompareTo(coord2));
		Assert.IsTrue(coord1.CompareTo(coord3) < 0);
		Assert.IsTrue(coord3.CompareTo(coord1) > 0);
	}

	[TestMethod]
	public void Coordinate_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var x = 1;
		var y = 2;
		var z = 3;

		// Act
		var coordinate = new Coordinate(x, y, z);

		// Assert
		Assert.AreEqual(x, coordinate.X);
		Assert.AreEqual(y, coordinate.Y);
		Assert.AreEqual(z, coordinate.Z);
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
	public void Coordinate_GetHashCode_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.AreEqual(coord1.GetHashCode(), coord2.GetHashCode());
		Assert.AreNotEqual(coord1.GetHashCode(), coord3.GetHashCode());
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
	public void Coordinate_ToString_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord = new Coordinate(1, 2, 3);
		var expectedString = "X:1, Y:2, Z:3";

		// Act
		var result = coord.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}
}
