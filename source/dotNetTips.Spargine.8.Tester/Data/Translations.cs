// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-18-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2024
// ***********************************************************************
// <copyright file="Translations.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class that encapsulates information for a translation.</summary>
// ***********************************************************************

using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Represents translations for various languages.
/// </summary>
[Serializable]
public sealed class Translations
{

	/// <summary>
	/// Gets or sets the translation for Chinese.
	/// </summary>
	/// <value>The Chinese translation.</value>
	[JsonPropertyName("cn")]
	public string Cn { get; set; }

	/// <summary>
	/// The country associated with the translations. This property is static and not serialized.
	/// </summary>
	/// <value>The country associated with the translations.</value>
	[JsonIgnore]
	public static Country Country => default!;

	/// <summary>
	/// Gets or sets the translation for German. Null values will not be written during serialization.
	/// </summary>
	/// <value>The German translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("de")]
	public string De { get; set; }

	/// <summary>
	/// Gets or sets the translation for Spanish. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Spanish translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("es")]
	public string Es { get; set; }

	/// <summary>
	/// Gets or sets the translation for Persian. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Persian translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("fa")]
	public string Fa { get; set; }

	/// <summary>
	/// Gets or sets the translation for French. Null values will not be written during serialization.
	/// </summary>
	/// <value>The French translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("fr")]
	public string Fr { get; set; }

	/// <summary>
	/// Gets or sets the translation for Croatian. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Croatian translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("hr")]
	public string Hr { get; set; }

	/// <summary>
	/// Gets or sets the translation for Italian. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Italian translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("it")]
	public string It { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the translation for Japanese. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Japanese translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("ja")]
	public string Ja { get; set; }

	/// <summary>
	/// Gets or sets the translation for Korean.
	/// </summary>
	/// <value>The Korean translation.</value>
	[JsonPropertyName("kr")]
	public string Kr { get; set; }

	/// <summary>
	/// Gets or sets the translation for Dutch. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Dutch translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("nl")]
	public string Nl { get; set; }

	/// <summary>
	/// Gets or sets the translation for Portuguese. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Portuguese translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("pt")]
	public string Pt { get; set; }

	/// <summary>
	/// Gets or sets the translation for Brazilian Portuguese. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Brazilian Portuguese translation.</value>
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("pt-BR")]
	public string PtBr { get; set; }

	/// <summary>
	/// Gets or sets the translation for Turkish.
	/// </summary>
	/// <value>The Turkish translation.</value>
	[JsonPropertyName("tr")]
	public string Tr { get; set; }

}
