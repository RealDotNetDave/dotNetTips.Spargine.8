// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-13-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2025
// ***********************************************************************
// <copyright file="ExceptionThrower.Create.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

public static partial class ExceptionThrower
{
	/// <summary>
	/// Creates a <see cref="FileNotFoundException"/> with a specified file name.
	/// </summary>
	/// <param name="fileName">The name of the file that was not found.</param>
	/// <returns>A <see cref="FileNotFoundException"/> instance.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(CreateFileNotFoundException), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static FileNotFoundException CreateFileNotFoundException([NotNull] string fileName) => new(Resources.ErrorFileNotFound, fileName);

	/// <summary>
	/// Creates a <see cref="FileNotFoundException"/> with a specified message and file name.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="fileName">The name of the file that was not found.</param>
	/// <returns>A <see cref="FileNotFoundException"/> instance.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(CreateFileNotFoundException), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static FileNotFoundException CreateFileNotFoundException([AllowNull] string message, [NotNull] string fileName) => new(message ?? Resources.ErrorFileNotFound, fileName);

	/// <summary>
	/// Creates a <see cref="FileNotFoundException"/> with a specified message, file name, and inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="fileName">The name of the file that was not found.</param>
	/// <param name="ex">The exception that is the cause of the current exception.</param>
	/// <returns>A <see cref="FileNotFoundException"/> instance.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(CreateFileNotFoundException), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static FileNotFoundException CreateFileNotFoundException([AllowNull] string message, [NotNull] string fileName, Exception ex) => new(message ?? Resources.ErrorFileNotFound, fileName, ex);
}
