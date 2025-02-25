// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 01-03-2025
//
// Last Modified By : David McCarter
// Last Modified On : 02-25-2025
// ***********************************************************************
// <copyright file="AutoDefaultDictionary.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// The AutoDefaultDictionary class simplifies handling of missing keys
// in dictionaries by providing a default value or a custom function to
// generate values dynamically. This can be particularly useful in
// applications where missing data should be handled gracefully without
// throwing exceptions.
// </summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// Represents a dictionary that returns a default value when a key is not found.
/// </summary>
/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
[Serializable]
[Information("Original Code by: Simon Painter. Improvement suggested by: James Curran.", Status = Status.NeedsDocumentation)]
public class AutoDefaultDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializable
		where TKey : notnull
		where TValue : notnull
{
	/// <summary>
	/// The default value to return when a key is not found in the dictionary.
	/// </summary>
	private readonly TValue _defaultValue;

	/// <summary>
	/// The function to call when a key is not found in the dictionary.
	/// </summary>
	private readonly Func<TKey, TValue> _onMissingKey;

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the default value for <typeparamref name="TValue"/>.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary() => this._defaultValue = default;

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified default value for <typeparamref name="TValue"/>.
	/// </summary>
	/// <param name="defaultValue">The default value to return when a key is not found in the dictionary.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(TValue defaultValue) => this._defaultValue = defaultValue;

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified comparer.
	/// </summary>
	/// <param name="comparer">The comparer to use when comparing keys.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(IEqualityComparer<TKey> comparer) : base(comparer) => this._defaultValue = default;

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified function to handle missing keys.
	/// </summary>
	/// <param name="onMissingKey">The function to call when a key is not found in the dictionary.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public AutoDefaultDictionary(Func<TKey, TValue> onMissingKey) => this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified dictionary and default value.
	/// </summary>
	/// <param name="dictionary">The dictionary to initialize with.</param>
	/// <param name="defaultValue">The default value to return when a key is not found in the dictionary.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(IDictionary<TKey, TValue> dictionary, TValue defaultValue) : base(dictionary) => this._defaultValue = defaultValue;

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified dictionary and function to handle missing keys.
	/// </summary>
	/// <param name="dictionary">The dictionary to initialize with.</param>
	/// <param name="onMissingKey">The function to call when a key is not found in the dictionary.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="onMissingKey"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public AutoDefaultDictionary(IDictionary<TKey, TValue> dictionary, Func<TKey, TValue> onMissingKey) : base(dictionary) => this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified key-value pair collection and default value.
	/// </summary>
	/// <param name="keyValuePairs">The key-value pairs to initialize with.</param>
	/// <param name="defaultValue">The default value to return when a key is not found in the dictionary.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs, TValue defaultValue) : base(keyValuePairs.ToDictionary(kvp => kvp.Key, kvp => kvp.Value)) => this._defaultValue = defaultValue;

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified key-value pair collection and function to handle missing keys.
	/// </summary>
	/// <param name="keyValuePairs">The key-value pairs to initialize with.</param>
	/// <param name="onMissingKey">The function to call when a key is not found in the dictionary.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="onMissingKey"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public AutoDefaultDictionary(IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs, Func<TKey, TValue> onMissingKey) : base(keyValuePairs.ToDictionary(kvp => kvp.Key, kvp => kvp.Value)) => this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified default value and comparer.
	/// </summary>
	/// <param name="defaultValue">The default value to return when a key is not found in the dictionary.</param>
	/// <param name="comparer">The comparer to use when comparing keys.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(TValue defaultValue, IEqualityComparer<TKey> comparer) : base(comparer) => this._defaultValue = defaultValue;

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified function to handle missing keys and comparer.
	/// </summary>
	/// <param name="onMissingKey">The function to call when a key is not found in the dictionary.</param>
	/// <param name="comparer">The comparer to use when comparing keys.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="onMissingKey"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public AutoDefaultDictionary(Func<TKey, TValue> onMissingKey, IEqualityComparer<TKey> comparer) : base(comparer) => this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));

	/// <summary>
	/// Gets or sets the value associated with the specified key. If the key does not exist, the default value is returned and added to the dictionary.
	/// </summary>
	/// <param name="key">The key of the value to get or set.</param>
	/// <returns>The value associated with the specified key, or the default value if the key does not exist.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null.</exception>
	[Information(OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public new TValue this[TKey key]
	{
		get
		{
			if (!this.TryGetValue(key, out var value))
			{
				value = this._onMissingKey != null ? this._onMissingKey(key) : this._defaultValue;
				this.Add(key, value);
			}

			return value;
		}
		set => base[key] = value;
	}
}
