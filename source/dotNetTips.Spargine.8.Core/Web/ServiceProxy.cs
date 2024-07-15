// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="ServiceProxy.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Generates a service proxy for types that implement
// ICommunicationObject, enabling communication with such objects.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel;
using System.ServiceModel.Description;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Web;

/// <summary>
/// Provides a base class for creating service proxies for types that implement <see cref="ICommunicationObject"/>.
/// This enables communication with WCF services by abstracting the creation and management of service channels.
/// </summary>
/// <typeparam name="T">The service contract type that implements <see cref="ICommunicationObject"/>.</typeparam>
/// <remarks>
/// Service proxies are used to manage service channels efficiently, handling creation, usage, and cleanup of channels.
/// This abstract class requires the implementation of the service contract as a generic type parameter.
/// </remarks>
public abstract class ServiceProxy<T>([NotNull] ServiceEndpoint serviceEndpoint) : IDisposable where T : ICommunicationObject
{

	/// <summary>
	/// The communication channel used to interact with the service.
	/// </summary>
	private T _channel;

	/// <summary>
	/// The factory used to create channels for communication with the service.
	/// </summary>
	private ChannelFactory<T> _channelFactory;

	/// <summary>
	/// The synchronization lock object used to ensure thread safety when initializing or disposing resources.
	/// </summary>
	private readonly object _lock = new();

	/// <summary>
	/// Initializes the service proxy by creating a channel factory and channel based on the provided service endpoint.
	/// Ensures that only one channel is created per instance, using a thread-safe initialization pattern.
	/// </summary>
	private void Initialize()
	{
		lock (this._lock)
		{
			if (this.Channel is not null)
			{
				return;
			} (this._channelFactory as IDisposable)?.Dispose();

			this._channelFactory = new ChannelFactory<T>(serviceEndpoint);

			this.Channel = this._channelFactory.CreateChannel(new EndpointAddress(serviceEndpoint.Address.Uri));
		}
	}

	/// <summary>
	/// Closes the communication channel with the service, ensuring a graceful shutdown of the connection.
	/// </summary>
	/// <remarks>
	/// This method checks if the channel exists and is not already disposed before attempting to close it.
	/// It's designed to be called from within the class or by derived classes to ensure resources are properly released.
	/// </remarks>
	protected void CloseChannel()
	{
		if (this.Channel is not null && this.Disposed is false)
		{
			this.Channel.Close();
		}
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	/// <remarks>
	/// If <paramref name="disposing"/> is <c>true</c>, the method disposes of managed resources (like the channel and channel factory).
	/// This method is called by the public Dispose method and the <see cref="GC.SuppressFinalize"/> method to release managed and unmanaged resources.
	/// </remarks>
	protected virtual void Dispose(bool disposing)
	{
		// Do nothing if the object has already been disposed of.
		if (this.Disposed)
		{
			return;
		}

		if (disposing)
		{
			lock (this._lock)
			{
				// Release disposable objects used by this instance here.
				(this._channel as IDisposable)?.Dispose();
				(this._channelFactory as IDisposable)?.Dispose();
			}
		}

		// Remember that the object has been disposed of.
		this.Disposed = true;
	}

	/// <summary>
	/// Gets the communication channel used to interact with the service. This property ensures the channel is initialized before use.
	/// </summary>
	/// <value>The communication channel.</value>
	/// <remarks>
	/// The channel is lazily initialized upon first access to ensure efficient use of resources. This design supports the efficient management of service connections.
	/// </remarks>
	protected T Channel
	{
		get
		{
			this.Initialize();
			return this._channel;
		}

		private set => this._channel = value;
	}

	/// <summary>
	/// Gets or sets a value indicating whether the <see cref="ServiceProxy{T}"/> is disposed.
	/// </summary>
	/// <value><c>true</c> if this instance is disposed; otherwise, <c>false</c>.</value>
	/// <remarks>
	/// This property is used internally to track the disposal state of the service proxy instance,
	/// ensuring that resources are not inadvertently released more than once.
	/// </remarks>
	protected bool Disposed { get; set; }

	/// <summary>
	/// Disposes of the resources (other than memory) used by the <see cref="ServiceProxy{T}"/>.
	/// </summary>
	/// <remarks>
	/// This method disposes the service proxy's resources by calling the protected virtual Dispose method with the disposing parameter set to true.
	/// It then calls GC.SuppressFinalize to take this object off the finalization queue and prevent finalization code for this object
	/// from executing a second time.
	/// </remarks>
	[Preserve("Part of IDisposable", "4/16/2023", "David McCarter")]
	public void Dispose()
	{
		this.Dispose(true);

		// Unregister object for finalization.
		GC.SuppressFinalize(this);
	}

}
