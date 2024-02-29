// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 06-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2023
// ***********************************************************************
// <copyright file="NetworkConnection.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Class NetworkConnection.
/// </summary>
public record NetworkConnection
{

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnection" /> class.
	/// </summary>
	/// <param name="bluetooth">if set to <c>true</c> [bluetooth].</param>
	/// <param name="cellular">if set to <c>true</c> [cellular].</param>
	/// <param name="ethernet">if set to <c>true</c> [ethernet].</param>
	/// <param name="unknown">if set to <c>true</c> [unknown].</param>
	/// <param name="wiFi">if set to <c>true</c> [wi fi].</param>
	public NetworkConnection(bool bluetooth, bool cellular, bool ethernet, bool unknown, bool wiFi)
	{
		this.Bluetooth = bluetooth;
		this.Cellular = cellular;
		this.Ethernet = ethernet;
		this.Unknown = unknown;
		this.WiFi = wiFi;
	}

	/// <summary>
	/// Gets a value indicating whether this <see cref="NetworkConnection" /> is bluetooth.
	/// </summary>
	/// <value><c>true</c> if bluetooth; otherwise, <c>false</c>.</value>
	public bool Bluetooth { get; }

	/// <summary>
	/// Gets a value indicating whether this <see cref="NetworkConnection" /> is cellular.
	/// </summary>
	/// <value><c>true</c> if cellular; otherwise, <c>false</c>.</value>
	public bool Cellular { get; }

	/// <summary>
	/// Gets a value indicating whether this <see cref="NetworkConnection" /> is ethernet.
	/// </summary>
	/// <value><c>true</c> if ethernet; otherwise, <c>false</c>.</value>
	public bool Ethernet { get; }

	/// <summary>
	/// Gets a value indicating whether this <see cref="NetworkConnection" /> is unknown.
	/// </summary>
	/// <value><c>true</c> if unknown; otherwise, <c>false</c>.</value>
	public bool Unknown { get; }

	/// <summary>
	/// Gets a value indicating whether this <see cref="NetworkConnection" /> is wifi.
	/// </summary>
	/// <value><c>true</c> if wifi; otherwise, <c>false</c>.</value>
	public bool WiFi { get; }

}
