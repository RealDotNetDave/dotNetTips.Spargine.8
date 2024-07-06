// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 06-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="NetworkConnection.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )




namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Represents a network connection with properties indicating the types of connections available.
/// </summary>
public record NetworkConnection
{

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnection"/> class.
	/// </summary>
	/// <param name="bluetooth">if set to <c>true</c>, indicates a Bluetooth connection is available.</param>
	/// <param name="cellular">if set to <c>true</c>, indicates a cellular connection is available.</param>
	/// <param name="ethernet">if set to <c>true</c>, indicates an Ethernet connection is available.</param>
	/// <param name="unknown">if set to <c>true</c>, indicates the connection type is unknown.</param>
	/// <param name="wiFi">if set to <c>true</c>, indicates a WiFi connection is available.</param>
	public NetworkConnection(bool bluetooth, bool cellular, bool ethernet, bool unknown, bool wiFi)
	{
		this.Bluetooth = bluetooth;
		this.Cellular = cellular;
		this.Ethernet = ethernet;
		this.Unknown = unknown;
		this.WiFi = wiFi;
	}

	/// <summary>
	/// Gets a value indicating whether a Bluetooth connection is available.
	/// </summary>
	/// <value><c>true</c> if a Bluetooth connection is available; otherwise, <c>false</c>.</value>
	public bool Bluetooth { get; }

	/// <summary>
	/// Gets a value indicating whether a cellular connection is available.
	/// </summary>
	/// <value><c>true</c> if a cellular connection is available; otherwise, <c>false</c>.</value>
	public bool Cellular { get; }

	/// <summary>
	/// Gets a value indicating whether an Ethernet connection is available.
	/// </summary>
	/// <value><c>true</c> if an Ethernet connection is available; otherwise, <c>false</c>.</value>
	public bool Ethernet { get; }

	/// <summary>
	/// Gets a value indicating whether the connection type is unknown.
	/// </summary>
	/// <value><c>true</c> if the connection type is unknown; otherwise, <c>false</c>.</value>
	public bool Unknown { get; }

	/// <summary>
	/// Gets a value indicating whether a WiFi connection is available.
	/// </summary>
	/// <value><c>true</c> if a WiFi connection is available; otherwise, <c>false</c>.</value>
	public bool WiFi { get; }

}
