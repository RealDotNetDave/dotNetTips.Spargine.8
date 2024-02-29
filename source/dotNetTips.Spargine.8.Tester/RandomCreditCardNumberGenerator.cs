// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-13-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2023
// ***********************************************************************
// <copyright file="RandomCreditCardNumberGenerator.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Generates random credit card numbers.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Globalization;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Class RandomCreditCardNumberGenerator.
/// </summary>
/// <remarks>Original code by: Kev Hunter https://kevhunter.wordpress.com</remarks>
internal static partial class RandomCreditCardNumberGenerator
{

	/// <summary>
	/// The amex prefix list
	/// </summary>
	internal static string[] AmexPrefixList = ["34", "37"];

	/// <summary>
	/// The diners prefix list
	/// </summary>
	internal static string[] DinersPrefixList = ["300", "301", "302", "303", "36", "38"];

	/// <summary>
	/// The discover prefix list
	/// </summary>
	internal static string[] DiscoverPrefixList = ["6011"];

	/// <summary>
	/// The enroute prefix list
	/// </summary>
	internal static string[] EnroutePrefixList = ["2014", "2149"];

	/// <summary>
	/// The JCB prefix list
	/// </summary>
	internal static string[] JCBPrefixList = ["35"];

	/// <summary>
	/// The mastercard prefix list
	/// </summary>
	internal static string[] MasterCardPrefixList = ["51", "52", "53", "54", "55", "2221", "2222", "2223", "2224", "2225", "2226", "2227", "2228", "2229", "223", "224", "225", "226", "227", "228", "229", "23", "24", "25", "26", "270", "271", "2720"];

	/// <summary>
	/// The visa prefix list
	/// </summary>
	internal static string[] VisaPrefixList = ["4539", "4556", "4916", "4532", "4929", "40240071", "4485", "4716", "4"];

	/// <summary>
	/// The voyager prefix list
	/// </summary>
	internal static string[] VoyagerPrefixList = ["8699"];

	/// <summary>
	/// Builds the prefix and length list.
	/// </summary>
	/// <param name="prefixList">The prefix list.</param>
	/// <param name="length">The length.</param>
	/// <returns>IEnumerable&lt;PrefixAndLength&gt;.</returns>
	private static IEnumerable<PrefixAndLength> BuildPrefixAndLengthList(string[] prefixList, int length)
	{
		IEnumerable<PrefixAndLength> enumerable()
		{
			for (var prefixIndex = 0; prefixIndex < prefixList.Length; prefixIndex++)
			{
				yield return new PrefixAndLength(prefixList[prefixIndex], length);
			}
		}

		return enumerable();
	}

	/// <summary>
	/// This is an example how BuildPrefixAndLengthList can be used
	/// </summary>
	/// <returns>PrefixAndLength[].</returns>
	private static PrefixAndLength[] BuildPrefixAndLengths()
	{
		var list = BuildPrefixAndLengthList(VisaPrefixList, 16).ToList();
		list.AddRange(BuildPrefixAndLengthList(MasterCardPrefixList, 16));
		list.AddRange(BuildPrefixAndLengthList(AmexPrefixList, 15));
		list.AddRange(BuildPrefixAndLengthList(DinersPrefixList, 16));
		list.AddRange(BuildPrefixAndLengthList(DiscoverPrefixList, 16));
		list.AddRange(BuildPrefixAndLengthList(VoyagerPrefixList, 16));
		list.AddRange(BuildPrefixAndLengthList(JCBPrefixList, 16));
		list.AddRange(BuildPrefixAndLengthList(EnroutePrefixList, 15));

		return [.. list];
	}

	/// <summary>
	/// Creates the fake credit card number.
	/// </summary>
	/// <param name="prefix">The prefix.</param>
	/// <param name="length">The length.</param>
	/// <returns>System.String.</returns>
	private static string CreateFakeCreditCardNumber(string prefix, int length)
	{
		var ccnumber = prefix;

		while (ccnumber.Length < length - 1)
		{
			var rnd = (GetDouble() * 1.0f) - 0f;

			ccnumber += Math.Floor(rnd * 10);
		}

		// reverse number and convert to int
		var reversedCCnumberstring = ccnumber.ToCharArray().Reverse();

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

		ccnumber += checkdigit;

		return ccnumber;
	}

	/// <summary>
	/// Nexts the double.
	/// </summary>
	/// <returns>System.Double.</returns>
	private static double GetDouble()
	{
		var nextULong = BitConverter.ToUInt64(RandomNumberGenerator.GetBytes(sizeof(ulong)));

		return (nextULong >> 11) * (1.0 / (1ul << 53));
	}

	/// <summary>
	/// Generate a random credit card number. Supported credit cards include: American Express, Diners Club, Discover, EnRoute, JCB, MasterCard, Visa, and Voyager.
	/// </summary>
	/// <returns>System.String.</returns>
	public static string GetCreditCardNumber() => GetCreditCardNumbers(1).SingleOrDefault();

	/// <summary>
	/// Generate a collection of random credit card numbers. Supported credit cards include: American Express, Diners Club, Discover, EnRoute, JCB, MasterCard, Visa, and Voyager.
	/// </summary>
	/// <param name="count">The how many.</param>
	/// <returns>ReadOnlyCollection&lt;System.String&gt;.</returns>
	public static ReadOnlyCollection<string> GetCreditCardNumbers(int count)
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
	/// The prefixes
	/// </summary>
	private static readonly PrefixAndLength[] _prefixes = BuildPrefixAndLengths();

}
