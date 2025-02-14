// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-04-2025
// ***********************************************************************
// <copyright file="DirectoryHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for working with file directories.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Security.Principal;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;
using DotNetTips.Spargine.Win32;
using Microsoft.Win32;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides a collection of static methods for directory operations, enhancing functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class includes methods for performing operations such as copying, moving, deleting directories, checking permissions,
/// loading files asynchronously, managing OneDrive folders, and conducting safe directory and file searches. These methods
/// are designed to extend the capabilities of the <see cref="DirectoryInfo"/> class and simplify common file system operations.
/// </remarks>
[Information(Status = Status.NeedsDocumentation, Documentation = "ADD URL")]
public static class DirectoryHelper
{

	/// <summary>
	/// Gets the application data folder path for the current user.
	/// </summary>
	/// <returns>The path to the application data folder.</returns>
	/// <exception cref="InvalidOperationException">Thrown when the user path environment variable is not set.</exception>
	[SupportedOSPlatform("windows")]
	[SupportedOSPlatform("macos")]
	[Information(nameof(AppDataFolder), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string AppDataFolder()
	{
		var userPath = Environment.GetEnvironmentVariable(RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "LOCALAPPDATA" : "Home");

		if (string.IsNullOrEmpty(userPath))
		{
			ExceptionThrower.ThrowInvalidOperationException("User path environment variable is not set.");
		}

		var companyName = Assembly.GetEntryAssembly().GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault().Company.Trim();

		return Path.Combine(userPath, companyName);
	}

	/// <summary>
	/// Checks if the current user has the specified permission on the given directory.
	/// </summary>
	/// <param name="directory">The directory to check permissions on.</param>
	/// <param name="permission">The permission to check for. Default is <see cref="FileSystemRights.Read" />.</param>
	/// <returns><c>true</c> if the specified permission is allowed; otherwise, <c>false</c>.</returns>
	/// <example>
	/// This example shows how to call the <see cref="CheckPermission" /> method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo("C:\\MyDirectory");
	/// var hasReadPermission = DirectoryHelper.CheckPermission(directoryInfo, FileSystemRights.Read);
	/// Console.WriteLine($"Has read permission: {hasReadPermission}");
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directory"/> is null.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(CheckPermission), author: "David McCarter", createdOn: "6/17/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Documentation = "https://bit.ly/SpargineAug2022", Status = Status.Available)]
	public static bool CheckPermission([NotNull] DirectoryInfo directory, FileSystemRights permission = FileSystemRights.Read)
	{
		//OPTIMIZATION FROM COPILOT BREAKS THIS CODE
		directory = directory.ArgumentNotNull();

		var accessControl = directory.GetAccessControl();
		var rules = accessControl.GetAccessRules(true, true, typeof(SecurityIdentifier));

		var allow = false;
		var deny = false;

		foreach (FileSystemAccessRule rule in rules)
		{
			if ((permission & rule.FileSystemRights) != permission)
			{
				continue;
			}

			switch (rule.AccessControlType)
			{
				case AccessControlType.Allow:
					allow = true;
					break;
				case AccessControlType.Deny:
					deny = true;
					break;
				default:
					break;
			}
		}

		return allow && !deny;
	}

	/// <summary>
	/// Copies the specified source directory to the specified destination directory.
	/// </summary>
	/// <param name="source">The source directory to copy from.</param>
	/// <param name="destination">The destination directory to copy to.</param>
	/// <param name="overwrite">if set to <c>true</c>, the destination files will be overwritten if they already exist.</param>
	/// <example>
	/// This example shows how to use the <see cref="CopyDirectory" /> method.
	/// <code>
	/// var sourceDir = new DirectoryInfo(@"C:\SourceDirectory");
	/// var destDir = new DirectoryInfo(@"C:\DestinationDirectory");
	/// DirectoryHelper.CopyDirectory(sourceDir, destDir, true);
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(CopyDirectory), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void CopyDirectory([NotNull] DirectoryInfo source, [NotNull] DirectoryInfo destination, bool overwrite = true)
	{
		source = source.ArgumentNotNull();
		_ = destination.ArgumentNotNull().CheckExists();

		var files = source.GetFiles();
		var subdirs = source.GetDirectories();

		_ = Parallel.ForEach(files, file =>
		{
			var destFile = Path.Combine(destination.FullName, file.Name);
			_ = file.CopyTo(destFile, overwrite);
		});

		_ = Parallel.ForEach(subdirs, subdir =>
		{
			var destSubDir = destination.CreateSubdirectory(subdir.Name);
			CopyDirectory(subdir, destSubDir, overwrite);
		});
	}

	/// <summary>
	/// Deletes the directory with retry.
	/// </summary>
	/// <param name="path">The directory to delete.</param>
	/// <param name="retries">Number of retries in case of failure. Default is 5.</param>
	/// <example>
	/// This example shows how to call the <see cref="DeleteDirectory" /> method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// DirectoryHelper.DeleteDirectory(directoryInfo, 5);
	/// </code></example>
	/// <remarks>Checks for the <see cref="IOException" /> and <see cref="UnauthorizedAccessException" />.</remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> is null.</exception>
	/// <exception cref="IOException">Thrown when the directory could not be deleted after the specified number of retries.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when the directory could not be deleted due to unauthorized access after the specified number of retries.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(DeleteDirectory), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void DeleteDirectory([NotNull] DirectoryInfo path, byte retries = 5)
	{
		//TODO: FOR VERSION 10, RETURN SIMPLERESULT.

		path = path.ArgumentNotNull();

		if (Path.Exists(path.FullName) is false)
		{
			return;
		}

		retries = retries.ArgumentInRange(1, upper: 250);

		// On some systems, directories/files created are created with attributes
		// that prevent them from being deleted. Set those attributes to be normal
		SetFileAttributesToNormal(path);

		_ = ExecutionHelper.ProgressiveRetry(() => path.Delete(true), retryCount: retries, retryWaitMilliseconds: 2);
	}

	/// <summary>
	/// Asynchronously loads files from the specified directories using the given search pattern and search option.
	/// </summary>
	/// <param name="directories">The directories from which files are to be loaded.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="directories" />.</param>
	/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>An asynchronous stream (<see cref="IAsyncEnumerable{T}" />) of collections of <see cref="FileInfo" />, where each collection represents files found in a directory.</returns>
	/// <remarks>This method utilizes deferred execution to improve performance. Files are not loaded into memory until the asynchronous stream is iterated.</remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directories"/> or <paramref name="searchPattern"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SupportedOSPlatform("windows")]
	[Information(nameof(LoadFilesAsync), author: "David McCarter", createdOn: "3/1/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static async IAsyncEnumerable<IEnumerable<FileInfo>> LoadFilesAsync([NotNull] IEnumerable<DirectoryInfo> directories, [NotNull] string searchPattern, SearchOption searchOption, [EnumeratorCancellation] CancellationToken cancellationToken = default)
	{
		directories = directories.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNull();

		if (searchOption.CheckIsDefined() is false)
		{
			searchOption = SearchOption.TopDirectoryOnly;
		}

		var options = new EnumerationOptions() { IgnoreInaccessible = true, RecurseSubdirectories = searchOption == SearchOption.AllDirectories };

		var tasks = directories.Where(directory => directory.Exists)
			.Select(directory => Task.Run(() => directory.GetFiles(searchPattern, options), cancellationToken))
			.ToList();

		foreach (var task in tasks)
		{
			yield return await task.ConfigureAwait(false);
		}
	}


	/// <summary>
	/// Loads the OneDrive folders for the current user.
	/// </summary>
	/// <returns>A read-only collection of <see cref="OneDriveFolder"/> objects representing the OneDrive folders.</returns>
	/// <remarks>
	/// This method retrieves the OneDrive folders by accessing the Windows Registry. It supports both personal and business accounts.
	/// Note: This method is only supported on Windows.
	/// </remarks>
	/// <exception cref="PlatformNotSupportedException">Thrown if the method is invoked on a non-Windows platform.</exception>
	/// <example>
	/// This example shows how to call the <see cref="LoadOneDriveFolders"/> method.
	/// <code>
	/// var oneDriveFolders = DirectoryHelper.LoadOneDriveFolders();
	/// foreach(var folder in oneDriveFolders)
	/// {
	///     Console.WriteLine($"OneDrive Folder: {folder.DirectoryInfo.FullName}");
	/// }
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[Information(nameof(LoadOneDriveFolders), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<OneDriveFolder> LoadOneDriveFolders()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) is false)
		{
			throw new PlatformNotSupportedException();
		}

		const string DisplayNameKey = "DisplayName";
		const string UserFolderKey = "UserFolder";
		const string AccountsKey = "Accounts";
		const string EmailKey = "UserEmail";

		var folders = new List<OneDriveFolder>();

		using (var oneDriveKey = RegistryHelper.GetRegistryKey(RegistryHelper.KeyCurrentUserOneDrive, RegistryHive.CurrentUser))
		{
			if (oneDriveKey.IsNotNull())
			{
				// Get Accounts
				using (var accountKey = oneDriveKey.GetSubKey(AccountsKey))
				{
					if (accountKey.IsNotNull() && accountKey.SubKeyCount > 0)
					{
						var subkeyCount = accountKey.GetSubKeyNames().LongLength;

						for (var subKeyIndex = 0; subKeyIndex < subkeyCount; subKeyIndex++)
						{
							using var key = accountKey.OpenSubKey(accountKey.GetSubKeyNames()[subKeyIndex]);

							var folder = new OneDriveFolder();
							var directoryValue = key.GetValue<string>(UserFolderKey);

							if (directoryValue.HasValue())
							{
								folder.DirectoryInfo = new DirectoryInfo(directoryValue);

								var emailValue = key.GetValue<string>(EmailKey);

								if (emailValue.IsNotNull())
								{
									folder.UserEmail = emailValue;
								}

								// Figure out account type
								var name = key.GetValue<string>(DisplayNameKey);

								if (name.HasValue())
								{
									folder.AccountType = OneDriveAccountType.Business;
									folder.AccountName = name;
								}
								else
								{
									folder.AccountName = OneDriveAccountType.Personal.ToString();
								}

								folders.Add(folder);
							}
						}
					}
				}
			}
		}

		return folders.ToReadOnlyCollection();
	}

	/// <summary>
	/// Moves a directory from a source to a destination, optionally allowing retries in case of failure.
	/// </summary>
	/// <param name="source">The source directory to move. Must not be null.</param>
	/// <param name="destination">The destination directory where the source directory should be moved to. Must not be null.</param>
	/// <param name="retries">The number of retry attempts for the move operation. Must be greater than or equal to 0.</param>
	/// <remarks>
	/// This method uses <see cref="DirectoryInfo.MoveTo"/> for moving the directory. If the operation fails, it will retry the specified number of times.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="retries"/> is less than 0.</exception>
	/// <example>
	/// This example shows how to call the <see cref="MoveDirectory" /> method.
	/// <code>
	/// var sourceDir = new DirectoryInfo(@"C:\SourceDirectory");
	/// var destDir = new DirectoryInfo(@"C:\DestinationDirectory");
	/// DirectoryHelper.MoveDirectory(sourceDir, destDir, 5);
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="IOException">Thrown when the directory could not be moved after the specified number of retries.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(MoveDirectory), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void MoveDirectory([NotNull] DirectoryInfo source, [NotNull] DirectoryInfo destination, int retries = 10)
	{
		source = source.ArgumentExists();
		retries = retries.ArgumentInRange(1, upper: 100, defaultValue: 10, errorMessage: Resources.RetriesAreLimitedTo0100);

		if (destination.ArgumentNotNull().CheckExists(throwException: true))
		{
			_ = ExecutionHelper.ProgressiveRetry(() => Directory.Move(source.FullName, destination.FullName), retryCount: 3, retryWaitMilliseconds: 10);
		}
	}

	/// <summary>
	/// Performs a safe directory search by matching specified search patterns and search option, ignoring errors accessing directories.
	/// </summary>
	/// <param name="path">The directory to search.</param>
	/// <param name="searchOption">Specifies whether the search operation should include only the current directory or should include all subdirectories.</param>
	/// <param name="searchPatterns">The search patterns to use for matching files.</param>
	/// <returns><c>true</c> if the directory contains any files that match the search patterns; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// Utilizes <see cref="DirectoryInfo.EnumerateDirectories(string, SearchOption)"/> and <see cref="DirectoryInfo.EnumerateFiles(string, SearchOption)"/> for searching, providing a more robust and error-tolerant approach compared to direct enumeration.
	/// </remarks>
	/// <example>
	/// This example shows how to call the SafeDirectorySearch method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// bool containsFiles = DirectoryHelper.SafeDirectorySearch(directoryInfo, SearchOption.TopDirectoryOnly, "*.txt", "*.docx");
	/// Console.WriteLine($"Directory contains matching files: {containsFiles}");
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> or <paramref name="searchPatterns"/> is null.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(SafeDirectorySearch), "David McCarter", "6/14/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineSep2022", Status = Status.Available)]
	public static bool SafeDirectorySearch([NotNull] DirectoryInfo path, SearchOption searchOption = SearchOption.TopDirectoryOnly, [NotNull] params string[] searchPatterns)
	{
		path = path.ArgumentExists();
		searchOption = searchOption.ArgumentDefined();
		searchPatterns = searchPatterns.ArgumentNotNull();

		return searchPatterns.Any(pattern => SafeDirectorySearch(path, pattern, searchOption).HasItems());
	}

	/// <summary>
	/// Performs a safe directory search by matching a specified search pattern and search option.
	/// </summary>
	/// <param name="path">The root directory to start the search from. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the directory names. Default is "*.*" which matches all directories.</param>
	/// <param name="searchOption">Specifies whether to search only the current directory, or all subdirectories. The default is <see cref="SearchOption.TopDirectoryOnly" />.</param>
	/// <returns>An <see cref="IEnumerable{DirectoryInfo}" /> containing directories that match the search pattern and option.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> or <paramref name="searchPattern"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption"/> is not a valid <see cref="SearchOption"/>.</exception>
	/// <example>
	/// This example shows how to call the SafeDirectorySearch method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// foreach (var dir in DirectoryHelper.SafeDirectorySearch(directoryInfo, "*.config", SearchOption.AllDirectories))
	/// {
	/// Console.WriteLine(dir.FullName);
	/// }
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> or <paramref name="searchPattern"/> is null.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(SafeDirectorySearch), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<DirectoryInfo> SafeDirectorySearch([NotNull] DirectoryInfo path, [NotNull] string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		//OPTIMIZATION FROM COPILOT BREAKS CODE
		path = path.ArgumentExists();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		var options = new EnumerationOptions { IgnoreInaccessible = true, ReturnSpecialDirectories = true, RecurseSubdirectories = false };

		if (searchOption == SearchOption.AllDirectories)
		{
			options.RecurseSubdirectories = true;
		}

		var directories = path.GetDirectories(searchPattern, options);
		var itemCount = directories.LongLength;

		for (var index = 0; index < itemCount; index++)
		{
			yield return directories[index];
		}
	}

	/// <summary>
	/// Performs a safe file search in the specified directory using the given search pattern and search option.
	/// Ignores errors accessing directories.
	/// </summary>
	/// <param name="path">The directory to search. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="path"/>.</param>
	/// <param name="searchOption">Specifies whether the search operation should include only the current directory or should include all subdirectories. Uses <see cref="SearchOption"/>.</param>
	/// <returns>A read-only collection of <see cref="FileInfo"/> objects that match the search pattern and option.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> or <paramref name="searchPattern"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption"/> is not a valid <see cref="SearchOption"/>.</exception>
	/// <example>
	/// This example shows how to call the SafeFileSearch method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// var files = DirectoryHelper.SafeFileSearch(directoryInfo, "*.txt", SearchOption.AllDirectories);
	/// foreach(var file in files)
	/// {
	/// Console.WriteLine(file.FullName);
	/// }
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> or <paramref name="searchPattern"/> is null.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "http://bit.ly/SpargineMarch2021", Status = Status.Available)]
	public static ReadOnlyCollection<FileInfo> SafeFileSearch([NotNull] DirectoryInfo path, [NotNull] string searchPattern, SearchOption searchOption)
	{
		var directories = new List<DirectoryInfo>(1)
		{
			path
		};

		return SafeFileSearch(directories, searchPattern, searchOption).ToReadOnlyCollection();
	}

	/// <summary>
	/// Performs a safe file search in the specified directories using the given search pattern and search option.
	/// Ignores errors accessing directories.
	/// </summary>
	/// <param name="directories">The directories to search. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="directories"/>.</param>
	/// <param name="searchOption">Specifies whether the search operation should include only the current directory or should include all subdirectories. Uses <see cref="SearchOption"/>.</param>
	/// <returns>An <see cref="IEnumerable{FileInfo}"/> containing files that match the search pattern and option.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="directories"/> or <paramref name="searchPattern"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption"/> is not a valid <see cref="SearchOption"/>.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<FileInfo> SafeFileSearch([NotNull] IEnumerable<DirectoryInfo> directories, [NotNull] string searchPattern, SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		directories = directories.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		var options = new EnumerationOptions
		{
			IgnoreInaccessible = true,
			ReturnSpecialDirectories = false,
			RecurseSubdirectories = false
		};

		if (searchOption == SearchOption.AllDirectories)
		{
			options.RecurseSubdirectories = true;
		}

		foreach (var directory in directories)
		{
			if (directory.Exists)
			{
				var directoryFiles = directory.EnumerateFiles(searchPattern, options).ToArray();

				if (directoryFiles.HasItems())
				{
					foreach (var directoryFile in directoryFiles)
					{
						yield return directoryFile;
					}
				}
			}
		}
	}

	/// <summary>
	/// Sets the attributes of all files in the specified directory, and its subdirectories, to normal.
	/// </summary>
	/// <param name="path">The directory whose file attributes will be set to normal. Must not be null.</param>
	/// <remarks>
	/// This method recursively traverses all files in the given directory and its subdirectories, setting their attributes to <see cref="FileAttributes.Normal"/>.
	/// It's useful for preparing files for deletion that might otherwise be read-only or have other attributes set.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> is null.</exception>
	/// <example>
	/// This example shows how to call the <see cref="SetFileAttributesToNormal" /> method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// DirectoryHelper.SetFileAttributesToNormal(directoryInfo);
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> is null.</exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(SetFileAttributesToNormal), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void SetFileAttributesToNormal([NotNull] DirectoryInfo path)
	{
		path = path.ArgumentExists();

		var options = new EnumerationOptions { IgnoreInaccessible = true, ReturnSpecialDirectories = false, RecurseSubdirectories = true };

		foreach (var file in path.GetFiles("*.*", options))
		{
			file.Attributes = FileAttributes.Normal;
		}
	}
}
