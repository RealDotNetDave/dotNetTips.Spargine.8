// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="InformationAttribute.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Attribute that enables the addition of informational data to methods.
// Properties include Author, BenchMarkStatus, CreatedOn, Description,
// Documentation, ModifiedBy, ModifiedOn, Status, UnitTestCoverage.
// </summary>
// ***********************************************************************
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Attribute that enables the addition of informational data to methods, classes, and other members.
/// This includes authorship, creation and modification dates, documentation links, and more.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate, Inherited = false)]
public sealed class InformationAttribute : Attribute
{

	/// <summary>
	/// The unit test coverage
	/// </summary>
	private int _unitTestCoverage;

	/// <summary>
	/// Initializes a new instance of the <see cref="InformationAttribute"/> class.
	/// </summary>
	public InformationAttribute()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InformationAttribute"/> class with a description.
	/// </summary>
	/// <param name="description">The description of the member this attribute is applied to.</param>
	public InformationAttribute(string description)
		: this(description, string.Empty, string.Empty, string.Empty)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InformationAttribute"/> class with a description, author, and creation date.
	/// </summary>
	/// <param name="description">The description of the member this attribute is applied to.</param>
	/// <param name="author">The author of the member.</param>
	/// <param name="createdOn">The creation date of the member.</param>
	public InformationAttribute(string description, string author, string createdOn)
		: this(description, author, createdOn, createdOn)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InformationAttribute"/> class with a description, author, creation date, and modification date.
	/// </summary>
	/// <param name="description">The description of the member this attribute is applied to.</param>
	/// <param name="author">The author of the member.</param>
	/// <param name="createdOn">The creation date of the member.</param>
	/// <param name="modifiedOn">The modification date of the member.</param>
	public InformationAttribute(string description, string author, string createdOn, string modifiedOn)
	{
		this.Description = description;
		this.Author = string.IsNullOrEmpty(author) ? Resources.UserUnknown : author;

		if (string.IsNullOrEmpty(createdOn) is false && DateTimeOffset.TryParse(createdOn, out var createdDate))
		{
			this.CreatedOn = createdDate;

			if (string.IsNullOrEmpty(modifiedOn) == DateTimeOffset.TryParse(modifiedOn, out var modifiedDate))
			{
				this.ModifiedOn = modifiedDate;
			}
		}

		if (string.IsNullOrEmpty(this.ModifiedBy))
		{
			this.ModifiedBy = author;
		}
	}

	/// <summary>
	/// Gets the author of the member.
	/// </summary>
	public string Author { get; }
	/// <summary>
	/// Gets or sets the benchmark status of the member.
	/// </summary>
	public BenchMarkStatus BenchMarkStatus { get; set; } = BenchMarkStatus.None;

	/// <summary>
	/// Gets the creation date of the member.
	/// </summary>
	public DateTimeOffset CreatedOn { get; set; }

	/// <summary>
	/// Gets the description of the member.
	/// </summary>
	public string Description { get; }

	/// <summary>
	/// Gets or sets the Uri for external documentation related to the member.
	/// </summary>
	public string Documentation { get; set; }

	/// <summary>
	/// Gets or sets the name of the person who last modified the member.
	/// </summary>
	public string ModifiedBy { get; set; }

	/// <summary>
	/// Gets the last modification date of the member.
	/// </summary>
	public DateTimeOffset ModifiedOn { get; private set; }

	/// <summary>
	/// Gets or sets the development status of the member.
	/// </summary>
	public Status Status { get; set; } = Status.NotSet;

	/// <summary>
	/// Gets or sets the unit test coverage percentage of the member.
	/// Must be between 0 - 100.
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not in the range of 0 - 100.</exception>
	public int UnitTestCoverage
	{
		get => this._unitTestCoverage;
		set
		{
			if (this._unitTestCoverage == value)
			{
				return;
			}

			if (value.CheckIsInRange(0, 100))
			{
				this._unitTestCoverage = value;
			}
			else
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException("Unit test coverage must be in the range of 0 - 100.");
			}
		}
	}

}
