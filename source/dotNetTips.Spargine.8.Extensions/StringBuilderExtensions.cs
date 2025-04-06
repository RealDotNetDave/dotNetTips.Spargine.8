// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-19-2025
// ***********************************************************************
// <copyright file="StringBuilderExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>StringBuilder Extensions.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="StringBuilder"/> to enhance and simplify its functionality.
/// </summary>
/// <remarks>
/// This class includes methods for appending key-value pairs, bytes, and collections with various formatting options.
/// </remarks>
[Information(nameof(StringBuilderExtensions), "David McCarter", "5/26/2020", "7/29/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineStringBuilderExtensions")]
public static class StringBuilderExtensions
{

	/// <summary>
	/// The special characters
	/// </summary>
	private static readonly char[] _specialCharacters = ['"', '\\'];

	/// <summary>
	/// Sets the separator.
	/// </summary>
	/// <param name="separator">The separator.</param>
	/// <returns>System.String.</returns>
	private static string SetSeparator(string separator)
	{
		if (separator.HasValue() is false)
		{
			separator = ControlChars.DefaultSeparator;
		}

		return separator;
	}

	/// <summary>
	/// Appends the bytes to the <see cref="StringBuilder"/>.
	/// Validates that <paramref name="sb" /> and <paramref name="bytes" /> are not null.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append to.</param>
	/// <param name="bytes">The byte array to append.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/> or <paramref name="bytes"/> is null.</exception>
	/// <example>
	/// <code>
	/// var sb = new StringBuilder();
	/// var byteArray = RandomData.GenerateByteArray(5);
	/// sb.AppendBytes(byteArray);
	/// </code>
	/// </example>
	[Information("Original code from efcore-master on GitHub", author: "David McCarter", createdOn: "5/26/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void AppendBytes([NotNull] this StringBuilder sb, [NotNull] byte[] bytes)
	{
		if (bytes is null)
		{
			return;
		}

		sb = sb.ArgumentNotNull().Append("'0x");

		//FrozenSet and Span is slower.
		foreach (var byteItem in bytes)
		{
			_ = sb.Append(byteItem.ToString("X2", CultureInfo.InvariantCulture));
		}

		_ = sb.Append('\'');
	}

	/// <summary>
	/// Appends the key-value pair to the <see cref="StringBuilder"/>.
	/// Validates that <paramref name="sb"/>, <paramref name="key"/>, and <paramref name="value"/> are not null.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append to.</param>
	/// <param name="key">The key to append.</param>
	/// <param name="value">The value to append.</param>
	/// <param name="includeQuotes">If set to <c>true</c>, includes quotes around the value.</param>
	/// <param name="includeComma">If set to <c>true</c>, includes a comma after the key-value pair.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/> or <paramref name="key"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="key"/> is empty.</exception>
	/// <example>
	/// <code>
	/// var sb = new StringBuilder();
	/// sb.AppendKeyValue("Name", "John", true, true);
	/// Console.WriteLine(sb.ToString()); // Output: Name="John",
	/// </code>
	/// </example>
	[Information("FROM .NET CORE SOURCE", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void AppendKeyValue([NotNull] this StringBuilder sb, [NotNull] string key, string value, bool includeQuotes = true, bool includeComma = true)
	{
		sb = sb.ArgumentNotNull();
		key = key.ArgumentNotNullOrEmpty();

		if (value is null)
		{
			return;
		}

		_ = sb.Append(key).Append(ControlChars.Equal);

		if (includeQuotes)
		{
			_ = sb.Append(ControlChars.Quote);
			var lastSpecialIndex = 0;
			int specialIndex;

			while (true)
			{
				specialIndex = value.IndexOfAny(_specialCharacters, lastSpecialIndex);

				if (specialIndex >= 0)
				{
					_ = sb.Append(value, lastSpecialIndex, specialIndex - lastSpecialIndex).Append(ControlChars.Backslash).Append(value[specialIndex]);
					lastSpecialIndex = specialIndex + 1;
				}
				else
				{
					_ = sb.Append(value, lastSpecialIndex, value.Length - lastSpecialIndex);
					break;
				}
			}
			_ = sb.Append(ControlChars.Quote);
		}
		else
		{
			_ = sb.Append(value);
		}

		if (includeComma)
		{
			_ = sb.Append(ControlChars.DefaultSeparator);
		}
	}

	/// <summary>
	/// Appends the values.
	/// Validates that <paramref name="sb" />, <paramref name="separator" /> and <paramref name="values" /> is not null.
	/// </summary>
	/// <param name="sb">The string builder.</param>
	/// <param name="separator">The separator.</param>
	/// <param name="values">The values.</param>
	/// <returns>StringBuilder.</returns>
	/// <exception cref="ArgumentNullException">sb</exception>
	/// <exception cref="ArgumentNullException">values</exception>
	/// <exception cref="ArgumentNullException">sb</exception>
	/// <example>
	///   <code>
	/// var sb = new StringBuilder();
	/// var values = RandomData.GenerateWords(5, 5, 7);
	/// sb.AppendValues(",", values);
	/// </code>
	/// </example>
	[Information("Original code from efcore-master on GitHub.", author: "David McCarter", createdOn: "7/1/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void AppendValues([NotNull] this StringBuilder sb, string separator, [NotNull] in IEnumerable<string> values)
	{
		sb = sb.ArgumentNotNull();

		if (values is null)
		{
			return;
		}

		separator = SetSeparator(separator);

		sb.AppendValues(separator, values, (value) => sb.Append(value));
	}

	/// <summary>
	/// Appends the values to the <see cref="StringBuilder"/> using the specified separator.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append to.</param>
	/// <param name="separator">The separator to use between appended values.</param>
	/// <param name="values">The values to append.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/> is null.</exception>
	/// <example>
	///   <code>
	/// var sb = new StringBuilder();
	/// var values = new[] { "value1", "value2", "value3" };
	/// sb.AppendValues(",", values);
	/// Console.WriteLine(sb.ToString()); // Output: value1,value2,value3
	/// </code>
	/// </example>
	[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void AppendValues([NotNull] this StringBuilder sb, string separator, [NotNull] params string[] values)
	{
		sb = sb.ArgumentNotNull();

		if (values is null)
		{
			return;
		}

		separator = SetSeparator(separator);

		sb.AppendValues(separator, values, (value) => sb.Append(value));
	}

	/// <summary>
	/// Appends the values to the <see cref="StringBuilder"/> using the specified separator and join action.
	/// Validates that <paramref name="sb"/>, <paramref name="values"/>, and <paramref name="joinAction"/> are not null.
	/// </summary>
	/// <typeparam name="T">The type of the elements in <paramref name="values"/>.</typeparam>
	/// <param name="sb">The <see cref="StringBuilder"/> to append to.</param>
	/// <param name="separator">The separator to use between appended values.</param>
	/// <param name="values">The collection of values to append.</param>
	/// <param name="joinAction">The action to perform on each element in the <paramref name="values"/> collection.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/>, <paramref name="values"/>, or <paramref name="joinAction"/> is null.</exception>
	/// <example>
	/// <code>
	/// var sb = new StringBuilder();
	/// var values = new[] { "value1", "value2", "value3" };
	/// sb.AppendValues(",", values, value => sb.Append(value));
	/// Console.WriteLine(sb.ToString()); // Output: value1,value2,value3
	/// </code>
	/// </example>
	[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void AppendValues<T>([NotNull] this StringBuilder sb, string separator, [NotNull] IEnumerable<T> values, [NotNull] Action<T> joinAction)
	{
		sb = sb.ArgumentNotNull();
		joinAction = joinAction.ArgumentNotNull();

		if (values is null)
		{
			return;
		}

		separator = SetSeparator(separator);

		var appended = false;

		//FrozenSet is slower.
		foreach (var value in values)
		{
			joinAction(value);
			_ = sb.Append(separator);
			appended = true;
		}

		if (appended)
		{
			sb.Length -= separator.Length;
		}
	}

	/// <summary>
	/// Appends the values to the <see cref="StringBuilder"/> using the specified separator and join action.
	/// Validates that <paramref name="sb"/>, <paramref name="values"/>, <paramref name="param"/>, and <paramref name="joinAction"/> are not null.
	/// </summary>
	/// <typeparam name="T">The type of the elements in <paramref name="values"/>.</typeparam>
	/// <typeparam name="TParam">The type of the parameter passed to the join action.</typeparam>
	/// <param name="sb">The <see cref="StringBuilder"/> to append to.</param>
	/// <param name="separator">The separator to use between appended values.</param>
	/// <param name="values">The collection of values to append.</param>
	/// <param name="param">The parameter to pass to each invocation of <paramref name="joinAction"/>.</param>
	/// <param name="joinAction">The action to perform on each element in the <paramref name="values"/> collection, which also takes <paramref name="param"/> as an argument.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/>, <paramref name="values"/>, <paramref name="param"/>, or <paramref name="joinAction"/> is null.</exception>
	/// <example>
	/// <code>
	/// var sb = new StringBuilder();
	/// var values = new[] { "value1", "value2", "value3" };
	/// sb.AppendValues(",", values, "param", (value, param) => sb.Append(value).Append(param));
	/// Console.WriteLine(sb.ToString()); // Output: value1param,value2param,value3param
	/// </code>
	/// </example>
	[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void AppendValues<T, TParam>([NotNull] this StringBuilder sb, string separator, [NotNull] IEnumerable<T> values, [NotNull] TParam param, [NotNull] Action<T, TParam> joinAction)
	{
		sb = sb.ArgumentNotNull();
		joinAction = joinAction.ArgumentNotNull();
		param = param.ArgumentNotNull();

		if (values is null)
		{
			return;
		}

		separator = SetSeparator(separator);

		var appended = false;

		//Frozenset is slower.
		foreach (var value in values)
		{
			joinAction(value, param);
			_ = sb.Append(separator);
			appended = true;
		}

		if (appended)
		{
			sb.Length -= separator.Length;
		}
	}

	/// <summary>
	/// Appends the values to the <see cref="StringBuilder"/> using the specified separator and join action.
	/// Validates that <paramref name="sb"/>, <paramref name="values"/>, <paramref name="param1"/>, <paramref name="param2"/>, and <paramref name="joinAction"/> are not null.
	/// </summary>
	/// <typeparam name="T">The type of the elements in <paramref name="values"/>.</typeparam>
	/// <typeparam name="TParam1">The type of the first parameter passed to the join action.</typeparam>
	/// <typeparam name="TParam2">The type of the second parameter passed to the join action.</typeparam>
	/// <param name="sb">The <see cref="StringBuilder"/> to append to.</param>
	/// <param name="separator">The separator to use between appended values.</param>
	/// <param name="values">The collection of values to append.</param>
	/// <param name="param1">The first parameter to pass to each invocation of <paramref name="joinAction"/>.</param>
	/// <param name="param2">The second parameter to pass to each invocation of <paramref name="joinAction"/>.</param>
	/// <param name="joinAction">The action to perform on each element in the <paramref name="values"/> collection, which also takes <paramref name="param1"/> and <paramref name="param2"/> as arguments.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/>, <paramref name="values"/>, <paramref name="param1"/>, <paramref name="param2"/>, or <paramref name="joinAction"/> is null.</exception>
	/// <example>
	/// <code>
	/// var sb = new StringBuilder();
	/// var values = new[] { "value1", "value2", "value3" };
	/// sb.AppendValues(",", values, "param1", "param2", (sb, value, param1, param2) => sb.Append(value).Append(param1).Append(param2));
	/// Console.WriteLine(sb.ToString()); // Output: value1param1param2,value2param1param2,value3param1param2
	/// </code>
	/// </example>
	[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void AppendValues<T, TParam1, TParam2>([NotNull] this StringBuilder sb, string separator, [NotNull] IEnumerable<T> values, [NotNull] TParam1 param1, [NotNull] TParam2 param2, [NotNull] Action<StringBuilder, T, TParam1, TParam2> joinAction)
	{
		sb = sb.ArgumentNotNull();
		param1 = param1.ArgumentNotNull();
		param2 = param2.ArgumentNotNull();
		joinAction = joinAction.ArgumentNotNull();

		if (values is null)
		{
			return;
		}

		separator = SetSeparator(separator);

		var appended = false;

		//FrozenSet is slower.
		foreach (var value in values)
		{
			joinAction(sb, value, param1, param2);
			_ = sb.Append(separator);
			appended = true;
		}

		if (appended)
		{
			sb.Length -= separator.Length;
		}
	}

	/// <summary>
	/// Clears the <see cref="StringBuilder"/> and sets its capacity.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to clear and set capacity for.</param>
	/// <param name="capacity">The new capacity to set for the <see cref="StringBuilder"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/> is null.</exception>
	[Information(nameof(ClearSetCapacity), author: "David McCarter", createdOn: "11/13/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static StringBuilder ClearSetCapacity([NotNull] this StringBuilder sb, int capacity)
	{
		sb = sb.ArgumentNotNull();
		sb.Clear().Capacity = capacity;
		return sb;
	}

}
