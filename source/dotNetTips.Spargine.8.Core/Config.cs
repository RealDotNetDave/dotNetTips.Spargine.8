// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="Config.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Adaptable type designed to simplify the creation of custom
// configuration objects, with a focus on easy disk saving in
// applications.
// </summary>
// ***********************************************************************
using System.Xml.Serialization;
using DotNetTips.Spargine.Core.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a generic configuration management class that simplifies the creation, loading, and saving of configuration objects to disk.
/// This class is designed to be adaptable for various types of configuration needs.
/// </summary>
/// <typeparam name="T">The type of the configuration object.</typeparam>
[Serializable]
[Information(Status = Status.NeedsDocumentation)]
public class Config<T> where T : class, new()
{

	/// <summary>
	/// The singleton instance of the configuration object.
	/// </summary>
	private static T _instance = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="Config{T}"/> class.
	/// Sets up default paths for the configuration file based on application information.
	/// </summary>
	protected Config()
	{
		var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		this.ConfigFolderName = Path.Combine(localAppData, App.AppInfo.Company);
		this.ConfigFileName = Path.Combine(this.ConfigFolderName, $"{App.AppInfo.Product}.config");
	}

	/// <summary>
	/// Loads the configuration from the disk if it exists.
	/// </summary>
	/// <returns><c>true</c> if the configuration was successfully loaded; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method attempts to deserialize the configuration object from a file specified by <see cref="ConfigFileName"/>.
	/// If the file does not exist, the method returns <c>false</c>.
	/// </remarks>
	public virtual bool Load()
	{
		if (File.Exists(this.ConfigFileName))
		{
			_instance = XmlSerialization.DeserializeFromFile<T>(new FileInfo(this.ConfigFileName));
			return true;
		}
		return false;
	}

	/// <summary>
	/// Saves the current instance of the configuration to the disk.
	/// </summary>
	/// <returns><c>true</c> if the configuration was successfully saved; otherwise, <c>false</c>.</returns>
	public virtual bool Save()
	{
		if (File.Exists(this.ConfigFileName))
		{
			File.Delete(this.ConfigFileName);
		}
		XmlSerialization.SerializeToFile(this.Instance, new FileInfo(this.ConfigFileName));
		return true;
	}

	/// <summary>
	/// Gets the full path of the configuration file.
	/// </summary>
	/// <value>The full path of the configuration file.</value>
	[XmlIgnore]
	public string ConfigFileName { get; }

	/// <summary>
	/// Gets the full path of the configuration folder.
	/// </summary>
	/// <value>The full path of the configuration folder.</value>
	[XmlIgnore]
	public string ConfigFolderName { get; }

	/// <summary>
	/// Gets the singleton instance of the configuration object.
	/// </summary>
	/// <value>The instance of the configuration object.</value>
	[XmlIgnore]
	public T Instance => _instance;

}
