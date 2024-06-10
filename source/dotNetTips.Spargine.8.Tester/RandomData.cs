// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-19-2019
//
// Last Modified By : David McCarter
// Last Modified On : 06-07-2024
// ***********************************************************************
// <copyright file="RandomData.cs" company="dotNetTips.Spargine.8.Tester">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Methods to randomly generate data for unit and benchmark testing.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public static partial class RandomData
{

	/// <summary>
	/// The address number count
	/// </summary>
	private const int AddressNumberCount = 5;

	/// <summary>
	/// The default file extension
	/// </summary>
	private const string DefaultFileExtension = "dotnettips.temp";

	/// <summary>
	/// The default file length
	/// </summary>
	private const int DefaultFileLength = 1024;

	/// <summary>
	/// The maximum file byte length
	/// </summary>
	private const int FileByteLengthChunk = 1024;

	/// <summary>
	/// The default maximum character for creating words.
	/// </summary>
	public const char DefaultMaxCharacter = 'z';

	/// <summary>
	/// The default maximum character random file name.
	/// </summary>
	public const char DefaultMaxCharacterRandomFile = 'Z';

	/// <summary>
	/// The default minimum character for creating words.
	/// </summary>
	public const char DefaultMinCharacter = 'a';

	/// <summary>
	/// The default minimum character random file name.
	/// </summary>
	public const char DefaultMinCharacterRandomFile = 'A';

	/// <summary>
	/// The countries
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<Country>> _countries = new(Countries.GetCountries());

	/// <summary>
	/// The domain extensions used to create random Urls.
	/// </summary>
	private static readonly Lazy<string[]> _domainExtensions = new(Resources.DomainExtentions.Split(Core.ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries));

	/// <summary>
	/// The first names
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<string>> _firstNames = new(Resources.FirstNames.Split(Core.ControlChars.Comma, StringSplitOptions.TrimEntries).ToReadOnlyCollection());

	/// <summary>
	/// The last names
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<string>> _lastNames = new(Resources.LastNames.Split(Core.ControlChars.Comma, StringSplitOptions.TrimEntries).ToReadOnlyCollection());

	/// <summary>
	/// The postal formats cache
	/// </summary>
	private static readonly Dictionary<Country, string[]> _postalFormatsCache = [];

	/// <summary>
	/// The random number generator
	/// </summary>
	[ThreadStatic]
	private static readonly RandomNumberGenerator _randomNumberGenerator;

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// The synchronize lock
	/// </summary>
	private static readonly object Lock = new();

	/// <summary>
	/// Initializes static members of the <see cref="RandomData" /> class.
	/// </summary>
	static RandomData() => _randomNumberGenerator = RandomNumberGenerator.Create();

	/// <summary>
	/// Chunks the number.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="chunkSize">Size of the chunk.</param>
	/// <returns>IEnumerable&lt;System.Int32&gt;.</returns>
	private static IEnumerable<int> ChunkNumber(this int input, int chunkSize)
	{
		for (var chunkIndex = 0; chunkIndex < input; chunkIndex += chunkSize)
		{
			yield return Math.Min(chunkSize, input - chunkIndex);
		}
	}

	/// <summary>
	/// Generates the address line one.
	/// </summary>
	/// <param name="addressLength">Length of the address.</param>
	/// <returns>System.String.</returns>
	private static string GenerateAddressLineOne(int addressLength) => $"{GenerateNumber(AddressNumberCount)} {GenerateWord(addressLength - AddressNumberCount - 1)}";

	/// <summary>
	/// Generates the address line two.
	/// </summary>
	/// <param name="addressLength">Length of the address.</param>
	/// <returns>System.String.</returns>
	private static string GenerateAddressLineTwo(int addressLength) => $"{GenerateWord(addressLength - AddressNumberCount - 1)} {GenerateNumber(AddressNumberCount)}";

	/// <summary>
	/// Generates the email address with names.
	/// </summary>
	/// <param name="firstName">The first name.</param>
	/// <param name="lastName">The last name.</param>
	/// <returns>System.String.</returns>
	private static string GenerateEmailAddressWithName(string firstName, string lastName) => $"{firstName.DefaultIfNullOrEmpty("FIRSTNAME")}.{lastName.DefaultIfNullOrEmpty("LASTNAME")}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";

	/// <summary>
	/// Generates the postal code.
	/// </summary>
	/// <param name="country">The countryName.</param>
	/// <param name="city">The city.</param>
	/// <returns>System.String.</returns>
	private static string GeneratePostalCode([NotNull] Country country, [AllowNull] City city)
	{
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
	/// Picks a random string from an array.
	/// </summary>
	/// <param name="words">The words.</param>
	/// <returns>System.String.</returns>
	private static string Of(params string[] words) => words[GenerateInteger(0, words.Length - 1)];

	/// <summary>
	/// Creates a file.
	/// </summary>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="fileLength">Length of the file.</param>
	internal static void CreateFile(string fileName, int fileLength = DefaultFileLength)
	{
		var chars = new ReadOnlySpan<char>(GenerateWord(fileLength).ToCharArray());

		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}

		var sliceStart = 0;

		using (var stream = File.AppendText(fileName))
		{
			foreach (var size in fileLength.ChunkNumber(FileByteLengthChunk))
			{
				stream.Write(chars.Slice(sliceStart, size));
				sliceStart += size;
			}

			stream.Flush();
		}
	}

	/// <summary>
	/// Generate a collection of Address types that implement the <see cref="IAddress" /> interface.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="country">The countryName.</param>
	/// <param name="count">The address count. Count must be 0 or higher. Defaults to 2.</param>
	/// <param name="addressLength">Length of the address. Length must be between 5 - 100. Defaults to 25.</param>
	/// <param name="countyProvinceLength">Length of the county province. Length must be between 5 - 50. Defaults to 20.</param>
	/// <returns>System.Collections.ObjectModel.Collection&lt;T&gt;.</returns>
	[Information(nameof(GenerateAddressCollection), "David McCarter", "12/4/2023", UnitTestCoverage = 100, Status = Status.CheckPerformance, Documentation = "ADD URL")]
	public static Collection<T> GenerateAddressCollection<T>([NotNull] Country country, int count = 2, int addressLength = 25, int countyProvinceLength = 20) where T : IAddress, new()
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
	[Information(nameof(GenerateAddressRecordCollection), "David McCarter", "3/14/2023", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "ADD URL")]
	public static Collection<AddressRecord> GenerateAddressRecordCollection([NotNull] CountryName country, int count = 2, int addressLength = 25, int countyProvinceLength = 20)
	{
		count = count.ArgumentInRange(lower: 0, defaultValue: 2);
		addressLength = addressLength.ArgumentInRange(lower: 5, upper: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(lower: 5, upper: 50);

		var addresses = new List<AddressRecord>(count);

		//Span is slower.
		var addressCollection = GenerateAddressCollection<Address>(Countries.GetCountry(country).ArgumentNotNull(paramName: country.GetDescription()), count, addressLength, countyProvinceLength);

		foreach (var address in addressCollection)
		{
			addresses.Add(AddressRecord.ToAddress(address));
		}

		return addresses.ToCollection();
	}

	/// <summary>
	/// Generates a random <see cref="byte" /> array.
	/// </summary>
	/// <param name="sizeInKb">The size in kb.</param>
	/// <returns>byte[].</returns>
	[Information(nameof(GenerateByteArray), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
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
	/// Generates a random <see cref="char" />.
	/// </summary>
	/// <returns>System.Char.</returns>
	/// <example>Output: 82 'R'</example>
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static char GenerateCharacter() => GenerateCharacter(DefaultMinCharacter, DefaultMaxCharacter);

	/// <summary>
	/// Creates a random <see cref="char" />.
	/// </summary>
	/// <param name="minValue">The minimum character value.</param>
	/// <param name="maxValue">The maximum character value.</param>
	/// <returns>System.Char.</returns>
	/// <example>Output: 65 'A'</example>
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static char GenerateCharacter(char minValue, char maxValue) => (char)GenerateInteger(minValue, maxValue);

	/// <summary>
	/// Create a Coordinate object that implements the  <see cref="ICoordinate" /> interface with random values.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <returns>T.</returns>
	/// <example>Output: X: 178765551 Y: -2145952440</example>
	[Information(nameof(GenerateCoordinate), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static T GenerateCoordinate<T>() where T : ICoordinate, new() => new() { X = GenerateInteger(), Y = GenerateInteger(), Z = GenerateInteger() };

	/// <summary>
	/// Create a collection of objects that implement the <see cref="ICoordinate" /> interface.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="count">The number of items to create. Minimum value is 1.</param>
	/// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
	/// <example>Output: [0]: {2089369587--284215139} [1]: {244137335-1577361939}</example>
	[Information(nameof(GenerateCoordinateCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
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
	/// Generates a random credit card number based on a random credit card formats .
	/// </summary>
	/// <returns>System.String.</returns>
	[Information(nameof(GenerateCreditCard), "David McCarter", "3/13/2023", UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static string GenerateCreditCard() => RandomCreditCardNumberGenerator.GetCreditCardNumber();

	/// <summary>
	/// Generates a collection of random credit card numbers.
	/// Default to a count of 100.
	/// </summary>
	/// <param name="count">The count.</param>
	/// <returns>ReadOnlyCollection&lt;System.String&gt;.</returns>
	[Information(nameof(GenerateCreditCard), "David McCarter", "3/13/2023", UnitTestCoverage = 0, Status = Status.Available)]
	public static ReadOnlyCollection<string> GenerateCreditCards(int count = 100)
	{
		count = count.ArgumentInRange(1, defaultValue: 1);

		return RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);
	}

	/// <summary>
	/// Generates a random <see cref="decimal" /> value.
	/// </summary>
	/// <param name="minValue">The minimum value.</param>
	/// <param name="maxValue">The maximum value.</param>
	/// <param name="decimalPlaces">The decimal places. Minimum value = 0.</param>
	/// <returns>System.Decimal.</returns>
	/// <example>Output: 95.15</example>
	[Information(nameof(GenerateDecimal), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static decimal GenerateDecimal(decimal minValue, decimal maxValue, int decimalPlaces)
	{
		decimalPlaces = decimalPlaces.ArgumentInRange(lower: 0, defaultValue: 0);

		var multiplier = ((decimal)decimalPlaces) * 10;

		return GenerateInteger((int)(minValue * multiplier), (int)(maxValue * multiplier)) / multiplier;
	}

	/// <summary>
	/// Generates a random domain extension.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: creditunion</example>
	[Information(nameof(GenerateDomainExtension), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateDomainExtension() => Of(_domainExtensions.Value);

	/// <summary>
	/// Create a random email address with a random domain.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: fbxpfvtanqysqmuqfh@kiuvf.fr</example>
	[Information(nameof(GenerateEmailAddress), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateEmailAddress() => $"{GenerateWord(5, 25, 'a', 'z')}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";

	/// <summary>
	/// Generate a random file with a default length of 1,024 and save it to the user's AppData\Roaming folder.
	/// </summary>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="fileLength">Byte length of the file. Minimum length = 1</param>
	/// <returns>Name of the file generated.</returns>
	/// <example>Output: C:\\Users\\user folder\\AppData\\Roaming\\UnitTest.test</example>
	[Information(nameof(GenerateFile), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateFile(string fileName, int fileLength = DefaultFileLength)
	{
		fileName = fileName.ArgumentNotNullOrEmpty(trim: true);
		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: 1);

		CreateFile(fileName, fileLength);

		return fileName;
	}

	/// <summary>
	/// Generate random files with a default length of 1,024 and save them to the user's AppData\Roaming folder.
	/// </summary>
	/// <param name="count">The number of files to create. Minimum value = 1.</param>
	/// <param name="fileLength">Length of the file. Minimum value = 1.</param>
	/// <param name="fileExtension">The file extension.</param>
	/// <returns>System.ValueTuple&lt;System.String, ReadOnlyCollection&lt;System.String&gt;&gt;.</returns>
	[Information(nameof(GenerateFiles), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static (string Path, ReadOnlyCollection<string> Files) GenerateFiles(int count = 100, int fileLength = DefaultFileLength, string fileExtension = DefaultFileExtension)
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
	/// Generates random files.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <param name="count">The number of files to create. Minimum value = 1.</param>
	/// <param name="fileLength">Length of the file. Minimum value = 1.</param>
	/// <returns>ReadOnlyCollection&lt;System.String&gt;.</returns>
	/// <example>Output: [0]: "c:\\temp\\dobybcyx.lj"  [1]: "c:\\temp\\zo2ggwub.3ro"</example>
	[Information(nameof(GenerateFiles), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
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
	/// Randomly generate a male or female first name.
	/// </summary>
	/// <returns>System.String.</returns>
	[Information(nameof(GenerateFirstName), "David McCarter", "3/11/2023", UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static string GenerateFirstName() => _firstNames.Value.PickRandom();

	/// <summary>
	/// Creates a random <see cref="int" /> value.
	/// </summary>
	/// <param name="min">The minimum int.</param>
	/// <param name="max">The maximum int.</param>
	/// <returns>System.Int32.</returns>
	/// <remarks>Does not use _randomNumberGenerator due to performance increase. [CA5394]</remarks>
	[Information(nameof(GenerateInteger), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
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
	/// Create a random key using a GUID and remove any dashes.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: f7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateKey), "David McCarter", "1/19/2019", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateKey() => KeyGenerator.GenerateKey();

	/// <summary>
	/// Randomly generate a person's last name.
	/// </summary>
	/// <returns>System.String.</returns>
	[Information(nameof(GenerateLastName), "David McCarter", "3/11/2023", UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static string GenerateLastName() => _lastNames.Value.PickRandom();

	/// <summary>
	/// Creates a random number as a <see cref="string" />.
	/// </summary>
	/// <param name="length">The length of the number. Minimum value = 1.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: "446085072052112"</example>
	/// <remarks>Does not use _randomNumberGenerator due to performance increase. [CA5394]</remarks>
	[Information(nameof(GenerateNumber), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
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
	/// Generates random male and female names, and provides outputs for FirstName, LastName, and FullName.
	/// </summary>
	/// <param name="count">The count. Minimnum value is 1.</param>
	/// <returns>System.Collections.ObjectModel.ReadOnlyCollection&lt;string&gt;.</returns>
	[Information(nameof(GeneratePersonNames), "David McCarter", "12/15/2023", UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
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
	/// Generates a <see cref="PersonRecord" /> with random values.
	/// </summary>
	/// <param name="addressCount">The address count. Count must be 0 - 100. Defaults to 2.</param>
	/// <param name="addressLength">Length of the address. Length must be between 5 - 100. Defaults to 25.</param>
	/// <param name="countyProvinceLength">Length of the county province. Length must be between 5 - 50. Defaults to 20.</param>
	/// <returns>PersonRecord.</returns>
	public static PersonRecord GeneratePersonRecord(int addressCount = 2, int addressLength = 25, int countyProvinceLength = 20)
	{
		addressCount = addressCount.ArgumentInRange(lower: 0, upper: 100, defaultValue: 2);

		var personData = GeneratePersonRef<Address>(addressCount, addressLength, countyProvinceLength);

		var person = PersonRecord.ToPersonRecord(personData);
		return person;
	}

	/// <summary>
	/// Generates a <see cref="PersonRecord" /> collection.
	/// </summary>
	/// <param name="count">The number of items to create. Minimum value = 1.</param>
	/// <returns>ReadOnlyCollection&lt;PersonRecord&gt;.</returns>
	[Information(nameof(GeneratePersonRecordCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
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
	/// Generates a Person reference type that implements <see cref="IAddress" /> with default values.
	/// </summary>
	/// <typeparam name="TAddress">The type of the t address.</typeparam>
	/// <param name="addressCount">The address count. Count must be 0 or higher. Defaults to 2.</param>
	/// <param name="addressLength">Length of the address. Length must be between 5 - 100. Defaults to 25.</param>
	/// <param name="countyProvinceLength">Length of the county province. Length must be between 5 - 50. Defaults to 20.</param>
	/// <returns>T.</returns>
	[Information(nameof(GeneratePersonRef), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
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
	/// Generates a <see cref="Models.RefTypes.Person{TAddress}" /> reference collection that implements <see cref="IAddress" />.
	/// </summary>
	/// <typeparam name="TAddress">The type of the t address.</typeparam>
	/// <param name="count">The number of items to create. Minimum value = 1.</param>
	/// <returns>System.Collections.ObjectModel.ReadOnlyCollection&lt;T&gt;.</returns>
	[Information(nameof(GeneratePersonRefCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
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
	/// Generates a <see cref="Models.ValueTypes.Person{TAddress}" /> value type that implements <see cref="IAddress" /> with random values.
	/// </summary>
	/// <typeparam name="TAddress">The type of the t address.</typeparam>
	/// <param name="addressCount">The address count. Count must be 0 or higher. Defaults to 2.</param>
	/// <param name="addressLength">Length of the address. Length must be between 5 - 100. Defaults to 25.</param>
	/// <param name="countyProvinceLength">Length of the county province. Length must be between 5 - 50. Defaults to 20.</param>
	/// <returns>T.</returns>
	[Information(nameof(GeneratePersonVal), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
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
	/// Generates a <see cref="Models.ValueTypes.Person{TAddress}" /> value collection that implements <see cref="IAddress" />.
	/// </summary>
	/// <typeparam name="TAddress">The type of the t address.</typeparam>
	/// <param name="count">The count.</param>
	/// <returns>System.Collections.ObjectModel.ReadOnlyCollection&lt;T&gt;.</returns>
	[Information(nameof(GeneratePersonValCollection), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
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
	/// Creates a phone number based on a specified <see cref="Country" />, with the option to include the country code.
	/// </summary>
	/// <param name="country">The countryName.</param>
	/// <param name="includeCountryCode">The include countryName code.</param>
	/// <returns>System.String.</returns>
	/// <example>Output for Taiwan: 886-352346002</example>
	[Information(nameof(GeneratePhoneNumber), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GeneratePhoneNumber([NotNull] Country country, bool includeCountryCode = false)
	{
		country = country.ArgumentNotNull();

		return includeCountryCode ? $"{country.PhoneCode}-{GenerateNumber(country.PhoneNumberLength)}" : GenerateNumber(country.PhoneNumberLength);
	}

	/// <summary>
	/// Creates a phone number based on a specified <see cref="CountryName" />, with the option to include the country code.
	/// </summary>
	/// <param name="countryName">Name of the country.</param>
	/// <param name="includeCountryCode">The include country code.</param>
	/// <returns>string.</returns>
	/// <example>Output for Taiwan: 886-352346002</example>
	[Information(nameof(GeneratePhoneNumber), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GeneratePhoneNumber([NotNull] CountryName countryName, bool includeCountryCode = false)
	{
		countryName = countryName.ArgumentDefined();

		//Lookup Country
		var country = Countries.GetCountry(countryName);

		return includeCountryCode ? $"{country.PhoneCode}-{GenerateNumber(country.PhoneNumberLength)}" : GenerateNumber(country.PhoneNumberLength);
	}

	/// <summary>
	/// Generates a random file name in the temporary folder.
	/// </summary>
	/// <param name="fileNameLength">Length of the file name. Minimum value = 1. Maximim value = 256.</param>
	/// <param name="extension">The extension.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: C:\\Users\\user folder Ex\\AppData\\Local\\Temp\\MSPRINYRBU.dotnettips.temp</example>
	[Information(nameof(GenerateRandomFileName), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateRandomFileName(int fileNameLength = 10, string extension = DefaultFileExtension)
	{
		fileNameLength = fileNameLength.ArgumentInRange(1, upper: 256);
		extension = extension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var fileName = $"{GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile)}{Core.ControlChars.Dot}{extension}";

		return Path.Combine(Path.GetTempPath(), fileName);
	}

	/// <summary>
	/// Generates a random file name.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <param name="fileNameLength">Length of the file name. Minimum value = 1. Maximum value = 256.</param>
	/// <param name="extension">The extension.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: c:\\temp\\FFDHRBMDXP.dotnettips</example>
	[Information(nameof(GenerateRandomFileName), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateRandomFileName([NotNull] string path, int fileNameLength = 10, string extension = DefaultFileExtension)
	{
		fileNameLength = fileNameLength.ArgumentInRange(1, upper: 256);
		extension = extension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var fileName = $"{GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile)}{Core.ControlChars.Dot}{extension}";

		return Path.Combine(path, fileName);
	}

	/// <summary>
	/// Generates location data randomly selecting a <see cref="Country" />, <see cref="State" /> and <see cref="City" />.
	/// </summary>
	/// <returns>(DotNetTips.Spargine.Tester.Data.Country countryName, DotNetTips.Spargine.Tester.Data.State state, DotNetTips.Spargine.Tester.Data.City city).</returns>
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
	/// Generates random person data, including values for date of birth, cell phone number, <see cref="Country" />, email address, first name, last name, and phone number.
	/// </summary>
	/// <returns>DotNetTips.Spargine.Tester.PersonData.</returns>
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
	/// Generates random first and last names for a person.
	/// </summary>
	/// <returns>(string firstName, string lastName).</returns>
	public static (string firstName, string lastName) GenerateRandomPersonName() => (GenerateFirstName(), GenerateLastName());

	/// <summary>
	/// Creates a random relative URL.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output:"/ljsylu/rsglcurkiylqld/wejdbuainlgjofnv/uwbrjftyt/"</example>
	[Information(nameof(GenerateRelativeUrl), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
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
	/// Generates a random file in the user's local temporary folder.
	/// </summary>
	/// <param name="fileLength">The length. Minimum value = 1.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: C:\\Users\\user folder\\AppData\\Local\\Temp\\OFQCKBRAKQ.dotnettips.temp</example>
	[Information(nameof(GenerateTempFile), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateTempFile(int fileLength = DefaultFileLength)
	{
		fileLength = fileLength.ArgumentInRange(lower: 1, defaultValue: DefaultFileLength);

		var fileName = GenerateRandomFileName();
		var fakeText = GenerateWord(fileLength);

		File.WriteAllText(fileName, fakeText);

		return fileName;
	}

	/// <summary>
	/// Creates a completely random URL.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: https://www.rp.red/wyfkxbfft/pqypmdstoydnootvdvnsqkn/</example>
	[Information(nameof(GenerateUrl), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateUrl() => $"{GenerateUrlHostName()}{GenerateRelativeUrl()}";

	/// <summary>
	/// Generate a random URL fragment.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: /rregyyjxpjiats</example>
	[Information(nameof(GenerateUrlFragment), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateUrlFragment() => $"/{GenerateWord(1, 25, 'a', 'z')}";

	/// <summary>
	/// Generates a random URL host name.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: https://www.ukrsusbrtjijfktfj.shouji</example>
	[Information(nameof(GenerateUrlHostName), "David McCarter", "1/19/2019", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GenerateUrlHostName() => $"https://{GenerateUrlHostNameNoProtocol()}";

	/// <summary>
	/// Creates a URL without a subdomain.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: www.txtkixvsxgryixbwrtje.shangrila</example>
	[Information(nameof(GenerateUrlHostNameNoProtocol), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateUrlHostNameNoProtocol() => $"www.{GenerateWord(1, 25, 'a', 'z')}.{GenerateUrlHostNameNoSubDomain()}";

	/// <summary>
	/// Creates a hostname without a subdomain.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example>Output: dz</example>
	[Information(nameof(GenerateUrlHostNameNoSubDomain), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateUrlHostNameNoSubDomain() => GenerateDomainExtension();

	/// <summary>
	/// Creates a random word.
	/// </summary>
	/// <param name="length">The length. Minimum value = 1.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: mL_g[E_E_CsoJvjshI]CFjFKa</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateWord(int length = 1)
	{
		length = length.ArgumentInRange(lower: 1, defaultValue: 1);

		var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);

		return returnValue;
	}

	/// <summary>
	/// Generates a random word within a specified minimum and maximum length.
	/// </summary>
	/// <param name="minLength">The minimum length. Minimum value = 1.</param>
	/// <param name="maxLength">The maximum length. Minimum value = 1.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: anvpwufadtxpfysguavguwm</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateWord(int minLength = 1, int maxLength = 1)
	{
		minLength = minLength.ArgumentInRange(lower: 1, defaultValue: 1);
		maxLength = maxLength.ArgumentInRange(lower: 1, defaultValue: 1);

		return GenerateWord(minLength, maxLength, DefaultMinCharacter, DefaultMaxCharacter);
	}

	/// <summary>
	/// Creates a random word using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// </summary>
	/// <param name="length">The length. Minimum value = 1.</param>
	/// <param name="minCharacter">The minimum character.  Defaults to 'a'.</param>
	/// <param name="maxCharacter">The maximum character.  Defaults to 'Z'.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: LBEEUMHHHK</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
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
	/// Creates a random word.
	/// </summary>
	/// <param name="minLength">The minimum length.</param>
	/// <param name="maxLength">The maximum length.</param>
	/// <param name="minCharacter">The minimum character. Defaults to 'a'.</param>
	/// <param name="maxCharacter">The maximum character. Defaults to 'Z'.</param>
	/// <returns>System.String.</returns>
	/// <example>Output: ACRNFTPAE</example>
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GenerateWord(int minLength = 1, int maxLength = 1, char minCharacter = 'a', char maxCharacter = 'Z')
	{
		minLength = minLength.ArgumentInRange(1, defaultValue: 1);
		maxLength = maxLength.ArgumentInRange(1, defaultValue: 1);

		return GenerateWord(GenerateInteger(minLength, maxLength), minCharacter, maxCharacter);
	}

	/// <summary>
	/// Generates a set of words with lengths falling within a specified minimum and maximum range.
	/// </summary>
	/// <param name="count">The word count. Minimum value = 1.</param>
	/// <param name="minLength">The minimum length. Minimum value = 1.</param>
	/// <param name="maxLength">The maximum length. Minimum value = 1.</param>
	/// <returns>ReadOnlyCollection&lt;System.String&gt;.</returns>
	/// <example>
	/// Output:
	/// [0]: "oKcMYETNvpiByRQVa^"
	/// [1]: "mnM\\wQwuluQ^VFxpOJEgLX"
	/// [2]: "Ad\\kCOMkmdK"
	/// </example>
	[Information(nameof(GenerateWords), "David McCarter", "1/19/2019", UnitTestCoverage = 100, Status = Status.Available)]
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
	/// <value>The long test string.</value>
	[Information(nameof(GenerateWords), "David McCarter", "1/19/2019", Status = Status.Available)]
	public static string LongTestString => Resources.LongTestString;

}
