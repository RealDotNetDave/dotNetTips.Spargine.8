// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 08-17-2024
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
public static partial class TypeExtensions
{

	/// <summary>
	/// Gets all abstract methods of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>A read-only collection of <see cref="MethodInfo"/> objects representing all abstract methods of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	[Information(nameof(GetAllAbstractMethods), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MethodInfo> GetAllAbstractMethods([NotNull] this Type type) => type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsAbstract).ToList().AsReadOnly();

	/// <summary>
	/// Gets all declared fields of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> of <see cref="FieldInfo"/> representing all declared fields of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	/// <example>
	/// Output: _address1,_address2,_bornOn,_cellPhone,_city,_country,_email,_firstName,
	/// _homePhone,_id,_lastName,_postalCode,_state
	/// </example>
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
	/// Gets all declared methods of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>An <see cref="IEnumerable{MethodInfo}"/> representing all declared methods of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	/// <example>
	/// Output: get_Address1, set_Address1, get_Address2, set_Address2, get_BornOn, set_BornOn, get_CellPhone,
	/// set_CellPhone, get_City, set_City, get_Country, set_Country, get_Email, set_Email, get_FirstName, set_FirstName,
	/// get_HomePhone, set_HomePhone, get_Id,set_Id, get_LastName, set_LastName, get_PostalCode, set_PostalCode,
	/// get_State, set_State, op_GreaterThanOrEqual, op_GreaterThan, op_Equality, op_LessThanOrEqual, op_LessThan,
	/// op_Inequality, CompareTo, Equals, Equals, GetHashCode, ToString, CalculateAge"
	/// </example>
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
	/// Gets all fields of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>An <see cref="IEnumerable{FieldInfo}"/> representing all fields of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
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
	/// Gets all generic methods of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>A read-only collection of <see cref="MethodInfo"/> objects representing all generic methods of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MethodInfo> GetAllGenericMethods([NotNull] this Type type) => type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsGenericMethod).ToList().AsReadOnly();

	/// <summary>
	/// Gets all methods of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>An <see cref="IEnumerable{MethodInfo}"/> representing all methods of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
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
	/// Gets all properties of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>An <see cref="IEnumerable{PropertyInfo}"/> representing all properties of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
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
	/// Gets all public methods of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>A read-only collection of <see cref="MethodInfo"/> objects representing all public methods of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MethodInfo> GetAllPublicMethods([NotNull] this Type type) => type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsPublic).ToList().AsReadOnly();

	/// <summary>
	/// Gets all static methods of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>A read-only collection of <see cref="MethodInfo"/> objects representing all static methods of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ReadOnlyCollection<MethodInfo> GetAllStaticMethods([NotNull] this Type type) => type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsStatic).ToList().AsReadOnly();

	/// <summary>
	/// Retrieves a custom attribute of a specified type that is applied to a specified <see cref="Type"/>.
	/// </summary>
	/// <typeparam name="TAttribute">The type of attribute to search for.</typeparam>
	/// <param name="type">The <see cref="Type"/> object to which the attribute is applied. This parameter cannot be null.</param>
	/// <returns>A custom attribute that matches <typeparamref name="TAttribute"/>, or null if no such attribute is found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	[return: MaybeNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this Type type)
		where TAttribute : Attribute => type.ArgumentNotNull().GetTypeInfo().GetCustomAttributes(typeof(TAttribute), false).OfType<TAttribute>().FirstOrDefault();

	/// <summary>
	/// Retrieves a custom attribute of a specified type that is applied to a specified <see cref="MethodInfo"/>.
	/// </summary>
	/// <typeparam name="TAttribute">The type of attribute to search for.</typeparam>
	/// <param name="methodInfo">The <see cref="MethodInfo"/> object to which the attribute is applied. This parameter cannot be null.</param>
	/// <returns>A custom attribute that matches <typeparamref name="TAttribute"/>, or null if no such attribute is found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="methodInfo"/> is null.</exception>
	[return: MaybeNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this MethodInfo methodInfo)
		where TAttribute : Attribute => methodInfo.ArgumentNotNull().GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;

	/// <summary>
	/// Retrieves a custom attribute of a specified type that is applied to a specified <see cref="PropertyInfo"/>.
	/// </summary>
	/// <typeparam name="TAttribute">The type of attribute to search for.</typeparam>
	/// <param name="propertyInfo">The <see cref="PropertyInfo"/> object to which the attribute is applied. This parameter cannot be null.</param>
	/// <returns>A custom attribute that matches <typeparamref name="TAttribute"/>, or null if no such attribute is found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="propertyInfo"/> is null.</exception>
	[return: MaybeNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this PropertyInfo propertyInfo)
		where TAttribute : Attribute => propertyInfo.ArgumentNotNull().GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;

	/// <summary>
	/// Retrieves a custom attribute of a specified type that is applied to a specified <see cref="FieldInfo"/>.
	/// </summary>
	/// <typeparam name="TAttribute">The type of attribute to search for.</typeparam>
	/// <param name="fieldInfo">The <see cref="FieldInfo"/> object to which the attribute is applied. This parameter cannot be null.</param>
	/// <returns>A custom attribute that matches <typeparamref name="TAttribute"/>, or null if no such attribute is found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="fieldInfo"/> is null.</exception>
	[return: MaybeNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this FieldInfo fieldInfo)
		where TAttribute : Attribute => fieldInfo?.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;

	/// <summary>
	/// Retrieves the names of interfaces implemented by the input object, optionally filtered by specified interface names.
	/// </summary>
	/// <param name="input">The object to examine. This parameter cannot be null.</param>
	/// <param name="interfaceNames">An optional array of interface names to filter the results. If not specified, all implemented interface names are returned.</param>
	/// <returns>A <see cref="ReadOnlyCollection{String}"/> containing the names of the implemented interfaces.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	/// <example>
	/// This example shows how to use the <see cref="GetImplementedInterfaces"/> method.
	/// <code>
	/// var myObject = new MyClass();
	/// var implementedInterfaces = myObject.GetImplementedInterfaces("IInterface1", "IInterface2");
	/// foreach(var interfaceName in implementedInterfaces)
	/// {
	///     Console.WriteLine(interfaceName);
	/// }
	/// </code>
	/// </example>
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
	/// Retrieves detailed information about the members of the specified <see cref="Type"/> that are decorated with a specific attribute.
	/// </summary>
	/// <typeparam name="TAttribute">The type of attribute to search for, where <typeparamref name="TAttribute"/> must derive from <see cref="Attribute"/>.</typeparam>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns>An array of tuples containing the name, attribute instance, privacy status, static status, and parameter type of each member decorated with <typeparamref name="TAttribute"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	[Information("https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static (string Name, TAttribute Attribute, bool IsPrivate, bool IsStatic, Type ParameterType)[] GetTypeMembersWithAttribute<TAttribute>([NotNull] this Type type)
		where TAttribute : Attribute
	{
		type = type.ArgumentNotNull();

		var allFields = type.GetFields()
						.Select(f => (f.Name,
										Attribute: f.GetAttribute<TAttribute>(), f.IsPrivate, f.IsStatic,
										ParameterType: f.FieldType));

		var allProperties = type.GetProperties()
			.Select(p => (p.Name,
							Attribute: p.GetAttribute<TAttribute>(),
							IsPrivate: p.GetSetMethod() is null,
							IsStatic: p.GetSetMethod() is not null && p.GetSetMethod().IsStatic, p.PropertyType));

		var joined = allFields.Concat(allProperties).Where(member => member.Attribute is not null).ToArray();

		//FrozenSet is slower.
		foreach (var member in joined.Where(m => m.IsPrivate))
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException($"Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it", "Member");
		}

		return joined;
	}

	/// <summary>
	/// Determines the type characteristics of the specified object.
	/// </summary>
	/// <param name="obj">The object to examine. This parameter cannot be null.</param>
	/// <returns>A <see cref="TypeOfType"/> value representing the type characteristics of the input object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetTypeOfType), OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.Completed, Status = Status.NeedsDocumentation)]
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
	/// Determines whether the specified method is decorated with a specific attribute.
	/// </summary>
	/// <typeparam name="T">The type of attribute to search for, where <typeparamref name="T"/> must derive from <see cref="Attribute"/>.</typeparam>
	/// <param name="methodInfo">The method to examine. This parameter cannot be null.</param>
	/// <returns><c>true</c> if the attribute of type <typeparamref name="T"/> is applied to the method; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="methodInfo"/> is null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasAttribute<T>([NotNull] this MethodInfo methodInfo) where T : Attribute => methodInfo.ArgumentNotNull().GetAttribute<T>() is not null;

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> has the specified base class.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <param name="baseClass">The base class <see cref="Type"/> to check for. This parameter cannot be null.</param>
	/// <returns><c>true</c> if <paramref name="type"/> has <paramref name="baseClass"/> as a base class; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="type"/> or <paramref name="baseClass"/> is null.</exception>
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
	/// Determines whether the specified <see cref="Type"/> has a parameterless constructor.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns><c>true</c> if the <paramref name="type"/> has a parameterless constructor; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is null.</exception>
	[Information(nameof(HasParameterlessConstructor), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasParameterlessConstructor([NotNull] this Type type) => type.ArgumentNotNull().GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) is not null;

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> implements the <see cref="IEnumerable"/> interface.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter cannot be null.</param>
	/// <returns><c>true</c> if the <paramref name="type"/> implements <see cref="IEnumerable"/>; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasParameterlessConstructor), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static bool IsEnumerable([NotNull] this Type type) => type.ArgumentNotNull().GetInterfaces().Any(t => t == typeof(IEnumerable));

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> is nullable.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to examine. This parameter can be null.</param>
	/// <returns><c>true</c> if the <paramref name="type"/> is nullable; otherwise, <c>false</c>.</returns>
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
	/// Returns the maximum of two <see cref="IComparable"/> objects.
	/// </summary>
	/// <typeparam name="T">The type of the objects being compared, which must implement <see cref="IComparable"/>.</typeparam>
	/// <param name="obj1">The first object to compare. This parameter can be null.</param>
	/// <param name="obj2">The second object to compare. This parameter can be null.</param>
	/// <returns>The maximum of <paramref name="obj1"/> and <paramref name="obj2"/>.</returns>
	/// <remarks>Original code by: Jeremy Clark</remarks>
	[Information(nameof(Max), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T Max<T>([AllowNull] this T obj1, [AllowNull] T obj2) where T : IComparable => obj1.CompareTo(obj2) >= 0 ? obj1 : obj2;

}
