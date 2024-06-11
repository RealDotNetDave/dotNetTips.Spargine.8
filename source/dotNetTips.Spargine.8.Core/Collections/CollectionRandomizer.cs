// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-06-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2024
// ***********************************************************************
// <copyright file="CollectionRandomizer.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Designed to shuffle a collection either once or endlessly. Enables
// users to retrieve items using the GetNext() method.
// </summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Internal;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Collections;

/// <summary>
/// Class CollectionRandomizer.
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
/// <param name="collection">The collection.</param>
/// <param name="repeat">If set to <c>true</c> and when using GetNext() the collection will repeat over and over and each time re-
/// shuffled. Be careful of getting into an endless loop, it could cause your app to crash.</param>
/// <remarks>The CollectionRandomizer is designed to shuffle a collection and allow retrieving items by using GetNext().</remarks>
[Information(nameof(CollectionRandomizer<T>), author: "David McCarter and Kristine Tran", createdOn: "8/26/2020", Status = Status.Available)]
[method: Information(nameof(CollectionRandomizer<T>), "David McCarter", "4/21/2021", Status = Status.Available, UnitTestCoverage = 0)]
public sealed class CollectionRandomizer<T>([NotNull] IEnumerable<T> collection, bool repeat = false)
{

	/// <summary>
	/// The collection
	/// </summary>
	private ImmutableArray<T> _collection = collection.ToImmutableArray();

	/// <summary>
	/// The collection enumerator
	/// </summary>
	private ImmutableArray<T>.Enumerator _collectionEnumerator;

	/// <summary>
	/// The initialized
	/// </summary>
	private bool _initialized;

	/// <summary>
	/// The thread lock
	/// </summary>
	private readonly object _threadLock = new();

	/// <summary>
	/// Initializes this instance.
	/// </summary>
	/// <exception cref="InvalidValueException{ImmutableArray}">Underlying collection is null.</exception>
	private void Init()
	{
		//Ignore if initialized unless repeat is true.
		if ((this._initialized && this.HasRemainingItems) ||
			(this._initialized && this.HasRemainingItems && repeat is false))
		{
			return;
		}

		//Validate Collection
		if (this._collection.Length is 0)
		{
			ExceptionThrower.ThrowInvalidValueException(Resources.UnderlyingCollectionIsNull, this._collection);
		}

		//Shuffle Collection
		this._collection = this._collection.Shuffle().ToImmutableArray();

		//Setup enumerator
		this._collectionEnumerator = this._collection.GetEnumerator();

		//Move to first item
		this.HasRemainingItems = this._collectionEnumerator.MoveNext();

		this._initialized = true;
	}

	/// <summary>
	/// Gets the next item in the collection.
	/// </summary>
	/// <returns>T.</returns>
	[Information(nameof(GetNext), "David McCarter", "4/21/2021", Status = Status.Available, UnitTestCoverage = 0)]
	public T GetNext()
	{
		lock (this._threadLock)
		{
			this.Init();

			var collectionItem = this._collectionEnumerator.Current;

			this.HasRemainingItems = this._collectionEnumerator.MoveNext();

			return collectionItem;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this instance has remaining items.
	/// </summary>
	/// <value><c>true</c> if this instance has remaining items; otherwise, <c>false</c>. This value will be <c>false</c>
	/// until the first time GetNext() is called and the shuffle is initialized.</value>
	[Information(nameof(HasRemainingItems), "David McCarter", "4/21/2021", Status = Status.Available, UnitTestCoverage = 0)]
	public bool HasRemainingItems { get; private set; }

}
