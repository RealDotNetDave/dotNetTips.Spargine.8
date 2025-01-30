# DotNetTips.Spargine.8 - 2025.8.1.30

## Services

### ReadOnlyCollection<String> AllServices()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** AllServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### Boolean IsProcessRunning(String processName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Void KillProcess(String processName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### ServiceController LoadService(String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** LoadService
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### Boolean ServiceExists(String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** ServiceExists
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### ServiceControllerStatus ServiceStatus(String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** ServiceStatus
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### ServiceActionResult StartService(String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartService
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### Void StartServices(IEnumerable<ServiceAction> requests)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### Void StartStopServices(IEnumerable<ServiceAction> requests)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StartStopServices
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### ServiceActionResult StopService(String serviceName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2016
* **Description:** StopService
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### Void StopServices(IEnumerable<ServiceAction> requests)

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
## RegistryHelper

### RegistryKey GetRegistryKey(String keyName, RegistryHive registryKeyType)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/10/2020
* **Description:** GetRegistryKey
* **Modified By:** David McCarter

*****
## HttpClientHelper

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Task<HttpResponseMessage> GetHttpResponseAsync(Uri url, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetHttpResponseAsync

### Task<Stream> GetStreamAsync(Uri url, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetHttpResponseAsync

*****
## DirectoryHelper

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### String AppDataFolder()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** AppDataFolder
* **Modified By:** David McCarter

### Boolean CheckPermission(DirectoryInfo directory, FileSystemRights permission)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2020
* **Description:** CheckPermission
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Void CopyDirectory(DirectoryInfo source, DirectoryInfo destination, Boolean overwrite)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** CopyDirectory
* **Modified By:** David McCarter

### Void DeleteDirectory(DirectoryInfo path, Int32 retries)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** DeleteDirectory
* **Modified By:** David McCarter

### IAsyncEnumerable<IEnumerable<FileInfo>> LoadFilesAsync(IEnumerable<DirectoryInfo> directories, String searchPattern, SearchOption searchOption, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** LoadFilesAsync
* **Modified By:** David McCarter

### ReadOnlyCollection<OneDriveFolder> LoadOneDriveFolders()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** LoadOneDriveFolders
* **Modified By:** David McCarter

### Void MoveDirectory(DirectoryInfo source, DirectoryInfo destination, Int32 retries)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** MoveDirectory
* **Modified By:** David McCarter

### Boolean SafeDirectorySearch(DirectoryInfo path, SearchOption searchOption, String[] searchPatterns)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/14/2021
* **Description:** SafeDirectorySearch
* **Documentation:** https://bit.ly/SpargineSep2022
* **Modified By:** David McCarter

### IEnumerable<DirectoryInfo> SafeDirectorySearch(DirectoryInfo path, String searchPattern, SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeDirectorySearch
* **Modified By:** David McCarter

### ReadOnlyCollection<FileInfo> SafeFileSearch(DirectoryInfo path, String searchPattern, SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeFileSearch
* **Documentation:** http://bit.ly/SpargineMarch2021
* **Modified By:** David McCarter

### IEnumerable<FileInfo> SafeFileSearch(IEnumerable<DirectoryInfo> directories, String searchPattern, SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SafeFileSearch
* **Modified By:** David McCarter

### Void SetFileAttributesToNormal(DirectoryInfo path)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/14/2018
* **Description:** SetFileAttributesToNormal
* **Modified By:** David McCarter

*****
## DriveHelper

### String GetDriveSerialNumber(String drive)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetDriveSerialNumber
* **Documentation:** https://dotnettips.wordpress.com/2007/12/14/finding-a-drives-serial-number/
* **Modified By:** David McCarter

### ReadOnlyCollection<DriveInfo> GetFixedDrives()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetFixedDrives
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### ReadOnlyCollection<DriveInfo> GetRemovableDrives()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/6/2020
* **Description:** GetRemovableDrives
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

*****
## FileHelper

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** FileHelper

### Boolean CheckPermission(FileInfo file, FileSystemRights permission)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2020
* **Description:** CheckPermission
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Int64 CopyFile(FileInfo file, DirectoryInfo destination)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CopyFile
* **Documentation:** https://bit.ly/SpargineJun2021

### Boolean CopyFile(FileInfo file, DirectoryInfo destination, CopyProgressRoutine progressCallback)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CopyFile
* **Documentation:** https://bit.ly/SpargineMay2024

### Task<Int64> CopyFileAsync(FileInfo file, DirectoryInfo destination, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** CopyFileAsync
* **Documentation:** https://dotnettips.wordpress.com/2020/11/17/coding-faster-with-the-dotnettips-utility-november-2020-update

### SimpleResult<ReadOnlyCollection<String>> DeleteFiles(ReadOnlyCollection<String> files, Boolean stopOnFirstError)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** DeleteFiles
* **Documentation:** https://bit.ly/SpargineMay2024

### Task DownloadFileFromWebAndUnzipAsync(Uri remoteUri, DirectoryInfo destination, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** DownloadFileFromWebAndUnzipAsync
* **Documentation:** https://bit.ly/SpargineJun2021

### Task DownloadFileFromWebAsync(Uri remoteUri, DirectoryInfo destination, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** DownloadFileFromWebAsync
* **Documentation:** https://bit.ly/SpargineJun2021

### Boolean FileHasInvalidChars(FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** FileHasInvalidChars
* **Documentation:** https://bit.ly/SpargineMay2022Data
* **Modified By:** David McCarter

### ReadOnlyCollection<Char> InvalidFileNameChars { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean MoveFile(FileInfo file, FileInfo destinationFile, FileMoveOptions fileMoveOptions, Int32 retryCount)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** MoveFile
* **Documentation:** https://bit.ly/SpargineMay2024

### Task UnGZipAsync(FileInfo file, DirectoryInfo destination, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** UnGZipAsync

### Task UnGZipAsync(FileInfo file, DirectoryInfo destination, Boolean deleteGZipFile, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** UnGZipAsync

### Task UnWinZipAsync(String zipPath, String expandedDirectoryPath, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** UnWinZipAsync

### Task UnZipAsync(FileInfo file, DirectoryInfo destination, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** UnZipAsync

### Task UnZipAsync(FileInfo file, DirectoryInfo destination, Boolean deleteZipFile, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** UnZipAsync

*****
## FileProcessor

### Int32 CopyFiles(IEnumerable<FileInfo> files, DirectoryInfo destination)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** CopyFiles
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### Int32 DeleteFiles(IEnumerable<FileInfo> files)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** DeleteFiles
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### Int32 DeleteFolders(IEnumerable<DirectoryInfo> folders)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 8/6/2017
* **Description:** DeleteFolders
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

*****
## PathHelper

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** PathHelper

### DirectoryInfo CombinePaths(Boolean createIfNotExists, String[] paths)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Documentation:** https://bit.ly/SparginePathHelper
* **Modified By:** David McCarter

### DirectoryInfo CombinePaths(Boolean createIfNotExists, String path1, String path2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Documentation:** https://bit.ly/SparginePathHelper
* **Modified By:** David McCarter

### DirectoryInfo CombinePaths(Boolean createIfNotExists, String path1, String path2, String path3)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Documentation:** https://bit.ly/SparginePathHelper
* **Modified By:** David McCarter

### DirectoryInfo CombinePaths(Boolean createIfNotExists, String path1, String path2, String path3, String path4)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/10/2020
* **Description:** CombinePaths
* **Documentation:** https://bit.ly/SparginePathHelper
* **Modified By:** David McCarter

### String EnsureTrailingSlash(String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Documentation:** https://bit.ly/SparginePathHelper
* **Modified By:** David McCarter

### Boolean HasInvalidFilterChars(String filter)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Documentation:** https://bit.ly/SparginePathHelper
* **Modified By:** David McCarter

### ReadOnlyCollection<Char> InvalidFilterChars()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### ReadOnlyCollection<Char> InvalidPathNameChars()

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean PathContainsWildcard(String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** PathContainsWildcard
* **Documentation:** https://bit.ly/SparginePathHelper
* **Modified By:** David McCarter

### Boolean PathHasInvalidChars(String path)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Documentation:** https://bit.ly/SparginePathHelper
* **Modified By:** David McCarter

### ReadOnlyCollection<Char> PathSeparators { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

*****
## TempFileManager

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 8/4/2024
* **Description:** TempFileManager
* **Modified By:** David McCarter

### String CreateFile()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Creates a new temporary file.

### ReadOnlyCollection<String> CreateFiles(Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Creates multiple temp files.

### Void DeleteAllFiles()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Deletes all temporary files.

### Void Dispose()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** NotRequired
* **Author:** UNKNOWN
* **Description:** Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

### IReadOnlyCollection<String> GetManagedFiles()

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Gets the list of files currently being managed.

### ValueTask System.IAsyncDisposable.DisposeAsync()

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** DisposeAsync

*****
## RegistryExtensions

### RegistryKey GetSubKey(RegistryKey key, String name)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** GetSubKey
* **Modified By:** David McCarter

### T GetValue(RegistryKey key, String name)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/1/2021
* **Description:** GetValue
* **Modified By:** David McCarter

*****
**Generated by Spargine - dotNetTips.com on 1/30/2025 7:56:22 PM UTC**
