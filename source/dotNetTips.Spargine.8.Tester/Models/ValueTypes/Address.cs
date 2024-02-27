// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-04-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-14-2023
// ***********************************************************************
// <copyright file="Address.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary> Value type named "Address" with properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This type inherits from the interface IAddress.</summary>
// ***********************************************************************
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Class Address. This class cannot be inherited.
/// Implements the <see cref="IAddress" />
/// </summary>
/// <seealso cref="IAddress" />
[DataContract(Name = "address", Namespace = "http://dotNetTips.Spargine.Tester.Models.Val")]
[DebuggerDisplay("{Id}")]
[Serializable]
[XmlRoot(ElementName = "Address", Namespace = "http://dotNetTips.Spargine.Tester.Models.Val")]
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
	public Address() => this.Id = RandomData.GenerateKey();

	/// <summary>
	/// Initializes a new instance of the <see cref="AddressRecord" /> class.
	/// </summary>
	/// <param name="id">The identifier.</param>
	public Address([NotNull] string id) => this.Id = id;

	/// <summary>
	/// Initializes a new instance of the <see cref="AddressRecord" /> class.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="address1">The address1.</param>
	/// <param name="address2">The address2.</param>
	/// <param name="city">The city.</param>
	/// <param name="state">The state.</param>
	/// <param name="countyProvince">The county province.</param>
	/// <param name="country">The country.</param>
	/// <param name="postalCode">The postal code.</param>
	/// <param name="phone">The phone.</param>
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
	/// Implements the != operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !=(Address left, Address right) => !(left == right);

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(Address left, Address right) => left.Equals(right);

	/// <summary>
	/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings:
	/// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item><item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item><item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item></list></returns>
	readonly int IComparable<IAddress>.CompareTo(IAddress other)
	{
		if (other is null)
		{
			return 1;
		}

		return string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Determines whether the specified <see cref="object" /> is equal to this instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
	public override readonly bool Equals(object obj) => this.Equals(obj);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public readonly bool Equals([NotNull] IAddress other) => this.Equals(other);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public readonly bool Equals(Address other) => this.Equals(other);

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
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
	/// Converts to <see cref=" AddressRecord"/> to <see cref=" Address"/>.
	/// </summary>
	/// <param name="address">The address.</param>
	/// <returns>Address.</returns>
	public static Address ToAddress(AddressRecord address)
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
	/// Returns a <see cref="string" /> that represents this instance.
	/// </summary>
	/// <returns>A <see cref="string" /> that represents this instance.</returns>
	public override readonly string ToString() => this.PropertiesToString();

	/// <summary>
	/// Gets or sets the Address1.
	/// </summary>
	/// <value>The Address1.</value>
	/// <exception cref="ArgumentOutOfRangeException">Address1</exception>
	/// <remarks>Address1 is limited to 100 characters.</remarks>
	[DataMember(Name = "address1", IsRequired = false)]
	[JsonPropertyName("address1")]
	[XmlElement]
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
	/// Gets or sets the Address2.
	/// </summary>
	/// <value>The Address2.</value>
	/// <exception cref="ArgumentOutOfRangeException">Address2</exception>
	/// <remarks>Address2 is limited to 100 characters.</remarks>
	[DataMember(Name = "address2", IsRequired = false)]
	[JsonPropertyName("address2")]
	[XmlElement]
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
	/// Gets or sets the city.
	/// </summary>
	/// <value>The city name.</value>
	/// <exception cref="ArgumentOutOfRangeException">City</exception>
	/// <remarks>City is limted to 150 characters.</remarks>
	[DataMember(Name = "city", IsRequired = false)]
	[JsonPropertyName("city")]
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
	/// Gets or sets the country.
	/// </summary>
	/// <value>The country name.</value>
	/// <exception cref="ArgumentOutOfRangeException">Country</exception>
	/// <remarks>Country is limited to 50 characters.</remarks>
	[DataMember(Name = "country", IsRequired = false)]
	[JsonPropertyName("country")]
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
	/// Gets or sets the county province.
	/// </summary>
	/// <value>The county province.</value>
	/// <exception cref="ArgumentOutOfRangeException">CountyProvince</exception>
	/// <remarks>CountyProvince is limited to 50 characters.</remarks>
	[DataMember(Name = "countryProvince", IsRequired = false)]
	[JsonPropertyName("countryProvince")]
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
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	/// <exception cref="ArgumentOutOfRangeException">Id</exception>
	/// <remarks>Id is limited to 50 characters.</remarks>
	[DataMember(Name = "id", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("id")]
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
	/// Gets or sets the phone.
	/// </summary>
	/// <value>The phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">Phone</exception>
	/// <remarks>Phone number is limited to 50 characters.</remarks>
	[DataMember(Name = "phone", IsRequired = false)]
	[JsonPropertyName("phone")]
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
	/// <value>The postal code.</value>
	/// <exception cref="ArgumentOutOfRangeException">PostalCode</exception>
	/// <remarks>Postal code is limited to 40 characters.</remarks>
	[DataMember(Name = "postalCode", IsRequired = false)]
	[JsonPropertyName("postalCode")]
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
	/// Gets or sets the state.
	/// </summary>
	/// <value>The state.</value>
	/// <exception cref="ArgumentOutOfRangeException">State</exception>
	/// <remarks>State is limited to 60 characters.</remarks>
	[DataMember(Name = "state", IsRequired = false)]
	[JsonPropertyName("state")]
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
