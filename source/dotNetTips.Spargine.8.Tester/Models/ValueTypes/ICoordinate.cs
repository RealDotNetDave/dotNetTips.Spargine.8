// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-29-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="ICoordinate.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// An interface named "ICoordinate" with properties X, Y,
// and Z for coordinating values.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Defines a set of properties for working with coordinates in a 3D space.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public interface ICoordinate
{

	/// <summary>
	/// Converts to string representation of the coordinate.
	/// </summary>
	/// <returns>A <see cref="string" /> that represents the current object.</returns>
	string ToString();

	/// <summary>
	/// Gets or sets the x coordinate.
	/// </summary>
	/// <value>The x value.</value>
	int X { get; set; }

	/// <summary>
	/// Gets or sets the y coordinate.
	/// </summary>
	/// <value>The y value.</value>
	int Y { get; set; }

	/// <summary>
	/// Gets or sets the z coordinate.
	/// </summary>
	/// <value>The z.</value>
	int Z { get; set; }

}
