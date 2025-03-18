// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-18-2025
// ***********************************************************************
// <copyright file="FileProcessorTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.IO;

/// <summary>
/// Defines test class FileProcessorTests.
/// </summary>
[ExcludeFromCodeCoverage]
[TestClass]
public class FileProcessorTests
{
	/// <summary>
	/// The directory count
	/// </summary>
	private const int DirectoryCount = 10;
	/// <summary>
	/// The file count
	/// </summary>
	private const int FileCount = 100;

#nullable enable
	/// <summary>
	/// Handles the Processed event of the Processor control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="FileProgressEventArgs"/> instance containing the event data.</param>
	private void Processor_Processed(object? sender, FileProgressEventArgs e) => Trace.WriteLine(e.Name + ":" + e.Message + ":" + e.ProgressState + ":" + e.Size);

	/// <summary>
	/// Defines the test method CopyFilesTest.
	/// </summary>
	[TestMethod]
	public void CopyFilesTest()
	{
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(FileCount, fileExtension: "processor.test");
		var path = generateFiles.Path;
		var files = new List<FileInfo>(generateFiles.Files.Count);

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "Copy"));

		Assert.IsTrue(processor.CopyFiles(files, destination) == FileCount);

		destination.Delete(true);

	}

#nullable disable

	/// <summary>
	/// Defines the test method DeleteFilesTest.
	/// </summary>
	[TestMethod]
	public void DeleteFilesTest()
	{
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(FileCount, fileExtension: "processor.test");
		var path = generateFiles.Path;
		var files = new List<FileInfo>(generateFiles.Files.Count);

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		foreach (var file in files)
		{
			File.SetAttributes(file.FullName, FileAttributes.ReadOnly);
		}

		Assert.IsTrue(processor.DeleteFiles(files) == FileCount);

	}

	/// <summary>
	/// Defines the test method DeleteFolders_EmptyFoldersList_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_EmptyFoldersList_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>();

		// Act
		var deletedCount = processor.DeleteFolders(folders, true);

		// Assert
		Assert.AreEqual(0, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFolders_FoldersDoNotExist_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_FoldersDoNotExist_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>(DirectoryCount);

		for (int index = 0; index < DirectoryCount; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			folders.Add(newPath);
		}

		// Act
		var deletedCount = processor.DeleteFolders(folders, true);

		// Assert
		Assert.AreEqual(0, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFolders_NullFolders_ThrowsArgumentNullException.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_NullFolders_ThrowsArgumentNullException()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		// Act & Assert
		Assert.IsTrue(processor.DeleteFolders(null, true) == 0);
	}

	/// <summary>
	/// Defines the test method DeleteFolders_ValidFolders_DeletesSuccessfully.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_ValidFolders_DeletesSuccessfully()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>(DirectoryCount);

		for (int index = 0; index < DirectoryCount; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);

			var testFiles = RandomData.GenerateFiles(newPath.FullName, FileCount);

			foreach (var file in testFiles)
			{
				File.SetAttributes(file, FileAttributes.ReadOnly);
			}
		}

		// Act
		var deletedCount = processor.DeleteFolders(folders, true);

		// Assert
		Assert.AreEqual(DirectoryCount, deletedCount);
		foreach (var folder in folders)
		{
			Assert.IsFalse(folder.Exists, $"Folder {folder.FullName} should be deleted.");
		}
	}

	/// <summary>
	/// Defines the test method DeleteFoldersTest.
	/// </summary>
	[TestMethod]
	public void DeleteFoldersTest()
	{
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>(DirectoryCount);

		for (int index = 0; index < DirectoryCount; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);

			var testFiles = RandomData.GenerateFiles(newPath.FullName, FileCount);

			foreach (var file in testFiles)
			{
				File.SetAttributes(file, FileAttributes.ReadOnly);
			}
		}

		Assert.IsTrue(processor.DeleteFolders(folders, true) == DirectoryCount);

	}

	//[TestMethod]
	//public void TEMPDeleteFoldersTest()
	//{
	//	var processor = new FileProcessor();
	//	processor.Processed += this.Processor_Processed;

	//	var folders = new List<DirectoryInfo>(DirectoryCount);

	//	var folder = new DirectoryInfo("C:\\Users\\david\\OneDrive - dotNetTips.com\\Backup\\DESKTOP-TU9NREL\\DAVID\\TURBO\\2025-02-22T15.21.58");

	//	folders.Add(folder);

	//	Assert.IsTrue(processor.DeleteFolders(folders, true) == folders.Count);

	//}

}
