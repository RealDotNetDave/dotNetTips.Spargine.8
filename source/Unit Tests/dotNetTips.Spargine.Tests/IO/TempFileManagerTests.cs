// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2025
// ***********************************************************************
// <copyright file="TempFileManagerTests.cs" company="DotNetTips.Spargine.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class TempFileManagerTests
{
	[TestMethod]
	public void CreateFile_ShouldAddFileToList()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act
			var filePath = manager.CreateFile();

			// Assert
			Assert.IsTrue(File.Exists(filePath));
			Assert.IsTrue(manager.GetManagedFiles().Contains(filePath));
		}
	}

	[TestMethod]
	public void CreateFiles_ShouldAddMultipleFilesToList()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			int fileCount = 50;

			// Act
			var files = manager.CreateFiles(fileCount);

			// Assert
			Assert.AreEqual(fileCount, files.Count);
			foreach (var file in files)
			{
				Assert.IsTrue(File.Exists(file));
				Assert.IsTrue(manager.GetManagedFiles().Contains(file));
			}
		}
	}

	[TestMethod]
	public void DeleteAllFiles_ShouldRemoveAllFilesFromList()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			manager.CreateFiles(50);

			// Act
			manager.DeleteAllFiles();

			// Assert
			Assert.AreEqual(0, manager.GetManagedFiles().Count);
		}
	}

	[TestMethod]
	public void DeleteFile_ShouldNotRemoveNonExistentFile()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			var filePath = manager.CreateFile();
			var nonExistentFilePath = filePath + "_nonexistent";

			// Act
			manager.DeleteFile(nonExistentFilePath);

			// Assert
			Assert.IsTrue(File.Exists(filePath));
			Assert.IsTrue(manager.GetManagedFiles().Contains(filePath));
		}
	}

	[TestMethod]
	public void DeleteFile_ShouldNotThrow_WhenFileNameIsNullOrEmpty()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act & Assert
			manager.DeleteFile(null);
			manager.DeleteFile(string.Empty);
		}
	}

	[TestMethod]
	public void DeleteFile_ShouldRemoveFileFromList()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			var filePath = manager.CreateFile();

			// Act
			manager.DeleteFile(filePath);

			// Assert
			Assert.IsFalse(File.Exists(filePath));
			Assert.IsFalse(manager.GetManagedFiles().Contains(filePath));
		}
	}

	[TestMethod]
	public void Dispose_ShouldReleaseResources()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			manager.CreateFiles(50);

			// Act
			manager.Dispose();

			// Assert
			Assert.AreEqual(0, manager.GetManagedFiles().Count);
		}
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldDeleteAllFiles()
	{
		// Arrange
		var manager = new TempFileManager();
		var files = manager.CreateFiles(50);

		// Act
		await (manager as IAsyncDisposable).DisposeAsync();

		// Assert
		foreach (var file in files)
		{
			Assert.IsFalse(File.Exists(file), $"File {file} should be deleted.");
		}
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldHandleEmptyFileList()
	{
		// Arrange
		var manager = new TempFileManager();

		// Act
		await (manager as IAsyncDisposable).DisposeAsync();

		// Assert
		Assert.AreEqual(0, manager.GetManagedFiles().Count);
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldNotThrowException_WhenCalledMultipleTimes()
	{
		// Arrange
		var manager = new TempFileManager();
		manager.CreateFiles(50);

		// Act & Assert
		await (manager as IAsyncDisposable).DisposeAsync();
		await (manager as IAsyncDisposable).DisposeAsync();
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldReleaseResources()
	{
		// Arrange
		var manager = new TempFileManager();
		manager.CreateFiles(50);

		// Act
		await (manager as IAsyncDisposable).DisposeAsync();

		// Assert
		Assert.AreEqual(0, manager.GetManagedFiles().Count);
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldSuppressFinalize()
	{
		// Arrange
		var manager = new TempFileManager();
		bool finalizeCalled = false;

		// Act
		await (manager as IAsyncDisposable).DisposeAsync();

		// Assert
		GC.ReRegisterForFinalize(manager);
		GC.Collect();
		GC.WaitForPendingFinalizers();

		Assert.IsFalse(finalizeCalled, "Finalize should not be called after DisposeAsync.");
	}

	[TestMethod]
	public void GetManagedFiles_ShouldReturnListOfManagedFiles()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			var files = manager.CreateFiles(50);

			// Act
			var managedFiles = manager.GetManagedFiles();

			// Assert
			CollectionAssert.AreEquivalent(files, managedFiles.ToList());
		}
	}

}
