// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-05-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-08-2024
// ***********************************************************************
// <copyright file="LineSplitEnumerator.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Class to enumerate a line split.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )



namespace DotNetTips.Spargine.Core;

// Must be a ref struct as it contains a ReadOnlySpan<char>
/// <summary>
/// Struct LineSplitEnumerator
/// </summary>
/// <param name="input">The string.</param>
/// <remarks>Initializes a new instance of the <see cref="LineSplitEnumerator" /> struct.</remarks>
[Information(nameof(LineSplitEnumerator), "David McCarter", "6/9/2022", Status = Status.Available, Documentation = "https://www.meziantou.net/split-a-string-into-lines-without-allocation.htm")]
public ref struct LineSplitEnumerator(ReadOnlySpan<char> input)
{

	// Needed to be compatible with the foreach operator
	/// <summary>
	/// Gets the enumerator.
	/// </summary>
	/// <returns>LineSplitEnumerator.</returns>
	public readonly LineSplitEnumerator GetEnumerator() => this;

	/// <summary>
	/// Moves the next.
	/// </summary>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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

		if (index < span.Length - 1 && span[index] == '\r')
		{
			// Try to consume the '\n' associated to the '\r'
			var next = span[index + 1];

			if (next == '\n')
			{
				this.Current = new LineSplitEntry(span[..index], span.Slice(index, 2));

				this._string = span[(index + 2)..];

				return true;
			}
		}

		this.Current = new LineSplitEntry(span[..index], span.Slice(index, 1));

		this._string = span[(index + 1)..];

		return true;
	}

	/// <summary>
	/// Gets the current line.
	/// </summary>
	/// <value>The current.</value>
	public LineSplitEntry Current { get; private set; } = default;

	/// <summary>
	/// The string
	/// </summary>
	private ReadOnlySpan<char> _string = input;

}
