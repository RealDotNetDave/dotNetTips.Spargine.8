// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-06-2024
// ***********************************************************************
// <copyright file="TaskExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class TaskExtensionsTests
{

	/// <summary>
	/// The fire result
	/// </summary>
	private string _fireResult = string.Empty;

	/// <summary>
	/// Fires the specified input.
	/// </summary>
	/// <param name="input">The input.</param>
	private async Task FireAsync(string input)
	{
		this._fireResult = input;

		Console.WriteLine(input);

		await Task.Delay(1).ConfigureAwait(false);
	}

	/// <summary>
	/// Defines the test method FireAndForgetTest01.
	/// </summary>
	[TestMethod]
	public void FireAndForgetTest01()
	{
		this.FireAsync(nameof(this.FireAndForgetTest01)).FireAndForget();

		Assert.AreEqual(this._fireResult, nameof(this.FireAndForgetTest01));
	}

	/// <summary>
	/// Defines the test method FireAndForgetTest02.
	/// </summary>
	[TestMethod]
	public void FireAndForgetTest02()
	{
		Action<Exception> value = (Exception ex) => Debug.WriteLine(ex.Message);

		var p = value;

		this.FireAsync(nameof(this.FireAndForgetTest01)).FireAndForget(p);

		Assert.AreEqual(this._fireResult, nameof(this.FireAndForgetTest01));
	}

}
