
// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 01-12-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-06-2024
// ***********************************************************************
// <copyright file="TypeOfType.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for Type.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )





namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Type"/>.
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
