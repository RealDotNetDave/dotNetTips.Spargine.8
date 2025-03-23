// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-29-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2025
// ***********************************************************************
// <copyright file="ResultStatus.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents the status of a result.
/// </summary>
public enum ResultStatus
{
	/// <summary>
	/// The action has failed
	/// </summary>
	[EnumMember(Value = "Failed")]
	Failed,

	/// <summary>
	/// The action has succeeded
	/// </summary>
	[EnumMember(Value = "Succeeded")]
	Succeeded,

	/// <summary>
	/// The action had partial success
	/// </summary>
	[EnumMember(Value = "Partial Success")]
	PartialSuccess,
}
