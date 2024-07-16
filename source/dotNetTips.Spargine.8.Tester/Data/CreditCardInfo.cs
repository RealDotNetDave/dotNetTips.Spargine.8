// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 03-13-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2024
// ***********************************************************************
// <copyright file="CreditCardInfo.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class that encapsulates information for a credit card.</summary>
// ***********************************************************************

using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Represents credit card information, including number, type, name, expiry date, CVV, and industry.
/// </summary>
/// <param name="number">The credit card number.</param>
/// <param name="type">The type of the credit card (e.g., Visa, MasterCard).</param>
/// <param name="name">The name on the credit card.</param>
/// <param name="expiryDate">The expiry date of the credit card.</param>
/// <param name="cvv">The CVV (Card Verification Value) of the credit card.</param>
/// <param name="industry">The industry associated with the credit card.</param>
/// <remarks>
/// This class is used to encapsulate all necessary information about a credit card.
/// </remarks>
public class CreditCardInfo(string number, string type, string name, string expiryDate, int cvv, string industry)
{

	/// <summary>
	/// Gets the Card Verification Value (CVV) of the credit card.
	/// </summary>
	/// <value>The CVV, a 3 or 4 digit number found on the card, used for transaction security.</value>
	[JsonPropertyName("cvv")]
	public int Cvv { get; } = cvv;

	/// <summary>
	/// Gets the expiry date of the credit card.
	/// </summary>
	/// <value>The expiry date in the format MM/YY.</value>
	[JsonPropertyName("expiryDate")]
	public string ExpiryDate { get; } = expiryDate;

	/// <summary>
	/// Gets the industry associated with the credit card.
	/// </summary>
	/// <value>The industry, such as banking, retail, or travel, that the credit card is associated with.</value>
	[JsonPropertyName("industry")]
	public string Industry { get; } = industry;

	/// <summary>
	/// Gets the name on the credit card.
	/// </summary>
	/// <value>The name as it appears on the credit card.</value>
	[JsonPropertyName("name")]
	public string Name { get; } = name;

	/// <summary>
	/// Gets the credit card number.
	/// </summary>
	/// <value>The credit card number as a string.</value>
	[JsonPropertyName("number")]
	public string Number { get; } = number;

	/// <summary>
	/// Gets the type of the credit card.
	/// </summary>
	/// <value>The type of the credit card, such as Visa, MasterCard, American Express, etc.</value>
	[JsonPropertyName("type")]
	public string Type { get; } = type;

}
