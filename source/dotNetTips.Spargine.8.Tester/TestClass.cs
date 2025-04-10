// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2025
// ***********************************************************************
// <copyright file="TestClass.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for TestClasses.</summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DotNetTips.Spargine.Extensions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Class TestClass.
/// </summary>
[ExcludeFromCodeCoverage]
public abstract class TestClass
{

	/// <summary>
	/// Converts the properties of each object in a collection to a string representation based on a selection function.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the collection.</typeparam>
	/// <param name="collection">The collection of objects whose properties will be converted to a string.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <returns>A string representation of the selected properties of the objects in the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="collection"/> or <paramref name="propertySelector"/> is null.</exception>
	protected static string CollectionPropertiesToString<T>(IEnumerable<T> collection, Func<PropertyInfo, bool> propertySelector)
	{
		if (collection == null)
		{
			throw new ArgumentNullException(nameof(collection), "Collection cannot be null.");
		}

		if (propertySelector == null)
		{
			throw new ArgumentNullException(nameof(propertySelector), "Property selector function cannot be null.");
		}

		var result = collection.Select(item => PropertiesToString(item, propertySelector));
		return string.Join(Environment.NewLine, result);
	}

	/// <summary>
	/// Prints the result.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input.</param>
	/// <param name="methodName">Name of the method.</param>
	protected static void PrintResult<T>(T input, string methodName)
	{
		var message = input is string || input.GetType().IsValueType
			? $"{methodName}: {input:C}"
			: $"{methodName}: {input.PropertiesToString(includeMemberName: false)}";

		Debug.WriteLine(message);
	}

	/// <summary>
	/// Converts the properties of an object to a string representation based on a selection function.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="input">The object whose properties will be converted to a string.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <returns>A string representation of the selected properties of the object.</returns>
	protected static string PropertiesToString<T>(T input, Func<PropertyInfo, bool> propertySelector)
	{
		if (input == null)
		{
			throw new ArgumentNullException(nameof(input), "Input object cannot be null.");
		}

		if (propertySelector == null)
		{
			throw new ArgumentNullException(nameof(propertySelector), "Property selector function cannot be null.");
		}

		var properties = input.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
								  .Where(propertySelector);

		var propertyStrings = properties.Select(prop =>
		{
			var value = prop.GetValue(input);
			return $"{prop.Name}: {value}";
		});

		return string.Join(", ", propertyStrings);

	}
}
