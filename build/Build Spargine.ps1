﻿dotnet clean D:\src\GitHub\dotNetTips.Spargine.8\source\dotNetTips.Spargine.8.sln

dotnet build D:\src\GitHub\dotNetTips.Spargine.8\source\dotNetTips.Spargine.8.sln --configuration Release

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.8\source\dotNetTips.Spargine.8.Extensions\dotNetTips.Spargine.8.Extensions.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.8\source\dotNetTips.Spargine.8.Core\dotNetTips.Spargine.8.Core.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.8\source\dotNetTips.Spargine.8\DotNetTips.Spargine.8.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine.8\source\dotNetTips.Spargine.8.Tester\dotNetTips.Spargine.8.Tester.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"