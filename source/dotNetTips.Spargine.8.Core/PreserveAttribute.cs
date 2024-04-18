// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2024
// ***********************************************************************
// <copyright file="PreserveAttribute.cs" company="dotNetTips.Spargine.Core">
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
/// PreserveAttribute. This class cannot be inherited.
/// Implements <see cref="Attribute" />
/// </summary>
/// <seealso cref="Attribute" />
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate, Inherited = false)]
[Information(nameof(PreserveAttribute), "David McCarter", "2/7/2023", Status = Status.Available, Documentation = "ADD URL")]
public sealed class PreserveAttribute : Attribute
{

	/// <summary>
	/// Initializes a new instance of the <see cref="PreserveAttribute" /> class.
	/// </summary>
	/// <param name="reason">The reason to keep this code description.</param>
	public PreserveAttribute(string reason)
	: this(PreserveReason.None, reason, string.Empty, string.Empty)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PreserveAttribute" /> class.
	/// </summary>
	/// <param name="reason">The reason to keep this code description.</param>
	/// <param name="createdOn">Reason created on date.</param>
	/// <param name="createdBy">Reason created by.</param>
	/// <exception cref="ArgumentNullException">createdBy</exception>
	/// <exception cref="ArgumentNullException">reason</exception>
	public PreserveAttribute(string reason, string createdOn, string createdBy)
		: this(PreserveReason.None, reason, createdOn, createdBy)
	{
	}
	/// <summary>
	/// Initializes a new instance of the <see cref="PreserveAttribute" /> class.
	/// </summary>
	/// <param name="preserveReason">The preserve reason.</param>
	/// <param name="reason">The reason to keep this code description.</param>
	/// <param name="createdOn">Reason created on date.</param>
	/// <param name="createdBy">Reason created by.</param>
	/// <exception cref="ArgumentNullException">createdBy</exception>
	/// <exception cref="ArgumentNullException">reason</exception>
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
	/// Gets the developer who created a reason.
	/// </summary>
	/// <value>The created by.</value>
	public string CreatedBy { get; }

	/// <summary>
	/// Gets the date the reason was added.
	/// </summary>
	/// <value>The created on.</value>
	public DateTimeOffset CreatedOn { get; }

	/// <summary>
	/// Gets the <see cref=" PreserveReason" />.
	/// </summary>
	/// <value>The reason.</value>
	public PreserveReason PreserveReason { get; }

	/// <summary>
	/// Gets the reason description.
	/// </summary>
	/// <value>The reason description.</value>
	public string Reason { get; }

}
