// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="Extensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a collection of extension methods for various types.
/// </summary>
internal static class Extensions
{

	/// <summary>
	/// The description cache
	/// </summary>
	private static readonly ConcurrentDictionary<Enum, string> _descriptionCache = new();
	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Adds the specified item to the collection if it does not already exist.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to add the item to.</param>
	/// <param name="item">The item to add to the collection.</param>
	/// <returns><c>true</c> if the item was added to the collection; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	/// <exception cref="ArgumentReadOnlyException">Thrown if <paramref name="collection"/> is read-only.</exception>
	[Information(nameof(AddIfNotExists), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	internal static bool AddIfNotExists<T>([NotNull] this ICollection<T> collection, [NotNull] T item)
	{
		if (item is null)
		{
			return false;
		}

		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		if (collection.Contains<T>(item))
		{
			return false;
		}

		collection.Add(item);

		return true;
	}

	/// <summary>
	/// Indicate whether the number falls in the specified range.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <param name="lower">Lower bound</param>
	/// <param name="upper">Upper bound</param>
	/// <returns>True/False</returns>
	internal static bool CheckIsInRange(this in int value, in int lower, in int upper) => value >= lower && value <= upper;

	/// <summary>
	/// Determines whether [is in range] [the specified lower].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
	internal static bool CheckIsInRange(this byte value, byte lower, byte upper) => value >= lower && value <= upper;

	/// <summary>
	/// Determines whether [is in range] [the specified lower].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
	internal static bool CheckIsInRange(this in long value, in long lower, in long upper) => value >= lower && value <= upper;

	/// <summary>
	/// Determines whether [is in range] [the specified lower].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
	internal static bool CheckIsInRange(this in double value, in double lower, in double upper) => value >= lower && value <= upper;

	/// <summary>
	/// Determines whether [is in range] [the specified lower].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
	internal static bool CheckIsInRange(this in decimal value, in decimal lower, in decimal upper) => value >= lower && value <= upper;

	/// <summary>
	/// Clears the <see cref="StringBuilder"/> and sets its capacity.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to clear and set capacity for.</param>
	/// <param name="capacity">The new capacity to set for the <see cref="StringBuilder"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/> is null.</exception>
	[Information(nameof(ClearSetCapacity), author: "David McCarter", createdOn: "11/13/2024", UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	internal static StringBuilder ClearSetCapacity([NotNull] this StringBuilder sb, int capacity)
	{
		sb = sb.ArgumentNotNull();
		sb.Clear().Capacity = capacity;
		return sb;
	}

	/// <summary>
	/// Counts the number of elements in the specified collection.
	/// </summary>
	/// <param name="collection">The collection to count the elements of.</param>
	/// <returns>The number of elements in the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection" /> is null.</exception>
	[Information(nameof(Count), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	internal static int Count(this IEnumerable collection)
	{
		if (collection is null)
		{
			return 0;
		}

		// If the collection is an ICollection or ICollection<T>, use its Count property for efficiency.
		if (collection is ICollection col)
		{
			return col.Count;
		}
		else if (collection is ICollection<object> colT)
		{
			return colT.Count;
		}

		// Fallback to manual counting for other IEnumerable types.
		var count = 0;
		var enumerator = collection.GetEnumerator();

		while (enumerator.MoveNext())
		{
			count++;
		}

		return count;
	}

	/// <summary>
	/// Counts the number of elements in the specified collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">The collection to count the elements of.</param>
	/// <returns>The number of elements in the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastCount), "David McCarter", "5/21/2022", Status = Status.Available)]
	internal static long FastCount<T>(this IEnumerable<T> collection) => collection.ArgumentNotNull().LongCount();

	/// <summary>
	/// Returns an enumerable collection representing the hierarchy of exceptions starting from the specified source exception.
	/// This method is useful for traversing nested exceptions (e.g., when dealing with aggregate exceptions).
	/// </summary>
	/// <typeparam name="TSource">The type of the source exception, must derive from <see cref="Exception"/>.</typeparam>
	/// <param name="source">The source exception to start traversing from.</param>
	/// <param name="nextItemFunction">A delegate that defines the method to retrieve the next exception in the hierarchy.</param>
	/// <returns>An <see cref="IEnumerable{TSource}"/> that represents the hierarchy of exceptions.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> or <paramref name="nextItemFunction"/> is null.</exception>
	[Information(nameof(FromHierarchy), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	internal static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, Func<TSource, TSource> nextItemFunction) where TSource : Exception
	{
		source = source.ArgumentNotNull();
		nextItemFunction = nextItemFunction.ArgumentNotNull();

		return FromHierarchy(source, nextItemFunction, s => s is not null);
	}

	/// <summary>
	/// Returns the hierarchy from the source, validating that <paramref name="source"/>, <paramref name="nextItemFunction"/>, and <paramref name="canContinue"/> are not null.
	/// This method allows traversing a hierarchy (e.g., of exceptions) by repeatedly applying <paramref name="nextItemFunction"/> to get the next item in the hierarchy,
	/// until <paramref name="canContinue"/> returns false.
	/// </summary>
	/// <typeparam name="TSource">The type of the source items in the hierarchy.</typeparam>
	/// <param name="source">The starting item in the hierarchy.</param>
	/// <param name="nextItemFunction">A function to get the next item in the hierarchy from the current item.</param>
	/// <param name="canContinue">A function that determines whether to continue traversing the hierarchy from the current item.</param>
	/// <returns>A sequence of items from the source up through the hierarchy as determined by <paramref name="nextItemFunction"/> and <paramref name="canContinue"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/>, <paramref name="nextItemFunction"/>, or <paramref name="canContinue"/> is null.</exception>
	internal static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, Func<TSource, TSource> nextItemFunction, Func<TSource, bool> canContinue)
		where TSource : Exception
	{
		source = source.ArgumentNotNull();
		nextItemFunction = nextItemFunction.ArgumentNotNull();
		canContinue = canContinue.ArgumentNotNull();

		while (source != null && canContinue(source))
		{
			yield return source;
			source = nextItemFunction(source);
		}
	}

	/// <summary>
	/// Gets all messages from an <see cref="Exception"/> and its inner exceptions, concatenated into a single string.
	/// </summary>
	/// <param name="exception">The exception to extract messages from.</param>
	/// <param name="separator">The character used to separate individual exception messages in the resulting string. Defaults to a comma.</param>
	/// <returns>A string containing all exception messages, separated by the specified separator.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="exception"/> is null.</exception>
	internal static string GetAllMessages(this Exception exception, char separator = ControlChars.Comma)
	{
		exception = exception.ArgumentNotNull();

		var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);

		return string.Join(separator, messages);
	}

	/// <summary>
	/// Gets all properties of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>An <see cref="IEnumerable{PropertyInfo}"/> representing all properties of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	internal static IEnumerable<PropertyInfo> GetAllProperties([NotNull] this Type type)
	{
		var typeInfo = type.ArgumentNotNull().GetTypeInfo();

		while (typeInfo is not null)
		{
			foreach (var propertyInfo in typeInfo.DeclaredProperties)
			{
				yield return propertyInfo;
			}

			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}
	}

	internal static string GetDescription(this Enum input)
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
	/// Checks if the string has a value (is not null or whitespace).
	/// </summary>
	/// <param name="input">The string to check.</param>
	/// <returns><c>true</c> if the string is not null or whitespace; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method considers a string as having a value if it is not null and contains characters other than whitespace.
	/// Uses <see cref="string.IsNullOrWhiteSpace(string)"/> internally to check if the string is null or whitespace.
	/// </remarks>
	internal static bool HasValue([NotNull] this string input) => input is not null && (input.Trim().Length > 0);

	/// <summary>
	/// Checks if the string has a specified length.
	/// </summary>
	/// <param name="input">The string to check.</param>
	/// <param name="length">The length to check for.</param>
	/// <returns><c>true</c> if the string is not null and has the specified length; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks if the <paramref name="input"/> string has a length equal to the specified <paramref name="length"/>.
	/// It is an extension method and cannot be called on a null instance.
	/// </remarks>
	internal static bool HasValue([NotNull] this string input, int length)
	{
		length = length.ArgumentInRange(lower: 1, upper: length);

		return input is not null && (input.ArgumentNotNull().Trim().Length == length);
	}

	///<summary>
	/// Checks if the input string has the specified value.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <param name="value">The value to compare with the input string.</param>
	/// <returns><c>true</c> if the input string has the specified value; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method first checks if the input string has any value using <see cref="HasValue(string)"/> method.
	/// Then, it compares the input string with the specified value using <see cref="string.Equals(string, string, StringComparison)"/>
	/// with <see cref="StringComparison.Ordinal"/>.
	/// </remarks>
	internal static bool HasValue([NotNull] this string input, [NotNull] string value) => input.HasValue() && string.Equals(input, value, StringComparison.Ordinal);

	/// <summary>
	/// Checks if the input string matches the specified regular expression pattern.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <param name="expression">The regular expression pattern to match against the input string. Uses <see cref="Regex"/> for matching.</param>
	/// <param name="options">The options for the regular expression match. See <see cref="RegexOptions"/> for details.</param>
	/// <returns><c>true</c> if the input string matches the regular expression pattern; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method first checks if the input string has any value using <see cref="HasValue(string)"/> method.
	/// Then, it creates a new <see cref="Regex"/> instance with the specified pattern and options to perform the match.
	/// </remarks>
	internal static bool HasValue([NotNull] this string input, [NotNull][StringSyntax(StringSyntaxAttribute.Regex)] string expression, [NotNull] RegexOptions options) => input.HasValue() && expression.HasValue() && new Regex(expression, options.ArgumentDefined()).IsMatch(input);

	/// <summary>
	/// Checks if the input string has a value within the specified length range.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <param name="minLength">The minimum length of the string.</param>
	/// <param name="maxLength">The maximum length of the string.</param>
	/// <returns><c>true</c> if the string's length is within the specified range; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks if the <paramref name="input"/> string's length is between <paramref name="minLength"/> and <paramref name="maxLength"/>.
	/// It is an extension method and cannot be called on a null instance.
	/// </remarks>
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	internal static bool HasValue([NotNull] this string input, int minLength, int maxLength)
	{
		minLength = minLength.ArgumentInRange(lower: 0, upper: maxLength);
		maxLength = maxLength.ArgumentInRange(lower: minLength, upper: int.MaxValue);

		return input is not null && input.Length.CheckIsInRange(minLength, maxLength);
	}

	/// <summary>
	/// Converts IDictionary to delimited string using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// </summary>
	/// <param name="list">The list.</param>
	/// <param name="delimiter">The delimiter.</param>
	/// <returns>System.String.</returns>
	internal static string ToDelimitedString([NotNull] this IDictionary list, char delimiter = ',')
	{
		if (string.IsNullOrEmpty(delimiter.ToString()))
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(delimiter));
		}

		if (list.Count == 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			foreach (DictionaryEntry item in list)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item.Key}: {item.Value}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Convert a list to a delimited string  using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="list">The list.</param>
	/// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
	/// <returns>System.String.</returns>
	internal static string ToDelimitedString<T>([NotNull] this IEnumerable<T> list, char delimiter = ControlChars.Comma)
	{
		if (list.FastCount() == 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			foreach (var item in list)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// To the immutable dictionary.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="values">The values.</param>
	/// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
	internal static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> values) => ImmutableDictionary.CreateRange(values);

	/// <summary>
	/// Converts to a <see cref="IDictionary{TKey, TValue}" /> to a <see cref="ReadOnlyCollection{KeyValuePair}" />.
	/// </summary>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	/// <typeparam name="TValue">The type of the value.</typeparam>
	/// <param name="dictionary">The dictionary.</param>
	/// <returns>ReadOnlyCollection&lt;KeyValuePair&lt;TKey, TValue&gt;&gt;.</returns>
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "11/6/2023")]
	internal static ReadOnlyCollection<KeyValuePair<TKey, TValue>> ToReadOnlyCollection<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary)
	{
		// Convert the dictionary to a list of KeyValuePair
		var list = new List<KeyValuePair<TKey, TValue>>(dictionary.ArgumentNotNull());

		// Create a ReadOnlyCollection from the list
		var readOnlyCollection = new ReadOnlyCollection<KeyValuePair<TKey, TValue>>(list);

		return readOnlyCollection;
	}

	/// <summary>
	/// Calculates the total character count from a string array.
	/// </summary>
	/// <param name="args">The array of strings to calculate the character count from.</param>
	/// <returns>The total character count of all strings in the array.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="args"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculateStringCount), "David McCarter", "11/14/2024")]
	public static int CalculateStringCount([NotNull] this string[] args)
	{
		if (args == null)
		{
			return 0;
		}

		var totalLength = 0;

		foreach (var arg in args)
		{
			if (arg != null)
			{
				totalLength += arg.Length;
			}
		}

		return totalLength;
	}

}
