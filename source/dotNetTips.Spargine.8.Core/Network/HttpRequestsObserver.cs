// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="HttpRequestsObserver.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Logs messages from HttpRequests.
// Original code by:
// https:www.meziantou.net/observing-all-http-requests-in-a-dotnet-application.htm
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Class HttpRequestsObserver. This class cannot be inherited.
/// Implements the <see cref="IDisposable" />
/// Implements the <see cref="IObserver{DiagnosticListener}" />
/// </summary>
/// <seealso cref="IDisposable" />
/// <seealso cref="IObserver{DiagnosticListener}" />
/// <param name="logger">The logger.</param>
/// <remarks>Initializes a new instance of the <see cref="HttpRequestsObserver" /> class.</remarks>
public sealed class HttpRequestsObserver(ILogger logger) : IDisposable, IObserver<DiagnosticListener>
{

	/// <summary>
	/// The disposed flag.
	/// </summary>
	private bool _disposed;

	/// <summary>
	/// The subscription.
	/// </summary>
	private IDisposable _subscription;

	/// <summary>
	/// Finalizes an instance of the <see cref="HttpRequestsObserver" /> class.
	/// </summary>
	~HttpRequestsObserver() => this.Dispose(false);

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	[Preserve("Part of IDisposable", "4/16/2023", "David McCarter")]
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	public void Dispose(bool disposing)
	{
		if (this._disposed)
		{
			return;
		}

		if (disposing)
		{
			this._subscription?.Dispose();
		}

		this._disposed = true;
	}

	/// <summary>
	/// Notifies the observer that the provider has finished sending push-based notifications.
	/// </summary>
	/// <exception cref="NotSupportedException"></exception>
	public void OnCompleted() { }

	/// <summary>
	/// Notifies the observer that the provider has experienced an error condition.
	/// </summary>
	/// <param name="error">An object that provides additional information about the error.</param>
	/// <exception cref="NotSupportedException"></exception>
	public void OnError(Exception error) { }

	/// <summary>
	/// Provides the observer with new data.
	/// </summary>
	/// <param name="value">The current notification information.</param>
	public void OnNext([NotNull] DiagnosticListener value)
	{
		if (value.ArgumentNotNull().Name is "HttpHandlerDiagnosticListener")
		{
			Debug.Assert(this._subscription == null);

			this._subscription = value.Subscribe(new HttpHandlerDiagnosticListener(logger));
		}
	}

}
