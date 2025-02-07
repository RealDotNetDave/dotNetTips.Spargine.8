// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-24-2024
// ***********************************************************************
// <copyright file="PathHelperTests.cs" company="McCarter Consulting">
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
public class PathHelperTests
{

	private readonly string _testDirectory = Path.Combine(Path.GetTempPath(), "PathHelperTests");

	[TestCleanup]
	public void Cleanup()
	{
		if (Directory.Exists(this._testDirectory))
		{
			Directory.Delete(this._testDirectory, true);
		}
	}

	[TestMethod]
	public void CombinePaths_FourStrings_CreateIfNotExistsTrue_DirectoryCreated()
	{
		var result = PathHelper.CombinePaths(true, this._testDirectory, "SubDirectory", "SubSubDirectory", "SubSubSubDirectory");
		Assert.IsTrue(result.Exists);
	}

	[TestMethod]
	public void CombinePaths_ParamsStringArray_CreateIfNotExistsFalse_DirectoryNotCreated()
	{
		var combinedPath = Path.Combine(this._testDirectory, "SubDirectory1", "SubDirectory2");
		var result = PathHelper.CombinePaths(false, this._testDirectory, "SubDirectory1", "SubDirectory2");
		Assert.IsFalse(result.Exists);
	}

	[TestMethod]
	public void CombinePaths_ParamsStringArray_CreateIfNotExistsTrue_DirectoryCreated()
	{
		var result = PathHelper.CombinePaths(true, this._testDirectory, "SubDirectory1", "SubDirectory2");
		Assert.IsTrue(result.Exists);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void CombinePaths_ParamsStringArray_NullPaths_ThrowsArgumentNullException()
	{
		PathHelper.CombinePaths(true, null);
	}

	[TestMethod]
	public void CombinePaths_ThreeStrings_CreateIfNotExistsTrue_DirectoryCreated()
	{
		var result = PathHelper.CombinePaths(true, this._testDirectory, "SubDirectory", "SubSubDirectory");
		Assert.IsTrue(result.Exists);
	}

	[TestMethod]
	public void CombinePaths_TwoStrings_CreateIfNotExistsTrue_DirectoryCreated()
	{
		var result = PathHelper.CombinePaths(true, this._testDirectory, "SubDirectory");
		Assert.IsTrue(result.Exists);
	}

	[TestMethod]
	public void EnsureTrailingSlash_EmptyString_ThrowsArgumentException()
	{
		Assert.ThrowsException<ArgumentNullException>(() => PathHelper.EnsureTrailingSlash(string.Empty));
	}

	[TestMethod]
	public void EnsureTrailingSlash_Null_ThrowsArgumentNullException()
	{
		Assert.ThrowsException<ArgumentNullException>(() => PathHelper.EnsureTrailingSlash(null));
	}

	[TestMethod]
	public void EnsureTrailingSlash_WithAltDirectorySeparatorChar_ReturnsPathWithSlash()
	{
		var pathWithAltSlash = "C:/TestPath";
		var expected = "C:/TestPath\\";
		var result = PathHelper.EnsureTrailingSlash(pathWithAltSlash);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void EnsureTrailingSlash_WithForwardSlash_ReturnsPathWithCorrectTrailingSlash()
	{
		var pathWithForwardSlash = "C:/TestPath";
		// Dynamically determine the expected trailing character based on the current platform
		var expected = $"C:/TestPath{Path.DirectorySeparatorChar}";

		var result = PathHelper.EnsureTrailingSlash(pathWithForwardSlash);

		// This assertion now respects the system's directory separator character
		Assert.IsTrue(result == expected);
	}

	[TestMethod]
	public void EnsureTrailingSlash_WithoutTrailingSlash_ReturnsPathWithSlash()
	{
		var pathWithoutSlash = "C:\\TestPath";
		var expected = pathWithoutSlash + "\\";
		var result = PathHelper.EnsureTrailingSlash(pathWithoutSlash);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void EnsureTrailingSlash_WithTrailingSlash_ReturnsSamePath()
	{
		var pathWithSlash = "C:\\TestPath\\";
		var result = PathHelper.EnsureTrailingSlash(pathWithSlash);
		Assert.AreEqual(pathWithSlash, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void HasInvalidFilterChars_NullFilter_ThrowsArgumentNullException()
	{
		PathHelper.HasInvalidFilterChars(null);
	}
	[TestMethod]
	public void HasInvalidFilterChars_WithInvalidChars_ReturnsTrue()
	{
		var filter = "filename<>.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsTrue(result, "Expected to find invalid characters in the filter.");
	}

	[TestMethod]
	public void HasInvalidFilterChars_WithInvalidPathChars_ReturnsTrue()
	{
		var filter = "filename<|>.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsTrue(result, "Expected to find invalid path characters in the filter.");
	}

	[TestMethod]
	public void HasInvalidFilterChars_WithValidChars_ReturnsFalse()
	{
		var filter = "filename.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsFalse(result, "Expected no invalid characters in the filter.");
	}

	[TestMethod]
	public void HasInvalidFilterChars_WithWildcardChars_ReturnsFalse()
	{
		var filter = "filename*.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsFalse(result, "Wildcards should not be considered as invalid characters.");
	}

	[TestInitialize]
	public void Initialize()
	{
		if (Directory.Exists(this._testDirectory))
		{
			Directory.Delete(this._testDirectory, true);
		}
	}

	[TestMethod]
	public void InvalidFilterChars_ExcludesDirectorySeparators()
	{
		var invalidChars = PathHelper.InvalidFilterChars();
		Assert.IsFalse(invalidChars.Contains(Path.DirectorySeparatorChar), "The InvalidFilterChars method should not include the directory separator character.");
		Assert.IsFalse(invalidChars.Contains(Path.AltDirectorySeparatorChar), "The InvalidFilterChars method should not include the alternate directory separator character.");
	}

	[TestMethod]
	public void InvalidFilterChars_ExcludesWildcards()
	{
		var invalidChars = PathHelper.InvalidFilterChars();
		Assert.IsFalse(invalidChars.Contains('*'), "The InvalidFilterChars method should not include the '*' wildcard character.");
		Assert.IsFalse(invalidChars.Contains('?'), "The InvalidFilterChars method should not include the '?' wildcard character.");
	}

	[TestMethod]
	public void InvalidPathNameChars_ExcludesDirectorySeparators()
	{
		var invalidChars = PathHelper.InvalidPathNameChars();
		Assert.IsFalse(invalidChars.Contains(Path.DirectorySeparatorChar), "The InvalidPathNameChars method should not include the directory separator character.");
		Assert.IsFalse(invalidChars.Contains(Path.AltDirectorySeparatorChar), "The InvalidPathNameChars method should not include the alternate directory separator character.");
	}

	[TestMethod]
	public void InvalidPathNameChars_ReturnsExpectedCharacters()
	{
		var invalidChars = PathHelper.InvalidPathNameChars();
		var expectedChars = Path.GetInvalidPathChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();
		CollectionAssert.AreEquivalent(expectedChars, invalidChars.ToList(), "The InvalidPathNameChars method did not return the expected characters.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void PathContainsWildcard_NullPath_ThrowsArgumentNullException()
	{
		PathHelper.PathContainsWildcard(null);
	}

	[TestMethod]
	public void PathContainsWildcard_WithBothWildcards_ReturnsTrue()
	{
		var path = "C:\\MyDirectory\\*?.txt";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsTrue(result, "Expected to find both '*' and '?' wildcards in the path.");
	}

	[TestMethod]
	public void PathContainsWildcard_WithoutWildcard_ReturnsFalse()
	{
		var path = "C:\\MyDirectory\\file.txt";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsFalse(result, "Expected not to find any wildcards in the path.");
	}

	[TestMethod]
	public void PathContainsWildcard_WithPathSeparator_ReturnsFalse()
	{
		var path = "C:\\MyDirectory\\";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsFalse(result, "Path separator should not be considered as a wildcard.");
	}

	[TestMethod]
	public void PathContainsWildcard_WithWildcardQuestion_ReturnsTrue()
	{
		var path = "C:\\MyDirectory\\?.txt";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsTrue(result, "Expected to find a wildcard '?' in the path.");
	}

	[TestMethod]
	public void PathContainsWildcard_WithWildcardStar_ReturnsTrue()
	{
		var path = "C:\\MyDirectory\\*.txt";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsTrue(result, "Expected to find a wildcard '*' in the path.");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void PathHasInvalidChars_NullPath_ThrowsArgumentNullException()
	{
		PathHelper.PathHasInvalidChars(null);
	}

	[TestMethod]
	public void PathHasInvalidChars_WithDirectorySeparatorsOnly_ReturnsFalse()
	{
		var path = "C:\\TestPath\\Valid\\Name\\";
		var result = PathHelper.PathHasInvalidChars(path);
		Assert.IsFalse(result, "Directory separators should not be considered as invalid characters.");
	}

	[TestMethod]
	public void PathHasInvalidChars_WithPathSeparator_ReturnsFalse()
	{
		var path = "C:\\MyDirectory\\";
		var result = PathHelper.PathHasInvalidChars(path);
		Assert.IsFalse(result, "Path separator should not be considered as an invalid character.");
	}

	[TestMethod]
	public void PathHasInvalidChars_WithValidChars_ReturnsFalse()
	{
		var path = "C:\\TestPath\\ValidName.txt";
		var result = PathHelper.PathHasInvalidChars(path);
		Assert.IsFalse(result, "Expected no invalid characters in the path.");
	}

	[TestMethod]
	public void PathSeparators_ReturnsExpectedSeparators()
	{
		var expectedSeparators = new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };
		var separators = PathHelper.PathSeparators;

		Assert.AreEqual(expectedSeparators.Length, separators.Count, "The count of path separators does not match the expected count.");

		foreach (var separator in expectedSeparators)
		{
			Assert.IsTrue(separators.Contains(separator), $"The expected separator '{separator}' was not found in the PathSeparators collection.");
		}
	}
}
