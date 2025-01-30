// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2024
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
