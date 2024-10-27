// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-08-2023
//
// Last Modified By : David McCarter
// Last Modified On : 10-27-2024
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

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Class PersonJsonSerializerContext.
/// Implements the <see cref="JsonSerializerContext" />
/// </summary>
/// <seealso cref="JsonSerializerContext" />
[JsonSourceGenerationOptions(IncludeFields = false)]
[JsonSerializable(typeof(Person<Address>), TypeInfoPropertyName = "Person")]
[JsonSerializable(typeof(List<Person<Address>>), TypeInfoPropertyName = "PersonList")]
[Information(nameof(PersonJsonValSerializerContext), Status = Status.Available)]
public partial class PersonJsonValSerializerContext : JsonSerializerContext
{
}
