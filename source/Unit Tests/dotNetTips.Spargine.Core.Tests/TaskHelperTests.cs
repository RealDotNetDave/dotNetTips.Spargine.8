// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-22-2024
// ***********************************************************************
// <copyright file="TaskHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;
[ExcludeFromCodeCoverage]
[TestClass]
public class TaskHelperTests
{

	private string _fireResult = string.Empty;

	private async Task Fire(string input)
	{
		this._fireResult = input;

		Console.WriteLine(input);

		await Task.Delay(1).ConfigureAwait(false);
	}

	private async Task<string> FireWithReturn(string input)
	{
		this._fireResult = input;

		Console.WriteLine(input);

		await Task.Delay(1).ConfigureAwait(false);

		return input;
	}

	[TestMethod]
	public void RunSync10()
	{
		TaskHelper.RunSync(() => this.Fire(nameof(this.RunSync10)));

		Assert.AreEqual(this._fireResult, nameof(this.RunSync10));
	}

	[TestMethod]
	public void RunSync11()
	{
		var cancelToken = new CancellationTokenSource().Token;

		TaskHelper.RunSync(() => this.Fire(nameof(this.RunSync11)), cancellationToken: cancelToken);

		Assert.AreEqual(this._fireResult, nameof(this.RunSync11));
	}

	[TestMethod]
	public void RunSync20()
	{
		_ = TaskHelper.RunSync(() => this.FireWithReturn(nameof(this.RunSync20)));

		Assert.AreEqual(this._fireResult, nameof(this.RunSync20));
	}

	[TestMethod]
	public void RunSync21()
	{
		var cancelToken = new CancellationTokenSource().Token;

		_ = TaskHelper.RunSync(() => this.FireWithReturn(nameof(this.RunSync21)), cancellationToken: cancelToken);

		Assert.AreEqual(this._fireResult, nameof(this.RunSync21));
	}

}
