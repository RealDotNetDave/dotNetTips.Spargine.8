// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2025
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

using System.Text.RegularExpressions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.RegularExpressions;

[Information("RegexProcessor.Methods", Documentation = "https://bit.ly/SpargineRegexProcessor", Status = Status.Available)]
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
	public static bool ContainsFirstLastName(string input) => input is null ? false : FirstLastNameRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Determines if the input contains a specific word.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input contains a word; otherwise, <c>false</c>.</returns>
	[Information(nameof(ContainsWord), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsWord(string input) => input is null ? false : ContainsWordRegex().IsMatch(input);

	/// <summary>
	/// Extracts a version number from the input string using a regular expression.
	/// </summary>
	/// <param name="input">The input string to check for a version number.</param>
	/// <returns>
	/// <c>true</c> if the input contains a valid version number; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// This method uses the <see cref="ExtractVersionRegex"/> to match version numbers in the input string.
	/// A version number typically follows the format "major.minor[.build[.revision]]".
	/// </remarks>
	/// <example>
	/// Example usage:
	/// <code>
	/// bool hasVersion = RegexProcessor.ExtractVersion("Version 1.2.3");
	/// Console.WriteLine(hasVersion); // Output: true
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown if the input string is null.</exception>
	[Information(nameof(ExtractVersion), "David McCarter", "4/9/2025", UnitTestStatus = UnitTestStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string ExtractVersion(string input) => ExtractVersionRegex().Match(input).Value;

	/// <summary>
	/// Extracts all numeric characters from the input string.
	/// </summary>
	/// <param name="input">The input string to extract numbers from.</param>
	/// <returns>A string containing all numeric characters extracted from the input.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the input string is null.</exception>
	[Information(nameof(GetNumbers), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GetNumbers(string input)
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
	public static bool IsCreditCardNumber(string input) => input is null ? false : CreditCardRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Checks whether the input represents a valid currency code.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a currency code; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsCurrencyCode), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsCurrencyCode(string input) => input is null ? false : CurrencyCodeRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Validates if the input is a correctly formatted email address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is an email address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsEmailAddress), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsEmailAddress(string input) => input is null ? false : EmailAddressRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Determines whether the input is a valid GUID (Globally Unique Identifier).
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a GUID; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsGuid), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsGuid(string input) => input is null ? false : GuidRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Checks if the input is a valid IPv4 address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a valid IPv4 address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsIPv4Address), "David McCarter", "10/10/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsIPv4Address(string input) => input is null ? false : IPv4AddressRegex().IsMatch(input);

	/// <summary>
	/// Checks if the input is a valid IPv6 address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a valid IPv6 address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsIPv6Address), "David McCarter", "10/10/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsIPv6Address(string input) => input is null ? false : IPv6AddressRegex().IsMatch(input);

	/// <summary>
	/// Validates whether the input is an ISBN (International Standard Book Number).
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is an ISBN; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsISBN), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsISBN(string input) => input is null ? false : ISBNRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Determines if the input is a valid MAC (Media Access Control) address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a MAC address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsMACAddress), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsMACAddress(string input) => input is null ? false : MACAddressSingleLine().IsMatch(input);

	/// <summary>
	/// Determines if the input string contains only alphabetic characters and has a length between 1 and 7 characters.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input contains only alphabetic characters and has a length between 1 and 7 characters; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsOneToSevenAlpha), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsOneToSevenAlpha(string input) => input is null ? false : OneTo7AlphaRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Determines if the input string is in scientific notation.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is in scientific notation; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsScientific), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsScientific(string input) => input is null ? false : ScientificRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Checks if the input is a valid SHA-1 hash.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a SHA1 hash; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsSHA1Hash), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsSHA1Hash(string input) => input is null ? false : SHA1HashRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Verifies if the input is a valid URL.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a URL; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsUrl), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsUrl(string input) => input is null ? false : UrlRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Determines whether the input contains a valid URL domain address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input contains a URL domain address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsUrlDomainAddress), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsUrlDomainAddress(string input) => input is null ? false : UrlDomainAddressRegexSingleLine().IsMatch(input);

	/// <summary>
	/// Checks whether the input is a valid string based on certain criteria.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a valid string; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsValidString), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsValidString(string input) => input is null ? false : StringRegex().IsMatch(input);

	/// <summary>
	/// Removes HTML tags from the input string and replaces them with the specified replacement text.
	/// </summary>
	/// <param name="input">The input string to process.</param>
	/// <param name="replacement">The string to replace HTML tags with. Defaults to an empty string.</param>
	/// <returns>The modified string with HTML tags replaced by the specified replacement string.</returns>
	[Information(nameof(RemoveHtml), "David McCarter", "8/1/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string RemoveHtml(string input, string replacement = ControlChars.EmptyString) => input is null ? input : RemoveHtmlRegex().Replace(input, replacement);

	/// <summary>
	/// Removes special characters from the input string, replacing them with the specified replacement text.
	/// </summary>
	/// <param name="input">The input string to process.</param>
	/// <param name="replacement">The string to replace special characters with. Defaults to an empty string.</param>
	/// <returns>The modified string with special characters replaced by the specified replacement string.</returns>
	[Information(nameof(RemoveSpecialChar), "David McCarter", "8/1/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string RemoveSpecialChar(string input, in string replacement = ControlChars.EmptyString) => input is null ? input : RemoveSpecialCharRegex().Replace(input, replacement);

	/// <summary>
	/// Replaces carriage return (CR) and line feed (LF) characters in the input string.
	/// </summary>
	/// <param name="input">The input string.</param>
	/// <param name="replacement">The replacement string (defaults to "").</param>
	/// <returns>The modified string.</returns>
	[Information(nameof(ReplaceCrLf), "David McCarter", "9/28/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ReplaceCrLf(string input, in string replacement = ControlChars.EmptyString) => input is null || replacement is null ? input : RemoveCrLfRegex().Replace(input, replacement);

	/// <summary>
	/// Replaces spaces in the input string with the specified replacement character.
	/// </summary>
	/// <param name="input">The input string.</param>
	/// <param name="replacement">The replacement string (defaults to "_").</param>
	/// <returns>The modified string.</returns>
	[Information(nameof(ReplaceSpaces), "David McCarter", "3/16/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ReplaceSpaces(string input, in string replacement = "_") => input is null || replacement is null ? input : SpacesRegex().Replace(input, replacement);
}
