// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2025
// ***********************************************************************
// <copyright file="PersonRecord.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// A real-world type for testing and benchmarking named "PersonRecord"
// with the following properties: Addresses, Age, BornOn, CellPhone,
// Email, FirstName, FullName, LastName, and Phone. Additionally,
// this type includes methods to convert from both Person reference
// and value types to PersonRecord.
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
/// Represents a person record in the system, encapsulating personal and contact information.
/// This record is designed to be immutable, ensuring thread safety and simplifying development.
/// Implements <see cref="IDataRecord"/> for data handling and supports comparison and sorting
/// through <see cref="IComparable{PersonRecord}"/>.
/// </summary>
[DataContract(Name = "personRecord", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "PersonRecord", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public sealed record PersonRecord : IComparable<PersonRecord>, IPersonRecord
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
	/// The home phone number
	/// </summary>
	[JsonIgnore]
	[NonSerialized]
	private string _phone;

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonRecord"/> class.
	/// This constructor is primarily used for deserialization.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PersonRecord()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PersonRecord"/> class with specified email and identifier.
	/// </summary>
	/// <param name="email">The email address of the person. Must be a valid email format and not exceed 75 characters.</param>
	/// <param name="id">The unique identifier for the person. Must not exceed 50 characters.</param>
	/// <exception cref="ValidationException">Thrown if the email or id does not meet the specified criteria.</exception>
	[JsonConstructor]
	[Information(nameof(PersonRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public PersonRecord([NotNull, EmailAddress(ErrorMessage = "The email address is not in a valid format."), MaxLength(75, ErrorMessage = "Email length is limited to 75 characters.")] string email, [NotNull, MaxLength(50, ErrorMessage = "Id length is limited to 50 characters.")] string id)
	{
		this.Email = email.ArgumentNotNullOrEmpty();
		this.Id = id.ArgumentNotNullOrEmpty();
	}

	/// <summary>
	/// Defines the less than operator for comparing two instances of <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="left">The left <see cref="PersonRecord"/> instance.</param>
	/// <param name="right">The right <see cref="PersonRecord"/> instance.</param>
	/// <returns><c>true</c> if the left instance is less than the right instance; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <(PersonRecord left, PersonRecord right) => left is null
		? right is not null
		: left.CompareTo(right) < 0;

	/// <summary>
	/// Implements the less than or equal to operator for comparing two instances of <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="left">The left <see cref="PersonRecord"/> instance.</param>
	/// <param name="right">The right <see cref="PersonRecord"/> instance.</param>
	/// <returns><c>true</c> if the left instance is less than or equal to the right instance; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <=(PersonRecord left, PersonRecord right) => left is null || left.CompareTo(right) <= 0;

	/// <summary>
	/// Implements the greater than operator for comparing two instances of <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="left">The left <see cref="PersonRecord"/> instance.</param>
	/// <param name="right">The right <see cref="PersonRecord"/> instance.</param>
	/// <returns><c>true</c> if the left instance is greater than the right instance; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >(PersonRecord left, PersonRecord right) => left is not null &&
		left.CompareTo(right) > 0;

	/// <summary>
	/// Implements the greater than or equal to operator for comparing two instances of <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="left">The left <see cref="PersonRecord"/> instance.</param>
	/// <param name="right">The right <see cref="PersonRecord"/> instance.</param>
	/// <returns><c>true</c> if the left instance is greater than or equal to the right instance; otherwise, <c>false</c>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >=(PersonRecord left, PersonRecord right) => left is null
		? right is null
		: left.CompareTo(right) >= 0;

	/// <summary>
	/// Calculates the age of the person based on their birth date and the current UTC date.
	/// </summary>
	/// <returns>The age of the person as a <see cref="TimeSpan"/>.</returns>
	[Information(nameof(CalculateAge), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	/// <summary>
	/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings: 
	/// Less than zero: This instance precedes <paramref name="other"/> in the sort order. 
	/// Zero: This instance occurs in the same position in the sort order as <paramref name="other"/>. 
	/// Greater than zero: This instance follows <paramref name="other"/> in the sort order.</returns>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CompareTo([NotNull] PersonRecord other) => other is null ? 1 : string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Converts a Person{ValueTypes.Address} instance to a <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="person">The ValueTypes.Person{ValueTypes.Address} to convert.</param>
	/// <returns>A <see cref="PersonRecord"/> that represents the converted person.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="person"/> is null.</exception>
	[return: NotNull]
	[Information(nameof(ToPersonRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static PersonRecord ToPersonRecord([NotNull] ValueTypes.Person<ValueTypes.Address> person)
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
			Phone = person.Phone,
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
	/// Converts a <see cref="Person{Address}"/> instance to a <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="person">The <see cref="Person{Address}"/> to convert.</param>
	/// <returns>A <see cref="PersonRecord"/> that represents the converted person.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="person"/> is null.</exception>
	[return: NotNull]
	[Information(nameof(ToPersonRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static PersonRecord ToPersonRecord([NotNull] in Person<Address> person)
	{
		_ = person.ArgumentNotNull();

		PersonRecord newPerson = new()
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
				newPerson.Addresses.Add(AddressRecord.ToAddress(address));
			}
		}

		return newPerson;
	}

	/// <summary>
	/// Converts the person record to a string representation, utilizing the PropertiesToString method for detailed output.
	/// </summary>
	/// <returns>A string representation of the person record.</returns>
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString() => this.PropertiesToString(includeMemberName: false);

	/// <summary>
	/// Gets or sets the collection of addresses associated with the person.
	/// </summary>
	/// <value>The collection of <see cref="AddressRecord"/> objects.</value>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[XmlIgnore]
	[Information(nameof(Addresses), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Collection<AddressRecord> Addresses
	{
		get => this._addresses;

		init
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
	/// This property is intended for use by the XML serializer and should not be used directly in code.
	/// </summary>
	/// <value>The collection of addresses for serialization.</value>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[JsonIgnore]
	[XmlArray("Addresses")]
	[Information(nameof(AddressesSerilization), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Collection<AddressRecord> AddressesSerilization
	{
		get => this._addresses;

		init
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
	/// Gets the age of the person calculated from the born on date to the current date.
	/// </summary>
	/// <value>The age as a <see cref="TimeSpan"/>.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	[Information(nameof(Age), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan Age => this.CalculateAge();

	/// <summary>
	/// Gets or sets the date and time when the person was born.
	/// </summary>
	/// <value>The born on date and time as a <see cref="DateTimeOffset"/>.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if an attempt is made to set a future date.</exception>
	[DataMember(Name = "bornOn", IsRequired = false)]
	[JsonPropertyName("bornOn")]
	[XmlElement("BornOn")]
	[Information(nameof(BornOn), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public DateTimeOffset BornOn
	{
		get => this._bornOn;
		init
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
	/// <value>The cell phone number.</value>
	/// <remarks>
	/// The cell phone number is limited to 50 characters and should be in a valid format.
	/// </remarks>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the cell phone number exceeds 50 characters.</exception>
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
		init
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
	/// Gets or sets the email address.
	/// </summary>
	/// <value>The email address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the email exceeds 75 characters.</exception>
	/// <remarks>
	/// The email address is validated to ensure it is in a correct format and does not exceed 75 characters in length.
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

		init
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
	/// The first name is limited to 50 characters. It is a required field and cannot be null or empty.
	/// </remarks>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the first name exceeds 50 characters.</exception>
	[DataMember(Name = "firstName", IsRequired = true)]
	[DefaultValue("")]
	[JsonPropertyName("firstName")]
	[MaxLength(50, ErrorMessage = "First name length is limited to 50 characters.")]
	[XmlElement("FirstName")]
	[Information(nameof(FirstName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FirstName
	{
		get => this._firstName;
		init
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
	/// <value>The full name.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	[Information(nameof(FullName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FullName => $"{this.FirstName} {this.LastName}";

	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The unique identifier for the person.</value>
	/// <remarks>
	/// The identifier is a required field and must not exceed 50 characters in length.
	/// </remarks>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the identifier exceeds 50 characters.</exception>
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
	/// <value>The last name of the person.</value>
	/// <remarks>
	/// The last name is a required field and must not exceed 50 characters in length.
	/// This property is used to store the family name of the person.
	/// </remarks>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the last name exceeds 50 characters.</exception>
	[DataMember(Name = "lastName", IsRequired = true)]
	[DefaultValue("")]
	[JsonPropertyName("lastName")]
	[MaxLength(50, ErrorMessage = "Last name length is limited to 50 characters.")]
	[XmlElement("LastName")]
	[Information(nameof(LastName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string LastName
	{
		get => this._lastName;
		init
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
}
