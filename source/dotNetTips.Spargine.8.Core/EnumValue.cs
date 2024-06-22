// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="EnumValue.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Used to supply the name and value for an Enum.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents a record that holds the name and value of an enumeration.
/// </summary>
public record EnumValue
{

	/// <summary>
	/// Initializes a new instance of the <see cref="EnumValue"/> record.
	/// </summary>
	/// <param name="value">The integer value of the enumeration.</param>
	/// <param name="name">The name of the enumeration. This cannot be null.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="name"/> is null or empty.</exception>
	public EnumValue(int value, [NotNull] string name)
	{
		this.Value = value;
		this.Name = name;
	}

	/// <summary>
	/// Gets the name of the enumeration.
	/// </summary>
	/// <value>The name of the enumeration.</value>
	public string Name { get; init; }

	/// <summary>
	/// Gets the integer value of the enumeration.
	/// </summary>
	/// <value>The integer value.</value>
	public int Value { get; init; }

}
