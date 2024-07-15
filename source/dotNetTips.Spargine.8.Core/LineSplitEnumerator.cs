// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-05-2022
//
// Last Modified By : David McCarter
// Last Modified On : 06-27-2024
// ***********************************************************************
// <copyright file="LineSplitEnumerator.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class to enumerate a line split.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )








namespace DotNetTips.Spargine.Core;

/// <summary>
/// Initializes a new instance of the <see cref="LineSplitEnumerator"/> struct for splitting a string into lines.
/// </summary>
/// <param name="input">The input string to be split into lines.</param>
[Information(nameof(LineSplitEnumerator), "David McCarter", "6/9/2022", Status = Status.Available, Documentation = "https://www.meziantou.net/split-a-string-into-lines-without-allocation.htm")]
public ref struct LineSplitEnumerator(ReadOnlySpan<char> input)
{

	/// <summary>
	/// Gets the enumerator itself, required to support the foreach loop semantics.
	/// </summary>
	/// <returns>The <see cref="LineSplitEnumerator"/> instance.</returns>
	public readonly LineSplitEnumerator GetEnumerator() => this;

	/// <summary>
	/// Advances the enumerator to the next line in the input string.
	/// </summary>
	/// <returns><c>true</c> if the enumerator was successfully advanced to the next line; <c>false</c> if the enumerator has passed the end of the collection.</returns>
	public bool MoveNext()
	{
		var span = this._string;

		if (span.Length == 0) // Reach the end of the string
		{
			return false;
		}

		var index = span.IndexOfAny('\r', '\n');

		if (index == -1) // The string is composed of only one line
		{
			this._string = ReadOnlySpan<char>.Empty; // The remaining string is an empty string
			this.Current = new LineSplitEntry(span, ReadOnlySpan<char>.Empty);

			return true;
		}

		ReadOnlySpan<char> lineEndSpan;
		var lineEndLength = 1;

		if (index < span.Length - 1 && span[index] == '\r' && span[index + 1] == '\n')
		{
			lineEndSpan = span.Slice(index, 2);
			lineEndLength = 2;
		}
		else
		{
			lineEndSpan = span.Slice(index, 1);
		}

		this.Current = new LineSplitEntry(span[..index], lineEndSpan);
		this._string = span[(index + lineEndLength)..];

		return true;
	}

	/// <summary>
	/// Gets the current line in the input string being enumerated.
	/// </summary>
	/// <value>The current line as a <see cref="LineSplitEntry"/>.</value>
	public LineSplitEntry Current { get; private set; } = default;

	/// <summary>
	/// The input string represented as a ReadOnlySpan.
	/// </summary>
	private ReadOnlySpan<char> _string = input;

}
