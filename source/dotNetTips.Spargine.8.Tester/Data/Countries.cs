// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-12-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-31-2024
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
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Provides static methods for retrieving comprehensive data about countries, including their regions, states, and cities.
/// Utilizes resources and serialization to efficiently manage and access country data.
/// </summary>
public static class Countries
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

		_ = options.Converters.AddRange(CountryConverters.Settings.Converters, false);

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
	private static ReadOnlyCollection<Country> DeserializeCountires()
	{
		try
		{
			var countries = JsonSerializer.Deserialize<Country[]>(Resources.WorldCities, _options);
			return countries?.AsReadOnly() ?? new ReadOnlyCollection<Country>(new List<Country>());
		}
		catch (JsonException ex)
		{
			// Log the exception or handle it as needed.
			throw new InvalidOperationException("Failed to deserialize countries data.", ex);
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
	[Information(nameof(GetCountries), "David McCarter", "3/24/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static ReadOnlyCollection<Country> GetCountries()
	{
		_countries ??= DeserializeCountires();

		return _countries;
	}

	/// <summary>
	/// Retrieves a country by its name.
	/// </summary>
	/// <param name="countryName">The name of the country to retrieve. Cannot be null.</param>
	/// <returns>The <see cref="Country"/> object if found; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="countryName"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static Country GetCountry([NotNull] CountryName countryName)
	{
		countryName = countryName.ArgumentNotNull();

		return GetCountries().FirstOrDefault(p => string.Equals(p.Name, countryName.GetDescription(), StringComparison.Ordinal));
	}

	/// <summary>
	/// Retrieves a country by its unique identifier.
	/// </summary>
	/// <param name="countryId">The unique identifier for the country.</param>
	/// <returns>A <see cref="Country"/> object if found; otherwise, null.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
	public static Country GetCountry(long countryId) => GetCountries().FirstOrDefault(p => p.Id == countryId);

	/// <summary>
	/// The serializer options configured for JSON operations within the Countries class.
	/// </summary>
	private static readonly JsonSerializerOptions _options = ConfigureSerializerOptions();

}
