// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 09-02-2024
// ***********************************************************************
// <copyright file="TempFileManager.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>TempFileManager creates and maintains a list of temporary files.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Extensions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// TempFileManager creates and maintains a list of temporary files. Implements the <see cref="IDisposable" />.
/// </summary>
/// <seealso cref="IDisposable" />
[Information(nameof(TempFileManager), "David McCarter", "8/4/2024", Status = Status.New)]
public class TempFileManager : IDisposable
{

	/// <summary>
	/// Indicates whether the object has been disposed.
	/// </summary>
	private bool _disposed;

	/// <summary>
	/// The list of temporary files managed by this instance.
	/// </summary>
	private readonly List<string> _files = [];

	/// <summary>
	/// Lock object for thread safety.
	/// </summary>
	private readonly object _lock = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="TempFileManager" /> class.
	/// </summary>
	public TempFileManager()
	{
	}

	/// <summary>
	/// Generates a random temporary file.
	/// </summary>
	/// <returns>The path of the created temporary file.</returns>
	private static string GenerateRandomFile()
	{
		var tempFileName = $"{UlidGenerator.GenerateUlid()}.dntt";
		var tempFilePath = Path.Combine(Path.GetTempPath(), tempFileName);

		// Create the file to ensure it exists
		using (File.Create(tempFilePath))
		{ }

		return tempFilePath;
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!this._disposed)
		{
			// If disposing equals true, dispose all managed and unmanaged resources.
			if (disposing)
			{
				// Dispose managed resources.
				this.DeleteAllFiles();
			}
		}

		this._disposed = true;
	}

	/// <summary>
	/// Creates a new temporary file.
	/// </summary>
	/// <returns>The path of the created temporary file.</returns>
	[Information("Creates a new temporary file.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public string CreateFile()
	{
		var tempFile = GenerateRandomFile();

		lock (this._lock)
		{
			this._files.Add(tempFile);
		}

		return tempFile;
	}

	/// <summary>
	/// Creates multiple temp files.
	/// </summary>
	/// <param name="count">The number of temporary files to create.</param>
	/// <returns>A read-only collection of the paths of the created temporary files.</returns>
	[Information("Creates multiple temp files.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public ReadOnlyCollection<string> CreateFiles(int count)
	{
		count = count.ArgumentInRange(1);
		var files = new List<string>(count);

		for (var fileCount = 0; fileCount < count; fileCount++)
		{
			files.Add(GenerateRandomFile());
		}

		lock (this._lock)
		{
			this._files.AddRange(files);
		}

		return files.ToReadOnlyCollection();
	}

	/// <summary>
	/// Deletes all temporary files.
	/// </summary>
	[Information("Deletes all temporary files.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public void DeleteAllFiles()
	{
		lock (this._lock)
		{
			if (this._files.HasItems())
			{
				foreach (var fileName in this._files.ToList())
				{
					this.DeleteFile(fileName);
				}
			}
		}
	}

	/// <summary>
	/// Deletes a temporary file.
	/// </summary>
	/// <param name="file">The file.</param>
	[Information("Deletes a temporary file.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public void DeleteFile(string file)
	{
		if (file.IsNullOrEmpty())
		{
			return;
		}

		if (File.Exists(file))
		{
			File.Delete(file);
		}

		lock (this._lock)
		{
			_ = this._files.Remove(file);
		}
	}

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	[Information("Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.", UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Gets the list of files currently being managed.
	/// </summary>
	/// <returns>A read-only collection of the paths of the managed temporary files.</returns>
	[Information("Gets the list of files currently being managed.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public IReadOnlyCollection<string> GetManagedFiles()
	{
		lock (this._lock)
		{
			return this._files.AsReadOnly();
		}
	}
}
