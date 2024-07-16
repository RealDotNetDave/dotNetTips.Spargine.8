// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2024
// ***********************************************************************
// <copyright file="ContryConverters.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Converters tailored for Country.</summary>
// ***********************************************************************

using System.Text.Json;

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Provides a centralized JsonSerializerOptions instance with converters tailored for country-related data.
/// </summary>
internal static class CountryConverters
{

	/// <summary>
	/// Gets the JsonSerializerOptions with converters for region, date, time, and ISO date-time offset handling.
	/// </summary>
	public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
	{
		Converters =
		{
			RegionConverter.Singleton,
			new DateOnlyConverter(),
			new TimeOnlyConverter(),
			IsoDateTimeOffsetConverter.Singleton,
		},
	};

}
