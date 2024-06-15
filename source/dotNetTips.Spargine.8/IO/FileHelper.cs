// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-11-2024
// ***********************************************************************
// <copyright file="FileHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for working with files.</summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Security.Principal;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides utility methods for file operations such as copying, moving, deleting, and permissions checking.
/// </summary>
[Information(nameof(FileHelper), "David McCarter", "2/11/2017", Status = Status.Available)]
public static class FileHelper
{

	/// <summary>
	/// The no result
	/// </summary>
	private const int NoResult = -1;

	/// <summary>
	/// The count for retries.
	/// </summary>
	private const int Retries = 10;

	/// <summary>
	/// The HTTP client
	/// </summary>
	private static HttpClient _httpClient;

	/// <summary>
	/// Delegate CopyProgressResult
	/// </summary>
	/// <param name="totalFileSize">Total size of the file.</param>
	/// <param name="totalBytesTransferred">The total bytes transferred.</param>
	/// <param name="streamSize">Size of the stream.</param>
	/// <param name="streamBytesTransferred">The stream bytes transferred.</param>
	/// <param name="dwStreamNumber">The dw stream number.</param>
	/// <param name="dwCallbackReason">The dw callback reason.</param>
	/// <param name="hSourceFile">The h source file.</param>
	/// <param name="hDestinationFile">The h destination file.</param>
	/// <param name="lpData">The lp data.</param>
	/// <returns>CopyProgressResult.</returns>
	public delegate CopyProgressResult CopyProgressRoutine(long totalFileSize, long totalBytesTransferred, long streamSize, long streamBytesTransferred, uint dwStreamNumber, CopyProgressCallbackReason dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

	/// <summary>
	/// Gets the HTTP client.
	/// </summary>
	/// <returns>System.Net.Http.HttpClient.</returns>
	private static HttpClient GetHttpClient()
	{
		_httpClient ??= new HttpClient();

		return _httpClient;
	}

	/// <summary>
	/// Un-zips a file as an asynchronous operation.
	/// </summary>
	/// <param name="zipPath">The zip file.</param>
	/// <param name="expandedDirectoryPath">The expanded directory file.</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnWinZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	private static async Task UnWinZipAsync(string zipPath, string expandedDirectoryPath)
	{
		using var zipFileStream = File.OpenRead(zipPath);
		using var zipArchiveStream = new ZipArchive(zipFileStream);

		for (var zipArchiveCount = 0; zipArchiveCount < zipArchiveStream.Entries.FastCount(); zipArchiveCount++)
		{
			var zipArchiveEntry = zipArchiveStream.Entries[zipArchiveCount];

			if (zipArchiveEntry.CompressedLength == 0)
			{
				continue;
			}

			var extractedFilePath = Path.Combine(expandedDirectoryPath, zipArchiveEntry.FullName);

			_ = Directory.CreateDirectory(Path.GetDirectoryName(extractedFilePath));

			using (var zipStream = zipArchiveEntry.Open())
			{
				using (var extractedFileStream = File.OpenWrite(extractedFilePath))
				{
					await zipStream.CopyToAsync(extractedFileStream, CancellationToken.None).ConfigureAwait(false);
				}
			}
		}
	}

	/// <summary>
	/// Checks the permission of a file.
	/// </summary>
	/// <param name="file">The file to check permissions on.</param>
	/// <param name="permission">The permission to check for. Defaults to FileSystemRights.Read.</param>
	/// <returns><c>true</c> if the file has the specified permission; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the <see cref="CheckPermission"/> method:
	/// <code>
	/// var fileInfo = new FileInfo("path/to/your/file.txt");
	/// var hasReadPermission = FileHelper.CheckPermission(fileInfo, FileSystemRights.Read);
	/// Console.WriteLine($"Has read permission: {hasReadPermission}");
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[Information(nameof(CheckPermission), author: "David McCarter", createdOn: "6/17/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool CheckPermission([NotNull] FileInfo file, FileSystemRights permission = FileSystemRights.Read)
	{
		file = file.ArgumentNotNull();

		var access = FileSystemAclExtensions.GetAccessControl(file);

		if (access is null)
		{
			return false;
		}

		var rules = access.GetAccessRules(true, true, typeof(SecurityIdentifier));

		if (rules is null)
		{
			return false;
		}

		var allow = false;
		var deny = false;

		foreach (FileSystemAccessRule rule in rules)
		{
			if ((rule.FileSystemRights & permission) != permission)
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
	/// Copies the file to a new directory. If the file already exists, it
	/// will be overwritten.
	/// </summary>
	/// <param name="file">The file to copy.</param>
	/// <param name="destination">The destination directory.</param>
	/// <returns>The length of the copied file in bytes.</returns>
	/// <example>
	/// Here is how you can use the CopyFile method:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/source/file.txt");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// var fileLength = FileHelper.CopyFile(sourceFile, destinationDir);
	/// Console.WriteLine($"Copied file length: {fileLength}");
	/// </code>
	/// </example>
	[Information(nameof(CopyFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static long CopyFile([NotNull] FileInfo file, [NotNull] DirectoryInfo destination)
	{
		//TODO: ADD TO BENCHMARKING TESTS. THEN TRY OPTIMIZE.
		var fileName = file.ArgumentExists().FullName;

		if (destination.ArgumentNotNull().CheckExists(throwException: true))
		{
			var destinationName = destination.FullName;

			var newFileName = Path.Combine(destinationName, fileName);

			using (var sourceStream = file.Open(FileMode.Open))
			{
				if (File.Exists(newFileName))
				{
					File.Delete(newFileName);
				}

				using var destinationStream = File.Create(newFileName);

				sourceStream.CopyTo(destinationStream);

				destinationStream.Flush();
			}

			return file.Length;
		}
		else
		{
			return NoResult;
		}
	}

	/// <summary>
	/// Copies the file to a new directory with progress callback. If the file already exists, it
	/// will be overwritten.
	/// </summary>
	/// <param name="file">The file to copy.</param>
	/// <param name="destination">The destination directory.</param>
	/// <param name="progressCallback">The progress callback.</param>
	/// <returns><c>true</c> if the file was copied successfully; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the CopyFile method with a progress callback:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/source/file.txt");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// bool result = FileHelper.CopyFile(sourceFile, destinationDir, (totalFileSize, totalBytesTransferred, streamSize, streamBytesTransferred, dwStreamNumber, dwCallbackReason, hSourceFile, hDestinationFile, lpData) =>
	/// {
	///     Console.WriteLine($"{totalBytesTransferred} of {totalFileSize} bytes transferred.");
	///     return CopyProgressResult.PROGRESS_CONTINUE;
	/// });
	/// Console.WriteLine($"Copy result: {result}");
	/// </code>
	/// </example>
	[Information(nameof(CopyFile), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
	public static bool CopyFile([NotNull] FileInfo file, [NotNull] DirectoryInfo destination, [NotNull] CopyProgressRoutine progressCallback)
	{
		//TODO: ADD TO BENCHMARKING TESTS. THEN TRY OPTIMIZE.
		file = file.ArgumentNotNull();
		destination = destination.ArgumentNotNull();
		progressCallback = progressCallback.ArgumentNotNull();

		if (destination.ArgumentNotNull().CheckExists(throwException: true))
		{
			var cancel = 0;

			return LibraryImport.CopyFileEx(file.FullName, Path.Combine(destination.FullName, file.Name), progressCallback, IntPtr.Zero, ref cancel, CopyFileMode.Restartable | CopyFileMode.Restartable);
		}
		else
		{
			return false;
		}
	}

	/// <summary>
	/// Copies a file to a new directory as an asynchronous operation.
	/// If the file already exists, it will be overwritten.
	/// </summary>
	/// <param name="file">The file.</param>
	/// <param name="destination">The destination folder.</param>
	/// <returns>Task&lt;System.Int64&gt; representing the length of the copied file in bytes.</returns>
	/// <example>
	/// Here is how you can use the <see cref="CopyFileAsync"/> method:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/source/file.txt");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// var fileLength = await FileHelper.CopyFileAsync(sourceFile, destinationDir);
	/// Console.WriteLine($"Copied file length: {fileLength}");
	/// </code>
	/// </example>
	[Information(nameof(CopyFileAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://dotnettips.wordpress.com/2020/11/17/coding-faster-with-the-dotnettips-utility-november-2020-update")]
	public static async Task<long> CopyFileAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination)
	{
		//TODO: ADD TO BENCHMARKING TESTS. THEN TRY OPTIMIZE.

		var fileName = file.ArgumentExists().FullName;
		_ = destination.ArgumentNotNull().CheckExists(createDirectory: true, throwException: true, errorMessage: string.Format(CultureInfo.InvariantCulture, Resources.DirectoryDoesNotExistOrCannotBeCreated, destination.FullName));

		var destinationName = destination.FullName;

		var newFileName = Path.Combine(destinationName, fileName);

		using (var sourceStream = File.Open(fileName, FileMode.Open))
		{
			if (File.Exists(newFileName))
			{
				File.Delete(newFileName);
			}

			using (var destinationStream = File.Create(newFileName))
			{
				await sourceStream.CopyToAsync(destinationStream, CancellationToken.None).ConfigureAwait(false);
				await destinationStream.FlushAsync(CancellationToken.None).ConfigureAwait(false);
			}
		}

		return file.Length;
	}

	/// <summary>
	/// Attempts to delete files and will return the names of the deleted files along with any
	/// error messages for files that could not be deleted.
	/// </summary>
	/// <param name="files">The files.</param>
	/// <param name="stopOnFirstError">The stop on first error.</param>
	/// <returns>DotNetTips.Spargine.Core.SimpleResult&lt;System.Collections.ObjectModel.ReadOnlyCollection&lt;string&gt;&gt;.</returns>
	[Information(nameof(DeleteFiles), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
	public static SimpleResult<ReadOnlyCollection<string>> DeleteFiles([NotNull] this ReadOnlyCollection<string> files, bool stopOnFirstError = false)
	{
		//TODO: ADD TO BENCHMARKING TESTS. THEN TRY OPTIMIZE.

		files = files.ArgumentNotNull();

		var result = new SimpleResult<ReadOnlyCollection<string>>();
		var filesDeleted = new ConcurrentBag<string>();

		foreach (var fileName in files)
		{
			try
			{
				if (File.Exists(fileName))
				{
					File.Delete(fileName);

					filesDeleted.Add(fileName);
				}
			}
			catch (Exception ex) when (ex is ArgumentException or
			  ArgumentNullException or
			  System.IO.DirectoryNotFoundException or
			  IOException or
			  NotSupportedException or
			  PathTooLongException or
			  UnauthorizedAccessException)
			{
				result.AddException(ex);

				if (stopOnFirstError)
				{
					break;
				}
			}
		}

		result.SetValue(new ReadOnlyCollection<string>(filesDeleted.ToList()));

		return result;
	}

	/// <summary>
	/// Downloads a file from a web URL and unzips it into the specified destination directory as an asynchronous operation.
	/// </summary>
	/// <param name="remoteUri">The remote file URL.</param>
	/// <param name="destination">The local directory where the file will be unzipped.</param>
	/// <returns>A task that represents the asynchronous download and unzip operation.</returns>
	/// <example>
	/// Here is how you can use the <see cref="DownloadFileFromWebAndUnzipAsync"/> method:
	/// <code>
	/// var remoteFileUrl = new Uri("http://example.com/file.zip");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.DownloadFileFromWebAndUnzipAsync(remoteFileUrl, destinationDir);
	/// </code>
	/// </example>
	[Information(nameof(DownloadFileFromWebAndUnzipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static async Task DownloadFileFromWebAndUnzipAsync([NotNull] Uri remoteUri, [NotNull] DirectoryInfo destination)
	{
		_ = destination.ArgumentNotNull().CheckExists();

		var tempDownloadPath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}{Path.GetExtension(remoteUri.ToString())}");

		await DownloadFileFromWebAsync(remoteUri, destination).ConfigureAwait(false);

		await UnZipAsync(new FileInfo(tempDownloadPath), destination, true).ConfigureAwait(false);
	}

	/// <summary>
	/// Downloads file from web URL as an asynchronous operation.
	/// Creates the <paramref name="destination" /> if it does not exist.
	/// </summary>
	/// <param name="remoteUri">The remote file URL.</param>
	/// <param name="destination">The local file file.</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	/// <example>
	/// Here is how you can use the <see cref="DownloadFileFromWebAsync"/> method:
	/// <code>
	/// var remoteFileUrl = new Uri("http://example.com/file.zip");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.DownloadFileFromWebAsync(remoteFileUrl, destinationDir);
	/// </code>
	/// </example>
	[Information(nameof(DownloadFileFromWebAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static async Task DownloadFileFromWebAsync([NotNull] Uri remoteUri, [NotNull] DirectoryInfo destination)
	{
		remoteUri = remoteUri.ArgumentNotNull();

		if (destination.ArgumentNotNull().Exists is false)
		{
			destination.Create();
		}

		var pathName = destination.FullName;

		using (var client = GetHttpClient())
		{
			using (var localStream = File.Create(pathName))
			{
				using (var stream = await client.GetStreamAsync(remoteUri, CancellationToken.None).ConfigureAwait(false))
				{
					await stream.CopyToAsync(localStream, CancellationToken.None).ConfigureAwait(false);
				}

				await localStream.FlushAsync(CancellationToken.None).ConfigureAwait(false);
			}
		}
	}

	/// <summary>
	/// Checks if the file name contains any invalid characters.
	/// </summary>
	/// <param name="file">The file to check.</param>
	/// <returns><c>true</c> if the file name contains invalid characters; otherwise, <c>false</c>.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool FileHasInvalidChars([NotNull] FileInfo file) => file.CheckExists() && file.ArgumentNotNull().FullName.IndexOfAny([.. InvalidFileNameChars]) != -1;

	/// <summary>
	/// Moves the file with retries and options.
	/// </summary>
	/// <param name="file">Name of the source file.</param>
	/// <param name="destinationFile">Name of the destination file.</param>
	/// <param name="fileMoveOptions">The file move options.</param>
	/// <param name="retryCount">The retry count.</param>
	/// <returns><c>true</c> if the file was moved successfully; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the <see cref="MoveFile"/> method:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/source/file.txt");
	/// var destinationFile = new FileInfo("path/to/destination/file.txt");
	/// bool result = FileHelper.MoveFile(sourceFile, destinationFile, FileMoveOptions.ReplaceExisting, 3);
	/// Console.WriteLine($"Move result: {result}");
	/// </code>
	/// </example>
	[Information(nameof(MoveFile), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
	public static bool MoveFile([NotNull] FileInfo file, [NotNull] FileInfo destinationFile, FileMoveOptions fileMoveOptions = FileMoveOptions.ReplaceExisting, int retryCount = 1)
	{
		var fileName = file.ArgumentExists().FullName;
		//fileMoveOptions = fileMoveOptions.ArgumentDefined();
		retryCount = retryCount.EnsureMinimum(1);

		for (var retryIndex = 0; retryIndex < Retries; retryIndex++)
		{
			try
			{
				return LibraryImport.MoveFileExW(fileName, destinationFile.FullName, (int)fileMoveOptions);
			}
			catch (IOException) when (retryIndex < retryCount - 1)
			{
				//RETRY
			}
			catch (UnauthorizedAccessException) when (retryIndex < retryCount - 1)
			{
				//RETRY
			}

			// If something has a transient lock on the file waiting may resolve the issue
			Thread.Sleep((retryIndex + 1) * 10);
		}

		return false;
	}

	/// <summary>
	/// Decompresses a GZip (.gz) file into the specified destination directory as an asynchronous operation.
	/// </summary>
	/// <param name="source">The source GZip file.</param>
	/// <param name="destination">The destination directory where the decompressed files will be placed.</param>
	/// <returns>A task that represents the asynchronous decompression operation.</returns>
	/// <example>
	/// Here is how you can use the UnGZipAsync method:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/your/file.gz");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.UnGZipAsync(sourceFile, destinationDir);
	/// </code>
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnGZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async Task UnGZipAsync([NotNull] FileInfo source, [NotNull] DirectoryInfo destination)
	{
		source = source.ArgumentExists();

		if (destination.ArgumentNotNull().Exists is false)
		{
			destination.Create();
		}

		var destinationPath = destination.FullName;

		using (var gzipStream = source.OpenRead())
		{
			using (var expandedStream = new GZipStream(gzipStream, CompressionMode.Decompress))
			{
				using (var targetFileStream = File.OpenWrite(destinationPath))
				{
					await expandedStream.CopyToAsync(targetFileStream).ConfigureAwait(false);
				}
			}
		}
	}

	/// <summary>
	/// Decompresses a GZip (.gz) file into the specified destination directory and optionally deletes the GZip file afterwards as an asynchronous operation.
	/// </summary>
	/// <param name="file">The GZip file to decompress.</param>
	/// <param name="destination">The destination directory where the decompressed files will be placed.</param>
	/// <param name="deleteGZipFile">if set to <c>true</c>, the GZip file will be deleted after decompression.</param>
	/// <returns>A task that represents the asynchronous decompression operation.</returns>
	/// <example>
	/// Here is how you can use the UnGZipAsync method:
	/// <code>
	/// var gzipFile = new FileInfo("path/to/your/file.gz");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.UnGZipAsync(gzipFile, destinationDir, true);
	/// </code>
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnGZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async Task UnGZipAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination, bool deleteGZipFile)
	{
		var fileName = new FileInfo(file.ArgumentExists().FullName);

		_ = destination.ArgumentNotNull().CheckExists();

		await UnGZipAsync(fileName, destination).ConfigureAwait(false);

		if (deleteGZipFile)
		{
			file.Delete();
		}
	}

	/// <summary>
	/// Unzips the specified ZIP file into the given destination directory as an asynchronous operation.
	/// </summary>
	/// <param name="file">The ZIP file to unzip.</param>
	/// <param name="destination">The destination directory where the unzipped files will be placed.</param>
	/// <returns>A task that represents the asynchronous unzip operation.</returns>
	/// <example>
	/// Here is how you can use the UnZipAsync method:
	/// <code>
	/// var zipFile = new FileInfo("path/to/your/file.zip");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.UnZipAsync(zipFile, destinationDir);
	/// </code>
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async Task UnZipAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination)
	{
		var fileName = file.ArgumentExists().FullName;

		_ = destination.ArgumentNotNull().CheckExists();

		await UnWinZipAsync(fileName, destination.FullName).ConfigureAwait(false);
	}

	/// <summary>
	/// Unzips the specified ZIP file into the given destination directory and optionally deletes the ZIP file afterwards as an asynchronous operation.
	/// </summary>
	/// <param name="file">The ZIP file to unzip.</param>
	/// <param name="destination">The destination directory where the unzipped files will be placed.</param>
	/// <param name="deleteZipFile">if set to <c>true</c>, the ZIP file will be deleted after unzipping.</param>
	/// <returns>A task that represents the asynchronous unzip operation.</returns>
	/// <example>
	/// Here is how you can use the UnZipAsync method:
	/// <code>
	/// var zipFile = new FileInfo("path/to/your/file.zip");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await UnZipAsync(zipFile, destinationDir, true);
	/// </code>
	/// </example>
	[Information(nameof(UnZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async Task UnZipAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination, bool deleteZipFile)
	{
		file = file.ArgumentExists();
		_ = destination.ArgumentNotNull().CheckExists();

		await UnZipAsync(file, destination).ConfigureAwait(false);

		if (deleteZipFile)
		{
			file.Delete();
		}
	}

	/// <summary>
	/// Gets a read-only collection of characters that are not allowed in file names, excluding
	/// the directory separator and alternate directory separator characters.
	/// </summary>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static ReadOnlyCollection<char> InvalidFileNameChars { get; } = Path.GetInvalidFileNameChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToReadOnlyCollection();

}
