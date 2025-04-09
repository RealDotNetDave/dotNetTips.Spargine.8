
// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 04-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-09-2025
// ***********************************************************************
// <copyright file="AssemblyHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DotNetTips.Spargine.Core.RegularExpressions;

namespace DotNetTips.Spargine.Core;

[Information(Status = Status.New)]
#nullable enable
public static class AssemblyHelper
{
	/// <summary>
	/// Safely parses a version string, falling back to <c>Version(0,0)</c> if parsing fails.
	/// </summary>
	/// <param name="input">The version string to parse.</param>
	/// <returns>A <see cref="Version"/> object representing the parsed version, or <c>Version(0,0)</c> if parsing fails.</returns>
	/// <remarks>
	/// This method attempts to parse the input string as a version. If the parsing fails, it tries to extract a version-like pattern
	/// using a regular expression and parses that. If all attempts fail, it returns <c>Version(0,0)</c>.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	private static Version VersionParseSafe(string input)
	{
		if (Version.TryParse(input, out var version))
		{
			return version;
		}

		// Try to extract version from things like "1.2.3-preview" or similar
		var extractedVersion = RegexProcessor.ExtractVersion(input);

		if (string.IsNullOrEmpty(extractedVersion) is false)
		{
			return Version.Parse(extractedVersion);
		}

		return new Version(0, 0);
	}

	/// <summary>
	/// Finds all types in the specified assembly file that implement or inherit from any of the specified types.
	/// </summary>
	/// <param name="file">The <see cref="FileInfo"/> representing the assembly file to search.</param>
	/// <param name="typeNames">An array of <see cref="Type"/> objects to check for implementation or inheritance.</param>
	/// <returns>A read-only collection of <see cref="Type"/> objects that implement or inherit from the specified types.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="typeNames"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the specified assembly file does not exist.</exception>
	[Information(nameof(FindTypesImplementing), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static ReadOnlyCollection<Type> FindTypesImplementing([NotNull] this FileInfo file, params Type[] typeNames)
	{
		file = file.ArgumentNotNull();
		typeNames = typeNames.ArgumentNotNull();
		var matchingTypes = new List<Type>();

		//Load all types
		var types = LoadAssemblyTypes(file);

		foreach (var type in types)
		{
			foreach (var targetType in typeNames)
			{
				// Check if the type implements or inherits from the target type
				if (targetType.IsAssignableFrom(type) && type != targetType)
				{
					matchingTypes.Add(type);
					break; // No need to check further once a match is found
				}
			}
		}

		return new ReadOnlyCollection<Type>(matchingTypes);
	}

	/// <summary>
	/// Finds .NET SDK files in the specified version or the highest available version.
	/// </summary>
	/// <param name="version">The specific version to search for. If null, the highest version is used.</param>
	/// <returns>A <see cref="ReadOnlyCollection{FileInfo}"/> containing .NET SDK file information.</returns>
	/// <remarks>
	/// This method searches the .NET SDK packs directory for the specified version or the highest available version.
	/// It retrieves DLL files from the "ref" folder of the selected version and target framework.
	/// </remarks>
	/// <exception cref="DirectoryNotFoundException">Thrown if the .NET packs directory does not exist.</exception>
	[Information(nameof(GetNetSdkDllFiles), "David McCarter", "4/9/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static ReadOnlyCollection<FileInfo> GetNetSdkDllFiles(string? version = null)
	{
		var root = Environment.GetEnvironmentVariable("DOTNET_ROOT");

		if (string.IsNullOrEmpty(root))
		{
			throw new DirectoryNotFoundException("The DOTNET_ROOT environment variable is not set or is empty.");
		}

		var dotnetPacksPath = new DirectoryInfo(Path.Combine(root, "packs"));

		var dllFiles = new List<FileInfo>();

		if (!dotnetPacksPath.Exists)
		{
			Trace.WriteLine("The .NET packs path does not exist.");
			return new ReadOnlyCollection<FileInfo>(dllFiles);
		}

		var packDirectories = dotnetPacksPath.GetDirectories();

		foreach (var packDir in packDirectories)
		{
			var versionDirs = packDir.GetDirectories()
									 .Select(dir => dir.Name)
									 .Where(name => !string.IsNullOrWhiteSpace(name))
									 .OrderByDescending(VersionParseSafe)
									 .ToList();

			var versionToUse = version;

			// If no specific version is provided, use the highest one
			if (string.IsNullOrWhiteSpace(versionToUse))
			{
				versionToUse = versionDirs.FirstOrDefault();
			}

			if (!string.IsNullOrWhiteSpace(versionToUse))
			{
				var refPath = new DirectoryInfo(Path.Combine(packDir.FullName, versionToUse, "ref"));
				if (refPath.Exists)
				{
					var targetFrameworks = refPath.GetDirectories();

					// Use highest versioned target framework (e.g., net8.0 over net7.0)
					var selectedTf = targetFrameworks
						.OrderByDescending(dir => dir.Name)
						.FirstOrDefault();

					if (selectedTf != null)
					{
						// Get all DLL files in the "ref" folder of the selected version and target framework
						var dllPaths = selectedTf.GetFiles("*.dll", SearchOption.AllDirectories);

						foreach (var dllPath in dllPaths.Where(TypeHelper.IsDotNetAssembly))
						{
							dllFiles.Add(dllPath);
						}
					}
				}
			}
		}

		return new ReadOnlyCollection<FileInfo>(dllFiles);
	}


	/// <summary>
	/// Loads the assembly from the specified file and extracts all types within it.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file to load.</param>
	/// <returns>A collection of <see cref="Type"/> objects representing all types in the assembly.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assemblyFile"/> is null.</exception>
	[Information(nameof(LoadAssemblyTypes), "David McCarter", "4/9/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static ReadOnlyCollection<Type> LoadAssemblyTypes(FileInfo assemblyFile)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);

		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);
			return assembly.GetTypes().AsReadOnly();
		}
		catch (ReflectionTypeLoadException ex)
		{
			// Return the types that were successfully loaded and log the loader exceptions if needed.
			Trace.WriteLine($"Failed to load some types from assembly: {assemblyFile.FullName}");

			foreach (var loaderException in ex.LoaderExceptions)
			{
				Trace.WriteLine(loaderException?.Message);
			}

			return ex.Types.Where(type => type != null).Select(type => type!).ToList().AsReadOnly();
		}
		catch (BadImageFormatException ex)
		{
			// Log the exception and rethrow it
			Trace.WriteLine($"BadImageFormatException: The file is not a valid .NET assembly: {assemblyFile.FullName}");
			Trace.WriteLine(ex.Message);

			return Array.Empty<Type>().ToList().AsReadOnly();
		}
		catch (FileLoadException ex)
		{
			// Log the exception and return an empty collection
			Trace.WriteLine($"FileLoadException: The assembly file could not be loaded: {assemblyFile.FullName}");
			Trace.WriteLine(ex.Message);

			return Array.Empty<Type>().ToList().AsReadOnly();
		}
	}

}
