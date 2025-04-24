// ***********************************************************************
// Assembly         : dotNetTips.Spargine8.Tester
// Author           : David McCarter
// Created          : 07-17-2019
//
// Last Modified By : David McCarter
// Last Modified On : 04-24-2025
// ***********************************************************************
// <copyright file="Person.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// A real-world type for testing and benchmarking named "Person" with
// the following properties: Addresses, Age, BornOn, CellPhone,
// Email, FirstName, FullName, LastName, and Phone. This type also
// includes methods to convert from PersonRecord and Person value
// types to Person.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Represents a person with various personal details and a collection of addresses.
/// This class is sealed to prevent inheritance, ensuring a consistent representation of a person across the application.
/// It implements IDataModel{Person{TAddress}, string} and <see cref="IPerson{TAddress}"/>,
/// indicating it can serve as a data model with a string identifier and has person-specific properties.
/// </summary>
/// <typeparam name="TAddress">The type of address this person can have, constrained to types that implement <see cref="IAddress"/>.</typeparam>
[DataContract(Name = "person", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "Person", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public sealed class Person<TAddress> : IDataModel<Person<TAddress>, string>, IPerson<TAddress>
	where TAddress : IAddress, new()
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
	/// The home phone number.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _phone;

	/// <summary>
	/// Initializes a new instance of the <see cref="Person{TAddress}"/> class.
	/// This parameterless constructor is primarily used for serialization.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Person()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Person{TAddress}"/> class with specified id and email.
	/// </summary>
	/// <param name="id">The unique identifier for the person.</param>
	/// <param name="email">The email address of the person.</param>
	/// <exception cref="ValidationException">Thrown when <paramref name="id"/> or <paramref name="email"/> is null or empty.</exception>
	[JsonConstructor]
	[Information(nameof(Person<TAddress>), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Person([NotNull, EmailAddress(ErrorMessage = "The email address is not in a valid format."), MaxLength(75, ErrorMessage = "Email length is limited to 75 characters.")] string email, [NotNull, MaxLength(50, ErrorMessage = "Id length is limited to 50 characters.")] string id)
	{
		this.Email = email.ArgumentNotNullOrEmpty();
		this.Id = id.ArgumentNotNullOrEmpty();
	}

	/// <summary>
	/// Determines whether two specified instances of <see cref="Person{TAddress}"/> are not equal.
	/// </summary>
	/// <param name="left">The first instance of <see cref="Person{TAddress}"/>.</param>
	/// <param name="right">The second instance of <see cref="Person{TAddress}"/>.</param>
	/// <returns>true if <paramref name="left"/> and <paramref name="right"/> do not represent the same value; otherwise, false.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator !=(Person<TAddress> left, Person<TAddress> right) => !(left == right);

	/// <summary>
	/// Implements the less than operator. Determines whether the left instance is less than the right instance.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Person{TAddress}"/>.</param>
	/// <param name="right">The right instance of <see cref="Person{TAddress}"/>.</param>
	/// <returns>true if the left instance is less than the right instance; otherwise, false.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <(Person<TAddress> left, Person<TAddress> right) => left is null
		? right is not null
		: left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the less than or equal to operator. Determines whether the left instance is less than or equal to the right instance.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Person{TAddress}"/>.</param>
	/// <param name="right">The right instance of <see cref="Person{TAddress}"/>.</param>
	/// <returns>true if the left instance is less than or equal to the right instance; otherwise, false.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <=(Person<TAddress> left, Person<TAddress> right) => left is null ||
		left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the equality operator. Determines whether the specified instances of <see cref="Person{TAddress}"/> are equal.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Person{TAddress}"/>.</param>
	/// <param name="right">The right instance of <see cref="Person{TAddress}"/>.</param>
	/// <returns>true if both instances are null or if they represent the same value; otherwise, false.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator ==(Person<TAddress> left, Person<TAddress> right) => left is null
		? right is null
		: left.Equals(right);

	/// <summary>
	/// Implements the greater than operator. Determines whether the left instance is greater than the right instance.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Person{TAddress}"/>.</param>
	/// <param name="right">The right instance of <see cref="Person{TAddress}"/>.</param>
	/// <returns>true if the left instance is greater than the right instance; otherwise, false.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >(Person<TAddress> left, Person<TAddress> right) => left is not null &&
		left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the greater than or equal to operator. Determines whether the left instance is greater than or equal to the right instance.
	/// </summary>
	/// <param name="left">The left instance of <see cref="Person{TAddress}"/>.</param>
	/// <param name="right">The right instance of <see cref="Person{TAddress}"/>.</param>
	/// <returns>true if the left instance is greater than or equal to the right instance; otherwise, false.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >=(Person<TAddress> left, Person<TAddress> right) => left is null
		? right is null
		: left.CompareTo(right) >= 0;


	/// <summary>
	/// Explicitly converts a <see cref="PersonRecord"/> to a <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="person">The <see cref="PersonRecord"/> instance to convert.</param>
	/// <returns>A new <see cref="Person{TAddress}"/> instance representing the converted person.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="person"/> is null.</exception>
	[return: NotNull]
	public static explicit operator Person<TAddress>(PersonRecord person)
		=> ToPerson(person);

	///<summary>
	/// Explicitly converts a <see cref="ValueTypes.Person{TAddress}"/> to a <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="person">The <see cref="ValueTypes.Person{TAddress}"/> instance to convert.</param>
	/// <returns>A new <see cref="Person{TAddress}"/> instance representing the converted person.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="person"/> is null.</exception>
	[return: NotNull]
	public static explicit operator Person<TAddress>(ValueTypes.Person<ValueTypes.Address> person)
		=> ToPerson(person);

	/// <summary>
	/// Calculates the age of the person based on their birth date and the current UTC date.
	/// </summary>
	/// <returns>The age of the person as a <see cref="TimeSpan"/>.</returns>
	[Information(nameof(CalculateAge), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	/// <summary>
	/// Compares this instance with a specified <see cref="Person{TAddress}"/> object and indicates whether this instance
	/// precedes, follows, or appears in the same position in the sort order as the specified <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="other">The <see cref="Person{TAddress}"/> to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings:
	/// Less than zero: This instance precedes <paramref name="other"/> in the sort order.
	/// Zero: This instance occurs in the same position in the sort order as <paramref name="other"/>.
	/// Greater than zero: This instance follows <paramref name="other"/> in the sort order.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="other"/> is null.</exception>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CompareTo([NotNull] Person<TAddress> other) => other is null ? 1 : string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Compares this instance with a specified <see cref="IPerson{TAddress}"/> object and indicates whether this instance
	/// precedes, follows, or appears in the same position in the sort order as the specified <see cref="IPerson{TAddress}"/>.
	/// </summary>
	/// <param name="other">The <see cref="IPerson{TAddress}"/> to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings:
	/// Less than zero: This instance precedes <paramref name="other"/> in the sort order.
	/// Zero: This instance occurs in the same position in the sort order as <paramref name="other"/>.
	/// Greater than zero: This instance follows <paramref name="other"/> in the sort order.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="other"/> is null.</exception>
	[Information(nameof(CalculateAge), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CompareTo([DisallowNull] IPerson<TAddress> other) => other is null ? 1 : string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Determines whether the specified object is equal to the current instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified object is equal to the current instance; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override bool Equals(object obj) => ReferenceEquals(this, obj);

	/// <summary>
	/// Determines whether the specified <see cref="Person{TAddress}"/> is equal to the current <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="other">The <see cref="Person{TAddress}"/> to compare with the current <see cref="Person{TAddress}"/>.</param>
	/// <returns><c>true</c> if the specified <see cref="Person{TAddress}"/> is equal to the current <see cref="Person{TAddress}"/>; otherwise, <c>false</c>.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool Equals([NotNull] Person<TAddress> other) => ReferenceEquals(this, other);

	/// <summary>
	/// Determines whether the specified <see cref="IPerson{TAddress}"/> is equal to the current <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="other">The <see cref="IPerson{TAddress}"/> to compare with the current <see cref="Person{TAddress}"/>.</param>
	/// <returns><c>true</c> if the specified <see cref="IPerson{TAddress}"/> is equal to the current <see cref="Person{TAddress}"/>; otherwise, <c>false</c>.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Information(nameof(Equals), Status = Status.Available)]
	public bool Equals([NotNull] IPerson<TAddress> other) => ReferenceEquals(this, other);

	/// <summary>
	/// Returns a hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
	/// </summary>
	/// <returns>A hash code for this instance.</returns>
	[Information(nameof(GetHashCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override int GetHashCode() => HashCode.Combine(this.Id, this.Email, this.FirstName, this.LastName);

	/// <summary>
	/// Converts to <see cref="ValueTypes.Person{TAddress}"/> to <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="person">The person.</param>
	/// <returns>DotNetTips.Spargine.Tester.Models.RefTypes.Person.</returns>
	[return: NotNull]
	[Information(nameof(ToPerson), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Person<TAddress> ToPerson([NotNull] in ValueTypes.Person<ValueTypes.Address> person)
	{
		_ = person.ArgumentNotNull();

		Person<TAddress> newPerson = new()
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
				newPerson.Addresses.Add((TAddress)(object)Address.ToAddress(address));
			}
		}

		return newPerson;
	}

	/// <summary>
	/// Converts a <see cref="PersonRecord"/> to a <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="person">The <see cref="PersonRecord"/> to convert.</param>
	/// <returns>A new instance of <see cref="Person{TAddress}"/> based on the provided <see cref="PersonRecord"/>.</returns>
	[return: NotNull]
	[Information(nameof(ToPerson), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Person<TAddress> ToPerson([NotNull] in PersonRecord person)
	{
		_ = person.ArgumentNotNull();

		Person<TAddress> newPerson = new(person.Email, person.Id)
		{
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
				newPerson.Addresses.Add((TAddress)(object)Address.ToAddress(address));
			}
		}

		return newPerson;
	}

	/// <summary>
	/// Returns a string that represents the current object, using PropertiesToString for a detailed representation.
	/// </summary>
	/// <returns>A string that represents the current object.</returns>
	[DebuggerStepThrough]
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString() => this.PropertiesToString(includeMemberName: false);

	/// <summary>
	/// Gets or sets the collection of addresses associated with the person.
	/// </summary>
	/// <value>The collection of <typeparamref name="TAddress"/> objects representing the addresses of the person.</value>
	/// <remarks>
	/// This property is serialized and deserialized using JSON but is ignored in XML serialization.
	/// Use <see cref="AddressesSerialization"/> for XML serialization.
	/// </remarks>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[XmlIgnore]
	[Information(nameof(Addresses), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	/// Gets or sets the addresses for XML serialization only.
	/// </summary>
	/// <value>The addresses serialization.</value>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[JsonIgnore]
	[XmlArray("Addresses")]
	[Preserve(PreserveReason.Other, "Preserve for XML serialization.", "4/24/2005", "David McCarter")]
	[Information(nameof(AddressesSerialization), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Collection<TAddress> AddressesSerialization
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
	/// Gets the age of the person calculated from the <see cref="BornOn"/> date.
	/// </summary>
	/// <value>The age as a <see cref="TimeSpan"/>.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	[Information(nameof(CalculateAge), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan Age => this.CalculateAge();

	/// <summary>
	/// Gets or sets the date and time when the person was born.
	/// </summary>
	/// <value>The birth date and time of the person.</value>
	/// <remarks>
	/// This property is serialized with the name "bornOn" and is required for XML serialization.
	/// It is marked with MemberNotNullAttribute to indicate that the backing field <c>_bornOn</c> will not be null after being set.
	/// </remarks>
	[DataMember(Name = "bornOn", IsRequired = false)]
	[JsonPropertyName("bornOn")]
	[XmlElement("BornOn")]
	[Information(nameof(BornOn), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public DateTimeOffset BornOn
	{
		get => this._bornOn;

		set
		{
			if (this._bornOn == value)
			{
				return;
			}

			if (value.ToUniversalTime() > DateTimeOffset.UtcNow)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.PersonBornOnCannotBeInTheFuture, nameof(this.BornOn));
			}
			else
			{
				this._bornOn = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the cell phone number of the person.
	/// </summary>
	/// <value>The cell phone number.</value>
	/// <remarks>
	/// The cell phone number is limited to 50 characters. It can be left empty.
	/// </remarks>
	[DataMember(Name = "cellPhone", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("cellPhone")]
	[MaxLength(50, ErrorMessage = "Cell phone number cannot exceed 50 characters.")]
	[Phone(ErrorMessage = "The cell phone number is not in a valid format.")]
	[XmlElement("CellPhone")]
	[Information(nameof(CellPhone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CellPhone
	{
		get => this._cellPhone;

		set
		{
			if (string.Equals(this._cellPhone, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.PhoneNumberIsLimitedTo50Characters, nameof(this.CellPhone));
			}
			else
			{
				this._cellPhone = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the email address of the person.
	/// </summary>
	/// <value>The email address.</value>
	/// <remarks>
	/// The email address is required and must be a valid email format. It is limited to 75 characters.
	/// This property is read-only and serialized with the name "email".
	/// </remarks>
	[DataMember(Name = "email", IsRequired = true)]
	[DefaultValue("")]
	[DisallowNull]
	[EmailAddress(ErrorMessage = "The email address is not in a valid format.")]
	[JsonPropertyName("email")]
	[MaxLength(75, ErrorMessage = "Email length is limited to 75 characters.")]
	[XmlElement("Email", IsNullable = false)]
	[Information(nameof(Email), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Email
	{
		get => this._email;

		set
		{
			if (string.Equals(this._email, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 75) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.EmailLengthIsLimitedTo75Characters, nameof(this.Email));
			}
			else
			{
				this._email = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the first name of the person.
	/// </summary>
	/// <value>The first name.</value>
	/// <remarks>
	/// The first name is limited to 50 characters. It is serialized with the name "firstName".
	/// </remarks>
	[DataMember(Name = "firstName", IsRequired = true)]
	[DefaultValue("")]
	[JsonPropertyName("firstName")]
	[MaxLength(50, ErrorMessage = "First name length is limited to 50 characters.")]
	[XmlElement("FirstName")]
	[Information(nameof(FirstName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FirstName
	{
		get => this._firstName;
		set
		{
			if (string.Equals(this._firstName, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.FirstNameLengthIsLimitedTo50Characters, nameof(this.FirstName));
			}
			else
			{
				this._firstName = value;
			}
		}
	}

	/// <summary>
	/// Gets the full name of the person by concatenating the first name and the last name.
	/// </summary>
	/// <value>The full name of the person.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	[Information(nameof(FullName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FullName => $"{this.FirstName} {this.LastName}";

	/// <summary>
	/// Gets the unique identifier for the person.
	/// </summary>
	/// <value>The unique identifier.</value>
	/// <remarks>
	/// The ID is a read-only property that is set at the time of object creation.
	/// It is serialized with the name "id" and is required for data exchange processes.
	/// </remarks>
	[DataMember(Name = "id", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessage = "Id length is limited to 50 characters.")]
	[ReadOnly(true)]
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
	/// Gets or sets the last name of the person.
	/// </summary>
	/// <value>The last name.</value>
	/// <remarks>
	/// The last name is limited to 50 characters. It is serialized with the name "lastName".
	/// </remarks>
	[DataMember(Name = "lastName", IsRequired = true)]
	[DefaultValue("")]
	[JsonPropertyName("lastName")]
	[MaxLength(50, ErrorMessage = "Last name length is limited to 50 characters.")]
	[XmlElement("LastName")]
	[Information(nameof(LastName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string LastName
	{
		get => this._lastName;
		set
		{
			if (string.Equals(this._lastName, value, StringComparison.Ordinal))
			{
				return;
			}

			if (value.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.LastNameLengthIsLimitedTo50Characters, nameof(this.LastName));
			}
			else
			{
				this._lastName = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the home phone number.
	/// </summary>
	/// <value>The home phone number.</value>
	/// <remarks>
	/// The home phone number is limited to 50 characters. It is serialized with the name "homePhone".
	/// </remarks>
	[DataMember(Name = "homePhone", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("homePhone")]
	[MaxLength(50)]
	[XmlElement("Phone")]
	[Information(nameof(Phone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
}
