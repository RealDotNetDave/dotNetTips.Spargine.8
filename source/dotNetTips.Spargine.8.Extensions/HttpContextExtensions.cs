// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-04-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="HttpContextExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for HttpContext.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using Microsoft.AspNetCore.Http;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="HttpContext"/>, enhancing its functionality with additional utility methods.
/// These methods include getting the remote IP address of the client, which can be useful for logging, analytics, and security purposes.
/// </summary>
/// <remarks>
/// The extension methods in this class are designed to simplify common operations performed on <see cref="HttpContext"/> instances,
/// making it easier to retrieve information such as the client's IP address. This can be particularly useful in web applications
/// for tracking user activity or implementing security measures based on IP addresses.
/// </remarks>
[Information(Status = Status.Available)]
public static class HttpContextExtensions
{

	/// <summary>
	/// Gets the remote IP address.
	/// Validates that <paramref name="context" /> is not null.
	/// </summary>
	/// <param name="context">The context.</param>
	/// <returns>System.String.</returns>
	[Information("Original code from: https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20", "David McCarter", "9/04/2017", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static string GetRemoteIPAddress([NotNull] this HttpContext context) => context.ArgumentNotNull().Connection.RemoteIpAddress.ToString();

}
