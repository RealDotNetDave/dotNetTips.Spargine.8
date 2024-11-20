// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-20-2024
// ***********************************************************************
// <copyright file="TypeExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for general types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Type"/> to enhance and simplify its usage.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static partial class TypeExtensions
{

	/// <summary>
	/// Gets all abstract methods of the specified type.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>A read-only collection of abstract methods.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information(nameof(GetAllAbstractMethods), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MethodInfo> GetAllAbstractMethods([NotNull] this Type type) => type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsAbstract).ToList().AsReadOnly();

	/// <summary>
	/// Gets all declared fields of the specified type.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>An enumerable collection of declared fields.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<FieldInfo> GetAllDeclaredFields([NotNull] this Type type)
	{
		type = type.ArgumentNotNull();

		for (var fieldIndex = 0; fieldIndex <
						type.GetFields(BindingFlags.Instance |
							BindingFlags.Static |
							BindingFlags.Public |
							BindingFlags.NonPublic |
							BindingFlags.DeclaredOnly)
							.LongLength; fieldIndex++)
		{
			yield return type.GetFields(BindingFlags.Instance |
				BindingFlags.Static |
				BindingFlags.Public |
				BindingFlags.NonPublic |
				BindingFlags.DeclaredOnly)[fieldIndex];
		}
	}

	/// <summary>
	/// Gets all declared methods of the specified type.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>An enumerable collection of declared methods.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information("Original Code .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<MethodInfo> GetAllDeclaredMethods([NotNull] this Type type)
	{
		type = type.ArgumentNotNull();

		for (var methodIndex = 0; methodIndex < type.GetMethods(BindingFlags.Instance |
				BindingFlags.Static |
				BindingFlags.Public |
				BindingFlags.NonPublic |
				BindingFlags.DeclaredOnly)
				.LongLength; methodIndex++)
		{
			yield return type.GetMethods(BindingFlags.Instance |
				BindingFlags.Static |
				BindingFlags.Public |
				BindingFlags.NonPublic |
				BindingFlags.DeclaredOnly)[methodIndex];
		}
	}

	/// <summary>
	/// Gets all fields of the specified type, including inherited fields.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>An enumerable collection of fields.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information(nameof(GetAllFields), UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<FieldInfo> GetAllFields([NotNull] this Type type)
	{
		var typeTypeInfo = type?.GetTypeInfo();

		while (typeTypeInfo != null)
		{
			//Using FrozenSet not much difference
			foreach (var fieldInfo in typeTypeInfo.DeclaredFields)
			{
				yield return fieldInfo;
			}

			typeTypeInfo = typeTypeInfo.BaseType?.GetTypeInfo();
		}
	}

	/// <summary>
	/// Gets all generic methods of the specified type.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>A read-only collection of generic methods.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MethodInfo> GetAllGenericMethods([NotNull] this Type type) => type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsGenericMethod).ToList().AsReadOnly();

	/// <summary>
	/// Gets all methods of the specified type, including inherited methods.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>An enumerable collection of methods.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<MethodInfo> GetAllMethods([NotNull] this Type type)
	{

		var typeInfo = type.ArgumentNotNull().GetTypeInfo();

		while (typeInfo is not null)
		{
			foreach (var methodInfo in typeInfo.DeclaredMethods)
			{
				yield return methodInfo;
			}

			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}
	}

	/// <summary>
	/// Gets all properties of the specified type, including inherited properties.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>An enumerable collection of properties.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<PropertyInfo> GetAllProperties([NotNull] this Type type)
	{
		var typeInfo = type.ArgumentNotNull().GetTypeInfo();

		while (typeInfo is not null)
		{
			foreach (var propertyInfo in typeInfo.DeclaredProperties)
			{
				yield return propertyInfo;
			}

			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}
	}

	/// <summary>
	/// Gets all public methods of the specified type.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>A read-only collection of public methods.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MethodInfo> GetAllPublicMethods([NotNull] this Type type) => type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsPublic).ToList().AsReadOnly();

	/// <summary>
	/// Gets all static methods of the specified type.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns>A read-only collection of static methods.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MethodInfo> GetAllStaticMethods([NotNull] this Type type) => type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsStatic).ToList().AsReadOnly();

	/// <summary>
	/// Gets a custom attribute of the specified type from the given type.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="type">The type to inspect.</param>
	/// <returns>The custom attribute of type <typeparamref name="TAttribute"/> if found; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[return: MaybeNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this Type type)
		where TAttribute : Attribute => type.ArgumentNotNull().GetTypeInfo().GetCustomAttributes(typeof(TAttribute), false).OfType<TAttribute>().FirstOrDefault();

	/// <summary>
	/// Gets a custom attribute of the specified type from the given method.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="methodInfo">The method to inspect.</param>
	/// <returns>The custom attribute of type <typeparamref name="TAttribute"/> if found; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the methodInfo is null.</exception>
	[return: MaybeNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this MethodInfo methodInfo)
		where TAttribute : Attribute => methodInfo.ArgumentNotNull().GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;

	/// <summary>
	/// Gets a custom attribute of the specified type from the given property.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="propertyInfo">The property to inspect.</param>
	/// <returns>The custom attribute of type <typeparamref name="TAttribute"/> if found; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the propertyInfo is null.</exception>
	[return: MaybeNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this PropertyInfo propertyInfo)
		where TAttribute : Attribute => propertyInfo.ArgumentNotNull().GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;

	/// <summary>
	/// Gets a custom attribute of the specified type from the given field.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="fieldInfo">The field to inspect.</param>
	/// <returns>The custom attribute of type <typeparamref name="TAttribute"/> if found; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the fieldInfo is null.</exception>
	[return: MaybeNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this FieldInfo fieldInfo)
		where TAttribute : Attribute => fieldInfo?.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;

	/// <summary>
	/// Gets the names of the implemented interfaces of the specified object.
	/// </summary>
	/// <param name="input">The object to inspect.</param>
	/// <param name="interfaceNames">Optional interface names to filter the results.</param>
	/// <returns>A read-only collection of implemented interface names.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the input is null.</exception>
	[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<string> GetImplementedInterfaces([NotNull] this object input, params string[] interfaceNames)
	{
		input = input.ArgumentNotNull();
		interfaceNames = interfaceNames.ArgumentNotNull();

		var interfaces = input.GetType().GetInterfaces().Select(p => p.Name);
		var foundInterfaces = new List<string>(interfaces.Intersect(interfaceNames));

		return foundInterfaces.AsReadOnly();
	}

	/// <summary>
	/// Gets all members of the specified type that have the specified attribute.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="type">The type whose members are to be searched.</param>
	/// <returns>A read-only collection of members that have the specified attribute.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the <paramref name="type"/> is null.</exception>
	[Information("https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MemberInfo> GetTypeMembersWithAttribute<TAttribute>([NotNull] this Type type)
		where TAttribute : Attribute
	{
		//CHANGED TO RETURN MEMBER INFO
		type = type.ArgumentNotNull();

		return TypeHelper.GetMembersWithAttribute<TAttribute>(type).ToReadOnlyCollection();
	}

	/// <summary>
	/// Determines the type of the specified object.
	/// </summary>
	/// <param name="obj">The object to inspect.</param>
	/// <returns>The type of the specified object.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the obj is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetTypeOfType), OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TypeOfType GetTypeOfType([NotNull] this object obj)
	{
		var objType = obj.GetType();

		if (objType.IsValueType)
		{
			return TypeOfType.Value;
		}

		if (objType.IsClass)
		{
			var member = objType.GetMethod("GetHashCode");
			if (member != null && member.GetCustomAttribute<CompilerGeneratedAttribute>() != null)
			{
				return TypeOfType.Record;
			}

			return TypeOfType.Reference;
		}

		return TypeOfType.Unknown;
	}

	/// <summary>
	/// Determines whether the specified method has an attribute of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the attribute to search for.</typeparam>
	/// <param name="methodInfo">The method to inspect.</param>
	/// <returns><c>true</c> if the method has the attribute; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the methodInfo is null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasAttribute<T>([NotNull] this MethodInfo methodInfo) where T : Attribute => methodInfo.ArgumentNotNull().GetAttribute<T>() is not null;

	/// <summary>
	/// Determines whether the specified type has the specified base class.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <param name="baseClass">The base class to check for.</param>
	/// <returns><c>true</c> if the type has the specified base class; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type or baseClass is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasBaseClass([NotNull] this Type type, [NotNull] Type baseClass)
	{
		if (type.CheckIsNotNull() is false && baseClass.CheckIsNotNull() is false)
		{
			return false;
		}

		while (type.CheckIsNotNull())
		{
			if (type.CheckEquals(baseClass))
			{
				return true;
			}
			else
			{
				type = type.BaseType;
			}
		}

		return false;
	}

	/// <summary>
	/// Determines whether the specified type has a parameterless constructor.
	/// </summary>
	/// <param name="type">The type to inspect.</param>
	/// <returns><c>true</c> if the type has a parameterless constructor; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information(nameof(HasParameterlessConstructor), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasParameterlessConstructor([NotNull] this Type type) => type.ArgumentNotNull().GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) is not null;

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> implements the <see cref="IEnumerable"/> interface.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns><c>true</c> if the <paramref name="type"/> implements <see cref="IEnumerable"/>; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information(nameof(HasParameterlessConstructor), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static bool IsEnumerable([NotNull] this Type type) => type.ArgumentNotNull().GetInterfaces().Any(t => t == typeof(IEnumerable));

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> is a nullable type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter can be null.</param>
	/// <returns><c>true</c> if the <paramref name="type"/> is a nullable type; otherwise, <c>false</c>.</returns>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNullable([AllowNull] this Type type) => Nullable.GetUnderlyingType(type) is not null;

	/// <summary>
	/// Determines whether the specified <see cref="PropertyInfo"/> represents a static property.
	/// </summary>
	/// <param name="property">The <see cref="PropertyInfo"/> to examine. This parameter cannot be null.</param>
	/// <returns><c>true</c> if the <paramref name="property"/> is static; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="property"/> is null.</exception>
	[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/31/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsStatic([NotNull] this PropertyInfo property) => (property.ArgumentNotNull().GetMethod ?? property.SetMethod).IsStatic;

	/// <summary>
	/// Returns the maximum of two comparable objects.
	/// </summary>
	/// <typeparam name="T">The type of the objects to compare. Must implement <see cref="IComparable"/>.</typeparam>
	/// <param name="obj1">The first object to compare. This parameter can be null.</param>
	/// <param name="obj2">The second object to compare. This parameter can be null.</param>
	/// <returns>The object that is greater, or <paramref name="obj1"/> if both are equal.</returns>
	[Information(nameof(Max), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T Max<T>([AllowNull] this T obj1, [AllowNull] T obj2) where T : IComparable => obj1.CompareTo(obj2) >= 0 ? obj1 : obj2;

}
