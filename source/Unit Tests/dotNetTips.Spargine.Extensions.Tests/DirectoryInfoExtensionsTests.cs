// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="DirectoryInfoExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DotNetTips.Spargine.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DirectoryInfoExtensionsTests
{

	[TestMethod]
	public void DirectoryInfoSizeTest01()
	{
		var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

		var result = directory.GetSize();

		Assert.IsTrue(result > 0);

		_ = Assert.ThrowsException<ArgumentNullException>(() => DirectoryInfoExtensions.GetSize(null));
	}

	[TestMethod]
	public void DirectoryInfoSizeTest02()
	{
		var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

		var result = directory.GetSize(ControlChars.WildcardAllFiles);

		Assert.IsTrue(result > 0);

		_ = Assert.ThrowsException<ArgumentNullException>(() => directory.GetSize(null) == 0);
	}

	[TestMethod]
	public void DirectoryInfoSizeTest03()
	{
		var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

		var result = directory.GetSize(searchPattern: ControlChars.WildcardAllFiles, searchOption: SearchOption.AllDirectories);

		Assert.IsTrue(result > 0);

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => directory.GetSize("*.txt", (SearchOption)100) ==
			0);
	}

}
