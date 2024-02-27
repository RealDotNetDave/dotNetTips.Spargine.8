
// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 01-12-2023
//
// Last Modified By : David McCarter
// Last Modified On : 11-22-2023
// ***********************************************************************
// <copyright file="TypeOfType.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class TypeExtensions.
/// </summary>
public static partial class TypeExtensions
{
	/// <summary>
	/// Enum TypeOfType
	/// </summary>
	public enum TypeOfType
	{
		/// <summary>
		/// Unknown type
		/// </summary>
		Unknown,

		/// <summary>
		/// Value type
		/// </summary>
		Value,

		/// <summary>
		/// Reference type
		/// </summary>
		Reference,

		/// <summary>
		/// Record type
		/// </summary>
		Record
	}

}
