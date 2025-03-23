// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 10-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2025
// ***********************************************************************
// <copyright file="PasswordVerificationResult.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration used in password verification.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )




using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Represents the result of a password verification process.
/// </summary>
public enum PasswordVerificationResult
{
	/// <summary>
	/// Indicates that the password verification failed.
	/// </summary>
	[EnumMember(Value = "Failed")]
	Failed,

	/// <summary>
	/// Indicates that the password verification succeeded.
	/// </summary>
	[EnumMember(Value = "Success")]
	Success,

	/// <summary>
	/// Indicates that the password verification succeeded, but the password needs to be rehashed.
	/// This can occur if the password hash algorithm has been changed since the password was last hashed.
	/// </summary>
	[EnumMember(Value = "Success - Rehash Needed")]
	SuccessRehashNeeded,
}
