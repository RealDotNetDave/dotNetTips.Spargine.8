// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : david
// Created          : 10-09-2024
//
// Last Modified By : david
// Last Modified On : 10-28-2024
// ***********************************************************************
// <copyright file="StreamExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[TestClass]
public class StreamExtensionsTests
{

	// Helper method to create a buffer of specified length
	private byte[] CreateBuffer(int length)
	{
		return new byte[length];
	}

	// Helper method to create a MemoryStream with specified data
	private MemoryStream CreateStream(byte[] data)
	{
		return new MemoryStream(data);
	}

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

	[TestMethod]
	public async Task ReadAsync_CancellationRequested_ThrowsTaskCanceledException()
	{
		// Arrange
		var data = new byte[] { 1, 2, 3, 4, 5 };
		using var stream = new MemoryStream(data);
		var buffer = new byte[data.Length];
		var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		await Assert.ThrowsExceptionAsync<TaskCanceledException>(async () =>
		{
			await stream.ReadAsync(buffer, cts.Token);
		});
	}

	[TestMethod]
	public async Task ReadAsync_EmptyStream_ReturnsZero()
	{
		// Arrange
		using var stream = new MemoryStream();
		var buffer = new byte[10];

		// Act
		var bytesRead = await stream.ReadAsync(buffer, CancellationToken.None);

		// Assert
		Assert.AreEqual(0, bytesRead);
	}
	[TestMethod]
	public async Task ReadAsync_ValidData_ReadsCorrectly()
	{
		// Arrange
		var data = new byte[] { 1, 2, 3, 4, 5 };
		using var stream = new MemoryStream(data);
		var buffer = new byte[data.Length];

		// Act
		var bytesRead = await stream.ReadAsync(buffer, CancellationToken.None);

		// Assert
		Assert.AreEqual(data.Length, bytesRead);
		CollectionAssert.AreEqual(data, buffer);
	}

	[TestMethod]
	public async Task WriteAsync_CancellationRequested_ThrowsTaskCanceledException()
	{
		// Arrange
		var data = new byte[] { 1, 2, 3, 4, 5 };
		using var stream = new MemoryStream();
		var source = new ReadOnlyMemory<byte>(data);
		var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		await Assert.ThrowsExceptionAsync<TaskCanceledException>(async () =>
		{
			await stream.WriteAsync(source, cts.Token);
		});
	}

	[TestMethod]
	public async Task WriteAsync_EmptyData_WritesNothing()
	{
		// Arrange
		var data = Array.Empty<byte>();
		using var stream = new MemoryStream();
		var source = new ReadOnlyMemory<byte>(data);

		// Act
		await stream.WriteAsync(source, CancellationToken.None);
		stream.Position = 0;
		var buffer = new byte[10];
		var bytesRead = await stream.ReadAsync(buffer, CancellationToken.None);

		// Assert
		Assert.AreEqual(0, bytesRead);
	}


	[TestMethod]
	public async Task WriteAsync_ValidData_WritesCorrectly()
	{
		// Arrange
		var data = new byte[] { 1, 2, 3, 4, 5 };
		using var stream = new MemoryStream();
		var source = new ReadOnlyMemory<byte>(data);

		// Act
		await stream.WriteAsync(source, CancellationToken.None);
		stream.Position = 0;
		var buffer = new byte[data.Length];
		await stream.ReadAsync(buffer, CancellationToken.None);

		// Assert
		CollectionAssert.AreEqual(data, buffer);
	}
}
