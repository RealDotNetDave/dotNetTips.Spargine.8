// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
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
using System.Net;
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
[SupportedOSPlatform("windows")]
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
	/// Represents the method that will be called by a file copy operation to provide progress updates.
	/// </summary>
	/// <param name="totalFileSize">The total size of the file being copied.</param>
	/// <param name="totalBytesTransferred">The total number of bytes transferred so far.</param>
	/// <param name="streamSize">The size of the current stream being copied. This parameter can be zero if not applicable.</param>
	/// <param name="streamBytesTransferred">The number of bytes transferred for the current stream. This parameter can be zero if not applicable.</param>
	/// <param name="dwStreamNumber">The number of the current stream. The first stream is 1.</param>
	/// <param name="dwCallbackReason">The reason the callback was called. See <see cref="CopyProgressCallbackReason"/> for possible values.</param>
	/// <param name="hSourceFile">A handle to the source file. This is an IntPtr and does not have a direct <see cref="FileInfo"/> equivalent.</param>
	/// <param name="hDestinationFile">A handle to the destination file. This is an IntPtr and does not have a direct <see cref="FileInfo"/> equivalent.</param>
	/// <param name="lpData">A pointer to application-defined data passed to the callback function. This is an IntPtr and does not have a direct .NET equivalent.</param>
	/// <returns>A <see cref="CopyProgressResult"/> value that determines the action to take.</returns>
	public delegate CopyProgressResult CopyProgressRoutine(long totalFileSize, long totalBytesTransferred, long streamSize, long streamBytesTransferred, uint dwStreamNumber, CopyProgressCallbackReason dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

	/// <summary>
	/// Retrieves a singleton instance of <see cref="HttpClient"/> for use in file operations.
	/// </summary>
	/// <returns>A singleton instance of <see cref="HttpClient"/>.</returns>
	/// <remarks>
	/// This method ensures that a single instance of <see cref="HttpClient"/> is reused across the application,
	/// which is a recommended practice for efficient network resource utilization.
	/// </remarks>
	private static HttpClient GetHttpClient()
	{
		_httpClient ??= new HttpClient();

		return _httpClient;
	}

	/// <summary>
	/// Asynchronously extracts the contents of a Windows compressed (zipped) folder to the specified directory.
	/// </summary>
	/// <param name="zipPath">The path to the zip file. Must not be null or empty.</param>
	/// <param name="expandedDirectoryPath">The path to the directory where the contents of the zip file will be extracted. Must not be null or empty.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="zipPath"/> or <paramref name="expandedDirectoryPath"/> is null or empty.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the zip file specified by <paramref name="zipPath"/> does not exist.</exception>
	/// <remarks>
	/// This method uses <see cref="ZipFile.ExtractToDirectory(string, string)"/> under the hood to perform the extraction.
	/// Make sure to call .Dispose on Task
	/// </remarks>
	[Information(nameof(UnWinZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	private static async Task UnWinZipAsync([NotNull] string zipPath, [NotNull] string expandedDirectoryPath)
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
	/// Checks if the specified file has the given permission for the current user.
	/// </summary>
	/// <param name="file">The file to check permissions on. Must not be null.</param>
	/// <param name="permission">The permission to check. Defaults to <see cref="FileSystemRights.Read"/>.</param>
	/// <returns><c>true</c> if the current user has the specified permission on the file; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> is null.</exception>
	/// <remarks>
	/// This method uses the <see cref="FileSecurity"/> class to check permissions and is intended for use on Windows platforms only.
	/// </remarks>
	/// <example>
	/// Here is how you can use the <see cref="CheckPermission"/> method:
	/// <code>
	/// var fileInfo = new FileInfo("path/to/your/file.txt");
	/// var hasReadPermission = FileHelper.CheckPermission(fileInfo, FileSystemRights.Read);
	/// Console.WriteLine($"Has read permission: {hasReadPermission}");
	/// </code>
	/// </example>
	[Information(nameof(CheckPermission), author: "David McCarter", createdOn: "6/17/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
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
	/// Copies a specified file to a new location.
	/// </summary>
	/// <param name="file">The source <see cref="FileInfo"/> object representing the file to copy. Must not be null.</param>
	/// <param name="destination">The destination <see cref="DirectoryInfo"/> where the file should be copied to. Must not be null.</param>
	/// <returns>The size of the copied file in bytes.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the source file does not exist.</exception>
	/// <exception cref="IOException">Thrown if an I/O error occurs during copying.</exception>
	/// <example>
	/// Here is how you can use the CopyFile method:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/source/file.txt");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// var fileLength = FileHelper.CopyFile(sourceFile, destinationDir);
	/// Console.WriteLine($"Copied file length: {fileLength}");
	/// </code>
	/// </example>
	[Information(nameof(CopyFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
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
	/// Copies a specified file to a new location with progress reporting.
	/// </summary>
	/// <param name="file">The source <see cref="FileInfo"/> object representing the file to copy. Must not be null.</param>
	/// <param name="destination">The destination <see cref="DirectoryInfo"/> where the file should be copied to. Must not be null.</param>
	/// <param name="progressCallback">The <see cref="CopyProgressRoutine"/> callback for reporting progress. Must not be null.</param>
	/// <returns><c>true</c> if the file was successfully copied; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/>, <paramref name="destination"/>, or <paramref name="progressCallback"/> is null.</exception>
	/// <exception cref="IOException">Thrown if an I/O error occurs during copying.</exception>
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
	[Information(nameof(CopyFile), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
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
	/// Asynchronously copies a specified file to a new location.
	/// </summary>
	/// <param name="file">The source <see cref="FileInfo"/> object representing the file to copy. Must not be null.</param>
	/// <param name="destination">The destination <see cref="DirectoryInfo"/> where the file should be copied to. Must not be null.</param>
	/// <returns>A Task{long} representing the asynchronous operation that completes with the size of the copied file in bytes.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the source file does not exist.</exception>
	/// <exception cref="IOException">Thrown if an I/O error occurs during copying.</exception>
	/// <example>
	/// Here is how you can use the <see cref="CopyFileAsync"/> method:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/source/file.txt");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// var fileLength = await FileHelper.CopyFileAsync(sourceFile, destinationDir);
	/// Console.WriteLine($"Copied file length: {fileLength}");
	/// </code>
	/// </example>
	[Information(nameof(CopyFileAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://dotnettips.wordpress.com/2020/11/17/coding-faster-with-the-dotnettips-utility-november-2020-update")]
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
	/// Deletes a collection of files.
	/// </summary>
	/// <param name="files">A read-only collection of file paths to delete. Must not be null.</param>
	/// <param name="stopOnFirstError">Specifies whether to stop deleting files upon encountering the first error.</param>
	/// <returns>A <see cref="SimpleResult{T}"/> containing a read-only collection of the paths of files that were successfully deleted.</returns>
	/// <remarks>
	/// This method attempts to delete each file specified in <paramref name="files"/>. If <paramref name="stopOnFirstError"/> is <c>false</c>,
	/// it will continue to attempt to delete the remaining files even if an error occurs. The result will contain the list of files that were
	/// successfully deleted and any error information.
	/// </remarks>
	[Information(nameof(DeleteFiles), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
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
	/// Downloads a file from the web and unzips it to the specified destination directory.
	/// </summary>
	/// <param name="remoteUri">The <see cref="Uri"/> of the remote file to download. Must not be null.</param>
	/// <param name="destination">The <see cref="DirectoryInfo"/> representing the destination directory where the unzipped files will be stored. Must not be null.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="remoteUri"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="WebException">Thrown if an error occurs during the download.</exception>
	/// <exception cref="IOException">Thrown if an error occurs while unzipping the file.</exception>
	/// <example>
	/// Here is how you can use the <see cref="DownloadFileFromWebAndUnzipAsync"/> method:
	/// <code>
	/// var remoteFileUrl = new Uri("http://example.com/file.zip");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.DownloadFileFromWebAndUnzipAsync(remoteFileUrl, destinationDir);
	/// </code>
	/// </example>
	[Information(nameof(DownloadFileFromWebAndUnzipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static async Task DownloadFileFromWebAndUnzipAsync([NotNull] Uri remoteUri, [NotNull] DirectoryInfo destination)
	{
		_ = destination.ArgumentNotNull().CheckExists();

		var tempDownloadPath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}{Path.GetExtension(remoteUri.ToString())}");

		await DownloadFileFromWebAsync(remoteUri, destination).ConfigureAwait(false);

		await UnZipAsync(new FileInfo(tempDownloadPath), destination, true).ConfigureAwait(false);
	}

	/// <summary>
	/// Asynchronously downloads a file from the specified <see cref="Uri"/> and saves it to the given destination directory.
	/// </summary>
	/// <param name="remoteUri">The <see cref="Uri"/> of the remote file to download. Must not be null.</param>
	/// <param name="destination">The <see cref="DirectoryInfo"/> representing the destination directory where the downloaded file will be saved. Must not be null.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous download operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="remoteUri"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="WebException">Thrown if an error occurs during the download.</exception>
	/// <exception cref="IOException">Thrown if an error occurs while saving the file.</exception>
	/// <example>
	/// Here is how you can use the <see cref="DownloadFileFromWebAsync"/> method:
	/// <code>
	/// var remoteFileUrl = new Uri("http://example.com/file.zip");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.DownloadFileFromWebAsync(remoteFileUrl, destinationDir);
	/// </code>
	/// </example>
	[Information(nameof(DownloadFileFromWebAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
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
	/// Checks if the specified file contains any invalid characters in its name.
	/// </summary>
	/// <param name="file">The <see cref="FileInfo"/> object representing the file to check. Must not be null.</param>
	/// <returns><c>true</c> if the file name contains any invalid characters; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method utilizes FileInfo.FullName to retrieve the file's full name and checks it against a list of invalid characters obtained from FileHelper.InvalidFileNameChars.
	/// </remarks>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool FileHasInvalidChars([NotNull] FileInfo file) => file.CheckExists() && file.ArgumentNotNull().FullName.IndexOfAny([.. InvalidFileNameChars]) != -1;

	/// <summary>
	/// Moves a file to a new location, optionally replacing the destination file and with retry logic.
	/// </summary>
	/// <param name="file">The source <see cref="FileInfo"/> object representing the file to move. Must not be null.</param>
	/// <param name="destinationFile">The destination <see cref="FileInfo"/> object representing the target file location. Must not be null.</param>
	/// <param name="fileMoveOptions">Specifies the behavior for moving the file, such as whether to overwrite an existing file at the destination. See <see cref="FileMoveOptions"/> for options.</param>
	/// <param name="retryCount">The number of times to retry the move operation in case of failure. Must be a non-negative number.</param>
	/// <returns><c>true</c> if the file was successfully moved; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="destinationFile"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the source file does not exist.</exception>
	/// <exception cref="IOException">Thrown if an error occurs during the move operation or if the destination file exists and <paramref name="fileMoveOptions"/> is not set to <see cref="FileMoveOptions.ReplaceExisting"/>.</exception>
	/// <example>
	/// Here is how you can use the <see cref="MoveFile"/> method:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/source/file.txt");
	/// var destinationFile = new FileInfo("path/to/destination/file.txt");
	/// bool result = FileHelper.MoveFile(sourceFile, destinationFile, FileMoveOptions.ReplaceExisting, 3);
	/// Console.WriteLine($"Move result: {result}");
	/// </code>
	/// </example>
	[Information(nameof(MoveFile), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2024")]
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
	/// Asynchronously decompresses a GZip (.gz) file to the specified destination directory.
	/// </summary>
	/// <param name="source">The source <see cref="FileInfo"/> representing the GZip file to decompress. Must not be null.</param>
	/// <param name="destination">The destination <see cref="DirectoryInfo"/> where the decompressed files will be stored. Must not be null.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous decompression operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the source file does not exist.</exception>
	/// <exception cref="IOException">Thrown if an error occurs during decompression.</exception>
	/// <example>
	/// Here is how you can use the UnGZipAsync method:
	/// <code>
	/// var sourceFile = new FileInfo("path/to/your/file.gz");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.UnGZipAsync(sourceFile, destinationDir);
	/// </code>
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnGZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
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
	/// Asynchronously decompresses a GZip (.gz) file to the specified destination directory and optionally deletes the GZip file after decompression.
	/// </summary>
	/// <param name="file">The source <see cref="FileInfo"/> representing the GZip file to decompress. Must not be null.</param>
	/// <param name="destination">The destination <see cref="DirectoryInfo"/> where the decompressed files will be stored. Must not be null.</param>
	/// <param name="deleteGZipFile">Specifies whether to delete the GZip file after decompression.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous decompression operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the source file does not exist.</exception>
	/// <exception cref="IOException">Thrown if an error occurs during decompression.</exception>
	/// <example>
	/// Here is how you can use the UnGZipAsync method:
	/// <code>
	/// var gzipFile = new FileInfo("path/to/your/file.gz");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.UnGZipAsync(gzipFile, destinationDir, true);
	/// </code>
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnGZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
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
	/// Asynchronously unzips a specified zip file to the given destination directory.
	/// </summary>
	/// <param name="file">The <see cref="FileInfo"/> representing the zip file to decompress. Must not be null.</param>
	/// <param name="destination">The <see cref="DirectoryInfo"/> representing the destination directory where the unzipped files will be stored. Must not be null.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous decompression operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the zip file does not exist.</exception>
	/// <exception cref="IOException">Thrown if an error occurs during decompression.</exception>
	/// <example>
	/// Here is how you can use the UnZipAsync method:
	/// <code>
	/// var zipFile = new FileInfo("path/to/your/file.zip");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await FileHelper.UnZipAsync(zipFile, destinationDir);
	/// </code>
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static async Task UnZipAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination)
	{
		var fileName = file.ArgumentExists().FullName;

		_ = destination.ArgumentNotNull().CheckExists();

		await UnWinZipAsync(fileName, destination.FullName).ConfigureAwait(false);
	}

	/// <summary>
	/// Asynchronously unzips a specified zip file to the given destination directory and optionally deletes the zip file after decompression.
	/// </summary>
	/// <param name="file">The <see cref="FileInfo"/> representing the zip file to decompress. Must not be null.</param>
	/// <param name="destination">The <see cref="DirectoryInfo"/> representing the destination directory where the unzipped files will be stored. Must not be null.</param>
	/// <param name="deleteZipFile">Specifies whether to delete the zip file after decompression.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous decompression operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the zip file does not exist.</exception>
	/// <exception cref="IOException">Thrown if an error occurs during decompression.</exception>
	/// <example>
	/// Here is how you can use the UnZipAsync method:
	/// <code>
	/// var zipFile = new FileInfo("path/to/your/file.zip");
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// await UnZipAsync(zipFile, destinationDir, true);
	/// </code>
	/// </example>
	[Information(nameof(UnZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
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
	/// Gets a read-only collection of characters that are not allowed in file names, excluding directory separator characters.
	/// </summary>
	/// <value>A <see cref="ReadOnlyCollection{T}"/> of type <see cref="char"/> that contains the characters not allowed in file names.</value>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<char> InvalidFileNameChars { get; } = Path.GetInvalidFileNameChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToReadOnlyCollection();

}
