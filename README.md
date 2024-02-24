# dotNetTips.Spargine v2023.6.8.1 for .NET 8
![](docs/graphics/dotNetTips-Spargine-Logo.jpg)
Open-source .NET assemblies from dotNetTips.com and David (dotNetDave) McCarter. 
This repository is for the dotNetTips.Spargine code for .NET 8. Please support this project by <a href="https://github.com/sponsors/RealDotNetDave" target="_blank">**clicking here**</a>. 
<a href="https://dotnettips.wordpress.com/spargine/" target="_blank">Click here</a> to visit the Spargine page on dotNetTips.com. Much of this code is also documented on <a href="https://dotnettips.wordpress.com/category/open-source/spargine/" target="_blank">dotNetTips.com</a>.

## NuGet
All of the assemblies listed below can be found on NuGet by <a href="https://www.nuget.org/profiles/davidmccarter" target="_blank">clicking here</a>.

## Projects
Below is the list of current projects in this repository
### .NET 6
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
        * **EasyLogger**: This class efficiently logs to any ILogger object, providing rapid logging for Critical, Debug, Error, Exception, Information, Trace, and Warning messages.
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
        
*   **DotNetTips.Spargine.Extensions:** Library for extension methods.
*   **DotNetTips.Spargine.Tester:** Library for creating dummy data for use in unit & benchmark tests.
*   **DotNetTips.Spargine.Benchmarking:** Library for benchmarking code using BenchmarkDotNet.
### Benchmark Tests
Below are the current benchmark results for these projects. *Currently it takes 4.5 hours to run all the benchmark tests.*
#### dotNetTips.Spargine
1. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark-report-stackoverflow.md" target="_blank">DirectoryHelper</a>
#### dotNetTips.Spargine.Core
1. CachedEnumerable 
2. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark-report-stackoverflow.md" target="_blank">ChannelQueueCollection</a>
2. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark-report-stackoverflow.md" target="_blank">Collection</a>
2. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark-report-stackoverflow.md" target="_blank">LoggingHelper</a>
3. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark-report-stackoverflow.md" target="_blank">EncryptionHelper</a>
3. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark-report-stackoverflow.md" target="_blank">Serialization</a>
3. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark-report-stackoverflow.md" target="_blank">StringBuilderHelper</a>
4. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark-report-stackoverflow.md" target="_blank">TypeHelper</a>

#### dotNetTips.Spargine.Extensions
1. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark-report-stackoverflow.md" target="_blank">Array</a>
1. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.AssemblyExtensionsBenchmark-report-stackoverflow.md" target="_blank">Assembly</a>
3. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark-report-stackoverflow.md" target="_blank">Collection</a>
4. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark-report-stackoverflow.md" target="_blank">Dictionary</a>
5. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark-report-stackoverflow.md" target="_blank">Enum</a>
7. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark-report-stackoverflow.md" target="_blank">Exception</a>
7. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.GeneralBenchmark-report-stackoverflow.md" target="_blank">General</a>
6. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCollectionBenchmark-report-stackoverflow.md" target="_blank">Enumerable</a>
6. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark-report-stackoverflow.md" target="_blank">ImmutableArray</a>
8. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsCollectionBenchmark-report-stackoverflow.md" target="_blank">List</a>
9. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark-report-stackoverflow.md" target="_blank">Object</a>
9. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-report-stackoverflow.md" target="_blank">ObservableCollection</a>
9. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark-report-stackoverflow.md" target="_blank">ReadOnlyCollection</a>
9. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark-report-stackoverflow.md" target="_blank">SortedDictionary</a>
9. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-report-stackoverflow.md" target="_blank">SortedSet</a>
10. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark-report-stackoverflow.md" target="_blank">StringBuilder</a>
11. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark-report-stackoverflow.md" target="_blank">String (mutiple string tests)</a>
12. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark-report-stackoverflow.md" target="_blank">String (single string tests)</a>
#### dotNetTips.Spargine.Tester
1. <a href="https://github.com/RealDotNetDave/dotNetTips.Spargine/blob/main/docs/Benchmark%20Results/6/DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark-report-stackoverflow.md" target="_blank">RandomData</a>
# Your Support Is Appreciated!
Do you have code you would like to submit to these repositories? Submit a pull request or submit an issue. I promise to take a look and include it if I like it! **I might just send you some cool geeky swag that includes one of my books (as supplies last).** You can also support this via GitHub Sponsors: <a href="https://github.com/sponsors/RealDotNetDave" target="_blank">https://github.com/sponsors/RealDotNetDave</a>
