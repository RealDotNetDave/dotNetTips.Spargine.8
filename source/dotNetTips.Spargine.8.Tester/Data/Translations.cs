// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2024
// ***********************************************************************
// <copyright file="Translations.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Class Translations.
/// </summary>
public sealed class Translations
{

	/// <summary>
	/// Gets or sets the cn.
	/// </summary>
	/// <value>The cn.</value>
	[JsonPropertyName("cn")]
	public string Cn { get; set; }

	/// <summary>
	/// Gets or sets the country.
	/// </summary>
	/// <value>The country.</value>
	public static Country Country => default!;

	/// <summary>
	/// Gets or sets the de.
	/// </summary>
	/// <value>The de.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("de")]
	public string De { get; set; }

	/// <summary>
	/// Gets or sets the es.
	/// </summary>
	/// <value>The es.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("es")]
	public string Es { get; set; }

	/// <summary>
	/// Gets or sets the fa.
	/// </summary>
	/// <value>The fa.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("fa")]
	public string Fa { get; set; }

	/// <summary>
	/// Gets or sets the fr.
	/// </summary>
	/// <value>The fr.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("fr")]
	public string Fr { get; set; }

	/// <summary>
	/// Gets or sets the hr.
	/// </summary>
	/// <value>The hr.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("hr")]
	public string Hr { get; set; }

	/// <summary>
	/// Gets or sets it.
	/// </summary>
	/// <value>It.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("it")]
	public string It { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the ja.
	/// </summary>
	/// <value>The ja.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("ja")]
	public string Ja { get; set; }
	/// <summary>
	/// Gets or sets the kr.
	/// </summary>
	/// <value>The kr.</value>
	[JsonPropertyName("kr")]
	public string Kr { get; set; }

	/// <summary>
	/// Gets or sets the nl.
	/// </summary>
	/// <value>The nl.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("nl")]
	public string Nl { get; set; }

	/// <summary>
	/// Gets or sets the pt.
	/// </summary>
	/// <value>The pt.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("pt")]
	public string Pt { get; set; }

	/// <summary>
	/// Gets or sets the pt br.
	/// </summary>
	/// <value>The pt br.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("pt-BR")]
	public string PtBr { get; set; }

	/// <summary>
	/// Gets or sets the tr.
	/// </summary>
	/// <value>The tr.</value>
	[JsonPropertyName("tr")]
	public string Tr { get; set; }

}
