// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-13-2025
// ***********************************************************************
// <copyright file="AddressRecord.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Record type with properties for Address1 and Address2, City, Country,
// CountryProvince, Phone, PostalCode, and State. This type inherits
// from the interface IAddress.
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
/// Represents an address record with detailed information such as address lines, city, state, country, postal code, and phone number.
/// This record is designed to be used in various scenarios where address information is required.
/// </summary>
[DataContract(Name = "addressRecord", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[DebuggerDisplay("Id = {Id}, Address1 = {Address1}, City = {City}, Country = {Country}")]
[Serializable]
[XmlRoot(ElementName = "AddressRecord", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public sealed record AddressRecord : IDataRecord
{
	/// <summary>
	/// The address1
	/// </summary>
	[NonSerialized]
	[JsonIgnore]
	private string _address1;

	/// <summary>
	/// The address2
	/// </summary>
	[NonSerialized]
	[JsonIgnore]
	private string _address2;

	/// <summary>
	/// The city
	/// </summary>
	[NonSerialized]
	[JsonIgnore]
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
	[NonSerialized]
	[JsonIgnore]
	private string _countyProvince;

	/// <summary>
	/// The identifier
	/// </summary>
	[NonSerialized]
	[JsonIgnore]
	private string _id;

	/// <summary>
	/// The phone
	/// </summary>
	[NonSerialized]
	[JsonIgnore]
	private string _phone;

	/// <summary>
	/// The postal code
	/// </summary>
	[NonSerialized]
	[JsonIgnore]
	private string _postalCode;

	/// <summary>
	/// The state
	/// </summary>
	[NonSerialized]
	[JsonIgnore]
	private string _state;

	/// <summary>
	/// Initializes a new instance of the <see cref="AddressRecord"/> class.
	/// This constructor is used to create an empty instance of an AddressRecord.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AddressRecord()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AddressRecord"/> class with a specified identifier.
	/// </summary>
	/// <param name="id">The unique identifier for the address record.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="id"/> is null.</exception>
	[JsonConstructor]
	[Information(nameof(AddressRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AddressRecord([NotNull] string id) => this.Id = id.ArgumentNotNull();

	/// <summary>
	/// Initializes a new instance of the <see cref="AddressRecord"/> class with specified details.
	/// </summary>
	/// <param name="id">The unique identifier for the address record.</param>
	/// <param name="address1">The first line of the address.</param>
	/// <param name="address2">The second line of the address (optional).</param>
	/// <param name="city">The city of the address.</param>
	/// <param name="state">The state of the address.</param>
	/// <param name="countyProvince">The county or province of the address (optional).</param>
	/// <param name="country">The country of the address.</param>
	/// <param name="postalCode">The postal code of the address.</param>
	/// <param name="phone">The phone number associated with the address (optional).</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="id"/> is null.</exception>
	[Information(nameof(AddressRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AddressRecord([NotNull] string id, string address1, string address2, string city, string state, string countyProvince, string country, string postalCode, string phone) : this(id)
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
	/// Explicitly converts an <see cref="Address"/> to an <see cref="AddressRecord"/>.
	/// </summary>
	/// <param name="address">The <see cref="Address"/> instance to convert.</param>
	/// <returns>An <see cref="AddressRecord"/> instance corresponding to the provided <see cref="Address"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="address"/> is null.</exception>
	[return: NotNull]
	public static explicit operator AddressRecord(Address address)
		=> ToAddress(address);

	/// <summary>
	/// Explicitly converts a <see cref="ValueTypes.Address"/> to an <see cref="AddressRecord"/>.
	/// </summary>
	/// <param name="address">The <see cref="ValueTypes.Address"/> instance to convert.</param>
	/// <returns>An <see cref="AddressRecord"/> instance corresponding to the provided <see cref="ValueTypes.Address"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="address"/> is null.</exception>
	[return: NotNull]
	public static explicit operator AddressRecord(ValueTypes.Address address)
		=> ToAddress(address);

	/// <summary>
	/// Converts an <see cref="Address"/> object to an <see cref="AddressRecord"/> object.
	/// </summary>
	/// <param name="address">The address object to convert.</param>
	/// <returns>An instance of <see cref="AddressRecord"/> initialized with values from the provided <see cref="Address"/> object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="address"/> is null.</exception>
	[Information(nameof(ToAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static AddressRecord ToAddress([NotNull] Address address) => new(address.ArgumentNotNull().Id)
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
	/// Converts a <see cref="ValueTypes.Address"/> object to an <see cref="AddressRecord"/> object.
	/// </summary>
	/// <param name="address">The <see cref="ValueTypes.Address"/> object to convert.</param>
	/// <returns>An instance of <see cref="AddressRecord"/> initialized with values from the provided <see cref="ValueTypes.Address"/> object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="address"/> is null.</exception>
	[Information(nameof(ToAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static AddressRecord ToAddress([NotNull] ValueTypes.Address address) => new(address.ArgumentNotNull().Id)
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
	/// Gets or sets the first line of the address.
	/// </summary>
	/// <value>The first line of the address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the value is longer than 100 characters.</exception>
	[DataMember(Name = "address2", IsRequired = false, Order = 2)]
	[Display(Name = "Address Line 2")]
	[JsonPropertyName("address2")]
	[MaxLength(100, ErrorMessage = "Address2 cannot exceed 100 characters.")]
	[StringLength(100, ErrorMessage = "The second line of the address must not exceed 100 characters.")]
	[XmlElement("Address2")]
	[Information(nameof(Address1), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Address1
	{
		get => this._address1;
		init
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
	[MaxLength(100, ErrorMessage = "Address2 cannot exceed 100 characters.")]
	[XmlElement("Address2")]
	[Information(nameof(Address2), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Address2
	{
		get => this._address2;
		init
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
	[JsonPropertyName("city")]
	[MaxLength(150, ErrorMessage = "City cannot exceed 150 characters.")]
	[StringLength(50, ErrorMessage = "The city must not exceed 50 characters.")]
	[XmlElement("City")]
	[Information(nameof(City), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string City
	{
		get => this._city;
		init
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
	[Display(Name = "Country")]
	[JsonPropertyName("country")]
	[MaxLength(50, ErrorMessage = "Country cannot exceed 50 characters.")]
	[StringLength(50, ErrorMessage = "The country must not exceed 50 characters.")]
	[XmlElement("Country")]
	[Information(nameof(Country), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Country
	{
		get => this._country;
		init
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
	[JsonPropertyName("countyProvince")]
	[MaxLength(50, ErrorMessage = "CountyProvince cannot exceed 50 characters.")]
	[StringLength(50, ErrorMessage = "The county or province must not exceed 50 characters.")]
	[XmlElement("CountyProvince")]
	[Information(nameof(CountyProvince), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CountyProvince
	{
		get => this._countyProvince;
		init
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
	[Information(nameof(Id), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[JsonPropertyName("phone")]
	[MaxLength(50, ErrorMessage = "Phone number cannot exceed 50 characters.")]
	[Phone(ErrorMessage = "The phone number is not in a valid format.")]
	[XmlElement("Phone")]
	[Information(nameof(Phone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Phone
	{
		get => this._phone;
		init
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
	/// <value>The postal code.</value>
	/// <exception cref="ArgumentOutOfRangeException">PostalCode</exception>
	/// <remarks>Postal code is limited to 20 characters.</remarks>
	[DataMember(Name = "postalCode", IsRequired = false, Order = 7)]
	[Display(Name = "Postal Code")]
	[JsonPropertyName("postalCode")]
	[MaxLength(20, ErrorMessage = "Postal code cannot exceed 20 characters.")]
	[StringLength(20, ErrorMessage = "The postal code must not exceed 20 characters.")]
	[XmlElement("PostalCode")]
	[Information(nameof(PostalCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string PostalCode
	{
		get => this._postalCode;
		init
		{
			if (string.Equals(this._postalCode, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 20) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.PostalCodeLengthIsLimitedToCharacters, nameof(this.PostalCode));
			}
			else
			{
				this._postalCode = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the state.
	/// </summary>
	/// <value>The state.</value>
	/// <exception cref="ArgumentOutOfRangeException">State</exception>
	/// <remarks>State is limited to 50 characters.</remarks>
	[DataMember(Name = "state", IsRequired = false, Order = 8)]
	[Display(Name = "State")]
	[JsonPropertyName("state")]
	[MaxLength(50, ErrorMessage = "State cannot exceed 60 characters.")]
	[StringLength(50, ErrorMessage = "The state or region must not exceed 50 characters.")]
	[XmlElement("State")]
	[Information(nameof(State), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string State
	{
		get => this._state;
		init
		{
			if (string.Equals(this._state, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.StateLengthIsLimitedToCharacters, nameof(this.State));
			}
			else
			{
				this._state = value;
			}
		}
	}
}
