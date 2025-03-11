// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-05-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="LineSplitEntry.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Used to supply information about line and separator details for a
// line split.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents an entry in a line split operation, containing both the line and its trailing separator.
/// </summary>
/// <param name="line">The content of the line, excluding any line terminator.</param>
/// <param name="separator">The line terminator found after the line content.</param>
/// <remarks>
/// This struct is useful for iterating over lines in a string while preserving information about line terminators.
/// </remarks>
[Information(nameof(LineSplitEntry), "David McCarter", "6/9/2022", Status = Status.Available, Documentation = "https://www.meziantou.net/split-a-string-into-lines-without-allocation.htm")]
public readonly ref struct LineSplitEntry(ReadOnlySpan<char> line, ReadOnlySpan<char> separator)
{

	/// <summary>
	/// Performs an implicit conversion from <see cref="LineSplitEntry"/> to <see cref="ReadOnlySpan{Char}"/>.
	/// This allows the line content to be used directly as a ReadOnlySpan&lt;char&gt;.
	/// </summary>
	/// <param name="entry">The line split entry.</param>
	/// <returns>The line content as a ReadOnlySpan&lt;char&gt;.</returns>
	[Information(Status = Status.Available)]
	public static implicit operator ReadOnlySpan<char>(LineSplitEntry entry) => entry.Line;

	/// <summary>
	/// Deconstructs this instance into its line and separator components.
	/// </summary>
	/// <param name="line">When this method returns, contains the line content.</param>
	/// <param name="separator">When this method returns, contains the line terminator.</param>
	[Information(nameof(Deconstruct), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public void Deconstruct(out ReadOnlySpan<char> line, out ReadOnlySpan<char> separator)
	{
		line = this.Line;
		separator = this.Separator;
	}

	/// <summary>
	/// Converts the <see cref="LineSplitEntry"/> to a <see cref="ReadOnlySpan{Char}"/> representing the line content.
	/// </summary>
	/// <param name="entry">The line split entry.</param>
	/// <returns>A <see cref="ReadOnlySpan{Char}"/> that contains the line content.</returns>
	[Information(nameof(ToReadOnlySpan), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlySpan<char> ToReadOnlySpan(LineSplitEntry entry) => entry.Line;

	/// <summary>
	/// Gets the content of the line, excluding any line terminator.
	/// </summary>
	/// <value>The line content.</value>
	[Information(nameof(Line), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ReadOnlySpan<char> Line { get; } = line;

	/// <summary>
	/// Gets the line terminator found after the line content.
	/// </summary>
	/// <value>The line terminator.</value>
	[Information(nameof(Separator), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ReadOnlySpan<char> Separator { get; } = separator;

}
