// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 10-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="PasswordVerificationResult.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration used in password verification.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )




namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Represents the result of a password verification process.
/// </summary>
public enum PasswordVerificationResult
{
	/// <summary>
	/// Indicates that the password verification failed.
	/// </summary>
	Failed,

	/// <summary>
	/// Indicates that the password verification succeeded.
	/// </summary>
	Success,

	/// <summary>
	/// Indicates that the password verification succeeded, but the password needs to be rehashed.
	/// This can occur if the password hash algorithm has been changed since the password was last hashed.
	/// </summary>
	SuccessRehashNeeded,
}
