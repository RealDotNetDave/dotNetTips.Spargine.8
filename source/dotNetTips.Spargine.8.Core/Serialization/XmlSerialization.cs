// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2025
// ***********************************************************************
// <copyright file="XmlSerialization.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Facilitates seamless serialization and deserialization of strings to
// and from the XML format.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// Provides functionality for serializing objects to XML strings and deserializing XML strings to objects.
/// This class contains static methods for both serialization to, and deserialization from, XML format.
/// It supports operations on both strings and files, offering a flexible API for working with XML data in .NET applications.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class XmlSerialization
{
	/// <summary>
	/// Deserializes the specified XML string into an object of the specified type.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="xml">The XML string to deserialize.</param>
	/// <returns>An instance of the specified type containing the deserialized data.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the xml parameter is null or empty.</exception>
	[Information(nameof(Deserialize), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TResult Deserialize<TResult>([NotNull][StringSyntax(StringSyntaxAttribute.Xml)] string xml)
		where TResult : new()
	{
		xml = xml.ArgumentNotNullOrEmpty();

		using (var sr = new StringReader(xml))
		{
			using (var xmlReader = XmlReader.Create(sr))
			{
				return (TResult)new XmlSerializer(typeof(TResult)).Deserialize(xmlReader);
			}
		}
	}

	/// <summary>
	/// Deserializes an XML file into an object of the specified type.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="file">The file containing the XML to deserialize.</param>
	/// <returns>An instance of the specified type containing the deserialized data from the file.</returns>
	/// <exception cref="FileNotFoundException">Thrown if the specified file does not exist.</exception>
	[Information(nameof(DeserializeFromFile), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TResult DeserializeFromFile<TResult>([NotNull] FileInfo file) where TResult : new()
	{
		file = file.ArgumentNotNull();

		return file.Exists is false
			? throw ExceptionThrower.CreateFileNotFoundException(Resources.FileNotFoundCannotDeserializeFromXML, file.FullName)
			: Deserialize<TResult>(File.ReadAllText(file.FullName));
	}

	/// <summary>
	/// Serializes the specified object to an XML string.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <returns>A string containing the XML representation of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the obj parameter is null.</exception>
	[Information(nameof(Serialize), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string Serialize([NotNull] object obj)
	{
		obj = obj.ArgumentNotNull();

		using (var writer = new StringWriter())
		{
			using (var xmlWriter = XmlWriter.Create(writer))
			{
				var serializer = new XmlSerializer(obj.GetType());

				serializer.Serialize(xmlWriter, obj);

				return writer.ToString();
			}
		}
	}

	/// <summary>
	/// Serializes the specified object to an XML file.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="file">The file to write the XML to.</param>
	/// <exception cref="ArgumentNullException">Thrown if any parameter is null.</exception>
	[Information(nameof(SerializeToFile), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void SerializeToFile([NotNull] object obj, [NotNull] FileInfo file)
	{
		obj = obj.ArgumentNotNull();
		file = file.ArgumentNotNull();

		if (file.Exists)
		{
			file.Delete();
		}

		var directoryName = file.DirectoryName;

		if (Directory.Exists(directoryName) is false)
		{
			_ = Directory.CreateDirectory(directoryName);
		}

		using (var writer = new StreamWriter(file.FullName))
		{
			using (var xmlWriter = XmlWriter.Create(writer))
			{
				new XmlSerializer(obj.GetType()).Serialize(xmlWriter, obj);
			}
		}
	}

	/// <summary>
	/// Converts a string to an XDocument securely.
	/// </summary>
	/// <param name="input">The input string to convert.</param>
	/// <returns>An XDocument instance representing the XML content of the input string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input parameter is null or empty.</exception>
	[Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static XDocument StringToXDocument([NotNull] string input) => StringToXDocument(
		input.ArgumentNotNullOrEmpty(),
		null);

	/// <summary>
	/// Converts a string to an XDocument securely, with an optional XML resolver.
	/// </summary>
	/// <param name="input">The input string to convert.</param>
	/// <param name="resolver">The XML resolver to use during conversion.</param>
	/// <returns>An XDocument instance representing the XML content of the input string.</returns>
	/// <remarks>Uses DtdProcessing.Prohibit to enhance security.</remarks>
	[Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static XDocument StringToXDocument([NotNull] string input, [AllowNull] XmlResolver resolver)
	{
		using (var stringReader = new StringReader(input.ArgumentNotNullOrEmpty()))
		{
			var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };

			using (var reader = XmlReader.Create(stringReader, options))
			{
				return XDocument.Load(reader);
			}
		}
	}
}
