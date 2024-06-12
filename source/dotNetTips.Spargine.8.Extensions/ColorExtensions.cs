// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 07-29-2018
//
// Last Modified By : David McCarter
// Last Modified On : 06-11-2024
// ***********************************************************************
// <copyright file="ColorExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions methods for the Color type.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class ColorExtensionsExtensions methods for the Color type.
/// </summary>
public static class ColorExtensions
{

	/// <summary>
	/// Averages the specified colors in the collection.
	/// Validates that <paramref name="colors" /> is not null and has items.
	/// </summary>
	/// <param name="colors">The colors.</param>
	/// <returns>Color.</returns>
	/// <exception cref="ArgumentOutOfRangeException">colors - colors</exception>
	[Information(nameof(Average), "David McCarter", "1/1/2015", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "ADD URL")]
	public static Color Average([NotNull] this IEnumerable<Color> colors)
	{
		colors = colors.ArgumentItemsExists();

		return Color.FromArgb(colors.Average(c => c.R).Round(), colors.Average(c => c.G).Round(), colors.Average(c => c.B).Round());
	}

}
