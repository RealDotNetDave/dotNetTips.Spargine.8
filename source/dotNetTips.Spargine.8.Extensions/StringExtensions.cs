// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-04-2025
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Common String Extensions.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.RegularExpressions;
using DotNetTips.Spargine.Extensions;
using Microsoft.Extensions.ObjectPool;
//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a collection of static methods for string manipulation and checks, enhancing the built-in string functionality.
/// </summary>
/// <remarks>
/// The <see cref="StringExtensions"/> class includes methods for various string operations such as computing hashes,
/// checking for specific content within strings (e.g., email addresses, domain names, GUIDs), converting strings to different formats or encodings,
/// and performing manipulations like concatenation, extraction, and indentation. These utilities aim to simplify common string handling tasks
/// in .NET applications.
/// </remarks>
[Information(Documentation = "https://bit.ly/SpargineStringExtensions", Status = Status.Available)]
public static class StringExtensions
{
	/// <summary>
	/// Provides a static instance of the <see cref="ASCIIEncoding"/> class for use throughout the StringExtensions class.
	/// This encoding is used for operations that require ASCII character encoding.
	/// </summary>
	private static readonly ASCIIEncoding _encoding = new();


	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Computes the hash of the given input string using the specified hash algorithm.
	/// </summary>
	/// <param name="input">The input string to compute the hash for. Must not be null.</param>
	/// <param name="hash">The hash algorithm type to use for computing the hash.</param>
	/// <returns>A byte array containing the computed hash of the input string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the specified hash algorithm is not supported.</exception>
	/// <remarks>
	/// This method utilizes the <see cref="HashAlgorithm"/> class to compute the hash.
	/// </remarks>
	private static byte[] GetHash([NotNull] string input, HashType hash)
	{
		var inputBytes = Encoding.ASCII.GetBytes(input);

		switch (hash)
		{
			case HashType.SHA256:
				{
					return SHA256.HashData(inputBytes);
				}
			case HashType.SHA384:
				{
					return SHA384.HashData(inputBytes);
				}
			case HashType.SHA512:
				{
					return SHA512.HashData(inputBytes);
				}
			default:
				break;
		}

		return [];
	}

	/// <summary>
	/// Calculates the size of a byte array needed to store the Base64 encoded version of the input string.
	/// </summary>
	/// <param name="input">The input string to be encoded.</param>
	/// <returns>The size of the byte array needed to store the Base64 encoded string, or 0 if the input is null or empty.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the input string is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculateByteArraySize), "David McCarter", "11/6/2024", BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static int CalculateByteArraySize([NotNull] this string input) => input.IsNullOrEmpty() ? 0 : input.Length * 3 / 4;

	/// <summary>
	/// Combines an array of strings into a single string using the <see cref="FastStringBuilder.Combine"/> method.
	/// </summary>
	/// <param name="input">The initial string to start the combination. Must not be null.</param>
	/// <param name="args">An array of strings to combine with the initial string. Must not be null.</param>
	/// <returns>A combined string.</returns>
	[Information(nameof(Concat), "David McCarter", "1/3/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string CombineToString([NotNull] this string input, [NotNull] params string[] args) => FastStringBuilder.Combine(false, args.ArgumentNotNull().AddFirst(input.ArgumentNotNull()));

	/// <summary>
	/// Computes the hash of the given input string using the specified hash algorithm.
	/// </summary>
	/// <param name="input">The input string to compute the hash for. Must not be null.</param>
	/// <param name="hashType">The type of hash algorithm to use, specified by the <see cref="HashType"/> enum. Defaults to <see cref="HashType.SHA256"/>.</param>
	/// <returns>A string representation of the computed hash.</returns>
	[Information(nameof(ComputeHash), "David McCarter", "10/8/2020", "1/9/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string ComputeHash([NotNull] this string input, HashType hashType = HashType.SHA256)
	{
		if (input.IsNullOrEmpty())
		{
			return ControlChars.EmptyString;
		}

		var hash = GetHash(input, hashType);

		var sb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			foreach (var hashItem in hash.AsSpan())
			{
				_ = sb.Append(hashItem.ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString().ToTrimmed();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Computes the SHA256 hash of the given input string.
	/// </summary>
	/// <param name="input">The input string to compute the hash for. Must not be null.</param>
	/// <returns>A string representation of the SHA256 hash.</returns>
	/// <remarks>
	/// This method uses the <see cref="SHA256"/> class to compute the hash.
	/// </remarks>
	[Information(nameof(ComputeSHA256Hash), "David McCarter", "9/15/2017", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ComputeSHA256Hash([NotNull] this string input)
	{
		if (input.IsNullOrEmpty())
		{
			return ControlChars.EmptyString;
		}

		// Create a SHA256
		// ComputeHash - returns byte array
		var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));

		// Convert byte array to a string
		return bytes.BytesToString();
	}

	/// <summary>
	/// Concatenates the given strings using the specified delimiter, with an option to add a line feed after each string.
	/// </summary>
	/// <param name="input">The initial string to start the concatenation. Must not be null.</param>
	/// <param name="delimiter">The delimiter to use for concatenation. Must not be null.</param>
	/// <param name="addLineFeed">If true, adds a line feed after each string.</param>
	/// <param name="args">An array of strings to concatenate. Must not be null.</param>
	/// <returns>A concatenated string.</returns>
	/// <remarks>
	/// This method uses the String.Join(string, string[]) method internally to perform the concatenation.
	/// </remarks>
	[Information(nameof(Concat), "David McCarter", "9/15/2017", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static string Concat([NotNull] this string input, [NotNull][ConstantExpected] string delimiter, bool addLineFeed, [NotNull] params string[] args)
	{
		if (input.IsNullOrEmpty())
		{
			return ControlChars.EmptyString;
		}

		if (delimiter.IsNullOrEmpty())
		{
			delimiter = ControlChars.EmptyString;
		}

		if (args is null)
		{
			return input;
		}

		var sb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			sb = sb.Append(input);

			if (args.HasItems())
			{
				foreach (var arg in args)
				{
					_ = addLineFeed
						? sb.AppendLine(arg)
						: sb.Append(string.Concat(arg, delimiter));
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Determines whether the input string contains any of the specified characters, using the specified string comparison option.
	/// </summary>
	/// <param name="input">The input string to check. Must not be null.</param>
	/// <param name="stringComparison">The string comparison option to use. Defaults to <see cref="StringComparison.OrdinalIgnoreCase"/>.</param>
	/// <param name="characters">The characters to check for in the input string. Must not be null.</param>
	/// <returns><c>true</c> if the input string contains any of the specified characters; otherwise, <c>false</c>.</returns>
	[Information(nameof(ContainsAny), "David McCarter", "9/15/2017", "2/9/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsAny([NotNull] this string input, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase, [NotNull] params string[] characters)
	{
		if (input is null || characters.CheckItemsExists() is false)
		{
			return false;
		}

		stringComparison = stringComparison.ArgumentDefined();

		return characters.LongLength != 0 && characters.FastAny(character => input.Contains(character, stringComparison));
	}

	/// <summary>
	/// Returns the original string if it is not null; otherwise, returns an empty string.
	/// </summary>
	/// <param name="value">The string to check for null.</param>
	/// <returns>The original string if not null; otherwise, <see cref="string.Empty"/>.</returns>
	[Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string DefaultIfNull([AllowNull] this string value) => value ?? string.Empty;

	/// <summary>
	/// Returns the original string if it is not null; otherwise, returns the specified default value or an empty string if the default value is also null.
	/// </summary>
	/// <param name="value">The string to check for null.</param>
	/// <param name="defaultValue">The default value to return if the string is null. This can also be null, in which case an empty string is returned.</param>
	/// <returns>The original string if it is not null; otherwise, the default value if it is not null; otherwise, <see cref="string.Empty"/>.</returns>
	[Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string DefaultIfNull([AllowNull] this string value, [AllowNull] string defaultValue) => value switch
	{
		null when defaultValue is not null => defaultValue,
		_ => string.Empty,
	};

	/// <summary>
	/// Returns the original string if it is not null or empty; otherwise, returns the specified default value.
	/// </summary>
	/// <param name="value">The string to check for null or emptiness.</param>
	/// <param name="defaultValue">The default value to return if the string is null or empty. This value must not be null.</param>
	/// <returns>The original string if it is not null or empty; otherwise, the <paramref name="defaultValue"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="defaultValue"/> is null.</exception>
	/// <remarks>
	/// This method uses <see cref="string.IsNullOrEmpty(string)"/> to check if the string is null or empty.
	/// </remarks>
	[Information(nameof(DefaultIfNullOrEmpty), "David McCarter", "9/15/2017", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string DefaultIfNullOrEmpty([AllowNull] this string value, [NotNull] string defaultValue)
	{
		defaultValue = defaultValue.ArgumentNotNull();

		return string.IsNullOrEmpty(value) ? defaultValue : value;
	}

	/// <summary>
	/// Splits a delimited string into an array of strings, removing empty entries.
	/// </summary>
	/// <param name="input">The input string to split.</param>
	/// <param name="delimiter">The character delimiter to split the string by. Default is a comma.</param>
	/// <returns>An array of strings that were delimited by the specified character.</returns>
	[Information(nameof(DelimitedStringToArray), "David McCarter", "8/13/2020", "8/13/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static string[] DelimitedStringToArray([NotNull] this string input, [ConstantExpected] in char delimiter = ControlChars.Comma) => string.IsNullOrEmpty(input) ? [] : input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

	/// <summary>
	/// Determines whether the end of this string instance matches the specified string when compared using the specified comparison option.
	/// </summary>
	/// <param name="input">The input string to compare.</param>
	/// <param name="inputToCompare">The string to compare to the end of the input string.</param>
	/// <returns><c>true</c> if <paramref name="inputToCompare"/> matches the end of this string; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses <see cref="string.Equals(string, string, StringComparison)"/> for comparison.
	/// </remarks>
	[Information(nameof(EqualsIgnoreCase), "David McCarter", "7/15/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool EqualsIgnoreCase([NotNull] this string input, [NotNull] string inputToCompare) => input is null || inputToCompare is null ? false : string.Equals(input, inputToCompare, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Determines whether the specified string is equal to the current string, ignoring case, or if both are null or empty.
	/// </summary>
	/// <param name="input">The first string to compare.</param>
	/// <param name="inputToCompare">The second string to compare.</param>
	/// <returns>true if the value of the <paramref name="input"/> parameter is equal to the value of the <paramref name="inputToCompare"/> parameter, ignoring case, or if both are null or empty; otherwise, false.</returns>
	/// <remarks>
	/// This method uses <see cref="string.Equals(string?, string?, StringComparison)"/> with <see cref="StringComparison.Ordinal"/> to perform the comparison.
	/// </remarks>

	[Information(nameof(EqualsOrBothNullOrEmpty), "David McCarter", "7/15/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool EqualsOrBothNullOrEmpty([NotNull] this string input, [NotNull] string inputToCompare) => string.Equals(input ?? string.Empty, inputToCompare ?? string.Empty, StringComparison.Ordinal);

	/// <summary>
	/// Extracts a substring from the input string that is between the specified start and end strings.
	/// </summary>
	/// <param name="input">The input string to extract from.</param>
	/// <param name="start">The starting string to look for.</param>
	/// <param name="end">The ending string to look for.</param>
	/// <returns>The extracted substring between the start and end strings.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the input, start, or end string is null or empty.</exception>
	[Information(nameof(Extract), "David McCarter", "10/8/2020", "2/9/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Extract([NotNull] this string input, [NotNull] string start, [NotNull] string end)
	{
		input = input.ArgumentNotNullOrEmpty();
		start = start.ArgumentNotNullOrEmpty();
		end = end.ArgumentNotNullOrEmpty();

		var startIndex = input.IndexOf(start, StringComparison.Ordinal);
		var endIndex = input.IndexOf(end, StringComparison.Ordinal);

		return input[startIndex..endIndex];
	}

	/// <summary>
	/// Compares two strings using the specified string comparison option.
	/// </summary>
	/// <param name="value">The first string to compare. Must not be null.</param>
	/// <param name="valueToCompare">The second string to compare. Must not be null.</param>
	/// <param name="comparison">The string comparison option to use. Must not be null.</param>
	/// <returns><c>true</c> if the strings are equal according to the specified comparison option; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="value"/>, <paramref name="valueToCompare"/>, or <paramref name="comparison"/> is null.</exception>
	[Information(nameof(FastCompare), "David McCarter", "2/16/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static bool FastCompare([NotNull] this string value, [NotNull] string valueToCompare, [NotNull] in StringComparison comparison) => string.Equals(value, valueToCompare, comparison);

	/// <summary>
	/// Decodes a string from Base64 encoding.
	/// </summary>
	/// <param name="input">The Base64 encoded string to decode.</param>
	/// <returns>A decoded string from the Base64 encoded <paramref name="input"/>.</returns>
	/// <remarks>
	/// This method decodes the string using <see cref="Convert.FromBase64String(string)"/> and then converts the byte array to a string using <see cref="Encoding.UTF8"/>.
	/// </remarks>
	[Information(nameof(FromBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string FromBase64([NotNull] this string input) => input.IsNullOrEmpty() ? ControlChars.EmptyString : _encoding.GetString(Convert.FromBase64String(input));

	/// <summary>
	/// Decompresses a Brotli compressed string asynchronously.
	/// </summary>
	/// <param name="value">The Brotli compressed string.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous decompression operation. The value of the TResult parameter contains the decompressed string.</returns>
	/// <remarks>
	/// This method uses <see cref="BrotliStream"/> for decompression.
	/// Original code from: https://khalidabuhakmeh.com/compress-strings-with-dotnet-and-csharp
	/// </remarks>
	[Information(nameof(FromBrotliStringAsync), "David McCarter", "10/24/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> FromBrotliStringAsync(this string value, CancellationToken cancellationToken = default)
	{
		var input = new MemoryStream(Convert.FromBase64String(value.ArgumentNotNull()));

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new BrotliStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output, cancellationToken).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Decompresses a Deflate compressed string asynchronously.
	/// </summary>
	/// <param name="value">The Deflate compressed string.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous decompression operation. The value of the TResult parameter contains the decompressed string.</returns>
	/// <remarks>
	/// This method uses <see cref="DeflateStream"/> for decompression.
	/// </remarks>
	[Information(nameof(FromDeflateStringAsync), "David McCarter", "9/12/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<string> FromDeflateStringAsync(this string value, CancellationToken cancellationToken = default)
	{
		var bytes = Convert.FromBase64String(value.ArgumentNotNull());
		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new DeflateStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output, cancellationToken).ConfigureAwait(false);
							await stream.FlushAsync(cancellationToken).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Decompresses a GZip compressed string asynchronously.
	/// </summary>
	/// <param name="value">The GZip compressed string.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous decompression operation. The value of the TResult parameter contains the decompressed string.</returns>
	/// <remarks>
	/// This method uses <see cref="GZipStream"/> for decompression.
	/// Original code from: https://khalidabuhakmeh.com/compress-strings-with-dotnet-and-csharp
	/// </remarks>
	[Information(nameof(FromGZipStringAsync), "David McCarter", "10/24/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> FromGZipStringAsync(this string value, CancellationToken cancellationToken = default)
	{
		value = value.ArgumentNotNullOrEmpty();

		var bytes = new byte[value.CalculateByteArraySize()];
		_ = Convert.TryFromBase64String(value, bytes, out _);

		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new GZipStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output, cancellationToken).ConfigureAwait(false);
							await stream.FlushAsync(cancellationToken).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Decompresses a ZLib compressed string asynchronously.
	/// </summary>
	/// <param name="value">The ZLib compressed string.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous decompression operation. The value of the TResult parameter contains the decompressed string.</returns>
	/// <remarks>
	/// This method uses <see cref="DeflateStream"/> for decompression, as ZLib compression is closely related to the Deflate compression algorithm.
	/// </remarks>
	[Information(nameof(FromZLibStringAsync), "David McCarter", "9/12/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<string> FromZLibStringAsync(this string value, CancellationToken cancellationToken = default)
	{
		var bytes = Convert.FromBase64String(value.ArgumentNotNull());
		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new ZLibStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output, cancellationToken).ConfigureAwait(false);
							await stream.FlushAsync(cancellationToken).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
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
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasValue([NotNull] this string input) => input is not null && (input.Trim().Length > 0);

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
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasValue([NotNull] this string input, int length)
	{
		length = length.ArgumentInRange(lower: 1, upper: length);

		return input is not null && (input.ArgumentNotNull().Trim().Length == length);
	}

	/// <summary>
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
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasValue([NotNull] this string input, [NotNull] string value) => input.HasValue() && string.Equals(input, value, StringComparison.Ordinal);

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
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasValue([NotNull] this string input, [NotNull][StringSyntax(StringSyntaxAttribute.Regex)] string expression, [NotNull] RegexOptions options) => input.HasValue() && expression.HasValue() && new Regex(expression, options.ArgumentDefined()).IsMatch(input);

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
	public static bool HasValue([NotNull] this string input, int minLength, int maxLength)
	{
		minLength = minLength.ArgumentInRange(lower: 0, upper: maxLength);
		maxLength = maxLength.ArgumentInRange(lower: minLength, upper: int.MaxValue);

		return input is not null && input.Length.IsInRange(minLength, maxLength);
	}

	/// <summary>
	/// Determines whether the specified string contains any whitespace characters.
	/// </summary>
	/// <param name="input">The string to check for whitespace.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> contains any whitespace characters; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses <see cref="char.IsWhiteSpace(char)"/> to check each character in the string for whitespace.
	/// </remarks>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasWhitespace([NotNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		//Span is slower
		foreach (var inputItem in input)
		{
			if (!IsAsciiWhitespace(inputItem))
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Indents each line of the input string by the specified length using the specified indentation character.
	/// </summary>
	/// <param name="input">The input string to indent.</param>
	/// <param name="length">The number of indentation characters to add to each line.</param>
	/// <param name="indentationCharacter">The character to use for indentation.</param>
	/// <returns>The indented string.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the input string is null.</exception>
	[Information(nameof(Indent), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static string Indent([NotNull] this string input, in int length, [ConstantExpected] in char indentationCharacter)
	{
		if (input.CheckIsNotNull() is false || length <= 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			if (length == 0)
			{
				_ = sb.Append(input.ArgumentNotNull());
			}

			for (var charIndex = 1; charIndex <= Math.Abs(length); charIndex++)
			{
				_ = sb.Append(indentationCharacter);
			}

			if (length > 0)
			{
				_ = sb.Append(input);
			}

			return sb.ToString().TrimEnd();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Determines whether the specified character is an ASCII digit.
	/// </summary>
	/// <param name="character">The character to evaluate.</param>
	/// <returns><c>true</c> if the character is an ASCII digit; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks if the character is a digit using <see cref="char.IsDigit(char)"/>.
	/// </remarks>
	[Information(nameof(IsAsciiDigit), author: "David McCarter", createdOn: "6/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsAsciiDigit(in this char character) => char.IsDigit(character.ArgumentNotNull());

	/// <summary>
	/// Determines whether the specified character is an ASCII letter.
	/// </summary>
	/// <param name="character">The character to evaluate.</param>
	/// <returns><c>true</c> if the character is an ASCII letter; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks if the character is a letter using <see cref="char.IsLetter(char)"/>.
	/// </remarks>
	[Information(nameof(IsAsciiLetter), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsAsciiLetter(in this char character) => char.IsLetter(character.ArgumentNotNull());

	/// <summary>
	/// Determines whether the specified character is an ASCII letter or digit.
	/// </summary>
	/// <param name="character">The character to evaluate.</param>
	/// <returns><c>true</c> if the character is an ASCII letter or digit; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks if the character is a letter or digit using <see cref="char.IsLetterOrDigit(char)"/>.
	/// </remarks>
	[Information(nameof(IsAsciiLetterOrDigit), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsAsciiLetterOrDigit(in this char character) => char.IsLetterOrDigit(character.ArgumentNotNull());

	/// <summary>
	/// Determines whether the specified character is an ASCII whitespace character.
	/// </summary>
	/// <param name="character">The character to evaluate.</param>
	/// <returns><c>true</c> if the character is an ASCII whitespace character; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks if the character is a whitespace character using <see cref="char.IsWhiteSpace(char)"/>.
	/// </remarks>
	[Information(nameof(IsAsciiWhitespace), author: "David McCarter", createdOn: "6/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsAsciiWhitespace(in this char character) => char.IsWhiteSpace(character.ArgumentNotNull());

	/// <summary>
	/// Determines whether the specified string is a valid credit card number.
	/// </summary>
	/// <param name="input">The string to validate as a credit card number.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid credit card number; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the credit card number.
	/// </remarks>
	[return: NotNull]
	[Information(nameof(IsCreditCardNumber), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsCreditCardNumber([NotNull] this string input) => RegexProcessor.IsCreditCardNumber(input);

	/// <summary>
	/// Determines whether the specified string is a valid currency code.
	/// </summary>
	/// <param name="input">The string to validate as a currency code.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid currency code; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the currency code.
	/// </remarks>
	[Information(nameof(IsCurrencyCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsCurrencyCode([NotNull] this string input) => RegexProcessor.IsCurrencyCode(input);

	/// <summary>
	/// Determines whether the specified string is a valid domain address.
	/// </summary>
	/// <param name="input">The string to validate as a domain address.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid domain address; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the domain address.
	/// </remarks>
	[return: NotNull]
	[Information(nameof(IsDomainAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsDomainAddress([NotNull] this string input) => RegexProcessor.IsUrlDomainAddress(input);

	/// <summary>
	/// Determines whether the specified string is a valid email address.
	/// </summary>
	/// <param name="input">The string to validate as an email address.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid email address; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the email address.
	/// </remarks>
	[return: NotNull]
	[Information(nameof(IsEmailAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsEmailAddress([NotNull] this string input) => RegexProcessor.IsEmailAddress(input);

#nullable enable
	/// <summary>
	/// Determines whether the specified string is empty.
	/// </summary>
	/// <param name="input">The string to check.</param>
	/// <returns><c>true</c> if the string is null or empty; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses <see cref="string.IsNullOrEmpty(string)"/> to check if the string is empty.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEmpty), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public static bool IsEmpty([NotNullWhen(false)] this string? input) => string.IsNullOrEmpty(input);
#nullable disable

	/// <summary>
	/// Determines whether the specified string is a valid first and last name.
	/// </summary>
	/// <param name="input">The string to validate as a first and last name.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> matches the first and last name pattern; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the first and last name.
	/// </remarks>
	[Information(nameof(IsFirstLastName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsFirstLastName([NotNull] this string input) => RegexProcessor.ContainsFirstLastName(input);

	/// <summary>
	/// Determines whether the specified string is a valid GUID.
	/// </summary>
	/// <param name="input">The string to validate as a GUID.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid GUID; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the GUID.
	/// </remarks>
	[Information(nameof(IsGuid), "David McCarter", "3/24/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsGuid([NotNull][StringSyntax(StringSyntaxAttribute.GuidFormat)] this string input) => RegexProcessor.IsGuid(input);

	/// <summary>
	/// Determines whether the specified string is a valid International Standard Book Number (ISBN).
	/// </summary>
	/// <param name="input">The string to validate as an ISBN.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid ISBN; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the ISBN.
	/// </remarks>
	[Information(nameof(IsISBN), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsISBN([NotNull] this string input) => RegexProcessor.IsISBN(input);

	/// <summary>
	/// Determines whether the specified string is a valid MAC address.
	/// </summary>
	/// <param name="input">The string to validate as a MAC address.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid MAC address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsMacAddress), "David McCarter", "3/24/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsMacAddress([NotNull] this string input) => RegexProcessor.IsMACAddress(input);

#nullable enable
	/// <summary>
	/// Determines whether the specified string is not empty.
	/// </summary>
	/// <param name="input">The string to check.</param>
	/// <returns><c>true</c> if the string is not empty; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks the opposite of <see cref="IsEmpty(string?)"/> to determine if a string is not empty.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNotEmpty), "David McCarter", "8/18/20", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public static bool IsNotEmpty(this string? input) => input.IsEmpty() is false;
#nullable disable

	/// <summary>
	/// Determines whether the specified string contains only characters in the range of '1' to '7' and is alphabetic.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string matches the pattern; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the input string.
	/// </remarks>
	[Information(nameof(IsOneToSevenAlpha), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsOneToSevenAlpha([NotNull] this string input) => RegexProcessor.IsOneToSevenAlpha(input);

	/// <summary>
	/// Determines whether the specified string is in scientific notation.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string is in scientific notation; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the input string.
	/// </remarks>
	[Information(nameof(IsScientific), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsScientific([NotNull] this string input) => RegexProcessor.IsScientific(input);

	/// <summary>
	/// Determines whether the specified string matches the pattern defined in the regular expression.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string matches the pattern; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsString([NotNull] this string input) => RegexProcessor.IsValidString(input);

	/// <summary>
	/// Determines whether the specified string is a valid SHA1 hash.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string is a valid SHA1 hash; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the input string.
	/// </remarks>
	[Information(nameof(IsStringSHA1Hash), "David McCarter", "5/31/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsStringSHA1Hash([NotNull] this string input) => RegexProcessor.IsSHA1Hash(input);

	/// <summary>
	/// Determines whether the specified string is a valid URL.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string is a valid URL; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the input string.
	/// </remarks>
	[Information(nameof(IsUrl), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsUrl([NotNull] this string input) => RegexProcessor.IsUrl(input);

	/// <summary>
	/// Removes all carriage return and line feed characters from the specified string.
	/// </summary>
	/// <param name="input">The string from which to remove carriage return and line feed characters.</param>
	/// <param name="replacement">The string to replace carriage return and line feed characters with. Defaults to an empty string.</param>
	/// <returns>A new string with all carriage return and line feed characters replaced by the specified replacement string.</returns>
	/// <remarks>
	/// This method uses a regular expression to identify and replace carriage return and line feed characters.
	/// </remarks>
	[Information(nameof(RemoveCRLF), "Kristine Tran", "2/1/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string RemoveCRLF([NotNull] this string input, [NotNull] string replacement = "") => RegexProcessor.ReplaceCrLf(input, replacement);

	/// <summary>
	/// Replaces all occurrences of an ellipsis (...) in the specified string with a period (.).
	/// </summary>
	/// <param name="input">The string to modify.</param>
	/// <returns>A new string with all ellipses replaced by periods.</returns>
	/// <remarks>
	/// This method is useful for normalizing text that uses ellipses.
	/// </remarks>
	[Information(nameof(ReplaceEllipsisWithPeriod), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ReplaceEllipsisWithPeriod([NotNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty(true);

		if (input.EndsWith("...", StringComparison.OrdinalIgnoreCase))
		{
			input = input[0..^2];
		}

		return input;
	}

	/// <summary>
	/// Splits the input string into a <see cref="ReadOnlyCollection{T}"/> of strings,
	/// separated by the specified <paramref name="separator"/>.
	/// The <paramref name="options"/> parameter specifies whether to include empty array elements in the array returned.
	/// </summary>
	/// <param name="input">The string to split.</param>
	/// <param name="options">Options for controlling the splitting operation.</param>
	/// <param name="separator">The character to use as a separator. <see cref="ControlChars.Comma"/> is the default.</param>
	/// <returns>A <see cref="ReadOnlyCollection{T}"/> of strings that has been split from the input string.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static ReadOnlyCollection<string> Split([NotNull] this string input, StringSplitOptions options, [ConstantExpected] in char separator = ControlChars.Comma)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined();

		return input.Split([separator], options).AsReadOnly();
	}

	/// <summary>
	/// Splits the input string into a <see cref="ReadOnlyCollection{String}"/> of strings,
	/// separated by the specified <paramref name="separator"/>.
	/// The <paramref name="options"/> parameter specifies whether to include empty array elements in the array returned.
	/// The <paramref name="count"/> parameter specifies the maximum number of substrings to return.
	/// </summary>
	/// <param name="input">The string to split.</param>
	/// <param name="options">Options for controlling the splitting operation, such as removing empty entries.</param>
	/// <param name="count">The maximum number of substrings to return.</param>
	/// <param name="separator">The character to use as a separator. Defaults to <see cref="ControlChars.Comma"/>.</param>
	/// <returns>A <see cref="ReadOnlyCollection{String}"/> of strings that has been split from the input string.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static ReadOnlyCollection<string> Split([NotNull] this string input, StringSplitOptions options, int count, [ConstantExpected] in char separator = ControlChars.Comma)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined();
		count = count.ArgumentInRange(lower: 1);

		return Array.AsReadOnly(input.Split([separator], count, options));
	}

	/// <summary>
	/// Splits the input string into a ReadOnlyCollection{string} of strings,
	/// separated by the specified <paramref name="separator"/>.
	/// The <paramref name="options"/> parameter specifies whether to include empty array elements in the array returned.
	/// The <paramref name="count"/> parameter specifies the maximum number of substrings to return.
	/// </summary>
	/// <param name="input">The string to split.</param>
	/// <param name="options">Options for controlling the splitting operation, such as removing empty entries.</param>
	/// <param name="count">The maximum number of substrings to return.</param>
	/// <param name="separator">The string to use as a separator. Defaults to <see cref="ControlChars.DefaultSeparator"/>.</param>
	/// <returns>A ReadOnlyCollection{string} of strings that has been split from the input string.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static ReadOnlyCollection<string> Split([NotNull] this string input, StringSplitOptions options, int count, [NotNull][ConstantExpected] string separator = ControlChars.DefaultSeparator)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined();
		count = count.ArgumentInRange(lower: 1);

		return new ReadOnlyCollection<string>(input.Split([separator], count, options));
	}

	/// <summary>
	/// Splits the input string into a sequence of lines.
	/// </summary>
	/// <param name="input">The string to split into lines.</param>
	/// <returns>A <see cref="LineSplitEnumerator"/> that can iterate over each line in the input string.</returns>
	/// <remarks>
	/// This method is an extension method and can be called directly on any string instance.
	/// It is particularly useful for processing multi-line strings.
	/// </remarks>
	[return: NotNull]
	[Information(nameof(SplitLines), "David McCarter", "6/9/2022", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed)]
	public static LineSplitEnumerator SplitLines([NotNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		// LineSplitEnumerator is a struct so there is no allocation here
		return new LineSplitEnumerator(input.AsSpan());
	}

	/// <summary>
	/// Splits the input string by commas and removes any empty entries from the resulting array.
	/// </summary>
	/// <param name="input">The string to split. This string cannot be null.</param>
	/// <returns>A ReadOnlyCollection{string} containing the non-empty elements from the split string.</returns>
	/// <remarks>
	/// This method uses <see cref="string.Split(char[], StringSplitOptions)"/> internally with <see cref="StringSplitOptions.RemoveEmptyEntries"/> to remove empty entries.
	/// </remarks>
	[return: NotNull]
	[Information(nameof(SplitRemoveEmpty), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> SplitRemoveEmpty([NotNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		return input.Trim().Split([ControlChars.Comma], options: StringSplitOptions.RemoveEmptyEntries).ToReadOnlyCollection();
	}

	/// <summary>
	/// Determines whether the beginning of this string instance matches the specified string when compared using the ordinal sort order.
	/// </summary>
	/// <param name="input">The string to check. This string cannot be null.</param>
	/// <param name="inputToCompare">The string to compare to the beginning of this string. This string cannot be null.</param>
	/// <returns><c>true</c> if <paramref name="inputToCompare"/> matches the beginning of this string; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method performs an ordinal (case-sensitive and culture-insensitive) comparison.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StartsWithOrdinal), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static bool StartsWithOrdinal([NotNull] this string input, [NotNull] string inputToCompare) => input.StartsWith(inputToCompare, StringComparison.Ordinal);

	/// <summary>
	/// Determines whether the beginning of this string instance matches the specified string when compared using the ordinal sort order and ignoring case.
	/// </summary>
	/// <param name="input">The string to check. This string cannot be null.</param>
	/// <param name="inputToCompare">The string to compare to the beginning of this string. This string cannot be null.</param>
	/// <returns><c>true</c> if <paramref name="inputToCompare"/> matches the beginning of this string, ignoring case; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method performs a comparison using <see cref="StringComparison.OrdinalIgnoreCase"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static bool StartsWithOrdinalIgnoreCase([NotNull] this string input, [NotNull] string inputToCompare) => string.IsNullOrEmpty(input) || string.IsNullOrEmpty(inputToCompare)
			? false
			: input.StartsWith(inputToCompare, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Trims whitespace from the start and end of the substring extracted from the specified range of the input string.
	/// </summary>
	/// <param name="input">The input string from which to extract and trim the substring.</param>
	/// <param name="startIndex">The zero-based starting character position of a substring in this instance.</param>
	/// <param name="length">The number of characters in the substring.</param>
	/// <returns>A string that is equivalent to the substring of length that begins at startIndex in input, but with white-space characters removed from the start and end.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="startIndex"/> or <paramref name="length"/> is less than zero, or <paramref name="startIndex"/> + <paramref name="length"/> is greater than the length of <paramref name="input"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNull]
	[Information(nameof(SubstringTrim), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static string SubstringTrim(this string input, in int startIndex, in int length)
	{
		if (input.IsNullOrEmpty())
		{
			return ControlChars.EmptyString;
		}

		if (startIndex < 0 || length < 0 || startIndex + length > input.Length)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(length));
		}

		// SUGGESTION FROM COPILOT SLOWER.
		return input.AsSpan(startIndex, length).ToString().Trim();
	}

	/// <summary>
	/// Converts the input string to its Base64 encoded form.
	/// </summary>
	/// <param name="input">The string to encode.</param>
	/// <returns>A Base64 encoded string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	[Information(nameof(ToBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ToBase64([NotNull] this string input) => input.IsNullOrEmpty() ? ControlChars.EmptyString : Convert.ToBase64String(_encoding.GetBytes(input));

	/// <summary>
	/// Converts a Base64 encoded string to a byte span.
	/// </summary>
	/// <param name="input">The Base64 encoded string.</param>
	/// <returns>A span of bytes representing the decoded Base64 string.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the input string is null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToBase64ByteSpan), "David McCarter", "11/5/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Span<byte> ToBase64ByteSpan(this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		var span = new Span<byte>(new byte[input.Length * 3 / 4]);

		return Convert.TryFromBase64String(input, span, out var bytesWritten) ? span[..bytesWritten] : [];
	}

	/// <summary>
	/// Compresses the specified string using the Brotli algorithm and returns the compressed string in an asynchronous operation.
	/// </summary>
	/// <param name="input">The string to compress. This string cannot be null.</param>
	/// <param name="level">The compression level to use. Defaults to <see cref="CompressionLevel.Fastest"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{String}"/> representing the asynchronous operation, which upon completion, yields the Brotli compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: iw2AZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAA==
	/// NoCompression: iw2AZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAA==
	/// Optimal: iw0A+I+UrMG9dHJoJzwdrIKg1dYDoCSJKErYXLOsvkcYAw==
	/// SmallestSize: iw0A+I+UrMG9dHJoJzwdrIKg1dYDoCSJKErYXLOsvkcYAw==
	/// </example>
	[Information(nameof(ToBrotliStringAsync), "David McCarter", "10/24/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToBrotliStringAsync([NotNull] this string input, CompressionLevel level = CompressionLevel.Fastest, CancellationToken cancellationToken = default)
	{
		var inputStream = new MemoryStream(Encoding.Unicode.GetBytes(input.ArgumentNotNull()));

		await using (inputStream.ConfigureAwait(continueOnCapturedContext: false))
		{
			var outputStream = new MemoryStream();

			await using (outputStream.ConfigureAwait(continueOnCapturedContext: false))
			{
				var brotliStream = new BrotliStream(outputStream, level);

				await using (brotliStream.ConfigureAwait(continueOnCapturedContext: false))
				{
					await inputStream.CopyToAsync(brotliStream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					await brotliStream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

					return Convert.ToBase64String(outputStream.ToArray());
				}
			}
		}
	}

	/// <summary>
	/// Converts the specified string to a byte array using the provided encoding.
	/// </summary>
	/// <param name="input">The string to convert. This string cannot be null.</param>
	/// <param name="encoding">The encoding to use for the conversion. This cannot be null. See <see cref="Encoding"/> for encoding types.</param>
	/// <returns>A byte array representing the encoded string.</returns>
	[Information(nameof(ToByteArray), "David McCarter", "12/21/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static byte[] ToByteArray([NotNull] this string input, [NotNull] Encoding encoding)
	{
		input = input.ArgumentNotNullOrEmpty();
		encoding = encoding.ArgumentNotNull();

		return encoding.GetBytes(input);
	}

	/// <summary>
	/// Compresses the specified string using the Deflate algorithm and returns the compressed string in an asynchronous operation.
	/// </summary>
	/// <param name="input">The string to compress. This string cannot be null.</param>
	/// <param name="level">The compression level to use. Defaults to <see cref="CompressionLevel.Fastest"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{String}"/> representing the asynchronous operation, which upon completion, yields the Deflate compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: SmHIZyhh8GNIZShhCGHIZChgKGbQY0hmyGfIZQAAAAD//w==
	/// NoCompression: ABwA4/9kAG8AdABOAGUAdABUAGkAcABzAC4AYwBvAG0AAAAA//8=
	/// Optimal: SmHIZyhh8GNIBZIhDJkMBQzFDHoMyUDRXAYAAAAA//8=
	/// SmallestSize: SmHIZyhh8GNIBZIhDJkMBQzFDHoMyUDRXAYAAAAA//8=
	/// </example>
	[Information(nameof(ToDeflateStringAsync), "David McCarter", "9/12/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static async Task<string> ToDeflateStringAsync([NotNull] this string input, CompressionLevel level = CompressionLevel.Fastest, CancellationToken cancellationToken = default)
	{
		_ = input.ArgumentNotNull();

		using var inputMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(input));
		using var outputMemoryStream = new MemoryStream();
		using (var deflateStream = new DeflateStream(outputMemoryStream, level, true))
		{
			await inputMemoryStream.CopyToAsync(deflateStream, cancellationToken).ConfigureAwait(false);
		}

		return Convert.ToBase64String(outputMemoryStream.ToArray());
	}

	/// <summary>
	/// Compresses the specified string using the GZip algorithm and returns the compressed string in an asynchronous operation.
	/// </summary>
	/// <param name="input">The string to compress. This string cannot be null.</param>
	/// <param name="level">The compression level to use. Defaults to <see cref="CompressionLevel.Fastest"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{String}"/> representing the asynchronous operation, which upon completion, yields the GZip compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: H4sIAAAAAAAECkphyGcoYfBjSGUoYQhhyGQoYChm0GNIZshnyGUAAAAA//8=
	/// NoCompression: H4sIAAAAAAAECgAcAOP/ZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAAAAAP//
	/// Optimal: H4sIAAAAAAAACkphyGcoYfBjSAWSIQyZDAUMxQx6DMlA0VwGAAAAAP//
	/// SmallestSize: H4sIAAAAAAACCkphyGcoYfBjSAWSIQyZDAUMxQx6DMlA0VwGAAAAAP/
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(ToGZipStringAsync), "David McCarter", "10/24/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToGZipStringAsync([NotNull] this string input, CompressionLevel level = CompressionLevel.Fastest, CancellationToken cancellationToken = default)
	{
		_ = input.ArgumentNotNull();

		using var inputMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(input));
		using var outputMemoryStream = new MemoryStream();
		using (var gzipStream = new GZipStream(outputMemoryStream, level, true))
		{
			await inputMemoryStream.CopyToAsync(gzipStream, cancellationToken).ConfigureAwait(false);
		}

		return Convert.ToBase64String(outputMemoryStream.ToArray());
	}

	/// <summary>
	/// Converts the specified string to title case, considering culture-specific rules.
	/// </summary>
	/// <param name="input">The string to convert to title case. This string cannot be null.</param>
	/// <returns>A string converted to title case using <see cref="CultureInfo.CurrentCulture"/> rules.</returns>
	[Information(nameof(ToTitleCase), "David McCarter", "10/8/2020", "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ToTitleCase([NotNull] this string input) => input.IsNullOrEmpty() ? input : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);

	/// <summary>
	/// Trims the specified string, removing all leading and trailing white-space characters. If the input is null, an empty string is returned.
	/// </summary>
	/// <param name="input">The string to trim. If this string is null, an empty string is returned.</param>
	/// <returns>A trimmed string, or an empty string if the input is null.</returns>
	[Information(nameof(ToTrimmed), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ToTrimmed([AllowNull] this string input) => input.IsNullOrEmpty() ? input : input.Trim();

	/// <summary>
	/// Compresses the specified string using the ZLib algorithm and returns the compressed string in an asynchronous operation.
	/// </summary>
	/// <param name="input">The string to compress. This string cannot be null.</param>
	/// <param name="level">The compression level to use. Defaults to <see cref="CompressionLevel.Fastest"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{String}"/> representing the asynchronous operation, which upon completion, yields the ZLib compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: eAFKYchnKGHwY0hlKGEIYchkKGAoZtBjSGbIZ8hlAAAAAP//
	/// NoCompression: eAEAHADj/2QAbwB0AE4AZQB0AFQAaQBwAHMALgBjAG8AbQAAAAD//w==
	/// Optimal: eJxKYchnKGHwY0gFkiEMmQwFDMUMegzJQNFcBgAAAAD//w==
	/// SmallestSize: eNpKYchnKGHwY0gFkiEMmQwFDMUMegzJQNFcBgAAAAD//w==
	/// </example>
	[Information(nameof(ToZLibStringAsync), "David McCarter", "9/12/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToZLibStringAsync([NotNull] this string input, CompressionLevel level = CompressionLevel.Fastest, CancellationToken cancellationToken = default)
	{
		input = input.ArgumentNotNull();

		using var inputMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(input));
		using var outputMemoryStream = new MemoryStream();
		using (var zlibStream = new ZLibStream(outputMemoryStream, level, true))
		{
			await inputMemoryStream.CopyToAsync(zlibStream, cancellationToken).ConfigureAwait(false);
		}

		return Convert.ToBase64String(outputMemoryStream.ToArray());
	}

}
