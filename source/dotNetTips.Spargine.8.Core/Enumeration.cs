// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="Enumeration.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Enables the creation of an enumeration without relying on the
// Enum class.
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a base class for creating an enumeration-like class structure that supports
/// descriptive names and associated values, offering more flexibility than the standard Enum type.
/// This allows for richer domain models with type safety, without the limitations of the built-in Enum type.
/// </summary>
/// <remarks>Original code by: Jimmy Bogard</remarks>
[Information(nameof(Enumeration), Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
[DebuggerDisplay(nameof(DisplayName))]
public abstract record Enumeration
{

	/// <summary>
	/// The display name of the enumeration.
	/// </summary>
	private readonly string _displayName;

	/// <summary>
	/// The internal storage of the enumeration value.
	/// </summary>
	private int _value;

	/// <summary>
	/// Private constructor used to prevent the creation of the Enumeration class without providing a value and display name.
	/// </summary>
	private Enumeration()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Enumeration"/> class.
	/// </summary>
	/// <param name="value">The integer value of the enumeration.</param>
	/// <param name="displayName">The display name of the enumeration.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="displayName"/> is null or empty.</exception>
	[Information(nameof(Enumeration), UnitTestCoverage = 100, Status = Status.Available)]
	protected Enumeration(int value, [NotNull] string displayName)
	{
		this._value = value;
		this.DisplayName = displayName;
	}

	/// <summary>
	/// Parses the specified value and returns an instance of the enumeration based on a predicate.
	/// </summary>
	/// <typeparam name="T">The type of the enumeration.</typeparam>
	/// <param name="description">A description used in the error message if no matching item is found.</param>
	/// <param name="predicate">A predicate to find the matching enumeration item.</param>
	/// <returns>An instance of the enumeration that matches the predicate.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the predicate is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown when no matching item is found.</exception>
	private static T Parse<T>(string description, [NotNull] Func<T, bool> predicate) where T : Enumeration, new()
	{
		var matchingItem = GetAll<T>().FirstOrDefault(predicate);

		if (matchingItem is null)
		{
			var message = $"Is not a valid {description} in {typeof(T)}.";

			ExceptionThrower.ThrowArgumentNullException(message, nameof(predicate));
		}

		return matchingItem;
	}

	/// <summary>
	/// Calculates the absolute difference between the values of two specified enumeration instances.
	/// </summary>
	/// <param name="firstValue">The first enumeration instance.</param>
	/// <param name="secondValue">The second enumeration instance.</param>
	/// <returns>The absolute difference between the values of <paramref name="firstValue"/> and <paramref name="secondValue"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when either <paramref name="firstValue"/> or <paramref name="secondValue"/> is null.</exception>
	[Information(nameof(AbsoluteDifference), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineEnumerationHandling")]
	public static int AbsoluteDifference([NotNull] Enumeration firstValue, [NotNull] Enumeration secondValue)
	{
		firstValue = firstValue.ArgumentNotNull();
		secondValue = secondValue.ArgumentNotNull();

		var absoluteDifference = Math.Abs(firstValue.Value - secondValue.Value);
		return absoluteDifference;
	}

	/// <summary>
	/// Returns an enumeration instance based on its display name.
	/// </summary>
	/// <typeparam name="T">The enumeration type.</typeparam>
	/// <param name="displayName">The display name of the enumeration instance.</param>
	/// <returns>An instance of the enumeration type that matches the given display name.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="displayName"/> is null or empty.</exception>
	/// <exception cref="InvalidOperationException">Thrown when no matching enumeration instance is found.</exception>
	[Information(nameof(FromDisplayName), UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineEnumerationHandling")]
	public static T FromDisplayName<T>([NotNull] string displayName) where T : Enumeration, new()
	{
		displayName = displayName.ArgumentNotNullOrEmpty();

		var matchingItem = Parse<T>(displayName, predicate: item => string.Equals(item.DisplayName, displayName, StringComparison.Ordinal));

		return matchingItem;
	}

	/// <summary>
	/// Returns an enumeration instance based on its integer value.
	/// </summary>
	/// <typeparam name="T">The enumeration type.</typeparam>
	/// <param name="value">The integer value of the enumeration instance.</param>
	/// <returns>An instance of the enumeration type that matches the given integer value.</returns>
	/// <exception cref="InvalidOperationException">Thrown when no matching enumeration instance is found.</exception>
	[Information(nameof(FromValue), UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineEnumerationHandling")]
	public static T FromValue<T>(int value) where T : Enumeration, new()
	{
		var matchingItem = Parse<T>("Validating int.", item => item.Value == value);

		return matchingItem;
	}

	/// <summary>
	/// Retrieves all instances of the specified enumeration type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of enumeration to retrieve instances for.</typeparam>
	/// <returns>An <see cref="IEnumerable{T}"/> containing all instances of the specified enumeration type.</returns>
	[Information(nameof(GetAll), UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineEnumerationHandling")]
	public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
	{
		var type = typeof(T);
		var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

		for (var fieldCount = 0; fieldCount < fields.Length; fieldCount++)
		{
			var instance = new T();

			if (fields[fieldCount].GetValue(instance) is T locatedValue)
			{
				yield return locatedValue;
			}
		}
	}

	/// <summary>
	/// Gets the display name of the enumeration.
	/// </summary>
	/// <value>The display name.</value>
	[Information(nameof(DisplayName), UnitTestCoverage = 100, Status = Status.Available)]
	public string DisplayName
	{
		get => this._displayName;
		init => this._displayName = value.ArgumentNotNullOrEmpty();
	}

	/// <summary>
	/// Gets the integer value of the enumeration.
	/// </summary>
	/// <value>The integer value.</value>
	[Information(nameof(Value), UnitTestCoverage = 0, Status = Status.Available)]
	public int Value
	{
		get => this._value;
		init => this._value = value.ArgumentInRange(lower: 0);
	}

}
