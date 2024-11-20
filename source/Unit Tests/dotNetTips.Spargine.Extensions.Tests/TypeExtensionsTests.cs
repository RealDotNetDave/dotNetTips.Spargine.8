// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-30-2024
// ***********************************************************************
// <copyright file="TypeExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Core.Logging;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

/// <summary>
/// Defines attribute class TypeExtensionsTests.
/// </summary>
[ExcludeFromCodeCoverage]
[TestClass]
public class TypeExtensionsTests
{

	/// <summary>
	/// Defines the attribute method GetAbstractMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetAbstractMethodsTest()
	{
		var result = typeof(AbstractTestType).GetAllAbstractMethods();

		Assert.IsTrue(result.FastCount() == 1);

		result = typeof(DataTable).GetAllAbstractMethods();

		Assert.IsTrue(result.FastCount() == 0);
	}

	[TestMethod]
	public void GetAllDeclaredFieldsTest()
	{
		var result = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).GetAllDeclaredFields();

		Assert.IsTrue(result.FastCount() > 0);
	}

	[TestMethod]
	public void GetAllDeclaredMethodsTest()
	{
		var result = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).GetAllDeclaredMethods();

		Assert.IsTrue(result.FastCount() > 0);
	}

	/// <summary>
	/// Defines the attribute method GetAllFieldsTest.
	/// </summary>
	[TestMethod]
	public void GetAllFieldsTest()
	{
		var result1 = typeof(TestType).GetAllFields();

		Assert.IsTrue(result1.FastCount() == 1);

		var result2 = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).GetAllFields();

		Assert.IsTrue(result2.FastCount() >= 8);
	}

	/// <summary>
	/// Defines the attribute method GetAllMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetAllMethodsTest()
	{
		var result = typeof(TestType).GetAllMethods();

		Assert.IsTrue(result.FastCount() == 13);

		result = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).GetAllMethods();

		Assert.IsTrue(result.FastCount() >= 44);
	}

	/// <summary>
	/// Defines the attribute method GetAttributeFieldTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeFieldTest()
	{
		Assert.IsNotNull(typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<DebuggerBrowsableAttribute>());

		Assert.IsNull(typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<XmlIgnoreAttribute>());
	}

	/// <summary>
	/// Defines the attribute method GetAttributeMethodTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeMethodTest()
	{
		var method = typeof(TestType).GetAllMethods().FirstOrDefault(p => string.Compare(p.Name, "get_UserName", StringComparison.Ordinal) == 0);

		var result1 = method.GetAttribute<CompilerGeneratedAttribute>();

		Assert.IsNotNull(result1);

		var result2 = method.GetAttribute<XmlIgnoreAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the attribute method GetAttributePropertyTest.
	/// </summary>
	[TestMethod]
	public void GetAttributePropertyTest()
	{
		var property = typeof(TestType).GetAllProperties().FirstOrDefault();

		var result1 = property.GetAttribute<DebuggerBrowsableAttribute>();

		Assert.IsNotNull(result1);

		var result2 = property.GetAttribute<XmlAnyAttributeAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the attribute method GetAttributeTypeTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeTypeTest()
	{
		var result1 = typeof(TestType).GetAttribute<XmlRootAttribute>();

		Assert.IsNotNull(result1);

		var result2 = typeof(TestType).GetAttribute<XmlIgnoreAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the attribute method GetGenericMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetGenericMethodsTest()
	{
		var result = typeof(TestType).GetAllGenericMethods();

		Assert.IsTrue(result.FastCount() == 1);
	}

	[TestMethod]
	public void GetImplementedInterfacesTest()
	{
		var table = new DataTable();

		var result = table.GetImplementedInterfaces("IComponent");

		Assert.IsTrue(result.FastCount() == 1);

		result = table.GetImplementedInterfaces("IFakeInterface");

		Assert.IsTrue(result.FastCount() == 0);

		result = table.GetImplementedInterfaces("IComponent", "IDisposable");

		Assert.IsTrue(result.FastCount() == 2);

	}

	[TestMethod]
	public void GetMaxTest()
	{
		var cord1 = RandomData.GenerateCoordinate<Coordinate>();
		var cord2 = RandomData.GenerateCoordinate<Coordinate>();

		var result = cord1.Max(cord2);

		Assert.IsNotNull(result);
	}

	/// <summary>
	/// Defines the attribute method GetPropertiesTest.
	/// </summary>
	[TestMethod]
	public void GetPropertiesTest()
	{
		var result = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).GetAllProperties();

		Assert.IsTrue(result.FastCount() >= 10);
	}

	/// <summary>
	/// Defines the attribute method GetPublicMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetPublicMethodsTest()
	{
		var result = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).GetAllPublicMethods();

		Assert.IsTrue(result.FastCount() >= 30);
	}

	/// <summary>
	/// Defines the attribute method GetStaticMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetStaticMethodsTest()
	{
		var result = typeof(TestType).GetAllStaticMethods();

		Assert.IsTrue(result.FastCount() == 1);
	}

	/// <summary>
	/// Defines the attribute method GetTypeMembersWithGivenAttributeTest.
	/// </summary>
	[TestMethod]
	public void GetTypeMembersWithGivenAttributeTest()
	{
		var members = typeof(FastLogger).GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
		var memAttrib = members.Where(member => member.GetCustomAttribute<InformationAttribute>() != null);


		var result1 = typeof(FastLogger).GetTypeMembersWithAttribute<InformationAttribute>();

		Assert.IsTrue(result1.FastCount() > 0);

		var result2 = typeof(TestType).GetTypeMembersWithAttribute<XmlAnyAttributeAttribute>();

		Assert.IsTrue(result2.FastCount() == 0);
	}

	[TestMethod]
	public void GetTypeOfTypeTest()
	{
		var refPerson = new Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>();

		var result = refPerson.GetTypeOfType();

		Assert.IsTrue(result == TypeExtensions.TypeOfType.Reference);

		var valPerson = new Tester.Models.ValueTypes.Person<Tester.Models.ValueTypes.Address>();

		result = valPerson.GetTypeOfType();

		Assert.IsTrue(result == TypeExtensions.TypeOfType.Value);

		var recordPerson = new PersonRecord("dotnetdave@live.com", "100");

		result = recordPerson.GetTypeOfType();

		Assert.IsTrue(result == TypeExtensions.TypeOfType.Record);
	}

	[TestMethod]
	public void HasBaseClassTest()
	{
		var result1 = typeof(DataTable).HasBaseClass(typeof(MarshalByValueComponent));

		Assert.IsTrue(result1);

		var result2 = typeof(DataTable).HasBaseClass(typeof(ValueType));

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void HasParameterlessConstructorTest()
	{
		var result = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).HasParameterlessConstructor();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEnumerableTest()
	{
		var result1 = typeof(BitArray).IsEnumerable();

		Assert.IsTrue(result1);

		var result2 = typeof(DataTable).IsEnumerable();

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void IsNullableTest()
	{
		var result1 = typeof(Foo).GetProperty("Bar").PropertyType.IsNullable();

		Assert.IsTrue(result1);

		var result2 = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).GetProperty("FirstName").PropertyType.IsNullable();

		Assert.IsFalse(result2);
	}

	/// <summary>
	/// Defines the attribute method IsNumericTest.
	/// </summary>
	[TestMethod]
	public void IsNumericTest()
	{
		var people = RandomData.GeneratePersonRefCollection<Tester.Models.RefTypes.Address>(10).AsEnumerable();
		var person = RandomData.GeneratePersonRef<Tester.Models.RefTypes.Address>();

		Assert.IsTrue(people.GetType().IsEnumerable());
		Assert.IsFalse(person.GetType().IsEnumerable());
	}

	[TestMethod]
	public void IsStaticTest()
	{
		var result1 = typeof(InMemoryCache).GetProperty("Instance").IsStatic();
		Assert.IsTrue(result1);

		var result2 = typeof(Tester.Models.RefTypes.Person<Tester.Models.RefTypes.Address>).GetProperty("FirstName").IsStatic();
		Assert.IsFalse(result2);
	}

}
