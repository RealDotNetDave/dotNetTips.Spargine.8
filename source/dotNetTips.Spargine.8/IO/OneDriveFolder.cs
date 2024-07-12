// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-12-2024
// ***********************************************************************
// <copyright file="OneDriveFolder.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>OneDrive folder information.</summary>
// ***********************************************************************


namespace DotNetTips.Spargine.IO;

/// <summary>
/// Represents a OneDrive folder, providing details such as account name, account type, directory information, and user email.
/// </summary>
public class OneDriveFolder
{

	/// <summary>
	/// Gets the name of the account.
	/// </summary>
	/// <value>The name of the account.</value>
	public string AccountName { get; internal set; }

	/// <summary>
	/// Gets the type of the account.
	/// </summary>
	/// <value>The type of the account.</value>
	public OneDriveAccountType AccountType { get; internal set; } = OneDriveAccountType.Personal;

	/// <summary>
	/// Gets the directory information.
	/// </summary>
	/// <value>The directory information.</value>
	public DirectoryInfo DirectoryInfo { get; internal set; }

	/// <summary>
	/// Gets the account email.
	/// </summary>
	/// <value>The account email.</value>
	public string UserEmail { get; internal set; }

}
