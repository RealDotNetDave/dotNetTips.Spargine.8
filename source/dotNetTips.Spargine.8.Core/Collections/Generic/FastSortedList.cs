// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="FastSortedList.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Custom Collection Class for `<T>`. Items within this collection are
// sorted only upon request.
// </summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// FastSortedList sorts the collection only when the collection is retrieved, which saves a lot on performance.
/// This class inherits from the <see cref="List{T}"/> class and overrides some of its methods to ensure that sorting is performed only when necessary.
/// </summary>
/// <typeparam name="T">The type of elements in the list.</typeparam>
/// <seealso cref="List{T}" />
[Serializable]
public class FastSortedList<T> : List<T>
{

	/// <summary>
	/// True or False if the list has been sorted.
	/// </summary>
	private bool _sorted;

	/// <summary>
	/// Initializes a new instance of the <see cref="FastSortedList{T}"/> class.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public FastSortedList()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="FastSortedList{T}"/> class.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new list.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> is null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public FastSortedList([NotNull] IEnumerable<T> collection) : base(collection)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="FastSortedList{T}"/> class that is empty and has the specified initial capacity.
	/// </summary>
	/// <param name="capacity">The number of elements that the new list, derived from <see cref="List{T}"/>, can initially store.</param>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public FastSortedList(int capacity) : base(capacity)
	{
	}

	/// <summary>
	/// Sorts the items in the collection if they have not been sorted yet.
	/// This method checks the <see cref="_sorted"/> flag before performing the sort operation to ensure that sorting is only done when necessary.
	/// </summary>
	[Information(Status = Status.Available)]
	private void SortCollection()
	{
		if (this._sorted is false)
		{
			this.Sort();

			this._sorted = true;
		}
	}

	/// <summary>
	/// Adds an object to the end of the <see cref="FastSortedList{T}"/>.
	/// </summary>
	/// <param name="item">The object to be added to the end of the <see cref="FastSortedList{T}"/>. The value can be <see langword="null" /> for reference types.</param>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public new void Add(T item)
	{
		item = item.ArgumentNotNull();

		base.Add(item);

		this._sorted = false;
	}

	/// <summary>
	/// Adds the items to the end of the <see cref="FastSortedList{T}"/>.
	/// </summary>
	/// <param name="items">The items to add to the end of the <see cref="FastSortedList{T}"/>. The collection itself cannot be null, but it can contain elements that are <see langword="null" /> for reference types.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null, indicating that the collection of items cannot be null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public new void AddRange(IEnumerable<T> items)
	{
		base.AddRange(items.ArgumentNotNull());

		this._sorted = false;
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="FastSortedList{T}"/>.
	/// This method ensures the collection is sorted before returning the enumerator, if it has not been sorted already.
	/// </summary>
	/// <returns>An enumerator for the <see cref="FastSortedList{T}"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public new Enumerator GetEnumerator()
	{
		this.SortCollection();
		return base.GetEnumerator();
	}

	/// <summary>
	/// Converts the <see cref="FastSortedList{T}"/> to an array.
	/// This method ensures the collection is sorted before converting, if it has not been sorted already.
	/// </summary>
	/// <returns>An array containing the elements of the <see cref="FastSortedList{T}"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public new T[] ToArray()
	{
		this.SortCollection();

		return base.ToArray();
	}

	/// <summary>
	/// Converts the <see cref="FastSortedList{T}"/> to an immutable list.
	/// This method ensures the collection is sorted before converting, if it has not been sorted already.
	/// </summary>
	/// <returns>An <see cref="IImmutableList{T}"/> containing the elements of the <see cref="FastSortedList{T}"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public IImmutableList<T> ToImmutableList()
	{
		this.SortCollection();

		return ImmutableList.CreateRange(this);
	}

	/// <summary>
	/// Returns a new collection based on the current <see cref="FastSortedList{T}"/>.
	/// This method ensures the collection is sorted before creating a new list, if it has not been sorted already.
	/// </summary>
	/// <returns>A new <see cref="List{T}"/> containing the elements of the <see cref="FastSortedList{T}"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public IList<T> ToList()
	{
		this.SortCollection();

		return new List<T>(base.ToArray());
	}

}
