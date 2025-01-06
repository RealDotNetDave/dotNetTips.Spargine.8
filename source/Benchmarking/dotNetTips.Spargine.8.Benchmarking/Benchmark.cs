// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-05-2025
// ***********************************************************************
// <copyright file="Benchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Abstract base class featuring common benchmarking methods,
// supplemented with default attributes.
// </summary>
// ***********************************************************************

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using DotNetTips.Spargine.Benchmarking.Properties;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using static BenchmarkDotNet.Attributes.JsonExporterAttribute;
using static BenchmarkDotNet.Attributes.MarkdownExporterAttribute;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Provides an abstract base for benchmark tests, including setup and cleanup routines, 
/// methods for consuming objects, generating random data, and updating test entities. 
/// It also includes properties for accessing various test data and configurations.
/// </summary>
//[AsciiDocExporter]
//[Atlassian]
//[ConcurrencyVisualizerProfiler]
//[CsvMeasurementsExporter]
//[EtwProfiler]
//[MarkdownExporter]
//[NativeMemoryProfiler]
//[PlainExporter]
//[StackOverflow]
//[TailCallDiagnoser]
[AllStatisticsColumn]
[BaselineColumn]
[CategoriesColumn]
[ConfidenceIntervalErrorColumn]
[CsvExporter]
[DisassemblyDiagnoser(printSource: true, exportGithubMarkdown: true, exportCombinedDisassemblyReport: true, exportDiff: true, exportHtml: true)]
[EvaluateOverhead]
[ExceptionDiagnoser]
[Full]
[GcServer(true)]
[GitHub]
[HtmlExporter]
[InliningDiagnoser(true, true)]
[IterationsColumn]
[JsonExporter(indentJson: true)]
[KurtosisColumn]
[LogicalGroupColumn]
[MaxColumn]
[MemoryDiagnoser(displayGenColumns: true)]
[MinColumn]
[MValueColumn]
[NamespaceColumn]
[Orderer(SummaryOrderPolicy.Method)]
[RankColumn]
[SkewnessColumn]
[StatisticalTestColumn]
[StopOnFirstError(true)]
[ThreadingDiagnoser]
public abstract class Benchmark
{

	/// <summary>
	/// Text indicating a failed operation or status.
	/// </summary>
	protected const string FailedText = "failed";

	/// <summary>
	/// Text indicating a successful operation or status.
	/// </summary>
	protected const string SuccessText = "success";

	/// <summary>
	/// A lowercase string for testing purposes.
	/// </summary>
	public const string LowerCaseString = "john doe";

	/// <summary>
	/// A proper case string for testing purposes.
	/// </summary>
	public const string ProperCaseString = "John Doe";

	/// <summary>
	/// A 10-character string for testing purposes.
	/// </summary>
	public const string String10Characters01 = "2ds9JiOtNF";

	/// <summary>
	/// A 10-character string for testing purposes.
	/// </summary>
	public const string String10Characters02 = "ndA5nJSHnU";

	/// <summary>
	/// A 15-character string for testing purposes.
	/// </summary>
	public const string String15Characters01 = "C8IIVjaUi0owZh6";

	/// <summary>
	/// A 15-character string for testing purposes.
	/// </summary>
	public const string String15Characters02 = "Q7sXguwS9vZpOo6";

	/// <summary>
	/// A test email address in lowercase.
	/// </summary>
	public const string TestEmailLowerCase = "fake@fakelive.com";

	/// <summary>
	/// A test email address in mixed case for testing purposes.
	/// </summary>
	public const string TestEmailMixedCase = "Fake@FakeLive.com";

	/// <summary>
	/// An uppercase string for testing purposes.
	/// </summary>
	public const string UpperCaseString = "JOHN DOE";

	/// <summary>
	/// Caches byte arrays of various sizes to avoid regenerating them for each benchmark iteration.
	/// </summary>
	private readonly Dictionary<int, byte[]> _byteArrayCache = [];

	/// <summary>
	/// Caches string arrays of various configurations to avoid regenerating them for each benchmark iteration.
	/// </summary>
	private readonly Dictionary<string, string[]> _stringArrayCache = [];

	/// <summary>
	/// Gets the consumer used for consuming objects in benchmark operations.
	/// </summary>
	/// <value>The consumer instance.</value>
	private Consumer Consumer { get; } = new();

	/// <summary>
	/// Performs cleanup operations. This method should be called at the end of benchmark runs.
	/// It logs the cleanup action to the console.
	/// </summary>
	public virtual void Cleanup() => ConsoleLogger.Default.WriteLine(LogKind.Info, $"Cleanup(): {nameof(Benchmark)}.");

	/// <summary>
	/// Consumes the specified object using the Benchmark.Consumer property to prevent the JIT compiler from optimizing away the code being benchmarked.
	/// </summary>
	/// <typeparam name="T">The type of the object to consume.</typeparam>
	/// <param name="obj">The object to consume.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Consume<T>(T obj) => this.Consumer.Consume(obj);

	/// <summary>
	/// Consumes the specified object asynchronously using the Benchmark.Consumer property to prevent the JIT compiler from optimizing away the code being benchmarked.
	/// This method wraps the synchronous consume operation in a Task to be awaited, ensuring compatibility with async workflows.
	/// </summary>
	/// <typeparam name="T">The type of the object to consume.</typeparam>
	/// <param name="obj">The object to consume.</param>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public async Task ConsumeAsync<T>(T obj) => await Task.Run(() => this.Consumer.Consume(obj)).ConfigureAwait(false);

	/// <summary>
	/// Generates a random byte array of a specified size in kilobytes. If the byte array of the requested size has already been generated, it retrieves the cached version to avoid regeneration.
	/// </summary>
	/// <param name="sizeInKb">The size of the byte array to generate, in kilobytes.</param>
	/// <returns>A byte array of the specified size.</returns>
	public byte[] GetByteArray(int sizeInKb)
	{
		sizeInKb = sizeInKb.EnsureMinimum(1);

		if (this._byteArrayCache.ContainsKey(sizeInKb) is false)
		{
			this._byteArrayCache.Add(sizeInKb, RandomData.GenerateByteArray(sizeInKb));
		}

		return this._byteArrayCache[sizeInKb];
	}

	/// <summary>
	/// Generates a random string array of a specified count, with each string's length bounded by the specified minimum and maximum lengths.
	/// The method caches the generated array to avoid regeneration on subsequent calls with the same parameters.
	/// </summary>
	/// <param name="count">The number of strings to generate in the array.</param>
	/// <param name="wordMinLength">The minimum length of each generated string. Defaults to 10.</param>
	/// <param name="wordMaxLength">The maximum length of each generated string. Defaults to 15.</param>
	/// <returns>An array of randomly generated strings of the specified count and length constraints.</returns>
	public string[] GetStringArray(in int count, int wordMinLength = 10, int wordMaxLength = 15)
	{
		//Ensure maxLenth is at least +1 of minLength.
		wordMinLength = wordMinLength.EnsureMinimum(1);
		wordMaxLength = wordMaxLength.EnsureMinimum(wordMinLength + 1);

		var key = $"{count}-{wordMinLength}-{wordMaxLength}";

		if (this._stringArrayCache.ContainsKey(key) is false)
		{
			this._stringArrayCache.Add(key, [.. RandomData.GenerateWords(count, wordMinLength, wordMaxLength)]);
		}

		return this._stringArrayCache[key];
	}

	/// <summary>
	/// Performs global cleanup operations after all benchmark methods have run.
	/// This method is automatically called by BenchmarkDotNet at the end of the benchmarking session.
	/// </summary>
	[GlobalCleanup]
	public void GlobalCleanup() => this.Cleanup();

	/// <summary>
	/// Performs global setup operations before any benchmark methods are run.
	/// This method is automatically called by BenchmarkDotNet at the beginning of the benchmarking session.
	/// It checks if the debugger should be launched and performs initial setup by calling the Setup method.
	/// </summary>
	[GlobalSetup]
	public void GlobalSetup()
	{
		if (this.LaunchDebugger)
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Launching debugger: {nameof(Benchmark)}.");
			_ = Debugger.Launch();
		}

		this.Setup();
	}

	/// <summary>
	/// Performs initial setup for benchmark tests. This method is intended to be overridden in derived classes to provide specific setup operations required by individual benchmarks.
	/// It is automatically called by BenchmarkDotNet at the beginning of the benchmarking session, prior to any benchmarks being executed.
	/// Implementations should ensure to call base.Setup() when overriding to preserve setup operations defined in the base class.
	/// </summary>
	public virtual void Setup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Setup(): {nameof(Benchmark)}.");

		this.Base64String = this.LongTestString.Substring(1, 50).ToBase64();
		this.Coordinate01 = RandomData.GenerateCoordinate<Coordinate>();
		this.Coordinate02 = RandomData.GenerateCoordinate<Coordinate>();
		this.PersonRecord01 = RandomData.GeneratePersonRecord();
		this.PersonRecord02 = RandomData.GeneratePersonRecord();
		this.PersonRef01 = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		this.PersonRef02 = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();
		this.PersonVal01 = RandomData.GeneratePersonVal<Tester.Models.ValueTypes.Address>();
		this.PersonVal02 = RandomData.GeneratePersonVal<Tester.Models.ValueTypes.Address>();
		this.StringToTrim = $"          {this.LongTestString}          ";
		this.TestGuid = Guid.NewGuid();
	}

	/// <summary>
	/// Simulates work by computing the hash code of the provided item object.
	/// This method demonstrates how to perform operations on objects that are constrained by generic type parameters.
	/// </summary>
	/// <param name="item">The object whose hash code will be computed.</param> 
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual void SimulateWork([NotNull] object item) => RuntimeHelpers.GetHashCode(item);

	/// <summary>
	/// Updates the Email property of a item object that implements the IPerson interface with a predefined test email address.
	/// This method demonstrates how to modify properties of objects that are constrained by generic type parameters.
	/// </summary>
	/// <param name="person">The item object whose Email property will be updated.</param>
	public virtual void Update([NotNull] Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> person) => person.Email = TestEmailLowerCase;

	/// <summary>
	/// Updates the Email property of a value type item object that implements the IPerson interface with a predefined test email address.
	/// This method demonstrates how to modify properties of value type objects that are constrained by generic type parameters.
	/// </summary>
	/// <param name="person">The value type item object whose Email property will be updated.</param>

	public virtual void Update(Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address> person) => person.Email = TestEmailLowerCase;

	/// <summary>
	/// Updates the Email property in an <see cref="PersonRecord"/> with a predefined test email address.
	/// This method demonstrates how to modify properties of record types, specifically for benchmarking purposes.
	/// </summary>
	/// <param name="person">The item record whose Email property will be updated.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual void Update(PersonRecord person) => _ = person with { Email = TestEmailLowerCase };

	/// <summary>
	/// Updates the coordinates of an <see cref="ICoordinate"/> object to predefined values.
	/// This method demonstrates how to modify properties of objects implementing the ICoordinate interface.
	/// </summary>
	/// <param name="coord">The coordinate object to update.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual void Update(ICoordinate coord)
	{
		coord.X = 100;
		coord.Y = 200;
		coord.Z = 300;
	}

	/// <summary>
	/// Gets or sets the Base64 encoded string. This property is used to store a Base64 encoded version of a test string for benchmarking purposes.
	/// </summary>
	/// <value>The Base64 encoded string.</value>
	public string Base64String { get; internal set; }

	/// <summary>
	/// Retrieves a random coordinate generated during startup for use in testing.
	/// </summary>
	/// <value>The first coordinate object.</value>
	public Coordinate Coordinate01 { get; private set; }

	/// <summary>
	/// Retrieves a random coordinate generated during startup.
	/// </summary>
	/// <value>The second coordinate object.</value>
	public Coordinate Coordinate02 { get; private set; }

	/// <summary>
	/// Retrieve JSON from resources for a <see cref="IPerson{TAddress}" /> object.
	/// </summary>
	/// <value>The JSON test data for a item.</value>
	public static string JsonTestDataPerson => Resources.JsonTestDataPerson;

	/// <summary>
	/// Retrieve the JSON representation of a <see cref="PersonRecord" /> object from the resources.
	/// This property provides access to the JSON data used for testing and benchmarking purposes.
	/// </summary>
	/// <value>The JSON test data for a PersonRecord.</value>
	public static string JsonTestDataPersonRecord => Resources.JsonTestDataPersonRecord;

	/// <summary>
	/// Gets or sets a value indicating whether the debugger should be launched at the start of the benchmarking session.
	/// This can be useful for debugging benchmark code. When set to <c>true</c>, the debugger is launched.
	/// </summary>
	/// <value><c>true</c> if the debugger should be launched; otherwise, <c>false</c>.</value>
	public bool LaunchDebugger { get; set; }

	/// <summary>
	/// Retrieves a long test string used for benchmarking parsing and formatting operations.
	/// This string is designed to simulate real-world text processing tasks, including parsing,
	/// manipulation, and output formatting. It reflects the performance improvements achieved
	/// through the transition of native code to managed code in .NET Core 2.1 and beyond.
	/// </summary>
	/// <value>A long test string.</value>
	public string LongTestString { get; } = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

	/// <summary>
	/// Retrieve the JSON representation of a <see cref="IPerson{TAddress}" /> object from the resources.
	/// This property provides access to the JSON data used for testing and benchmarking purposes.
	/// </summary>
	/// <value>The item json.</value>
	public static string PersonJson => Resources.JsonTestDataPerson;

	/// <summary>
	/// Retrieves a randomly generated <see cref="PersonRecord"/> during startup for testing purposes.
	/// This property provides access to a <see cref="PersonRecord"/> instance that can be used in benchmark tests to measure performance of operations involving item records.
	/// </summary>
	/// <value>The first <see cref="PersonRecord"/> object.</value>
	public PersonRecord PersonRecord01 { get; private set; }

	/// <summary>
	/// Retrieves a randomly generated <see cref="PersonRecord"/> during startup for testing purposes.
	/// This property provides access to a <see cref="PersonRecord"/> instance that can be used in benchmark tests to measure performance of operations involving item records.
	/// </summary>
	/// <value>The second <see cref="PersonRecord"/> object.</value>
	public PersonRecord PersonRecord02 { get; private set; }

	/// <summary>
	/// Retrieve the JSON representation of a <see cref="PersonRecord" /> object from the resources.
	/// This property provides access to the JSON data used for testing and benchmarking purposes.
	/// </summary>
	/// <value>The item record json.</value>
	public static string PersonRecordJson => Resources.JsonTestDataPersonRecord;

	/// <summary>
	/// Retrieve the XML representation of a <see cref="PersonRecord" /> object from the resources.
	/// This property provides access to the XML data used for testing and benchmarking purposes.
	/// </summary>
	/// <value>The item record XML.</value>
	public static string PersonRecordXml => Resources.XmlTestDataPersonRecord;

	/// <summary>
	/// Retrieves a Person{Address} reference type object for testing generated during startup.
	/// This property provides access to a Person object instance that can be used in benchmark tests to measure performance of operations involving item objects.
	/// </summary>
	/// <value>The first Person{Address} object.</value>
	public Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> PersonRef01 { get; private set; }

	/// <summary>
	/// Retrieves a Person{Address} reference type object for testing generated during startup.
	/// This property provides access to a Person object instance that can be used in benchmark tests to measure performance of operations involving item objects.
	/// </summary>
	/// <value>The second Person{Address} object.</value>
	public Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> PersonRef02 { get; private set; }

	/// <summary>
	/// Retrieves a Person{Address} value type object for testing generated during startup.
	/// This property provides access to a Person value type instance that can be used in benchmark tests to measure performance of operations involving item value type objects.
	/// </summary>
	/// <value>The first Person{Address} object.</value>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address> PersonVal01 { get; private set; }

	/// <summary>
	/// Retrieves a Person{Address} value type object for testing generated during startup.
	/// This property provides access to a Person value type instance that can be used in benchmark tests to measure performance of operations involving item value type objects.
	/// </summary>
	/// <value>The second Person{Address} object.</value>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address> PersonVal02 { get; private set; }

	/// <summary>
	/// Retrieve the XML representation of a <see cref="IPerson{TAddress}" /> object from the resources.
	/// This property provides access to the XML data used for testing and benchmarking purposes.
	/// </summary>
	/// <value>The item XML.</value>
	public static string PersonXml => Resources.XmlTestDataPerson;

	/// <summary>
	/// Retrieve a string with spaces on both sides for testing purposes.
	/// This property is initialized during the setup phase and is used in benchmarks that require a string manipulation operation, such as trimming.
	/// </summary>
	/// <value>The string to trim.</value>
	public virtual string StringToTrim { get; private set; }

	/// <summary>
	/// Retrieves a Guid generated at startup for testing purposes.
	/// This property is used in benchmarks that require a unique identifier for each test instance.
	/// </summary>
	/// <value>The test unique identifier.</value>
	public Guid TestGuid { get; internal set; }

}
