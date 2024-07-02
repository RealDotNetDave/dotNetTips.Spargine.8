// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-21-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="JsonSerialization.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// This class simplifies the process of serializing and deserializing
// strings to and from JSON format using the JsonSerializer. JSON
// serialization is a widely adopted and efficient method for storing
// and exchanging data in various applications and APIs.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// Provides methods for serializing objects to JSON strings and deserializing JSON strings to objects.
/// Utilizes the System.Text.Json namespace for efficient processing. This class supports custom serialization
/// options and aims to simplify the use of JSON serialization in .NET applications.
/// </summary>
public static class JsonSerialization
{

	/// <summary>
	/// Specifies options for JSON serialization and deserialization.
	/// </summary>
	/// <remarks>
	/// This includes settings such as number handling to allow reading from and writing numbers as strings.
	/// </remarks>
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
	/// <exception cref="NotSupportedException">Thrown when an undefined or unexpected <see cref="JsonValueKind"/> is encountered.</exception>
	/// <remarks>
	/// This method performs a deep comparison of the contents of two <see cref="JsonElement"/> instances,
	/// including objects, arrays, and primitive values. It is designed to handle complex JSON structures
	/// and can be used for testing and validation purposes.
	/// </remarks>
	private static bool JsonEqual(JsonElement expected, JsonElement actual)
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
	/// Deserializes the specified JSON string into an object of type <typeparamref name="TResult"/>.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <returns>An instance of <typeparamref name="TResult"/> deserialized from the JSON string.</returns>
	/// <exception cref="InvalidOperationException">Thrown if deserialization fails or the result is null.</exception>
	/// <remarks>
	/// This method uses the configured <see cref="JsonSerializerOptions"/> for deserialization.
	/// It throws an <see cref="InvalidOperationException"/> if the deserialization process fails
	/// or if the result is null, ensuring that a valid object is always returned.
	/// </remarks>
	[Information(nameof(Deserialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static TResult Deserialize<TResult>([NotNull][StringSyntax(StringSyntaxAttribute.Json)] string json) => JsonSerializer.Deserialize<TResult>(json, _options) ?? throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");

	/// <summary>
	/// Deserializes JSON content from a specified file into an object of type <typeparamref name="TResult" />.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize the JSON content into.</typeparam>
	/// <param name="file">The file containing the JSON content to deserialize.</param>
	/// <returns>An instance of <typeparamref name="TResult" /> deserialized from the JSON content in the file.</returns>
	/// <exception cref="FileNotFoundException">Thrown if the specified file does not exist.</exception>
	[Information(nameof(DeserializeFromFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TResult DeserializeFromFile<TResult>([NotNull] FileInfo file) where TResult : class
	{
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
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool JsonEqual([NotNull] string actual, string expected)
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
	/// Serializes the specified object to a JSON string using configured JsonSerializerOptions.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <returns>A JSON string representation of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input object is null.</exception>
	[Information(nameof(Serialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static string Serialize([NotNull] object obj)
	{
		obj = obj.ArgumentNotNull();
		return JsonSerializer.Serialize(obj, _options);
	}

	/// <summary>
	/// Serializes the specified object to a JSON file using configured JsonSerializerOptions.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="file">The file information where the JSON content will be written.</param>
	/// <exception cref="ArgumentNullException">Thrown if the input object or file is null.</exception>
	/// <remarks>This method ensures that all directories and subdirectories in the specified path are created unless they already exist before writing the JSON content.</remarks>
	[Information(nameof(SerializeToFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void SerializeToFile([NotNull] object obj, [NotNull] FileInfo file)
	{
		obj = obj.ArgumentNotNull();
		file = file.ArgumentNotNull();

		file.Directory?.Create(); // Creates all directories and subdirectories in the specified path unless they already exist.

		File.WriteAllText(file.FullName, Serialize(obj));
	}

}
