// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="OneDriveFolder.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>OneDrive folder information.</summary>
// ***********************************************************************
using DotNetTips.Spargine.Extensions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Represents a OneDrive folder, providing details such as account name, account type, directory information, and user email.
/// </summary>
public class OneDriveFolder
{

	/// <summary>
	/// Initializes a new instance of the <see cref="OneDriveFolder" /> class.
	/// </summary>
	public OneDriveFolder() => this.InitializeFields();

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
