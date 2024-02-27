// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2023
// ***********************************************************************
// <copyright file="ICloneable.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// This interface is intended to be used for types that are meant to be
// cloned, as it mandates the implementation of the method Clone().
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )



namespace DotNetTips.Spargine.Core;

/// <summary>
/// ICloneable Interface.
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
public interface ICloneable<out T>
{

	/// <summary>
	/// Cones this instance.
	/// </summary>
	/// <returns>T.</returns>
	T Clone();

}
