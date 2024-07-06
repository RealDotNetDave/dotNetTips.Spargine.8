// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2024
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
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class FileProcessorTests
{

#nullable enable
	private void Processor_Processed(object? sender, FileProgressEventArgs e) => Trace.WriteLine(e.Message);

#nullable disable

	[TestMethod]
	public void DeleteFilesTest()
	{
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(1000, fileExtension: "processor.test");
		var path = generateFiles.Path;
		var files = new List<FileInfo>(generateFiles.Files.Count());

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		Assert.IsTrue(processor.DeleteFiles(files) == 1000);

	}

}
