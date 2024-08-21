// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="FileProcessor.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Facilitates file copying and deletion operations,
// incorporating event handling for files. Additionally, it offers the
// capability to delete folders.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Security;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Diagnostics;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Facilitates file copying, deletion, and folder deletion operations. It incorporates event handling to notify about the progress and status of file operations.
/// </summary>
/// <remarks>
/// <para>This class provides methods to copy and delete files and folders with the added capability of event-based notifications for each operation. This allows for real-time monitoring of the process, including success, failure, and progress updates.</para>
/// <para>Events:</para>
/// <list type="bullet">
/// <item>
/// <description><see cref="Processed"/>: Occurs when a file or folder has been processed, providing details such as the operation performed, the name of the file or folder, and the outcome.</description>
/// </item>
/// </list>
/// <para>Usage:</para>
/// <code>
/// var fileProcessor = new FileProcessor();
/// fileProcessor.Processed += (sender, e) => 
/// {
///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
/// };
/// 
/// var filesToCopy = new List&lt;FileInfo&gt; { new FileInfo("path/to/source/file.txt") };
/// var destinationDir = new DirectoryInfo("path/to/destination");
/// fileProcessor.CopyFiles(filesToCopy, destinationDir);
/// </code>
/// </remarks>
public class FileProcessor
{

	/// <summary>
	/// Occurs when a file or folder has been processed.
	/// </summary>
	/// <remarks>
	/// This event can be used to receive notifications about the progress and status of file and folder operations such as copying, deletion, etc.
	/// Each event provides data through <see cref="FileProgressEventArgs"/> which includes details like the operation performed, the name of the file or folder, and the outcome.
	/// </remarks>
	public event EventHandler<FileProgressEventArgs> Processed;

	/// <summary>
	/// Raises the <see cref="Processed"/> event.
	/// </summary>
	/// <param name="e">The <see cref="FileProgressEventArgs"/> instance containing the event data.</param>
	protected virtual void OnProcessed(FileProgressEventArgs e) => this.Processed?.Invoke(this, e);

	/// <summary>
	/// Copies files to a new location. This method will not throw exceptions.
	/// </summary>
	/// <param name="files">The files to copy.</param>
	/// <param name="destination">The destination folder where files will be copied.</param>
	/// <returns>The number of files successfully copied.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if file copy succeeded or failed.
	/// </remarks>
	/// <example>
	/// Here is an example of using the <see cref="CopyFiles"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var filesToCopy = new List&lt;FileInfo&gt; { new FileInfo("path/to/source/file.txt") };
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// fileProcessor.CopyFiles(filesToCopy, destinationDir);
	/// </code>
	/// </example>
	[Information(nameof(CopyFiles), author: "David McCarter", createdOn: "8/6/2017", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public int CopyFiles([NotNull] IEnumerable<FileInfo> files, [NotNull] DirectoryInfo destination)
	{
		var list = files.ArgumentNotNull().ToArray();

		_ = destination.ArgumentNotNull().CheckExists();

		var destinationPath = destination.FullName;

		var successCount = 0;

		for (var fileCount = 0; fileCount < list.Length; fileCount++)
		{
			var tempFile = list[fileCount];

			if (tempFile.Exists)
			{
				try
				{
					var newFileName = new FileInfo(fileName: tempFile.FullName.Replace(tempFile.Directory.Root.FullName, destinationPath, StringComparison.InvariantCulture));

					if (newFileName.Directory.Exists is false)
					{
						newFileName.Directory.Create();
					}

					var psw = PerformanceStopwatch.StartNew();

					_ = tempFile.CopyTo(newFileName.FullName, overwrite: true);

					var perf = psw.StopReset();

					successCount++;

					this.OnProcessed(new FileProgressEventArgs
					{
						Name = tempFile.FullName,
						Message = tempFile.Name,
						ProgressState = FileProgressState.Copied,
						Size = tempFile.Length,
						SpeedInMilliseconds = perf.TotalMilliseconds,
					});
				}
				catch (Exception ex) when (ex is IOException or SecurityException or UnauthorizedAccessException)
				{
					// Send error.
					this.OnProcessed(new FileProgressEventArgs
					{
						Name = tempFile.FullName,
						ProgressState = FileProgressState.Error,
						Size = tempFile.Length,
						Message = ex.Message,
					});
				}
			}
			else
			{
				this.OnProcessed(new FileProgressEventArgs
				{
					Name = tempFile.FullName,
					ProgressState = FileProgressState.Error,
					Size = tempFile.Length,
					Message = Resources.FileNotFound,
				});
			}
		}

		return successCount;
	}

	/// <summary>
	/// Deletes the specified files.
	/// </summary>
	/// <param name="files">The files to delete.</param>
	/// <returns>The number of files successfully deleted.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if file deletion succeeded or failed.
	/// </remarks>
	/// <example>
	/// Here is an example of using the <see cref="DeleteFiles"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var filesToDelete = new List&lt;FileInfo&gt; { new FileInfo("path/to/file/to/delete.txt") };
	/// fileProcessor.DeleteFiles(filesToDelete);
	/// </code>
	/// </example>
	[Information(nameof(DeleteFiles), author: "David McCarter", createdOn: "8/6/2017", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public int DeleteFiles([NotNull] IEnumerable<FileInfo> files)
	{
		if (files.HasItems() is false)
		{
			return 0;
		}

		var successCount = 0;

		foreach (var listItem in files)
		{
			if (listItem.Exists)
			{
				long fileLength = 0;

				try
				{
					var psw = PerformanceStopwatch.StartNew();

					fileLength = listItem.Length;
					listItem.Delete();

					var perf = psw.StopReset();

					successCount++;

					this.OnProcessed(e: new FileProgressEventArgs
					{
						Name = listItem.FullName,
						Message = listItem.Name,
						ProgressState = FileProgressState.Deleted,
						Size = fileLength,
						SpeedInMilliseconds = perf.TotalMilliseconds,
					});
				}
				catch (Exception ex) when (ex is IOException or SecurityException or UnauthorizedAccessException)
				{
					this.OnProcessed(new FileProgressEventArgs
					{
						Name = listItem.FullName,
						ProgressState = FileProgressState.Error,
						Size = fileLength,
						Message = ex.Message,
					});
				}
			}
			else
			{
				this.OnProcessed(new FileProgressEventArgs
				{
					Name = listItem.FullName,
					ProgressState = FileProgressState.Error,
					Message = Resources.FileNotFound,
				});
			}
		}

		return successCount;
	}

	/// <summary>
	/// Deletes the specified folders and all their contents.
	/// </summary>
	/// <param name="folders">The folders to delete.</param>
	/// <returns>The number of folders successfully deleted.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if folder deletion succeeded or failed.
	/// </remarks>
	/// <example>
	/// Here is an example of using the <see cref="DeleteFolders"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var foldersToDelete = new List&lt;DirectoryInfo&gt; { new DirectoryInfo("path/to/folder/to/delete") };
	/// fileProcessor.DeleteFolders(foldersToDelete);
	/// </code>
	/// </example>
	[Information(nameof(DeleteFolders), author: "David McCarter", createdOn: "8/6/2017", UnitTestStatus = UnitTestStatus.None, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public int DeleteFolders([NotNull] IEnumerable<DirectoryInfo> folders)
	{
		if (folders.HasItems() is false)
		{
			return 0;
		}

		var successCount = 0;

		foreach (var listItem in folders)
		{
			if (listItem.Exists)
			{
				try
				{
					listItem.Delete(recursive: true);

					successCount++;

					this.OnProcessed(new FileProgressEventArgs
					{
						Name = listItem.FullName,
						ProgressState = FileProgressState.Deleted,
					});
				}
				catch (Exception ex) when (ex is IOException or SecurityException or UnauthorizedAccessException or System.IO.DirectoryNotFoundException)
				{
					this.OnProcessed(new FileProgressEventArgs
					{
						Name = listItem.FullName,
						ProgressState = FileProgressState.Error,
						Message = ex.Message,
					});
				}
			}
			else
			{
				this.OnProcessed(new FileProgressEventArgs
				{
					Name = listItem.FullName,
					ProgressState = FileProgressState.Error,
					Message = Resources.FolderNotFound,
				});
			}
		}

		return successCount;
	}

}
