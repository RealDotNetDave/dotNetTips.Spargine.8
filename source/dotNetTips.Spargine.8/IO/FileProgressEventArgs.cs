// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2024
// ***********************************************************************
// <copyright file="FileProgressEventArgs.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Arguments for FileProcessor.cs</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


namespace DotNetTips.Spargine.IO;

/// <summary>
/// Represents the arguments for file progress events.
/// </summary>
/// <remarks>
/// This class provides data for events related to the progress of file operations, such as copying, moving, or deleting files.
/// </remarks>
/// <seealso cref="EventArgs" />
public sealed class FileProgressEventArgs : EventArgs
{
	//TODO: RENAME IN V10 SINCE THIS ISN'T ONLY FOR FILES.
	/// <summary>
	/// Initializes a new instance of the <see cref="FileProgressEventArgs" /> class.
	/// </summary>
	public FileProgressEventArgs() => this.Message = string.Empty;

	/// <summary>
	/// Gets or sets the file progress message.
	/// </summary>
	/// <value>The message indicating the progress of the file operation.</value>
	public string Message
	{
		get; internal set;
	}

	/// <summary>
	/// Gets or sets the full path and file name.
	/// </summary>
	/// <value>The full name of the file including its path.</value>
	public string Name
	{
		get; internal set;
	}

	/// <summary>
	/// Gets or sets the progress state.
	/// </summary>
	/// <value>The state of the progress.</value>
	/// <seealso cref="FileProgressState"/>
	public FileProgressState ProgressState
	{
		get; internal set;
	}

	/// <summary>
	/// Gets or sets the file size.
	/// </summary>
	/// <value>The size of the file in bytes.</value>
	public long Size
	{
		get; internal set;
	}

	/// <summary>
	/// Gets or sets the speed in milliseconds.
	/// </summary>
	/// <value>The speed of the file operation in milliseconds.</value>
	public double SpeedInMilliseconds
	{
		get; internal set;
	}

}
