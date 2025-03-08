// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-08-2025
// ***********************************************************************
// <copyright file="FastStringBuilder.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Enhances performance when using a StringBuilder by employing an
// ObjectPool.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides methods to efficiently build strings using a pooled StringBuilder to reduce memory allocations.
/// </summary>
/// <remarks>
/// This class leverages an ObjectPool of StringBuilder instances to minimize the overhead of creating and disposing StringBuilder objects,
/// which can lead to significant performance improvements in scenarios where string manipulation is frequent.
/// </remarks>
[Information(Status = Status.NeedsDocumentation, Documentation = "ADD URL")]
public static class FastStringBuilder
{

	/// <summary>
	/// The ObjectPool of StringBuilder instances.
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Converts an array of bytes into a hexadecimal string representation, making it easy to inspect raw byte data in string form.
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// </summary>
	/// <param name="bytes">The byte array to convert.</param>
	/// <returns>A hexadecimal string representation of the byte array, prefixed with '0x'.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="bytes"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToString), author: "David McCarter", createdOn: "3/7/2025", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string BytesToString([NotNull] ref readonly byte[] bytes)
	{
		if (bytes is null || bytes.LongLength == 0)
		{
			return ControlChars.EmptyString;
		}

		return BytesToString(bytes.AsSpan());
	}

	/// <summary>
	/// Converts a ReadOnlySpan of bytes into a hexadecimal string representation, making it easy to inspect raw byte data in string form.
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// </summary>
	/// <param name="bytes">The ReadOnlySpan of bytes to convert.</param>
	/// <returns>A hexadecimal string representation of the byte array, prefixed with '0x'.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToString), author: "David McCarter", createdOn: "2/18/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.New)]
	public static string BytesToString(ReadOnlySpan<byte> bytes)
	{
		if (bytes.IsEmpty)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		// Set capacity to increase performance
		_ = sb.EnsureCapacity((bytes.Length * 2) + 2);

		try
		{
			foreach (var @byte in bytes)
			{
				_ = sb.Append(@byte.ToString("X2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Combines an array of strings into a single string, optionally adding a line feed after each element.
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// </summary>
	/// <param name="addLineFeed">If set to <c>true</c>, adds a line feed after each element.</param>
	/// <param name="args">The array of strings to combine.</param>
	/// <returns>A combined string with or without line feeds after each element based on <paramref name="addLineFeed"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Combine), "David McCarter", "12/23/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string Combine(in bool addLineFeed = false, [NotNull] params string[] args)
	{
		if (args == null || args.Length == 0)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			//ASSPAN, IMMUTABLEARRAY IS Slower!
			foreach (var arg in args)
			{
				_ = addLineFeed ? sb.AppendLine(arg) : sb.Append(arg);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Combines an array of strings into a single string, adding a space between each word.
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// </summary>
	/// <param name="args">The array of strings to combine.</param>
	/// <returns>A combined string with spaces between each word.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Combine), "David McCarter", "3/6/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.New)]
	public static string CombineWithSpace([NotNull] params string[] args)
	{
		if (args == null || args.Length == 0)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			//ASSPAN, IMMUTABLEARRAY IS Slower!
			for (var index = 0; index < args.Length; index++)
			{
				_ = sb.Append(args[index]);

				if (index < args.Length - 1)
				{
					_ = sb.Append(ControlChars.Space);
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Concatenates an array of strings using a specified delimiter, optionally adding a line feed after each element.
	/// This method is a wrapper over <see cref="ConcatStrings(string, bool, string[])"/> for convenience when using a char delimiter.
	/// </summary>
	/// <param name="delimiter">The character used to separate each string in the output.</param>
	/// <param name="addLineFeed">If set to <c>true</c>, adds a line feed after each element instead of using the delimiter.</param>
	/// <param name="args">The array of strings to concatenate.</param>
	/// <returns>A concatenated string with elements separated by <paramref name="delimiter"/> or line feeds based on <paramref name="addLineFeed"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Concat), "David McCarter", "2/19/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Concat([ConstantExpected] char delimiter = ControlChars.Comma, in bool addLineFeed = false, [NotNull] params string[] args)
	{
		if (args == null || args.Length == 0)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			var itemCount = args.Length;

			for (var index = 0; index < itemCount; index++)
			{
				_ = sb.Append(args[index]);

				if (index < itemCount - 1)
				{
					_ = addLineFeed ? sb.AppendLine() : sb.Append(delimiter);
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Concatenates the strings.
	/// </summary>
	/// <param name="delimiter">The delimiter.</param>
	/// <param name="addLineFeed">if set to <c>true</c> [add line feed].</param>
	/// <param name="args">The arguments.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Concat), "David McCarter", "2/19/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Concat(string delimiter = ControlChars.CommaSpace, in bool addLineFeed = false, [NotNull] params string[] args)
	{
		if (args == null || args.Length == 0)
		{
			return ControlChars.EmptyString;
		}

		if (delimiter == null)
		{
			delimiter = ControlChars.CommaSpace;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			var itemCount = args.Length;

			for (var index = 0; index < itemCount; index++)
			{
				_ = sb.Append(args[index]);

				if (index < itemCount - 1)
				{
					_ = addLineFeed ? sb.AppendLine() : sb.Append(delimiter);
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}


	/// <summary>
	/// Formats a string using the specified format and arguments.
	/// </summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="args">An array of objects to format.</param>
	/// <returns>A formatted string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Format), "David McCarter", "03/04/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string Format(string format, params string[] args)
	{
		if (args.CheckItemsExists() == false || format.CheckIsNotNull() == false)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			return sb.AppendFormat(CultureInfo.CurrentCulture, format, args).ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Joins an enumerable collection of strings with a specified delimiter.
	/// </summary>
	/// <param name="delimiter">The delimiter to use between each string.</param>
	/// <param name="values">The collection of strings to join.</param>
	/// <returns>A single string with the values joined by the delimiter.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Join), "David McCarter", "03/04/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string Join([NotNull] IEnumerable<string> values, [ConstantExpected] in char delimiter = ControlChars.Comma)
	{
		if (values?.Any() == false)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			using var enumerator = values.GetEnumerator();

			if (enumerator.MoveNext())
			{
				_ = sb.Append(enumerator.Current);
			}

			while (enumerator.MoveNext())
			{
				_ = sb.Append(delimiter).Append(enumerator.Current);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Joins an enumerable collection of strings with a specified delimiter.
	/// </summary>
	/// <param name="delimiter">The delimiter to use between each string.</param>
	/// <param name="values">The collection of strings to join.</param>
	/// <returns>A single string with the values joined by the delimiter.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Join), "David McCarter", "03/04/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string Join([NotNull] IEnumerable<string> values, string delimiter = ControlChars.CommaSpace)
	{
		if (values?.Any() != true)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			using var enumerator = values.GetEnumerator();

			if (enumerator.MoveNext())
			{
				_ = sb.Append(enumerator.Current);
			}

			while (enumerator.MoveNext())
			{
				_ = sb.Append(delimiter).Append(enumerator.Current);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Performs the specified action on a <see cref="StringBuilder"/> instance obtained from an object pool.
	/// This approach improves performance by reducing memory allocations.
	/// </summary>
	/// <param name="action">The action to perform on the <see cref="StringBuilder"/>. Must not be null.</param>
	/// <returns>A string resulting from the action performed on the <see cref="StringBuilder"/>.</returns>
	/// <example>
	/// Here is an example of using PerformAction method:
	/// <code>
	/// var result = FastStringBuilder.PerformAction(sb => 
	/// {
	///     sb.Append("Hello, ");
	///     sb.Append("world!");
	/// });
	/// Console.WriteLine(result); // Output: Hello, world!
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PerformAction), "David McCarter", "12/23/2022", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string PerformAction([NotNull] in Action<StringBuilder> action)
	{
		if (action is null)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			action.Invoke(sb);
			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}

	}

	/// <summary>
	/// Removes all occurrences of a specified string from the input string using a StringBuilder from an ObjectPool.
	/// </summary>
	/// <param name="input">The input string to remove the specified string from.</param>
	/// <param name="toRemove">The string to remove from the input string.</param>
	/// <returns>A new string with all occurrences of the specified string removed.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Remove), "David McCarter", "03/05/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string Remove(string input, string toRemove)
	{
		if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(toRemove))
		{
			return input ?? ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			var startIndex = 0;
			int index;

			while ((index = input.IndexOf(toRemove, startIndex, StringComparison.Ordinal)) != -1)
			{
				_ = sb.Append(input, startIndex, index - startIndex);
				startIndex = index + toRemove.Length;
			}

			if (startIndex < input.Length)
			{
				_ = sb.Append(input, startIndex, input.Length - startIndex);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Converts a dictionary to a delimited string, useful for serialization or creating CSV-like outputs. This method efficiently builds a string representation of key-value pairs, with a specified delimiter.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The dictionary to convert.</param>
	/// <param name="delimiter">The delimiter to use between each key-value pair.</param>
	/// <returns>A string representation of the dictionary, with each key-value pair separated by the specified delimiter.</returns>
	/// <remarks>
	/// This method is optimized for performance by using a StringBuilder from an ObjectPool, reducing memory allocations.
	/// Example output: <code>CKpPdnfyf: CKpPdnfyf,T\\\\^wwVx: T\\\\^wwVx,S`ikV: S`ikV,uHTR[yy: uHTR[yy,PNmB_h: PNmB_</code>
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToDelimitedString), "David McCarter", "1/1/2021", Status = Status.Available, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static string ToDelimitedString<TKey, TValue>([NotNull] in Dictionary<TKey, TValue> collection, [ConstantExpected] in char delimiter = ControlChars.Comma)
	{
		if (collection == null || collection.Count == 0)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			//FrozenDictionary, ImmutableArray and FrozenSet is slower.
			foreach (var item in collection)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter);
				}

				_ = sb.Append(item.Key).Append(ControlChars.Colon).Append(item.Value);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}
}
