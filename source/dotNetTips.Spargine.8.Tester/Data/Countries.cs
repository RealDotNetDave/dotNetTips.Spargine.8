// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-12-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-12-2024
// ***********************************************************************
// <copyright file="Countries.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Methods for retrieving comprehensive data encompassing all countries
// worldwide, including their respective regions, states and cities.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Provides methods for retrieving comprehensive data encompassing all countries worldwide,
/// including their respective regions, states, and cities.
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
	/// Deserializes collection of <see cref="Country" />.
	/// </summary>
	/// <returns>ReadOnlyCollection&lt;Country&gt;.</returns>
	private static ReadOnlyCollection<Country> DeserializeCountires() => JsonSerializer.Deserialize<Country[]>(Resources.WorldCities, _options).AsReadOnly();

	/// <summary>
	/// Gets country data.
	/// </summary>
	/// <returns>A <see cref="ReadOnlyCollection{Country}"/> representing all countries.</returns>
	[Information(nameof(GetCountries), "David McCarter", "3/24/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static ReadOnlyCollection<Country> GetCountries()
	{
		_countries ??= DeserializeCountires();

		return _countries;
	}

	/// <summary>
	/// Gets the country by the specified country name.
	/// </summary>
	/// <param name="countryName">The name of the country. This parameter cannot be null.</param>
	/// <returns>A <see cref="Country"/> object if found; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="countryName"/> is null.</exception>
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static Country GetCountry([NotNull] CountryName countryName)
	{
		countryName = countryName.ArgumentNotNull();

		return GetCountries().FirstOrDefault(p => p.Name == countryName.GetDescription());
	}

	/// <summary>
	/// Gets the country by country Id.
	/// </summary>
	/// <param name="countryId">The country identifier. This parameter must be a positive number.</param>
	/// <returns>A <see cref="Country"/> object if found; otherwise, null.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="countryId"/> is less than or equal to 0.</exception>
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static Country GetCountry(long countryId) => GetCountries().FirstOrDefault(p => p.Id == countryId);

	/// <summary>
	/// The options
	/// </summary>
	private static readonly JsonSerializerOptions _options = ConfigureSerializerOptions();

}
