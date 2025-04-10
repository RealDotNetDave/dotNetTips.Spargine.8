// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 04-10-2025
// ***********************************************************************
// <copyright file="UnitTester.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Abstract base class providing common methods for debugging and saving object properties.
/// </summary>
public abstract class UnitTester
{
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
		input = input.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();

		return string.Join(", ", input.GetType()
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
	[Information(nameof(PrintToDebug), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void PrintToDebug<T>(IEnumerable<T> collection, Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
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
	[Information(nameof(PrintToDebug), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void PrintToDebug<T>(T input, Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
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
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void SaveToFile<T>(IEnumerable<T> collection, Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();
		methodName = methodName.ArgumentNotNullOrEmpty();

		var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"{methodName}.txt");

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
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void SaveToFile<T>(T input, Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();
		methodName = methodName.ArgumentNotNullOrEmpty();

		var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"{methodName}.txt");

		var content = this.PropertiesToString(input, propertySelector);
		File.WriteAllText(filePath, content);
	}
}
