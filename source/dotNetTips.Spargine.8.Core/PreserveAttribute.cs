// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="PreserveAttribute.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Attribute to make it easier to look at code and know that the code
// needs to be preserved due to one of the reasons in PreserveReason.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )






namespace DotNetTips.Spargine.Core;

/// <summary>
/// Attribute used to indicate that the associated code should be preserved during compilation or linking processes, typically for reasons specified in <see cref="PreserveReason"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate, Inherited = false)]
[Information(nameof(PreserveAttribute), "David McCarter", "2/7/2023", Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2023")]
public sealed class PreserveAttribute : Attribute
{

	/// <summary>
	/// Initializes a new instance of the <see cref="PreserveAttribute"/> class with a specified reason for preservation.
	/// </summary>
	/// <param name="reason">The reason why the associated code needs to be preserved.</param>
	public PreserveAttribute(string reason)
	: this(PreserveReason.None, reason, string.Empty, string.Empty)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PreserveAttribute"/> class with a specified reason for preservation, the date the reason was created, and the developer who created the reason.
	/// </summary>
	/// <param name="reason">The reason why the associated code needs to be preserved.</param>
	/// <param name="createdOn">The date when the reason was created, in a format that can be parsed by <see cref="DateTimeOffset.TryParse(string, out DateTimeOffset)"/>.</param>
	/// <param name="createdBy">The name of the developer who created the reason.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="createdBy"/> or <paramref name="reason"/> is null.</exception>
	public PreserveAttribute(string reason, string createdOn, string createdBy)
		: this(PreserveReason.None, reason, createdOn, createdBy)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PreserveAttribute"/> class with specified preservation details.
	/// </summary>
	/// <param name="preserveReason">The reason for preservation, as defined in <see cref="PreserveReason"/>.</param>
	/// <param name="reason">A detailed description of the reason for preservation.</param>
	/// <param name="createdOn">The date when the reason was created, in a format that can be parsed by <see cref="DateTimeOffset.TryParse(string, out DateTimeOffset)"/>.</param>
	/// <param name="createdBy">The name of the developer who created the reason.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="createdBy"/> or <paramref name="reason"/> is null.</exception>
	public PreserveAttribute(PreserveReason preserveReason, string reason, string createdOn, string createdBy)
	{
		this.CreatedBy = createdBy ?? throw new ArgumentNullException(nameof(createdBy));
		this.PreserveReason = preserveReason;
		this.Reason = reason ?? throw new ArgumentNullException(nameof(reason));

		if (string.IsNullOrEmpty(createdOn) is false && DateTimeOffset.TryParse(createdOn, out var createdDate))
		{
			this.CreatedOn = createdDate;
		}
	}

	/// <summary>
	/// Gets the name of the developer who created the reason for preservation.
	/// </summary>
	/// <value>The name of the developer.</value>
	public string CreatedBy { get; }

	/// <summary>
	/// Gets the date when the reason for preservation was created.
	/// </summary>
	/// <value>The date when the reason was added.</value>
	public DateTimeOffset CreatedOn { get; }

	/// <summary>
	/// Gets the preservation reason as defined in <see cref="PreserveReason"/>.
	/// </summary>
	/// <value>The preservation reason.</value>
	public PreserveReason PreserveReason { get; }

	/// <summary>
	/// Gets the detailed description of the reason for preservation.
	/// </summary>
	/// <value>The detailed reason why the associated code needs to be preserved.</value>
	public string Reason { get; }

}
