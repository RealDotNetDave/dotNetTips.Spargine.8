// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-03-2023
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2024
// ***********************************************************************
// <copyright file="HtmlElement.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common HTML elements and characters</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )



namespace DotNetTips.Spargine.Core;

/// <summary>
/// HtmlElement's.
/// </summary>
[Information(nameof(HtmlElement), "David McCarter", "1/3/2023", UnitTestCoverage = 0, Status = Status.Available)]
public static class HtmlElement
{

	/// <summary>
	/// The list item end (&lt; /li &gt;).
	/// </summary>
	public const string ListItemEnd = "</li>";

	/// <summary>
	/// The list item start (&lt;li &gt;).
	/// </summary>
	public const string ListItemStart = "<li>";

	/// <summary>
	/// The ordered list element end (&lt;/ol &gt;).
	/// </summary>
	public const string OrderedListElementEnd = "</ol>";

	/// <summary>
	/// The ordered list element start (&lt;ol &gt;).
	/// </summary>
	public const string OrderedListElementStart = "<ol>";

	/// <summary>
	/// Quote
	/// </summary>
	public const string Quote = "&quot;";

	/// <summary>
	/// Space
	/// </summary>
	public const string Space = "&nbsp;";

	/// <summary>
	/// The table data row element end (&lt;/td &gt;)
	/// </summary>
	public const string TableDataRowElementEnd = "</td>";

	/// <summary>
	/// The table data row element start (&lt;td &gt;)
	/// </summary>
	public const string TableDataRowElementStart = "<td>";

	/// <summary>
	/// The unordered list element end  (&lt;/ul &gt;).
	/// </summary>
	public const string UnorderedListElementEnd = "</ul>";

	/// <summary>
	/// The unordered list element start (&lt;ul &gt;).
	/// </summary>
	public const string UnorderedListElementStart = "<ul>";

}
