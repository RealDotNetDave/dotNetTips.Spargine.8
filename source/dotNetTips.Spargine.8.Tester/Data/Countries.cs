// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-12-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2024
// ***********************************************************************
// <copyright file="Countries.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class _countries. This class cannot be inherited.
/// </summary>
public static class Countries
{

	/// <summary>
	/// The countries
	/// </summary>
	private static ReadOnlyCollection<Country> _countries;

	/// <summary>
	/// Configures the serializer options.
	/// </summary>
	/// <returns>JsonSerializerOptions.</returns>
	private static JsonSerializerOptions ConfigureSerializerOptions()
	{
		var options = new JsonSerializerOptions()
		{
			NumberHandling = JsonNumberHandling.AllowReadingFromString,
		};

		_ = options.Converters.AddRange(ContryConverters.Settings.Converters, false);

		return options;
	}

	/// <summary>
	/// Deserializes the countires.
	/// </summary>
	/// <returns>ReadOnlyCollection&lt;Country&gt;.</returns>
	private static ReadOnlyCollection<Country> DeserializeCountires() => JsonSerializer.Deserialize<Country[]>(Resources.WorldCities, _options).AsReadOnly();

	/// <summary>
	/// Gets country data.
	/// </summary>
	/// <returns>ReadOnlyCollection&lt;Country&gt;.</returns>
	[Information(nameof(GetCountries), "David McCarter", "3/24/2023", UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static ReadOnlyCollection<Country> GetCountries()
	{
		_countries ??= DeserializeCountires();

		return _countries;
	}

	/// <summary>
	/// Gets the name of the country by country name.
	/// </summary>
	/// <param name="countryName">Name of the country.</param>
	/// <returns>Country.</returns>
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static Country GetCountry(CountryName countryName)
	{
		countryName = countryName.ArgumentNotNull();

		return GetCountries().FirstOrDefault(p => p.Name == countryName.GetDescription());
	}

	/// <summary>
	/// Gets the country by country Id.
	/// </summary>
	/// <param name="countryId">The country identifier.</param>
	/// <returns>Country.</returns>
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static Country GetCountry(long countryId) => GetCountries().FirstOrDefault(p => p.Id == countryId);

	/// <summary>
	/// The options
	/// </summary>
	private static readonly JsonSerializerOptions _options = ConfigureSerializerOptions();

}