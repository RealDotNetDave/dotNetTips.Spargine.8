// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 07-11-2024
//
// Last Modified By : David McCarter
// Last Modified On : 03-07-2025
// ***********************************************************************
// <copyright file="ReadOnlySpanExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ReadOnlySpanExtensionsTests
{
	[TestMethod]
	public void BytesToStringTest()
	{
		var bytes = RandomData.GenerateByteArray(100);

		var readOnlySpan = new ReadOnlySpan<byte>(bytes);
		var result = readOnlySpan.BytesToString();

		Assert.IsTrue(result.Length > 100);
	}

	public int[] CreateArray()
	{
		int[] array = new int[100];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 1;
		}
		return array;
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void PickRandom_EmptySpan_ThrowsArgumentException()
	{
		ReadOnlySpan<int> emptySpan = new ReadOnlySpan<int>();
		emptySpan.PickRandom();
	}

	[TestMethod]
	public void PickRandom_MultipleCalls_ReturnsDifferentElements()
	{
		ReadOnlySpan<int> span = new ReadOnlySpan<int>(this.CreateArray());
		var result1 = span.PickRandom();
		var result2 = span.PickRandom();
		// Note: This test might occasionally fail due to the random nature of the method, but it's unlikely.
		Assert.AreNotEqual(result1, result2);
	}

	[TestMethod]
	public void PickRandom_NonEmptySpan_ReturnsElementFromSpan()
	{
		ReadOnlySpan<int> span = new ReadOnlySpan<int>(this.CreateArray());
		var result = span.PickRandom();
		Assert.IsTrue(span.Contains(result));
	}

}
