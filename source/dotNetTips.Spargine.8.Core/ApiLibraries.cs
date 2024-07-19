// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="ApiLibraries.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>List of common Windows API libraries.</summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Contains constants for commonly used Windows API library names. This class provides a centralized repository of DLL names used in P/Invoke method declarations.
/// </summary>
/// <remarks>
/// The constants in this class represent the file names of various Windows API libraries. These constants are used to specify the DLL name in P/Invoke signatures, ensuring type safety and reducing the likelihood of runtime errors due to misspelled library names.
/// </remarks>
[Information(nameof(ApiLibraries), "David McCarter", "3/24/2023", Status = Status.Available)]
public static class ApiLibraries
{

	/// <summary>
	/// ADs Router Layer DLL
	/// </summary>
	public const string Activeds = "activeds.dll";

	/// <summary>
	/// Advanced Windows 32 Base API
	/// </summary>
	public const string Advapi32 = "advapi32.dll";

	/// <summary>
	/// Authorization Framework API
	/// </summary>
	public const string Authz = "authz.dll";

	/// <summary>
	/// Windows Cryptographic Primitives Library
	/// </summary>
	public const string BCrypt = "BCrypt.dll";

	/// <summary>
	/// Native System.IO.Compression DLL
	/// </summary>
	public const string CompressionNative = "System.IO.Compression.Native";

	/// <summary>
	/// Credential Manager User Interface
	/// </summary>
	public const string Credui = "credui.dll";

	/// <summary>
	/// Windows Crypto API
	/// </summary>
	public const string Crypt32 = "crypt32.dll";

	/// <summary>
	/// Microsoft Trust UI Provider
	/// </summary>
	public const string CryptUI = "cryptui.dll";

	/// <summary>
	/// DNS Client API DLL
	/// </summary>
	public const string Dnsapi = "dnsapi.dll";

	/// <summary>
	/// DS Setup Client DLL
	/// </summary>
	public const string Dsrole = "dsrole.dll";

	/// <summary>
	/// Windows Graphics Device Interface
	/// </summary>
	public const string Gdi32 = "gdi32.dll";

	/// <summary>
	/// The Globalization Native
	/// </summary>
	public const string GlobalizationNative = "System.Globalization.Native";

	/// <summary>
	/// Hosting Policy
	/// </summary>
	public const string HostPolicy = "hostpolicy.dll";

	/// <summary>
	/// HTTP Protocol Stack API
	/// </summary>
	public const string HttpApi = "httpapi.dll";

	/// <summary>
	/// Windows IP Helper API
	/// </summary>
	public const string IpHlpApi = "iphlpapi.dll";

	/// <summary>
	/// Windows 32-bit Dynamic Link Library
	/// </summary>
	public const string Kernel32 = "kernel32.dll";

	/// <summary>
	/// Net Logon Client DLL
	/// </summary>
	public const string Logoncli = "logoncli.dll";

	/// <summary>
	/// Microsoft implementation of the IETF QUIC protocol
	/// </summary>
	public const string MsQuic = "msquic.dll";

	/// <summary>
	/// Microsoft Windows Sockets Network – Dynamic Link Library
	/// </summary>
	public const string Mswsock = "mswsock.dll";

	/// <summary>
	/// Microsoft Windows Encryption API Library
	/// </summary>
	public const string NCrypt = "ncrypt.dll";

	/// <summary>
	/// Windows NET API
	/// </summary>
	public const string Netapi32 = "netapi32.dll";

	/// <summary>
	/// Net Win32 API Helpers
	/// </summary>
	public const string Netutils = "netutils.dll";

	/// <summary>
	/// NT System Functions
	/// </summary>
	public const string NtDll = "ntdll.dll";

	/// <summary>
	/// ODBC Database Query Standard.
	/// </summary>
	public const string Odbc32 = "odbc32.dll";

	/// <summary>
	/// Microsoft OLE for Windows
	/// </summary>
	public const string Ole32 = "ole32.dll";

	/// <summary>
	/// Microsoft OLE for Windows
	/// </summary>
	public const string OleAut32 = "oleaut32.dll";

	/// <summary>
	/// Performance Data Helper DLL
	/// </summary>
	public const string Pdh = "pdh.dll";

	/// <summary>
	/// Security Support Provider Interface
	/// </summary>
	public const string Secur32 = "secur32.dll";

	/// <summary>
	/// Windows Shell API
	/// </summary>
	public const string Shell32 = "shell32.dll";

	/// <summary>
	/// Security Support Provider Interface
	/// </summary>
	public const string SspiCli = "sspicli.dll";

	/// <summary>
	/// Microsoft C Runtime Library
	/// </summary>
	public const string Ucrtbase = "ucrtbase.dll";

	/// <summary>
	/// Windows User API Client DLL
	/// </summary>
	public const string User32 = "user32.dll";

	/// <summary>
	/// Version Checking and File Installation Libraries
	/// </summary>
	public const string Version = "version.dll";

	/// <summary>
	/// Web Socket API
	/// </summary>
	public const string WebSocket = "websocket.dll";

	/// <summary>
	/// Eventing Consumption and Configuration API
	/// </summary>
	public const string Wevtapi = "wevtapi.dll";

	/// <summary>
	/// Windows HTTP Services
	/// </summary>
	public const string WinHttp = "winhttp.dll";

	/// <summary>
	/// MCI API DLL
	/// </summary>
	public const string WinMM = "winmm.dll";

	/// <summary>
	/// Workstation Service Client DLL
	/// </summary>
	public const string Wkscli = "wkscli.dll";

	/// <summary>
	/// Win32 LDAP API DLL
	/// </summary>
	public const string Wldap32 = "wldap32.dll";

	/// <summary>
	/// Windows Socket 2.0 32-Bit DLL
	/// </summary>
	public const string Ws232 = "ws2_32.dll";

	/// <summary>
	/// Windows Remote Desktop Session Host Server SDK APIs
	/// </summary>
	public const string Wtsapi32 = "wtsapi32.dll";

}
