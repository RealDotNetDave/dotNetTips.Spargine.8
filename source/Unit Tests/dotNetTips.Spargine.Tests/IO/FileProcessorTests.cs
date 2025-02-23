// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2025
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

[ExcludeFromCodeCoverage]
[TestClass]
public class FileProcessorTests
{
	const int DirectoryCount = 10;
	const int FileCount = 100;

#nullable enable
	private void Processor_Processed(object? sender, FileProgressEventArgs e) => Trace.WriteLine(e.Name + ":" + e.Message + ":" + e.ProgressState + ":" + e.Size);

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

}
