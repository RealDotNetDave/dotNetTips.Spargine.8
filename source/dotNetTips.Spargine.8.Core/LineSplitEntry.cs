// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-05-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="LineSplitEntry.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Used to supply information about line and separator details for a
// line split.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Struct LineSplitEntry
/// </summary>
/// <param name="line">The line.</param>
/// <param name="separator">The separator.</param>
/// <remarks>Initializes a new instance of the <see cref="LineSplitEntry" /> struct.</remarks>
[Information(nameof(LineSplitEntry), "David McCarter", "6/9/2022", Status = Status.Available, Documentation = "https://www.meziantou.net/split-a-string-into-lines-without-allocation.htm")]
public readonly ref struct LineSplitEntry(ReadOnlySpan<char> line, ReadOnlySpan<char> separator)
{

	// This method allow to implicitly cast the type into a ReadOnlySpan<char>, so you can write the following code
	// foreach (ReadOnlySpan<char> entry in str.SplitLines())
	/// <summary>
	/// Performs an implicit conversion from <see cref="LineSplitEntry" /> to <see cref="ReadOnlySpan{Char}" />.
	/// </summary>
	/// <param name="entry">The entry.</param>
	/// <returns>The result of the conversion.</returns>
	public static implicit operator ReadOnlySpan<char>(LineSplitEntry entry) => entry.Line;

	// This method allow to deconstruct the type, so you can write any of the following code
	// foreach (var entry in str.SplitLines()) { _ = entry.Line; }
	// foreach (var (line, endOfLine) in str.SplitLines()) { _ = line; }
	// https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct?WT.mc_id=DT-MVP-5003978#deconstructing-user-defined-types
	/// <summary>
	/// Deconstructs the specified line.
	/// </summary>
	/// <param name="line">The line.</param>
	/// <param name="separator">The separator.</param>
	public void Deconstruct(out ReadOnlySpan<char> line, out ReadOnlySpan<char> separator)
	{
		line = this.Line;
		separator = this.Separator;
	}

	// This method allow to implicitly cast the type into a ReadOnlySpan<char>.
	/// <summary>
	/// Performs an implicit conversion from <see cref="LineSplitEntry" /> to <see cref="ReadOnlySpan{Char}" />.
	/// </summary>
	/// <param name="entry">The entry.</param>
	/// <returns>The result of the conversion.</returns>
	public static ReadOnlySpan<char> ToReadOnlySpan(LineSplitEntry entry) => entry.Line;

	/// <summary>
	/// Gets the line.
	/// </summary>
	/// <value>The line.</value>
	public ReadOnlySpan<char> Line { get; } = line;

	/// <summary>
	/// Gets the separator.
	/// </summary>
	/// <value>The separator.</value>
	public ReadOnlySpan<char> Separator { get; } = separator;

}
