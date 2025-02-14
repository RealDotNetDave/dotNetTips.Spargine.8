// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-04-2025
// ***********************************************************************
// <copyright file="DirectoryHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class DirectoryHelperTests
{
	[TestMethod]
	public void AppDataFolder_ReturnsCorrectPathOnMacOS()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
		{
			// Arrange
			var expectedPathStart = Environment.GetEnvironmentVariable("HOME");

			// Act
			var result = DirectoryHelper.AppDataFolder();

			// Assert
			Assert.IsTrue(result.StartsWith(expectedPathStart), "The path should start with the HOME environment variable value.");
		}
		else
		{
			Assert.Inconclusive("This test is designed to run on macOS.");
		}
	}
	[TestMethod]
	public void AppDataFolder_ReturnsCorrectPathOnWindows()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			// Arrange
			var expectedPathStart = Environment.GetEnvironmentVariable("LOCALAPPDATA");

			// Act
			var result = DirectoryHelper.AppDataFolder();

			// Assert
			Assert.IsTrue(result.StartsWith(expectedPathStart), "The path should start with the LOCALAPPDATA environment variable value.");
		}
		else
		{
			Assert.Inconclusive("This test is designed to run on Windows.");
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CheckPermissionTest()
	{
		var path = Environment.GetFolderPath(Environment.SpecialFolder.System);

		Assert.IsTrue(DirectoryHelper.CheckPermission(new DirectoryInfo(path)));

		Assert.IsTrue(DirectoryHelper.CheckPermission(new DirectoryInfo(path), FileSystemRights.Write));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	[ExpectedException(typeof(DirectoryNotFoundException))]
	public void CopyDirectory_InvalidSource_ThrowsDirectoryNotFoundException()
	{
		// Arrange
		var invalidSourceDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectory = new DirectoryInfo(destinationDirectoryPath);

		// Act
		DirectoryHelper.CopyDirectory(invalidSourceDirectory, destinationDirectory, true);

		// No need for Assert, as an exception is expected
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyDirectory_ValidSourceAndDestination_CopiesAllContents()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = new DirectoryInfo(destinationDirectoryPath);

		// Create a file in the source directory to test the copy
		File.WriteAllText(Path.Combine(sourceDirectory.FullName, "testFile.txt"), "This is a test file.");

		// Act
		DirectoryHelper.CopyDirectory(sourceDirectory, destinationDirectory, true);

		// Assert
		var copiedFilePath = Path.Combine(destinationDirectory.FullName, "testFile.txt");
		Assert.IsTrue(File.Exists(copiedFilePath), "The file should have been copied to the destination directory.");

		// Cleanup
		sourceDirectory.Delete(true);
		destinationDirectory.Delete(true);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_DeletedDirectory_DeletesSuccessfully()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), nameof(this.DeleteDirectory_DeletedDirectory_DeletesSuccessfully));

		var directory = new DirectoryInfo(tempDirectoryPath);
		directory.Create();

		new DirectoryInfo(tempDirectoryPath).Delete();

		// Act
		DirectoryHelper.DeleteDirectory(directory);

		// Assert
		Assert.IsFalse(Directory.Exists(tempDirectoryPath), "The directory should have been deleted.");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_NonExistentDirectory_NoExceptionThrown()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), "TEST");

		// Act & Assert
		DirectoryHelper.DeleteDirectory(new DirectoryInfo(tempDirectoryPath), 1);
		// No exception is expected, even though the directory does not exist
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_ValidDirectory_DeletesSuccessfully()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), nameof(this.DeleteDirectory_ValidDirectory_DeletesSuccessfully));

		var directory = new DirectoryInfo(tempDirectoryPath);
		directory.Create();

		// Act
		DirectoryHelper.DeleteDirectory(directory);

		// Assert
		Assert.IsFalse(Directory.Exists(tempDirectoryPath), "The directory should have been deleted.");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_WithRetries_DeletesSuccessfullyAfterRetries()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), nameof(this.DeleteDirectory_WithRetries_DeletesSuccessfullyAfterRetries));

		var directory = new DirectoryInfo(tempDirectoryPath);
		directory.Create();

		_ = RandomData.GenerateFiles(tempDirectoryPath, 100);

		// Simulate a condition that would initially prevent deletion, such as a temporary lock by another process
		// For testing purposes, this is simulated by a short delay within the test, as actual process locking is complex and flaky in automated tests

		Task.Delay(100).ContinueWith(_ =>
		{
			DirectoryHelper.DeleteDirectory(directory, 5);
		});

		// Act
		Thread.Sleep(500); // Wait for the delayed deletion attempt

		// Assert
		Assert.IsFalse(Directory.Exists(tempDirectoryPath), "The directory should have been deleted after retries.");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void GetOneDriveFolderTest()
	{
		var result = DirectoryHelper.LoadOneDriveFolders();

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0);
	}

	[TestMethod]
	public async Task LoadFilesAsync_EmptyDirectory_ReturnsNoFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		try
		{
			var searchPattern = "*.txt";
			var searchOption = SearchOption.TopDirectoryOnly;
			var directories = new List<DirectoryInfo> { new DirectoryInfo(tempDirectory.FullName) };

			// Act
			var files = new List<FileInfo>();
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, searchPattern, searchOption))
			{
				files.AddRange(fileSet);
			}

			// Assert
			Assert.AreEqual(0, files.Count);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}
	[TestMethod]
	public async Task LoadFilesAsync_ValidDirectory_ReturnsFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		try
		{
			var searchPattern = "*.txt";
			var searchOption = SearchOption.TopDirectoryOnly;
			var directories = new List<DirectoryInfo> { new DirectoryInfo(tempDirectory.FullName) };

			// Create dummy files for testing
			var expectedFiles = new List<string>
			{
				Path.Combine(tempDirectory.FullName, "file1.txt"),
				Path.Combine(tempDirectory.FullName, "file2.txt")
			};

			foreach (var filePath in expectedFiles)
			{
				File.WriteAllText(filePath, "Test content");
			}

			// Act
			var files = new List<FileInfo>();
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, searchPattern, searchOption))
			{
				files.AddRange(fileSet);
			}

			// Assert
			Assert.AreEqual(expectedFiles.Count, files.Count);
			foreach (var file in files)
			{
				Assert.IsTrue(expectedFiles.Contains(file.FullName));
			}
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearchTest()
	{
		var folder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

		var result = DirectoryHelper.SafeDirectorySearch(folder, "*Microsoft*", SearchOption.AllDirectories);

		Assert.IsTrue(result.HasItems());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchIEnumerableTest()
	{
		var folders = new List<DirectoryInfo>();

		folders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)));

		var result = DirectoryHelper.SafeFileSearch(folders, "*.png", SearchOption.AllDirectories);

		Assert.IsTrue(result.HasItems());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchTest()
	{
		var folder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

		var result = DirectoryHelper.SafeFileSearch(folder, "*.png", SearchOption.AllDirectories);

		Assert.IsTrue(result.HasItems());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SetFileAttributesToNormal_ValidDirectory_SetsAttributesSuccessfully()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);

		// Create a file in the directory and set its attributes to ReadOnly
		var testFilePath = Path.Combine(tempDirectoryPath, "testFile.txt");
		var testFile = File.Create(testFilePath);
		testFile.Close();
		File.SetAttributes(testFilePath, FileAttributes.ReadOnly);

		// Act
		DirectoryHelper.SetFileAttributesToNormal(directory);

		// Assert
		var attributes = File.GetAttributes(testFilePath);
		Assert.IsFalse(attributes.HasFlag(FileAttributes.ReadOnly), "The file attributes should no longer include ReadOnly.");

		// Cleanup
		directory.Delete(true);
	}

}
