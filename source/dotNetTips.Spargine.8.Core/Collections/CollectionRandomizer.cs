// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-06-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-25-2025
// ***********************************************************************
// <copyright file="CollectionRandomizer.cs" company="McCarter Consulting">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Collections;

/// <summary>
/// Initializes a new instance of the <see cref="CollectionRandomizer{T}"/> class.
/// </summary>
/// <param name="collection">The collection to randomize. This collection must not be null.</param>
/// <param name="repeat">if set to <c>true</c>, the collection will repeat over and over, each time reshuffled. Be cautious of endless loops, which could crash your application.</param>
/// <remarks>
/// The <see cref="CollectionRandomizer{T}"/> is designed to shuffle a collection and allow retrieving items sequentially with the option to repeat and reshuffle.
/// </remarks>
[Information(nameof(CollectionRandomizer<T>), author: "David McCarter and Kristine Tran", createdOn: "8/26/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineCollectionRandomizer")]
public sealed class CollectionRandomizer<T>([NotNull] in IEnumerable<T> collection, bool repeat = false)
{

	/// <summary>
	/// The collection to be randomized. This collection is converted to an <see cref="ImmutableArray{T}"/> to ensure thread-safety and immutability.
	/// </summary>
	private ImmutableArray<T> _collection = [.. collection];

	/// <summary>
	/// The enumerator for the randomized collection. This enumerator is used internally to iterate through the <see cref="ImmutableArray{T}"/> of randomized items.
	/// </summary>
	private ImmutableArray<T>.Enumerator _collectionEnumerator;

	/// <summary>
	/// Backing field for the <see cref="HasRemainingItems"/> property.
	/// Indicates whether there are remaining items to be retrieved from the collection.
	/// </summary>
	private bool _hasRemainingItems;

	/// <summary>
	/// Indicates whether the <see cref="CollectionRandomizer{T}"/> has been initialized. Initialization occurs upon the first call to <see cref="GetNext"/>. 
	/// If <c>true</c>, the collection has been shuffled and is ready for item retrieval.
	/// </summary>
	private bool _initialized;

	/// <summary>
	/// The thread lock used to ensure thread safety when accessing the collection.
	/// </summary>
	private readonly object _threadLock = new();

	/// <summary>
	/// Initializes this instance of <see cref="CollectionRandomizer{T}"/>.
	/// </summary>
	/// <remarks>
	/// This method prepares the collection for item retrieval by shuffling it. If the <see cref="CollectionRandomizer{T}"/> is set to repeat,
	/// the collection will be reshuffled each time it is exhausted. This method is called automatically before the first item retrieval.
	/// </remarks>
	/// <exception cref="InvalidValueException{ImmutableArray}">Thrown if the underlying collection is null or empty.</exception>
	private void Init()
	{
		//Ignore if initialized unless repeat is true.
		if (!((!this._initialized || !this.HasRemainingItems) &&
			(!this._initialized || !this.HasRemainingItems || repeat is true)))
		{
			return;
		}

		//Validate Collection
		if (this._collection.Length is 0)
		{
			ExceptionThrower.ThrowInvalidValueException(Resources.UnderlyingCollectionIsNull, this._collection);
		}

		//Shuffle Collection
		this._collection = [.. this._collection.Shuffle()];

		//Setup enumerator
		this._collectionEnumerator = this._collection.GetEnumerator();

		//Move to first item
		this.HasRemainingItems = this._collectionEnumerator.MoveNext();

		this._initialized = true;
	}

	/// <summary>
	/// Gets the next item in the collection. If the collection is set to repeat, it will reshuffle once all items have been retrieved.
	/// </summary>
	/// <returns>The next item of type <typeparamref name="T"/> from the collection.</returns>
	/// <exception cref="InvalidOperationException">Thrown if the collection is empty or all items have been retrieved and the collection is not set to repeat.</exception>
	/// <seealso cref="Init"/>
	[Information(nameof(GetNext), "David McCarter", "4/21/2021", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public T GetNext()
	{
		lock (this._threadLock)
		{
			if (!this._initialized || (!this.HasRemainingItems && repeat))
			{
				this.Init();
			}
			else if (!this.HasRemainingItems)
			{
				ExceptionThrower.ThrowInvalidOperationException(Resources.NoMoreItemsToRetrieveAndTheCollectionIsNot);
			}

			var collectionItem = this._collectionEnumerator.Current;

			this.HasRemainingItems = this._collectionEnumerator.MoveNext();

			return collectionItem;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this instance has remaining items to be retrieved by <see cref="GetNext"/>.
	/// </summary>
	/// <value>
	/// <c>true</c> if this instance has remaining items; otherwise, <c>false</c>. This value will be <c>false</c>
	/// until the first time <see cref="GetNext"/> is called and the collection is shuffled.
	/// </value>
	[Information(nameof(HasRemainingItems), "David McCarter", "4/21/2021", Status = Status.Available, UnitTestStatus = UnitTestStatus.None)]
	public bool HasRemainingItems
	{
		get
		{
			lock (this._threadLock)
			{
				return this._hasRemainingItems;
			}
		}
		private set
		{
			lock (this._threadLock)
			{
				this._hasRemainingItems = value;
			}
		}
	}

}
