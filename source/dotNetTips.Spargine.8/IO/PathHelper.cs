// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="PathHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for path manipulation, encompassing handling invalid filter characters, invalid path names, and path separators.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides utility methods for path manipulation and validation, including combining paths, ensuring trailing slashes, and checking for invalid characters.
/// </summary>
/// <remarks>
/// This class offers a variety of static methods to assist with common path manipulation tasks such as combining paths, ensuring paths end with a directory separator,
/// and validating paths for invalid characters. It is designed to simplify file system operations by abstracting complex checks and operations into straightforward method calls.
/// </remarks>
public static class PathHelper
{

	/// <summary>
	/// The invalid file name characters, excluding '*', '|', and '?'.
	/// </summary>
	/// <remarks>
	/// This array is derived from <see cref="FileHelper.InvalidFileNameChars"/> by filtering out specific characters.
	/// It is used to validate file names by checking against characters that are not allowed in file names according to the file system.
	/// </remarks>
	[SupportedOSPlatform("windows")]
	private static readonly char[] InvalidFileNameChars = FileHelper.InvalidFileNameChars.Where(c => c is not '*' and not '|' and not '?').ToArray();

	/// <summary>
	/// The invalid path characters, excluding directory separator characters.
	/// </summary>
	/// <remarks>
	/// This array is derived from <see cref="Path.GetInvalidPathChars"/> by filtering out the directory separator characters
	/// <see cref="Path.DirectorySeparatorChar"/> and <see cref="Path.AltDirectorySeparatorChar"/>.
	/// It is used to validate paths by checking against characters that are not allowed in paths according to the file system.
	/// </remarks>
	private static readonly char[] InvalidPathChars = Path.GetInvalidPathChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();

	/// <summary>
	/// Combines the paths into a single path. If <paramref name="createIfNotExists"/> is true, the combined path will be created if it does not exist.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c>, the combined path will be created if it does not exist.</param>
	/// <param name="paths">The paths to combine.</param>
	/// <returns>A <see cref="DirectoryInfo"/> object for the combined path.</returns>
	/// <example>
	/// Here is how you can use the CombinePaths method:
	/// <code>
	/// var combinedPathInfo = PathHelper.CombinePaths(true, "C:\\path1", "path2", "path3");
	/// Console.WriteLine(combinedPathInfo.FullName);
	/// </code>
	/// </example>
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SparginePathHelper")]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] params string[] paths)
	{
		paths = paths.ArgumentItemsExists(nameof(paths));

		for (var paramCount = 0; paramCount < paths.Length; paramCount++)
		{
			paths[paramCount] = paths[paramCount].ToTrimmed();
		}

		var combinedPath = Path.Combine(paths);

		var di = new DirectoryInfo(combinedPath);

		if (createIfNotExists && di.Exists is false)
		{
			di.Create();
		}

		return di;
	}

	/// <summary>
	/// Combines two specified path strings into a single path. If <paramref name="createIfNotExists"/> is set to <c>true</c>, the combined path will be created if it does not exist.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c>, the combined path will be created if it does not exist.</param>
	/// <param name="path1">The first path to combine.</param>
	/// <param name="path2">The second path to combine.</param>
	/// <returns>A <see cref="DirectoryInfo"/> object for the combined path.</returns>
	/// <example>
	/// Here is how you can use the CombinePaths method:
	/// <code>
	/// var combinedPathInfo = PathHelper.CombinePaths(true, "C:\\path1", "path2");
	/// Console.WriteLine(combinedPathInfo.FullName);
	/// </code>
	/// </example>
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SparginePathHelper")]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] string path1, [NotNull] string path2)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();

		return CombinePaths(createIfNotExists, [path1, path2]);
	}

	/// <summary>
	/// Combines three specified path strings into a single path. If <paramref name="createIfNotExists"/> is set to <c>true</c>, the combined path will be created if it does not exist.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c>, the combined path will be created if it does not exist.</param>
	/// <param name="path1">The first path to combine.</param>
	/// <param name="path2">The second path to combine.</param>
	/// <param name="path3">The third path to combine.</param>
	/// <returns>A <see cref="DirectoryInfo"/> object for the combined path.</returns>
	/// <example>
	/// Here is how you can use the CombinePaths method:
	/// <code>
	/// var combinedPathInfo = PathHelper.CombinePaths(true, "C:\\path1", "path2", "path3");
	/// Console.WriteLine(combinedPathInfo.FullName);
	/// </code>
	/// </example>
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SparginePathHelper")]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] string path1, [NotNull] string path2, [NotNull] string path3)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();
		path3 = path3.ArgumentNotNullOrEmpty();

		return CombinePaths(createIfNotExists, [path1, path2, path3]);
	}

	/// <summary>
	/// Combines four specified path strings into a single path. If <paramref name="createIfNotExists"/> is set to <c>true</c>, the combined path will be created if it does not exist.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c>, the combined path will be created if it does not exist.</param>
	/// <param name="path1">The first path to combine.</param>
	/// <param name="path2">The second path to combine.</param>
	/// <param name="path3">The third path to combine.</param>
	/// <param name="path4">The fourth path to combine.</param>
	/// <returns>A <see cref="DirectoryInfo"/> object for the combined path.</returns>
	/// <example>
	/// Here is how you can use the CombinePaths method:
	/// <code>
	/// var combinedPathInfo = PathHelper.CombinePaths(true, "C:\\path1", "path2", "path3", "path4");
	/// Console.WriteLine(combinedPathInfo.FullName);
	/// </code>
	/// </example>
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SparginePathHelper")]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] string path1, [NotNull] string path2, [NotNull] string path3, [NotNull] string path4)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();
		path3 = path3.ArgumentNotNullOrEmpty();
		path4 = path4.ArgumentNotNullOrEmpty();

		var paths = new string[] { path1, path2, path3, path4 };

		return CombinePaths(createIfNotExists, paths);
	}

	/// <summary>
	/// Ensures that the specified path ends with a directory separator character.
	/// </summary>
	/// <param name="path">The path to modify.</param>
	/// <returns>The modified path that ends with a directory separator character.</returns>
	/// <example>
	/// Here is how you can use the EnsureTrailingSlash method:
	/// <code>
	/// string path = "C:\\MyDirectory";
	/// string result = PathHelper.EnsureTrailingSlash(path);
	/// Console.WriteLine(result); // Output: C:\MyDirectory\
	/// </code>
	/// </example>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SparginePathHelper")]
	public static string EnsureTrailingSlash([NotNull] string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		if (!path.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
		{
			path += Path.DirectorySeparatorChar;
		}

		return path;
	}

	/// <summary>
	/// Determines whether the specified filter contains any invalid characters.
	/// </summary>
	/// <param name="filter">The filter string to check.</param>
	/// <returns><c>true</c> if the specified filter contains invalid characters; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the HasInvalidFilterChars method:
	/// <code>
	/// string filter = "filename?.txt";
	/// bool result = PathHelper.HasInvalidFilterChars(filter);
	/// Console.WriteLine(result); // Output: True
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SparginePathHelper")]
	public static bool HasInvalidFilterChars([NotNull] string filter)
	{
		filter = filter.ArgumentNotNullOrEmpty();

		return filter.IndexOfAny([.. InvalidFilterChars()]) != -1;
	}

	/// <summary>
	/// Gets the invalid filter characters, excluding wildcards.
	/// </summary>
	/// <returns>A read-only collection of characters that are invalid in file names, excluding wildcard characters.</returns>
	/// <example>
	/// Here is how you can retrieve the invalid filter characters:
	/// <code>
	/// var invalidChars = PathHelper.InvalidFilterChars();
	/// foreach (var c in invalidChars)
	/// {
	///     Console.Write(c + ", ");
	/// }
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<char> InvalidFilterChars() => InvalidFileNameChars.ToReadOnlyCollection();

	/// <summary>
	/// Gets the invalid path name characters, excluding directory separators.
	/// </summary>
	/// <returns>A read-only collection of characters that are invalid in path names, excluding directory separator characters.</returns>
	/// <example>
	/// Here is how you can retrieve the invalid path name characters:
	/// <code>
	/// var invalidChars = PathHelper.InvalidPathNameChars();
	/// foreach (var c in invalidChars)
	/// {
	///     Console.Write(c + ", ");
	/// }
	/// </code>
	/// </example>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<char> InvalidPathNameChars() => InvalidPathChars.ToReadOnlyCollection();

	/// <summary>
	/// Checks to see if the path contains any wildcards ('*' or '?').
	/// </summary>
	/// <param name="path">The path to check.</param>
	/// <returns><c>true</c> if the path contains wildcards; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the PathContainsWildcard method:
	/// <code>
	/// string path = "C:\\MyDirectory\\*.txt";
	/// bool containsWildcard = PathHelper.PathContainsWildcard(path);
	/// Console.WriteLine(containsWildcard); // Output: True
	/// </code>
	/// </example>
	[Information(nameof(PathContainsWildcard), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SparginePathHelper")]
	public static bool PathContainsWildcard([NotNull] string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		return (path?.IndexOf('*', StringComparison.Ordinal) != -1) || (path?.IndexOf('?', StringComparison.Ordinal) != -1);
	}

	/// <summary>
	/// Determines if the path has invalid characters.
	/// </summary>
	/// <param name="path">The path to check for invalid characters.</param>
	/// <returns><c>true</c> if the path contains any characters that are invalid in file and directory paths; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks the path against a set of characters that are not allowed in file and directory paths, as defined by the operating system.
	/// The invalid characters are obtained from <see cref="InvalidPathNameChars"/>, which excludes directory separator characters.
	/// </remarks>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SparginePathHelper")]
	public static bool PathHasInvalidChars([NotNull] string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		return path.IndexOfAny([.. InvalidPathNameChars()]) != -1;
	}

	/// <summary>
	/// Gets the path separators used in file paths.
	/// </summary>
	/// <value>
	/// A read-only collection of characters used as path separators, specifically the
	/// <see cref="Path.DirectorySeparatorChar"/> and <see cref="Path.AltDirectorySeparatorChar"/>.
	/// </value>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<char> PathSeparators => new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar }.ToReadOnlyCollection();

}
