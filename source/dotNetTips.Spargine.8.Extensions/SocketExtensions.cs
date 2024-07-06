// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-19-2024
// ***********************************************************************
// <copyright file="SocketExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for Socket.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Socket"/> class, enhancing its functionality
/// with additional utility methods. These methods include binding to an anonymous port, forcing
/// non-blocking mode, and attempting connections with a timeout.
/// </summary>
[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available)]
public static class SocketExtensions
{

	/// <summary>
	/// Binds to an IP address and OS-assigned port. Returns the chosen port.
	/// Validates that <paramref name="socket" /> and <paramref name="address" /> is not null.
	/// </summary>
	/// <param name="socket">The socket.</param>
	/// <param name="address">The address.</param>
	/// <returns>System.Int32.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int BindToAnonymousPort([NotNull] this Socket socket, [NotNull] IPAddress address)
	{
		socket.ArgumentNotNull().Bind(new IPEndPoint(address.ArgumentNotNull(), 0));

		return ((IPEndPoint)socket.LocalEndPoint).Port;
	}

	/// <summary>
	/// On non-Windows platforms, once non-blocking is turned on (either explicitly or by performing an async
	/// operation), always stay in non-blocking mode.
	/// Validates that <paramref name="socket" /> is not null.
	/// </summary>
	/// <param name="socket">The <see cref="Socket"/> to modify.</param>
	/// <param name="force">if set to <c>true</c>, the <paramref name="socket"/> is forced into non-blocking mode.</param>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static void ForceNonBlocking([NotNull] this Socket socket, bool force)
	{
		if (socket.CheckIsNotNull())
		{
			socket.Blocking = force;
		}
	}

	/// <summary>
	/// Tries to connect within the provided timeout interval. Useful to speed up "cannot connect" assertions on
	/// Windows. Validates that <paramref name="socket" /> and <paramref name="remoteEndpoint" /> are not null.
	/// </summary>
	/// <param name="socket">The <see cref="Socket"/> to use for the connection attempt.</param>
	/// <param name="remoteEndpoint">The <see cref="EndPoint"/> to which you want to connect.</param>
	/// <param name="millisecondsTimeout">The timeout in milliseconds for the connection attempt.</param>
	/// <returns><c>true</c> if the connection is successful within the timeout period; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> or <paramref name="remoteEndpoint"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeout"/> is less than 1.</exception>
	/// <exception cref="PlatformNotSupportedException">Thrown when the operation is not supported on the current platform, specifically non-Windows platforms.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool TryConnect([NotNull] this Socket socket, [NotNull] EndPoint remoteEndpoint, int millisecondsTimeout)
	{
		socket = socket.ArgumentNotNull();
		remoteEndpoint = remoteEndpoint.ArgumentNotNull();
		millisecondsTimeout = millisecondsTimeout.EnsureMinimum(1);

		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			using (var mre = new ManualResetEventSlim(false))
			{
				using (var sea = new SocketAsyncEventArgs() { RemoteEndPoint = remoteEndpoint, UserToken = mre })
				{
					sea.Completed += (s, e) => ((ManualResetEventSlim)e.UserToken).Set();

					var pending = socket.ConnectAsync(sea);

					if (!pending || mre.Wait(millisecondsTimeout))
					{
						return sea.SocketError == SocketError.Success;
					}

					Socket.CancelConnectAsync(sea); // this will close the socket!

					// In case of time-out, ManualResetEventSlim is left un-disposed to avoid race conditions,
					// letting SafeHandle's finalizer to do the cleanup.
					return false;
				}
			}
		}
		else
		{
			throw new PlatformNotSupportedException();
		}
	}

}
