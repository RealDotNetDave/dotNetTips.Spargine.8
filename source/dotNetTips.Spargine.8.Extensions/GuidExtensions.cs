// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 07-30-2018
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="GuidExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for Guid.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Guid"/> type.
/// These methods include converting a Guid to a string representation without dashes and checking if a Guid is not empty.
/// </summary>
public static class GuidExtensions
{

	/// <summary>
	/// Converts the specified <see cref="Guid"/> to a string representation without dashes.
	/// </summary>
	/// <param name="input">The <see cref="Guid"/> to convert.</param>
	/// <returns>A string representation of the <see cref="Guid"/> without dashes if the <paramref name="input"/> is not empty; otherwise, an empty string.</returns>
	[Information(nameof(ToDigits), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
