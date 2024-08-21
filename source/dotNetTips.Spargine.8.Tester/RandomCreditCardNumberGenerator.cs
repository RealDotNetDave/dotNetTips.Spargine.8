// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-13-2023
//
// Last Modified By : David McCarter
// Last Modified On : 08-21-2024
// ***********************************************************************
// <copyright file="RandomCreditCardNumberGenerator.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Generates random credit card numbers.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester;
//TODO: MAKE PUBLIC AFTER AUG 2024

/// <summary>
/// Provides functionality to generate random credit card numbers for various card types.
/// This class cannot be inherited and is intended for internal use within the assembly.
/// </summary>
/// <remarks>
/// Original code by: Kev Hunter https://kevhunter.wordpress.com
/// This utility class supports generating random but valid credit card numbers for testing purposes.
/// It includes support for major credit card types such as Visa, MasterCard, American Express, and others.
/// The generated numbers are random and follow the credit card companies' numbering schemes, including passing the Luhn check.
/// However, these numbers are not valid for real transactions but can be used for testing validation and formatting routines.
/// </remarks>
internal static partial class RandomCreditCardNumberGenerator
{
	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// The American Express (Amex) credit card prefix list.
	/// </summary>
	/// <remarks>
	/// American Express cards typically start with the prefixes 34 or 37.
	/// This list is used to generate valid-looking American Express credit card numbers for testing purposes.
	/// </remarks>
	private static readonly string[] AmexPrefixList = ["34", "37"];

	/// <summary>
	/// The Diners Club credit card prefix list.
	/// </summary>
	/// <remarks>
	/// Diners Club cards typically start with the prefixes listed here.
	/// This list is used to generate valid-looking Diners Club credit card numbers for testing purposes.
	/// </remarks>
	private static readonly string[] DinersPrefixList = ["300", "301", "302", "303", "36", "38"];

	/// <summary>
	/// The Discover credit card prefix list.
	/// </summary>
	/// <remarks>
	/// Discover cards typically start with the prefix 6011.
	/// This list is used to generate valid-looking Discover credit card numbers for testing purposes.
	/// </remarks>
	private static readonly string[] DiscoverPrefixList = ["6011"];

	/// <summary>
	/// The EnRoute credit card prefix list.
	/// </summary>
	/// <remarks>
	/// EnRoute cards typically start with the prefixes 2014 and 2149.
	/// This list is used to generate valid-looking EnRoute credit card numbers for testing purposes.
	/// </remarks>
	private static readonly string[] EnroutePrefixList = ["2014", "2149"];

	/// <summary>
	/// The JCB credit card prefix list.
	/// </summary>
	/// <remarks>
	/// JCB cards typically start with the prefix 35.
	/// This list is used to generate valid-looking JCB credit card numbers for testing purposes.
	/// </remarks>
	private static readonly string[] JCBPrefixList = ["35"];

	/// <summary>
	/// The MasterCard credit card prefix list.
	/// </summary>
	/// <remarks>
	/// MasterCard cards typically start with the prefixes listed here, including both the traditional range of 51-55 and the expanded range of 2221-2720.
	/// This list is used to generate valid-looking MasterCard credit card numbers for testing purposes.
	/// </remarks>
	private static readonly string[] MasterCardPrefixList = ["51", "52", "53", "54", "55", "2221", "2222", "2223", "2224", "2225", "2226", "2227", "2228", "2229", "223", "224", "225", "226", "227", "228", "229", "23", "24", "25", "26", "270", "271", "2720"];

	/// <summary>
	/// The Visa credit card prefix list.
	/// </summary>
	/// <remarks>
	/// Visa cards typically start with the prefix 4. This list includes common Visa prefixes,
	/// used to generate valid-looking Visa credit card numbers for testing purposes.
	/// </remarks>
	private static readonly string[] VisaPrefixList = ["4539", "4556", "4916", "4532", "4929", "40240071", "4485", "4716", "4"];

	/// <summary>
	/// The Voyager credit card prefix list.
	/// </summary>
	/// <remarks>
	/// Voyager cards typically start with the prefix 8699.
	/// This list is used to generate valid-looking Voyager credit card numbers for testing purposes.
	/// </remarks>
	private static readonly string[] VoyagerPrefixList = ["8699"];

	/// <summary>
	/// Builds a collection of <see cref="PrefixAndLength"/> objects from a given list of prefixes and a specified length.
	/// </summary>
	/// <param name="prefixList">The list of prefix strings for the credit card numbers.</param>
	/// <param name="length">The length of the credit card number to generate.</param>
	/// <returns>A collection of <see cref="PrefixAndLength"/> objects, each representing a prefix and its corresponding length.</returns>
	/// <remarks>
	/// This method is used to prepare the data needed for generating credit card numbers. Each prefix from the given list is paired with the specified length to create a <see cref="PrefixAndLength"/> object. These objects are then used to generate credit card numbers of the correct length starting with the specified prefixes.
	/// </remarks>
	private static IEnumerable<PrefixAndLength> BuildPrefixAndLengthList(string[] prefixList, int length) => prefixList.Select(prefix => new PrefixAndLength(prefix, length));

	/// <summary>
	/// Builds the prefix and length arrays for various credit card number generations.
	/// </summary>
	/// <returns>An array of <see cref="PrefixAndLength"/> objects, each representing a combination of a prefix and its corresponding length for credit card numbers.</returns>
	/// <remarks>
	/// This method consolidates the prefix lists for different credit card types with their respective lengths into a single array of <see cref="PrefixAndLength"/> objects.
	/// These objects are then used throughout the credit card number generation process to ensure that generated numbers have appropriate prefixes and lengths according to credit card type.
	/// </remarks>
	private static PrefixAndLength[] BuildPrefixAndLengths() => BuildPrefixAndLengthList(VisaPrefixList, 16)
			.Concat(BuildPrefixAndLengthList(MasterCardPrefixList, 16))
			.Concat(BuildPrefixAndLengthList(AmexPrefixList, 15))
			.Concat(BuildPrefixAndLengthList(DinersPrefixList, 16))
			.Concat(BuildPrefixAndLengthList(DiscoverPrefixList, 16))
			.Concat(BuildPrefixAndLengthList(VoyagerPrefixList, 16))
			.Concat(BuildPrefixAndLengthList(JCBPrefixList, 16))
			.Concat(BuildPrefixAndLengthList(EnroutePrefixList, 15))
			.ToArray();

	/// <summary>
	/// Creates a fake credit card number using a specified prefix and length.
	/// </summary>
	/// <param name="prefix">The prefix to use for the credit card number.</param>
	/// <param name="length">The total length of the credit card number to generate.</param>
	/// <returns>A fake credit card number as a string.</returns>
	/// <remarks>
	/// This method generates a credit card number that passes the Luhn check (modulus 10 check).
	/// It uses the <see cref="RandomNumberGenerator"/> for generating random digits and the <see cref="StringBuilder"/> from <see cref="_stringBuilderPool"/> for efficient string manipulation.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="prefix"/> is null.</exception>
	private static string CreateFakeCreditCardNumber([NotNull] string prefix, int length)
	{
		prefix = prefix.ArgumentNotNull();

		var sb = _stringBuilderPool.Get();
		try
		{
			_ = sb.Append(prefix);

			while (sb.Length < length - 1)
			{
				_ = sb.Append(RandomNumberGenerator.GetInt32(0, 10));
			}

			// reverse number and convert to int
			var reversedCCnumberstring = sb.ToString().ToCharArray().Reverse();

			var reversedCCnumberList = reversedCCnumberstring.Select(c => Convert.ToInt32(c.ToString(), CultureInfo.InvariantCulture));

			// calculate sum //Luhn Algorithm http://en.wikipedia.org/wiki/Luhn_algorithm
			var sum = 0;
			var pos = 0;
			var reversedCCnumber = reversedCCnumberList.ToArray();

			while (pos < length - 1)
			{
				var odd = reversedCCnumber[pos] * 2;

				if (odd > 9)
				{
					odd -= 9;
				}

				sum += odd;

				if (pos != length - 2)
				{
					sum += reversedCCnumber[pos + 1];
				}

				pos += 2;
			}

			// calculate check digit
			var checkdigit = Convert.ToInt32(((Math.Floor((decimal)sum / 10) + 1) * 10) - sum) % 10;

			_ = sb.Append(checkdigit);

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Generate a single random credit card number. Supported credit cards include: American Express, Diners Club, Discover, EnRoute, JCB, MasterCard, Visa, and Voyager.
	/// </summary>
	/// <returns>A single random credit card number as a string.</returns>
	/// <remarks>
	/// This method is a convenience wrapper around <see cref="GetCreditCardNumbers(int)"/> with a count of 1.
	/// It relies on <see cref="GetCreditCardNumbers(int)"/> to validate the input and ensure at least one credit card number is generated.
	/// The generated credit card number is random and follows the credit card companies' numbering schemes, including passing the Luhn check.
	/// However, these numbers are not valid for real transactions but can be used for testing validation and formatting routines.
	/// </remarks>
	[Information(nameof(GetCreditCardNumber), BenchMarkStatus = BenchMarkStatus.Benchmark, Status = Status.NeedsDocumentation)]
	public static string GetCreditCardNumber() => GetCreditCardNumbers(1).SingleOrDefault();

	/// <summary>
	/// Generate a collection of random credit card numbers. Supported credit cards include: American Express, Diners Club, Discover, EnRoute, JCB, MasterCard, Visa, and Voyager.
	/// </summary>
	/// <param name="count">The number of credit card numbers to generate. Must be at least 1.</param>
	/// <returns>A read-only collection of generated credit card numbers.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="count"/> is less than 1, ensuring that at least one credit card number is generated.</exception>
	/// <remarks>
	/// This method utilizes <see cref="CreateFakeCreditCardNumber(string, int)"/> to generate each credit card number based on predefined prefixes and lengths.
	/// The generated numbers are random and follow the credit card companies' numbering schemes, including passing the Luhn check.
	/// However, these numbers are not valid for real transactions but can be used for testing validation and formatting routines.
	/// </remarks>
	[Information(nameof(GetCreditCardNumbers), BenchMarkStatus = BenchMarkStatus.Benchmark, Status = Status.NeedsDocumentation)]
	public static ReadOnlyCollection<string> GetCreditCardNumbers([Range(1, int.MaxValue)] int count)
	{
		count = count.ArgumentInRange(1);

		var result = new Stack<string>(count);

		for (var cardCount = 0; cardCount < count; cardCount++)
		{
			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length - 1)];

			result.Push(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
		}

		return result.ToList().AsReadOnly();
	}

	/// <summary>
	/// The prefixes used for generating credit card numbers.
	/// </summary>
	/// <remarks>
	/// This array is built using the <see cref="BuildPrefixAndLengths"/> method, which combines various credit card prefix lists with their corresponding lengths to generate valid credit card numbers.
	/// The array contains <see cref="PrefixAndLength"/> objects, each representing a combination of a prefix and its corresponding length for credit card numbers.
	/// These objects are utilized throughout the credit card number generation process to ensure that generated numbers have appropriate prefixes and lengths according to credit card type.
	/// </remarks>
	private static readonly PrefixAndLength[] _prefixes = BuildPrefixAndLengths();

}
