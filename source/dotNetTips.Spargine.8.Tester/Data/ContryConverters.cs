// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2024
// ***********************************************************************
// <copyright file="ContryConverters.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class ContryConverters.
/// </summary>
internal static class ContryConverters
{

	/// <summary>
	/// The settings
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