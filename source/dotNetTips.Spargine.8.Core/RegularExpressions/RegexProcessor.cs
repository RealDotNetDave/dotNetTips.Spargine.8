// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2024
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
/// Class RegexProcessor.
/// </summary>
public static partial class RegexProcessor
{

	/// <summary>
	/// The contains first last name pattern
	/// </summary>
	private const string ContainsFirstLastNamePattern = @"^([a-zA-Z]{2,}\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\s?([a-zA-Z]{1,})?)";

	/// <summary>
	/// Contains word pattern
	/// </summary>
	private const string ContainsWordPattern = @"^\b[a-zA-Z0-9_]+\b$";

	/// <summary>
	/// Credit card pattern
	/// </summary>
	private const string CreditCardPattern = @"^((4\d{3})|(5[1-5]\d{2})|(6011))-?\d{4}-?\d{4}-?\d{4}|3[4,7]\d{13}$";

	/// <summary>
	/// Currency code pattern
	/// </summary>
	private const string CurrencyCodePattern = @"^[a-zA-Z]{3}$";

	/// <summary>
	/// Email pattern
	/// </summary>
	private const string EmailPattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

	/// <summary>
	/// Guid Pattern
	/// </summary>
	private const string GuidPattern = @"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$";

	/// <summary>
	/// ISBN pattern
	/// </summary>
	private const string ISBNPattern = @"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$";

	/// <summary>
	/// The MAC address pattern
	/// </summary>
	private const string MACAddressPattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";

	/// <summary>
	/// The one to7 alpha pattern
	/// </summary>
	private const string OneTo7AlphaPattern = @"^[a-zA-Z]{1,7}$";

	/// <summary>
	/// The remove cr/lf pattern
	/// </summary>
	private const string RemoveCrLfPattern = @"[\r\n]+";

	/// <summary>
	/// Replace spaces pattern
	/// </summary>
	private const string ReplaceSpacesPattern = @"\s+";

	/// <summary>
	/// The SHA1 hash pattern
	/// </summary>
	private const string SHA1HashPattern = @"\b([a-fA-F0-9]{40})\b";

	/// <summary>
	/// The string pattern
	/// </summary>
	private const string StringPattern = @"^(\w|\W)+$";

	/// <summary>
	/// URL domain address pattern
	/// </summary>
	private const string UrlDomainAddress = @"^[a-zA-Z0-9\-\.]+\.(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$";

	/// <summary>
	/// URL pattern
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
	[Information(nameof(ContainsFirstLastName), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD URL")]
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
	/// <summary>
	/// Currencies the code regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>Regex.</returns>
	[Information(nameof(ContainsWord), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool ContainsWord(string input)
	{
		if (input is null)
		{
			return false;
		}

		return ContainsWordRegex().IsMatch(input);
	}

	/// <summary>
	/// Firsts the last name regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	/// <summary>
	/// Determines whether the input is a is credit card number.
	/// <summary>
	/// Emails the regex.
	/// </summary><returns>Regex.</returns>
	/// </summary>
	/// <param name="input">The input.</param>
	/// <summary>
	/// Unique identifiers the regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	/// <returns><c>true</c> if [is credit card number] [the specified input]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsCreditCardNumber), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
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
	/// <summary>
	/// Macs the address single line.
	/// </summary>
	/// <returns>Regex.</returns>
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if [is currency code] [the specified input]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsCurrencyCode), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool IsCurrencyCode(string input)
	{
		if (input is null)
		{
			return false;
		}

		return CurrencyCodeRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determins if the input is an email address.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>Regex.</returns>
	[Information(nameof(IsEmailAddress), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool IsEmailAddress(string input)
	{
		if (input is null)
		{
			return false;
		}

		return EmailAddressRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the specified input is Guid.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <summary>
	/// Strings the regex.
	/// </summary>
	/// <returns>Regex.</returns>
	/// <returns><c>true</c> if the specified input is unique identifier; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsGuid), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool IsGuid(string input)
	{
		if (input is null)
		{
			return false;
		}

		return GuidRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the specified input is an ISBN.
	/// <summary>
	/// URLs the regex single line.
	/// </summary>
	/// <returns>Regex.</returns>
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is isbn; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsISBN), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool IsISBN(string input)
	{
		if (input is null)
		{
			return false;
		}

		return ISBNRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether [is MAC address] [the specified input].
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>bool.</returns>
	[Information(nameof(IsMACAddress), "David McCarter", "9/28/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD URL")]
	public static bool IsMACAddress(string input)
	{
		if (input is null)
		{
			return false;
		}

		return MACAddressSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether [is SHA1 hash] [the specified input].
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>bool.</returns>
	[Information(nameof(IsSHA1Hash), "David McCarter", "9/28/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD URL")]
	public static bool IsSHA1Hash(string input)
	{
		if (input is null)
		{
			return false;
		}

		return SHA1HashRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether the specified input is an URL.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is URL; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsUrl), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool IsUrl(string input)
	{
		if (input is null)
		{
			return false;
		}

		return UrlRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether [is URL contains domain address] [the specified input].
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>bool.</returns>
	[Information(nameof(IsUrlDomainAddress), "David McCarter", "9/28/2023", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD URL")]
	public static bool IsUrlDomainAddress(string input)
	{
		if (input is null)
		{
			return false;
		}

		return UrlDomainAddressRegexSingleLine().IsMatch(input);
	}

	/// <summary>
	/// Determines whether [is valid string] [the specified input].
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>bool.</returns>
	[Information(nameof(IsValidString), "David McCarter", "9/28/2023", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD URL")]
	public static bool IsValidString(string input)
	{
		if (input is null)
		{
			return false;
		}

		return StringRegex().IsMatch(input);
	}

	/// <summary>
	/// Replaces the cr/lf.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="replacement">The replacement. (defaults to "")</param>
	/// <returns>string.</returns>
	[Information(nameof(ReplaceCrLf), "David McCarter", "9/28/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD URL")]
	public static string ReplaceCrLf(string input, string replacement = "")
	{
		if (input is null || replacement is null)
		{
			return input;
		}

		return RemoveCrLfRegex().Replace(input, replacement);
	}

	/// <summary>
	/// Replaces the spaces in the input.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="replacement">The replacement (defaults to "_").</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ReplaceSpaces), "David McCarter", "3/16/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string ReplaceSpaces(string input, string replacement = "_")
	{
		if (input is null || replacement is null)
		{
			return input;
		}

		return SpacesRegex().Replace(input, replacement);
	}

}
