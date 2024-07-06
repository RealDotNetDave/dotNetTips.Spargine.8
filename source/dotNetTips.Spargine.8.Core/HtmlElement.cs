// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-03-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="HtmlElement.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common HTML elements and characters</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )







namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides constants for common HTML elements and characters.
/// </summary>
[Information(nameof(HtmlElement), "David McCarter", "1/3/2023", Status = Status.Available)]
public static class HtmlElement
{

	/// <summary>
	/// The list item end tag (&lt;/li&gt;).
	/// </summary>
	public const string ListItemEnd = "</li>";

	/// <summary>
	/// The list item start tag (&lt;li&gt;).
	/// </summary>
	public const string ListItemStart = "<li>";

	/// <summary>
	/// The ordered list element end tag (&lt;/ol&gt;).
	/// </summary>
	public const string OrderedListElementEnd = "</ol>";

	/// <summary>
	/// The ordered list element start tag (&lt;ol&gt;).
	/// </summary>
	public const string OrderedListElementStart = "<ol>";

	/// <summary>
	/// Represents the HTML quote character entity (&quot;).
	/// </summary>
	public const string Quote = "&quot;";

	/// <summary>
	/// Represents the HTML non-breaking space character entity.
	/// </summary>
	public const string Space = "&nbsp;";

	/// <summary>
	/// The table data row element end tag (&lt;/td&gt;).
	/// </summary>
	public const string TableDataRowElementEnd = "</td>";

	/// <summary>
	/// The table data row element start tag (&lt;td&gt;).
	/// </summary>
	public const string TableDataRowElementStart = "<td>";

	/// <summary>
	/// The unordered list element end tag (&lt;/ul&gt;).
	/// </summary>
	public const string UnorderedListElementEnd = "</ul>";

	/// <summary>
	/// The unordered list element start tag (&lt;ul&gt;).
	/// </summary>
	public const string UnorderedListElementStart = "<ul>";

}
