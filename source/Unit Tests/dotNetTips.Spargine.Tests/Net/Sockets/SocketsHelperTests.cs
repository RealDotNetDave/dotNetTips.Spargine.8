// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-24-2024
// ***********************************************************************
// <copyright file="SocketsHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Net.Sockets;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.Net.Sockets;

[TestClass]
public class SocketsHelperTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public async Task ConnectTcpAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		SocketsHttpConnectionContext context = null;
		var cancellationToken = new CancellationToken(false);

		// Act
		await SocketsHelper.ConnectTcpAsync(context, cancellationToken);

		// Assert is handled by the ExpectedException attribute
	}

}
