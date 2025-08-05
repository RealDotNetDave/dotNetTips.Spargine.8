// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-05-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-07-2025
// ***********************************************************************
// <copyright file="IEasyDisposableTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Data;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class IEasyDisposableTests
{
	public class TestDisposable : IEasyDisposable
	{
		private DataTable _field = new DataTable();

		public bool IsDisposed { get; set; }
	}


	[TestMethod]
	public void DisposeFields_DisposesAllIDisposableFields()
	{
		using (var disposable = new TestDisposable())
		{
		}
	}
}
