// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-24-2024
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
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using DotNetTips.Spargine.Benchmarking.Properties;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Perfolizer.Mathematics.SignificanceTesting;
using static BenchmarkDotNet.Attributes.JsonExporterAttribute;
using static BenchmarkDotNet.Attributes.MarkdownExporterAttribute;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Base class for benchmark tests.
/// Implements the <see cref="object" />
/// </summary>
/// <seealso cref="object" />
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
[InliningDiagnoser(false, true)]
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
[StatisticalTestColumn(StatisticalTestKind.Welch, showPValues: true)]
[StopOnFirstError(true)]
[ThreadingDiagnoser]
public abstract class Benchmark
{

	/// <summary>
	/// The failed text
	/// </summary>
	protected const string FailedText = "failed";

	/// <summary>
	/// The success text
	/// </summary>
	protected const string SuccessText = "success";

	/// <summary>
	/// A lowercase string for testing purposes.
	/// </summary>
	/// <value>The lower case string.</value>
	public const string LowerCaseString = "john doe";

	/// <summary>
	/// A proper case string for testing purposes.
	/// </summary>
	/// <value>The proper case string.</value>
	public const string ProperCaseString = "John Doe";

	/// <summary>
	/// A 10-character string for testing purposes.
	/// </summary>
	/// <value>The string10 characters.</value>
	public const string String10Characters01 = "2ds9JiOtNF";

	/// <summary>
	/// A 10-character string for testing purposes.
	/// </summary>
	/// <value>The string10 characters02.</value>
	public const string String10Characters02 = "ndA5nJSHnU";

	/// <summary>
	/// A 15-character string for testing purposes.
	/// </summary>
	/// <value>The string15 characters.</value>
	public const string String15Characters01 = "C8IIVjaUi0owZh6";

	/// <summary>
	/// A 15-character string for testing purposes.
	/// </summary>
	/// <value>The string15 characters02.</value>
	public const string String15Characters02 = "Q7sXguwS9vZpOo6";

	/// <summary>
	/// A test email address in lowercase.
	/// </summary>
	/// <value>The test email lower case.</value>
	public const string TestEmailLowerCase = "fake@fakelive.com";

	/// <summary>
	/// A test email address in mixed case.
	/// </summary>
	/// <value>The test email mixed case.</value>
	public const string TestEmailMixedCase = "Fake@FakeLive.com";

	/// <summary>
	/// A upper case string for testing purposes.
	/// </summary>
	public const string UpperCaseString = "JOHN DOE";

	/// <summary>
	/// The byte array cache
	/// </summary>
	private readonly Dictionary<int, byte[]> _byteArrayCache = [];

	/// <summary>
	/// The string array cache
	/// </summary>
	private readonly Dictionary<string, string[]> _stringArrayCache = [];

	/// <summary>
	/// Gets the consumer.
	/// </summary>
	/// <value>The consumer.</value>
	private Consumer Consumer { get; } = new();

	/// <summary>
	/// Clean up this instance. Make sure to invoke this method virtually in a [GlobalCleanup] routine.
	/// </summary>
	public virtual void Cleanup() => ConsoleLogger.Default.WriteLine(LogKind.Info, $"Cleanup(): {nameof(Benchmark)}.");

	/// <summary>
	/// Consume the specified object using the Benchmark.Consumer property.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="obj">The object.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Consume<T>(T obj) => this.Consumer.Consume(obj);

	/// <summary>
	/// Consume an object as an asynchronous operation using the Benchmark.Consumer property.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="obj">The object.</param>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public async Task ConsumeAsync<T>(T obj) => await Task.Run(() => this.Consumer.Consume(obj)).ConfigureAwait(false);

	/// <summary>
	/// Generates a random byte array for a given size in kilobytes. Cache results for subsequent calls.
	/// </summary>
	/// <param name="sizeInKb">The size in kb. Default value is 1.</param>
	/// <returns>System.Byte[].</returns>
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
	/// Generates a random string array and cache the results for subsequent calls.
	/// </summary>
	/// <param name="count">The count.</param>
	/// <param name="wordMinLength">The minimum string length for the generated word.</param>
	/// <param name="wordMaxLength">The maximum string length for the generated word.</param>
	/// <returns>System.String[].</returns>
	public string[] GetStringArray(int count, int wordMinLength = 10, int wordMaxLength = 15)
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
	/// BenchmarkDotNet GlobalCleanup method utilizing the [GlobalCleanup] attribute.
	/// </summary>
	[GlobalCleanup]
	public void GlobalCleanup() => this.Cleanup();

	/// <summary>
	/// BenchmarkDotNet GlobalSetup method utilizing the [GlobalSetup] attribute.
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
	/// Generates and stores random data for use in benchmark tests. Call this method first if overridden.
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
	/// Update the Email property in an object that implements <see cref="IPerson{TAddress}" /> with a random email address.
	/// </summary>
	/// <typeparam name="TAddress">The type of the t address.</typeparam>
	/// <param name="person">The coord.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual void Update<TAddress>(IPerson<TAddress> person) where TAddress : IAddress, new()
	{
		if (person is not null)
		{
			person.Email = TestEmailLowerCase;
		}
	}

	/// <summary>
	/// Update the Email property in an <see cref="PersonRecord" /> with a random email address.
	/// </summary>
	/// <param name="person">The coord.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual void Update(PersonRecord person)
	{
		if (person is not null)
		{
			_ = person with { Email = TestEmailLowerCase };
		}
	}

	/// <summary>
	/// Updates the coord's values address.
	/// </summary>
	/// <param name="coord">The coord.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual void Update(ICoordinate coord)
	{
		if (coord is not null)
		{
			coord.X = 100;
			coord.Y = 200;
			coord.Z = 300;
		}
	}

	/// <summary>
	/// Retrieves a random Base64 string generated during startup for use in testing.
	/// </summary>
	/// <value>The base64 string.</value>
	public string Base64String { get; internal set; }

	/// <summary>
	/// Retrieves a random coordinate generated during startup for use in testing.
	/// </summary>
	/// <value>The coordinate01.</value>
	public Coordinate Coordinate01 { get; private set; }

	/// <summary>
	/// Retrieves a random coordinate generated during startup.
	/// </summary>
	/// <value>The coordinate02.</value>
	public Coordinate Coordinate02 { get; private set; }

	/// <summary>
	/// Retrieve JSON from resources for a <see cref="IPerson{TAddress}" /> object.
	/// </summary>
	/// <value>The json test data coord proper.</value>
	public static string JsonTestDataPerson => Resources.JsonTestDataPerson;

	/// <summary>
	/// Retrieve JSON from resources for a <see cref="PersonRecord" /> object.
	/// </summary>
	/// <value>The json test data coord record.</value>
	public static string JsonTestDataPersonRecord => Resources.JsonTestDataPersonRecord;

	/// <summary>
	/// Get or set a value indicating whether to launch the BenchmarkDotNet debugger.:
	/// </summary>
	/// <value><c>true</c> if [launch debugger]; otherwise, <c>false</c>.</value>
	public bool LaunchDebugger { get; set; }

	/// <summary>
	/// Retrieve a long test string with a length of 969 characters, including spaces.
	/// </summary>
	/// <value>The long test string.</value>
	public string LongTestString { get; } = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

	/// <summary>
	/// Retrieve the JSON representation of a <see cref="IPerson{TAddress}" /> object from the resources.
	/// </summary>
	/// <value>The person json.</value>
	public static string PersonJson => Resources.JsonTestDataPerson;

	/// <summary>
	/// Retrieve a randomly generated PersonRecord during startup for testing purposes.
	/// </summary>
	/// <value>The coord record01.</value>
	public PersonRecord PersonRecord01 { get; private set; }

	/// <summary>
	/// Retrieve a randomly generated PersonRecord during startup for testing purposes.
	/// </summary>
	/// <value>The coord record02.</value>
	public PersonRecord PersonRecord02 { get; private set; }

	/// <summary>
	/// Retrieve the JSON representation of a <see cref="PersonRecord" /> object from the resources.
	/// </summary>
	/// <value>The person record json.</value>
	public static string PersonRecordJson => Resources.JsonTestDataPersonRecord;

	/// <summary>
	/// Retrieve the XML representation of a <see cref="PersonRecord" /> object from the resources.
	/// </summary>
	/// <value>The person record XML.</value>
	public static string PersonRecordXml => Resources.XmlTestDataPersonRecord;

	/// <summary>
	/// Retrieves a <see cref="IPerson{TAddress}" /> reference type object for testing generated during startup.
	/// </summary>
	/// <value>The coord ref01.</value>
	public Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> PersonRef01 { get; private set; }

	/// <summary>
	/// Retrieves a <see cref="IPerson{TAddress}" /> reference type object for testing generated during startup.
	/// </summary>
	/// <value>The coord ref02.</value>
	public Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address> PersonRef02 { get; private set; }

	/// <summary>
	/// Retrieves a <see cref="IPerson{TAddress}" /> value type object for testing generated during startup.
	/// </summary>
	/// <value>The coord value01.</value>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address> PersonVal01 { get; private set; }

	/// <summary>
	/// Retrieves a <see cref="IPerson{TAddress}" /> value type object for testing generated during startup.
	/// </summary>
	/// <value>The coord value02.</value>
	public Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address> PersonVal02 { get; private set; }

	/// <summary>
	/// Retrieve the XML representation of a <see cref="IPerson{TAddress}" /> object from the resources.
	/// </summary>
	/// <value>The person XML.</value>
	public static string PersonXml => Resources.XmlTestDataPerson;

	/// <summary>
	/// Retrieve a string with spaces on both sides for testing purposes.
	/// </summary>
	/// <value>The string to trim.</value>
	public virtual string StringToTrim { get; private set; }

	/// <summary>
	/// Retrieve a Guid generated at startup for testing purposes.
	/// </summary>
	/// <value>The test unique identifier.</value>
	public Guid TestGuid { get; internal set; }

}
