// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 01-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2025
// ***********************************************************************
// <copyright file="AssemblyExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for Assembly.</summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Assembly" /> to enhance functionality related to type discovery and instantiation.
/// </summary>
/// <remarks>
/// The <see cref="AssemblyExtensions"/> class contains methods that extend the functionality of the <see cref="Assembly" /> class,
/// making it easier to perform tasks such as getting all types, interfaces, or instances of a specific type within an assembly,
/// and filtering them based on various criteria. These methods are designed to simplify common reflection-based tasks.
/// </remarks>
[Information(Documentation = "https://bit.ly/SpargineAssemblyExtensions", Status = Status.Available)]
public static class AssemblyExtensions
{

	/// <summary>
	/// Gets all interfaces defined in the specified assembly.
	/// </summary>
	/// <param name="assembly">The assembly to search for interfaces.</param>
	/// <returns>A read-only collection of <see cref="Type" /> objects representing the interfaces defined in the specified assembly.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assembly" /> is null.</exception>
	/// <remarks>This method extracts all interfaces from the types defined in the specified assembly, ensuring no duplicates are returned.
	/// It validates that the provided assembly is not null before proceeding with the extraction.</remarks>
	[Information(nameof(GetAllInterfaces), "David McCarter", "1/7/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> GetAllInterfaces([NotNull] this Assembly assembly)
	{
		assembly = assembly.ArgumentNotNull();

		var interfaces = new List<Type>();

		// USING SPAN CAUSES ISSUES. FrozenSet is slower. Recommendation from CoPilot is slower.
		var array = assembly.GetTypes();

		foreach (var arrayItem in array)
		{
			interfaces.AddRange(arrayItem.GetInterfaces());
		}

		return interfaces.ToReadOnlyCollection();
	}

	/// <summary>
	/// Gets all types in an <see cref="Assembly" />.
	/// This method filters out abstract types and returns a read-only collection of the remaining types.
	/// </summary>
	/// <param name="assembly">The assembly to search for types.</param>
	/// <returns>A read-only collection of <see cref="Type" /> objects representing the non-abstract types defined in the specified assembly.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assembly" /> is null.</exception>
	/// <remarks>This method is useful for scenarios where you need to work with concrete types defined in an assembly,
	/// such as when creating instances or performing reflection-based processing.</remarks>
	[Information(nameof(GetAllTypes), "David McCarter", "221/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> GetAllTypes([NotNull] this Assembly assembly)
	{
		assembly = assembly.ArgumentNotNull();

		var types = assembly.GetTypes();
		var result = new List<Type>(types.Length);

		foreach (var type in types)
		{
			if (!type.IsAbstract)
			{
				result.Add(type);
			}
		}

		return new ReadOnlyCollection<Type>(result);
	}

	/// <summary>
	/// Gets all instances of a specified type <typeparamref name="T" /> within the assembly.
	/// </summary>
	/// <typeparam name="T">The type of instances to find. This type must be a class.</typeparam>
	/// <param name="assembly">The assembly to search for instances of type <typeparamref name="T" />.</param>
	/// <returns>An enumerable of instances of the specified type <typeparamref name="T" />.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assembly" /> is null.</exception>
	/// <remarks>This method searches the assembly for types that are assignable to <typeparamref name="T" />,
	/// are not interfaces, are not abstract, and are not generic types. It then attempts to create an instance
	/// of each found type using the default constructor.</remarks>
	[Information(nameof(GetInstances), "David McCarter", "1/7/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> GetInstances<T>([NotNull] this Assembly assembly) where T : class
	{
		assembly = assembly.ArgumentNotNull();

		var types = assembly.GetTypes();
		var targetType = typeof(T);

		foreach (var type in types)
		{
			if (!type.IsInterface && !type.IsAbstract && !type.IsGenericType && targetType.IsAssignableFrom(type))
			{
				if (Activator.CreateInstance(type) is T instance)
				{
					yield return instance;
				}
			}
		}
	}

	/// <summary>
	/// Gets the types from the specified assembly that are assignable to the specified type and are not abstract.
	/// </summary>
	/// <param name="assembly">The assembly to search.</param>
	/// <param name="type">The type to match against assignable types in the assembly.</param>
	/// <returns>A read-only collection of types that are assignable to the specified type and are not abstract.</returns>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="assembly" /> or <paramref name="type" /> is null.</exception>
	/// <remarks>This method is useful for finding all concrete implementations or subclasses of a given type within an assembly.
	/// Original code from: oqtane.framework</remarks>
	[Information(nameof(GetTypes), "David McCarter", "1/7/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> GetTypes([NotNull] this Assembly assembly, [NotNull] Type type)
	{
		assembly = assembly.ArgumentNotNull();
		type = type.ArgumentNotNull();

		var types = assembly.GetTypes();
		var result = new List<Type>(types.Length);

		foreach (var t in types)
		{
			if (!t.IsAbstract && type.IsAssignableFrom(t))
			{
				result.Add(t);
			}
		}

		return new ReadOnlyCollection<Type>(result);

	}

}
