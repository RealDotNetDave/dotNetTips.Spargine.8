# DotNetTips.Spargine.Benchmarking v2025.8.2.28 for .NET 8
![](docs/graphics/dotNetTips-Spargine-Logo.jpg)
Open-source .NET assembly from dotNetTips.com and David (dotNetDave) McCarter for benchmarking code using <a href="https://benchmarkdotnet.org/index.html" target="_blank">BenchmarkDotNet</a>.. 
This repository is for the dotNetTips.Spargine code for .NET 8. Please support this project by <a href="https://github.com/sponsors/RealDotNetDave" target="_blank">**clicking here**</a>. 
<a href="https://dotnettips.wordpress.com/spargine/" target="_blank">Click here</a> to visit the Spargine page on dotNetTips.com. Much of this code is also documented on <a href="https://dotnettips.wordpress.com/category/open-source/spargine/" target="_blank">dotNetTips.com</a>.

# NuGet
All of the Spargine assemblies listed below can be found on NuGet by <a href="https://www.nuget.org/profiles/davidmccarter" target="_blank">clicking here</a>.

* **Benchmark**: Abstract base class featuring common benchmarking methods, supplemented with default attributes. Default attributes (subject to change): [AllStatisticsColumn], [BaselineColumn], [CategoriesColumn], [ConfidenceIntervalErrorColumn], [CsvExporter], [DisassemblyDiagnoser(printSource: true, exportGithubMarkdown: true, exportCombinedDisassemblyReport: true, exportDiff: true, exportHtml: true)], [EvaluateOverhead], [ExceptionDiagnoser], [Full], [GcServer(true)], [GitHub], [HtmlExporter], [InliningDiagnoser(false, true)], [IterationsColumn], [JsonExporter(indentJson: true)], [KurtosisColumn], [LogicalGroupColumn], [MaxColumn], [MemoryDiagnoser(displayGenColumns: true)], [MinColumn], [MValueColumn], [NamespaceColumn], [Orderer(SummaryOrderPolicy.Method)], [RankColumn], [SkewnessColumn], [StatisticalTestColumn(StatisticalTestKind.Welch, showPValues: true)], [StopOnFirstError(true)], [ThreadingDiagnoser]
    * **LowerCaseString** (constant): A lowercase string for testing purposes.
    * **ProperCaseString** (constant): A proper case string for testing purposes.
    * **UpperCaseString** (constant): A upper case string for testing purposes.
    * **String10Characters01 & String10Characters02** (constant): A 10-character string for testing purposes.
    * **String15Characters01 & String15Characters02** (constant): A 15-character string for testing purposes.
    * **TestEmailLowerCase** (constant): A  test email address in lowercase.
    * **TestEmailMixedCase** (constant): A test email address in mixed case.
    * **Cleanup** (virtual): Clean up this instance. Make sure to invoke this method virtually in a `[GlobalCleanup]` routine.
    * **Consume**: Consume the specified object using the Benchmark.Consumer property.
    * **ConsumeAsync**: Consume an object as an asynchronous operation using the Benchmark.Consumer property.
    * **GenerateByeArray**: Generates a random byte array for a given size in kilobytes. Cache results for subsequent calls.
    * **GetStringArray**: Generates a random string array and cache the results for subsequent calls.
    * **GlobalCleanup**: BenchmarkDotNet GlobalCleanup method utilizing the `[GlobalCleanup]` attribute.
    * **GlobalSetup**: BenchmarkDotNet GlobalSetup method utilizing the `[GlobalSetup]` attribute.
    * **Setup**: Generates and stores random data for use in benchmark tests. Call this method first if overridden.
    * **Update**: Update the Email property in an object that implements  IPerson or for a PersonRecord with a random email address. Overloaded to change the values of a ICoordinate object.
    * **Base64String** (property): Retrieves a random Base64 string generated during startup.
    * **Coordinate01 & Coordinate02** (property): Retrieves a random coordinate generated during startup for use in testing.
    * **JsonTestDataPerson** (static string): Retrieve JSON from resources for a Person object.
    * **JsonTestDataPersonRecord** (static string): Retrieve JSON from resources for a PersonRecord object.
    * **LaunchDebugger**: Get or set a value indicating whether to launch the BenchmarkDotNet debugger.
    * **LongTestString** (property): Retrieve a long test string with a length of 969 characters, including spaces.
    * **PersonJson** (static string): Retrieve the JSON representation of a Person object from the resources.
    * **PersonRecord01 & PersonRecord02** (property): Retrieve a randomly generated PersonRecord during startup for testing purposes.
    * **PersonRecordJson** (static string): Retrieve the JSON representation of a PersonRecord object from the resources.
    * **PersonRecordXml** (static string): Retrieve the XML representation of a PersonRecord object from the resources.
    * **PersonRef01 & PersonRef02** (property) Retrieves a Person reference type object for testing generated during startup.
    * **PersonVal01 & PersonVal02** (property) Retrieves a Person reference type object for testing generated during startup.
    * **PersonXml** (static string): Retrieve the XML representation of a Person object from the resources.
    * **StringToTrim** (property): Retrieve a string with spaces on both sides for testing purposes.
    * **TestGuid** (property): Retrieve a Guid generated at startup for testing purposes.
* **CollectionBenchmark**: Base class for tests utilizing collections, with additional functionality to preload collections for enhanced benchmark test speed.
    * **GetPeopleRecordToInsert** (virtual): Gets a collection of PersonRecord objects for insertion into collections.
    * **GetPeopleRefToInsert** (virtual): Gets a collection of Person reference objects for insertion into collections.
    * **GetPeopleValToInsert** (virtual): Gets a collection of Person value objects for insertion into collections.
    * **GetPersonRefArray**: Gets Person reference types as an array.
    * **GetPersonRecordArray**: Gets a collection of PersonRecord as an array.
    * **GetPersonRecordCollection**: Gets a collection of PersonRecord as a Collection.
    * **GetPersonRefCollection**: Gets Person reference types as a Collection.
    * **GetPersonRefDictionary**: Gets Person reference types as a Dictionary.
    * **GetPersonValArray**: Retrieves Person value types as an array.
    * **GetPersonValCollection**: Retrieves Person value types as a Collection.
    * **MaxCount** (property): Retrieves the maximum count.
* **CounterBenchmark**: Abstract class designed for benchmark tests that involve a counter.
    * **MaxCount**: Gets the maximum count.
* **LargeCollectionBenchmark**: Class for performing benchmark tests on large collections with count values set to 64, 128, 256, 512, 1024, 2048, 4096, and 8192.
    * **Count**: Gets or sets the collection count.
* **SmallCollectionBenchmark**: Class for conducting benchmark tests on small collections with count values set to 16, 32, 64, 128, 256, 512, 1024, and 2048.
    * **Count**: Gets or sets the collection count.
* **TinyCollectionBenchmark**: Class for performing benchmark tests on very small collections with count values set to 2, 4, 8, 16, 32, 64, 128, and 256.
         * **Count**: Gets or sets the collection count.
# Benchmark Tests
**<a href="https://github.com/RealDotNetDave/dotNetTips.Spargine.8/tree/master/docs/Benchmark%20Results" target="_blank">Click here</a>** to view current benchmark results for this project.
# Your Support Is Appreciated!
Do you have code you would like to submit to these repositories? Submit a pull request or submit an issue. I promise to take a look and include it if I like it! **I might just send you some cool geeky swag that includes one of my books (as supplies last).** You can also support this via GitHub Sponsors: <a href="https://github.com/sponsors/RealDotNetDave" target="_blank">https://github.com/sponsors/RealDotNetDave</a>
