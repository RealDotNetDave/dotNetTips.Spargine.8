// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-11-2023
// ***********************************************************************
// <copyright file="XmlSerialization.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// This class facilitates easy serialization and deserialization of
// strings to and from the XML format.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core.Properties;

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// XML Serialization helper methods.
/// </summary>
public static class XmlSerialization
{

	/// <summary>
	/// Deserialize the specified XML.
	/// </summary>
	/// <typeparam name="TResult">Type.</typeparam>
	/// <param name="xml">The XML.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">xml.</exception>
	[Information(nameof(Deserialize), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static TResult Deserialize<TResult>([NotNull] string xml) where TResult : class
	{
		using (var sr = new StringReader(xml.ArgumentNotNullOrEmpty(true)))
		{
			using (var xmlReader = XmlReader.Create(sr))
			{
				return (TResult)new XmlSerializer(typeof(TResult)).Deserialize(xmlReader);
			}
		}
	}

	/// <summary>
	/// De-serializes from XML file.
	/// </summary>
	/// <typeparam name="TResult">Type.</typeparam>
	/// <param name="file">File</param>
	/// <returns>T.</returns>
	/// <exception cref="FileNotFoundException"></exception>
	[Information(nameof(DeserializeFromFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static TResult DeserializeFromFile<TResult>([NotNull] FileInfo file) where TResult : class
	{
		file = file.ArgumentNotNull();

		return file.Exists is false
			? throw new FileNotFoundException(Resources.FileNotFoundCannotDeserializeFromXML, file.FullName)
			: Deserialize<TResult>(File.ReadAllText(file.FullName));
	}

	/// <summary>
	/// Serializes the specified obj to xml.
	/// </summary>
	/// <param name="obj">The obj.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentNullException">obj.</exception>
	[Information(nameof(Serialize), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static string Serialize([NotNull] object obj)
	{
		obj = obj.ArgumentNotNull();

		using (var writer = new StringWriter())
		{
			using (var xmlWriter = XmlWriter.Create(writer))
			{
				var type = obj.GetType();

				var serializer = new XmlSerializer(type);

				serializer.Serialize(xmlWriter, obj);

				return writer.ToString();
			}
		}

	}

	/// <summary>
	/// Serializes obj to XML file.
	/// </summary>
	/// <param name="obj">The obj.</param>
	/// <param name="file">File</param>
	[Information(nameof(SerializeToFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
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

		File.WriteAllText(file.FullName, Serialize(obj));
	}

	/// <summary>
	/// Securely convert string to XDocument.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>XDocument.</returns>
	[Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None)]
	public static XDocument StringToXDocument([NotNull] string input) => StringToXDocument(input.ArgumentNotNullOrEmpty(), null);

	/// <summary>
	/// Securely convert string to XDocument.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="resolver">The resolver.</param>
	/// <returns>XDocument.</returns>
	/// <remarks>Uses DtdProcessing.Prohibit.</remarks>
	[Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None)]
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