// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions **
// Author           : David McCarter
// Created          : 07-30-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2023
// ***********************************************************************
// <copyright file="GuidExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class GuidExtensions.
/// </summary>
public static class GuidExtensions
{

	/// <summary>
	/// Returns the <see cref="Guid" /> without dashes.
	/// Validates that <paramref name="input" /> is not empty.
	/// </summary>
	/// <param name="input">The Guid value.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ToDigits), UnitTestCoverage = 100, Status = Status.Available)]
	public static string ToDigits([NotNull] this Guid input)
	{
		if (input.CheckIsNotEmpty())
		{
			return input.ToString("N", CultureInfo.InvariantCulture);
		}
		else
		{
			return string.Empty;
		}
	}

}
