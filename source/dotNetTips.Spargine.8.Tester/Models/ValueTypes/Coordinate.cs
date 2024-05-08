// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 02-29-2024
// ***********************************************************************
// <copyright file="Coordinate.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// A practical value type designed for testing and benchmarking,
// named "Coordinate," featuring properties X, Y, and Z.
// It inherits from the interface ICoordinate.
// </summary>
// ***********************************************************************
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Struct Coordinate
/// Implements the <see cref="ICoordinate" />
/// Implements the <see cref="IComparable" />&gt;
/// </summary>
/// <seealso cref="IComparable" />
/// <seealso cref="ICoordinate" />
/// <param name="x">The x.</param>
/// <param name="y">The y.</param>
/// <param name="z">The z.</param>
/// <remarks>Initializes a new instance of the <see cref="Coordinate" /> struct.</remarks>
[DataContract(Name = "coordinate")]
[Serializable]
[XmlRoot(ElementName = "Coordinate")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public struct Coordinate(int x, int y, int z = 0) : ICoordinate, IEquatable<Coordinate>, IComparable, IComparable<Coordinate>
{

	/// <summary>
	/// Implements the != operator.
	/// </summary>
	/// <param name="cord1">The first coordinate.</param>
	/// <param name="cord2">The second coordinate.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !=(Coordinate cord1, Coordinate cord2) => !(cord1 == cord2);

	/// <summary>
	/// Implements the &lt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <(Coordinate left, Coordinate right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the &lt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <=(Coordinate left, Coordinate right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="cord1">The first coordinate.</param>
	/// <param name="cord2">The second coordinate.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(Coordinate cord1, Coordinate cord2) => cord1.Equals(cord2);

	/// <summary>
	/// Implements the &gt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >(Coordinate left, Coordinate right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the &gt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >=(Coordinate left, Coordinate right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Compares one object to another.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentInvalidException">obj</exception>
	public readonly int CompareTo(object obj)
	{
		if (obj is not Coordinate)
		{
			ExceptionThrower.ThrowArgumentInvalidException(string.Format(CultureInfo.CurrentCulture, Resources.ObjectIsNotType, nameof(obj), nameof(Coordinate)), nameof(obj));
		}

		return this.CompareTo((Coordinate)obj);
	}

	/// <summary>
	/// Compares to.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>System.Int32.</returns>
	public readonly int CompareTo(Coordinate other)
	{
		var result = this.X.CompareTo(other.X);
		if (result != 0)
		{
			return result;
		}

		result = this.Y.CompareTo(other.Y);
		if (result != 0)
		{
			return result;
		}

		result = this.Z.CompareTo(other.Z);
		if (result != 0)
		{
			return result;
		}

		return result;
	}

	/// <summary>
	/// Determines whether the specified <see cref="object" /> is equal to this instance.
	/// </summary>
	/// <param name="obj">The object to compare with the this instance.</param>
	/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
	public override readonly bool Equals(object obj) => obj is Coordinate proper && this.Equals(proper);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>True if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.</returns>
	public readonly bool Equals(Coordinate other) => this.X == other.X && this.Y == other.Y && this.Z == other.Z;

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public override readonly int GetHashCode() => HashCode.Combine(this.X, this.Y, this.Z);

	/// <summary>
	/// Returns a <see cref="string" /> of the coordinates.
	/// </summary>
	/// <returns>A <see cref="string" /> of the coordinates.</returns>
	public override readonly string ToString() => this.PropertiesToString();

	/// <summary>
	/// Gets or sets the x coordinate.
	/// </summary>
	/// <value>The x.</value>
	[DataMember(Name = "x", IsRequired = false)]
	[JsonPropertyName("x")]
	[XmlElement]
	public int X { get; set; } = x;

	/// <summary>
	/// Gets or sets the y coordinate.
	/// </summary>
	/// <value>The y.</value>
	[DataMember(Name = "y", IsRequired = false)]
	[JsonPropertyName("y")]
	[XmlElement]
	public int Y { get; set; } = y;

	/// <summary>
	/// Gets or sets the z coordinate.
	/// </summary>
	/// <value>The z.</value>
	[DataMember(Name = "z", IsRequired = false)]
	[JsonPropertyName("z")]
	[XmlElement]
	public int Z { get; set; } = z;

}
