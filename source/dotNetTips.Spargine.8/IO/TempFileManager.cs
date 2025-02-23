// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2025
// ***********************************************************************
// <copyright file="TempFileManager.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>TempFileManager creates and maintains a list of temporary files.</summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// TempFileManager creates and maintains a list of temporary files. Implements the <see cref="IDisposable" />.
/// </summary>
/// <seealso cref="IDisposable" />
/// <remarks>
/// Initializes a new instance of the <see cref="TempFileManager" /> class.
/// </remarks>
[SupportedOSPlatform("windows")]
[Information(nameof(TempFileManager), "David McCarter", "8/4/2024", Status = Status.NeedsDocumentation)]
[method: ExcludeFromCodeCoverage]
public class TempFileManager() : IDisposable, IAsyncDisposable
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
	/// Finalizes an instance of the <see cref="TempFileManager"/> class.
	/// </summary>
	~TempFileManager()
	{
		this.Dispose(false);
	}

	/// <summary>
	/// Asynchronously performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	/// <returns>A task that represents the asynchronous dispose operation.</returns>
	[Information(nameof(IAsyncDisposable.DisposeAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	async ValueTask IAsyncDisposable.DisposeAsync()
	{
		await Task.Run(() => this.Dispose(true)).ConfigureAwait(false);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Generates a random temporary file.
	/// </summary>
	/// <returns>The path of the created temporary file.</returns>
	private static string GenerateRandomFile()
	{
		var tempFilePath = Path.Combine(Path.GetTempPath(), $"{UlidGenerator.GenerateUlid()}.dntt");

		try
		{
			// Create the file to ensure it exists
			File.Create(tempFilePath).Dispose();
		}
		catch (Exception ex)
		{
			// Log or handle the exception as needed
			ExceptionThrower.ThrowIOException(Resources.FailedToCreateTemporaryFile, ex);
		}

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
	[Information(nameof(CreateFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string CreateFile()
	{
		var file = GenerateRandomFile();
		this._files.Add(file);

		// Set to temporary file
		FileHelper.AddAttributes(new FileInfo(file), FileAttributes.Temporary);

		return file;
	}

	/// <summary>
	/// Creates multiple temp files.
	/// </summary>
	/// <param name="count">The number of temporary files to create.</param>
	/// <returns>A read-only collection of the paths of the created temporary files.</returns>
	[Information(nameof(CreateFiles), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
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

		return files.ToReadOnlyCollection();
	}

	/// <summary>
	/// Deletes all temporary files.
	/// </summary>
	[SupportedOSPlatform("windows")]
	[Information(nameof(DeleteAllFiles), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void DeleteAllFiles()
	{
		_ = FileHelper.DeleteFiles(this._files.ToReadOnlyCollection());
		this._files.Clear();
	}

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	[Preserve(PreserveReason.MethodPartOfIDisposable, "2/12/2025", "David McCarter")]
	[Information(nameof(Dispose), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Gets the list of files currently being managed.
	/// </summary>
	/// <returns>A read-only collection of the paths of the managed temporary files.</returns>
	[Information(nameof(GetManagedFiles), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public IReadOnlyCollection<string> GetManagedFiles() => this._files.ToReadOnlyCollection();
}
