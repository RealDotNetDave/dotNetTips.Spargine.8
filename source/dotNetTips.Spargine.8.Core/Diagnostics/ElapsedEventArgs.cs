// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 05-08-2025
//
// Last Modified By : David McCarter
// Last Modified On : 05-08-2025
// ***********************************************************************
// <copyright file="ElapsedEventArgs.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )



namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// Provides data for events that report elapsed time.
/// </summary>
[Information(nameof(ElapsedEventArgs), "David McCarter", "05/08/2025", Status = Status.New)]
public class ElapsedEventArgs : EventArgs
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ElapsedEventArgs"/> class.
	/// </summary>
	/// <param name="elapsed">The elapsed time.</param>
	[Information(nameof(ElapsedEventArgs), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public ElapsedEventArgs(TimeSpan elapsed)
	{
		this.Elapsed = elapsed;
	}

	/// <summary>
	/// Gets the elapsed time.
	/// </summary>
	/// <value>The time span representing the elapsed time.</value>
	[Information(nameof(Elapsed), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public TimeSpan Elapsed { get; }
}
