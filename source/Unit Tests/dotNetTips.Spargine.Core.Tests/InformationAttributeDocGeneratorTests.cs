
using System;
using System.Reflection;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[TestClass]
public class InformationAttributeDocGeneratorTests
{
	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_ReturnsDocumentation()
	{
		// Arrange
		var assembly = Assembly.GetAssembly(typeof(InformationAttribute));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.IsTrue(result.Contains($"# {assembly.FullName}"));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_ToFile()
	{
		// Arrange
		var assembly = Assembly.GetAssembly(typeof(InformationAttribute));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, @"c:\temp\markdowntext.md");

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}
}
