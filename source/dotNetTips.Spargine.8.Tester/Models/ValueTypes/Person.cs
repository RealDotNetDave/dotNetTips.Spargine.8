// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : david
// Created          : 10-25-2021
//
// Last Modified By : david
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="Person.cs" company="McCarter Consulting">
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
/// Represents a person with properties for addresses, age, birth date, contact numbers, email, and names.
/// This struct is generic to support different types of addresses.
/// </summary>
/// <typeparam name="TAddress">The type of address this person can have, must implement <see cref="IAddress"/>.</typeparam>
[DataContract(Name = "person")]
[DebuggerDisplay("{Email}")]
[JsonConverter(typeof(JsonStringEnumConverter))]
[Serializable]
[XmlRoot(ElementName = "Person")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public struct Person<TAddress> : IDataModel<Person<TAddress>, string>, IPerson<TAddress> where TAddress : IAddress, new()
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
	/// This constructor is primarily used for deserialization purposes.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[JsonConstructor]
	public Person()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="Person{TAddress}"/> struct with specified identifier and email.
	/// </summary>
	/// <param name="id">The unique identifier for the person.</param>
	/// <param name="email">The email address of the person.</param>
	public Person([NotNull] string id, [NotNull] string email) : this()
	{
		this.Id = id;
		this.Email = email;
	}

	/// <summary>
	/// Implements the inequality operator (!=). Checks if two <see cref="Person{TAddress}"/> instances are not equal.
	/// </summary>
	/// <param name="left">The left <see cref="Person{TAddress}"/> instance.</param>
	/// <param name="right">The right <see cref="Person{TAddress}"/> instance.</param>
	/// <returns><c>true</c> if the instances are not equal; otherwise, <c>false</c>.</returns>
	public static bool operator !=(Person<TAddress> left, Person<TAddress> right) => !(left == right);

	/// <summary>
	/// Implements the less than operator (&lt;). Checks if the left <see cref="Person{TAddress}"/> instance is less than the right <see cref="Person{TAddress}"/> instance.
	/// </summary>
	/// <param name="left">The left <see cref="Person{TAddress}"/> instance.</param>
	/// <param name="right">The right <see cref="Person{TAddress}"/> instance.</param>
	/// <returns><c>true</c> if the left instance is less than the right instance; otherwise, <c>false</c>.</returns>
	public static bool operator <(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the less than or equal to operator (&lt;=). Checks if the left <see cref="Person{TAddress}"/> instance is less than or equal to the right <see cref="Person{TAddress}"/> instance.
	/// </summary>
	/// <param name="left">The left <see cref="Person{TAddress}"/> instance.</param>
	/// <param name="right">The right <see cref="Person{TAddress}"/> instance.</param>
	/// <returns><c>true</c> if the left instance is less than or equal to the right instance; otherwise, <c>false</c>.</returns>
	public static bool operator <=(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the equality operator (==). Checks if two <see cref="Person{TAddress}"/> instances are equal.
	/// </summary>
	/// <param name="left">The left <see cref="Person{TAddress}"/> instance.</param>
	/// <param name="right">The right <see cref="Person{TAddress}"/> instance.</param>
	/// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
	public static bool operator ==(Person<TAddress> left, Person<TAddress> right) => left.Equals(right);

	/// <summary>
	/// Implements the greater than operator (&gt;). Checks if the left <see cref="Person{TAddress}"/> instance is greater than the right <see cref="Person{TAddress}"/> instance.
	/// </summary>
	/// <param name="left">The left <see cref="Person{TAddress}"/> instance.</param>
	/// <param name="right">The right <see cref="Person{TAddress}"/> instance.</param>
	/// <returns><c>true</c> if the left instance is greater than the right instance; otherwise, <c>false</c>.</returns>
	public static bool operator >(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the greater than or equal to operator (&gt;=). Checks if the left <see cref="Person{TAddress}"/> instance is greater than or equal to the right <see cref="Person{TAddress}"/> instance.
	/// </summary>
	/// <param name="left">The left <see cref="Person{TAddress}"/> instance.</param>
	/// <param name="right">The right <see cref="Person{TAddress}"/> instance.</param>
	/// <returns><c>true</c> if the left instance is greater than or equal to the right instance; otherwise, <c>false</c>.</returns>
	public static bool operator >=(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Calculates the age of the person based on the current date and the person's birth date.
	/// </summary>
	/// <returns>A <see cref="TimeSpan"/> representing the age of the person.</returns>
	public readonly TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	/// <summary>
	/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This instance precedes <paramref name="other"/> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="other"/>. Greater than zero This instance follows <paramref name="other"/> in the sort order.</returns>
	[DebuggerStepThrough]
	public readonly int CompareTo([NotNull] Person<TAddress> other) => string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Compares the current instance with another <see cref="IPerson{TAddress}"/> instance and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
	/// </summary>
	/// <param name="other">An <see cref="IPerson{TAddress}"/> to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This instance precedes <paramref name="other"/> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="other"/>. Greater than zero This instance follows <paramref name="other"/> in the sort order.</returns>
	[DebuggerStepThrough]
	public readonly int CompareTo([NotNull] IPerson<TAddress> other)
	{
		if (other is null)
		{
			return 1;
		}

		return string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Determines whether the specified <see cref="Person{TAddress}"/> is equal to the current <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="other">The <see cref="Person{TAddress}"/> to compare with the current <see cref="Person{TAddress}"/>.</param>
	/// <returns><c>true</c> if the specified <see cref="Person{TAddress}"/> is equal to the current <see cref="Person{TAddress}"/>; otherwise, <c>false</c>.</returns>

	public readonly bool Equals([NotNull] Person<TAddress> other) => string.Equals(this.Id, other.Id, StringComparison.Ordinal) &&
			   string.Equals(this.Email, other.Email, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Determines whether the specified object is equal to the current instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified object is equal to the current instance; otherwise, <c>false</c>.</returns>
	public override readonly bool Equals(object obj)
	{
		if (obj is Person<TAddress> other)
		{
			return this.Equals(other);
		}

		return false;
	}

	/// <summary>
	/// Determines whether the specified <see cref="IPerson{TAddress}"/> is equal to the current <see cref="Person{TAddress}"/>.
	/// </summary>
	/// <param name="other">The <see cref="IPerson{TAddress}"/> to compare with the current <see cref="Person{TAddress}"/>.</param>
	/// <returns><c>true</c> if the specified <see cref="IPerson{TAddress}"/> is equal to the current <see cref="Person{TAddress}"/>; otherwise, <c>false</c>.</returns>
	public readonly bool Equals([NotNull] IPerson<TAddress> other)
	{
		if (other == null)
		{
			return false;
		}

		// Assuming Id and Email are the unique identifiers for equality comparison.
		return string.Equals(this.Id, other.Id, StringComparison.Ordinal) &&
			   string.Equals(this.Email, other.Email, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Returns a hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
	/// Note: The base GetHashCode method is used here, which might not provide a good distribution for all scenarios.
	/// Consider overriding this method to compute a hash code based on instance fields that contribute to the object's equality.
	/// </summary>
	/// <returns>A hash code for the current object.</returns>
	public override readonly int GetHashCode() => base.GetHashCode();

	/// <summary>
	/// Gets or sets the collection of addresses for the person.
	/// </summary>
	/// <value>The collection of <typeparamref name="TAddress"/> instances representing the addresses of the person.</value>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[NotNull]
	[XmlArray("Addresses")]
	[XmlArrayItem("Address")]
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
	/// Gets or sets the addresses for XML serialization only. This property is intended for use by the XML serializer and should not be used directly in code.
	/// </summary>
	/// <value>The collection of addresses for XML serialization.</value>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[JsonIgnore]
	[MemberNotNull(nameof(_addresses))]
	[XmlArray("Addresses")]
	[XmlArrayItem("Address")]
	public Collection<TAddress> AddressesSerilization
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
	/// Gets the age of the person calculated from the birth date to the current date.
	/// </summary>
	/// <value>The age as a <see cref="TimeSpan"/>.</value>
	[JsonIgnore]
	[XmlIgnore]
	public readonly TimeSpan Age => this.CalculateAge();

	/// <summary>
	/// Gets or sets the date and time when the person was born.
	/// </summary>
	/// <value>The date and time representing the person's birth date.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when setting a future date.</exception>
	[JsonPropertyName("bornOn")]
	[XmlElement]
	[MemberNotNull(nameof(_bornOn))]
	public DateTimeOffset BornOn
	{
		readonly get => this._bornOn;
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
	/// <value>The cell phone number in string format.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the cell phone number exceeds 50 characters.</exception>
	/// <remarks>
	/// The cell phone number is validated to ensure it conforms to a standard phone number format and does not exceed the maximum length.
	/// </remarks>
	[DataMember(Name = "cellPhone", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("cellPhone")]
	[Phone(ErrorMessage = "Invalid Phone Number")]
	[StringLength(50, ErrorMessage = "Cell phone number cannot exceed 50 characters.")]
	[XmlElement("CellPhone")]
	public string CellPhone
	{
		readonly get => this._cellPhone;
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
	/// Gets or sets the email address of the person.
	/// </summary>
	/// <value>The email address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the email exceeds 75 characters.</exception>
	/// <remarks>
	/// The email address is validated to ensure it conforms to a standard email format and does not exceed the maximum length.
	/// </remarks>
	[DataMember(Name = "email", IsRequired = true)]
	[DisallowNull]
	[EmailAddress(ErrorMessage = "Invalid Email Address")]
	[JsonPropertyName("email")]
	[MemberNotNull(nameof(_email))]
	[ReadOnly(true)]
	[Required(ErrorMessage = "Email is required.")]
	[StringLength(75, ErrorMessage = "Email cannot exceed 75 characters.")]
	[XmlElement(IsNullable = false)]
	public string Email
	{
		readonly get => this._email;
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
	/// Gets or sets the first name of the person.
	/// </summary>
	/// <value>The first name.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the first name exceeds 50 characters.</exception>
	/// <remarks>
	/// The first name is validated to ensure it does not exceed the maximum length.
	/// </remarks>
	[DataMember(Name = "firstName", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("firstName")]
	[MemberNotNull(nameof(_firstName))]
	[Required(ErrorMessage = "First name is required.")]
	[StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
	[XmlElement("FirstName")]
	public string FirstName
	{
		readonly get => this._firstName;
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
	/// Gets the full name of the person by concatenating the first name and the last name.
	/// </summary>
	/// <value>The full name of the person.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public readonly string FullName => $"{this.FirstName} {this.LastName}";

	/// <summary>
	/// Gets the unique identifier for the person.
	/// </summary>
	/// <value>The unique identifier as a string.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the identifier exceeds 50 characters.</exception>
	/// <remarks>
	/// The identifier is validated to ensure it does not exceed the maximum length.
	/// </remarks>
	[DataMember(Name = "id", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("id")]
	[MemberNotNull(nameof(_id))]
	[ReadOnly(true)]
	[Required(ErrorMessage = "ID is required.")]
	[StringLength(50, ErrorMessage = "ID cannot exceed 50 characters.")]
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
	/// Gets or sets the last name of the person.
	/// </summary>
	/// <value>The last name as a string.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the last name exceeds 50 characters.</exception>
	/// <remarks>
	/// The last name is validated to ensure it does not exceed the maximum length allowed.
	/// </remarks>
	[DataMember(Name = "lastName", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("lastName")]
	[MemberNotNull(nameof(_lastName))]
	[Required(ErrorMessage = "Last name is required.")]
	[StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
	[XmlElement("LastName")]
	public string LastName
	{
		readonly get => this._lastName;
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
	/// Gets or sets the home phone number.
	/// </summary>
	/// <value>The home phone number in string format.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the home phone number exceeds 50 characters.</exception>
	/// <remarks>
	/// The home phone number is validated to ensure it conforms to a standard phone number format and does not exceed the maximum length.
	/// </remarks>
	[DataMember(Name = "homePhone", IsRequired = false)]
	[DefaultValue("")]
	[JsonPropertyName("homePhone")]
	[Phone(ErrorMessage = "Invalid Phone Number")]
	[StringLength(50, ErrorMessage = "Home phone number cannot exceed 50 characters.")]
	[XmlElement("HomePhone")]
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

}
