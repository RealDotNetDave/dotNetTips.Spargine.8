// ***********************************************************************
// Assembly         : dotNetTips.Spargine8.Tester
// Author           : David McCarter
// Created          : 07-17-2019
//
// Last Modified By : David McCarter
// Last Modified On : 02-19-2024
// ***********************************************************************
// <copyright file="Person.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>A real-world type of Person for testing and benchmarking.</summary>
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Person class that implements interfaces and validates data.
/// </summary>
/// <typeparam name="TAddress">The type of the t address.</typeparam>
[DataContract(Name = "person")]
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "Person")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public sealed class Person<TAddress> : IDataModel<Person<TAddress>, string>, IPerson<TAddress> where TAddress : IAddress, new()
{

	/// <summary>
	/// The address collection
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private Collection<TAddress> _addresses = [];

	/// <summary>
	/// The born on date and time.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private DateTimeOffset _bornOn;

	/// <summary>
	/// The cell phone number.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _cellPhone;

	/// <summary>
	/// The email address.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _email;

	/// <summary>
	/// The first name.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _firstName;

	/// <summary>
	/// The home phone number.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _homePhone;

	/// <summary>
	/// The unique identifier.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _id;

	/// <summary>
	/// The last name.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _lastName;

	/// <summary>
	/// Initializes a new instance of the <see cref="Person{TAddress}" /> class.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Person() => this.Id = RandomData.GenerateKey();

	/// <summary>
	/// Initializes a new instance of the <see cref="Person{TAddress}" /> class.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="email">The email.</param>
	public Person([NotNull] string id, [NotNull] string email)
	{
		this.Id = id;
		this.Email = email;
	}

	/// <summary>
	/// Implements the != operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !=(Person<TAddress> left, Person<TAddress> right) => !(left == right);

	/// <summary>
	/// Implements the &lt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <(Person<TAddress> left, Person<TAddress> right) => left is null
		? right is not null
		: left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the &lt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <=(Person<TAddress> left, Person<TAddress> right) => left is null ||
		left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(Person<TAddress> left, Person<TAddress> right) => left is null ? right is null : left.Equals(right);

	/// <summary>
	/// Implements the &gt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >(Person<TAddress> left, Person<TAddress> right) => left is not null &&
		left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the &gt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >=(Person<TAddress> left, Person<TAddress> right) => left is null
		? right is null
		: left.CompareTo(right) >= 0;

	/// <summary>
	/// Calculates the person's age.
	/// </summary>
	/// <returns>TimeSpan.</returns>
	public TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	/// <summary>
	/// Compares to.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>int.</returns>
	public int CompareTo(Person<TAddress> other)
	{
		if (other is null)
		{
			return 1;
		}

		return string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Compares to.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>int.</returns>
	public int CompareTo(IPerson<TAddress> other)
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
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
	/// <exception cref="NotImplementedException"></exception>
	public override bool Equals([NotNull] object obj) => ReferenceEquals(this, obj);

	/// <summary>
	/// Equals the specified other.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="NotImplementedException"></exception>
	public bool Equals([NotNull] Person<TAddress> other) => ReferenceEquals(this, other);

	/// <summary>
	/// Equalses the specified other.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>bool.</returns>
	public bool Equals(IPerson<TAddress> other) => ReferenceEquals(this, other);

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public override int GetHashCode()
	{
		var hash = new HashCode();
		hash.Add(this.Addresses);
		hash.Add(this.BornOn);
		hash.Add(this.CellPhone);
		hash.Add(this.Email);
		hash.Add(this.FirstName);
		hash.Add(this.Phone);
		hash.Add(this.Id);
		hash.Add(this.LastName);

		return hash.ToHashCode();
	}

	/// <summary>
	/// Converts to <see cref="ValueTypes.Person{TAddress}" /> to <see cref="Person{TAddress}" />.
	/// </summary>
	/// <param name="person">The person.</param>
	/// <returns>DotNetTips.Spargine.Tester.Models.RefTypes.Person.</returns>
	public static Person<Address> ToPerson(ValueTypes.Person<ValueTypes.Address> person)
	{
		person = person.ArgumentNotNull();

		Person<Address> newPerson = new()
		{
			Id = person.Id,
			Email = person.Email,
			FirstName = person.FirstName,
			LastName = person.LastName,
			BornOn = person.BornOn,
			CellPhone = person.CellPhone,
			Phone = person.Phone,
		};

		if (person.Addresses.HasItems())
		{
			foreach (var address in person.Addresses)
			{
				newPerson.Addresses.Add(Address.ToAddress(address));

			}
		}

		return newPerson;
	}

	/// <summary>
	/// Converts <see cref="PersonRecord" /> .
	/// </summary>
	/// <param name="person">The person.</param>
	/// <returns>DotNetTips.Spargine.Tester.Models.RefTypes.Person.</returns>
	public static Person<Address> ToPerson(PersonRecord person)
	{
		person = person.ArgumentNotNull();

		Person<Address> newPerson = new(person.Id, person.Email)
		{
			FirstName = person.FirstName,
			LastName = person.LastName,
			BornOn = person.BornOn,
			CellPhone = person.CellPhone,
			Phone = person.HomePhone,
		};

		if (person.Addresses.HasItems())
		{
			foreach (var address in person.Addresses)
			{
				newPerson.Addresses.Add(Address.ToAddress(address));

			}
		}

		return newPerson;
	}

	/// <summary>
	/// Returns a <see cref="string" /> that represents this instance.
	/// </summary>
	/// <returns>A <see cref="string" /> that represents this instance.</returns>
	public override string ToString() => this.PropertiesToString();

	/// <summary>
	/// Gets a collection of <see cref="Address" /> for a Person.
	/// </summary>
	/// <value>The addresses.</value>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[XmlIgnore]
	public Collection<TAddress> Addresses
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
	public Collection<TAddress> AddressesSerilization
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
	/// Gets the age of the person.
	/// </summary>
	/// <value>The age.</value>
	[JsonIgnore]
	[XmlIgnore]
	public TimeSpan Age => this.CalculateAge();

	/// <summary>
	/// Gets or sets the born on date and time.
	/// </summary>
	/// <value>The born on.</value>
	/// <exception cref="ArgumentOutOfRangeException">BornOn cannot be in the future.</exception>
	[DataMember(Name = "bornOn", IsRequired = false)]
	[JsonPropertyName("bornOn")]
	[XmlElement]
	public DateTimeOffset BornOn
	{
		get => this._bornOn;

		set
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
	/// <value>The cell phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">CellPhone is limited
	/// to 50 characters.</exception>
	/// <remarks>Cell phone number is limited to 50 characters.</remarks>
	[DataMember(Name = "cellPhone", IsRequired = false)]
	[JsonPropertyName("cellPhone")]
	[XmlElement]
	public string CellPhone
	{
		get => this._cellPhone;

		set
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
	/// Gets the email address.
	/// </summary>
	/// <value>The email.</value>
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

		set
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
		set
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
	/// Gets the identifier.
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
		set
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

	/// <summary>
	/// Gets or sets the home phone.
	/// </summary>
	/// <value>The home phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">Phone is limted
	/// to 50 characters.</exception>
	/// <remarks>Home phone is limited to 50 characters.</remarks>
	[DataMember(Name = "homePhone", IsRequired = false)]
	[JsonPropertyName("homePhone")]
	[XmlElement]
	public string Phone
	{
		get => this._homePhone;
		set
		{
			if (string.Equals(this._homePhone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._homePhone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Phone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}

}
