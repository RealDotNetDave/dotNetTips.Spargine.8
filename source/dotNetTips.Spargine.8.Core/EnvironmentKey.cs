// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 10-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2024
// ***********************************************************************
// <copyright file="EnvironmentKey.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Enumeration for common environment keys.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Enum EnvironmentKey represents common environment variable keys.
/// </summary>
[Information(Status = Status.Available)]
public enum EnvironmentKey
{
	/// <summary>
	/// The ASP.NET Core Environment variable.
	/// </summary>
	ASPNETCORE_ENVIRONMENT,

	/// <summary>
	/// The environment variable for all users' profile path.
	/// </summary>
	ALLUSERSPROFILE,

	/// <summary>
	/// The environment variable for the application data directory.
	/// </summary>
	APPDATA,

	/// <summary>
	/// The environment variable for the client name in a remote session.
	/// </summary>
	CLIENTNAME,

	/// <summary>
	/// The COM+ environment variable to disable GUI in the shim for side-by-side execution.
	/// </summary>
	COMPLUS_NoGuiFromShim,

	/// <summary>
	/// The environment variable for the common program files directory.
	/// </summary>
	CommonProgramFiles,

	/// <summary>
	/// The environment variable for the common program files directory on Windows x64.
	/// </summary>
	CommonProgramW6432,

	/// <summary>
	/// The environment variable for the computer name.
	/// </summary>
	COMPUTERNAME,

	/// <summary>
	/// The environment variable for the command-line interpreter executable path.
	/// </summary>
	ComSpec,

	/// <summary>
	/// The environment variable for driver data.
	/// </summary>
	DriverData,

	/// <summary>
	/// The environment variable to enable XAML diagnostics source information.
	/// </summary>
	ENABLE_XAML_DIAGNOSTICS_SOURCE_INFO,

	/// <summary>
	/// The environment variable for the FPS browser application profile string.
	/// </summary>
	FPS_BROWSER_APP_PROFILE_STRING,

	/// <summary>
	/// The environment variable for the FPS browser user profile string.
	/// </summary>
	FPS_BROWSER_USER_PROFILE_STRING,

	/// <summary>
	/// The environment variable for the F# installation directory.
	/// </summary>
	FSHARPINSTALLDIR,

	/// <summary>
	/// The environment variable for the home drive.
	/// </summary>
	HOMEDRIVE,

	/// <summary>
	/// The environment variable for the home path.
	/// </summary>
	HOMEPATH,

	/// <summary>
	/// The environment variable for the IIS binaries directory.
	/// </summary>
	IIS_BIN,

	/// <summary>
	/// The environment variable for the IIS drive.
	/// </summary>
	IIS_DRIVE,

	/// <summary>
	/// The environment variable for the IIS sites home directory.
	/// </summary>
	IIS_SITES_HOME,

	/// <summary>
	/// The environment variable for the IIS user home directory.
	/// </summary>
	IIS_USER_HOME,

	/// <summary>
	/// The environment variable for the local application data directory.
	/// </summary>
	LOCALAPPDATA,

	/// <summary>
	/// The environment variable for the logon server.
	/// </summary>
	LOGONSERVER,

	/// <summary>
	/// The environment variable to make MSBuild load Microsoft targets in read-only mode.
	/// </summary>
	MSBuildLoadMicrosoftTargetsReadOnly,

	/// <summary>
	/// The environment variable for the MSMPI binaries directory.
	/// </summary>
	MSMPI_BIN,

	/// <summary>
	/// The environment variable for the number of processors.
	/// </summary>
	NUMBER_OF_PROCESSORS,

	/// <summary>
	/// The environment variable for the path to OneDrive.
	/// </summary>
	OneDrive,

	/// <summary>
	/// The environment variable for the path to OneDrive for Business.
	/// </summary>
	OneDriveCommercial,

	/// <summary>
	/// The environment variable for the path to OneDrive for Consumer.
	/// </summary>
	OneDriveConsumer,

	/// <summary>
	/// The environment variable for the operating system name.
	/// </summary>
	OS,

	/// <summary>
	/// The environment variable for the system path.
	/// </summary>
	Path,

	/// <summary>
	/// The environment variable for the executable file extensions.
	/// </summary>
	PATHEXT,

	/// <summary>
	/// The environment variable for the PKG definition application configuration file.
	/// </summary>
	PkgDefApplicationConfigFile,

	/// <summary>
	/// The environment variable for the processor architecture.
	/// </summary>
	PROCESSOR_ARCHITECTURE,

	/// <summary>
	/// The environment variable for the processor identifier.
	/// </summary>
	PROCESSOR_IDENTIFIER,

	/// <summary>
	/// The environment variable for the processor level.
	/// </summary>
	PROCESSOR_LEVEL,

	/// <summary>
	/// The environment variable for the processor revision.
	/// </summary>
	PROCESSOR_REVISION,

	/// <summary>
	/// The environment variable for the program data directory.
	/// </summary>
	ProgramData,

	/// <summary>
	/// The environment variable for the program files directory.
	/// </summary>
	ProgramFiles,

	/// <summary>
	/// The environment variable for the program files directory on Windows x64.
	/// </summary>
	ProgramW6432,

	/// <summary>
	/// The environment variable for the PowerShell module path.
	/// </summary>
	PSModulePath,

	/// <summary>
	/// The environment variable for the public directory.
	/// </summary>
	PUBLIC,

	/// <summary>
	/// The environment variable for the Service Hub log session key.
	/// </summary>
	ServiceHubLogSessionKey,

	/// <summary>
	/// The environment variable for the session name.
	/// </summary>
	SESSIONNAME,

	/// <summary>
	/// The environment variable for the system drive.
	/// </summary>
	SystemDrive,

	/// <summary>
	/// The environment variable for the system root directory.
	/// </summary>
	SystemRoot,

	/// <summary>
	/// The environment variable for the temporary files directory.
	/// </summary>
	TEMP,

	/// <summary>
	/// The environment variable for the threaded wait dialog DPI context.
	/// </summary>
	ThreadedWaitDialogDpiContext,

	/// <summary>
	/// The environment variable for the temporary files directory.
	/// </summary>
	TMP,

	/// <summary>
	/// The environment variable for the user domain.
	/// </summary>
	USERDOMAIN,

	/// <summary>
	/// The environment variable for the user domain roaming profile.
	/// </summary>
	USERDOMAIN_ROAMINGPROFILE,

	/// <summary>
	/// The environment variable for the user name.
	/// </summary>
	USERNAME,

	/// <summary>
	/// The environment variable for the user profile directory.
	/// </summary>
	USERPROFILE,

	/// <summary>
	/// The environment variable for the Visual Studio directory.
	/// </summary>
	VisualStudioDir,

	/// <summary>
	/// The environment variable for the Visual Studio edition.
	/// </summary>
	VisualStudioEdition,

	/// <summary>
	/// The environment variable for the Visual Studio version.
	/// </summary>
	VisualStudioVersion,

	/// <summary>
	/// The environment variable for the Visual Studio App ID directory.
	/// </summary>
	VSAPPIDDIR,

	/// <summary>
	/// The environment variable for the Visual Studio App ID name.
	/// </summary>
	VSAPPIDNAME,

	/// <summary>
	/// The environment variable for the Visual Studio language.
	/// </summary>
	VSLANG,

	/// <summary>
	/// The environment variable for the Visual Studio logger unique ID.
	/// </summary>
	VSLOGGER_UNIQUEID,

	/// <summary>
	/// The environment variable for the Visual Studio SKU edition.
	/// </summary>
	VSSKUEDITION,

	/// <summary>
	/// The environment variable for the VTune Amplifier 2019 directory.
	/// </summary>
	VTUNE_AMPLIFIER_2019_DIR,

	/// <summary>
	/// The environment variable for the Windows directory.
	/// </summary>
	windir
}
