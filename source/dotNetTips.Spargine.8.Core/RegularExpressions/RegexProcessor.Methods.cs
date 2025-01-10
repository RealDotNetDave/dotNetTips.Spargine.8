// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-09-2025
// ***********************************************************************
// <copyright file="RegexProcessor.Methods.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Utility methods for common string regular expressions. Included
// methods: ContainsWord, IsCreditCardNumber, IsEmailAddress, IsUrl,
// IsISBN, and more.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using System.Text.RegularExpressions;

namespace DotNetTips.Spargine.Core.RegularExpressions;

public static partial class RegexProcessor
{
	/// <summary>
	/// Checks if the given input contains both a first and last name.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns>
	///   <c>true</c> if the input contains a first and last name; otherwise, <c>false</c>.
	/// </returns>
	[Information(nameof(ContainsFirstLastName), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsFirstLastName(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return FirstLastNameRegexSingleLine().IsMatch(input);
	}


	/// <summary>
	/// Determines if the input contains a specific word.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input contains a word; otherwise, <c>false</c>.</returns>
	[Information(nameof(ContainsWord), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsWord(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return ContainsWordRegex().IsMatch(input);
	}

	/// <summary>
	/// Extracts all numeric characters from the input string.
	/// </summary>
	/// <param name="input">The input string to extract numbers from.</param>
	/// <returns>A string containing all numeric characters extracted from the input.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the input string is null.</exception>
	[Information(nameof(GetNumbers), UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static string GetNumbers(in string input)
	{
		ArgumentNullException.ThrowIfNull(input);

		var sb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			foreach (Match match in ExtractNumbersRegexSingleLine().Matches(input))
			{
				_ = sb.Append(match.Value);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Verifies if the input is a valid credit card number.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a credit card number; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsCreditCardNumber), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsCreditCardNumber(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return CreditCardRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Checks whether the input represents a valid currency code.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a currency code; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsCurrencyCode), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsCurrencyCode(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return CurrencyCodeRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Validates if the input is a correctly formatted email address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is an email address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsEmailAddress), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsEmailAddress(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return EmailAddressRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a valid GUID (Globally Unique Identifier).
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a GUID; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsGuid), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsGuid(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return GuidRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Checks if the input is a valid IPv4 address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a valid IPv4 address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsIPv4Address), "David McCarter", "10/10/2023", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static bool IsIPv4Address(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return IPv4AddressRegex().IsMatch(input);
	}

	/// <summary>
	/// Checks if the input is a valid IPv6 address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a valid IPv6 address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsIPv6Address), "David McCarter", "10/10/2023", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static bool IsIPv6Address(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return IPv6AddressRegex().IsMatch(input);
	}



	/// <summary>
	/// Validates whether the input is an ISBN (International Standard Book Number).
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is an ISBN; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsISBN), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsISBN(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return ISBNRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines if the input is a valid MAC (Media Access Control) address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a MAC address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsMACAddress), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsMACAddress(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return MACAddressSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Checks if the input is a valid SHA-1 hash.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a SHA1 hash; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsSHA1Hash), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsSHA1Hash(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return SHA1HashRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Verifies if the input is a valid URL.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a URL; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsUrl), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsUrl(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return UrlRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input contains a valid URL domain address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input contains a URL domain address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsUrlDomainAddress), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsUrlDomainAddress(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return UrlDomainAddressRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Checks whether the input is a valid string based on certain criteria.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a valid string; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsValidString), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsValidString(in string input)
	{
		if (input is null)
		{
			return false;
		}

		return StringRegex().IsMatch(input);
	}

	/// <summary>
	/// Removes HTML tags from the input string and replaces them with the specified replacement text.
	/// </summary>
	/// <param name="input">The input string to process.</param>
	/// <param name="replacement">The string to replace HTML tags with. Defaults to an empty string.</param>
	/// <returns>The modified string with HTML tags replaced by the specified replacement string.</returns>
	[Information(nameof(RemoveSpecialChar), "David McCarter", "8/1/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string RemoveHtml(in string input, in string replacement = "")
	{
		if (input is null)
		{
			return input;
		}

		return RemoveHtmlRegex().Replace(input, replacement);
	}

	/// <summary>
	/// Removes special characters from the input string, replacing them with the specified replacement text.
	/// </summary>
	/// <param name="input">The input string to process.</param>
	/// <param name="replacement">The string to replace special characters with. Defaults to an empty string.</param>
	/// <returns>The modified string with special characters replaced by the specified replacement string.</returns>
	[Information(nameof(RemoveSpecialChar), "David McCarter", "8/1/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string RemoveSpecialChar(in string input, in string replacement = "")
	{
		if (input is null)
		{
			return input;
		}

		return RemoveSpecialCharRegex().Replace(input, replacement);
	}

	/// <summary>
	/// Replaces carriage return (CR) and line feed (LF) characters in the input string.
	/// </summary>
	/// <param name="input">The input string.</param>
	/// <param name="replacement">The replacement string (defaults to "").</param>
	/// <returns>The modified string.</returns>
	[Information(nameof(ReplaceCrLf), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ReplaceCrLf(in string input, in string replacement = "")
	{
		if (input is null || replacement is null)
		{
			return input;
		}

		return RemoveCrLfRegex().Replace(input, replacement);
	}

	/// <summary>
	/// Replaces spaces in the input string with the specified replacement character.
	/// </summary>
	/// <param name="input">The input string.</param>
	/// <param name="replacement">The replacement string (defaults to "_").</param>
	/// <returns>The modified string.</returns>
	[Information(nameof(ReplaceSpaces), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ReplaceSpaces(in string input, in string replacement = "_")
	{
		if (input is null || replacement is null)
		{
			return input;
		}

		return SpacesRegex().Replace(input, replacement);
	}


}
