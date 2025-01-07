// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-07-2025
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
using System.Globalization;
using System.Reflection;
using System.Text;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a base class for creating an enumeration-like class structure that supports
/// descriptive names and associated values, offering more flexibility than the standard Enum type.
/// This allows for richer domain models with type safety, without the limitations of the built-in Enum type.
/// </summary>
/// <remarks>Original code by: Jimmy Bogard</remarks>
[Information(nameof(Enumeration), Documentation = "http://bit.ly/SpargineFeb2021", Status = Status.Available)]
[DebuggerDisplay(nameof(DisplayName))]
public class Enumeration : IComparable
{

	/// <summary>
	/// A composite format string used for error messages when an object is not of the expected type.
	/// </summary>
	private static readonly CompositeFormat ErrorObjectMustBeOfTypeFormat = CompositeFormat.Parse(Resources.ErrorObjectMustBeOfType);

	/// <summary>
	/// Private constructor used to prevent the creation of the Enumeration class without providing a value and display name.
	/// </summary>
	protected Enumeration()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Enumeration"/> class.
	/// </summary>
	/// <param name="value">The integer value of the enumeration.</param>
	/// <param name="displayName">The display name of the enumeration.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="displayName"/> is null or empty.</exception>
	[Information(nameof(Enumeration), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	protected Enumeration(int value, [NotNull] string displayName)
	{
		this.Value = value;
		this.DisplayName = displayName;
	}

	/// <summary>
	/// Determines whether two specified instances of <see cref="Enumeration"/> are not equal.
	/// </summary>
	/// <param name="left">The first <see cref="Enumeration"/> to compare.</param>
	/// <param name="right">The second <see cref="Enumeration"/> to compare.</param>
	/// <returns><c>true</c> if the instances are not equal; otherwise, <c>false</c>.</returns>
	public static bool operator !=(Enumeration left, Enumeration right) => !(left == right);

	/// <summary>
	/// Determines whether the first specified instance of <see cref="Enumeration"/> is less than the second specified instance.
	/// </summary>
	/// <param name="left">The first <see cref="Enumeration"/> to compare.</param>
	/// <param name="right">The second <see cref="Enumeration"/> to compare.</param>
	/// <returns><c>true</c> if the first instance is less than the second instance; otherwise, <c>false</c>.</returns>
	public static bool operator <(Enumeration left, Enumeration right) => left is null ? right is not null : left.CompareTo(right) < 0;

	/// <summary>
	/// Determines whether the first specified instance of <see cref="Enumeration"/> is less than or equal to the second specified instance.
	/// </summary>
	/// <param name="left">The first <see cref="Enumeration"/> to compare.</param>
	/// <param name="right">The second <see cref="Enumeration"/> to compare.</param>
	/// <returns><c>true</c> if the first instance is less than or equal to the second instance; otherwise, <c>false</c>.</returns>
	public static bool operator <=(Enumeration left, Enumeration right) => left is null || left.CompareTo(right) <= 0;

	/// <summary>
	/// Determines whether two specified instances of <see cref="Enumeration"/> are equal.
	/// </summary>
	/// <param name="left">The first <see cref="Enumeration"/> to compare.</param>
	/// <param name="right">The second <see cref="Enumeration"/> to compare.</param>
	/// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
	public static bool operator ==(Enumeration left, Enumeration right)
	{
		if (left is null)
		{
			return right is null;
		}

		return left.Equals(right);
	}

	/// <summary>
	/// Determines whether the first specified instance of <see cref="Enumeration"/> is greater than the second specified instance.
	/// </summary>
	/// <param name="left">The first <see cref="Enumeration"/> to compare.</param>
	/// <param name="right">The second <see cref="Enumeration"/> to compare.</param>
	/// <returns><c>true</c> if the first instance is greater than the second instance; otherwise, <c>false</c>.</returns>
	public static bool operator >(Enumeration left, Enumeration right) => left is not null && left.CompareTo(right) > 0;

	/// <summary>
	/// Determines whether the first specified instance of <see cref="Enumeration"/> is greater than or equal to the second specified instance.
	/// </summary>
	/// <param name="left">The first <see cref="Enumeration"/> to compare.</param>
	/// <param name="right">The second <see cref="Enumeration"/> to compare.</param>
	/// <returns><c>true</c> if the first instance is greater than or equal to the second instance; otherwise, <c>false</c>.</returns>
	public static bool operator >=(Enumeration left, Enumeration right) => left is null ? right is null : left.CompareTo(right) >= 0;

	/// <summary>
	/// Parses the specified value and returns an instance of the enumeration based on a predicate.
	/// </summary>
	/// <typeparam name="T">The type of the enumeration.</typeparam>
	/// <param name="description">A description used in the error message if no matching item is found.</param>
	/// <param name="predicate">A predicate to find the matching enumeration item.</param>
	/// <returns>An instance of the enumeration that matches the predicate.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the predicate is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown when no matching item is found.</exception>
	private static T Parse<T>(in string description, [NotNull] in Func<T, bool> predicate) where T : Enumeration
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
	[Information(nameof(AbsoluteDifference), OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineEnumerationHandling", Status = Status.Available)]
	public static int AbsoluteDifference([NotNull] Enumeration firstValue, [NotNull] Enumeration secondValue)
	{
		firstValue = firstValue.ArgumentNotNull();
		secondValue = secondValue.ArgumentNotNull();

		return Math.Abs(firstValue.Value - secondValue.Value);
	}

	/// <summary>
	/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
	/// </summary>
	/// <param name="obj">An object to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings:
	/// Less than zero: This instance precedes <paramref name="obj"/> in the sort order.
	/// Zero: This instance occurs in the same position in the sort order as <paramref name="obj"/>.
	/// Greater than zero: This instance follows <paramref name="obj"/> in the sort order.</returns>
	public int CompareTo(object obj)
	{
		ArgumentNullException.ThrowIfNull(obj);

		if (obj is not Enumeration other)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, ErrorObjectMustBeOfTypeFormat, nameof(Enumeration)), nameof(obj));
		}

		return this.Value.CompareTo(other.Value);
	}

	/// <summary>
	/// Determines whether the specified object is equal to the current enumeration instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current enumeration instance.</param>
	/// <returns><c>true</c> if the specified object is equal to the current enumeration instance; otherwise, <c>false</c>.</returns>
	public override bool Equals(object obj)
	{
		if (obj is null)
		{
			return false;
		}

		if (obj is not Enumeration otherValue)
		{
			return false;
		}

		var typeMatches = this.GetType().Equals(obj.GetType());
		var valueMatches = this.Value.Equals(otherValue.Value);

		return typeMatches && valueMatches;
	}

	/// <summary>
	/// Returns an enumeration instance based on its display name.
	/// </summary>
	/// <typeparam name="T">The enumeration type.</typeparam>
	/// <param name="displayName">The display name of the enumeration instance.</param>
	/// <returns>An instance of the enumeration type that matches the given display name.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="displayName"/> is null or empty.</exception>
	/// <exception cref="InvalidOperationException">Thrown when no matching enumeration instance is found.</exception>
	[Information(nameof(FromDisplayName), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Documentation = "https://bit.ly/SpargineEnumerationHandling", Status = Status.Available)]
	public static T FromDisplayName<T>([NotNull] string displayName) where T : Enumeration
	{
		displayName = displayName.ArgumentNotNullOrEmpty();

		return Parse<T>(displayName, predicate: item => string.Equals(item.DisplayName, displayName, StringComparison.Ordinal));
	}

	/// <summary>
	/// Returns an enumeration instance based on its integer value.
	/// </summary>
	/// <typeparam name="T">The enumeration type.</typeparam>
	/// <param name="value">The integer value of the enumeration instance.</param>
	/// <returns>An instance of the enumeration type that matches the given integer value.</returns>
	/// <exception cref="InvalidOperationException">Thrown when no matching enumeration instance is found.</exception>
	[Information(nameof(FromValue), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Documentation = "https://bit.ly/SpargineEnumerationHandling", Status = Status.Available)]
	public static T FromValue<T>(int value) where T : Enumeration => Parse<T>(value.ToString(CultureInfo.CurrentCulture), item => item.Value == value);

	/// <summary>
	/// Retrieves all instances of the specified enumeration type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of enumeration to retrieve instances for.</typeparam>
	/// <returns>An <see cref="IEnumerable{T}"/> containing all instances of the specified enumeration type.</returns>
	[Information(nameof(GetAll), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Documentation = "https://bit.ly/SpargineEnumerationHandling", Status = Status.Available)]
	public static IEnumerable<T> GetAll<T>() where T : Enumeration
	{
		var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

		foreach (var field in fields)
		{
			if (field.GetValue(null) is T locatedValue)
			{
				yield return locatedValue;
			}
		}
	}

	/// <summary>
	/// Returns a hash code for the current enumeration instance.
	/// </summary>
	/// <returns>A hash code for the current enumeration instance.</returns>
	public override int GetHashCode() => this.Value.GetHashCode();

	/// <summary>
	/// Returns the display name of the enumeration.
	/// </summary>
	/// <returns>The display name of the enumeration.</returns>
	public override string ToString() => this.DisplayName;

	/// <summary>
	/// Gets the display name of the enumeration.
	/// </summary>
	/// <value>The display name.</value>
	[Information(nameof(DisplayName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string DisplayName { get; }

	/// <summary>
	/// Gets the integer value of the enumeration.
	/// </summary>
	/// <value>The integer value.</value>
	[Information(nameof(Value), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int Value { get; }
}
