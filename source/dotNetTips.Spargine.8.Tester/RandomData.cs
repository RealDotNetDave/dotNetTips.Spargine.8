// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-19-2019
//
// Last Modified By : David McCarter
// Last Modified On : 09-05-2024
// ***********************************************************************
// <copyright file="RandomData.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Create random data for unit and benchmark testing.</summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using DotNetTips.Spargine.Tester.Properties;
using Microsoft.Extensions.ObjectPool;
using Microsoft.VisualBasic;
using Address = DotNetTips.Spargine.Tester.Models.RefTypes.Address;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Provides methods for generating random data for various types. This class is useful for testing and simulation purposes,
/// offering functions to create random names, addresses, emails, phone numbers, and more.
/// </summary>
/// <remarks>
/// Utilizes <see cref="RandomNumberGenerator"/> for generating cryptographically secure random data where necessary.
/// This class is designed to be thread-safe and efficient in generating large volumes of random data.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public static class RandomData
{
	/// <summary>
	/// Specifies the number of digits in an address number.
	/// </summary>
	private const int AddressNumberCount = 5;

	/// <summary>
	/// The default file extension used when generating random file names.
	/// </summary>
	private const string DefaultFileExtension = "dotnettips.temp";

	/// <summary>
	/// The default length for generated files.
	/// </summary>
	private const int DefaultFileLength = 1024;

	/// <summary>
	/// The default maximum character used in various string generation methods.
	/// </summary>
	public const char DefaultMaxCharacter = 'z';

	/// <summary>
	/// The default maximum character used when generating random file names.
	/// </summary>
	public const char DefaultMaxCharacterRandomFile = 'Z';

	/// <summary>
	/// The default minimum character used when generating random file names.
	/// </summary>
	public const char DefaultMinCharacter = 'a';

	/// <summary>
	/// The default minimum character used when generating random file names.
	/// </summary>
	public const char DefaultMinCharacterRandomFile = 'A';

	/// <summary>
	/// A lazy-loaded read-only collection of countries.
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<Country>> _countries = new(Countries.GetCountries());

	/// <summary>
	/// A lazy-loaded array of domain extensions.
	/// </summary>
	private static readonly Lazy<string[]> _domainExtensions = new(Resources.DomainExtentions.Split(Core.ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries));

	/// <summary>
	/// A lazy-loaded read-only collection of first names.
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<string>> _firstNames = new(Resources.FirstNames.Split(Core.ControlChars.Comma, StringSplitOptions.TrimEntries).ToReadOnlyCollection());

	/// <summary>
	/// A lazy-loaded read-only collection of last names.
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<string>> _lastNames = new(Resources.LastNames.Split(Core.ControlChars.Comma, StringSplitOptions.TrimEntries).ToReadOnlyCollection());

	/// <summary>
	/// A cache for postal formats, keyed by country.
	/// </summary>
	private static readonly Dictionary<Country, string[]> _postalFormatsCache = [];

	/// <summary>
	/// Provides a thread-static instance of RandomNumberGenerator for generating cryptographically secure random numbers.
	/// </summary>
	[ThreadStatic]
	private static readonly RandomNumberGenerator _randomNumberGenerator;

	/// <summary>
	/// An object pool for reusing instances of StringBuilder, reducing allocations.
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// An object used for locking to ensure thread safety in certain operations.
	/// </summary>
	private static readonly object Lock = new();

	/// <summary>
	/// Initializes static members of the <see cref="RandomData" /> class.
	/// </summary>
	static RandomData() => _randomNumberGenerator = RandomNumberGenerator.Create();

	/// <summary>
	/// Generates the first line of an address.
	/// </summary>
	/// <param name="addressLength">The total desired length of the address line.</param>
	/// <returns>A string representing the first line of an address.</returns>
	/// <remarks>
	/// This method combines a number, generated by <see cref="GenerateNumber(int)"/>, and a word, generated by <see cref="GenerateWord(int)"/>, to form an address line.
	/// The address number is controlled by <see cref="AddressNumberCount"/>, ensuring the generated address line meets the specified length requirements.
	/// </remarks>
	private static string GenerateAddressLineOne(in int addressLength) => $"{GenerateNumber(AddressNumberCount)} {GenerateWord(addressLength - AddressNumberCount - 1)}";

	/// <summary>
	/// Generates the second line of an address.
	/// </summary>
	/// <param name="addressLength">The total desired length of the address line.</param>
	/// <returns>A string representing the second line of an address.</returns>
	/// <remarks>
	/// This method combines a word, generated by <see cref="GenerateWord(int)"/>, and a number, generated by <see cref="GenerateNumber(int)"/>, to form an address line.
	/// The address number is controlled by <see cref="AddressNumberCount"/>, ensuring the generated address line meets the specified length requirements.
	/// </remarks>
	private static string GenerateAddressLineTwo(in int addressLength) => $"{GenerateWord(addressLength - AddressNumberCount - 1)} {GenerateNumber(AddressNumberCount)}";

	/// <summary>
	/// Generates an email address using the provided first and last names. If either is null or empty, defaults are used.
	/// </summary>
	/// <param name="firstName">The first name to use in the email address. Defaults to "FIRSTNAME" if null or empty.</param>
	/// <param name="lastName">The last name to use in the email address. Defaults to "LASTNAME" if null or empty.</param>
	/// <returns>A string representing the generated email address.</returns>
	/// <remarks>
	/// This method utilizes <see cref="StringExtensions.DefaultIfNullOrEmpty(string, string)"/> to provide default values for null or empty names,
	/// <see cref="GenerateWord(int, int, char, char)"/> to generate a random domain name, and <see cref="GenerateDomainExtension"/> to append a random domain extension.
	/// </remarks>
	private static string GenerateEmailAddressWithName(string firstName, string lastName) => $"{firstName.DefaultIfNullOrEmpty("FIRSTNAME")}.{lastName.DefaultIfNullOrEmpty("LASTNAME")}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";

	/// <summary>
	/// Generates a postal code for the specified country and city.
	/// </summary>
	/// <param name="country">The country for which to generate a postal code. Cannot be null.</param>
	/// <param name="city">The city within the country for which to generate a postal code. Can be null.</param>
	/// <returns>A string representing the generated postal code.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="country"/> is null.</exception>
	/// <remarks>
	/// Utilizes <see cref="Country"/> to determine the format of the postal code. If <paramref name="city"/> is provided,
	/// it may influence the generated postal code based on city-specific rules.
	/// </remarks>
	private static string GeneratePostalCode([NotNull] Country country, [AllowNull] City city)
	{
		country = country.ArgumentNotNull();

		if (!_postalFormatsCache.TryGetValue(country, out var postalFormats))
		{
			if (string.IsNullOrEmpty(country.PostalFormat))
			{
				return string.Empty;
			}

			postalFormats = country.PostalFormat.Split(Core.ControlChars.Comma);
			_postalFormatsCache[country] = postalFormats;
		}

		var format = postalFormats.PickRandom();
		var builder = _stringBuilderPool.Get();

		try
		{
			foreach (var character in format.AsSpan())
			{
				_ = character switch
				{
					'N' => builder.Append(GenerateNumber(1)),
					'A' => builder.Append(GenerateCharacter('A', 'Z')),
					_ => builder.Append(character),
				};
			}

			_ = builder.Replace("CC", country.Iso2);

			if (city is not null && format.Contains("CITY", StringComparison.Ordinal))
			{
				_ = builder.Replace("CITY", city.Name);
			}

			return builder.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(builder);
		}
	}

	/// <summary>
	/// Selects a random word from the provided array of words.
	/// </summary>
	/// <param name="words">An array of words to select from. Cannot be null or empty.</param>
	/// <returns>A randomly selected word from the array.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the input array is null, ensuring the array is not null.</exception>
	/// <exception cref="ArgumentException">Thrown when the input array is empty, ensuring the array contains at least one element.</exception>
	/// <remarks>
	/// This method utilizes <see cref="GenerateInteger(int, int)"/> to select a random index within the bounds of the <paramref name="words"/> array.
	/// </remarks>
	private static string Of([NotNull] params string[] words) => words[GenerateInteger(0, words.Length - 1)];

	/// <summary>
	/// Creates a file with a specified length filled with random data.
	/// </summary>
	/// <param name="fileName">The name of the file to create. Cannot be null or empty.</param>
	/// <param name="fileLength">The length of the file in bytes. Defaults to <see cref="DefaultFileLength"/> if not specified.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="fileName"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="fileName"/> is empty.</exception>
	/// <remarks>
	/// This method uses <see cref="RandomNumberGenerator"/> for generating random data to fill the file.
	/// </remarks>
	internal static void CreateFile([NotNull] string fileName, in int fileLength = DefaultFileLength)
	{
		const int bufferSize = 4096; // Use a buffer size of 4KB.
		var buffer = new byte[bufferSize];
		var iterations = fileLength / bufferSize;
		var remainingBytes = fileLength % bufferSize;

		using (var rng = RandomNumberGenerator.Create())
		{
			using (var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize))
			{
				for (var index = 0; index < iterations; index++)
				{
					rng.GetBytes(buffer);
					fileStream.Write(buffer, 0, buffer.Length);
				}

				if (remainingBytes > 0)
				{
					buffer = new byte[remainingBytes];
					rng.GetBytes(buffer);
					fileStream.Write(buffer, 0, buffer.Length);
				}
			}
		}
	}

	/// <summary>
	/// Generates a collection of addresses of type <typeparamref name="T"/>, where each address is populated with random data.
	/// </summary>
	/// <typeparam name="T">The type of address to generate, must implement <see cref="IAddress"/>.</typeparam>
	/// <param name="country">The country for which to generate addresses. Must not be null.</param>
	/// <param name="count">The number of addresses to generate. Defaults to 2.</param>
	/// <param name="addressLength">The length of the address line. Defaults to 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province. Defaults to 20.</param>
	/// <returns>A collection of addresses of the specified type.</returns>
	[Information(nameof(GenerateAddressCollection), "David McCarter", "12/4/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static Collection<T> GenerateAddressCollection<T>(Country country, int count = 2, int addressLength = 25, int countyProvinceLength = 20) where T : IAddress, new()
	{
		country = country.ArgumentNotNull();
		count = count.ArgumentInRange(lower: 0, defaultValue: 2);
		addressLength = addressLength.ArgumentInRange(lower: 5, upper: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(lower: 5, upper: 50);

		var addresses = new List<T>(count);

		for (var addressIndex = 0; addressIndex < count; addressIndex++)
		{
			var state = country.States?.PickRandom();
			var city = state?.Cities?.PickRandom();

			addresses.Add(new T()
			{
				Id = GenerateKey(),
				Address1 = GenerateAddressLineOne(addressLength),
				Address2 = GenerateAddressLineTwo(addressLength),
				City = city is null ? string.Empty : city.Name,
				Country = country.Name,
				CountyProvince = GenerateWord(countyProvinceLength),
				Phone = GenerateNumber(country.PhoneNumberLength),
				PostalCode = GeneratePostalCode(country, city),
				State = state is null ? string.Empty : state.Name,
			});
		}

		return addresses.ToCollection();
	}

	/// <summary>
	/// Generate a collection of <see cref="AddressRecord" /> instances.
	/// </summary>
	/// <param name="country">The countryName.</param>
	/// <param name="count">The address count. Count must be 0 or higher. Defaults to 2.</param>
	/// <param name="addressLength">Length of the address. Length must be between 5 - 100. Defaults to 25.</param>
	/// <param name="countyProvinceLength">Length of the county province. Length must be between 5 - 50. Defaults to 20.</param>
	/// <returns>System.Collections.ObjectModel.Collection&lt;DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord&gt;.</returns>
	[Information(nameof(GenerateAddressRecordCollection), author: "David McCarter", createdOn: "3/14/2023", UnitTestStatus = UnitTestStatus.WIP, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/Spargine8")]
	public static Collection<AddressRecord> GenerateAddressRecordCollection([NotNull] CountryName country, int count = 2, int addressLength = 25, int countyProvinceLength = 20)
	{
		count = count.ArgumentInRange(lower: 0, defaultValue: 2);
		addressLength = addressLength.ArgumentInRange(lower: 5, upper: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(lower: 5, upper: 50);

		var addresses = new List<AddressRecord>(count);

		var addressCollection = GenerateAddressCollection<Address>(Countries.GetCountry(country).ArgumentNotNull(paramName: country.GetDescription()), count, addressLength, countyProvinceLength);

		foreach (var address in addressCollection)
		{
			addresses.Add(AddressRecord.ToAddress(address));
		}

		return addresses.ToCollection();
	}

	/// <summary>
	/// Generates a byte array of a specified size in kilobytes.
	/// </summary>
	/// <param name="sizeInKb">The size of the byte array to generate, in kilobytes.</param>
	/// <returns>A byte array filled with random bytes.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="sizeInKb"/> is negative.</exception>
	/// <remarks>
	/// This method uses <see cref="RandomNumberGenerator"/> to fill the byte array with cryptographically secure random bytes.
	/// </remarks>
	[Information(nameof(GenerateByteArray), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static byte[] GenerateByteArray(double sizeInKb)
	{
		sizeInKb = sizeInKb.ArgumentMeetsCondition(sizeInKb >= double.Epsilon, errorMessage: string.Format(CultureInfo.InvariantCulture, Resources.SizeMustBeEpsilon, double.Epsilon));

		var bytes = new byte[Convert.ToInt32(sizeInKb * 1024)];

		lock (Lock)
		{
			_randomNumberGenerator.GetBytes(bytes);
		}

		return bytes;
	}

	/// <summary>
	/// Generates a random character using the default minimum and maximum character constraints.
	/// </summary>
	/// <returns>A random character between <see cref="DefaultMinCharacter"/> and <see cref="DefaultMaxCharacter"/>.</returns>
	/// <example>Output: 82 'R'</example>
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static char GenerateCharacter() => GenerateCharacter(DefaultMinCharacter, DefaultMaxCharacter);

	/// <summary>
	/// Generates a random character within a specified range.
	/// </summary>
	/// <param name="minValue">The minimum value of the character to generate.</param>
	/// <param name="maxValue">The maximum value of the character to generate.</param>
	/// <returns>A random character between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
	/// <remarks>
	/// This method utilizes <see cref="GenerateInteger(int, int)"/> to generate a random integer within the specified range and then casts it to a character.
	/// </remarks>
	/// <example>Output: 65 'A'</example>
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static char GenerateCharacter(char minValue, char maxValue) => (char)GenerateInteger(minValue, maxValue);

	/// <summary>
	/// Generates a coordinate with random values for X, Y, and Z using the specified <typeparamref name="T"/> which must implement <see cref="ICoordinate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the coordinate to generate. Must implement <see cref="ICoordinate"/>.</typeparam>
	/// <returns>A new instance of <typeparamref name="T"/> with random values for X, Y, and Z.</returns>
	/// <example>Output: X: 178765551 Y: -2145952440</example>
	[Information(nameof(GenerateCoordinate), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static T GenerateCoordinate<T>() where T : ICoordinate, new() => new() { X = GenerateInteger(), Y = GenerateInteger(), Z = GenerateInteger() };

	/// <summary>
	/// Generates a collection of coordinates with random values for X, Y, and Z.
	/// </summary>
	/// <typeparam name="T">The type of the coordinate to generate. Must implement <see cref="ICoordinate"/>.</typeparam>
	/// <param name="count">The number of coordinates to generate in the collection.</param>
	/// <returns>A read-only collection of <typeparamref name="T"/> with random values for X, Y, and Z.</returns>
	/// <example>Output: [0]: {2089369587--284215139} [1]: {244137335-1577361939}</example>
	[Information(nameof(GenerateCoordinateCollection), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<T> GenerateCoordinateCollection<T>(int count = 1) where T : ICoordinate, new()
	{
		count = count.ArgumentInRange(lower: 1, defaultValue: 1);

		var coordinates = new List<T>(count);

		for (var coordinateIndex = 0; coordinateIndex < count; coordinateIndex++)
		{
			coordinates.Add(GenerateCoordinate<T>());
		}

		return coordinates.AsReadOnly();
	}

	/// <summary>
	/// Generates a random credit card number.
	/// </summary>
	/// <returns>A string representing a random credit card number.</returns>
	/// <remarks>
	/// This method utilizes the <see cref="RandomCreditCardNumberGenerator.GetCreditCardNumber"/> method to generate a valid credit card number.
	/// </remarks>
	[Information(nameof(GenerateCreditCard), "David McCarter", "3/13/2023", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static string GenerateCreditCard() => RandomCreditCardNumberGenerator.GetCreditCardNumber();

	/// <summary>
	/// Generates a read-only collection of random credit card numbers.
	/// </summary>
	/// <param name="count">The number of credit card numbers to generate. Default is 1.</param>
	/// <returns>A read-only collection of random credit card numbers.</returns>
	/// <remarks>
	/// This method leverages the <see cref="GenerateCreditCard"/> method to generate each credit card number in the collection.
	/// </remarks>
	[Information(nameof(GenerateCreditCard), "David McCarter", "3/13/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> GenerateCreditCards(int count = 1)
	{
		count = count.ArgumentInRange(1, defaultValue: 1);

		return RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);
	}

	/// <summary>
	/// Generates a random decimal number within a specified range and with a specified number of decimal places.
	/// </summary>
	/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
	/// <param name="maxValue">The exclusive upper bound of the random number returned. <paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.</param>
	/// <param name="decimalPlaces">The number of decimal places for the generated number.</param>
	/// <returns>A decimal number that is greater than or equal to <paramref name="minValue"/>, less than <paramref name="maxValue"/>, and rounded to <paramref name="decimalPlaces"/> decimal places.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="minValue"/> is greater than <paramref name="maxValue"/>, or <paramref name="decimalPlaces"/> is negative.</exception>
	/// <example>Output: 95.15</example>
	[Information(nameof(GenerateDecimal), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static decimal GenerateDecimal(in decimal minValue, in decimal maxValue, int decimalPlaces)
	{
		decimalPlaces = decimalPlaces.ArgumentInRange(lower: 0, defaultValue: 0);

		var multiplier = ((decimal)decimalPlaces) * 10;

		return GenerateInteger((int)(minValue * multiplier), (int)(maxValue * multiplier)) / multiplier;
	}

	/// <summary>
	/// Generates a random domain extension from a predefined list.
	/// </summary>
	/// <returns>A string representing a random domain extension.</returns>
	/// <remarks>
	/// This method selects a random domain extension from a predefined list using the <see cref="Of(string[])"/> method.
	/// </remarks>
	/// <example>Output: creditunion</example>
	[Information(nameof(GenerateDomainExtension), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateDomainExtension() => Of(_domainExtensions.Value);

	/// <summary>
	/// Generates a random email address.
	/// </summary>
	/// <returns>A string representing a random email address.</returns>
	/// <remarks>
	/// This method constructs an email address by generating a random username and domain name using <see cref="GenerateWord(int, int, char, char)"/> and appends a random domain extension using <see cref="GenerateDomainExtension"/>.
	/// </remarks>
	/// <example>Output: fbxpfvtanqysqmuqfh@kiuvf.fr</example>
	[Information(nameof(GenerateEmailAddress), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string GenerateEmailAddress() => $"{GenerateWord(5, 25, 'a', 'z')}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";

	/// <summary>
	/// Generates a file with random content.
	/// </summary>
	/// <param name="fileName">The name of the file to generate.</param>
	/// <param name="fileLength">The length of the file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <returns>The path to the generated file.</returns>
	/// <remarks>
	/// This method uses <see cref="GenerateCharacter()"/> to generate random content for the file.
	/// </remarks>
	/// <example>Output: C:\\Users\\user folder\\AppData\\Roaming\\UnitTest.test</example>
	[Information(nameof(GenerateFile), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateFile(string fileName, int fileLength = DefaultFileLength)
	{
		fileName = fileName.ArgumentNotNullOrEmpty(trim: true);
		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: 1);

		CreateFile(fileName, fileLength);

		return fileName;
	}

	/// <summary>
	/// Generates a specified number of files with random content, each having a specified length and file extension.
	/// </summary>
	/// <param name="count">The number of files to generate. Default is 1.</param>
	/// <param name="fileLength">The length of each file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <param name="fileExtension">The file extension for each generated file. Default is <see cref="DefaultFileExtension"/>.</param>
	/// <returns>A tuple containing the path where files are generated and a read-only collection of the names of the generated files.</returns>
	[Information(nameof(GenerateFiles), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static (string Path, ReadOnlyCollection<string> Files) GenerateFiles(int count = 1, int fileLength = DefaultFileLength, string fileExtension = DefaultFileExtension)
	{
		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: 1);
		fileExtension = fileExtension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var files = new List<string>(count);

		for (var fileIndex = 0; fileIndex < count; fileIndex++)
		{
			files.Add(GenerateFile(GenerateRandomFileName(fileNameLength: 25, extension: fileExtension), fileLength));
		}

		return (Path.GetTempPath(), files.AsReadOnly());
	}

	/// <summary>
	/// Generates a specified number of files with random content at the given path, each having a specified length and file extension.
	/// </summary>
	/// <param name="path">The directory path where the files will be generated. Must not be null.</param>
	/// <param name="count">The number of files to generate. Default is 100.</param>
	/// <param name="fileLength">The length of each file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <remarks>
	/// This method leverages <see cref="CreateFile"/> for file creation and GenerateRandomFileName to generate unique file names.
	/// </remarks>
	/// <example>Output: [0]: "c:\\temp\\dobybcyx.lj"  [1]: "c:\\temp\\zo2ggwub.3ro"</example>
	[Information(nameof(GenerateFiles), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<string> GenerateFiles([NotNull] string path, int count = 100, int fileLength = DefaultFileLength)
	{
		path = path.ArgumentNotNullOrEmpty();
		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: 1);

		_ = Directory.CreateDirectory(path);

		var files = new List<string>(count);

		for (var fileCount = 0; fileCount < count; fileCount++)
		{
			var fileName = GenerateRandomFileName(path);

			CreateFile(fileName, fileLength);

			files.Add(fileName);
		}

		return files.AsReadOnly();
	}

	/// <summary>
	/// Generates a random first name from a predefined list from a pool containing over 1,800 names.
	/// </summary>
	/// <returns>A string representing a random first name.</returns>
	/// <remarks>
	/// This method selects a random first name from a predefined list using the PickRandom{T}(IEnumerable{T}) extension method on <see cref="_firstNames"/>.
	/// </remarks>
	[Information(nameof(GenerateFirstName), "David McCarter", "3/11/2023", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static string GenerateFirstName() => _firstNames.Value.PickRandom();

	/// <summary>
	/// Generates a random integer within a specified range.
	/// </summary>
	/// <param name="min">The inclusive lower bound of the random number returned. Default is <see cref="int.MinValue"/>.</param>
	/// <param name="max">The exclusive upper bound of the random number returned. Must be greater than or equal to <paramref name="min"/>. Default is <see cref="int.MaxValue"/>.</param>
	/// <returns>A 32-bit signed integer greater than or equal to <paramref name="min"/> and less than <paramref name="max"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
	[Information(nameof(GenerateInteger), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static int GenerateInteger(int min = int.MinValue, int max = int.MaxValue)
	{
		//Ensure maxLength is +1 of minLength so the _randomNumberGenerator does not cause an exception.
		max = max.EnsureMinimum(min + 1);

		lock (Lock)
		{
			return RandomNumberGenerator.GetInt32(min, max);
		}
	}

	/// <summary>
	/// Generates a unique key using the <see cref="GenerateKey"/> method.
	/// </summary>
	/// <returns>A unique key as a string.</returns>
	/// <example>Output: f7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateKey), "David McCarter", "1/19/2019", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateKey() => KeyGenerator.GenerateKey();

	/// <summary>
	/// Generates a random last name from a predefined list from a pool containing over 2,000 names.
	/// </summary>
	/// <returns>A string representing a random last name.</returns>
	/// <remarks>
	/// This method selects a random last name from a predefined list using the PickRandom{T}System.Collections.Generic.IEnumerable{T} extension method on <see cref="_lastNames"/>.
	/// </remarks>
	[Information(nameof(GenerateLastName), "David McCarter", "3/11/2023", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static string GenerateLastName() => _lastNames.Value.PickRandom();

	/// <summary>
	/// Generates a string representation of a random number with the specified length.
	/// </summary>
	/// <param name="length">The length of the number to generate. Default is 1.</param>
	/// <returns>A string containing a random number of the specified length.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="length"/> is less than 1.</exception>
	/// <remarks>
	/// This method uses <see cref="Random"/> for generating each digit of the number. Ensure that the <see cref="Random"/> instance is properly initialized to avoid generating predictable sequences.
	/// </remarks>
	/// <example>Output: "446085072052112"</example>
	[Information(nameof(GenerateNumber), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static string GenerateNumber(int length = 1)
	{
		length = length.ArgumentInRange(lower: 1, defaultValue: 1);

		var sb = _stringBuilderPool.Get();

		try
		{
			lock (Lock)
			{
				for (var numberIndex = 0; numberIndex < length; numberIndex++)
				{
					_ = sb.Append(RandomNumberGenerator.GetInt32(0, 9));
				}
			}

			return sb.ToString().ToTrimmed();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Generates a collection of <see cref="PersonName"/> objects.
	/// </summary>
	/// <param name="count">The number of <see cref="PersonName"/> objects to generate. Default is 1.</param>
	/// <returns>A read-only collection of <see cref="PersonName"/> objects.</returns>
	/// <remarks>
	/// This method leverages <see cref="GenerateFirstName"/> and <see cref="GenerateLastName"/> to create each <see cref="PersonName"/>.
	/// </remarks>
	[Information(nameof(GeneratePersonNames), "David McCarter", "12/15/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static ReadOnlyCollection<PersonName> GeneratePersonNames(int count = 1)
	{
		count = count.ArgumentInRange(lower: 1, defaultValue: 1);

		var names = new List<PersonName>(count);

		for (var nameIndex = 0; nameIndex < count; nameIndex++)
		{
			var personName = new PersonName(_firstNames.Value.PickRandom(), _lastNames.Value.PickRandom());

			if (names.AddIfNotExists(personName) is false)
			{
				nameIndex--;
			}
		}

		return names.ToReadOnlyCollection();
	}

	/// <summary>
	/// Generates a <see cref="PersonRecord"/> with random data.
	/// </summary>
	/// <param name="addressCount">The number of addresses to generate for the person. Default is 2.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>A <see cref="PersonRecord"/> populated with random data.</returns>
	/// <remarks>
	/// This method leverages <see cref="GenerateAddressCollection{T}(Country, int, int, int)"/> to generate addresses for the person.
	/// </remarks>
	[Information(nameof(GeneratePersonRecord), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static PersonRecord GeneratePersonRecord(int addressCount = 2, int addressLength = 25, int countyProvinceLength = 20)
	{
		addressCount = addressCount.ArgumentInRange(lower: 0, upper: 100, defaultValue: 2);

		var personData = GeneratePersonRef<Address>(addressCount, addressLength, countyProvinceLength);

		var person = PersonRecord.ToPersonRecord(personData);
		return person;
	}

	/// <summary>
	/// Generates a collection of <see cref="PersonRecord"/> objects.
	/// </summary>
	/// <param name="count">The number of <see cref="PersonRecord"/> objects to generate. Default is 1.</param>
	/// <returns>A read-only collection of <see cref="PersonRecord"/> objects.</returns>
	/// <remarks>
	/// This method leverages <see cref="GeneratePersonRecord(int, int, int)"/> to create each <see cref="PersonRecord"/> in the collection.
	/// </remarks>
	[Information(nameof(GeneratePersonRecordCollection), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static ReadOnlyCollection<PersonRecord> GeneratePersonRecordCollection(int count = 1)
	{
		count = count.ArgumentInRange(lower: 1, defaultValue: 1);

		var records = new List<PersonRecord>(count);

		for (var recordIndex = 0; recordIndex < count; recordIndex++)
		{
			var person = GeneratePersonRecord();

			records.Add(person);
		}

		return records.AsReadOnly();
	}

	/// <summary>
	/// Generates a <see cref="Models.RefTypes.Person{TAddress}"/> object with random data.
	/// </summary>
	/// <typeparam name="TAddress">The type of address, must implement <see cref="IAddress"/> and have a parameterless constructor.</typeparam>
	/// <param name="addressCount">The number of addresses to generate for the person. Default is 2.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>A <see cref="Models.RefTypes.Person{TAddress}"/> object populated with random address data.</returns>

	[Information(nameof(GeneratePersonRef), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static Models.RefTypes.Person<TAddress> GeneratePersonRef<TAddress>(int addressCount = 2, int addressLength = 25, int countyProvinceLength = 20) where TAddress : IAddress, new()
	{
		addressCount = addressCount.ArgumentInRange(lower: 0, defaultValue: 2);
		addressLength = addressLength.ArgumentInRange(lower: 5, upper: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(lower: 5, upper: 50);

		var personData = GenerateRandomPersonData();

		var person = new Models.RefTypes.Person<TAddress>()
		{
			Addresses = GenerateAddressCollection<TAddress>(personData.Country, addressCount, addressLength, countyProvinceLength),
			BornOn = personData.BornOn,
			CellPhone = personData.CellPhone,
			Email = personData.Email,
			FirstName = personData.FirstName,
			Id = GenerateKey(),
			LastName = personData.LastName,
			Phone = personData.Phone,
		};

		return person;
	}

	/// <summary>
	/// Generates a read-only collection of <see cref="Models.RefTypes.Person{TAddress}"/> objects.
	/// </summary>
	/// <typeparam name="TAddress">The type of address, must implement <see cref="IAddress"/> and have a parameterless constructor.</typeparam>
	/// <param name="count">The number of <see cref="Models.RefTypes.Person{TAddress}"/> objects to generate. Default is 1.</param>
	/// <returns>A read-only collection of <see cref="Models.RefTypes.Person{TAddress}"/> objects.</returns>
	[Information(nameof(GeneratePersonRefCollection), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static ReadOnlyCollection<Models.RefTypes.Person<TAddress>> GeneratePersonRefCollection<TAddress>(int count = 1) where TAddress : IAddress, new()
	{
		count = count.ArgumentInRange(lower: 1, defaultValue: 1);

		var people = new List<Models.RefTypes.Person<TAddress>>(count);

		for (var index = 0; index < count; index++)
		{
			people.Add(GeneratePersonRef<TAddress>());
		}

		return people.AsReadOnly();
	}

	/// <summary>
	/// Generates a <see cref="Models.ValueTypes.Person{TAddress}"/> object with specified parameters.
	/// </summary>
	/// <typeparam name="TAddress">The type of address, must be a struct and implement <see cref="IAddress"/>.</typeparam>
	/// <param name="addressCount">The number of addresses to generate for the person. Default is 2.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>A <see cref="Models.ValueTypes.Person{TAddress}"/> object.</returns>
	[Information(nameof(GeneratePersonVal), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static Models.ValueTypes.Person<TAddress> GeneratePersonVal<TAddress>(int addressCount = 2, int addressLength = 25, int countyProvinceLength = 20) where TAddress : struct, IAddress
	{
		addressCount = addressCount.ArgumentInRange(lower: 0, defaultValue: 2);
		addressLength = addressLength.ArgumentInRange(lower: 5, upper: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(lower: 5, upper: 50);

		var personData = GenerateRandomPersonData();

		var person = new Models.ValueTypes.Person<TAddress>
		{
			Addresses = GenerateAddressCollection<TAddress>(personData.Country, addressCount, addressLength, countyProvinceLength),
			BornOn = personData.BornOn,
			CellPhone = personData.CellPhone,
			Email = personData.Email,
			FirstName = personData.FirstName,
			Id = GenerateKey(),
			LastName = personData.LastName,
			Phone = personData.Phone,
		};

		return person;
	}

	/// <summary>
	/// Generates a read-only collection of <see cref="Models.ValueTypes.Person{TAddress}"/> objects.
	/// </summary>
	/// <typeparam name="TAddress">The type of address, must be a struct and implement <see cref="IAddress"/>.</typeparam>
	/// <param name="count">The number of <see cref="Models.ValueTypes.Person{TAddress}"/> objects to generate. Default is 1.</param>
	/// <returns>A read-only collection of <see cref="Models.ValueTypes.Person{TAddress}"/> objects.</returns>
	[Information(nameof(GeneratePersonValCollection), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static ReadOnlyCollection<Models.ValueTypes.Person<TAddress>> GeneratePersonValCollection<TAddress>(int count = 1) where TAddress : struct, IAddress
	{
		count = count.ArgumentInRange(lower: 1, defaultValue: 1);

		var people = new List<Models.ValueTypes.Person<TAddress>>(count);

		for (var index = 0; index < count; index++)
		{
			people.Add(GeneratePersonVal<TAddress>());
		}

		return people.AsReadOnly();
	}

	/// <summary>
	/// Generates a phone number for the specified <paramref name="country"/>. Optionally includes the country code.
	/// </summary>
	/// <param name="country">The country for which to generate the phone number. Must not be null.</param>
	/// <param name="includeCountryCode">If set to <c>true</c>, includes the country code in the generated phone number.</param>
	/// <returns>A string representing the generated phone number.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="country"/> is null.</exception>
	/// <remarks>
	/// This method utilizes the <see cref="Country"/> enumeration to determine the format of the generated phone number.
	/// </remarks>
	/// <example>Output for Taiwan: 886-352346002</example>
	[Information(nameof(GeneratePhoneNumber), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static string GeneratePhoneNumber([NotNull] Country country, bool includeCountryCode = false)
	{
		country = country.ArgumentNotNull();

		return includeCountryCode ? $"{country.PhoneCode}-{GenerateNumber(country.PhoneNumberLength)}" : GenerateNumber(country.PhoneNumberLength);
	}

	/// <summary>
	/// Generates a phone number for the specified country. Optionally includes the country code.
	/// </summary>
	/// <param name="countryName">The country for which to generate the phone number. Uses the <see cref="CountryName"/> enum.</param>
	/// <param name="includeCountryCode">If set to <c>true</c>, includes the country code in the generated phone number.</param>
	/// <returns>A string representing the generated phone number.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="countryName"/> is null.</exception>
	/// <remarks>
	/// This method utilizes the <see cref="CountryName"/> enumeration to determine the format of the generated phone number.
	/// </remarks>
	/// <example>Output for Taiwan: 886-352346002</example>
	[Information(nameof(GeneratePhoneNumber), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/Spargine8")]
	public static string GeneratePhoneNumber([NotNull] CountryName countryName, bool includeCountryCode = false)
	{
		countryName = countryName.ArgumentDefined();

		//Lookup Country
		var country = Countries.GetCountry(countryName);

		return includeCountryCode ? $"{country.PhoneCode}-{GenerateNumber(country.PhoneNumberLength)}" : GenerateNumber(country.PhoneNumberLength);
	}

	/// <summary>
	/// Generates a random file name with the specified length and extension in the temp path.
	/// </summary>
	/// <param name="fileNameLength">The length of the file name. Default is 10.</param>
	/// <param name="extension">The file extension. Default is <see cref="DefaultFileExtension"/>.</param>
	/// <returns>A random file name with the specified length and extension.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="extension"/> is null.</exception>
	[Information(nameof(GenerateRandomFileName), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static string GenerateRandomFileName(int fileNameLength = 10, [NotNull] string extension = DefaultFileExtension)
	{
		fileNameLength = fileNameLength.ArgumentInRange(1, upper: 256);
		extension = extension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var fileName = $"{GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile)}{Core.ControlChars.Dot}{extension}";

		return Path.Combine(Path.GetTempPath(), fileName);
	}

	/// <summary>
	/// Generates a random file name with the specified length and extension at the given path.
	/// </summary>
	/// <param name="path">The path where the file will be generated. Must not be null.</param>
	/// <param name="fileNameLength">The length of the file name. Default is 10.</param>
	/// <param name="extension">The file extension. Default is <see cref="DefaultFileExtension"/>.</param>
	/// <returns>A string representing the full path of the generated file.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> or <paramref name="extension"/> is null.</exception>
	/// <example>Output: c:\\temp\\FFDHRBMDXP.dotnettips</example>
	[Information(nameof(GenerateRandomFileName), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static string GenerateRandomFileName([NotNull] string path, int fileNameLength = 10, [NotNull] string extension = DefaultFileExtension)
	{
		fileNameLength = fileNameLength.ArgumentInRange(1, upper: 256);
		extension = extension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var fileName = $"{GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile)}{Core.ControlChars.Dot}{extension}";

		return Path.Combine(path, fileName);
	}

	/// <summary>
	/// Generates random real location data including country, state, and city.
	/// </summary>
	/// <returns>A tuple containing a <see cref="Country"/>, <see cref="State"/>, and <see cref="City"/>.</returns>
	[Information(nameof(GenerateRandomLocationData), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.NeedsDocumentation)]
	public static (Country country, State state, City city) GenerateRandomLocationData()
	{
		var country = _countries.Value.PickRandom();
		State state = null;
		City city = null;

		if (country.States.HasItems())
		{
			state = country.States.PickRandom();

			if (state.Cities.HasItems())
			{
				city = state.Cities.PickRandom();
			}
		}

		return (country, state, city);
	}

	/// <summary>
	/// Generates random person data including first name, last name, and email.
	/// </summary>
	/// <returns>A <see cref="PersonData"/> object populated with random values.</returns>
	[Information(nameof(GenerateRandomPersonData), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.NeedsDocumentation)]
	public static PersonData GenerateRandomPersonData()
	{
		var (country, _, _) = GenerateRandomLocationData();
		var (firstName, lastName) = GenerateRandomPersonName();

		var data = new PersonData
		{
			BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 90), 0, 0, 0)),
			CellPhone = GenerateNumber(country.PhoneNumberLength),
			Country = country,
			Email = GenerateEmailAddressWithName(firstName, lastName),
			FirstName = firstName,
			LastName = lastName,
			Phone = GenerateNumber(country.PhoneNumberLength),
		};

		return data;
	}

	/// <summary>
	/// Generates a random person's first and last name.
	/// </summary>
	/// <returns>A tuple containing the first name and last name of a person. The first name is generated using <see cref="GenerateFirstName"/> and the last name is generated using <see cref="GenerateLastName"/>.</returns>
	[Information(nameof(GenerateRandomLocationData), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.NeedsDocumentation)]
	public static (string firstName, string lastName) GenerateRandomPersonName() => (GenerateFirstName(), GenerateLastName());

	/// <summary>
	/// Generates a relative URL.
	/// </summary>
	/// <returns>A string representing a relative URL.</returns>
	/// <remarks>
	/// This method can be used to generate relative URLs for web applications. It's a part of the <see cref="RandomData"/> class which provides various methods for generating random data.
	/// </remarks>
	/// <example>Output:"/ljsylu/rsglcurkiylqld/wejdbuainlgjofnv/uwbrjftyt/"</example>
	[Information(nameof(GenerateRelativeUrl), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static string GenerateRelativeUrl()
	{
		var sb = _stringBuilderPool.Get();

		try
		{
			for (var lengthIndex = 0; lengthIndex < GenerateInteger(1, 10); lengthIndex++)
			{
				_ = sb.Append(GenerateUrlFragment());
			}

			sb = sb.Append('/');

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Generates a temporary file with random content.
	/// </summary>
	/// <param name="fileLength">The length of the file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <returns>The path to the generated temporary file.</returns>
	/// <example>Output: C:\\Users\\user folder\\AppData\\Local\\Temp\\OFQCKBRAKQ.dotnettips.temp</example>
	[Information(nameof(GenerateTempFile), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static string GenerateTempFile(int fileLength = DefaultFileLength)
	{
		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: DefaultFileLength);

		var fileName = GenerateRandomFileName();
		var fakeText = GenerateWord(fileLength);

		File.WriteAllText(fileName, fakeText);

		return fileName;
	}

	/// <summary>
	/// Generates a full URL by combining a randomly generated host name with a randomly generated relative URL.
	/// </summary>
	/// <returns>A string representing the full URL.</returns>
	/// <remarks>
	/// This method combines the output of <see cref="GenerateUrlHostName"/> and <see cref="GenerateRelativeUrl"/> to construct the full URL.
	/// </remarks>
	/// <example>Output: https://www.rp.red/wyfkxbfft/pqypmdstoydnootvdvnsqkn/</example>
	[Information(nameof(GenerateUrl), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static string GenerateUrl() => $"{GenerateUrlHostName()}{GenerateRelativeUrl()}";

	/// <summary>
	/// Generates a URL fragment.
	/// </summary>
	/// <returns>A string representing a URL fragment.</returns>
	/// <remarks>
	/// The fragment is generated by creating a random word using <see cref="GenerateWord(int, int, char, char)"/> method.
	/// </remarks>
	/// <example>Output: /rregyyjxpjiats</example>
	[Information(nameof(GenerateUrlFragment), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.NeedsDocumentation)]
	public static string GenerateUrlFragment() => $"/{GenerateWord(1, 25, 'a', 'z')}";

	/// <summary>
	/// Generates a URL host name with HTTPS protocol.
	/// </summary>
	/// <returns>A string representing a URL host name prefixed with HTTPS protocol.</returns>
	/// <remarks>
	/// This method constructs a full URL host name by prefixing the HTTPS protocol to the host name generated by <see cref="GenerateUrlHostNameNoProtocol"/>.
	/// </remarks>
	/// <example>Output: https://www.ukrsusbrtjijfktfj.shouji</example>
	[Information(nameof(GenerateUrlHostName), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
	public static string GenerateUrlHostName() => $"https://{GenerateUrlHostNameNoProtocol()}";

	/// <summary>
	/// Generates a URL host name without the protocol.
	/// </summary>
	/// <returns>A string representing a URL host name without the protocol. The domain name is generated using <see cref="GenerateWord(int, int, char, char)"/> and the top-level domain is generated using <see cref="GenerateUrlHostNameNoSubDomain"/>.</returns>
	/// <example>Output: www.txtkixvsxgryixbwrtje.shangrila</example>
	[Information(nameof(GenerateUrlHostNameNoProtocol), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string GenerateUrlHostNameNoProtocol() => $"www.{GenerateWord(1, 25, 'a', 'z')}.{GenerateUrlHostNameNoSubDomain()}";

	/// <summary>
	/// Generates a URL host name without the protocol by using a randomly generated domain extension.
	/// </summary>
	/// <returns>A string representing a URL host name without the protocol. The domain extension is generated using <see cref="GenerateDomainExtension"/>.</returns>
	/// <example>Output: dz</example>
	[Information(nameof(GenerateUrlHostNameNoSubDomain), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string GenerateUrlHostNameNoSubDomain() => GenerateDomainExtension();

	/// <summary>
	/// Generates a word of the specified length.
	/// </summary>
	/// <param name="length">The length of the word to generate. Default is 1.</param>
	/// <returns>A randomly generated word of the specified length.</returns>
	/// <remarks>
	/// This method utilizes <see cref="GenerateWord(int, int)"/> internally to generate a word within a specific range.
	/// </remarks>
	/// <example>Output: mL_g[E_E_CsoJvjshI]CFjFKa</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string GenerateWord(int length = 1)
	{
		length = length.ArgumentInRange(lower: 1, defaultValue: 1);

		var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);

		return returnValue;
	}

	/// <summary>
	/// Generates a random word with a length between the specified minimum and maximum lengths.
	/// </summary>
	/// <param name="minLength">The minimum length of the word.</param>
	/// <param name="maxLength">The maximum length of the word.</param>
	/// <returns>A randomly generated word.</returns>
	/// <example>Output: anvpwufadtxpfysguavguwm</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string GenerateWord(int minLength = 1, int maxLength = 1)
	{
		minLength = minLength.ArgumentInRange(lower: 1, defaultValue: 1);
		maxLength = maxLength.ArgumentInRange(lower: 1, defaultValue: 1);

		return GenerateWord(minLength, maxLength, DefaultMinCharacter, DefaultMaxCharacter);
	}

	/// <summary>
	/// Generates a word of the specified length using characters within the specified range.
	/// </summary>
	/// <param name="length">The length of the word to generate.</param>
	/// <param name="minCharacter">The minimum character to use for word generation. Default is 'a'.</param>
	/// <param name="maxCharacter">The maximum character to use for word generation. Default is 'Z'.</param>
	/// <returns>A randomly generated word.</returns>
	/// <remarks>
	/// This method utilizes the <see cref="Random"/> class for generating random characters within the specified range.
	/// </remarks>
	/// <example>Output: LBEEUMHHHK</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string GenerateWord(int length = 1, char minCharacter = 'a', char maxCharacter = 'Z')
	{
		length = length.ArgumentInRange(lower: 1, defaultValue: 1);

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var wordIndex = 0; wordIndex < length; wordIndex++)
			{
				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Generates a word with a random length within the specified range and character limits.
	/// </summary>
	/// <param name="minLength">The minimum length of the word. Must be greater than 0.</param>
	/// <param name="maxLength">The maximum length of the word. Must be greater than or equal to <paramref name="minLength"/>.</param>
	/// <param name="minCharacter">The minimum ASCII character to use for the word. Default is 'a'.</param>
	/// <param name="maxCharacter">The maximum ASCII character to use for the word. Default is 'Z'.</param>
	/// <returns>A randomly generated word.</returns>
	/// <remarks>
	/// This method utilizes the <see cref="Random"/> class for generating random characters within the specified range.
	/// </remarks>
	/// <example>Output: ACRNFTPAE</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string GenerateWord(int minLength = 1, int maxLength = 1, char minCharacter = 'a', char maxCharacter = 'Z')
	{
		minLength = minLength.ArgumentInRange(1, defaultValue: 1);
		maxLength = maxLength.ArgumentInRange(1, defaultValue: 1);

		return GenerateWord(GenerateInteger(minLength, maxLength), minCharacter, maxCharacter);
	}

	/// <summary>
	/// Generates a collection of random words.
	/// </summary>
	/// <param name="count">The number of words to generate. Default is 1.</param>
	/// <param name="minLength">The minimum length of each word. Default is 1.</param>
	/// <param name="maxLength">The maximum length of each word. Default is 1.</param>
	/// <returns>A <see cref="ReadOnlyCollection{String}"/> containing the generated words.</returns>
	/// <remarks>
	/// This method utilizes <see cref="GenerateWord(int, int)"/> to generate each word in the collection.
	/// </remarks>
	/// <example>
	/// Output:
	/// [0]: "oKcMYETNvpiByRQVa^"
	/// [1]: "mnM\\wQwuluQ^VFxpOJEgLX"
	/// [2]: "Ad\\kCOMkmdK"
	/// </example>
	[Information(nameof(GenerateWords), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> GenerateWords(int count = 1, int minLength = 1, int maxLength = 1)
	{
		count = count.ArgumentInRange(lower: 1, defaultValue: 1);
		minLength = minLength.ArgumentInRange(lower: 1, defaultValue: 1);
		maxLength = maxLength.ArgumentInRange(lower: 1, defaultValue: 1);

		var strings = new List<string>(count);

		for (var wordCount = 0; wordCount < count; wordCount++)
		{
			strings.Add(GenerateWord(minLength, maxLength));
		}

		return strings.AsReadOnly();
	}

	/// <summary>
	/// Provides an extensive string for testing purposes, with a length of 969 characters, including spaces.
	/// </summary>
	/// <value>
	/// The long test string loaded from <see cref="Resources.LongTestString"/>.
	/// </value>
	[Information(nameof(GenerateWords), "David McCarter", "1/19/2019", Status = Status.Available)]
	public static string LongTestString => Resources.LongTestString;

}
