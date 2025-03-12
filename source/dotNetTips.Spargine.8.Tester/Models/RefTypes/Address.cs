// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-12-2025
// ***********************************************************************
// <copyright file="Address.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Reference type with properties for Address1 and Address2, City,
// Country, CountryProvince, Phone, PostalCode, and State. This type
// inherits from the interface IAddress.
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
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Represents a physical address. This class cannot be inherited and implements the IAddress interface.
/// It includes properties for various components of a physical address such as Address1, Address2, City, State, CountyProvince, Country, PostalCode, and Phone.
/// </summary>
[DataContract(Name = "address", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[DebuggerDisplay("Id = {Id}, Address1 = {Address1}, City = {City}, Country = {Country}")]
[Serializable]
[XmlRoot(ElementName = "Address", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public sealed class Address : IAddress
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
	[NonSerialized]
	[JsonIgnore]
	private string _country = RegionInfo.CurrentRegion.ThreeLetterISORegionName;

	/// <summary>
	/// The county province
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _countyProvince;

	/// <summary>
	/// The identifier
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private readonly string _id;

	/// <summary>
	/// The phone number
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
	/// Initializes a new instance of the <see cref="Address"/> class.
	/// This constructor is parameterless and intended for use in scenarios where an address is being initialized without initial property values.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Address()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Address"/> class with a specified identifier.
	/// </summary>
	/// <param name="id">The unique identifier for the address.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
	[JsonConstructor]
	public Address([NotNull] string id) => this.Id = id;

	/// <summary>
	/// Initializes a new instance of the <see cref="Address"/> class with specified details.
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
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null.</exception>
	public Address(
		[NotNull] string id,
		string address1,
		string address2,
		string city,
		string state,
		string countyProvince,
		string country,
		string postalCode,
		string phone) : this(id)
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
	/// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, <c>false</c>.</returns>
	public static bool operator !=(Address left, Address right) => !(left == right);

	/// <summary>
	/// Implements the less than operator. Determines whether the left instance precedes the right instance in the sort order.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Address"/>.</param>
	/// <param name="right">The right instance of <see cref="Address"/>.</param>
	/// <returns><c>true</c> if the left instance precedes the right instance in the sort order; otherwise, <c>false</c>.</returns>
	public static bool operator <(Address left, Address right) => left is null
		? right is not null
		: left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the less than or equal to operator. Determines whether the left instance precedes or occurs in the same position in the sort order as the right instance.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Address"/>.</param>
	/// <param name="right">The right instance of <see cref="Address"/>.</param>
	/// <returns><c>true</c> if the left instance precedes or occurs in the same position in the sort order as the right instance; otherwise, <c>false</c>.</returns>
	public static bool operator <=(Address left, Address right) => left is null || left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the equality operator. Determines whether the specified instances of <see cref="Address"/> are equal.
	/// </summary>
	/// <param name="left">The first instance of <see cref="Address"/>.</param>
	/// <param name="right">The second instance of <see cref="Address"/>.</param>
	/// <returns><c>true</c> if both instances are equal; otherwise, <c>false</c>.</returns>
	public static bool operator ==(Address left, Address right) => left is null ? right is null : left.Equals(right);

	/// <summary>
	/// Implements the greater than operator. Determines whether the left instance follows the right instance in the sort order.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Address"/>.</param>
	/// <param name="right">The right instance of <see cref="Address"/>.</param>
	/// <returns><c>true</c> if the left instance follows the right instance in the sort order; otherwise, <c>false</c>.</returns>
	public static bool operator >(Address left, Address right) => left is not null && left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the greater than or equal to operator. Determines whether the left instance follows or occurs in the same position in the sort order as the right instance.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Address"/>.</param>
	/// <param name="right">The right instance of <see cref="Address"/>.</param>
	/// <returns><c>true</c> if the left instance follows or occurs in the same position in the sort order as the right instance; otherwise, <c>false</c>.</returns>
	public static bool operator >=(Address left, Address right) => left is null
		? right is null
		: left.CompareTo(right) >= 0;

	/// <summary>
	/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings:
	/// <list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>Less than zero</term><description>This instance precedes <paramref name="other"/> in the sort order.</description></item><item><term>Zero</term><description>This instance occurs in the same position in the sort order as <paramref name="other"/>.</description></item><item><term>Greater than zero</term><description>This instance follows <paramref name="other"/> in the sort order.</description></item></list></returns>
	int IComparable<IAddress>.CompareTo(IAddress other) => other is null ? 1 : string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Compares this instance with a specified <see cref="Address"/> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The address to compare with this instance.</param>
	/// <returns>A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has these meanings: 
	/// <list type="table">
	/// <item>
	/// <term>Less than zero</term>
	/// <description>This instance precedes <paramref name="address"/> in the sort order.</description>
	/// </item>
	/// <item>
	/// <term>Zero</term>
	/// <description>This instance occurs in the same position in the sort order as <paramref name="address"/>.</description>
	/// </item>
	/// <item>
	/// <term>Greater than zero</term>
	/// <description>This instance follows <paramref name="address"/> in the sort order.</description>
	/// </item>
	/// </list>
	/// </returns>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CompareTo(Address address) => address is null ? 1 : string.Compare(this.Id, address.Id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Determines whether the specified <see cref="IAddress"/> is equal to the current <see cref="Address"/>.
	/// </summary>
	/// <param name="other">The <see cref="IAddress"/> to compare with the current <see cref="Address"/>.</param>
	/// <returns><c>true</c> if the specified <see cref="IAddress"/> is equal to the current <see cref="Address"/>; otherwise, <c>false</c>.</returns>
	public bool Equals([NotNull] IAddress other) => ReferenceEquals(this, other);

	/// <summary>
	/// Determines whether the specified object is equal to the current instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified object is equal to the current instance; otherwise, <c>false</c>.</returns>
	public override bool Equals([NotNull] object obj) => ReferenceEquals(this, obj);

	/// <summary>
	/// Returns a hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
	/// </summary>
	/// <returns>A hash code for this instance.</returns>
	[DebuggerStepThrough]
	public override int GetHashCode()
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
	/// Converts an <see cref="AddressRecord"/> to an <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The <see cref="AddressRecord"/> to convert.</param>
	/// <returns>An <see cref="Address"/> instance corresponding to the provided <see cref="AddressRecord"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="address"/> is null.</exception>
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
	/// Converts a <see cref="ValueTypes.Address"/> to an <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The <see cref="ValueTypes.Address"/> to convert.</param>
	/// <returns>An <see cref="Address"/> instance corresponding to the provided <see cref="ValueTypes.Address"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="address"/> is null.</exception>
	public static Address ToAddress([NotNull] ValueTypes.Address address) => new(address.ArgumentNotNull().Id)
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

	/// <summary>
	/// Returns a <see cref="string"/> that represents the current <see cref="Address"/> instance.
	/// </summary>
	/// <returns>A <see cref="string"/> that represents this instance.</returns>
	[DebuggerStepThrough]
	public override string ToString() => this.PropertiesToString(includeMemberName: false);

	/// <summary>
	/// Gets or sets the first line of the address.
	/// </summary>
	/// <value>The first line of the address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is longer than 100 characters.</exception>
	[DataMember(Name = "address1", IsRequired = false, Order = 1)]
	[DefaultValue("")]
	[Display(Name = "Address Line 1")]
	[JsonPropertyName("address1")]
	[MaxLength(100, ErrorMessage = "Address1 cannot exceed 100 characters.")]
	[XmlElement("Address1")]
	public string Address1
	{
		get => this._address1;
		set
		{
			if (string.Equals(this._address1, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 100) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.AddressLengthIsLimitedTo100Characters, nameof(this.Address1));
			}
			else
			{
				this._address1 = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the second line of the address.
	/// </summary>
	/// <value>The second line of the address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is longer than 100 characters.</exception>
	/// <remarks>Address2 is optional and is limited to 100 characters.</remarks>
	[DataMember(Name = "address2", IsRequired = false, Order = 2)]
	[DefaultValue("")]
	[Display(Name = "Address Line 2")]
	[JsonPropertyName("address2")]
	[XmlElement("Address2")]
	public string Address2
	{
		get => this._address2;
		set
		{
			if (string.Equals(this._address2, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 100) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.AddressLengthIsLimitedTo100Characters, nameof(this.Address2));
			}
			else
			{
				this._address2 = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the city name.
	/// </summary>
	/// <value>The name of the city.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is longer than 150 characters.</exception>
	/// <remarks>City name is limited to 150 characters.</remarks>
	[DataMember(Name = "city", IsRequired = false, Order = 3)]
	[Display(Name = "City")]
	[DefaultValue("")]
	[JsonPropertyName("city")]
	[MaxLength(150, ErrorMessage = "City cannot exceed 150 characters.")]
	[XmlElement("City")]
	public string City
	{
		get => this._city;
		set
		{
			if (string.Equals(this._city, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 150) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.CityLengthIsLimitedToCharacters, nameof(this.City));
			}
			else
			{
				this._city = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the country.
	/// </summary>
	/// <value>The country name.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is longer than 50 characters.</exception>
	/// <remarks>Country is limited to 50 characters.</remarks>
	[DataMember(Name = "country", IsRequired = false, Order = 4)]
	[DefaultValue("")]
	[Display(Name = "Country")]
	[JsonPropertyName("country")]
	[MaxLength(50, ErrorMessage = "Country cannot exceed 50 characters.")]
	[XmlElement("Country")]
	public string Country
	{
		get => this._country;
		set
		{
			if (string.Equals(this._country, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.CountryLengthIsLimitedTo50Characters, nameof(this.Country));
			}
			else
			{
				this._country = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the county or province.
	/// </summary>
	/// <value>The county or province.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is longer than 50 characters.</exception>
	/// <remarks>CountyProvince is optional and is limited to 50 characters.</remarks>
	[DataMember(Name = "countyProvince", IsRequired = false, Order = 5)]
	[Display(Name = "County/Province")]
	[JsonPropertyName("countryProvince")]
	[MaxLength(50, ErrorMessage = "CountyProvince cannot exceed 50 characters.")]
	[XmlElement("CountyProvince")]
	public string CountyProvince
	{
		get => this._countyProvince;
		set
		{
			if (string.Equals(this._countyProvince, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value?.Length > 50)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.CountyProvinceLengthIsLimitedTo50Character, nameof(this.CountyProvince));
			}
			else
			{
				this._countyProvince = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the unique identifier for the address record.
	/// </summary>
	/// <value>The unique identifier.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the identifier value is not within the required range.</exception>
	/// <remarks>The identifier is limited to 50 characters and is required for identifying the address record uniquely.</remarks>
	[DataMember(Name = "id", IsRequired = true, Order = 0)]
	[DisallowNull]
	[Display(Name = "Identifier")]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessage = "Id cannot exceed 50 characters.")]
	[ReadOnly(true)]
	[Required(ErrorMessage = "Id is required.")]
	[XmlElement("Id", IsNullable = false)]
	public string Id
	{
		get => this._id;
		init
		{
			if (string.Equals(this._id, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(1, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.IdLengthIsLimitedTo50Characters, nameof(this.Id));
			}
			else
			{
				this._id = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the phone number associated with the address.
	/// </summary>
	/// <value>The phone number.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the phone number is longer than 50 characters.</exception>
	/// <remarks>Phone number is optional and is limited to 50 characters.</remarks>
	[DataMember(Name = "phone", IsRequired = false, Order = 6)]
	[Display(Name = "Phone Number")]
	[DefaultValue("")]
	[JsonPropertyName("phone")]
	[MaxLength(50, ErrorMessage = "Phone number cannot exceed 50 characters.")]
	[XmlElement("Phone")]
	public string Phone
	{
		get => this._phone;
		set
		{
			if (string.Equals(this._phone, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.PhoneNumberIsLimitedTo50Characters, nameof(this.Phone));
			}
			else
			{
				this._phone = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the postal code.
	/// </summary>
	/// <value>The postal code of the address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the postal code is longer than 40 characters.</exception>
	/// <remarks>Postal code is limited to 40 characters.</remarks>
	[DataMember(Name = "postalCode", IsRequired = false, Order = 7)]
	[Display(Name = "Postal Code")]
	[DefaultValue("")]
	[JsonPropertyName("postalCode")]
	[MaxLength(40, ErrorMessage = "Postal code cannot exceed 40 characters.")]
	[XmlElement("PostalCode")]
	public string PostalCode
	{
		get => this._postalCode;
		set
		{
			if (string.Equals(this._postalCode, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 40) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.PostalCodeLengthIsLimitedTo40Characters, nameof(this.PostalCode));
			}
			else
			{
				this._postalCode = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the state or region of the address.
	/// </summary>
	/// <value>The state or region.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the state value is longer than 60 characters.</exception>
	/// <remarks>State is optional and is limited to 60 characters.</remarks>
	[DataMember(Name = "state", IsRequired = false, Order = 8)]
	[Display(Name = "State")]
	[DefaultValue("")]
	[JsonPropertyName("state")]
	[MaxLength(60, ErrorMessage = "State cannot exceed 60 characters.")]
	[XmlElement("State")]
	public string State
	{
		get => this._state;
		set
		{
			if (string.Equals(this._state, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 60) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.StateLengthIsLimitedTo60Characters, nameof(this.State));
			}
			else
			{
				this._state = value;
			}
		}
	}
}
