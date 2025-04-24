// ***********************************************************************
// Assembly         : dotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 10-25-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-24-2025
// ***********************************************************************
// <copyright file="Person.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// A real-world value type crafted for testing and benchmarking,
// named "Person," encompassing properties such as Addresses, Age,
// BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone.
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
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Represents a person with various personal details. This struct is generic to allow for different types of addresses.
/// </summary>
/// <typeparam name="TAddress">The type of address this person can have, constrained to types that implement <see cref="IAddress"/>.</typeparam>
/// <remarks>
/// Initializes a new instance of the <see cref="Person{TAddress}"/> struct.
/// </remarks>
[DataContract(Name = "person", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "Person", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
[method: EditorBrowsable(EditorBrowsableState.Never)]
public struct Person<TAddress>() : IDataModel<Person<TAddress>, string>, IPerson<TAddress>
	where TAddress : IAddress, new()
{
	/// <summary>
	/// The addresses
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private Collection<TAddress> _addresses = [];

	/// <summary>
	/// The born on date and time.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private DateTimeOffset _bornOn = default;

	/// <summary>
	/// The cell phone number.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _cellPhone = default;

	/// <summary>
	/// The email address.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _email = default;

	/// <summary>
	/// The first name.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _firstName = default;

	/// <summary>
	/// The home phone number.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _phone = default;

	/// <summary>
	/// The unique identifier.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _id = default;

	/// <summary>
	/// The last name.
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _lastName = default;

	/// <summary>
	/// Initializes a new instance of the <see cref="Person{TAddress}"/> struct.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="email">The email.</param>
	[JsonConstructor]
	[Information(nameof(Person<TAddress>), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Person([NotNull, EmailAddress(ErrorMessage = "The email address is not in a valid format."), MaxLength(75, ErrorMessage = "Email length is limited to 75 characters.")] string email, [NotNull, MaxLength(50, ErrorMessage = "Id length is limited to 50 characters.")] string id) : this()
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
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator !=(Person<TAddress> left, Person<TAddress> right) => !(left == right);

	/// <summary>
	/// Implements the op_LessThan operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the op_LessThanOrEqual operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <=(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator ==(Person<TAddress> left, Person<TAddress> right) => left.Equals(right);

	/// <summary>
	/// Implements the op_GreaterThan operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the op_GreaterThanOrEqual operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >=(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Explicitly converts a <see cref="PersonRecord"/> to a <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="personRecord">The <see cref="PersonRecord"/> to convert.</param>
	/// <returns>A <see cref="Person{TAddress}"/> instance corresponding to the provided <see cref="PersonRecord"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="personRecord"/> is null.</exception>
	public static explicit operator Person<TAddress>(PersonRecord personRecord)
		=> ToPerson(personRecord);

	/// <summary>
	/// Explicitly converts a <see cref="RefTypes.Person{Address}"/> to a <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="refPerson">The <see cref="RefTypes.Person{Address}"/> to convert.</param>
	/// <returns>A <see cref="Person{TAddress}"/> instance corresponding to the provided <see cref="RefTypes.Person{Address}"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="refPerson"/> is null.</exception>
	public static explicit operator Person<TAddress>(RefTypes.Person<RefTypes.Address> refPerson)
		=> ToPerson(refPerson);

	/// <summary>
	/// Calculates the age of the person based on their birth date and the current UTC date.
	/// </summary>
	/// <returns>The age of the person as a <see cref="TimeSpan"/>.</returns>
	[Information(nameof(CalculateAge), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	/// <summary>
	/// Compares this instance with a specified <see cref="Person{TAddress}"/> object and indicates whether this instance
	/// precedes, follows, or appears in the same position in the sort order as the specified <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="other">The <see cref="Person{TAddress}"/> to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings:
	/// Less than zero: This instance precedes <paramref name="other"/> in the sort order.
	/// Zero: This instance occurs in the same position in the sort order as <paramref name="other"/>.
	/// Greater than zero: This instance follows <paramref name="other"/> in the sort order.</returns>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly int CompareTo(Person<TAddress> other) => string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);

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
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly int CompareTo([NotNull] IPerson<TAddress> other) => other is null ? 1 : string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
	[Information(nameof(Equals), Status = Status.Available)]
	public readonly bool Equals([NotNull] Person<TAddress> other) => Equals(this, other);

	/// <summary>
	/// Determines whether the specified <see cref="object"/> is equal to this instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified <see cref="object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), Status = Status.Available)]
	public override readonly bool Equals([NotNull] object obj) => base.Equals(obj);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly bool Equals([NotNull] IPerson<TAddress> other) => base.Equals(other);

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	[Information(nameof(GetHashCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override readonly int GetHashCode() => HashCode.Combine(this.Id, this.Email, this.FirstName, this.LastName);

	/// <summary>
	/// Converts a <see cref="PersonRecord"/> to a <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="person">The <see cref="PersonRecord"/> to convert.</param>
	/// <returns>A new instance of <see cref="Person{TAddress}"/> based on the provided <see cref="PersonRecord"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="person"/> is null.</exception>
	[return: NotNull]
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
	/// Converts a <see cref="RefTypes.Person{Address}"/> to a <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="person">The <see cref="RefTypes.Person{Address}"/> to convert.</param>
	/// <returns>A new instance of <see cref="Person{TAddress}"/> based on the provided <see cref="RefTypes.Person{Address}"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="person"/> is null.</exception>
	[return: NotNull]
	public static Person<TAddress> ToPerson([NotNull] in RefTypes.Person<RefTypes.Address> person)
	{
		// Fix: Renamed the local variable to avoid conflict with the parameter name.
		_ = person.ArgumentNotNull();

		var newPerson = new Person<TAddress>(person.Email, person.Id)
		{
			FirstName = person.FirstName,
			LastName = person.LastName,
			BornOn = person.BornOn,
			CellPhone = person.CellPhone,
			Phone = person.Phone
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
	/// Returns a <see cref="string"/> that represents this instance.
	/// </summary>
	/// <returns>A <see cref="string"/> that represents this instance.</returns>
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString() => this.PropertiesToString(includeMemberName: false);

	/// <summary>
	/// Gets a collection of <see cref="Address"/> for a Person.
	/// </summary>
	/// <value>The addresses.</value>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[XmlIgnore]
	[Information(nameof(Addresses), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Collection<TAddress> Addresses
	{
		readonly get => this._addresses;

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
		readonly get => this._addresses;

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
	[Information(nameof(Age), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly TimeSpan Age => this.CalculateAge();

	/// <summary>
	/// Gets or sets the born on date and time.
	/// </summary>
	/// <value>The born on.</value>
	/// <exception cref="ArgumentOutOfRangeException">BornOn</exception>
	[DataMember(Name = "bornOn", IsRequired = false)]
	[JsonPropertyName("bornOn")]
	[XmlElement("BornOn")]
	[Information(nameof(BornOn), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public DateTimeOffset BornOn
	{
		readonly get => this._bornOn;
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
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">CellPhone</exception>
	[DataMember(Name = "cellPhone", IsRequired = false)]
	[JsonPropertyName("cellPhone")]
	[MaxLength(50, ErrorMessage = "Cell phone number cannot exceed 50 characters.")]
	[Phone(ErrorMessage = "The cell phone number is not in a valid format.")]
	[XmlElement("CellPhone")]
	[Information(nameof(CellPhone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CellPhone
	{
		readonly get => this._cellPhone;
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
	/// Gets the email.
	/// </summary>
	/// <value>The email.</value>
	/// <exception cref="ArgumentOutOfRangeException">Email</exception>
	[DataMember(Name = "email", IsRequired = true)]
	[EmailAddress(ErrorMessage = "The email address is not in a valid format.")]
	[JsonPropertyName("email")]
	[MaxLength(75, ErrorMessage = "Email length is limited to 75 characters.")]
	[XmlElement("Email", IsNullable = false)]
	[Information(nameof(Email), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Email
	{
		readonly get => this._email;

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
	/// Gets or sets the first name.
	/// </summary>
	/// <value>The first name.</value>
	/// <exception cref="ArgumentOutOfRangeException">FirstName</exception>
	[DataMember(Name = "firstName", IsRequired = false)]
	[JsonPropertyName("firstName")]
	[MaxLength(50, ErrorMessage = "First name length is limited to 50 characters.")]
	[XmlElement("FirstName")]
	[Information(nameof(FirstName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FirstName
	{
		readonly get => this._firstName;
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
	/// Gets the full name of the person.
	/// </summary>
	/// <value>The full name.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	[Information(nameof(FullName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly string FullName => $"{this.FirstName} {this.LastName}";

	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	/// <exception cref="ArgumentOutOfRangeException">Id</exception>
	[DataMember(Name = "id", IsRequired = true)]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessage = "Id cannot exceed 50 characters.")]
	[ReadOnly(true)]
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
	/// Gets or sets the last name.
	/// </summary>
	/// <value>The last name.</value>
	/// <exception cref="ArgumentOutOfRangeException">LastName</exception>
	[DataMember(Name = "lastName", IsRequired = true)]
	[JsonPropertyName("lastName")]
	[MaxLength(50, ErrorMessage = "Last name length is limited to 50 characters.")]
	[XmlElement("LastName", IsNullable = false)]
	[Information(nameof(LastName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string LastName
	{
		readonly get => this._lastName;
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
	/// Gets or sets the home phone.
	/// </summary>
	/// <value>The home phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">Phone</exception>
	[DataMember(Name = "homePhone", IsRequired = false)]
	[JsonPropertyName("homePhone")]
	[MaxLength(50)]
	[XmlElement("HomePhone")]
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
