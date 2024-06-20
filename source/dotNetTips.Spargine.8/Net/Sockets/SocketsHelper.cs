// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 01-11-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="SocketsHelper.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Helper methods for Socket operations.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Net.Sockets;

/// <summary>
/// Provides utility methods for working with sockets, including methods for connecting to TCP servers asynchronously.
/// This class contains methods that are essential for network communication, leveraging the <see cref="Socket"/> class
/// for creating connections and transmitting data over the network. The methods are designed to be efficient and easy to use,
/// abstracting some of the complexities involved in socket programming.
/// </summary>
/// <remarks>
/// The methods within this class are optimized for performance and usability, ensuring that common socket operations
/// are accessible with minimal code. It is part of the DotNetTips.Spargine library, which aims to provide a comprehensive
/// set of utilities for .NET developers.
/// </remarks>
public static class SocketsHelper
{

	/// <summary>
	/// Connect TCP as an asynchronous operation.
	/// </summary>
	/// <param name="context">The context.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A <see cref="ValueTask{Stream}"/> that represents the asynchronous operation, which upon completion returns a <see cref="Stream"/> connected to the TCP server.</returns>
	/// <example>
	/// Here is how you can use the ConnectTcpAsync method:
	/// <code>
	/// var context = new SocketsHttpConnectionContext(new DnsEndPoint("example.com", 80));
	/// var cancellationToken = new CancellationToken();
	/// var stream = await SocketsHelper.ConnectTcpAsync(context, cancellationToken);
	/// // Use the stream for network operations
	/// </code>
	/// </example>
	/// <remarks>Original code by: Máňa Píchová.</remarks>
	public static async ValueTask<Stream> ConnectTcpAsync([NotNull] SocketsHttpConnectionContext context, CancellationToken cancellationToken = default)
	{
		context = context.ArgumentNotNull();

		// The following socket constructor will create a dual-mode socket on systems where IPV6 is available.
		using var socket = new Socket(SocketType.Stream, ProtocolType.Tcp)
		{
			/* Turn off Nagle's algorithm since it degrades performance in most HttpClient scenarios.*/
			NoDelay = true,
			DualMode = true,
		};

		await socket.ConnectAsync(context.DnsEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

		// The stream should take the ownership of the underlying socket,
		// closing it when it's disposed.
		return new NetworkStream(socket, ownsSocket: true);
	}

}
