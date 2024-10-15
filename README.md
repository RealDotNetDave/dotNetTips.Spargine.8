# DotNetTips.Spargine for Microsoft .NET 8: v2024.8.10.15 
![Spargine 8](docs/Graphics/SPARGINE-8-BANNER.png)

Open-source .NET assemblies from dotNetTips.com and **<a href="https://dotnettips.wordpress.com/about/" target="_blank">David (dotNetDave) McCarter</a>**. 
This repository contains the dotNetTips.Spargine code for .NET 8. Spargine includes foundational code that I've been developing since the days of .NET 2! It also features a library to support your testing and another one dedicated to benchmarking your code.

Please support this project by <a href="https://github.com/sponsors/RealDotNetDave" target="_blank">**clicking here**</a>. 
<a href="https://dotnettips.wordpress.com/spargine/" target="_blank">Click here</a> to visit the Spargine page on dotNetTips.com. Much of this code is also documented on <a href="https://dotnettips.wordpress.com/category/open-source/spargine/" target="_blank">**dotNetTips.com**</a>.
# NuGet
All of the assemblies listed below can be found on NuGet by <a href="https://www.nuget.org/profiles/davidmccarter" target="_blank">clicking here</a>.
# Projects
Below is the list of current projects in this repository
*  	**DotNetTips.Spargine:** Windows and File I/O Targeting Library.
    * **IO**
        * **DirectoryHelper**: Common methods for working with file directories.
        * **DriveHelper**: Common methods for working with disk drives.
        * **FileHelper**: Common methods for working with files.
        * **FileProcessor**: Facilitates file copying and deletion operations, incorporating event handling for files. Additionally, it offers the capability to delete folders.
        * **PathHelper**: Common methods for path manipulation, encompassing handling invalid filter characters, invalid path names, and path separators.
    * **Net**
        * **Http**
            * **HttpClientHelper**: Utility methods for HttpClient.
        * **Sockets**
            * **SocketsHelper**: Helper methods for Socket operations.
    * **Win32**
        * **RegistryHelper**: Convenient methods for interacting with the Windows registration database, streamlining access and manipulation tasks.
    * **Service**: Convenient helper methods for seamless management of Windows services, offering key features such as loading a service, checking its running status, starting and stopping services, and more.
*   **DotNetTips.Spargine.Core:** Core library used by all of the other assemblies.
    * **Cache**
        * **InMemoryCache**: MemoryCache with a default duration of 20 minutes for storing objects in memory.
    * **Collections**
        * **Generic**
            * **Concurrent**
                * **ChannelQueue**: QueueManager class featuring the ListenAsync method for common queuing of items.
                * **ConcurrentHashSet**: Represents a thread-safe, hash-based unique collection.
                * **DistinctBlockingCollection**: A custom thread-safe collection type designed for multi-threading tasks, ensuring uniqueness for all items in the collection.
                * **DistinctConcurrentBag**: Inherits from ConcurrentBag<T> and ensures that all items in the bag are unique.
            * **FastSortedList**: Custom Collection Class for `<T>`. Items within this collection are sorted only upon request.
            * **ObservableList**: Custom Observable Collection Class for `<T>`. Includes the following events: CollectionChanged, PropertyChanged, PropertyChanging.
        * **CollectionRandomizer**: Designed to shuffle a collection either once or endlessly. Enables users to retrieve items using the GetNext() method.
    * **Devices**
        * **Clock**: Time Utility Class for common tasks related to clocks and time. It includes functionalities to retrieve the current time and tick count, along with a method to determine the number of days in the current month (DaysInCurrentMonth).
    * **Diagnostics**
        * **PerformanceStopwatch**: Enhances Stopwatch with helpful methods: StartNew() and StopReset(). Additionally, it possesses the ability to add messages that can be retrieved when the Stopwatch stops.
    * **Logging**
        * **FastLogger**: This class efficiently logs to any ILogger object, providing rapid logging for Critical, Debug, Error, Exception, Information, Trace, and Warning messages.
        * **LoggingHelper**: Utility methods designed for logging purposes. Includes functionality to log computer information and application details. Additionally, it can capture and log all domain exceptions, even if the exception originates from a different assembly, covering exceptions from the .NET framework.
    * **Network**
        * **HttpEventListener**: Listens and logs messages from HTTP events, capturing events such as request start and stop. This functionality facilitates comprehensive monitoring and logging of HTTP-related activities.
        * **HttpEventListenerAsysncLocal**: Listens asynchronously and logs messages from HTTP events, including request start and stop. This functionality enables comprehensive monitoring and logging of asynchronous HTTP-related activities.
        * **HttpHandlerDiagnosticListener**: Accesses the HttpRequestMessage/HttpResponseMessage instances, providing a useful means to retrieve information such as request headers or the response status code.
        * **HttpRequestObserver**: Observes the HttpRequestMessage/HttpResponseMessage instances, offering a valuable method to retrieve information such as request headers or the response status code.
    * **RegularExpressions**
        * **RegexProcessor**: Utility methods for common string regular expressions. Included methods: ContainsWord, IsCreditCardNumber, IsEmailAddress, IsUrl, IsISBN, and more.
    * **Security**
        * **EncryptionHelper**: Provides secure encryption for strings using AES (Advanced Encryption Standard) and includes a method to validate encrypted strings. The AES encryption ensures the confidentiality and integrity of sensitive information, making it suitable for securely handling data.
        * **SHA256PasswordHasher**: Generates and verifies passwords using SHA256, a secure cryptographic hash function.
    * **Serialization**
        * **JsonSerialization**: This class simplifies the process of serializing and deserializing strings to and from JSON format using the JsonSerializer. JSON serialization is a widely adopted and efficient method for storing and exchanging data in various applications and APIs.
        * **XmlSerialization**: Facilitates seamless serialization and deserialization of strings to and from the XML format.
    * **Web**
        * **ServiceProxy**: Generates a service proxy for types that implement ICommunicationObject, enabling communication with such objects.
        * **WebHelper**: Utility methods for website calls. These functions streamline website interactions and efficiently manage HTTP-related tasks.
    * **ApiLibraries**: List of common Windows API libraries.
    * **App**: Application Information and Utility Methods.
    * **ArgumentInvalidException**: Custom exception type for invalid argument value.
    * **ArgumentReadOnlyException**: Custom exception type for read-only argument values, such as collections.
    * **CachedEnumerable**: Custom collection type for enhanced performance during iteration.
    * **ComputerInfo**: Used to retrieve common computer information.
    * **Config**: Adaptable type designed to simplify the creation of custom configuration objects, with a focus on easy disk saving in applications.
    * **ControlChars**: Contains frequently used strings and characters, including backslash, comma, dash, double quote, empty string, forward slash, quote, space, tab, underscore, and more.
    * **DirectoryNotFoundException**: Custom exception to be utilized when a directory cannot be found.
    * **EnumHelper**: Facilitates the usage of Enums by providing convenient methods such as AdjustCamelCase(), AdjustName(), GetNames(), and more.
    * **EnvironmentKey**: Enumeration for common environment keys.
    * **ExceptionThrower**: Inspired by the .NET ExceptionThrower, this tool streamlines the process of throwing exceptions effortlessly. All exceptions thrown utilize default messages, and if necessary, custom messages can also be provided.
    * **ExecutionHelper**: When making calls to code that might be interrupted by network issues, the ProgressiveRetry() method proves beneficial. It automatically retries the code multiple times (default is 3) when encountering connection problems or other internet-related interruptions.
    * **FastStringBuilder**: Enhances performance when using a StringBuilder by employing an ObjectPool.
    * **IDataModel**: Interface designed for model classes, enforcing the implementation of the "Id" property, which is mandatory.
    * **IDataRecord**: Interface tailored for model records, mandating the implementation of the "Id" property. Additionally, it provides functionality to convert all the properties and their data to a string representation.
    * **InformationAttribute**: Attribute that enables the addition of informational data to methods. Properties include Author, BenchMarkStatus, CreatedOn, Description, Documentation, ModifiedBy, ModifiedOn, Status, UnitTestCoverage.
    * **InvalidEnumTypeException**: Custom exception to be utilized when a value for an Enum is invalid.
    * **InvalidValueException**: Custom exception to be used when an invalid value is encountered.
    * **KeyGenerator**: Generates unique keys using a GUID without dashes.
    * **LoggableException**: Exception type that includes a HasBeenLogged property to prevent an exception from being logged multiple times.
    * **MessageNotQueuedException**: Custom exception to be employed when a message could not be queued.
    * **NetworkConnectionException**: Custom exception to be used when there is a network connection error.
    * **PreserveAttribute**: Attribute to make it easier to look at code and know that the code needs to be preserved due to one of the reasons in PreserveReason (None, ObjectInjected, MethodFromInterface, MethodOverride, Other).
    * **ProcessorInforamtion**: Utility to retrieve information about the computer processor.
    * **SimpleResult**: Enables methods to return a value, a status, and exception information as needed. This comprehensive approach provides flexibility in handling various outcomes.
    * **Singleton<T>**: Enables easy creation of a singleton type by utilizing Lazy<T> to instantiate the type only when necessary.
    * **TaskHelper**: Synchronous execution methods for Tasks streamline the process of running asynchronous operations without requiring explicit asynchronous handling. This simplifies code readability and management.
    * **TypeHelper**: Provides valuable methods for type management, encompassing tasks such as loading derived types, creating new types, discovering derived types, converting JSON to objects, transforming JSON files into objects, generating instance hash codes, and listing built-in types. These functionalities empower developers to handle types effectively in diverse scenarios.
    * **Valdaitor**: Methods facilitating the validation of arguments and values, ensuring both simplicity and accuracy. In the event of encountering invalid data, an Exception will be thrown, accompanied by an appropriate error message, which can be either custom or default.
        
*   **DotNetTips.Spargine.Extensions:** Library for common extension methods. Supported types are: Array, Assembly, Boolean, Collection, Color, DataContext, DataReader, DataTable, DateTime, Dictionary, Enumerable, Enum, Exception, Guid, HttpClient, HttpContext, HttpRequest, HttpReponseHeader, ImmutableArray, LINQ, List, Math, Numeric, Object, ObservableCollection, Process, ReadOnlyCollection, ReadOnlySpan, Socket, SortedDictionary, SortedSet, Stream, StringBuilder, String, Task, Thread, WebClient
*   **DotNetTips.Spargine.Tester:** Library for creating dummy data for use in unit & benchmark tests.
    * **Data**:
        * **Countries**: Methods for retrieving comprehensive data encompassing all countries worldwide, including their respective regions, states and cities.
    * **Models**
        * **RefTypes**
            * **Address**: Reference type with properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This type inherits from the interface IAddress.
            * **AddressRecord**: Record type with properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This type inherits from the interface IAddress.
            * **IAddress**: Interface "IAddress" that defines properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This interface inherits from another interface named IAddress.
            * **IPerson**: Interface "IPerson" that defines properties for Addresses, BornOn, CellPhone, Email, FirstName, LastName, and Phone.
            * **Person**: A real-world type for testing and benchmarking named "Person" with the following properties: Addresses, Age, BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone. This type also includes methods to convert from PersonRecord and Person value types to Person.
            * **PersonJsonSerializerContext**: JSON context designed to optimize the serialization and deserialization processes for the "Person" type and collections of "Person."
            * **PersonRecord**: A real-world type for testing and benchmarking named "PersonRecord" with the following properties: Addresses, Age, BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone. Additionally, this type includes methods to convert from both Person reference and value types to PersonRecord.
        * **ValueTypes**
            * **Address**: Value type named "Address" with properties for Address1 and Address2, City, Country, CountryProvince, Phone, PostalCode, and State. This type inherits from the interface IAddress.
            * **Coordinate**: A practical value type designed for testing and benchmarking, named "Coordinate," featuring properties X, Y, and Z. It inherits from the interface ICoordinate.
            * **ICoordinate**: An interface named "ICoordinate" with properties X, Y, and Z for coordinating values.
            * **Person**: A real-world value type crafted for testing and benchmarking, named "Person," encompassing properties such as Addresses, Age, BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone.
    * **RandomData**: Create random data for unit and benchmark testing.
        * **GenerateAddressCollection<T>**: Generate a collection of Address types that implement the IAddress interface.
        * **GenerateAddressRecordCollection**: Generate a collection of AddressRecord instances.
        * **GenerateByteArray**: Generates a random byte array.
        * **GenerateCharacter**: Generates a random character. 
        * **GenerateCoordinate**: Create a Coordinate object that implements the  ICoordinate interface with random values.
        * **GenerateCoordinateCollection**: Create a collection of objects that implement the ICoordinate interface.
        * **GenerateCreditCardNumber**: Generate a random credit card number. Supported credit cards include: American Express, Diners Club, Discover, EnRoute, JCB, MasterCard, Visa, and Voyager.
        * **GenerateCreditCardNumbers**: Generate a collection of random credit card numbers. Supported credit cards include: American Express, Diners Club, Discover, EnRoute, JCB, MasterCard, Visa, and Voyager.
        * **GenerateDecimal**: Generates a random decimal value.
        * **GenerateDomainExtension**: Generates a random domain extension. Example: `creditunion`
        * **GenerateEmailAddress**: Create a random email address with a random domain.
        * **GenerateFile**: Generate a random file with a default length of 1,024 and save it to the user's AppData\Roaming folder.
        * **GenerateFiles**: Generate random files with a default length of 1,024 and save them to the user's AppData\Roaming folder.
        * **GenerateFirstName**: Randomly generate a male or female first name.
        * **GenerateInteger**: Generates a random integer value.
        * **GenerateKey**: Create a random key using a GUID and remove any dashes.
        * **GenerateLastName**: Randomly generate a person's last name.
        * **GenerateNumber**: Create a random number as a string.
        * **GeneratePersonNames**: Generates random male and female names, and provides outputs for FirstName, LastName, and FullName.
        * **GeneratePersonRecord**: Generates a PersonRecord with random values.
        * **GeneratePersonRecordCollection**: Generates a PersonRecord ReadOnlyCollection.
        * **GeneratePersonRef**: Generates a Person reference type that implements IAddress with default values.
        * **GeneratePersonRefCollection**: Generates a Person reference ReadOnlyCollection that implements IAddress.
        * **GeneratePersonVal**: Generates a Person value type that implements IAddress with random values.
        * **GeneratePersonValCollection**: Generates a Person value ReadOnlyCollection that implements IAddress.
        * **GeneratePhoneNumer**: Creates a phone number based on a specified Country or CountryName, with the option to include the country code.
        * **GenrateRandomFileName**: Generates a random file name in the temporary folder. This method is overloaded to also use any folder of your choosing. Example: `C:\\Users\*user folder*\AppData\Local\Temp\MSPRINYRBU.dotnettips.temp`
        * **GenerateRandomLocationData**: Generates location data by selecting a random Country, State, and City.
        * **GenerateRandomPersonData**: Generates random person data, including values for date of birth, cell phone number, Country, email address, first name, last name, and phone number.
        * **GenerateRandomPersonName**: Generates random first and last names for a person.
        * **GenerateRelativeUrl**: Creates a random relative URL. Example: `/ljsylu/rsglcurkiylqld/wejdbuainlgjofnv/uwbrjftyt/`
        * GenerateTempFile: Generates a random file in the user's local temporary folder. Example: `C:\\Users\*user folder*\AppData\Local\Temp\OFQCKBRAKQ.dotnettips.temp`
        * **GenerateUrl**: Creates a completely random URL. Example: `https://www.rp.red/wyfkxbfft/pqypmdstoydnootvdvnsqkn/`
        * **GenerateUrlHostName**: Generates a random URL host name. Example: `https://www.ukrsusbrtjijfktfj.shouji`
        * **GenerateUrlHostNameNoProtocol**: Creates a URL without a subdomain. Example: `www.txtkixvsxgryixbwrtje.shangrila`
        * **GenerateUrlHostNameNoSubDomain**: Creates a hostname without a subdomain. Example: `dz`.
        * **GenerateUrlFragment**: Generate a random URL fragment. Example: `/sfs`
        * **GenerateWord**: Generates a random word within a specified minimum and maximum length. Example: `anvpwufadtxpfysguavguwm`
        * **GenerateWords**: Generates a ReadOnlyCollection of words with lengths falling within a specified minimum and maximum range.
        * **LongTestString** (property): Provides an extensive string for testing purposes, with a length of 969 characters, including spaces.
*   **DotNetTips.Spargine.Benchmarking:** Library for benchmarking code using <a href="https://benchmarkdotnet.org/index.html" target="_blank">BenchmarkDotNet</a>. To read more about this project, <a href="source/Benchmarking/README.md" target="_blank">**click here**</a>.
# Benchmark Tests
Spargine undergoes performance testing through benchmark tests using **BenchmarkDotNet**. **<a href="https://github.com/RealDotNetDave/dotNetTips.Spargine.8/tree/master/docs/Benchmark%20Results" target="_blank">Click here</a>** to access the latest benchmark results for these projects.
# Your Support Is Appreciated!
Do you have code you would like to submit to these repositories? Submit a pull request or submit an issue. I promise to take a look and include it if I like it! **I might just send you some cool geeky swag that includes one of my books (as supplies last).** **You can also support these projects via GitHub Sponsors:** <a href="https://github.com/sponsors/RealDotNetDave" target="_blank">https://github.com/sponsors/RealDotNetDave</a>
