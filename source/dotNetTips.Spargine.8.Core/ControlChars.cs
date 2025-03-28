// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="ControlChars.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Contains frequently used strings and characters, including backslash,
// comma, dash, double quote, empty string, forward slash, quote, space,
// tab, underscore, and more.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a collection of control characters and frequently used strings for convenience.
/// </summary>
/// <remarks>
/// This class contains constants for various control characters and strings that are commonly used in programming,
/// such as new line characters, space, tab, and special punctuation marks. It simplifies the use of these characters
/// by providing them as ready-to-use constants, avoiding the need for magic strings or characters throughout the code.
/// </remarks>
[Information(Status = Status.Available)]
public static class ControlChars
{
	/// <summary>
	/// The ampersand character.
	/// </summary>
	public const char Ampersand = '&';

	/// <summary>
	/// The asterisk character (*).
	/// </summary>
	public const char Asterisk = '*';

	/// <summary>
	/// The at symbol (@).
	/// </summary>
	public const char At = '@';

	/// <summary>
	/// The backspace character.
	/// </summary>
	public const char Back = '\b';

	/// <summary>
	/// The backslash character (\).
	/// </summary>
	public const char Backslash = '\\';

	/// <summary>
	/// The back tick character (`).
	/// </summary>
	public const char BackTick = '`';

	/// <summary>
	/// The colon character (:).
	/// </summary>
	public const char Colon = ':';

	/// <summary>
	/// The comma character (,).
	/// </summary>
	public const char Comma = ',';

	/// <summary>
	/// A comma followed by a space.
	/// </summary>
	public const string CommaSpace = ", ";

	/// <summary>
	/// The carriage return character.
	/// </summary>
	public const char CR = '\r';

	/// <summary>
	/// The carriage return and line feed sequence (\r\n).
	/// </summary>
	public const string CRLF = "\r\n";

	/// <summary>
	/// The dash character (-).
	/// </summary>
	public const char Dash = '-';

	/// <summary>
	/// The default separator, a comma followed by a space.
	/// </summary>
	public const string DefaultSeparator = ", ";

	/// <summary>
	/// The dot (period) character (.).
	/// </summary>
	public const char Dot = '.';

	/// <summary>
	/// The double quote character (").
	/// </summary>
	public const string DoubleQuote = "''";

	/// <summary>
	/// An empty string.
	/// </summary>
	public const string EmptyString = "";

	/// <summary>
	/// The end angle bracket character (>).
	/// </summary>
	public const char EndAngleBracket = '>';

	/// <summary>
	/// The closing brace character (}).
	/// </summary>
	public const char EndBrace = '}';

	/// <summary>
	/// The end comment character ()).
	/// </summary>
	public const char EndComment = ')';

	/// <summary>
	/// The end square bracket character (]).
	/// </summary>
	public const char EndSquareBracket = ']';

	/// <summary>
	/// The equal symbol (=).
	/// </summary>
	public const char Equal = '=';

	/// <summary>
	/// The Escape character (ESC), ASCII value 27.
	/// </summary>
	public const char Escape = (char)27;

	/// <summary>
	/// The exclamation mark character (!).
	/// </summary>
	public const char ExclamationMark = '!';

	/// <summary>
	/// The form feed character.
	/// </summary>
	public const char FormFeed = '\f';

	/// <summary>
	/// The forward slash character (/).
	/// </summary>
	public const char ForwardSlash = '/';

	/// <summary>
	/// The line feed character.
	/// </summary>
	public const char LF = '\n';

	/// <summary>
	/// The new line character.
	/// </summary>
	public const char NewLine = '\n';

	/// <summary>
	/// The null character.
	/// </summary>
	public const char NullChar = '\0';

	/// <summary>
	/// The percent character (%).
	/// </summary>
	public const char Percent = '%';

	/// <summary>
	/// The pipe character (|).
	/// </summary>
	public const char Pipe = '|';

	/// <summary>
	/// The plus character (+).
	/// </summary>
	public const char Plus = '+';

	/// <summary>
	/// The question mark character (?).
	/// </summary>
	public const char QuestionMark = '?';

	/// <summary>
	/// The quote character (").
	/// </summary>
	public const char Quote = '\"';

	/// <summary>
	/// The semicolon character (;).
	/// </summary>
	public const char Semicolon = ';';

	/// <summary>
	/// The single quote character (').
	/// </summary>
	public const char SingleQuote = '\'';

	/// <summary>
	/// The space character.
	/// </summary>
	public const char Space = ' ';

	/// <summary>
	/// The start angle bracket character.
	/// </summary>
	public const char StartAngleBracket = '<';

	/// <summary>
	/// The opening brace character ({).
	/// </summary>
	public const char StartBrace = '{';

	/// <summary>
	/// The start comment character (()).
	/// </summary>
	public const char StartComment = '(';

	/// <summary>
	/// The start square bracket character ([).
	/// </summary>
	public const char StartSquareBracket = '[';

	/// <summary>
	/// The tab character.
	/// </summary>
	public const char Tab = '\t';

	/// <summary>
	/// The tilde character (~).
	/// </summary>
	public const char Tilde = '~';

	/// <summary>
	/// The underscore character (_).
	/// </summary>
	public const char Underscore = '_';

	/// <summary>
	/// The vertical tab character.
	/// </summary>
	public const char VerticalTab = '\v';

	/// <summary>
	/// Represents the wildcard pattern "*.*" used for matching all files.
	/// </summary>
	public const string WildcardAllFiles = "*.*";

}
