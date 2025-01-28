// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : david
// Created          : 10-09-2024
//
// Last Modified By : david
// Last Modified On : 01-02-2025
// ***********************************************************************
// <copyright file="StreamExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class StreamExtensionsTests
{
	[TestMethod]
	public void FlushClose_StreamIsNotNull_FlushesAndClosesStream()
	{
		// Arrange
		var stream = new MemoryStream();

		// Act
		stream.FlushClose();

		// Assert
		Assert.ThrowsException<ObjectDisposedException>(() => stream.WriteByte(0));
	}

	[TestMethod]
	public void FlushClose_StreamIsNull_DoesNothing()
	{
		// Arrange
		Stream stream = null;

		// Act & Assert
		stream.FlushClose(); // Should not throw any exception
	}
}
