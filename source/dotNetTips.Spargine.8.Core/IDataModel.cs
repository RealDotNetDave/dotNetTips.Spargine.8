// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 02-05-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2024
// ***********************************************************************
// <copyright file="IDataModel.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Interface designed for model classes, enforcing the implementation of the "Id" property, which is mandatory.</summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Internal;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Interface IDataModel to ensure all types have an Id property.
/// Implements the <see cref="IComparable{T}" />
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
/// <typeparam name="TKey">The type of the t key.</typeparam>
/// <seealso cref="IComparable{T}" />
public interface IDataModel<T, TKey> : IComparable<T>, IEquatable<T>
{

	/// <summary>
	/// Alls the properties to string.
	/// </summary>
	/// <returns>System.String.</returns>
	public string AllPropertiesToString() => this.PropertiesToString();

	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	//[Required]
	[MaxLength(length: 50, ErrorMessage = "Id must be 10 characters to a max of 50.")]
	[MinLength(length: 10, ErrorMessage = "Id must be 10 characters to a max of 50.")]
	[DisallowNull]
	TKey Id { get; init; }

}
