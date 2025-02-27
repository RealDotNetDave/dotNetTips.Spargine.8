// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-15-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="PersonName.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Class that contains the first name, last name, and full name for
// a person.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
using System.Diagnostics;
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Represents a person's name, including first name, last name, and full name.
/// </summary>
[DataContract(Name = "PersonName", Namespace = "http://DotNetTips.Spargine.Tester")]
[DebuggerDisplay("{FullName}")]
[Serializable]
public sealed record PersonName
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PersonName"/> class.
	/// </summary>
	[Information(nameof(PersonName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public PersonName()
	{
		this.FirstName = string.Empty;
		this.LastName = string.Empty;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonName"/> class with specified first and last names.
	/// </summary>
	/// <param name="firstName">The first name.</param>
	/// <param name="lastName">The last name.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="firstName"/> or <paramref name="lastName"/> is null.</exception>
	[Information(nameof(PersonName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public PersonName(string firstName, string lastName)
	{
		this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
		this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
	}

	/// <summary>
	/// Gets the first name.
	/// </summary>
	/// <value>The first name.</value>
	[DataMember(Order = 1)]
	[Information(nameof(FirstName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FirstName { get; init; }

	/// <summary>
	/// Gets the full name, constructed from <see cref="FirstName"/> and <see cref="LastName"/>.
	/// </summary>
	/// <value>The full name.</value>
	[Information(nameof(FullName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FullName => $"{this.FirstName} {this.LastName}";

	/// <summary>
	/// Gets the last name.
	/// </summary>
	/// <value>The last name.</value>
	[DataMember(Order = 2)]
	[Information(nameof(LastName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string LastName { get; init; }
}
