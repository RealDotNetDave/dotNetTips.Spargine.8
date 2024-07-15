// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-13-2024
// ***********************************************************************
// <copyright file="DirectoryInfoExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for DirectoryInfo.</summary>
// ***********************************************************************
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="DirectoryInfo" /> to enhance and simplify its usage.
/// </summary>
/// <remarks>This class includes methods for calculating the total size of files within a directory,
/// and potentially more functionalities that extend <see cref="DirectoryInfo" />.
/// These methods aim to provide more convenient ways to interact with directories in .NET applications.</remarks>

public static class DirectoryInfoExtensions
{

	/// <summary>
	/// Gets the total size of files in a <see cref="DirectoryInfo" /> based on a search pattern and search option.
	/// </summary>
	/// <param name="path">The directory information.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="path" />. This parameter can contain a combination of valid literal and wildcard characters, but doesn't support regular expressions.</param>
	/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.</param>
	/// <returns>The total size of files in bytes.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path" /> is null.</exception>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="searchPattern" /> is null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption" /> is not a valid <see cref="SearchOption" />.</exception>
	/// <example>
	/// This example shows how to use the <see cref="GetSize" /> method to calculate the total size of files in a directory and its subdirectories.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// long totalSize = directoryInfo.GetSize("*.*", SearchOption.AllDirectories);
	/// Console.WriteLine($"Total size: {totalSize} bytes");
	/// </code></example>
	[Information(nameof(GetSize), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static long GetSize(this DirectoryInfo path, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		path = path.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		long totalSize = 0;
		foreach (var file in path.EnumerateFiles(searchPattern, searchOption))
		{
			totalSize += file.Length;
		}
		return totalSize;
	}

}
