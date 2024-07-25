// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 08-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="ObservableHashSetSingletons.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// Provides singleton instances for commonly used <see cref="PropertyChangedEventArgs"/> and <see cref="PropertyChangingEventArgs"/> to avoid unnecessary allocations in ObservableHashSet{T}.
/// </summary>
internal static class ObservableHashSetSingletons
{

	/// <summary>
	/// Gets the <see cref="PropertyChangedEventArgs"/> instance for the "Count" property change.
	/// </summary>
	/// <value>The <see cref="PropertyChangedEventArgs"/> for the "Count" property change.</value>
	internal static PropertyChangedEventArgs CountPropertyChanged { get; } = new(propertyName: "Count");

	/// <summary>
	/// Gets the <see cref="PropertyChangingEventArgs"/> instance for the "Count" property changing.
	/// </summary>
	/// <value>The <see cref="PropertyChangingEventArgs"/> for the "Count" property changing.</value>
	internal static PropertyChangingEventArgs CountPropertyChanging { get; } = new(propertyName: "Count");

	/// <summary>
	/// Gets an empty array to represent no items, used to avoid unnecessary allocations.
	/// </summary>
	/// <value>An empty array representing no items.</value>
	internal static object[] NoItems { get; } = [];

}
