// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 03-20-2023
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="ProcessorInformation.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.InteropServices;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Struct ProcessorInformation
/// </summary>
public struct ProcessorInformation : IEquatable<ProcessorInformation>
{

	/// <summary>
	/// Implements the != operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !=(ProcessorInformation left, ProcessorInformation right) => !(left == right);

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(ProcessorInformation left, ProcessorInformation right) => left.Equals(right);

	/// <summary>
	/// Determines whether the specified <see cref="object" /> is equal to this instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
	public override readonly bool Equals(object obj) => obj is ProcessorInformation information && this.Equals(information);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public readonly bool Equals(ProcessorInformation other) => this.PageSize == other.PageSize && this.MinimumApplicationAddress.Equals(other.MinimumApplicationAddress) && this.MaximumApplicationAddress.Equals(other.MaximumApplicationAddress) && this.ActiveProcessorMask.Equals(other.ActiveProcessorMask) && this.NumberOfProcessors == other.NumberOfProcessors && this.ProcessorArchitecture == other.ProcessorArchitecture && this.AllocationGranularity == other.AllocationGranularity && this.ProcessorLevel == other.ProcessorLevel && this.ProcessorRevision == other.ProcessorRevision && this.PageSize == other.PageSize && this.MinimumApplicationAddress.Equals(other.MinimumApplicationAddress) && this.MaximumApplicationAddress.Equals(other.MaximumApplicationAddress) && this.ActiveProcessorMask.Equals(other.ActiveProcessorMask) && this.NumberOfProcessors == other.NumberOfProcessors && this.ProcessorArchitecture == other.ProcessorArchitecture && this.AllocationGranularity == other.AllocationGranularity && this.ProcessorLevel == other.ProcessorLevel && this.ProcessorRevision == other.ProcessorRevision;

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
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