// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-11-2025
// ***********************************************************************
// <copyright file="CountryRepository.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core.Data.Converters;
using DotNetTips.Spargine.Core.Data.Models;
using DotNetTips.Spargine.Core.Properties;
using DotNetTips.Spargine.Core.RegularExpressions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data;

/// <summary>
/// Provides static methods for retrieving comprehensive data about countries, including their regions, states, and cities.
/// Utilizes resources and serialization to efficiently manage and access country data.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class CountryRepository
{
	/// <summary>
	/// Holds a read-only collection of all countries, lazily initialized upon first access.
	/// </summary>
	private static ReadOnlyCollection<Country> _countries;

	/// <summary>
	/// Configures and returns the serializer options for JSON serialization.
	/// </summary>
	/// <returns>A <see cref="JsonSerializerOptions"/> object configured with custom settings for serialization.</returns>
	/// <remarks>
	/// This method sets up JSON serializer options to handle numbers as strings and adds custom converters.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static JsonSerializerOptions ConfigureSerializerOptions()
	{
		var options = new JsonSerializerOptions()
		{
			NumberHandling = JsonNumberHandling.AllowReadingFromString,
		};

		foreach (var converter in CountryConverter.Settings.Converters)
		{
			options.Converters.Add(converter);
		}

		return options;
	}

	/// <summary>
	/// Deserializes the JSON string from resources into a collection of <see cref="Country"/>.
	/// This method is marked with <see cref="MethodImplOptions.NoInlining"/> to suggest that
	/// the JIT compiler should not inline this method, potentially to improve debugging or
	/// to work around JIT compilation behaviors.
	/// </summary>
	/// <returns>A read-only collection of <see cref="Country"/> objects.</returns>
	/// <exception cref="InvalidOperationException">Thrown when deserialization fails due to invalid JSON format.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ReadOnlyCollection<Country> DeserializeCountries()
	{
		try
		{
			var countries = JsonSerializer.Deserialize<Country[]>(Resources.WorldCities, _options);
			return countries?.AsReadOnly() ?? new ReadOnlyCollection<Country>([]);
		}
		catch (JsonException ex)
		{
			// Log the exception or handle it as needed.
			throw new InvalidOperationException(Resources.FailedToDeserializeCountriesData, ex);
		}
	}

	/// <summary>
	/// Retrieves a read-only collection of all countries.
	/// </summary>
	/// <returns>A <see cref="ReadOnlyCollection{Country}"/> representing the comprehensive list of countries.</returns>
	/// <remarks>
	/// This method ensures thread-safe initialization and retrieval of the country collection.
	/// It leverages lazy loading to initialize the collection only once, upon the first request.
	/// </remarks>
	[MethodImpl(MethodImplOptions.Synchronized)]
	[Information(nameof(GetCountries), "David McCarter", "3/24/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Country> GetCountries()
	{
		_countries ??= DeserializeCountries();

		return _countries;
	}

	/// <summary>
	/// Retrieves a country by its name.
	/// </summary>
	/// <param name="countryName">The name of the country to retrieve. Cannot be null.</param>
	/// <returns>The <see cref="Country"/> object if codeFound; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="countryName"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Country GetCountry([NotNull] CountryName countryName)
	{
		countryName = countryName.ArgumentNotNull();

		return GetCountries().FirstOrDefault(p => string.Equals(p.Name, countryName.GetDescription(), StringComparison.Ordinal));
	}

	/// <summary>
	/// Retrieves a country by its unique identifier.
	/// </summary>
	/// <param name="countryId">The unique identifier for the country.</param>
	/// <returns>A <see cref="Country"/> object if codeFound; otherwise, null.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Country GetCountry(long countryId)
	{
		var countries = GetCountries();

		foreach (var country in countries)
		{
			if (country.Id == countryId)
			{
				return country;
			}
		}

		return null;
	}

	/// <summary>
	/// Validates the phone number for a given country.
	/// </summary>
	/// <param name="countryName">The name of the country to validate the phone number for. Cannot be null.</param>
	/// <param name="phoneNumber">The phone number to validate.</param>
	/// <param name="validateCountryCode">If set to <c>true</c>, validates the country code as part of the phone number.</param>
	/// <returns><c>true</c> if the phone number is valid for the specified country; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="countryName"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ValidatePhoneNumber), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ValidatePhoneNumber([NotNull] CountryName countryName, in string phoneNumber, bool validateCountryCode = false)
	{
		var country = GetCountry(countryName.ArgumentNotNull());

		var number = RegexProcessor.GetNumbers(phoneNumber);

		if (validateCountryCode)
		{
			var countryCodes = country.PhoneCode.Split(ControlChars.Comma);
			var codeFound = false;

			foreach (var code in countryCodes)
			{
				var strippedCode = RegexProcessor.GetNumbers(code);

				if (number.StartsWith(strippedCode, StringComparison.OrdinalIgnoreCase))
				{
					codeFound = true;
					number = number[strippedCode.Length..];
					break;
				}

			}

			if (codeFound is false)
			{
				return false;
			}
		}

		return number.Length == country.PhoneNumberLength;
	}

	/// <summary>
	/// Validates the postal code for a given country.
	/// </summary>
	/// <param name="countryName">The name of the country to validate the postal code for. Cannot be null.</param>
	/// <param name="postalCode">The postal code to validate.</param>
	/// <returns>
	/// A <see cref="PostalCodeState"/> value indicating whether the postal code is valid, invalid, or unknown for the specified country.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="countryName"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ValidatePostalCode), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static PostalCodeState ValidatePostalCode([NotNull] CountryName countryName, in string postalCode)
	{
		var country = GetCountry(countryName.ArgumentNotNull());

		if (string.IsNullOrEmpty(country.PostalRegex))
		{
			return PostalCodeState.Unknown;
		}

		return Regex.IsMatch(postalCode?.Trim() ?? string.Empty, country.PostalRegex) ? PostalCodeState.Valid : PostalCodeState.Invalid;
	}

	/// <summary>
	/// The serializer options configured for JSON operations within the CountryRepository class.
	/// </summary>
	private static readonly JsonSerializerOptions _options = ConfigureSerializerOptions();
}
