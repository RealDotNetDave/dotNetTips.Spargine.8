// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="Categories.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common values to be used in the BenchmarkCategory attribute.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Provides a list of categories used to classify benchmarks. These categories help in organizing and filtering benchmarks based on their functionality or the features they demonstrate.
/// </summary>
public static class Categories
{

	/// <summary>
	/// Category for benchmarks involving arrays.
	/// </summary>
	public const string Array = "Array";

	/// <summary>
	/// Category for benchmarks involving asynchronous operations.
	/// </summary>
	public const string Async = "Async";

	/// <summary>
	/// Category for benchmarks related to cloud computing and operations.
	/// </summary>
	public const string Cloud = "Cloud";

	/// <summary>
	/// Category for benchmarks that deal with collections.
	/// </summary>
	public const string Collections = "Collections";

	/// <summary>
	/// Category for benchmarks involving data compression techniques.
	/// </summary>
	public const string Compression = "Compression";

	/// <summary>
	/// Category for benchmarks involving encryption algorithms.
	/// </summary>
	public const string Encryption = "Encryption";

	/// <summary>
	/// Special category for benchmarks that are meant for comparison purposes.
	/// </summary>
	public const string ForComparison = "**FOR COMPARISON**";

	/// <summary>
	/// Category for benchmarks that use generic collections.
	/// </summary>
	public const string GenericCollections = "Collections<>";

	/// <summary>
	/// Category for benchmarks involving globalization features.
	/// </summary>
	public const string Globalization = "Globalization";

	/// <summary>
	/// Category for benchmarks that involve immutable data structures.
	/// </summary>
	public const string Immutable = "Immutable";

	/// <summary>
	/// Category for benchmarks that involve input/output operations.
	/// </summary>
	public const string IO = "IO";

	/// <summary>
	/// Category for benchmarks that involve JSON operations.
	/// </summary>
	public const string JSON = "JSON";

	/// <summary>
	/// Category for benchmarks that involve LINQ operations.
	/// </summary>
	public const string LINQ = "LINQ";

	/// <summary>
	/// Category for benchmarks that involve logging operations.
	/// </summary>
	public const string Logging = "LOGGING";

	/// <summary>
	/// Special category for new benchmarks or benchmarks that have been recently added.
	/// </summary>
	public const string New = "**NEW**";

	/// <summary>
	/// Category for benchmarks that involve queue data structures.
	/// </summary>
	public const string Queues = "Queues";

	/// <summary>
	/// Category for benchmarks that involve record types.
	/// </summary>
	public const string RecordType = "Record Type";

	/// <summary>
	/// Category for benchmarks that involve reference types.
	/// </summary>
	public const string ReferenceType = "Ref Type";

	/// <summary>
	/// Category for benchmarks that involve reflection.
	/// </summary>
	public const string Reflection = "Reflection";

	/// <summary>
	/// Category for benchmarks that involve serialization operations.
	/// </summary>
	public const string Serialization = "Serialization";

	/// <summary>
	/// Category for benchmarks that involve Span operations.
	/// </summary>
	public const string Span = "Span";

	/// <summary>
	/// Category for benchmarks that involve string operations.
	/// </summary>
	public const string Strings = "Strings";

	/// <summary>
	/// Category for benchmarks that involve threading and concurrency.
	/// </summary>
	public const string Threading = "Threading";

	/// <summary>
	/// Special category for benchmarks that have been updated.
	/// </summary>
	public const string Updated = "Updated";

	/// <summary>
	/// Category for benchmarks that involve validation operations.
	/// </summary>
	public const string Validation = "Validation";

	/// <summary>
	/// Category for benchmarks that involve value types.
	/// </summary>
	public const string ValueType = "Value Type";

	/// <summary>
	/// Category for benchmarks that involve XML operations.
	/// </summary>
	public const string XML = "XML";

}
