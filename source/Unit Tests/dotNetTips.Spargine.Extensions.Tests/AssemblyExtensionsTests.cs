// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="AssemblyExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AssemblyExtensionsTests
{

	[TestMethod]
	public void GetAllTypesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetAllTypes();

		Assert.IsTrue(result.FastCount() >= 1);
	}

	[TestMethod]
	public void GetInstancesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsTests>();

		Assert.IsTrue(result.FastCount() == 1);
	}

	[TestMethod]
	public void GetInterfacesTest()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetAllInterfaces().ToList();

		Assert.IsTrue(result.FastCount() > 0);
	}

	[TestMethod]
	public void GetTypes_NullAssembly_ThrowsArgumentNullException()
	{
		// Arrange
		var type = typeof(AssemblyExtensionsTests);

		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => ((Assembly)null).GetTypes(type));
	}

	[TestMethod]
	public void GetTypes_NullType_ThrowsArgumentNullException()
	{
		// Arrange
		var assembly = Assembly.GetExecutingAssembly();

		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => assembly.GetTypes(null));
	}

	[TestMethod]
	public void GetTypes_ValidInputs_ReturnsTypes()
	{
		// Arrange
		var assembly = Assembly.GetExecutingAssembly();
		var type = typeof(AssemblyExtensionsTests);

		// Act
		var result = assembly.GetTypes(type);

		// Assert
		Assert.IsTrue(result.Count > 0);
		Assert.IsTrue(result.Contains(type));
	}

	[TestMethod]
	public void GetTypesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetTypes();

		Assert.IsTrue(result.FastCount() > 0);
	}

}
