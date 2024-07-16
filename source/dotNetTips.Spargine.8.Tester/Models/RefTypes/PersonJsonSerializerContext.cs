// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-08-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Provides a custom JSON serialization context for optimizing the serialization
/// and deserialization of <see cref="Person{TAddress}"/> types and their collections.
/// </summary>
/// <remarks>
/// This class leverages source generation for JSON serialization to improve performance
/// and reduce runtime overhead by generating serialization metadata at compile time.
/// </remarks>
[JsonSourceGenerationOptions(IncludeFields = false)]
[JsonSerializable(typeof(Person<Address>), TypeInfoPropertyName = "Person")]
[JsonSerializable(typeof(List<Person<Address>>), TypeInfoPropertyName = "PersonList")]
[Information(nameof(PersonJsonSerializerContext), Status = Status.NeedsDocumentation)]
public partial class PersonJsonSerializerContext : JsonSerializerContext
{
}

