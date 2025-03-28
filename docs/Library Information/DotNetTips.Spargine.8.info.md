# DotNetTips.Spargine.8 - 2025.8.3.19

## DotNetTips.Spargine.Extensions.RegistryExtensions

* **Status:** Needs Documentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Microsoft.Win32.RegistryKey GetSubKey(Microsoft.Win32.RegistryKey key, System.String name)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** GetSubKey
* **Modified By:** David McCarter

### T GetValue(Microsoft.Win32.RegistryKey key, System.String name)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** GetValue
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.DirectoryHelper

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineDirectoryHelper

### System.String AppDataFolder()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** AppDataFolder
* **Modified By:** David McCarter

### System.Boolean CheckPermission(System.IO.DirectoryInfo directory, System.Security.AccessControl.FileSystemRights permission)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2020
* **Description:** CheckPermission
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### System.Void CopyDirectory(System.IO.DirectoryInfo source, System.IO.DirectoryInfo destination, System.Boolean overwrite)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** CopyDirectory
* **Modified By:** David McCarter

### System.Void DeleteDirectory(System.IO.DirectoryInfo path, System.Byte retries, System.Boolean recursive)

* **Status:** Updated
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** DeleteDirectory
* **Modified By:** David McCarter

### System.Collections.Generic.IAsyncEnumerable<System.Collections.Generic.IEnumerable<System.IO.FileInfo>> LoadFilesAsync(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> directories, System.String searchPattern, System.IO.SearchOption searchOption, System.Threading.CancellationToken cancellationToken)

* **Status:** Updated
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** LoadFilesAsync
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.IO.OneDriveFolder> LoadOneDriveFolders()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** LoadOneDriveFolders
* **Modified By:** David McCarter

### System.Void MoveDirectory(System.IO.DirectoryInfo source, System.IO.DirectoryInfo destination, System.Byte retries)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Check Performance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** MoveDirectory
* **Modified By:** David McCarter

### System.Void RemoveAttributes(System.IO.DirectoryInfo path, System.IO.FileAttributes& attributesToRemove)

* **Status:** New
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** RemoveAttributes

### System.Boolean SafeDirectorySearch(System.IO.DirectoryInfo path, System.IO.SearchOption searchOption, System.String[] searchPatterns)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/14/2021
* **Description:** SafeDirectorySearch
* **Documentation:** https://bit.ly/SpargineSep2022
* **Modified By:** David McCarter

### System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> SafeDirectorySearch(System.IO.DirectoryInfo path, System.String searchPattern, System.IO.SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeDirectorySearch
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.IO.FileInfo> SafeFileSearch(System.IO.DirectoryInfo path, System.String searchPattern, System.IO.SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeFileSearch
* **Documentation:** http://bit.ly/SpargineMarch2021
* **Modified By:** David McCarter

### System.Collections.Generic.IEnumerable<System.IO.FileInfo> SafeFileSearch(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> directories, System.String searchPattern, System.IO.SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeFileSearch
* **Modified By:** David McCarter

### System.Void SetFileAttributesToNormal(System.IO.DirectoryInfo path)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SetFileAttributesToNormal
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.DriveHelper

* **Status:** Needs Documentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### System.String GetDriveFormat(System.String drive)

* **Status:** New
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetDriveFormat

### System.Int64 GetDriveFreeSpace(System.String drive)

* **Status:** New
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetDriveFreeSpace

### System.String GetDriveLabel(System.String drive)

* **Status:** New
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetDriveLabel

### System.String GetDriveSerialNumber(System.String drive)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetDriveSerialNumber
* **Documentation:** https://dotnettips.wordpress.com/2007/12/14/finding-a-drives-serial-number/
* **Modified By:** David McCarter

### System.Int64 GetDriveTotalSize(System.String drive)

* **Status:** New
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/10/2023
* **Description:** GetDriveTotalSize
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> GetFixedDrives()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetFixedDrives
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> GetRemovableDrives()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetRemovableDrives
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.FileHelper

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Description:** FileHelper
* **Documentation:** https://bit.ly/SpargineFileHelper

### System.Void AddAttributes(System.IO.FileInfo file, System.IO.FileAttributes& attributesToAdd)

* **Status:** New
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** AddAttributes

### System.Void AddReadOnlyAttribute(System.IO.FileInfo file)

* **Status:** New
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** AddReadOnlyAttribute

### System.Boolean CheckPermission(System.IO.FileInfo file, System.Security.AccessControl.FileSystemRights permission)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2020
* **Description:** CheckPermission
* **Modified By:** David McCarter

### System.Int64 CopyFile(System.IO.FileInfo file, System.IO.DirectoryInfo destination)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** CopyFile

### System.Boolean CopyFile(System.IO.FileInfo file, System.IO.DirectoryInfo destination, DotNetTips.Spargine.IO.FileHelper+CopyProgressRoutine progressCallback)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** CopyFile

### System.Threading.Tasks.Task<System.Int64> CopyFileAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** CopyFileAsync

### DotNetTips.Spargine.Core.SimpleResult<System.Collections.ObjectModel.ReadOnlyCollection<System.String>> DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection<System.String> files, System.Boolean stopOnFirstError)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** DeleteFiles

### System.Threading.Tasks.Task DownloadFileFromWebAndUnzipAsync(System.Uri remoteUri, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Description:** DownloadFileFromWebAndUnzipAsync

### System.Threading.Tasks.Task<DotNetTips.Spargine.Core.SimpleResult<System.Int32>> DownloadFileFromWebAsync(System.Uri remoteUri, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Updated
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Description:** DownloadFileFromWebAsync

### System.Boolean FileHasInvalidChars(System.IO.FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** FileHasInvalidChars
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidFileNameChars { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Boolean MoveFile(System.IO.FileInfo file, System.IO.FileInfo destinationFile, System.Boolean replaceExisting, System.Int32 retryCount)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** MoveFile

### System.Void RemoveAttributes(System.IO.FileInfo file, System.IO.FileAttributes& attributesToRemove)

* **Status:** New
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** RemoveAttributes

### System.Void RemoveReadOnlyAttribute(System.IO.FileInfo file)

* **Status:** New
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** RemoveReadOnlyAttribute

### System.Threading.Tasks.Task UnGZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Description:** UnGZipAsync

### System.Threading.Tasks.Task UnGZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Boolean deleteGZipFile, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Description:** UnGZipAsync

### System.Threading.Tasks.Task UnWinZipAsync(System.String zipPath, System.String expandedDirectoryPath, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Description:** UnWinZipAsync

### System.Threading.Tasks.Task UnZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Description:** UnZipAsync

### System.Threading.Tasks.Task UnZipAsync(System.IO.FileInfo file, System.IO.DirectoryInfo destination, System.Boolean deleteZipFile, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** None
* **Description:** UnZipAsync

*****
## DotNetTips.Spargine.IO.FileProcessor

* **Status:** Update Documentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** ADD URL

### System.Int32 CopyFiles(System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& files, System.IO.DirectoryInfo destination)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** CopyFiles
* **Modified By:** David McCarter

### System.Int32 DeleteFiles(System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& files)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** DeleteFiles
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.Int32 DeleteFolders(System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]& folders, System.Boolean& recursive)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** DeleteFolders
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.PathHelper

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Description:** PathHelper
* **Documentation:** https://bit.ly/SparginePathHelper

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String[] paths)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2, System.String path3)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter

### System.IO.DirectoryInfo CombinePaths(System.Boolean createIfNotExists, System.String path1, System.String path2, System.String path3, System.String path4)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Modified By:** David McCarter

### System.String EnsureTrailingSlash(System.String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Boolean HasInvalidFilterChars(System.String filter)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidFilterChars()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> InvalidPathNameChars()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Boolean PathContainsWildcard(System.String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** PathContainsWildcard
* **Modified By:** David McCarter

### System.Boolean PathHasInvalidChars(System.String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### System.Collections.ObjectModel.ReadOnlyCollection<System.Char> PathSeparators { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.IO.TempFileManager

* **Status:** Needs Documentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 8/4/2024
* **Description:** TempFileManager
* **Documentation:** ADD URL
* **Modified By:** David McCarter

### System.String CreateFile()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** CreateFile

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> CreateFiles(System.Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** CreateFiles

### System.Void DeleteAllFiles()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** DeleteAllFiles

### System.Void DeleteFile(System.String fileName)

* **Status:** New
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** DeleteFile

### System.Void Dispose()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Not Required
* **Description:** Dispose

### System.Collections.Generic.IReadOnlyCollection<System.String> GetManagedFiles()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetManagedFiles

### System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()

* **Status:** Available
* **Optimization Status:** Not Required
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** DisposeAsync

*****
## DotNetTips.Spargine.Net.Http.HttpClientHelper

* **Status:** Needs Documentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetHttpResponseAsync(System.Uri url, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetHttpResponseAsync

### System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri url, System.Threading.CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Description:** GetHttpResponseAsync

*****
## DotNetTips.Spargine.Net.Sockets.SocketsHelper

* **Status:** Needs Documentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

*****
## DotNetTips.Spargine.Services

* **Status:** Needs Documentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### System.Collections.ObjectModel.ReadOnlyCollection<System.String> AllServices()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** AllServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.Boolean IsProcessRunning(System.String processName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### System.Void KillProcess(System.String processName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### System.ServiceProcess.ServiceController LoadService(System.String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** LoadService
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.Boolean ServiceExists(System.String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** ServiceExists
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.ServiceProcess.ServiceControllerStatus ServiceStatus(System.String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** ServiceStatus
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### DotNetTips.Spargine.ServiceActionResult StartService(System.String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartService
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.Void StartServices(System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.ServiceAction, DotNetTips.Spargine.8, Version=2025.8.3.19, Culture=neutral, PublicKeyToken=null]]& requests)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.Void StartStopServices(System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.ServiceAction, DotNetTips.Spargine.8, Version=2025.8.3.19, Culture=neutral, PublicKeyToken=null]]& requests)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartStopServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### DotNetTips.Spargine.ServiceActionResult StopService(System.String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StopService
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### System.Void StopServices(System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.ServiceAction, DotNetTips.Spargine.8, Version=2025.8.3.19, Culture=neutral, PublicKeyToken=null]]& requests)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StopServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

*****
## DotNetTips.Spargine.Win32.RegistryHelper

* **Status:** Needs Documentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Microsoft.Win32.RegistryKey GetRegistryKey(System.String keyName, Microsoft.Win32.RegistryHive registryKeyType)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Not Required
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/10/2020
* **Description:** GetRegistryKey
* **Modified By:** David McCarter

*****
**Generated by Spargine - dotNetTips.com on 3/28/2025 4:17:33 PM UTC**
