// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for Enum.</summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Enum" /> type, enhancing enum functionality with additional utilities such as getting descriptions, parsing, and retrieving items.
/// </summary>
public static class EnumExtensions
{

	/// <summary>
	/// The description cache
	/// </summary>
	private static readonly ConcurrentDictionary<Enum, string> _descriptionCache = new();

	/// <summary>
	/// Gets the description of the enum value using the <see cref="EnumMemberAttribute" /> if available; otherwise, it returns the enum's name.
	/// </summary>
	/// <param name="input">The enum value to get the description for.</param>
	/// <returns>The description of the enum value.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input" /> is null.</exception>
	[Information(nameof(GetDescription), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/SpargineEnumerationHandling")]
	public static string GetDescription(this Enum input)
	{
		input = input.ArgumentDefined();

		return _descriptionCache.GetOrAdd(input, key =>
		{
			var field = key.GetType().GetField(key.ToString());
			var attributes = (EnumMemberAttribute[])field.GetCustomAttributes(typeof(EnumMemberAttribute), false);
			return attributes.Length > 0 ? attributes[0].Value : key.ToString();
		});
	}

	/// <summary>
	/// Gets the names and values of an <see cref="Enum" />.
	/// This method returns a read-only collection of tuples, where each tuple contains the name (description) and the numeric value of each enum member.
	/// The description is obtained from the enum member's name itself.
	/// </summary>
	/// <param name="input">The enumeration to retrieve items from.</param>
	/// <returns>A <see cref="ReadOnlyCollection{T}" /> where T is a tuple of string and int, representing the description and value of each enum member.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input" /> is null.</exception>
	[Information(nameof(GetItems), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/SpargineEnumerationHandling")]
	public static ReadOnlyCollection<(string Description, int Value)> GetItems(this Enum input)
	{
		var enumType = input.GetType();
		var enumValues = Enum.GetValues(enumType).Cast<Enum>();

		var items = Array.ConvertAll(enumValues.ToArray(), value =>
			(Description: Enum.GetName(enumType, value), Value: Convert.ToInt32(value, CultureInfo.InvariantCulture))
		);

		return new ReadOnlyCollection<(string Description, int Value)>(items);

	}

	/// <summary>
	/// Parses the specified string to an enum of type <typeparamref name="T" />.
	/// </summary>
	/// <typeparam name="T">The enum type to which the string will be parsed.</typeparam>
	/// <param name="name">The string representation of the enum value to parse.</param>
	/// <returns>An enum of type <typeparamref name="T" /> corresponding to the parsed string.</returns>
	/// <exception cref="ArgumentException">Thrown if <paramref name="name" /> is null or an empty string, or if it does not correspond to any value of <typeparamref name="T" />.</exception>
	[Information(nameof(Parse), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineEnumerationHandling")]
	public static T Parse<T>(this string name)
		where T : Enum
	{
		name = name.ArgumentNotNullOrEmpty();

		return (T)Enum.Parse(typeof(T), name);
	}

}
