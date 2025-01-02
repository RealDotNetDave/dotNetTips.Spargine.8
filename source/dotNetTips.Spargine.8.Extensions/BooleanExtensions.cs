// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="BooleanExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions for the boolean type.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="bool"/> type, enhancing its usability and integration within applications.
/// </summary>
/// <remarks>
/// This class includes methods for converting boolean values to strings in various formats, such as lowercase,
/// which can be particularly useful for generating user-friendly display strings or for serialization purposes.
/// </remarks>
[Information(nameof(BooleanExtensions), author: "David McCarter", createdOn: "7/15/2020")]
public static class BooleanExtensions
{

	/// <summary>
	/// Converts to <see cref="bool" /> value to lowercase.
	/// </summary>
	/// <param name="value">if set to <c>true</c> [value].</param>
	/// <returns>System.String.</returns>
	[ExcludeFromCodeCoverage]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available, BenchmarkStatus = BenchmarkStatus.NotRequired, Documentation = "ADD URL")]
	public static string ToLowerCase(this bool value) => value ? Resources.TrueLowerCase : Resources.FalseLowerCase;

}
