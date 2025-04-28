// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 04-28-2025
// ***********************************************************************
// <copyright file="UnitTester.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// The UnitTester class is an abstract base class designed to
// facilitate unit testing by providing utility methods for debugging
// and saving object properties.
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Provides utility methods for debugging and saving object properties.
/// This class is intended to be used as a base class for unit testing scenarios.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="UnitTester"/> class.
/// </remarks>
/// <param name="outputDirectory">The directory where output files will be saved. Defaults to the current directory if not specified.</param>
[ExcludeFromCodeCoverage]
[DebuggerStepThrough]
[Information(Status = Status.NeedsDocumentation, Documentation = "ADD URL")]
public abstract class UnitTester(string outputDirectory = null)
{
	/// <summary>
	/// The directory where output files will be saved.
	/// </summary>
	/// <remarks>
	/// This field is initialized in the constructor and defaults to the current directory
	/// if no specific directory is provided.
	/// </remarks>
	private readonly string _outputDirectory = outputDirectory ?? App.ExecutingFolder();

	/// <summary>
	/// Converts the properties of an object to a string representation based on a selection function.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="input">The object whose properties will be converted to a string.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <returns>A string representation of the selected properties of the object.</returns>
	[Information(nameof(PropertiesToString), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	protected virtual string PropertiesToString<T>(T input, Func<PropertyInfo, bool> propertySelector)
	{
		return string.Join(ControlChars.CommaSpace, input.GetType()
			.GetProperties(BindingFlags.Public | BindingFlags.Instance)
			.Where(propertySelector)
			.Select(prop =>
			{
				var value = prop.GetValue(input);
				return $"{prop.Name}: {value}";
			}));
	}

	/// <summary>
	/// Prints the properties of each object in a input to the debug output.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the input.</typeparam>
	/// <param name="collection">The input of objects whose properties will be printed to the debug output.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="collection"/> or <paramref name="propertySelector"/> is null.</exception>
	[DebuggerStepThrough]
	[Information(nameof(PrintToDebug), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void PrintToDebug<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();

		Debug.WriteLine(new string(ControlChars.Equal, 80));

		Debug.WriteLineIf(methodName.HasValue(), $"Method: {methodName}");

		foreach (var item in collection)
		{
			Debug.WriteLine(this.PropertiesToString(item, propertySelector));
		}

		Debug.WriteLine(new string(ControlChars.Equal, 80));
	}

	/// <summary>
	/// Prints the properties of an object to the debug output.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="input">The object whose properties will be printed to the debug output.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="input"/> or <paramref name="propertySelector"/> is null.
	/// </exception>
	[DebuggerStepThrough]
	[Information(nameof(PrintToDebug), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void PrintToDebug<T>([NotNull] T input, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();

		Debug.WriteLineIf(methodName.HasValue(), $"Method: {methodName}");
		Debug.WriteLine(this.PropertiesToString(input, propertySelector));
	}

	/// <summary>
	/// Saves the properties of each object in a collection to a file in the current directory.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the collection.</typeparam>
	/// <param name="collection">The collection of objects whose properties will be saved to the file.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="collection"/> or <paramref name="propertySelector"/> is null.</exception>
	[DebuggerStepThrough]
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void SaveToFile<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();
		methodName = methodName.ArgumentNotNullOrEmpty();

		var filePath = Path.Combine(this.OutputDirectory, $"{methodName}.txt");

		var content = collection
			.Select(item => this.PropertiesToString(item, propertySelector))
			.ToArray(); // Materialize the content to avoid deferred execution issues.

		File.WriteAllLines(filePath, content);
	}

	/// <summary>
	/// Saves the properties of an object to a file in the current directory.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="input">The object whose properties will be saved to the file.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="input"/> or <paramref name="propertySelector"/> is null.
	/// </exception>
	[DebuggerStepThrough]
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void SaveToFile<T>([NotNull] T input, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();
		methodName = methodName.ArgumentNotNullOrEmpty();

		var filePath = Path.Combine(this.OutputDirectory, $"{methodName}.txt");

		var content = this.PropertiesToString(input, propertySelector);
		File.WriteAllText(filePath, content);
	}

	/// <summary>
	/// Asynchronously saves the properties of each object in a collection to a file in the current directory.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the collection.</typeparam>
	/// <param name="collection">The collection of objects whose properties will be saved to the file.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="collection"/> or <paramref name="propertySelector"/> is null.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="methodName"/> is null or empty.
	/// </exception>
	[AsyncStateMachine(typeof(Task))]
	[DebuggerStepThrough]
	[Information(nameof(SaveToFileAsync), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public async Task SaveToFileAsync<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();
		methodName = methodName.ArgumentNotNullOrEmpty();

		var filePath = Path.Combine(this.OutputDirectory, $"{methodName}.txt");

		var content = collection
			.Select(item => this.PropertiesToString(item, propertySelector))
			.ToArray();

		await File.WriteAllLinesAsync(filePath, content, CancellationToken.None).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets the output directory where files will be saved.
	/// </summary>
	/// <value>
	/// A string representing the directory path where output files will be saved.
	/// </value>
	public string OutputDirectory => this._outputDirectory;
}
