// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="TestType.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[XmlRoot]
public class TestType
{

	/// <summary>
	/// Gets the name.
	/// </summary>
	/// <returns>System.String.</returns>
	public static string GetName()
	{
		return "GetName";
	}

	/// <summary>
	/// Invokes the specified input.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>System.String.</returns>
	public string Invoke(string input)
	{
		return input;
	}

	/// <summary>
	/// Runs this instance.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public void Run<T>() where T : class
	{
		//Do Nothing
	}

	/// <summary>
	/// Gets or sets the name of the user.
	/// </summary>
	/// <value>The name of the user.</value>
	[XmlIgnore]
	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public string UserName { get; set; }

}

