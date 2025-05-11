// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 05-08-2025
//
// Last Modified By : David McCarter
// Last Modified On : 05-09-2025
// ***********************************************************************
// <copyright file="DiagnosticEntry.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// Represents a single diagnostic message entry.
/// </summary>
[Information("DiagnosticEntry", "David McCarter", "05/08/2025", Status = Status.New)]
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public readonly struct DiagnosticEntry : IEquatable<DiagnosticEntry>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DiagnosticEntry"/> struct.
	/// </summary>
	/// <param name="timestamp">The UTC timestamp of the message.</param>
	/// <param name="message">The content of the message.</param>
	/// <param name="elapsed">The elapsed time when recorded.</param>
	[Information(nameof(DiagnosticEntry), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public DiagnosticEntry([NotNull] DateTimeOffset timestamp, [NotNull] string message, [NotNull] TimeSpan elapsed)
	{
		this.Timestamp = timestamp;
		this.Message = message?.Trim();
		this.Elapsed = elapsed;
	}

	/// <summary>
	/// Determines whether two <see cref="DiagnosticEntry"/> instances are not equal.
	/// </summary>
	/// <param name="left">The first <see cref="DiagnosticEntry"/> to compare.</param>
	/// <param name="right">The second <see cref="DiagnosticEntry"/> to compare.</param>
	/// <returns>
	/// <c>true</c> if the two <see cref="DiagnosticEntry"/> instances are not equal; otherwise, <c>false</c>.
	/// </returns>
	public static bool operator !=(DiagnosticEntry left, DiagnosticEntry right)
	{
		return !(left == right);
	}

	/// <summary>
	/// Determines whether two <see cref="DiagnosticEntry"/> instances are equal.
	/// </summary>
	/// <param name="left">The first <see cref="DiagnosticEntry"/> to compare.</param>
	/// <param name="right">The second <see cref="DiagnosticEntry"/> to compare.</param>
	/// <returns>
	/// <c>true</c> if the two <see cref="DiagnosticEntry"/> instances are equal; otherwise, <c>false</c>.
	/// </returns>
	public static bool operator ==(DiagnosticEntry left, DiagnosticEntry right)
	{
		return left.Equals(right);
	}

	private string GetDebuggerDisplay()
	{
		return this.ToString();
	}

	/// <summary>
	/// Determines whether the specified object is equal to the current <see cref="DiagnosticEntry"/>.
	/// </summary>
	/// <param name="obj">The object to compare with the current <see cref="DiagnosticEntry"/>.</param>
	/// <returns>
	/// <c>true</c> if the specified object is equal to the current <see cref="DiagnosticEntry"/>; otherwise, <c>false</c>.
	/// </returns>
	[Information(nameof(Equals), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public override bool Equals(object obj)
	{
		return obj is DiagnosticEntry other && this.Equals(other);
	}

	/// <summary>
	/// Determines whether the specified <see cref="DiagnosticEntry"/> is equal to the current <see cref="DiagnosticEntry"/>.
	/// </summary>
	/// <param name="other">The <see cref="DiagnosticEntry"/> to compare with the current instance.</param>
	/// <returns>
	/// <c>true</c> if the specified <see cref="DiagnosticEntry"/> is equal to the current instance; otherwise, <c>false</c>.
	/// </returns>
	[Information(nameof(Equals), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public bool Equals(DiagnosticEntry other)
	{
		return this.Timestamp == other.Timestamp && string.Equals(this.Message, other.Message, StringComparison.Ordinal) && this.Elapsed == other.Elapsed;
	}

	/// <summary>
	/// Returns a hash code for the current <see cref="DiagnosticEntry"/>.
	/// </summary>
	/// <returns>
	/// A hash code for the current <see cref="DiagnosticEntry"/>.
	/// </returns>
	[Information(nameof(GetHashCode), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public override int GetHashCode()
	{
		return HashCode.Combine(this.Timestamp, this.Message, this.Elapsed);
	}

	/// <summary>
	/// Returns a string representation of the diagnostic entry.
	/// </summary>
	/// <returns>A string representation of the diagnostic entry.</returns>
	[Information(nameof(ToString), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public override string ToString()
	{
		return $"{this.Timestamp:u} - {this.Message} ({this.Elapsed.TotalMilliseconds} ms)";
	}

	/// <summary>
	/// Gets the elapsed time when the diagnostic entry was recorded.
	/// </summary>
	[Information(nameof(Elapsed), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public TimeSpan Elapsed { get; }

	/// <summary>
	/// Gets the content of the diagnostic message.
	/// </summary>
	[Information(nameof(Message), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public string Message { get; }

	/// <summary>
	/// Gets the UTC timestamp of the diagnostic entry.
	/// </summary>
	[Information(nameof(Timestamp), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public DateTimeOffset Timestamp { get; }
}
