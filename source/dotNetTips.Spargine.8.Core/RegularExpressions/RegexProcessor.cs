// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-09-2025
// ***********************************************************************
// <copyright file="RegexProcessor.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Source Generator methods for common string regular expressions. Included
// methods: ContainsWord, IsCreditCardNumber, IsEmailAddress, IsUrl,
// IsISBN, and more.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using System.Text.RegularExpressions;

namespace DotNetTips.Spargine.Core.RegularExpressions;

/// <summary>
/// Provides utility methods for common string regular expressions. This includes
/// methods for validating and processing strings against common patterns such as
/// email addresses, URLs, credit card numbers, and more.
/// </summary>
[Information(Documentation = "https://bit.ly/SpargineRegexProcessor", Status = Status.Available)]
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
	/// The pattern to validate IPv4 addresses.
	/// </summary>
	private const string IPv4AddressPattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

	/// <summary>
	/// The pattern to validate IPv6 addresses.
	/// </summary>
	private const string IPv6AddressPattern = @"^([0-9a-fA-F]{1,4}:){7}([0-9a-fA-F]{1,4}|:)$";

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
	/// The pattern to validate postal codes.
	/// </summary>
	private const string PostalCodePattern = @"^\d{5}(-\d{4})?$";

	/// <summary>
	/// The pattern to remove carriage return and line feed characters.
	/// </summary>
	private const string RemoveCrLfPattern = @"[\r\n]+";

	/// <summary>
	/// The pattern to remove HTML tags from a string.
	/// </summary>
	private const string RemoveHtmlPattern = @"</?.+?>";

	/// <summary>
	/// The pattern to remove special characters from a string.
	/// </summary>
	private const string RemoveSpecialCharPattern = @"[^0-9a-zA-Z]";

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
	/// Gets a regex instance for validating IPv4 addresses.
	/// </summary>
	/// <returns>A <see cref="Regex"/> instance configured to validate IPv4 addresses.</returns>
	[GeneratedRegex(IPv4AddressPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex IPv4AddressRegex();

	/// <summary>
	/// Gets a regex instance for validating IPv6 addresses.
	/// </summary>
	/// <returns>A <see cref="Regex"/> instance configured to validate IPv6 addresses.</returns>
	[GeneratedRegex(IPv6AddressPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex IPv6AddressRegex();

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

	/// <summary>
	/// The pattern to validate strings with 1 to 7 alphabetic characters.
	/// </summary>
	/// <returns>A <see cref="Regex"/> instance configured to validate strings with 1 to 7 alphabetic characters.</returns>
	[GeneratedRegex(OneTo7AlphaPattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex OneTo7AlphaRegexSingleLine();

	/// <summary>
	/// Gets a regex instance for validating postal codes.
	/// </summary>
	/// <returns>A <see cref="Regex"/> instance configured to validate postal codes.</returns>
	[GeneratedRegex(PostalCodePattern, RegexOptions.CultureInvariant | RegexOptions.Singleline)]
	private static partial Regex PostalCodeRegex();

	/// <summary>
	/// Removes the cr/lf regex.
	/// </summary>
	/// <returns>System.Text.RegularExpressions.Regex.</returns>
	[GeneratedRegex(RemoveCrLfPattern, RegexOptions.CultureInvariant | RegexOptions.RightToLeft | RegexOptions.IgnoreCase)]
	private static partial Regex RemoveCrLfRegex();

	/// <summary>
	/// Gets a regex instance for removing HTML tags from a string.
	/// </summary>
	/// <returns>A <see cref="Regex"/> instance configured to remove HTML tags.</returns>
	[GeneratedRegex(RemoveHtmlPattern, RegexOptions.CultureInvariant | RegexOptions.Multiline | RegexOptions.IgnoreCase)]
	private static partial Regex RemoveHtmlRegex();

	/// <summary>
	/// Gets a regex instance for removing special characters from a string.
	/// </summary>
	/// <returns>A <see cref="Regex"/> instance configured to remove special characters.</returns>
	[GeneratedRegex(RemoveSpecialCharPattern, RegexOptions.CultureInvariant | RegexOptions.Multiline | RegexOptions.IgnoreCase)]
	private static partial Regex RemoveSpecialCharRegex();

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

}
