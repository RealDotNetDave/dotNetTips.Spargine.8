// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-21-2024
// ***********************************************************************
// <copyright file="PropertiesTest.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
public class PropertiesTest
{

	public DateTimeOffset? ClosedOn { get; set; }
	public string Id { get; set; }

	public Person<Address> Person { get; set; }

	public PersonRecord PersonRecord { get; set; }

	public DateTimeOffset Today { get; set; }

}
