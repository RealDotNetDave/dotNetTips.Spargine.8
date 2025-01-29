// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 10-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2025
// ***********************************************************************
// <copyright file="PersonJsonValSerializerContext.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

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
