// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 11-16-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2025
// ***********************************************************************
// <copyright file="InformationAttributeDocGenerator.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Globalization;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Generates documentation for a given type based on the InformationAttribute.
/// </summary>
[Information(Status = Status.NeedsDocumentation, Documentation = "")]
public static class InformationAttributeDocGenerator
{
	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Generates a documentation string for the specified type based on the InformationAttribute.
	/// </summary>
	/// <param name="type">The type for which to generate documentation.</param>
	/// <param name="sb">The StringBuilder to append the documentation to.</param>
	private static void GenerateDocument(Type type, StringBuilder sb)
	{
		type = type.ArgumentNotNull();

		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"## {GetTypeName(type)}");
		_ = sb.AppendLine();

		var members = TypeHelper.GetMembersWithAttribute<InformationAttribute>(type).ToList();

		//Add document for class
		var classInfo = members.FirstOrDefault(p => p.MemberType == MemberTypes.TypeInfo);

		if (classInfo is not null)
		{
			GenerateMemberInfo(sb, classInfo);

			_ = members.Remove(classInfo);
		}

		foreach (var member in members.OrderBy(p => p.Name))
		{
			GenerateMemberInfo(sb, member);
		}

	}

	/// <summary>
	/// Generates member information documentation based on the InformationAttribute.
	/// </summary>
	/// <param name="sb">The StringBuilder to append the documentation to.</param>
	/// <param name="memberInfo">The member information to document.</param>
	private static void GenerateMemberInfo(StringBuilder sb, MemberInfo memberInfo)
	{
		//Get InfomationAttribute data
		var info = memberInfo.GetCustomAttribute<InformationAttribute>();

		if (memberInfo.MemberType != MemberTypes.TypeInfo)
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"### {GetMemberSignature(memberInfo)}");
			_ = sb.AppendLine();
		}

		//Display main statuses first
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **Status:** {info.Status}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **Optimization Status:** {info.OptimizationStatus}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **BenchMarkStatus:** {info.BenchmarkStatus}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **Unit Test Status:** {info.UnitTestStatus}");

		if (info.Author.HasValue())
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **Author:** {info.Author}");
		}


		if (info.CreatedOn != DateTimeOffset.MinValue)
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **CreatedOn:** {info.CreatedOn.ToString("d", CultureInfo.CurrentCulture)}");
		}

		if (info.Description.HasValue())
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **Description:** {info.Description}");
		}

		if (info.Documentation.HasValue())
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **Documentation:** {info.Documentation}");
		}

		if (info.ModifiedBy.HasValue())
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **Modified By:** {info.ModifiedBy}");
		}

		if (info.ModifiedOn != DateTimeOffset.MinValue)
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"* **Modified On:** {info.ModifiedOn.ToString("d", CultureInfo.CurrentCulture)}");
		}

		_ = sb.AppendLine();
	}

	/// <summary>
	/// Gets the signature of the specified member.
	/// </summary>
	/// <param name="member">The member for which to get the signature.</param>
	/// <returns>A string representing the signature of the member.</returns>
	private static string GetMemberSignature(MemberInfo member)
	{

		switch (member.MemberType)
		{
			case MemberTypes.Constructor:
				var constructor = (ConstructorInfo)member;
				var constructorName = GetTypeName(constructor.DeclaringType); // Use the class name for the constructor
				var constructorParameters = constructor.GetParameters();
				var constructorParameterList = string.Join(", ", Array.ConvertAll(constructorParameters, p => $"{GetTypeName(p.ParameterType)} {p.Name}"));
				return $"{constructorName} ({constructorParameterList})";

			case MemberTypes.Method:
				var method = (MethodInfo)member;
				var returnType = GetTypeName(method.ReturnType);
				var methodName = method.Name;
				var parameters = method.GetParameters();
				var parameterList = string.Join(", ", Array.ConvertAll(parameters, p => $"{GetTypeName(p.ParameterType)} {p.Name}"));
				return $"{returnType} {methodName}({parameterList})";

			case MemberTypes.Property:
				var property = (PropertyInfo)member;
				return $"{GetTypeName(property.PropertyType)} {property.Name} {{ get; set; }}";

			case MemberTypes.Field:
				var field = (FieldInfo)member;
				return $"{GetTypeName(field.FieldType)} {field.Name}";

			case MemberTypes.Event:
				var eventInfo = (EventInfo)member;
				return $"event {eventInfo.EventHandlerType.Name} {eventInfo.Name}";

			default:
				return $"{member.MemberType} {member.Name}";
		}
	}

	private static string GetTypeName(Type type)
	{
		if (type.IsGenericType && type.Name.Contains('`', StringComparison.Ordinal))
		{
			// Handle generic types
			var typeName = _stringBuilderPool.Value.Get().Clear();
			var baseName = type.Name[..type.Name.IndexOf('`', StringComparison.Ordinal)];
			_ = typeName.Append(baseName);
			_ = typeName.Append('<');

			var genericArguments = type.GetGenericArguments();
			_ = typeName.Append(string.Join(", ", Array.ConvertAll(genericArguments, GetTypeName)));
			_ = typeName.Append('>');

			return typeName.ToString();
		}

		return type.Name;
	}

	/// <summary>
	/// Checks if the specified type or any of its members have the InformationAttribute.
	/// </summary>
	/// <param name="type">The type to check for the InformationAttribute.</param>
	/// <returns>True if the type or any of its members have the InformationAttribute; otherwise, false.</returns>
	private static bool HasInformationAttribute(Type type)
	{
		// Check if the type itself has the InformationAttribute
		if (Attribute.IsDefined(type, typeof(InformationAttribute)))
		{
			return true;
		}

		// Check if any of the members of the type have the InformationAttribute
		return type.GetMembers().Any(member => Attribute.IsDefined(member, typeof(InformationAttribute)));
	}

	/// <summary>
	/// Generates documentation for all types in the specified assembly.
	/// </summary>
	/// <param name="assembly">The assembly for which to generate documentation.</param>
	/// <returns>A string containing the generated documentation for the entire assembly.</returns>
	[Information(nameof(GenerateMarkdownDocumentForAssembly), "David McCarter", "11/18/2024", BenchmarkStatus = BenchmarkStatus.None, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.New)]
	public static string GenerateMarkdownDocumentForAssembly(Assembly assembly)
	{
		assembly = assembly.ArgumentNotNull();

		var sb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"# {assembly.GetName().Name} - {assembly.GetName().Version}");
			_ = sb.AppendLine();

			var types = assembly.GetTypes().Where(type => type != null && HasInformationAttribute(type)).ToArray();

			foreach (var type in types)
			{
				GenerateDocument(type, sb);
				_ = sb.AppendLine("*****");
			}

			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"**Generated by Spargine - dotNetTips.com on {DateTime.UtcNow} UTC**");

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Generates documentation for all types in the specified assembly and writes it to a file.
	/// </summary>
	/// <param name="assembly">The assembly for which to generate documentation.</param>
	/// <param name="path">The path where the documentation file will be saved.</param>
	/// <returns>The name of the file to which the documentation was written.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assembly"/> is null.</exception>
	[Information(nameof(GenerateMarkdownDocumentForAssembly), "David McCarter", "11/18/2024", BenchmarkStatus = BenchmarkStatus.None, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.New)]
	public static string GenerateMarkdownDocumentForAssembly(Assembly assembly, string path)
	{
		var result = GenerateMarkdownDocumentForAssembly(assembly);

		// Use or create filename
		var fileName = Path.Combine(path, $"{assembly.GetName().Name}.info.md");

		File.WriteAllText(fileName, result);

		return fileName;
	}
}
