// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-13-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-08-2023
// ***********************************************************************
// <copyright file="CreditCardInfo.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class CreditCardInfo.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="CreditCardInfo" /> class.
/// </remarks>
/// <param name="number">The number.</param>
/// <param name="type">The type.</param>
/// <param name="name">The name.</param>
/// <param name="expiryDate">The expiry date.</param>
/// <param name="cvv">The CVV.</param>
/// <param name="industry">The industry.</param>
public class CreditCardInfo(
	string number,
	string type,
	string name,
	string expiryDate,
	int cvv,
	string industry
	)
{

	/// <summary>
	/// Gets the CVV.
	/// </summary>
	/// <value>The CVV.</value>
	[JsonPropertyName("cvv")]
	public int Cvv { get; } = cvv;

	/// <summary>
	/// Gets the expiry date.
	/// </summary>
	/// <value>The expiry date.</value>
	[JsonPropertyName("expiryDate")]
	public string ExpiryDate { get; } = expiryDate;

	/// <summary>
	/// Gets the industry.
	/// </summary>
	/// <value>The industry.</value>
	[JsonPropertyName("industry")]
	public string Industry { get; } = industry;

	/// <summary>
	/// Gets the name.
	/// </summary>
	/// <value>The name.</value>
	[JsonPropertyName("name")]
	public string Name { get; } = name;

	/// <summary>
	/// Gets the number.
	/// </summary>
	/// <value>The number.</value>
	[JsonPropertyName("number")]
	public string Number { get; } = number;

	/// <summary>
	/// Gets the type.
	/// </summary>
	/// <value>The type.</value>
	[JsonPropertyName("type")]
	public string Type { get; } = type;

}
