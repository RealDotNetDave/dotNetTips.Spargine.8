// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-17-2025
// ***********************************************************************
// <copyright file="ObservableList.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Custom Observable Collection Class for `<T>`. Includes the following
// events: CollectionChanged, PropertyChanged, PropertyChanging.
// </summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// Represents a dynamic data collection that provides notifications when items get added, removed, or when the whole list is refreshed.
/// This collection also implements the <see cref="ISet{T}"/> interface, providing set operations.
/// </summary>
/// <typeparam name="T">The type of elements in the list.</typeparam>
[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/31/2020", Status = Status.Available)]
public class ObservableList<T> : ISet<T>, IReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged, INotifyPropertyChanging
{
	/// <summary>
	/// The underlying <see cref="HashSet{T}"/> used to store elements of the set.
	/// </summary>
	private HashSet<T> _set;

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}"/> class
	/// that is empty and uses the default equality comparer for the set type.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public ObservableList() : this(EqualityComparer<T>.Default)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}"/> class
	/// that is empty and uses the specified equality comparer for the set type.
	/// </summary>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when
	/// comparing values in the set, or null to use the default <see cref="EqualityComparer{T}"/>
	/// implementation for the set type.</param>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public ObservableList(IEqualityComparer<T> comparer) => this._set = new HashSet<T>(comparer);

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}"/> class
	/// that uses the default <see cref="EqualityComparer{T}"/> for the set type, contains elements copied
	/// from the specified collection, and has sufficient capacity to accommodate the
	/// number of elements copied.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new set.</param>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public ObservableList(IEnumerable<T> collection) : this(collection, EqualityComparer<T>.Default)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}"/> class
	/// that uses the specified equality comparer for the set type, contains elements
	/// copied from the specified collection, and has sufficient capacity to accommodate
	/// the number of elements copied.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new set.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when
	/// comparing values in the set, or null to use the default <see cref="IEqualityComparer{T}"/>
	/// implementation for the set type.</param>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public ObservableList(IEnumerable<T> collection, IEqualityComparer<T> comparer) => this._set =
		new HashSet<T>(collection, comparer);

	/// <summary>
	/// Occurs when the contents of the collection changes.
	/// </summary>
	/// <remarks>
	/// This event can indicate all changes to the collection including adding, removing, and replacing items.
	/// </remarks>
	/// <seealso cref="NotifyCollectionChangedEventArgs"/>
	public event NotifyCollectionChangedEventHandler CollectionChanged;

	/// <summary>
	/// Occurs when a property value changes.
	/// </summary>
	/// <remarks>
	/// The event can indicate all changes to a property including updates to its value.
	/// </remarks>
	/// <seealso cref="PropertyChangedEventArgs"/>
	public event PropertyChangedEventHandler PropertyChanged;

	/// <summary>
	/// Occurs when a property of this <see cref="ObservableList{T}"/> is changing.
	/// </summary>
	public event PropertyChangingEventHandler PropertyChanging;

	/// <summary>
	/// Adds an item to the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <param name="item">The object to add to the collection.</param>
	void ICollection<T>.Add(T item) => this.Add(item);

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	/// <remarks>
	/// This method is a type-safe wrapper for the <see cref="IEnumerable.GetEnumerator"/> method.
	/// </remarks>
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	/// <remarks>
	/// This method is a type-safe wrapper for the <see cref="IEnumerable{T}.GetEnumerator"/> method.
	/// </remarks>
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Called when the collection changes.
	/// </summary>
	/// <param name="action">The action that caused the collection change.</param>
	/// <param name="item">The item involved in the change.</param>
	/// <remarks>
	/// This method raises the <see cref="CollectionChanged"/> event with the specified action and item.
	/// </remarks>
	private void OnCollectionChanged(NotifyCollectionChangedAction action, T item) => this.OnCollectionChanged(
		new NotifyCollectionChangedEventArgs(action, item));

	/// <summary>
	/// Called when the collection changes, specifically when items are replaced.
	/// </summary>
	/// <param name="newItems">The new items that are replacing the old items in the collection.</param>
	/// <param name="oldItems">The old items that are being replaced by the new items in the collection.</param>
	/// <remarks>
	/// This method raises the <see cref="CollectionChanged"/> event with <see cref="NotifyCollectionChangedAction.Replace"/> action,
	/// providing the old items and new items involved in the change.
	/// </remarks>
	private void OnCollectionChanged(IList newItems, IList oldItems) => this.OnCollectionChanged(
		new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItems, oldItems));

	/// <summary>
	/// Called when the "Count" property value has changed.
	/// </summary>
	/// <remarks>
	/// This method raises the <see cref="PropertyChanged"/> event indicating the "Count" property has changed.
	/// </remarks>
	private void OnCountPropertyChanged() => this.OnPropertyChanged(ObservableHashSetSingletons.CountPropertyChanged);

	/// <summary>
	/// Called before the "Count" property value changes.
	/// </summary>
	/// <remarks>
	/// This method raises the <see cref="PropertyChanging"/> event indicating the "Count" property is changing.
	/// </remarks>
	private void OnCountPropertyChanging() => this.OnPropertyChanging(ObservableHashSetSingletons.CountPropertyChanging);

	/// <summary>
	/// Raises the <see cref="CollectionChanged"/> event.
	/// </summary>
	/// <param name="e">The event data.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="e"/> is null.</exception>
	/// <remarks>
	/// This method is called to notify listeners that the collection has changed. The change details are encapsulated in the <paramref name="e"/> parameter.
	/// </remarks>
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) => this.CollectionChanged?.Invoke(
		this,
		e);

	/// <summary>
	/// Raises the <see cref="PropertyChanged"/> event.
	/// </summary>
	/// <param name="e">The property changed event data.</param>
	/// <remarks>
	/// This method is called to notify listeners that a property value has changed. The property that changed is specified in the <paramref name="e"/> parameter.
	/// </remarks>
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e) => this.PropertyChanged?.Invoke(this, e);

	/// <summary>
	/// Raises the <see cref="PropertyChanging"/> event.
	/// </summary>
	/// <param name="e">The <see cref="PropertyChangingEventArgs"/> instance containing the event data.</param>
	/// <remarks>
	/// This method is called to notify listeners that a property of the <see cref="ObservableList{T}"/> is about to change.
	/// </remarks>
	protected virtual void OnPropertyChanging(PropertyChangingEventArgs e) => this.PropertyChanging?.Invoke(this, e);

	/// <summary>
	/// Adds the specified element to the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <param name="item">The element to add to the set.</param>
	/// <returns><see langword="true"/> if the element is added to the <see cref="ObservableList{T}"/>; <see langword="false"/> if the element is already present.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool Add(T item)
	{
		// TODO: CHANGE TO VOID AT THE END OF 2025 TO WORK LIKE ADD

		if (item is null)
		{
			return false;
		}

		if (this._set.Contains(item))
		{
			return false;
		}

		this.OnCountPropertyChanging();

		_ = this._set.Add(item);

		this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);

		this.OnCountPropertyChanged();

		return true;
	}

	/// <summary>
	/// Removes all elements from the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <remarks>
	/// This method raises the <see cref="CollectionChanged"/> event with <see cref="NotifyCollectionChangedAction.Reset"/> action
	/// to indicate all items have been removed. It also raises the <see cref="PropertyChanging"/> and <see cref="PropertyChanged"/>
	/// events for the "Count" property before and after the collection is cleared, respectively.
	/// </remarks>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void Clear()
	{
		if (this._set.FastCount() == 0)
		{
			return;
		}

		this.OnCountPropertyChanging();

		var removed = this.ToList();

		this._set.Clear();

		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Determines whether the <see cref="ObservableList{T}"/> contains the specified element.
	/// </summary>
	/// <param name="item">The element to locate in the <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="ObservableList{T}"/> contains the specified element; otherwise, <see langword="false"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool Contains([NotNullWhen(true)] T item)
	{
		if (item is null)
		{
			return false;
		}

		return this._set.Contains(item);
	}

	/// <summary>
	/// Copies the elements of the <see cref="ObservableList{T}"/> to an array.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the <see cref="ObservableList{T}"/>. The array must have zero-based indexing.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void CopyTo([NotNull] T[] array) => this._set.CopyTo(array.ArgumentNotNull());

	/// <summary>
	/// Copies the elements of the <see cref="ObservableList{T}"/> to an array, starting at the specified array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the <see cref="ObservableList{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void CopyTo([NotNull] T[] array, int arrayIndex) => this._set
		.CopyTo(array.ArgumentNotNull(), arrayIndex);

	/// <summary>
	/// Copies the specified number of elements of the <see cref="ObservableList{T}"/> to an array, starting at the specified array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the <see cref="ObservableList{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	/// <param name="count">The number of elements to copy to <paramref name="array"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void CopyTo([NotNull] T[] array, int arrayIndex, int count) => this._set
		.CopyTo(array.ArgumentNotNull(), arrayIndex, count);

	/// <summary>
	/// Removes all elements in the specified collection from the current set.
	/// </summary>
	/// <param name="other">The collection of items to remove from the current set. Elements in this collection that are not found in the current set are ignored.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	/// <remarks>
	/// This method determines what elements are in the specified collection but not in the current set. It then removes those elements from the current set.
	/// <para>
	/// This method uses the <see cref="HashSet{T}.ExceptWith"/> method of the underlying <see cref="HashSet{T}"/> to perform this operation.
	/// </para>
	/// </remarks>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void ExceptWith([NotNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.ExceptWith(other);

		if (copy.FastCount() == this._set.FastCount())
		{
			return;
		}

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	public virtual HashSet<T>.Enumerator GetEnumerator() => this._set.GetEnumerator();

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void IntersectWith([NotNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.IntersectWith(other);

		if (copy.FastCount() == this._set.FastCount())
		{
			return;
		}

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Determines whether the current <see cref="ObservableList{T}"/> is a proper subset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the current <see cref="ObservableList{T}"/> is a proper subset of <paramref name="other"/>; otherwise, <see langword="false"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool IsProperSubsetOf([NotNullWhen(true)] IEnumerable<T> other) => this._set
		.IsProperSubsetOf(other.ArgumentNotNull());

	/// <summary>
	/// Determines whether the <see cref="ObservableList{T}"/> is a proper superset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="ObservableList{T}"/> is a proper superset of <paramref name="other"/>; otherwise, <see langword="false"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool IsProperSupersetOf([NotNullWhen(true)] IEnumerable<T> other) => this._set
		.IsProperSupersetOf(other.ArgumentNotNull());

	/// <summary>
	/// Determines whether the <see cref="ObservableList{T}"/> is a subset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="ObservableList{T}"/> is a subset of <paramref name="other"/>; otherwise, <see langword="false"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool IsSubsetOf([NotNullWhen(true)] IEnumerable<T> other) => this._set
		.IsSubsetOf(other.ArgumentNotNull());

	/// <summary>
	/// Determines whether the <see cref="ObservableList{T}"/> is a superset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="ObservableList{T}"/> is a superset of <paramref name="other"/>; otherwise, <see langword="false"/>.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool IsSupersetOf([NotNullWhen(true)] IEnumerable<T> other) => this._set
		.IsSupersetOf(other.ArgumentNotNull());

	/// <summary>
	/// Determines whether the current <see cref="ObservableList{T}"/> overlaps with the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the current set and the specified collection share at least one common element; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool Overlaps([NotNull] IEnumerable<T> other) => this._set.Overlaps(other.ArgumentNotNull());

	/// <summary>
	/// Removes the specified item from the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <param name="item">The item to remove.</param>
	/// <returns><see langword="true"/> if item was successfully removed from the <see cref="ObservableList{T}"/>; otherwise, <see langword="false"/>. This method also returns <see langword="false"/> if item is not found in the original <see cref="ObservableList{T}"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is <see langword="null"/>.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool Remove([NotNull] T item)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		if (!this._set.Contains(item))
		{
			return false;
		}

		this.OnCountPropertyChanging();

		_ = this._set.Remove(item);

		this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);

		this.OnCountPropertyChanged();

		return true;
	}

	/// <summary>
	/// Removes all elements that match the conditions defined by the specified predicate.
	/// </summary>
	/// <param name="match">The <see cref="Predicate{T}"/> delegate that defines the conditions of the elements to remove.</param>
	/// <returns>The number of elements removed from the <see cref="ObservableList{T}"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="match"/> is <see langword="null"/>.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual int RemoveWhere([NotNull] Predicate<T> match)
	{
		match = match.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		var removedCount = copy.RemoveWhere(match);

		if (removedCount == 0)
		{
			return 0;
		}

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

		this.OnCountPropertyChanged();

		return removedCount;
	}

	/// <summary>
	/// Determines whether the current <see cref="ObservableList{T}"/> contains the same elements as the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the current <see cref="ObservableList{T}"/> set is equal to the specified collection; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool SetEquals([NotNull] IEnumerable<T> other) => this._set.SetEquals(other.ArgumentNotNull());

	/// <summary>
	/// Modifies the current <see cref="ObservableList{T}"/> to contain only elements that are present either in it or in the specified collection, but not both.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>. This collection must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void SymmetricExceptWith([NotNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.SymmetricExceptWith(other);

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();
		var added = copy.Where(i => !this._set.Contains(i)).ToList();

		if (removed.FastCount() == 0 && added.FastCount() == 0)
		{
			return;
		}

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(added, removed);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Forces the <see cref="ObservableList{T}"/> to reduce its capacity to match its current count, minimizing memory overhead.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void TrimExcess() => this._set.TrimExcess();

	/// <summary>
	/// Modifies the current <see cref="ObservableList{T}"/> to contain all elements that are present in the <see cref="ObservableList{T}"/> itself, the specified collection, or both.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>. This collection must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual void UnionWith([NotNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.UnionWith(other);

		if (copy.FastCount() == this._set.FastCount())
		{
			return;
		}

		var added = copy.Where(i => !this._set.Contains(i)).ToList();

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Gets the <see cref="IEqualityComparer{T}"/> object that is used to determine equality for the values in the set.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual IEqualityComparer<T> Comparer => this._set.Comparer;

	/// <summary>
	/// Gets the number of elements contained in the <see cref="ObservableList{T}"/>.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual int Count => this._set.Count;

	/// <summary>
	/// Gets a value indicating whether the <see cref="ObservableList{T}"/> is read-only.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public virtual bool IsReadOnly => ((ICollection<T>)this._set).IsReadOnly;
}
