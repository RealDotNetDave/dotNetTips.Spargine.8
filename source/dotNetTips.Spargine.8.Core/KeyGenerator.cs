// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 05-30-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-13-2024
// ***********************************************************************
// <copyright file="KeyGenerator.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Generates unique keys using a GUID without dashes.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides functionality to generate unique keys.
/// </summary>
public static class KeyGenerator
{

	/// <summary>
	/// Creates a random key from a GUID without dashes.
	/// </summary>
	/// <returns>A unique key as a string.</returns>
	/// <example>Example: f7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static string GenerateKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);

	/// <summary>
	/// Creates a random key from a GUID with a specified prefix.
	/// </summary>
	/// <param name="prefix">The prefix to prepend to the generated key.</param>
	/// <returns>A unique key as a string with the specified prefix.</returns>
	/// <example>Example: DataRecordf7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static string GenerateKey([NotNull] string prefix) => $"{prefix.ArgumentNotNull()}{Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture)}";

}
