// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-28-2025
// ***********************************************************************
// <copyright file="TypeHelper.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Provides valuable methods for type management, encompassing tasks
// such as loading derived types, creating new types, discovering derived
// types, converting JSON to objects, transforming JSON files into
// objects, generating instance hash codes, and listing built-in types.
// These functionalities empower developers to handle types effectively
// in diverse scenarios.
// </summary>
// ***********************************************************************

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a collection of utility methods for type inspection and manipulation, including functionality
/// for creating instances, comparing objects, finding derived types, and working with JSON and assembly data.
/// </summary>
/// <remarks>
/// This class includes methods for various operations such as creating instances of types, checking if an object
/// equals an instance, finding derived types within assemblies, directories, or the current AppDomain, and
/// converting objects to and from JSON. It also provides methods to get default values, hash codes, property values,
/// and display names for types, as well as determining if a type is a built-in .NET type or if an assembly is a .NET assembly.
/// </remarks>
[Information(Status = Status.NeedsDocumentation, Documentation = "ADD URL")]
public static partial class TypeHelper
{

	/// <summary>
	/// A read-only collection of built-in .NET types. This collection is used internally to check if a type is a built-in .NET type.
	/// </summary>
	private static HashSet<Type> _builtInTypes;

	/// <summary>
	/// A static field to cache the built-in .NET types.
	/// </summary>
	private static Dictionary<Type, string> _cachedBuiltInTypes;

	/// <summary>
	/// Provides a pool of reusable <see cref="StringBuilder"/> instances to reduce allocations and improve performance.
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Computes and initializes the list of built-in .NET types that are considered primitive for the purposes of this utility class.
	/// This method populates the <see cref="_builtInTypes"/> collection with types that are commonly used and recognized as fundamental types within .NET applications.
	/// </summary>
	private static void ComputeBuiltInTypes()
	{
		// Use a HashSet to store the built-in types for faster lookups
		var builtInTypes = new HashSet<Type>();

		// Get all the assemblies loaded in the current app domain
		var assemblies = AppDomain.CurrentDomain.GetAssemblies();

		// Loop through each assembly
		foreach (var assembly in assemblies)
		{
			// Get the types defined in the assembly
			Type[] types;
			try
			{
				types = assembly.GetTypes();
			}
			catch (ReflectionTypeLoadException ex)
			{
				types = [.. ex.Types.Where(t => t != null)];
			}

			// Loop through each type
			foreach (var type in types)
			{
				// Check if the type is a built-in type
				if (IsBuiltinType(type))
				{
					// Add the type to the HashSet
					_ = builtInTypes.Add(type);
				}
			}
		}

		// Convert the HashSet to a read-only collection
		_builtInTypes = builtInTypes;
	}


	/// <summary>
	/// Determines whether the provided stream represents a .NET assembly.
	/// </summary>
	/// <param name="stream">The stream to analyze.</param>
	/// <returns><c>true</c> if the stream represents a .NET assembly; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsDotNetAssembly), author: "David McCarter", createdOn: "5/20/2024", OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	private static bool IsDotNetAssembly(in Stream stream)
	{
		try
		{
			using var peReader = new PEReader(stream);

			if (!peReader.HasMetadata)
			{
				return false;
			}

			// If peReader.PEHeaders doesn't throw, it is a valid PEImage
			return peReader.PEHeaders.CorHeader != null && peReader.GetMetadataReader().IsAssembly;
		}
		catch (BadImageFormatException)
		{
			return false;
		}
		catch (IOException ex)
		{
			Trace.WriteLine(ex);
			return false;
		}
		catch (UnauthorizedAccessException ex)
		{
			Trace.WriteLine(ex);
			return false;
		}
	}

	/// <summary>
	/// Loads types derived from a specified base type from a collection of TypeInfo objects.
	/// </summary>
	/// <param name="types">The collection of TypeInfo objects to search through.</param>
	/// <param name="baseType">The base type to find derived types of.</param>
	/// <param name="classOnly">If true, only class types are considered; otherwise, interfaces are also considered.</param>
	/// <returns>An enumerable collection of types that are derived from the specified base type.</returns>
	[Information(OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	private static IEnumerable<Type> LoadDerivedTypes(IEnumerable<TypeInfo> types, Type baseType, bool classOnly)
	{
		foreach (var type in types)
		{
			if (classOnly && !type.IsClass)
			{
				continue;
			}

			if (baseType.IsInterface)
			{
				if (type.ImplementedInterfaces.Contains(baseType))
				{
					yield return type.AsType();
				}
			}
			else if (type.IsSubclassOf(baseType))
			{
				yield return type.AsType();
			}
		}
	}

	/// <summary>
	/// Processes a given type to construct its display name, handling generic types and applying specified display options.
	/// </summary>
	/// <param name="builder">The <see cref="StringBuilder"/> instance used to build the display name.</param>
	/// <param name="type">The type to process for display.</param>
	/// <param name="options">Options that specify how the display name should be formatted.</param>
	[Information(OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	private static void ProcessType(in StringBuilder builder, in Type type, in DisplayNameOptions options)
	{
		if (type.IsGenericType)
		{
			var genericArguments = type.GetGenericArguments();
			ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);
		}
		else if (type.IsArray)
		{
			ProcessType(builder, type.GetElementType(), options);
			_ = builder.Append("[]");
		}
		else if (type.IsGenericParameter)
		{
			if (options.IncludeGenericParameterNames)
			{
				_ = builder.Append(type.Name);
			}
		}
		else
		{
			var name = options.FullName ? type.FullName : type.Name;
			_ = builder.Append(name);

			if (options.NestedTypeDelimiter != ControlChars.Plus)
			{
				_ = builder.Replace(ControlChars.Plus, options.NestedTypeDelimiter, builder.Length - name.Length, name.Length);
			}
		}
	}

	/// <summary>
	/// Dynamically lists all built-in .NET types.
	/// </summary>
	/// <returns>A dictionary of built-in .NET types and their string representations.</returns>
	/// <remarks>
	/// This method gathers a comprehensive list of built-in .NET types, including primitive types,
	/// common types, and types from the System namespace. The results are cached to improve performance
	/// on subsequent calls.
	/// </remarks>
	/// <example>
	/// <code>
	/// var builtInTypes = TypeHelper.BuiltInTypeNames();
	/// foreach (var type in builtInTypes)
	/// {
	///     Console.WriteLine($"{type.Key}: {type.Value}");
	/// }
	/// </code>
	/// </example>
	[Information(nameof(BuiltInTypeNames), author: "David McCarter", createdOn: "11/6/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/Spargine8", Status = Status.Available)]
	public static Dictionary<Type, string> BuiltInTypeNames()
	{
		// Check if the cache is already populated
		if (_cachedBuiltInTypes != null)
		{
			return _cachedBuiltInTypes;
		}

		var builtInTypes = new Dictionary<Type, string>();

		// Add primitive types
		var primitiveTypes = new[]
		{
				typeof(bool), typeof(byte), typeof(char), typeof(decimal), typeof(double),
				typeof(float), typeof(int), typeof(long), typeof(sbyte), typeof(short),
				typeof(uint), typeof(ulong), typeof(ushort)
			};

		var options = new DisplayNameOptions(fullName: false, includeGenericParameterNames: true, includeGenericParameters: true);

		foreach (var type in primitiveTypes)
		{
			builtInTypes[type] = GetTypeDisplayName(type, options);
		}

		// Add other common built-in types
		var commonTypes = new[]
		{
				typeof(string), typeof(object), typeof(DateTime), typeof(DateTimeOffset),
				typeof(TimeSpan), typeof(Guid), typeof(Uri), typeof(BigInteger), typeof(Half),
				typeof(IntPtr), typeof(UIntPtr), typeof(DateTimeKind), typeof(Nullable<>),
				typeof(ValueTuple), typeof(Tuple), typeof(Span<>), typeof(ReadOnlySpan<>),
				typeof(Memory<>), typeof(ReadOnlyMemory<>), typeof(ArraySegment<>),
				typeof(KeyValuePair<,>), typeof(List<>), typeof(Dictionary<,>), typeof(HashSet<>),
				typeof(Queue<>), typeof(Stack<>), typeof(LinkedList<>), typeof(SortedList<,>),
				typeof(SortedDictionary<,>), typeof(SortedSet<>), typeof(ConcurrentDictionary<,>),
				typeof(ConcurrentQueue<>), typeof(ConcurrentStack<>), typeof(BlockingCollection<>),
				typeof(ObservableCollection<>), typeof(ReadOnlyCollection<>), typeof(ReadOnlyDictionary<,>),
				typeof(ReadOnlyObservableCollection<>), typeof(ImmutableArray<>), typeof(ImmutableList<>),
				typeof(ImmutableDictionary<,>), typeof(ImmutableHashSet<>), typeof(ImmutableQueue<>),
				typeof(ImmutableStack<>), typeof(ImmutableSortedDictionary<,>), typeof(ImmutableSortedSet<>)
			};

		foreach (var type in commonTypes)
		{
			builtInTypes[type] = GetTypeDisplayName(type, includeGenericParameterNames: true, includeGenericParameters: true);
		}

		// Add types from the System namespace
		var systemTypes = Assembly.GetAssembly(typeof(int)).GetTypes()
			.Where(t => string.Equals(t.Namespace, "System", StringComparison.Ordinal) && t.IsPublic && !t.IsGenericType)
			.ToList();

		foreach (var type in systemTypes)
		{
			builtInTypes[type] = GetTypeDisplayName(type, includeGenericParameterNames: true, includeGenericParameters: true);
		}

		// Cache the result
		_cachedBuiltInTypes = builtInTypes;

		return builtInTypes;
	}

	/// <summary>
	/// Creates an instance of the specified type <typeparamref name="T"/>.
	/// This method requires the type <typeparamref name="T"/> to have a parameterless constructor.
	/// </summary>
	/// <typeparam name="T">The type of object to create.</typeparam>
	/// <returns>An instance of the specified type.</returns>
	/// <remarks>
	/// This method uses reflection to create an instance of 
	/// <typeparamref name="T"/>. It requires <typeparamref name="T"/> 
	/// to have a parameterless constructor. 
	/// Original code by: Jeremy Clark
	/// </remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static T Create<T>()
		where T : class => Activator.CreateInstance<T>();

	/// <summary>
	/// Creates an instance of the specified type <typeparamref name="T"/> using the provided parameters.
	/// </summary>
	/// <typeparam name="T">The type of the instance to create. Must be a reference type.</typeparam>
	/// <param name="paramArray">The parameters to pass to the constructor of the type <typeparamref name="T"/>.</param>
	/// <returns>An instance of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="paramArray"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static T Create<T>([NotNull] params object[] paramArray)
	{
		paramArray = paramArray.ArgumentNotNull();

		return (T)Activator.CreateInstance(typeof(T), args: paramArray);
	}

	/// <summary>
	/// Determines whether the specified object is the same instance as the provided instance.
	/// </summary>
	/// <param name="value">The object to compare. Must not be null.</param>
	/// <param name="instance">The instance to compare against. Must not be null.</param>
	/// <returns><c>true</c> if the specified object is the same instance as the provided instance; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="value"/> or <paramref name="instance"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static bool DoesObjectEqualInstance([NotNull] in object value, [NotNull] in object instance) => ReferenceEquals(value, instance);

	/// <summary>
	/// Finds all types derived from a specified base type within the currently loaded assemblies.
	/// </summary>
	/// <param name="baseType">The base type to find derived types of.</param>
	/// <param name="classOnly">If true, only class types are considered; otherwise, interfaces are also considered.</param>
	/// <returns>A read-only collection of types that are derived from the specified base type.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> FindDerivedTypes([NotNull] Type baseType, bool classOnly)
	{
		baseType = baseType.ArgumentNotNull();

		var path = AppContext.BaseDirectory;

		return FindDerivedTypes(new DirectoryInfo(path), SearchOption.TopDirectoryOnly, baseType, classOnly);
	}

	/// <summary>
	/// Finds all types derived from a specified base type within the specified <see cref="AppDomain"/>.
	/// </summary>
	/// <param name="currentDomain">The <see cref="AppDomain"/> to search for derived types in.</param>
	/// <param name="baseType">The base type to find derived types of.</param>
	/// <param name="classOnly">If true, only class types are considered; otherwise, interfaces are also considered.</param>
	/// <returns>A read-only collection of types that are derived from the specified base type.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/SpargineApril2022", Status = Status.Available)]
	public static ReadOnlyCollection<Type> FindDerivedTypes([NotNull] AppDomain currentDomain, [NotNull] Type baseType, bool classOnly)
	{
		currentDomain = currentDomain.ArgumentNotNull();
		baseType = baseType.ArgumentNotNull();

		//USING SPAN CAUSES ISSUES, FrozenSet is slower.
		var assemblyCollection = currentDomain.ArgumentNotNull().GetAssemblies();

		List<Type> types = [];

		foreach (var assembly in assemblyCollection)
		{
			try
			{
				types.AddRange(LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly));
			}
			catch (ReflectionTypeLoadException reflectionEx)
			{
				Trace.WriteLine(reflectionEx.GetAllMessages());
			}
		}

		return types.AsReadOnly();
	}

	/// <summary>
	/// Finds all types derived from a specified base type within the assemblies located in the specified directory.
	/// </summary>
	/// <param name="path">The directory containing the assemblies to search.</param>
	/// <param name="fileSearchType">Specifies whether to search all directories or only the top directory.</param>
	/// <param name="baseType">The base type to find derived types of.</param>
	/// <param name="classOnly">If true, only class types are considered; otherwise, interfaces are also considered.</param>
	/// <returns>A read-only collection of types that are derived from the specified base type.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static ReadOnlyCollection<Type> FindDerivedTypes([NotNull] DirectoryInfo path, SearchOption fileSearchType, [NotNull] Type baseType, bool classOnly)
	{
		fileSearchType = fileSearchType.ArgumentDefined();
		baseType = baseType.ArgumentNotNull();

		var files = path.ArgumentExists().EnumerateFiles("*.dll", fileSearchType).ToImmutableArray();

		var list = files;
		var foundTypes = new List<Type>();
		var itemCount = list.Length;

		for (var fileIndex = 0; fileIndex < itemCount; fileIndex++)
		{
			try
			{
				var fileName = list[fileIndex].FullName;

				if (IsDotNetAssembly(new FileInfo(fileName)))
				{
					var assembly = Assembly.LoadFrom(fileName);
					var exportedTypes = assembly.ExportedTypes.Where(p => p.BaseType is not null).ToImmutableArray();

					if (exportedTypes.Count() > 0)
					{
						var containsBaseType = exportedTypes.Any(p => string.Equals(p.BaseType.FullName, baseType.FullName, StringComparison.Ordinal));

						if (containsBaseType)
						{
							foundTypes.AddRange(LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly));
						}
					}
				}
			}
			catch (BadImageFormatException ex)
			{
				Trace.WriteLine(ex.GetAllMessages());
			}
			catch (FileLoadException fileLoadEx)
			{
				Trace.WriteLine(fileLoadEx.GetAllMessages());
			}
			catch (FileNotFoundException fileNotFoundEx)
			{
				Trace.WriteLine(fileNotFoundEx.GetAllMessages());
			}
			catch (TypeLoadException typeLoadEx)
			{
				Trace.WriteLine(typeLoadEx.GetAllMessages());
			}
		}

		return foundTypes.AsReadOnly();
	}

	/// <summary>
	/// Deserializes a JSON string into an instance of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <returns>An instance of <typeparamref name="T"/> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="json"/> is null or empty.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or the deserialization fails.</exception>
	[Information(nameof(FromJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static T FromJson<T>([NotNull][StringSyntax(StringSyntaxAttribute.Json)] string json)
		where T : class => JsonSerializer.Deserialize<T>(json);

	/// <summary>
	/// Deserializes a JSON file into an instance of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the object to deserialize to.</typeparam>
	/// <param name="file">The <see cref="FileInfo"/> representing the file to deserialize from.</param>
	/// <returns>An instance of <typeparamref name="T"/> deserialized from the JSON file.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> is null.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or the deserialization fails.</exception>
	[Information(nameof(FromJsonFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static T FromJsonFile<T>([NotNull] FileInfo file)
		where T : class
	{
		file = file.ArgumentNotNull();

		if (file.Exists is false)
		{
			throw ExceptionThrower.CreateFileNotFoundException(file.FullName);
		}

		var json = File.ReadAllText(file.FullName, Encoding.UTF8);

		return JsonSerializer.Deserialize<T>(json);
	}

	/// <summary>
	/// Gets the default value for the specified type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type for which to get the default value.</typeparam>
	/// <returns>The default value for type <typeparamref name="T"/>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T GetDefault<T>() => default;

	/// <summary>
	/// Computes the hash code for the specified instance.
	/// </summary>
	/// <param name="instance">The instance to compute the hash code for.</param>
	/// <returns>The computed hash code.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="instance"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static int GetInstanceHashCode([NotNull] object instance)
	{
		var hash = instance.ArgumentNotNull().GetType().GetRuntimeProperties().Where(p => p is not null).Select(prop => prop.GetValue(instance)).Where(value => value is not null).Aggregate(-1, (accumulator, value) => accumulator ^ value.GetHashCode());

		return hash;
	}

	/// <summary>
	/// Retrieves all members of the specified type that have the specified attribute.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="type">The type to search for members with the specified attribute.</param>
	/// <returns>An enumerable collection of members that have the specified attribute.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[Information(nameof(GetMembersWithAttribute), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<MemberInfo> GetMembersWithAttribute<TAttribute>(Type type) where TAttribute : Attribute
	{
		type = type.ArgumentNotNull();

		var membersWithAttribute = new List<MemberInfo>();

		// Check for attributes on the type itself
		if (Attribute.IsDefined(type, typeof(TAttribute), true))
		{
			membersWithAttribute.Add(type);
		}

		// Define binding flags once to avoid repetition
		var bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

		// Check for attributes on the properties, methods, fields, and events of the type
		foreach (var member in type.GetMembers(bindingFlags))
		{
			if (Attribute.IsDefined(member, typeof(TAttribute), true))
			{
				membersWithAttribute.Add(member);
			}
		}

		return membersWithAttribute;
	}

	/// <summary>
	/// Gets the property values of the specified object.
	/// </summary>
	/// <typeparam name="T">The type of the object to get property values from.</typeparam>
	/// <param name="input">The object instance to extract property values from.</param>
	/// <returns>A read-only collection of key-value pairs where each key is a property name and each value is the property's value as a string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	/// <example>Output:
	/// [Address1, `fqrZjAqTNANUNIyJWFyNjCQx]
	/// [Address2, bSUnkmaIIMutgJtAKYZANpSHM]
	/// [Age, 23360.00:00:00.0086580]
	/// [BornOn, 1/23/1957 2:45:24 PM -08:00]
	/// [CellPhone, 704-375-5873]
	/// [City, fDbZYFMANE\MLxD]
	/// [Country, RbPjkyMasw`gnWR]
	/// [Email, thmiduaodph@djpumhmaheckkmrmwkkpxs.gov]
	/// [FirstName, ugdv\bhaHgSY^Ui]
	/// [HomePhone, 147-205-1085]
	/// [Id, f1bcbdbdf18a4adaa89e46383b235008]
	/// [LastName, H^hkKhwWggIrUCYbbxiFEJGJM]
	/// [PostalCode, 86560656].
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetPropertyValues), author: "David McCarter", createdOn: "11/03/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Documentation = "http://bit.ly/SpargineMarch2021", Status = Status.Available)]
	public static ReadOnlyCollection<KeyValuePair<string, string>> GetPropertyValues<T>([NotNull] in T input)
	{
		_ = input.ArgumentNotNull();

		var returnValue = new Dictionary<string, string>();

		var properties = input.GetType().GetAllProperties().Where(p => p.CanRead).OrderBy(p => p.Name).ToArray();

		foreach (var propertyInfo in properties)
		{
			var propertyValue = propertyInfo.GetValue(input);

			if (propertyValue is IDictionary dictionary && dictionary.Count > 0)
			{
				_ = returnValue.AddIfNotExists(new KeyValuePair<string, string>(propertyInfo.Name, dictionary.ToDelimitedString()));
			}
			else if (propertyValue is not null)
			{
				_ = returnValue.AddIfNotExists(new KeyValuePair<string, string>(propertyInfo.Name, propertyValue.ToString()));
			}
		}

		return returnValue.ToReadOnlyCollection();
	}

	/// <summary>
	/// Gets the display name of the type of the specified object, even if it's a generic type.
	/// </summary>
	/// <param name="item">The object to get the type display name for.</param>
	/// <param name="fullName">If true, the full name of the type is returned; otherwise, the short name is returned.</param>
	/// <returns>The display name of the type of the specified object.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/31/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static string GetTypeDisplayName([NotNull] in object item, bool fullName = true) => item is null ? null : GetTypeDisplayName(item.GetType(), fullName);

	/// <summary>
	/// Gets the display name of the specified type using the provided display options.
	/// </summary>
	/// <param name="type">The type to get the display name for.</param>
	/// <param name="options">The display options to use for formatting the display name.</param>
	/// <returns>The display name of the type.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static string GetTypeDisplayName([NotNull] Type type, in DisplayNameOptions options)
	{
		type = type.ArgumentNotNull();

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			ProcessType(sb, type, options);

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Gets the display name of the specified type.
	/// </summary>
	/// <param name="type">The type to get the display name for.</param>
	/// <param name="fullName">If true, returns the full name of the type; otherwise, returns the short name.</param>
	/// <param name="includeGenericParameterNames">If true, includes the names of generic parameters in the display name.</param>
	/// <param name="includeGenericParameters">If true, includes generic parameters in the display name.</param>
	/// <param name="nestedTypeDelimiter">The delimiter to use for nested types.</param>
	/// <returns>The display name of the type.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/31/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string GetTypeDisplayName([NotNull] Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = ControlChars.Dot)
	{
		type = type.ArgumentNotNull();

		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			ProcessType(sb, type, new DisplayNameOptions(fullName, includeGenericParameterNames, includeGenericParameters, nestedTypeDelimiter));

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Determines whether the specified type is a built-in .NET type.
	/// </summary>
	/// <param name="type">The type to check.</param>
	/// <returns><c>true</c> if the type is a built-in .NET type; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsBuiltinType), author: "David McCarter", createdOn: "11/6/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Documentation = "https://bit.ly/Spargine8", Status = Status.Available)]
	public static bool IsBuiltinType(in Type type) => type != null && BuiltInTypeNames().ContainsKey(type);

	/// <summary>
	/// Determines whether the specified file is a .NET assembly.
	/// </summary>
	/// <param name="file">The file to check.</param>
	/// <returns><c>true</c> if the file is a .NET assembly; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the file argument is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown when the file does not exist.</exception>
	/// <exception cref="IOException">Thrown when an I/O error occurs.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when access to the file is unauthorized.</exception>
	[Information("Orginal code by GÉRALD BARRÉ", author: "David McCarter", createdOn: "5/20/2024", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static bool IsDotNetAssembly(FileInfo file)
	{
		file = file.ArgumentExists();

		using var stream = File.OpenRead(file.FullName);

		return IsDotNetAssembly(stream);
	}

	/// <summary>
	/// Processes a generic type to construct its display name, including handling of generic arguments.
	/// </summary>
	/// <param name="builder">The <see cref="StringBuilder"/> used to build the display name.</param>
	/// <param name="type">The generic type to process.</param>
	/// <param name="genericArguments">The array of generic arguments for the type.</param>
	/// <param name="length">The number of generic arguments to consider.</param>
	/// <param name="options">Display name options to customize the output.</param>
	[Information(nameof(ProcessGenericType), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void ProcessGenericType(StringBuilder builder, Type type, Type[] genericArguments, int length, DisplayNameOptions options)
	{
		builder = builder.ArgumentNotNull();
		type = type.ArgumentNotNull();
		genericArguments = genericArguments.ArgumentNotNull();

		var offset = 0;

		if (type.IsNested)
		{
			offset = type.DeclaringType.GetGenericArguments().Length;
		}

		if (options.FullName)
		{
			if (type.IsNested)
			{
				ProcessGenericType(builder, type.DeclaringType, genericArguments, offset, options);
				_ = builder.Append(options.NestedTypeDelimiter);
			}
			else if (!string.IsNullOrEmpty(type.Namespace))
			{
				_ = builder.Append(type.Namespace);
				_ = builder.Append(ControlChars.Dot);
			}
		}

		var genericPartIndex = type.Name.IndexOf('`', StringComparison.Ordinal);
		if (genericPartIndex <= 0)
		{
			_ = builder.Append(type.Name);
			return;
		}

		_ = builder.Append(type.Name, 0, genericPartIndex);

		if (options.IncludeGenericParameters)
		{
			_ = builder.Append(ControlChars.StartAngleBracket);

			for (var typeCount = offset; typeCount < length; typeCount++)
			{
				ProcessType(builder, genericArguments[typeCount], options);

				if (typeCount + 1 == length)
				{
					continue;
				}

				_ = builder.Append(ControlChars.Comma);
				if (options.IncludeGenericParameterNames || !genericArguments[typeCount + 1].IsGenericParameter)
				{
					_ = builder.Append(ControlChars.Space);
				}
			}

			_ = builder.Append(ControlChars.EndAngleBracket);
		}
	}

	/// <summary>
	/// Gets a read-only collection of built-in .NET types.
	/// </summary>
	[Information(nameof(BuiltInTypes), "David McCarter", "11/6/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/Spargine8", Status = Status.Available)]
	public static ReadOnlyCollection<Type> BuiltInTypes
	{
		get
		{
			if (_builtInTypes == null)
			{
				ComputeBuiltInTypes();
			}

			return _builtInTypes.ToList().AsReadOnly();
		}
	}

}
