// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-31-2024
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for Enum.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extension methods for <see cref="Enum" />.
/// </summary>
public static class EnumExtensions
{

	/// <summary>
	/// Gets the <see cref="Enum" /> description.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentNullException">val</exception>
	[Information(nameof(GetDescription), UnitTestCoverage = 100, Status = Status.Available)]
	public static string GetDescription(this Enum input)
	{
		var field = input.ArgumentNotNull().GetType().GetField(input.ToString());

		var attributes = (EnumMemberAttribute[])field.GetCustomAttributes(typeof(EnumMemberAttribute), false);

		return attributes.LongLength > 0 ? attributes[0].Value : input.ToString();
	}

	/// <summary>
	/// Gets the names and values of an <see cref="Enum" />.
	/// </summary>
	/// <param name="input">The enumeration.</param>
	/// <returns>ReadOnlyCollection&lt;System.ValueTuple&lt;System.String, System.Int32&gt;&gt;.</returns>
	[Information(nameof(GetItems), UnitTestCoverage = 100, Status = Status.Available)]
	public static ReadOnlyCollection<(string Description, int Value)> GetItems(this Enum input)
	{
		var items = new List<(string Description, int Value)>();

		foreach (var name in Enum.GetNames(input.GetType()))
		{
			items.Add((Description: name, Value: (int)Enum.Parse(input.GetType(), name)));
		}

		return items.AsReadOnly();
	}

	/// <summary>
	/// Parses the specified <see cref="Enum" /> name.
	/// Validates that <paramref name="name" /> contains text.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="name">The name.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentException">name</exception>
	/// <exception cref="ArgumentException">The exception.</exception>
	[Information(nameof(Parse), UnitTestCoverage = 100, Status = Status.Available)]
	public static T Parse<T>([NotNull] this string name)
		where T : Enum
	{
		name = name.ArgumentNotNullOrEmpty();

		return (T)Enum.Parse(typeof(T), name);
	}

}
