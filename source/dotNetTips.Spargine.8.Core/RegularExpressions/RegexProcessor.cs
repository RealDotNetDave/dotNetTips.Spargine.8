// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="RegexProcessor.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Utility methods for common string regular expressions. Included
// methods: ContainsWord, IsCreditCardNumber, IsEmailAddress, IsUrl,
// IsISBN, and more.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using System.Text.RegularExpressions;

namespace DotNetTips.Spargine.Core.RegularExpressions;

/// <summary>
/// Provides utility methods for common string regular expressions. This includes
/// methods for validating and processing strings against common patterns such as
/// email addresses, URLs, credit card numbers, and more.
/// </summary>
public static partial class RegexProcessor
{

	/// <summary>
	/// The pattern to check for a first and last name.
	/// </summary>
	private const string ContainsFirstLastNamePattern = @"^([a-zA-Z]{2,}\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\s?([a-zA-Z]{1,})?)";

	/// <summary>
	/// The pattern to check if the input contains a word.
	/// </summary>
	private const string ContainsWordPattern = @"^\b[a-zA-Z0-9_]+\b$";

	/// <summary>
	/// The pattern to validate credit card numbers.
	/// </summary>
	private const string CreditCardPattern = @"^((4\d{3})|(5[1-5]\d{2})|(6011))-?\d{4}-?\d{4}-?\d{4}|3[4,7]\d{13}$";

	/// <summary>
	/// The pattern to validate currency codes.
	/// </summary>
	private const string CurrencyCodePattern = @"^[a-zA-Z]{3}$";

	/// <summary>
	/// The pattern to validate email addresses.
	/// </summary>
	private const string EmailPattern = "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])";

	/// <summary>
	/// The pattern to validate GUIDs.
	/// </summary>
	private const string GuidPattern = @"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$";

	/// <summary>
	/// The pattern to validate ISBNs.
	/// </summary>
	private const string ISBNPattern = @"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$";

	/// <summary>
	/// The pattern to validate MAC addresses.
	/// </summary>
	private const string MACAddressPattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";

	/// <summary>
	/// The pattern to validate strings with 1 to 7 alphabetic characters.
	/// </summary>
	private const string OneTo7AlphaPattern = @"^[a-zA-Z]{1,7}$";

	/// <summary>
	/// The pattern to remove carriage return and line feed characters.
	/// </summary>
	private const string RemoveCrLfPattern = @"[\r\n]+";

	/// <summary>
	/// The pattern to replace spaces.
	/// </summary>
	private const string ReplaceSpacesPattern = @"\s+";

	/// <summary>
	/// The pattern to validate SHA1 hashes.
	/// </summary>
	private const string SHA1HashPattern = @"\b([a-fA-F0-9]{40})\b";

	/// <summary>
	/// The pattern to validate strings.
	/// </summary>
	private const string StringPattern = @"^(\w|\W)+$";

	/// <summary>
	/// The pattern to validate URL domain addresses.
	/// </summary>
	private const string UrlDomainAddress = @"^[a-zA-Z0-9\-\.]+\.(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$";

	/// <summary>
	/// The pattern to validate URLs.
	/// </summary>
	private const string UrlPattern = @"(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?";

	/// <summary>
	/// Determines whether [contains word regex].
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(ContainsWordPattern, RegexOptions.CultureInvariant | RegexOptions.Multiline)]
	private static partial Regex ContainsWordRegex();

	/// <summary>
	/// Credits the card regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(CreditCardPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex CreditCardRegexSingleLine();

	/// <summary>
	/// Currencies the code regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(CurrencyCodePattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex CurrencyCodeRegexSingleLine();

	/// <summary>
	/// Emails the address regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(EmailPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex EmailAddressRegexSingleLine();

	/// <summary>
	/// Determins if the string contains a first and last name.
	/// </summary>
	/// <returns>System.Text.RegularExpressions.Regex.</returns>
	[GeneratedRegex(ContainsFirstLastNamePattern, RegexOptions.CultureInvariant | RegexOptions.Singleline | RegexOptions.IgnoreCase)]
	private static partial Regex FirstLastNameRegexSingleLine();

	/// <summary>
	/// Unique identifiers the regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(GuidPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex GuidRegexSingleLine();

	/// <summary>
	/// Isbns the regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(ISBNPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex ISBNRegexSingleLine();

	/// <summary>
	/// Credits the card regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(MACAddressPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex MACAddressSingleLine();

	[GeneratedRegex(OneTo7AlphaPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex OneTo7AlphaRegexSingleLine();

	/// <summary>
	/// Removes the cr/lf regex.
	/// </summary>
	/// <returns>System.Text.RegularExpressions.Regex.</returns>
	[GeneratedRegex(RemoveCrLfPattern, RegexOptions.CultureInvariant | RegexOptions.RightToLeft | RegexOptions.IgnoreCase)]
	private static partial Regex RemoveCrLfRegex();

	/// <summary>
	/// Determins if string contains a SHA1 hashed string.
	/// </summary>
	/// <returns>System.Text.RegularExpressions.Regex.</returns>
	[GeneratedRegex(SHA1HashPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex SHA1HashRegexSingleLine();

	/// <summary>
	/// Spaceses the regex.
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(ReplaceSpacesPattern, RegexOptions.CultureInvariant | RegexOptions.Multiline)]
	private static partial Regex SpacesRegex();

	/// <summary>
	/// Determins if the text is a valid string.
	/// </summary>
	/// <returns>System.Text.RegularExpressions.Regex.</returns>
	[GeneratedRegex(StringPattern, RegexOptions.CultureInvariant | RegexOptions.Multiline | RegexOptions.IgnoreCase)]
	private static partial Regex StringRegex();

	/// <summary>
	/// Determins if the string is a domain address.
	/// </summary>
	/// <returns>System.Text.RegularExpressions.Regex.</returns>
	[GeneratedRegex(UrlDomainAddress, RegexOptions.CultureInvariant | RegexOptions.Singleline | RegexOptions.IgnoreCase)]
	private static partial Regex UrlDomainAddressRegexSingleLine();

	/// <summary>
	/// URLs the regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	[GeneratedRegex(UrlPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex UrlRegexSingleLine();

	/// <summary>
	/// Determines whether [contains word regex].
	/// </summary>
	/// <param name="input">The input.</param>
	/// <summary>
	/// Determines whether [contains word regex].
	/// </summary>
	/// <returns>Regex.</returns>
	/// <returns>Regex.</returns>
	[Information(nameof(ContainsFirstLastName), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static bool ContainsFirstLastName(string input)
	{
		if (input is null)
		{
			return false;
		}

		return FirstLastNameRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input contains a word.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input contains a word; otherwise, <c>false</c>.</returns>
	[Information(nameof(ContainsWord), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsWord(string input)
	{
		if (input is null)
		{
			return false;
		}

		return ContainsWordRegex().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a credit card number.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a credit card number; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsCreditCardNumber), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool IsCreditCardNumber(string input)
	{
		if (input is null)
		{
			return false;
		}

		return CreditCardRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a currency code.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a currency code; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsCurrencyCode), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool IsCurrencyCode(string input)
	{
		if (input is null)
		{
			return false;
		}

		return CurrencyCodeRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is an email address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is an email address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsEmailAddress), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool IsEmailAddress(string input)
	{
		if (input is null)
		{
			return false;
		}

		return EmailAddressRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a GUID.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a GUID; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsGuid), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool IsGuid(string input)
	{
		if (input is null)
		{
			return false;
		}

		return GuidRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is an ISBN.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is an ISBN; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsISBN), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool IsISBN(string input)
	{
		if (input is null)
		{
			return false;
		}

		return ISBNRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a MAC address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a MAC address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsMACAddress), "David McCarter", "9/28/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static bool IsMACAddress(string input)
	{
		if (input is null)
		{
			return false;
		}

		return MACAddressSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a SHA1 hash.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a SHA1 hash; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsSHA1Hash), "David McCarter", "9/28/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static bool IsSHA1Hash(string input)
	{
		if (input is null)
		{
			return false;
		}

		return SHA1HashRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a URL.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a URL; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsUrl), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool IsUrl(string input)
	{
		if (input is null)
		{
			return false;
		}

		return UrlRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input contains a URL domain address.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input contains a URL domain address; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsUrlDomainAddress), "David McCarter", "9/28/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static bool IsUrlDomainAddress(string input)
	{
		if (input is null)
		{
			return false;
		}

		return UrlDomainAddressRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a valid string.
	/// </summary>
	/// <param name="input">The input string to check.</param>
	/// <returns><c>true</c> if the input is a valid string; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsValidString), "David McCarter", "9/28/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static bool IsValidString(string input)
	{
		if (input is null)
		{
			return false;
		}

		return StringRegex().IsMatch(input);
	}

	/// <summary>
	/// Replaces carriage return and line feed characters in the input string.
	/// </summary>
	/// <param name="input">The input string.</param>
	/// <param name="replacement">The replacement string (defaults to "").</param>
	/// <returns>The modified string.</returns>
	[Information(nameof(ReplaceCrLf), "David McCarter", "9/28/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static string ReplaceCrLf(string input, string replacement = "")
	{
		if (input is null || replacement is null)
		{
			return input;
		}

		return RemoveCrLfRegex().Replace(input, replacement);
	}

	/// <summary>
	/// Replaces spaces in the input string.
	/// </summary>
	/// <param name="input">The input string.</param>
	/// <param name="replacement">The replacement string (defaults to "_").</param>
	/// <returns>The modified string.</returns>
	[Information(nameof(ReplaceSpaces), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string ReplaceSpaces(string input, string replacement = "_")
	{
		if (input is null || replacement is null)
		{
			return input;
		}

		return SpacesRegex().Replace(input, replacement);
	}

}
