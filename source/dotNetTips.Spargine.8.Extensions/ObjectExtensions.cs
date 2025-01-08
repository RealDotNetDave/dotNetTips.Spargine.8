// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-07-2025
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for Object.</summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a collection of extension methods for objects, enhancing functionality with additional utility methods for common tasks.
/// </summary>
/// <remarks>
/// This class includes methods for deep cloning objects, computing SHA256 hashes, disposing object fields, converting objects to and from JSON,
/// checking for properties, initializing fields, checking for nullability, converting properties to dictionaries or strings, and more.
/// These methods are designed to extend the capabilities of all objects and simplify common operations related to serialization,
/// reflection, and memory management.
/// </remarks>
[Information(Documentation = "https://bit.ly/SpargineObjectExtensions", Status = Status.Available)]
public static class ObjectExtensions
{

	/// <summary>
	/// The options
	/// </summary>
	private static readonly JsonSerializerOptions _options = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Converts an object to a specified type, offering a clean way to cast or switch between types without throwing exceptions when dealing with mismatched types.
	/// </summary>
	/// <typeparam name="T">The type to which to convert the object.</typeparam>
	/// <param name="obj">The object to convert.</param>
	/// <returns>An object of type <typeparamref name="T" />.</returns>
	/// <exception cref="InvalidCastException">Thrown if the object cannot be cast to type <typeparamref name="T" />.</exception>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(As), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T As<T>([NotNull] this object obj) => (T)obj.ArgumentNotNull();

	/// <summary>
	/// Creates a deep clone of an object by serializing it into JSON and deserializing it back.
	/// This approach ensures a complete copy of the object, but the object must be serializable with System.Text.Json.
	/// This method is ideal when working with complex object graphs that need duplication.
	/// </summary>
	/// <typeparam name="T">The type of the object being cloned.</typeparam>
	/// <param name="obj">The object to clone.</param>
	/// <returns>A deep clone of the original object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static T Clone<T>([NotNull] this object obj) => FromJson<T>(obj.ArgumentNotNull().ToJson());

	/// <summary>
	/// Generates a SHA-256 hash of the object’s serialized JSON.
	/// This is particularly valuable when you need to create a unique, consistent identifier for an object based on its data, rather than its reference identity.
	/// It's perfect for caching or object comparison scenarios.
	/// </summary>
	/// <param name="obj">The object to compute the hash for.</param>
	/// <returns>A string representing the hexadecimal value of the SHA-256 hash.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ComputeSha256Hash), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ComputeSha256Hash([NotNull] this object obj)
	{
		obj = obj.ArgumentNotNull();

		// Create a SHA256
		// ComputeHash - returns byte array
		var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(obj.ToJson())).AsSpan();

		// Convert byte array to a string
		var sb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			foreach (var @byte in bytes)
			{
				_ = sb.Append(@byte.ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Automatically disposes of all IDisposable fields within an object using reflection, simplifying memory management in classes that deal with unmanaged resources.
	/// This method is a must-use in any IDisposable implementation, ensuring resources are freed efficiently.
	/// </summary>
	/// <param name="obj">The object containing IDisposable fields to be disposed.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DisposeFields), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void DisposeFields([NotNull] this IDisposable obj)
	{
		if (obj is null)
		{
			return;
		}

		foreach (var field in obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
		{
			if (field.FieldType.IsAssignableTo(typeof(IDisposable)) && field.GetValue(obj) is IDisposable disposableField)
			{
				disposableField.Dispose();
			}
		}
	}

	/// <summary>
	///Provides an optimized method to compute a hash code for an
	///object, enhancing performance when working with large
	///collections or when using objects as keys in hash-based
	///collections.
	/// </summary>
	/// <param name="obj">The object to compute the hash code for.</param>
	/// <returns>A fast hash code for the specified object.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastGetHashCode), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static int FastGetHashCode(this object obj)
	{
		obj = obj.ArgumentNotNull();

		return RuntimeHelpers.GetHashCode(obj);
	}

	/// <summary>
	/// Deserializes a JSON string back into an object.
	/// This method simplifies working with JSON data, reducing the overhead of manual deserialization.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <returns>An instance of <typeparamref name="TResult" /> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="json" /> is null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FromJson), "David McCarter", "4/21/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TResult FromJson<TResult>([NotNull][StringSyntax(StringSyntaxAttribute.Json)] this string json) => JsonSerialization.Deserialize<TResult>(json.ArgumentNotNullOrEmpty());

	/// <summary>
	/// Determines whether an object contains a specific property.
	/// Using reflection, this method can check both public and private properties, making it a versatile tool when dealing with dynamic or loosely-typed data.
	/// </summary>
	/// <param name="obj">The object to inspect.</param>
	/// <param name="propertyName">The name of the property to search for.</param>
	/// <returns><c>true</c> if the property exists; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasProperty), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasProperty([NotNull] this object obj, [NotNull] string propertyName) => obj.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) != null;

	/// <summary>
	/// Automatically sets all null instance fields of an object to their default values.
	/// This reflection-based method is a time-saver when working with objects that have numerous fields, reducing the need for manual initialization, especially in data models or DTOs.
	/// </summary>
	/// <param name="obj">The object whose fields will be initialized. Must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(InitializeFields), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static void InitializeFields([NotNull] this object obj)
	{
		obj = obj.ArgumentNotNull();

		var fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

		foreach (var field in fields)
		{
			if (field.GetValue(obj) == null && !field.FieldType.IsValueType)
			{
				var defaultValue = Activator.CreateInstance(field.FieldType, true);
				field.SetValue(obj, defaultValue);
			}
		}
	}

	/// <summary>
	/// Determines whether the specified object is not null.
	/// </summary>
	/// <param name="obj">The object to check.</param>
	/// <returns><c>true</c> if the object is not null; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsNotNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsNotNull([AllowNull] this object obj) => obj is not null;

	/// <summary>
	/// Determines whether the specified object is null.
	/// </summary>
	/// <param name="obj">The object to test for null.</param>
	/// <returns><c>true</c> if the object is null; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method is an extension method and can be called on any object to easily check for nullity.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsNull([AllowNull] this object obj) => obj is null;

	/// <summary>
	/// Converts an object’s properties into a dictionary, with property names as keys and their values as dictionary values.
	/// This is useful when you need to pass an object's state to a logging mechanism, or transform it for flexible data manipulation.
	/// </summary>
	/// <param name="obj">The object whose properties are to be converted.</param>
	/// <param name="memberName">The name of a specific member to convert. If empty, all properties are converted.</param>
	/// <param name="ignoreNulls">Specifies whether to ignore properties with null values.</param>
	/// <returns>A dictionary containing the names and string representations of the properties of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	/// <example>Output:
	/// [0]: {[PersonRecord.BornOn, 1/29/2007 11:52:12 AM -08:00]}
	/// [1]: {[PersonRecord.CellPhone, 747-388-4458]}
	/// [2]: {[PersonRecord.Email, elfhlsoepfmuiyr@uomrrywscvaapwjcu.org.uk]}
	/// [3]: {[PersonRecord.FirstName, ZyeMgwQRFABsisq]}
	/// [4]: {[PersonRecord.HomePhone, 255 - 871 - 4415]}
	/// [5]: {[PersonRecord.Id, 58dc933fe6004719a37e7a35373ad645]}
	/// [6]: {[PersonRecord.LastName, j_`iqWAGoOeKTpjWhojFyRHld]}
	/// [7]: {[PersonRecord.Addresses[0].Address1, XkbOcAlseMEMnPY ^ jkEcYWnFD]}
	/// [8]: {[PersonRecord.Addresses[0].Address2, tJkpTHikrRfFaGENX]`_agaw[]}
	/// [9]: {[PersonRecord.Addresses[0].City, KlWA ^ Aw]KhqADREV\uwmXJeAU]}
	/// [10]: {[PersonRecord.Addresses[0].Country, AtN`\NbnUIVSjUQicVXNMUL[J]}
	/// [11]: {[PersonRecord.Addresses[0].Id, 9330f3a225b14d96b67779f2c932302a]}
	/// [12]: {[PersonRecord.Addresses[0].CountyProvince, EkdKDBGWf ^ Givi[OMhIh]}
	/// [13]: {[PersonRecord.Addresses[0].State, RGOuDpJyfgwxyfC]}
	/// [14]: {[PersonRecord.Addresses[0].Phone, 065 - 507 - 7161]}
	/// [15]: {[PersonRecord.Addresses[0].PostalCode, 56633485]}
	/// [16]: {[PersonRecord.Addresses[1].Address1, lGSJwGNOtd ^ rXv`RxPcVCZHhk]}
	/// [17]: {[PersonRecord.Addresses[1].Address2, \EJGOmHyfAPERA ^ DrTR`xlDFU]}
	/// [18]: {[PersonRecord.Addresses[1].City, xiWPASydY[BEHfpVrluPNgOFS]}
	/// [19]: {[PersonRecord.Addresses[1].Country, JFpIljBDlQEkiehQ[r`\xjh[J]}
	/// [20]: {[PersonRecord.Addresses[1].Id, 8c95fd0cbbcf4beb993081bdd9c96ceb]}
	/// [21]: {[PersonRecord.Addresses[1].CountyProvince, FyHoHRZQwpMJ[gjABVUk]}
	/// [22]: {[PersonRecord.Addresses[1].State, dxeZkn[HyLo\wUS]}
	/// [23]: {[PersonRecord.Addresses[1].Phone, 511 - 286 - 7653]}
	/// [24]: {[PersonRecord.Addresses[1].PostalCode, 33385672]}
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNull]
	[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static IDictionary<string, string> PropertiesToDictionary([NotNull] this object obj, [NotNull] string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
	{
		var result = new Dictionary<string, string>();
		memberName = memberName.ArgumentNotNull();
		var objectType = obj.ArgumentNotNull().GetType();

		// Reserve a special treatment for specific types by design (like string -that's a list of chars and you don't want to iterate on its items)
		if (TypeHelper.BuiltInTypeNames.ContainsKey(objectType))
		{
			result.Add(memberName, obj.ToString());
			return result;
		}

		// If the type implements the IEnumerable interface.
		if (objectType.IsEnumerable())
		{
			var itemCount = 0;

			// Loop through the collection using the enumerator strategy and collect all items in the result bag
			// Note: if the collection is empty it will not return anything about its existence,
			// because the method is supposed to catch value items not the list itself
			foreach (var item in (IEnumerable)obj)
			{
				var itemId = itemCount++;

				var itemInnerMember = string.Format(CultureInfo.CurrentCulture, $"{{0}}[{{1}}]", memberName, itemId);

				result = result.Concat(item.PropertiesToDictionary(itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
			}

			return result;
		}

		// Otherwise go deeper in the object tree.
		// And foreach object public property collect each value
		var propertyCollection = objectType.GetProperties().AsReadOnlySpan();

		var newMemberName = string.Empty;

		if (memberName.Length > 0)
		{
			newMemberName = $"{memberName}{ControlChars.Dot}";
		}

		var propertyCount = propertyCollection.Length;

		for (var propertyIndex = 0; propertyIndex < propertyCount; propertyIndex++)
		{
			var property = propertyCollection[propertyIndex];
			var ignoreAttribute = property.GetAttribute<JsonIgnoreAttribute>();

			if (ignoreAttribute == null)
			{
				var innerObject = property.GetValue(obj, null);

				if (ignoreNulls && innerObject is null)
				{
					continue;
				}

				var innerMember = string.Format(CultureInfo.CurrentCulture, "{0}{1}", newMemberName, property.Name);

				result = result.Concat(innerObject.PropertiesToDictionary(innerMember)).ToDictionary(e => e.Key, e => e.Value);
			}
		}

		return result;
	}

	/// <summary>
	/// Converts an object’s properties into a dictionary, with property names as keys and their values as dictionary values.
	/// This is useful when you need to pass an object's state to a logging mechanism, or transform it for flexible data manipulation.
	/// </summary>
	/// <param name="obj">The object whose properties are to be converted.</param>
	/// <param name="header">An optional header to prepend to the string representation.</param>
	/// <param name="keyValueSeparator">The character used to separate property names from their values.</param>
	/// <param name="sequenceSeparator">The string used to separate properties in the string representation.</param>
	/// <param name="ignoreNulls">Specifies whether properties with null values should be ignored.</param>
	/// <param name="includeMemberName">Specifies whether the property name should be included in the string representation.</param>
	/// <returns>A string representation of the object's properties.</returns>
	/// <example>Output:
	/// PersonRecord, PersonRecord.BornOn:1/29/2007 11:52:12 AM -08:00, PersonRecord.CellPhone:747-388-4458,
	/// PersonRecord.Email:elfhlsoepfmuiyr @uomrrywscvaapwjcu.org.uk, PersonRecord.FirstName:ZyeMgwQRFABsisq,
	/// PersonRecord.HomePhone:255-871-4415, PersonRecord.Id:58dc933fe6004719a37e7a35373ad645,
	/// PersonRecord.LastName:j_`iqWAGoOeKTpjWhojFyRHld, PersonRecord.Addresses[0].Address1:XkbOcAlseMEMnPY^jkEcYWnFD,
	/// PersonRecord.Addresses[0].Address2:tJkpTHikrRfFaGENX]`_agaw[,
	/// PersonRecord.Addresses[0].City:KlWA ^ Aw] KhqADREV\\uwmXJeAU,
	/// PersonRecord.Addresses[0].Country:AtN`\\NbnUIVSjUQicVXNMUL[J,
	/// PersonRecord.Addresses[0].Id:9330f3a225b14d96b67779f2c932302a,
	/// PersonRecord.Addresses[0].CountyProvince:EkdKDBGWf ^ Givi[OMhIh,
	/// PersonRecord.Addresses[0].State:RGOuDpJyfgwxyfC, PersonRecord.Addresses[0].Phone:065 - 507 - 7161,
	/// PersonRecord.Addresses[0].PostalCode:56633485, PersonRecord.Addresses[1].Address1:lGSJwGNOtd ^ rXv`RxPcVCZHhk,
	/// PersonRecord.Addresses[1].Address2:\\EJGOmHyfAPERA ^ DrTR`xlDFU,
	/// PersonRecord.Addresses[1].City:xiWPASydY[BEHfpVrluPNgOFS,
	/// PersonRecord.Addresses[1].Country:JFpIljBDlQEkiehQ[r`\\xjh[J,
	/// PersonRecord.Addresses[1].Id:8c95fd0cbbcf4beb993081bdd9c96ceb,
	/// PersonRecord.Addresses[1].CountyProvince:FyHoHRZQwpMJ[gjABVUk,
	/// PersonRecord.Addresses[1].State:dxeZkn[HyLo\\wUS, PersonRecord.Addresses[1].Phone:511 - 286 - 7653,
	/// PersonRecord.Addresses[1].PostalCode:33385672
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static string PropertiesToString([NotNull] this object obj, [AllowNull] string header = ControlChars.EmptyString, char keyValueSeparator = ControlChars.Colon, [NotNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
	{
		obj = obj.ArgumentNotNull();
		sequenceSeparator = sequenceSeparator.ArgumentNotNull();

		var typeName = obj.GetType().Name;

		if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
		{
			typeName = "Item";
		}
		else if (includeMemberName is false)
		{
			typeName = string.Empty;
		}

		var properties = obj.PropertiesToDictionary(memberName: typeName, ignoreNulls: ignoreNulls);

		var result = properties.Aggregate(header, (acc, pair) => string.Format(CultureInfo.CurrentCulture, "{0}{1}{2}{3}{4}", acc, sequenceSeparator, pair.Key, keyValueSeparator, pair.Value));

		return result.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result.Remove(0, sequenceSeparator.Length) : result;
	}

	/// <summary>
	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// </summary>
	/// <param name="obj">The object to convert to a string.</param>
	/// <returns>The string representation of <paramref name="obj" /> if it is not null; otherwise, an empty string.</returns>
	[Information(nameof(StripNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string StripNull([AllowNull] this object obj) => obj?.ToString() ?? string.Empty;

	/// <summary>
	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <returns>A JSON string representation of <paramref name="obj" />.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	[return: NotNull]
	public static string ToJson([NotNull] this object obj) => JsonSerializer.Serialize(obj.ArgumentNotNull(), _options);

	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// <param name="obj">The object to serialize.</param>
	/// <param name="options">The options to use for serialization, or null to use default options.</param>
	/// <returns>A <see cref="SimpleResult{T}"/> containing the JSON string representation of the object and a flag indicating success.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static SimpleResult<string> ToJson([NotNull] this object obj, [AllowNull] JsonSerializerOptions options = null)
	{
		obj = obj.ArgumentNotNull();

		try
		{
			return SimpleResult.FromValue(JsonSerializer.Serialize(obj, options));
		}
		catch (NotSupportedException ex)
		{
			return SimpleResult.FromException<string>(ex);
		}
	}

	/// <summary>
	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="file">The file information where the JSON will be saved. Must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> or <paramref name="file" /> is null.</exception>
	/// <exception cref="JsonException">Thrown if an error occurs during serialization.</exception>
	/// <exception cref="IOException">Thrown if an error occurs while writing the file.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToJsonFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void ToJsonFile([NotNull] this object obj, [NotNull] FileInfo file)
	{
		file = file.ArgumentNotNull();

		var json = obj.ArgumentNotNull().ToJson();

		File.WriteAllText(file.FullName, json, Encoding.UTF8);
	}

	/// <summary>
	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// </summary>
	/// <param name="obj">The <see cref="IDisposable" /> object to dispose.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static void TryDispose([NotNull] this IDisposable obj) => TryDispose(obj.ArgumentNotNull(), false);

	/// <summary>
	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// Optionally throws an exception if the disposal fails.
	/// </summary>
	/// <param name="obj">The <see cref="IDisposable" /> object to dispose.</param>
	/// <param name="throwException">Specifies whether to throw an exception if the disposal fails.</param>
	/// <exception cref="Exception">Thrown if <paramref name="throwException" /> is true and the disposal fails.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void TryDispose([NotNull] this IDisposable obj, [DoesNotReturnIf(true)] bool throwException)
	{
		if (obj is null)
		{
			return;
		}

		try
		{
			if (obj is IAsyncDisposable asyncDisposable)
			{
				var result = asyncDisposable.DisposeAsync();

				if (result.IsFaulted)
				{
					ExceptionThrower.ThrowInvalidOperationException(Resources.ThereIsAnIssueDisposingOfTheObjectUsingAsyncDispose);
				}
			}
			else
			{
				obj.Dispose();
			}
		}
		catch
		{
			if (throwException)
			{
				throw;
			}
		}
	}

}
