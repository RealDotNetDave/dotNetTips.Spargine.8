// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-12-2024
// ***********************************************************************
// <copyright file="EnumHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Facilitates the usage of Enums by providing convenient methods such as
// AdjustCamelCase(), AdjustName(), GetNames(), and more.
// </summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides utility methods for working with enumerations, such as converting between names and values,
/// adjusting naming conventions, and extracting metadata. This class cannot be inherited.
/// </summary>
public static class EnumHelper
{

	/// <summary>
	/// Regular expression used to identify camel case words within a string.
	/// This is used to adjust enum names to a more readable format by inserting spaces between camel case words.
	/// </summary>
	private static readonly Regex _titleCaseRegex = new(@"(\B[A-Z])", RegexOptions.Multiline | RegexOptions.Compiled);

	/// <summary>
	/// Adjusts camel case naming in the provided string by inserting a space before each capital letter that is not at the beginning.
	/// </summary>
	/// <param name="name">The string to adjust.</param>
	/// <returns>A string with spaces inserted before capital letters that are not at the beginning.</returns>
	private static string AdjustCamelCase(string name) => _titleCaseRegex.Replace(name, replacement: " $1");

	/// <summary>
	/// Adjusts the name of the enumeration value by replacing underscores with spaces and applying camel case adjustment.
	/// </summary>
	/// <param name="name">The original name of the enumeration value.</param>
	/// <returns>The adjusted name with underscores replaced by spaces and camel case naming applied.</returns>
	private static string AdjustName(string name) => AdjustCamelCase(name.Replace(ControlChars.Underscore, ControlChars.Space))
			.Replace(ControlChars.Space, ControlChars.Space);

	/// <summary>
	/// Retrieves a list of names for an enumeration type, with options to adjust for readability and to use XML attributes.
	/// </summary>
	/// <param name="type">The enumeration type.</param>
	/// <param name="fixNames">If set to <c>true</c>, adjusts the names for readability by adding spaces in camel case names and replacing underscores with spaces.</param>
	/// <param name="useXml">If set to <c>true</c>, uses the <see cref="XmlEnumAttribute"/> for the names if available.</param>
	/// <returns>A list of enumeration names as strings.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="type"/> is null.</exception>
	private static List<string> GetNames([NotNull] Type type, bool fixNames = true, bool useXml = true)
	{
		// Set up result
		var result = new List<string>();

		//Load fields
		var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

		// Enum names (text) are defined as fields for the type
		foreach (var enumValue in fields.AsSpan())
		{
			// If XML is specified and found, use this name
			if (useXml)
			{
				var attribute = (XmlEnumAttribute)Attribute.GetCustomAttribute(enumValue, typeof(XmlEnumAttribute));

				if (attribute is not null)
				{
					result.Add(attribute.Name);
					continue;
				}
			}

			// Attempt to use the Description attribute (if present)
			var description = (DescriptionAttribute)Attribute.GetCustomAttribute(enumValue, typeof(DescriptionAttribute));

			if (description is not null)
			{
				// use this value
				result.Add(description.Description);
			}
			else
			{
				// If not found use the Enum name, with adjustment if requested
				result.Add(fixNames ? AdjustName(enumValue.Name) : enumValue.Name);
			}
		}

		return result;
	}

	/// <summary>
	/// Gets the enumeration names and values for a specified enumeration type.
	/// </summary>
	/// <typeparam name="T">The type of the enumeration.</typeparam>
	/// <param name="fixNames">If set to <c>true</c>, adjusts the names for readability by adding spaces in camel case names and replacing underscores with spaces.</param>
	/// <param name="useXmlNames">If set to <c>true</c>, uses the <see cref="XmlEnumAttribute"/> for the names if available.</param>
	/// <returns>A read-only collection of <see cref="EnumValue"/>, each representing an enumeration name and its corresponding value.</returns>
	/// <example>
	/// Using this method with an enumeration type <c>RequestCacheLevel</c> will return a collection containing:
	/// <code>
	/// new EnumValue { Name = "Default", Value = 0 },
	/// new EnumValue { Name = "BypassCache", Value = 1 },
	/// and so on for each enumeration value.
	/// </code>
	/// </example>
	[Information(nameof(GetValues), author: "David McCarter", createdOn: "1/1/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Documentation = "https://bit.ly/SpargineEnumerationHandling", Status = Status.Available)]
	public static ReadOnlyCollection<EnumValue> GetValues<T>(bool fixNames = true, bool useXmlNames = true)
		where T : Enum
	{
		var enumType = typeof(T);

		// Get the enum values
		var allValues = (int[])Enum.GetValues(enumType);

		// Get list of names
		// Add values to result
		var result = new List<EnumValue>();

		var enumNames = GetNames(enumType, fixNames, useXmlNames).ToImmutableArray();

		//TODO: Refactor to use Span
		for (var valueCount = 0; valueCount < allValues.Length; valueCount++)
		{
			result.Add(new EnumValue(allValues[valueCount], enumNames[valueCount]));
		}

		return result.AsReadOnly();
	}

}
