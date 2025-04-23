// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-05-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2025
// ***********************************************************************
// <copyright file="RandomDataTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Data;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class RandomDataTests
{
	/// <summary>
	/// The address count
	/// </summary>
	private const int AddressCount = 2;

	/// <summary>
	/// The count
	/// </summary>
	private const int Count = 256;

	/// <summary>
	/// The file extension
	/// </summary>
	private const string FileExtension = "dotnettips.com";

	/// <summary>
	/// The file length
	/// </summary>
	private const int FileLength = 1500;

	/// <summary>
	/// Deletes the files.
	/// </summary>
	/// <param name="files">The files.</param>
	private void DeleteFiles(IEnumerable<string> files)
	{
		if (files.DoesNotHaveItems())
		{
			return;
		}

		_ = Parallel.ForEach(
			source: files,
			body: (fileName) =>
			{
				try
				{
					File.Delete(fileName);
				}
				catch (Exception ex) when (ex is ArgumentException ||
					ex is ArgumentNullException ||
					ex is System.IO.DirectoryNotFoundException ||
					ex is IOException ||
					ex is NotSupportedException ||
					ex is PathTooLongException ||
					ex is UnauthorizedAccessException)
				{
					Trace.WriteLine(ex.GetAllMessages());
				}
			});
	}

	/// <summary>
	/// Defines the test method AddToPersonCollectionTest.
	/// </summary>
	[TestMethod]
	public void AddToPersonCollectionTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(Count);

			var newPeople = new List<Models.RefTypes.Person<Models.RefTypes.Address>>();

			for (var personCount = 0; personCount < people.FastCount(); personCount++)
			{
				_ = newPeople.AddIfNotExists(people[personCount]);
			}

			Assert.IsTrue(newPeople.FastCount() == Count);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ClonePersonProperTest()
	{
		var person = RandomData.GeneratePersonRef<Models.RefTypes.Address>();

		try
		{
			var personClone = person.Clone<Models.RefTypes.Person<Models.RefTypes.Address>>();

			Assert.IsNotNull(personClone);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ConvertPersonValToRefTest()
	{
		var personVal = RandomData.GeneratePersonVal<Models.ValueTypes.Address>();

		var personRef = Models.RefTypes.Person<Models.RefTypes.Address>.ToPerson(personVal);

		Assert.IsNotNull(personRef);
	}

	[TestMethod]
	public void Deserialize_JsonSerilizerContext_Person_Collection_Test()
	{
		var json = RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(Count).ToJson();

		var result = JsonSerializer.Deserialize(json, PersonJsonSerializerContext.Default.PersonList);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == Count);
	}

	[TestMethod]
	public void Deserialize_JsonSerilizerContext_PersonProper_Ref_Test()
	{
		var json = RandomData.GeneratePersonRef<Models.RefTypes.Address>().ToJson();

		var normalResult = JsonSerializer.Deserialize<Models.RefTypes.Person<Models.RefTypes.Address>>(json);

		Assert.IsNotNull(normalResult);

		var result = JsonSerializer.Deserialize(json, PersonJsonSerializerContext.Default.Person);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void Deserialize_JsonSerilizerContext_PersonRecord_Collection_Test()
	{
		var json = RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(Count).ToJson();

		var result = JsonSerializer.Deserialize(json, PersonJsonSerializerContext.Default.PersonRecordList);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == Count);
	}

	[TestMethod]
	public void Deserialize_JsonSerilizerContext_PersonVal_Collection_Test()
	{
		var json = RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(Count).ToJson();

		var result = JsonSerializer.Deserialize(json, PersonJsonValSerializerContext.Default.PersonList);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == Count);
	}

	[TestMethod]
	public void GenerateAddressCollection_DefaultParameters_ReturnsAddresses()
	{
		// Arrange
		var country = RandomData.GenerateRandomLocationData().country;

		// Act
		var result = RandomData.GenerateAddressCollection<Models.RefTypes.Address>(country);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == 2);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GenerateAddressCollection_InvalidCountry_ThrowsException()
	{
		// Act
		RandomData.GenerateAddressCollection<Models.RefTypes.Address>(null);
	}

	[TestMethod]
	public void GenerateAddressCollection_SpecifiedParameters_ReturnsAddresses()
	{
		// Arrange
		var country = RandomData.GenerateRandomLocationData().country;
		int count = 5;
		int addressLength = 50;
		int countyProvinceLength = 30;

		// Act
		var result = RandomData.GenerateAddressCollection<Models.RefTypes.Address>(country, count, addressLength, countyProvinceLength);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == count);
	}

	[TestMethod]
	public void GenerateAddressCollectionTest()
	{
		var addresses = RandomData.GenerateAddressCollection<Models.ValueTypes.Address>(
			RandomData.GenerateRandomLocationData().country,
			AddressCount,
			100,
			50);

		Assert.IsNotNull(addresses);

		Assert.IsTrue(addresses.FastCount() == AddressCount);
	}

	[TestMethod]
	public void GenerateAddressRecordCollectionTest()
	{
		var country = RandomData.GenerateRandomLocationData().country;

		var countryName = Enum.TryParse<CountryName>(country.Name, out var countryNameResult)
			? countryNameResult
			: CountryName.UnitedStates;

		var addresses = RandomData.GenerateAddressRecordCollection(countryName, AddressCount, 100, 50);

		Assert.IsNotNull(addresses);

		Assert.IsTrue(addresses.FastCount() == AddressCount);
	}

	[TestMethod]
	public void GenerateByteArrayTest()
	{
		var byteArray = RandomData.GenerateByteArray(1);

		Assert.IsTrue(byteArray.Length > 0);

		Assert.IsTrue(byteArray.First() > 0);
	}

	[TestMethod]
	public void GenerateCharacterTest()
	{
		var character = RandomData.GenerateCharacter();

		Assert.IsNotNull(character);
	}

	[TestMethod]
	public void GenerateCharacterTestWithMinMaxCharTest()
	{
		var character = RandomData.GenerateCharacter('A', 'C');

		Assert.IsNotNull(character);
	}

	[TestMethod]
	public void GenerateCoordinateCollectionTest()
	{
		var coordinates = RandomData.GenerateCoordinateCollection<Models.ValueTypes.Coordinate>(Count);

		Assert.IsNotNull(coordinates);

		Assert.IsTrue(coordinates.FastCount() == Count);
	}

	[TestMethod]
	public void GenerateCoordinateTest()
	{
		var coordinate = RandomData.GenerateCoordinate<Models.ValueTypes.Coordinate>();

		Assert.IsNotNull(coordinate);

		Assert.IsNotNull(coordinate.ToString());
	}

	[TestMethod]
	public void GenerateCreditCardsTest()
	{
		var result = RandomData.GenerateCreditCards(100);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == 100);
	}

	[TestMethod]
	public void GenerateCreditCardTest()
	{
		var result = RandomData.GenerateCreditCard();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GenerateDecimalTest()
	{
		var decimalValue = RandomData.GenerateDecimal(0, 100, 2);

		Assert.IsTrue(decimalValue >= 0);
		Assert.IsTrue(decimalValue <= 100);
	}

	[TestMethod]
	public void GenerateDomainExtensionTest()
	{
		var stringValue = RandomData.GenerateDomainExtension();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateEmailAddressTest()
	{
		var stringValue = RandomData.GenerateEmailAddress();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateFiles_DefaultParameters_ReturnsFiles()
	{
		// Act
		var result = RandomData.GenerateFiles();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotNull(result.Path);
		Assert.IsTrue(result.Files.Count == 1);

		// Clean up
		this.DeleteFiles(result.Files);
	}

	[TestMethod]
	public void GenerateFiles_SpecifiedParameters_ReturnsFiles()
	{
		// Arrange
		int count = 5;
		int fileLength = 1024;
		string fileExtension = "test";

		// Act
		var result = RandomData.GenerateFiles(count, fileLength, fileExtension);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotNull(result.Path);
		Assert.IsTrue(result.Files.Count == count);

		// Clean up
		this.DeleteFiles(result.Files);
	}

	[TestMethod]
	public void GenerateFiles_WithPath_ReturnsFiles()
	{
		// Arrange
		string path = Path.GetTempPath();
		int count = 5;
		int fileLength = 1024;

		// Act
		var result = RandomData.GenerateFiles(path, count, fileLength);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == count);

		// Clean up
		this.DeleteFiles(result);
	}

	[TestMethod]
	public void GenerateFilesTest()
	{
		var files = RandomData.GenerateFiles(Count, FileLength);

		Assert.IsNotNull(files);

		Assert.IsNotNull(files.Path);

		Assert.IsTrue(files.Files.FastCount() == Count);

		this.DeleteFiles(files.Files);
	}

	[TestMethod]
	public void GenerateFilesWithExtTest()
	{
		var files = RandomData.GenerateFiles(count: Count, fileLength: FileLength, fileExtension: "test");

		Assert.IsNotNull(files);

		Assert.IsNotNull(files.Path);

		Assert.IsTrue(files.Files.FastCount() == Count);

		this.DeleteFiles(files.Files);
	}


	[TestMethod]
	public void GenerateFilesWithPathTest()
	{
		var files = RandomData.GenerateFiles(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData,
				Environment.SpecialFolderOption.DoNotVerify),
			Count,
			FileLength);

		Assert.IsNotNull(files);

		Assert.IsTrue(files.FastCount() == Count);

		this.DeleteFiles(files);
	}

	[TestMethod]
	public void GenerateFileTest()
	{
		var fileName = RandomData.GenerateFile(RandomData.GenerateRandomFileName(), fileLength: FileLength);

		Assert.IsNotNull(fileName);

		var testFile = new FileInfo(fileName);

		Assert.IsTrue(testFile.Exists);

		Assert.IsTrue(FileLength == testFile.Length);

		testFile.Delete();
	}

	[TestMethod]
	public void GenerateGenerateUrlHostNameTest()
	{
		var stringValue = RandomData.GenerateUrlHostName();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateIntegerTest()
	{
		var intValue = RandomData.GenerateInteger(0, 1000);

		Assert.IsTrue(intValue >= 0);
		Assert.IsTrue(intValue <= 1000);
	}

	[TestMethod]
	public void GenerateKeyTest()
	{
		var stringValue = RandomData.GenerateKey();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateNamesTest()
	{
		for (var count = 0; count < Count; count++)
		{
			Debug.WriteLine($"{RandomData.GenerateFirstName()} {RandomData.GenerateLastName()}");
		}
	}

	[TestMethod]
	public void GenerateNumberTest()
	{
		var stringValue = RandomData.GenerateNumber(15);

		Assert.IsNotNull(stringValue);

		Assert.IsTrue(stringValue.Length == 15);
	}

	[TestMethod]
	public void GeneratePersonNames_DefaultParameters_ReturnsPersonNames()
	{
		// Act
		var result = RandomData.GeneratePersonNames();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == 1);
	}

	[TestMethod]
	public void GeneratePersonNames_SpecifiedParameters_ReturnsPersonNames()
	{
		// Arrange
		int count = 5;

		// Act
		var result = RandomData.GeneratePersonNames(count);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == count);
	}

	[TestMethod]
	public void GeneratePersonNamesTest()
	{
		var personNames = RandomData.GeneratePersonNames(Count);

		Assert.IsNotNull(personNames);

		Assert.IsTrue(personNames.FastCount() == Count);
	}

	[TestMethod]
	public void GeneratePersonRecordCollectionTest()
	{
		var people = RandomData.GeneratePersonRecordCollection(AddressCount);

		Assert.IsNotNull(people);

		Assert.IsTrue(people.Count == AddressCount);

		JsonSerialization.SerializeToFile(
			people,
			new FileInfo(Path.Combine(App.ExecutingFolder(), "PeopleRecord.json")));
	}

	[TestMethod]
	public void GeneratePersonRecordTest()
	{
		var person = RandomData.GeneratePersonRecord(addressCount: AddressCount);

		Assert.IsNotNull(person);
		Assert.IsNotNull(person.Addresses);
		Assert.IsNotNull(person.AddressesSerilization);
		Assert.IsNotNull(person.BornOn);
		Assert.IsNotNull(person.CellPhone);
		Assert.IsNotNull(person.Email);
		Assert.IsNotNull(person.FirstName);
		Assert.IsNotNull(person.FullName);
		Assert.IsNotNull(person.Id);
		Assert.IsNotNull(person.LastName);
		Assert.IsNotNull(person.Phone);
		Assert.IsTrue(person.Addresses.Count == 2);

		Assert.IsTrue(person.Addresses.FastCount() == AddressCount);

		JsonSerialization.SerializeToFile(
			person,
			new FileInfo(Path.Combine(App.ExecutingFolder(), "PersonRecord.json")));
	}

	[TestMethod]
	public void GeneratePersonRefCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(Count);

		Assert.IsNotNull(people);

		Assert.IsTrue(people.FastCount() == Count);

		JsonSerialization.SerializeToFile(people, new FileInfo(Path.Combine(App.ExecutingFolder(), "PeopleRef.json")));
	}

	[TestMethod]
	public void GeneratePersonRefTest()
	{
		var person = RandomData.GeneratePersonRef<Models.RefTypes.Address>(addressCount: AddressCount);

		Assert.IsNotNull(person);
		Assert.IsNotNull(person.Addresses);
		Assert.IsNotNull(person.AddressesSerilization);
		Assert.IsNotNull(person.BornOn);
		Assert.IsNotNull(person.CellPhone);
		Assert.IsNotNull(person.Email);
		Assert.IsNotNull(person.FirstName);
		Assert.IsNotNull(person.FullName);
		Assert.IsNotNull(person.Id);
		Assert.IsNotNull(person.LastName);
		Assert.IsNotNull(person.Phone);
		Assert.IsTrue(person.Addresses.FastCount() == AddressCount);

		JsonSerialization.SerializeToFile(person, new FileInfo(Path.Combine(App.ExecutingFolder(), "PersonRef.json")));
	}

	[TestMethod]
	public void GeneratePersonValCollectionTest()
	{
		var people = RandomData.GeneratePersonValCollection<Models.ValueTypes.Address>(Count);

		Assert.IsTrue(people.FastCount() == Count);

		Assert.IsTrue(people.ToDictionary(item => item.Id).FastCount() == Count);

		JsonSerialization.SerializeToFile(people, new FileInfo(Path.Combine(App.ExecutingFolder(), "PeopleVal.json")));
	}

	[TestMethod]
	public void GeneratePersonValTest()
	{
		var person = RandomData.GeneratePersonVal<Models.ValueTypes.Address>(addressCount: AddressCount);

		Assert.IsNotNull(person);
		Assert.IsNotNull(person.Addresses);
		Assert.IsNotNull(person.AddressesSerilization);
		Assert.IsNotNull(person.BornOn);
		Assert.IsNotNull(person.CellPhone);
		Assert.IsNotNull(person.Email);
		Assert.IsNotNull(person.FirstName);
		Assert.IsNotNull(person.FullName);
		Assert.IsNotNull(person.Id);
		Assert.IsNotNull(person.LastName);
		Assert.IsNotNull(person.Phone);
		Assert.IsTrue(person.Addresses.Count == 5);

		Assert.IsTrue(person.Addresses.FastCount() == AddressCount);

		JsonSerialization.SerializeToFile(person, new FileInfo(Path.Combine(App.ExecutingFolder(), "PersonVal.json")));
	}

	[TestMethod]
	public void GeneratePhoneNumber_Country_Test_Random()
	{
		var country = CountryRepository.GetCountries().Shuffle().FirstOrDefault();

		var stringValue = RandomData.GeneratePhoneNumber(country, true);

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GeneratePhoneNumber_CountryName_Test_USA()
	{
		var stringValue = RandomData.GeneratePhoneNumber(CountryName.Taiwan, true);

		Assert.IsNotNull(stringValue);
	}

	//[TestMethod]
	//public void GeneratePhoneNumberUSATest()
	//{
	//	var stringValue = RandomData.GeneratePhoneNumber( );

	//	Assert.IsNotNull(stringValue);
	//}

	[TestMethod]
	public void GenerateRandomFileNameAllParamsTest()
	{
		var stringValue = RandomData.GenerateRandomFileName(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData,
				Environment.SpecialFolderOption.DoNotVerify),
			fileNameLength: 10,
			extension: FileExtension);

		Assert.IsNotNull(stringValue);

		Assert.IsTrue(new FileInfo(stringValue).Name.Length == 10 + FileExtension.Length + 1);

		Assert.IsTrue(stringValue.EndsWith(FileExtension));
	}

	[TestMethod]
	public void GenerateRandomFileNameTest()
	{
		var stringValue = RandomData.GenerateRandomFileName();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateRandomFileNameWithExtTest()
	{
		var stringValue = RandomData.GenerateRandomFileName(fileNameLength: 10, extension: FileExtension);

		Assert.IsNotNull(stringValue);

		Assert.IsTrue(new FileInfo(stringValue).Name.Length == 10 + FileExtension.Length + 1);

		Assert.IsTrue(stringValue.EndsWith(FileExtension));
	}

	[TestMethod]
	public void GenerateRandomFileNameWithPathTest()
	{
		var stringValue = RandomData.GenerateRandomFileName(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData,
				Environment.SpecialFolderOption.DoNotVerify));

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateRandomLocationDataTest()
	{
		var result = RandomData.GenerateRandomLocationData();

		Assert.IsNotNull(result);

		Assert.IsNotNull(result.country);
	}

	[TestMethod]
	public void GenerateRandomPersonDataTest()
	{
		var result = RandomData.GenerateRandomPersonData();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GenerateRandomPersonNameTest()
	{
		var result = RandomData.GenerateRandomPersonName();

		Assert.IsNotNull(result);

		Assert.IsNotNull(result.firstName);

		Assert.IsNotNull(result.lastName);
	}

	[TestMethod]
	public void GenerateRelativeUrlTest()
	{
		var stringValue = RandomData.GenerateRelativeUrl();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateTempFileTest()
	{
		var stringValue = RandomData.GenerateTempFile(FileLength);

		Assert.IsNotNull(stringValue);

		var tempFile = new FileInfo(stringValue);

		Assert.IsTrue(tempFile.Exists);

		Assert.IsTrue(tempFile.Length == FileLength);

		tempFile.Delete();
	}

	[TestMethod]
	public void GenerateUrlFragmentTest()
	{
		var stringValue = RandomData.GenerateUrlFragment();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateUrlHostNameNoProtocolTest()
	{
		var stringValue = RandomData.GenerateUrlHostNameNoProtocol();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateUrlHostNameNoSubDomainTest()
	{
		var stringValue = RandomData.GenerateUrlHostNameNoSubDomain();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateUrlTest()
	{
		var stringValue = RandomData.GenerateUrl();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateValPersonTest()
	{
		var person = RandomData.GeneratePersonVal<Models.ValueTypes.Address>();

		Assert.IsNotNull(person);

		Assert.IsNotNull(person.Addresses);

		Assert.IsTrue(person.BornOn > DateTimeOffset.Parse("1/1/1800"));

		Assert.IsNotNull(person.CellPhone);

		Assert.IsNotNull(person.Email);

		Assert.IsNotNull(person.FirstName);

		Assert.IsNotNull(person.Phone);

		Assert.IsNotNull(person.Id);

		Assert.IsNotNull(person.LastName);

		Assert.IsNotNull(person.FullName);

		Assert.IsNotNull(person.ToString());
	}

	[TestMethod]
	public void GenerateWordLengthWithCharactersTest()
	{
		var stringValue = RandomData.GenerateWord(length: 10, minCharacter: 'A', maxCharacter: 'Z');

		Assert.IsNotNull(stringValue);

		Assert.IsTrue(stringValue.Length == 10);
	}

	[TestMethod]
	public void GenerateWordMinMaxLengthTest()
	{
		var stringValue = RandomData.GenerateWord(minLength: 10, maxLength: 25);

		Assert.IsNotNull(stringValue);

		Assert.IsTrue(stringValue.Length >= 10);

		Assert.IsTrue(stringValue.Length <= 25);
	}

	[TestMethod]
	public void GenerateWordMinMaxLengthWithCharactersTest()
	{
		var stringValue = RandomData.GenerateWord(minLength: 5, maxLength: 25, minCharacter: 'A', maxCharacter: 'Z');

		Assert.IsNotNull(stringValue);

		Assert.IsTrue(stringValue.Length >= 5);

		Assert.IsTrue(stringValue.Length <= 25);
	}

	[TestMethod]
	public void GenerateWordsTest()
	{
		const int WordCount = 25;

		var words = RandomData.GenerateWords(WordCount, 10, 25);

		Assert.IsTrue(words.FastCount() == WordCount);
	}

	/// <summary>
	/// Defines the test method GenerateWordTest.
	/// </summary>
	[TestMethod]
	public void GenerateWordTest()
	{
		var stringValue = RandomData.GenerateWord(25);

		Assert.IsNotNull(stringValue);

		Assert.IsTrue(stringValue.Length == 25);
	}

	[TestMethod]
	public void PersonRecord_Serialization_Test()
	{
		var person = RandomData.GeneratePersonRecord();

		var result = JsonSerializer.Serialize(person);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		person = JsonSerializer.Deserialize<PersonRecord>(result);

		Assert.IsNotNull(person);
	}

	[TestMethod]
	public void PersonRef_Serialization_Test()
	{
		var person = RandomData.GeneratePersonRef<Models.RefTypes.Address>();

		var result = JsonSerializer.Serialize(person);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		person = JsonSerializer.Deserialize<Models.RefTypes.Person<Models.RefTypes.Address>>(result);

		Assert.IsNotNull(person);
	}

	[TestMethod]
	public void PersonVal_Serialization_Test()
	{
		var person = RandomData.GeneratePersonVal<Models.ValueTypes.Address>();

		var result = JsonSerializer.Serialize(person);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		person = JsonSerializer.Deserialize<Models.ValueTypes.Person<Models.ValueTypes.Address>>(result);

		Assert.IsNotNull(person);
	}

	[TestMethod]
	public void ReadOnlySequenceCollectionTest()
	{
		try
		{
			var people = new ReadOnlySequence<Models.RefTypes.Person<Models.RefTypes.Address>>(
				RandomData.GeneratePersonRefCollection<Models.RefTypes.Address>(Count).ToArray());

			var newPeople = new List<Models.RefTypes.Person<Models.RefTypes.Address>>();

			foreach (var person in people)
			{
				if (MemoryMarshal.TryGetArray(person, out var segment))
				{
					foreach (var item in segment)
					{
						newPeople.Add(item);
					}
				}
			}

			Assert.IsTrue(newPeople.FastCount() == Count);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void RecordToStringTest()
	{
		var stringValue1 = RandomData.GeneratePersonRecord().ToString();

		Assert.IsNotNull(stringValue1);

		var stringValue2 = RandomData.GeneratePersonRecord().PropertiesToString();

		Assert.IsNotNull(stringValue2);
	}

	/// <summary>
	/// Defines the test method UpdatePersonRecordTest.
	/// </summary>
	[TestMethod]
	public void UpdatePersonRecordTest()
	{
		var person1 = RandomData.GeneratePersonRecord();

		Assert.IsNotNull(person1);

		// Update Postal code
		var person2 = person1 with { CellPhone = "(858) 123-1234" };

		Assert.IsNotNull(person2);

		Debug.WriteLine(person2.ToString());

		Debug.WriteLine(person2.PropertiesToString());
	}
}
