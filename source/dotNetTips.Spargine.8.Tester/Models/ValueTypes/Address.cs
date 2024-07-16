// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-04-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2024
// ***********************************************************************
// <copyright file="Address.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Value type named "Address" with properties for Address1
// and Address2, City, Country, CountryProvince, Phone, PostalCode,
// and State. This type inherits from the interface IAddress.
// </summary>
// ***********************************************************************
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
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
/// Represents a physical address with properties for address lines, city, state, country, postal code, and phone number.
/// Implements the <see cref="IAddress"/> interface and supports equality comparison.
/// </summary>
[DataContract(Name = "address", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[DebuggerDisplay("{Id}")]
[Serializable]
[XmlRoot(ElementName = "Address", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public struct Address : IAddress, IEquatable<Address>
{

	/// <summary>
	/// The address1
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _address1;

	/// <summary>
	/// The address2
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _address2;

	/// <summary>
	/// The city
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _city;

	/// <summary>
	/// The country
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _country = RegionInfo.CurrentRegion.ThreeLetterISORegionName;

	/// <summary>
	/// The county province
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _countyProvince;

	/// <summary>
	/// The phone
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _phone;

	/// <summary>
	/// The postal code
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _postalCode;

	/// <summary>
	/// The state
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _state;

	/// <summary>
	/// The identifier
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _id;

	/// <summary>
	/// Prevents a default instance of the <see cref="PersonRecord" /> class from being created.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[JsonConstructor]
	public Address()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="Address"/> struct with a specified identifier.
	/// </summary>
	/// <param name="id">The unique identifier for the address.</param>
	public Address([NotNull] string id) => this.Id = id;

	/// <summary>
	/// Initializes a new instance of the <see cref="Address"/> struct.
	/// </summary>
	/// <param name="id">The unique identifier for the address.</param>
	/// <param name="address1">The first line of the address.</param>
	/// <param name="address2">The second line of the address (optional).</param>
	/// <param name="city">The city of the address.</param>
	/// <param name="state">The state or region of the address.</param>
	/// <param name="countyProvince">The county or province of the address (optional).</param>
	/// <param name="country">The country of the address.</param>
	/// <param name="postalCode">The postal code of the address.</param>
	/// <param name="phone">The phone number associated with the address (optional).</param>
	public Address([NotNull] string id, string address1, string address2, string city, string state, string countyProvince, string country, string postalCode, string phone) : this(id)
	{
		this.Address1 = address1;
		this.Address2 = address2;
		this.City = city;
		this.Country = country;
		this.CountyProvince = countyProvince;
		this.Phone = phone;
		this.PostalCode = postalCode;
		this.State = state;
	}

	/// <summary>
	/// Determines whether two specified instances of <see cref="Address"/> are not equal.
	/// </summary>
	/// <param name="left">The first instance of <see cref="Address"/>.</param>
	/// <param name="right">The second instance of <see cref="Address"/>.</param>
	/// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> do not represent the same value; otherwise, <c>false</c>.</returns>
	public static bool operator !=(Address left, Address right) => !(left == right);

	/// <summary>
	/// Implements the less than operator &lt;. Determines whether the left instance precedes the right instance in the sort order.
	/// </summary>
	/// <param name="left">The left <see cref="Address"/> instance.</param>
	/// <param name="right">The right <see cref="Address"/> instance.</param>
	/// <returns><c>true</c> if the left instance precedes the right instance in the sort order; otherwise, <c>false</c>.</returns>
	public static bool operator <(Address left, Address right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the less than or equal to operator &lt;=. Determines whether the left instance is either less than or equal to the right instance in the sort order.
	/// </summary>
	/// <param name="left">The left <see cref="Address"/> instance.</param>
	/// <param name="right">The right <see cref="Address"/> instance.</param>
	/// <returns><c>true</c> if the left instance is less than or equal to the right instance in the sort order; otherwise, <c>false</c>.</returns>
	public static bool operator <=(Address left, Address right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the equality operator ==. Determines whether the left instance is equal to the right instance.
	/// </summary>
	/// <param name="left">The left <see cref="Address"/> instance.</param>
	/// <param name="right">The right <see cref="Address"/> instance.</param>
	/// <returns><c>true</c> if the left instance is equal to the right instance; otherwise, <c>false</c>.</returns>
	public static bool operator ==(Address left, Address right) => left.Equals(right);

	/// <summary>
	/// Implements the greater than operator &gt;. Determines whether the left instance follows the right instance in the sort order.
	/// </summary>
	/// <param name="left">The left <see cref="Address"/> instance.</param>
	/// <param name="right">The right <see cref="Address"/> instance.</param>
	/// <returns><c>true</c> if the left instance follows the right instance in the sort order; otherwise, <c>false</c>.</returns>
	public static bool operator >(Address left, Address right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the greater than or equal to operator &gt;=. Determines whether the left instance is either greater than or equal to the right instance in the sort order.
	/// </summary>
	/// <param name="left">The left <see cref="Address"/> instance.</param>
	/// <param name="right">The right <see cref="Address"/> instance.</param>
	/// <returns><c>true</c> if the left instance is greater than or equal to the right instance in the sort order; otherwise, <c>false</c>.</returns>
	public static bool operator >=(Address left, Address right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings:
	/// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item><item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item><item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item></list></returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	readonly int IComparable<IAddress>.CompareTo([NotNull] IAddress other)
	{
		if (other is null)
		{
			return 1;
		}

		return string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Compares the current instance with another <see cref="Address"/> instance.
	/// </summary>
	/// <param name="address">The <see cref="Address"/> to compare with this instance.</param>
	/// <returns>A 32-bit signed integer that indicates the relative order of the objects being compared.
	/// The return value has the following meanings: Less than zero indicates this instance precedes <paramref name="address"/>.
	/// Zero indicates this instance occurs in the same position in the sort order as <paramref name="address"/>.
	/// Greater than zero indicates this instance follows <paramref name="address"/>.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly int CompareTo([NotNull] Address address) => string.Compare(this.Id, address.Id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Determines whether the specified object is equal to the current instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified object is equal to the current instance; otherwise, <c>false</c>.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override readonly bool Equals(object obj) => obj is Address other && this.Equals(other);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool Equals([NotNull] IAddress other) => other is Address address && this.Equals(address);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool Equals(Address other)
	{
		return string.Equals(Address1, other.Address1, StringComparison.Ordinal) &&
			   string.Equals(Address2, other.Address2, StringComparison.Ordinal) &&
			   string.Equals(City, other.City, StringComparison.Ordinal) &&
			   string.Equals(State, other.State, StringComparison.Ordinal) &&
			   string.Equals(CountyProvince, other.CountyProvince, StringComparison.Ordinal) &&
			   string.Equals(Country, other.Country, StringComparison.Ordinal) &&
			   string.Equals(PostalCode, other.PostalCode, StringComparison.Ordinal) &&
			   string.Equals(Phone, other.Phone, StringComparison.Ordinal) &&
			   string.Equals(Id, other.Id, StringComparison.Ordinal);
	}

	/// <summary>
	/// Returns a hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
	/// </summary>
	/// <returns>A hash code for this instance.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override readonly int GetHashCode()
	{
		var hash = new HashCode();
		hash.Add(this.Address1);
		hash.Add(this.Address2);
		hash.Add(this.City);
		hash.Add(this.Country);
		hash.Add(this.CountyProvince);
		hash.Add(this.Id);
		hash.Add(this.Phone);
		hash.Add(this.PostalCode);
		hash.Add(this.State);
		return hash.ToHashCode();
	}

	/// <summary>
	/// Converts an <see cref="AddressRecord"/> to an <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The address record to convert.</param>
	/// <returns>An <see cref="Address"/> instance corresponding to the provided <see cref="AddressRecord"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="address"/> is null.</exception>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Address ToAddress([NotNull] AddressRecord address)
	{
		return new(address.ArgumentNotNull().Id)
		{
			Address1 = address.Address1,
			Address2 = address.Address2,
			City = address.City,
			Country = address.Country,
			CountyProvince = address.CountyProvince,
			Phone = address.Phone,
			PostalCode = address.PostalCode,
			State = address.State,
		};
	}

	/// <summary>
	/// Returns a <see cref="string"/> that represents the current <see cref="Address"/>.
	/// </summary>
	/// <returns>A <see cref="string"/> that represents this instance, formatted according to the properties of the <see cref="Address"/>.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override readonly string ToString() => this.PropertiesToString();

	/// <summary>
	/// Gets or sets the first line of the address.
	/// </summary>
	/// <value>The first line of the address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not within the specified range (0 to 100 characters).</exception>
	/// <remarks>This property is limited to 100 characters.</remarks>
	[DataMember(Name = "address1", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("address1")]
	[MaxLength(100, ErrorMessage = "Address1 length is limited to 100 characters.")]
	[MinLength(0, ErrorMessage = "Address1 cannot be less than 0 characters.")]
	[XmlElement(ElementName = "Address1")]
	public string Address1
	{
		readonly get => this._address1;
		set
		{
			if (string.Equals(this._address1, value, StringComparison.Ordinal))
			{
				return;
			}

			this._address1 = value.HasValue(0, 100) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Address1),
					Resources.AddressLengthIsLimitedTo100Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the second line of the address.
	/// </summary>
	/// <value>The second line of the address.</value>
	[DataMember(Name = "address2", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("address2")]
	[MaxLength(100, ErrorMessage = "Address2 length is limited to 100 characters.")]
	[MemberNotNull(nameof(_address2))]
	[MinLength(0, ErrorMessage = "Address2 cannot be less than 0 characters.")]
	[XmlElement(ElementName = "Address2")]
	public string Address2
	{
		readonly get => this._address2;
		set
		{
			if (string.Equals(this._address2, value, StringComparison.Ordinal))
			{
				return;
			}

			this._address2 = value.HasValue(0, 100) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Address2),
					Resources.AddressLengthIsLimitedTo100Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the city name.
	/// </summary>
	/// <value>The name of the city.</value>
	[DataMember(Name = "city", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("city")]
	[MaxLength(150, ErrorMessage = "City length is limited to 150 characters.")]
	[MinLength(0, ErrorMessage = "City cannot be less than 0 characters.")]
	[XmlElement]
	public string City
	{
		readonly get => this._city;
		set
		{
			if (string.Equals(this._city, value, StringComparison.Ordinal))
			{
				return;
			}

			this._city = value.HasValue(0, 150) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.City),
					Resources.CityLengthIsLimitedToCharacters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the country name.
	/// </summary>
	/// <value>The name of the country.</value>
	[DataMember(Name = "country", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("country")]
	[MaxLength(50, ErrorMessage = "Country length is limited to 50 characters.")]
	[MemberNotNull(nameof(_country))]
	[MinLength(0, ErrorMessage = "Country cannot be less than 0 characters.")]
	[XmlElement]
	public string Country
	{
		readonly get => this._country;
		set
		{
			if (string.Equals(this._country, value, StringComparison.Ordinal))
			{
				return;
			}

			this._country = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Country),
					Resources.CountryLengthIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the county or province part of the address.
	/// </summary>
	/// <value>The county or province.</value>
	[DataMember(Name = "countyProvince", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("countyProvince")]
	[MaxLength(50, ErrorMessage = "County or province length is limited to 50 characters.")]
	[MemberNotNull(nameof(_countyProvince))]
	[MinLength(0, ErrorMessage = "County or province cannot be less than 0 characters.")]
	[XmlElement]
	public string CountyProvince
	{
		readonly get => this._countyProvince;
		set
		{
			if (string.Equals(this._countyProvince, value, StringComparison.Ordinal))
			{
				return;
			}

			this._countyProvince = value?.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.CountyProvince), Resources.CountyProvinceLengthIsLimitedTo50Character) : value;
		}
	}

	/// <summary>
	/// Gets or sets the unique identifier for the address.
	/// </summary>
	/// <value>The unique identifier.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not within the specified range (1 to 50 characters).</exception>
	/// <remarks>Id is limited to 50 characters.</remarks>
	[DataMember(Name = "id", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessage = "Id length is limited to 50 characters.")]
	[MemberNotNull(nameof(_id))]
	[MinLength(1, ErrorMessage = "Id cannot be empty.")]
	[XmlElement(IsNullable = false)]
	public string Id
	{
		readonly get => this._id;

		init
		{
			if (string.Equals(this._id, value, StringComparison.Ordinal))
			{
				return;
			}

			this._id = value.HasValue(1, 50) is false
				? throw new ArgumentOutOfRangeException(nameof(this.Id), Resources.IdLengthIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the phone number associated with the address.
	/// </summary>
	/// <value>The phone number.</value>
	[DataMember(Name = "phone", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("phone")]
	[MaxLength(50, ErrorMessage = "Phone number length is limited to 50 characters.")]
	[MinLength(0, ErrorMessage = "Phone number cannot be less than 0 characters.")]
	[MemberNotNull(nameof(_phone))]
	[XmlElement]
	public string Phone
	{
		readonly get => this._phone;
		set
		{
			if (string.Equals(this._phone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._phone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Phone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the postal code.
	/// </summary>
	/// <value>The postal code of the address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is not within the specified range (0 to 40 characters).</exception>
	/// <remarks>Postal code is limited to 40 characters to ensure compliance with most global postal code formats.</remarks>
	[DataMember(Name = "postalCode", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("postalCode")]
	[MaxLength(40, ErrorMessage = "Postal code length is limited to 40 characters.")]
	[MemberNotNull(nameof(_postalCode))]
	[MinLength(0, ErrorMessage = "Postal code cannot be less than 0 characters.")]
	[XmlElement]
	public string PostalCode
	{
		readonly get => this._postalCode;
		set
		{
			if (string.Equals(this._postalCode, value, StringComparison.Ordinal))
			{
				return;
			}

			this._postalCode = value.HasValue(0, 40) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.PostalCode),
					Resources.PostalCodeLengthIsLimitedTo40Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the state or province part of the address.
	/// </summary>
	/// <value>The state or province.</value>
	[DataMember(Name = "state", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("state")]
	[MaxLength(60, ErrorMessage = "State length is limited to 60 characters.")]
	[MemberNotNull(nameof(_state))]
	[MinLength(0, ErrorMessage = "State cannot be less than 0 characters.")]
	[XmlElement]
	public string State
	{
		readonly get => this._state;
		set
		{
			if (string.Equals(this._state, value, StringComparison.Ordinal))
			{
				return;
			}

			this._state = value.HasValue(0, 60) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.State),
					Resources.StateLengthIsLimitedTo60Characters)
				: value;
		}
	}

}
