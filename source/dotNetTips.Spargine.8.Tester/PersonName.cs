
// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-15-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2023
// ***********************************************************************
// <copyright file="PersonName.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Class PersonName.
/// </summary>
[Serializable]
public sealed record PersonName
{

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonName" /> class.
	/// </summary>
	public PersonName()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonName" /> class.
	/// </summary>
	/// <param name="firstName">The first name.</param>
	/// <param name="lastName">The last name.</param>
	public PersonName(string firstName, string lastName)
	{
		this.FirstName = firstName;
		this.LastName = lastName;
	}

	/// <summary>
	/// Gets the first name.
	/// </summary>
	/// <value>The first name.</value>
	public string FirstName { get; init; }

	/// <summary>
	/// Gets the full name.
	/// </summary>
	/// <value>The full name.</value>
	public string FullName => $"{this.FirstName}{ControlChars.Space}{this.LastName}";

	/// <summary>
	/// Gets the last name.
	/// </summary>
	/// <value>The last name.</value>
	public string LastName { get; init; }

}
