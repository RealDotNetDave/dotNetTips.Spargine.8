// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-02-2024
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="David McCarter - dotNetTips.com">
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
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for objects.
/// </summary>
public static class ObjectExtensions
{

	/// <summary>
	/// The options
	/// </summary>
	private static readonly JsonSerializerOptions _options = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Tries to dispose items in the <see cref="IEnumerable" />.
	/// </summary>
	/// <param name="items">The items.</param>
	private static void DisposeCollection(this IEnumerable items) => ProcessCollectionToDispose(items);

	/// <summary>
	/// Processes the <see cref="IEnumerable" /> to dispose.
	/// </summary>
	/// <param name="items">The items.</param>
	private static void ProcessCollectionToDispose(IEnumerable items)
	{
		if (items.HasItems())
		{
			foreach (var item in items)
			{
				if (item is IDisposable disposeItem)
				{
					disposeItem.TryDispose();
				}
			}
		}
	}

	/// <summary>
	/// Converts the specified object to the specified type <typeparamref name="T" />.
	/// </summary>
	/// <typeparam name="T">The type to convert the object to.</typeparam>
	/// <param name="obj">The object to convert.</param>
	/// <returns>The converted object of type <typeparamref name="T" />.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	[Information(nameof(As), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T As<T>([NotNull] this object obj) => (T)obj.ArgumentNotNull();

	/// <summary>
	/// Creates a deep copy of the specified object.
	/// </summary>
	/// <typeparam name="T">The type of the object being cloned.</typeparam>
	/// <param name="obj">The object to clone.</param>
	/// <returns>A deep copy of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	/// <remarks>This method serializes the object to JSON and then deserializes it back to create a deep copy.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T Clone<T>([NotNull] this object obj) => FromJson<T>(obj.ArgumentNotNull().ToJson());

	/// <summary>
	/// Computes the SHA256 hash of the serialized JSON representation of the specified object.
	/// </summary>
	/// <param name="obj">The object to compute the SHA256 hash for. The object is serialized to JSON before hashing.</param>
	/// <returns>A string representing the hexadecimal value of the SHA256 hash.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	/// <remarks>This method serializes the object to JSON using the default serializer settings and then computes the SHA256 hash of the resulting string.
	/// It is useful for generating a consistent hash for objects that can be serialized to JSON.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ComputeSha256Hash), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ComputeSha256Hash([NotNull] this object obj)
	{
		obj = obj.ArgumentNotNull();

		// Create a SHA256
		// ComputeHash - returns byte array
		var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(obj.ToJson())).AsSpan();

		// Convert byte array to a string
		var sb = _stringBuilderPool.Get();

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
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Disposes all disposable fields within the object.
	/// </summary>
	/// <param name="obj">The object containing the fields to dispose.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	/// <remarks>This method uses reflection to iterate through all fields of the object. If a field implements <see cref="IDisposable" />,
	/// it will be disposed. This is useful for cleaning up resources in objects that contain multiple disposable fields.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DisposeFields), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void DisposeFields([NotNull] this IDisposable obj)
	{
		if (obj is null)
		{
			return;
		}

		//ReadOnlySpan and FrozenSet is slower.
		var list = obj.GetType().GetRuntimeFields().Where(p => p.IsStatic is false);

		if (list.DoesNotHaveItems())
		{
			return;
		}

		foreach (var field in list)
		{
			if (field is not null)
			{
				if (field is IDisposable disposableItem)
				{
					disposableItem.TryDispose();
				}
				else if (field is IEnumerable collection)
				{
					collection.DisposeCollection();
				}
			}
		}
	}

	/// <summary>
	/// Deserializes the JSON string to an object of type <typeparamref name="TResult" />.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <returns>An instance of <typeparamref name="TResult" /> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="json" /> is null or empty.</exception>
	[Information(nameof(FromJson), "David McCarter", "4/21/2022", UnitTestStatus = UnitTestStatus.Completed, Status = Status.NeedsDocumentation, OptimizationStatus = OptimizationStatus.Completed)]
	public static TResult FromJson<TResult>([NotNull][StringSyntax(StringSyntaxAttribute.Json)] this string json) => JsonSerialization.Deserialize<TResult>(json.ArgumentNotNullOrEmpty());

	/// <summary>
	/// Determines whether the specified object has a property with the given name.
	/// </summary>
	/// <param name="obj">The object to check.</param>
	/// <param name="propertyName">The name of the property to look for.</param>
	/// <returns><c>true</c> if the property exists; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> or <paramref name="propertyName" /> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasProperty), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasProperty([NotNull] this object obj, [NotNull] string propertyName)
	{
		if (obj is null)
		{
			return false;
		}

		propertyName = propertyName.ArgumentNotNullOrEmpty();

		var type = obj.GetType();
		return type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance) != null;
	}

	/// <summary>
	/// Initializes all fields of the specified object that are currently null to their default values.
	/// This method uses reflection to iterate through all instance fields of the object and initializes
	/// fields that are null and not of a value type. This can be particularly useful for initializing
	/// objects that have many fields, reducing the need for manual initialization.
	/// </summary>
	/// <param name="obj">The object whose fields will be initialized. Must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(InitializeFields), UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
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
	[Information(nameof(IsNotNull), UnitTestStatus = UnitTestStatus.Completed, Status = Status.NeedsDocumentation, OptimizationStatus = OptimizationStatus.Completed)]
	public static bool IsNotNull([AllowNull] this object obj) => obj is not null;

	/// <summary>
	/// Determines whether the specified object is null.
	/// </summary>
	/// <param name="obj">The object to check.</param>
	/// <returns><c>true</c> if the object is null; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNull), UnitTestStatus = UnitTestStatus.Completed, Status = Status.CheckPerformance, OptimizationStatus = OptimizationStatus.WIP)]
	public static bool IsNull([AllowNull] this object obj) => obj is null;

	/// <summary>
	/// Converts the properties of the specified object to a dictionary.
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
	[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.WIP, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static IDictionary<string, string> PropertiesToDictionary([NotNull] this object obj, [NotNull] string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
	{
		obj = obj.ArgumentNotNull();

		var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
		var result = new Dictionary<string, string>();

		//SPAN IS SLOWER
		foreach (var property in properties)
		{
			if (!string.IsNullOrEmpty(memberName) && !property.Name.Equals(memberName, StringComparison.Ordinal))
			{
				continue;
			}

			var value = property.GetValue(obj);
			if (value == null && ignoreNulls)
			{
				continue;
			}

			result[property.Name] = value?.ToString() ?? string.Empty;
		}

		return result;
	}

	/// <summary>
	/// Converts the properties of the specified object to a string representation.
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
	[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/SpargineFeb2021")]
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
	/// Returns a non-null string representation of the specified object.
	/// </summary>
	/// <param name="obj">The object to convert to a string.</param>
	/// <returns>The string representation of <paramref name="obj" /> if it is not null; otherwise, an empty string.</returns>
	[Information(nameof(StripNull), UnitTestStatus = UnitTestStatus.Completed, Status = Status.NeedsDocumentation, OptimizationStatus = OptimizationStatus.Completed)]
	public static string StripNull([AllowNull] this object obj) => obj is null ? string.Empty : obj.ToString();

	/// <summary>
	/// Serializes the specified object to a JSON string using predefined JsonSerializerOptions.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <returns>A JSON string representation of <paramref name="obj" />.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[return: NotNull]
	public static string ToJson([NotNull] this object obj) => JsonSerializer.Serialize(obj.ArgumentNotNull(), _options);

	/// <summary>
	/// Serializes the specified object to a JSON string using optional JsonSerializerOptions.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="options">The JsonSerializerOptions to use for serialization. If null, default options will be used.</param>
	/// <returns>A <see cref="SimpleResult{T}" /> containing the JSON string representation of <paramref name="obj" /> if serialization is successful; otherwise, contains the exception.</returns>
	/// <exception cref="NotSupportedException">Thrown if serialization is not supported for the object.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug23")]
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
	/// Serializes the specified object to a JSON file.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="file">The file information where the JSON will be saved. Must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj" /> or <paramref name="file" /> is null.</exception>
	/// <exception cref="JsonException">Thrown if an error occurs during serialization.</exception>
	/// <exception cref="IOException">Thrown if an error occurs while writing the file.</exception>
	/// <remarks>This method serializes the object to a JSON string using the default JsonSerializerOptions and writes it to the specified file.
	/// If the file already exists, it will be overwritten.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToJsonFile), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void ToJsonFile([NotNull] this object obj, [NotNull] FileInfo file)
	{
		file = file.ArgumentNotNull();

		var json = obj.ArgumentNotNull().ToJson();

		File.WriteAllText(file.FullName, json, Encoding.UTF8);
	}

	/// <summary>
	/// Attempts to dispose the specified object and suppresses any exceptions.
	/// </summary>
	/// <param name="obj">The <see cref="IDisposable" /> object to dispose.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, Status = Status.CheckPerformance)]
	public static void TryDispose([NotNull] this IDisposable obj) => TryDispose(obj.ArgumentNotNull(), false);

	/// <summary>
	/// Attempts to dispose the specified object and optionally throws an exception if the disposal fails.
	/// </summary>
	/// <param name="obj">The <see cref="IDisposable" /> object to dispose.</param>
	/// <param name="throwException">Specifies whether to throw an exception if the disposal fails.</param>
	/// <exception cref="Exception">Thrown if <paramref name="throwException" /> is true and the disposal fails.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, Status = Status.CheckPerformance)]
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
