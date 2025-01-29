// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 12-04-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2025
// ***********************************************************************
// <copyright file="Address.cs" company="David McCarter - dotNetTips.com">
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
/// Represents an address with properties for Address1, Address2, City, Country, CountyProvince, Phone, PostalCode, and State.
/// This struct implements <see cref="IAddress"/> and <see cref="IEquatable{Address}"/>.
/// </summary>
[DataContract(Name = "address", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[DebuggerDisplay("Id = {Id}, Address1 = {Address1}, City = {City}, Country = {Country}")]
[Serializable]
[XmlRoot(ElementName = "Address", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
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
	/// Prevents a default instance of the <see cref="PersonRecord"/> class from being created.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Address()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Address"/> struct with a specified identifier.
	/// </summary>
	/// <param name="id">The unique identifier for the address.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
	[JsonConstructor]
	[Information(nameof(Address), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Address([NotNull] string id) => this.Id = id.ArgumentNotNull();

	/// <summary>
	/// Initializes a new instance of the <see cref="AddressRecord"/> class.
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
	[Information(nameof(Address), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[Information("!=", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator !=(Address left, Address right) => !(left == right);

	/// <summary>
	/// Implements the &lt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information("<", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool operator <(Address left, Address right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the &lt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information("<=", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool operator <=(Address left, Address right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information("==", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator ==(Address left, Address right) => left.Equals(right);

	/// <summary>
	/// Implements the &gt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information(">", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool operator >(Address left, Address right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the &gt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information(">=", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static bool operator >=(Address left, Address right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings:
	/// <list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>Less than zero</term><description>This instance precedes <paramref name="other"/> in the sort order.</description></item><item><term>Zero</term><description>This instance occurs in the same position in the sort order as <paramref name="other"/>.</description></item><item><term>Greater than zero</term><description>This instance follows <paramref name="other"/> in the sort order.</description></item></list></returns>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	readonly int IComparable<IAddress>.CompareTo(IAddress other)
	{
		if (other is null)
		{
			return 1;
		}

		return string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Compares current object.
	/// </summary>
	/// <param name="address">The address.</param>
	/// <returns>System.Int32.</returns>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly int CompareTo(Address address) => this.CompareTo(address);

	/// <summary>
	/// Determines whether the specified <see cref="object"/> is equal to this instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified <see cref="object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public override readonly bool Equals(object obj) => base.Equals(obj);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public readonly bool Equals([NotNull] IAddress other) => base.Equals(other);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly bool Equals(Address other) => base.Equals(other);

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	[DebuggerStepThrough]
	[Information(nameof(GetHashCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override readonly int GetHashCode()
	{
		var hash = new HashCode();
		hash.Add(this.Id, StringComparer.OrdinalIgnoreCase);
		hash.Add(this.Address1, StringComparer.Ordinal);
		hash.Add(this.Address2, StringComparer.Ordinal);
		hash.Add(this.City, StringComparer.Ordinal);
		hash.Add(this.Country, StringComparer.Ordinal);
		hash.Add(this.CountyProvince, StringComparer.Ordinal);
		hash.Add(this.Phone, StringComparer.Ordinal);
		hash.Add(this.PostalCode, StringComparer.Ordinal);
		hash.Add(this.State, StringComparer.Ordinal);
		return hash.ToHashCode();
	}

	/// <summary>
	/// Converts to <see cref=" AddressRecord"/> to <see cref=" Address"/>.
	/// </summary>
	/// <param name="address">The address.</param>
	/// <returns>Address.</returns>
	[Information(nameof(ToAddress), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
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
	/// Returns a <see cref="string"/> that represents this instance.
	/// </summary>
	/// <returns>A <see cref="string"/> that represents this instance.</returns>
	[DebuggerStepThrough]
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override readonly string ToString() => this.PropertiesToString();

	/// <summary>
	/// Gets or sets the Address1.
	/// </summary>
	/// <value>The Address1.</value>
	/// <exception cref="ArgumentOutOfRangeException">Address1</exception>
	/// <remarks>Address1 is limited to 100 characters.</remarks>
	[DataMember(Name = "address1", IsRequired = false, Order = 1)]
	[Display(Name = "Address Line 1")]
	[JsonPropertyName("address1")]
	[MaxLength(100, ErrorMessage = "Address1 cannot exceed 100 characters.")]
	[XmlElement("Address1")]
	[Information(nameof(Address1), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[DataMember(Name = "address2", IsRequired = false, Order = 2)]
	[Display(Name = "Address Line 2")]
	[JsonPropertyName("address2")]
	[MaxLength(100, ErrorMessage = "Address2 cannot exceed 100 characters.")]
	[XmlElement("Address2")]
	[Information(nameof(Address2), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[DataMember(Name = "city", IsRequired = false, Order = 3)]
	[Display(Name = "City")]
	[JsonPropertyName("city")]
	[MaxLength(150, ErrorMessage = "City cannot exceed 150 characters.")]
	[XmlElement("City")]
	[Information(nameof(City), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
				? throw new ArgumentOutOfRangeException(nameof(this.City), Resources.CityLengthIsLimitedToCharacters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the country.
	/// </summary>
	/// <value>The country name.</value>
	/// <exception cref="ArgumentOutOfRangeException">Country</exception>
	/// <remarks>Country is limited to 50 characters.</remarks>
	[DataMember(Name = "country", IsRequired = false, Order = 4)]
	[Display(Name = "Country")]
	[JsonPropertyName("country")]
	[MaxLength(50, ErrorMessage = "Country cannot exceed 50 characters.")]
	[XmlElement("Country")]
	[Information(nameof(Country), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[DataMember(Name = "countyProvince", IsRequired = false, Order = 5)]
	[Display(Name = "County/Province")]
	[JsonPropertyName("countyProvince")]
	[MaxLength(50, ErrorMessage = "CountyProvince cannot exceed 50 characters.")]
	[XmlElement("CountyProvince")]
	[Information(nameof(CountyProvince), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CountyProvince
	{
		readonly get => this._countyProvince;
		set
		{
			if (string.Equals(this._countyProvince, value, StringComparison.Ordinal))
			{
				return;
			}

			this._countyProvince = value?.Length > 50
				? throw new ArgumentOutOfRangeException(
					nameof(this.CountyProvince),
					Resources.CountyProvinceLengthIsLimitedTo50Character)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	/// <exception cref="ArgumentOutOfRangeException">Id</exception>
	/// <remarks>Id is limited to 50 characters.</remarks>
	[DataMember(Name = "id", IsRequired = true, Order = 0)]
	[Display(Name = "Identifier")]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessage = "Id cannot exceed 50 characters.")]
	[Required(ErrorMessage = "Id is required.")]
	[XmlElement("Id", IsNullable = false)]
	[Information(nameof(Id), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[DataMember(Name = "phone", IsRequired = false, Order = 6)]
	[Display(Name = "Phone Number")]
	[JsonPropertyName("phone")]
	[MaxLength(50, ErrorMessage = "Phone number cannot exceed 50 characters.")]
	[XmlElement("Phone")]
	[Information(nameof(Phone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[DataMember(Name = "postalCode", IsRequired = false, Order = 7)]
	[Display(Name = "Postal Code")]
	[JsonPropertyName("postalCode")]
	[MaxLength(40, ErrorMessage = "Postal code cannot exceed 40 characters.")]
	[XmlElement("PostalCode")]
	[Information(nameof(PostalCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[DataMember(Name = "state", IsRequired = false, Order = 8)]
	[Display(Name = "State")]
	[JsonPropertyName("state")]
	[MaxLength(60, ErrorMessage = "State cannot exceed 60 characters.")]
	[XmlElement("State")]
	[Information(nameof(State), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
