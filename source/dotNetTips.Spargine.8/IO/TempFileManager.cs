// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-08-2025
// ***********************************************************************
// <copyright file="TempFileManager.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// TempFileManager creates and maintains a list of temporary files.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
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
[Information(nameof(TempFileManager), "David McCarter", "8/4/2024", Status = Status.NeedsDocumentation)]
public class TempFileManager : IDisposable
{

	/// <summary>
	/// Indicates whether the object has been disposed.
	/// </summary>
	private bool _disposed;

	/// <summary>
	/// The list of temporary files managed by this instance.
	/// </summary>
	private readonly ConcurrentBag<string> _files = [];

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
	[Information("Creates a new temporary file.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string CreateFile()
	{
		var file = GenerateRandomFile();
		this._files.Add(file);

		return file;
	}

	/// <summary>
	/// Creates multiple temp files.
	/// </summary>
	/// <param name="count">The number of temporary files to create.</param>
	/// <returns>A read-only collection of the paths of the created temporary files.</returns>
	[Information("Creates multiple temp files.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ReadOnlyCollection<string> CreateFiles(int count)
	{
		count = count.ArgumentInRange(1);
		var files = new ConcurrentBag<string>();

		_ = Parallel.For(0, count, _ =>
		{
			var file = GenerateRandomFile();
			files.Add(file);
			this._files.Add(file);
		});

		return files.ToList().AsReadOnly();
	}

	/// <summary>
	/// Deletes all temporary files.
	/// </summary>
	[Information("Deletes all temporary files.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void DeleteAllFiles()
	{
		_ = Parallel.ForEach(this._files, DeleteFile);

		while (this._files.TryTake(out _))
		{ }
	}

	/// <summary>
	/// Deletes a temporary file.
	/// </summary>
	/// <param name="file">The file.</param>
	[Information("Deletes a temporary file.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void DeleteFile(string file)
	{
		if (file.IsNullOrEmpty())
		{
			return;
		}

		File.Delete(file);

		_ = _files.TryTake(out _);
	}

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	[Information("Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.", UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Gets the list of files currently being managed.
	/// </summary>
	/// <returns>A read-only collection of the paths of the managed temporary files.</returns>
	[Information("Gets the list of files currently being managed.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public IReadOnlyCollection<string> GetManagedFiles()
	{
		return this._files.ToList().AsReadOnly();
	}
}
