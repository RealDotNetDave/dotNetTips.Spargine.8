// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 07-29-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-27-2024
// ***********************************************************************
// <copyright file="ColorExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions methods for the Color type.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Color"/> type, enhancing functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class includes methods for operations such as averaging the RGB values of a collection of colors. It is part of the DotNetTips.Spargine.8.Extensions
/// library, which provides a wide range of extension methods for .NET types, aiming to improve code readability and efficiency.
/// </remarks>
public static class ColorExtensions
{

	/// <summary>
	/// Averages the specified colors in the collection.
	/// Validates that <paramref name="colors" /> is not null and has items.
	/// </summary>
	/// <param name="colors">The colors.</param>
	/// <returns>Color.</returns>
	/// <exception cref="ArgumentOutOfRangeException">colors - colors</exception>
	[Information(nameof(Average), "David McCarter", "1/1/2015", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static Color Average([NotNull] this IEnumerable<Color> colors)
	{
		colors = colors.ArgumentItemsExists();

		return Color.FromArgb(colors.Average(c => c.R).Round(), colors.Average(c => c.G).Round(), colors.Average(c => c.B).Round());
	}

}
