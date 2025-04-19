// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="GlobalSuppressions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Roslynator", "RCS1171:Simplify lazy initialization.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.GetHttpClient~System.Net.Http.HttpClient")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP014:Use a single instance of HttpClient", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.GetHttpClient~System.Net.Http.HttpClient")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.DriveHelper.GetDriveSerialNumber(System.String)~System.String")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Services.StartService(System.String)~DotNetTips.Spargine.ServiceActionResult")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Services.StopService(System.String)~DotNetTips.Spargine.ServiceActionResult")]
[assembly: SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.Services")]
[assembly: SuppressMessage("Design", "CA1028:Enum Storage should be Int32", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.IO.CopyProgressResult")]
[assembly: SuppressMessage("Design", "CA1028:Enum Storage should be Int32", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.IO.CopyFileMode")]
[assembly: SuppressMessage("Design", "CA1028:Enum Storage should be Int32", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.IO.CopyProgressCallbackReason")]
[assembly: SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder~System.String")]
[assembly: SuppressMessage("Style", "IDE0305:Simplify collection initialization", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection{System.String},System.Boolean)~DotNetTips.Spargine.Core.SimpleResult{System.Collections.ObjectModel.ReadOnlyCollection{System.String}}")]
[assembly: SuppressMessage("Async/await", "CRR0030:Redundant 'await'", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Net.Http.HttpClientHelper.GetHttpResponseAsync(System.Uri,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileProcessor.CopyFiles(System.Collections.Generic.IEnumerable{System.IO.FileInfo}@,System.IO.DirectoryInfo)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileProcessor.DeleteFiles(System.Collections.Generic.IEnumerable{System.IO.FileInfo}@)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileProcessor.DeleteFolders(System.Collections.Generic.IEnumerable{System.IO.DirectoryInfo}@,System.Boolean@)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.TempFileManager.GenerateRandomFile~System.String")]
