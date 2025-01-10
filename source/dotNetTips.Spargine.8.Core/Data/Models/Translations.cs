// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="Translations.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data.Models;

/// <summary>
/// Represents translations for various languages.
/// </summary>
[DataContract]
[Serializable]
public sealed class Translations
{

	/// <summary>
	/// Gets or sets the translation for Chinese.
	/// </summary>
	/// <value>The Chinese translation.</value>
	[DataMember(Name = "cn")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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
	[DataMember(Name = "de")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("de")]
	public string De { get; set; }

	/// <summary>
	/// Gets or sets the translation for Spanish. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Spanish translation.</value>
	[DataMember(Name = "es")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("es")]
	public string Es { get; set; }

	/// <summary>
	/// Gets or sets the translation for Persian. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Persian translation.</value>
	[DataMember(Name = "fa")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("fa")]
	public string Fa { get; set; }

	/// <summary>
	/// Gets or sets the translation for French. Null values will not be written during serialization.
	/// </summary>
	/// <value>The French translation.</value>
	[DataMember(Name = "fr")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("fr")]
	public string Fr { get; set; }

	/// <summary>
	/// Gets or sets the translation for Croatian. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Croatian translation.</value>
	[DataMember(Name = "hr")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("hr")]
	public string Hr { get; set; }

	/// <summary>
	/// Gets or sets the translation for Italian. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Italian translation.</value>
	[DataMember(Name = "it")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("it")]
	public string It { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the translation for Japanese. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Japanese translation.</value>
	[DataMember(Name = "ja")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("ja")]
	public string Ja { get; set; }

	/// <summary>
	/// Gets or sets the translation for Korean.
	/// </summary>
	/// <value>The Korean translation.</value>
	[DataMember(Name = "kr")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("kr")]
	public string Kr { get; set; }

	/// <summary>
	/// Gets or sets the translation for Dutch. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Dutch translation.</value>
	[DataMember(Name = "nl")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("nl")]
	public string Nl { get; set; }

	/// <summary>
	/// Gets or sets the translation for Portuguese. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Portuguese translation.</value>
	[DataMember(Name = "pt")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("pt")]
	public string Pt { get; set; }

	/// <summary>
	/// Gets or sets the translation for Brazilian Portuguese. Null values will not be written during serialization.
	/// </summary>
	/// <value>The Brazilian Portuguese translation.</value>
	[DataMember(Name = "pt-BR")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("pt-BR")]
	public string PtBr { get; set; }

	/// <summary>
	/// Gets or sets the translation for Turkish.
	/// </summary>
	/// <value>The Turkish translation.</value>
	[DataMember(Name = "tr")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("tr")]
	public string Tr { get; set; }

}
