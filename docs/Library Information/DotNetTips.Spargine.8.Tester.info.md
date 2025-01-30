# DotNetTips.Spargine.8.Tester - 2025.8.1.30

## PersonData

### PersonData (DateTimeOffset bornOn, String cellPhone, Country country, String email, String firstName, String lastName, String phone)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** PersonData

*****
## PersonName

### PersonName ()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** PersonName

### PersonName (String firstName, String lastName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** PersonName

### String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** FirstName

### String FullName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** FullName

### String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** LastName

*****
## RandomCreditCardNumberGenerator

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** RandomCreditCardNumberGenerator
* **Documentation:** https://bit.ly/SpargineTester

### String GetCreditCardNumber()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetCreditCardNumber

### ReadOnlyCollection<String> GetCreditCardNumbers(Int32 count)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetCreditCardNumbers

*****
## RandomData

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

### Collection<T> GenerateAddressCollection(Country country, Int32 count, Int32 addressLength, Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/4/2023
* **Description:** GenerateAddressCollection
* **Modified By:** David McCarter

### Collection<AddressRecord> GenerateAddressRecordCollection(CountryName country, Int32 count, Int32 addressLength, Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/14/2023
* **Description:** GenerateAddressRecordCollection
* **Modified By:** David McCarter

### Byte[] GenerateByteArray(Double sizeInKb)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateByteArray
* **Modified By:** David McCarter

### Char GenerateCharacter()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCharacter
* **Modified By:** David McCarter

### Char GenerateCharacter(Char minValue, Char maxValue)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCharacter
* **Modified By:** David McCarter

### T GenerateCoordinate()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCoordinate
* **Modified By:** David McCarter

### ReadOnlyCollection<T> GenerateCoordinateCollection(Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateCoordinateCollection
* **Modified By:** David McCarter

### String GenerateCreditCard()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/13/2023
* **Description:** GenerateCreditCard
* **Modified By:** David McCarter

### ReadOnlyCollection<String> GenerateCreditCards(Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/13/2023
* **Description:** GenerateCreditCard
* **Modified By:** David McCarter

### Decimal GenerateDecimal(Decimal& minValue, Decimal& maxValue, Int32 decimalPlaces)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateDecimal
* **Modified By:** David McCarter

### String GenerateDomainExtension()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateDomainExtension
* **Modified By:** David McCarter

### String GenerateEmailAddress()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateEmailAddress
* **Modified By:** David McCarter

### String GenerateFile(String fileName, Int32 fileLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFile
* **Modified By:** David McCarter

### ValueTuple<String, ReadOnlyCollection<String>> GenerateFiles(Int32 count, Int32 fileLength, String fileExtension)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFiles
* **Modified By:** David McCarter

### ReadOnlyCollection<String> GenerateFiles(String path, Int32 count, Int32 fileLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateFiles
* **Modified By:** David McCarter

### String GenerateFirstName()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/11/2023
* **Description:** GenerateFirstName
* **Modified By:** David McCarter

### Int32 GenerateInteger(Int32 min, Int32 max)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateInteger
* **Modified By:** David McCarter

### String GenerateKey()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateKey
* **Modified By:** David McCarter

### String GenerateLastName()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/11/2023
* **Description:** GenerateLastName
* **Modified By:** David McCarter

### String GenerateNumber(Int32 length)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateNumber
* **Modified By:** David McCarter

### ReadOnlyCollection<PersonName> GeneratePersonNames(Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/15/2023
* **Description:** GeneratePersonNames
* **Modified By:** David McCarter

### PersonRecord GeneratePersonRecord(Int32 addressCount, Int32 addressLength, Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GeneratePersonRecord

### ReadOnlyCollection<PersonRecord> GeneratePersonRecordCollection(Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRecordCollection
* **Modified By:** David McCarter

### Person<TAddress> GeneratePersonRef(Int32 addressCount, Int32 addressLength, Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRef
* **Modified By:** David McCarter

### ReadOnlyCollection<Person<TAddress>> GeneratePersonRefCollection(Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonRefCollection
* **Modified By:** David McCarter

### Person<TAddress> GeneratePersonVal(Int32 addressCount, Int32 addressLength, Int32 countyProvinceLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonVal
* **Modified By:** David McCarter

### ReadOnlyCollection<Person<TAddress>> GeneratePersonValCollection(Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePersonValCollection
* **Modified By:** David McCarter

### String GeneratePhoneNumber(Country country, Boolean includeCountryCode)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePhoneNumber
* **Modified By:** David McCarter

### String GeneratePhoneNumber(CountryName countryName, Boolean includeCountryCode)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GeneratePhoneNumber
* **Modified By:** David McCarter

### String GenerateRandomFileName(Int32 fileNameLength, String extension)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRandomFileName
* **Modified By:** David McCarter

### String GenerateRandomFileName(String path, Int32 fileNameLength, String extension)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRandomFileName
* **Modified By:** David McCarter

### ValueTuple<Country, State, City> GenerateRandomLocationData()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GenerateRandomLocationData

### PersonData GenerateRandomPersonData()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GenerateRandomPersonData

### ValueTuple<String, String> GenerateRandomPersonName()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GenerateRandomLocationData

### String GenerateRelativeUrl()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateRelativeUrl
* **Modified By:** David McCarter

### String GenerateTempFile(Int32 fileLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateTempFile
* **Modified By:** David McCarter

### String GenerateUrl()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrl
* **Modified By:** David McCarter

### String GenerateUrlFragment()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlFragment
* **Modified By:** David McCarter

### String GenerateUrlHostName()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostName
* **Modified By:** David McCarter

### String GenerateUrlHostNameNoProtocol()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostNameNoProtocol
* **Modified By:** David McCarter

### String GenerateUrlHostNameNoSubDomain()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateUrlHostNameNoSubDomain
* **Modified By:** David McCarter

### String GenerateWord(Int32 length)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter

### String GenerateWord(Int32 minLength, Int32 maxLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter

### String GenerateWord(Int32 length, Char minCharacter, Char maxCharacter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter

### String GenerateWord(Int32 minLength, Int32 maxLength, Char minCharacter, Char maxCharacter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWord
* **Modified By:** David McCarter

### ReadOnlyCollection<String> GenerateWords(Int32 count, Int32 minLength, Int32 maxLength)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWords
* **Modified By:** David McCarter

### String LongTestString { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/19/2019
* **Description:** GenerateWords
* **Modified By:** David McCarter

*****
## Address

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

### Address (String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Address

### Address (String id, String address1, String address2, String city, String state, String countyProvince, String country, String postalCode, String phone)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Address

### String Address1 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Address1

### String Address2 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Address2

### String City { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** City

### Int32 CompareTo(Address address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CompareTo

### String Country { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Country

### String CountyProvince { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CountyProvince

### Boolean Equals(Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Equals

### Boolean Equals(IAddress other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Equals

### Boolean Equals(Address other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Equals

### Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetHashCode

### String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Id

### Boolean op_Equality(Address left, Address right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ==

### Boolean op_GreaterThan(Address left, Address right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** >

### Boolean op_GreaterThanOrEqual(Address left, Address right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** >=

### Boolean op_Inequality(Address left, Address right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** !=

### Boolean op_LessThan(Address left, Address right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** <

### Boolean op_LessThanOrEqual(Address left, Address right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** <=

### String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Phone

### String PostalCode { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** PostalCode

### String State { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** State

### Int32 System.IComparable<DotNetTips.Spargine.Tester.Models.RefTypes.IAddress>.CompareTo(IAddress other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CompareTo

### Address ToAddress(AddressRecord address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ToAddress

### String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToString

*****
## Coordinate

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Documentation:** https://bit.ly/SpargineTester

### Int32 CompareTo(Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CompareTo

### Int32 CompareTo(Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CompareTo

### Boolean Equals(Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Equals

### Boolean Equals(Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Equals

### Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** GetHashCode

### Boolean op_Equality(Coordinate cord1, Coordinate cord2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed

### Boolean op_GreaterThan(Coordinate left, Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_GreaterThanOrEqual(Coordinate left, Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed

### Boolean op_Inequality(Coordinate cord1, Coordinate cord2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed

### Boolean op_LessThan(Coordinate left, Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_LessThanOrEqual(Coordinate left, Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToString

### Int32 X { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** X

### Int32 Y { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Y

### Int32 Z { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Z

*****
## Person<TAddress>

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

### Person<TAddress> (String email, String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Person

### Collection<TAddress> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Addresses

### Collection<TAddress> AddressesSerilization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** AddressesSerilization

### TimeSpan Age { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Age

### DateTimeOffset BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** BornOn

### TimeSpan CalculateAge()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CalculateAge

### String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CellPhone

### Int32 CompareTo(Person<TAddress> other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CompareTo

### Int32 CompareTo(IPerson<TAddress> other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CompareTo

### String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Email

### Boolean Equals(Person<TAddress> other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Equals

### Boolean Equals(Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Equals

### Boolean Equals(IPerson<TAddress> other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Equals

### String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** FirstName

### String FullName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** FullName

### Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetHashCode

### String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Id

### String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** LastName

### Boolean op_Equality(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_GreaterThan(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_GreaterThanOrEqual(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_Inequality(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed

### Boolean op_LessThan(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_LessThanOrEqual(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Phone

### String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToString

*****
## PersonAddressComparerByLastName

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonComparerByLastName

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonComparerByLastNameThenFirstName

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonEmailEqualityComparer

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonJsonValSerializerContext

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** PersonJsonValSerializerContext

*****
## Address

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

### Int32 CompareTo(Address address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CompareTo

*****
## AddressRecord

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

### AddressRecord (String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** AddressRecord

### AddressRecord (String id, String address1, String address2, String city, String state, String countyProvince, String country, String postalCode, String phone)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** AddressRecord

### String Address1 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Address1

### String Address2 { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Address2

### String City { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** City

### String Country { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Country

### String CountyProvince { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CountyProvince

### String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Id

### String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Phone

### String PostalCode { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** PostalCode

### String State { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** State

### AddressRecord ToAddress(Address address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ToAddress

### AddressRecord ToAddress(Address address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ToAddress

*****
## Coordinate

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

### Int32 CompareTo(Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CompareTo

### Int32 CompareTo(Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CompareTo

### Boolean Equals(Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Equals

### Boolean Equals(Coordinate other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Equals

### Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** GetHashCode

### Boolean op_Equality(Coordinate cord1, Coordinate cord2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed

### Boolean op_GreaterThan(Coordinate left, Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_GreaterThanOrEqual(Coordinate left, Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed

### Boolean op_Inequality(Coordinate cord1, Coordinate cord2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed

### Boolean op_LessThan(Coordinate left, Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_LessThanOrEqual(Coordinate left, Coordinate right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToString

### Int32 X { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** X

### Int32 Y { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Y

### Int32 Z { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Z

*****
## ICoordinate

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

*****
## IPerson<TAddress>

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

*****
## Person<TAddress>

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

### Person<TAddress> (String email, String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Person

### Collection<TAddress> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Addresses

### Collection<TAddress> AddressesSerilization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** AddressesSerilization

### TimeSpan Age { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CalculateAge

### DateTimeOffset BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** BornOn

### TimeSpan CalculateAge()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CalculateAge

### String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CellPhone

### Int32 CompareTo(Person<TAddress> other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CompareTo

### Int32 CompareTo(IPerson<TAddress> other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CalculateAge

### String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Email

### Boolean Equals(Object obj)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Equals

### Boolean Equals(Person<TAddress> other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Equals

### Boolean Equals(IPerson<TAddress> other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Equals

### String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** FirstName

### String FullName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** FullName

### Int32 GetHashCode()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetHashCode

### String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Id

### String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** LastName

### Boolean op_Equality(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_GreaterThan(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_GreaterThanOrEqual(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_Inequality(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed

### Boolean op_LessThan(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_LessThanOrEqual(Person<TAddress> left, Person<TAddress> right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Phone

### Person<Address> ToPerson(Person<Address> person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ToPerson

### Person<Address> ToPerson(PersonRecord person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ToPerson

### String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToString

*****
## PersonAddressComparerByLastName

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonComparerByLastName

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonComparerByLastNameThenFirstName

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonEmailEqualityComparer

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonJsonSerializerContext

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** PersonJsonSerializerContext

*****
## PersonRecord

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTester

### PersonRecord (String email, String id)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** PersonRecord

### Collection<AddressRecord> Addresses { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Addresses

### Collection<AddressRecord> AddressesSerilization { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** AddressesSerilization

### TimeSpan Age { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Age

### DateTimeOffset BornOn { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** BornOn

### TimeSpan CalculateAge()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CalculateAge

### String CellPhone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CellPhone

### Int32 CompareTo(PersonRecord other)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CompareTo

### String Email { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Email

### String FirstName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** FirstName

### String FullName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** FullName

### String Id { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Id

### String LastName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** LastName

### Boolean op_GreaterThan(PersonRecord left, PersonRecord right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_GreaterThanOrEqual(PersonRecord left, PersonRecord right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_LessThan(PersonRecord left, PersonRecord right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean op_LessThanOrEqual(PersonRecord left, PersonRecord right)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### String Phone { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** Phone

### PersonRecord ToPersonRecord(Person<Address> person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ToPersonRecord

### PersonRecord ToPersonRecord(Person<Address> person)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ToPersonRecord

### String ToString()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ToString

*****
## PersonRecordComparerByLastName

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## PersonRecordEmailEqualityComparer

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
**Generated by Spargine - dotNetTips.com on 1/30/2025 6:59:50 PM UTC**
