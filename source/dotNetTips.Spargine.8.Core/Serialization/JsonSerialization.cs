// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 03-07-2025
// ***********************************************************************
// <copyright file="JsonSerialization.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides methods for serializing objects to JSON strings and
// deserializing JSON strings to objects.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// Provides methods for serializing objects to JSON strings and deserializing JSON strings to objects.
/// Utilizes the System.Text.Json namespace for efficient processing. This class supports custom serialization
/// options and aims to simplify the use of JSON serialization in .NET applications.
/// </summary>
[Information(Documentation = "https://bit.ly/SpargineJsonSerialization", Status = Status.Available)]
public static class JsonSerialization
{
	/// <summary>
	/// Specifies options for JSON serialization and deserialization.
	/// </summary>
	private static readonly JsonSerializerOptions _options = new()
	{
		NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
	};

	/// <summary>
	/// Compares two <see cref="JsonElement"/> instances for equality, considering their structure and data.
	/// </summary>
	/// <param name="expected">The expected <see cref="JsonElement"/> structure.</param>
	/// <param name="actual">The actual <see cref="JsonElement"/> structure to compare against the expected.</param>
	/// <returns><c>true</c> if both <see cref="JsonElement"/> instances are equal; otherwise, <c>false</c>.</returns>
	/// <exception cref="NotSupportedException">Thrown when encountering an undefined or unexpected JsonValueKind.</exception>
	/// <remarks>
	/// This method performs a deep comparison of the contents of two <see cref="JsonElement"/> instances,
	/// including objects, arrays, and primitive values. It is designed to handle complex JSON structures
	/// and can be used for testing and validation purposes.
	/// </remarks>
	private static bool JsonEqual(in JsonElement expected, in JsonElement actual)
	{
		var valueKind = expected.ValueKind;

		if (valueKind != actual.ValueKind)
		{
			return false;
		}

		switch (valueKind)
		{
			case JsonValueKind.Object:
				var propertyNames = new HashSet<string>();

				using (var expectedEnumerator = expected.EnumerateObject())
				{
					foreach (var property in expectedEnumerator)
					{
						_ = propertyNames.Add(property.Name);
					}
				}

				using (var actualEnumerator = actual.EnumerateObject())
				{
					foreach (var property in actualEnumerator)
					{
						_ = propertyNames.Add(property.Name);
					}
				}

				foreach (var name in propertyNames)
				{
					if (!JsonEqual(expected.GetProperty(name), actual.GetProperty(name)))
					{
						return false;
					}
				}

				return true;
			case JsonValueKind.Array:
				using (var expectedEnumerator = actual.EnumerateArray())
				{
					using (var actualEnumerator = expected.EnumerateArray())
					{
						while (expectedEnumerator.MoveNext())
						{
							if (!actualEnumerator.MoveNext())
							{
								return false;
							}

							if (!JsonEqual(expectedEnumerator.Current, actualEnumerator.Current))
							{
								return false;
							}
						}

						return !actualEnumerator.MoveNext();
					}
				}

			case JsonValueKind.String:
				return string.Equals(expected.GetString(), actual.GetString(), StringComparison.Ordinal);
			case JsonValueKind.Number:
			case JsonValueKind.True:
			case JsonValueKind.False:
			case JsonValueKind.Null:
				return string.Equals(expected.GetRawText(), actual.GetRawText(), StringComparison.Ordinal);
			case JsonValueKind.Undefined:
				throw new NotSupportedException($"Undefined JsonValueKind: {valueKind}.");
			default:
				throw new NotSupportedException($"Unexpected JsonValueKind: {valueKind}.");
		}
	}

	/// <summary>
	/// Converts a specified JSON string into its corresponding object representation.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <returns>An instance of <typeparamref name="TResult"/> deserialized from the JSON string.</returns>
	/// <exception cref="InvalidOperationException">Failed to deserialize the JSON string to {typeof(TResult)}.</exception>
	/// <remarks>This method uses the configured <see cref="JsonSerializerOptions"/> for deserialization.
	/// It throws an <see cref="InvalidOperationException"/> if the deserialization process fails
	/// or if the result is null, ensuring that a valid object is always returned.</remarks>
	[Information(nameof(Deserialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TResult Deserialize<TResult>([NotNull][StringSyntax(StringSyntaxAttribute.Json)] string json)
	{
		json = json.ArgumentNotNullOrEmpty();

		return JsonSerializer.Deserialize<TResult>(json, _options) ??
				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
	}

	/// <summary>
	/// Reads JSON content from a specified file and deserializes it into an object.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize the JSON content into.</typeparam>
	/// <param name="file">The file containing the JSON content to deserialize.</param>
	/// <returns>An instance of <typeparamref name="TResult"/> deserialized from the JSON content in the file.</returns>
	/// <exception cref="FileNotFoundException">Thrown if the specified file does not exist.</exception>
	[Information(nameof(DeserializeFromFile), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TResult DeserializeFromFile<TResult>([NotNull] FileInfo file) where TResult : class
	{
		file = file.ArgumentNotNull();

		if (file.Exists is false)
		{
			ExceptionThrower.ThrowFileNotFoundException(Resources.FileNotFoundCannotDeserializeFromJSON, file.FullName);
		}

		return Deserialize<TResult>(File.ReadAllText(file.FullName));
	}

	/// <summary>
	/// Determines whether [is valid JSON] [the specified json].
	/// </summary>
	/// <param name="actual">The actual.</param>
	/// <param name="expected">The expected.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool JsonEqual([NotNull] string actual, in string expected)
	{
		actual = actual.ArgumentNotNullOrEmpty();

		using (var expectedDom = JsonDocument.Parse(expected))
		{
			using (var actualDom = JsonDocument.Parse(actual))
			{
				return JsonEqual(expectedDom.RootElement, actualDom.RootElement);
			}
		}
	}

	/// <summary>
	/// Reads JSON content from a specified file and deserializes it into an object.
	/// </summary>
	/// <typeparam name="T">The type of objects to deserialize.</typeparam>
	/// <param name="json">The JSON string containing the collection.</param>
	/// <param name="count">The number of objects to deserialize from the JSON string.</param>
	/// <returns>An array of deserialized objects of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the count is less than 1.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or cannot be deserialized to the specified type.</exception>
	[Information(nameof(LoadCollectionFromJson), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T[] LoadCollectionFromJson<T>([NotNull][StringSyntax(StringSyntaxAttribute.Json)] string json, [ConstantExpected(Min = 1, Max = int.MaxValue)] int count)
	{
		json = json.ArgumentNotNullOrEmpty();
		count = count.ArgumentInRange(lower: 1);

		var items = new T[count];

		using (var doc = JsonDocument.Parse(json))
		{
			var root = doc.RootElement;

			for (var itemCount = 0; itemCount < count; itemCount++)
			{
				items[itemCount] = root[itemCount].Deserialize<T>(_options);
			}
		}

		return items;
	}

	/// <summary>
	/// Reads JSON content from a specified file and deserializes it into an object.
	/// </summary>
	/// <typeparam name="T">The type of objects to deserialize.</typeparam>
	/// <param name="json">The JSON string containing the collection.</param>
	/// <param name="count">The number of objects to deserialize from the JSON string.</param>
	/// <param name="info">The metadata information for the type to deserialize.</param>
	/// <returns>An array of deserialized objects of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the count is less than 1.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or cannot be deserialized to the specified type.</exception>
	[Information(nameof(LoadCollectionFromJson), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T[] LoadCollectionFromJson<T>([NotNull][StringSyntax(StringSyntaxAttribute.Json)] string json, [ConstantExpected(Min = 1, Max = int.MaxValue)] int count, JsonTypeInfo info)
	{
		json = json.ArgumentNotNullOrEmpty();
		count = count.ArgumentInRange(lower: 1);
		info = info.ArgumentNotNull();

		var items = new T[count];

		using (var doc = JsonDocument.Parse(json))
		{
			var root = doc.RootElement;
			for (var itemCount = 0; itemCount < count; itemCount++)
			{
				items[itemCount] = (T)root[itemCount].Deserialize(info);
			}
		}

		return items;
	}

	/// <summary>
	/// Serializes an object into its JSON string representation.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <returns>A JSON string representation of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input object is null.</exception>
	/// <remarks>This method uses the configured JsonSerializerOptions for serialization.
	/// It ensures that the serialized string is in a format that can be easily deserialized back into an object.</remarks>
	[Information(nameof(Serialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Serialize([NotNull] object obj)
	{
		obj = obj.ArgumentNotNull();

		return JsonSerializer.Serialize(obj);
	}

	/// <summary>
	/// Serializes an object and saves it to a specified JSON.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="file">The file information where the JSON content will be written.</param>
	/// <exception cref="ArgumentNullException">Thrown if the input object or file is null.</exception>
	/// <remarks>This method ensures that all directories and subdirectories in the specified path are created unless they already exist before writing the JSON content.
	/// Utilizes the configured JsonSerializerOptions for serialization.</remarks>
	[Information(nameof(SerializeToFile), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void SerializeToFile([NotNull] object obj, [NotNull] FileInfo file)
	{
		obj = obj.ArgumentNotNull();
		file = file.ArgumentNotNull();

		file.Directory?.Create();

		File.WriteAllText(file.FullName, Serialize(obj));
	}
}
