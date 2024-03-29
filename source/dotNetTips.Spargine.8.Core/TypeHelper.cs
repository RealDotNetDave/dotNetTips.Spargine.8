// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2024
// ***********************************************************************
// <copyright file="TypeHelper.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Provides valuable methods for type management, encompassing tasks such as loading derived types, creating new types, discovering derived types, converting JSON to objects, transforming JSON files into objects, generating instance hash codes, and listing built-in types. These functionalities empower developers to handle types effectively in diverse scenarios.
// </summary>
// ***********************************************************************

using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class TypeHelper.
/// </summary>
public static class TypeHelper
{

	/// <summary>
	/// The builtin types
	/// </summary>
	private static ReadOnlyCollection<Type> _builtinTypes;

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Computes the builtin types.
	/// </summary>
	[Information(nameof(ComputeBuiltinTypes), author: "David McCarter", createdOn: "11/6/2023")]
	private static void ComputeBuiltinTypes()
	{
		// Get all the assemblies loaded in the current app domain
		var assemblies = AppDomain.CurrentDomain.GetAssemblies();

		// Create a list to store the built-in types
		var builtinTypes = new List<Type>();

		// Loop through each assembly
		foreach (var assembly in assemblies)
		{
			// Get the types defined in the assembly
			var types = assembly.GetTypes();

			// Loop through each type
			foreach (var type in types)
			{
				// Check if the type is a built-in type
				if (IsBuiltinType(type))
				{
					// Add the type to the list
					builtinTypes.Add(type);
				}
			}
		}

		_builtinTypes = builtinTypes.AsReadOnly();
	}

	/// <summary>
	/// Loads the derived types of a type.
	/// </summary>
	/// <param name="types">The types.</param>
	/// <param name="baseType">Type of the base.</param>
	/// <param name="classOnly">The class only.</param>
	/// <returns>IEnumerable&lt;Type&gt;.</returns>
	[Information(UnitTestCoverage = 99, Status = Status.Available)]
	private static IEnumerable<Type> LoadDerivedTypes(IEnumerable<TypeInfo> types, Type baseType, bool classOnly)
	{
		// works out the derived types
		var list = types.ToList();

		for (var typeCount = 0; typeCount < list.FastCount(); typeCount++)
		{
			var type = list[typeCount];

			// if classOnly, it must be a class
			// useful when you want to create instance
			if (classOnly && !type.IsClass)
			{
				continue;
			}

			if (baseType.IsInterface)
			{
				if (type.GetInterface(baseType.FullName) is not null)
				{
					// add it to result list
					yield return type;
				}
			}
			else if (type.IsSubclassOf(baseType))
			{
				// add it to result list
				yield return type;
			}
		}
	}

	/// <summary>
	/// Processes the type of the generic.
	/// </summary>
	/// <param name="builder">The builder.</param>
	/// <param name="type">The type.</param>
	/// <param name="genericArguments">The generic arguments.</param>
	/// <param name="length">The length.</param>
	/// <param name="options">The options.</param>
	[Information(UnitTestCoverage = 99, Status = Status.Available)]
	private static void ProcessGenericType(StringBuilder builder, Type type, Type[] genericArguments, int length, DisplayNameOptions options)
	{
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
	/// Processes the type.
	/// </summary>
	/// <param name="builder">The builder.</param>
	/// <param name="type">The type.</param>
	/// <param name="options">The options.</param>
	[Information(UnitTestCoverage = 99, Status = Status.Available)]
	private static void ProcessType(StringBuilder builder, Type type, DisplayNameOptions options)
	{
		if (type.IsGenericType)
		{
			var genericArguments = type.GetGenericArguments();
			ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);
		}
		else if (type.IsArray)
		{
			ProcessType(builder, type, options);
		}
		else if (BuiltInTypeNames.ContainsKey(type))
		{
			_ = builder.Append(type.Name);
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
	/// Creates type instance.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <returns>T.</returns>
	/// <remarks>Original code by: Jeremy Clark</remarks>
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public static T Create<T>()
		where T : class
	{
		var instance = Activator.CreateInstance<T>();

		return instance is not null ? instance : null;
	}

	/// <summary>
	/// Creates the specified parameter array.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="paramArray">The parameter array.</param>
	/// <returns>T.</returns>
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public static T Create<T>([NotNull] params object[] paramArray)
	{
		var instance = (T)Activator.CreateInstance(typeof(T), args: paramArray);

		return instance;
	}

	/// <summary>
	/// Does the object equal instance.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="instance">The instance.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public static bool DoesObjectEqualInstance([NotNull] object value, [NotNull] object instance)
	{
		var result = ReferenceEquals(value, instance);

		return result;
	}

	/// <summary>
	/// Finds the derived types in the app folder.
	/// </summary>
	/// <param name="baseType">Type of the base.</param>
	/// <param name="classOnly">if set to <c>true</c> [class only].</param>
	/// <returns>IEnumerable&lt;Type&gt;.</returns>
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public static ReadOnlyCollection<Type> FindDerivedTypes([NotNull] Type baseType, bool classOnly)
	{
		var path = Path.GetDirectoryName(AppContext.BaseDirectory);

		return FindDerivedTypes(new DirectoryInfo(path), SearchOption.AllDirectories, baseType, classOnly);
	}

	/// <summary>
	/// Finds the derived types.
	/// </summary>
	/// <param name="currentDomain">The current domain.</param>
	/// <param name="baseType">Type of the base.</param>
	/// <param name="classOnly">if set to <c>true</c> [class only].</param>
	/// <returns>IEnumerable&lt;Type&gt;.</returns>
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public static ReadOnlyCollection<Type> FindDerivedTypes([NotNull] AppDomain currentDomain, [NotNull] Type baseType, bool classOnly)
	{
		currentDomain = currentDomain.ArgumentNotNull();
		baseType = baseType.ArgumentNotNull();

		var array = currentDomain.ArgumentNotNull().GetAssemblies();
		List<Type> types = null;

		for (var assemblyCount = 0; assemblyCount < array.Length; assemblyCount++)
		{
			try
			{
				var assembly = array[assemblyCount];
				var tempTypes = LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly).ToList();

				if (tempTypes?.FastCount() > 0)
				{
					if (types is null)
					{
						types = tempTypes;
					}
					else
					{
						types.AddRange(tempTypes);
					}
				}
			}
			catch (ReflectionTypeLoadException reflectionEx)
			{
				Trace.WriteLine(reflectionEx.GetAllMessages());
			}
		}

		return types.AsReadOnly();
	}

	/// <summary>
	/// Finds the derived types using the path.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <param name="fileSearchType">The search option.</param>
	/// <param name="baseType">Type of the base.</param>
	/// <param name="classOnly">if set to <c>true</c> [class only].</param>
	/// <returns>IEnumerable&lt;Type&gt;.</returns>
	/// <exception cref="DirectoryNotFoundException">Could not find path.</exception>
	/// <exception cref="ArgumentNullException">Could not find path.</exception>
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public static ReadOnlyCollection<Type> FindDerivedTypes([NotNull] DirectoryInfo path, SearchOption fileSearchType, [NotNull] Type baseType, bool classOnly)
	{
		fileSearchType = fileSearchType.ArgumentDefined();
		baseType = baseType.ArgumentNotNull();

		var files = path.ArgumentExists().EnumerateFiles("*.dll", fileSearchType).ToList();

		var list = files.ToList();
		var foundTypes = new List<Type>();

		for (var fileIndex = 0; fileIndex < list.FastCount(); fileIndex++)
		{
			try
			{
				var assembly = Assembly.LoadFrom(list[fileIndex].FullName);
				var exportedTypes = assembly.ExportedTypes.Where(p => p.BaseType is not null).ToList();

				if (exportedTypes?.FastCount() > 0)
				{
					var containsBaseType = exportedTypes.Any(p => string.Equals(p.BaseType.FullName, baseType.FullName, StringComparison.Ordinal));

					if (containsBaseType)
					{
						foundTypes.AddRange(LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly));
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
		}

		return foundTypes.AsReadOnly();
	}

	/// <summary>
	/// Creates object from Json.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="json">The json.</param>
	/// <returns>T.</returns>
	[Information(nameof(FromJson), UnitTestCoverage = 100, Status = Status.Available)]
	public static T FromJson<T>([NotNull] string json)
		where T : class => JsonSerializer.Deserialize<T>(json);

	/// <summary>
	/// Creates object from a Json file.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="file">File</param>
	/// <returns>T.</returns>
	/// <exception cref="FileNotFoundException">The exception.</exception>
	[Information(nameof(FromJsonFile), UnitTestCoverage = 99, Status = Status.Available)]
	public static T FromJsonFile<T>([NotNull] FileInfo file)
		where T : class
	{
		file = file.ArgumentNotNull();

		if (file.Exists is false)
		{
			ExceptionThrower.ThrowFileNotFoundException(Resources.ErrorFileNotFound, file.FullName);
		}

		var json = File.ReadAllText(file.FullName, Encoding.UTF8);

		return JsonSerializer.Deserialize<T>(json);
	}

	/// <summary>
	/// Gets the default type.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <returns>T.</returns>
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public static T GetDefault<T>() => default;

	/// <summary>
	/// Gets the instance hash code.
	/// </summary>
	/// <param name="instance">The instance.</param>
	/// <returns>Int32.</returns>
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public static int GetInstanceHashCode([NotNull] object instance)
	{
		var hash = instance.ArgumentNotNull().GetType().GetRuntimeProperties().Where(p => p is not null).Select(prop => prop.GetValue(instance)).Where(value => value is not null).Aggregate(-1, (accumulator, value) => accumulator ^ value.GetHashCode());

		return hash;
	}

	/// <summary>
	/// Gets the property values from a type.
	/// </summary>
	/// <typeparam name="T">Generic type.</typeparam>
	/// <param name="input">The input.</param>
	/// <returns>ReadOnlyDictionary&lt;System.String, System.String&gt;.</returns>
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
	[Information(nameof(GetPropertyValues), author: "David McCarter", createdOn: "11/03/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static ReadOnlyCollection<KeyValuePair<string, string>> GetPropertyValues<T>([NotNull] T input)
	{
		input = input.ArgumentNotNull();

		var returnValue = new Dictionary<string, string>();

		var properties = input.GetType().GetAllProperties().Where(p => p.CanRead).OrderBy(p => p.Name).ToArray();

		for (var propertyCount = 0; propertyCount < properties.Length; propertyCount++)
		{
			var propertyInfo = properties[propertyCount];

			if (string.Equals(propertyInfo.PropertyType.Name, "IDictionary", StringComparison.Ordinal))
			{
				var propertyValue = propertyInfo.GetValue(input) as IDictionary;

				if (propertyValue?.Count > 0)
				{
					_ = returnValue.AddIfNotExists(new KeyValuePair<string, string>(propertyInfo.Name, propertyValue.ToDelimitedString()));
				}
			}
			else
			{
				// Get property value
				var propertyValue = propertyInfo.GetValue(input);

				if (propertyValue is not null)
				{
					_ = returnValue.AddIfNotExists(new KeyValuePair<string, string>(propertyInfo.Name, propertyValue.ToString()));
				}
			}
		}

		return returnValue.ToReadOnlyCollection();
	}

	/// <summary>
	/// Gets the display name of the type.
	/// </summary>
	/// <param name="item">The item.</param>
	/// <param name="fullName">if set to <c>true</c> [full name].</param>
	/// <returns>System.String.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/31/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string GetTypeDisplayName([NotNull] object item, bool fullName = true) => item is null ? null : GetTypeDisplayName(item.GetType(), fullName);

	/// <summary>
	/// Pretty print a type name using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// </summary>
	/// <param name="type">The <see cref="Type" />.</param>
	/// <param name="fullName"><c>true</c> to print a fully qualified name.</param>
	/// <param name="includeGenericParameterNames"><c>true</c> to include generic parameter names.</param>
	/// <param name="includeGenericParameters"><c>true</c> to include generic parameters.</param>
	/// <param name="nestedTypeDelimiter">Character to use as a delimiter in nested type names</param>
	/// <returns>The pretty printed type name.</returns>
	/// <exception cref="ArgumentNullException">type</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/31/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static string GetTypeDisplayName([NotNull] Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = ControlChars.Plus)
	{
		type = type.ArgumentNotNull();

		var sb = _stringBuilderPool.Get();
		try
		{
			ProcessType(
				sb,
				type,
				new DisplayNameOptions(
					fullName,
					includeGenericParameterNames,
					includeGenericParameters,
					nestedTypeDelimiter));

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Determines whether [is built-in type] [the specified type].
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns><c>true</c> if [is built-in type] [the specified type]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsBuiltinType), author: "David McCarter", createdOn: "11/6/2023", UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static bool IsBuiltinType(Type type)
	{
		if (type is null)
		{
			return false;
		}

		// Check if the type is a primitive type
		if (type.IsPrimitive)
		{
			return true;
		}

		// Check if the type is a simple type (string, object, or dynamic)
		if (type == typeof(string) || type == typeof(object))
		{
			return true;
		}

		// Check if the type is a nullable value type
		if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			// Get the underlying value type
			var valueType = type.GetGenericArguments()[0];

			// Check if the value type is a primitive type
			if (valueType.IsPrimitive)
			{
				return true;
			}
		}

		// Otherwise, the type is not a built-in type
		return false;
	}

	/// <summary>
	/// Gets the built in type names.
	/// </summary>
	/// <value>The built in type names.</value>
	public static Dictionary<Type, string> BuiltInTypeNames { get; } = new()
	{
		{ typeof(DateTime), "datetime" },
		{ typeof(DateTimeOffset), "datetimeoffset" },
		{ typeof(TimeSpan), "timespan" },
		{ typeof(bool), "bool" },
		{ typeof(byte), "byte" },
		{ typeof(char), "char" },
		{ typeof(decimal), "decimal" },
		{ typeof(double), "double" },
		{ typeof(float), "float" },
		{ typeof(int), "int" },
		{ typeof(long), "long" },
		{ typeof(object), "object" },
		{ typeof(sbyte), "sbyte" },
		{ typeof(short), "short" },
		{ typeof(string), "string" },
		{ typeof(uint), "uint" },
		{ typeof(ulong), "ulong" },
		{ typeof(ushort), "ushort" },
		{ typeof(void), "void" },
	};

	/// <summary>
	/// Gets all of the builtin types for .NET.
	/// </summary>
	/// <value>The builtin types.</value>
	[Information(nameof(BuiltinTypes), "David McCarter", "11/6/2023", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "ADD URL")]
	public static ReadOnlyCollection<Type> BuiltinTypes
	{
		get
		{
			if (_builtinTypes is null)
			{
				ComputeBuiltinTypes();
			}

			return _builtinTypes;
		}
	}

	/// <summary>
	/// Struct DisplayNameOptions.
	/// </summary>
	/// <param name="fullName">if set to <c>true</c> [full name].</param>
	/// <param name="includeGenericParameterNames">if set to <c>true</c> [include generic parameter names].</param>
	/// <param name="includeGenericParameters">if set to <c>true</c> [include generic parameters].</param>
	/// <param name="nestedTypeDelimiter">The nested type delimiter.</param>
	/// <remarks>Initializes a new instance of the <see cref="DisplayNameOptions" /> struct.</remarks>
	internal readonly struct DisplayNameOptions(bool fullName, bool includeGenericParameterNames, bool includeGenericParameters, char nestedTypeDelimiter)
	{

		/// <summary>
		/// Gets a value indicating whether [full name].
		/// </summary>
		/// <value><c>true</c> if [full name]; otherwise, <c>false</c>.</value>
		public bool FullName { get; } = fullName;

		/// <summary>
		/// Gets a value indicating whether [include generic parameter names].
		/// </summary>
		/// <value><c>true</c> if [include generic parameter names]; otherwise, <c>false</c>.</value>
		public bool IncludeGenericParameterNames { get; } = includeGenericParameterNames;

		/// <summary>
		/// Gets a value indicating whether [include generic parameters].
		/// </summary>
		/// <value><c>true</c> if [include generic parameters]; otherwise, <c>false</c>.</value>
		public bool IncludeGenericParameters { get; } = includeGenericParameters;

		/// <summary>
		/// Gets the nested type delimiter.
		/// </summary>
		/// <value>The nested type delimiter.</value>
		public char NestedTypeDelimiter { get; } = nestedTypeDelimiter;

	}

}
