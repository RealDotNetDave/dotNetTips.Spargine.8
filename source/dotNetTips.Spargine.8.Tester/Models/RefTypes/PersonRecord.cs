// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2024
// ***********************************************************************
// <copyright file="PersonRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary> A real-world type for testing and benchmarking named "PersonRecord" with the following properties: Addresses, Age, BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone. Additionally, this type includes methods to convert from both Person reference and value types to PersonRecord.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Class Person with proper encapsulation and validation.
/// Implements the <see cref="IDataRecord" />
/// </summary>
[DataContract(Name = "personRecord")]
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "PersonRecord")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public sealed record PersonRecord : IDataRecord, IComparable<PersonRecord>
{

	/// <summary>
	/// The addresses
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private Collection<AddressRecord> _addresses = [];

	/// <summary>
	/// The born on
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private DateTimeOffset _bornOn;

	/// <summary>
	/// The cell phone number
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _cellPhone;

	/// <summary>
	/// The email
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _email;

	/// <summary>
	/// The first name
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _firstName;

	/// <summary>
	/// The home phone number
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _homePhone;

	/// <summary>
	/// The identifier
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _id;

	/// <summary>
	/// The last name
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _lastName;

	/// <summary>
	/// Prevents a default instance of the <see cref="PersonRecord" /> class from being created.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PersonRecord() => this.Id = RandomData.GenerateKey();

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonRecord" /> class.
	/// </summary>
	/// <param name="email">The email.</param>
	/// <param name="id">The identifier.</param>
	public PersonRecord([NotNull] string email, [NotNull] string id)
	{
		this.Email = email;
		this.Id = id;
	}

	/// <summary>
	/// Implements the &lt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <(PersonRecord left, PersonRecord right) => left is null ? right is not null : left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the &lt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <=(PersonRecord left, PersonRecord right) => left is null || left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the &gt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >(PersonRecord left, PersonRecord right) => left is not null && left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the &gt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >=(PersonRecord left, PersonRecord right) => left is null ? right is null : left.CompareTo(right) >= 0;

	/// <summary>
	/// Calculates the person's age.
	/// </summary>
	/// <returns>TimeSpan.</returns>
	public TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	/// <summary>
	/// Compares to.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>System.Int32.</returns>
	public int CompareTo(PersonRecord other)
	{
		if (other is null)
		{
			return 1;
		}

		return string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Converts to <see cref="ValueTypes.Person{TAddress}" /> to <see cref="PersonRecord" />
	/// </summary>
	/// <param name="person">The person.</param>
	/// <returns>DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.</returns>
	public static PersonRecord ToPersonRecord(ValueTypes.Person<ValueTypes.Address> person)
	{
		person = person.ArgumentNotNull();

		PersonRecord newPerson = new()
		{
			Id = person.Id,
			Email = person.Email,
			FirstName = person.FirstName,
			LastName = person.LastName,
			BornOn = person.BornOn,
			CellPhone = person.CellPhone,
			HomePhone = person.Phone,
		};

		if (person.Addresses.HasItems())
		{
			foreach (var address in person.Addresses)
			{
				newPerson.Addresses.Add(AddressRecord.ToAddress(address));
			}
		}

		return newPerson;
	}

	/// <summary>
	/// Converts to <see cref="Person{TAddress}" /> to <see cref="PersonRecord" />
	/// </summary>
	/// <param name="person">The person.</param>
	/// <returns>DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.</returns>
	public static PersonRecord ToPersonRecord(Person<Address> person)
	{
		person = person.ArgumentNotNull();

		PersonRecord newPerson = new()
		{
			Id = person.Id,
			Email = person.Email,
			FirstName = person.FirstName,
			LastName = person.LastName,
			BornOn = person.BornOn,
			CellPhone = person.CellPhone,
			HomePhone = person.Phone,
		};

		if (person.Addresses.HasItems())
		{
			foreach (var address in person.Addresses)
			{
				newPerson.Addresses.Add(AddressRecord.ToAddress(address));
			}
		}

		return newPerson;
	}
	/// <summary>
	/// Converts to string.
	/// </summary>
	/// <returns>string.</returns>
	public override string ToString() => this.PropertiesToString();

	/// <summary>
	/// Gets a collection of <see cref="Address" /> for a Person.
	/// </summary>
	/// <value>The addresses.</value>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[XmlIgnore]
	public Collection<AddressRecord> Addresses
	{
		get => this._addresses;

		set
		{
			var addressCollection = value;

			if (this._addresses == addressCollection)
			{
				return;
			}

			this._addresses = [.. addressCollection];
		}
	}

	/// <summary>
	/// Gets or sets the addresses for XML serilization only.
	/// </summary>
	/// <value>The addresses serilization.</value>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlArray("Addresses")]
	[JsonIgnore]
	public Collection<AddressRecord> AddressesSerilization
	{
		get => this._addresses;

		set
		{
			var addressCollection = value;

			if (this.Addresses.Equals(addressCollection))
			{
				return;
			}
			else
			{
				this._addresses = [.. addressCollection];
			}
		}
	}

	/// <summary>
	/// Gets the age of the person.
	/// </summary>
	/// <value>The age.</value>
	[JsonIgnore]
	[XmlIgnore]
	public TimeSpan Age => this.CalculateAge();

	/// <summary>
	/// Gets or sets the born on date.
	/// </summary>
	/// <value>The born on date.</value>
	/// <exception cref="ArgumentOutOfRangeException">BornOn cannot be in the future.</exception>
	[DataMember(Name = "bornOn", IsRequired = false)]
	[JsonPropertyName("bornOn")]
	[XmlElement]
	public DateTimeOffset BornOn
	{
		get => this._bornOn;
		init
		{
			if (this._bornOn == value)
			{
				return;
			}

			this._bornOn = value.ToUniversalTime() > DateTimeOffset.UtcNow
				? throw new ArgumentOutOfRangeException(
					nameof(this.BornOn),
					Resources.PersonBornOnCannotBeInTheFuture)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	/// <exception cref="ArgumentOutOfRangeException">CellPhone is limited
	/// to 50 characters.</exception>
	/// <remarks>Cell phone number is limited to 50 characters.</remarks>
	[DataMember(Name = "cellPhone", IsRequired = false)]
	[JsonPropertyName("cellPhone")]
	[XmlElement]
	public string CellPhone
	{
		get => this._cellPhone;
		init
		{
			if (string.Equals(this._cellPhone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._cellPhone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.CellPhone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the email address.
	/// </summary>
	/// <value>The email address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Email is limited
	/// to 75 characters.</exception>
	/// <remarks>Email is limited to 75 characters.</remarks>
	[DataMember(Name = "email", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("email")]
	[XmlElement(IsNullable = false)]
	public string Email
	{
		get => this._email;
		init
		{
			if (string.Equals(this._email, value, StringComparison.Ordinal))
			{
				return;
			}

			this._email = value.HasValue(0, 75) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Email),
					Resources.EmailLengthIsLimitedTo75Characters)
				: value;
		}
	}
	//#endif
	/// <summary>
	/// Gets or sets the first name.
	/// </summary>
	/// <value>The first name.</value>
	/// <exception cref="ArgumentOutOfRangeException">First name is limted
	/// to 50 characters.</exception>
	/// <remarks>Firt name is limited to 50 characters.</remarks>
	[DataMember(Name = "firstName", IsRequired = false)]
	[JsonPropertyName("firstName")]
	[XmlElement]
	public string FirstName
	{
		get => this._firstName;
		init
		{
			if (string.Equals(this._firstName, value, StringComparison.Ordinal))
			{
				return;
			}

			this._firstName = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.FirstName),
					Resources.FirstNameLengthIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets the full name of the person.
	/// </summary>
	/// <value>The full name.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	public string FullName => $"{this.FirstName} {this.LastName}";

	/// <summary>
	/// Gets or sets the home phone number.
	/// </summary>
	/// <value>The home phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">Phone is limted
	/// to 50 characters.</exception>
	/// <remarks>Home phone is limited to 50 characters.</remarks>
	[DataMember(Name = "homePhone", IsRequired = false)]
	[JsonPropertyName("homePhone")]
	[XmlElement]
	public string HomePhone
	{
		get => this._homePhone;
		init
		{
			if (string.Equals(this._homePhone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._homePhone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.HomePhone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	/// <exception cref="ArgumentOutOfRangeException">Id is limited
	/// to 50 characters.</exception>
	/// <remarks>Id is limited to 50 characters.</remarks>
	[DataMember(Name = "id", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("id")]
	[XmlElement(IsNullable = false)]
	public string Id
	{
		get => this._id;
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
	/// Gets or sets the last name.
	/// </summary>
	/// <value>The last name.</value>
	/// <exception cref="ArgumentOutOfRangeException">LastName is limited
	/// to 50 characters.</exception>
	/// <remarks>Last name is limited to 50 characters.</remarks>
	[DataMember(Name = "lastName", IsRequired = false)]
	[JsonPropertyName("lastName")]
	[XmlElement]
	public string LastName
	{
		get => this._lastName;
		init
		{
			if (string.Equals(this._lastName, value, StringComparison.Ordinal))
			{
				return;
			}

			this._lastName = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.LastName),
					Resources.LastNameLengthIsLimitedTo50Characters)
				: value;
		}
	}

}
