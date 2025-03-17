// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-20-2023
//
// Last Modified By : David McCarter
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="ProcessorInformation.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Utility to retrieve information about the computer processor.</summary>
// ***********************************************************************
using System.Runtime.InteropServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents information about the computer's processor, including details such as the number of processors, processor architecture, and page size.
/// </summary>
[Information(Status = Status.Available)]
public struct ProcessorInformation : IEquatable<ProcessorInformation>
{

	/// <summary>
	/// Implements the inequality operator. Checks whether two <see cref="ProcessorInformation"/> instances are not equal.
	/// </summary>
	/// <param name="left">The first instance to compare.</param>
	/// <param name="right">The second instance to compare.</param>
	/// <returns><c>true</c> if the instances are not equal; otherwise, <c>false</c>.</returns>
	[Information("!=", Status = Status.Available)]
	public static bool operator !=(ProcessorInformation left, ProcessorInformation right) => !(left == right);

	/// <summary>
	/// Implements the equality operator. Checks whether two <see cref="ProcessorInformation"/> instances are equal.
	/// </summary>
	/// <param name="left">The first instance to compare.</param>
	/// <param name="right">The second instance to compare.</param>
	/// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
	[Information("==", Status = Status.Available)]
	public static bool operator ==(ProcessorInformation left, ProcessorInformation right) => left.Equals(right);

	/// <summary>
	/// Determines whether the specified object is equal to the current <see cref="ProcessorInformation"/> instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified object is equal to the current instance; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), Status = Status.Available)]
	public override readonly bool Equals(object obj) => obj is ProcessorInformation information && this.Equals(information);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><c>true</c> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public readonly bool Equals(ProcessorInformation other)
	{
		return this.PageSize == other.PageSize && this.MinimumApplicationAddress.Equals(other.MinimumApplicationAddress) && this.MaximumApplicationAddress.Equals(other.MaximumApplicationAddress) && this.ActiveProcessorMask.Equals(other.ActiveProcessorMask) && this.NumberOfProcessors == other.NumberOfProcessors && this.ProcessorArchitecture == other.ProcessorArchitecture && this.AllocationGranularity == other.AllocationGranularity && this.ProcessorLevel == other.ProcessorLevel && this.ProcessorRevision == other.ProcessorRevision;
	}

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	[Information(nameof(GetHashCode), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public override readonly int GetHashCode()
	{
		var hash = new HashCode();
		hash.Add(this.PageSize);
		hash.Add(this.MinimumApplicationAddress);
		hash.Add(this.MaximumApplicationAddress);
		hash.Add(this.ActiveProcessorMask);
		hash.Add(this.NumberOfProcessors);
		hash.Add(this.ProcessorArchitecture);
		hash.Add(this.AllocationGranularity);
		hash.Add(this.ProcessorLevel);
		hash.Add(this.ProcessorRevision);
		return hash.ToHashCode();
	}

	/// <summary>
	/// Gets the active processor mask.
	/// </summary>
	/// <value>The active processor mask.</value>
	public nint ActiveProcessorMask { get; internal set; }

	/// <summary>
	/// Gets the allocation granularity.
	/// </summary>
	/// <value>The allocation granularity.</value>
	public int AllocationGranularity { get; internal set; }

	/// <summary>
	/// Gets the maximum application address.
	/// </summary>
	/// <value>The maximum application address.</value>
	public nint MaximumApplicationAddress { get; internal set; }

	/// <summary>
	/// Gets the minimum application address.
	/// </summary>
	/// <value>The minimum application address.</value>
	public nint MinimumApplicationAddress { get; internal set; }

	/// <summary>
	/// Gets the number of processors.
	/// </summary>
	/// <value>The number of processors.</value>
	public int NumberOfProcessors { get; internal set; }

	/// <summary>
	/// Gets the size of the page.
	/// </summary>
	/// <value>The size of the page.</value>
	public int PageSize { get; internal set; }

	/// <summary>
	/// Gets the processor architecture.
	/// </summary>
	/// <value>The processor architecture.</value>
	public Architecture ProcessorArchitecture { get; internal set; }

	/// <summary>
	/// Gets the processor level.
	/// </summary>
	/// <value>The processor level.</value>
	public int ProcessorLevel { get; internal set; }

	/// <summary>
	/// Gets the processor revision.
	/// </summary>
	/// <value>The processor revision.</value>
	public int ProcessorRevision { get; internal set; }

}
