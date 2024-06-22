// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
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
/// Defines a method to create a clone of a type.
/// </summary>
/// <typeparam name="T">The type of object to clone.</typeparam>
public interface ICloneable<out T>
{

	/// <summary>
	/// Creates a new object that is a copy of the current instance.
	/// </summary>
	/// <returns>A new object that is a copy of this instance.</returns>
	T Clone();

}
