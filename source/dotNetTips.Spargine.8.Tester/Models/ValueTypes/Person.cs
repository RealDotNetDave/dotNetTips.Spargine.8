// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : david
// Created          : 10-25-2021
//
// Last Modified By : david
// Last Modified On : 05-11-2024
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
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Struct Person
/// </summary>
/// <typeparam name="TAddress">The type of the t address.</typeparam>
[DataContract(Name = "person")]
[DebuggerDisplay("{Email}")]
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
	/// Initializes a new instance of the <see cref="Person{TAddress}" /> struct.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Person()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="Person{TAddress}" /> struct.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="email">The email.</param>
	public Person([NotNull] string id, [NotNull] string email) : this()
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
	/// Implements the op_LessThan operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the op_LessThanOrEqual operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <=(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(Person<TAddress> left, Person<TAddress> right) => left.Equals(right);

	/// <summary>
	/// Implements the op_GreaterThan operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the op_GreaterThanOrEqual operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >=(Person<TAddress> left, Person<TAddress> right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Calculates the person's age.
	/// </summary>
	/// <returns>TimeSpan.</returns>
	public readonly TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	/// <summary>
	/// Compares to.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>int.</returns>
	public readonly int CompareTo([NotNull] Person<TAddress> other) => string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Compares to.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>int.</returns>
	public readonly int CompareTo([NotNull] IPerson<TAddress> other)
	{
		if (other is null)
		{
			return 1;
		}

		return string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);
	}
	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public readonly bool Equals([NotNull] Person<TAddress> other) => Equals(this, other);

	/// <summary>
	/// Determines whether the specified <see cref="object" /> is equal to this instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
	public override readonly bool Equals([NotNull] object obj) => base.Equals(obj);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public readonly bool Equals([NotNull] IPerson<TAddress> other) => base.Equals(other);

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public override readonly int GetHashCode() => base.GetHashCode();

	/// <summary>
	/// Gets a collection of <see cref="Address" /> for a Person.
	/// </summary>
	/// <value>The addresses.</value>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[MaybeNull]
	[MemberNotNull(nameof(_addresses))]
	[XmlIgnore]
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
	/// Gets or sets the addresses for XML serilization only.
	/// </summary>
	/// <value>The addresses serilization.</value>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlArray("Addresses")]
	[JsonIgnore]
	[MemberNotNull(nameof(_addresses))]
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
	/// Gets the age of the person.
	/// </summary>
	/// <value>The age.</value>
	[JsonIgnore]
	[XmlIgnore]
	public readonly TimeSpan Age => this.CalculateAge();

	/// <summary>
	/// Gets or sets the born on date and time.
	/// </summary>
	/// <value>The born on.</value>
	/// <exception cref="ArgumentOutOfRangeException">BornOn</exception>
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
	/// <value>The cell phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">CellPhone</exception>
	[DefaultValue("")]
	[JsonPropertyName("cellPhone")]
	[MemberNotNull(nameof(_cellPhone))]
	[XmlElement]
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
	/// Gets the email.
	/// </summary>
	/// <value>The email.</value>
	/// <exception cref="ArgumentOutOfRangeException">Email</exception>
	[DataMember(Name = "email", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("email")]
	[ReadOnly(true)]
	[XmlElement(IsNullable = false)]
	[MemberNotNull(nameof(_email))]
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
	/// Gets or sets the first name.
	/// </summary>
	/// <value>The first name.</value>
	/// <exception cref="ArgumentOutOfRangeException">FirstName</exception>
	[DefaultValue("")]
	[JsonPropertyName("firstName")]
	[MemberNotNull(nameof(_firstName))]
	[XmlElement]
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
	/// Gets the full name of the person.
	/// </summary>
	/// <value>The full name.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	public readonly string FullName => $"{this.FirstName} {this.LastName}";

	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	/// <exception cref="ArgumentOutOfRangeException">Id</exception>
	[DataMember(Name = "id", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("id")]
	[MemberNotNull(nameof(_id))]
	[ReadOnly(true)]
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
	/// Gets or sets the last name.
	/// </summary>
	/// <value>The last name.</value>
	/// <exception cref="ArgumentOutOfRangeException">LastName</exception>
	[DefaultValue("")]
	[JsonPropertyName("lastName")]
	[MemberNotNull(nameof(_lastName))]
	[XmlElement]
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
	/// Gets or sets the home phone.
	/// </summary>
	/// <value>The home phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">Phone</exception>
	[DefaultValue("")]
	[JsonPropertyName("homePhone")]
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

}
