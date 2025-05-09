// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-10-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2025
// ***********************************************************************
// <copyright file="InternalMethods.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Internal;

/// <summary>
/// Class InternalMethods.
/// </summary>
internal static class InternalMethods
{

	/// <summary>
	/// The null string
	/// </summary>
	private const string NullString = "[null]";


	/// <summary>
	/// Ensures the minimum.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="minValue">The minimum value.</param>
	/// <returns>System.Int32.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureMinimum), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	internal static int EnsureMinimum(this int value, int minValue) => value < minValue ? minValue : value;

	/// <summary>
	/// Generates the random number.
	/// </summary>
	/// <returns>System.Int32.</returns>
	internal static int GenerateRandomNumber() => RandomNumberGenerator.GetInt32(int.MaxValue);

	/// <summary>
	/// Determines whether the specified type is enumerable.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns><c>true</c> if the specified type is enumerable; otherwise, <c>false</c>.</returns>
	internal static bool IsEnumerable(Type type) => type.GetInterfaces().Any(t => t == typeof(IEnumerable));


	/// <summary>
	/// Converts object properties to a <see cref="IDictionary" />.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <param name="memberName">Name of the member.</param>
	/// <param name="ignoreNulls">if set to <c>true</c> [ignore nulls].</param>
	/// <returns>IDictionary&lt;System.String, System.String&gt;.</returns>
	internal static IDictionary<string, string> PropertiesToDictionary(object obj, string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
	{
		var result = new Dictionary<string, string>();

		if (obj is null)
		{
			result.Add(memberName, NullString);
			return result;
		}

		var objectType = obj.GetType();

		// Reserve a special treatment for specific types by design (like string -that's a list of chars and you don't want to iterate on its items)
		if (TypeHelper.BuiltInTypeNames().ContainsKey(objectType))
		{
			result.Add(memberName, obj.ToString());
			return result;
		}

		// If the type implements the IEnumerable interface.
		if (IsEnumerable(objectType))
		{
			var itemCount = 0;

			// Loop through the collection using the enumerator strategy and collect all items in the result bag
			// Note: if the collection is empty it will not return anything about its existence,
			// because the method is supposed to catch value items not the list itself
			foreach (var item in (IEnumerable)obj)
			{
				var itemId = itemCount++;

				var itemInnerMember = string.Format(CultureInfo.CurrentCulture, "{0}[{1}]", memberName, itemId);
				result = result.Concat(PropertiesToDictionary(item, itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
			}
			return result;
		}

		// Otherwise go deeper in the object tree.
		// And foreach object public property collect each value
		var propertyCollection = objectType.GetProperties();

		var newMemberName = string.Empty;

		if (memberName.Length > 0)
		{
			newMemberName = $"{memberName}{ControlChars.Dot}";
		}

		var propertyCount = propertyCollection.LongLength;

		for (var index = 0; index < propertyCount; index++)
		{
			var property = propertyCollection[index];
			var innerObject = property.GetValue(obj, null);

			if (ignoreNulls && innerObject is null)
			{
				continue;
			}

			var innerMember = string.Format(CultureInfo.CurrentCulture, "{0}{1}", newMemberName, property.Name);
			result = result.Concat(PropertiesToDictionary(innerObject, innerMember)).ToDictionary(e => e.Key, e => e.Value);
		}

		return result;
	}

	/// <summary>
	/// Propertieses to string.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <param name="header">The header.</param>
	/// <param name="keyValueSeparator">The key value separator.</param>
	/// <param name="sequenceSeparator">The sequence separator.</param>
	/// <param name="ignoreNulls">if set to <c>true</c> [ignore nulls].</param>
	/// <param name="includeMemberName">if set to <c>true</c> [include member name].</param>
	/// <returns>System.String.</returns>
	internal static string PropertiesToString(this object obj, string header = ControlChars.EmptyString, char keyValueSeparator = ControlChars.Colon, string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
	{
		var typeName = obj.GetType().Name;

		if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
		{
			typeName = "Item";
		}
		else if (includeMemberName is false)
		{
			typeName = string.Empty;
		}

		var properties = PropertiesToDictionary(obj, memberName: typeName, ignoreNulls: ignoreNulls);

		var result = properties.Aggregate(header, (acc, pair) => string.Format(CultureInfo.CurrentCulture, "{0}{1}{2}{3}{4}", acc, sequenceSeparator, pair.Key, keyValueSeparator, pair.Value));

		return result.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result[sequenceSeparator.Length..] : result;
	}

	/// <summary>
	/// Shuffles the specified collection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	internal static IEnumerable<T> Shuffle<T>([NotNull] this IEnumerable<T> collection) => collection.ArgumentItemsExists().OrderBy(_ => GenerateRandomNumber());

}
