// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 02-04-2025
// ***********************************************************************
// <copyright file="Coordinate.cs" company="McCarter Consulting">
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
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Represents a 3D coordinate with X, Y, and Z integer values.
/// </summary>
/// <param name="x">The X coordinate.</param>
/// <param name="y">The Y coordinate.</param>
/// <param name="z">The Z coordinate. Default is 0.</param>
/// <remarks>
/// This struct is designed for testing and benchmarking scenarios.
/// It implements <see cref="ICoordinate"/>, <see cref="IEquatable{Coordinate}"/>,
/// <see cref="IComparable"/>, and <see cref="IComparable{Coordinate}"/> interfaces.
/// </remarks>
[DataContract(Name = "coordinate", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[Serializable]
[XmlRoot(ElementName = "Coordinate", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public struct Coordinate(int x, int y, int z = 0) : ICoordinate, IEquatable<Coordinate>, IComparable, IComparable<Coordinate>
{
	/// <summary>
	/// Implements the inequality operator. Checks if two <see cref="Coordinate"/> instances are not equal.
	/// </summary>
	/// <param name="cord1">The first <see cref="Coordinate"/> instance.</param>
	/// <param name="cord2">The second <see cref="Coordinate"/> instance.</param>
	/// <returns><c>true</c> if the instances are not equal; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator !=(Coordinate cord1, Coordinate cord2) => !(cord1 == cord2);

	/// <summary>
	/// Implements the less than operator. Checks if the first <see cref="Coordinate"/> instance is less than the second.
	/// </summary>
	/// <param name="left">The first <see cref="Coordinate"/> instance.</param>
	/// <param name="right">The second <see cref="Coordinate"/> instance.</param>
	/// <returns><c>true</c> if the first instance is less than the second; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <(Coordinate left, Coordinate right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the less than or equal to operator. Checks if the first <see cref="Coordinate"/> instance is less than or equal to the second.
	/// </summary>
	/// <param name="left">The first <see cref="Coordinate"/> instance.</param>
	/// <param name="right">The second <see cref="Coordinate"/> instance.</param>
	/// <returns><c>true</c> if the first instance is less than or equal to the second; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <=(Coordinate left, Coordinate right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the equality operator. Checks if two <see cref="Coordinate"/> instances are equal.
	/// </summary>
	/// <param name="cord1">The first <see cref="Coordinate"/> instance.</param>
	/// <param name="cord2">The second <see cref="Coordinate"/> instance.</param>
	/// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator ==(Coordinate cord1, Coordinate cord2) => cord1.Equals(cord2);

	/// <summary>
	/// Implements the greater than operator. Checks if the first <see cref="Coordinate"/> instance is greater than the second.
	/// </summary>
	/// <param name="left">The first <see cref="Coordinate"/> instance.</param>
	/// <param name="right">The second <see cref="Coordinate"/> instance.</param>
	/// <returns><c>true</c> if the first instance is greater than the second; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >(Coordinate left, Coordinate right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the greater than or equal to operator. Checks if the first <see cref="Coordinate"/> instance is greater than or equal to the second.
	/// </summary>
	/// <param name="left">The first <see cref="Coordinate"/> instance.</param>
	/// <param name="right">The second <see cref="Coordinate"/> instance.</param>
	/// <returns><c>true</c> if the first instance is greater than or equal to the second; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >=(Coordinate left, Coordinate right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Compares this instance with a specified <see cref="object"/> and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="object"/>.
	/// </summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings: 
	/// Less than zero: This instance precedes <paramref name="obj"/> in the sort order. 
	/// Zero: This instance occurs in the same position in the sort order as <paramref name="obj"/>.
	/// Greater than zero: This instance follows <paramref name="obj"/> in the sort order.</returns>
	/// <exception cref="ArgumentException">Thrown when <paramref name="obj"/> is not of type <see cref="Coordinate"/>.</exception>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly int CompareTo(object obj)
	{
		if (obj is not Coordinate)
		{
			ExceptionThrower.ThrowArgumentInvalidException(
				string.Format(CultureInfo.CurrentCulture, Resources.ObjectIsNotType, nameof(obj), nameof(Coordinate)),
				nameof(obj));
		}

		return this.CompareTo((Coordinate)obj);
	}

	/// <summary>
	/// Compares this instance with another instance of <see cref="Coordinate"/> and returns an integer indicating whether this instance precedes, follows, or is in the same position in the sort order as the other instance.
	/// </summary>
	/// <param name="other">An instance of <see cref="Coordinate"/> to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has the following meanings: 
	/// Less than zero: This instance precedes <paramref name="other"/> in the sort order. 
	/// Zero: This instance occurs in the same position in the sort order as <paramref name="other"/>.
	/// Greater than zero: This instance follows <paramref name="other"/> in the sort order.</returns>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	/// Determines whether the specified object is equal to the current instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified object is equal to the current instance; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override readonly bool Equals(object obj) => obj is Coordinate proper && this.Equals(proper);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>True if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly bool Equals(Coordinate other) => this.X == other.X && this.Y == other.Y && this.Z == other.Z;

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	[Information(nameof(GetHashCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override readonly int GetHashCode() => HashCode.Combine(this.X, this.Y, this.Z);

	/// <summary>
	/// Returns a string that represents the current <see cref="Coordinate"/>.
	/// </summary>
	/// <returns>A string representation of the current <see cref="Coordinate"/>, including its X, Y, and Z values.</returns>
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString() => this.PropertiesToString(includeMemberName: false);

	/// <summary>
	/// Gets or sets the x coordinate.
	/// </summary>
	/// <value>The x.</value>
	[DataMember(Name = "x", IsRequired = false)]
	[JsonPropertyName("x")]
	[XmlElement("X")]
	[Information(nameof(X), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int X { get; set; } = x;

	/// <summary>
	/// Gets or sets the y coordinate.
	/// </summary>
	/// <value>The y.</value>
	[DataMember(Name = "y", IsRequired = false)]
	[JsonPropertyName("y")]
	[XmlElement("Y")]
	[Information(nameof(Y), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int Y { get; set; } = y;

	/// <summary>
	/// Gets or sets the z coordinate.
	/// </summary>
	/// <value>The z.</value>
	[DataMember(Name = "z", IsRequired = false)]
	[JsonPropertyName("z")]
	[XmlElement("Z")]
	[Information(nameof(Z), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int Z { get; set; } = z;
}
