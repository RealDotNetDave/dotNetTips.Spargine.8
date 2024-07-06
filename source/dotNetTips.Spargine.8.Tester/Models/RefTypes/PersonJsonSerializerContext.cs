// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-08-2023
//
// Last Modified By : David McCarter
// Last Modified On : 05-29-2024
// ***********************************************************************
// <copyright file="PersonJsonSerializerContext.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// JSON context designed to optimize the serialization and
// deserialization processes for the "Person" type and collections of
// "Person."
// </summary>
// ***********************************************************************

using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Class PersonJsonSerializerContext.
/// Implements the <see cref="JsonSerializerContext" />
/// Implements the <see cref="System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver" />
/// </summary>
/// <seealso cref="JsonSerializerContext" />
/// <seealso cref="System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver" />
[JsonSourceGenerationOptions(IncludeFields = false)]
[JsonSerializable(typeof(Person<Address>), TypeInfoPropertyName = "Person")]
[JsonSerializable(typeof(List<Person<Address>>), TypeInfoPropertyName = "PersonList")]
[Information(nameof(PersonJsonSerializerContext), Status = Status.NeedsDocumentation)]
public partial class PersonJsonSerializerContext : JsonSerializerContext
{
}

