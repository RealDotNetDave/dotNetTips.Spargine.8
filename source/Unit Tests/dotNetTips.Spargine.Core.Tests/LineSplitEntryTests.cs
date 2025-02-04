// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 02-04-2025
// ***********************************************************************
// <copyright file="LineSplitEntryTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class LineSplitEntryTests
{
	[TestMethod]
	public void LineSplitEntry_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = "\n".AsSpan();

		// Act
		var entry = new LineSplitEntry(line, separator);

		// Assert
		Assert.AreEqual(line.ToString(), entry.Line.ToString());
		Assert.AreEqual(separator.ToString(), entry.Separator.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_Deconstruct_ShouldReturnLineAndSeparator()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = "\n".AsSpan();
		var entry = new LineSplitEntry(line, separator);

		// Act
		entry.Deconstruct(out var deconstructedLine, out var deconstructedSeparator);

		// Assert
		Assert.AreEqual(line.ToString(), deconstructedLine.ToString());
		Assert.AreEqual(separator.ToString(), deconstructedSeparator.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ImplicitConversion_EmptyLine_ShouldReturnEmpty()
	{
		// Arrange
		var line = ReadOnlySpan<char>.Empty;
		var separator = "\n".AsSpan();
		var entry = new LineSplitEntry(line, separator);

		// Act
		ReadOnlySpan<char> result = entry;

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ImplicitConversion_EmptyLineAndSeparator_ShouldReturnEmpty()
	{
		// Arrange
		var line = ReadOnlySpan<char>.Empty;
		var separator = ReadOnlySpan<char>.Empty;
		var entry = new LineSplitEntry(line, separator);

		// Act
		ReadOnlySpan<char> result = entry;

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ImplicitConversion_EmptySeparator_ShouldReturnLine()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = ReadOnlySpan<char>.Empty;
		var entry = new LineSplitEntry(line, separator);

		// Act
		ReadOnlySpan<char> result = entry;

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ImplicitConversion_ShouldReturnLine()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = "\n".AsSpan();
		var entry = new LineSplitEntry(line, separator);

		// Act
		ReadOnlySpan<char> result = entry;

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ToReadOnlySpan_ShouldReturnLine()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = "\n".AsSpan();
		var entry = new LineSplitEntry(line, separator);

		// Act
		var result = LineSplitEntry.ToReadOnlySpan(entry);

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}


}
