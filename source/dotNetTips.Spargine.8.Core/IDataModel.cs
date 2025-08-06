// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 02-05-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-12-2025
// ***********************************************************************
// <copyright file="IDataModel.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Interface designed for model classes, enforcing the implementation of
// the "Id" property, which is mandatory.
// </summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines a generic data model with a unique identifier, supporting comparison and equality checks.
/// </summary>
/// <typeparam name="T">The type of the data model implementing this interface.</typeparam>
/// <typeparam name="TKey">The type of the identifier for the data model.</typeparam>
/// <seealso cref="IComparable{T}" />
/// <seealso cref="IEquatable{T}" />
[Information(Status = Status.NeedsDocumentation)]
public interface IDataModel<T, TKey> : IComparable<T>, IEquatable<T>
{
	/// <summary>
	/// Gets or sets the unique identifier for the data model.
	/// </summary>
	/// <value>The unique identifier of the data model.</value>
	/// <remarks>
	/// The identifier is required and must be between 10 to 50 characters.
	/// </remarks>
	[Required(ErrorMessage = "Id is required.")]
	[MaxLength(50, ErrorMessage = "Id must be a maximum of 50 characters.")]
	[MinLength(10, ErrorMessage = "Id must be at least 10 characters.")]
	[DisallowNull]
	public TKey Id { get; init; }

}
